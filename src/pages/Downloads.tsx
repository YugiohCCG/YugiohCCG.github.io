import { useMemo, useState } from "react";
import { Link } from "react-router-dom";
import cardsData from "../data/cards.json";
import usePageMeta from "../hooks/usePageMeta";
import useRemoteJson from "../hooks/useRemoteJson";
import type { ReleaseArtifact, ReleaseManifest } from "../types/website";
import { asset } from "../utils/assets";

const GROUP_DETAILS: Record<ReleaseArtifact["group"], { label: string; description: string; icon: string }> = {
  installer: { label: "Recommended Installer", description: "Everything required in one guided setup.", icon: "window" },
  database: { label: "Database", description: "Card records and game data.", icon: "database" },
  scripts: { label: "Scripts", description: "Card effects used by the duel engine.", icon: "code" },
  banlist: { label: "Banlist", description: "The current CCG format restrictions.", icon: "shield" },
  arts: { label: "Card Arts", description: "Artwork displayed throughout Omega.", icon: "image" },
  pics: { label: "Full Card Images", description: "Readable, full-resolution card renders.", icon: "cards" },
  holograms: { label: "Holograms", description: "Transparent duel-field card projections.", icon: "sparkle" },
};

const INSTALL_PATHS = [
  ["Database", "CCG_v1.db", String.raw`C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases`],
  ["Scripts", "CCG_Scripts.zip", String.raw`C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts`],
  ["Card Arts", "YGO_Omega_Images_v*.zip", String.raw`C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Arts`],
  ["Full Card Images", "YGO_Omega_Pics_v*.zip", String.raw`C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Pics`],
  ["Holograms", "YGO_Omega_Holograms_v*.zip", String.raw`C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Holograms`],
  ["Banlist", "CCG_Banlist.lflist.conf", String.raw`C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Banlists`],
] as const;

const formatBytes = (bytes: number) => {
  const units = ["B", "KB", "MB", "GB"];
  let value = bytes;
  let unit = 0;
  while (value >= 1024 && unit < units.length - 1) { value /= 1024; unit += 1; }
  return `${value.toFixed(unit > 1 ? 1 : 0)} ${units[unit]}`;
};

const formatDate = (value?: string) => value
  ? new Date(value).toLocaleDateString(undefined, { day: "numeric", month: "short", year: "numeric" })
  : "Unknown";

function Icon({ name }: { name: string }) {
  const paths: Record<string, React.ReactNode> = {
    download: <><path d="M12 3v11" /><path d="m7.5 10 4.5 4.5 4.5-4.5" /><path d="M4 18v2h16v-2" /></>,
    copy: <><rect x="8" y="8" width="11" height="11" rx="2" /><path d="M16 8V6a2 2 0 0 0-2-2H6a2 2 0 0 0-2 2v8a2 2 0 0 0 2 2h2" /></>,
    window: <><rect x="3" y="4" width="18" height="16" rx="2" /><path d="M3 9h18M7 6.5h.01M10 6.5h.01" /></>,
    database: <><ellipse cx="12" cy="5" rx="7" ry="3" /><path d="M5 5v7c0 1.7 3.1 3 7 3s7-1.3 7-3V5M5 12v7c0 1.7 3.1 3 7 3s7-1.3 7-3v-7" /></>,
    code: <><path d="m8 8-4 4 4 4M16 8l4 4-4 4M14 5l-4 14" /></>,
    shield: <path d="M12 3 5 6v5c0 4.6 2.8 8.2 7 10 4.2-1.8 7-5.4 7-10V6l-7-3Z" />,
    image: <><rect x="3" y="4" width="18" height="16" rx="2" /><circle cx="9" cy="9" r="2" /><path d="m3 17 5-5 4 4 3-3 6 6" /></>,
    cards: <><rect x="7" y="3" width="12" height="17" rx="2" /><path d="M7 7H5a2 2 0 0 0-2 2v10a2 2 0 0 0 2 2h8" /></>,
    sparkle: <><path d="m12 2 1.5 5.5L19 9l-5.5 1.5L12 16l-1.5-5.5L5 9l5.5-1.5L12 2Z" /><path d="m19 15 .7 2.3L22 18l-2.3.7L19 21l-.7-2.3L16 18l2.3-.7L19 15Z" /></>,
    check: <path d="m5 12 4 4L19 6" />,
    arrow: <path d="m9 18 6-6-6-6" />,
  };
  return <svg className="download-icon" viewBox="0 0 24 24" aria-hidden="true">{paths[name]}</svg>;
}

function CopyButton({ value, label = "Copy" }: { value: string; label?: string }) {
  const [copied, setCopied] = useState(false);
  const copy = async () => {
    await navigator.clipboard.writeText(value);
    setCopied(true);
    window.setTimeout(() => setCopied(false), 1600);
  };
  return <button type="button" className={`download-copy${copied ? " is-copied" : ""}`} onClick={copy} aria-label={`${label}: ${value}`}><Icon name={copied ? "check" : "copy"} /><span>{copied ? "Copied" : label}</span></button>;
}

function DownloadButton({ file, prominent = false }: { file: ReleaseArtifact; prominent?: boolean }) {
  const [progress, setProgress] = useState<number | null>(null);
  const download = async () => {
    setProgress(0);
    try {
      const response = await fetch(asset(file.path));
      if (!response.ok || !response.body) { setProgress(null); window.location.assign(asset(file.path)); return; }
      const reader = response.body.getReader();
      const chunks: BlobPart[] = [];
      let received = 0;
      while (true) {
        const { done, value } = await reader.read();
        if (done) break;
        chunks.push(value);
        received += value.byteLength;
        setProgress(Math.min(100, Math.round((received / file.bytes) * 100)));
      }
      const url = URL.createObjectURL(new Blob(chunks));
      const anchor = document.createElement("a");
      anchor.href = url;
      anchor.download = file.path.split("/").pop() ?? file.label;
      anchor.click();
      URL.revokeObjectURL(url);
      setProgress(null);
    } catch {
      setProgress(null);
      window.location.assign(asset(file.path));
    }
  };
  return <button type="button" className={`download-action${prominent ? " is-hero" : ""}`} onClick={download} disabled={progress != null}>
    <Icon name="download" /><span>{progress == null ? (prominent ? "Download for Windows" : "Download") : `Downloading ${progress}%`}</span>
    {progress != null && <i style={{ width: `${progress}%` }} />}
  </button>;
}

function ArtifactRow({ file }: { file: ReleaseArtifact }) {
  return <article className="download-file">
    <div className="download-file-main"><div className="download-file-type"><Icon name="download" /></div><div className="download-file-name"><strong>{file.label}</strong><span>{file.path.split("/").pop()} · {formatBytes(file.bytes)}</span></div><DownloadButton file={file} /></div>
    <div className="download-hash"><span>SHA-256</span><code title={file.sha256}>{file.sha256}</code><CopyButton value={file.sha256} label="Copy hash" /></div>
  </article>;
}

export default function Downloads() {
  usePageMeta("Downloads", "Download the verified Yu-Gi-Oh! CCG package for YGO Omega.");
  const [saved, setSaved] = useState(false);
  const { data: manifest, loading, error } = useRemoteJson<ReleaseManifest>("data/release-manifest.json");
  const grouped = useMemo(() => {
    const groups = new Map<ReleaseArtifact["group"], ReleaseArtifact[]>();
    for (const file of manifest?.files ?? []) groups.set(file.group, [...(groups.get(file.group) ?? []), file]);
    return groups;
  }, [manifest]);
  const installer = grouped.get("installer")?.[0];
  const manualGroups = (["database", "scripts", "banlist", "arts", "pics", "holograms"] as const).filter((group) => grouped.has(group));
  const manualFiles = manualGroups.flatMap((group) => grouped.get(group) ?? []);
  const manualSize = manualFiles.reduce((total, file) => total + file.bytes, 0);

  const handleDownloadJson = () => {
    const blob = new Blob([JSON.stringify(cardsData, null, 2)], { type: "application/json" });
    const url = URL.createObjectURL(blob);
    const anchor = document.createElement("a");
    anchor.href = url; anchor.download = "CCG-Custom-Database.json"; anchor.click();
    URL.revokeObjectURL(url); setSaved(true);
  };

  return <div className="downloads-page">
    <section className="downloads-hero anim-rise">
      <div className="downloads-hero-glow" aria-hidden="true" />
      <div className="downloads-hero-top">
        <div><p className="downloads-eyebrow"><span /> Omega distribution</p><h1>Get the complete CCG package</h1><p>Install every card, script, image, hologram, and format rule needed to play in YGO Omega.</p></div>
        {manifest && <div className="downloads-release"><span>Current release</span><strong>{manifest.version}</strong><small>Updated {formatDate(manifest.released_at)}</small></div>}
      </div>
      {loading && <div className="downloads-notice" role="status">Loading the latest release…</div>}
      {Boolean(error) && <div className="downloads-notice is-error">Release metadata could not be loaded.</div>}
      {installer && <div className="downloads-installer">
        <div className="downloads-installer-mark"><Icon name="window" /></div>
        <div className="downloads-installer-copy"><span>Recommended for most players</span><h2>One-click Omega installer</h2><p>Guided setup installs or updates every required component while preserving unrelated Omega files.</p><div className="downloads-requirements"><span><Icon name="check" /> Windows</span><span><Icon name="check" /> {formatBytes(installer.bytes)}</span><span><Icon name="check" /> Safe update</span></div></div>
        <div className="downloads-installer-actions"><DownloadButton file={installer} prominent /><Link to="/releases">See release notes <Icon name="arrow" /></Link></div>
      </div>}
      {manifest && <div className="downloads-stats"><div><strong>{manifest.card_count}</strong><span>Playable cards</span></div><div><strong>{manifest.monster_count}</strong><span>Monsters</span></div><div><strong>{manualFiles.length}</strong><span>Verified files</span></div><div><strong>SHA-256</strong><span>Checksums included</span></div></div>}
    </section>

    {manualGroups.length > 0 && <section className="downloads-section anim-rise anim-delay-1" id="manual-downloads">
      <header className="downloads-section-head"><div><p className="downloads-eyebrow">Manual package</p><h2>Choose individual files</h2><p>For advanced installs, repairs, or downloading only the assets you need.</p></div><div className="downloads-section-tools"><span>{manualFiles.length} files · {formatBytes(manualSize)}</span><button type="button" onClick={handleDownloadJson}><Icon name="download" /> Export card JSON</button></div></header>
      {saved && <div className="downloads-saved" role="status"><Icon name="check" /> JSON export started as <code>CCG-Custom-Database.json</code>.</div>}
      <div className="downloads-groups">{manualGroups.map((group) => {
        const files = grouped.get(group) ?? [];
        const detail = GROUP_DETAILS[group];
        return <section className={`download-group is-${group}`} key={group}><header><div className="download-group-icon"><Icon name={detail.icon} /></div><div><h3>{detail.label}</h3><p>{detail.description}</p></div><span>{files.length} {files.length === 1 ? "file" : "parts"}</span></header><div className="download-group-files">{files.map((file) => <ArtifactRow key={file.path} file={file} />)}</div></section>;
      })}</div>
    </section>}

    <section className="downloads-section downloads-install-guide">
      <header className="downloads-section-head"><div><p className="downloads-eyebrow">Manual setup</p><h2>Install in six steps</h2><p>Extract every numbered archive part, then place each component in its matching Omega folder.</p></div><span className="downloads-guide-badge">Default Windows paths</span></header>
      <ol className="downloads-steps">{INSTALL_PATHS.map(([label, file, path], index) => <li key={label}><div className="downloads-step-number">{String(index + 1).padStart(2, "0")}</div><div className="downloads-step-copy"><span>{label}</span><strong>{file}</strong><div><code>{path}</code><CopyButton value={path} /></div></div></li>)}</ol>
      <div className="downloads-restart"><span><Icon name="check" /></span><div><strong>Finish the installation</strong><p>Restart YGO Omega, then select the CCG database if prompted.</p></div></div>
    </section>

    <section className="downloads-section downloads-help">
      <header className="downloads-section-head"><div><p className="downloads-eyebrow">Support</p><h2>Troubleshooting</h2><p>Quick answers to the most common installation issues.</p></div></header>
      <div className="downloads-faq">
        <details><summary>Omega is installed somewhere else <Icon name="arrow" /></summary><p>Choose the folder containing <code>YGO Omega.exe</code> in the installer, or replace the root shown in the manual paths.</p></details>
        <details><summary>Cards appear without images or holograms <Icon name="arrow" /></summary><p>Confirm every numbered ZIP part was extracted into its matching folder, then restart Omega.</p></details>
        <details><summary>Scarstech Circuit victory text is missing <Icon name="arrow" /></summary><p>Back up <code>YGO Omega_Data\Files\Bundles\strdata.conf</code>, then append <code>!victory 0x24 Victory by the effect of &quot;Scarstech Circuit&quot;</code> once.</p></details>
        <details><summary>How do I verify a download? <Icon name="arrow" /></summary><p>Compute its SHA-256 hash and compare it with the value beside the file. A mismatch means the download is incomplete or stale.</p></details>
      </div>
    </section>
  </div>;
}
