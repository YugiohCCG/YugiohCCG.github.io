import type { Card } from "../types/card";
import { useImageViewer } from "./ImageViewer";
import { asset } from "../utils/assets";
import LegalityBadge, { legalStatus } from "./LegalityBadge";

type Props = { card: Card; imageHeight?: number };

export default function CardTile({ card, imageHeight }: Props) {
  const { open } = useImageViewer();
  const imgSrc = asset(card.image); // handles relative & absolute
  const status = legalStatus((card as any).legal);

  return (
    <div className="relative w-full h-full">
      <div className="card">
        <div
          className="w-full rounded-xl cursor-zoom-in bg-neutral-900 overflow-hidden"
          style={imageHeight ? { height: imageHeight } : { aspectRatio: "1 / 1.45965417867" }}
          onClick={() => open(imgSrc, card.name, status)}
          title="Click to enlarge"
        >
          <img
            src={imgSrc}
            alt={card.name}
            className="w-full h-full object-contain object-center"
            loading="lazy"
          />
        </div>
      </div>
      {status && (
        <LegalityBadge
          status={status}
          className="absolute pointer-events-none z-30"
          size={54}
          style={{ top: -14, left: -14 }}
        />
      )}
    </div>
  );
}
