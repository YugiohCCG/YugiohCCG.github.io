// Compact Filters Panel with asset icons and category chips
import { useEffect, useMemo, useState, type ReactNode } from "react";
import { useSearchParams } from "react-router-dom";
import useCards from "../hooks/useCards";
import LegalityBadge from "./LegalityBadge";

const ASSET = (name: string) => `/assets/misc/${name}`;

const ATTRS = ["DARK", "LIGHT", "EARTH", "WATER", "FIRE", "WIND", "DIVINE"];
const ICONS = ["Equip", "Field", "Quick-Play", "Ritual", "Continuous", "Counter", "Normal"];
const CARD_TYPES = [
  "Normal","Effect","Ritual","Fusion","Synchro","Xyz","Pendulum","Link",
  "Toon","Spirit","Union","Gemini","Tuner","Flip",
];

const ATTR_ICON: Record<string, string> = {
  DARK: ASSET("DARK.svg"),
  LIGHT: ASSET("LIGHT.svg"),
  EARTH: ASSET("EARTH.svg"),
  WATER: ASSET("WATER.svg"),
  FIRE: ASSET("FIRE.svg"),
  WIND: ASSET("WIND.svg"),
  DIVINE: ASSET("DIVINE.svg"),
};

const SPELL_ICON: Record<string, string> = {
  Equip: ASSET("Equip.svg"),
  Field: ASSET("Field.svg"),
  "Quick-Play": ASSET("Quick-Play.svg"),
  Ritual: ASSET("Ritual.svg"),
  Continuous: ASSET("Continuous.svg"),
  Counter: ASSET("Counter.svg"),
  Normal: ASSET("Normal.svg"),
};

const CARDTYPE_ICON: Record<string, string> = {
  Normal: ASSET("Normal.png"),
  Effect: ASSET("Effect.png"),
  Ritual: ASSET("Ritual.png"),
  Fusion: ASSET("Fusion.png"),
  Synchro: ASSET("Synchro.png"),
  Xyz: ASSET("XYZ.png"),
  Toon: ASSET("Toon.png"),
  Spirit: ASSET("Spirit.png"),
  Union: ASSET("Union.png"),
  Gemini: ASSET("Gemini.png"),
  Tuner: ASSET("Tuner.png"),
  Flip: ASSET("Flip.png"),
  Pendulum: ASSET("Pendulum.png"),
  Link: ASSET("Link.png"),
};

const MONSTER_ICON: Record<string, string> = {
  Aqua: ASSET("Aqua-TF06.svg"),
  Beast: ASSET("Beast-TF06.svg"),
  "Beast-Warrior": ASSET("Beast-Warrior-TF06.svg"),
  "Beast-W": ASSET("Beast-Warrior-TF06.svg"),
  "Winged Beast": ASSET("Winged_Beast-TF06.svg"),
  "Winged-Beast": ASSET("Winged_Beast-TF06.svg"),
  "Celestial Warrior": ASSET("Celestial Warrior.png"),
  Cyborg: ASSET("Cyborg.png"),
  Cyberse: ASSET("Cyberse.png"),
  Cyber: ASSET("Cyberse-TF06.svg"),
  "Divine-Beast": ASSET("Divine-Beast-TF06.svg"),
  Dinosaur: ASSET("Dinosaur-TF06.svg"),
  Dragon: ASSET("Dragon-TF06.svg"),
  Fairy: ASSET("Fairy-TF06.svg"),
  Fiend: ASSET("Fiend-TF06.svg"),
  Fish: ASSET("Fish-TF06.svg"),
  Galaxy: ASSET("Galaxy.png"),
  Illusion: ASSET("Illusion.png"),
  Insect: ASSET("Insect-TF06.svg"),
  Machine: ASSET("Machine-TF06.svg"),
  Plant: ASSET("Plant-TF06.svg"),
  Psychic: ASSET("Psychic-TF06.svg"),
  Pyro: ASSET("Pyro-TF06.svg"),
  Reptile: ASSET("Reptile-TF06.svg"),
  Rock: ASSET("Rock-TF06.svg"),
  "Sea Serpent": ASSET("Sea_Serpent-TF06.svg"),
  "Sea-Serpent": ASSET("Sea_Serpent-TF06.svg"),
  Spellcaster: ASSET("Spellcaster-TF06.svg"),
  Thunder: ASSET("Thunder-TF06.svg"),
  Warrior: ASSET("Warrior-TF06.svg"),
  Zombie: ASSET("Zombie-TF06.svg"),
};

const CATEGORY_ICONS: Record<string, string> = {
  Monster: ASSET("CG_Star.svg"),
  Spell: ASSET("SPELL.svg"),
  Trap: ASSET("TRAP.svg"),
};

const LEGALITY_ICON: Record<string, string> = {
  Banned: "banned",
  Limited: "limited",
  "Semi-Limited": "semi",
};

const LEVELS = Array.from({ length: 14 }, (_, i) => i); // 0..13
const SCALES = Array.from({ length: 14 }, (_, i) => i); // 0..13
const LINK_RATINGS = [1, 2, 3, 4, 5, 6];

const ARROWS_GRID: (string | null)[] = [
  "TL", "T",  "TR",
  "L",  null, "R",
  "BL", "B",  "BR",
];

const CATEGORY = [
  { key: "Monster", label: "Monster" },
  { key: "Spell", label: "Spell" },
  { key: "Trap", label: "Trap" },
];

function IconLabel({ icon, label }: { icon?: string; label: string }) {
  return (
    <span className="flex items-center gap-1">
      {icon && <img src={icon} alt={label} className="h-4 w-4" loading="lazy" />}
      <span>{label}</span>
    </span>
  );
}

function Chip({
  active,
  onClick,
  children,
  title,
}: {
  active?: boolean;
  onClick?: () => void;
  children: ReactNode;
  title?: string;
}) {
  return (
    <button
      type="button"
      title={title}
      onClick={onClick}
      className={`filter-pill ${active ? "active" : ""}`}
    >
      {children}
    </button>
  );
}

function Section({
  title,
  onClear,
  children,
  fixedHeight = false,
}: {
  title?: string;
  onClear?: () => void;
  children: ReactNode;
  fixedHeight?: boolean;
}) {
  const showHeader = Boolean(title || onClear);
  return (
    <section className="filter-section">
      {showHeader && (
        <div className="mb-1 flex items-center justify-between">
          {title && <h3 className="filter-title">{title}</h3>}
          {onClear && (
            <button
              className="text-[11px] text-neutral-400 hover:underline"
              onClick={onClear}
              type="button"
            >
              clear
            </button>
          )}
        </div>
      )}
      <div className={fixedHeight ? "max-h-20 overflow-auto pr-1.5" : ""}>{children}</div>
    </section>
  );
}

const getAll = (p: URLSearchParams, k: string) => p.getAll(k);
const getAllNum = (p: URLSearchParams, k: string) =>
  p.getAll(k).map((v) => Number(v)).filter((n) => !Number.isNaN(n));
const getOne = (p: URLSearchParams, k: string) => p.get(k) ?? "";
const getNum = (p: URLSearchParams, k: string) => (p.get(k) ? Number(p.get(k)) : undefined);
const putList = (p: URLSearchParams, k: string, vals: string[]) => {
  p.delete(k);
  for (const v of vals) p.append(k, v);
};
const putListNum = (p: URLSearchParams, k: string, vals: number[]) => {
  p.delete(k);
  for (const v of vals) p.append(k, String(v));
};

export default function FiltersPanel() {
  const { indexes } = useCards({ includeTCG: false, includeCustom: true, includeTest: false });
  const [params, setParams] = useSearchParams();

  const [collapsed, setCollapsed] = useState(true);

  const [q, setQ] = useState(getOne(params, "q"));
  const [setCode, setSetCode] = useState(getOne(params, "set"));
  const [archetypeSel, setArchetypeSel] = useState(getOne(params, "archetype"));
  const [category, setCategory] = useState(getOne(params, "category"));

  const [attributes, setAttributes] = useState<string[]>(getAll(params, "attribute"));
  const [icons, setIcons] = useState<string[]>(getAll(params, "icon"));
  const [monsterTypes, setMonsterTypes] = useState<string[]>(getAll(params, "monsterType"));
  const [cardTypes, setCardTypes] = useState<string[]>(getAll(params, "cardTypes"));

  const [levelSet, setLevelSet] = useState<number[]>(getAllNum(params, "levelIn"));
  const [rankSet,  setRankSet]  = useState<number[]>(getAllNum(params, "rankIn"));
  const [scaleSet, setScaleSet] = useState<number[]>(getAllNum(params, "scaleIn"));
  const [linkSet,  setLinkSet]  = useState<number[]>(getAllNum(params, "linkIn"));

  const [arrows, setArrows] = useState<string[]>(getAll(params, "linkArrows"));

  const [atkMin, setAtkMin] = useState<number | undefined>(getNum(params, "atkMin"));
  const [atkMax, setAtkMax] = useState<number | undefined>(getNum(params, "atkMax"));
  const [defMin, setDefMin] = useState<number | undefined>(getNum(params, "defMin"));
  const [defMax, setDefMax] = useState<number | undefined>(getNum(params, "defMax"));

  const [legal, setLegal] = useState<string[]>(getAll(params, "legal"));
  const [dateStart, setDateStart] = useState<string>(getOne(params, "dateStart"));
  const [dateEnd, setDateEnd] = useState<string>(getOne(params, "dateEnd"));

  useEffect(() => { setQ(getOne(params, "q")); }, [params]);

  const setsOptions = useMemo(() => indexes.setsList ?? [], [indexes.setsList]);
  const archetypeOptions = useMemo(
    () => [...new Set(indexes.archetypes ?? [])].sort((a, b) => a.localeCompare(b)),
    [indexes.archetypes]
  );
  const monsterTypeOptions = useMemo(
    () => indexes.monsterTypes ?? [],
    [indexes.monsterTypes]
  );

  const toggle = (list: string[], setList: (v: string[]) => void, value: string) => {
    setList(list.includes(value) ? list.filter((x) => x !== value) : [...list, value]);
  };
  const toggleNum = (list: number[], setList: (v: number[]) => void, value: number) => {
    setList(list.includes(value) ? list.filter((x) => x !== value) : [...list, value].sort((a,b)=>a-b));
  };

  const apply = () => {
    const p = new URLSearchParams(params);
    const setOrDel = (k: string, v?: string) => (v ? p.set(k, v) : p.delete(k));
    const setNum = (k: string, v?: number) => (v != null && !Number.isNaN(v) ? p.set(k, String(v)) : p.delete(k));

    setOrDel("q", q.trim() || undefined);
    setOrDel("set", setCode || undefined);
    setOrDel("archetype", archetypeSel || undefined);
    setOrDel("category", category || undefined);

    putList(p, "attribute", attributes);
    putList(p, "icon", icons);
    putList(p, "monsterType", monsterTypes);
    putList(p, "cardTypes", cardTypes);

    putListNum(p, "levelIn", levelSet);
    putListNum(p, "rankIn", rankSet);
    putListNum(p, "scaleIn", scaleSet);
    putListNum(p, "linkIn", linkSet);

    ["levelMin","levelMax","rankMin","rankMax","scaleMin","scaleMax","linkMin","linkMax"]
      .forEach((k) => p.delete(k));

    putList(p, "linkArrows", arrows);

    setNum("atkMin", atkMin); setNum("atkMax", atkMax);
    setNum("defMin", defMin); setNum("defMax", defMax);

    putList(p, "legal", legal);
    setOrDel("dateStart", dateStart || undefined);
    setOrDel("dateEnd", dateEnd || undefined);

    p.set("filters", collapsed ? "0" : "1");
    setParams(p, { replace: true });
  };

  const reset = () => {
    const p = new URLSearchParams();
    p.set("filters", collapsed ? "0" : "1");
    setParams(p, { replace: true });

    setQ(""); setSetCode(""); setArchetypeSel(""); setCategory("");
    setAttributes([]); setIcons([]); setMonsterTypes([]); setCardTypes([]);

    setLevelSet([]); setRankSet([]); setScaleSet([]); setLinkSet([]);

    setArrows([]); setAtkMin(undefined); setAtkMax(undefined); setDefMin(undefined); setDefMax(undefined);
    setLegal([]); setDateStart(""); setDateEnd("");
  };

  return (
    <div className="mb-4 filters-shell shadow-sm">
      <form
        className="grid gap-2 md:grid-cols-[1fr,11rem,11rem,auto] md:items-center"
        onSubmit={(e) => { e.preventDefault(); apply(); }}
      >
        <input
          placeholder="Search keyword/name/text..."
          value={q}
          onChange={(e) => setQ(e.target.value)}
          className="bg-neutral-900 border border-neutral-700 rounded-lg px-3 py-2 text-sm"
        />
        <select
          className="bg-neutral-900 border border-neutral-700 rounded-lg px-2.5 py-2 text-sm min-w-[10rem]"
          value={setCode}
          onChange={(e) => setSetCode(e.target.value)}
        >
          <option value="">All Sets</option>
          {setsOptions.map((s: any) => (
            <option key={s.code} value={s.code}>{s.code}</option>
          ))}
        </select>
        <select
          className="bg-neutral-900 border border-neutral-700 rounded-lg px-2.5 py-2 text-sm min-w-[10rem]"
          value={archetypeSel}
          onChange={(e) => setArchetypeSel(e.target.value)}
        >
          <option value="">All Archetypes</option>
          {archetypeOptions.map((a) => (
            <option key={a} value={a}>{a}</option>
          ))}
        </select>

        <div className="flex gap-2 md:justify-end">
          <button
            type="button"
            className="btn"
            onClick={() => {
              const n = !collapsed;
              setCollapsed(n);
              params.set("filters", n ? "0" : "1");
              setParams(params, { replace: true });
            }}
          >
            {collapsed ? "Show Filters" : "Hide Filters"}
          </button>
          <button type="button" className="btn" onClick={reset}>Reset</button>
          <button type="submit" className="btn btn-primary">Apply</button>
        </div>
      </form>

      {!collapsed && (
        <div className="mt-2 flex flex-col gap-2">
          {/* Order: Category -> Icon -> Attribute -> Monster Type (Type) -> Card Type */}
          <Section onClear={category ? () => setCategory("") : undefined}>
            <div className="filter-grid">
              {CATEGORY.map((c) => (
                <Chip
                  key={c.key}
                  active={category === c.key}
                  onClick={() => setCategory(category === c.key ? "" : c.key)}
                  title={c.label}
                >
                  <IconLabel icon={CATEGORY_ICONS[c.key]} label={c.label} />
                </Chip>
              ))}
            </div>
          </Section>

          <Section onClear={icons.length ? () => setIcons([]) : undefined}>
            <div className="filter-grid">
              {ICONS.map((i) => (
                <Chip key={i} active={icons.includes(i)} onClick={() => toggle(icons, setIcons, i)}>
                  <IconLabel icon={SPELL_ICON[i]} label={i} />
                </Chip>
              ))}
            </div>
          </Section>

          <Section onClear={attributes.length ? () => setAttributes([]) : undefined}>
            <div className="filter-grid">
              {ATTRS.map((a) => (
                <Chip key={a} active={attributes.includes(a)} onClick={() => toggle(attributes, setAttributes, a)}>
                  <IconLabel icon={ATTR_ICON[a]} label={a} />
                </Chip>
              ))}
            </div>
          </Section>

          <Section
            // Monster types
            onClear={monsterTypes.length ? () => setMonsterTypes([]) : undefined}
          >
            <div className="filter-grid">
              {monsterTypeOptions.map((t) => {
                const label = String(t);
                const icon = MONSTER_ICON[label] || MONSTER_ICON[label.replace("-", " ")] || "";
                return (
                  <Chip
                    key={label}
                    active={monsterTypes.includes(label)}
                    onClick={() => toggle(monsterTypes, setMonsterTypes, label)}
                  >
                    <IconLabel icon={icon} label={label} />
                  </Chip>
                );
              })}
            </div>
          </Section>

          <Section
            // Card type row
            onClear={cardTypes.length ? () => setCardTypes([]) : undefined}
            fixedHeight
          >
            <div className="filter-grid">
              {["Normal","Effect","Ritual","Fusion","Synchro","Xyz","Pendulum","Link"].map((t) => (
                <Chip key={t} active={cardTypes.includes(t)} onClick={() => toggle(cardTypes, setCardTypes, t)}>
                  <IconLabel icon={CARDTYPE_ICON[t]} label={t} />
                </Chip>
              ))}
            </div>
            <div className="mt-1 filter-grid">
              {["Toon","Spirit","Union","Gemini","Tuner","Flip"].map((t) => (
                <Chip key={t} active={cardTypes.includes(t)} onClick={() => toggle(cardTypes, setCardTypes, t)}>
                  <IconLabel icon={CARDTYPE_ICON[t]} label={t} />
                </Chip>
              ))}
            </div>
          </Section>

          <div className="grid gap-2 md:grid-cols-2">
            <Section title="Level" onClear={levelSet.length ? () => setLevelSet([]) : undefined}>
              <div className="filter-grid">
                {LEVELS.map((n) => (
                  <Chip key={`L${n}`} active={levelSet.includes(n)} onClick={() => toggleNum(levelSet, setLevelSet, n)}>
                    {n}
                  </Chip>
                ))}
              </div>
            </Section>

            <Section title="Rank" onClear={rankSet.length ? () => setRankSet([]) : undefined}>
              <div className="filter-grid">
                {LEVELS.map((n) => (
                  <Chip key={`R${n}`} active={rankSet.includes(n)} onClick={() => toggleNum(rankSet, setRankSet, n)}>
                    {n}
                  </Chip>
                ))}
              </div>
            </Section>
          </div>

          <div className="grid gap-2 md:grid-cols-2">
            <Section title="Pendulum" onClear={scaleSet.length ? () => setScaleSet([]) : undefined}>
              <div className="filter-grid">
                {SCALES.map((n) => (
                  <Chip key={`S${n}`} active={scaleSet.includes(n)} onClick={() => toggleNum(scaleSet, setScaleSet, n)}>
                    {n}
                  </Chip>
                ))}
              </div>
            </Section>

            <Section title="Link Rating" onClear={linkSet.length ? () => setLinkSet([]) : undefined}>
              <div className="filter-grid">
                {LINK_RATINGS.map((n) => (
                  <Chip key={`LN${n}`} active={linkSet.includes(n)} onClick={() => toggleNum(linkSet, setLinkSet, n)}>
                    {n}
                  </Chip>
                ))}
              </div>
            </Section>
          </div>

          <div className="grid gap-2 md:grid-cols-2">
            <Section title="ATK / DEF">
              <div className="flex flex-wrap items-center gap-2">
                <label className="text-xs text-neutral-300">ATK</label>
                <input
                  type="number"
                  className="bg-neutral-900 border border-neutral-700 rounded-lg px-2 py-1.5 text-sm w-24"
                  placeholder="min"
                  value={atkMin ?? ""}
                  onChange={(e) => setAtkMin(e.target.value ? Number(e.target.value) : undefined)}
                />
                <span className="text-neutral-500">–</span>
                <input
                  type="number"
                  className="bg-neutral-900 border border-neutral-700 rounded-lg px-2 py-1.5 text-sm w-24"
                  placeholder="max"
                  value={atkMax ?? ""}
                  onChange={(e) => setAtkMax(e.target.value ? Number(e.target.value) : undefined)}
                />

                <label className="ml-3 text-xs text-neutral-300">DEF</label>
                <input
                  type="number"
                  className="bg-neutral-900 border border-neutral-700 rounded-lg px-2 py-1.5 text-sm w-24"
                  placeholder="min"
                  value={defMin ?? ""}
                  onChange={(e) => setDefMin(e.target.value ? Number(e.target.value) : undefined)}
                />
                <span className="text-neutral-500">–</span>
                <input
                  type="number"
                  className="bg-neutral-900 border border-neutral-700 rounded-lg px-2 py-1.5 text-sm w-24"
                  placeholder="max"
                  value={defMax ?? ""}
                  onChange={(e) => setDefMax(e.target.value ? Number(e.target.value) : undefined)}
                />
              </div>
            </Section>

            <Section title="Legality" onClear={legal.length ? () => setLegal([]) : undefined}>
              <div className="flex flex-wrap gap-1.5">
                {["Banned", "Limited", "Semi-Limited", "Legal"].map((v) => (
                  <Chip key={v} active={legal.includes(v)} onClick={() => toggle(legal, setLegal, v)}>
                    {LEGALITY_ICON[v] ? (
                      <span className="flex items-center gap-1">
                        <LegalityBadge status={LEGALITY_ICON[v] as any} size={22} />
                        <span>{v}</span>
                      </span>
                    ) : (
                      <span>{v}</span>
                    )}
                  </Chip>
                ))}
              </div>
            </Section>
          </div>
        </div>
      )}
    </div>
  );
}
