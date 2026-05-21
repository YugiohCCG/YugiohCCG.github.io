import fs from "node:fs/promises";
import path from "node:path";

const repoRoot = process.cwd();
const outputPath = path.join(repoRoot, "public", "data", "ygo-draft-pool.json");
const overridesPath = path.join(repoRoot, "src", "data", "draft-tag-overrides.json");

const EXTRA_TYPES = ["Fusion", "Synchro", "Xyz", "Link"];

function normalizeName(value) {
  return String(value ?? "").trim().toLowerCase();
}

function mapCategory(raw) {
  const type = String(raw?.type ?? "").toLowerCase();
  if (type.includes("spell")) return "Spell";
  if (type.includes("trap")) return "Trap";
  return "Monster";
}

function mapCardTypes(raw) {
  const type = String(raw?.type ?? "");
  const mappings = [
    "Effect",
    "Normal",
    "Fusion",
    "Synchro",
    "Xyz",
    "Link",
    "Pendulum",
    "Ritual",
    "Tuner",
    "Flip",
    "Spirit",
    "Gemini",
    "Union",
    "Toon"
  ];

  return mappings.filter((entry) =>
    type.toLowerCase().includes(entry.toLowerCase())
  );
}

function draftTagsFor(name, handTrapSet, boardBreakerSet, spellTrapNonEngineSet) {
  const normalized = normalizeName(name);
  return {
    handTrap: handTrapSet.has(normalized),
    boardBreaker: boardBreakerSet.has(normalized),
    spellTrapNonEngine: spellTrapNonEngineSet.has(normalized)
  };
}

function shouldExclude(card, excludeFragments) {
  const type = String(card?.type ?? "").toLowerCase();
  if (type.includes("token") || type.includes("skill")) return true;
  const normalizedName = normalizeName(card?.name ?? "");
  return excludeFragments.some((fragment) => normalizedName.includes(fragment));
}

function isTcgCard(card) {
  return (
    Array.isArray(card?.misc_info) &&
    card.misc_info.some(
      (info) => Array.isArray(info?.formats) && info.formats.includes("TCG")
    )
  );
}

function normalizeCard(card, handTrapSet, boardBreakerSet, spellTrapNonEngineSet) {
  const category = mapCategory(card);
  const cardTypes = category === "Monster" ? mapCardTypes(card) : null;
  const monsterType = category === "Monster" && card?.race ? [String(card.race)] : null;
  const icon = category !== "Monster" && card?.race ? String(card.race) : null;
  const misc = Array.isArray(card?.misc_info) ? card.misc_info[0] : null;

  return {
    id: String(card.id),
    name: String(card.name ?? ""),
    image: String(card?.card_images?.[0]?.image_url ?? ""),
    set: card?.card_sets?.[0]?.set_code ? String(card.card_sets[0].set_code) : null,
    archetype: card?.archetype ? String(card.archetype) : null,
    text: card?.desc ? String(card.desc) : null,
    keywords: [],
    category,
    icon,
    cardTypes,
    monsterType,
    attribute: card?.attribute ? String(card.attribute) : null,
    level: typeof card?.level === "number" ? card.level : null,
    rank: typeof card?.rank === "number" ? card.rank : null,
    linkRating: typeof card?.linkval === "number" ? card.linkval : null,
    linkArrows: Array.isArray(card?.linkmarkers) ? card.linkmarkers.map(String) : null,
    scale: typeof card?.scale === "number" ? card.scale : null,
    atk: typeof card?.atk === "number" ? card.atk : null,
    def: typeof card?.def === "number" ? card.def : null,
    source: "TCG",
    isExtraDeck: Array.isArray(cardTypes)
      ? cardTypes.some((entry) => EXTRA_TYPES.includes(entry))
      : false,
    draftTags: draftTagsFor(card.name, handTrapSet, boardBreakerSet, spellTrapNonEngineSet),
    timestamps: misc?.tcg_date ? { added: misc.tcg_date } : undefined
  };
}

async function main() {
  const overrides = JSON.parse(await fs.readFile(overridesPath, "utf8"));
  const handTrapSet = new Set(overrides.handTrapNames.map(normalizeName));
  const boardBreakerSet = new Set(overrides.boardBreakerNames.map(normalizeName));
  const spellTrapNonEngineSet = new Set(
    overrides.spellTrapNonEngineNames.map(normalizeName)
  );
  const excludeFragments = overrides.excludeNameFragments.map(normalizeName);

  const [dbVersionResponse, cardResponse] = await Promise.all([
    fetch("https://db.ygoprodeck.com/api/v7/checkDBVer.php"),
    fetch("https://db.ygoprodeck.com/api/v7/cardinfo.php?misc=yes")
  ]);

  if (!dbVersionResponse.ok) {
    throw new Error(`checkDBVer failed with ${dbVersionResponse.status}`);
  }
  if (!cardResponse.ok) {
    throw new Error(`cardinfo failed with ${cardResponse.status}`);
  }

  const dbVersionPayload = await dbVersionResponse.json();
  const dbVersion = Array.isArray(dbVersionPayload)
    ? dbVersionPayload[0] ?? {}
    : dbVersionPayload ?? {};
  const payload = await cardResponse.json();
  const cards = Array.isArray(payload?.data) ? payload.data : [];

  const normalized = cards
    .filter((card) => isTcgCard(card) && !shouldExclude(card, excludeFragments))
    .map((card) =>
      normalizeCard(card, handTrapSet, boardBreakerSet, spellTrapNonEngineSet)
    );

  const output = {
    meta: {
      generatedAt: new Date().toISOString(),
      databaseVersion: dbVersion.database_version,
      lastUpdate: dbVersion.last_update,
      tcgCount: normalized.length,
      ccgCount: 0,
      usingFallback: false
    },
    cards: normalized
  };

  await fs.mkdir(path.dirname(outputPath), { recursive: true });
  await fs.writeFile(outputPath, JSON.stringify(output));
  console.log(
    `Wrote ${normalized.length} cards to ${path.relative(repoRoot, outputPath)} from DB ${dbVersion.database_version}`
  );
}

main().catch((error) => {
  console.error(error);
  process.exit(1);
});
