import { describe, expect, it } from "vitest";
import type { Card } from "../types/card";
import cardsData from "../data/cards.json";
import { cardMatches } from "./filters";
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
  it("exposes named families, including single cards and Spell/Trap series", () => {
    const cardsById = new Map((cardsData as Card[]).map((item) => [item.passcode, item]));
    expect(consolidatedArchetypes.length).toBeGreaterThan(0);
    for (const group of consolidatedArchetypes) {
      expect(group.cardIds.length).toBeGreaterThanOrEqual(1);
      expect(group.cardIds).toContain(group.iconCardId);
      expect(cardsById.get(group.iconCardId)).toBeTruthy();
      expect(group.iconImage).toBeTruthy();
    }
  });

  it("joins printed-effect support into the associated archetype", () => {
    const byName = new Map((cardsData as Card[]).map((item) => [item.name, item]));
    expect(cardMemberships(byName.get("Bauy Magician")!)).toContain("Bau");
    expect(cardMemberships(byName.get("Magical Girl Explosion!")!)).toContain("Charmelia");
    expect(cardMemberships(byName.get("Phlogiston's Roar!")!)).toContain("Phlogiston Dragon");
  });

  it("files placeholders and newly added families consistently in filters", () => {
    const byName = new Map((cardsData as Card[]).map((item) => [item.name, item]));
    expect((cardsData as Card[]).some((item) => ["Existing", "New"].includes(item.archetype ?? ""))).toBe(false);
    for (const [name, family] of [
      ["Machina Megaframe", "Machina"], ["Scion of Nephthys", "Nephthys"],
      ["Symphonic Warrior DDJ", "Symphonic Warrior"], ["Heart of the Hydra", "Dark Swamp"],
      ["Vylon Chevron", "Vylon"], ["Sylvan Flamushroomo", "Sylvan"],
      ["Killamity Goldenrod", "Killamity"], ["Kali Yuga - Vritra", "Kali Yuga"],
      ["Terrarumian Cushion Moss", "Terrarumian"], ["Pride of the Stellaers", "Stellaer"],
      ["Reactor Shocker", "Reactor"], ["Striking Mirror Force", "Mirror Force"],
      ["Lance — Luminar Justiciar", "Aurelion — Divine Illumination"],
    ]) {
      const item = byName.get(name)!;
      expect(item, name).toBeTruthy();
      expect(cardMemberships(item), name).toContain(family);
      expect(cardMatches(item, { archetype: family }), name).toBe(true);
    }
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
