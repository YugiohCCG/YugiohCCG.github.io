import { describe, expect, it } from "vitest";

import type { Card } from "../types/card";
import { cardMatches, sortCards, type Query } from "./filters";

const baseCard: Card = {
  id: "CARD-TEST",
  passcode: 259000001,
  name: "Test Dragon",
  image: "/test.jpg",
  set: "TEST-001 Test Set",
  archetype: "Primary",
  archetypes: ["Secondary"],
  treatedAs: ["Treated"],
  namedSeries: ["Named"],
  text: "Add 1 card from your Deck to your hand.",
  keywords: ["searcher"],
  category: "Monster",
  icon: null,
  cardTypes: ["Effect", "Link"],
  monsterType: ["Dragon"],
  attribute: "DARK",
  level: null,
  rank: null,
  linkRating: 2,
  linkArrows: ["BL", "BR"],
  scale: null,
  atk: 0,
  def: null,
  legal: {},
  timestamps: { added: "2025-07-22" },
};

const matches = (query: Query, card: Card = baseCard) => cardMatches(card, query);

describe("cardMatches", () => {
  it("matches text and keyword terms case-insensitively", () => {
    expect(matches({ q: "DECK" })).toBe(true);
    expect(matches({ q: "searcher" })).toBe(true);
    expect(matches({ q: "ritual" })).toBe(false);
  });

  it("matches primary, secondary, treated-as, named, and repeated archetypes", () => {
    expect(matches({ archetype: "Primary" })).toBe(true);
    expect(matches({ archetype: "secondary" })).toBe(true);
    expect(matches({ archetype: "Treated" })).toBe(true);
    expect(matches({ archetype: "Named" })).toBe(true);
    expect(matches({ archetype: ["Missing", "Secondary"] })).toBe(true);
    expect(matches({ archetype: ["Missing", "Other"] })).toBe(false);
  });

  it("uses inclusive date ranges from timestamps.added", () => {
    expect(matches({ dateStart: "2025-07-22", dateEnd: "2025-07-22" })).toBe(true);
    expect(matches({ dateStart: "2025-07-23" })).toBe(false);
    expect(matches({ dateEnd: "2025-07-21" })).toBe(false);
  });

  it("supports inclusive numeric boundaries and excludes missing values", () => {
    expect(matches({ atkMin: 0, atkMax: 0, linkIn: [2] })).toBe(true);
    expect(matches({ atkMin: 1 })).toBe(false);
    expect(matches({ levelIn: [2] })).toBe(false);
  });

  it("applies OR within list filters and AND across filter families", () => {
    expect(matches({ attribute: ["LIGHT", "DARK"], cardTypes: ["Fusion", "Link"] })).toBe(true);
    expect(matches({ attribute: ["LIGHT"], cardTypes: ["Link"] })).toBe(false);
  });

  it("requires every selected link arrow", () => {
    expect(matches({ linkArrows: ["BL", "BR"] })).toBe(true);
    expect(matches({ linkArrows: ["BL", "T"] })).toBe(false);
  });

  it("matches legality states", () => {
    expect(matches({ legal: ["Legal"] })).toBe(true);
    expect(matches({ legal: ["Forbidden"] })).toBe(false);
    expect(matches({ legal: ["Forbidden"] }, { ...baseCard, legal: { banned: true } })).toBe(true);
  });

  it("treats unreleased cards as To Be Released and excludes them from Legal", () => {
    const unreleased = { ...baseCard, legal: { tobereleased: false } };
    expect(matches({ legal: ["To Be Released"] }, unreleased)).toBe(true);
    expect(matches({ legal: ["Legal"] }, unreleased)).toBe(false);

    const released = { ...baseCard, legal: { tobereleased: true } };
    expect(matches({ legal: ["Legal"] }, released)).toBe(true);
    expect(matches({ legal: ["To Be Released"] }, released)).toBe(false);
  });
});

describe("sortCards", () => {
  it("sorts dates by nested added value", () => {
    const earlier = { ...baseCard, id: "EARLY", timestamps: { added: "2025-01-01" } };
    const later = { ...baseCard, id: "LATE", timestamps: { added: "2026-01-01" } };
    expect(sortCards([later, earlier], "date", "asc").map((card) => card.id)).toEqual([
      "EARLY",
      "LATE",
    ]);
  });
});
