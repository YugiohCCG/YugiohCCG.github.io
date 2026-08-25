import { readFileSync } from "node:fs";
import { resolve } from "node:path";
import { describe, expect, it } from "vitest";
import type { Card } from "../types/card";
import { BANLIST_TYPE_ORDER, banlistGroup, orderBanlistCards } from "./banlistOrder";

const cards = JSON.parse(readFileSync(resolve(process.cwd(), "public/data/banlist-cards.json"), "utf8")) as Card[];

describe("banlist type ordering", () => {
  it("classifies Extra Deck monsters by frame type instead of generic Effect", () => {
    const byName = new Map(cards.map((card) => [card.name.toUpperCase(), card]));
    expect(banlistGroup(byName.get("EL SHADDOLL WINDA")!)).toBe("Monster/Fusion");
    expect(banlistGroup(byName.get("ABYSS DWELLER")!)).toBe("Monster/Xyz");
    expect(banlistGroup(byName.get("APOLLOUSA, BOW OF THE GODDESS")!)).toBe("Monster/Link");
  });

  it("orders every restriction section by type and then alphabetically", () => {
    for (const status of ["banned", "limited", "semiLimited"] as const) {
      const ordered = orderBanlistCards(cards.filter((card) => card.legal?.[status]));
      const keys = ordered.map((card) => [BANLIST_TYPE_ORDER.indexOf(banlistGroup(card) as typeof BANLIST_TYPE_ORDER[number]), card.name.toLocaleLowerCase()] as const);
      expect(keys).toEqual([...keys].sort((a, b) => a[0] - b[0] || a[1].localeCompare(b[1])));
    }
  });
});
