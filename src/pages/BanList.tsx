import { useMemo, useState } from "react";
import CardTile from "../components/CardTile";
import useRemoteJson from "../hooks/useRemoteJson";
import type { Card } from "../types/card";
import usePageMeta from "../hooks/usePageMeta";
import { banlistGroup, banlistComparator, orderBanlistCards } from "../utils/banlistOrder";

function Section({ title, items }: { title: string; items: Card[] }) {
  const ordered = orderBanlistCards(items);
  return (
    <section className="space-y-3">
      <h3 className="font-display text-3xl leading-none">
        {title} <span className="text-sm text-slate-500">({ordered.length})</span>
      </h3>
      <div className="grid gap-4 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">
        {ordered.map((c) => (
          <CardTile key={(c as any).id ?? c.name} card={c} detailsEnabled={String(c.id).startsWith("CARD-")} />
        ))}
      </div>
    </section>
  );
}

export default function BanList() {
  usePageMeta("Ban List", "Browse the current forbidden, limited, and semi-limited CCG cards.");
  const { data: cards, loading, error } = useRemoteJson<Card[]>("data/banlist-cards.json");
  const [view, setView] = useState<"grid" | "list">("grid");
  const [search, setSearch] = useState("");

  const banned = (cards ?? []).filter((c: any) => c.legal?.banned);
  const limited = (cards ?? []).filter((c: any) => c.legal?.limited && !c.legal?.banned);
  const semi = (cards ?? []).filter(
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
      const statusDifference = statusOrder[a.status] - statusOrder[b.status];
      return statusDifference || banlistComparator(a.card, b.card);
    });
  }, [bannedFiltered, limitedFiltered, semiFiltered]);

  if (loading) return <div className="card">Loading ban list...</div>;
  if (error) return <div className="card text-red-700">Failed to load ban list.</div>;

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
            aria-pressed={view === "grid"}
          >
            Grid View
          </button>
          <button
            type="button"
            className={`btn ${view === "list" ? "btn-primary" : ""}`}
            onClick={() => setView("list")}
            aria-pressed={view === "list"}
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
          <div className="banlist-table" role="table" aria-label="CCG ban list">
            <div className="banlist-header" role="row">
              <span role="columnheader">Type</span>
              <span role="columnheader">Name</span>
              <span role="columnheader">Status</span>
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
                  role="row"
                >
                  <span className="truncate" role="cell">{banlistGroup(card)}</span>
                  <span className="truncate" role="cell">{String(card.name ?? "")}</span>
                  <span className="font-semibold" role="cell">{status}</span>
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
