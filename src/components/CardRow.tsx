import type { ReactNode } from "react";
import clsx from "clsx";
import type { Card } from "../types/card";
import { useImageViewer } from "./ImageViewer";
import { asset } from "../utils/assets";
import LegalityBadge, { legalStatus } from "./LegalityBadge";

const RATIO = 1.45965417867;

function Chip({ children }: { children: ReactNode }) {
  return (
    <span className="inline-flex items-center rounded-md border border-slate-300 bg-white px-2 py-0.5 text-[11px] leading-none text-slate-600">
      {children}
    </span>
  );
}

export default function CardRow({ card }: { card: Card }) {
  const isMonster = card.category === "Monster";
  const imgW = 96;
  const imgH = Math.round(imgW * RATIO);
  const { open } = useImageViewer();
  const status = legalStatus((card as any).legal);
  const imgSrc = asset(card.image);

  return (
    <div className="list-row card p-3">
      <div className="grid grid-cols-[auto,1fr,auto] items-start gap-3">
        <button
          type="button"
          className="card-image relative cursor-zoom-in overflow-hidden rounded-lg border border-slate-300 bg-slate-50"
          style={{ width: imgW, height: imgH }}
          onClick={() => open(imgSrc, card.name, status)}
          title="Click to enlarge"
        >
          <img
            src={imgSrc}
            alt={card.name}
            className="h-full w-full rounded-lg object-contain"
            loading="lazy"
          />
        </button>

        <div className="min-w-0">
          <div className="flex items-center gap-2">
            <h3 className="truncate text-sm font-bold uppercase tracking-wide text-slate-800">{card.name}</h3>
            <div className="flex flex-wrap items-center gap-1">
              {isMonster && card.attribute && <Chip>{card.attribute}</Chip>}
              {!isMonster && <Chip>{card.icon || "Normal"}</Chip>}
              {isMonster && (card.level != null || card.rank != null || card.linkRating != null) && (
                <Chip>
                  {card.level != null && <>Level {card.level}</>}
                  {card.rank != null && <>Rank {card.rank}</>}
                  {card.linkRating != null && <>Link {card.linkRating}</>}
                </Chip>
              )}
              {isMonster && card.monsterType?.length ? (
                <Chip>{card.monsterType.join(" / ")}</Chip>
              ) : (
                <Chip>
                  {card.category}
                  {card.cardTypes?.length ? ` | ${card.cardTypes.join(" / ")}` : ""}
                </Chip>
              )}
              {card.scale != null && <Chip>Scale {card.scale}</Chip>}
            </div>
          </div>

          {card.text && <p className="mt-1 line-clamp-3 text-sm text-slate-600">{card.text}</p>}

          <div className="mt-1 text-[12px] text-slate-500">
            {card.archetype && <span>{card.archetype}</span>}
            {card.set && (
              <span className={clsx(card.archetype && "before:content-['|'] before:mx-1")}>
                {card.set}
              </span>
            )}
          </div>
        </div>

        <div className="flex flex-col items-end gap-2 pl-2">
          {status && (
            <LegalityBadge
              status={status}
              className="absolute pointer-events-none z-10"
              size={38}
              style={{ top: -10, left: -10 }}
            />
          )}

          {isMonster ? (
            <div className="text-xs font-semibold text-slate-700">
              <span className="inline-block min-w-[120px] text-right">
                ATK {card.atk ?? "-"} / DEF {card.def ?? "-"}
              </span>
            </div>
          ) : (
            <div className="text-xs text-slate-500">Spell / Trap</div>
          )}

          {card.legal?.banned && (
            <span className="rounded-md border border-red-400 bg-red-50 px-2 py-0.5 text-[11px] font-bold text-red-700">
              BANNED
            </span>
          )}
          {!card.legal?.banned && card.legal?.limited && (
            <span className="rounded-md border border-orange-400 bg-orange-50 px-2 py-0.5 text-[11px] font-bold text-orange-700">
              LIMITED
            </span>
          )}
          {!card.legal?.banned && !card.legal?.limited && card.legal?.semiLimited && (
            <span className="rounded-md border border-yellow-400 bg-yellow-50 px-2 py-0.5 text-[11px] font-bold text-yellow-700">
              SEMI
            </span>
          )}
        </div>
      </div>
    </div>
  );
}
