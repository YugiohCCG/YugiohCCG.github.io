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
  it("returns close misspellings instead of requiring an exact substring", () => {
    const fuse = makeFuse([
      card("Stardrake of Gravitic Coils", "Stardrake"),
      card("Unrelated Card", "Other"),
    ]);
    expect(fuse.search("Stardrak").map((result) => result.item.name)).toContain(
      "Stardrake of Gravitic Coils",
    );
  });
});
