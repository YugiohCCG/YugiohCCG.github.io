#!/usr/bin/env node
"use strict";

const crypto = require("node:crypto");
const fs = require("node:fs");
const path = require("node:path");
const { pathToFileURL } = require("node:url");
const { DatabaseSync } = require("node:sqlite");

const ROOT = path.resolve(__dirname, "..");
const CARDS_PATH = path.join(ROOT, "src", "data", "cards.json");
const DB_PATH = path.join(ROOT, "public", "CCG Downloads", "CCG_Database", "CCG_v1.db");
const SCRIPTS_PATH = path.join(ROOT, "public", "CCG Downloads", "CCG_Scripts");
const DEFAULT_OUTPUT = path.join(ROOT, "scripts", "output", "omega_headless_registration_audit.json");
const SUPPORT_FILES = ["constant.lua", "utility.lua", "procedure.lua"];
const NORMAL_FILLER = 89631139;

function argument(name, fallback = null) {
  const index = process.argv.indexOf(name);
  return index >= 0 && index + 1 < process.argv.length ? process.argv[index + 1] : fallback;
}

function sha256(content) {
  return crypto.createHash("sha256").update(content).digest("hex");
}

function decodeSetcodes(value) {
  if (!value) return [];
  if (typeof value === "bigint") {
    const result = [];
    let packed = BigInt.asUintN(64, value);
    for (let index = 0; index < 4; index += 1) {
      const setcode = Number(packed & 0xffffn);
      if (setcode) result.push(setcode);
      packed >>= 16n;
    }
    return result;
  }
  const bytes = value instanceof Uint8Array ? value : new Uint8Array(value);
  const result = [];
  for (let index = 0; index + 1 < bytes.length; index += 2) {
    const setcode = bytes[index] | (bytes[index + 1] << 8);
    if (setcode) result.push(setcode);
  }
  return result;
}

function loadCardData() {
  const result = new Map();
  const database = new DatabaseSync(DB_PATH, { readOnly: true });
  const statement = database.prepare(
    "select id, alias, setcode, type, atk, def, level, race, attribute from datas",
  );
  statement.setReadBigInts(true);
  for (const row of statement.all()) {
    const code = Number(row.id);
    const type = Number(row.type);
    const rawLevel = Number(row.level);
    const rawDefense = Number(row.def);
    result.set(code, {
      code,
      alias: Number(row.alias),
      setcodes: decodeSetcodes(row.setcode),
      type,
      level: rawLevel & 0xff,
      attribute: Number(row.attribute),
      race: row.race,
      attack: Number(row.atk),
      defense: type & 0x4000000 ? 0 : rawDefense,
      lscale: (rawLevel >>> 24) & 0xff,
      rscale: (rawLevel >>> 16) & 0xff,
      link_marker: type & 0x4000000 ? rawDefense : 0,
    });
  }
  database.close();

  // A script-free official Normal Monster keeps both decks valid without
  // requiring Omega's private card database for this registration audit.
  result.set(NORMAL_FILLER, {
    code: NORMAL_FILLER,
    alias: 0,
    setcodes: [0xdd],
    type: 0x11,
    level: 8,
    attribute: 0x10,
    race: 0x2000n,
    attack: 3000,
    defense: 2500,
    lscale: 0,
    rscale: 0,
    link_marker: 0,
  });
  return result;
}

async function loadCoreModule(packageDirectory = null) {
  const packageEntry = packageDirectory
    ? path.join(packageDirectory, "mod.js")
    : require.resolve("@n1xx1/ocgcore-wasm");
  const implementation = path.join(path.dirname(packageEntry), "dist", "index.js");
  if (!fs.existsSync(implementation)) {
    throw new Error(`ocgcore-wasm implementation not found: ${implementation}`);
  }
  return import(pathToFileURL(implementation).href);
}

async function main() {
  const supportDirectory = argument("--support-dir");
  const corePackageDirectory = argument("--core-package-dir");
  const outputPath = path.resolve(argument("--output", DEFAULT_OUTPUT));
  const fieldProbe = process.argv.includes("--field-probe");
  if (!supportDirectory) throw new Error("--support-dir is required");

  const support = new Map();
  for (const name of SUPPORT_FILES) {
    const sourcePath = path.join(supportDirectory, name);
    if (!fs.existsSync(sourcePath)) throw new Error(`Omega support script missing: ${sourcePath}`);
    support.set(name, fs.readFileSync(sourcePath, "utf8"));
  }
  const definedCategories = new Set(
    [...support.values()].flatMap((content) =>
      [...content.matchAll(/^\s*(CATEGORY_[A-Z0-9_]+)\s*=/gm)].map((match) => match[1]),
    ),
  );

  const activeCards = JSON.parse(fs.readFileSync(CARDS_PATH, "utf8"));
  const cardData = loadCardData();
  const coreModule = await loadCoreModule(corePackageDirectory);
  const {
    default: createCore,
    OcgDuelMode,
    OcgLocation,
    OcgPosition,
    OcgProcessResult,
  } = coreModule;
  const core = await createCore({ sync: true, print() {}, printErr() {} });
  const coreVersion = [...core.getVersion()];
  const results = [];

  for (const card of activeCards) {
    const code = Number(card.passcode);
    const sourcePath = path.join(SCRIPTS_PATH, `c${code}.lua`);
    const source = fs.readFileSync(sourcePath, "utf8");
    const requestedScripts = [];
    const missingCardData = new Set();
    const logs = [];
    const errors = [];
    let duel = null;

    const referencedCategories = new Set(
      [...source.matchAll(/\bCATEGORY_[A-Z0-9_]+\b/g)].map((match) => match[0]),
    );
    const undefinedCategories = [...referencedCategories]
      .filter((name) => !definedCategories.has(name))
      .sort();
    if (undefinedCategories.length) {
      errors.push(`undefined Omega category constants: ${undefinedCategories.join(", ")}`);
    }

    const scriptReader = (requested) => {
      requestedScripts.push(requested);
      const basename = path.basename(String(requested).replaceAll("\\", "/"));
      const customPath = path.join(SCRIPTS_PATH, basename);
      if (fs.existsSync(customPath)) return fs.readFileSync(customPath, "utf8");
      return "";
    };

    try {
      duel = core.createDuel({
        flags: OcgDuelMode.MODE_MR5 | OcgDuelMode.PSEUDO_SHUFFLE,
        seed: [1n, 2n, 3n, BigInt(code)],
        team1: { drawCountPerTurn: 1, startingDrawCount: 0, startingLP: 8000 },
        team2: { drawCountPerTurn: 1, startingDrawCount: 0, startingLP: 8000 },
        cardReader: (requestedCode) => {
          const data = cardData.get(requestedCode);
          if (!data) missingCardData.add(requestedCode);
          return data ?? null;
        },
        scriptReader,
        errorHandler: (type, message) => logs.push({ type, message }),
      });
      if (!duel) throw new Error("createDuel returned null");

      for (const [name, content] of support) {
        if (!core.loadScript(duel, `ccg-support/${name}`, content)) {
          errors.push(`failed to load Omega support script ${name}`);
        }
      }

      const metadata = cardData.get(code);
      if (!metadata) throw new Error("card metadata is missing from CCG_v1.db");
      core.duelNewCard(duel, {
        team: 0,
        duelist: 0,
        code,
        controller: 0,
        // The normal gate uses banished face-down to isolate registration.
        // The optional exploratory probe places the card face-up on its
        // natural field zone so continuous and idle-scan callbacks execute.
        location: fieldProbe
          ? (metadata.type & 0x1 ? OcgLocation.MZONE : OcgLocation.SZONE)
          : OcgLocation.REMOVED,
        sequence: 0,
        position: fieldProbe ? OcgPosition.FACEUP_ATTACK : OcgPosition.FACEDOWN_DEFENSE,
      });
      for (let player = 0; player < 2; player += 1) {
        for (let copy = 0; copy < 5; copy += 1) {
          core.duelNewCard(duel, {
            team: player,
            duelist: 0,
            code: NORMAL_FILLER,
            controller: player,
            location: OcgLocation.DECK,
            sequence: 0,
            position: OcgPosition.FACEDOWN_DEFENSE,
          });
        }
      }
      core.startDuel(duel);
      let status = OcgProcessResult.CONTINUE;
      let steps = 0;
      while (status === OcgProcessResult.CONTINUE && steps < 50) {
        status = core.duelProcess(duel);
        core.duelGetMessage(duel);
        steps += 1;
      }
      if (status !== OcgProcessResult.WAITING) {
        errors.push(`duel reached status ${status} after ${steps} process steps`);
      }
      if (!requestedScripts.includes(`c${code}.lua`)) {
        errors.push("target card script was not requested by the core");
      }
    } catch (error) {
      errors.push(`${error.name}: ${error.message}`);
    } finally {
      if (duel) core.destroyDuel(duel);
    }

    const runtimeErrors = logs.filter((entry) => entry.type === 0);
    errors.push(...runtimeErrors.map((entry) => entry.message));
    if (missingCardData.size) {
      errors.push(`card reader requested missing codes: ${[...missingCardData].sort((a, b) => a - b).join(", ")}`);
    }
    results.push({
      card_id: code,
      card_name: card.name,
      script: `c${code}.lua`,
      script_sha256: sha256(source),
      status: errors.length ? "failed" : "passed",
      errors,
      runtime_logs: errors.length ? logs : [],
    });
  }

  const failures = results.filter((result) => result.status === "failed");
  const omegaNativeMethodsMissingFromWasm = fieldProbe
    ? failures.filter((failure) =>
        failure.errors.every((message) =>
          message.includes("method 'IsFaceupEx'") || message.includes("method 'IsCanOverlay'"),
        ),
      )
    : [];
  const report = {
    schema_version: 1,
    mode: fieldProbe ? "faceup_field_probe" : "registration",
    engine: "@n1xx1/ocgcore-wasm",
    engine_version: coreVersion,
    omega_support: Object.fromEntries(
      [...support].map(([name, content]) => [name, { sha256: sha256(content), bytes: Buffer.byteLength(content) }]),
    ),
    summary: {
      active_cards: activeCards.length,
      cards_tested: results.length,
      passed: results.length - failures.length,
      failed: failures.length,
      infrastructure_excluded: omegaNativeMethodsMissingFromWasm.length,
    },
    infrastructure_exclusions: omegaNativeMethodsMissingFromWasm.map((failure) => ({
      card_id: failure.card_id,
      card_name: failure.card_name,
      reason: "Installed Omega scripts require native Card methods absent from the public WASM core.",
      errors: [...new Set(failure.errors)],
    })),
    failures,
    cards: results.map(({ runtime_logs, ...result }) => result),
  };
  fs.mkdirSync(path.dirname(outputPath), { recursive: true });
  fs.writeFileSync(outputPath, `${JSON.stringify(report, null, 2)}\n`, "utf8");

  console.log(`engine_version=${coreVersion.join(".")}`);
  console.log(`cards_tested=${results.length}`);
  console.log(`passed=${results.length - failures.length}`);
  console.log(`failed=${failures.length}`);
  console.log(`report=${outputPath}`);
  for (const failure of failures.slice(0, 30)) {
    console.log(`ERROR ${failure.card_id} (${failure.card_name}): ${failure.errors.join(" | ")}`);
  }
  return failures.length ? 1 : 0;
}

main()
  .then((exitCode) => {
    process.exitCode = exitCode;
  })
  .catch((error) => {
    console.error(`${error.name}: ${error.message}`);
    process.exitCode = 1;
  });
