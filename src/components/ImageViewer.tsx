import React, { createContext, useContext, useEffect, useRef, useState } from "react";
import { createPortal } from "react-dom";
import LegalityBadge, { type LegalityStatus } from "./LegalityBadge";

type Ctx = { open: (src: string, alt?: string, status?: LegalityStatus | null) => void; close: () => void };
const ImageViewerContext = createContext<Ctx | null>(null);

export function useImageViewer() {
  const ctx = useContext(ImageViewerContext);
  if (!ctx) throw new Error("useImageViewer must be used within <ImageViewerProvider>");
  return ctx;
}

export function ImageViewerProvider({ children }: { children: React.ReactNode }) {
  const [openState, setOpenState] = useState<{ src: string; alt?: string; status?: LegalityStatus | null } | null>(null);
  const dialogRef = useRef<HTMLDivElement>(null);
  const previousFocus = useRef<HTMLElement | null>(null);
  const open = (src: string, alt?: string, status?: LegalityStatus | null) => {
    previousFocus.current = document.activeElement as HTMLElement | null;
    setOpenState({ src, alt, status });
  };
  const close = () => { setOpenState(null); window.setTimeout(() => previousFocus.current?.focus(), 0); };

  useEffect(() => {
    if (!openState) return;
    const previousOverflow = document.body.style.overflow;
    document.body.style.overflow = "hidden";
    dialogRef.current?.querySelector<HTMLElement>("button")?.focus();
    const onKey = (event: KeyboardEvent) => {
      if (event.key === "Escape") close();
      if (event.key !== "Tab" || !dialogRef.current) return;
      const focusable = [...dialogRef.current.querySelectorAll<HTMLElement>('button, [href], [tabindex]:not([tabindex="-1"])')];
      if (!focusable.length) return;
      const first = focusable[0];
      const last = focusable[focusable.length - 1];
      if (event.shiftKey && document.activeElement === first) { event.preventDefault(); last.focus(); }
      else if (!event.shiftKey && document.activeElement === last) { event.preventDefault(); first.focus(); }
    };
    window.addEventListener("keydown", onKey);
    return () => { window.removeEventListener("keydown", onKey); document.body.style.overflow = previousOverflow; };
  }, [openState]);

  return <ImageViewerContext.Provider value={{ open, close }}>{children}{createPortal(openState ? (
    <div className="fixed inset-0 z-[100] flex items-center justify-center bg-black/70 p-4 backdrop-blur-sm" onClick={close} role="dialog" aria-modal="true" aria-label={openState.alt ? `${openState.alt} card image` : "Card image"}>
      <div ref={dialogRef} className="relative max-h-[90vh] max-w-[90vw]" onClick={(event) => event.stopPropagation()}>
        {openState.status && <LegalityBadge status={openState.status} className="pointer-events-none absolute drop-shadow-[0_10px_24px_rgba(0,0,0,0.6)]" size={54} style={{ top: -14, left: -14 }} />}
        <button className="absolute -right-3 -top-3 grid h-9 w-9 place-items-center rounded-full border border-slate-300 bg-white text-xl leading-none text-slate-700 shadow-sm" onClick={close} aria-label="Close image viewer" title="Close">×</button>
        <img src={openState.src} alt={openState.alt || ""} className="max-h-[90vh] max-w-[90vw] rounded-lg object-contain" />
      </div>
    </div>
  ) : null, document.body)}</ImageViewerContext.Provider>;
}
