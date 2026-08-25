import { describe, expect, it } from "vitest";

import type { Card } from "../types/card";
import { makeFuse } from "./search";

const card = (name: string, archetype: string): Card => ({
  id: name,
  name,
  image: "/test.jpg",
  set: "TEST-001 Test",
  archetype,
  text: "",
  keywords: null,
  category: "Monster",
  icon: null,
  cardTypes: ["Effect"],
  monsterType: ["Dragon"],
  attribute: "DARK",
  level: 4,
  rank: null,
  linkRating: null,
  linkArrows: null,
  scale: null,
  atk: 1000,
  def: 1000,
});

describe("makeFuse", () => {
  it("uses a strict literal match when genuine results exist", () => {
    const fishMonster = {
      ...card("Jelly Lass", "Grand Blue"),
      monsterType: ["Fish"],
      text: "If this card is Normal Summoned: draw 1 card.",
    };
    const fishSupport = {
      ...card("Cosmic Ocean", "Ghoti"),
      monsterType: null,
      text: "Add 1 Fish monster from your Deck to your hand.",
    };
    const unrelated = {
      ...card("Unrelated Card", "Other"),
      text: "If this card is Special Summoned: draw 1 card.",
    };

    const results = makeFuse([fishMonster, fishSupport, unrelated])
      .search("Fish")
      .map((result) => result.item.name);

    expect(results).toEqual(["Jelly Lass", "Cosmic Ocean"]);
  });

  it("returns close misspellings when there are no literal matches", () => {
    const fuse = makeFuse([
      card("Stardrake of Gravitic Coils", "Stardrake"),
      card("Unrelated Card", "Other"),
    ]);
    expect(fuse.search("Stardrkae").map((result) => result.item.name)).toContain(
      "Stardrake of Gravitic Coils",
    );
  });
});
