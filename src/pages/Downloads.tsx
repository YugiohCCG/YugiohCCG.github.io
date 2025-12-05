import { useState } from "react";
import cardsData from "../data/cards.json";

export default function Downloads() {
  const [saved, setSaved] = useState(false);

  const handleDownload = () => {
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
    <div className="space-y-4">
      <div className="flex items-center justify-between">
        <div>
          <h1 className="text-2xl font-semibold">Downloads</h1>
          <p className="text-neutral-400 text-sm">
            Export the custom card database for YGO Omega.
          </p>
        </div>
        <button type="button" className="btn btn-primary" onClick={handleDownload}>
          Download Database (.json)
        </button>
      </div>

      {saved && (
        <div className="text-sm text-green-300">
          Download started. Save the file as <code>CCG-Custom-Database.json</code>.
        </div>
      )}

      <section className="card space-y-2">
        <h2 className="text-lg font-semibold">Install Instructions (YGO Omega)</h2>
        <ol className="list-decimal list-inside space-y-1 text-sm text-neutral-200">
          <li>Click “Download Database (.json)” above.</li>
          <li>When prompted, save the file as <code>CCG-Custom-Database.json</code>.</li>
          <li>
            Move the saved file to:
            <br />
            <code>C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases</code>
          </li>
          <li>Restart YGO Omega.</li>
          <li>In Omega, select this database from the available list if prompted.</li>
        </ol>
        <p className="text-xs text-neutral-400">
        </p>
      </section>
    </div>
  );
}
