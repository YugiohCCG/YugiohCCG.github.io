import React from "react";
import ReactDOM from "react-dom/client";
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import "./index.css";

import App from "./App";
import Home from "./pages/Home";
import Releases from "./pages/Releases";
import Cards from "./pages/Cards";
import BanList from "./pages/BanList";
import Downloads from "./pages/Downloads";

const router = createBrowserRouter(
  [
    {
      path: "/",
      element: <App />,
      children: [
        { index: true, element: <Home /> },
        { path: "releases", element: <Releases /> },
        { path: "cards", element: <Cards /> },
        { path: "banlist", element: <BanList /> },
        { path: "downloads", element: <Downloads /> },
      ],
    },
  ],
  // IMPORTANT: picks up "/" from vite.config.ts in production
  { basename: import.meta.env.BASE_URL }
);

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);
