import { useEffect, useState } from "react";
import { Link, NavLink, Outlet, useLocation } from "react-router-dom";
import { ImageViewerProvider } from "../components/ImageViewer";
import { asset } from "../utils/assets";
import PrintTitle from "../components/PrintTitle";
import useRemoteJson from "../hooks/useRemoteJson";
import type { ReleaseManifest } from "../types/website";
import "./tokyo-print.css";

const navigation = [["/", "Home"], ["/releases", "Releases"], ["/cards", "Card Database"], ["/archetypes", "Archetypes"], ["/banlist", "Ban List"], ["/deck-builder", "Deck Builder"], ["/downloads", "Downloads"], ["/draft", "Draft"]];
export default function TokyoPrintLayout() {
  const location = useLocation();
  const section = location.pathname.split("/")[1];
  const pageTitles: Record<string, string> = { releases: "Release Archive", cards: "Card Database", archetypes: "Archetypes", banlist: "Ban List", "deck-builder": "Deck Builder", downloads: "CCG Downloads", support: "Card Support Status" };
  const pageTitle = pageTitles[section];
  const titleCaptions: Record<string, string> = { releases: "COLLECTED / EDITIONS", cards: "CARD / ARCHIVE", archetypes: "CHOOSE YOUR / STRATEGY", banlist: "FORMAT / RULES", "deck-builder": "YOUR NEXT / STRATEGY", downloads: "READY TO / PLAY", support: "CARD / REVIEWS" };
  const { data: releaseManifest } = useRemoteJson<ReleaseManifest>("data/release-manifest.json");
  const [menuOpen, setMenuOpen] = useState(false);
  const [theme, setTheme] = useState(() => localStorage.getItem("ccg_theme_mode") ?? (matchMedia("(prefers-color-scheme: dark)").matches ? "night" : "day"));
  useEffect(() => { document.documentElement.setAttribute("data-theme", theme); document.documentElement.style.colorScheme = theme === "night" ? "dark" : "light"; localStorage.setItem("ccg_theme_mode", theme); }, [theme]);
  useEffect(() => { setMenuOpen(false); window.scrollTo({ top: 0, behavior: "instant" }); }, [location.pathname]);
  return <ImageViewerProvider><div className="tp-demo" data-print-theme={theme}>
    <a className="tp-skip" href="#tp-content">Skip to content</a>
    <div className="tp-paper"><header className="tp-header tp-full-header">
      <Link className="tp-brand" to="/" aria-label="CCG home"><img className="tp-brand-logo" src={asset("/assets/branding/ccg-tokyo-print.png")} alt="Yu-Gi-Oh! CCG" width="2120" height="742" /></Link>
      <div className="tp-header-controls"><button className="tp-menu" aria-expanded={menuOpen} aria-controls="tp-navigation" onClick={() => setMenuOpen(!menuOpen)}>Menu {menuOpen ? "−" : "+"}</button><button className="tp-theme" aria-label={`Switch to ${theme === "day" ? "night" : "day"} mode`} onClick={() => setTheme(theme === "day" ? "night" : "day")}><img src={asset(`/assets/misc/${theme === "day" ? "DARK" : "LIGHT"}.svg`)} alt="" /><span>{theme === "day" ? "Night" : "Day"}</span></button></div>
      <nav id="tp-navigation" className={menuOpen ? "is-open" : ""} aria-label="Primary navigation">{navigation.map(([path, label], index) => <NavLink key={path} to={path} end={path === "/"}><sup>{String(index + 1).padStart(2, "0")}</sup>{label}</NavLink>)}<a href="https://yu-gi-oh-custom-card-game.github.io/ccg-interspace/" target="_blank" rel="noopener noreferrer"><sup>09</sup>Interspace ↗</a></nav>
    </header>
    <main id="tp-content" className={`tp-functional-content ${pageTitle ? "tp-has-page-title" : ""}`} data-print-section={section} tabIndex={-1}>{pageTitle && <header className="tp-page-heading"><PrintTitle as="h1" caption={titleCaptions[section]}>{pageTitle}</PrintTitle>{section === "downloads" && releaseManifest && <div className="tp-current-release"><span>Current release</span><strong>{releaseManifest.version}</strong></div>}</header>}<Outlet /></main>
    <footer className="tp-footer"><div><strong>PLAY YOUR<br /><span>OWN WAY.</span></strong><p>Yu-Gi-Oh! Custom Card Game / Community made. © {new Date().getFullYear()}</p></div><div><NavLink to="/support">Implementation status ↗</NavLink><Link to="/legacy">Legacy website ↗</Link></div></footer></div>
  </div></ImageViewerProvider>;
}
