import { Link } from "react-router-dom";
import usePageMeta from "../hooks/usePageMeta";

export default function NotFound() {
  usePageMeta("Page not found");
  return <section className="card text-center"><div className="font-display text-7xl">404</div><h1 className="mt-2 font-display text-4xl">Page not found</h1><p className="mt-2 text-slate-600">That route does not exist or has moved.</p><Link className="btn btn-primary mt-5" to="/">Return home</Link></section>;
}
