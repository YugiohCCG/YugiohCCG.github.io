import { useEffect, useState } from "react";
import { Outlet, NavLink, useLocation } from "react-router-dom";
import { ImageViewerProvider } from "./components/ImageViewer";

type NavItem =
  | { to: string; label: string; end?: boolean }
  | { href: string; label: string };

const PRIMARY_NAV_ITEMS: NavItem[] = [
  { to: "/", label: "Home", end: true },
  { to: "/releases", label: "Releases" },
  { to: "/cards", label: "Card Database" },
  { to: "/archetypes", label: "Archetypes" },
  { to: "/banlist", label: "Ban List" },
  { to: "/deck-builder", label: "Deck Builder" },
  { to: "/downloads", label: "Downloads" },
  { to: "/draft", label: "Draft" },
  { href: "https://yu-gi-oh-custom-card-game.github.io/ccg-interspace/", label: "Interspace" },
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
  const [menuOpen, setMenuOpen] = useState(false);
  const location = useLocation();

  useEffect(() => {
    const root = document.documentElement;
    root.setAttribute("data-theme", theme);
    root.style.colorScheme = theme === "night" ? "dark" : "light";
    window.localStorage.setItem(THEME_KEY, theme);
  }, [theme]);

  useEffect(() => setMenuOpen(false), [location.pathname]);

  const navLinks = (items: NavItem[], mobile = false) => items.map((item) =>
    "href" in item ? (
      <a key={item.href} href={item.href} target="_blank" rel="noopener noreferrer" className="site-nav-link" onClick={() => mobile && setMenuOpen(false)}>
        <span>{item.label}</span><span className="site-nav-external" aria-hidden="true">↗</span>
      </a>
    ) : (
      <NavLink key={item.to} to={item.to} end={item.end} className={({ isActive }) => `site-nav-link ${isActive ? "site-nav-link-active" : ""}`} data-theme={theme} onClick={() => mobile && setMenuOpen(false)}>{item.label}</NavLink>
    )
  );

  return (
    <ImageViewerProvider>
      <div className="app-frame flex min-h-full flex-col">
        <a href="#main-content" className="skip-link">Skip to content</a>
        <header className="site-header sticky top-0 z-40">
          <div className="site-header-shell">
            <div className="site-header-row">
              <NavLink to="/" end className="site-brand" aria-label="Yu-Gi-Oh! CCG home">
                <img
                  src="/assets/branding/yugioh-ccg-logo-exact.png"
                  alt="Yu-Gi-Oh! CCG"
                  className="site-brand-logo"
                />
              </NavLink>

              <div className="site-header-actions">
                <nav className="site-navigation" aria-label="Primary navigation">
                  {navLinks(PRIMARY_NAV_ITEMS)}
                </nav>

                <button type="button" className="menu-toggle" aria-expanded={menuOpen} aria-controls="mobile-navigation" aria-label="Toggle navigation" onClick={() => setMenuOpen((value) => !value)}>
                  <span className="menu-toggle-label">Menu</span>
                  <span aria-hidden="true" className={`menu-toggle-icon ${menuOpen ? "is-open" : ""}`}><i /><i /></span>
                </button>

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
                    <span className="theme-toggle-thumb" />
                    <span className="theme-toggle-attribute theme-toggle-attribute-dark">
                      <img src="/assets/misc/DARK.svg" alt="" />
                    </span>
                    <span className="theme-toggle-attribute theme-toggle-attribute-light">
                      <img src="/assets/misc/LIGHT.svg" alt="" />
                    </span>
                  </span>
                </button>
              </div>
            </div>
            {menuOpen && <nav id="mobile-navigation" className="mobile-navigation" aria-label="Mobile navigation">{navLinks(PRIMARY_NAV_ITEMS, true)}</nav>}
          </div>
        </header>

        <main id="main-content" className="site-main flex-1" tabIndex={-1}>
          <div className="site-shell px-4 py-6 md:py-8">
            <Outlet />
          </div>
        </main>

        <footer className="site-footer site-shell px-4 pb-8">
          <div className="site-footer-inner">
            <span className="site-footer-mark">CCG</span>
            <span>Curated by the Yu-Gi-Oh! Custom Card Game community</span>
            <span className="site-footer-year">© {new Date().getFullYear()}</span>
          </div>
        </footer>
      </div>
    </ImageViewerProvider>
  );
}
