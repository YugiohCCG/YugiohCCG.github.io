import PrintTitle from "../components/PrintTitle";
import { useParams } from "react-router-dom";
import Link from "../components/SiteLink";
import { useImageViewer } from "../components/ImageViewer";
import { useState } from "react";
import LegalityBadge, { legalStatus } from "../components/LegalityBadge";
import useCards from "../hooks/useCards";
import usePageMeta from "../hooks/usePageMeta";
import useRemoteJson from "../hooks/useRemoteJson";
import { atkDef, levelRankLink, typeLine } from "../types/card";
import type { SupportStatus } from "../types/website";
import { asset } from "../utils/assets";
import { cardMemberships } from "../utils/memberships";

export default function CardDetail() {
  const { open } = useImageViewer();
  const [shared, setShared] = useState(false);
  const { cardId = "" } = useParams();
  const { cards } = useCards({ includeTCG: false, includeCustom: true, includeTest: false, ignoreTextQuery: true });
  const { data: support } = useRemoteJson<SupportStatus>("data/support-status.json");
  const card = cards.find((item) => String(item.passcode) === cardId || item.id === cardId);
  usePageMeta(card?.name ?? "Card not found", card?.text?.slice(0, 155) ?? "CCG card details");

  if (!card) return <section className="card"><h2 className="font-display text-4xl">Card not found</h2><Link className="btn mt-4" to="/cards">Return to database</Link></section>;

  const memberships = cardMemberships(card);
  const review = support?.cards.find((item) => item.passcode === card.passcode);
  const related = cards.filter((item) => item.passcode !== card.passcode && cardMemberships(item).some((name) => memberships.includes(name))).slice(0, 8);
  const status = legalStatus(card.legal);
  const share = async () => {
    const payload = { title: card.name, text: `View ${card.name} in the Yu-Gi-Oh! CCG database.`, url: window.location.href };
    if (navigator.share) await navigator.share(payload);
    else await navigator.clipboard.writeText(window.location.href);
    setShared(true);
    window.setTimeout(() => setShared(false), 1600);
  };

  return <div className="space-y-6 tp-card-profile">
    <nav className="text-sm text-slate-500" aria-label="Breadcrumb"><Link to="/cards" className="hover:underline">Card Database</Link> / <span>{card.name}</span></nav>
    <section className="card tp-profile-layout grid gap-6 lg:grid-cols-[minmax(16rem,25rem)_1fr]">
      <div className="relative tp-profile-art"><button type="button" className="tp-profile-zoom" aria-label={`Enlarge ${card.name}`} onClick={() => open(asset(card.image), card.name)}><img src={asset(card.image)} alt={card.name} className="w-full rounded-xl border border-slate-300 object-contain" /></button><span className="tp-profile-art-label">CCG / {card.passcode} · Click to enlarge</span>{status && <LegalityBadge status={status} className="absolute -left-3 -top-3" size={58} />}</div>
      <div className="tp-profile-copy">
        <p className="text-xs font-bold uppercase tracking-[0.14em] text-slate-500">{card.set || card.category}</p>
        <PrintTitle as="h1" caption="CARD / PROFILE" className="mt-1 font-display text-4xl leading-none md:text-5xl">{card.name}</PrintTitle>
        <div className="mt-3 flex flex-wrap gap-2"><button type="button" className="btn" onClick={share}>{shared ? "Link copied" : "Share card"}</button>{card.passcode != null && <button type="button" className="btn" onClick={() => navigator.clipboard.writeText(String(card.passcode))}>Copy passcode</button>}</div>
        <div className="tp-profile-specs mt-4 flex flex-wrap gap-2 text-xs">
          <span className="rounded-full bg-slate-100 px-3 py-1 font-bold">{typeLine(card)}</span>
          {card.attribute && <span className="rounded-full bg-slate-100 px-3 py-1 font-bold">{card.attribute}</span>}
          {levelRankLink(card) && <span className="rounded-full bg-slate-100 px-3 py-1 font-bold">{levelRankLink(card)}</span>}
          {atkDef(card) && <span className="rounded-full bg-slate-100 px-3 py-1 font-bold">{atkDef(card)}</span>}
        </div>
        <div className="tp-profile-effect mt-5 whitespace-pre-line rounded-xl border border-slate-300/70 bg-white p-4 text-sm leading-6 text-slate-700"><h2 className="tp-profile-effect-label">Card text</h2>{card.text || "No effect text."}</div>
        <dl className="tp-profile-meta mt-4 grid gap-3 sm:grid-cols-2">
          <div><dt className="text-xs font-bold uppercase text-slate-500">Omega passcode</dt><dd className="font-mono text-sm">{card.passcode ?? "Unavailable"}</dd></div>
          <div><dt className="text-xs font-bold uppercase text-slate-500">Added</dt><dd className="text-sm">{card.timestamps?.added || "Unknown"}</dd></div>
        </dl>
        {memberships.length > 0 && <div className="mt-4"><div className="text-xs font-bold uppercase text-slate-500">Archetypes and memberships</div><div className="mt-2 flex flex-wrap gap-2">{memberships.map((name) => <Link key={name} className="btn" to={`/archetypes/${encodeURIComponent(name)}`}>{name}</Link>)}</div></div>}
        <div className="tp-profile-review mt-4 rounded-xl border border-slate-300/70 bg-slate-50 p-3"><div className="text-xs font-bold uppercase text-slate-500">Implementation status</div><div className="mt-1 flex flex-wrap items-center gap-2"><strong>{review?.verdict ?? "Loading…"}</strong>{review && <Link className="text-sm text-accent hover:underline" to={`/support?q=${encodeURIComponent(card.name)}`}>View review details</Link>}</div></div>
      </div>
    </section>
    {related.length > 0 && <section className="card tp-related-section" aria-label="Related cards">
      <header className="tp-related-header">
        <PrintTitle as="h2" caption="CONNECTED / CARDS" className="font-display text-3xl tp-related-title">Related Cards</PrintTitle>
        <Link className="tp-related-browse" to={`/archetypes/${encodeURIComponent(memberships[0])}`}>Browse {memberships[0]} <span aria-hidden="true">↗</span></Link>
      </header>
      <div className="tp-related-grid grid gap-4 sm:grid-cols-2 lg:grid-cols-4">
        {related.map((item) => <Link key={item.passcode} to={`/cards/${item.passcode}`} className="tp-related-card" aria-label={`View ${item.name}`}>
          <div className="tp-related-art"><img src={asset(item.image)} alt="" loading="lazy" width="400" height="584" /><span className="tp-related-arrow" aria-hidden="true">↗</span></div>
          <div className="tp-related-copy"><h3>{item.name}</h3><p>{typeLine(item)}</p></div>
        </Link>)}
      </div>
    </section>}
  </div>;
}
