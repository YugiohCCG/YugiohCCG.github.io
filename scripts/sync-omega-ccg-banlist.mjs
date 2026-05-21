import fs from "node:fs";
import path from "node:path";
import process from "node:process";
import { fileURLToPath } from "node:url";

const scriptDir = path.dirname(fileURLToPath(import.meta.url));
const repoRoot = path.resolve(scriptDir, "..");
const outputPath = path.join(
  repoRoot,
  "public",
  "CCG Downloads",
  "CCG_Banlist",
  "CCG_Banlist.lflist.conf"
);

const paths = {
  customCards: path.join(repoRoot, "src", "data", "cards.json"),
  tcgCards: path.join(repoRoot, "src", "data", "tcg-cards.json"),
  idMap: path.join(repoRoot, "scripts", "output", "CCG_v1_id_map.json"),
  draftPool: path.join(repoRoot, "public", "data", "ygo-draft-pool.json"),
};

// The website source keeps this legacy shorthand while Omega needs the card passcode.
const TCG_PASSCODE_OVERRIDES = new Map([["EL-SHADDOL-WINDA", "94977269"]]);

const STATUS = {
  forbidden: "0",
  limited: "1",
  semiLimited: "2",
};

function readJson(filePath) {
  return JSON.parse(fs.readFileSync(filePath, "utf8"));
}

function normalizeName(value) {
  return String(value || "")
    .normalize("NFKD")
    .toUpperCase()
    .replace(/[^A-Z0-9]+/g, "");
}

function limitationFor(card) {
  if (card?.legal?.banned) return STATUS.forbidden;
  if (card?.legal?.limited) return STATUS.limited;
  if (card?.legal?.semiLimited) return STATUS.semiLimited;
  return null;
}

function imagePasscode(card) {
  return String(card?.image || "").match(/\/cards\/(\d+)\.(?:jpe?g|png|webp)(?:$|\?)/i)?.[1] ?? null;
}

function indexDraftPoolPasscodes(cards) {
  const byName = new Map();

  for (const card of cards) {
    const key = normalizeName(card.name);
    const passcode = String(card.id || "");
    if (!key || !/^\d+$/.test(passcode)) continue;

    const passcodes = byName.get(key) ?? new Set();
    passcodes.add(passcode);
    byName.set(key, passcodes);
  }

  return byName;
}

function buildTcgRows(cards, draftPoolByName) {
  return cards.flatMap((card) => {
    const limitation = limitationFor(card);
    if (!limitation) return [];

    const draftPoolPasscodes = [...(draftPoolByName.get(normalizeName(card.name)) ?? [])];
    if (draftPoolPasscodes.length > 1 && !imagePasscode(card) && !TCG_PASSCODE_OVERRIDES.has(String(card.id || ""))) {
      throw new Error(
        `Ambiguous draft-pool passcode for restricted TCG card ${card.id}: ${draftPoolPasscodes.join(", ")}`
      );
    }

    const passcode =
      TCG_PASSCODE_OVERRIDES.get(String(card.id || "")) ??
      imagePasscode(card) ??
      draftPoolPasscodes[0];

    if (!passcode) {
      throw new Error(`Missing Omega passcode for restricted TCG card ${card.id}: ${card.name}`);
    }

    return [{ passcode, limitation, name: String(card.name) }];
  });
}

function buildCustomRows(cards, idMap) {
  const passcodeBySourceId = new Map(idMap.map((entry) => [String(entry.source_id), String(entry.omega_id)]));

  return cards.flatMap((card) => {
    const limitation = limitationFor(card);
    if (!limitation) return [];

    const passcode = passcodeBySourceId.get(String(card.id));
    if (!passcode) {
      throw new Error(`Missing Omega passcode for restricted CCG card ${card.id}: ${card.name}`);
    }

    return [{ passcode, limitation, name: String(card.name) }];
  });
}

function assertUniquePasscodes(rows) {
  const seen = new Map();

  for (const row of rows) {
    const previous = seen.get(row.passcode);
    if (previous) {
      throw new Error(`Duplicate banlist passcode ${row.passcode}: ${previous.name}, ${row.name}`);
    }
    seen.set(row.passcode, row);
  }
}

function rowComparator(a, b) {
  return a.name.localeCompare(b.name, undefined, { sensitivity: "base" });
}

function renderSection(title, rows, limitation) {
  const lines = rows
    .filter((row) => row.limitation === limitation)
    .sort(rowComparator)
    .map((row) => `${row.passcode} ${row.limitation} --${row.name}`);

  return [`#${title}`, ...lines];
}

function buildBanlist() {
  const draftPool = readJson(paths.draftPool);
  const draftPoolByName = indexDraftPoolPasscodes(draftPool.cards ?? []);
  const rows = [
    ...buildTcgRows(readJson(paths.tcgCards), draftPoolByName),
    ...buildCustomRows(readJson(paths.customCards), readJson(paths.idMap)),
  ];

  assertUniquePasscodes(rows);

  const lines = [
    "!CCG Banlist",
    ...renderSection("forbidden", rows, STATUS.forbidden),
    ...renderSection("limited", rows, STATUS.limited),
    ...renderSection("semi-limited", rows, STATUS.semiLimited),
  ];

  return { content: `${lines.join("\n")}\n`, rows };
}

const { content, rows } = buildBanlist();
const checkOnly = process.argv.includes("--check");
const current = fs.existsSync(outputPath) ? fs.readFileSync(outputPath, "utf8") : "";

if (checkOnly) {
  if (current !== content) {
    console.error(`Omega CCG banlist is out of sync: ${path.relative(repoRoot, outputPath)}`);
    process.exitCode = 1;
  } else {
    console.log(`Omega CCG banlist is in sync: entries=${rows.length}`);
  }
} else {
  fs.writeFileSync(outputPath, content, "utf8");
  console.log(`Wrote ${path.relative(repoRoot, outputPath)}: entries=${rows.length}`);
}
