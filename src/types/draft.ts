import type { Card } from "./card";

export type DraftSource = "CCG" | "TCG";
export type DraftDeckSection = "main" | "extra" | "side";

export type DraftTags = {
  handTrap: boolean;
  boardBreaker: boolean;
  spellTrapNonEngine: boolean;
};

export type DraftPoolCard = Card & {
  source: DraftSource;
  isExtraDeck: boolean;
  draftTags: DraftTags;
  omegaId?: string | number | null;
};

export type DraftPick = {
  card: DraftPoolCard;
  section: DraftDeckSection;
  round: number;
  specialRound: boolean;
};

export type DraftOfferMeta = {
  pickNumber: number;
  section: DraftDeckSection;
  picksRemainingInSection: number;
  specialRound: boolean;
};

export type DraftSession = {
  picks: DraftPick[];
  offer: DraftPoolCard[];
  meta: DraftOfferMeta | null;
  completed: boolean;
};

export type DraftPoolMeta = {
  generatedAt: string;
  databaseVersion?: string;
  lastUpdate?: string;
  usingFallback: boolean;
  tcgCount: number;
  ccgCount: number;
};

export type DraftPoolSnapshot = {
  meta: DraftPoolMeta;
  cards: DraftPoolCard[];
};
