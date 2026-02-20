import React, { createContext, useContext, useEffect, useState } from "react";
import { createPortal } from "react-dom";
import LegalityBadge, { type LegalityStatus } from "./LegalityBadge";

type Ctx = {
  open: (src: string, alt?: string, status?: LegalityStatus | null) => void;
  close: () => void;
};

const ImageViewerContext = createContext<Ctx | null>(null);

export function useImageViewer() {
  const ctx = useContext(ImageViewerContext);
  if (!ctx) throw new Error("useImageViewer must be used within <ImageViewerProvider>");
  return ctx;
}

export function ImageViewerProvider({ children }: { children: React.ReactNode }) {
  const [openState, setOpenState] = useState<{
    src: string;
    alt?: string;
    status?: LegalityStatus | null;
  } | null>(null);

  const open = (src: string, alt?: string, status?: LegalityStatus | null) =>
    setOpenState({ src, alt, status });
  const close = () => setOpenState(null);

  useEffect(() => {
    if (!openState) return;
    const onKey = (e: KeyboardEvent) => e.key === "Escape" && close();
    window.addEventListener("keydown", onKey);
    return () => window.removeEventListener("keydown", onKey);
  }, [openState]);

  return (
    <ImageViewerContext.Provider value={{ open, close }}>
      {children}
      {createPortal(
        openState ? (
          <div
            className="fixed inset-0 z-[100] flex items-center justify-center bg-black/70 p-4 backdrop-blur-sm"
            onClick={close}
            role="dialog"
            aria-modal="true"
          >
            <div className="relative max-h-[90vh] max-w-[90vw]" onClick={(e) => e.stopPropagation()}>
              {openState.status && (
                <LegalityBadge
                  status={openState.status}
                  className="pointer-events-none absolute drop-shadow-[0_10px_24px_rgba(0,0,0,0.6)]"
                  size={54}
                  style={{ top: -14, left: -14 }}
                />
              )}

              <button
                className="absolute -right-3 -top-3 grid h-9 w-9 place-items-center rounded-full border border-slate-300 bg-white text-xl leading-none text-slate-700 shadow-sm"
                onClick={close}
                aria-label="Close"
                title="Close"
              >
                X
              </button>

              <img
                src={openState.src}
                alt={openState.alt || ""}
                className="max-h-[90vh] max-w-[90vw] rounded-lg object-contain"
              />
            </div>
          </div>
        ) : null,
        document.body
      )}
    </ImageViewerContext.Provider>
  );
}
