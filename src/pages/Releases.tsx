import { Link } from "react-router-dom";
import sets from "../data/sets.json";
import { asset } from "../utils/assets";

const RELEASE_TONE_ROTATION = ["story-tone-blue", "story-tone-mint", "story-tone-orange", "story-tone-violet", "story-tone-red", "story-tone-slate"];

const RELEASE_TONES_BY_CODE: Record<string, string> = {
  CHST: "story-tone-blue",
  PHPA: "story-tone-violet",
  DAEL: "story-tone-orange",
  COOR: "story-tone-red",
  TATA: "story-tone-slate",
};

export default function Releases() {
  return (
    <div className="space-y-5">
      <section className="card anim-rise">
        <p className="text-[12px] font-bold uppercase tracking-[0.14em] text-slate-500">Set Library</p>
        <h2 className="font-display text-4xl leading-none">Release Archive</h2>
      </section>

      <section className="release-grid grid gap-4 md:grid-cols-2 xl:grid-cols-3">
        {sets.map((s, i) => {
          const to = `/cards?set=${encodeURIComponent(s.code)}`;
          const cover = asset(s.coverImage || "");
          const toneClass = RELEASE_TONES_BY_CODE[s.code] ?? RELEASE_TONE_ROTATION[i % RELEASE_TONE_ROTATION.length];

          return (
            <Link
              key={s.code}
              to={to}
              className="story-tile release-card anim-rise block h-full overflow-hidden focus:outline-none focus-visible:ring-2 focus-visible:ring-accent"
              style={{ animationDelay: `${Math.min(i, 6) * 55}ms` }}
              title={`Open ${s.code} ${s.name}`}
            >
              <div className="story-tile-media aspect-[818/1288]">
                <img
                  src={cover}
                  alt={`${s.name} cover`}
                  className="h-full w-full object-cover object-center"
                  loading="lazy"
                />
              </div>

              <div className={`story-tile-body release-tile-body ${toneClass}`}>
                <div className="release-tile-copy">
                  <p className="story-meta">{s.code}</p>
                  <h3 className="story-title-small release-tile-title line-clamp-2">{s.name}</h3>
                  {s.releaseDate && <p className="release-tile-date text-sm opacity-90">{s.releaseDate}</p>}
                </div>
                <span className="btn release-tile-cta bg-white/95" aria-hidden="true">
                  View Set
                </span>
              </div>
            </Link>
          );
        })}
      </section>
    </div>
  );
}
