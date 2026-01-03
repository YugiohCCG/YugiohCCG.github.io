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
      <div className="flex items-center justify-between">
        <div>
          <h1 className="text-2xl font-semibold">Downloads</h1>
          <p className="text-neutral-400 text-sm">
            Get the latest custom database and scripts for YGO Omega.
          </p>
        </div>
      </div>

      <section className="card space-y-3">
        <h2 className="text-lg font-semibold">Option 1: One-click Installer (Recommended)</h2>
        <p className="text-sm text-neutral-300">
          Installs both the database and scripts into YGO Omega automatically. Default path:
          <code className="ml-1">C:\Program Files (x86)\YGO Omega</code>. If Omega is elsewhere, browse to its root.
        </p>
        <a className="btn btn-primary w-fit" href={INSTALLER_URL}>
          Download Installer (.exe)
        </a>
        <p className="text-xs text-neutral-400">
          Re-run this installer anytime to pull the latest files from GitHub.
        </p>
      </section>

      <section className="card space-y-3">
        <h2 className="text-lg font-semibold">Option 2: Manual Install</h2>
        <div className="flex flex-wrap gap-2">
          <a className="btn" href={DB_URL}>
            Download Database (.db)
          </a>
          <a className="btn" href={SCRIPTS_ZIP_URL}>
            Download Scripts (.zip)
          </a>
          <a className="btn" href={BANLIST_URL}>
            Download Banlist (.lflist.conf)
          </a>
          {IMAGE_PARTS.map((u, idx) => (
            <a key={u} className="btn" href={u}>
              Download Images v{idx + 1} (.zip)
            </a>
          ))}
          <button type="button" className="btn" onClick={handleDownloadJson}>
            Download JSON (export)
          </button>
        </div>
        {saved && (
          <div className="text-sm text-green-300">
            JSON export started. Save the file as <code>CCG-Custom-Database.json</code>.
          </div>
        )}
        <ol className="list-decimal list-inside space-y-1 text-sm text-neutral-200">
          <li>
            Place <code>CCG_v1.db</code> into
            <div>
              <code>C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases</code>
            </div>
          </li>
          <li>
            Extract <code>CCG_Scripts_v1.zip</code> into
            <div>
              <code>C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\CCG_Scripts_v1</code>
            </div>
          </li>
          <li>
            Extract all image parts (<code>YGO_Omega_Images_v1.zip</code>, <code>v2</code>, <code>v3</code>, ...)
            directly into
            <div>
              <code>C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Arts</code>
            </div>
            (no extra subfolder)
          </li>
          <li>
            Place <code>Untitled Banlist.lflist.conf</code> into
            <div>
              <code>C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Banlists</code>
            </div>
          </li>
          <li>Restart YGO Omega. Select the CCG database if prompted.</li>
        </ol>
      </section>
    </div>
  );
}
