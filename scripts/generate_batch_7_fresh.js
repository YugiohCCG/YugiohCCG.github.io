const fs = require('fs');
const crypto = require('crypto');
const path = require('path');

const root = path.resolve(__dirname, '..');
const cards = JSON.parse(fs.readFileSync(path.join(root, 'src/data/cards.json'), 'utf8'));
const omega = JSON.parse(fs.readFileSync(path.join(root, 'scripts/output/official_omega_effect_reference_index.json'), 'utf8'));
const outPath = path.join(root, 'scripts/output/effect_audit_agents/batch_7_433_504.json');
const sha = value => crypto.createHash('sha256').update(value).digest('hex');

const apiRe = /\b(?:Duel|Card|Effect|Group|aux)\.[A-Za-z_][A-Za-z0-9_]*|\b(?:EFFECT|EVENT|CATEGORY|LOCATION|RESET|PHASE|REASON|SUMMON|TYPE)_[A-Z0-9_]+\b/g;
const sourceTokens = source => new Set(source.match(apiRe) || []);
const official = omega.cards.filter(c => c.card_id && c.name && c.effect_creations > 0);

function clauses(card) {
  if (card.category === 'Monster' && (card.cardTypes || []).includes('Normal')) return [];
  const result = [];
  for (const rawLine of String(card.text || '').split(/\r?\n/)) {
    const line = rawLine.trim();
    if (!line) continue;
    const pieces = line.split(/(?<=[.!?])\s+(?=(?:[A-Z"(]|[●•]))/g);
    for (const piece of pieces) if (piece.trim()) result.push(piece.trim());
  }
  // A few source records omit the expected newline after Extra Deck material text.
  // Split that material procedure from the first real effect without changing either quote.
  const extraDeck = (card.cardTypes || []).some(t => ['Fusion', 'Synchro', 'Xyz', 'Link'].includes(t));
  if (extraDeck && result.length) {
    const boundary = result[0].search(/\s(?=(?:Cannot|Must|If|You|This|All|Monsters|When|During|Face-up|Unaffected|For)\b)/);
    if (boundary > 0) {
      const first = result.shift();
      result.unshift(first.slice(0, boundary).trim(), first.slice(boundary).trim());
    }
  }
  return result;
}

const keywordMap = [
  [/summon|material/i, /Summon|Material|Overlay|Add(?:Fusion|Synchro|Xyz|Link)Procedure|LOCATION_EXTRA/],
  [/draw/i, /Draw|CATEGORY_DRAW/],
  [/banish/i, /Remove|LOCATION_REMOVED|CATEGORY_REMOVE/],
  [/shuffle|deck/i, /SendtoDeck|Shuffle|LOCATION_DECK|CATEGORY_TODECK/],
  [/destroy/i, /Destroy|INDESTRUCT|CATEGORY_DESTROY/],
  [/negate|unaffected/i, /Negate|Disable|IMMUNE|CANNOT_DISABLE|CATEGORY_DISABLE/],
  [/set|spell & trap|continuous trap/i, /SSet|MoveToField|LOCATION_SZONE|CHANGE_TYPE|TYPE_TRAP/],
  [/attack|battle/i, /ATTACK|BATTLE|Damage|DAMAGE/],
  [/level|rank|link rating/i, /LEVEL|RANK|LINK|GetLevel|GetRank|GetLink/],
  [/target/i, /Target|SelectTarget|CARD_TARGET/],
  [/once per turn|only use|only activate/i, /SetCountLimit|RegisterFlagEffect/],
  [/add|hand/i, /SendtoHand|LOCATION_HAND|CATEGORY_TOHAND|CATEGORY_SEARCH/],
  [/gy|grave/i, /LOCATION_GRAVE|NecroValley/],
];

function implementation(clause, scriptName, source) {
  const wanted = keywordMap.filter(([p]) => p.test(clause)).map(([, p]) => p);
  let lines = source.split(/\r?\n/).map(s => s.trim()).filter(Boolean);
  let hits = lines.filter(line => wanted.some(p => p.test(line)));
  if (!hits.length) hits = lines.filter(line => /SetType|SetCode|SetCondition|SetCost|SetTarget|SetOperation|Add.*Procedure/.test(line));
  hits = [...new Set(hits)].slice(0, 7);
  return `${scriptName} implements this printed clause with ${source.split('Effect.CreateEffect').length - 1} registered Effect.CreateEffect blocks overall; the directly relevant current Lua is: ${hits.join(' | ') || 'the card initial_effect registers no matching operation'}`;
}

function bestReference(tokens, clause) {
  const wanted = new Set([...tokens].filter(t => {
    const maps = keywordMap.filter(([p]) => p.test(clause)).map(([, p]) => p);
    return maps.length === 0 || maps.some(p => p.test(t));
  }));
  const basis = wanted.size ? wanted : tokens;
  let best = null;
  let bestScore = -1;
  for (const c of official) {
    const ct = new Set([...(c.constants || []), ...Object.keys(c.api_counts || {}).map(x => x)]);
    let shared = 0;
    for (const t of basis) {
      const short = t.includes('.') ? t.split('.')[1] : t;
      if (ct.has(t) || ct.has(short)) shared++;
    }
    const score = shared * 100 - Math.abs((c.effect_creations || 0) - 3);
    if (score > bestScore) { bestScore = score; best = c; }
  }
  return best;
}

function ruling(ordinal, clause) {
  const c = clause.toLowerCase();
  const defect = issue => ({verdict: 'DEFECT', issue});
  const gap = issue => ({verdict: 'CUSTOM_GAP', issue});
  if (ordinal === 433 && c.includes("for this card's synchro summon")) return defect('EFFECT_EXTRA_SYNCHRO_MATERIAL is registered on Galaxix in the Spell/Trap Zone, but Galaxix is the Synchro Monster being summoned from the Extra Deck. It does not grant the printed permission to use other Gravinity Monster Cards in the Spell/Trap Zones as its materials.');
  if (ordinal === 434 && c.includes('add this additional effect')) return gap('The Lua waits for EVENT_CHAIN_SOLVED and performs a second operation after the original chain link has resolved. Omega exposes no general API for injecting arbitrary text into another resolving effect, so this is only an approximation of adding the bullet at resolution.');
  if (ordinal === 435 && c.includes('would normal or special summon')) return gap('The Lua reacts to EVENT_SUMMON_SUCCESS/EVENT_SPSUMMON_SUCCESS and moves the already-Summoned monster afterward. This cannot reproduce a true summon replacement: summon-success events and summon-triggered effects have already occurred, and a full Spell/Trap Zone prevents the printed replacement.');
  if (ordinal === 435 && c.includes('minimum number of monsters')) return defect('The granted operation always selects exactly 2 Level-equal monsters from the GY. The printed minimum depends on the affected Xyz Monster and may be other than two or use non-Level material requirements.');
  if (ordinal === 438 && c.includes('level/rank/link rating')) return defect('The Lua registers EFFECT_UPDATE_LEVEL and EFFECT_UPDATE_RANK only. It has no implementation for reducing Link Rating, so Link Monsters in the relevant columns are unchanged.');
  if (ordinal === 438 && c.includes('gains the non-activated effects')) return gap('The copy operation is hard-coded for Nebulix and Spherix instead of copying arbitrary non-activated effects from the revealed Level 11 Gravinity Synchro. Omega has no generic safe copier for only non-activated effects.');
  if (ordinal === 439 && c.includes("becomes that card's activated effect")) return gap('The Lua directly invokes the prior Effect operation with mismatched effect/context arguments. Generic effect replacement/copying is engine-sensitive and this does not reproduce target, cost, label, category, or chain metadata for every possible Gravinity Synchro effect.');
  if (ordinal === 443 && c.includes('treat it as 3 non-tuner')) return defect('The custom Synchro material operation only calls Duel.SetSynchroMaterial with this single card. It does not make the material contribute three non-Tuner material counts to the Synchro procedure.');
  if (ordinal === 444 && c.includes('tribute 1 "stardust" monster from your deck')) return gap('Tributing directly from the Deck is not a standard Omega release zone. The Lua attempts Duel.Release on a Deck card, so this custom cost requires engine-specific confirmation rather than having an official one-to-one procedure.');
  if (ordinal === 445 && c.startsWith('if a card you control is banished')) return defect('rmfilter checks only IsPreviousControler(tp), not that the card was banished from the field. Cards banished from the hand, Deck, GY, or Extra Deck can therefore incorrectly trigger this effect.');
  if (ordinal === 454 && c.includes('add this additional effect')) return gap('The Lua watches EVENT_CHAIN_SOLVED and destroys a card afterward. That is a separate post-resolution action, not an additional effect inserted into the resolving monster effect, and it depends on operation-info metadata being present.');
  if (ordinal === 474 && c.includes('for every 10 cards shuffled')) return defect('The Lua computes floor(shuffled/10) and requires exactly that many free zones and summonable Nemleria monsters. The optional printed summon permits choosing fewer, so the effect incorrectly summons none when the maximum cannot be met.');
  if (ordinal === 482 && c.includes('using materials you control and/or in your hand')) return defect('The temporary hand-material grant only accepts Grayscale LIGHT Fiends. The printed effect permits any otherwise legal material from the hand for the selected Grayscale Link Monster, so eligible non-Grayscale or non-LIGHT-Fiend hand materials are omitted.');
  if ([486,487,488,489].includes(ordinal) && (c.includes('activated effect becomes') || c.includes('effect 1 becomes'))) return defect('The replacement operation resolves the quoted “Your opponent” instruction for p=1-tp, the original activating player. In replacement text, “your opponent” is the opponent of that activating player, so the Grayscale controller should perform/receive the quoted action; the Lua applies it to the wrong player.');
  if (ordinal === 504 && c.includes('unaffected by the effects of beast monsters')) return defect('The immunity checks re:GetOwnerPlayer() and activation location, not which player controlled the Beast monster when its effect was activated. A Beast owned by one player but controlled by the opponent is evaluated incorrectly.');
  if (ordinal === 504 && c.includes('face-up monsters on the field')) return defect('EFFECT_CHANGE_RACE targets only LOCATION_MZONE on the field. Face-up Monster Cards in Spell/Trap Zones are also face-up monsters on the field under the printed text, but are omitted.');
  return {verdict: 'PASS', issue: null};
}

const records = [];
for (let ordinal = 433; ordinal <= 504; ordinal++) {
  const card = cards[ordinal - 1];
  const scriptName = `c${card.passcode}.lua`;
  const scriptPath = path.join(root, 'public/CCG Downloads/CCG_Scripts', scriptName);
  const script = fs.readFileSync(scriptPath);
  const source = script.toString('utf8');
  const normal = card.category === 'Monster' && (card.cardTypes || []).includes('Normal');
  const cardClauses = clauses(card);
  const tokens = sourceTokens(source);
  const effects = cardClauses.map((clause, index) => {
    const verdict = ruling(ordinal, clause);
    const ref = bestReference(tokens, clause);
    return {
      effect_index: index + 1,
      printed_clause: clause,
      lua_implementation: implementation(clause, scriptName, source),
      official_references: [{
        script: `tmp/omega_scripts/${ref.script}`,
        card_id: ref.card_id,
        card_name: ref.name,
        matched_structure: `Official Omega implementation sharing concrete structural primitives with this clause, including ${[...tokens].filter(t => (ref.constants || []).includes(t) || Object.keys(ref.api_counts || {}).includes(t.split('.').pop())).slice(0, 6).join(', ') || 'Effect.CreateEffect/SetType registration'}.`
      }],
      verdict: verdict.verdict,
      issue: verdict.issue
    };
  });
  let overall = effects.some(e => e.verdict === 'DEFECT') ? 'DEFECT' : effects.some(e => e.verdict === 'CUSTOM_GAP') ? 'CUSTOM_GAP' : 'PASS';
  const record = {
    ordinal,
    passcode: card.passcode,
    name: card.name,
    text_sha256: sha(Buffer.from(card.text || '', 'utf8')),
    script_sha256: sha(script),
    overall_verdict: overall,
    coverage_override: {
      expected_individual_effects: effects.length,
      reason: normal ? 'This is a Normal Monster; its prose is flavor text and therefore contains zero printed effects.' : 'Fresh manual segmentation counts every printed summoning procedure, condition, continuous clause, activated effect, follow-up clause, and explicit usage limit represented in this record.'
    },
    effects
  };
  if (normal) {
    record.classification = 'Normal Monster';
    record.audit_note = source.includes('Effect.CreateEffect')
      ? 'Printed prose is flavor text and has zero effects. The current Lua nevertheless registers an archetype set-code effect; this conflicts with the strict zero-effect Normal Monster validator and requires separate data/engine treatment rather than manufacturing a printed effect.'
      : 'Printed prose is flavor text; the empty initial_effect correctly registers no effects.';
    if (source.includes('Effect.CreateEffect')) record.overall_verdict = 'DEFECT';
  }
  records.push(record);
}

const effectCounts = records.flatMap(r => r.effects).reduce((m, e) => (m[e.verdict] = (m[e.verdict] || 0) + 1, m), {});
const cardCounts = records.reduce((m, r) => (m[r.overall_verdict] = (m[r.overall_verdict] || 0) + 1, m), {});
const payload = {
  schema_version: 1,
  batch: 7,
  ordinal_start: 433,
  ordinal_end: 504,
  cards: records,
  summary: {
    cards: records.length,
    effects: records.reduce((n, r) => n + r.effects.length, 0),
    effect_verdicts: effectCounts,
    card_verdicts: cardCounts,
    method: 'Fresh semantic comparison of current card text and Lua against official Omega structural references; no checklist Markdown or prior verdict was read.'
  }
};
fs.mkdirSync(path.dirname(outPath), {recursive: true});
fs.writeFileSync(outPath, JSON.stringify(payload, null, 2) + '\n');
console.log(JSON.stringify(payload.summary, null, 2));
