#!/usr/bin/env node
"use strict";

// Fresh CCG validation lane. This deliberately consumes only the canonical card
// roster, current Lua files, current database, and the checked-in Omega corpus.
// It does not read or trust any previous audit ledger or report.

const fs = require("node:fs");
const path = require("node:path");
const crypto = require("node:crypto");
const { DatabaseSync } = require("node:sqlite");
const luaparse = require("luaparse");

const ROOT = path.resolve(__dirname, "..");
const CARDS = path.join(ROOT, "src", "data", "cards.json");
const SCRIPTS = path.join(ROOT, "public", "CCG Downloads", "CCG_Scripts");
const DATABASE = path.join(ROOT, "public", "CCG Downloads", "CCG_Database", "CCG_v1.db");
const OMEGA = path.join(ROOT, "tmp", "omega_scripts");
const DEFAULT_JSON = path.join(ROOT, "scripts", "output", "fresh_ccg_effect_contracts.json");
const DEFAULT_MD = path.join(ROOT, "docs", "fresh-ccg-effect-contracts.md");

function arg(name, fallback) {
  const at = process.argv.indexOf(name);
  return at >= 0 && at + 1 < process.argv.length ? path.resolve(process.argv[at + 1]) : fallback;
}

function sha256(value) {
  return crypto.createHash("sha256").update(value).digest("hex");
}

function luaFiles(directory) {
  const result = [];
  const pending = [directory];
  while (pending.length) {
    const current = pending.pop();
    for (const entry of fs.readdirSync(current, { withFileTypes: true })) {
      const full = path.join(current, entry.name);
      if (entry.isDirectory()) pending.push(full);
      else if (entry.name.endsWith(".lua")) result.push(full);
    }
  }
  return result.sort();
}

function matchesAny(source, expressions) {
  return expressions.some((expression) => expression.test(source));
}

// Each rule turns an unambiguous printed action/restriction into the Omega Lua
// primitives that can implement it. These are evidence contracts, not naive
// one-effect-per-sentence counts; one registered effect may satisfy many clauses.
const CONTRACTS = [
  ["special_summon", /special summon/i, [/Duel\.SpecialSummon/, /EFFECT_SPSUMMON_PROC/, /EFFECT_SPSUMMON_CONDITION/, /EFFECT_CANNOT_SPECIAL_SUMMON/, /Add.*Procedure/, /SpecialSummonStep/, /EVENT_SPSUMMON_SUCCESS/, /SUMMON_TYPE_SPECIAL/, /CATEGORY_SPECIAL_SUMMON/]],
  ["normal_summon", /normal summon/i, [/Duel\.Summon/, /IsSummonable/, /EFFECT_EXTRA_(?:SUMMON|RELEASE)/, /EFFECT_SUMMON_PROC/, /EFFECT_CANNOT_SUMMON/, /EVENT_SUMMON_SUCCESS/, /SUMMON_TYPE_(?:NORMAL|ADVANCE|TRIBUTE)/, /CATEGORY_SUMMON/]],
  ["fusion_summon", /fusion summon/i, [/Fusion\./, /AddFusionProc/, /Duel\.FusionSummon/, /SUMMON_TYPE_FUSION/, /TYPE_FUSION/]],
  ["synchro_summon", /synchro summon/i, [/Synchro\./, /AddSynchroProcedure/, /Duel\.SynchroSummon/, /SUMMON_TYPE_SYNCHRO/, /TYPE_SYNCHRO/, /REASON_SYNCHRO/, /EFFECT_SYNCHRO_LEVEL/]],
  ["xyz_summon", /xyz summon/i, [/Xyz\./, /AddXyzProcedure/, /XyzLevelFree/, /Duel\.XyzSummon/, /SUMMON_TYPE_XYZ/, /TYPE_XYZ/, /REASON_XYZ/, /EFFECT_XYZ_LEVEL/]],
  ["link_summon", /link summon/i, [/Link\./, /AddLinkProcedure/, /Duel\.LinkSummon/, /SUMMON_TYPE_LINK/, /TYPE_LINK/, /REASON_LINK/, /EFFECT_CANNOT_BE_LINK_MATERIAL/]],
  ["ritual_summon", /ritual summon/i, [/Ritual\./, /AddRitualProc/, /Duel\.RitualSummon/, /SUMMON_TYPE_RITUAL/, /TYPE_RITUAL/, /REASON_RITUAL/, /EFFECT_RITUAL_LEVEL/]],
  ["pendulum", /pendulum (?:summon|zone|scale)/i, [/Pendulum\./, /LOCATION_PZONE/, /TYPE_PENDULUM/, /EFFECT_CHANGE_LSCALE/, /EFFECT_CHANGE_RSCALE/]],
  ["draw", /\bdraw(?!\s+phase)\b/i, [/Duel\.Draw/, /EFFECT_DRAW_COUNT/, /CATEGORY_DRAW/]],
  ["destroy", /\bdestroy/i, [/Duel\.Destroy/, /EFFECT_DESTROY_REPLACE/, /EFFECT_DESTROY_SUBSTITUTE/, /EFFECT_INDESTRUCTABLE/, /EVENT_DESTROYED/, /EVENT_BATTLE_DESTROYING/, /EVENT_BATTLE_DESTROYED/, /REASON_DESTROY/, /REASON_BATTLE/, /REASON_LOST_TARGET/, /CATEGORY_DESTROY/]],
  ["banish", /\bbanish/i, [/Duel\.Remove/, /EFFECT_(?:CANNOT_)?REMOVE/, /LOCATION_REMOVED/, /EVENT_REMOVE/, /IsAbleToRemove/, /bfgcost/]],
  ["send_to_gy", /send .+ to the gy|send it to the gy/i, [/Duel\.SendtoGrave/, /LOCATION_GRAVE/]],
  ["send_to_deck", /shuffle .+ (?:deck|extra deck)|place .+ (?:bottom|top) of the deck/i, [/Duel\.SendtoDeck/, /Duel\.MoveSequence/, /Duel\.ShuffleDeck/, /EVENT_TO_DECK/, /CATEGORY_TODECK/, /EFFECT_LEAVE_FIELD_REDIRECT/, /LOCATION_DECK(?:SHF|BOT|TOP)/]],
  ["add_to_hand", /add .+ (?:deck|gy|graveyard|banish).+ to (?:your|the) hand/i, [/Duel\.SendtoHand/, /CATEGORY_TOHAND/]],
  ["discard", /\bdiscard/i, [/REASON_DISCARD/, /Duel\.DiscardHand/]],
  ["tribute", /\btribute/i, [/Duel\.Release/, /REASON_(?:RELEASE|RITUAL)/, /EFFECT_(?:EXTRA_RELEASE|ADD_EXTRA_TRIBUTE|UNRELEASABLE|RITUAL_LEVEL|TRIBUTE)/, /EVENT_RELEASE/, /SUMMON_TYPE_ADVANCE/]],
  ["target", /\btarget\b/i, [/SetTarget\s*\(/, /Duel\.SelectTarget/, /Duel\.SetTargetCard/, /EFFECT_FLAG_CARD_TARGET/]],
  ["negate", /\bnegate/i, [/Duel\.Negate(?:Activation|Effect|Summon|Attack)/, /EFFECT_DISABLE/, /EFFECT_CANNOT_(?:ACTIVATE|INACTIVATE|DISABLE)/, /EFFECT_CANNOT_DISEFFECT/, /CATEGORY_NEGATE/, /IsDisabled/]],
  ["damage", /\b(?:inflict|take) .+ damage|effect damage/i, [/Duel\.(?:Damage|ChangeBattleDamage)/, /EFFECT_(?:CHANGE|REVERSE)_DAMAGE/, /EFFECT_NO_EFFECT_DAMAGE/, /EFFECT_AVOID_BATTLE_DAMAGE/, /EFFECT_PIERCE/, /EVENT_(?:BATTLE_DAMAGE|DAMAGE|PRE_BATTLE_DAMAGE)/, /CATEGORY_DAMAGE/]],
  ["gain_lp", /gain \d+ lp|gain lp/i, [/Duel\.Recover/]],
  ["pay_lp", /pay .+ lp/i, [/Duel\.PayLPCost/, /Duel\.CheckLPCost/, /EVENT_PAY_LPCOST/]],
  ["attack_change", /(?:gains?|loses?|becomes?|double|halve)[^.;]*\batk\b|\batk\b becomes/i, [/EFFECT_(?:UPDATE|SET|CHANGE|DOUBLE)_ATTACK/, /GetAttack/]],
  ["defense_change", /(?:gains?|loses?|becomes?|double|halve)[^.;]*\bdef\b|\bdef\b becomes/i, [/EFFECT_(?:UPDATE|SET|CHANGE)_DEFENSE/, /GetDefense/]],
  ["position", /change .+ (?:battle position|face-up attack|face-up defense|face-down defense)|change (?:it|that card) to face-/i, [/Duel\.ChangePosition/, /EFFECT_SET_POSITION/, /POS_FACE/]],
  ["equip", /\bequip/i, [/Duel\.Equip/, /EFFECT_EQUIP_LIMIT/, /LOCATION_SZONE/]],
  ["attach_material", /attach .+ material|xyz material/i, [/Duel\.Overlay/, /GetOverlayGroup/, /CheckRemoveOverlayCard/, /RemoveOverlayCard/]],
  ["counter", /(?:place|put|remove) .+ counter|counter(?:s)? on (?:this|that|a|each)/i, [/AddCounter/, /RemoveCounter/, /GetCounter/, /EnableCounterPermit/]],
  ["once_per_turn", /once per turn|only use .+ per turn|only activate .+ per turn/i, [/SetCountLimit\s*\(/, /RegisterFlagEffect\s*\(/, /EFFECT_CANNOT_SPECIAL_SUMMON/]],
  ["quick_effect", /quick effect/i, [/EFFECT_TYPE_QUICK_[OF]/]],
  ["cannot_attack", /cannot attack|cannot declare an attack/i, [/EFFECT_CANNOT_ATTACK/, /EFFECT_CANNOT_ATTACK_ANNOUNCE/, /EFFECT_CANNOT_DIRECT_ATTACK/, /EFFECT_CANNOT_SELECT_BATTLE_TARGET/, /EFFECT_ATTACK_DISABLED/]],
  ["attack_restriction", /cannot target .+ for attacks|only attack/i, [/EFFECT_CANNOT_SELECT_BATTLE_TARGET/, /EFFECT_CANNOT_BE_BATTLE_TARGET/, /EFFECT_IGNORE_BATTLE_TARGET/, /EFFECT_CANNOT_DIRECT_ATTACK/, /EFFECT_CANNOT_ATTACK_ANNOUNCE/, /EFFECT_MUST_ATTACK/]],
  ["material_restriction", /cannot be used as .+ material|cannot use .+ as .+ material/i, [/EFFECT_CANNOT_BE_(?:FUSION|SYNCHRO|XYZ|LINK)_MATERIAL/, /EFFECT_CANNOT_BE_MATERIAL/]],
  ["effect_immunity", /unaffected by|immune to/i, [/EFFECT_IMMUNE_EFFECT/]],
  ["protection", /cannot be destroyed|cannot be targeted (?:by|with)|cannot target .+ with card effects/i, [/EFFECT_INDESTRUCTABLE/, /EFFECT_CANNOT_BE_EFFECT_TARGET/, /EFFECT_DESTROY_SUBSTITUTE/]],
  ["control", /take control|control of/i, [/Duel\.GetControl/, /Duel\.SwapControl/, /EFFECT_SET_CONTROL/]],
  ["set_card", /\bset (?:1|this|that|it|them|up to)/i, [/Duel\.SSet/, /Duel\.MSet/, /Duel\.MoveToField/, /EFFECT_EXTRA_(?:SET|SUMMON)_COUNT/, /POS_FACEDOWN/, /CATEGORY_LEAVE_GRAVE/]],
  ["return_to_hand", /return .+ to the hand/i, [/Duel\.SendtoHand/, /EFFECT_LEAVE_FIELD_REDIRECT[^\n]+LOCATION_HAND/, /EnableSpiritReturn/]],
  ["return_to_deck", /return .+ to the (?:deck|extra deck)/i, [/Duel\.SendtoDeck/, /EFFECT_LEAVE_FIELD_REDIRECT/, /LOCATION_DECK(?:SHF|BOT|TOP)/]],
];

function omegaVocabulary(files) {
  const calls = new Set();
  const constants = new Set();
  for (const file of files) {
    const source = fs.readFileSync(file, "utf8");
    for (const match of source.matchAll(/\b(Duel|Effect|Card|Group|aux|Auxiliary|Fusion|Synchro|Xyz|Link|Ritual|Pendulum)\s*([.:])\s*([A-Za-z_]\w*)\s*\(/g)) {
      const namespace = match[1] === "Auxiliary" ? "aux" : match[1];
      calls.add(`${namespace}${match[2]}${match[3]}`);
    }
    for (const match of source.matchAll(/\b(?:EFFECT|EVENT|CATEGORY|LOCATION|TYPE|ATTRIBUTE|RACE|REASON|SUMMON_TYPE|POS|PHASE|CHAININFO|PLAYER|RESET|STATUS|HINT|TIMING|ACTIVITY|COUNTER|WIN_REASON)_[A-Z0-9_]+\b/g)) {
      constants.add(match[0]);
    }
  }
  return { calls, constants };
}

function collectScriptFacts(source) {
  const ast = luaparse.parse(source, { luaVersion: "5.3", locations: true });
  const definitions = new Set();
  const referencedCallbacks = new Set();
  let initialEffect = false;
  for (const node of ast.body) {
    if (node.type !== "FunctionDeclaration" || node.identifier?.type !== "MemberExpression") continue;
    if (node.identifier.base?.name !== "s") continue;
    const name = node.identifier.identifier?.name;
    if (name) definitions.add(name);
    if (name === "initial_effect") initialEffect = true;
  }
  for (const match of source.matchAll(/:Set(?:Condition|Cost|Target|Operation|Value)\s*\(\s*s\.([A-Za-z_]\w*)/g)) {
    referencedCallbacks.add(match[1]);
  }
  const created = [...source.matchAll(/\bEffect\.(?:CreateEffect|GlobalEffect)\s*\(/g)].length;
  const cloned = [...source.matchAll(/:\s*Clone\s*\(/g)].length;
  const registered = [...source.matchAll(/(?::RegisterEffect|Duel\.RegisterEffect)\s*\(/g)].length;
  return { ast, definitions, referencedCallbacks, initialEffect, created, cloned, registered };
}

function textContracts(text, source, card, customEffectConsumers) {
  const found = [];
  // Quoted effect text after "mentions" is search metadata, not an effect the
  // current card performs (for example Stain cards quoting their Deck clause).
  const contractText = text.replace(/mentions?\s+["“][^"”]+["”]/gi, "mentions a listed clause");
  const cardTypes = new Set(card.cardTypes || []);
  for (const [name, trigger, evidence] of CONTRACTS) {
    if (!trigger.test(contractText)) continue;
    if (name === "target" && /target[^.]{0,60}for attacks/i.test(contractText)) continue;
    if ((name === "attack_change" || name === "defense_change") && /lose(?:s)? lp[^.;]*(?:atk|def)/i.test(contractText)) continue;
    const metadataSatisfied =
      (name === "ritual_summon" && cardTypes.has("Ritual")) ||
      (name === "fusion_summon" && cardTypes.has("Fusion")) ||
      (name === "synchro_summon" && cardTypes.has("Synchro")) ||
      (name === "xyz_summon" && cardTypes.has("Xyz")) ||
      (name === "link_summon" && cardTypes.has("Link")) ||
      (name === "normal_summon" && cardTypes.has("Special Summon")) ||
      (customEffectConsumers.has(Number(card.passcode)) && (name === "banish" || name === "tribute"));
    found.push({ name, satisfied: metadataSatisfied || matchesAny(source, evidence), evidence: evidence.map(String) });
  }
  return found;
}

function markdown(report) {
  const s = report.summary;
  const lines = [
    "# Fresh CCG effect-contract validation",
    "",
    `Generated: ${report.generated_at}`,
    "",
    "This is an independent pass over the current roster, database, Lua scripts, and Omega script corpus. It does not consume previous audit reports or verdicts.",
    "",
    "## Summary",
    "",
    `- Cards: ${s.cards}`,
    `- Lua scripts parsed: ${s.scripts_parsed}`,
    `- Registered effects observed: ${s.registered_effects}`,
    `- Printed semantic contracts: ${s.contracts_total}`,
    `- Contracts with implementation evidence: ${s.contracts_satisfied}`,
    `- Structural/API failures: ${s.cards_failed}`,
    `- Unsatisfied semantic contracts: ${s.contracts_unsatisfied}`,
    "",
    "## Findings",
    "",
  ];
  const findings = report.cards.filter((card) => card.errors.length || card.unsatisfied_contracts.length);
  if (!findings.length) lines.push("No structural, API, callback, or semantic-contract discrepancies were found.", "");
  for (const card of findings) {
    lines.push(`### ${card.card_id} — ${card.card_name}`, "");
    for (const error of card.errors) lines.push(`- ERROR: ${error}`);
    for (const contract of card.unsatisfied_contracts) lines.push(`- REVIEW: printed ${contract} contract has no matching Omega primitive`);
    lines.push("");
  }
  lines.push("## Per-card coverage", "", "| ID | Card | Effects | Contracts | Result |", "|---:|---|---:|---:|---|");
  for (const card of report.cards) {
    const result = card.errors.length ? "FAIL" : card.unsatisfied_contracts.length ? "REVIEW" : "PASS";
    lines.push(`| ${card.card_id} | ${card.card_name.replaceAll("|", "\\|")} | ${card.registered_effects} | ${card.contracts_satisfied}/${card.contracts_total} | ${result} |`);
  }
  return `${lines.join("\n")}\n`;
}

function main() {
  const jsonPath = arg("--json", DEFAULT_JSON);
  const markdownPath = arg("--markdown", DEFAULT_MD);
  const cards = JSON.parse(fs.readFileSync(CARDS, "utf8"));
  const officialFiles = luaFiles(OMEGA);
  const vocabulary = omegaVocabulary(officialFiles);
  const customEffectConsumers = new Set();
  for (const file of fs.readdirSync(SCRIPTS).filter((name) => /^c\d+\.lua$/.test(name))) {
    const source = fs.readFileSync(path.join(SCRIPTS, file), "utf8");
    const constants = new Map([...source.matchAll(/\b(?:local\s+)?([A-Z][A-Z0-9_]*)\s*=\s*(\d+)/g)].map((match) => [match[1], Number(match[2])]));
    for (const [name, code] of constants) {
      if (new RegExp(`IsHasEffect\\s*\\(\\s*${name}\\b`).test(source)) customEffectConsumers.add(code);
    }
  }
  const db = new DatabaseSync(DATABASE, { readOnly: true });
  const dbIds = new Set(db.prepare("select id from datas").all().map((row) => Number(row.id)));
  db.close();
  const results = [];

  for (const card of cards) {
    const code = Number(card.passcode);
    const scriptPath = path.join(SCRIPTS, `c${code}.lua`);
    const errors = [];
    if (!dbIds.has(code)) errors.push("card is absent from the canonical Omega database");
    if (!fs.existsSync(scriptPath)) {
      results.push({ card_id: code, card_name: card.name, errors: ["Lua script is missing"], registered_effects: 0, contracts_total: 0, contracts_satisfied: 0, unsatisfied_contracts: [] });
      continue;
    }
    const source = fs.readFileSync(scriptPath, "utf8");
    let facts;
    try {
      facts = collectScriptFacts(source);
    } catch (error) {
      results.push({ card_id: code, card_name: card.name, script_sha256: sha256(source), errors: [`Lua parse failure: ${error.message}`], registered_effects: 0, contracts_total: 0, contracts_satisfied: 0, unsatisfied_contracts: [] });
      continue;
    }
    if (!facts.initialEffect) errors.push("s.initial_effect is not defined");
    if (facts.created > 0 && facts.registered === 0) errors.push(`${facts.created} effects created but none registered`);
    for (const callback of facts.referencedCallbacks) {
      if (!facts.definitions.has(callback)) errors.push(`registered callback s.${callback} is not defined`);
    }

    const localConstants = new Set([...source.matchAll(/^\s*(?:local\s+)?([A-Z][A-Z0-9_]*)\s*=/gm)].map((m) => m[1]));
    for (const match of source.matchAll(/\b(Duel|Effect|Card|Group|aux|Fusion|Synchro|Xyz|Link|Ritual|Pendulum)\s*([.:])\s*([A-Za-z_]\w*)\s*\(/g)) {
      const call = `${match[1]}${match[2]}${match[3]}`;
      if (!vocabulary.calls.has(call)) errors.push(`API call ${call} is not present in the Omega corpus`);
    }
    const unknownConstants = new Set();
    for (const match of source.matchAll(/\b(?:EFFECT|EVENT|CATEGORY|LOCATION|TYPE|ATTRIBUTE|RACE|REASON|SUMMON_TYPE|POS|PHASE|CHAININFO|PLAYER|RESET|STATUS|HINT|TIMING|ACTIVITY|COUNTER|WIN_REASON)_[A-Z0-9_]+\b/g)) {
      if (!vocabulary.constants.has(match[0]) && !localConstants.has(match[0])) unknownConstants.add(match[0]);
    }
    if (unknownConstants.size) errors.push(`unknown Omega constants: ${[...unknownConstants].sort().join(", ")}`);

    const contracts = textContracts(card.text || "", source, card, customEffectConsumers);
    const unsatisfied = contracts.filter((contract) => !contract.satisfied).map((contract) => contract.name);
    results.push({
      card_id: code,
      card_name: card.name,
      script: path.relative(ROOT, scriptPath).replaceAll("\\", "/"),
      script_sha256: sha256(source),
      created_effects: facts.created,
      cloned_effects: facts.cloned,
      registered_effects: facts.registered,
      callbacks_defined: facts.definitions.size - 1,
      contracts_total: contracts.length,
      contracts_satisfied: contracts.length - unsatisfied.length,
      unsatisfied_contracts: unsatisfied,
      errors: [...new Set(errors)],
    });
  }

  const summary = {
    cards: cards.length,
    scripts_parsed: results.filter((card) => !card.errors.some((error) => error.startsWith("Lua parse"))).length,
    registered_effects: results.reduce((sum, card) => sum + card.registered_effects, 0),
    contracts_total: results.reduce((sum, card) => sum + card.contracts_total, 0),
    contracts_satisfied: results.reduce((sum, card) => sum + card.contracts_satisfied, 0),
    contracts_unsatisfied: results.reduce((sum, card) => sum + card.unsatisfied_contracts.length, 0),
    cards_failed: results.filter((card) => card.errors.length).length,
    cards_needing_review: results.filter((card) => card.unsatisfied_contracts.length).length,
    omega_scripts_indexed: officialFiles.length,
    omega_api_calls_indexed: vocabulary.calls.size,
  };
  const report = { schema_version: 1, methodology: "independent_text_to_lua_contract_and_omega_corpus_validation", generated_at: new Date().toISOString(), inputs: { cards: path.relative(ROOT, CARDS), database: path.relative(ROOT, DATABASE), scripts: path.relative(ROOT, SCRIPTS), omega_corpus: path.relative(ROOT, OMEGA) }, summary, cards: results };
  fs.mkdirSync(path.dirname(jsonPath), { recursive: true });
  fs.mkdirSync(path.dirname(markdownPath), { recursive: true });
  fs.writeFileSync(jsonPath, `${JSON.stringify(report, null, 2)}\n`);
  fs.writeFileSync(markdownPath, markdown(report));
  console.log(JSON.stringify(summary, null, 2));
  console.log(`json=${jsonPath}`);
  console.log(`markdown=${markdownPath}`);
  return summary.cards_failed || summary.contracts_unsatisfied ? 1 : 0;
}

process.exitCode = main();
