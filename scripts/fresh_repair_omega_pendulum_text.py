"""Repair only installed Pendulum descriptions; preserve frozen audit databases."""
import hashlib
import json
import shutil
import sqlite3
from pathlib import Path
from sync_omega_ccg_db import omega_description

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / 'output/fresh-ccg-september'
DB = Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Databases\CCG_v1.db')
BACKUP = OUT / 'pendulum-omega-text-before-repair.db'

def digest(p):
    return hashlib.sha256(p.read_bytes()).hexdigest()

def parse(text):
    # Reproduce inspected Omega CardLocalization constructor: default E,
    # StringReader.ReadLine, exact header equality, append other lines.
    sections = {k: [] for k in 'PEMRC'}
    current = 'E'
    for line in text.splitlines():
        # The inspected constructor terminates on String.IsNullOrEmpty(ReadLine()).
        if not line:
            break
        if line in sections:
            current = line
        else:
            sections[current].append(line)
    return {k: '\n'.join(v).strip() for k, v in sections.items()}

def main():
    cards = json.loads((ROOT / 'src/data/cards.json').read_text(encoding='utf-8'))
    cards = {int(c['passcode']): c for c in cards if 'Pendulum' in (c.get('cardTypes') or [])}
    assert len(cards) == 24
    con = sqlite3.connect(DB)
    before = {t: con.execute(f'SELECT * FROM {t} ORDER BY id').fetchall() for t in ('datas', 'texts')}
    installed = {r[0] for r in con.execute('SELECT id FROM datas WHERE type & 16777216')}
    assert installed == set(cards), (installed - set(cards), set(cards) - installed)
    if not BACKUP.exists():
        shutil.copy2(DB, BACKUP)
    checks = []
    for code, card in cards.items():
        previous = con.execute('SELECT desc FROM texts WHERE id=?', (code,)).fetchone()[0]
        description = omega_description(card)
        sections = parse(description)
        assert sections['P'] and sections['E']
        lua = ROOT / f'public/CCG Downloads/CCG_Scripts/c{code}.lua'
        local = DB.parent.parent / f'Scripts/c{code}.lua'
        source = lua.read_text(encoding='utf-8')
        assert 'EnablePendulumAttribute' in source and 'LOCATION_PZONE' in source
        assert digest(lua) == digest(local)
        con.execute('UPDATE texts SET desc=? WHERE id=?', (description, code))
        checks.append({'passcode': code, 'name': card['name'], 'before_pendulum_empty': not parse(previous)['P'],
                       'pendulum_text': sections['P'], 'monster_text': sections['E'],
                       'lua_sha256': digest(lua), 'installed_lua_matches': True})
    after = {t: con.execute(f'SELECT * FROM {t} ORDER BY id').fetchall() for t in ('datas', 'texts')}
    assert before['datas'] == after['datas']
    assert len(before['texts']) == len(after['texts'])
    for old, new in zip(before['texts'], after['texts']):
        assert old[:2] == new[:2] and old[3:] == new[3:]
        assert old == new or old[0] in cards
    con.commit()
    assert con.execute('PRAGMA integrity_check').fetchone() == ('ok',)
    for check in checks:
        s = parse(con.execute('SELECT desc FROM texts WHERE id=?', (check['passcode'],)).fetchone()[0])
        assert s['P'] == check['pendulum_text'] and s['E'] == check['monster_text']
    con.close()
    result = {'scope': 'All 24 installed CCG Pendulums; client text parser reproduction and Lua wiring/parity, not full in-game behavior certification',
              'backup': str(BACKUP), 'backup_sha256': digest(BACKUP), 'installed_database_sha256': digest(DB),
              'format': 'P newline pendulum text newline E newline monster text',
              'client_evidence': 'tmp/cpp2il_isil/IsilDump/Assembly-CSharp/Card/CardLocalization.txt constructor; DBTextHeader enum P=80 E=69',
              'checks': checks, 'unrelated_rows_metadata_and_prompt_strings_unchanged': True}
    (OUT / 'current-omega-pendulum-text-repair.json').write_text(json.dumps(result, indent=2, ensure_ascii=False)+'\n', encoding='utf-8')
    print(json.dumps({'checked': len(checks), 'previously_empty_pendulum_boxes': sum(c['before_pendulum_empty'] for c in checks), 'integrity': 'ok'}))

if __name__ == '__main__':
    main()
