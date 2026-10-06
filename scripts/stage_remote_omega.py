"""Build a separate candidate DB from the pinned remote roster; never publish it."""
import json
import shutil
from pathlib import Path
from sync_omega_ccg_db import sync_db, decode_setcodes, message_carrier_id
import sqlite3

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / "output/fresh-ccg-september"


def main():
    baseline = json.loads((OUT / "baseline-remote.json").read_text(encoding="utf-8"))
    cards = [c["specification"] for c in baseline["cards"]]
    changes = json.loads((ROOT / "src/data/banlist-update.json").read_text(encoding="utf-8"))
    limits = {c["passcode"]: c["limit"] for c in changes["changes"]}
    for card in cards:
        if card["passcode"] in limits:
            limit = limits[card["passcode"]]
            card.setdefault("legal", {}).update(banned=limit == 0, limited=limit == 1, semiLimited=limit == 2)
    source = OUT / "candidate-cards.json"
    source.write_text(json.dumps(cards, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    candidate = OUT / "candidate-CCG_v1.db"
    shutil.copy2(ROOT / "public/CCG Downloads/CCG_Database/CCG_v1.db", candidate)
    result = sync_db(source, candidate, OUT / "candidate-id-map.json", insert_only=True)
    with sqlite3.connect(candidate) as db:
        underroot_fusion = db.execute("select setcode,type from datas where id=238272438").fetchone()
        assert underroot_fusion and 0xA110 in decode_setcodes(underroot_fusion[0]) and underroot_fusion[1] & 0x40, "Terror Blossom Fusion metadata missing"
        underroot_prompts = db.execute("select str1,str2,str3 from texts where id=?", (message_carrier_id(238272438),)).fetchone()
        assert underroot_prompts and all(underroot_prompts), "Terror Blossom effect descriptions missing"
        blossom = db.execute("select setcode from datas where id=238272435").fetchone()
        assert blossom and 0xA111 in decode_setcodes(blossom[0]), "Blossom Skull Underroot setcode missing"
        blossom_prompts = db.execute("select str1,str2,str3,str4 from texts where id=?", (message_carrier_id(238272435),)).fetchone()
        assert blossom_prompts and all(blossom_prompts), "Blossom Skull effect descriptions missing"
        terror = db.execute("select setcode from datas where id=238272434").fetchone()
        assert terror and 0xA111 in decode_setcodes(terror[0]), "Terror Skull Underroot setcode missing"
        terror_prompts = db.execute("select str1,str2,str3,str4 from texts where id=?", (message_carrier_id(238272434),)).fetchone()
        assert terror_prompts and all(terror_prompts), "Terror Skull effect descriptions missing"
        nether = db.execute("select setcode from datas where id=238272436").fetchone()
        assert nether and 0xA111 in decode_setcodes(nether[0]), "Nether Skull Underroot setcode missing"
        nether_prompts = db.execute("select str1,str2,str3 from texts where id=?", (message_carrier_id(238272436),)).fetchone()
        assert nether_prompts and all(nether_prompts), "Nether Skull effect descriptions missing"
        over = db.execute("select setcode from datas where id=238272437").fetchone()
        assert over and 0xA111 in decode_setcodes(over[0]), "Over Skull Underroot setcode missing"
        prompts = db.execute("select str1,str2,str3,str4 from texts where id=?", (message_carrier_id(238272437),)).fetchone()
        assert prompts and all(prompts), "Over Skull effect descriptions missing"
        for code, count in [(244163508, 2), (244163509, 3), (238274863, 3), (238274861, 2), (238274858, 4), (238274859, 2), (238274860, 3), (238274857, 3), (238274862, 3), (244161941, 2), (244165675, 3), (244168521, 2), (284639724, 4), (284639723, 5), (284639722, 5), (284639721, 6), (284639720, 3), (284639719, 2), (284639718, 3), (284639717, 2), (284636666, 1), (284636665, 3), (284636664, 3), (284636663, 3), (284636662, 2), (284636661, 4), (284636589, 2), (284636587, 3), (284636586, 3)]:
            row = db.execute("select setcode from datas where id=?", (code,)).fetchone()
            expected = 0x36 if code in (244163508, 244163509) else (0x53 if code == 238274861 else (0x195 if code == 244161941 else 0x30))
            assert row and (code in (244165675,244168521,284639724,284639723,284639722,284639721,284639720,284639719,284639718,284639717,284636666,284636665,284636664,284636663,284636662,284636661,284636589,284636587,284636586) or expected in decode_setcodes(row[0])), (code, "Expected setcode missing")
            strings = db.execute("select str1,str2,str3 from texts where id=?", (message_carrier_id(code),)).fetchone()
            assert strings and all(strings[:count]), (code, "Missing effect descriptions")
        marker = db.execute("select def from datas where id=244168521").fetchone()
        assert marker == (0x145,), (244168521, "Bahariasaurus Link Markers missing")
        for code in range(284636661, 284636667):
            row = db.execute("select setcode from datas where id=?", (code,)).fetchone()
            assert row and 0x0F3C in decode_setcodes(row[0]), (code, "Aquamarine setcode missing")
        groups = [
            (range(238272434, 238272439), {0xA110, 0xA111}),
            ([238272439], {0xA110, 0xA112}),
            ([238272440], {0xA110, 0xA113}),
            (range(238273768, 238273773), {0x1066}),
            (range(238276248, 238276253), {0x11F}),
            (range(238276572, 238276581), {0x90}),
            (range(239935093, 239935103), {0xA123}),
            (range(244163199, 244163207), {0xA120}),
            ([244163508, 244163509], {0x36}),
            (list(range(247755864, 247755874)) + [247756271, 247756272], {0xA121}),
            (list(range(284636586, 284636590)) + list(range(284639717, 284639727)), {0xA122}),
        ]
        for codes, expected in groups:
            for code in codes:
                row = db.execute("select setcode from datas where id=?", (code,)).fetchone()
                actual = set(decode_setcodes(row[0])) if row else set()
                assert expected <= actual, (code, "Archetype setcode missing", expected, actual)
                assert not actual.intersection({0xBFDE, 0xAA02}), (code, "Placeholder archetype setcode leaked", actual)
        for entry in baseline["cards"]:
            if entry["script_sha256"]:
                continue
            code = entry["passcode"]
            row = db.execute("select setcode from datas where id=?", (code,)).fetchone()
            actual = set(decode_setcodes(row[0])) if row else set()
            assert not actual.intersection({0xBFDE, 0xAA02}), (code, "Placeholder archetype setcode leaked", actual)
        trap_stats = db.execute("select atk,def,level,race,attribute from datas where id=284636661").fetchone()
        assert trap_stats == (500, 2300, 6, 64, 2), (284636661, "Trap Monster stats missing")
    print(json.dumps({"source_revision": baseline["source_revision"], "candidate_only": True, **result}, indent=2))


if __name__ == "__main__":
    main()
