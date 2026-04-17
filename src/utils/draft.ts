import type { Card } from "../types/card";
import type {
  DraftDeckSection,
  DraftOfferMeta,
  DraftPick,
  DraftPoolCard,
  DraftPoolMeta,
  DraftPoolSnapshot,
  DraftSession,
  DraftSource,
  DraftTags,
} from "../types/draft";
import draftTagOverrides from "../data/draft-tag-overrides.json";

const EXTRA_TYPES = new Set(["Fusion", "Synchro", "Xyz", "Link"]);
const ATTRIBUTE_NAMES = new Set(["DARK", "LIGHT", "FIRE", "WATER", "WIND", "EARTH", "DIVINE"]);
const RACE_NAMES = new Set([
  "Aqua",
  "Beast",
  "Beast-Warrior",
  "Creator-God",
  "Cyberse",
  "Dinosaur",
  "Divine-Beast",
  "Dragon",
  "Fairy",
  "Fiend",
  "Fish",
  "Illusion",
  "Insect",
  "Machine",
  "Plant",
  "Psychic",
  "Pyro",
  "Reptile",
  "Rock",
  "Sea Serpent",
  "Spellcaster",
  "Thunder",
  "Warrior",
  "Winged Beast",
  "Wyrm",
  "Zombie",
]);
const HAND_TRAPS = new Set(
  draftTagOverrides.handTrapNames.map((name) => normalizeName(name))
);
const BOARD_BREAKERS = new Set(
  draftTagOverrides.boardBreakerNames.map((name) => normalizeName(name))
);
const EXCLUDE_FRAGMENTS = draftTagOverrides.excludeNameFragments.map((name) =>
  normalizeName(name)
);

export const DRAFT_TARGETS: Record<DraftDeckSection, number> = {
  main: 40,
  extra: 15,
  side: 15,
};

export const TOTAL_DRAFT_PICKS =
  DRAFT_TARGETS.main + DRAFT_TARGETS.extra + DRAFT_TARGETS.side;
export const OFFER_SIZE = 3;

const SOURCE_RATE: Record<DraftSource, number> = {
  CCG: 0.33,
  TCG: 0.67,
};

const PRE_SIDE_PICKS = DRAFT_TARGETS.main + DRAFT_TARGETS.extra;
const EXTRA_ARCHETYPE_SLOT_RATE = 0.5;
const EXISTING_ARCHETYPE_SLOT_RATE = 0.3;
const EXTRA_RAMP_EXPONENT = 1.7;
const MAX_SYNCHRO_LEVEL = 16;
const SPECIAL_ROUND_RATE = 0.18;
const DRAFT_ROUND_SECTIONS: DraftDeckSection[] = Array.from(
  { length: TOTAL_DRAFT_PICKS },
  (_, pickCount) => {
    if (pickCount >= PRE_SIDE_PICKS) return "side";

    const extraBefore = Math.floor(
      Math.pow(pickCount / PRE_SIDE_PICKS, EXTRA_RAMP_EXPONENT) * DRAFT_TARGETS.extra
    );
    const extraAfter = Math.floor(
      Math.pow((pickCount + 1) / PRE_SIDE_PICKS, EXTRA_RAMP_EXPONENT) *
        DRAFT_TARGETS.extra
    );

    return extraAfter > extraBefore ? "extra" : "main";
  }
);

type UtilityFocus = "boardBreaker" | "handTrap" | "interaction";
type CardPredicate = (card: DraftPoolCard) => boolean;
type SynchroLevelProfile = {
  exactLevels: Set<number>;
  tunerCount: number;
  nonTunerCount: number;
};
type MaterialProfile = {
  monsters: DraftPoolCard[];
  monsterCount: number;
  effectMonsterCount: number;
  nameCounts: Map<string, number>;
  archetypeCounts: Map<string, number>;
  levelCounts: Map<number, number>;
  attributeCounts: Map<string, number>;
  raceCounts: Map<string, number>;
  maxSameAttributeCount: number;
  maxSameRaceCount: number;
};

type DraftIndexes = {
  main: Record<DraftSource, DraftPoolCard[]>;
  extra: Record<DraftSource, DraftPoolCard[]>;
  side: Record<DraftSource, DraftPoolCard[]>;
  special: {
    main: Record<DraftSource, DraftPoolCard[]>;
    side: Record<DraftSource, DraftPoolCard[]>;
  };
};

function normalizeName(value: string): string {
  return value.trim().toLowerCase();
}

function toKeywordArray(value: Card["keywords"]): string[] {
  if (Array.isArray(value)) return value.map(String);
  if (typeof value === "string" && value.trim()) return [value.trim()];
  return [];
}

function deriveExtraDeck(cardTypes: string[] | null | undefined): boolean {
  if (!Array.isArray(cardTypes)) return false;
  return cardTypes.some((type) => EXTRA_TYPES.has(String(type)));
}

export function resolveDraftTags(name: string): DraftTags {
  const normalized = normalizeName(name);
  return {
    handTrap: HAND_TRAPS.has(normalized),
    boardBreaker: BOARD_BREAKERS.has(normalized),
  };
}

function shouldExcludeByName(name: string): boolean {
  const normalized = normalizeName(name);
  return EXCLUDE_FRAGMENTS.some((fragment) => normalized.includes(fragment));
}

export function normalizeDraftCard(card: Card, source: DraftSource): DraftPoolCard {
  const draftTags = resolveDraftTags(String(card.name ?? ""));
  const cardTypes = Array.isArray(card.cardTypes) ? card.cardTypes.map(String) : null;
  const monsterType = Array.isArray(card.monsterType) ? card.monsterType.map(String) : null;
  const keywords = toKeywordArray(card.keywords);

  return {
    ...card,
    id: String(card.id ?? card.name),
    image: String(card.image ?? ""),
    name: String(card.name ?? ""),
    set: card.set ? String(card.set) : null,
    archetype: card.archetype ? String(card.archetype) : null,
    text: card.text ? String(card.text) : null,
    keywords,
    cardTypes,
    monsterType,
    source,
    draftTags,
    isExtraDeck: deriveExtraDeck(cardTypes),
  };
}

export function hydrateDraftPoolCard(input: DraftPoolCard): DraftPoolCard {
  return normalizeDraftCard(input, input.source);
}

export function currentDraftSection(pickCount: number): DraftDeckSection {
  return DRAFT_ROUND_SECTIONS[pickCount] ?? "side";
}

function countPicksInSection(picks: DraftPick[], section: DraftDeckSection): number {
  return picks.reduce((total, pick) => total + (pick.section === section ? 1 : 0), 0);
}

function picksRemainingInSection(section: DraftDeckSection, picks: DraftPick[]): number {
  return Math.max(0, DRAFT_TARGETS[section] - countPicksInSection(picks, section));
}

function buildDraftIndexes(cards: DraftPoolCard[]): DraftIndexes {
  const init = (): Record<DraftSource, DraftPoolCard[]> => ({ CCG: [], TCG: [] });
  const indexes: DraftIndexes = {
    main: init(),
    extra: init(),
    side: init(),
    special: { main: init(), side: init() },
  };

  for (const card of cards) {
    const source = card.source;
    if (card.isExtraDeck) {
      indexes.extra[source].push(card);
    } else {
      indexes.main[source].push(card);
      indexes.side[source].push(card);
      if (card.draftTags.handTrap || card.draftTags.boardBreaker) {
        indexes.special.main[source].push(card);
        indexes.special.side[source].push(card);
      }
    }
  }

  return indexes;
}

function countById(picks: DraftPick[]): Map<string, number> {
  const counts = new Map<string, number>();
  for (const pick of picks) {
    counts.set(pick.card.id, (counts.get(pick.card.id) ?? 0) + 1);
  }
  return counts;
}

function countByArchetype(picks: DraftPick[]): Map<string, number> {
  const counts = new Map<string, number>();
  for (const pick of picks) {
    if (!pick.card.archetype) continue;
    const key = normalizeName(pick.card.archetype);
    counts.set(key, (counts.get(key) ?? 0) + 1);
  }
  return counts;
}

function incrementCount<Key>(counts: Map<Key, number>, key: Key) {
  counts.set(key, (counts.get(key) ?? 0) + 1);
}

function weightedRandomIndex(weights: number[]): number {
  const totalWeight = weights.reduce((sum, weight) => sum + weight, 0);
  if (totalWeight <= 0) return -1;

  let roll = Math.random() * totalWeight;
  for (let index = 0; index < weights.length; index += 1) {
    roll -= weights[index] ?? 0;
    if (roll <= 0) return index;
  }

  return weights.length - 1;
}

function cardMatchesArchetype(card: DraftPoolCard, archetypeKey: string): boolean {
  return typeof card.archetype === "string" && normalizeName(card.archetype) === archetypeKey;
}

function hasMonsterType(card: DraftPoolCard, type: string): boolean {
  return Array.isArray(card.cardTypes) && card.cardTypes.includes(type);
}

function buildSynchroLevelProfile(picks: DraftPick[]): SynchroLevelProfile {
  const tunerLevels: number[] = [];
  const nonTunerLevels: number[] = [];

  for (const pick of picks) {
    const card = pick.card;
    if (card.isExtraDeck || card.category !== "Monster" || typeof card.level !== "number") {
      continue;
    }

    if (hasMonsterType(card, "Tuner")) {
      tunerLevels.push(card.level);
    } else {
      nonTunerLevels.push(card.level);
    }
  }

  const reachableNonTunerSums = Array(MAX_SYNCHRO_LEVEL + 1).fill(false);
  reachableNonTunerSums[0] = true;

  for (const level of nonTunerLevels) {
    const normalizedLevel = Math.max(0, Math.min(MAX_SYNCHRO_LEVEL, level));
    for (let sum = MAX_SYNCHRO_LEVEL; sum >= normalizedLevel; sum -= 1) {
      if (reachableNonTunerSums[sum - normalizedLevel]) {
        reachableNonTunerSums[sum] = true;
      }
    }
  }

  const exactLevels = new Set<number>();
  for (const tunerLevel of tunerLevels) {
    for (let nonTunerSum = 1; nonTunerSum <= MAX_SYNCHRO_LEVEL - tunerLevel; nonTunerSum += 1) {
      if (reachableNonTunerSums[nonTunerSum]) {
        exactLevels.add(tunerLevel + nonTunerSum);
      }
    }
  }

  return {
    exactLevels,
    tunerCount: tunerLevels.length,
    nonTunerCount: nonTunerLevels.length,
  };
}

function buildMaterialProfile(picks: DraftPick[]): MaterialProfile {
  const monsters: DraftPoolCard[] = [];
  const nameCounts = new Map<string, number>();
  const archetypeCounts = new Map<string, number>();
  const levelCounts = new Map<number, number>();
  const attributeCounts = new Map<string, number>();
  const raceCounts = new Map<string, number>();
  let effectMonsterCount = 0;

  for (const pick of picks) {
    const card = pick.card;
    if (card.isExtraDeck || card.category !== "Monster") continue;
    monsters.push(card);
    incrementCount(nameCounts, normalizeName(card.name));

    if (card.archetype) {
      incrementCount(archetypeCounts, normalizeName(card.archetype));
    }
    if (typeof card.level === "number") {
      incrementCount(levelCounts, card.level);
    }
    if (typeof card.attribute === "string" && ATTRIBUTE_NAMES.has(card.attribute)) {
      incrementCount(attributeCounts, card.attribute);
    }
    if (Array.isArray(card.monsterType)) {
      for (const race of card.monsterType) {
        if (RACE_NAMES.has(race)) {
          incrementCount(raceCounts, race);
        }
      }
    }
    if (hasMonsterType(card, "Effect")) {
      effectMonsterCount += 1;
    }
  }

  return {
    monsters,
    monsterCount: monsters.length,
    effectMonsterCount,
    nameCounts,
    archetypeCounts,
    levelCounts,
    attributeCounts,
    raceCounts,
    maxSameAttributeCount: Math.max(...attributeCounts.values(), 0),
    maxSameRaceCount: Math.max(...raceCounts.values(), 0),
  };
}

function materialLine(card: DraftPoolCard): string {
  return String(card.text ?? "")
    .split(/\r?\n/)
    .map((line) => line.trim())
    .find(Boolean) ?? "";
}

function countMonsterTokenMatches(profile: MaterialProfile, token: string): number {
  const normalizedToken = normalizeName(token);
  const exactNameMatches = profile.nameCounts.get(normalizedToken) ?? 0;
  if (exactNameMatches > 0) return exactNameMatches;

  const exactArchetypeMatches = profile.archetypeCounts.get(normalizedToken) ?? 0;
  if (exactArchetypeMatches > 0) return exactArchetypeMatches;

  return profile.monsters.reduce((total, card) => {
    const normalizedName = normalizeName(card.name);
    const normalizedArchetype = normalizeName(card.archetype ?? "");
    if (
      normalizedName.includes(normalizedToken) ||
      normalizedArchetype.includes(normalizedToken)
    ) {
      return total + 1;
    }
    return total;
  }, 0);
}

function exactQuotedRequirementMultiplier(
  requirementLine: string,
  profile: MaterialProfile
): number {
  if (!requirementLine) return 1;

  const consumedRanges: Array<[number, number]> = [];
  const tokenRequirements = new Map<string, { requiredCount: number; exactName: boolean }>();
  const addRequirement = (token: string, requiredCount: number, exactName: boolean) => {
    const key = `${exactName ? "exact" : "token"}:${normalizeName(token)}`;
    const current = tokenRequirements.get(key);
    if (current) {
      current.requiredCount += requiredCount;
    } else {
      tokenRequirements.set(key, { requiredCount, exactName });
    }
  };

  for (const match of requirementLine.matchAll(
    /(\d+)\+?\s+"([^"]+)"(?:\s+[A-Za-z-]+)*\s+monster[s]?/gi
  )) {
    const [raw, countValue, token] = match;
    const start = match.index ?? 0;
    consumedRanges.push([start, start + raw.length]);
    addRequirement(token, Number(countValue), false);
  }

  for (const match of requirementLine.matchAll(
    /including an?\s+"([^"]+)"(?:\s+[A-Za-z-]+)*\s+monster/gi
  )) {
    const [raw, token] = match;
    const start = match.index ?? 0;
    consumedRanges.push([start, start + raw.length]);
    addRequirement(token, 1, false);
  }

  for (const match of requirementLine.matchAll(/"([^"]+)"/g)) {
    const [raw, token] = match;
    const start = match.index ?? 0;
    const end = start + raw.length;
    const covered = consumedRanges.some(([rangeStart, rangeEnd]) => start >= rangeStart && end <= rangeEnd);
    if (!covered) {
      addRequirement(token, 1, true);
    }
  }

  let hadExplicitRequirement = false;
  for (const [key, requirement] of tokenRequirements.entries()) {
    hadExplicitRequirement = true;
    const token = key.replace(/^(exact|token):/, "");
    const available = requirement.exactName
      ? profile.nameCounts.get(token) ?? 0
      : countMonsterTokenMatches(profile, token);
    if (available < requirement.requiredCount) {
      return 0.02;
    }
  }

  return hadExplicitRequirement ? 1.35 : 1;
}

function countMonstersByToken(
  profile: MaterialProfile,
  level: number | null,
  token: string | null
): number {
  const normalizedToken = token ? normalizeName(token) : null;
  const tokenValue = token ?? "";
  return profile.monsters.reduce((total, card) => {
    if (typeof level === "number" && card.level !== level) return total;
    if (!normalizedToken) return total + 1;

    const isAttribute = ATTRIBUTE_NAMES.has(tokenValue);
    const isRace = RACE_NAMES.has(tokenValue);
    if (isAttribute && card.attribute === tokenValue) return total + 1;
    if (isRace && Array.isArray(card.monsterType) && card.monsterType.includes(tokenValue)) {
      return total + 1;
    }
    return total;
  }, 0);
}

function extraDeckSummonabilityMultiplier(
  card: DraftPoolCard,
  profile: MaterialProfile,
  synchroProfile: SynchroLevelProfile
): number {
  const requirementLine = materialLine(card);
  let multiplier = exactQuotedRequirementMultiplier(requirementLine, profile);
  if (multiplier <= 0.02) return multiplier;

  if (hasMonsterType(card, "Synchro")) {
    if (synchroProfile.tunerCount === 0 || synchroProfile.nonTunerCount === 0) {
      return 0.04;
    }
    if (typeof card.level === "number") {
      multiplier *= synchroProfile.exactLevels.has(card.level) ? 2.1 : 0.18;
    }
  }

  if (hasMonsterType(card, "Xyz") && typeof card.rank === "number") {
    const xyzCountMatch = requirementLine.match(/^(\d+)\+?\s+Level\s+(\d+)(?:\s+([A-Za-z-]+))?\s+monsters?/i);
    const requiredCount = xyzCountMatch ? Number(xyzCountMatch[1]) : 2;
    const requiredLevel = xyzCountMatch ? Number(xyzCountMatch[2]) : card.rank;
    const token = xyzCountMatch?.[3] ?? null;
    const matchingCount = countMonstersByToken(profile, requiredLevel, token);
    if (matchingCount < requiredCount) {
      return 0.04;
    }
    multiplier *= 1.6;
  }

  if (hasMonsterType(card, "Link")) {
    const effectMatch = requirementLine.match(/^(\d+)\+?\s+Effect Monsters?/i);
    if (effectMatch) {
      const requiredCount = Number(effectMatch[1]);
      if (profile.effectMonsterCount < requiredCount) {
        return 0.05;
      }
      multiplier *= 1.35;
    } else {
      const genericMatch = requirementLine.match(/^(\d+)\+?\s+monsters?/i);
      if (genericMatch) {
        const requiredCount = Number(genericMatch[1]);
        if (profile.monsterCount < requiredCount) {
          return 0.05;
        }
      }
    }

    const typeIncludeMatch = requirementLine.match(/including an?\s+([A-Za-z-]+)\s+monster/i);
    if (typeIncludeMatch) {
      const race = typeIncludeMatch[1] ?? "";
      if (RACE_NAMES.has(race) && (profile.raceCounts.get(race) ?? 0) === 0) {
        return 0.05;
      }
    }

    if (/same Type/i.test(requirementLine) && profile.maxSameRaceCount < 2) {
      return 0.05;
    }
    if (/same Attribute/i.test(requirementLine) && profile.maxSameAttributeCount < 2) {
      return 0.05;
    }
  }

  if (hasMonsterType(card, "Fusion")) {
    const racePairMatch = requirementLine.match(/^(\d+)\s+([A-Za-z-]+)\s+monsters?/i);
    if (racePairMatch) {
      const requiredCount = Number(racePairMatch[1]);
      const token = racePairMatch[2] ?? "";
      if (RACE_NAMES.has(token) && (profile.raceCounts.get(token) ?? 0) < requiredCount) {
        return 0.05;
      }
      if (ATTRIBUTE_NAMES.has(token) && (profile.attributeCounts.get(token) ?? 0) < requiredCount) {
        return 0.05;
      }
    }

    if (/same Type/i.test(requirementLine) && profile.maxSameRaceCount < 2) {
      return 0.05;
    }
    if (/same Attribute/i.test(requirementLine) && profile.maxSameAttributeCount < 2) {
      return 0.05;
    }
  }

  return multiplier;
}

function filterExtraPoolBySummonability(
  cards: DraftPoolCard[],
  profile: MaterialProfile,
  synchroProfile: SynchroLevelProfile
): DraftPoolCard[] {
  if (cards.length <= OFFER_SIZE) return cards;
  const filtered = cards.filter(
    (card) => extraDeckSummonabilityMultiplier(card, profile, synchroProfile) >= 0.1
  );
  return filtered.length >= OFFER_SIZE ? filtered : cards;
}

function shouldPreferExistingArchetype(
  archetypeCounts: Map<string, number>,
  section: DraftDeckSection
): boolean {
  if (!archetypeCounts.size) return false;
  const rate =
    section === "extra" ? EXTRA_ARCHETYPE_SLOT_RATE : EXISTING_ARCHETYPE_SLOT_RATE;
  return Math.random() < rate;
}

function choosePreferredArchetype(archetypeCounts: Map<string, number>): string | null {
  const entries = [...archetypeCounts.entries()].filter(([, count]) => count > 0);
  if (!entries.length) return null;

  const weights = entries.map(([, count]) => Math.pow(count, 1.15));
  const index = weightedRandomIndex(weights);
  return index >= 0 ? entries[index]?.[0] ?? null : null;
}

function cardMatchesUtilityFocus(card: DraftPoolCard, focus: UtilityFocus): boolean {
  switch (focus) {
    case "boardBreaker":
      return card.draftTags.boardBreaker;
    case "handTrap":
      return card.draftTags.handTrap;
    case "interaction":
      return card.draftTags.handTrap || card.draftTags.boardBreaker;
    default:
      return false;
  }
}

function utilityFocusForSlot(
  section: DraftDeckSection,
  specialRound: boolean,
  slotIndex: number
): UtilityFocus | null {
  if (section === "extra") return null;

  if (specialRound) {
    if (section === "side") {
      return slotIndex < 2 ? "boardBreaker" : "interaction";
    }
    if (slotIndex === 0) return "interaction";
    return Math.random() < 0.4 ? "boardBreaker" : null;
  }

  if (section === "side") {
    if (slotIndex === 0) return "boardBreaker";
    if (slotIndex === 1 && Math.random() < 0.5) return "boardBreaker";
    if (slotIndex === 2 && Math.random() < 0.2) return "handTrap";
    return null;
  }

  if (slotIndex === 0 && Math.random() < 0.22) return "interaction";
  if (slotIndex === 1 && Math.random() < 0.1) return "boardBreaker";
  return null;
}

function weightForCard(
  card: DraftPoolCard,
  archetypeCounts: Map<string, number>,
  materialProfile: MaterialProfile,
  synchroProfile: SynchroLevelProfile,
  section: DraftDeckSection,
  specialRound: boolean
): number {
  let weight = 1;

  if (card.archetype) {
    const picksInArchetype = archetypeCounts.get(normalizeName(card.archetype)) ?? 0;
    if (picksInArchetype > 0) {
      const archetypeCap = section === "extra" ? 1.5 : 1.2;
      const archetypeScale = section === "extra" ? 0.7 : 0.5;
      weight *= 1 + Math.min(archetypeCap, archetypeScale * Math.sqrt(picksInArchetype));
    }
  }

  if (card.draftTags.handTrap) {
    weight *= section === "side" ? 1.35 : 1.18;
    if (specialRound) {
      weight *= 1.08;
    }
  }

  if (card.draftTags.boardBreaker) {
    weight *= section === "side" ? 2.35 : 1.3;
    if (specialRound) {
      weight *= section === "side" ? 1.15 : 1.05;
    }
  }

  if (section === "extra") {
    weight *= extraDeckSummonabilityMultiplier(card, materialProfile, synchroProfile);
  }

  return weight;
}

function randomFromWeightedPool(
  cards: DraftPoolCard[],
  archetypeCounts: Map<string, number>,
  materialProfile: MaterialProfile,
  synchroProfile: SynchroLevelProfile,
  section: DraftDeckSection,
  specialRound: boolean
): DraftPoolCard | null {
  if (!cards.length) return null;
  const weights = cards.map((card) =>
    weightForCard(
      card,
      archetypeCounts,
      materialProfile,
      synchroProfile,
      section,
      specialRound
    )
  );
  const index = weightedRandomIndex(weights);
  if (index < 0) {
    return cards[Math.floor(Math.random() * cards.length)] ?? null;
  }
  return cards[index] ?? cards[cards.length - 1] ?? null;
}

function chooseSource(
  indexes: DraftIndexes,
  section: DraftDeckSection,
  specialRound: boolean,
  pickedThisOffer: Set<string>,
  pickedCounts: Map<string, number>,
  preferredFilter: CardPredicate | null
): DraftSource {
  const sources: DraftSource[] = ["CCG", "TCG"];
  const available = sources.filter((source) => {
    const pool =
      specialRound && section !== "extra"
        ? indexes.special[section][source]
        : indexes[section][source];
    return pool.some((card) => (pickedCounts.get(card.id) ?? 0) < 3 && !pickedThisOffer.has(card.id));
  });

  if (!available.length) return "TCG";
  if (available.length === 1) return available[0]!;

  if (preferredFilter) {
    const preferredAvailable = available.filter((source) => {
      const pool =
        specialRound && section !== "extra"
          ? indexes.special[section][source]
          : indexes[section][source];
      return pool.some(
        (card) =>
          (pickedCounts.get(card.id) ?? 0) < 3 &&
          !pickedThisOffer.has(card.id) &&
          preferredFilter(card)
      );
    });

    if (preferredAvailable.length === 1) return preferredAvailable[0]!;
    if (preferredAvailable.length === 2) {
      return Math.random() < SOURCE_RATE.CCG ? "CCG" : "TCG";
    }
  }

  return Math.random() < SOURCE_RATE.CCG ? "CCG" : "TCG";
}

function poolForRound(
  indexes: DraftIndexes,
  section: DraftDeckSection,
  source: DraftSource,
  specialRound: boolean
): DraftPoolCard[] {
  if (specialRound && section !== "extra") {
    return indexes.special[section][source];
  }
  return indexes[section][source];
}

function canRunSpecialRound(indexes: DraftIndexes, section: DraftDeckSection): boolean {
  if (section === "extra") return false;
  const totalSpecial =
    indexes.special[section].CCG.length + indexes.special[section].TCG.length;
  return totalSpecial >= OFFER_SIZE;
}

function buildOffer(
  indexes: DraftIndexes,
  picks: DraftPick[]
): { offer: DraftPoolCard[]; meta: DraftOfferMeta | null } {
  const pickNumber = picks.length;
  if (pickNumber >= TOTAL_DRAFT_PICKS) {
    return { offer: [], meta: null };
  }

  const section = currentDraftSection(pickNumber);
  const specialRound =
    canRunSpecialRound(indexes, section) && Math.random() < SPECIAL_ROUND_RATE;
  const pickedCounts = countById(picks);
  const archetypeCounts = countByArchetype(picks);
  const materialProfile = buildMaterialProfile(picks);
  const synchroProfile = buildSynchroLevelProfile(picks);
  const pickedThisOffer = new Set<string>();
  const offer: DraftPoolCard[] = [];

  while (offer.length < OFFER_SIZE) {
    const utilityFocus = utilityFocusForSlot(section, specialRound, offer.length);
    const preferredArchetype = shouldPreferExistingArchetype(archetypeCounts, section)
      ? choosePreferredArchetype(archetypeCounts)
      : null;
    const utilityFilter = utilityFocus
      ? (card: DraftPoolCard) => cardMatchesUtilityFocus(card, utilityFocus)
      : null;
    const archetypeFilter = preferredArchetype
      ? (card: DraftPoolCard) => cardMatchesArchetype(card, preferredArchetype)
      : null;
    const preferredFilter =
      utilityFilter && archetypeFilter
        ? (card: DraftPoolCard) => utilityFilter(card) && archetypeFilter(card)
        : utilityFilter ?? archetypeFilter;
    const source = chooseSource(
      indexes,
      section,
      specialRound,
      pickedThisOffer,
      pickedCounts,
      preferredFilter
    );
    const sourcePool = poolForRound(indexes, section, source, specialRound).filter((card) => {
      if ((pickedCounts.get(card.id) ?? 0) >= 3) return false;
      return !pickedThisOffer.has(card.id);
    });
    const fallbackPool = (["CCG", "TCG"] as const)
      .flatMap((fallbackSource) => poolForRound(indexes, section, fallbackSource, specialRound))
      .filter((card) => (pickedCounts.get(card.id) ?? 0) < 3 && !pickedThisOffer.has(card.id));
    const refinedSourcePool =
      section === "extra"
        ? filterExtraPoolBySummonability(sourcePool, materialProfile, synchroProfile)
        : sourcePool;
    const refinedFallbackPool =
      section === "extra"
        ? filterExtraPoolBySummonability(fallbackPool, materialProfile, synchroProfile)
        : fallbackPool;
    const jointSourcePool = preferredFilter
      ? refinedSourcePool.filter((card) => preferredFilter(card))
      : [];
    const jointFallbackPool = preferredFilter
      ? refinedFallbackPool.filter((card) => preferredFilter(card))
      : [];
    const archetypeSourcePool = archetypeFilter
      ? refinedSourcePool.filter((card) => archetypeFilter(card))
      : [];
    const archetypeFallbackPool = archetypeFilter
      ? refinedFallbackPool.filter((card) => archetypeFilter(card))
      : [];
    const utilitySourcePool = utilityFilter
      ? refinedSourcePool.filter((card) => utilityFilter(card))
      : [];
    const utilityFallbackPool = utilityFilter
      ? refinedFallbackPool.filter((card) => utilityFilter(card))
      : [];
    const nextCard = randomFromWeightedPool(
      jointSourcePool.length
        ? jointSourcePool
        : jointFallbackPool.length
          ? jointFallbackPool
          : utilitySourcePool.length
            ? utilitySourcePool
            : utilityFallbackPool.length
              ? utilityFallbackPool
              : archetypeSourcePool.length
                ? archetypeSourcePool
                : archetypeFallbackPool.length
                  ? archetypeFallbackPool
                  : refinedSourcePool.length
                    ? refinedSourcePool
                    : refinedFallbackPool,
      archetypeCounts,
      materialProfile,
      synchroProfile,
      section,
      specialRound
    );
    if (!nextCard) break;
    offer.push(nextCard);
    pickedThisOffer.add(nextCard.id);
  }

  return {
    offer,
    meta: {
      pickNumber: pickNumber + 1,
      section,
      picksRemainingInSection: picksRemainingInSection(section, picks),
      specialRound,
    },
  };
}

export function createDraftSession(cards: DraftPoolCard[]): DraftSession {
  const indexes = buildDraftIndexes(cards);
  const next = buildOffer(indexes, []);
  return {
    picks: [],
    offer: next.offer,
    meta: next.meta,
    completed: false,
  };
}

export function applyDraftPick(
  session: DraftSession,
  selectedCardId: string,
  cards: DraftPoolCard[]
): DraftSession {
  if (session.completed || !session.meta) return session;
  const card = session.offer.find((entry) => entry.id === selectedCardId);
  if (!card) return session;

  const nextPicks: DraftPick[] = [
    ...session.picks,
    {
      card,
      section: session.meta.section,
      round: session.meta.pickNumber,
      specialRound: session.meta.specialRound,
    },
  ];

  if (nextPicks.length >= TOTAL_DRAFT_PICKS) {
    return {
      picks: nextPicks,
      offer: [],
      meta: null,
      completed: true,
    };
  }

  const indexes = buildDraftIndexes(cards);
  const next = buildOffer(indexes, nextPicks);
  return {
    picks: nextPicks,
    offer: next.offer,
    meta: next.meta,
    completed: false,
  };
}

type DraftSectionSummary = {
  total: number;
  entries: Array<{ name: string; count: number; source: DraftSource }>;
};

export function summarizeDraftSections(
  picks: DraftPick[]
): Record<DraftDeckSection, DraftSectionSummary> {
  const sections: Record<DraftDeckSection, Map<string, { name: string; count: number; source: DraftSource }>> = {
    main: new Map(),
    extra: new Map(),
    side: new Map(),
  };

  for (const pick of picks) {
    const section = sections[pick.section];
    const existing = section.get(pick.card.name);
    if (existing) {
      existing.count += 1;
    } else {
      section.set(pick.card.name, {
        name: pick.card.name,
        count: 1,
        source: pick.card.source,
      });
    }
  }

  const output = {} as Record<DraftDeckSection, DraftSectionSummary>;
  for (const key of Object.keys(sections) as DraftDeckSection[]) {
    const entries = [...sections[key].values()].sort((a, b) => {
      if (b.count !== a.count) return b.count - a.count;
      return a.name.localeCompare(b.name);
    });
    output[key] = {
      total: entries.reduce((sum, entry) => sum + entry.count, 0),
      entries,
    };
  }
  return output;
}

export function buildDecklistText(picks: DraftPick[]): string {
  const summary = summarizeDraftSections(picks);
  const lines = [
    "# CCG Draft Deck",
    `# Generated ${new Date().toISOString()}`,
    "",
    `# Main Deck (${summary.main.total})`,
    ...summary.main.entries.map((entry) => `${entry.count}x ${entry.name}`),
    "",
    `# Extra Deck (${summary.extra.total})`,
    ...summary.extra.entries.map((entry) => `${entry.count}x ${entry.name}`),
    "",
    `# Side Deck (${summary.side.total})`,
    ...summary.side.entries.map((entry) => `${entry.count}x ${entry.name}`),
    "",
  ];
  return lines.join("\n");
}

export function downloadDecklist(picks: DraftPick[]) {
  const content = buildDecklistText(picks);
  const blob = new Blob([content], { type: "text/plain;charset=utf-8" });
  const url = URL.createObjectURL(blob);
  const anchor = document.createElement("a");
  anchor.href = url;
  anchor.download = "ccg-draft-deck.txt";
  anchor.click();
  URL.revokeObjectURL(url);
}

export function buildFallbackDraftSnapshot(
  customCards: Card[],
  tcgCards: Card[]
): DraftPoolSnapshot {
  const normalizedCustom = customCards
    .filter((card) => !shouldExcludeByName(String(card.name ?? "")))
    .map((card) => normalizeDraftCard(card, "CCG"));
  const normalizedTcg = tcgCards
    .filter((card) => !shouldExcludeByName(String(card.name ?? "")))
    .map((card) => normalizeDraftCard(card, "TCG"));

  const meta: DraftPoolMeta = {
    generatedAt: new Date().toISOString(),
    usingFallback: true,
    tcgCount: normalizedTcg.length,
    ccgCount: normalizedCustom.length,
  };

  return {
    meta,
    cards: [...normalizedCustom, ...normalizedTcg],
  };
}
