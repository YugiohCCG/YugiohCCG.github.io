import type { Card } from "../types/card";

export const BANLIST_TYPE_ORDER = [
  "Monster/Normal",
  "Monster/Effect",
  "Monster/Ritual",
  "Monster/Fusion",
  "Monster/Synchro",
  "Monster/Xyz",
  "Monster/Pendulum",
  "Monster/Link",
  "Spell",
  "Trap",
] as const;

const TYPE_WEIGHT = new Map<string, number>(BANLIST_TYPE_ORDER.map((type, index) => [type, index]));

export function banlistGroup(card: Card): string {
  const category = String(card.category ?? "").toLowerCase();
  const types = (card.cardTypes ?? []).map((type) => String(type).toLowerCase());
  const has = (type: string) => types.some((value) => value.includes(type));

  if (category === "spell") return "Spell";
  if (category === "trap") return "Trap";

  // Specific summon/frame types must win over the generic Effect subtype.
  if (has("ritual")) return "Monster/Ritual";
  if (has("fusion")) return "Monster/Fusion";
  if (has("synchro")) return "Monster/Synchro";
  if (has("xyz")) return "Monster/Xyz";
  if (has("link")) return "Monster/Link";
  if (has("pendulum")) return "Monster/Pendulum";
  if (has("normal")) return "Monster/Normal";
  return "Monster/Effect";
}

export function banlistComparator(a: Card, b: Card): number {
  const typeDifference = (TYPE_WEIGHT.get(banlistGroup(a)) ?? 99) - (TYPE_WEIGHT.get(banlistGroup(b)) ?? 99);
  if (typeDifference !== 0) return typeDifference;
  return a.name.localeCompare(b.name, undefined, { sensitivity: "base" });
}

export function orderBanlistCards(cards: Card[]): Card[] {
  return [...cards].sort(banlistComparator);
}
