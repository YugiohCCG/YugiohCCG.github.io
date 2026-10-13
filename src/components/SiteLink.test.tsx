import { renderToStaticMarkup } from "react-dom/server";
import { MemoryRouter } from "react-router-dom";
import { describe, expect, it } from "vitest";
import SiteLink from "./SiteLink";

describe("shared site navigation", () => {
  it("preserves production links outside the preview", () => {
    const html = renderToStaticMarkup(<MemoryRouter initialEntries={["/cards"]}><SiteLink to="/cards/259229055">Card</SiteLink></MemoryRouter>);
    expect(html).toContain('href="/cards/259229055"');
  });
  it("keeps detail links and release filters inside the legacy site", () => {
    const html = renderToStaticMarkup(<MemoryRouter initialEntries={["/legacy/cards"]}>
      <SiteLink to="/cards/259229055">Card</SiteLink>
      <SiteLink to={{ pathname: "/cards", search: "?set=VEIL", hash: "#results" }}>Release</SiteLink>
      <SiteLink to="https://example.com/">External</SiteLink>
    </MemoryRouter>);
    expect(html).toContain('href="/legacy/cards/259229055"');
    expect(html).toContain('href="/legacy/cards?set=VEIL#results"');
    expect(html).toContain('href="https://example.com/"');
  });
});
