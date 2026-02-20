import { useSearchParams } from "react-router-dom";

type Dir = "asc" | "desc";
const SORTS = [
  { key: "name", label: "Name", defaultDir: "asc" as Dir },
  { key: "date", label: "Date Added", defaultDir: "desc" as Dir },
  { key: "atk", label: "ATK", defaultDir: "desc" as Dir },
  { key: "def", label: "DEF", defaultDir: "desc" as Dir },
  { key: "level", label: "Level", defaultDir: "desc" as Dir },
  { key: "rank", label: "Rank", defaultDir: "desc" as Dir },
  { key: "link", label: "Link", defaultDir: "desc" as Dir },
];

export default function CardsToolbar({ total }: { total: number }) {
  const [params, setParams] = useSearchParams();
  const view = (params.get("view") || "grid") as "grid" | "list";
  const sort = params.get("sort") || "name";
  const active = SORTS.find((s) => s.key === sort) || SORTS[0];
  const dirParam = params.get("dir") as Dir | null;
  const dir: Dir = dirParam ?? active.defaultDir;

  const setSort = (key: string) => {
    const p = new URLSearchParams(params);
    if (key === sort) {
      p.set("dir", dir === "asc" ? "desc" : "asc");
    } else {
      p.set("sort", key);
      const def = SORTS.find((s) => s.key === key)?.defaultDir ?? "asc";
      p.set("dir", def);
    }
    setParams(p, { replace: true });
  };

  const setView = (v: "grid" | "list") => {
    const p = new URLSearchParams(params);
    p.set("view", v);
    setParams(p, { replace: true });
  };

  const arrow = (k: string) => {
    if (k !== sort) return null;
    return <span className="ml-1">{dir === "asc" ? "^" : "v"}</span>;
  };

  return (
    <div className="card">
      <div className="flex flex-col gap-3 md:flex-row md:items-center md:justify-between">
        <div className="text-sm text-slate-600">{total.toLocaleString()} cards</div>

        <div className="flex flex-wrap items-center gap-2">
          <div className="flex flex-wrap gap-1 rounded-lg border border-slate-300 bg-white p-1">
            {SORTS.map((s) => (
              <button
                key={s.key}
                type="button"
                onClick={() => setSort(s.key)}
                className={
                  `rounded-md px-3 py-1.5 text-xs font-bold uppercase tracking-wide transition ` +
                  (sort === s.key
                    ? "bg-accent text-white"
                    : "bg-transparent text-slate-600 hover:bg-slate-100")
                }
                title={`Sort by ${s.label}`}
              >
                {s.label}
                {arrow(s.key)}
              </button>
            ))}
          </div>

          <div className="flex gap-1 rounded-lg border border-slate-300 bg-white p-1">
            <button
              type="button"
              className={`rounded-md px-3 py-1.5 text-xs font-bold uppercase tracking-wide ${view === "grid" ? "bg-accent text-white" : "text-slate-600 hover:bg-slate-100"}`}
              onClick={() => setView("grid")}
            >
              Grid
            </button>
            <button
              type="button"
              className={`rounded-md px-3 py-1.5 text-xs font-bold uppercase tracking-wide ${view === "list" ? "bg-accent text-white" : "text-slate-600 hover:bg-slate-100"}`}
              onClick={() => setView("list")}
            >
              List
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}
