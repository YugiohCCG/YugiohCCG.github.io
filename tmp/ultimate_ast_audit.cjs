const fs = require("fs");
const path = require("path");
const luaparse = require("./lua_parser/node_modules/luaparse");

const repo = path.resolve(__dirname, "..");
const cards = JSON.parse(fs.readFileSync(path.join(repo, "src/data/cards.json"), "utf8"));
const scriptsDir = path.join(repo, "public/CCG Downloads/CCG_Scripts");
const findings = [];

const mutatingTargetCall = /\bDuel\.(?:PayLPCost|DiscardHand|Release|Remove|Sendto[A-Za-z]+|Destroy|SpecialSummon|Draw|Damage|Recover|Overlay|MoveToField|SSet|Summon|MSet|FusionSummon|SynchroSummon|XyzSummon|LinkSummon|ShuffleDeck)\s*\(/g;

function memberName(node) {
  if (!node) return null;
  if (node.type === "Identifier") return node.name;
  if (node.type === "MemberExpression") {
    const base = memberName(node.base);
    const key = node.identifier && (node.identifier.name || node.identifier.value);
    return base && key ? `${base}.${key}` : null;
  }
  return null;
}

function walk(node, visit) {
  if (!node || typeof node !== "object") return;
  visit(node);
  for (const [key, value] of Object.entries(node)) {
    if (key === "loc" || key === "range") continue;
    if (Array.isArray(value)) {
      for (const child of value) walk(child, visit);
    } else if (value && typeof value === "object") {
      walk(value, visit);
    }
  }
}

for (let ordinal = 0; ordinal < cards.length; ordinal += 1) {
  const card = cards[ordinal];
  const scriptPath = path.join(scriptsDir, `c${card.passcode}.lua`);
  if (!fs.existsSync(scriptPath)) continue;
  const source = fs.readFileSync(scriptPath, "utf8");
  let ast;
  try {
    ast = luaparse.parse(source, { luaVersion: "5.3", ranges: true, locations: true });
  } catch (error) {
    findings.push({
      ordinal: ordinal + 1,
      id: card.passcode,
      name: card.name,
      kind: "parse-error",
      detail: String(error),
    });
    continue;
  }

  const roles = new Map();
  for (const role of ["Cost", "Target", "Operation", "Condition", "Value"]) {
    const regex = new RegExp(`Set${role}\\s*\\(\\s*s\\.([A-Za-z_][A-Za-z0-9_]*)`, "g");
    for (const match of source.matchAll(regex)) {
      const name = match[1];
      if (!roles.has(name)) roles.set(name, new Set());
      roles.get(name).add(role.toLowerCase());
    }
  }

  walk(ast, (node) => {
    if (node.type !== "FunctionDeclaration" || !node.identifier || !node.range) return;
    const fullName = memberName(node.identifier);
    if (!fullName || !fullName.startsWith("s.")) return;
    const functionName = fullName.slice(2);
    const functionRoles = roles.get(functionName);
    if (!functionRoles) return;
    const body = source.slice(node.range[0], node.range[1]);

    if (functionRoles.has("target")) {
      const calls = [...body.matchAll(mutatingTargetCall)].map((match) => match[0].trim());
      if (calls.length) {
        findings.push({
          ordinal: ordinal + 1,
          id: card.passcode,
          name: card.name,
          function: `s.${functionName}`,
          line: node.loc.start.line,
          kind: "target-mutates-state",
          detail: [...new Set(calls)],
        });
      }
    }

    if (functionRoles.has("condition")) {
      const calls = [...body.matchAll(mutatingTargetCall)].map((match) => match[0].trim());
      if (calls.length) {
        findings.push({
          ordinal: ordinal + 1,
          id: card.passcode,
          name: card.name,
          function: `s.${functionName}`,
          line: node.loc.start.line,
          kind: "condition-mutates-state",
          detail: [...new Set(calls)],
        });
      }
    }

    if (functionRoles.has("operation")) {
      if (/\bDuel\.SelectTarget\s*\(/.test(body)) {
        findings.push({
          ordinal: ordinal + 1,
          id: card.passcode,
          name: card.name,
          function: `s.${functionName}`,
          line: node.loc.start.line,
          kind: "operation-selects-target",
        });
      }
      if (/\bDuel\.GetFirstTarget\s*\(/.test(body) && !/IsRelateToEffect\s*\(/.test(body)) {
        findings.push({
          ordinal: ordinal + 1,
          id: card.passcode,
          name: card.name,
          function: `s.${functionName}`,
          line: node.loc.start.line,
          kind: "target-resolution-without-visible-relation-check",
        });
      }
      if (/CHAININFO_TARGET_CARDS/.test(body) && !/IsRelateToEffect|Card\.IsRelateToEffect/.test(body)) {
        findings.push({
          ordinal: ordinal + 1,
          id: card.passcode,
          name: card.name,
          function: `s.${functionName}`,
          line: node.loc.start.line,
          kind: "target-group-without-visible-relation-filter",
        });
      }
      if (/REASON_COST/.test(body) && mutatingTargetCall.test(body)) {
        mutatingTargetCall.lastIndex = 0;
        findings.push({
          ordinal: ordinal + 1,
          id: card.passcode,
          name: card.name,
          function: `s.${functionName}`,
          line: node.loc.start.line,
          kind: "operation-contains-cost-reason",
        });
      }
      mutatingTargetCall.lastIndex = 0;
    }
  });
}

fs.writeFileSync(
  path.join(repo, "tmp/ultimate_ast_findings.json"),
  `${JSON.stringify(findings, null, 2)}\n`,
  "utf8",
);
const counts = Object.entries(
  findings.reduce((result, finding) => {
    result[finding.kind] = (result[finding.kind] || 0) + 1;
    return result;
  }, {}),
);
console.log(`cards=${cards.length} findings=${findings.length}`);
for (const [kind, count] of counts) console.log(`${kind}=${count}`);
