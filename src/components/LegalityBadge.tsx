import clsx from "clsx";
import type React from "react";

export type LegalityStatus = "banned" | "limited" | "semi";

type LegalLike = {
  banned?: boolean;
  limited?: boolean;
  semiLimited?: boolean;
} | null | undefined;

/** Resolve a card's legal status to the badge variant we display. */
export function legalStatus(legal: LegalLike): LegalityStatus | null {
  if (!legal) return null;
  if (legal.banned) return "banned";
  if (legal.limited) return "limited";
  if (legal.semiLimited) return "semi";
  return null;
}

const LABEL: Record<LegalityStatus, string> = {
  banned: "Banned",
  limited: "Limited",
  semi: "Semi-Limited",
};

type Props = {
  status: LegalityStatus;
  className?: string;
  size?: number;
  style?: React.CSSProperties;
};

export default function LegalityBadge({ status, className, size = 34, style }: Props) {
  const label = LABEL[status];

  return (
    <div
      className={clsx("legality-badge", className)}
      style={{ width: size, height: size, ...style }}
      role="img"
      aria-label={label}
      title={label}
    >
      {renderIcon(status)}
    </div>
  );
}

function renderIcon(status: LegalityStatus) {
  const outer = (
    <>
      <circle cx="32" cy="32" r="30" fill="#d62828" stroke="#0b0b0b" strokeWidth="4" />
      <circle cx="32" cy="32" r="22" fill="#0b0b0b" stroke="#d62828" strokeWidth="3" />
    </>
  );

  if (status === "banned") {
    return (
      <svg viewBox="0 0 64 64" aria-hidden="true">
        {outer}
        <line
          x1="18"
          y1="46"
          x2="46"
          y2="18"
          stroke="#d62828"
          strokeWidth="8"
          strokeLinecap="round"
        />
      </svg>
    );
  }

  const number = status === "limited" ? "1" : "2";

  return (
    <svg viewBox="0 0 64 64" aria-hidden="true">
      {outer}
      <text
        x="32"
        y="42"
        textAnchor="middle"
        fontSize="30"
        fontWeight="800"
        fill="#f7d300"
        fontFamily="'Segoe UI', 'Inter', 'Montserrat', sans-serif"
      >
        {number}
      </text>
    </svg>
  );
}
