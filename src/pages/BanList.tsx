import PrintTitle from "../components/PrintTitle";
import { useMemo, useState } from "react";
import { cardGridColumns, GridViewSwitch, GridWidthSelect } from "../components/CardsToolbar";
import CardTile from "../components/CardTile";
import useRemoteJson from "../hooks/useRemoteJson";
import type { Card } from "../types/card";
import usePageMeta from "../hooks/usePageMeta";
import { banlistGroup, banlistComparator, orderBanlistCards } from "../utils/banlistOrder";
import tcgBaseline from "../data/tcg-banlist-baseline.json";
import banlistUpdate from "../data/banlist-update.json";

const statusLabels = ["Forbidden", "Limited", "Semi-Limited", "Unlimited"];

function typeClass(card: Card) {
  return `type-${banlistGroup(card).toLowerCase().replace(/[^a-z0-9]+/g, "-").replace(/^-|-$/g, "")}`;
}

const comparisonStatuses = ["banned", "limited", "semi", "unlimited"] as const;

function officialCardImage(passcode: Card["passcode"]) {
  return passcode ? `https://images.ygoprodeck.com/images/cards/${passcode}.jpg` : "";
}

function Section({ title, items, columns }: { title: string; items: Card[]; columns: string }) {
  const ordered = orderBanlistCards(items);
  return (
    <section className="space-y-3 tp-banlist-section">
      <h3 className="font-display text-3xl leading-none">
        {title} <span className="text-sm text-slate-500">({ordered.length})</span>
      </h3>
      <div className={`grid gap-4 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 ${cardGridColumns(columns)}`}>
        {ordered.map((c) => (
          <CardTile key={(c as any).id ?? c.name} card={c.image ? c : { ...c, image: officialCardImage(c.passcode) }} detailsEnabled={String(c.id).startsWith("CARD-")} />
        ))}
      </div>
    </section>
  );
}

export default function BanList() {
  usePageMeta("Ban List", "Browse the current forbidden, limited, and semi-limited CCG cards.");
  const { data: cards, loading, error } = useRemoteJson<Card[]>("data/banlist-cards.json");
  const { data: comparisonCards, loading: comparisonLoading, error: comparisonError } = useRemoteJson<Card[]>("data/tcg-comparison-cards.json");
  const [tab, setTab] = useState<"banlist" | "differences">("banlist");
  const [view, setView] = useState<"grid" | "list">("grid");
  const [columns, setColumns] = useState("6");
  const [search, setSearch] = useState("");
  const [direction, setDirection] = useState<"all" | "stricter" | "looser">("all");
  const [ccgStatus, setCcgStatus] = useState("all");
  const [comparisonSort, setComparisonSort] = useState("type");

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

  const statusLabel = (limit: number) => statusLabels[limit];
  const allDifferences = (comparisonCards ?? []).flatMap((card) => {
    const legal = card.legal;
    const ccg = legal?.banned ? 0 : legal?.limited ? 1 : legal?.semiLimited ? 2 : 3;
    const key = card.name.toUpperCase().replace(/[^A-Z0-9]/g, "");
    const tcg = (tcgBaseline.limits as Record<string, number>)[key] ?? 3;
    return ccg !== tcg ? [{ card, ccg, tcg }] : [];
  });

  const differences = allDifferences.filter(({ card, ccg, tcg }) =>
    matchesSearch(card) && (direction === "all" || (direction === "stricter" ? ccg < tcg : ccg > tcg)) &&
    (ccgStatus === "all" || ccg === Number(ccgStatus))
  ).sort((a, b) => {
    const byName = a.card.name.localeCompare(b.card.name);
    const byType = banlistComparator(a.card, b.card);
    return a.ccg - b.ccg || (comparisonSort === "name" ? byName
      : comparisonSort === "tcg" ? a.tcg - b.tcg || byType : byType);
  });
  const ccgCardsByPasscode = new Map((cards ?? []).map(card => [card.passcode, card]));
  const resetComparison = () => { setSearch(""); setDirection("all"); setCcgStatus("all"); };
  const badge = (limit: number) => (
    <span className={`inline-flex flex-wrap items-center gap-1 rounded-full border px-3 py-1 text-xs font-bold ${[
      "border-red-200 bg-red-50 text-red-800", "border-amber-200 bg-amber-50 text-amber-900",
      "border-blue-200 bg-blue-50 text-blue-800", "border-emerald-200 bg-emerald-50 text-emerald-800",
    ][limit]}`}>{statusLabel(limit)} <span className="font-normal">· {limit} {limit === 1 ? "copy" : "copies"}</span></span>
  );
  if (loading) return <div className="card">Loading ban list...</div>;
  if (error) return <div className="card text-red-700">Failed to load ban list.</div>;

  return (
    <div className="grid gap-4 tp-banlist-page">
      <section className="card anim-rise">
        <p className="text-[12px] font-bold uppercase tracking-[0.14em] text-slate-500">Format Rules</p>
        <PrintTitle as="h2" caption="FORMAT / RULES" className="font-display text-4xl leading-none">Ban List</PrintTitle>
        <p className="mt-2 text-sm text-slate-600">
          Effective {new Date(`${banlistUpdate.effectiveDate}T00:00:00Z`).toLocaleDateString("en-GB", { day: "numeric", month: "long", year: "numeric", timeZone: "UTC" })}
        </p>
        {tab === "banlist" && <p className="mt-2 text-sm text-slate-600">
          Forbidden: {bannedFiltered.length} | Limited: {limitedFiltered.length} | Semi-Limited: {semiFiltered.length}
        </p>}

        <div className="mt-4 flex flex-wrap gap-2" aria-label="Ban list sections">
          <button type="button" className={`btn ${tab === "banlist" ? "btn-primary" : ""}`} aria-pressed={tab === "banlist"} onClick={() => setTab("banlist")}>Ban List</button>
          <button type="button" className={`btn ${tab === "differences" ? "btn-primary" : ""}`} aria-pressed={tab === "differences"} onClick={() => setTab("differences")}>Differences to TCG</button>
        </div>
      </section>

      <div className="filters-shell flex flex-wrap items-center gap-3">
        <input
          type="search"
          aria-label="Search cards by name or type"
          placeholder="Search cards by name or type..."
          value={search}
          onChange={(e) => setSearch(e.target.value)}
          className="min-w-[min(100%,16rem)] flex-1 rounded-lg border border-slate-300 bg-white px-3 py-2 text-sm text-slate-700"
        />
        <GridViewSwitch view={view} setView={setView} />
        {tab === "banlist" && view === "grid" && <GridWidthSelect columns={columns} onChange={setColumns} />}
      </div>

      {tab === "differences" ? (
        <section className="card space-y-4">
          <div className="flex flex-wrap items-start justify-between gap-3">
            <div>
              <p className="text-xs font-bold uppercase tracking-widest text-slate-500">CCG / TCG comparison</p>
              <h3 className="font-display text-3xl">What changes when you play CCG?</h3>
            </div>
            <a className="btn text-sm" href={tcgBaseline.sourceUrl} target="_blank" rel="noreferrer">View Konami list ↗</a>
          </div>
          <p className="max-w-3xl text-sm text-slate-600">Compare the CCG list with the TCG snapshot effective {new Date(`${tcgBaseline.effectiveDate}T00:00:00Z`).toLocaleDateString("en-GB", { day: "numeric", month: "long", year: "numeric", timeZone: "UTC" })}. Only official cards with different copy limits appear here. Custom CCG cards are excluded.</p>
          {comparisonLoading ? <p role="status">Loading comparison...</p> : comparisonError ? <p role="alert">Failed to load comparison. Please refresh to try again.</p> : (<>
            <div className="flex flex-wrap items-end gap-3">
              <label className="grid gap-1 text-xs font-bold text-slate-600">Restriction
                <select value={direction} onChange={e => setDirection(e.target.value as typeof direction)} className="rounded-lg border border-slate-300 bg-white p-2 text-sm text-slate-800">
                  <option value="all">All differences</option>
                  <option value="stricter">Stricter in CCG</option>
                  <option value="looser">More freedom in CCG</option>
                </select>
              </label>
              <label className="grid gap-1 text-xs font-bold text-slate-600">CCG status
                <select value={ccgStatus} onChange={e => setCcgStatus(e.target.value)} className="rounded-lg border border-slate-300 bg-white p-2 text-sm text-slate-800">
                  <option value="all">All statuses</option>{[0, 1, 2, 3].map(n => <option key={n} value={n}>{statusLabel(n)}</option>)}
                </select>
              </label>
              <label className="grid gap-1 text-xs font-bold text-slate-600">Sort within groups
                <select value={comparisonSort} onChange={e => setComparisonSort(e.target.value)} className="rounded-lg border border-slate-300 bg-white p-2 text-sm text-slate-800">
                  <option value="type">Card type</option><option value="name">Card name A–Z</option><option value="tcg">TCG copy limit</option>
                </select>
              </label>
              <button type="button" className="btn text-sm" onClick={resetComparison}>Clear filters</button>
            </div>
            {differences.length ? statusLabels.map((status, limit) => {
              const group = differences.filter(({ ccg }) => ccg === limit);
              if (!group.length) return null;
              return (
                <section key={status} className="space-y-3 tp-banlist-section">
                  <h3 className="font-display text-3xl leading-none">{limit === 0 ? "Banned" : status}</h3>
                  {view === "grid" ? (
                    <div className="grid gap-4 sm:grid-cols-2 xl:grid-cols-3">
                      {group.map(({ card, ccg, tcg }) => {
                        const ccgCard = ccgCardsByPasscode.get(card.passcode);
                        const tcgImage = officialCardImage(card.passcode);
                        return (
                          <article key={card.passcode} className="tp-comparison-pair border p-3">
                            <h4 className="tp-comparison-name mb-3">{card.name}</h4>
                            <div className="grid grid-cols-2 gap-3">
                              {([
                                ["CCG", ccg, ccgCard?.image || tcgImage],
                                ["TCG", tcg, tcgImage],
                              ] as const).map(([format, copies, image]) => (
                                <div key={format} className="tp-comparison-panel flex min-w-0 flex-col border">
                                  <p className="tp-comparison-format border-b px-2 py-2 text-center font-mono text-xs tracking-widest">
                                    {format}
                                  </p>
                                  <div className="px-3 pt-4"><CardTile card={{ ...card, image }} imageOnly statusOverride={comparisonStatuses[copies]} /></div>
                                </div>
                              ))}
                            </div>
                          </article>
                        );
                      })}
                    </div>
                  ) : (
                    <div className="banlist-table" role="table" aria-label={`${status} CCG and TCG comparison`}>
                      <div className="banlist-header !grid-cols-[minmax(0,2fr)_repeat(2,minmax(0,1fr))]" role="row">
                        <span role="columnheader">Card</span>
                        <span role="columnheader">CCG</span>
                        <span role="columnheader">TCG</span>
                      </div>
                      {group.map(({ card, ccg, tcg }) => (
                        <div key={card.passcode} className={`banlist-row ${typeClass(card)} !grid-cols-[minmax(0,2fr)_repeat(2,minmax(0,1fr))] items-center`} role="row">
                          <span className="break-words" role="cell">{card.name}<small className="block">{banlistGroup(card)}</small></span>
                          <span role="cell">{badge(ccg)}</span>
                          <span role="cell">{badge(tcg)}</span>
                        </div>
                      ))}
                    </div>
                  )}
                </section>
              );
            }) : <div className="rounded-xl border border-dashed border-slate-300 p-8 text-center"><p className="font-semibold">No matching differences</p><p className="mt-1 text-sm text-slate-600">Try another card name or clear your filters.</p><button type="button" className="btn mt-4" onClick={resetComparison}>Show all differences</button></div>}
          </>)}
        </section>
      ) : view === "grid" ? (
        bannedFiltered.length || limitedFiltered.length || semiFiltered.length ? (
          <div className="grid gap-6">
            <Section columns={columns} title="Banned" items={bannedFiltered as Card[]} />
            <Section columns={columns} title="Limited" items={limitedFiltered as Card[]} />
            <Section columns={columns} title="Semi-Limited" items={semiFiltered as Card[]} />
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
                    .toLowerCase()} ${typeClass(card)}`}
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
