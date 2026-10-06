// Re-render CCG card images with ygocarder (https://github.com/lauqerm/ygocarder).
//
// Pipeline for each entry in src/data/cards.json:
//   1. Load the existing full card image from public/assets/cards/
//   2. Crop artwork via scripts/card_art_crop.py (same ratios as export_omega_ccg_arts.py)
//   3. Map cards.json fields → ygocarder JSON and render headless Chromium
//   4. Atomically replace the original image in public/assets/cards/
//
// Usage:
//   node scripts/cardImage.js
//   node scripts/cardImage.js --dry-run --limit 3
//   node scripts/cardImage.js --passcode 245265629
//
// Requires: python + Pillow (scripts/requirements.txt), puppeteer (npm i -D puppeteer)
// Env: CARD_RENDER_URL (defaults to the public ygocarder site)

const crypto = require('crypto');
const fs = require('fs/promises');
const path = require('path');
const { execFile } = require('child_process');
const { promisify } = require('util');

const execFileAsync = promisify(execFile);

const REPO_ROOT = path.resolve(__dirname, '..');
const DEFAULT_CARDS_PATH = path.join(REPO_ROOT, 'src', 'data', 'cards.json');
const DEFAULT_ASSETS_DIR = path.join(REPO_ROOT, 'public', 'assets', 'cards');
const CROP_SCRIPT = path.join(__dirname, 'card_art_crop.py');
const DEFAULT_RENDER_URL = 'https://lauqerm.github.io/ygocarder/';

const CARD_COPYRIGHT = '\u00A92026 YU-GI-OH! CUSTOM CARD GAME';

const EXTRA_DECK_TYPES = ['Ritual', 'Fusion', 'Synchro', 'Xyz', 'Link'];
const ORDERED_ABILITIES = ['Spirit', 'Toon', 'Union', 'Gemini', 'Flip'];

const LINK_ARROW_TO_NUMPAD = {
  TL: '7', T: '8', TR: '9',
  L: '4', R: '6',
  BL: '1', B: '2', BR: '3',
};

const SPELL_TRAP_ICON = {
  Normal: 'NO ICON',
  'Quick-Play': 'QUICK-PLAY',
  Continuous: 'CONTINUOUS',
  Equip: 'EQUIP',
  Field: 'FIELD',
  Ritual: 'RITUAL',
  Counter: 'COUNTER',
};

const YGOCARDER_IMPORT_REQUIRED_KEYS = ['isFirstEdition', 'typeAbility', 'setId'];

function decodeHtmlEntities(value) {
  return String(value || '')
    .replace(/&amp;/g, '&')
    .replace(/&lt;/g, '<')
    .replace(/&gt;/g, '>')
    .replace(/&quot;/g, '"')
    .replace(/&#39;/g, "'");
}

function splitPendulumText(text) {
  const raw = String(text || '');
  const match = raw.match(/^Pendulum Effect:\s*([\s\S]*?)(?:\nMonster Effect:\s*([\s\S]*))?$/i);
  if (!match) return { effect: raw, pendulumEffect: '' };
  return {
    pendulumEffect: match[1].trim(),
    effect: (match[2] || '').trim(),
  };
}

function cardSetId(card) {
  const set = String(card.set || '').trim();
  if (!set) return card.id || '';
  return set.split(/\s+/)[0];
}

function cardPassword(card) {
  if (card.passcode == null) return '';
  return String(card.passcode);
}

/**
 * Map a CCG cards.json entry onto the ygocarder card JSON shape.
 * @param {object} card
 * @param {string} artDataUrl  base64 data URL for cropped artwork
 */
function mapCcgCardToYgocarder(card = {}, artDataUrl = '') {
  const category = card.category || 'Monster';
  const meta = {
    setId: cardSetId(card),
    password: cardPassword(card),
    creator: CARD_COPYRIGHT,
  };

  const base = {
    version: 3,
    format: 'tcg',
    region: 'en',
    name: decodeHtmlEntities(card.name || ''),
    effect: decodeHtmlEntities(card.text || ''),
    setId: meta.setId,
    password: meta.password,
    creator: meta.creator,
    sticker: 'unlimited',
    isFirstEdition: true,
    firstEditionText: '1<st> Edition',
    art: '',
    artData: artDataUrl || '',
    artSource: 'offline',
    cardIcon: 'auto',
  };

  if (category === 'Spell' || category === 'Trap') {
    const isSpell = category === 'Spell';
    const subType = card.icon || 'Normal';
    const typeAbility = [isSpell ? 'Spell Card' : 'Trap Card'];
    return {
      ...base,
      frame: isSpell ? 'spell' : 'trap',
      attribute: isSpell ? 'SPELL' : 'TRAP',
      subFamily: SPELL_TRAP_ICON[subType] || 'NO ICON',
      star: 0,
      starList: [],
      typeAbility,
      atk: '',
      def: '',
      isLink: null,
      linkMap: [],
      linkRating: '',
      isPendulum: false,
    };
  }

  const types = Array.isArray(card.cardTypes) ? card.cardTypes : [];
  const extraType = EXTRA_DECK_TYPES.find((entry) => types.includes(entry)) || null;
  const isPendulum = types.includes('Pendulum');
  const isLink = extraType === 'Link';
  const isNormal = types.includes('Normal') && !types.includes('Effect');
  const { effect, pendulumEffect } = isPendulum ? splitPendulumText(card.text) : { effect: card.text || '', pendulumEffect: '' };

  const typeAbility = [];
  const species = Array.isArray(card.monsterType) ? card.monsterType[0] : card.monsterType;
  if (species) typeAbility.push(species);
  if (extraType) typeAbility.push(extraType);
  ORDERED_ABILITIES.forEach((ability) => {
    if (types.includes(ability)) typeAbility.push(ability);
  });
  if (types.includes('Tuner')) typeAbility.push('Tuner');
  if (isPendulum) typeAbility.push('Pendulum');
  typeAbility.push(isNormal ? 'Normal' : 'Effect');

  const linkMap = isLink && Array.isArray(card.linkArrows)
    ? card.linkArrows.map((arrow) => LINK_ARROW_TO_NUMPAD[arrow]).filter(Boolean)
    : [];

  let star = 0;
  if (!isLink) {
    if (extraType === 'Xyz' && card.rank != null) star = card.rank;
    else if (card.level != null) star = card.level;
  }

  const scale = card.scale != null ? String(card.scale) : '4';

  return {
    ...base,
    effect: decodeHtmlEntities(effect),
    frame: extraType ? extraType.toLowerCase() : (isNormal ? 'normal' : 'effect'),
    attribute: card.attribute || 'NONE',
    subFamily: 'NO ICON',
    star,
    starList: [],
    typeAbility,
    atk: card.atk != null && card.atk !== '' ? String(card.atk) : '0',
    def: isLink ? '' : (card.def != null && card.def !== '' ? String(card.def) : '0'),
    isLink,
    linkMap,
    linkRating: isLink ? String(card.linkRating || linkMap.length || '') : '',
    isPendulum,
    pendulumFrame: 'auto',
    pendulumEffect: decodeHtmlEntities(pendulumEffect),
    pendulumScaleBlue: scale,
    pendulumScaleRed: scale,
  };
}

function validateYgocarderExport(cardJson) {
  const problems = [];
  if (!cardJson || typeof cardJson !== 'object') return ['card JSON is missing'];
  for (const key of YGOCARDER_IMPORT_REQUIRED_KEYS) {
    if (!(key in cardJson)) problems.push(`missing required import field "${key}"`);
  }
  if (!Array.isArray(cardJson.typeAbility) || cardJson.typeAbility.length === 0) {
    problems.push('typeAbility must be a non-empty array');
  }
  return problems;
}

async function cropCardArtToDataUrl(imagePath) {
  const { stdout } = await execFileAsync(
    process.env.PYTHON || 'python',
    [CROP_SCRIPT, '--input', imagePath, '--base64'],
    { maxBuffer: 16 * 1024 * 1024, windowsHide: true },
  );
  const base64 = String(stdout || '').trim();
  if (!base64) throw new Error(`card_art_crop.py returned empty output for ${imagePath}`);
  return `data:image/jpeg;base64,${base64}`;
}

function sanitizeCardFileName(name, fallback = 'card') {
  const cleaned = String(name || '')
    .replace(/[\\/:*?"<>|]/g, '')
    .replace(/\s+/g, ' ')
    .trim()
    .slice(0, 80);
  return cleaned || fallback;
}

let browserPromise = null;
let sharedPagePromise = null;
let sessionReady = false;
let sessionRenderUrl = '';
let renderQueue = Promise.resolve();

const USE_SINGLE_PROCESS = /^true$/i.test(process.env.CARD_RENDER_SINGLE_PROCESS || '');

function isBrowserFatalError(err) {
  const msg = String(err?.message || err || '');
  return /detached|Target closed|Session closed|Connection closed|Protocol error|Browser has disconnected|Navigation failed/i.test(msg);
}

async function resetRendererSession() {
  sessionReady = false;
  sessionRenderUrl = '';
  sharedPagePromise = null;
  if (!browserPromise) return;
  const browser = await browserPromise.catch(() => null);
  browserPromise = null;
  if (browser) await browser.close().catch(() => {});
}

async function getBrowser() {
  if (!browserPromise) {
    const puppeteer = (await import('puppeteer')).default;
    const args = [
      '--no-sandbox',
      '--disable-setuid-sandbox',
      '--disable-dev-shm-usage',
      '--disable-gpu',
      '--no-first-run',
      '--disable-extensions',
      '--disable-background-networking',
      '--disable-background-timer-throttling',
      '--disable-renderer-backgrounding',
      '--disable-software-rasterizer',
      '--mute-audio',
      '--js-flags=--max-old-space-size=512',
    ];
    if (USE_SINGLE_PROCESS) args.push('--single-process', '--no-zygote');
    browserPromise = puppeteer.launch({ headless: true, args }).catch((err) => {
      browserPromise = null;
      throw err;
    });
  }
  return browserPromise;
}

async function getRenderPage() {
  const browser = await getBrowser();
  if (sharedPagePromise) {
    const existing = await sharedPagePromise.catch(() => null);
    if (existing && !existing.isClosed()) return existing;
    sharedPagePromise = null;
  }
  sharedPagePromise = (async () => {
    const page = await browser.newPage();
    await page.setViewport({ width: 1280, height: 1600, deviceScaleFactor: 1 });
    return page;
  })().catch((err) => {
    sharedPagePromise = null;
    throw err;
  });
  return sharedPagePromise;
}

async function ensureYgocarderSession(page, renderUrl, timeoutMs) {
  if (sessionReady && sessionRenderUrl === renderUrl) {
    try {
      await page.waitForSelector('.import-button', { timeout: 15000 });
      return;
    } catch {
      sessionReady = false;
    }
  }
  await page.goto(renderUrl, { waitUntil: 'domcontentloaded', timeout: timeoutMs });
  await page.waitForSelector('.import-button', { timeout: timeoutMs });
  sessionReady = true;
  sessionRenderUrl = renderUrl;
}

async function openImportModal(page) {
  await page.evaluate(() => {
    document.querySelector('.import-modal .ant-modal-close')?.click();
  }).catch(() => {});

  let lastErr = null;
  for (let attempt = 0; attempt < 3; attempt += 1) {
    try {
      await page.waitForSelector('.import-button', { timeout: 15000 });
      await page.click('.import-button');
      await page.waitForSelector('#import-textarea', { timeout: 12000 });
      return;
    } catch (err) {
      lastErr = err;
    }
  }
  throw lastErr || new Error('Could not open ygocarder import modal');
}

async function renderCardToPngBufferNow(cardJson, { renderUrl, timeoutMs = 60000, mime = 'image/png' } = {}, isRetry = false) {
  if (!renderUrl) {
    const err = new Error('CARD_RENDER_URL is not configured');
    err.code = 'NO_RENDER_URL';
    throw err;
  }

  const exportProblems = validateYgocarderExport(cardJson);
  if (exportProblems.length > 0) {
    console.warn(`[card-image] ygocarder export validation: ${exportProblems.join('; ')}`);
  }

  const page = await getRenderPage();
  const quality = mime === 'image/jpeg' ? 0.92 : undefined;
  try {
    await ensureYgocarderSession(page, renderUrl, timeoutMs);
    await openImportModal(page);

    const cardJsonString = JSON.stringify(cardJson);
    await page.evaluate((jsonString) => {
      const textarea = document.getElementById('import-textarea');
      const setter = Object.getOwnPropertyDescriptor(
        window.HTMLTextAreaElement.prototype, 'value',
      ).set;
      setter.call(textarea, jsonString);
      textarea.dispatchEvent(new Event('input', { bubbles: true }));
      textarea.dispatchEvent(new Event('change', { bubbles: true }));
      document.getElementById('export-canvas')?.classList.remove('js-export-available');
      const okButton = document.querySelector('.import-modal .ant-modal-footer .ant-btn-primary')
        || document.querySelector('.import-modal .ant-btn-primary');
      if (okButton) okButton.click();
    }, cardJsonString);

    await page.waitForSelector('#export-canvas.js-export-available', { timeout: timeoutMs });
    await new Promise((resolve) => setTimeout(resolve, 300));

    const dataUrl = await page.evaluate((exportMime, exportQuality) => {
      const canvas = document.getElementById('export-canvas');
      if (!canvas) throw new Error('export canvas not found');
      return exportMime === 'image/jpeg'
        ? canvas.toDataURL('image/jpeg', exportQuality)
        : canvas.toDataURL('image/png');
    }, mime, quality);

    const base64 = String(dataUrl).replace(/^data:image\/\w+;base64,/, '');
    if (!base64) throw new Error('ygocarder returned an empty image');
    return Buffer.from(base64, 'base64');
  } catch (err) {
    await resetRendererSession();
    if (!isRetry) {
      return renderCardToPngBufferNow(cardJson, { renderUrl, timeoutMs, mime }, true);
    }
    throw err;
  }
}

const RENDER_IDLE_SHUTDOWN_MS = Number(process.env.CARD_RENDER_IDLE_MS || 60000);
let pendingRenders = 0;
let idleShutdownTimer = null;

function scheduleIdleShutdown() {
  if (idleShutdownTimer) clearTimeout(idleShutdownTimer);
  if (RENDER_IDLE_SHUTDOWN_MS <= 0) return;
  idleShutdownTimer = setTimeout(() => {
    idleShutdownTimer = null;
    if (pendingRenders === 0) resetRendererSession().catch(() => {});
  }, RENDER_IDLE_SHUTDOWN_MS);
  if (typeof idleShutdownTimer.unref === 'function') idleShutdownTimer.unref();
}

async function renderCardToPngBuffer(cardJson, options = {}) {
  pendingRenders += 1;
  if (idleShutdownTimer) {
    clearTimeout(idleShutdownTimer);
    idleShutdownTimer = null;
  }
  const run = () => renderCardToPngBufferNow(cardJson, options);
  const result = renderQueue.then(run, run);
  renderQueue = result.catch(() => {});
  try {
    return await result;
  } finally {
    pendingRenders -= 1;
    if (pendingRenders === 0) scheduleIdleShutdown();
  }
}

async function closeCardRenderer() {
  await resetRendererSession();
}

function resolveCardImagePath(card, assetsDir = DEFAULT_ASSETS_DIR) {
  const imageRef = String(card.image || '');
  if (!imageRef.startsWith('/assets/cards/')) return null;
  const rel = imageRef.slice('/assets/cards/'.length);
  return path.join(assetsDir, rel);
}

function outputMimeForPath(filePath) {
  return path.extname(filePath).toLowerCase() === '.png' ? 'image/png' : 'image/jpeg';
}

/**
 * Re-render every CCG card listed in cards.json and replace its image in public/assets/cards.
 */
async function renderAllCcgCards(options = {}) {
  const {
    cardsPath = DEFAULT_CARDS_PATH,
    assetsDir = DEFAULT_ASSETS_DIR,
    renderUrl = process.env.CARD_RENDER_URL || DEFAULT_RENDER_URL,
    dryRun = false,
    limit = Infinity,
    passcode = null,
    cardId = null,
  } = options;

  const cards = JSON.parse(await fs.readFile(cardsPath, 'utf8'));
  const summary = { rendered: 0, skipped: 0, failed: 0 };

  for (const card of cards) {
    if (summary.rendered >= limit) break;
    if (passcode != null && card.passcode !== passcode) continue;
    if (cardId && card.id !== cardId) continue;

    const targetPath = resolveCardImagePath(card, assetsDir);
    if (!targetPath) {
      summary.skipped += 1;
      continue;
    }

    try {
      await fs.access(targetPath);
    } catch {
      console.warn(`[skip] missing image: ${targetPath}`);
      summary.skipped += 1;
      continue;
    }

    if (dryRun) {
      console.log(`[dry-run] ${card.id} ${card.name} -> ${targetPath}`);
      summary.rendered += 1;
      continue;
    }

    try {
      const artDataUrl = await cropCardArtToDataUrl(targetPath);
      const cardJson = mapCcgCardToYgocarder(card, artDataUrl);
      const mime = outputMimeForPath(targetPath);
      const buffer = await renderCardToPngBuffer(cardJson, { renderUrl, mime });
      const tmpPath = `${targetPath}.tmp${path.extname(targetPath)}`;
      await fs.writeFile(tmpPath, buffer);
      await fs.rename(tmpPath, targetPath);
      console.log(`[ok] ${card.id} ${card.name}`);
      summary.rendered += 1;
    } catch (err) {
      console.error(`[fail] ${card.id} ${card.name}: ${err.message}`);
      summary.failed += 1;
    }
  }

  await closeCardRenderer();
  return summary;
}

function parseCliArgs(argv) {
  const options = {
    dryRun: false,
    limit: Infinity,
    passcode: null,
    cardId: null,
    cardsPath: DEFAULT_CARDS_PATH,
    assetsDir: DEFAULT_ASSETS_DIR,
    renderUrl: process.env.CARD_RENDER_URL || DEFAULT_RENDER_URL,
  };

  for (let i = 0; i < argv.length; i += 1) {
    const arg = argv[i];
    if (arg === '--dry-run') options.dryRun = true;
    else if (arg === '--limit') options.limit = Number(argv[++i] || '0') || Infinity;
    else if (arg === '--passcode') options.passcode = Number(argv[++i]);
    else if (arg === '--card-id') options.cardId = argv[++i];
    else if (arg === '--cards') options.cardsPath = path.resolve(argv[++i]);
    else if (arg === '--assets') options.assetsDir = path.resolve(argv[++i]);
    else if (arg === '--render-url') options.renderUrl = argv[++i];
    else if (arg === '--help' || arg === '-h') options.help = true;
  }

  return options;
}

async function main() {
  const options = parseCliArgs(process.argv.slice(2));
  if (options.help) {
    console.log(`Usage: node scripts/cardImage.js [options]

Options:
  --dry-run            List cards that would be rendered
  --limit <n>          Stop after n successful renders
  --passcode <id>      Render a single card by passcode
  --card-id <id>       Render a single card by id (e.g. CARD-0001)
  --cards <path>       cards.json path (default: src/data/cards.json)
  --assets <dir>       card images dir (default: public/assets/cards)
  --render-url <url>   ygocarder URL (default: public site)
`);
    return;
  }

  const summary = await renderAllCcgCards(options);
  console.log(`rendered=${summary.rendered} skipped=${summary.skipped} failed=${summary.failed}`);
  if (summary.failed > 0) process.exitCode = 1;
}

if (require.main === module) {
  main().catch((err) => {
    console.error(err);
    process.exitCode = 1;
  });
}

module.exports = {
  CARD_COPYRIGHT,
  YGOCARDER_IMPORT_REQUIRED_KEYS,
  mapCcgCardToYgocarder,
  mapInterspaceCardToYgocarder: mapCcgCardToYgocarder,
  validateYgocarderExport,
  cropCardArtToDataUrl,
  renderCardToPngBuffer,
  renderAllCcgCards,
  closeCardRenderer,
  sanitizeCardFileName,
  generateCardPassword: () => String(crypto.randomInt(0, 100000000)).padStart(8, '0'),
};
