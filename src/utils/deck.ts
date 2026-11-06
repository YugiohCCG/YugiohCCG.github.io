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

export function serializeXmlDeck(deck: DeckState, cardName: (id: number) => string | undefined): string {
  const escape = (value: string) => value.replace(/&/g, "&amp;").replace(/</g, "&lt;")
    .replace(/>/g, "&gt;").replace(/"/g, "&quot;").replace(/'/g, "&apos;");
  const sections: DeckSection[] = ["main", "extra", "side"];
  return [
    '<?xml version="1.0" encoding="UTF-8"?>',
    '<deck name="CCG Deck">',
    ...sections.flatMap(section => {
      const counts = new Map<number, number>();
      for (const id of deck[section]) counts.set(id, (counts.get(id) ?? 0) + 1);
      return [
        `  <${section}>`,
        ...Array.from(counts, ([id, count]) => {
          const name = cardName(id);
          return `    <card id="${id}" count="${count}"${name ? ` name="${escape(name)}"` : ""} />`;
        }),
        `  </${section}>`,
      ];
    }),
    "</deck>",
    "",
  ].join("\n");
}
