import { Link as RouterLink, useLocation, type LinkProps } from "react-router-dom";

export const TOKYO_BASE = "/";
export function isPrintPath(path: string) {
  return path !== "/legacy" && !path.startsWith("/legacy/");
}
export function tokyoPath(path: string) { return path; }
export function legacyPath(path: string) {
  return path.startsWith("/") && !path.startsWith("//") && path !== "/legacy" && !path.startsWith("/legacy/")
    ? `/legacy${path === "/" ? "" : path}` : path;
}
export default function SiteLink({ to, ...props }: LinkProps) {
  const { pathname } = useLocation();
  const destination = isPrintPath(pathname) ? to : typeof to === "string" ? legacyPath(to)
    : { ...to, pathname: to.pathname ? legacyPath(to.pathname) : to.pathname };
  return <RouterLink {...props} to={destination} />;
}
