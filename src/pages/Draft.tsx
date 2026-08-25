import { useState, type CSSProperties } from "react";
import { useImageViewer } from "../components/ImageViewer";
import useDraftPool from "../hooks/useDraftPool";
import usePageMeta from "../hooks/usePageMeta";
import type { DraftDeckSection, DraftPoolCard, DraftSession } from "../types/draft";
import { asset } from "../utils/assets";
import {
  DRAFT_TARGETS,
  OFFER_SIZE,
  TOTAL_DRAFT_PICKS,
  applyDraftPick,
  createDraftSession,
  downloadDecklist,
  summarizeDraftSections,
} from "../utils/draft";

const SECTIONS: DraftDeckSection[] = ["main", "extra", "side"];
const SECTION_LABEL: Record<DraftDeckSection, string> = {
  main: "Main Deck",
  extra: "Extra Deck",
  side: "Side Deck",
};

function cardTag(card: DraftPoolCard): string | null {
  if (card.draftTags.handTrap) return "Hand Trap";
  if (card.draftTags.boardBreaker) return "Board Breaker";
  if (card.draftTags.spellTrapNonEngine) return "Interaction";
  if (card.isExtraDeck) return "Extra Deck";
  return card.archetype || null;
}

function DraftChoice({ card, index, onPick }: { card: DraftPoolCard; index: number; onPick: () => void }) {
  const { open } = useImageViewer();
  const tag = cardTag(card);
  return <article
    className={`draft-choice is-${card.source.toLowerCase()}`}
    onClick={onPick}
  >
    <button type="button" className="draft-choice-zoom" onClick={(event) => {
      event.stopPropagation();
      open(asset(card.image), card.name);
    }} aria-label={`View ${card.name} at full size`} title="View full-size card">
      <svg viewBox="0 0 24 24" aria-hidden="true"><circle cx="10.8" cy="10.8" r="6.8" /><path d="m16 16 5 5" /></svg>
    </button>
    <span className="draft-choice-source">{card.source}</span>
    <span className="draft-choice-image">
      <img src={asset(card.image)} alt={card.name} draggable={false} />
    </span>
    <span className="draft-choice-copy">
      <strong>{card.name}</strong>
      <span>{card.category}{card.archetype ? ` · ${card.archetype}` : ""}</span>
    </span>
    <div className="draft-choice-footer">
      {tag ? <span className="draft-choice-tag">{tag}</span> : <span />}
      <button type="button" className="draft-pick-command" onClick={(event) => {
        event.stopPropagation();
        onPick();
      }} aria-label={`Draft ${card.name}, option ${index + 1}`}>Draft card</button>
    </div>
  </article>;
}

function DeckRail({ session }: { session: DraftSession }) {
  const summary = summarizeDraftSections(session.picks);
  const recent = session.picks.slice(-6).reverse();
  return <aside className="draft-deck-rail" aria-label="Drafted deck status">
    <div className="draft-rail-heading"><span>Deck zones</span><strong>{session.picks.length}/{TOTAL_DRAFT_PICKS}</strong></div>
    <div className="draft-zone-list">
      {SECTIONS.map((section) => {
        const count = summary[section].total;
        const target = DRAFT_TARGETS[section];
        return <section key={section} className={`draft-zone is-${section}`}>
          <div className="draft-zone-top"><strong>{SECTION_LABEL[section]}</strong><span>{count}/{target}</span></div>
          <div className="draft-zone-meter"><span style={{ width: `${Math.min(100, count / target * 100)}%` }} /></div>
          <div className="draft-zone-stack" aria-hidden="true">{Array.from({ length: Math.min(5, count) }, (_, index) => <i key={index} />)}</div>
        </section>;
      })}
    </div>
    <div className="draft-log">
      <div className="draft-log-title">Pick history</div>
      {recent.length ? recent.map((pick) => <div className="draft-log-row" key={`${pick.round}-${pick.card.id}`}>
        <span>#{pick.round}</span><strong title={pick.card.name}>{pick.card.name}</strong><i className={`is-${pick.section}`} />
      </div>) : <p>Your selections will appear here.</p>}
    </div>
  </aside>;
}

function DraftLobby({ loading, cardCount, ccgCount, tcgCount, featuredCards, onBegin }: { loading: boolean; cardCount: number; ccgCount: number; tcgCount: number; featuredCards: DraftPoolCard[]; onBegin: () => void }) {
  return <div className="draft-lobby">
    <section className="draft-lobby-stage">
      <div className="draft-lobby-content">
        <p className="draft-eyebrow">CCG Draft Room</p>
        <h1>Build your<br /><span>70-card deck.</span></h1>
        <p className="draft-lobby-lede">Choose one card from each three-card offer. The pool responds to your archetypes, Extra Deck needs, and interaction picks as the draft progresses.</p>
        <button type="button" className="draft-launch" onClick={onBegin} disabled={loading}>
          <span>{loading ? "Shuffling card pool…" : "Begin draft"}</span>
          <small>{TOTAL_DRAFT_PICKS} picks · {OFFER_SIZE} choices each</small>
        </button>
      </div>
      <div className="draft-lobby-deck" aria-hidden="true">{featuredCards.slice(0, 3).map((card, index) => <img key={card.id} src={asset(card.image)} alt="" style={{ "--fan-index": index } as CSSProperties} />)}</div>
    </section>
    <section className="draft-lobby-rules" aria-label="Draft format">
      <div><span>01</span><strong>Choose</strong><p>Pick one card from every offer.</p></div>
      <div><span>02</span><strong>Build</strong><p>Complete Main, Extra, and Side Deck zones.</p></div>
      <div><span>03</span><strong>Export</strong><p>Download a ready-to-play Omega deck.</p></div>
      <div className="draft-pool-readout"><span>Live pool</span><strong>{cardCount.toLocaleString()}</strong><p>{ccgCount.toLocaleString()} CCG · {tcgCount.toLocaleString()} TCG</p></div>
    </section>
  </div>;
}

function DraftComplete({ session, onRestart }: { session: DraftSession; onRestart: () => void }) {
  const summary = summarizeDraftSections(session.picks);
  return <div className="draft-complete">
    <section className="draft-victory">
      <p className="draft-eyebrow">Draft complete</p><h1>Your deck is ready.</h1>
      <p>Seventy decisions. One finished Omega deck.</p>
      <div className="draft-victory-actions"><button type="button" className="draft-launch is-compact" onClick={() => downloadDecklist(session.picks)}><span>Download .ydk</span><small>Open in YGO Omega</small></button><button type="button" className="draft-quiet-button" onClick={onRestart}>Draft again</button></div>
    </section>
    <section className="draft-results-grid">
      {SECTIONS.map((section) => <div key={section} className={`draft-result-zone is-${section}`}><div><strong>{SECTION_LABEL[section]}</strong><span>{summary[section].total}</span></div><ol>{summary[section].entries.map((entry) => <li key={entry.name}><span>{entry.name}</span><b>×{entry.count}</b></li>)}</ol></div>)}
    </section>
  </div>;
}

export default function Draft() {
  usePageMeta("Draft Arena", "Draft a 70-card CCG and TCG pool, then export the completed Omega deck.");
  const { loading, snapshot, error } = useDraftPool();
  const [session, setSession] = useState<DraftSession | null>(null);
  const [announcement, setAnnouncement] = useState("");
  const totalPicked = session?.picks.length ?? 0;
  const progress = totalPicked / TOTAL_DRAFT_PICKS * 100;

  const beginDraft = () => setSession(createDraftSession(snapshot.cards));
  const restartDraft = () => { setAnnouncement(""); setSession(createDraftSession(snapshot.cards)); };
  const pickCard = (card: DraftPoolCard) => {
    setAnnouncement(`${card.name} added to ${session?.meta ? SECTION_LABEL[session.meta.section] : "your deck"}.`);
    setSession((current) => current ? applyDraftPick(current, card.id, snapshot.cards) : current);
  };

  if (!session) return <div className="draft-game"><DraftLobby loading={loading} cardCount={snapshot.cards.length} ccgCount={snapshot.meta.ccgCount} tcgCount={snapshot.meta.tcgCount} featuredCards={snapshot.cards.filter((card) => Boolean(card.image)).slice(0, 3)} onBegin={beginDraft} />{error && <p className="draft-load-warning">Full pool unavailable: {error}</p>}</div>;
  if (session.completed) return <div className="draft-game"><DraftComplete session={session} onRestart={restartDraft} /></div>;

  return <div className="draft-game is-running">
    <header className="draft-hud">
      <div className="draft-hud-round"><span>Pick</span><strong>{totalPicked + 1}</strong><small>of {TOTAL_DRAFT_PICKS}</small></div>
      <div className="draft-hud-center">
        <div className="draft-hud-meta"><strong>{session.meta ? SECTION_LABEL[session.meta.section] : "Draft"}</strong>{session.meta?.specialRound && <span>Non-engine round</span>}<small>{session.meta?.picksRemainingInSection} remaining in zone</small></div>
        <div className="draft-master-progress"><span style={{ width: `${progress}%` }} /></div>
      </div>
      <button type="button" className="draft-quiet-button" onClick={restartDraft}>Restart</button>
    </header>

    <div className="draft-arena-layout">
      <main className="draft-table">
        <div className="draft-table-mark" aria-hidden="true"><i /><span>CCG</span></div>
        <div className="draft-table-heading"><p>Current offer</p><h1>Choose one card</h1><span>Inspect any card before making your pick</span></div>
        <div className="draft-offer-grid" key={session.meta?.pickNumber}>{session.offer.map((card, index) => <DraftChoice key={card.id} card={card} index={index} onPick={() => pickCard(card)} />)}</div>
        <div className="draft-announcement" aria-live="polite">{announcement}</div>
      </main>
      <DeckRail session={session} />
    </div>
  </div>;
}
