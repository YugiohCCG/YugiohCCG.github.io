import { useMemo, useState } from "react";
import { Link, useSearchParams } from "react-router-dom";
import usePageMeta from "../hooks/usePageMeta";
import useRemoteJson from "../hooks/useRemoteJson";
import type { SupportStatus as SupportStatusData } from "../types/website";

const VERDICTS = ["ALL", "PASS", "FIXED", "UNSUPPORTED", "MANUAL_RULING"];
const tone: Record<string, string> = {
  PASS: "border-emerald-300 bg-emerald-50 text-emerald-800",
  FIXED: "border-sky-300 bg-sky-50 text-sky-800",
  UNSUPPORTED: "border-amber-300 bg-amber-50 text-amber-900",
  MANUAL_RULING: "border-rose-300 bg-rose-50 text-rose-900",
};

export default function SupportStatus() {
  usePageMeta("Card Support Status", "Current implementation, engine-limitation, and ruling status for every CCG card.");
  const { data, loading, error } = useRemoteJson<SupportStatusData>("data/support-status.json");
  const [params, setParams] = useSearchParams();
  const [query, setQuery] = useState(params.get("q") ?? "");
  const verdict = params.get("status") ?? "ALL";
  const results = useMemo(() => (data?.cards ?? []).filter((card) => {
    const matchesText = !query.trim() || `${card.name} ${card.passcode}`.toLowerCase().includes(query.trim().toLowerCase());
    return matchesText && (verdict === "ALL" || card.verdict === verdict);
  }), [data, query, verdict]);
  const setVerdict = (value: string) => {
    const next = new URLSearchParams(params);
    if (value === "ALL") next.delete("status");
    else next.set("status", value);
    setParams(next, { replace: true });
  };

  if (loading) return <div className="card" role="status">Loading implementation reviews…</div>;
  if (error || !data) return <div className="card text-red-700">Support metadata could not be loaded.</div>;
  return <div className="space-y-5">
    <section className="card"><p className="text-xs font-bold uppercase tracking-wide text-slate-500">Transparent QA</p><h1 className="font-display text-4xl">Card Support Status</h1><p className="mt-2 text-sm text-slate-600">Hash-pinned card-by-card effect reviews. Last generated {data.generated_at ? new Date(data.generated_at).toLocaleString() : "unknown"}.</p><div className="mt-4 grid gap-3 sm:grid-cols-2 lg:grid-cols-5">{Object.entries(data.summary.verdicts).map(([key, count]) => <div key={key} className={`rounded-xl border p-3 ${tone[key] ?? "border-slate-300 bg-white"}`}><div className="text-xs font-bold uppercase">{key.replace("_", " ")}</div><div className="font-display text-3xl">{count}</div></div>)}</div></section>
    <section className="card"><div className="flex flex-col gap-3 lg:flex-row"><input type="search" className="min-w-0 flex-1 rounded-lg border border-slate-300 bg-white px-3 py-2" placeholder="Search card name or passcode…" value={query} onChange={(event) => setQuery(event.target.value)} /><div className="flex flex-wrap gap-2">{VERDICTS.map((item) => <button key={item} type="button" className={`btn ${verdict === item ? "btn-primary" : ""}`} onClick={() => setVerdict(item)}>{item.replace("_", " ")}</button>)}</div></div><div className="mt-3 text-sm text-slate-500" aria-live="polite">{results.length} matching cards</div></section>
    <div className="grid gap-3">{results.map((card) => <article key={card.passcode} className="card"><div className="flex flex-wrap items-start justify-between gap-3"><div><Link to={`/cards/${card.passcode}`} className="font-bold text-slate-800 hover:text-accent">{card.name}</Link><div className="text-xs text-slate-500">{card.passcode}</div></div><span className={`rounded-full border px-3 py-1 text-xs font-bold ${tone[card.verdict] ?? "border-slate-300"}`}>{card.verdict.replace("_", " ")}</span></div>{card.issues.length > 0 && <div className="mt-3 space-y-2">{card.issues.map((issue, index) => <details key={`${card.passcode}-${index}`} className="rounded-lg border border-slate-300 bg-white p-3"><summary className="cursor-pointer text-sm font-bold">{issue.verdict.replace("_", " ")}: {issue.clause}</summary>{issue.notes && <p className="mt-2 text-sm text-slate-600">{issue.notes}</p>}</details>)}</div>}</article>)}</div>
  </div>;
}
