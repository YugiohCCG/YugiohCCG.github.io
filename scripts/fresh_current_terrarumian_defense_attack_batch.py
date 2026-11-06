import hashlib,json,subprocess
from pathlib import Path
ROOT=Path.cwd();OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
paths=[Path(__file__).resolve(),ROOT/'scripts/fresh_current_terrarumian_defense_attack.cjs',ROOT/'scripts/fresh_terrarumian_cushion_defense_attack.cjs',ROOT/'scripts/fresh_corrected_card_data_transport.cjs',ROOT/'scripts/fresh_installed_card.cjs',OUT/'candidate-CCG_v1.db',FILES/'Databases/CCG_v1.db']+[ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua' for c in range(284639717,284639725)]+[ROOT/'tmp/omega_scripts'/n for n in ['constant.lua','utility.lua','procedure.lua']]+list((ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist').glob('*.js'))+[ROOT/'node_modules/@n1xx1/ocgcore-wasm/dist/index-card-data-transport-candidate.mjs']
before={str(p.resolve()):sha(p) for p in paths};runs=[]
for c in range(284639717,284639725):
 for control in [None,'no-attack','use-defense']:
  r=subprocess.run(['node','--no-warnings','scripts/fresh_current_terrarumian_defense_attack.cjs',str(c)]+(['--'+control] if control else []),capture_output=True,text=True,timeout=20)
  p=OUT/(f'current-terrarumian-{c}-defense-attack'+('-'+control if control else '')+'.json');d=json.loads(p.read_text());assert bool(d['failure'])==bool(control) and not d['logs'],(c,control,r.stdout+r.stderr);assert r.returncode==bool(control)
  runs.append({'passcode':c,'control':control,'artifact':p.name,'sha256':sha(p),'expected_failure':bool(control)})
assert before=={str(p.resolve()):sha(p) for p in paths};assert all((ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{c}.lua').read_bytes()==(FILES/'Scripts'/f'c{c}.lua').read_bytes() for c in range(284639717,284639725))
(OUT/'current-terrarumian-defense-attack-batch.json').write_text(json.dumps({'status':'NATIVE_DEFENSE_ATTACK_FAMILY_VERIFIED','runtime_dependencies_sha256':before,'runs':runs,'scope':'All eight full production scripts; installed metadata except explicitly controlled ATK900/DEF3000 for discriminating stat choice. Corrected transport/no Lua API adapter. Actual native battle from faceup defense against ATK1000: attacker destroyed/opponent survives. Omitted defense-attack permission and DEF-instead-of-ATK controls fail. Source seeded field; no natural summon conclusion. Controlled stats, full-card and live Omega limits explicit.'},indent=2)+'\n',encoding='utf-8');print('Eight defense-attack effects and effective controls verified')
