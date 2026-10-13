import PrintTitle from "../components/PrintTitle";
import { useParams } from "react-router-dom";
import Link from "../components/SiteLink";
import CardTile from "../components/CardTile";
import useCards from "../hooks/useCards";
import usePageMeta from "../hooks/usePageMeta";
import { consolidatedArchetypes, standaloneLabels } from "../utils/memberships";
import { asset } from "../utils/assets";
import { archetypeFamilies } from "../utils/archetype-library";

export default function Archetypes() {
  const { name } = useParams();
  const { cards } = useCards({ includeTCG: false, includeCustom: true, includeTest: false, ignoreTextQuery: true });
  const cardsById = new Map(cards.filter((card) => card.passcode != null).map((card) => [card.passcode as number, card]));
  const standaloneCards = cards.filter((card) => !consolidatedArchetypes.some((group) => group.cardIds.includes(card.passcode!))).sort((a, b) => a.name.localeCompare(b.name));
  const groups = [...consolidatedArchetypes, ...(standaloneCards.length ? [{ name: "Standalone & Generic", cardIds: standaloneCards.map((card) => card.passcode!), iconCardId: standaloneCards[0].passcode!, iconName: standaloneCards[0].name, iconImage: standaloneCards[0].image }] : [])].sort((a, b) => a.name.localeCompare(b.name));
  const selectedGroup = name ? groups.find((item) => item.name.toLowerCase() === name.toLowerCase()) ?? (standaloneLabels.has(name) ? groups.find((item) => item.name === "Standalone & Generic") : undefined) : undefined;
  const selectedName = selectedGroup?.name;
  usePageMeta(selectedName ?? "Archetypes", selectedName ? `Browse every ${selectedName} CCG card and related support.` : "Browse every CCG archetype and named series.");

  if (name && !selectedName) return <section className="card"><h1 className="font-display text-4xl">Archetype not found</h1><Link className="btn mt-4" to="/archetypes">Browse archetypes</Link></section>;
  if (selectedGroup) {
    const items = selectedGroup.cardIds.map((id) => cardsById.get(id)).filter((card): card is NonNullable<typeof card> => Boolean(card)).sort((a, b) => a.name.localeCompare(b.name));
    return <div className="space-y-5"><nav className="text-sm text-slate-500"><Link to="/archetypes" className="hover:underline">Archetypes</Link> / {selectedGroup.name}</nav><section className="card flex flex-wrap items-center gap-5"><span className="archetype-art h-24 w-24 rounded-2xl"><img src={asset(selectedGroup.iconImage)} alt={`${selectedGroup.name} artwork`} /></span><div><p className="text-xs font-bold uppercase tracking-wide text-slate-500">{selectedGroup.name === "Standalone & Generic" ? "Card Archive" : "Archetype Library"}</p><PrintTitle as="h1" caption="FAMILY / COLLECTION" className="font-display text-4xl">{selectedGroup.name}</PrintTitle><p className="mt-2 text-sm text-slate-600">{items.length} cards.</p></div></section><div className="cards-grid grid gap-4 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">{items.map((card) => <CardTile key={card.passcode} card={card} />)}</div></div>;
  }
  return <ArchetypeDirectory />;
}
const collections = [
  { kind: "custom", title: "Custom Archetypes & Series", description: "Original card families created for CCG." },
  { kind: "support", title: "Custom Support", description: "CCG cards for existing Yu-Gi-Oh! archetypes, series, and monster types." },
] as const;

function ArchetypeDirectory() {
  return <div className="space-y-6 archetype-library-page">
    <h1 className="sr-only">Archetypes</h1>
    {collections.map((collection) => {
      const families = archetypeFamilies.filter((family) => family.kind === collection.kind);
      if (!families.length) return null;
      return <section key={collection.kind}><div className="library-section-heading"><PrintTitle as="h2" caption="CHOOSE YOUR / STRATEGY" className="font-display text-3xl">{collection.title}</PrintTitle><p>{collection.description}</p></div>
        <div className="library-box-grid">{families.map((family) => <Link key={family.family} to={`/archetypes/${encodeURIComponent(family.family)}`} className="library-box-link"><div className="library-box"><img className="library-box-render" src={asset(`/assets/deck-boxes/${family.group.iconCardId}.webp?v=7`)} alt="" loading="lazy" width="400" height="600" /></div><h3>{family.family}</h3></Link>)}</div>
      </section>;
    })}
  </div>;
}
