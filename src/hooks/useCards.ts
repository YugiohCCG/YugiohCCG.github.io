// src/hooks/useCards.ts
import { useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import type { Card, SetInfo } from "../types/card";
import { cardMatches, type Query } from "../utils/filters";

// Bundled data
import customCards from "../data/cards.json";
import tcgCards from "../data/tcg-cards.json";
import testCards from "../data/cards - test.json";
import setsData from "../data/sets.json";

export type UseCardsOptions = {
  includeTCG?: boolean;
  includeCustom?: boolean;
  includeTest?: boolean;
};

export type Indexes = {
  setsByCode: Map<string, SetInfo>;
  setsList: SetInfo[];
  archetypes: string[];
  monsterTypes: string[];    // NEW: global monster-type options (unfiltered)
};

export type UseCardsResult = {
  loading: boolean;
  error: unknown | null;
  cards: Card[];
  sets: SetInfo[];
  indexes: Indexes;
  query: Query;
};

// ---------- URL helpers ----------
const getAll = (p: URLSearchParams, k: string) => p.getAll(k);
const getOne = (p: URLSearchParams, k: string) => p.get(k) ?? "";

const getAllNum = (p: URLSearchParams, k: string) =>
  p.getAll(k).map((v) => Number(v)).filter((n) => !Number.isNaN(n));

const getNum = (p: URLSearchParams, k: string) => {
  const v = p.get(k);
  return v == null || v === "" ? undefined : Number(v);
};

// Collect numbers from multiple possible keys (supports single + repeated)
function collectNums(p: URLSearchParams, keys: string[]): number[] {
  const out: number[] = [];
  for (const k of keys) {
    // repeated values
    const many = getAllNum(p, k);
    if (many.length) out.push(...many);
    // single value
    const single = getNum(p, k);
    if (single != null && !Number.isNaN(single)) out.push(single);
  }
  // dedupe & sort
  return Array.from(new Set(out)).sort((a, b) => a - b);
}

function buildQuery(params: URLSearchParams): Query {
  const q: Query = {
    q: getOne(params, "q") || undefined,
    set: getOne(params, "set") || undefined,

    archetype: getOne(params, "archetype") || undefined,
    category: (getOne(params, "category") as any) || undefined,
    icon: getAll(params, "icon"),
    attribute: getAll(params, "attribute"),

    monsterType: getAll(params, "monsterType"),
    cardTypes: getAll(params, "cardTypes"),

    // legacy ranges (UI may still set these)
    levelMin: getNum(params, "levelMin"),
    levelMax: getNum(params, "levelMax"),
    rankMin: getNum(params, "rankMin"),
    rankMax: getNum(params, "rankMax"),
    scaleMin: getNum(params, "scaleMin"),
    scaleMax: getNum(params, "scaleMax"),
    linkMin: getNum(params, "linkMin"),
    linkMax: getNum(params, "linkMax"),

    // tolerant exact-list forms
    levelIn: collectNums(params, ["levelIn", "level", "lvl"]),
    rankIn:  collectNums(params, ["rankIn", "rank", "rk"]),
    scaleIn: collectNums(params, ["scaleIn", "scale", "pendulum", "ps", "sc"]),
    linkIn:  collectNums(params, ["linkIn", "link", "linkRating", "lnk"]),

    atkMin: getNum(params, "atkMin"),
    atkMax: getNum(params, "atkMax"),
    defMin: getNum(params, "defMin"),
    defMax: getNum(params, "defMax"),

    legal: getAll(params, "legal"),
    linkArrows: getAll(params, "linkArrows").length
      ? getAll(params, "linkArrows")
      : getAll(params, "arrows"), // tolerate alt key

    dateStart: getOne(params, "dateStart") || undefined,
    dateEnd: getOne(params, "dateEnd") || undefined,

    sort: (getOne(params, "sort") as any) || undefined,
    view: (getOne(params, "view") as any) || undefined,
  };

  // If exact lists exist, clear ranges to avoid conflicts
  if (q.levelIn?.length) q.levelMin = q.levelMax = undefined;
  if (q.rankIn?.length)  q.rankMin  = q.rankMax  = undefined;
  if (q.scaleIn?.length) q.scaleMin = q.scaleMax = undefined;
  if (q.linkIn?.length)  q.linkMin  = q.linkMax  = undefined;

  return q;
}

export default function useCards(
  opts: UseCardsOptions = { includeTCG: true, includeCustom: true, includeTest: false }
): UseCardsResult {
  const [params] = useSearchParams();
  const query = useMemo(() => buildQuery(params), [params]);

  // Compose dataset based on options (UNFILTERED source)
  const sourceCards: Card[] = useMemo(() => {
    const parts: Card[][] = [];
    if (opts.includeCustom !== false) parts.push(customCards as unknown as Card[]);
    if (opts.includeTCG) parts.push(tcgCards as unknown as Card[]);
    if (opts.includeTest) parts.push(testCards as unknown as Card[]);
    return parts.flat();
  }, [opts.includeCustom, opts.includeTCG, opts.includeTest]);

  const sets: SetInfo[] = useMemo(
    () => (setsData as unknown as SetInfo[]) ?? [],
    []
  );

  // FILTERED results to display
  const cards: Card[] = useMemo(() => {
    if (!sourceCards?.length) return [];
    return sourceCards.filter((c) => cardMatches(c, query));
  }, [sourceCards, query]);

  // INDEXES from the UNFILTERED source (so UI options never disappear)
  const indexes: Indexes = useMemo(() => {
    const setsByCode = new Map<string, SetInfo>();
    for (const s of sets) {
      if (s?.code) setsByCode.set(String(s.code), s);
    }

    const archetypes = Array.from(
      new Set(sourceCards.map((c: any) => c?.archetype).filter(Boolean).map(String))
    ).sort((a, b) => a.localeCompare(b));

    const monsterTypes = Array.from(
      new Set(
        sourceCards.flatMap((c: any) => {
          const v = c?.monsterType ?? c?.race;
          if (Array.isArray(v)) return v.map(String);
          if (typeof v === "string") return [v];
          return [];
        })
      )
    ).sort((a, b) => a.localeCompare(b));

    return { setsByCode, setsList: sets, archetypes, monsterTypes };
  }, [sets, sourceCards]);

  return { cards, sets, indexes, query, loading: false, error: null };
}
