import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";

export default defineConfig({
  base: "/",               // root site: https://yugiohccg.github.io/
  plugins: [react()],
  build: { outDir: "dist" },
});