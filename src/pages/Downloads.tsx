import { useState } from "react";
import cardsData from "../data/cards.json";

const INSTALLER_URL = "https://yugiohccg.github.io/CCG%20Downloads/CCG_Omega_Addon_Setup.exe";
const DB_URL = "https://yugiohccg.github.io/CCG%20Downloads/CCG_v1.db";
const SCRIPTS_ZIP_URL = "https://yugiohccg.github.io/CCG%20Downloads/CCG_Scripts_v1.zip";
const BANLIST_URL = "https://yugiohccg.github.io/CCG%20Downloads/Untitled%20Banlist.lflist.conf";
const IMAGES_BASE = "https://yugiohccg.github.io/CCG%20Downloads";
const IMAGE_PARTS = [
  `${IMAGES_BASE}/YGO_Omega_Images_v1.zip`,
  `${IMAGES_BASE}/YGO_Omega_Images_v2.zip`,
  `${IMAGES_BASE}/YGO_Omega_Images_v3.zip`,
];

export default function Downloads() {
  const [saved, setSaved] = useState(false);

  const handleDownloadJson = () => {
    const blob = new Blob([JSON.stringify(cardsData, null, 2)], {
      type: "application/json",
    });
    const url = URL.createObjectURL(blob);
    const a = document.createElement("a");
    a.href = url;
    a.download = "CCG-Custom-Database.json";
    a.click();
    URL.revokeObjectURL(url);
    setSaved(true);
  };

  return (
    <div className="space-y-6">
      <section className="card anim-rise">
        <p className="text-[12px] font-bold uppercase tracking-[0.14em] text-slate-500">Omega Distribution</p>
        <h2 className="font-display text-4xl leading-none">Downloads</h2>
        <p className="mt-2 text-sm text-slate-600">
          Install the custom package in one click, or pull each file manually.
        </p>
      </section>

      <div className="grid gap-4 lg:grid-cols-2">
        <section className="story-tile anim-rise anim-delay-1">
          <div className="story-tile-body story-tone-blue">
            <div className="story-meta">Recommended</div>
            <h3 className="story-title-small mt-2">One-click Installer</h3>
            <p className="mt-2 text-sm opacity-95">
              Installs both database and scripts automatically. Default path:
              <code className="ml-1 rounded bg-black/20 px-1.5 py-0.5">C:\Program Files (x86)\YGO Omega</code>
            </p>
            <a className="btn mt-4 bg-white/95" href={INSTALLER_URL}>
              Download Installer (.exe)
            </a>
          </div>
        </section>

        <section className="story-tile anim-rise anim-delay-2">
          <div className="story-tile-body story-tone-orange">
            <div className="story-meta">Manual Package</div>
            <h3 className="story-title-small mt-2">Individual Files</h3>
            <div className="mt-3 flex flex-wrap gap-2">
              <a className="btn bg-white/95" href={DB_URL}>
                Database (.db)
              </a>
              <a className="btn bg-white/95" href={SCRIPTS_ZIP_URL}>
                Scripts (.zip)
              </a>
              <a className="btn bg-white/95" href={BANLIST_URL}>
                Banlist (.conf)
              </a>
              {IMAGE_PARTS.map((u, idx) => (
                <a key={u} className="btn bg-white/95" href={u}>
                  Images v{idx + 1}
                </a>
              ))}
              <button type="button" className="btn bg-white/95" onClick={handleDownloadJson}>
                JSON Export
              </button>
            </div>
          </div>
        </section>
      </div>

      {saved && (
        <div className="card border-emerald-300 bg-emerald-50 text-emerald-800">
          JSON export started as <code>CCG-Custom-Database.json</code>.
        </div>
      )}

      <section className="card">
        <h3 className="font-display text-3xl leading-none">Manual Install Steps</h3>
        <ol className="mt-3 space-y-2 text-sm text-slate-700">
          <li className="rounded-lg border border-slate-300/70 bg-white px-3 py-2">
            Place <code>CCG_v1.db</code> in
            <div className="mt-1 text-xs text-slate-500">
              C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases
            </div>
          </li>
          <li className="rounded-lg border border-slate-300/70 bg-white px-3 py-2">
            Extract <code>CCG_Scripts_v1.zip</code> to
            <div className="mt-1 text-xs text-slate-500">
              C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\CCG_Scripts_v1
            </div>
          </li>
          <li className="rounded-lg border border-slate-300/70 bg-white px-3 py-2">
            Extract all image parts directly into
            <div className="mt-1 text-xs text-slate-500">
              C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Arts
            </div>
          </li>
          <li className="rounded-lg border border-slate-300/70 bg-white px-3 py-2">
            Place <code>Untitled Banlist.lflist.conf</code> in
            <div className="mt-1 text-xs text-slate-500">
              C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Banlists
            </div>
          </li>
          <li className="rounded-lg border border-slate-300/70 bg-white px-3 py-2">
            Restart YGO Omega and select the CCG database if prompted.
          </li>
        </ol>
      </section>
    </div>
  );
}
