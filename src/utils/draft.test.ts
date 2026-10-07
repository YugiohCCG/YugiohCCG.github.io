import { describe, expect, it, vi } from "vitest";
import type { Card } from "../types/card";
import type { DraftPick, DraftPoolCard, DraftSession, DraftSource } from "../types/draft";
import {
  applyDraftPick,
  assessExtraDeckCard,
  createDraftSession,
  draftCardIdentity,
  normalizeDraftCard,
} from "./draft";

function card(
  name: string,
  overrides: Partial<Card> = {},
  source: DraftSource = "TCG"
): DraftPoolCard {
  return normalizeDraftCard(
    {
      id: name.toLowerCase().replace(/\W+/g, "-"),
      name,
      image: "",
      set: null,
      archetype: null,
      text: "",
      keywords: [],
      category: "Monster",
      icon: null,
      cardTypes: ["Effect"],
      monsterType: ["Warrior"],
      attribute: "EARTH",
      level: 4,
      rank: null,
      linkRating: null,
      linkArrows: null,
      scale: null,
      atk: 1000,
      def: 1000,
      ...overrides,
    },
    source
  );
}

function pick(entry: DraftPoolCard, round: number): DraftPick {
  return { card: entry, section: "main", round, specialRound: false };
}

describe("Extra Deck draft playability", () => {
  it("reads Xyz ranks from the generated pool's level field", () => {
    const xyz = card("Rank Four", {
      cardTypes: ["Xyz"],
      level: 4,
      text: "2 Level 4 monsters\nA useful effect.",
    });
    const oneMaterial = [pick(card("Material A"), 1)];
    const twoMaterials = [...oneMaterial, pick(card("Material B"), 2)];

    expect(assessExtraDeckCard(xyz, oneMaterial).playable).toBe(false);
    expect(assessExtraDeckCard(xyz, twoMaterials).playable).toBe(true);
  });

  it("does not call an unreachable Synchro playable", () => {
    const levelEight = card("Level Eight Synchro", {
      cardTypes: ["Synchro"],
      level: 8,
      text: "1 Tuner + 1+ non-Tuner monsters",
    });
    const materials = [
      pick(card("Tuner", { cardTypes: ["Effect", "Tuner"], level: 3 }), 1),
      pick(card("Non-Tuner", { level: 4 }), 2),
    ];

    expect(assessExtraDeckCard(levelEight, materials).playable).toBe(false);
  });

  it("honours restricted non-Tuner Synchro materials", () => {
    const synchro = card("Spellcaster Synchro", {
      cardTypes: ["Synchro"],
      level: 7,
      text: "1 Tuner + 1+ non-Tuner Spellcaster monsters",
    });
    const tuner = pick(card("Tuner", { cardTypes: ["Effect", "Tuner"], level: 3 }), 1);
    const warrior = pick(card("Warrior", { monsterType: ["Warrior"], level: 4 }), 2);
    const spellcaster = pick(card("Mage", { monsterType: ["Spellcaster"], level: 4 }), 3);

    expect(assessExtraDeckCard(synchro, [tuner, warrior]).playable).toBe(false);
    expect(assessExtraDeckCard(synchro, [tuner, spellcaster]).playable).toBe(true);
  });

  it("requires both Fusion materials and a Fusion effect", () => {
    const fusion = card("Dragon Fusion", {
      cardTypes: ["Fusion"],
      monsterType: ["Dragon"],
      text: "2 Dragon monsters\nMust be Fusion Summoned.",
    });
    const materials = [
      pick(card("Dragon A", { monsterType: ["Dragon"] }), 1),
      pick(card("Dragon B", { monsterType: ["Dragon"] }), 2),
    ];
    const polymerization = pick(
      card("Polymerization", {
        category: "Spell",
        cardTypes: null,
        monsterType: null,
        level: null,
        text: "Fusion Summon 1 Fusion Monster from your Extra Deck.",
      }),
      3
    );

    expect(assessExtraDeckCard(fusion, materials).playable).toBe(false);
    expect(assessExtraDeckCard(fusion, [...materials, polymerization]).playable).toBe(true);
  });

  it("enforces typed Link materials", () => {
    const link = card("Water Link", {
      cardTypes: ["Link"],
      level: null,
      linkRating: 2,
      text: "2 WATER monsters\nA useful effect.",
    });
    const water = pick(card("Water A", { attribute: "WATER" }), 1);
    const earth = pick(card("Earth A", { attribute: "EARTH" }), 2);
    const secondWater = pick(card("Water B", { attribute: "WATER" }), 3);

    expect(assessExtraDeckCard(link, [water, earth]).playable).toBe(false);
    expect(assessExtraDeckCard(link, [water, secondWater]).playable).toBe(true);
  });
});

describe("Draft card identity", () => {
  it("distinguishes cards with the same raw id from different sources", () => {
    const tcg = card("TCG Card", { id: "shared" }, "TCG");
    const ccg = card("CCG Card", { id: "shared" }, "CCG");
    const session: DraftSession = {
      picks: [],
      offer: [tcg, ccg],
      meta: { pickNumber: 1, section: "main", picksRemainingInSection: 40, specialRound: false },
      completed: false,
    };

    const next = applyDraftPick(session, draftCardIdentity(ccg), [tcg, ccg]);
    expect(next.picks[0]?.card.source).toBe("CCG");
  });

  it("respects Limited copy caps", () => {
    const random = vi.spyOn(Math, "random").mockReturnValue(0);
    const limited = card("Limited Card", { legal: { limited: true } });
    const cards = [limited, card("Option B"), card("Option C"), card("Option D")];
    const session = createDraftSession(cards);
    const next = applyDraftPick(session, draftCardIdentity(limited), cards);

    expect(next.offer).not.toContain(limited);
    random.mockRestore();
  });
});
