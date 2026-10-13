import type { Card } from "../types/card";
import classification from "../data/archetype-classification.json";
import archetypeCatalog from "../data/archetype-catalog.json";

export type ArchetypeCatalogEntry = {
  name: string;
  cardIds: number[];
  iconCardId: number;
  iconName: string;
  iconImage: string;
};

export const standaloneLabels = new Set(classification.filter((record) => record.kind === "standalone").map((record) => record.family));
export const consolidatedArchetypes = (archetypeCatalog as ArchetypeCatalogEntry[]).filter((group) => !standaloneLabels.has(group.name));

const membershipsByPasscode = new Map<number, string[]>();
for (const group of consolidatedArchetypes) {
  for (const passcode of group.cardIds) {
    membershipsByPasscode.set(passcode, [...(membershipsByPasscode.get(passcode) ?? []), group.name]);
  }
}

export function cardMemberships(card: Card): string[] {
  if (card.passcode == null) return [];
  return membershipsByPasscode.get(card.passcode) ?? [];
}

export function isExtraDeckCard(card: Card): boolean {
  return (card.cardTypes ?? []).some((type) => ["Fusion", "Synchro", "Xyz", "Link"].includes(type));
}
