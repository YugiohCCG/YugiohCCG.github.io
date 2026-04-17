import { useMemo, useState } from "react";
import CardTile from "../components/CardTile";
import useDraftPool from "../hooks/useDraftPool";
import type { DraftDeckSection, DraftPoolCard, DraftSession } from "../types/draft";
import {
  DRAFT_TARGETS,
  OFFER_SIZE,
  TOTAL_DRAFT_PICKS,
  applyDraftPick,
  createDraftSession,
  downloadDecklist,
  summarizeDraftSections,
} from "../utils/draft";

const SECTION_LABEL: Record<DraftDeckSection, string> = {
  main: "Main Deck",
  extra: "Extra Deck",
  side: "Side Deck",
};

function sourceTone(source: DraftPoolCard["source"]) {
  return source === "CCG"
    ? "border border-orange-300/80 bg-orange-100 text-orange-800"
    : "border border-blue-300/80 bg-blue-100 text-blue-800";
}

function sectionTone(section: DraftDeckSection) {
  switch (section) {
    case "extra":
      return "border border-sky-300/80 bg-sky-100 text-sky-900";
    case "side":
      return "border border-emerald-300/80 bg-emerald-100 text-emerald-900";
    case "main":
    default:
      return "border border-violet-300/80 bg-violet-100 text-violet-900";
  }
}

function sectionSurface(section: DraftDeckSection) {
  switch (section) {
    case "extra":
      return "draft-surface-extra";
    case "side":
      return "draft-surface-side";
    case "main":
    default:
      return "draft-surface-main";
  }
}

export default function Draft() {
  const { loading, snapshot, error } = useDraftPool();
  const [session, setSession] = useState<DraftSession | null>(null);

  const summary = useMemo(
    () => summarizeDraftSections(session?.picks ?? []),
    [session?.picks]
  );

  const totalPicked = session?.picks.length ?? 0;
  const recentPicks = session?.picks.slice(-8).reverse() ?? [];

  const beginDraft = () => {
    setSession(createDraftSession(snapshot.cards));
  };

  const restartDraft = () => {
    setSession(createDraftSession(snapshot.cards));
  };

  const pickCard = (cardId: string) => {
    setSession((current) => (current ? applyDraftPick(current, cardId, snapshot.cards) : current));
  };

  return (
    <div className="draft-page grid gap-4 xl:grid-cols-[minmax(0,1fr)_18rem]">
      <div className="grid gap-4">
        <section className="card draft-hero-card anim-rise overflow-hidden">
          <div className="grid gap-4 lg:grid-cols-[minmax(0,1fr)_18rem]">
            <div>
              <p className="text-[12px] font-bold uppercase tracking-[0.14em] text-slate-700">
                Prototype Mode
              </p>
              <h2 className="font-display text-4xl leading-none">Draft Simulator</h2>
              <p className="mt-2 max-w-3xl text-sm text-slate-700">
                Draft a 40-card main deck, 15-card extra deck, and 15-card side deck from
                three-card offers. CCG cards target a 33% share of the pool, TCG cards target 67%,
                extra-deck rounds mix into the first 55 picks starting slow and ramping up,
                extra-deck offers lean harder toward your existing archetypes, side-deck picks
                lean toward board breakers, and cards cannot appear after being chosen three times.
              </p>
            </div>

            <div className="grid gap-2 text-sm">
              <div className="draft-panel draft-spotlight-card draft-pool-card rounded-2xl p-4">
                <div className="text-xs font-bold uppercase tracking-[0.12em] text-slate-700">
                  Pool Status
                </div>
                <div className="mt-2 text-3xl font-display text-slate-900">
                  {snapshot.meta.ccgCount + snapshot.meta.tcgCount}
                </div>
                <div className="mt-1 text-xs text-slate-700">
                  {snapshot.meta.ccgCount} CCG + {snapshot.meta.tcgCount} TCG
                </div>
                {snapshot.meta.databaseVersion && (
                  <div className="mt-2 text-[11px] text-slate-600">
                    YGO DB {snapshot.meta.databaseVersion}
                  </div>
                )}
                {snapshot.meta.lastUpdate && (
                  <div className="text-[11px] text-slate-600">
                    Upstream {snapshot.meta.lastUpdate}
                  </div>
                )}
              </div>

              <div className="draft-panel draft-spotlight-card draft-runtime-card rounded-2xl p-4">
                <div className="text-xs font-bold uppercase tracking-[0.12em] text-slate-700">
                  Runtime
                </div>
                <div className="mt-2 text-sm text-slate-700">
                  {loading
                    ? "Loading full TCG pool..."
                    : snapshot.meta.usingFallback
                      ? "Using local fallback dataset."
                      : "Using full imported TCG pool."}
                </div>
                {error && <div className="mt-2 text-xs text-amber-700">{error}</div>}
              </div>
            </div>
          </div>
        </section>

        {!session ? (
          <section className="card draft-overview-card anim-rise">
            <div className="grid gap-6 lg:grid-cols-[minmax(0,1fr)_19rem]">
              <div className="space-y-4">
                <div>
                  <h3 className="font-display text-3xl leading-none">How This Build Works</h3>
                  <p className="mt-2 text-sm text-slate-700">
                    The first iteration uses the full imported TCG metadata when available, merges it
                    with the local CCG card pool, and applies a starter hand-trap and board-breaker tag
                    overlay. That gives us a real end-to-end draft now while leaving room to tune tags,
                    image hosting, and pack validation later.
                  </p>
                </div>

                <div className="grid gap-3 sm:grid-cols-3">
                  <div className="draft-target-card draft-target-main rounded-2xl p-4">
                    <div className="text-xs font-bold uppercase tracking-[0.12em] text-violet-700">
                      Main Deck
                    </div>
                    <div className="mt-2 font-display text-4xl leading-none text-violet-950">
                      40
                    </div>
                    <div className="mt-1 text-xs text-violet-950">Non-extra only</div>
                  </div>
                  <div className="draft-target-card draft-target-extra rounded-2xl p-4">
                    <div className="text-xs font-bold uppercase tracking-[0.12em] text-sky-700">
                      Extra Deck
                    </div>
                    <div className="mt-2 font-display text-4xl leading-none text-sky-950">
                      15
                    </div>
                    <div className="mt-1 text-xs text-sky-950">Starts sparse, ramps later</div>
                  </div>
                  <div className="draft-target-card draft-target-side rounded-2xl p-4">
                    <div className="text-xs font-bold uppercase tracking-[0.12em] text-emerald-700">
                      Side Deck
                    </div>
                    <div className="mt-2 font-display text-4xl leading-none text-emerald-950">
                      15
                    </div>
                    <div className="mt-1 text-xs text-emerald-950">Never extra deck</div>
                  </div>
                </div>
              </div>

              <div className="draft-start-card rounded-[1.4rem] p-5">
                <h3 className="font-display text-3xl leading-none">Start Draft</h3>
                <p className="mt-2 text-sm text-slate-700">
                  This creates a fresh 70-pick run against the current pool snapshot and opens the
                  first {OFFER_SIZE}-card offer.
                </p>
                <button
                  type="button"
                  className="btn btn-primary mt-5 w-full"
                  onClick={beginDraft}
                  disabled={loading}
                >
                  {loading ? "Preparing Pool..." : "Begin Draft"}
                </button>
              </div>
            </div>
          </section>
        ) : (
          <>
            <section className="card draft-hero-card anim-rise">
              <div className="flex flex-wrap items-start justify-between gap-4">
                <div>
                  <div className="flex flex-wrap items-center gap-2">
                    {session.meta && (
                      <>
                        <span className={`rounded-full px-3 py-1 text-xs font-bold uppercase tracking-[0.12em] ${sectionTone(session.meta.section)}`}>
                          {SECTION_LABEL[session.meta.section]}
                        </span>
                        {session.meta.specialRound && (
                          <span className="rounded-full border border-rose-300/80 bg-rose-100 px-3 py-1 text-xs font-bold uppercase tracking-[0.12em] text-rose-800">
                            Hand Trap / Board Breaker Round
                          </span>
                        )}
                      </>
                    )}
                  </div>
                  <h3 className="mt-3 font-display text-3xl leading-none">
                    {session.completed ? "Deck Complete" : `Pick ${totalPicked + 1} of ${TOTAL_DRAFT_PICKS}`}
                  </h3>
                  {!session.completed && session.meta && (
                    <p className="mt-2 text-sm text-slate-700">
                      {session.meta.picksRemainingInSection} pick
                      {session.meta.picksRemainingInSection === 1 ? "" : "s"} left in this section.
                    </p>
                  )}
                </div>

                <div className="flex flex-wrap gap-2">
                  <button type="button" className="btn" onClick={restartDraft}>
                    Restart Draft
                  </button>
                  {session.completed && (
                    <button
                      type="button"
                      className="btn btn-primary"
                      onClick={() => downloadDecklist(session.picks)}
                    >
                      Download .txt
                    </button>
                  )}
                </div>
              </div>
            </section>

            {!session.completed && (
              <section className="grid gap-4 md:grid-cols-2 xl:grid-cols-3">
                {session.offer.map((card, index) => (
                  <article
                    key={card.id}
                    className="card anim-rise grid gap-4"
                    style={{ animationDelay: `${index * 70}ms` }}
                  >
                    <CardTile card={card} />

                    <div className="flex flex-wrap gap-2">
                      <span className={`rounded-full px-3 py-1 text-[11px] font-bold uppercase tracking-[0.12em] ${sourceTone(card.source)}`}>
                        {card.source}
                      </span>
                      {card.archetype && (
                        <span className="rounded-full border border-slate-300/80 bg-slate-100 px-3 py-1 text-[11px] font-bold uppercase tracking-[0.12em] text-slate-700">
                          {card.archetype}
                        </span>
                      )}
                      {card.draftTags.handTrap && (
                        <span className="rounded-full border border-rose-300/80 bg-rose-100 px-3 py-1 text-[11px] font-bold uppercase tracking-[0.12em] text-rose-800">
                          Hand Trap
                        </span>
                      )}
                      {card.draftTags.boardBreaker && (
                        <span className="rounded-full border border-amber-300/80 bg-amber-100 px-3 py-1 text-[11px] font-bold uppercase tracking-[0.12em] text-amber-800">
                          Board Breaker
                        </span>
                      )}
                      {card.isExtraDeck && (
                        <span className="rounded-full border border-sky-300/80 bg-sky-100 px-3 py-1 text-[11px] font-bold uppercase tracking-[0.12em] text-sky-800">
                          Extra Deck
                        </span>
                      )}
                    </div>

                    <button
                      type="button"
                      className="btn btn-primary w-full"
                      onClick={() => pickCard(card.id)}
                    >
                      Draft This Card
                    </button>
                  </article>
                ))}
              </section>
            )}

            {session.completed && (
              <section className="grid gap-4 lg:grid-cols-3">
                {(["main", "extra", "side"] as DraftDeckSection[]).map((section) => (
                  <div
                    key={section}
                    className={`card draft-sidebar-card draft-summary-card ${sectionSurface(section)} overflow-hidden`}
                  >
                    <div className="flex items-center justify-between gap-2">
                      <h4 className="font-display text-3xl leading-none">{SECTION_LABEL[section]}</h4>
                      <span className={`rounded-full px-3 py-1 text-xs font-bold uppercase tracking-[0.12em] ${sectionTone(section)}`}>
                        {summary[section].total}
                      </span>
                    </div>
                    <div className="mt-4 grid gap-2 text-sm">
                      {summary[section].entries.map((entry) => (
                        <div
                          key={`${section}-${entry.name}`}
                          className="draft-panel grid grid-cols-[minmax(0,1fr)_auto] items-center gap-3 rounded-xl px-3 py-2"
                        >
                          <div className="min-w-0">
                            <div className="truncate font-bold text-slate-800">{entry.name}</div>
                            <div className="text-xs text-slate-600">{entry.source}</div>
                          </div>
                          <div className="min-w-[2.25rem] text-right font-display text-2xl leading-none text-slate-800">
                            {entry.count}
                          </div>
                        </div>
                      ))}
                    </div>
                  </div>
                ))}
              </section>
            )}
          </>
        )}
      </div>

      <aside className="grid gap-3 self-start xl:sticky xl:top-20">
        <section className="card draft-sidebar-card draft-progress-shell">
          <div className="flex items-center justify-between gap-2">
            <h3 className="font-display text-2xl leading-none">Live Deck Panel</h3>
            <span className="rounded-full border border-slate-300/80 bg-slate-100 px-2.5 py-1 text-[11px] font-bold uppercase tracking-[0.12em] text-slate-700">
              {totalPicked}/{TOTAL_DRAFT_PICKS}
            </span>
          </div>

          <div className="mt-3 grid gap-2 sm:grid-cols-3 xl:grid-cols-1">
            {(["main", "extra", "side"] as DraftDeckSection[]).map((section) => (
              <div
                key={section}
                className={`draft-panel draft-mini-card ${sectionSurface(section)} rounded-xl px-3 py-2.5`}
              >
                <div className="text-[11px] font-bold uppercase tracking-[0.12em] text-slate-700">
                  {SECTION_LABEL[section]}
                </div>
                <div className="mt-1.5 font-display text-3xl leading-none text-slate-900">
                  {summary[section].total}
                </div>
                <div className="mt-1 text-[11px] text-slate-600">
                  Target {DRAFT_TARGETS[section]}
                </div>
              </div>
            ))}
          </div>
        </section>

        <section className="card draft-sidebar-card draft-recent-shell">
          <h3 className="font-display text-2xl leading-none">Recent Picks</h3>
          <div className="mt-3 grid gap-2">
            {recentPicks.length ? (
              recentPicks.map((pick) => (
                <div
                  key={`${pick.round}-${pick.card.id}`}
                  className="draft-panel rounded-xl px-3 py-2"
                >
                  <div className="flex items-center justify-between gap-3">
                    <div className="min-w-0">
                      <div className="truncate font-bold text-slate-800">{pick.card.name}</div>
                      <div className="text-xs text-slate-600">
                        {SECTION_LABEL[pick.section]} | {pick.card.source}
                      </div>
                    </div>
                    <span className="text-xs font-bold uppercase tracking-[0.12em] text-slate-700">
                      #{pick.round}
                    </span>
                  </div>
                </div>
              ))
            ) : (
              <div className="draft-panel rounded-xl px-3 py-4 text-sm text-slate-700">
                No picks yet.
              </div>
            )}
          </div>
        </section>
      </aside>
    </div>
  );
}
