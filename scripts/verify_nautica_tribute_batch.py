"""Verify this bounded repair without relaxing the historical audit ledger."""
import hashlib
import json
import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / 'output/fresh-ccg-september'
BACKUP = OUT / 'nautica-before-full-field-tribute-repair'
INSTALLED = Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')
SOURCE = ROOT / 'public/CCG Downloads/CCG_Scripts'
sha = lambda p: hashlib.sha256(p.read_bytes()).hexdigest()
read = lambda p: json.loads(p.read_text(encoding='utf-8'))
codes = [259941091, 225109525, 218905439]
files = []
for code in codes:
    name = f'c{code}.lua'
    old = (BACKUP / name).read_text(encoding='utf-8')
    before, after = ('local p=1-tp; if Duel.GetLocationCount(p,LOCATION_MZONE)<=0 then return end', 'local p=1-tp') if code == 259941091 else ('or (ft>0 and Duel.IsPlayerCanSummon(p)', 'or (Duel.IsPlayerCanSummon(p)')
    assert old.count(before) == 1
    assert old.replace(before, after) == (SOURCE / name).read_text(encoding='utf-8')
    assert (SOURCE / name).read_bytes() == (INSTALLED / name).read_bytes()
    files.append(dict(passcode=code, source_sha256=sha(SOURCE / name), installed_sha256=sha(INSTALLED / name),
                      before_source_sha256=sha(BACKUP / name), before_installed_sha256=sha(BACKUP / ('installed-' + name))))
artifacts = {}
for name, count, expected in [
    ('current-oceanica-summon-followup-tribute-source.json', 3, []),
    ('nautica-full-field-tribute-source.json', 6, []),
]:
    data = read(OUT / name)
    assert len(data['results']) == count and all(not r['logs'] for r in data['results'])
    assert [i for i, r in enumerate(data['results']) if r['failure']] == expected
    artifacts[name] = sha(OUT / name)
for name, count, expected in [
    ('current-oceanica-summon-followup-tribute-source.json', 3, [1]),
    ('nautica-full-field-tribute-source.json', 6, [1, 4]),
]:
    data = read(BACKUP / name)
    assert len(data['results']) == count and all(not r['logs'] for r in data['results'])
    assert [i for i, r in enumerate(data['results']) if r['failure']] == expected
    artifacts['nautica-before-full-field-tribute-repair/' + name] = sha(BACKUP / name)
cards = {int(c['passcode']): c for c in read(ROOT / 'src/data/cards.json') if c.get('passcode')}
callers = []
for path in sorted(SOURCE.glob('c*.lua')):
    text = path.read_text(encoding='utf-8-sig')
    if not re.search(r'Duel\.Summon\s*\(', text):
        continue
    code = int(path.stem[1:])
    callers.append(dict(passcode=code, name=cards[code]['name'],
        printed_text=cards[code]['text'], source_sha256=sha(path),
        verdict='CONFIRMED_AND_FIXED' if code in codes else 'NO_SAME_BLANKET_NORMAL_SUMMON_CAPACITY_GATE',
        rationale='Native IsSummonable handles Tribute space; Special Summon capacity checks remain valid. Own source self-Special-Summon capacity checks are separate prerequisites.'))
assert len(callers) == 15
regression = read(ROOT / 'scripts/output/ohmen-lua-regressions/nautica-tribute-20261115-summary.json')
assert len(regression) == 33 and all(r['status'] == 0 for r in regression)
probes = read(OUT / 'ohmen-additional-engine-probes.json')
assert len(probes) == 17 and all(not r['failure'] for r in probes)
gate = read(OUT / 'current-ohmen-effects-batch.json')
assert gate['baseline_cases'] == 38
report = dict(
    status='THREE_BOUNDED_REPAIRS_VERIFIED_AND_INSTALLED_BROAD_GATES_OPEN', files=files,
    cases=9, original_failures=3, regression_cases=131, additional_probes=17, legacy_ohmen_gate_cases=38,
    counts_note='Suite counts reported separately; no assertion that they are disjoint or total716.',
    artifacts_sha256=artifacts, scan=dict(scripts=704, current_spec_cards=703, normal_summon_callers=callers),
    rule_source='https://img.yugioh-card.com/en/downloads/rulebook/SD_RuleBook_EN_10.pdf',
    rule_inference='A Tribute Summon removes its Tributes before placement. IsSummonable permits legal Tribute Summons with occupied Main Monster Zones.',
    qualifications=['Oceanica test-only IsChainDisabled query mapping retained.', 'Adventures test-only CHAININFO_TARGET_CARDS=8 mapping retained.',
        'Evander initially seeded Xyz source; neutral paid Overlay setup, not proof of original Xyz recipe.',
        'Full-field Level2 return tests verify Extra Zone target exclusion before resolution; four Level5 cases verify actual return, Tribute payment, summon and ATK0.',
        'No live Omega duel verification; no full-card or archetype completion.'],
    broad_gate_results=read(OUT / 'nautica-full-field-tribute-batch/commands.json'),
    remaining=['Historical711 syntax/init roster requires reconciliation to current703 specification.',
        'Historical strict repair composition rejects existing source changes; do not weaken assertions.',
        'Historical installed initialization artifact/hash relationship is inconsistent.',
        'Oceanica both-player Hand mode selection and original-runtime query verification remain open.'],
    clause_coverage={str(code): dict(full_card='OPEN', tested='Normal Summon followup permits legal full-field Tribute Summon and preserves ATK0; Level2 capacity boundary',
        other_effects='Existing scoped evidence retained; unresolved clauses remain open') for code in codes})
(OUT / 'current-nautica-full-field-tribute-review.json').write_text(json.dumps(report, indent=2, ensure_ascii=False) + '\n', encoding='utf-8')
print('Verified 3 exact repairs/installed parity; 9 cases pass; 3 old failures; all15 Normal Summon callers reviewed.')
