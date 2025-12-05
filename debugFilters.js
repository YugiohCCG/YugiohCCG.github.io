const fs = require("fs");
const cards = JSON.parse(fs.readFileSync("src/data/cards.json", "utf8"));

const up = (s) => (s ?? "").toString().trim().toUpperCase();

const asStr = (c, keys) => {
  for (const k of keys) {
    const v = c?.[k];
    if (v != null) return String(v);
  }
  return undefined;
};

const asStrList = (c, keys) => {
  for (const k of keys) {
    const v = c?.[k];
    if (Array.isArray(v)) return v.map(String);
    if (typeof v === "string" && v) {
      return v
        .split(/[\/ ]+/)
        .filter(Boolean)
        .map(String);
    }
  }
  return [];
};

const hasAny = (hay = [], needles = []) => {
  if (!needles.length) return true;
  const H = new Set(hay.map(up));
  return needles.some((n) => H.has(up(n)));
};

function cardMatches(card, q) {
  const C = card;

  if (q.category) {
    const cat = asStr(C, ["category", "frameType"]);
    if (up(cat) !== up(q.category)) return false;
  }

  if (q.icon?.length) {
    const icons = asStrList(C, ["icon", "spellType", "trapType"]);
    if (!hasAny(icons, q.icon)) return false;
  }

  if (q.monsterType?.length) {
    const species = asStrList(C, ["monsterType", "race"]);
    if (!hasAny(species, q.monsterType)) return false;
  }

  if (q.cardTypes?.length) {
    const kinds = asStrList(C, ["cardTypes", "type"]);
    if (!hasAny(kinds, q.cardTypes)) return false;
  }

  return true;
}

const targetNames = new Set([
  "A Throne of Crying Chaos",
  "Pixie Bot",
  "Pot of Fortune",
]);

const uniq = (list) => [...new Set(list)];

const allCategories = uniq(cards.map((c) => c.category).filter(Boolean));
const allIcons = uniq(cards.map((c) => c.icon).filter(Boolean));
const allAttrs = uniq(cards.map((c) => c.attribute).filter(Boolean));
const allMonsterTypes = uniq(
  cards.flatMap((c) => (Array.isArray(c.monsterType) ? c.monsterType : c.monsterType ? [c.monsterType] : []))
);
const allCardTypes = uniq(
  cards.flatMap((c) =>
    Array.isArray(c.cardTypes)
      ? c.cardTypes
      : typeof c.type === "string"
      ? c.type.split(/[\/ ]+/).filter(Boolean)
      : []
  )
);

console.log("categories", allCategories);
console.log("icons", allIcons);
console.log("attrs", allAttrs);
console.log("monsterTypes", allMonsterTypes);
console.log("cardTypes", allCardTypes);

for (const name of targetNames) {
  const card = cards.find((c) => c.name === name);
  console.log("---", name);
  console.log({
    category: card.category,
    icon: card.icon,
    monsterType: card.monsterType,
    cardTypes: card.cardTypes,
    type: card.type,
  });
}
