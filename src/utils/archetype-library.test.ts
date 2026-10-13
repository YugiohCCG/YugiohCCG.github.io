import { describe, expect, it } from "vitest";
import { archetypeFamilies } from "./archetype-library";
import { consolidatedArchetypes } from "./memberships";
describe("archetype directory", () => {
  it("includes each named family exactly once", () => {
    expect(new Set(archetypeFamilies.map((item) => item.family)).size).toBe(archetypeFamilies.length);
    expect(archetypeFamilies.map((item) => item.family).sort()).toEqual(consolidatedArchetypes.map((group) => group.name).sort());
    for (const family of archetypeFamilies) {
      expect(family.group.iconImage).toBeTruthy();
      expect(["support", "custom", "generic"]).toContain(family.kind);
    }
  });
  it("keeps standalone monsters and named-card pairs out of the family directory", () => {
    for (const passcode of [259373017, 259889864, 245265629]) {
      expect(consolidatedArchetypes.some((family) => family.cardIds.includes(passcode))).toBe(false);
    }
  });
  it("files existing families and generic effects separately from original archetypes", () => {
    for (const name of ["C", "Gaia", "Mirror Force", "Pot", "Pumpkin", "Spirit"]) {
      expect(archetypeFamilies.find((family) => family.family === name)?.kind).toBe("support");
    }
    expect(archetypeFamilies.find((family) => family.family === "Reactor")).toBeUndefined();
    expect(archetypeFamilies.find((family) => family.family === "Galactica")?.kind).toBe("custom");
    expect(archetypeFamilies.find((family) => family.family === "Kali Yuga")?.kind).toBe("custom");
  });
});
