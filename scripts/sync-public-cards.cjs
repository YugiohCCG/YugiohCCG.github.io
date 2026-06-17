const fs = require("fs");
const path = require("path");

const repoRoot = path.resolve(__dirname, "..");
const sourcePath = path.join(repoRoot, "src", "data", "cards.json");
const publicPath = path.join(repoRoot, "public", "assets", "cards.json");
const checkOnly = process.argv.includes("--check");

function readIfExists(filePath) {
  try {
    return fs.readFileSync(filePath);
  } catch (error) {
    if (error && error.code === "ENOENT") {
      return null;
    }
    throw error;
  }
}

const source = readIfExists(sourcePath);
if (!source) {
  console.error(`Missing source cards file: ${sourcePath}`);
  process.exit(1);
}

const current = readIfExists(publicPath);
const inSync = current !== null && Buffer.compare(source, current) === 0;

if (checkOnly) {
  if (!inSync) {
    console.error("public/assets/cards.json is out of sync with src/data/cards.json");
    console.error(`source: ${sourcePath}`);
    console.error(`public: ${publicPath}`);
    process.exit(1);
  }

  console.log("public cards.json is in sync");
  process.exit(0);
}

if (inSync) {
  console.log("public cards.json is already in sync");
  process.exit(0);
}

fs.mkdirSync(path.dirname(publicPath), { recursive: true });
fs.copyFileSync(sourcePath, publicPath);
console.log("synced public/assets/cards.json from src/data/cards.json");
