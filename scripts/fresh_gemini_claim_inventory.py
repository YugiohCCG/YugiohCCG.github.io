"""Capture Gemini's assertions separately from verified audit results."""
import hashlib, json, re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
REPORT = Path(r'C:\Users\hclar\.gemini\antigravity\brain\2502d83b-69f1-4c3d-88d3-8f14eaacfb7b\CCG_Omega_Card_Effect_Bug_Audit_Report.md')
OUT = ROOT / 'output/fresh-ccg-september'
text = REPORT.read_text(encoding='utf-8')
lines = text.splitlines()
rows, claims = [], []
group = card = section = ''
fenced = False
for number, line in enumerate(lines, 1):
    if line.startswith('```'):
        fenced = not fenced
        continue
    if fenced:
        continue
    if line.startswith('### Group '):
        group = line.split(':')[0].replace('### ', '')
    if re.match(r'^#{2,3} \d+[. ]', line) and 'Passcode' not in line and group:
        card = line.lstrip('# ')
    if line.startswith('#'):
        section = line.lstrip('# ')
    if re.match(r'^\d+\. \*\*', line) or (line.startswith('- **Stellaer of') and group):
        claims.append({'key': f'report-L{number}', 'line': number, 'group': group,
                       'card': card, 'section': section, 'claim': line,
                       'status': 'PENDING_INDIVIDUAL_REVIEW'})
    if line.startswith('| `') and number > next(i for i,l in enumerate(lines,1) if l.startswith('## 4. Master')):
        cells = [c.strip() for c in line.strip('|').split('|')]
        code = int(re.search(r'\d+', cells[0]).group())
        source = ROOT / f'public/CCG Downloads/CCG_Scripts/c{code}.lua'
        rows.append({'passcode': code, 'name': cells[1].strip('*'), 'line': number,
                     'categories': re.findall(r'`([^`]+)`', cells[3]),
                     'claimed_lines': cells[4], 'reference': cells[5],
                     'source_sha256': hashlib.sha256(source.read_bytes()).hexdigest() if source.exists() else None,
                     'status': 'UNDERSPECIFIED' if cells[4] == 'Logic/Structural' else 'PENDING_CONTEXT_REVIEW'})
result = {'report_sha256': hashlib.sha256(REPORT.read_bytes()).hexdigest(),
          'scope': 'Claim inventory, not proof of defects; pending entries are not checked/fixed cards.',
          'report_claimed_scripts': 621,
          'current_roster': len(json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']),
          'deep_claims': claims, 'master_rows': rows}
(OUT/'gemini-claim-inventory.json').write_text(json.dumps(result,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'deep_claims': len(claims), 'master_rows': len(rows), 'unique_master_cards': len({r['passcode'] for r in rows}),
                  'underspecified_rows': sum(r['status']=='UNDERSPECIFIED' for r in rows)}))
