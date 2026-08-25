import { describe, expect, it } from "vitest";
import type { Card } from "../types/card";
import cardsData from "../data/cards.json";
import { serializeOmegaDeck } from "./deck";
import { cardMemberships, consolidatedArchetypes, isExtraDeckCard } from "./memberships";

const card = (overrides: Partial<Card> = {}): Card => ({
  id: "CARD-TEST", passcode: 123, name: "Test Card", image: "", set: null,
  archetype: "Primary", text: "", keywords: [], category: "Monster", icon: null,
  cardTypes: ["Effect"], monsterType: ["Dragon"], attribute: "DARK", level: 4,
  rank: null, linkRating: null, linkArrows: null, scale: null, atk: 1000, def: 1000,
  ...overrides,
});

describe("website card tools", () => {
  it("only exposes consolidated multi-card archetypes with a monster icon", () => {
    const cardsById = new Map((cardsData as Card[]).map((item) => [item.passcode, item]));
    expect(consolidatedArchetypes.length).toBeGreaterThan(0);
    for (const group of consolidatedArchetypes) {
      expect(group.cardIds.length).toBeGreaterThanOrEqual(2);
      expect(group.cardIds).toContain(group.iconCardId);
      expect(cardsById.get(group.iconCardId)?.category).toBe("Monster");
      expect(group.iconImage).toBeTruthy();
    }
  });

  it("joins printed-effect support into the associated archetype", () => {
    const byName = new Map((cardsData as Card[]).map((item) => [item.name, item]));
    expect(cardMemberships(byName.get("Bauy Magician")!)).toContain("Bau");
    expect(cardMemberships(byName.get("Magical Girl Explosion!")!)).toContain("Charmelia");
    expect(cardMemberships(byName.get("Phlogiston's Roar!")!)).toContain("Phlogiston Dragon");
  });

  it("recognizes every Extra Deck card family", () => {
    for (const type of ["Fusion", "Synchro", "Xyz", "Link"]) expect(isExtraDeckCard(card({ cardTypes: [type] }))).toBe(true);
    expect(isExtraDeckCard(card({ cardTypes: ["Effect"] }))).toBe(false);
  });

  it("serializes Main, Extra, and Side sections in Omega YDK format", () => {
    expect(serializeOmegaDeck({ main: [1, 2], extra: [3], side: [4] }))
      .toBe("#created by Yu-Gi-Oh! CCG Deck Builder\n#main\n1\n2\n#extra\n3\n!side\n4\n");
  });
});
