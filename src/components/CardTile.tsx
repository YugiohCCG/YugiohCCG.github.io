import type { Card } from "../types/card";
import { useImageViewer } from "./ImageViewer";
import { asset } from "../utils/assets";
import LegalityBadge, { legalStatus } from "./LegalityBadge";
import { Link } from "react-router-dom";

type Props = { card: Card; imageHeight?: number; detailsEnabled?: boolean };

export default function CardTile({ card, imageHeight, detailsEnabled = true }: Props) {
  const { open } = useImageViewer();
  const imgSrc = asset(card.image);
  const status = legalStatus((card as any).legal);

  return (
    <div className="relative h-full w-full">
      <div className="card h-full">
        <button
          type="button"
          className="w-full cursor-zoom-in overflow-hidden rounded-lg border border-slate-300 bg-slate-50"
          style={imageHeight ? { height: imageHeight } : { aspectRatio: "1 / 1.45965417867" }}
          onClick={() => open(imgSrc, card.name, status)}
          title="Click to enlarge"
        >
          <img
            src={imgSrc}
            alt={card.name}
            className="h-full w-full object-contain object-center"
            loading="lazy"
          />
        </button>

        <div className="mt-3 space-y-1">
          <h3 className="line-clamp-2 text-sm font-bold uppercase tracking-wide text-slate-800">{card.name}</h3>
          <p className="text-xs text-slate-700">{card.set || card.category}</p>
          {detailsEnabled && card.passcode != null && (
            <Link
              className="mt-2 inline-flex text-xs font-bold text-accent hover:underline"
              to={`/cards/${card.passcode}`}
            >
              Card details
            </Link>
          )}
        </div>
      </div>

      {status && (
        <LegalityBadge
          status={status}
          className="pointer-events-none absolute z-30"
          size={52}
          style={{ top: -12, left: -12 }}
        />
      )}
    </div>
  );
}
