import { useEffect, useMemo, useState } from "react";
import type { Card } from "../types/card";
import type { DraftPoolSnapshot } from "../types/draft";
import { buildFallbackDraftSnapshot, hydrateDraftPoolCard } from "../utils/draft";
import { asset } from "../utils/assets";
import customCards from "../data/cards.json";
import tcgCards from "../data/tcg-cards.json";

type UseDraftPoolResult = {
  loading: boolean;
  snapshot: DraftPoolSnapshot;
  error: string | null;
};

const fallbackSnapshot = buildFallbackDraftSnapshot(
  customCards as Card[],
  tcgCards as Card[]
);
const fallbackCcgCards = fallbackSnapshot.cards.filter((card) => card.source === "CCG");

export default function useDraftPool(): UseDraftPoolResult {
  const [remoteSnapshot, setRemoteSnapshot] = useState<DraftPoolSnapshot | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    let active = true;

    async function load() {
      try {
        const response = await fetch(asset("data/ygo-draft-pool.json"), {
          cache: "no-store",
        });
        if (!response.ok) {
          throw new Error(`Draft pool fetch failed with ${response.status}`);
        }
        const parsed = (await response.json()) as DraftPoolSnapshot;
        if (!active) return;
        const hydratedCards = parsed.cards.map(hydrateDraftPoolCard);
        setRemoteSnapshot({
          meta: {
            ...parsed.meta,
            ccgCount: fallbackCcgCards.length,
            tcgCount: hydratedCards.length,
            usingFallback: false,
          },
          cards: [...fallbackCcgCards, ...hydratedCards],
        });
      } catch (err) {
        if (!active) return;
        setError(err instanceof Error ? err.message : "Unable to load full draft pool");
      } finally {
        if (active) setLoading(false);
      }
    }

    void load();
    return () => {
      active = false;
    };
  }, []);

  const snapshot = useMemo(() => remoteSnapshot ?? fallbackSnapshot, [remoteSnapshot]);

  return { loading, snapshot, error };
}
