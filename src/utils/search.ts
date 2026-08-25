import Fuse, { type IFuseOptions } from "fuse.js";
import type { Card } from "../types/card";

const SEARCH_FIELDS: (keyof Card)[] = [
  "name",
  "archetype",
  "set",
  "category",
  "attribute",
  "text",
  "keywords",
  "monsterType",
  "cardTypes",
];

const options: IFuseOptions<Card> = {
  keys: [
    { name: "name", weight: 4 },
    { name: "archetype", weight: 3 },
    { name: "monsterType", weight: 2 },
    { name: "cardTypes", weight: 1.5 },
    { name: "keywords", weight: 1.5 },
    { name: "set", weight: 1 },
    { name: "category", weight: 1 },
    { name: "attribute", weight: 1 },
    { name: "text", weight: 0.5 },
  ],
  threshold: 0.25,
  ignoreLocation: true,
  includeScore: true,
  useExtendedSearch: false,
  minMatchCharLength: 3,
};

const normalise = (value: unknown) => String(value ?? "").trim().toLocaleLowerCase();

function searchableText(card: Card): string {
  return SEARCH_FIELDS.flatMap((field) => {
    const value = card[field];
    return Array.isArray(value) ? value : [value];
  })
    .filter((value) => value != null)
    .map(normalise)
    .join(" ");
}

export function makeFuse(cards: Card[]) {
  const fuse = new Fuse(cards, options);

  return {
    search(rawQuery: string) {
      const query = normalise(rawQuery);
      if (!query) return [];

      // Normal searches should be predictable: every entered term must occur
      // literally somewhere in the card's searchable fields. This prevents a
      // short term such as "Fish" from fuzzily matching common words like
      // "this" throughout hundreds of card descriptions.
      const terms = query.split(/\s+/).filter(Boolean);
      const exact = cards.flatMap((item, refIndex) =>
        terms.every((term) => searchableText(item).includes(term))
          ? [{ item, refIndex, score: 0 }]
          : [],
      );
      if (exact.length) return exact;

      // Preserve typo tolerance only as a fallback, and discard weak fuzzy
      // matches even if Fuse reports them from a long text field.
      if (query.length < 3) return [];
      return fuse.search(query).filter((result) => (result.score ?? 1) <= 0.25);
    },
  };
}
