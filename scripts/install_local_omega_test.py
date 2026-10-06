"""Install the current CCG candidate into local Omega for testing, with backups."""
import hashlib,json,os,shutil,sqlite3,sys
from datetime import datetime
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
OUT=ROOT/'output/fresh-ccg-september'
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def connect(p):return sqlite3.connect(p.resolve().as_uri()+'?mode=ro',uri=True)
def record(manifest):
 backup=Path(manifest['backup']).resolve()
 assert backup.is_relative_to((FILES/'Backup').resolve())
 for p in (backup/'manifest.json',OUT/'local-omega-test-install.json'):
  p.write_text(json.dumps(manifest,indent=2)+'\n',encoding='utf-8')
def finish(manifest,candidate,target,sources,scripts):
 assert sha(candidate)==manifest['database_after_sha256'],'Candidate changed since backup; review before resuming'
 assert sha(target) in (manifest['database_before_sha256'],manifest['database_after_sha256']),'Installed DB changed since backup'
 assert all(sha(p)==sha(scripts/p.name) for p in sources),'Source/install script parity changed'
 temp=target.with_name(target.name+'.ccg-test-tmp')
 if sha(target)!=manifest['database_after_sha256']:
  shutil.copy2(candidate,temp)
  try:os.replace(temp,target)
  except PermissionError:
   manifest['status']='SCRIPTS_INSTALLED_DATABASE_PENDING_GAME_CLOSE';record(manifest)
   raise RuntimeError('Close Omega to release database, then rerun with --resume') from None
 assert sha(target)==sha(candidate)
 with connect(target) as c:assert c.execute('pragma integrity_check').fetchone()[0]=='ok'
 manifest.update(status='INSTALLED_AND_HASH_VERIFIED',changed_scripts=len(manifest['changes']),new_scripts=sum(not x['existed'] for x in manifest['changes']))
 record(manifest)
 print(json.dumps({k:v for k,v in manifest.items() if k!='changes'},indent=2))
def main():
 candidate=OUT/'candidate-CCG_v1.db';target=FILES/'Databases/CCG_v1.db';scripts=FILES/'Scripts'
 roster=json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']
 assert target.is_file() and scripts.is_dir()
 if '--resume' in sys.argv:
  manifest=json.loads((OUT/'local-omega-test-install.json').read_text(encoding='utf-8'))
  assert manifest['status']=='SCRIPTS_INSTALLED_DATABASE_PENDING_GAME_CLOSE','No pending database install'
  sources=sorted((ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'))
  finish(manifest,candidate,target,sources,scripts);return
 with connect(candidate) as c,connect(target) as old:
  assert c.execute('pragma integrity_check').fetchone()[0]=='ok'
  for table in ('datas','texts'):
   newids={r[0] for r in c.execute('select id from '+table)};oldids={r[0] for r in old.execute('select id from '+table)}
   assert oldids<=newids,('Installed-only rows would be lost',table,oldids-newids)
  assert all(c.execute('select 1 from datas where id=?',(card['passcode'],)).fetchone() and c.execute('select 1 from texts where id=?',(card['passcode'],)).fetchone() for card in roster)
 sources=sorted((ROOT/'public/CCG Downloads/CCG_Scripts').glob('*.lua'))
 assert all(any(p.name=='c'+str(card['passcode'])+'.lua' for p in sources) for card in roster)
 changes=[p for p in sources if not (scripts/p.name).exists() or sha(p)!=sha(scripts/p.name)]
 backup=FILES/'Backup'/('CCG-Test-'+datetime.now().strftime('%Y%m%d-%H%M%S'));backup.mkdir(parents=True,exist_ok=False)
 manifest={'purpose':'Local Omega test installation, not native certification or public release','backup':str(backup),'database_before_sha256':sha(target),'database_after_sha256':sha(candidate),'roster_cards':len(roster),'source_scripts':len(sources),'changes':[]}
 with connect(target) as original,sqlite3.connect(backup/'CCG_v1.db') as saved:original.backup(saved)
 (backup/'Scripts').mkdir()
 for p in changes:
  dest=scripts/p.name;existed=dest.exists()
  if existed:shutil.copy2(dest,backup/'Scripts'/p.name)
  manifest['changes'].append({'name':p.name,'existed':existed,'before_sha256':sha(dest) if existed else None,'after_sha256':sha(p)})
 (backup/'manifest.json').write_text(json.dumps(manifest,indent=2)+'\n',encoding='utf-8')
 for p in changes:
  dest=scripts/p.name;temp=dest.with_name(dest.name+'.ccg-test-tmp');shutil.copy2(p,temp);os.replace(temp,dest)
 manifest.update(status='SCRIPTS_INSTALLED_DATABASE_PENDING_GAME_CLOSE',changed_scripts=len(changes),new_scripts=sum(not x['existed'] for x in manifest['changes']))
 record(manifest)
 finish(manifest,candidate,target,sources,scripts)
if __name__=='__main__':main()
