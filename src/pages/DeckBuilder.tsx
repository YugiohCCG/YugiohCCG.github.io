import { useDeferredValue, useEffect, useMemo, useState, type DragEvent } from "react";
import { Link } from "react-router-dom";
import useBanlistCards from "../hooks/useBanlistCards";
import usePageMeta from "../hooks/usePageMeta";
import useRemoteJson from "../hooks/useRemoteJson";
import { useImageViewer } from "../components/ImageViewer";
import LegalityBadge, { legalStatus } from "../components/LegalityBadge";
import type { Card } from "../types/card";
import customCardsData from "../data/cards.json";
import { asset } from "../utils/assets";
import { isExtraDeckCard } from "../utils/memberships";
import { serializeOmegaDeck, type DeckSection, type DeckState } from "../utils/deck";

const EMPTY: DeckState = { main: [], extra: [], side: [] };
const STORAGE_KEY = "ccg_deck_builder_v1";
const DRAG_TYPE = "application/x-ccg-deck-card";
type CardPool = "all" | "ccg" | "yugioh";
type DragPayload =
  | { source: "catalog"; cardId: number }
  | { source: "deck"; cardId: number; section: DeckSection; index: number };

const SECTION_LABEL: Record<DeckSection, string> = {
  main: "Main Deck",
  extra: "Extra Deck",
  side: "Side Deck",
};

function initialDeck(): DeckState {
  try {
    const value = JSON.parse(localStorage.getItem(STORAGE_KEY) ?? "null");
    if (value?.main && value?.extra && value?.side) return value;
  } catch {
    // Ignore invalid saved state.
  }
  return EMPTY;
}

function cardArtwork(card: Card, fullResolution = false) {
  if (card.image) return asset(card.image);
  return card.passcode
    ? `https://images.ygoprodeck.com/images/${fullResolution ? "cards" : "cards_small"}/${card.passcode}.jpg`
    : "";
}

function CardArtwork({ card, className = "" }: { card: Card; className?: string }) {
  const source = cardArtwork(card);
  if (source) return <img src={source} alt={`${card.name} card`} className={className} loading="lazy" draggable={false} />;
  return <span className={`deck-card-fallback is-${card.category.toLowerCase()} ${className}`} aria-label={`${card.name}, artwork unavailable`}><b>{card.name}</b><small>{card.category}</small></span>;
}

function parseDrag(event: DragEvent): DragPayload | null {
  try {
    const raw = event.dataTransfer.getData(DRAG_TYPE) || event.dataTransfer.getData("text/plain");
    const value = JSON.parse(raw) as DragPayload;
    return value?.cardId ? value : null;
  } catch {
    return null;
  }
}

function beginDrag(event: DragEvent, payload: DragPayload) {
  const serialized = JSON.stringify(payload);
  event.dataTransfer.effectAllowed = "copyMove";
  event.dataTransfer.setData(DRAG_TYPE, serialized);
  event.dataTransfer.setData("text/plain", serialized);
}

export default function DeckBuilder() {
  usePageMeta("Deck Builder", "Build, validate, save, and export decks using every CCG and Yu-Gi-Oh! card.");
  const { open } = useImageViewer();
  const customCards = customCardsData as Card[];
  const { data: officialCards, loading: loadingOfficial, error: officialError } = useRemoteJson<Card[]>("data/yugioh-cards.json");
  const { legalFor } = useBanlistCards("TCG");
  const [deck, setDeck] = useState<DeckState>(initialDeck);
  const [query, setQuery] = useState("");
  const [pool, setPool] = useState<CardPool>("all");
  const [dragTarget, setDragTarget] = useState<DeckSection | null>(null);
  const [dragging, setDragging] = useState<DragPayload | null>(null);
  const deferredQuery = useDeferredValue(query.trim().toLowerCase());
  const customIds = useMemo(() => new Set(customCards.map((card) => card.passcode)), [customCards]);
  const cards = useMemo(() => [...(officialCards ?? []).filter((card) => !customIds.has(card.passcode)), ...customCards], [customCards, customIds, officialCards]);
  const byId = useMemo(() => new Map(cards.filter((card) => card.passcode).map((card) => [card.passcode as number, card])), [cards]);
  const results = useMemo(() => cards.filter((card) => {
    const isCustom = customIds.has(card.passcode);
    if (pool === "ccg" && !isCustom) return false;
    if (pool === "yugioh" && isCustom) return false;
    return `${card.name} ${card.text ?? ""} ${card.archetype ?? ""}`.toLowerCase().includes(deferredQuery);
  }).slice(0, 80), [cards, customIds, deferredQuery, pool]);

  useEffect(() => localStorage.setItem(STORAGE_KEY, JSON.stringify(deck)), [deck]);

  const copiesIn = (state: DeckState, id: number) => state.main.filter((value) => value === id).length + state.extra.filter((value) => value === id).length + state.side.filter((value) => value === id).length;
  const copies = (id: number) => copiesIn(deck, id);
  const copyLimit = (card: Card) => { const legal = card.legal ?? legalFor(card); return legal?.banned ? 0 : legal?.limited ? 1 : legal?.semiLimited ? 2 : 3; };
  const sectionAccepts = (card: Card, section: DeckSection) => section === "side" || (section === "extra" ? isExtraDeckCard(card) : !isExtraDeckCard(card));
  const sectionHasRoom = (state: DeckState, section: DeckSection) => state[section].length < (section === "main" ? 60 : 15);

  const add = (card: Card, section: DeckSection = isExtraDeckCard(card) ? "extra" : "main") => {
    if (!card.passcode || !sectionAccepts(card, section)) return;
    setDeck((current) => {
      if (copiesIn(current, card.passcode as number) >= 3 || !sectionHasRoom(current, section)) return current;
      return { ...current, [section]: [...current[section], card.passcode as number] };
    });
  };

  const remove = (section: DeckSection, index: number) => setDeck((current) => ({ ...current, [section]: current[section].filter((_, itemIndex) => itemIndex !== index) }));

  const startDrag = (event: DragEvent, payload: DragPayload) => {
    setDragging(payload);
    beginDrag(event, payload);
  };

  const finishDrag = () => {
    setDragging(null);
    setDragTarget(null);
  };

  const returnCardToLibrary = (event: DragEvent) => {
    event.preventDefault();
    const payload = parseDrag(event);
    if (payload?.source === "deck") remove(payload.section, payload.index);
    finishDrag();
  };

  const dropCard = (event: DragEvent, targetSection: DeckSection, targetIndex?: number) => {
    event.preventDefault();
    finishDrag();
    const payload = parseDrag(event);
    if (!payload) return;
    const card = byId.get(payload.cardId);
    if (!card || !sectionAccepts(card, targetSection)) return;
    if (payload.source === "catalog") {
      add(card, targetSection);
      return;
    }
    setDeck((current) => {
      if (payload.section !== targetSection && !sectionHasRoom(current, targetSection)) return current;
      const sourceCards = [...current[payload.section]];
      if (sourceCards[payload.index] !== payload.cardId) return current;
      sourceCards.splice(payload.index, 1);
      const targetCards = payload.section === targetSection ? sourceCards : [...current[targetSection]];
      let insertAt = targetIndex ?? targetCards.length;
      if (payload.section === targetSection && payload.index < insertAt) insertAt -= 1;
      targetCards.splice(Math.max(0, Math.min(insertAt, targetCards.length)), 0, payload.cardId);
      return payload.section === targetSection
        ? { ...current, [targetSection]: targetCards }
        : { ...current, [payload.section]: sourceCards, [targetSection]: targetCards };
    });
  };

  const exportDeck = () => {
    const url = URL.createObjectURL(new Blob([serializeOmegaDeck(deck)], { type: "text/plain" }));
    const anchor = document.createElement("a");
    anchor.href = url;
    anchor.download = "CCG-Deck.ydk";
    anchor.click();
    URL.revokeObjectURL(url);
  };

  const respectsLimits = [...deck.main, ...deck.extra, ...deck.side].every((id) => { const card = byId.get(id); return !card || copies(id) <= copyLimit(card); });
  const legalityIssues = new Set([...deck.main, ...deck.extra, ...deck.side].filter((id) => { const card = byId.get(id); return card && copies(id) > copyLimit(card); })).size;
  const valid = deck.main.length >= 40 && deck.main.length <= 60 && deck.extra.length <= 15 && deck.side.length <= 15 && respectsLimits;
  const validationMessage = valid
    ? "Deck is export-ready."
    : deck.main.length < 40
      ? `Main Deck needs ${40 - deck.main.length} more cards.`
      : legalityIssues > 0
        ? `${legalityIssues} card${legalityIssues === 1 ? "" : "s"} exceed the current banlist limit.`
        : "Deck does not meet the current format requirements.";

  return <div className="deck-builder space-y-5">
    <section className="card deck-builder-hero">
      <p className="deck-kicker">Omega deck workshop</p>
      <div className="deck-builder-heading">
        <div><h1 className="font-display text-4xl">Deck Builder</h1><p>Search the complete CCG and Yu-Gi-Oh! catalog. Drag cards onto a deck zone, rearrange them, then export an Omega <code>.ydk</code>.</p></div>
        <div className="flex gap-2"><button className="btn" type="button" onClick={() => setDeck(EMPTY)}>Clear</button><button className="btn btn-primary" type="button" onClick={exportDeck} disabled={!valid}>Export .ydk</button></div>
      </div>
      <div className={`deck-validation ${valid ? "is-valid" : "is-incomplete"}`} role="status">{validationMessage}</div>
    </section>

    <div className="deck-workspace">
      <section className={`card deck-catalog ${dragging?.source === "deck" ? "can-return" : ""}`} onDragOver={(event) => { if (dragging?.source === "deck") { event.preventDefault(); event.dataTransfer.dropEffect = "move"; } }} onDrop={returnCardToLibrary}>
        <div className="deck-section-heading"><div><p className="deck-kicker">Card library</p><h2 className="font-display text-3xl">Find Cards</h2></div><span>{results.length} shown</span></div>
        <div className="deck-return-drop" aria-hidden={dragging?.source !== "deck"}><b>Return card to library</b><span>Drop anywhere in this panel to remove it from your deck</span></div>
        <div className="deck-search-controls"><input type="search" placeholder="Name, text, or archetype…" value={query} onChange={(event) => setQuery(event.target.value)} /><select value={pool} onChange={(event) => setPool(event.target.value as CardPool)} aria-label="Card pool"><option value="all">All cards</option><option value="ccg">CCG only</option><option value="yugioh">Yu-Gi-Oh! only</option></select></div>
        {loadingOfficial && <p className="deck-catalog-note" role="status">Loading the complete Yu-Gi-Oh! catalog…</p>}
        {Boolean(officialError) && <p className="deck-catalog-note is-error" role="alert">The official card catalog could not be loaded.</p>}
        <div className="deck-catalog-grid">{results.map((card) => {
          const limit = copyLimit(card);
          const status = legalStatus(card.legal ?? legalFor(card));
          const isCustom = customIds.has(card.passcode);
          const disabled = copies(card.passcode as number) >= 3;
          return <article key={card.passcode} className={`deck-library-card ${disabled ? "is-maxed" : ""}`} draggable={!disabled} onDragStart={(event) => startDrag(event, { source: "catalog", cardId: card.passcode as number })} onDragEnd={finishDrag}>
            {status && <LegalityBadge status={status} className="deck-legality" size={30} />}
            <div className="deck-library-art"><button type="button" className="deck-artwork-button" draggable={!disabled} onDragStart={(event) => { event.stopPropagation(); startDrag(event, { source: "catalog", cardId: card.passcode as number }); }} onClick={() => open(cardArtwork(card, true), card.name, status)} aria-label={`Magnify ${card.name}`}><CardArtwork card={card} className="deck-artwork" /></button><span className="deck-source-tag">{isCustom ? "CCG" : "TCG"}</span></div>
            <div className="deck-library-copy">{isCustom ? <Link to={`/cards/${card.passcode}`} title={card.name}>{card.name}</Link> : <strong title={card.name}>{card.name}</strong>}<small>{copies(card.passcode as number)} in deck{status ? ` · limit ${limit}` : ""}</small></div>
            <div className="deck-library-actions"><button type="button" onClick={() => add(card)} disabled={disabled}>+ {isExtraDeckCard(card) ? "Extra" : "Main"}</button><button type="button" onClick={() => add(card, "side")} disabled={disabled}>+ Side</button></div>
          </article>;
        })}</div>
      </section>

      <div className="deck-zones">{(["main", "extra", "side"] as DeckSection[]).map((section) => <section key={section} className={`card deck-zone is-${section} ${dragTarget === section ? "is-drag-target" : ""}`} onDragEnter={(event) => { event.preventDefault(); setDragTarget(section); }} onDragOver={(event) => { event.preventDefault(); event.dataTransfer.dropEffect = dragging?.source === "catalog" ? "copy" : "move"; }} onDragLeave={(event) => { if (!event.currentTarget.contains(event.relatedTarget as Node)) setDragTarget(null); }} onDrop={(event) => dropCard(event, section)}>
        <div className="deck-zone-heading"><div><p className="deck-kicker">{section === "side" ? "Between games" : "Duel loadout"}</p><h2 className="font-display text-3xl">{SECTION_LABEL[section]}</h2></div><span>{deck[section].length}<small>/{section === "main" ? "40–60" : "15"}</small></span></div>
        <div className="deck-zone-grid">{deck[section].map((id, index) => {
          const card = byId.get(id);
          if (!card) return null;
          const status = legalStatus(card.legal ?? legalFor(card));
          return <article key={`${section}-${id}-${index}`} className="deck-slot" draggable onDragStart={(event) => startDrag(event, { source: "deck", cardId: id, section, index })} onDragEnd={finishDrag} onDragOver={(event) => event.preventDefault()} onDrop={(event) => { event.stopPropagation(); dropCard(event, section, index); }} title={`${card.name} — drag to reorder or move`}>
            <button type="button" className="deck-artwork-button" draggable onDragStart={(event) => { event.stopPropagation(); startDrag(event, { source: "deck", cardId: id, section, index }); }} onClick={() => open(cardArtwork(card, true), card.name, status)} aria-label={`Magnify ${card.name}`}><CardArtwork card={card} className="deck-artwork" /></button>
            {status && <LegalityBadge status={status} className="deck-legality" size={29} />}
            <button type="button" className="deck-slot-remove" onClick={() => remove(section, index)} aria-label={`Remove ${card.name}`}>×</button>
            <span>{card.name}</span>
          </article>;
        })}{deck[section].length === 0 && <div className="deck-drop-empty"><b>Drop cards here</b><span>{section === "side" ? "Any card can enter the Side Deck" : section === "extra" ? "Fusion, Synchro, Xyz, and Link cards" : "Main Deck cards only"}</span></div>}</div>
      </section>)}</div>
    </div>
  </div>;
}
