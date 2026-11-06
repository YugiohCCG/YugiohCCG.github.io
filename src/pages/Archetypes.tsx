import { useState } from "react";
import sampleDecks from "../data/sample-decks.json";
import artworkSelection from "../../public/assets/deck-boxes/artwork-selection.json";
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
    const samples = Object.entries(sampleDecks).filter(([, sample]) => sample.archetype === selectedGroup.name);
    const items = selectedGroup.cardIds.map((id) => cardsById.get(id)).filter((card): card is NonNullable<typeof card> => Boolean(card)).sort((a, b) => a.name.localeCompare(b.name));
    return (
      <div className="space-y-4">
        <nav className="text-sm text-slate-500">
          <Link to="/archetypes" className="hover:underline">Archetypes</Link> / {selectedGroup.name}
        </nav>
        <header className="archetype-detail-heading flex flex-wrap items-center gap-3 border-b border-[color:var(--line-strong)] pb-3">
          <span className="archetype-art h-14 w-14 shrink-0">
            <img src={asset(selectedGroup.iconImage)} alt="" />
          </span>
          <div className="flex-1">
            <h1 className="font-display text-3xl leading-none">{selectedGroup.name}</h1>
            <p className="mt-1 text-xs">{items.length} cards</p>
          </div>
          {samples.length > 0 && (
            <div className="flex flex-wrap gap-2">
              {samples.map(([id, sample]) => (
                <Link key={id} className="btn text-xs"
                  title={sample.name}
                  aria-label={`Load sample deck ${sample.name} in Deck Builder`}
                  to={{ pathname: "/deck-builder", search: `?sample=${id}` }}>
                  {samples.length === 1 ? "Load sample deck" : sample.name} <span aria-hidden="true">↗</span>
                </Link>
              ))}
            </div>
          )}
        </header>
        <div className="cards-grid grid gap-4 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4">
          {items.map((card) => <CardTile key={card.passcode} card={card} />)}
        </div>
      </div>
    );
  }
  return <ArchetypeDirectory />;
}
const collections = [
  { kind: "custom", title: "Custom Archetypes & Series", description: "Original card families created for CCG." },
  { kind: "support", title: "Custom Support", description: "CCG cards for existing Yu-Gi-Oh! archetypes, series, and monster types." },
] as const;

const sampleArchetypes = new Set(Object.values(sampleDecks).map(sample => sample.archetype));

function ArchetypeDirectory() {
  const [samplesOnly, setSamplesOnly] = useState(false);
  return <div className="space-y-6 archetype-library-page">
    <h1 className="sr-only">Archetypes</h1>
    {collections.map((collection) => {
      const families = archetypeFamilies.filter(family =>
        family.kind === collection.kind && (!samplesOnly || sampleArchetypes.has(family.family))
      );
      if (!families.length) return null;
      return (
        <section key={collection.kind}>
          <div className="library-section-heading">
            <div className="library-heading-row flex flex-wrap items-center justify-between gap-3">
              <PrintTitle as="h2" caption="CHOOSE YOUR / STRATEGY" className="font-display text-3xl">{collection.title}</PrintTitle>
              {collection.kind === "custom" && (
                <div className="sample-deck-controls ml-auto flex flex-wrap items-center justify-end gap-x-4 gap-y-2">
                  <label className="inline-flex cursor-pointer items-center gap-2 text-xs font-bold">
                    <input type="checkbox" role="switch" checked={samplesOnly}
                      onChange={(event) => setSamplesOnly(event.target.checked)} className="peer sr-only" />
                    <span className="sample-deck-switch" aria-hidden="true" />
                    Includes sample deck
                  </label>
                  <p className="flex items-center gap-1.5 text-xs">
                    <span className="sample-deck-marker" aria-hidden="true" />
                    Sample deck available
                  </p>
                </div>
              )}
            </div>
            <p>{collection.description}</p>
          </div>
          <div className="library-box-grid">
            {families.map((family) => {
              const hasSample = sampleArchetypes.has(family.family);
              const defaultArtwork = `${family.group.iconCardId}.webp`;
              const artwork = family.family === "Ohmen"
                ? artworkSelection.find(item => item.family === family.family)?.asset ?? defaultArtwork
                : defaultArtwork;
              return (
                <Link key={family.family} to={`/archetypes/${encodeURIComponent(family.family)}`} className="library-box-link relative">
                  {hasSample && <span className="sample-deck-marker absolute right-3 top-3" role="img" aria-label="Sample deck available" />}
                  <div className="library-box">
                    <img className="library-box-render" src={asset(`/assets/deck-boxes/${artwork}?v=7`)} alt="" loading="lazy" width="400" height="600" />
                  </div>
                  <h3>{family.family}</h3>
                </Link>
              );
            })}
          </div>
        </section>
      );
    })}
  </div>;
}
