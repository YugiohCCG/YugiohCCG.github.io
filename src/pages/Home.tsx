import { Link } from "react-router-dom";
import news from "../data/news.json";
import sets from "../data/sets.json";
import { useMemo, useState } from "react";
import useCards from "../hooks/useCards";
import useBanlistCards from "../hooks/useBanlistCards";
import { useImageViewer } from "../components/ImageViewer";
import { legalStatus } from "../components/LegalityBadge";
import type { Card } from "../types/card";
import { asset } from "../utils/assets";

const fmt = (iso: string) => {
  const d = new Date(iso);
  return Number.isNaN(d.valueOf())
    ? iso
    : d.toLocaleDateString(undefined, {
        day: "2-digit",
        month: "short",
        year: "numeric",
      });
};

const sortedNews = [...news].sort((a, b) => String(b.date).localeCompare(String(a.date)));
const NEWS_BATCH_SIZE = 3;

const sortedSets = [...(sets as any[])].sort((a, b) =>
  String(b.releaseDate ?? "").localeCompare(String(a.releaseDate ?? ""))
);
const OMEGA_HOME_IMAGE = "/assets/misc/Yugioh_Omega_Main.jpg";

const addedAt = (card: Card) => {
  const time = Date.parse(card.timestamps?.added ?? "");
  return Number.isNaN(time) ? -1 : time;
};

function sortByLatestAdded(cards: Card[]) {
  return [...cards].sort((a, b) => {
    const byAdded = addedAt(b) - addedAt(a);
    if (byAdded !== 0) return byAdded;
    return String(b.id ?? "").localeCompare(String(a.id ?? ""), undefined, { numeric: true });
  });
}

const modIndex = (value: number, total: number) => ((value % total) + total) % total;

function buildCarouselOffsets(total: number) {
  const span = Math.min(5, total);
  const leftCount = Math.floor((span - 1) / 2);
  const rightCount = span - leftCount - 1;
  const offsets: number[] = [];
  for (let offset = -leftCount; offset <= rightCount; offset += 1) {
    offsets.push(offset);
  }
  return offsets;
}

export default function Home() {
  const { open } = useImageViewer();
  const { cards: customVisible } = useCards({
    includeTCG: false,
    includeCustom: true,
    includeTest: false,
  });

  const { cards: allSource } = useCards({
    includeTCG: true,
    includeCustom: true,
    includeTest: false,
  });

  const { withLegal } = useBanlistCards("TCG");
  const allWithLegal = withLegal(allSource as any);

  const bannedCount = allWithLegal.filter((c: any) => c.legal?.banned).length;
  const limitedCount = allWithLegal.filter(
    (c: any) => c.legal?.limited && !c.legal?.banned
  ).length;
  const semiCount = allWithLegal.filter(
    (c: any) => c.legal?.semiLimited && !c.legal?.limited && !c.legal?.banned
  ).length;

  const [hero, sideA, sideB, rowA, rowB] = sortedSets;
  const latestCards = useMemo(
    () =>
      sortByLatestAdded(customVisible as Card[])
        .filter((card) => Boolean(card.image))
        .slice(0, 14),
    [customVisible]
  );
  const [activeLatest, setActiveLatest] = useState(0);
  const [visibleNewsCount, setVisibleNewsCount] = useState(
    Math.min(NEWS_BATCH_SIZE, sortedNews.length)
  );

  const latestWindow = useMemo(() => {
    if (latestCards.length === 0) return [];
    const offsets = buildCarouselOffsets(latestCards.length);
    return offsets.map((offset) => {
      const index = modIndex(activeLatest + offset, latestCards.length);
      return { card: latestCards[index], offset, index };
    });
  }, [activeLatest, latestCards]);

  const canCycleLatest = latestCards.length > 1;
  const visibleNews = sortedNews.slice(0, visibleNewsCount);
  const canShowMoreNews = visibleNewsCount < sortedNews.length;
  const canShowLessNews = visibleNewsCount > NEWS_BATCH_SIZE;

  const cycleLatest = (step: number) => {
    if (!canCycleLatest) return;
    setActiveLatest((current) => modIndex(current + step, latestCards.length));
  };

  const toggleNewsList = () => {
    if (canShowMoreNews) {
      setVisibleNewsCount((count) => Math.min(count + NEWS_BATCH_SIZE, sortedNews.length));
      return;
    }
    setVisibleNewsCount(Math.min(NEWS_BATCH_SIZE, sortedNews.length));
  };

  return (
    <div className="space-y-6">
      <section className="card anim-rise">
        <div className="flex flex-wrap items-end justify-between gap-3">
          <div>
            <p className="text-[12px] font-bold uppercase tracking-[0.14em] text-slate-500">
              Editorial Hub
            </p>
            <h2 className="font-display text-4xl leading-none">Latest CCG Stories and Releases</h2>
            <p className="mt-2 max-w-2xl text-sm text-slate-600">
            </p>
          </div>

          <div className="home-metrics">
            <div className="home-metric home-metric-cards">
              <div className="home-metric-label">Cards</div>
              <div className="home-metric-value">{customVisible.length}</div>
            </div>
            <div className="home-metric home-metric-sets">
              <div className="home-metric-label">Sets</div>
              <div className="home-metric-value">{sortedSets.length}</div>
            </div>
            <div className="home-metric home-metric-banned">
              <div className="home-metric-label">Banned</div>
              <div className="home-metric-value home-metric-value-status">{bannedCount}</div>
            </div>
            <div className="home-metric home-metric-limited">
              <div className="home-metric-label">Limited</div>
              <div className="home-metric-value home-metric-value-status">{limitedCount}</div>
            </div>
            <div className="home-metric home-metric-semi">
              <div className="home-metric-label">Semi-Limited</div>
              <div className="home-metric-value home-metric-value-status">{semiCount}</div>
            </div>
          </div>
        </div>
      </section>

      {(hero || sideA) && (
        <section className="home-set-grid grid items-start gap-4 lg:grid-cols-3">
          {hero && (
            <Link
              to={`/cards?set=${encodeURIComponent(hero.code)}`}
              className="story-tile home-set-tile-link anim-rise lg:col-span-2"
              aria-label={`Open ${hero.name} set`}
            >
              <div className="story-tile-media home-story-media home-story-media-hero">
                <img
                  src={asset(hero.homeImage || hero.coverImage || "")}
                  alt={`${hero.name} cover`}
                  loading="lazy"
                />
              </div>
              <div className="story-tile-body story-tone-mint">
                <div className="story-meta">Featured Latest Release</div>
                <h3 className="story-title mt-2">
                  CHRONICLES OF THE STARBORN
                </h3>
                {hero.description && <p className="mt-2 text-base opacity-95">{hero.description}</p>}
              </div>
            </Link>
          )}

          <div className="grid gap-4 lg:col-span-1">
            {sideA && (
              <Link
                to="/downloads"
                className="story-tile home-set-tile-link anim-rise anim-delay-1"
                aria-label="Open downloads"
              >
                <div className="story-tile-media home-story-media">
                  <img
                    src={asset(OMEGA_HOME_IMAGE)}
                    alt="YGO Omega setup"
                    loading="lazy"
                  />
                </div>
                <div className="story-tile-body story-tone-violet">
                  <div className="story-meta">Omega Setup</div>
                  <h3 className="story-title-small mt-1">INSTALL CCG ON OMEGA</h3>
                  <p className="mt-0.5 text-sm opacity-95">Autamtic & Manual Instillation</p>
                </div>
              </Link>
            )}

            {sideA && (
              <Link
                to={`/cards?set=${encodeURIComponent(sideA.code)}`}
                className="story-tile home-set-tile-link anim-rise anim-delay-2"
                aria-label={`Open ${sideA.name} set`}
              >
                <div className="story-tile-media home-story-media">
                  <img
                    src={asset(sideA.homeImage || sideA.coverImage || "")}
                    alt={`${sideA.name} cover`}
                    loading="lazy"
                  />
                </div>
                <div className="story-tile-body story-tone-blue">
                  <div className="story-meta">Set Release</div>
                  <h3 className="story-title-small mt-1">PHANTOM PARADE</h3>
                  <p className="mt-0.5 text-sm opacity-95">Release Date: {sideA.releaseDate || "TBA"}</p>
                </div>
              </Link>
            )}
          </div>
        </section>
      )}

      {(sideB || rowA || rowB) && (
        <section className="home-set-grid grid gap-4 md:grid-cols-2 xl:grid-cols-3">
          {sideB && (
            <Link
              to={`/cards?set=${encodeURIComponent(sideB.code)}`}
              className="story-tile home-set-tile-link anim-rise anim-delay-1"
              aria-label={`Open ${sideB.name} set`}
            >
              <div className="story-tile-media home-story-media">
                <img
                  src={asset(sideB.homeImage || sideB.coverImage || "")}
                  alt={`${sideB.name} cover`}
                  loading="lazy"
                />
              </div>
              <div className="story-tile-body story-tone-orange">
                <div className="story-meta">Set Release</div>
                <h3 className="story-title-small mt-1">DAWN OF THE ELEMENTS</h3>
                <p className="mt-0.5 text-sm opacity-95">Release Date: {sideB.releaseDate || "TBA"}</p>
              </div>
            </Link>
          )}

          {rowA && (
            <Link
              to={`/cards?set=${encodeURIComponent(rowA.code)}`}
              className="story-tile home-set-tile-link anim-rise anim-delay-2"
              aria-label={`Open ${rowA.name} set`}
            >
              <div className="story-tile-media home-story-media">
                <img
                  src={asset(rowA.homeImage || rowA.coverImage || "")}
                  alt={`${rowA.name} cover`}
                  loading="lazy"
                />
              </div>
              <div className="story-tile-body story-tone-red">
                <div className="story-meta">Set Release</div>
                <h3 className="story-title-small mt-1">COSMIC ORIGINS</h3>
                <p className="mt-0.5 text-sm opacity-95">Release Date: {rowA.releaseDate || "TBA"}</p>
              </div>
            </Link>
          )}

          {rowB && (
            <Link
              to={`/cards?set=${encodeURIComponent(rowB.code)}`}
              className="story-tile home-set-tile-link anim-rise anim-delay-3"
              aria-label={`Open ${rowB.name} set`}
            >
              <div className="story-tile-media home-story-media">
                <img
                  src={asset(rowB.homeImage || rowB.coverImage || "")}
                  alt={`${rowB.name} cover`}
                  loading="lazy"
                />
              </div>
              <div className="story-tile-body story-tone-slate">
                <div className="story-meta">Set Release</div>
                <h3 className="story-title-small mt-1">TAINTED TALES</h3>
                <p className="mt-0.5 text-sm opacity-95">Release Date: {rowB.releaseDate || "TBA"}</p>
              </div>
            </Link>
          )}
        </section>
      )}

      {latestCards.length > 0 && (
        <section className="latest-carousel anim-rise" aria-label="Latest releases carousel">
          <h3 className="latest-carousel-title">Latest Releases</h3>
          <button
            type="button"
            className="latest-carousel-nav is-prev"
            onClick={() => cycleLatest(-1)}
            disabled={!canCycleLatest}
            aria-label="Previous latest cards"
          >
            <span aria-hidden="true">&lt;</span>
          </button>

          <div className="latest-carousel-track">
            {latestWindow.map(({ card, offset, index }) => (
              <button
                key={`${card.id}-${index}-${offset}`}
                type="button"
                className="latest-carousel-card"
                data-offset={offset}
                onClick={() => open(asset(card.image || ""), card.name, legalStatus((card as any).legal))}
                title={card.name}
                aria-label={`Open ${card.name} image`}
              >
                <img src={asset(card.image || "")} alt={card.name} loading="lazy" />
              </button>
            ))}
          </div>

          <button
            type="button"
            className="latest-carousel-nav is-next"
            onClick={() => cycleLatest(1)}
            disabled={!canCycleLatest}
            aria-label="Next latest cards"
          >
            <span aria-hidden="true">&gt;</span>
          </button>
        </section>
      )}

      <section className="card">
        <div className="mb-3">
          <h3 className="font-display text-3xl leading-none">Latest News</h3>
        </div>

        {sortedNews.length === 0 ? (
          <p className="text-sm text-slate-600">No news posts yet.</p>
        ) : (
          <>
            <ul className="space-y-2">
              {visibleNews.map((item, index) => {
                const isExternal = /^https?:\/\//i.test(item.link);
                return (
                  <li
                    key={`${item.title}-${index}`}
                    className="flex flex-wrap items-center justify-between gap-2 rounded-lg border border-slate-300/70 bg-white px-3 py-2"
                  >
                    <div>
                      <p className="font-bold text-slate-800">{item.title}</p>
                      <p className="text-xs text-slate-500">{fmt(item.date)}</p>
                    </div>

                    {isExternal ? (
                      <a href={item.link} className="btn" target="_blank" rel="noreferrer">
                        Open
                      </a>
                    ) : (
                      <Link to={item.link} className="btn">
                        Open
                      </Link>
                    )}
                  </li>
                );
              })}
            </ul>

            {(canShowMoreNews || canShowLessNews) && (
              <button type="button" className="btn mt-3" onClick={toggleNewsList}>
                {canShowMoreNews ? `Show More (${visibleNewsCount}/${sortedNews.length}) v` : "Show Less ^"}
              </button>
            )}
          </>
        )}
      </section>

    </div>
  );
}
