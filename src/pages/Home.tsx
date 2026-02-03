import { Link } from "react-router-dom";
import news from "../data/news.json";
import sets from "../data/sets.json";
import useCards from "../hooks/useCards";
import useBanlistCards from "../hooks/useBanlistCards";

// tiny util: safe date -> "01 May 2025"
const fmt = (iso: string) => {
  const d = new Date(iso);
  return isNaN(d.valueOf())
    ? iso
    : d.toLocaleDateString(undefined, {
        day: "2-digit",
        month: "short",
        year: "numeric",
      });
};

// sort newest first (expects ISO "YYYY-MM-DD")
const sortedNews = [...news].sort((a, b) => String(b.date).localeCompare(String(a.date)));
const latestNews = sortedNews.slice(0, 4);

// assume sets.json is newest-first; fall back gracefully
const featuredSet = (sets as any[])[0] ?? null;

export default function Home() {
  // Visible custom cards (same visibility rules as Card Database)
  const { cards: customVisible } = useCards({
    includeTCG: false,
    includeCustom: true,
    includeTest: false,
  });

  // Current banlist totals (custom + official TCG)
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

  return (
    <div className="ygo-bg">
      <div className="max-w-6xl mx-auto px-3 py-6 space-y-8">
        {/* Hero */}
        <section className="card relative overflow-hidden border border-purple-500/40 bg-gradient-to-br from-neutral-900/90 via-neutral-900/80 to-neutral-950/95">
          <div className="pointer-events-none absolute inset-0 bg-[radial-gradient(circle_at_top,_rgba(147,51,234,0.22),_transparent_60%),radial-gradient(circle_at_bottom,_rgba(59,130,246,0.14),_transparent_55%)]" />

          <div className="relative grid gap-6 md:grid-cols-[2fr,1.3fr] items-center">
            <div>
              <h1 className="text-3xl md:text-4xl font-semibold tracking-wide mb-3">
                CCG Yugioh Community
              </h1>
              <p className="text-neutral-200 text-sm md:text-base mb-4 max-w-xl">
                A curated hub for custom Yu-Gi-Oh! cards, banlists, and set releases built for
                serious duelists, playgroups, and creators. Browse the full database, explore
                themed sets, and sync the latest ban list directly into YGO Omega.
              </p>

              <div className="flex flex-wrap gap-3">
                <Link to="/cards" className="btn btn-primary">
                  Open Card Database
                </Link>
                <Link to="/banlist" className="btn">
                  View Ban List
                </Link>
                <Link to="/downloads" className="btn">
                  Install in YGO Omega
                </Link>
              </div>
            </div>

            <div className="relative">
                <div className="grid grid-cols-3 gap-3 text-center text-xs">
                <div className="rounded-xl bg-neutral-900/90 border border-purple-500/40 px-3 py-3 shadow-soft">
                  <div className="text-neutral-300 mb-1">Custom Cards</div>
                  <div className="text-2xl font-semibold text-accent">
                    {customVisible.length}
                  </div>
                </div>
                <div className="rounded-xl bg-neutral-900/90 border border-amber-400/40 px-3 py-3 shadow-soft">
                  <div className="text-neutral-300 mb-1">Sets</div>
                  <div className="text-2xl font-semibold text-amber-300">
                    {(sets as any[]).length}
                  </div>
                </div>
                <div className="rounded-xl bg-neutral-900/90 border border-red-500/40 px-3 py-3 shadow-soft">
                  <div className="text-neutral-300 mb-1">Banlist</div>
                  <div className="text-[11px] leading-relaxed">
                    <span className="font-semibold text-red-300">{bannedCount}</span> Banned
                    <br />
                    <span className="font-semibold text-amber-300">{limitedCount}</span> Limited
                    <br />
                    <span className="font-semibold text-blue-300">{semiCount}</span> Semi-Limited
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>

        {/* Featured row */}
        <section className="grid gap-5 md:grid-cols-[1.6fr,1.4fr]">
          {/* Featured set */}
          <div className="card border border-neutral-800/80 bg-neutral-900/90">
            <div className="flex items-center justify-between mb-3">
              <h2 className="text-lg font-semibold">Featured Set</h2>
              <Link to="/releases" className="text-xs text-accent hover:underline">
                View all releases
              </Link>
            </div>
            {featuredSet ? (
              <div className="grid gap-4 md:grid-cols-[1.3fr,1.7fr] items-center">
                <div className="rounded-xl overflow-hidden bg-neutral-950">
                  <img
                    src={featuredSet.coverImage}
                    alt={`${featuredSet.name} cover`}
                    className="w-full h-full object-cover object-center"
                    loading="lazy"
                  />
                </div>
                <div className="space-y-2 text-sm">
                  <div className="text-xs uppercase tracking-wide text-neutral-400">
                    Latest Release
                  </div>
                  <div className="text-base font-semibold">
                    {featuredSet.code} {featuredSet.name}
                  </div>
                  {featuredSet.releaseDate && (
                    <div className="text-xs text-neutral-400">
                      Release date: {featuredSet.releaseDate}
                    </div>
                  )}
                  {featuredSet.description && (
                    <p className="text-neutral-200 text-xs md:text-sm line-clamp-3">
                      {featuredSet.description}
                    </p>
                  )}
                  <Link
                    to={`/cards?set=${encodeURIComponent(featuredSet.code)}`}
                    className="btn btn-primary mt-2 inline-flex"
                  >
                    Browse Set
                  </Link>
                </div>
              </div>
            ) : (
              <p className="text-neutral-300 text-sm">No sets configured yet.</p>
            )}
          </div>

          {/* Quick links / flows */}
          <div className="card border border-neutral-800/80 bg-neutral-900/90">
            <h2 className="text-lg font-semibold mb-3">Get Started</h2>
            <ol className="space-y-2 text-sm text-neutral-200 list-decimal list-inside">
              <li>
                <span className="font-semibold">Browse the Card Database</span> to explore all
                custom monsters, spells, and traps with advanced filtering.
              </li>
              <li>
                <span className="font-semibold">Check the Ban List</span> to see which cards are
                legal, limited, semi-limited, or banned for the current format.
              </li>
              <li>
                <span className="font-semibold">Download the Database for YGO Omega</span> from the{" "}
                <Link to="/downloads" className="text-accent hover:underline">
                  Downloads
                </Link>{" "}
                tab and follow the install steps.
              </li>
              <li>
                <span className="font-semibold">Host duels or events</span> using this shared card
                pool and banlist so everyone plays by the same rules.
              </li>
            </ol>
          </div>
        </section>

        {/* News / updates */}
        <section className="card border border-neutral-800/80 bg-neutral-900/95">
          <div className="flex items-center justify-between mb-3">
            <h2 className="text-lg font-semibold">Latest News</h2>
            <span className="text-xs text-neutral-400">
              Pulled from the most recent community updates
            </span>
          </div>
          {latestNews.length === 0 ? (
            <p className="text-sm text-neutral-300">No news posts yet.</p>
          ) : (
            <ul className="space-y-2 text-sm">
              {latestNews.map((n, i) => {
                const isExternal = /^https?:\/\//i.test(n.link);
                return (
                  <li
                    key={i}
                    className="flex items-center justify-between bg-neutral-950/40 rounded-xl px-3 py-2"
                  >
                    <div>
                      <div className="font-medium">{n.title}</div>
                      <div className="text-[11px] text-neutral-400">{fmt(n.date)}</div>
                    </div>
                    {isExternal ? (
                      <a href={n.link} className="btn text-xs" target="_blank" rel="noreferrer">
                        View
                      </a>
                    ) : (
                      <Link to={n.link} className="btn text-xs">
                        View
                      </Link>
                    )}
                  </li>
                );
              })}
            </ul>
          )}
        </section>
      </div>
    </div>
  );
}
