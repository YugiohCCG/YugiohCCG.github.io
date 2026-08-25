import { Link, useParams } from "react-router-dom";
import CardTile from "../components/CardTile";
import useCards from "../hooks/useCards";
import usePageMeta from "../hooks/usePageMeta";
import { consolidatedArchetypes } from "../utils/memberships";
import { asset } from "../utils/assets";

export default function Archetypes() {
  const { name } = useParams();
  const { cards } = useCards({ includeTCG: false, includeCustom: true, includeTest: false, ignoreTextQuery: true });
  const cardsById = new Map(cards.filter((card) => card.passcode != null).map((card) => [card.passcode as number, card]));
  const selectedGroup = name ? consolidatedArchetypes.find((item) => item.name.toLowerCase() === name.toLowerCase()) : undefined;
  const selectedName = selectedGroup?.name;
  usePageMeta(selectedName ?? "Archetypes", selectedName ? `Browse every ${selectedName} CCG card and related support.` : "Browse every CCG archetype and named series.");

  if (name && !selectedName) return <section className="card"><h1 className="font-display text-4xl">Archetype not found</h1><Link className="btn mt-4" to="/archetypes">Browse archetypes</Link></section>;
  if (selectedGroup) {
    const items = selectedGroup.cardIds.map((id) => cardsById.get(id)).filter((card): card is NonNullable<typeof card> => Boolean(card));
    return <div className="space-y-5"><nav className="text-sm text-slate-500"><Link to="/archetypes" className="hover:underline">Archetypes</Link> / {selectedGroup.name}</nav><section className="card flex flex-wrap items-center gap-5"><span className="archetype-art h-24 w-24 rounded-2xl"><img src={asset(selectedGroup.iconImage)} alt={`${selectedGroup.name} artwork`} /></span><div><p className="text-xs font-bold uppercase tracking-wide text-slate-500">Archetype Library</p><h1 className="font-display text-4xl">{selectedGroup.name}</h1><p className="mt-2 text-sm text-slate-600">{items.length} connected cards.</p></div></section><div className="cards-grid grid gap-4 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">{items.map((card) => <CardTile key={card.passcode} card={card} />)}</div></div>;
  }
  return <div className="space-y-5"><section className="card"><p className="text-xs font-bold uppercase tracking-wide text-slate-500">Connected Card Families</p><h1 className="font-display text-4xl">Archetypes</h1><p className="mt-2 text-sm text-slate-600">Groups are consolidated from printed card names and effect references. One-card labels are excluded.</p></section><div className="grid gap-3 sm:grid-cols-2 lg:grid-cols-3">{consolidatedArchetypes.map((group) => <Link key={group.name} to={`/archetypes/${encodeURIComponent(group.name)}`} className="card flex items-center gap-4 hover:border-accent"><span className="archetype-art h-20 w-20 shrink-0 rounded-xl"><img src={asset(group.iconImage)} alt="" loading="lazy" /></span><div className="min-w-0"><div className="font-display text-2xl leading-tight">{group.name}</div><div className="mt-1 text-sm text-slate-500">{group.cardIds.length} cards</div></div></Link>)}</div></div>;
}
