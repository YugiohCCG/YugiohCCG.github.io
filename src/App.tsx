import { useEffect, useState } from "react";
import { Outlet, NavLink } from "react-router-dom";
import { ImageViewerProvider } from "./components/ImageViewer";

const NAV_ITEMS: Array<{ to: string; label: string; end?: boolean }> = [
  { to: "/", label: "Home", end: true },
  { to: "/releases", label: "Set Releases" },
  { to: "/cards", label: "Card Database" },
  { to: "/banlist", label: "Ban List" },
  { to: "/downloads", label: "Downloads" },
];

type ThemeMode = "day" | "night";
const THEME_KEY = "ccg_theme_mode";

function getInitialTheme(): ThemeMode {
  if (typeof window === "undefined") return "day";

  const saved = window.localStorage.getItem(THEME_KEY);
  if (saved === "day" || saved === "night") return saved;

  return window.matchMedia("(prefers-color-scheme: dark)").matches ? "night" : "day";
}

export default function App() {
  const [theme, setTheme] = useState<ThemeMode>(() => getInitialTheme());

  useEffect(() => {
    const root = document.documentElement;
    root.setAttribute("data-theme", theme);
    root.style.colorScheme = theme === "night" ? "dark" : "light";
    window.localStorage.setItem(THEME_KEY, theme);
  }, [theme]);

  return (
    <ImageViewerProvider>
      <div className="flex min-h-full flex-col">
        <header className="site-header sticky top-0 z-40 border-b backdrop-blur">
          <div className="site-shell px-4 py-3">
            <div className="flex flex-wrap items-center justify-between gap-3">
              <NavLink to="/" end className="inline-flex items-center">
                <img
                  src="/assets/branding/yugioh-ccg-logo-exact.png"
                  alt="Yu-Gi-Oh! CCG"
                  className="h-11 w-auto sm:h-12 md:h-14"
                />
              </NavLink>

              <div className="flex items-center gap-2">
                <nav className="flex flex-wrap gap-2">
                  {NAV_ITEMS.map((item) => (
                    <NavLink
                      key={item.to}
                      to={item.to}
                      end={item.end}
                      className={({ isActive }) =>
                        `site-nav-link ${isActive ? "site-nav-link-active" : ""}`
                      }
                    >
                      {item.label}
                    </NavLink>
                  ))}
                </nav>

                <button
                  type="button"
                  className="theme-toggle"
                  onClick={() => setTheme((t) => (t === "day" ? "night" : "day"))}
                  aria-label={`Switch to ${theme === "day" ? "night" : "day"} mode`}
                  title={`Switch to ${theme === "day" ? "night" : "day"} mode`}
                >
                  <span className="sr-only">
                    {theme === "day" ? "Switch to night mode" : "Switch to day mode"}
                  </span>
                  <span className="theme-toggle-track" aria-hidden="true">
                    <span className="theme-toggle-thumb">
                      <span className="theme-toggle-crater theme-toggle-crater-a" />
                      <span className="theme-toggle-crater theme-toggle-crater-b" />
                      <span className="theme-toggle-crater theme-toggle-crater-c" />
                    </span>
                  </span>
                </button>
              </div>
            </div>
          </div>
        </header>

        <main className="flex-1">
          <div className="site-shell px-4 py-6 md:py-8">
            <Outlet />
          </div>
        </main>

        <footer className="site-shell px-4 pb-8 text-xs text-slate-500">
          <div className="rounded-xl border border-slate-300/60 bg-white/70 px-4 py-3">
            (c) {new Date().getFullYear()} CCG Yugioh Community
          </div>
        </footer>
      </div>
    </ImageViewerProvider>
  );
}
