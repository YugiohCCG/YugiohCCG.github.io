// src/pages/BanList.tsx
import useBanlistCards from "../hooks/useBanlistCards";
import useCards from "../hooks/useCards";
import CardTile from "../components/CardTile";
import type { Card } from "../types/card";
import { useMemo, useState } from "react";

/** Final display order for Banlist groups */
const BANLIST_GROUP_ORDER = [
  "Monster/Effect",
  "Monster/Fusion",
  "Monster/Link",
  "Monster/Ritual",
  "Monster/Synchro",
  "Monster/Xyz",
  "Spell",
  "Trap",
] as const;

const GROUP_WEIGHT: Record<string, number> = Object.fromEntries(
  BANLIST_GROUP_ORDER.map((g, i) => [g, i])
);

/** Group resolver with correct precedence:
 *  - Specific extra types FIRST (fusion/link/ritual/synchro/xyz)
 *  - Generic "effect" LAST among monsters
 *  - Then Spell/Trap
 */
function banlistGroup(card: Card): string {
  const category = String((card as any).category ?? (card as any).frameType ?? "").toLowerCase();
  const typeStr: string = String((card as any).type ?? "").toLowerCase();
  const cardTypes: string[] = Array.isArray((card as any).cardTypes)
    ? (card as any).cardTypes.map((t: any) => String(t).toLowerCase())
    : typeStr
    ? typeStr.split(/[\/ ]+/)
    : [];

  const has = (k: string) =>
    typeStr.includes(k) || cardTypes.some((t) => t.includes(k));

  if (category === "spell") return "Spell";
  if (category === "trap") return "Trap";

  // Monster buckets — specific types first, then generic Effect
  if (has("fusion"))  return "Monster/Fusion";
  if (has("link"))    return "Monster/Link";
  if (has("ritual"))  return "Monster/Ritual";
  if (has("synchro")) return "Monster/Synchro";
  if (has("xyz"))     return "Monster/Xyz";
  if (has("effect"))  return "Monster/Effect";

  // Not in your requested buckets (e.g., Normal, Pendulum-only, Token)
  // Push these after your groups (won’t show before Spell/Trap).
  return "zzz__Other";
}

/** Strict comparator: group order above, then alphabetical by name */
function banlistComparator(a: Card, b: Card): number {
  const ga = banlistGroup(a);
  const gb = banlistGroup(b);
  const wa = GROUP_WEIGHT[ga] ?? Number.MAX_SAFE_INTEGER;
  const wb = GROUP_WEIGHT[gb] ?? Number.MAX_SAFE_INTEGER;
  if (wa !== wb) return wa - wb;
  const an = String(a.name ?? "").toLowerCase();
  const bn = String(b.name ?? "").toLowerCase();
  return an.localeCompare(bn);
}

function Section({ title, items }: { title: string; items: Card[] }) {
  // Apply ONLY this sort right before render — avoids any “date” or upstream order effects.
  const ordered = items.slice().sort(banlistComparator);
  return (
    <section className="mb-8">
      <h2 className="text-xl font-semibold mb-3">
        {title} <span className="text-sm text-neutral-400">({ordered.length})</span>
      </h2>
      <div className="grid sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-4">
        {ordered.map((c) => (
          <CardTile key={(c as any).id ?? c.name} card={c} />
        ))}
      </div>
    </section>
  );
}

export default function BanList() {
  const { cards, loading: loadingCards, error: errorCards } = useCards();
  const { withLegal, loading: loadingBan, error: errorBan } = useBanlistCards("TCG");
  const [view, setView] = useState<"grid" | "list">("grid");

  if (loadingCards || loadingBan) return <div>Loading…</div>;
  if (errorCards || errorBan) return <div className="text-red-500">Failed to load ban list.</div>;

  const withL = withLegal(cards);

  const banned = withL.filter((c: any) => c.legal?.banned);
  const limited = withL.filter((c: any) => c.legal?.limited && !c.legal?.banned);
  const semi = withL.filter(
    (c: any) => c.legal?.semiLimited && !c.legal?.limited && !c.legal?.banned
  );

  const flatList = useMemo(() => {
    const add = (arr: Card[], status: "Forbidden" | "Limited" | "Semi-Limited") =>
      arr.map((c) => ({ card: c, status }));
    const rows = [
      ...add(banned as Card[], "Forbidden"),
      ...add(limited as Card[], "Limited"),
      ...add(semi as Card[], "Semi-Limited"),
    ];
    const statusOrder: Record<string, number> = { Forbidden: 0, Limited: 1, "Semi-Limited": 2 };
    return rows.sort((a, b) => {
      const sa = statusOrder[a.status] ?? 99;
      const sb = statusOrder[b.status] ?? 99;
      if (sa !== sb) return sa - sb;
      return banlistComparator(a.card, b.card);
    });
  }, [banned, limited, semi]);

  return (
    <div className="grid gap-4">
      <div className="flex gap-2">
        <button
          type="button"
          className={`btn ${view === "grid" ? "btn-primary" : ""}`}
          onClick={() => setView("grid")}
        >
          Grid View
        </button>
        <button
          type="button"
          className={`btn ${view === "list" ? "btn-primary" : ""}`}
          onClick={() => setView("list")}
        >
          List View
        </button>
      </div>

      {view === "grid" ? (
        <div className="grid gap-6">
          <Section title="Banned" items={banned as Card[]} />
          <Section title="Limited" items={limited as Card[]} />
          <Section title="Semi-Limited" items={semi as Card[]} />
        </div>
      ) : (
        <div className="banlist-table">
          <div className="banlist-header">
            <span>Type</span>
            <span>Name</span>
            <span>Status</span>
          </div>
          {flatList.map(({ card, status }) => (
            <div
              key={String((card as any).id ?? card.name) + status}
              className={`banlist-row status-${status.replace(/[^a-z0-9]+/gi, "").toLowerCase()} type-${banlistGroup(card)
                .toLowerCase()
                .replace(/[^a-z0-9]+/g, "-")
                .replace(/^-|-$/g, "")}`}
            >
              <span className="truncate">{banlistGroup(card)}</span>
              <span className="truncate">{card.name}</span>
              <span className="font-semibold">{status}</span>
            </div>
          ))}
        </div>
      )}
    </div>
  );
}
