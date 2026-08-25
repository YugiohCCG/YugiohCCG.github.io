import { Link, useParams } from "react-router-dom";
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

  return <div className="space-y-6">
    <nav className="text-sm text-slate-500" aria-label="Breadcrumb"><Link to="/cards" className="hover:underline">Card Database</Link> / <span>{card.name}</span></nav>
    <section className="card grid gap-6 lg:grid-cols-[minmax(16rem,25rem)_1fr]">
      <div className="relative"><img src={asset(card.image)} alt={card.name} className="w-full rounded-xl border border-slate-300 object-contain" />{status && <LegalityBadge status={status} className="absolute -left-3 -top-3" size={58} />}</div>
      <div>
        <p className="text-xs font-bold uppercase tracking-[0.14em] text-slate-500">{card.set || card.category}</p>
        <h1 className="mt-1 font-display text-4xl leading-none md:text-5xl">{card.name}</h1>
        <div className="mt-3 flex flex-wrap gap-2"><button type="button" className="btn" onClick={share}>{shared ? "Link copied" : "Share card"}</button>{card.passcode != null && <button type="button" className="btn" onClick={() => navigator.clipboard.writeText(String(card.passcode))}>Copy passcode</button>}</div>
        <div className="mt-4 flex flex-wrap gap-2 text-xs">
          <span className="rounded-full bg-slate-100 px-3 py-1 font-bold">{typeLine(card)}</span>
          {card.attribute && <span className="rounded-full bg-slate-100 px-3 py-1 font-bold">{card.attribute}</span>}
          {levelRankLink(card) && <span className="rounded-full bg-slate-100 px-3 py-1 font-bold">{levelRankLink(card)}</span>}
          {atkDef(card) && <span className="rounded-full bg-slate-100 px-3 py-1 font-bold">{atkDef(card)}</span>}
        </div>
        <div className="mt-5 whitespace-pre-line rounded-xl border border-slate-300/70 bg-white p-4 text-sm leading-6 text-slate-700">{card.text || "No effect text."}</div>
        <dl className="mt-4 grid gap-3 sm:grid-cols-2">
          <div><dt className="text-xs font-bold uppercase text-slate-500">Omega passcode</dt><dd className="font-mono text-sm">{card.passcode ?? "Unavailable"}</dd></div>
          <div><dt className="text-xs font-bold uppercase text-slate-500">Added</dt><dd className="text-sm">{card.timestamps?.added || "Unknown"}</dd></div>
        </dl>
        {memberships.length > 0 && <div className="mt-4"><div className="text-xs font-bold uppercase text-slate-500">Archetypes and memberships</div><div className="mt-2 flex flex-wrap gap-2">{memberships.map((name) => <Link key={name} className="btn" to={`/archetypes/${encodeURIComponent(name)}`}>{name}</Link>)}</div></div>}
        <div className="mt-4 rounded-xl border border-slate-300/70 bg-slate-50 p-3"><div className="text-xs font-bold uppercase text-slate-500">Implementation status</div><div className="mt-1 flex flex-wrap items-center gap-2"><strong>{review?.verdict ?? "Loading…"}</strong>{review && <Link className="text-sm text-accent hover:underline" to={`/support?q=${encodeURIComponent(card.name)}`}>View review details</Link>}</div></div>
      </div>
    </section>
    {related.length > 0 && <section className="card"><h2 className="font-display text-3xl">Related Cards</h2><div className="mt-4 grid gap-3 sm:grid-cols-2 lg:grid-cols-4">{related.map((item) => <Link key={item.passcode} to={`/cards/${item.passcode}`} className="rounded-xl border border-slate-300 bg-white p-3 hover:border-accent"><img src={asset(item.image)} alt="" className="mx-auto h-40 object-contain" loading="lazy" /><div className="mt-2 text-sm font-bold">{item.name}</div></Link>)}</div></section>}
  </div>;
}
