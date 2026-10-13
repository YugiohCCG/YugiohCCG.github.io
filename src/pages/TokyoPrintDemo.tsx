import { useNavigate } from "react-router-dom";
import { asset } from "../utils/assets";
import { tokyoPath } from "../components/SiteLink";
import Home from "./Home";

export default function TokyoPrintDemo() {
  const navigate = useNavigate();
  return <>
          <section className="tp-hero">
            <div className="tp-hero-copy"><p className="tp-eyebrow"><span className="tp-red-dot" /> MADE BY DUELISTS. FOR DUELISTS.</p><h1>NEW CARDS.<br /><span>NEW</span><br />POSSIBILITIES.</h1><p className="tp-hero-description">Original archetypes. Fresh support. A whole new way to play Yu-Gi-Oh! Explore the cards our community brings to the table.</p><button className="tp-primary" onClick={() => navigate(tokyoPath("/archetypes"))}>Explore the archetypes <span aria-hidden="true">↗</span></button><div className="tp-hero-foot"><span>NOTHING ORDINARY.<br />EVERYTHING TO PLAY FOR.</span><span className="tp-cross" aria-hidden="true">✳</span></div></div>
            <div className="tp-hero-print"><div className="tp-registration" aria-hidden="true">+<span>+</span></div><div className="tp-feature-art"><img src={asset("/assets/cards/Graydeux_the_Eternal_Grayscale_Entity.png")} alt="Graydeux, the Eternal Grayscale Entity" /><span className="tp-screen" aria-hidden="true" /></div><span className="tp-kanji" lang="ja" aria-hidden="true">決闘</span><span className="tp-print-stamp">NEXT<br />CHAPTER<br /><strong>VEIL</strong></span><div className="tp-print-caption"><span>001 / GRAYDEUX</span><span>VEIL OF ETERNITY — COMING SOON</span></div></div>
          </section>
        <section className="tp-home-original"><Home /></section></>;
}
