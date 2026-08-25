export type DeckSection = "main" | "extra" | "side";
export type DeckState = Record<DeckSection, number[]>;

export function serializeOmegaDeck(deck: DeckState): string {
  return [
    "#created by Yu-Gi-Oh! CCG Deck Builder",
    "#main",
    ...deck.main,
    "#extra",
    ...deck.extra,
    "!side",
    ...deck.side,
    "",
  ].join("\n");
}
