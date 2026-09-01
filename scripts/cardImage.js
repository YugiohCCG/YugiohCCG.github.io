// Run: node scripts/cardImage.js  (delegates to cardImage.cjs)
import { spawnSync } from 'node:child_process';
import path from 'node:path';
import { fileURLToPath } from 'node:url';

const __dirname = path.dirname(fileURLToPath(import.meta.url));
const result = spawnSync(
  process.execPath,
  [path.join(__dirname, 'cardImage.cjs'), ...process.argv.slice(2)],
  { stdio: 'inherit' },
);
process.exit(result.status ?? 1);
