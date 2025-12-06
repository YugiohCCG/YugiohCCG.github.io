// Quick helper to map a minified stack position back to source using the sourcemap.
const fs = require("fs");
const { SourceMapConsumer } = require("source-map");

const mapPath = "dist/assets/index-DMq5uczh.js.map";

if (!fs.existsSync(mapPath)) {
  console.error("Sourcemap not found at", mapPath);
  process.exit(1);
}

const rawMap = JSON.parse(fs.readFileSync(mapPath, "utf8"));

// Position copied from production error stack:
//   index-DMq5uczh.js:61:717871
const line = 61;
const column = 717871;

SourceMapConsumer.with(rawMap, null, (consumer) => {
  const pos = consumer.originalPositionFor({ line, column });
  console.log("Original position:", pos);
});

