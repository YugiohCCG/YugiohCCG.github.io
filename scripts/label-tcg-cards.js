// scripts/label-tcg-cards.mjs
import fs from "node:fs";
import path from "node:path";

const ORDER = [
  "Monster/Effect",
  "Monster/Fusion",
  "Monster/Link",
  "Monster/Ritual",
  "Monster/Synchro",
  "Monster/Xyz",
  "Spell",
  "Trap",
];

const file = path.resolve("src/data/tcg-cards.json");

const norm = (s) => (s ?? "").toString().trim();
const isNum = (v) => typeof v === "number" && Number.isFinite(v);

function normalizeCategory(cat) {
  const c = norm(cat).toLowerCase();
  if (c === "spell") return "Spell";
  if (c === "trap") return "Trap";
  return "Monster";
}

function normalizeTypes(types) {
  if (!Array.isArray(types)) return [];
  const out = new Set();
  for (const t of types) {
    const k = norm(t).toLowerCase();
    if (["effect", "monster"].includes(k)) out.add("Effect");
    else if (k === "fusion") out.add("Fusion");
    else if (k === "link") out.add("Link");
    else if (k === "ritual") out.add("Ritual");
    else if (k === "synchro") out.add("Synchro");
    else if (k === "xyz" || k === "x-y-z") out.add("Xyz");
    else if (k === "normal") out.add("Effect");
  }
  return [...out];
}

function primarySubtype(card) {
  const types = normalizeTypes(card.cardTypes).map((t) => t.toLowerCase());
  if (types.includes("link") || isNum(card.linkRating)) return "Link";
  if (types.includes("ritual") || norm(card.icon).toLowerCase() === "ritual")
    return "Ritual";
  if (types.includes("fusion")) return "Fusion";
  if (types.includes("synchro")) return "Synchro";
  if (types.includes("xyz") || isNum(card.rank)) return "Xyz";
  return "Effect";
}

function deriveSortGroup(card) {
  const category = normalizeCategory(card.category);
  if (category === "Spell") return "Spell";
  if (category === "Trap") return "Trap";
  return `Monster/${primarySubtype(card)}`;
}

function orderIndex(group) {
  const i = ORDER.indexOf(group);
  return i === -1 ? 99 : i;
}

const raw = fs.readFileSync(file, "utf8");
const cards = JSON.parse(raw);

const updated = cards.map((c) => {
  const category = normalizeCategory(c.category);
  const cardTypes = normalizeTypes(c.cardTypes);
  const sortGroup = deriveSortGroup({ ...c, category, cardTypes });
  const sortGroupIndex = orderIndex(sortGroup);

  return {
    ...c,
    category,
    cardTypes,
    sortGroup,
    sortGroupIndex,
  };
});

fs.writeFileSync(file, JSON.stringify(updated, null, 2));
console.log(`✅ Labeled ${updated.length} cards with sortGroup + sortGroupIndex`);
