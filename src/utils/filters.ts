// src/utils/filters.ts
import type { Card } from "../types/card";

export type Query = {
  q?: string;
  set?: string | string[];

  archetype?: string | string[];
  category?: ("Monster" | "Spell" | "Trap") | "";
  icon?: string[];
  attribute?: string[];

  monsterType?: string[];
  cardTypes?: string[];

  // ranges (legacy)
  levelMin?: number; levelMax?: number;
  rankMin?: number;  rankMax?: number;
  scaleMin?: number; scaleMax?: number;
  linkMin?: number;  linkMax?: number;

  // exact lists (preferred when present)
  levelIn?: number[];
  rankIn?: number[];
  scaleIn?: number[];
  linkIn?: number[];

  atkMin?: number; atkMax?: number;
  defMin?: number; defMax?: number;

  legal?: string[];
  linkArrows?: string[];

  dateStart?: string;
  dateEnd?: string;

  sort?: string;
  view?: "grid" | "list";
};

// ---- helpers ----
const up = (s?: string | null) => (s ?? "").toString().trim().toUpperCase();

const asStr = (c: any, keys: string[]): string | undefined => {
  for (const k of keys) {
    const v = c?.[k];
    if (v != null) return String(v);
  }
  return undefined;
};
const asNum = (c: any, keys: string[]): number | undefined => {
  for (const k of keys) {
    const v = c?.[k];
    if (typeof v === "number") return v;
    if (v != null && !isNaN(Number(v))) return Number(v);
  }
  return undefined;
};
const asStrList = (c: any, keys: string[]): string[] => {
  for (const k of keys) {
    const v = c?.[k];
    if (Array.isArray(v)) return v.map(String);
    if (typeof v === "string" && v) {
      return v.split(/[\/ ]+/).filter(Boolean).map(String);
    }
  }
  return [];
};

const hasAny = (hay: string[] = [], needles: string[] = []) => {
  if (!needles.length) return true;
  const H = new Set(hay.map(up));
  return needles.some((n) => H.has(up(n)));
};

const isOneOf = (n: number | undefined | null, list?: number[]) => {
  if (!list || !list.length) return true;
  if (n == null) return false;
  return new Set(list).has(n);
};
const inRange = (n: number | undefined | null, lo?: number, hi?: number) => {
  if (lo == null && hi == null) return true;
  if (n == null) return false;
  if (lo != null && n < lo) return false;
  if (hi != null && n > hi) return false;
  return true;
};

const setCodeFrom = (val: unknown): string | null => {
  if (!val) return null;
  const s = String(val).toUpperCase().trim();
  if (/^[A-Z]{3,6}$/.test(s)) return s;
  const m = s.split(/\s+/)[0].match(/^([A-Z]{3,6})/);
  return m ? m[1] : null;
};
const setMatches = (cardSet: unknown, wanted?: string | string[]) => {
  const list = Array.isArray(wanted) ? wanted : wanted ? [wanted] : [];
  if (!list.length) return true;
  const code = setCodeFrom(cardSet);
  return !!code && list.map(up).includes(up(code));
};

const dateInRange = (iso?: string, start?: string, end?: string) => {
  if (!start && !end) return true;
  if (!iso) return false;
  const d = iso.slice(0, 10);
  if (start && d < start) return false;
  if (end && d > end) return false;
  return true;
};

// ---- predicate ----
export function cardMatches(card: Card, q: Query): boolean {
  const C: any = card;
  const baseCategory = asStr(C, ["category", "frameType"]);
  const isMonster = up(baseCategory) === "MONSTER";

  // text term
  if (q.q) {
    const term = q.q.toLowerCase();
    const hay = `${card.name ?? ""} ${(C.text ?? C.desc ?? "")}`.toLowerCase();
    if (!hay.includes(term)) return false;
  }

  // set
  if (!setMatches(C.set, q.set)) return false;

  // archetype
  if (q.archetype) {
    const arch = asStr(C, ["archetype"]);
    const want = Array.isArray(q.archetype) ? q.archetype[0] : q.archetype;
    if (up(arch) !== up(want)) return false;
  }

  // category (Monster/Spell/Trap)
  if (q.category) {
    if (up(baseCategory) !== up(q.category)) return false;
  }

  // icon
  if (q.icon?.length) {
    const icons = asStrList(C, ["icon", "spellType", "trapType"]);
    if (!hasAny(icons, q.icon)) return false;
  }

  // attribute
  if (q.attribute?.length) {
    const attr = asStr(C, ["attribute"]);
    if (!q.attribute.map(up).includes(up(attr))) return false;
  }

  // monster type (race) – only applies to Monster cards
  if (q.monsterType?.length) {
    if (!isMonster) return false;
    const species = asStrList(C, ["monsterType", "race"]);
    if (!hasAny(species, q.monsterType)) return false;
  }

  // card type(s)
  if (q.cardTypes?.length) {
    // If any requested type is a monster-only subtype, require Monster category
    const monsterOnly = new Set([
      "EFFECT","RITUAL","FUSION","SYNCHRO","XYZ","PENDULUM","LINK",
      "TOON","SPIRIT","UNION","GEMINI","TUNER","FLIP",
    ]);
    const wantsMonsterSubtype = q.cardTypes.some((t) => monsterOnly.has(up(t)));
    if (wantsMonsterSubtype && !isMonster) return false;

    const kinds = asStrList(C, ["cardTypes", "type"]);
    if (!hasAny(kinds, q.cardTypes)) return false;
  }

  // legality (banned/limited/semi/Legal)
  if (q.legal?.length) {
    const l = (C.legal || {}) as any;
    const match = (s: string) => {
      const v = up(s);
      if (v === "BANNED" || v === "FORBIDDEN") return !!l.banned;
      if (v === "LIMITED" || v === "LIMIT") return !!l.limited;
      if (v === "SEMI" || v === "SEMILIMITED" || v === "SEMI-LIMITED") return !!l.semiLimited;
      if (v === "LEGAL" || v === "UNLIMITED") return !l.banned && !l.limited && !l.semiLimited;
      return false;
    };
    if (!q.legal.some(match)) return false;
  }

  // numeric categories (exclusionary with the rest)
  const level = asNum(C, ["level"]);
  const rank  = asNum(C, ["rank"]);
  const link  = asNum(C, ["linkRating", "link", "linkval"]);
  const scale = asNum(C, ["scale", "pendulumScale"]);

  if (q.levelIn?.length) { if (!isOneOf(level, q.levelIn)) return false; }
  else if (q.levelMin != null || q.levelMax != null) {
    if (!inRange(level, q.levelMin, q.levelMax)) return false;
  }

  if (q.rankIn?.length) { if (!isOneOf(rank, q.rankIn)) return false; }
  else if (q.rankMin != null || q.rankMax != null) {
    if (!inRange(rank, q.rankMin, q.rankMax)) return false;
  }

  if (q.linkIn?.length) { if (!isOneOf(link, q.linkIn)) return false; }
  else if (q.linkMin != null || q.linkMax != null) {
    if (!inRange(link, q.linkMin, q.linkMax)) return false;
  }

  if (q.scaleIn?.length) { if (!isOneOf(scale, q.scaleIn)) return false; }
  else if (q.scaleMin != null || q.scaleMax != null) {
    if (!inRange(scale, q.scaleMin, q.scaleMax)) return false;
  }

  // ATK/DEF
  const atk = asNum(C, ["atk"]);
  const def = asNum(C, ["def"]);
  if (!inRange(atk, q.atkMin, q.atkMax)) return false;
  if (!inRange(def, q.defMin, q.defMax)) return false;

  // link arrows (AND)
  if (q.linkArrows?.length) {
    const have = new Set(asStrList(C, ["linkArrows"]).map((x) => x.toUpperCase()));
    for (const a of q.linkArrows.map((x) => x.toUpperCase())) {
      if (!have.has(a)) return false;
    }
  }

  // date
  const added = asStr(C, ["timestamps?.added", "timestamps", "added"]);
  if (!dateInRange(added, q.dateStart, q.dateEnd)) return false;

  return true;
}

// ---- sorting (exported for Cards.tsx) ----
export type SortKey = "name" | "atk" | "def" | "level" | "rank" | "link" | "date";
export type SortDir = "asc" | "desc";

export function sortCards(items: Card[], key: SortKey, dir: SortDir): Card[] {
  const mul = dir === "desc" ? -1 : 1;
  const cmp = <T>(a: T, b: T) => (a === b ? 0 : a > b ? 1 : -1);
  const by = <T>(sel: (c: Card) => T) =>
    [...items].sort((a, b) => {
      const va = sel(a) as any, vb = sel(b) as any;
      const na = va == null, nb = vb == null;
      if (na && nb) return 0;
      if (na) return 1;
      if (nb) return -1;
      return mul * cmp(va, vb);
    });

  switch (key) {
    case "atk":   return by((c: any) => c.atk ?? null);
    case "def":   return by((c: any) => c.def ?? null);
    case "level": return by((c: any) => c.level ?? null);
    case "rank":  return by((c: any) => c.rank ?? null);
    case "link":  return by((c: any) => (c.linkRating ?? c.link ?? c.linkval ?? null));
    case "date":  return by((c: any) => (c.timestamps?.added ?? ""));
    case "name":
    default:      return by((c: any) => (c.name || "").toLowerCase());
  }
}
