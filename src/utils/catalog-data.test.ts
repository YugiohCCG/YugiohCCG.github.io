import { existsSync, readFileSync } from "node:fs";
import { resolve } from "node:path";
import { describe, expect, it } from "vitest";
import type { Card } from "../types/card";

describe("full Yu-Gi-Oh! deck catalog", () => {
  const path = resolve(process.cwd(), "public/data/yugioh-cards.json");
  const cards = JSON.parse(readFileSync(path, "utf8")) as Card[];

  it("contains a unique, deck-usable passcode for every catalog card", () => {
    expect(cards.length).toBeGreaterThan(14_000);
    expect(new Set(cards.map((card) => card.passcode)).size).toBe(cards.length);
    expect(cards.every((card) => card.passcode && card.name && card.text)).toBe(true);
  });

  it("contains foundational and current Yu-Gi-Oh! cards", () => {
    const names = new Set(cards.map((card) => card.name));
    expect(names.has("Blue-Eyes White Dragon")).toBe(true);
    expect(names.has("Dark Magician")).toBe(true);
    expect(names.has("Mulcharmy Fuwalos")).toBe(true);
  });
});

describe("website banlist catalog", () => {
  const cards = JSON.parse(readFileSync(resolve(process.cwd(), "public/data/banlist-cards.json"), "utf8")) as Card[];
  const source = readFileSync(resolve(process.cwd(), "public/CCG Downloads/CCG_Banlist/CCG_Banlist.lflist.conf"), "utf8");
  const rows = [...source.matchAll(/^(\d+)\s+([012])(?:\s+--.*)?$/gm)].map((match) => ({
    passcode: Number(match[1]),
    status: match[2],
  }));

  it("matches every passcode and restriction in the downloadable Omega banlist", () => {
    const generated = cards.map((card) => ({
      passcode: card.passcode,
      status: card.legal?.banned ? "0" : card.legal?.limited ? "1" : "2",
    }));
    expect(generated).toEqual(rows);
  });

  it("contains both TCG and CCG cards", () => {
    expect(cards.some((card) => card.id.startsWith("YGO-"))).toBe(true);
    expect(cards.some((card) => card.id.startsWith("CARD-"))).toBe(true);
  });

  it("ships a local image for every banlist card", () => {
    for (const card of cards) {
      expect(card.image, card.name).toMatch(/^\/assets\//);
      expect(existsSync(resolve(process.cwd(), "public", card.image.slice(1))), card.name).toBe(true);
    }
  });
});

describe("Ohmen spell visibility", () => {
  it("includes all three restored spells in the Ohmen archetype", () => {
    const cards = JSON.parse(readFileSync(resolve(process.cwd(), "src/data/cards.json"), "utf8")) as Card[];
    const catalog = JSON.parse(readFileSync(resolve(process.cwd(), "src/data/archetype-catalog.json"), "utf8"));
    const ohmen = catalog.find((group: { name: string }) => group.name === "Ohmen");
    for (const name of ["Ohmen Surge", "Ohmen Powerload", "Ohmen Beacon"]) {
      const card = cards.find((item) => item.name === name)!;
      expect(card.hidden, name).not.toBe(true);
      expect(card.archetype, name).toBe("Ohmen");
      expect(ohmen.cardIds, name).toContain(card.passcode);
    }
  });
});
