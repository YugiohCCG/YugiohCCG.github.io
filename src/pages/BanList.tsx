import { useMemo, useState } from "react";
import CardTile from "../components/CardTile";
import useBanlistCards from "../hooks/useBanlistCards";
import useCards from "../hooks/useCards";
import type { Card } from "../types/card";

const BANLIST_GROUP_ORDER = [
  "Monster",
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

function banlistGroup(card: Card): string {
  const category = String((card as any).category ?? (card as any).frameType ?? "").toLowerCase();
  const typeStr: string = String((card as any).type ?? "").toLowerCase();
  const cardTypes: string[] = Array.isArray((card as any).cardTypes)
    ? (card as any).cardTypes.map((t: any) => String(t).toLowerCase())
    : typeStr
      ? typeStr.split(/[\/ ]+/)
      : [];

  const has = (k: string) => typeStr.includes(k) || cardTypes.some((t) => t.includes(k));

  if (category === "spell") return "Spell";
  if (category === "trap") return "Trap";

  if (has("fusion")) return "Monster/Fusion";
  if (has("link")) return "Monster/Link";
  if (has("ritual")) return "Monster/Ritual";
  if (has("synchro")) return "Monster/Synchro";
  if (has("xyz")) return "Monster/Xyz";
  if (has("effect")) return "Monster/Effect";

  return "Monster";
}

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
  const ordered = items.slice().sort(banlistComparator);
  return (
    <section className="space-y-3">
      <h3 className="font-display text-3xl leading-none">
        {title} <span className="text-sm text-slate-500">({ordered.length})</span>
      </h3>
      <div className="grid gap-4 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">
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
  const [search, setSearch] = useState("");

  const withL = withLegal(cards);

  const banned = withL.filter((c: any) => c.legal?.banned);
  const limited = withL.filter((c: any) => c.legal?.limited && !c.legal?.banned);
  const semi = withL.filter(
    (c: any) => c.legal?.semiLimited && !c.legal?.limited && !c.legal?.banned
  );

  const searchTerm = search.trim().toLowerCase();
  const matchesSearch = (card: Card) => {
    if (!searchTerm) return true;
    const hay = `${String(card.name ?? "").toLowerCase()} ${banlistGroup(card).toLowerCase()}`;
    return hay.includes(searchTerm);
  };

  const bannedFiltered = banned.filter((c) => matchesSearch(c as Card));
  const limitedFiltered = limited.filter((c) => matchesSearch(c as Card));
  const semiFiltered = semi.filter((c) => matchesSearch(c as Card));

  const flatList = useMemo(() => {
    const add = (arr: Card[], status: "Forbidden" | "Limited" | "Semi-Limited") =>
      arr.map((c) => ({ card: c, status }));

    const rows = [
      ...add(bannedFiltered as Card[], "Forbidden"),
      ...add(limitedFiltered as Card[], "Limited"),
      ...add(semiFiltered as Card[], "Semi-Limited"),
    ];

    const statusOrder: Record<string, number> = { Forbidden: 0, Limited: 1, "Semi-Limited": 2 };

    return rows.sort((a, b) => {
      const sa = statusOrder[a.status] ?? 99;
      const sb = statusOrder[b.status] ?? 99;
      if (sa !== sb) return sa - sb;
      return banlistComparator(a.card, b.card);
    });
  }, [bannedFiltered, limitedFiltered, semiFiltered]);

  if (loadingCards || loadingBan) return <div className="card">Loading ban list...</div>;
  if (errorCards || errorBan) return <div className="card text-red-700">Failed to load ban list.</div>;

  return (
    <div className="grid gap-4">
      <section className="card anim-rise">
        <p className="text-[12px] font-bold uppercase tracking-[0.14em] text-slate-500">Format Rules</p>
        <h2 className="font-display text-4xl leading-none">Ban List</h2>
        <p className="mt-2 text-sm text-slate-600">
          Forbidden: {bannedFiltered.length} | Limited: {limitedFiltered.length} | Semi-Limited: {semiFiltered.length}
        </p>

        <div className="mt-4 flex flex-wrap items-center gap-2">
          <input
            type="search"
            placeholder="Search ban list by card name or type..."
            value={search}
            onChange={(e) => setSearch(e.target.value)}
            className="min-w-[16rem] flex-1 rounded-lg border border-slate-300 bg-white px-3 py-2 text-sm text-slate-700"
          />
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
      </section>

      {view === "grid" ? (
        bannedFiltered.length || limitedFiltered.length || semiFiltered.length ? (
          <div className="grid gap-6">
            <Section title="Banned" items={bannedFiltered as Card[]} />
            <Section title="Limited" items={limitedFiltered as Card[]} />
            <Section title="Semi-Limited" items={semiFiltered as Card[]} />
          </div>
        ) : (
          <div className="card text-sm text-slate-600">No ban list cards match your search.</div>
        )
      ) : (
        <div className="card">
          <div className="banlist-table">
            <div className="banlist-header">
              <span>Type</span>
              <span>Name</span>
              <span>Status</span>
            </div>
            {flatList.length > 0 ? (
              flatList.map(({ card, status }) => (
                <div
                  key={String((card as any).id ?? card.name) + status}
                  className={`banlist-row status-${status
                    .replace(/[^a-z0-9]+/gi, "")
                    .toLowerCase()} type-${banlistGroup(card)
                    .toLowerCase()
                    .replace(/[^a-z0-9]+/g, "-")
                    .replace(/^-|-$/g, "")}`}
                >
                  <span className="truncate">{banlistGroup(card)}</span>
                  <span className="truncate">{String(card.name ?? "")}</span>
                  <span className="font-semibold">{status}</span>
                </div>
              ))
            ) : (
              <div className="rounded-lg border border-slate-300 bg-white px-3 py-2 text-sm text-slate-600">
                No ban list cards match your search.
              </div>
            )}
          </div>
        </div>
      )}
    </div>
  );
}
