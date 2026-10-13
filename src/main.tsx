import React, { Suspense, lazy } from "react";
import ReactDOM from "react-dom/client";
import { createBrowserRouter, Navigate, RouterProvider, useLocation } from "react-router-dom";
import "./index.css";

import App from "./App";
const Home = lazy(() => import("./pages/Home"));
const Releases = lazy(() => import("./pages/Releases"));
const Cards = lazy(() => import("./pages/Cards"));
const CardDetail = lazy(() => import("./pages/CardDetail"));
const Archetypes = lazy(() => import("./pages/Archetypes"));
const BanList = lazy(() => import("./pages/BanList"));
const Downloads = lazy(() => import("./pages/Downloads"));
const Draft = lazy(() => import("./pages/Draft"));
const DeckBuilder = lazy(() => import("./pages/DeckBuilder"));
const SupportStatus = lazy(() => import("./pages/SupportStatus"));
const NotFound = lazy(() => import("./pages/NotFound"));
const TokyoPrintLayout = lazy(() => import("./pages/TokyoPrintLayout"));
const TokyoPrintDemo = lazy(() => import("./pages/TokyoPrintDemo"));

const page = (element: React.ReactNode) => <Suspense fallback={<div className="card" role="status">Loading page…</div>}>{element}</Suspense>;

function PreviewRedirect() {
  const location = useLocation();
  const path = location.pathname.replace(/^\/demo\/tokyo-print/, "") || "/";
  return <Navigate to={`${path}${location.search}${location.hash}`} replace />;
}

const children = (legacy = false) => [
  { index: true, element: page(legacy ? <Home /> : <TokyoPrintDemo />) },
  { path: "releases", element: page(<Releases />) },
  { path: "cards", element: page(<Cards />) },
  { path: "cards/:cardId", element: page(<CardDetail />) },
  { path: "archetypes", element: page(<Archetypes />) },
  { path: "archetypes/:name", element: page(<Archetypes />) },
  { path: "banlist", element: page(<BanList />) },
  { path: "downloads", element: page(<Downloads />) },
  { path: "draft", element: page(<Draft />) },
  { path: "deck-builder", element: page(<DeckBuilder />) },
  { path: "support", element: page(<SupportStatus />) },
  { path: "decks", element: <Navigate to={legacy ? "/legacy/archetypes" : "/archetypes"} replace /> },
  { path: "*", element: page(<NotFound />) },
];

const router = createBrowserRouter([
  { path: "/demo/tokyo-print/*", element: <PreviewRedirect /> },
  { path: "/legacy", element: <App />, children: children(true) },
  { path: "/", element: page(<TokyoPrintLayout />), children: children() },
], { basename: import.meta.env.BASE_URL });

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);
