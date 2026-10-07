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
import tcgOmegaIds from "../data/tcg-omega-ids.json";

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
const MATERIAL_TOKENS = [...ATTRIBUTE_NAMES, ...RACE_NAMES].sort(
  (a, b) => b.length - a.length
);
const MATERIAL_TOKEN_BY_NAME = new Map(
  MATERIAL_TOKENS.map((token) => [token.toLowerCase(), token])
);
const MATERIAL_TOKEN_PATTERN = MATERIAL_TOKENS.map((token) =>
  token.replace(/[.*+?^${}()|[\]\\]/g, "\\$&")
).join("|");
const HAND_TRAPS = new Set(
  draftTagOverrides.handTrapNames.map((name) => normalizeName(name))
);
const BOARD_BREAKERS = new Set(
  draftTagOverrides.boardBreakerNames.map((name) => normalizeName(name))
);
const SPELL_TRAP_NON_ENGINE = new Set(
  draftTagOverrides.spellTrapNonEngineNames.map((name) => normalizeName(name))
);
const EXCLUDE_FRAGMENTS = draftTagOverrides.excludeNameFragments.map((name) =>
  normalizeName(name)
);
const TCG_OMEGA_IDS: Record<string, string> = tcgOmegaIds;
const CARD_ARCHETYPE_KEY_CACHE = new WeakMap<DraftPoolCard, string[]>();
const MATERIAL_LINE_CACHE = new WeakMap<DraftPoolCard, string>();

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

type UtilityFocus =
  | "boardBreaker"
  | "handTrap"
  | "spellTrapNonEngine"
  | "interaction";
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
  fusionEnablerCount: number;
  mainCategoryCounts: Map<string, number>;
  nameCounts: Map<string, number>;
  archetypeCounts: Map<string, number>;
  levelCounts: Map<number, number>;
  attributeCounts: Map<string, number>;
  raceCounts: Map<string, number>;
  maxSameAttributeCount: number;
  maxSameRaceCount: number;
};

type ExtraDeckAssessment = {
  multiplier: number;
  playable: boolean;
  label: string;
};
type XyzMaterialNeed = {
  level: number;
  token: string | null;
  missing: boolean;
};
type ExtraDeckSupportProfile = {
  archetypeKeys: Set<string>;
  quotedTokens: Set<string>;
  synchroLevels: Set<number>;
  xyzNeeds: XyzMaterialNeed[];
  linkTokens: Set<string>;
  hasLink: boolean;
  needsLinkEffect: boolean;
  fusionTokens: Set<string>;
  hasFusion: boolean;
  needsSameType: boolean;
  needsSameAttribute: boolean;
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
const DRAFT_INDEX_CACHE = new WeakMap<DraftPoolCard[], DraftIndexes>();

function normalizeName(value: string): string {
  return value.trim().toLowerCase();
}

export function draftCardIdentity(card: Pick<DraftPoolCard, "id" | "source">): string {
  return `${card.source}:${card.id}`;
}

function cardArchetypeKeys(card: DraftPoolCard): string[] {
  const cached = CARD_ARCHETYPE_KEY_CACHE.get(card);
  if (cached) return cached;
  const keys = [card.archetype, ...(card.archetypes ?? []), ...(card.treatedAs ?? [])]
    .filter((value): value is string => typeof value === "string" && value.trim().length > 0)
    .map(normalizeName)
    .filter((value, index, values) => values.indexOf(value) === index);
  CARD_ARCHETYPE_KEY_CACHE.set(card, keys);
  return keys;
}

function maximumDraftCopies(card: DraftPoolCard): number {
  if (card.legal?.banned || card.legal?.tobereleased === false) return 0;
  if (card.legal?.limited) return 1;
  if (card.legal?.semiLimited) return 2;
  return 3;
}

function canonicalMaterialToken(value: string | null | undefined): string | null {
  if (!value) return null;
  return MATERIAL_TOKEN_BY_NAME.get(normalizeName(value)) ?? null;
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

function isNumericPasscode(value: unknown): value is string | number {
  return /^\d+$/.test(String(value ?? ""));
}

function resolveOmegaPasscode(card: Card, source: DraftSource): string | number | null {
  if (source === "CCG") {
    if (typeof card.passcode === "number" && isNumericPasscode(card.passcode)) {
      return card.passcode;
    }
  }

  if (source === "TCG") {
    const mappedId = TCG_OMEGA_IDS[String(card.id ?? "")];
    if (isNumericPasscode(mappedId)) return mappedId;
  }

  return isNumericPasscode(card.id) ? String(card.id) : null;
}

export function resolveDraftTags(name: string): DraftTags {
  const normalized = normalizeName(name);
  return {
    handTrap: HAND_TRAPS.has(normalized),
    boardBreaker: BOARD_BREAKERS.has(normalized),
    spellTrapNonEngine: SPELL_TRAP_NON_ENGINE.has(normalized),
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
    omegaId: resolveOmegaPasscode(card, source),
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
    if (maximumDraftCopies(card) === 0) continue;
    const source = card.source;
    if (card.isExtraDeck) {
      indexes.extra[source].push(card);
    } else {
      indexes.main[source].push(card);
      indexes.side[source].push(card);
      if (
        card.draftTags.handTrap ||
        card.draftTags.boardBreaker ||
        card.draftTags.spellTrapNonEngine
      ) {
        indexes.special.main[source].push(card);
        indexes.special.side[source].push(card);
      }
    }
  }

  return indexes;
}

function indexesForCards(cards: DraftPoolCard[]): DraftIndexes {
  const cached = DRAFT_INDEX_CACHE.get(cards);
  if (cached) return cached;
  const indexes = buildDraftIndexes(cards);
  DRAFT_INDEX_CACHE.set(cards, indexes);
  return indexes;
}

function countById(picks: DraftPick[]): Map<string, number> {
  const counts = new Map<string, number>();
  for (const pick of picks) {
    const key = draftCardIdentity(pick.card);
    counts.set(key, (counts.get(key) ?? 0) + 1);
  }
  return counts;
}

function countByArchetype(picks: DraftPick[]): Map<string, number> {
  const counts = new Map<string, number>();
  for (const pick of picks) {
    if (pick.section === "side") continue;
    for (const key of cardArchetypeKeys(pick.card)) {
      counts.set(key, (counts.get(key) ?? 0) + 1);
    }
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
  return cardArchetypeKeys(card).includes(archetypeKey);
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
  const mainCategoryCounts = new Map<string, number>();
  let effectMonsterCount = 0;
  let fusionEnablerCount = 0;

  for (const pick of picks) {
    const card = pick.card;
    if (pick.section !== "main" || card.isExtraDeck) continue;
    incrementCount(mainCategoryCounts, card.category);
    if (
      /Fusion Summon|Polymerization/i.test(`${card.name}\n${card.text ?? ""}`)
    ) {
      fusionEnablerCount += 1;
    }
    if (card.category !== "Monster") continue;
    monsters.push(card);
    incrementCount(nameCounts, normalizeName(card.name));

    for (const archetype of cardArchetypeKeys(card)) {
      incrementCount(archetypeCounts, archetype);
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
    fusionEnablerCount,
    mainCategoryCounts,
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
  const cached = MATERIAL_LINE_CACHE.get(card);
  if (cached !== undefined) return cached;
  const line = String(card.text ?? "")
    .split(/\r?\n/)
    .map((line) => line.trim())
    .find(Boolean) ?? "";
  MATERIAL_LINE_CACHE.set(card, line);
  return line;
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
      normalizedName === normalizedToken ||
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

  for (const match of requirementLine.matchAll(
    /"([^"]+)"(?:\s+[A-Za-z-]+)*\s+monster/gi
  )) {
    const [raw, token] = match;
    const start = match.index ?? 0;
    const end = start + raw.length;
    const covered = consumedRanges.some(([rangeStart, rangeEnd]) => start >= rangeStart && end <= rangeEnd);
    if (!covered) {
      consumedRanges.push([start, end]);
      addRequirement(token, 1, false);
    }
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
  const tokenValue = canonicalMaterialToken(token);
  return profile.monsters.reduce((total, card) => {
    if (typeof level === "number" && card.level !== level) return total;
    if (!tokenValue) return total + 1;

    const isAttribute = ATTRIBUTE_NAMES.has(tokenValue);
    const isRace = RACE_NAMES.has(tokenValue);
    if (isAttribute && card.attribute === tokenValue) return total + 1;
    if (isRace && Array.isArray(card.monsterType) && card.monsterType.includes(tokenValue)) {
      return total + 1;
    }
    return total;
  }, 0);
}

function xyzRank(card: DraftPoolCard): number | null {
  if (typeof card.rank === "number") return card.rank;
  // The generated YGO draft snapshot currently places Xyz ranks in `level`.
  return hasMonsterType(card, "Xyz") && typeof card.level === "number" ? card.level : null;
}

function requiredMonsterCount(requirementLine: string): number {
  const leadingCount = requirementLine.match(/^(\d+)\+?\s+/);
  return leadingCount ? Number(leadingCount[1]) : 1;
}

function typedMaterialRequirementMultiplier(
  requirementLine: string,
  profile: MaterialProfile
): number {
  const matches = [...requirementLine.matchAll(
    new RegExp(`(?:^|\\+\\s*)(\\d+)\\+?\\s+(?:Level\\s+\\d+\\s+)?(${MATERIAL_TOKEN_PATTERN})(?:-Type)?(?:\\s+(?:Effect|Normal|Pendulum|Tuner|non-Tuner))*\\s+monsters?`, "gi")
  )];

  for (const match of matches) {
    const required = Number(match[1]);
    const token = canonicalMaterialToken(match[2]);
    if (token && countMonstersByToken(profile, null, token) < required) return 0.02;
  }
  return matches.length ? 1.2 : 1;
}

function fusionNeedsEnabler(card: DraftPoolCard): boolean {
  const text = String(card.text ?? "");
  return !(
    /do not use "?Polymerization"?/i.test(text) ||
    /Must (?:first )?be Special Summoned[\s\S]{0,180}?\bby (?:banishing|sending|tributing)/i.test(text) ||
    /Special Summoned[\s\S]{0,120}?\bby (?:banishing|sending|tributing)/i.test(text)
  );
}

function synchroRequirementIsReachable(
  card: DraftPoolCard,
  profile: MaterialProfile
): boolean {
  if (typeof card.level !== "number") return true;
  const line = materialLine(card);
  const namedTuner = normalizeName(line.match(/^"([^"]+)"\s*\+/)?.[1] ?? "");
  const tunerToken = canonicalMaterialToken(
    line.match(new RegExp(`^\\d+\\s+(${MATERIAL_TOKEN_PATTERN})(?:-Type)?\\s+Tuner`, "i"))?.[1]
  );
  const nonTunerToken = canonicalMaterialToken(
    line.match(new RegExp(`non-Tuner\\s+(${MATERIAL_TOKEN_PATTERN})(?:-Type)?\\s+monsters?`, "i"))?.[1]
  );
  const requiredNonTuners = Number(line.match(/(\d+)\+?\s+non-Tuner/i)?.[1] ?? 1);

  const tuners = profile.monsters.filter((monster) => {
    if (!hasMonsterType(monster, "Tuner") || typeof monster.level !== "number") return false;
    if (namedTuner && normalizeName(monster.name) !== namedTuner) return false;
    return !tunerToken || cardMatchesMaterialToken(monster, tunerToken);
  });
  const nonTuners = profile.monsters.filter(
    (monster) =>
      !hasMonsterType(monster, "Tuner") &&
      typeof monster.level === "number" &&
      (!nonTunerToken || cardMatchesMaterialToken(monster, nonTunerToken))
  );

  for (const tuner of tuners) {
    const target = card.level - (tuner.level ?? 0);
    if (target <= 0) continue;
    const reachable = Array.from({ length: target + 1 }, () => new Set<number>());
    reachable[0]!.add(0);
    for (const monster of nonTuners) {
      const level = monster.level ?? 0;
      for (let sum = target; sum >= level; sum -= 1) {
        for (const count of reachable[sum - level]!) {
          reachable[sum]!.add(count + 1);
        }
      }
    }
    if ([...reachable[target]!].some((count) => count >= requiredNonTuners)) return true;
  }
  return false;
}

function extraDeckSummonabilityMultiplier(
  card: DraftPoolCard,
  profile: MaterialProfile,
  synchroProfile: SynchroLevelProfile
): number {
  const requirementLine = materialLine(card);
  let multiplier = exactQuotedRequirementMultiplier(requirementLine, profile);
  if (multiplier <= 0.02) return multiplier;
  multiplier *= typedMaterialRequirementMultiplier(requirementLine, profile);
  if (multiplier <= 0.03) return multiplier;
  if (
    /with different names/i.test(requirementLine) &&
    profile.nameCounts.size < requiredMonsterCount(requirementLine)
  ) {
    return 0.03;
  }

  if (hasMonsterType(card, "Synchro")) {
    if (synchroProfile.tunerCount === 0 || synchroProfile.nonTunerCount === 0) {
      return 0.04;
    }
    if (typeof card.level === "number") {
      multiplier *=
        synchroProfile.exactLevels.has(card.level) &&
        synchroRequirementIsReachable(card, profile)
          ? 2.1
          : 0.18;
    }
  }

  const rank = xyzRank(card);
  if (hasMonsterType(card, "Xyz") && rank !== null) {
    const xyzCountMatch = requirementLine.match(
      new RegExp(
        `^(\\d+)\\+?\\s+Level\\s+(\\d+)(?:\\s+(${MATERIAL_TOKEN_PATTERN}))?\\s+monsters?`,
        "i"
      )
    );
    const requiredCount = xyzCountMatch ? Number(xyzCountMatch[1]) : 2;
    const requiredLevel = xyzCountMatch ? Number(xyzCountMatch[2]) : rank;
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
      } else if (profile.monsterCount < requiredMonsterCount(requirementLine)) {
        return 0.05;
      }
    }

    const typeIncludeMatch = requirementLine.match(
      new RegExp(`including an?\\s+(${MATERIAL_TOKEN_PATTERN})\\s+monster`, "i")
    );
    if (typeIncludeMatch) {
      const token = canonicalMaterialToken(typeIncludeMatch[1]);
      if (token) {
        if (RACE_NAMES.has(token) && (profile.raceCounts.get(token) ?? 0) === 0) {
          return 0.05;
        }
        if (ATTRIBUTE_NAMES.has(token) && (profile.attributeCounts.get(token) ?? 0) === 0) {
          return 0.05;
        }
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
    if (fusionNeedsEnabler(card) && profile.fusionEnablerCount === 0) {
      return 0.03;
    }
    const racePairMatch = requirementLine.match(
      new RegExp(`^(\\d+)\\s+(${MATERIAL_TOKEN_PATTERN})\\s+monsters?`, "i")
    );
    if (racePairMatch) {
      const requiredCount = Number(racePairMatch[1]);
      const token = canonicalMaterialToken(racePairMatch[2]);
      if (!token) return multiplier;
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

function assessExtraDeckCardFromProfiles(
  card: DraftPoolCard,
  profile: MaterialProfile,
  synchroProfile: SynchroLevelProfile
): ExtraDeckAssessment {
  const multiplier = extraDeckSummonabilityMultiplier(card, profile, synchroProfile);
  const playable = multiplier >= 0.75;
  const line = materialLine(card);
  let method = "materials available";
  if (hasMonsterType(card, "Xyz")) {
    const rank = xyzRank(card);
    method = rank == null ? "Xyz materials available" : `Rank ${rank} materials available`;
  } else if (hasMonsterType(card, "Synchro")) {
    method = typeof card.level === "number" ? `Level ${card.level} reachable` : "Synchro line available";
  } else if (hasMonsterType(card, "Link")) {
    method = `${requiredMonsterCount(line)}+ Link materials available`;
  } else if (hasMonsterType(card, "Fusion")) {
    method = fusionNeedsEnabler(card)
      ? "materials and Fusion effect available"
      : "contact materials available";
  }
  return {
    multiplier,
    playable,
    label: playable ? `Summonable now · ${method}` : `Setup needed · ${method}`,
  };
}

export function assessExtraDeckCard(
  card: DraftPoolCard,
  picks: DraftPick[]
): ExtraDeckAssessment {
  return assessExtraDeckCardFromProfiles(
    card,
    buildMaterialProfile(picks),
    buildSynchroLevelProfile(picks.filter((pick) => pick.section === "main"))
  );
}

export function draftCardInsight(
  card: DraftPoolCard,
  picks: DraftPick[],
  section: DraftDeckSection
): string {
  if (section === "extra") return assessExtraDeckCard(card, picks).label;

  const archetypeCounts = countByArchetype(picks);
  const strongestArchetype = cardArchetypeKeys(card)
    .map((key) => ({ key, count: archetypeCounts.get(key) ?? 0 }))
    .sort((left, right) => right.count - left.count)[0];
  if (strongestArchetype && strongestArchetype.count > 0) {
    return `Engine fit · ${card.archetype ?? strongestArchetype.key}`;
  }

  if (section === "main") {
    const materials = buildMaterialProfile(picks);
    const extraCards = picks
      .filter((pick) => pick.section === "extra")
      .map((pick) => pick.card);
    const support = buildExtraDeckSupportProfile(extraCards, materials);
    if (extraDeckMaterialSupportMultiplier(card, support, materials) >= 1.5) {
      return "Unlocks your Extra Deck";
    }
  }

  if (card.draftTags.boardBreaker) return "Breaks established boards";
  if (card.draftTags.handTrap) return "Early-turn interaction";
  if (card.draftTags.spellTrapNonEngine) return "Flexible interaction";
  return section === "side" ? "Matchup option" : "Wildcard lane";
}

function filterExtraPoolBySummonability(
  cards: DraftPoolCard[],
  profile: MaterialProfile,
  synchroProfile: SynchroLevelProfile,
  scoreCache: Map<string, number>
): DraftPoolCard[] {
  if (cards.length <= OFFER_SIZE) return cards;
  const cardsWithScores = cards.map((card) => {
    const key = draftCardIdentity(card);
    let score = scoreCache.get(key);
    if (score === undefined) {
      score = assessExtraDeckCardFromProfiles(card, profile, synchroProfile).multiplier;
      scoreCache.set(key, score);
    }
    return { card, score };
  });
  const playableNow = cardsWithScores
    .filter(({ score }) => score >= 0.75)
    .map(({ card }) => card);
  if (playableNow.length >= OFFER_SIZE) return playableNow;

  const draftableMaterials = cardsWithScores
    .filter(({ score }) => score >= 0.15)
    .map(({ card }) => card);
  return draftableMaterials.length >= OFFER_SIZE ? draftableMaterials : cards;
}

function shouldPreferExistingArchetype(
  archetypeCounts: Map<string, number>,
  section: DraftDeckSection,
  slotIndex: number
): boolean {
  if (!archetypeCounts.size) return false;
  // Preserve one wildcard lane so every offer is not simply three versions of
  // the same obvious engine pick.
  if (slotIndex === OFFER_SIZE - 1) return false;
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
    case "spellTrapNonEngine":
      return card.draftTags.spellTrapNonEngine;
    case "interaction":
      return (
        card.draftTags.handTrap ||
        card.draftTags.boardBreaker ||
        card.draftTags.spellTrapNonEngine
      );
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
      if (slotIndex === 0) return "boardBreaker";
      if (slotIndex === 1) return "spellTrapNonEngine";
      return "interaction";
    }
    if (slotIndex === 0) return "interaction";
    if (slotIndex === 1) {
      return Math.random() < 0.5 ? "spellTrapNonEngine" : "boardBreaker";
    }
    return null;
  }

  if (section === "side") {
    if (slotIndex === 0) return "boardBreaker";
    if (slotIndex === 1 && Math.random() < 0.5) return "spellTrapNonEngine";
    if (slotIndex === 2 && Math.random() < 0.25) return "interaction";
    return null;
  }

  if (slotIndex === 0 && Math.random() < 0.22) return "interaction";
  if (slotIndex === 1 && Math.random() < 0.1) return "spellTrapNonEngine";
  return null;
}

function cardMatchesMaterialToken(card: DraftPoolCard, token: string | null): boolean {
  const canonical = canonicalMaterialToken(token);
  if (!canonical || card.isExtraDeck || card.category !== "Monster") return false;
  if (ATTRIBUTE_NAMES.has(canonical)) return card.attribute === canonical;
  return Array.isArray(card.monsterType) && card.monsterType.includes(canonical);
}

function cardMatchesAnyMaterialToken(
  card: DraftPoolCard,
  tokens: Set<string>
): boolean {
  for (const token of tokens) {
    if (cardMatchesMaterialToken(card, token)) return true;
  }
  return false;
}

function cardMatchesQuotedMaterial(card: DraftPoolCard, quotedTokens: Set<string>): boolean {
  if (card.isExtraDeck || card.category !== "Monster") return false;

  const cardName = normalizeName(card.name);
  const archetype = normalizeName(card.archetype ?? "");
  for (const token of quotedTokens) {
    if (
      cardName === token ||
      archetype === token ||
      archetype.includes(token)
    ) {
      return true;
    }
  }

  return false;
}

function hasMatchingTunerPair(
  card: DraftPoolCard,
  level: number,
  materialProfile: MaterialProfile
): boolean {
  if (card.category !== "Monster" || typeof card.level !== "number") return false;
  const candidateIsTuner = hasMonsterType(card, "Tuner");
  const candidateLevel = card.level;
  return materialProfile.monsters.some((monster) => {
    if (typeof monster.level !== "number") return false;
    const monsterIsTuner = hasMonsterType(monster, "Tuner");
    if (candidateIsTuner === monsterIsTuner) return false;
    return candidateLevel + monster.level === level;
  });
}

function matchingMaterialCount(
  materialProfile: MaterialProfile,
  level: number | null,
  token: string | null
): number {
  return countMonstersByToken(materialProfile, level, token);
}

function buildExtraDeckSupportProfile(
  extraDeckPicks: DraftPoolCard[],
  materialProfile: MaterialProfile
): ExtraDeckSupportProfile {
  const profile: ExtraDeckSupportProfile = {
    archetypeKeys: new Set(),
    quotedTokens: new Set(),
    synchroLevels: new Set(),
    xyzNeeds: [],
    linkTokens: new Set(),
    hasLink: false,
    needsLinkEffect: false,
    fusionTokens: new Set(),
    hasFusion: false,
    needsSameType: false,
    needsSameAttribute: false,
  };

  for (const extraCard of extraDeckPicks) {
    const requirementLine = materialLine(extraCard);
    if (extraCard.archetype) {
      profile.archetypeKeys.add(normalizeName(extraCard.archetype));
    }
    for (const match of requirementLine.matchAll(/"([^"]+)"/g)) {
      const token = normalizeName(match[1] ?? "");
      if (token) profile.quotedTokens.add(token);
    }

    if (hasMonsterType(extraCard, "Synchro") && typeof extraCard.level === "number") {
      profile.synchroLevels.add(extraCard.level);
    }

    const rank = xyzRank(extraCard);
    if (hasMonsterType(extraCard, "Xyz") && rank !== null) {
      const xyzCountMatch = requirementLine.match(
        new RegExp(
          `^(\\d+)\\+?\\s+Level\\s+(\\d+)(?:\\s+(${MATERIAL_TOKEN_PATTERN}))?\\s+monsters?`,
          "i"
        )
      );
      const requiredCount = xyzCountMatch ? Number(xyzCountMatch[1]) : 2;
      const level = xyzCountMatch ? Number(xyzCountMatch[2]) : rank;
      const token = canonicalMaterialToken(xyzCountMatch?.[3] ?? null);
      profile.xyzNeeds.push({
        level,
        token,
        missing: matchingMaterialCount(materialProfile, level, token) < requiredCount,
      });
    }

    if (hasMonsterType(extraCard, "Link")) {
      profile.hasLink = true;
      profile.needsLinkEffect ||= /Effect Monsters?/i.test(requirementLine);
      const typeIncludeMatch = requirementLine.match(
        new RegExp(`including an?\\s+(${MATERIAL_TOKEN_PATTERN})\\s+monster`, "i")
      );
      const typeToken = canonicalMaterialToken(typeIncludeMatch?.[1] ?? null);
      if (typeToken) profile.linkTokens.add(typeToken);
    }

    if (hasMonsterType(extraCard, "Fusion")) {
      profile.hasFusion = true;
      const typedMaterialMatch = requirementLine.match(
        new RegExp(`^(\\d+)\\s+(${MATERIAL_TOKEN_PATTERN})\\s+monsters?`, "i")
      );
      const fusionToken = canonicalMaterialToken(typedMaterialMatch?.[2] ?? null);
      if (fusionToken) profile.fusionTokens.add(fusionToken);
    }

    profile.needsSameType ||= /same Type/i.test(requirementLine);
    profile.needsSameAttribute ||= /same Attribute/i.test(requirementLine);
  }

  return profile;
}

function extraDeckMaterialSupportMultiplier(
  card: DraftPoolCard,
  supportProfile: ExtraDeckSupportProfile,
  materialProfile: MaterialProfile
): number {
  if (card.isExtraDeck) return 1;

  let score =
    card.archetype &&
    supportProfile.archetypeKeys.has(normalizeName(card.archetype))
      ? 1.45
      : 1;

  if (cardMatchesQuotedMaterial(card, supportProfile.quotedTokens)) {
    score = Math.max(score, 2.6);
  }

  if (card.category === "Monster") {
    for (const synchroLevel of supportProfile.synchroLevels) {
      if (hasMatchingTunerPair(card, synchroLevel, materialProfile)) {
        score = Math.max(score, 2.4);
      } else if (hasMonsterType(card, "Tuner")) {
        score = Math.max(score, 1.9);
      } else if (typeof card.level === "number" && card.level < synchroLevel) {
        score = Math.max(score, 1.3);
      }
    }

    for (const xyzNeed of supportProfile.xyzNeeds) {
      if (
        card.level === xyzNeed.level &&
        (!xyzNeed.token || cardMatchesMaterialToken(card, xyzNeed.token))
      ) {
        score = Math.max(score, xyzNeed.missing ? 2.25 : 1.35);
      }
    }

    if (cardMatchesAnyMaterialToken(card, supportProfile.linkTokens)) {
      score = Math.max(score, 2.2);
    } else if (supportProfile.needsLinkEffect && hasMonsterType(card, "Effect")) {
      score = Math.max(score, 1.55);
    } else if (supportProfile.hasLink) {
      score = Math.max(score, 1.2);
    }

    if (cardMatchesAnyMaterialToken(card, supportProfile.fusionTokens)) {
      score = Math.max(score, 2.05);
    }

    if (supportProfile.needsSameType) {
      const overlapsRace = (card.monsterType ?? []).some(
        (race) => (materialProfile.raceCounts.get(race) ?? 0) > 0
      );
      if (overlapsRace) score = Math.max(score, 1.7);
    }
    if (
      supportProfile.needsSameAttribute &&
      typeof card.attribute === "string" &&
      (materialProfile.attributeCounts.get(card.attribute) ?? 0) > 0
    ) {
      score = Math.max(score, 1.7);
    }
  } else if (
    supportProfile.hasFusion &&
    card.category === "Spell" &&
    /Fusion Summon|Polymerization/i.test(`${card.name}\n${card.text ?? ""}`)
  ) {
    score = Math.max(score, 1.8);
  }

  return score;
}

function weightForCard(
  card: DraftPoolCard,
  archetypeCounts: Map<string, number>,
  pickedCounts: Map<string, number>,
  materialProfile: MaterialProfile,
  synchroProfile: SynchroLevelProfile,
  extraDeckSupportProfile: ExtraDeckSupportProfile,
  section: DraftDeckSection,
  specialRound: boolean,
  currentOffer: DraftPoolCard[],
  extraScoreCache: Map<string, number>
): number {
  let weight = 1;

  const copies = pickedCounts.get(draftCardIdentity(card)) ?? 0;
  weight *= copies === 0 ? 1 : copies === 1 ? 0.58 : 0.24;

  if (card.archetype) {
    const picksInArchetype = Math.max(
      0,
      ...cardArchetypeKeys(card).map((key) => archetypeCounts.get(key) ?? 0)
    );
    if (picksInArchetype > 0) {
      const archetypeCap = section === "extra" ? 1.5 : 1.2;
      const archetypeScale = section === "extra" ? 0.7 : 0.5;
      weight *= 1 + Math.min(archetypeCap, archetypeScale * Math.sqrt(picksInArchetype));
    }
  }

  if (section === "main" && materialProfile.mainCategoryCounts.size > 0) {
    const draftedMain = [...materialProfile.mainCategoryCounts.values()].reduce(
      (sum, count) => sum + count,
      0
    );
    const targetShare = card.category === "Monster" ? 0.55 : card.category === "Spell" ? 0.27 : 0.18;
    const current = materialProfile.mainCategoryCounts.get(card.category) ?? 0;
    const deficit = targetShare * (draftedMain + 1) - current;
    weight *= Math.max(0.72, Math.min(1.45, 1 + deficit * 0.09));
  }

  if (currentOffer.length > 0) {
    const sameCategory = currentOffer.filter((offered) => offered.category === card.category).length;
    weight *= Math.pow(section === "extra" ? 0.88 : 0.78, sameCategory);

    if (section === "extra") {
      const method = [...EXTRA_TYPES].find((type) => hasMonsterType(card, type));
      const sameMethod = currentOffer.filter((offered) =>
        method ? hasMonsterType(offered, method) : false
      ).length;
      weight *= Math.pow(0.68, sameMethod);
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

  if (card.draftTags.spellTrapNonEngine) {
    weight *= section === "side" ? 1.85 : 1.22;
    if (specialRound) {
      weight *= 1.12;
    }
  }

  if (section === "extra") {
    weight *=
      extraScoreCache.get(draftCardIdentity(card)) ??
      extraDeckSummonabilityMultiplier(card, materialProfile, synchroProfile);
  } else if (section === "main") {
    weight *= extraDeckMaterialSupportMultiplier(
      card,
      extraDeckSupportProfile,
      materialProfile
    );
  }

  return weight;
}

function randomFromWeightedPool(
  cards: DraftPoolCard[],
  archetypeCounts: Map<string, number>,
  pickedCounts: Map<string, number>,
  materialProfile: MaterialProfile,
  synchroProfile: SynchroLevelProfile,
  extraDeckSupportProfile: ExtraDeckSupportProfile,
  section: DraftDeckSection,
  specialRound: boolean,
  currentOffer: DraftPoolCard[],
  extraScoreCache: Map<string, number>
): DraftPoolCard | null {
  if (!cards.length) return null;
  const weights = cards.map((card) =>
    weightForCard(
      card,
      archetypeCounts,
      pickedCounts,
      materialProfile,
      synchroProfile,
      extraDeckSupportProfile,
      section,
      specialRound,
      currentOffer,
      extraScoreCache
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
    return pool.some((card) =>
      (pickedCounts.get(draftCardIdentity(card)) ?? 0) < maximumDraftCopies(card) &&
      !pickedThisOffer.has(draftCardIdentity(card))
    );
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
          (pickedCounts.get(draftCardIdentity(card)) ?? 0) < maximumDraftCopies(card) &&
          !pickedThisOffer.has(draftCardIdentity(card)) &&
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
  const extraDeckPicks = picks
    .filter((pick) => pick.section === "extra")
    .map((pick) => pick.card);
  const extraDeckSupportProfile = buildExtraDeckSupportProfile(
    extraDeckPicks,
    materialProfile
  );
  const pickedThisOffer = new Set<string>();
  const offer: DraftPoolCard[] = [];
  const extraScoreCache = new Map<string, number>();

  while (offer.length < OFFER_SIZE) {
    const utilityFocus = utilityFocusForSlot(section, specialRound, offer.length);
    const preferredArchetype = shouldPreferExistingArchetype(
      archetypeCounts,
      section,
      offer.length
    )
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
      const key = draftCardIdentity(card);
      if ((pickedCounts.get(key) ?? 0) >= maximumDraftCopies(card)) return false;
      return !pickedThisOffer.has(key);
    });
    const fallbackPool = (["CCG", "TCG"] as const)
      .flatMap((fallbackSource) => poolForRound(indexes, section, fallbackSource, specialRound))
      .filter((card) => {
        const key = draftCardIdentity(card);
        return (
          (pickedCounts.get(key) ?? 0) < maximumDraftCopies(card) &&
          !pickedThisOffer.has(key)
        );
      });
    let refinedFallbackPool =
      section === "extra"
        ? filterExtraPoolBySummonability(fallbackPool, materialProfile, synchroProfile, extraScoreCache)
        : fallbackPool;
    let refinedSourcePool =
      section === "extra"
        ? filterExtraPoolBySummonability(sourcePool, materialProfile, synchroProfile, extraScoreCache)
        : sourcePool;
    if (section === "extra") {
      const playableFallback = refinedFallbackPool.filter(
        (card) => (extraScoreCache.get(draftCardIdentity(card)) ?? 0) >= 0.75
      );
      if (playableFallback.length >= OFFER_SIZE - offer.length) {
        refinedFallbackPool = playableFallback;
        refinedSourcePool = refinedSourcePool.filter(
          (card) => (extraScoreCache.get(draftCardIdentity(card)) ?? 0) >= 0.75
        );
      }
    }
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
      pickedCounts,
      materialProfile,
      synchroProfile,
      extraDeckSupportProfile,
      section,
      specialRound,
      offer,
      extraScoreCache
    );
    if (!nextCard) break;
    offer.push(nextCard);
    pickedThisOffer.add(draftCardIdentity(nextCard));
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
  const indexes = indexesForCards(cards);
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
  selectedCardIdentity: string,
  cards: DraftPoolCard[]
): DraftSession {
  if (session.completed || !session.meta) return session;
  const card = session.offer.find(
    (entry) => draftCardIdentity(entry) === selectedCardIdentity
  );
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

  const indexes = indexesForCards(cards);
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
  const sections: Record<DraftDeckSection, string[]> = {
    main: [],
    extra: [],
    side: [],
  };

  for (const pick of picks) {
    const passcode = pick.card.omegaId;
    if (!isNumericPasscode(passcode)) continue;
    sections[pick.section].push(String(passcode));
  }

  const lines = [
    "#created by CCG Draft",
    "#main",
    ...sections.main,
    "#extra",
    ...sections.extra,
    "!side",
    ...sections.side,
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
  anchor.download = "ccg-draft-deck.ydk";
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
