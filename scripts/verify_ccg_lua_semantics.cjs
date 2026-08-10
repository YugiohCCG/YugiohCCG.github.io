#!/usr/bin/env node
/* Audit every CCG Lua script for callback-role and search-condition defects. */

const fs = require("fs");
const path = require("path");
const luaparse = require("luaparse");

const root = path.resolve(__dirname, "..");
const cardsPath = path.join(root, "src", "data", "cards.json");
const scriptsDir = path.join(root, "public", "CCG Downloads", "CCG_Scripts");
const defaultOutput = path.join(root, "scripts", "output", "ccg_lua_semantic_audit.json");
const reviewedPath = path.join(root, "scripts", "ccg_qa_reviewed_findings.json");
const outputArg = process.argv.indexOf("--output");
const outputPath = outputArg >= 0 ? path.resolve(process.argv[outputArg + 1]) : defaultOutput;
const strictReview = process.argv.includes("--strict-review");

const cards = JSON.parse(fs.readFileSync(cardsPath, "utf8"));
const byId = new Map(cards.map((card, index) => [Number(card.passcode), { ...card, ordinal: index + 1 }]));
const scriptPaths = fs.readdirSync(scriptsDir)
  .filter((name) => /^c\d+\.lua$/.test(name))
  .sort((a, b) => Number(a.slice(1, -4)) - Number(b.slice(1, -4)));

const roleMethods = new Map([
  ["SetCondition", "condition"],
  ["SetCost", "cost"],
  ["SetTarget", "target"],
  ["SetOperation", "operation"],
  ["SetValue", "value"],
]);
const mutatingCalls = new Set([
  "Duel.PayLPCost", "Duel.DiscardHand", "Duel.Release", "Duel.Remove",
  "Duel.SendtoGrave", "Duel.SendtoHand", "Duel.SendtoDeck", "Duel.Destroy",
  "Duel.SpecialSummon", "Duel.Draw", "Duel.Damage", "Duel.Recover", "Duel.Overlay",
  "Duel.MoveToField", "Duel.SSet", "Duel.Summon", "Duel.MSet", "Duel.FusionSummon",
  "Duel.SynchroSummon", "Duel.XyzSummon", "Duel.LinkSummon", "Duel.ShuffleDeck",
]);
const selectionNames = new Set([
  "Duel.SelectMatchingCard", "Duel.SelectTarget",
]);
const checkerFor = new Map([
  ["Duel.SelectMatchingCard", "Duel.IsExistingMatchingCard"],
  ["Duel.GetMatchingGroup", "Duel.IsExistingMatchingCard"],
  ["Duel.SelectTarget", "Duel.IsExistingTarget"],
]);

function memberName(node) {
  if (!node) return null;
  if (node.type === "Identifier") return node.name;
  if (node.type === "StringLiteral" || node.type === "NumericLiteral") return String(node.value);
  if (node.type === "MemberExpression" || node.type === "IndexExpression") {
    const base = memberName(node.base);
    const key = memberName(node.identifier || node.index);
    return base && key ? `${base}.${key}` : null;
  }
  return null;
}

function walk(node, visit, parent = null) {
  if (!node || typeof node !== "object") return;
  visit(node, parent);
  for (const [key, value] of Object.entries(node)) {
    if (key === "loc" || key === "range") continue;
    if (Array.isArray(value)) {
      for (const child of value) walk(child, visit, node);
    } else if (value && typeof value === "object") {
      walk(value, visit, node);
    }
  }
}

function normalizeExpression(value) {
  return value
    .replace(/\s+/g, "")
    .replace(/^\((.*)\)$/s, "$1")
    .replace(/Auxiliary\./g, "aux.");
}

function callDetails(node, source) {
  const name = memberName(node.base);
  if (!name) return null;
  return {
    name,
    line: node.loc?.start.line || null,
    args: (node.arguments || []).map((argument) =>
      normalizeExpression(source.slice(argument.range[0], argument.range[1]))
    ),
  };
}

function coreSearchSignature(call) {
  const offset = call.name === "Duel.SelectMatchingCard" || call.name === "Duel.SelectTarget" ? 1 : 0;
  return call.args.slice(offset, offset + 4).join("|");
}

function searchLocationSignature(call) {
  return coreSearchSignature(call).split("|").slice(1).join("|");
}

function finding(card, script, severity, kind, line, detail) {
  return {
    severity,
    kind,
    ordinal: card?.ordinal || null,
    card_id: card ? Number(card.passcode) : Number(script.slice(1, -4)),
    card_name: card?.name || "Compatibility script",
    script,
    line: line || null,
    detail,
  };
}

function actionCoverageFindings(card, script, source) {
  if (!card) return [];
  const text = String(card.text || "").toLowerCase();
  const rules = [
    {
      kind: "printed-draw-without-visible-implementation",
      text: /\bdraw\s+(?:\d+|one|two|three|a|up\s+to|cards?\b)/,
      source: /Duel\.Draw|EFFECT_DRAW_COUNT|CATEGORY_DRAW/,
    },
    {
      kind: "printed-damage-without-visible-implementation",
      text: /(?:\binflict\b[^.!?]{0,80}\bdamage\b|\btake no battle damage\b)/,
      source: /Duel\.Damage|EFFECT_CHANGE_DAMAGE|EFFECT_REFLECT_DAMAGE|EFFECT_NO_EFFECT_DAMAGE|EFFECT_AVOID_BATTLE_DAMAGE|EFFECT_PIERCE|EFFECT_DOUBLE_TRIBUTE|EFFECT_CHANGE_BATTLE_DAMAGE/,
    },
    {
      kind: "printed-add-to-hand-without-visible-implementation",
      text: /(?:^|[.;!?]\s*)(?:you can\s+)?add\b[^.;!?]{0,160}\bto (?:your|the) hand\b/,
      source: /Duel\.SendtoHand|CATEGORY_TOHAND/,
    },
  ];
  return rules
    .filter((rule) => rule.text.test(text) && !rule.source.test(source))
    .map((rule) => finding(card, script, "review", rule.kind, null,
      "Printed action has no recognized implementation pattern; review manually."));
}

const findings = [];
const ledgers = [];
let acceptedReplacementTargets = 0;

for (const script of scriptPaths) {
  const scriptPath = path.join(scriptsDir, script);
  const cardId = Number(script.slice(1, -4));
  const card = byId.get(cardId);
  const source = fs.readFileSync(scriptPath, "utf8");
  let ast;
  try {
    ast = luaparse.parse(source, {
      luaVersion: "5.3",
      ranges: true,
      locations: true,
      comments: false,
    });
  } catch (error) {
    findings.push(finding(card, script, "error", "parse-error", null, String(error)));
    ledgers.push({ card_id: cardId, script, parsed: false, effects: 0, callbacks: 0, searches: 0 });
    continue;
  }

  const roles = new Map();
  const functions = new Map();
  const effectRoutes = new Map();
  const allCalls = [];
  let effectCreations = 0;
  walk(ast, (node) => {
    if (node.type === "CallExpression" || node.type === "TableCallExpression" || node.type === "StringCallExpression") {
      const call = callDetails(node, source);
      if (!call) return;
      allCalls.push(call);
      if (call.name === "Effect.CreateEffect") effectCreations += 1;
      const method = call.name.split(".").at(-1);
      const role = roleMethods.get(method);
      if (role && node.arguments?.[0]) {
        const callbackName = memberName(node.arguments[0]);
        if (callbackName?.match(/^(?:s|c\d+)\./)) {
          if (!roles.has(callbackName)) roles.set(callbackName, new Set());
          roles.get(callbackName).add(role);
          const effectName = call.name.slice(0, -(method.length + 1));
          if (!effectRoutes.has(effectName)) effectRoutes.set(effectName, {});
          effectRoutes.get(effectName)[role] = callbackName;
        }
      }
    }
    if (node.type === "FunctionDeclaration" && node.identifier && node.range) {
      const name = memberName(node.identifier);
      if (name) functions.set(name, node);
    }
  });

  const callsByFunction = new Map();
  for (const [name, functionNode] of functions) {
    const calls = [];
    walk(functionNode, (node) => {
      if (node.type === "CallExpression") {
        const call = callDetails(node, source);
        if (call) calls.push(call);
      }
    });
    callsByFunction.set(name, calls);
  }

  for (const [name, functionNode] of functions) {
    const functionRoles = roles.get(name);
    if (!functionRoles) continue;
    const body = source.slice(functionNode.range[0], functionNode.range[1]);
    const calls = callsByFunction.get(name) || [];

    const mutations = calls.filter((call) => mutatingCalls.has(call.name));
    if (functionRoles.has("target") && mutations.length) {
      const replacementTarget = /REASON_REPLACE/.test(body) || /rep/i.test(name);
      if (replacementTarget) {
        acceptedReplacementTargets += 1;
      } else {
        findings.push(finding(card, script, "error", "target-mutates-state",
          functionNode.loc.start.line, `${name}: ${[...new Set(mutations.map((call) => call.name))].join(", ")}`));
      }
    }
    if (functionRoles.has("condition") && mutations.length) {
      findings.push(finding(card, script, "error", "condition-mutates-state",
        functionNode.loc.start.line, `${name}: ${[...new Set(mutations.map((call) => call.name))].join(", ")}`));
    }
    if (functionRoles.has("operation") && calls.some((call) => call.name === "Duel.SelectTarget")) {
      findings.push(finding(card, script, "error", "operation-selects-target",
        functionNode.loc.start.line, `${name} selects an activation target during resolution.`));
    }

    if ((functionRoles.has("cost") || functionRoles.has("target")) && /\bchk\b/.test(body)) {
      const checkCalls = calls.filter((call) =>
        call.name === "Duel.IsExistingMatchingCard" || call.name === "Duel.IsExistingTarget");
      const selectCalls = calls.filter((call) => selectionNames.has(call.name));
      for (const select of selectCalls) {
        const expectedChecker = checkerFor.get(select.name);
        const familyChecks = checkCalls.filter((call) => call.name === expectedChecker);
        if (!familyChecks.length) continue;
        const familySelections = selectCalls.filter((call) => checkerFor.get(call.name) === expectedChecker);
        // Multi-step and option-dependent targeting deliberately uses more than
        // one predicate. Those routes are recorded for manual scenario tests,
        // while a single guard/single selection mismatch is deterministic.
        if (familyChecks.length !== 1 || familySelections.length !== 1) continue;
        const expected = coreSearchSignature(select);
        if (!familyChecks.some((call) => coreSearchSignature(call) === expected)) {
          findings.push(finding(card, script, "error", "search-check-selection-mismatch",
            select.line, `${name}: ${select.name}(${expected}) differs from its ${expectedChecker} guard.`));
        }
      }
    }

    if (functionRoles.has("operation")) {
      const getsFirstTarget = calls.some((call) => call.name === "Duel.GetFirstTarget");
      const relationHelpers = [...functions.entries()]
        .filter(([, node]) => /IsRelateToEffect/.test(source.slice(node.range[0], node.range[1])))
        .map(([helper]) => helper.split(".").at(-1));
      const usesRelationHelper = relationHelpers.some((helper) =>
        new RegExp(`\\b${helper.replace(/[.*+?^${}()|[\\]\\]/g, "\\$&")}\\b`).test(body));
      if (getsFirstTarget && !/IsRelateToEffect/.test(body) && !usesRelationHelper) {
        findings.push(finding(card, script, "review", "target-resolution-without-visible-relation-check",
          functionNode.loc.start.line, `${name} gets the first target without a visible relation check.`));
      }
      if (/CHAININFO_TARGET_CARDS/.test(body) && !/IsRelateToEffect/.test(body) && !usesRelationHelper) {
        findings.push(finding(card, script, "review", "target-group-without-visible-relation-filter",
          functionNode.loc.start.line, `${name} resolves a target group without a visible relation filter.`));
      }
    }
  }

  // Compare a target callback's activation-time search with the corresponding
  // operation callback's resolution-time selection. A mismatch here commonly
  // produces an activatable effect that cannot resolve as advertised.
  for (const [effectName, route] of effectRoutes) {
    if (!route.target || !route.operation) continue;
    const targetCalls = callsByFunction.get(route.target) || [];
    const operationCalls = callsByFunction.get(route.operation) || [];
    const checks = targetCalls.filter((call) => call.name === "Duel.IsExistingMatchingCard");
    const selections = operationCalls.filter((call) =>
      call.name === "Duel.SelectMatchingCard" || call.name === "Duel.GetMatchingGroup");
    if (!checks.length || !selections.length) continue;
    for (const select of selections) {
      const signature = coreSearchSignature(select);
      if (!checks.some((check) => coreSearchSignature(check) === signature)) {
        if (!checks.some((check) => searchLocationSignature(check) === searchLocationSignature(select))) {
          continue;
        }
        findings.push(finding(card, script, "review", "target-operation-search-mismatch",
          select.line, `${effectName}: ${route.target} does not visibly guard ${route.operation}'s ${select.name}(${signature}).`));
      }
    }
  }

  findings.push(...actionCoverageFindings(card, script, source));
  ledgers.push({
    ordinal: card?.ordinal || null,
    card_id: cardId,
    card_name: card?.name || "Compatibility script",
    script,
    parsed: true,
    effects: effectCreations,
    callbacks: roles.size,
    searches: allCalls.filter((call) => /^(?:Duel\.)?(?:IsExisting|SelectMatching|GetMatching|SelectTarget)/.test(call.name)).length,
  });
}

const reviewedEntries = fs.existsSync(reviewedPath)
  ? JSON.parse(fs.readFileSync(reviewedPath, "utf8"))
  : [];
const scriptHashes = new Map(scriptPaths.map((script) => {
  const bytes = fs.readFileSync(path.join(scriptsDir, script));
  const hash = require("crypto").createHash("sha256").update(bytes).digest("hex");
  return [script, hash];
}));
const reviewedByKey = new Map(reviewedEntries.map((entry) => [
  `${entry.script}|${entry.kind}|${entry.line}`,
  entry,
]));
const acceptedFindings = [];
const openFindings = [];
for (const item of findings) {
  const reviewed = reviewedByKey.get(`${item.script}|${item.kind}|${item.line}`);
  if (item.severity === "review" && reviewed && reviewed.script_sha256 === scriptHashes.get(item.script)) {
    acceptedFindings.push({ ...item, disposition: reviewed.reason });
  } else {
    openFindings.push(item);
  }
}
const matchedReviewedKeys = new Set(acceptedFindings.map((item) => `${item.script}|${item.kind}|${item.line}`));
const staleReviewedFindings = reviewedEntries.filter((entry) =>
  !matchedReviewedKeys.has(`${entry.script}|${entry.kind}|${entry.line}`));

const counts = openFindings.reduce((result, item) => {
  result[item.severity] = (result[item.severity] || 0) + 1;
  return result;
}, {});
const kinds = openFindings.reduce((result, item) => {
  result[item.kind] = (result[item.kind] || 0) + 1;
  return result;
}, {});
const report = {
  schema_version: 1,
  summary: {
    active_cards: cards.length,
    scripts: scriptPaths.length,
    parsed_scripts: ledgers.filter((item) => item.parsed).length,
    effect_creations: ledgers.reduce((sum, item) => sum + item.effects, 0),
    callback_functions: ledgers.reduce((sum, item) => sum + item.callbacks, 0),
    search_calls: ledgers.reduce((sum, item) => sum + item.searches, 0),
    accepted_replacement_target_callbacks: acceptedReplacementTargets,
    errors: counts.error || 0,
    review_candidates: counts.review || 0,
    accepted_reviewed_findings: acceptedFindings.length,
    stale_reviewed_findings: staleReviewedFindings.length,
    findings_by_kind: Object.fromEntries(Object.entries(kinds).sort()),
  },
  findings: openFindings,
  accepted_findings: acceptedFindings,
  stale_reviewed_findings: staleReviewedFindings,
  cards: ledgers,
};

fs.mkdirSync(path.dirname(outputPath), { recursive: true });
fs.writeFileSync(outputPath, `${JSON.stringify(report, null, 2)}\n`, "utf8");
for (const [key, value] of Object.entries(report.summary)) {
  console.log(`${key}=${typeof value === "object" ? JSON.stringify(value) : value}`);
}
console.log(`report=${outputPath}`);
for (const item of openFindings.filter((candidate) => candidate.severity === "error").slice(0, 50)) {
  console.log(`ERROR ${item.script}:${item.line || 0} ${item.kind} ${item.detail}`);
}
if (strictReview) {
  for (const item of openFindings.filter((candidate) => candidate.severity === "review").slice(0, 50)) {
    console.log(`REVIEW ${item.script}:${item.line || 0} ${item.kind} ${item.detail}`);
  }
}
process.exit((counts.error || 0) > 0 || staleReviewedFindings.length > 0
  || (strictReview && (counts.review || 0) > 0) ? 1 : 0);
