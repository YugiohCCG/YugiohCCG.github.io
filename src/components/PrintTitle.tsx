import { useLocation } from "react-router-dom";
import type { ReactNode } from "react";
import { isPrintPath } from "./SiteLink";

type Props = { children: ReactNode; caption: string; as?: "h1" | "h2" | "h3"; className?: string };

export default function PrintTitle({ children, caption, as: Heading = "h2", className = "" }: Props) {
  const { pathname } = useLocation();
  const print = isPrintPath(pathname);
  if (!print) return <Heading className={className}>{children}</Heading>;
  return <Heading className={`${className} tp-title-stamp ${Heading === "h3" ? "tp-title-secondary" : ""}`}><span className="tp-title-caption">{caption}</span><span className="tp-title-text">{children}</span></Heading>;
}
