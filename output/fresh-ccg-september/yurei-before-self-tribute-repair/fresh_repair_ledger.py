"""Reconcile documented individual repairs; counts repaired cards, not complete audits."""
import hashlib,json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september';FILES=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
_necro_deck_cost_views={}
def pre_necro_deck_cost_source(p):
 current=p.read_bytes();manifest=OUT/'necrovalley-deck-cost-repair-files.json'
 if p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 key=str(p.resolve())
 if key not in _necro_deck_cost_views:
  import subprocess
  backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[3])))",str(backup/p.name),item['helper'],str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10)
  assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_necro_deck_cost_views[key]=old
 return _necro_deck_cost_views[key]

_field_destroy_damage_views={}
def pre_field_destroy_damage_source(p):
 current=pre_brazier_visibility_source(p);manifest=OUT/'field-destroy-damage-step-repair-files.json'
 if p.name not in ['c238276251.lua','c251236672.lua'] or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _field_destroy_damage_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[3])))",str(backup/p.name),item['helper'],str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_field_destroy_damage_views[key]=old
 return _field_destroy_damage_views[key]
_resource_visibility_views={}
def pre_resource_visibility_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'destroy-resource-visibility-repair-files.json'
 if p.name not in ['c238276248.lua','c284636589.lua','c247755871.lua'] or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _resource_visibility_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[3])))",str(backup/p.name),item['helper'],str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_resource_visibility_views[key]=old
 return _resource_visibility_views[key]
_previous_visibility_views={}
def pre_previous_visibility_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'destroyed-previous-visibility-repair-files.json'
 if p.name not in ['c235051048.lua','c247755869.lua','c239935098.lua'] or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _previous_visibility_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[3])))",str(backup/p.name),item['helper'],str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_previous_visibility_views[key]=old
 return _previous_visibility_views[key]
_observatory_damage_views={}
def pre_observatory_damage_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'observatory-damage-step-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c238274862.lua').resolve(),(FILES/'Scripts/c238274862.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _observatory_damage_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_observatory_damage_views[key]=old
 return _observatory_damage_views[key]
_aldrez_revival_damage_views={}
def pre_aldrez_revival_damage_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'aldrez-revival-damage-step-repair-files.json'
 if p.name not in ['c238282350.lua','c231129918.lua'] or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _aldrez_revival_damage_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_aldrez_revival_damage_views[key]=old
 return _aldrez_revival_damage_views[key]
_matriarch_damage_views={}
def pre_matriarch_damage_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'matriarch-damage-step-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c259093260.lua').resolve(),(FILES/'Scripts/c259093260.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _matriarch_damage_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_matriarch_damage_views[key]=old
 return _matriarch_damage_views[key]
_yurei_tribute_views={}
def pre_yurei_tribute_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'yurei-tribute-resolution-repair-files.json'
 if p.name!='c259844716.lua' or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _yurei_tribute_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_yurei_tribute_resolution_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_yurei_tribute_views[key]=old
 return _yurei_tribute_views[key]
_remaining_normal_views={}
def pre_remaining_normal_source(p):
 current=pre_yurei_tribute_source(p);manifest=OUT/'remaining-normal-summon-repair-files.json'
 if p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 key=str(p.resolve())
 if key not in _remaining_normal_views:
  import subprocess
  backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2])[process.argv[3]](require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper'],item['method']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_remaining_normal_views[key]=old
 return _remaining_normal_views[key]
_sear_native_type_views={}
def pre_sear_native_type_source(p):
 current=pre_remaining_normal_source(p);manifest=OUT/'sear-native-original-type-repair-files.json'
 if p.name!='c245935439.lua' or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _sear_native_type_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_sear_native_original_type_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_sear_native_type_views[key]=old
 return _sear_native_type_views[key]
_bobbie_normal_views={}
def pre_bobbie_normal_source(p):
 current=pre_sear_native_type_source(p);manifest=OUT/'bobbie-normal-summon-repair-files.json'
 if p.name!='c259114562.lua' or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _bobbie_normal_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_bobbie_normal_summon_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_bobbie_normal_views[key]=old
 return _bobbie_normal_views[key]
_normal_zero_views={}
def pre_normal_zero_source(p):
 current=pre_bobbie_normal_source(p);manifest=OUT/'nautica-normal-summon-zero-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if p.name==v['file'] and p.resolve().parent in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()]),None)
 if not item:return current
 key=str(p.resolve())
 if key not in _normal_zero_views:
  import subprocess
  backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_nautica_normal_summon_zero_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(backup/p.name),str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_normal_zero_views[key]=old
 return _normal_zero_views[key]
_bottom_order_views={}
def pre_bottom_order_source(p):
 current=pre_normal_zero_source(p);manifest=OUT/'nautica-bottom-order-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if p.name==v['file'] and p.resolve().parent in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()]),None)
 if not item:return current
 key=str(p.resolve())
 if key not in _bottom_order_views:
  import subprocess
  backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_nautica_bottom_order_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(backup/p.name),str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_bottom_order_views[key]=old
 return _bottom_order_views[key]
def pre_shuffle_timing_source(p):
 current=pre_bottom_order_source(p);manifest=OUT/'shuffle-search-timing-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if p.name==v['file'] and p.resolve().parent in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()]),None)
 if not item:return current
 import subprocess
 backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
 r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256']
 return old
def pre_phase_limit_source(p):
 current=pre_shuffle_timing_source(p);review=OUT/'phase-limit-repair-review';manifest=review/'manifest.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if p.resolve() in [Path(v['source']).resolve(),Path(v['installed']).resolve()]),None)
 if not item:return current
 old=(review/item['source_backup']).read_bytes();assert old==(review/item['installed_backup']).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
 if item['passcode']==259265448:
  pattern=b'\te2:SetCountLimit(1,id+100)\n';assert old.count(pattern)==1;expected=old.replace(pattern,b'')
 else:
  pattern=b'if chk==0 then return c:GetOverlayGroup()';assert old.count(pattern)==1 and old.count(b'Duel.DisableShuffleCheck()')==1
  expected=old.replace(pattern,b'if chk==0 then return c:GetFlagEffect(id+1000)==0 and c:GetOverlayGroup()').replace(b'Duel.DisableShuffleCheck()',b'c:RegisterFlagEffect(id+1000,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_BATTLE,0,1) Duel.DisableShuffleCheck()')
 assert expected==current==(review/item['proposed_file']).read_bytes() and hashlib.sha256(current).hexdigest()==item['proposed_sha256']
 return old
_underworld_then_views={}
def pre_underworld_then_source(p):
 current=pre_phase_limit_source(p);manifest=OUT/'underworld-then-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c259265448.lua').resolve(),(FILES/'Scripts/c259265448.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _underworld_then_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_underworld_then_views[key]=old
 return _underworld_then_views[key]
_underworld_damage_views={}
def pre_underworld_damage_source(p):
 current=pre_underworld_then_source(p);manifest=OUT/'underworld-damage-step-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c259265448.lua').resolve(),(FILES/'Scripts/c259265448.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _underworld_damage_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_underworld_damage_views[key]=old
 return _underworld_damage_views[key]
_origins_damage_views={}
def pre_origins_damage_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'origins-damage-step-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c244986323.lua').resolve(),(FILES/'Scripts/c244986323.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _origins_damage_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_origins_damage_views[key]=old
 return _origins_damage_views[key]
_queen_support_views={}
def pre_queen_support_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'queen-support-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c231892575.lua').resolve(),(FILES/'Scripts/c231892575.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _queen_support_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_queen_support_views[key]=old
 return _queen_support_views[key]
_rigel_rating_views={}
def pre_rigel_rating_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'rigel-link-rating-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c215853847.lua').resolve(),(FILES/'Scripts/c215853847.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _rigel_rating_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_rigel_rating_views[key]=old
 return _rigel_rating_views[key]
_prayer_visibility_views={}
def pre_prayer_visibility_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'prayer-visibility-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c238276252.lua').resolve(),(FILES/'Scripts/c238276252.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _prayer_visibility_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_prayer_visibility_views[key]=old
 return _prayer_visibility_views[key]
_brazier_visibility_views={}
def pre_brazier_visibility_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'brazier-destroyed-visibility-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c238276251.lua').resolve(),(FILES/'Scripts/c238276251.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _brazier_visibility_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_brazier_visibility_views[key]=old
 return _brazier_visibility_views[key]
_tristegsaurus_damage_views={}
def pre_tristegsaurus_damage_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'tristegsaurus-damage-step-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c244162598.lua').resolve(),(FILES/'Scripts/c244162598.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _tristegsaurus_damage_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_tristegsaurus_damage_views[key]=old
 return _tristegsaurus_damage_views[key]
_octantis_damage_views={}
def pre_octantis_damage_source(p):
 current=pre_previous_visibility_source(p);manifest=OUT/'octantis-damage-step-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c235051048.lua').resolve(),(FILES/'Scripts/c235051048.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _octantis_damage_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_octantis_damage_views[key]=old
 return _octantis_damage_views[key]
_murugan_damage_views={}
def pre_murugan_damage_source(p):
 current=pre_previous_visibility_source(p);manifest=OUT/'murugan-damage-step-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c247755869.lua').resolve(),(FILES/'Scripts/c247755869.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _murugan_damage_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_murugan_damage_views[key]=old
 return _murugan_damage_views[key]
_trumpet_damage_views={}
def pre_trumpet_damage_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'trumpet-damage-step-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c284639724.lua').resolve(),(FILES/'Scripts/c284639724.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _trumpet_damage_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_trumpet_damage_views[key]=old
 return _trumpet_damage_views[key]
_terrarumian_destroy_views={}
def pre_terrarumian_destroy_source(p):
 current=pre_trumpet_damage_source(p);manifest=OUT/'terrarumian-destroy-visibility-repair-files.json'
 if p.name not in [f'c{code}.lua' for code in range(284639717,284639725)] or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _terrarumian_destroy_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_terrarumian_destroy_views[key]=old
 return _terrarumian_destroy_views[key]
_trumpet_visibility_views={}
def pre_trumpet_visibility_source(p):
 current=pre_terrarumian_destroy_source(p);manifest=OUT/'trumpet-destroyed-visibility-repair-files.json'
 if p.resolve() not in [(ROOT/'public/CCG Downloads/CCG_Scripts/c284639724.lua').resolve(),(FILES/'Scripts/c284639724.lua').resolve()] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _trumpet_visibility_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  r=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert r.returncode==0 and r.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_trumpet_visibility_views[key]=old
 return _trumpet_visibility_views[key]
_terrarumian_condition_views={}
def pre_terrarumian_condition_source(p):
 current=pre_trumpet_visibility_source(p);manifest=OUT/'terrarumian-condition-visibility-repair-files.json'
 if p.name not in [f'c{code}.lua' for code in range(284639718,284639725)] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _terrarumian_condition_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_terrarumian_condition_views[key]=old
 return _terrarumian_condition_views[key]
_continuous_condition_views={}
def pre_continuous_condition_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'continuous-condition-contract-repair-files.json'
 if p.name not in ['c250829750.lua','c258576611.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _continuous_condition_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_continuous_condition_views[key]=old
 return _continuous_condition_views[key]
_ivy_battle_visibility_views={}
def pre_ivy_battle_visibility_source(p):
 current=pre_terrarumian_condition_source(p);manifest=OUT/'ivy-battle-visibility-repair-files.json'
 if p.name not in ['c284639722.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _ivy_battle_visibility_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper'],str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_ivy_battle_visibility_views[key]=old
 return _ivy_battle_visibility_views[key]
_harpie_field_set_views={}
def pre_harpie_field_set_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'harpie-field-set-capacity-repair-files.json'
 if p.name not in ['c259794136.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _harpie_field_set_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper'],str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_harpie_field_set_views[key]=old
 return _harpie_field_set_views[key]
_growth_field_set_views={}
def pre_growth_field_set_source(p):
 current=pre_resource_visibility_source(p);manifest=OUT/'growth-field-set-capacity-repair-files.json'
 if p.name not in ['c284636589.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _growth_field_set_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper'],str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_growth_field_set_views[key]=old
 return _growth_field_set_views[key]
_field_set_capacity_views={}
def pre_field_set_capacity_source(p):
 current=pre_terrarumian_condition_source(p);manifest=OUT/'terrarumian-field-set-capacity-repair-files.json'
 if p.name not in ['c284639719.lua','c284639720.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _field_set_capacity_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[3])))",str(backup/p.name),item['helper'],str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_field_set_capacity_views[key]=old
 return _field_set_capacity_views[key]
_coin_defense_views={}
def pre_coin_defense_source(p):
 current=pre_terrarumian_condition_source(p);manifest=OUT/'coin-defense-requirement-repair-files.json'
 if p.name not in ['c284639718.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _coin_defense_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_coin_defense_views[key]=old
 return _coin_defense_views[key]
_arktos_extra_views={}
def pre_arktos_extra_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'arktos-extra-column-repair-files.json'
 if p.name not in ['c259537607.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _arktos_extra_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_arktos_extra_views[key]=old
 return _arktos_extra_views[key]
_krawler_origin_views={}
def pre_krawler_origin_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'krawler-effect-origin-repair-files.json'
 if p.name not in ['c259322868.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _krawler_origin_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_krawler_origin_views[key]=old
 return _krawler_origin_views[key]
_eldora_history_views={}
def pre_eldora_history_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'eldora-destroyed-history-repair-files.json'
 if p.name not in ['c250917339.lua','c259482393.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _eldora_history_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_eldora_history_views[key]=old
 return _eldora_history_views[key]
_trumpet_origin_views={}
def pre_trumpet_origin_source(p):
 current=pre_terrarumian_condition_source(p);manifest=OUT/'trumpet-destroyed-origin-repair-files.json'
 if p.name!='c284639724.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _trumpet_origin_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_trumpet_origin_views[key]=old
 return _trumpet_origin_views[key]
_scion_hand_views={}
def pre_scion_hand_source(p):
 current=pre_resource_visibility_source(p);manifest=OUT/'scion-hand-arrival-repair-files.json'
 if p.name!='c238276248.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _scion_hand_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_scion_hand_views[key]=old
 return _scion_hand_views[key]
_champion_hand_views={}
def pre_champion_hand_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'champion-hand-arrival-repair-files.json'
 if p.name!='c259429721.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _champion_hand_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_champion_hand_views[key]=old
 return _champion_hand_views[key]
_independent_followup_views={}
def pre_independent_followup_source(p):
 current=pre_champion_hand_source(p);manifest=OUT/'independent-followups-repair-files.json'
 if p.name not in ['c224822244.lua','c259429721.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _independent_followup_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/'+process.argv[2]).corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),item['helper']],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_independent_followup_views[key]=old
 return _independent_followup_views[key]
_triceron_independent_views={}
def pre_triceron_independent_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'triceron-independent-shuffle-repair-files.json'
 if p.name!='c259640854.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _triceron_independent_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'triceron-before-independent-shuffle-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_triceron_independent_shuffle_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_triceron_independent_views[key]=old
 return _triceron_independent_views[key]
_nether_move_visibility_views={}
def pre_nether_move_visibility_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'nether-move-visibility-repair-files.json'
 if p.name!='c238272436.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _nether_move_visibility_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'nether-before-move-visibility-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_nether_move_visibility_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_nether_move_visibility_views[key]=old
 return _nether_move_visibility_views[key]
_shuffle_visibility_views={}
def pre_shuffle_visibility_source(p):
 current=pre_triceron_independent_source(p) if p.name=='c259640854.lua' else pre_nether_move_visibility_source(p);manifest=OUT/'shuffle-visibility-repair-files.json'
 if p.name not in ['c238272436.lua','c259640854.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _shuffle_visibility_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/'shuffle-visibility-before-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_nether_shuffle_visibility_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(backup/p.name),str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_shuffle_visibility_views[key]=old
 return _shuffle_visibility_views[key]
_send_arrival_views={}
def pre_send_arrival_source(p):
 current=pre_shuffle_visibility_source(p);manifest=OUT/'send-arrival-repair-files.json'
 if p.name not in ['c238272436.lua','c284636661.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _send_arrival_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/'send-arrival-before-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_nether_send_arrival_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(backup/p.name),str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_send_arrival_views[key]=old
 return _send_arrival_views[key]
_underroot_space_views={}
def pre_underroot_space_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'underroot-projected-space-repair-files.json'
 if p.name!='c238272437.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _underroot_space_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'underroot-before-projected-space-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_underroot_projected_space_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_underroot_space_views[key]=old
 return _underroot_space_views[key]
_independent_summon_lock_views={}
def pre_independent_summon_lock_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'independent-summon-locks-repair-files.json'
 if p.name not in ['c259366591.lua','c220856437.lua','c259472680.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _independent_summon_lock_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/'independent-summon-locks-before-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_independent_summon_locks_repair.cjs').corrected(Number(process.argv[2]),require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name),str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_independent_summon_lock_views[key]=old
 return _independent_summon_lock_views[key]
_vylon_lock_views={}
def pre_vylon_lock_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'vylon-aid-independent-lock-repair-files.json'
 if p.name!='c238274861.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _vylon_lock_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'vylon-aid-before-independent-lock-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_vylon_aid_lock_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_vylon_lock_views[key]=old
 return _vylon_lock_views[key]
_adamantios_name_views={}
def pre_adamantios_name_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'adamantios-name-repair-files.json'
 if p.name!='c259315827.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _adamantios_name_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'adamantios-before-name-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_adamantios_name_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_adamantios_name_views[key]=old
 return _adamantios_name_views[key]
_adamantios_replacement_views={}
def pre_adamantios_replacement_source(p):
 current=pre_adamantios_name_source(p);manifest=OUT/'adamantios-replacement-identity-repair-files.json'
 if p.name!='c259315827.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _adamantios_replacement_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'adamantios-before-replacement-identity-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_adamantios_replacement_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_adamantios_replacement_views[key]=old
 return _adamantios_replacement_views[key]
_destroy_replacement_views={}
def pre_destroy_replacement_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'destroy-replacement-repair-files.json'
 if p.name not in ['c244790302.lua','c248788543.lua'] or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _destroy_replacement_views:
  import subprocess
  item=next(v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name);backup=OUT/'destroy-replacement-before-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_avatar_replacement_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8'),Number(process.argv[2])))",str(backup/p.name),str(item['passcode'])],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_destroy_replacement_views[key]=old
 return _destroy_replacement_views[key]
_avatar_copy_views={}
def pre_avatar_copy_source(p):
 current=pre_destroy_replacement_source(p);manifest=OUT/'avatar-copy-state-repair-files.json'
 if p.name!='c244790302.lua' or not manifest.exists():return current
 key=str(p.resolve())
 if key not in _avatar_copy_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'avatar-before-copy-state-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_avatar_copy_identity_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_avatar_copy_views[key]=old
 return _avatar_copy_views[key]
_stain_departure_views={}
def pre_stain_departure_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'stain-departure-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 key=str(p.resolve())
 if key not in _stain_departure_views:
  import subprocess
  backup=OUT/'stain-before-departure-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_stain_departure_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_stain_departure_views[key]=old
 return _stain_departure_views[key]
_deck_monster_views={}
def pre_deck_monster_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'deck-monster-type-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 key=str(p.resolve())
 if key not in _deck_monster_views:
  import subprocess
  backup=OUT/'deck-monster-type-before-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_deck_monster_type_repair.cjs').corrected(Number(process.argv[1]),require('fs').readFileSync(process.argv[2],'utf8')))",str(item['passcode']),str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_deck_monster_views[key]=old
 return _deck_monster_views[key]
_destroy_summon_views={}
_capacity_views={}
_kali_capacity_views={}

_visibility_family_views={}
def pre_visibility_family_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'summon-visibility-family-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 if p.name not in _visibility_family_views:
  import subprocess
  backup=OUT/'summon-visibility-family-before-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_summon_visibility_family_repair.cjs').corrected(Number(process.argv[1]),require('fs').readFileSync(process.argv[2],'utf8')))",str(item['passcode']),str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_visibility_family_views[p.name]=(old,current)
 old,after=_visibility_family_views[p.name];assert current==after;return old

_visibility_views={}
def pre_visibility_source(p):
 current=pre_necro_deck_cost_source(p);manifest=OUT/'summon-visibility-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 if p.name not in _visibility_views:
  import subprocess
  backup=OUT/'summon-visibility-before-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_summon_visibility_repair.cjs').corrected(Number(process.argv[1]),require('fs').readFileSync(process.argv[2],'utf8')))",str(item['passcode']),str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_visibility_views[p.name]=(old,current)
 old,after=_visibility_views[p.name];assert current==after;return old

_mage_group_views={}
def pre_mage_group_source(p):
 current=pre_visibility_source(p);manifest=OUT/'mage-group-zone-repair-files.json'
 if p.name!='c259072906.lua' or not manifest.exists():return current
 if not _mage_group_views:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'mage-before-group-zone-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_mage_group_zone_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_mage_group_views.update(old=old,after=current)
 assert current==_mage_group_views['after'];return _mage_group_views['old']

_ritual_main_views={}
def pre_ritual_main_source(p):
 current=pre_mage_group_source(p);manifest=OUT/'ritual-main-space-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 if p.name not in _ritual_main_views:
  import subprocess
  backup=OUT/'ritual-before-main-space-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_ritual_main_space_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_ritual_main_views[p.name]=(old,current)
 old,after=_ritual_main_views[p.name];assert current==after;return old

_ritual_zone_views={}
def pre_ritual_zone_source(p):
 current=pre_ritual_main_source(p);manifest=OUT/'ritual-zone-subgroup-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 if p.name not in _ritual_zone_views:
  import subprocess
  backup=OUT/'ritual-before-zone-subgroup-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_ritual_zone_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_ritual_zone_views[p.name]=(old,current)
 old,after=_ritual_zone_views[p.name];assert current==after;return old

def pre_kali_capacity_source(p):
 current=pre_murugan_damage_source(p) if p.name=='c247755869.lua' else pre_resource_visibility_source(p) if p.name=='c247755871.lua' else pre_ritual_zone_source(p);manifest=OUT/'kali-zone-capacity-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 if p.name not in _kali_capacity_views:
  import subprocess
  backup=OUT/'kali-before-zone-capacity-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256'];code="const fs=require('node:fs');process.stdout.write(require('./scripts/fresh_current_kali_zone_capacity.cjs').corrected(Number(process.argv[1]),fs.readFileSync(process.argv[2],'utf8')))";a=subprocess.run(['node','--no-warnings','-e',code,str(item['passcode']),str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_kali_capacity_views[p.name]=(old,current)
 old,after=_kali_capacity_views[p.name];assert current==after;return old

def pre_capacity_source(p):
 current=pre_ivy_battle_visibility_source(p) if p.name=='c284639722.lua' else pre_trumpet_origin_source(p) if p.name=='c284639724.lua' else pre_coin_defense_source(p) if p.name=='c284639718.lua' else pre_field_set_capacity_source(p) if p.name in ['c284639719.lua','c284639720.lua'] else pre_terrarumian_condition_source(p) if p.name in ['c284639717.lua','c284639721.lua','c284639723.lua'] else pre_kali_capacity_source(p);manifest=OUT/'destroy-summon-capacity-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 if p.name not in _capacity_views:
  import subprocess
  backup=OUT/'destroy-summon-before-capacity-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256'];code="const fs=require('node:fs');process.stdout.write(require('./scripts/fresh_current_destroy_summon_capacity.cjs').corrected(Number(process.argv[1]),fs.readFileSync(process.argv[2],'utf8')))";a=subprocess.run(['node','--no-warnings','-e',code,str(item['passcode']),str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'];_capacity_views[p.name]=(old,current)
 old,after=_capacity_views[p.name];assert current==after;return old
def pre_seraphina_wipe_source(p):
 current=pre_capacity_source(p);manifest=OUT/'seraphina-wipe-relation-repair-files.json'
 if p.name!='c218142234.lua' or not manifest.exists():return current
 item=json.loads(manifest.read_text())['files'][0];backup=OUT/'seraphina-before-wipe-relation-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
 at=old.index(b'function s.desop(e,tp,eg,ep,ev,re,r,rp)');tail=old[at:];pattern=rb'\tif not \(c:IsRelateToEffect\(e\) and c:IsFaceup\(\)\) then return end\r?\n';changed,count=re.subn(pattern,b'',tail)
 assert count==1 and old[:at]+changed==current and hashlib.sha256(current).hexdigest()==item['after_sha256'],'Exact Seraphina destruction guard reconciliation failed'
 return old

def pre_unprinted_limit_source(p):
 current=pre_seraphina_wipe_source(p);manifest=OUT/'pendulum-unprinted-limit-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 backup=OUT/item['backup'];old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
 pattern=rb'\te1:SetCountLimit\(1,id'+(rb'\+200' if item['passcode']==259873115 else b'')+rb'\)\r?\n'
 changed,count=re.subn(pattern,b'',old)
 assert count==1 and changed==current and hashlib.sha256(current).hexdigest()==item['after_sha256'],'Exact unprinted Pendulum limit reconciliation failed'
 return old

def pre_disabled_corruption_source(p):
 current=pre_unprinted_limit_source(p);manifest=OUT/'disabled-corruption-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if v['file']==p.name),None)
 if not item:return current
 backup=OUT/'ritual-before-disabled-corruption-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
 pattern=rb'(function s\.corruptionfilter\(c\)\r?\n[ \t]*return c:IsFaceup\(\) and )(c:IsCode\([^\r\n]+\)\r?\nend)'
 changed,count=re.subn(pattern,lambda m:m[1]+b'not c:IsDisabled() and '+m[2],old,count=1)
 assert count==1 and changed==current and hashlib.sha256(current).hexdigest()==item['after_sha256'],'Exact disabled Corruption filter reconciliation failed'
 return old

_mage_counter_cache={}
def pre_mage_counter_source(p):
 current=pre_disabled_corruption_source(p)
 if p.name!='c259072906.lua':return current
 manifest=OUT/'mage-corruption-material-repair-files.json'
 if not manifest.exists():return current
 if not _mage_counter_cache:
  import subprocess
  item=json.loads(manifest.read_text())['files'][0];backup=OUT/'mage-before-corruption-material-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  code="const fs=require('node:fs');process.stdout.write(require('./scripts/fresh_mage_corruption_repair.cjs').corrected(fs.readFileSync(process.argv[1],'utf8')))"
  result=subprocess.run(['node','--no-warnings','-e',code,str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert result.returncode==0,result.stderr
  assert result.stdout==current and hashlib.sha256(current).hexdigest()==item['after_sha256'],'Mage exact counter-material reconciliation failed'
  _mage_counter_cache.update(old=old,current=current)
 assert current==_mage_counter_cache['current']
 return _mage_counter_cache['old']

def pre_revival_source(p):
 current=pre_mage_counter_source(p);manifest=OUT/'ritual-revival-repair-files.json'
 if not manifest.exists():return current
 item=next((v for v in json.loads(manifest.read_text())['files'] if p.name==v['file']),None)
 if not item:return current
 backup=OUT/'ritual-before-revival-limit-repair';previous=(backup/p.name).read_bytes()
 assert previous==(backup/('installed-'+p.name)).read_bytes() and sha(backup/p.name)==item['before_sha256']
 pattern=rb'(?:[ \t]*--(?:Special|Ritual) Summon limit\r?\n)?([ \t]*local e0=Effect.CreateEffect\(c\)\r?\n[\s\S]*?e0:SetValue\(aux.ritlimit\)\r?\n[ \t]*c:RegisterEffect\(e0\)\r?\n)'
 changed,count=re.subn(pattern,b'',previous,count=1)
 assert count==1 and changed==current and hashlib.sha256(current).hexdigest()==item['after_sha256'] and b'c:EnableReviveLimit()' in current,'Ritual revival reconciliation differs from exact block removal'
 return previous

def source_hash_matches(p,expected):
 if hashlib.sha256(pre_necro_deck_cost_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_yurei_tribute_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_normal_zero_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_bottom_order_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_shuffle_timing_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_phase_limit_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_underworld_then_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_matriarch_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_underworld_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_origins_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_aldrez_revival_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_queen_support_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_rigel_rating_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_prayer_visibility_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_brazier_visibility_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_observatory_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_tristegsaurus_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_field_destroy_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_resource_visibility_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_previous_visibility_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_octantis_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_murugan_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_trumpet_damage_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_terrarumian_destroy_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_trumpet_visibility_source(p)).hexdigest()==expected:return True
 if sha(p)==expected:return True
 if p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()]:return False
 if hashlib.sha256(pre_terrarumian_condition_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_continuous_condition_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_ivy_battle_visibility_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_harpie_field_set_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_growth_field_set_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_field_set_capacity_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_coin_defense_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_arktos_extra_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_krawler_origin_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_eldora_history_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_trumpet_origin_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_scion_hand_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_champion_hand_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_independent_followup_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_triceron_independent_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_nether_move_visibility_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_shuffle_visibility_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_send_arrival_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_underroot_space_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_independent_summon_lock_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_vylon_lock_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_adamantios_name_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_adamantios_replacement_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_destroy_replacement_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_avatar_copy_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_stain_departure_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_deck_monster_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_visibility_family_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_visibility_source(p)).hexdigest()==expected:return True
 if p.name=='c247789143.lua' and (OUT/'silphia-pair-repair-files.json').exists():
  import subprocess
  item=json.loads((OUT/'silphia-pair-repair-files.json').read_text())['files'][0];backup=OUT/'silphia-before-pair-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_silphia_pair_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==p.read_bytes() and sha(p)==item['after_sha256'];return expected==item['before_sha256']
 if p.name=='c237089049.lua' and (OUT/'azeriel-visibility-repair-files.json').exists():
  import subprocess
  item=json.loads((OUT/'azeriel-visibility-repair-files.json').read_text())['files'][0];backup=OUT/'azeriel-before-visibility-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_azeriel_visibility_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==pre_deck_monster_source(p) and hashlib.sha256(pre_deck_monster_source(p)).hexdigest()==item['after_sha256'];return expected==item['before_sha256']
 if p.name=='c259160760.lua' and (OUT/'sanctuary-visibility-repair-files.json').exists():
  import subprocess
  item=json.loads((OUT/'sanctuary-visibility-repair-files.json').read_text())['files'][0];backup=OUT/'sanctuary-before-visibility-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_sanctuary_visibility_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==p.read_bytes() and sha(p)==item['after_sha256'];return expected==item['before_sha256']
 if p.name=='c215034223.lua' and (OUT/'arms-united-visibility-repair-files.json').exists():
  import subprocess
  item=json.loads((OUT/'arms-united-visibility-repair-files.json').read_text())['files'][0];backup=OUT/'arms-united-before-visibility-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_arms_united_visibility_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==p.read_bytes() and sha(p)==item['after_sha256'];return expected==item['before_sha256']
 if p.name=='c247580036.lua' and (OUT/'dragar-also-repair-files.json').exists():
  import subprocess
  item=json.loads((OUT/'dragar-also-repair-files.json').read_text())['files'][0];backup=OUT/'dragar-before-also-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  a=subprocess.run(['node','-e',"process.stdout.write(require('./scripts/fresh_dragar_also_repair.cjs').corrected(require('fs').readFileSync(process.argv[1],'utf8')))",str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==pre_visibility_source(p) and hashlib.sha256(pre_visibility_source(p)).hexdigest()==item['after_sha256'];return expected==item['before_sha256']
 if p.name=='c253934904.lua' and (OUT/'stagger-capacity-repair-files.json').exists():
  item=json.loads((OUT/'stagger-capacity-repair-files.json').read_text())['files'][0];backup=OUT/'stagger-before-capacity-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256'];at=old.index(b'function s.sptg2(');nl=b'\r\n' if b'\r\n' in old else b'\n';helper=nl.join([b'function s.spacecheck(g,tp)',b' return Duel.GetMZoneCount(tp,g)>0',b'end',b'']);q=b'Duel.GetMatchingGroupCount(s.darkfilter,tp,LOCATION_MZONE,0,nil)>=2';assert old.count(q)==1;changed=(old[:at]+helper+old[at:]).replace(q,b'Duel.GetMatchingGroup(s.darkfilter,tp,LOCATION_MZONE,0,nil):CheckSubGroup(s.spacecheck,2,2,tp)');assert changed==p.read_bytes() and sha(p)==item['after_sha256'];return expected==item['before_sha256']
 if hashlib.sha256(pre_mage_group_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_ritual_main_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_capacity_source(p)).hexdigest()==expected:return True
 if p.name=='c247755871.lua' and (OUT/'jarita-revival-order-repair-files.json').exists():
  item=json.loads((OUT/'jarita-revival-order-repair-files.json').read_text())['files'][0];backup=OUT/'jarita-before-revival-order-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256'];start=old.index(b'function s.revop(');end=old.find(b'\nfunction ',start+1);end=len(old) if end<0 else end;body,count=re.subn(rb' if not c:IsRelateToEffect\(e\) then return end\r?\n',b'',old[start:end]);assert count==1 and old[:start]+body+old[end:]==pre_kali_capacity_source(p) and hashlib.sha256(pre_kali_capacity_source(p)).hexdigest()==item['after_sha256'];return expected==item['before_sha256']
 if p.name in ['c236898203.lua','c238274860.lua','c247755865.lua'] and (OUT/'destroy-summon-order-repair-files.json').exists():
  import subprocess
  item=next(v for v in json.loads((OUT/'destroy-summon-order-repair-files.json').read_text())['files'] if v['file']==p.name)
  if p.name not in _destroy_summon_views:
   backup=OUT/'destroy-summon-before-order-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256'];code="const fs=require('node:fs');process.stdout.write(require('./scripts/fresh_current_destroy_then_summon.cjs').corrected(Number(process.argv[1]),fs.readFileSync(process.argv[2],'utf8')))";a=subprocess.run(['node','--no-warnings','-e',code,str(item['passcode']),str(backup/p.name)],cwd=ROOT,capture_output=True,timeout=10);assert a.returncode==0,a.stderr;assert a.stdout==pre_capacity_source(p) and hashlib.sha256(a.stdout).hexdigest()==item['after_sha256'];_destroy_summon_views[p.name]=a.stdout
  assert pre_capacity_source(p)==_destroy_summon_views[p.name];return expected==item['before_sha256']
 if p.name=='c247755867.lua' and (OUT/'yajna-set-order-repair-files.json').exists():
  item=json.loads((OUT/'yajna-set-order-repair-files.json').read_text())['files'][0];backup=OUT/'yajna-before-set-order-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256'];nl=b'\r\n' if b'\r\n' in old else b'\n';before=b' if not c:IsRelateToEffect(e) or not tc or not tc:IsRelateToEffect(e)'+nl+b'  or Duel.Destroy(tc,REASON_EFFECT)==0 or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 or not c:IsSSetable() then return end';after=b' if not tc or not tc:IsRelateToEffect(e) or Duel.Destroy(tc,REASON_EFFECT)==0 then return end'+nl+b' if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 or not c:IsSSetable() then return end';assert old.count(before)==1 and old.replace(before,after)==p.read_bytes() and sha(p)==item['after_sha256'];return expected==item['before_sha256']
 if p.name=='c244790302.lua' and (OUT/'stained-avatar-relation-repair-files.json').exists():
  item=json.loads((OUT/'stained-avatar-relation-repair-files.json').read_text())['files'][0];backup=OUT/'stained-avatar-before-relation-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256'];at=old.index(b'function s.desop(');tail,count=re.subn(rb'\tif not c:IsRelateToEffect\(e\) then return end\r?\n',b'',old[at:]);assert count==1 and old[:at]+tail==pre_avatar_copy_source(p) and hashlib.sha256(pre_avatar_copy_source(p)).hexdigest()==item['after_sha256'];return expected==item['before_sha256']
 if hashlib.sha256(pre_seraphina_wipe_source(p)).hexdigest()==expected:return True
 if hashlib.sha256(pre_unprinted_limit_source(p)).hexdigest()==expected:return True
 stage=pre_disabled_corruption_source(p)
 if hashlib.sha256(stage).hexdigest()==expected:return True
 if p.name=='c284639720.lua':
  manifest=json.loads((OUT/'terrarumian-faceup-count-repair-files.json').read_text())['files'][0];backup=OUT/'terrarumian-before-faceup-count-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==manifest['before_sha256']
  nl=b'\r\n' if b'\r\n' in old else b'\n';before=b'function s.countfilter(c)'+nl+b' return c:IsSetCard(SET_TERRARUMIAN)'+nl+b'end';after=before.replace(b'return c:IsSetCard',b'return c:IsFaceup() and c:IsSetCard');assert old.count(before)==1 and old.replace(before,after)==stage and hashlib.sha256(stage).hexdigest()==manifest['after_sha256']
  return expected==manifest['before_sha256']
 if p.name=='c259882493.lua':
  item=json.loads((OUT/'patrician-extra-limit-repair-files.json').read_text())['files'][0];backup=OUT/'patrician-before-extra-limit-repair';old=(backup/p.name).read_bytes();assert old==(backup/('installed-'+p.name)).read_bytes() and hashlib.sha256(old).hexdigest()==item['before_sha256']
  text=old.decode('utf-8');text=text.replace('function s.initial_effect(c)','function s.initial_effect(c)\n Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.excounter)',1)
  text=text.replace('function s.splimit(e,se,sp,st) local c=e:GetHandler(); return not (c:IsLocation(LOCATION_EXTRA) and c:IsFacedown()) or st&SUMMON_TYPE_FUSION==SUMMON_TYPE_FUSION or se==e end','function s.excounter(c) return not (c:IsCode(id) and c:IsSummonLocation(LOCATION_EXTRA) and c:IsPreviousPosition(POS_FACEDOWN)) end\nfunction s.splimit(e,se,sp,st) local c=e:GetHandler(); return not (c:IsLocation(LOCATION_EXTRA) and c:IsFacedown()) or (Duel.GetCustomActivityCount(id,sp,ACTIVITY_SPSUMMON)==0 and (st&SUMMON_TYPE_FUSION==SUMMON_TYPE_FUSION or se==e)) end',1)
  text=text.replace('return c:IsFacedown() and Duel.IsExistingMatchingCard(s.rel','return c:IsFacedown() and Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 and Duel.IsExistingMatchingCard(s.rel',1)
  assert text.encode('utf-8')==p.read_bytes() and sha(p)==item['after_sha256'],'Patrician exact summon-counter reconciliation failed'
  return expected==item['before_sha256']
 stage=pre_mage_counter_source(p)
 if hashlib.sha256(stage).hexdigest()==expected:return True
 view=pre_revival_source(p)
 if p.name=='c259844716.lua':view=pre_remaining_normal_source(p)
 if hashlib.sha256(view).hexdigest()==expected:return True
 manifest=OUT/'public-reveal-repair-files.json'
 if not manifest.exists():return False
 entry=next((v for v in json.loads(manifest.read_text())['files'] if p.name==v['file']),None)
 if not entry or p.resolve().parent not in [(ROOT/'public/CCG Downloads/CCG_Scripts').resolve(),(FILES/'Scripts').resolve()]:return False
 if expected!=entry['before_sha256']:return False
 backup=OUT/'glitchling-before-public-reveal-repair';old=(backup/p.name).read_bytes();assert sha(backup/p.name)==entry['before_sha256'] and old==(backup/('installed-'+p.name)).read_bytes()
 text=old.decode('utf-8');code=entry['passcode']
 if code in [259678739,259072906]:
  before='return c:IsRace(RACE_CYBERSE) and (c:IsType(TYPE_RITUAL) or c:IsType(TYPE_NORMAL))'
  assert text.count(before)==1;changed=text.replace(before,'return not c:IsPublic() and c:IsRace(RACE_CYBERSE) and (c:IsType(TYPE_RITUAL) or c:IsType(TYPE_NORMAL))')
 elif code==259844716:
  before='if chk==0 then return Duel.IsExistingMatchingCard(s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,e:GetHandler()) end'
  assert text.count(before)==1;changed=text.replace(before,'if chk==0 then return not e:GetHandler():IsPublic() and Duel.IsExistingMatchingCard(s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,e:GetHandler()) end')
 else:
  cost,filter={238274859:('spcost','handfilter'),230998543:('xyzcost','handfilter'),259454809:('hcost','aero'),246524183:('revcost','filter')}[code]
  start=text.index('function s.'+cost+'(');end=text.find('\nfunction ',start+1);end=len(text) if end<0 else end;body=text[start:end];assert 's.'+filter in body and 'function s.revealfilter(' not in text
  nl='\r\n' if '\r\n' in text else '\n';guard='(not c:IsLocation(LOCATION_HAND) or not c:IsPublic())' if code==246524183 else 'not c:IsPublic()'
  helper=nl.join(['function s.revealfilter(c,e,tp)',' return '+guard+' and s.'+filter+'(c,e,tp)','end',''])
  changed=text[:start]+helper+body.replace('s.'+filter,'s.revealfilter')+text[end:]
 assert changed.encode('utf-8')==view and hashlib.sha256(view).hexdigest()==entry['after_sha256'],'Public-reveal reconciliation differs from exact bounded patch'
 return True

def verify_dependency(relative,expected):
 p=ROOT/relative
 if source_hash_matches(p,expected):return
 assert relative=='output/fresh-ccg-september/current-spec-CCG_v1.db','Unreconciled dependency: '+relative
 reconciliation=json.loads((OUT/'current-spec-name-only-reconciliation.json').read_text())
 assert sha(p)==reconciliation['current_sha256']
 archived=ROOT/reconciliation['archived_path']
 assert sha(archived)==expected==reconciliation['archived_sha256']
 import sqlite3
 with sqlite3.connect(archived.resolve().as_uri()+'?mode=ro',uri=True) as a,sqlite3.connect(p.resolve().as_uri()+'?mode=ro',uri=True) as b:
  assert a.execute('select name,sql from sqlite_master order by name').fetchall()==b.execute('select name,sql from sqlite_master order by name').fetchall()
  for table in ['datas','texts']:
   old={row[0]:row for row in a.execute('select * from '+table)};new={row[0]:row for row in b.execute('select * from '+table)};assert old.keys()==new.keys()
   for code in old:
    if old[code]!=new[code]:assert table=='texts' and code in [284636589,132636589] and old[code][2:]==new[code][2:] and old[code][1]=='"Terrarumian Growth' and new[code][1]=='Terrarumian Growth'

def main():
 plans=[(215034223,'talismandrake_united','old-cost','Talismandrake Arms United discard-cost source exclusion repair'),(214371067,'enra','old-timing','Enra successful-summon continuation repair and local installation'),(212684822,'ektelestis','old-limit','Ektelestis first-summon restriction repair'),(254065048,'polemistis','old-limit','Polemistis summon repair and reusable roster pattern triage'),(259937946,'grand_blue_prince','old-limit','Grand Blue Prince first-Fusion versus revival repair'),(213266433,'hanging_frute','no-tracking','The Hanging Frute surviving re-set defender once-each repair')]
 roster={c['passcode']:c for c in json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']};handoff=(ROOT/'docs/CCG-AUDIT-HANDOFF.md').read_text(encoding='utf-8');rows=[]
 database_hash=sha(OUT/'candidate-CCG_v1.db')
 for code,prefix,control,section in plans:
  # Resolve only this card's artifacts; hash matches remain mandatory.
  artifacts={sha(p):p for p in OUT.glob(prefix.replace('_','-')+'*.json')}
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';batch=OUT/(prefix.replace('_','-')+'-batch.json') if prefix=='talismandrake_united' else OUT/(prefix+'-batch.json');data=json.loads(batch.read_text(encoding='utf-8'));assert source_hash_matches(source,data['script_sha256']);assert data['candidate_database_sha256']==database_hash;assert section in handoff
  assert sha(FILES/'Scripts'/source.name)==sha(source),'Installed script differs'
  assert any(r['control']==control and r['expected_failures'] and r['status']==1 for r in data['runs']);assert any(r['control'] is None and r['status']==0 for r in data['runs'])
  for run in data['runs']:
   artifact=artifacts[run['artifact_sha256']];result=json.loads(artifact.read_text(encoding='utf-8'));assert source_hash_matches(source,result['script_sha256']);assert [r['test'] for r in result['results'] if r['failure']]==run['expected_failures']
   harness=ROOT/'scripts'/('fresh_'+prefix+'_'+run['harness']+'.cjs');assert sha(harness)==run['harness_sha256']
  rows.append({'passcode':code,'name':roster[code]['name'],'documented_repair_section':section,'script_sha256':sha(source),'batch':batch.name,'batch_sha256':sha(batch),'regression_control':control,'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 assert sha(OUT/'candidate-CCG_v1.db')==database_hash,'Database changed during verification'
 review_path=OUT/'gemini-validation.json'
 if review_path.exists():
  review=json.loads(review_path.read_text(encoding='utf-8'));manifest=OUT/'gemini-supported-fixes.json'
  assert review['repair_manifest_sha256']==sha(manifest)
  assert review['callback_harness_sha256']==sha(ROOT/'scripts/fresh_gemini_callback_regression.lua')
  assert review['callback_assertions']==91 and review['native_omega_verified'] is False
  for repair in json.loads(manifest.read_text(encoding='utf-8'))['changes']:
   code=repair['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua'
   assert repair['after_sha256']==review['source_scripts'][str(code)]
   reconciliation=None
   if sha(source)!=repair['after_sha256']:
    if code==210628767:
     reconciliation=OUT/'morbydrip-source-reconciliation.json';reconciled=json.loads(reconciliation.read_text());assert reconciled['script_sha256']==sha(source);assert reconciled['historical_repair_sha256']==repair['after_sha256'];assert reconciled['current_batch_sha256']==sha(OUT/'current-morbydrip-placement-repaired-batch.json')
     before=(OUT/'morbydrip-before-occupied-column-repair/source-c210628767.lua').read_bytes();after=source.read_bytes();newline=b'\r\n' if b'\r\n' in before else b'\n';assert after.replace(newline+b'\tif Duel.GetFieldCard(p,LOCATION_SZONE,sq) then return false end',b'').replace(b' or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0',b'')==before
    elif code==216258796:
     reconciliation=OUT/'actinia-source-reconciliation.json';reconciled=json.loads(reconciliation.read_text());assert reconciled['script_sha256']==sha(source);assert reconciled['historical_repair_sha256']==repair['after_sha256']
     before=(OUT/'actinia-before-revival-qualification-repair/c216258796.lua').read_bytes();assert hashlib.sha256(before).hexdigest()==repair['after_sha256'];assert source.read_bytes().replace(b'\r\n',b'\n').replace(b'\n\tif not c:IsStatus(STATUS_PROC_COMPLETE) then return false end',b'')==before.replace(b'\r\n',b'\n')
    else:
     assert code==237684285,'Unreviewed historical source change'
     reconciliation=OUT/'janna-source-reconciliation.json'
     reconciled=json.loads(reconciliation.read_text(encoding='utf-8'))
     assert reconciled['script_sha256']==sha(source)
     assert reconciled['historical_repair_sha256']==repair['after_sha256']
     assert reconciled['historical_validation_sha256']==sha(review_path)
     assert reconciled['reconciliation_script_sha256']==sha(ROOT/'scripts/fresh_janna_source_reconcile.py')
     assert reconciled['callback_harness_sha256']==review['callback_harness_sha256']
     assert reconciled['callback_assertions']==99 and reconciled['native_omega_verified'] is False
   else:assert sha(source)==repair['after_sha256']
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'documented_repair_section':'Gemini claim review',
                'repair':repair['reason'],'script_sha256':sha(source),'validation':'gemini-validation.json',
                'validation_sha256':sha(review_path),'evidence_type':'Source-reviewed repair; callback regression plus existing focused public-engine tests where available',
                'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
   if reconciliation:
    rows[-1]['source_reconciliation']={'artifact':reconciliation.name,'sha256':sha(reconciliation),'scope':reconciled['scope']}
 field_path=OUT/'field-search-family-batch.json'
 if field_path.exists():
  field=json.loads(field_path.read_text(encoding='utf-8'));source=ROOT/'public/CCG Downloads/CCG_Scripts/c259883230.lua'
  assert field['harness_sha256']==sha(ROOT/'scripts/fresh_field_search_family.cjs')
  assert field['batch_script_sha256']==sha(ROOT/'scripts/fresh_field_search_family_batch.py')
  assert field['candidate_database_sha256']==database_hash
  for dependency,h in field['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  relevant=[r for r in field['runs'] if r['source']==259883230]
  assert any(r['control']=='old-field-condition' and r['expected_failures']==[{'facedownField':True}] for r in relevant)
  for run in relevant:
   assert run['source_sha256']==sha(source)
   assert run['target_sha256']==sha(ROOT/'public/CCG Downloads/CCG_Scripts'/f"c{run['target']}.lua")
   assert run['artifact_sha256']==sha(OUT/run['artifact'])
   data=json.loads((OUT/run['artifact']).read_text(encoding='utf-8'))
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  rows.append({'passcode':259883230,'name':roster[259883230]['name'],'documented_repair_section':'Release of the Pyre face-down condition repair',
               'repair':'Pyro monster search condition requires face-up monster.', 'script_sha256':sha(source),
               'batch':field_path.name,'batch_sha256':sha(field_path),'regression_control':'old-field-condition',
               'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 zone_path=OUT/'pyre-zone-lock-batch.json'
 if zone_path.exists():
  zone=json.loads(zone_path.read_text(encoding='utf-8'))
  row=next(r for r in rows if r['passcode']==259883230)
  assert zone['script_sha256']==row['script_sha256']
  assert zone['harness_sha256']==sha(ROOT/'scripts/fresh_pyre_zone_lock_count.cjs')
  assert zone['batch_script_sha256']==sha(ROOT/'scripts/fresh_pyre_zone_lock_batch.py')
  for dependency,h in zone['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  assert any(r['control']=='old-lock-limit' and r['status']==1 for r in zone['runs'])
  assert any(r['card_data_adapter'] and r['control'] is None and r['status']==0 for r in zone['runs'])
  for run in zone['runs']:assert run['artifact_sha256']==sha(OUT/run['artifact'])
  row['additional_regression']={'batch':zone_path.name,'batch_sha256':sha(zone_path),'scope':zone['scope']}
  row['repair']+=' Zone-lock use also remains consumed while the same card stays face-up.'
 focused_path=OUT/'current-reconciled-surge-spherix-batch.json'
 if focused_path.exists():
  focused=json.loads(focused_path.read_text(encoding='utf-8'))
  assert focused['baseline_cases']==41
  assert focused['batch_script_sha256']==sha(ROOT/'scripts/fresh_reconciled_surge_spherix_batch.py')
  for dependency,h in focused['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for code in [259869259,231088629]:
   source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua'
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   relevant=[r for r in focused['runs'] if r['passcode']==code]
   assert any(r['control'] is None and r['status']==0 for r in relevant)
   assert any(r['control'] and r['status']==1 and r['expected_failures'] for r in relevant)
   for run in relevant:
    assert run['script_sha256']==sha(source)
    assert run['harness_sha256']==sha(ROOT/'scripts'/run['harness'])
    artifact=OUT/run['artifact'];assert run['artifact_sha256']==sha(artifact)
    data=json.loads(artifact.read_text(encoding='utf-8'))
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'documented_repair_section':'Surge per-copy tracking and Spherix interception repairs',
                'script_sha256':sha(source),'batch':focused_path.name,'batch_sha256':sha(focused_path),
                'repair':'Independent co-link transition tracking and activation baseline' if code==259869259 else 'Remove invalid relation guard from continuous summon interception; preserve optional XYZ attachment choice; allow face-down opponent monsters for column shuffle. General material count/eligibility remains open.',
                'evidence_type':focused['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 onibi_path=OUT/'current-onibi-batch.json'
 if onibi_path.exists():
  batch=json.loads(onibi_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c217713649.lua'
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  assert batch['baseline_cases']==4 and len(batch['runs'])==4
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   result=json.loads(artifact.read_text());assert result['script_sha256']==sha(source)
   assert [r['test'] for r in result['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==217713649 for r in rows)
  rows.append({'passcode':217713649,'name':roster[217713649]['name'],'repair':'Continue optional Spirit search after the actual successful Normal Summon; clear the selected-card continuation on success or negation.', 'script_sha256':sha(source),'batch':onibi_path.name,'batch_sha256':sha(onibi_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 aqua_path=OUT/'current-aqua-repair-batch.json'
 if aqua_path.exists():
  batch=json.loads(aqua_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c227035644.lua'
  assert batch['script_sha256']==sha(source) and batch['baseline_cases']==5
  additional=batch['additional_regression'];assert sha(OUT/additional['batch'])==additional['sha256']
  current=json.loads((OUT/additional['batch']).read_text())
  for dependency,h in current['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in current['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==227035644 for r in rows)
  rows.append({'passcode':227035644,'name':roster[227035644]['name'],'repair':'Permit own face-down field Fusion Materials while retaining face-up banished restriction; exclude non-monster, Fusion-ineligible and effect-immune first-effect materials.', 'script_sha256':sha(source),'batch':aqua_path.name,'batch_sha256':sha(aqua_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 plank_path=OUT/'current-planktonites-fusion-batch.json'
 if plank_path.exists():
  batch=json.loads(plank_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c250339529.lua'
  assert batch['baseline_cases']==2
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==250339529 for r in rows)
  rows.append({'passcode':250339529,'name':roster[250339529]['name'],'repair':'Apply existing immunity filter to normal Fusion material pools at targeting and resolution.', 'script_sha256':sha(source),'batch':plank_path.name,'batch_sha256':sha(plank_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 provocation_path=OUT/'current-dinomorphia-provocation-fusion-batch.json'
 if provocation_path.exists():
  batch=json.loads(provocation_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259826112.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259826112 for r in rows)
  rows.append({'passcode':259826112,'name':roster[259826112]['name'],'repair':'Exclude source-immune monsters from optional Fusion material pool after successful Trap Set.', 'script_sha256':sha(source),'batch':provocation_path.name,'batch_sha256':sha(provocation_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 grimoire_path=OUT/'current-grimoire-fusion-batch.json'
 if grimoire_path.exists():
  batch=json.loads(grimoire_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259680842.lua'
  assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259680842 for r in rows)
  rows.append({'passcode':259680842,'name':roster[259680842]['name'],'repair':'Apply source immunity filtering to optional Deck Fusion material pool.', 'script_sha256':sha(source),'batch':grimoire_path.name,'batch_sha256':sha(grimoire_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 crawler_path=OUT/'current-crawler-hand-summon-batch.json'
 if crawler_path.exists():
  batch=json.loads(crawler_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c213611313.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==213611313 for r in rows)
  rows.append({'passcode':213611313,'name':roster[213611313]['name'],'repair':'Discard cost must leave a distinct eligible Galaxy monster in Hand.', 'script_sha256':sha(source),'batch':crawler_path.name,'batch_sha256':sha(crawler_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 hanabi_path=OUT/'current-hanabi-spirit-limit-batch.json'
 if hanabi_path.exists():
  batch=json.loads(hanabi_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259790247.lua'
  assert batch['baseline_cases']==2
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259790247 for r in rows)
  rows.append({'passcode':259790247,'name':roster[259790247]['name'],'repair':'Block simultaneous double summon under Blue-Eyes Spirit Dragon at targeting and resolution.', 'script_sha256':sha(source),'batch':hanabi_path.name,'batch_sha256':sha(hanabi_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 astrocyte_path=OUT/'current-astrocyte-leave-field-batch.json'
 if astrocyte_path.exists():
  batch=json.loads(astrocyte_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259481543.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259481543 for r in rows)
  rows.append({'passcode':259481543,'name':roster[259481543]['name'],'repair':'Block leave-field simultaneous double summon under Blue-Eyes Spirit Dragon at targeting and resolution.', 'script_sha256':sha(source),'batch':astrocyte_path.name,'batch_sha256':sha(astrocyte_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 murugan_path=OUT/'current-murugan-spirit-limit-batch.json'
 if murugan_path.exists():
  batch=json.loads(murugan_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c247755869.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==247755869 for r in rows)
  rows.append({'passcode':247755869,'name':roster[247755869]['name'],'repair':'Block Hand double summon under Spirit Dragon at targeting/resolution while preserving field single revival.', 'script_sha256':sha(source),'batch':murugan_path.name,'batch_sha256':sha(murugan_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 carcel_path=OUT/'current-reconciled-carcel-spirit-limit-batch.json'
 if carcel_path.exists():
  batch=json.loads(carcel_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259780273.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259780273 for r in rows)
  rows.append({'passcode':259780273,'name':roster[259780273]['name'],'repair':'Block mandatory Hand/Deck simultaneous summon under Spirit Dragon at targeting and resolution.', 'script_sha256':sha(source),'batch':carcel_path.name,'batch_sha256':sha(carcel_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 devotee_path=OUT/'current-devotee-spirit-limit-batch.json'
 if devotee_path.exists():
  batch=json.loads(devotee_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259024242.lua'
  assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259024242 for r in rows)
  rows.append({'passcode':259024242,'name':roster[259024242]['name'],'repair':'Block mandatory two-token summon under Spirit Dragon at targeting and resolution.', 'script_sha256':sha(source),'batch':devotee_path.name,'batch_sha256':sha(devotee_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 bedroom_path=OUT/'current-bedroom-spirit-limit-batch.json'
 if bedroom_path.exists():
  batch=json.loads(bedroom_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259090287.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259090287 for r in rows)
  rows.append({'passcode':259090287,'name':roster[259090287]['name'],'repair':'Use controller from handler in protection condition; cap optional excavation summons to one under Spirit Dragon.', 'script_sha256':sha(source),'batch':bedroom_path.name,'batch_sha256':sha(bedroom_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 bhodi_path=OUT/'current-bhodi-spirit-limit-batch.json'
 if bhodi_path.exists():
  batch=json.loads(bhodi_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259072745.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert 'additional_regression' in batch,'Bhodi material Fusion certificate required'
  if 'additional_regression' in batch:
   additional=batch['additional_regression'];assert sha(OUT/additional['batch'])==additional['sha256']
   stronger=json.loads((OUT/additional['batch']).read_text());assert stronger['baseline_cases']==4
   for dependency,h in stronger['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in stronger['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259072745 for r in rows)
  rows.append({'passcode':259072745,'name':roster[259072745]['name'],'repair':'Cap optional revival group at one under Spirit Dragon. Additional actual canonical material Fusion recipe/regression verified; explicit legacy FaceupEx/sterile mandatory-material adapters; native Omega/general mandatory effects open.', 'script_sha256':sha(source),'batch':bhodi_path.name,'batch_sha256':sha(bhodi_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 abe_path=OUT/'current-abe-spirit-limit-batch.json'
 if abe_path.exists():
  batch=json.loads(abe_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259635008.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259635008 for r in rows)
  rows.append({'passcode':259635008,'name':roster[259635008]['name'],'repair':'Preserve mandatory Extra Deck return; block subsequent simultaneous Spirit pair under Spirit Dragon. Explicit unavailable Synchro procedure disabled for initial Special Summon fixture; native Omega open.', 'script_sha256':sha(source),'batch':abe_path.name,'batch_sha256':sha(abe_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 machina_path=OUT/'current-machina-spirit-limit-batch.json'
 if machina_path.exists():
  batch=json.loads(machina_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259247853.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259247853 for r in rows)
  rows.append({'passcode':259247853,'name':roster[259247853]['name'],'repair':'Block simultaneous Extra Link pair under Spirit at targeting/resolution; isolated public card-data and bounded group-selection adapters. Initial source/anchor procedures, general selection and native Omega open.', 'script_sha256':sha(source),'batch':machina_path.name,'batch_sha256':sha(machina_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 eisodos_path=OUT/'current-eisodos-leave-field-batch.json'
 if eisodos_path.exists():
  batch=json.loads(eisodos_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c241543138.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==241543138 for r in rows)
  rows.append({'passcode':241543138,'name':roster[241543138]['name'],'repair':'Add Spirit restriction at token targeting/resolution; retain separate IsPlayerCanSpecialSummonCount guard.', 'script_sha256':sha(source),'batch':eisodos_path.name,'batch_sha256':sha(eisodos_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 breeze_path=OUT/'current-breeze-spirit-limit-batch.json'
 if breeze_path.exists():
  batch=json.loads(breeze_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c230998543.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==230998543 for r in rows)
  rows.append({'passcode':230998543,'name':roster[230998543]['name'],'repair':'Add Spirit guard to detached source/Hand pair targeting and resolution; retain count API. Explicit legacy detach-event adapter; original event and native Omega unverified.', 'script_sha256':sha(source),'batch':breeze_path.name,'batch_sha256':sha(breeze_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 otakemaru_path=OUT/'current-otakemaru-spirit-limit-batch.json'
 if otakemaru_path.exists():
  batch=json.loads(otakemaru_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c221855414.lua'
  assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==221855414 for r in rows)
  rows.append({'passcode':221855414,'name':roster[221855414]['name'],'repair':'Limit mandatory End Phase return effect to once per turn; prevents repeated forced activation when return is blocked. Canonical actual return/pair, Spirit, wrong total/roles and blocked return tested. Proper Synchro and native Omega open.', 'script_sha256':sha(source),'batch':otakemaru_path.name,'batch_sha256':sha(otakemaru_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 volt_path=OUT/'current-volt-union-equip-batch.json'
 if volt_path.exists():
  batch=json.loads(volt_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c238274859.lua'
  assert batch['baseline_cases']==7
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  summon_path=OUT/'current-volt-spirit-limit-batch.json'
  summon=json.loads(summon_path.read_text());assert summon['baseline_cases']==7
  for dependency,h in summon['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in summon['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==238274859 for r in rows)
  rows.append({'passcode':238274859,'name':roster[238274859]['name'],'repair':'Apply Necrovalley Union filter at equip targeting, matching resolution. Seven equip cases and removed-filter control; seven Hand pair/LIGHT lock cases with two controls. Proper Union protections, limits/renewal, interruptions and native Omega open.', 'script_sha256':sha(source),'batch':volt_path.name,'batch_sha256':sha(volt_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 lightning_path=OUT/'current-lightning-shot-followup-batch.json'
 if lightning_path.exists():
  batch=json.loads(lightning_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259446105.lua'
  assert batch['baseline_cases']==3
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  main_batch=json.loads((OUT/'current-lightning-shot-batch.json').read_text());assert main_batch['baseline_cases']==7
  for dependency,h in main_batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in main_batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259446105 for r in rows)
  rows.append({'passcode':259446105,'name':roster[259446105]['name'],'repair':'Cancel pending GY movement before shuffling negated activation handler. Actual opposing Spell/Trap activations now reach Deck after effect detach; monster/alternate host regressions retained. Proper Xyz and native Omega open.', 'script_sha256':sha(source),'batch':lightning_path.name,'batch_sha256':sha(lightning_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 navi_path=OUT/'current-navi-necrovalley-batch.json'
 if navi_path.exists():
  batch=json.loads(navi_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259548744.lua'
  assert batch['baseline_cases']==2
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  for regression_name,cases in [('current-navi-recycle-attach-batch.json',3),('current-navi-negation-batch.json',6)]:
   regression=json.loads((OUT/regression_name).read_text());assert regression['baseline_cases']==cases
   for dependency,h in regression['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in regression['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259548744 for r in rows)
  rows.append({'passcode':259548744,'name':roster[259548744]['name'],'repair':'Apply Necrovalley filter when counting/selecting GY recycle candidates. Protected cards excluded and no detach if no legal recycle pool. Overlay branch bounded by explicit neutral adapter; proper Xyz/native Omega open.', 'script_sha256':sha(source),'batch':navi_path.name,'batch_sha256':sha(navi_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 egg_path=OUT/'current-egg-hand-search-batch.json'
 if egg_path.exists():
  batch=json.loads(egg_path.read_text());source=ROOT/'public/CCG Downloads/CCG_Scripts/c259464064.lua'
  assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  revival=json.loads((OUT/'current-egg-revival-batch.json').read_text());assert revival['baseline_cases']==4
  for dependency,h in revival['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in revival['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  for prefix,cases in [('battle',3),('extra-lock',2),('normal-search',3)]:
   regression=json.loads((OUT/f'current-egg-{prefix}-batch.json').read_text());assert regression['baseline_cases']==cases
   for dependency,h in regression['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in regression['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert any(r['control'] and r['expected_failures'] for r in regression['runs'])
  assert not any(r['passcode']==259464064 for r in rows)
  rows.append({'passcode':259464064,'name':roster[259464064]['name'],'repair':'Require faceup Obsidim in either Field Zone for native Hand summon procedure. Allow GY revival trigger during Damage Step after battle destruction. Listed-card search, shared limit, Extra Deck lock/reset and prior GY revival regressions preserved; official field effects/full card/native Omega open.', 'script_sha256':sha(source),'batch':egg_path.name,'batch_sha256':sha(egg_path),'evidence_type':batch['scope'],'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 shade_path=OUT/'current-shade-attach-batch.json'
 if shade_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259615843.lua'
  for prefix,cases in [('attach',3),('attach-safety',2),('aura',6),('summon',5)]:
   batch=json.loads((OUT/f'current-shade-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  rows.append({'passcode':259615843,'name':roster[259615843]['name'],'repair':'Use legacy IsCanOverlay attachment eligibility so Spell targets permitted. Bounded neutral compatibility adapter in public runtime; Require distinct Xyz recipient and recheck immunity/overlay eligibility at resolution. General eligibility, multiple-host cases and native Omega remain open.','script_sha256':sha(source),'batch':shade_path.name,'batch_sha256':sha(shade_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 plexus_path=OUT/'current-plexus-boost-scope-batch.json'
 if plexus_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259669838.lua'
  for prefix,cases in [('boost-scope',1),('shuffle',2),('necrovalley',1),('revival',4)]:
   batch=json.loads((OUT/f'current-plexus-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259669838 for r in rows)
  rows.append({'passcode':259669838,'name':roster[259669838]['name'],'repair':'Apply printed all-Krawler300 ATK/DEF boost to both fields. Actual shuffle and on-summon regressions preserved; original Link disabled in public tests, proper Link/native Omega open.','script_sha256':sha(source),'batch':plexus_path.name,'batch_sha256':sha(plexus_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 vik_path=OUT/'current-vik-immunity-batch.json'
 if vik_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259113182.lua'
  for prefix,cases in [('immunity',2),('attach',6),('normal-search',4)]:
   batch=json.loads((OUT/f'current-vik-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259113182 for r in rows)
  rows.append({'passcode':259113182,'name':roster[259113182]['name'],'repair':'Recheck targeted recipient immunity at attachment resolution, matching pinned Overlay Regen reference. Native Hand/GY attachment and Normal Summon search regressions pass; native Omega open.','script_sha256':sha(source),'batch':vik_path.name,'batch_sha256':sha(vik_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 calamities_path=OUT/'current-calamities-activation-batch.json'
 if calamities_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259187643.lua'
  for prefix,cases in [('activation',4),('lock',5),('flip',4),('flip-copies',1),('flip-shared',1)]:
   batch=json.loads((OUT/f'current-calamities-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259187643 for r in rows)
  rows.append({'passcode':259187643,'name':roster[259187643]['name'],'repair':'Separate optional activation take from card activation. Allow decline/empty pool/prior restricted activity without take or lock; accepted take retains history/future restriction with End Phase reset. Use native legacy single-card shared flip limit for independent copies and shared SpecialSummon/Set events. Public tests use explicit modern SINGLE flag mapping. Native Omega open.','script_sha256':sha(source),'batch':calamities_path.name,'batch_sha256':sha(calamities_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 melantha_path=OUT/'current-melantha-summon-batch.json'
 if melantha_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259221974.lua'
  for prefix,cases in [('summon',3),('external',2)]:
   batch=json.loads((OUT/f'current-melantha-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259221974 for r in rows)
  rows.append({'passcode':259221974,'name':roster[259221974]['name'],'repair':'Own effect target/operation explicitly bypass initial procedure restriction; normal/set and external effect Hand/GY prohibitions retained. Taxation/battle/native Omega open.','script_sha256':sha(source),'batch':melantha_path.name,'batch_sha256':sha(melantha_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 argalia_path=OUT/'current-argalia-immunity-batch.json'
 if argalia_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259748623.lua'
  for prefix,cases in [('immunity',2),('attach',6),('destroy',4),('procedure',6),('destroy-immunity',2),('necrovalley',2)]:
   batch=json.loads((OUT/f'current-argalia-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259748623 for r in rows)
  rows.append({'passcode':259748623,'name':roster[259748623]['name'],'repair':'Recheck targeted recipient immunity at Quick attachment resolution. Use IsCanOverlay for optional opponent-GY attachment including Spells; explicit bounded public adapter. Optional attachment rechecks recipient immunity. Apply Necrovalley filter to optional opponent-GY eligibility; protected cards retained and destruction preserved. Native Hand/GY attachment regressions pass; native Omega open.','script_sha256':sha(source),'batch':argalia_path.name,'batch_sha256':sha(argalia_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 arktos_path=OUT/'current-arktos-pendulum-batch.json'
 if arktos_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259537607.lua'
  for prefix,cases in [('pendulum',6),('movement',6),('normal-movement',5),('pendulum-late',2)]:
   batch=json.loads((OUT/f'current-arktos-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259537607 for r in rows)
  rows.append({'passcode':259537607,'name':roster[259537607]['name'],'repair':'Remove extra controller argument from Duel.SpecialSummon so Pendulum same-column zone mask is used, matching pinned Vaylantz reference. Recheck same-column summon eligibility at resolution to preserve Pendulum source when destination becomes blocked. No adapters; proper Fusion support, Quick/limits/native Omega remain open.','script_sha256':sha(source),'batch':arktos_path.name,'batch_sha256':sha(arktos_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 gambling_path=OUT/'current-gambling-interruption-batch.json'
 if gambling_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c224774049.lua'
  for prefix,cases in [('outcomes',5),('interruption',2)]:
   batch=json.loads((OUT/f'current-gambling-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==224774049 for r in rows)
  rows.append({'passcode':224774049,'name':roster[224774049]['name'],'repair':'Apply printed2000LP loss before empty-at-resolution Deck early return, since no card added. Actual native CL2 empties Deck regression/control; blocked-add and ordinary hit/miss/short/empty-activation preserved. Explicit legacy TARGET_PARAM adapter, native Omega/all die outcomes remain open','script_sha256':sha(source),'batch':gambling_path.name,'batch_sha256':sha(gambling_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 nemleria_path=OUT/'current-nemleria-eligibility-batch.json'
 if nemleria_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259766646.lua'
  batch=json.loads(nemleria_path.read_text());assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259766646 for r in rows)
  rows.append({'passcode':259766646,'name':roster[259766646]['name'],'repair':'Require Dreaming Nemleria IsAbleToExtra for initial eligibility and resolution selection. Prevent activation when native Deck/Extra prohibition makes first step impossible; preserve Hand/Deck faceup Extra placement and subsequent Nemleria Spell Set. Four native scenarios/two controls; no adapters. Native Omega/full card open.','script_sha256':sha(source),'batch':nemleria_path.name,'batch_sha256':sha(nemleria_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 phlogistic_path=OUT/'current-phlogistic-damage-batch.json'
 if phlogistic_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c219714894.lua'
  batch=json.loads(phlogistic_path.read_text());assert batch['baseline_cases']==2
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==219714894 for r in rows)
  rows.append({'passcode':219714894,'name':roster[219714894]['name'],'repair':'Use actual Duel.Damage return for half-inflicted-damage ATK gain; native2000LPpayment/full1000damage/reduced500damage cases and oldformula/noBoost controls. No adapters; GY setting/countlimits/native Omega/full card open.','script_sha256':sha(source),'batch':phlogistic_path.name,'batch_sha256':sha(phlogistic_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 nautica_path=OUT/'current-nautica-optional-search-batch.json'
 if nautica_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259797813.lua'
  batch=json.loads(nautica_path.read_text());assert batch['baseline_cases']==4
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259797813 for r in rows)
  rows.append({'passcode':259797813,'name':roster[259797813]['name'],'repair':'Honor optional activation search with eligibility check and SelectYesNo before Deck/GY monster selection. Four actual accept/decline cases and mandatory/no-add controls. No adapters; chain followup, uniqueness, native Omega and full card remain open.','script_sha256':sha(source),'batch':nautica_path.name,'batch_sha256':sha(nautica_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 haunt_path=OUT/'current-ghostrick-haunt-self-set-batch.json'
 if haunt_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c241540236.lua'
  batch=json.loads(haunt_path.read_text());assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert source_hash_matches(source,data['script_sha256'])
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==241540236 for r in rows)
  rows.append({'passcode':241540236,'name':roster[241540236]['name'],'repair':'Add EFFECT_FLAG_DELAY to optional Graveyard EVENT_CHAINING trigger so Level1 Ghostrick Hand activation offers selfSet after chain resolution. Five native scenarios and noSet/noRedirect/noDelay/ignoreLevel controls verify actual selfSet and subsequent destruction banishredirect. Position/return five-case regression preserved. No adapters; interruption/other leavefield routes/native Omega/full card remain open','script_sha256':sha(source),'batch':haunt_path.name,'batch_sha256':sha(haunt_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 gravinity_path=OUT/'current-gravinity-transfer-recipient-choice-batch.json'
 if gravinity_path.exists():
  batch=json.loads(gravinity_path.read_text());assert batch['baseline_cases']==16 and not batch.get('diagnostic_only')
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for code in [215768254,235538173,249680945,256172827]:
   source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua'
   runs=[r for r in batch['runs'] if r['recipient']==code];assert len(runs)==4
   for run in runs:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['recipient_script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'repair':'Honor optional TransferCall all-effects permission on primary/movement selected routes. Consume flag once, prompt with additional effect description, preserve primary-before-movement sequence. Four real-recipient accept/decline scenarios and mandatory/no-extra/no-consume controls; native flag/type/destruction assertions. No adapters; permission on negated activation/other recipient effects/native Omega/full card open.','script_sha256':sha(source),'batch':gravinity_path.name,'batch_sha256':sha(gravinity_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 melody_path=OUT/'current-melody-division-extra-normal-batch.json'
 if melody_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c243420199.lua'
  for prefix,cases in [('extra-normal',4),('attach',7)]:
   batch=json.loads((OUT/f'current-melody-division-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases and not batch.get('diagnostic_only')
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==243420199 for r in rows)
  rows.append({'passcode':243420199,'name':roster[243420199]['name'],'repair':'Use value0 for unrestricted Level2 extra NormalSummon and clone EFFECT_EXTRA_SET_COUNT for printed extra Set. Native four-case summon/set/two-copy shared extra use/wrongset tests and noExtra/oldValue/noSet/ignoreSet controls; seven-case banish-cost attachment regression preserved. No adapters; turn reset/other levels/materialeligibility/nativeOmega/full card open.','script_sha256':sha(source),'batch':melody_path.name,'batch_sha256':sha(melody_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 ganan_path=OUT/'current-ganan-direct-battle-batch.json'
 if ganan_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c259459462.lua'
  for prefix,cases in [('direct-battle',3),('chain-damage',2),('unique',3)]:
   batch=json.loads((OUT/f'current-ganan-{prefix}-batch.json').read_text());assert batch['baseline_cases']==cases and not batch.get('diagnostic_only')
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==259459462 for r in rows)
  rows.append({'passcode':259459462,'name':roster[259459462]['name'],'repair':'Use EFFECT_IGNORE_BATTLE_TARGET so Ganan remains untargetable while lone Ganan permits printed direct attacks. Three actual native battle cases verify1000directdamage below3000ATK/zero at3000 and other defender targeted without Ganan. OldCode/noProtection/noIgnore controls; chainATK/damage2case and uniqueness3case regressions pass. No adapters; proper Link/negatedchains/nativeOmega/full card open','script_sha256':sha(source),'batch':ganan_path.name,'batch_sha256':sha(ganan_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 frozen_path=OUT/'current-frozen-girl-transfer-batch.json'
 if frozen_path.exists():
  batch=json.loads(frozen_path.read_text());assert batch['baseline_cases']==3 and not batch.get('diagnostic_only')
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for code in [222676270,223505382]:
   source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua'
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['script_sha256' if code==222676270 else 'secondary_script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert sha(FILES/'Scripts'/source.name)==sha(source)
   assert not any(r['passcode']==code for r in rows)
   rows.append({'passcode':code,'name':roster[code]['name'],'repair':'Register effect-specific faceup placement marker on TransferCall Deckmonster SZONE placement and check it in FrozenGirl response condition. Three native cases: discard/effectnegation, decline allowing actual placement, unrelated damage excluded. Four controls detect missing marker/negation/discard and overly broad registration. Transfer placement4/expiry2/interruption2 and recipient-choice16 regressions refreshed. Other qualifying placements/cost and continuous replacement exclusions/limits/nativeOmega/full card remain OPEN.','script_sha256':sha(source),'batch':frozen_path.name,'batch_sha256':sha(frozen_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 swamp_path=OUT/'current-frozen-girl-swamp-batch.json'
 if swamp_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c239935101.lua'
  batch=json.loads(swamp_path.read_text());assert batch['baseline_cases']==3 and not batch.get('diagnostic_only')
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
   data=json.loads(artifact.read_text());assert data['secondary_script_sha256']==sha(source)
   assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==239935101 for r in rows)
  rows.append({'passcode':239935101,'name':roster[239935101]['name'],'repair':'Mark only initial activation WATER Reptile Deckmonster faceup SZONE placement for FrozenGirl response. Native three-case discard/effectnegation, decline with actual placement and unrelated damage exclusion; missing marker/negation/discard and broad marker controls. No adapters; battle/endphase effects, placement eligibility/interruption, nativeOmega/full card OPEN.','script_sha256':sha(source),'batch':swamp_path.name,'batch_sha256':sha(swamp_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 meeting_marker_path=OUT/'current-frozen-girl-crewal-210366076-batch.json'
 if meeting_marker_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c210366076.lua'
  for name,cases,secondary in [('current-frozen-girl-crewal-210366076-batch.json',3,True),('current-crewal-meeting-placement-batch.json',12,False),('current-crewal-meeting-recover-batch.json',5,False)]:
   batch=json.loads((OUT/name).read_text());assert batch['baseline_cases']==cases and not batch.get('diagnostic_only')
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert data['secondary_script_sha256' if secondary else 'script_sha256']==sha(source)
    assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==210366076 for r in rows)
  rows.append({'passcode':210366076,'name':roster[210366076]['name'],'repair':'Mark initial activation Zombie Deck/GY/banished placement as faceup ContinuousTrap for FrozenGirl response; recovery ignition unmarked. Native real GYZombie interaction3cases4controls confirms paid ContinuousTrap cost persists after effectnegation. Current placement12cases4controls and recovery5cases2controls preserved. No adapters; other interactions/interruption/nativeOmega/full card OPEN.','script_sha256':sha(source),'batch':meeting_marker_path.name,'batch_sha256':sha(meeting_marker_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 bear_path=OUT/'current-teleum-bear-negation-repaired-batch.json'
 if bear_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c251699681.lua'
  for name,cases,key in [('current-teleum-bear-negation-repaired-batch.json',2,'diagnostic_cases'),('current-teleum-bear-attack-repaired-batch.json',2,'baseline_cases'),('current-teleum-bear-history-preservation-repaired-batch.json',4,'baseline_cases')]:
   batch=json.loads((OUT/name).read_text());assert batch[key]==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   assert source.relative_to(ROOT).as_posix() in batch['runtime_dependencies_sha256']
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256']
    data=json.loads(artifact.read_text());assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures']
   assert any(r['control'] is None and not r['expected_failures'] for r in batch['runs'])
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  assert not any(r['passcode']==251699681 for r in rows)
  rows.append({'passcode':251699681,'name':roster[251699681]['name'],'repair':'Rollback exactly one permanent and turn activation-history flag for relevant player on EVENT_CHAIN_NEGATED. Actual attack-response activation/effect-negation2cases, attack/persistence2cases and seeded prior/bothplayer history preservation4cases, each with2controls. Official FAQ12712 activation-count distinction applied by inference to custom Trap. Prior counts are seeded, not actual prior activations. No adapters; summon-response legacy GetReadyChain, actual multiple/bothplayer activations, nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':bear_path.name,'batch_sha256':sha(bear_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 hallo_path=OUT/'current-happy-halloween-counter-repaired-batch.json'
 if hallo_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c255977900.lua';batch=json.loads(hallo_path.read_text());assert batch['baseline_cases']==9
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures'];assert not data['relation_guard_comparison']
  assert sum(r['control'] is None and not r['expected_failures'] for r in batch['runs'])==2
  assert any(r['control']=='original-guard' and r['expected_failures']==[{}] for r in batch['runs'])
  assert not any(r['passcode']==255977900 for r in rows)
  rows.append({'passcode':255977900,'name':roster[255977900]['name'],'repair':'Remove IsRelateToEffect guard from continuous SpecialSummon counter operation; retain faceup guard. Full Ween actual summon/group event one-counter accrual; wrongmonster/Normal/opponent excluded. Native disabled/facedown/sourceGY boundaries, nine cases/five control runs including original guard. No seeded counters/adapters. Activation/cost/revival/limits/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':hallo_path.name,'batch_sha256':sha(hallo_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 faceup_path=OUT/'current-happy-halloween-faceup-repaired-batch.json'
 if faceup_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c255977900.lua';batch=json.loads(faceup_path.read_text());assert batch['baseline_cases']==6
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  assert any(r['control']=='original-faceup' and len(r['expected_failures'])==2 for r in batch['runs'])
  row=next(r for r in rows if r['passcode']==255977900);row['repair']+=' Additional repair: require source faceup in ignition spop. Six native reference/facedown/disabled Hand/GY cases and four controls, including original-faceup reproducing both facedown failures; exact-byte backups happy-halloween-before-faceup-repair. Cost preserved. Native engine handles same-chain source departure/re-entry; faceup guard adds missing facedown exclusion.';row['additional_batch']=faceup_path.name;row['additional_batch_sha256']=sha(faceup_path)
 helmsman_path=OUT/'current-helmsman-hand-capacity-repaired-batch.json'
 if helmsman_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c215730767.lua'
  for name,cases in [('current-helmsman-hand-capacity-repaired-batch.json',5),('current-helmsman-hand-summon-batch.json',6),('current-helmsman-hand-locks-batch.json',6),('current-helmsman-hand-negation-batch.json',4)]:
   batch=json.loads((OUT/name).read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [r['test'] for r in data['results'] if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  batch=json.loads(helmsman_path.read_text());assert any(r['control']=='original-capacity' and r['expected_failures']==[{'full':True}] for r in batch['runs']);assert sha(FILES/'Scripts'/source.name)==sha(source);assert not any(r['passcode']==215730767 for r in rows)
  rows.append({'passcode':215730767,'name':roster[215730767]['name'],'repair':'Recheck MonsterZone space before Hand selfsummon resolution so CL2 filling all zones preserves Hand source and paidSpellTrapcost. Native five interruption cases/four controls including original-capacity; Handcost6/locks6/negation4 regressions. Exact-byte both-copy backup helmsman-before-hand-capacity-repair. Official FAQ19958 no-space Handresource retention applied by inference. No adapters; Zombie revival/ContinuousTrap selfsummon/shareduse/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':helmsman_path.name,'batch_sha256':sha(helmsman_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 frute_path=OUT/'current-fruteification-ritual-repaired-batch.json'
 if frute_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c256930605.lua';batch=json.loads(frute_path.read_text());assert batch['baseline_cases']==5
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results']);assert data['legacy_chaininfo_adapter'] is False
  assert any(r['control']=='original-relation' and r['expected_failures']==[0,1,2,3] for r in batch['runs']);assert any(r['control']=='original-material' and r['expected_failures']==[4] for r in batch['runs']);assert sha(FILES/'Scripts'/source.name)==sha(source);assert not any(r['passcode']==256930605 for r in rows)
  rows.append({'passcode':256930605,'name':roster[256930605]['name'],'repair':'Exclude selected Ritual from its material subgroup; remove unestablished target relation check from matching-card-selected Ritual. Native Hand/GY Ritual, Hand/field real materials, higher level and insufficient-other-material exclusion: five cases/four controls including original-line regressions. Both-copy exact-byte backups fruteification-before-relation-material-repair. Optional revival/current focused integration follow-ups separately diagnostic; all-effects/nativeOmega remain OPEN.','script_sha256':sha(source),'batch':frute_path.name,'batch_sha256':sha(frute_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 heat_path=OUT/'current-talismandrake-heat-hand-capacity-repaired-batch.json'
 if heat_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c210506870.lua'
  for name,cases in [('current-talismandrake-heat-hand-capacity-repaired-batch.json',7),('current-talismandrake-heat-hand-summon-batch.json',8)]:
   batch=json.loads((OUT/name).read_text());assert batch['baseline_cases']==cases
   for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
   for run in batch['runs']:
    artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  batch=json.loads(heat_path.read_text());assert any(r['control']=='original-capacity' and r['expected_failures']==[6] for r in batch['runs']);assert sha(FILES/'Scripts'/source.name)==sha(source);assert not any(r['passcode']==210506870 for r in rows)
  rows.append({'passcode':210506870,'name':roster[210506870]['name'],'repair':'Recheck MZONE space before Hand selfsummon resolution; native CL2 four Deck summons fill five zones and source remains Hand. Seven interruption cases/three controls including original-capacity; eight Hand eligibility cases/three controls. Exact-byte both-copy backups heat-before-hand-capacity-repair. Helmsman precedent/FAQ19958 interpretation applied by inference; Pendulum/equip ATK/Fusion/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':heat_path.name,'batch_sha256':sha(heat_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 morby_path=OUT/'current-morbydrip-placement-repaired-batch.json'
 if morby_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c210628767.lua';batch=json.loads(morby_path.read_text());assert batch['baseline_cases']==11
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results']);assert not data['in_memory_occupied_guard']
  assert any(r['control']=='original-guard' and r['expected_failures']==[6,7,8] for r in batch['runs']);assert sha(FILES/'Scripts'/source.name)==sha(source);assert sum(r['passcode']==210628767 for r in rows)==1
  row=next(r for r in rows if r['passcode']==210628767);row.update({'passcode':210628767,'name':roster[210628767]['name'],'repair':row.get('repair','')+' Additional repair: After destruction attempt, retain monster when required owner SZONE column remains occupied. Prevent generic MoveToField arriving in another column. Eleven native actual full-card Hand SS placement cases/four controls; five columns, destructible/indestructible/both or one-sided occupants, actual borrowed target owner mirrored return and absent target. Native ContinuousTrap type observer, no adapters. Exact-byte both-copy backups morbydrip-before-occupied-column-repair. NormalSummon/interruption/ExtraMonster columns/revival/EndPhase/shareduse/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':morby_path.name,'batch_sha256':sha(morby_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 morby_capacity_path=OUT/'current-morbydrip-revival-capacity-repaired-batch.json'
 if morby_capacity_path.exists():
  source=ROOT/'public/CCG Downloads/CCG_Scripts/c210628767.lua';batch=json.loads(morby_capacity_path.read_text());assert batch['baseline_cases']==7
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert data['script_sha256']==sha(source);assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results']);assert not data['capacity_guard_comparison']
  assert any(r['control']=='original-capacity' and r['expected_failures']==[6] for r in batch['runs']);row=next(r for r in rows if r['passcode']==210628767);row['repair']+=' Additional revival repair: recheck MZONE capacity before native SS so late full zones retain ContinuousTrap rather than consuming it toGY. Seven cases/fourcontrols including original-capacity; seven earlier Morbydrip batches refreshed/preserved. Both-copy byte backups morbydrip-before-revival-capacity-repair.';row['additional_batch']=morby_capacity_path.name;row['additional_batch_sha256']=sha(morby_capacity_path)
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c212429024.lua'
 nebulix_batches=[]
 for scope in ['copies','regression','repeat','attribution','interruption','opponent','capacity','reentry']:
  p=OUT/f'current-gravinity-nebulix-shared-append-{scope}-production-batch.json'
  if not p.exists():break
  batch=json.loads(p.read_text())
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  nebulix_batches.append({'path':p.name,'sha256':sha(p),'cases':batch['baseline_cases']})
 if len(nebulix_batches)==8:
  assert sum(b['cases'] for b in nebulix_batches)==34
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  rows.append({'passcode':212429024,'name':'Gravinity Nebulix','repair':'Append each copy additional effect to resolving Spell/Trap operation, preserve original once and original reason effect, respect native negation and source lifecycle. Shared per-link list cleared by global CHAIN_END. Exact-byte backup nebulix-before-resolution-append-repair. Eight production groups/34 cases including old-source attribution/negation controls. Native Synchro/recycle/Omega/fullcard OPEN.','script_sha256':sha(source),'batches':nebulix_batches,'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c214552846.lua'
 eldora_path=OUT/'current-eldora-resolution-repaired-batch.json'
 if eldora_path.exists():
  batch=json.loads(eldora_path.read_text());assert batch['baseline_cases']==9
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  assert any(r['control']=='old-source' and r['expected_failures']==[0,4,5,6,7,8] for r in batch['runs'])
  assert sha(FILES/'Scripts'/source.name)==sha(source)
  rows.append({'passcode':214552846,'name':'Eldora, the Intergalactic Empire','repair':'Replace premature Quick Chain response with optional resolution wrapper. Preserve original operation if declined or current source/threat cannot qualify; skip destruction when original effect negated, source departed or remaining own threat below two. Actual selfdestroy/negation and late indestructibility. Exact-byte backup eldora-before-resolution-timing-repair; nine native cases/four controls including old-source. GY matching destruction/Set/shared use/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':eldora_path.name,'batch_sha256':sha(eldora_path),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 attribution_batches=[]
 for name,cases in [('current-eldora-reason-repaired-batch.json',1),('current-eldora-lifecycle-repaired-batch.json',3)]:
  p=OUT/name;batch=json.loads(p.read_text());assert batch['baseline_cases']==cases
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  if cases==1:
   assert any(r['control']=='old-wrapper' and r['expected_failures']==[0] for r in batch['runs'])
   assert any(r['control']=='direct-call' and r['expected_failures']==[0] for r in batch['runs'])
  else:
   assert any(r['control']=='no-resolution' and r['expected_failures']==[0,1,2] for r in batch['runs'])
   assert any(r['control']=='no-reentry' and r['expected_failures']==[2] for r in batch['runs'])
  attribution_batches.append({'path':name,'sha256':sha(p),'cases':cases})
 row=next(r for r in rows if r['passcode']==214552846)
 row['repair']+=' Additional attribution correction: dispatch actual source continuous custom event during resolution wrapper so native self-destruction reason effect is Eldora; preserve original callback/reason, native negation suppression and repeated resolution/reentry. Nine refreshed production groups/53 cases. Exact-byte both-copy backup eldora-before-self-destruction-attribution-repair. Native Omega/fullcard remains OPEN.'
 row['additional_batches']=attribution_batches
 actinia_batches=[]
 for name,cases in [('negation',8),('interruption',7),('use-reset',3),('opponent-reset',3),('qualification-repaired',1),('proper-revival',6),('revival-boundaries',4),('revival-use-reset',1)]:
  p=OUT/f'current-actinia-{name}-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==cases
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  if name=='qualification-repaired':assert any(r['control']=='old-source' and r['expected_failures']==[0] for r in batch['runs'])
  actinia_batches.append({'path':p.name,'sha256':sha(p),'cases':cases})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c216258796.lua';assert sha(FILES/'Scripts'/source.name)==sha(source);assert sum(b['cases'] for b in actinia_batches)==33
 row=next(r for r in rows if r['passcode']==216258796)
 row['repair']+=' Additional repair: Require STATUS_PROC_COMPLETE in GY special summon procedure. Actual improper Extra-to-GY source no longer revives; old-source control reproduces offer. Proper history fixture uses real two printed-category materials, native non-bypass Fusion Summon then CompleteProcedure and actual destruction; proper revival/partner/capacity/player lock/NecroValley/shared summon use/reset verified. Eight production groups/33 cases including negation/interruption/named effect use regressions. Exact-byte both-copy backup actinia-before-revival-qualification-repair. Official Konami rulebook proper-summon restriction applied by inference. Source Fusion material-selection is separately blocked by public GetMustMaterial gap; fixture does not certify production recipe. NativeOmega/fullcard OPEN.'
 row['batches']=actinia_batches
 psychi_batches=[]
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c217332244.lua'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'psychi-before-payment-repair'
 assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 old=(backup/source.name).read_text();assert 'for i=100,lp-1,100 do' in old and 'HINTMSG_NUMBER' in old
 assert 'while place>=1 do' in source.read_text() and 'HINTMSG_NUMBER' not in source.read_text()
 for name,cases in [('current-psychi-summon-procedure-batch.json',7),('current-psychi-token-payment-repaired-batch.json',13),('current-psychi-proper-history-repaired-batch.json',3)]:
  p=OUT/name;batch=json.loads(p.read_text());assert batch['baseline_cases']==cases
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,r in enumerate(data['results']) if r['failure']]==run['expected_failures'];assert not any(r['logs'] for r in data['results'])
  psychi_batches.append({'path':name,'sha256':sha(p)})
 assert not any(r['passcode']==217332244 for r in rows)
 assert (OUT/'psychi-before-proper-history-repair/c217332244.lua').read_bytes()==(OUT/'psychi-before-proper-history-repair/installed-c217332244.lua').read_bytes()
 assert 'e0:SetValue(function(e,se,sp,st) return e:GetHandler():IsStatus(STATUS_PROC_COMPLETE) end)' in source.read_text()
 rows.append({'passcode':217332244,'name':'To Proto Psychi','repair':'Replace100-step LP choices with bounded decimal digit choices permitting every positive integer below current LP; use defined HINT_NUMBER in place of undefined HINTMSG_NUMBER. Actual native Token tribute/payment/exact ATK DEF gain;13 payment cases/three controls and7 summon cases/three controls. Exact repository/installed backups psychi-before-payment-repair. Proper-history correction permits actual native revival after printed Hand procedure while improperGY/externalHand excluded;3cases/fourcontrols, exact backup psy chi-before-proper-history-repair (directory psychi-before-proper-history-repair). Other effects/shared use/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batches':psychi_batches,'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c217632789.lua'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'pawty-before-hand-cost-guard';assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert 'if not c:IsStatus(STATUS_ACT_FROM_HAND) then return true end' in (backup/source.name).read_text()
 assert 'c:IsLocation(LOCATION_HAND) or c:IsStatus(STATUS_ACT_FROM_HAND)' in source.read_text()
 p=OUT/'current-pawty-cost-boundaries-repaired-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==5
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  artifact=OUT/run['artifact'];assert sha(artifact)==run['artifact_sha256'];data=json.loads(artifact.read_text());assert [i for i,v in enumerate(data['results']) if v['failure']]==run['expected_failures']
  if run['control']=='old-source':assert run['expected_failures']==[2,3,4] and all(any('Parameter 1' in log['message'] for log in data['results'][i]['logs']) for i in [2,3,4])
  else:assert all(not v['logs'] for v in data['results'])
 assert not any(v['passcode']==217632789 for v in rows)
 rows.append({'passcode':217632789,'name':'Skewy! Pawty Tyme','repair':'Check current Hand location as well as STATUS_ACT_FROM_HAND before allowing cost bypass, so unavailable-cost Hand activation is excluded before payment rather than nil selection error. Five native cases/four controls incl old-source errors; seven earlier groups refreshed. Exact both-copy backup pawty-before-hand-cost-guard. Activation limit/fullcard/nativeOmega OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-pawty-activation-reset-repaired-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==3
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'];assert all(not v['logs'] for v in d['results'])
 row=next(v for v in rows if v['passcode']==217632789);row['activation_batch']={'path':p.name,'sha256':sha(p)};row['repair']+=' Portable shared activation flag plus EVENT_CHAIN_NEGATED rollback replaces legacy count encoding; three native cases/fourcontrols and8 earlier groups refreshed, exact both-copy backup pawty-before-portable-activation-repair. Uses Bear Trap-tested APIs; actual Omega duel execution still open.'
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c217645912.lua'
 p=OUT/'current-tide-activation-repaired-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==15
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 assert len(batch['groups'])==4 and sum(g['baseline_cases'] for g in batch['groups'])==15
 for group in batch['groups']:
  assert any(run['control']=='old-source' and run['expected_failures'] for run in group['runs'])
  for run in group['runs']:
   a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==group['baseline_cases'];assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'];assert all(not v['logs'] for v in d['results'])
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'tide-before-optional-activation-repair';assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert not any(v['passcode']==217645912 for v in rows)
 rows.append({'passcode':217645912,'name':'Crewal Tide','repair':'Permit basic Field activation independently of optional Zombie mill. Choose optional effect at target declaration only with eligible resource, no prior nonCrewal summon and unused named playerflag; restriction applies only to chosen effect. Shared chosen-use persists through activation/effect negation and resets next turn; decline preserves use. Actual native summon history/later summon legality/three full copies/negation/reset, four groups15cases12controls including old-source. Exact both-copy backup tide-before-optional-activation-repair. Second trigger/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c218142234.lua'
 p=OUT/'current-seraphina-capacity-repaired-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==7
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==7;assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'];assert all(not v['logs'] for v in d['results'])
 assert any(run['control']=='old-source' and run['expected_failures']==[5,6] for run in batch['runs'])
 assert any(run['control']=='ignore-capacity' and run['expected_failures']==[4,6] for run in batch['runs'])
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 backup=OUT/'seraphina-before-capacity-repair';assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert 'aux.dncheck(g) and Duel.GetMZoneCount(tp,g)>0' in source.read_text()
 assert not any(v['passcode']==218142234 for v in rows)
 rows.append({'passcode':218142234,'name':'Maiden of Talismandrakes Seraphina','repair':'Allow Pendulum activation when the shuffle cost frees Monster Zones. Combine distinct-name and projected free-zone checks in cost eligibility and subgroup selection, remove premature target current-capacity guard. Actual neutral printed-category native Fusion history/PZone placement and7cases4controls, including mixed GY/field pool forcing MZONE cost and old-source failures. Exact both-copy backup seraphina-before-capacity-repair. Production Fusion recipe/equip/other effects/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-reconciled-sylvan-standalone-batch.json';batch=json.loads(p.read_text());assert batch['baseline_goleaf_cases']==12 and batch['family_loader_cards']==8
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text())
  if run['family']:
   assert len(d['results'])==8 and sum(v['pass'] for v in d['results'])==run['passed']
  else:
   assert len(d['results'])==12 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
   if run['old_source']:
    for i in run['expected_failures']:assert "global 'CCGSylvan'" in d['results'][i]['failure'] and ':59:' in d['results'][i]['failure']
  if not run['old_source']:assert all(not v['logs'] for v in d['results'])
 roster={v['passcode']:v['name'] for v in json.loads((OUT/'baseline-remote.json').read_text(encoding='utf-8'))['cards']}
 clean=lambda text:'\n'.join(line.strip() for line in text.splitlines() if line.strip())
 for code in batch['cards']:
  source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';backup=OUT/'current-state-reconciliation-before-install/Scripts'/source.name
  current=source.read_text(encoding='utf8');previous=backup.read_text(encoding='utf8')
  assert current.split('local s,id=GetID()',1)[1]==previous.split('local s,id=GetID()',1)[1]
  assert clean(current.split('function CCGSylvan.Plant',1)[1].split('local s,id=GetID()',1)[0])==clean(previous.split('function CCGSylvan.Plant',1)[1].split('local s,id=GetID()',1)[0])
  assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert 'if type(CCGSylvan)~="table" then' in current
  assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Standalone inline Sylvan helper fixes missing external helper; valid existing namespace preserved. Current card effect and helper function bodies equal prior inline version. Native Goleaf12 actual-duel cases in missing/preexisting namespaces; original exact nilglobal reproduced. All8 current custom Sylvans pass isolated loader/functions/sentinel checks, with initial_effect explicitly bypassed only for loading tests. Other effects/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-reconciled-ritual-material-release-batch.json';batch=json.loads(p.read_text());assert batch['leotron_cases']==15 and batch['family_callback_cases']==28
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert all(not v['logs'] for v in d['results'])
  actual=[i for i,v in enumerate(d['results']) if v['failure']] if run['family'] else [v['scenario'] for v in d['results'] if v['failure']]
  assert actual==run['expected_failures']
 for code in batch['cards']:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';backup=OUT/'ritual-material-before-release-guard'
  assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  assert 'c:IsCanBeRitualMaterial(rc) and c:IsReleasableByEffect()' in source.read_text(encoding='utf-8')
  assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
  assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Reject non-Tributable Hand/field Ritual materials using native contextual IsReleasableByEffect. Shared7filters verified by28bounded native callbacks and original14protected failures; Leotron15actual primary Pendulum Ritual cases with original4capacity/protection failures and3controls6/4/2. Exact both-copy backup and installed parity. Other effects/Deck-send/Mage group/fullcard/native Omega OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-reconciled-ritual-material-context-batch.json';batch=json.loads(p.read_text());assert batch['family_callback_cases']==23
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==23 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for code in batch['cards']:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';backup=OUT/'ritual-context-before-release-guard'
  assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
  assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Reject protected non-Tributable Hand/field Ritual materials while preserving eligible Deck-send materials; Nephthys self Tribute guarded. Four full native-loaded scripts with23bounded production filter callbacks, original7protected failures and blindDeckguard3failures. Full effects/Mage group Pendulum/nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-reconciled-glitchling-mage-pendulum-group-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==12
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==12 and all(not v['logs'] for v in d['results']);assert [v['scenario'] for v in d['results'] if v['failure']]==run['expected_failures']
 row=next(v for v in rows if v['passcode']==259072906);row['group_pendulum_batch']=p.name;row['group_pendulum_batch_sha256']=sha(p);row['repair']+=' Also reject protected and immune field materials in actual group Pendulum Ritual procedure; pass actual procedure effect to immunity check.12nativecases/original2failures/3controls5each, properstatus/payment/checklist and1/2summons; Extra targets/reset/liveOmega/fullcard OPEN.'
 p=OUT/'current-reconciled-chain-trigger-delay-batch.json';batch=json.loads(p.read_text());assert batch['family_registration_cases']==10 and batch['starry_compatibility_cases']==9
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert all(not v['logs'] for v in d['results'])
  actual=[i for i,v in enumerate(d['results']) if v['failure']] if run['family'] else [v['scenario'] for v in d['results'] if v['failure']];assert actual==run['expected_failures']
 for item in json.loads((OUT/'chain-trigger-delay-repair-files.json').read_text()):
  code=int(item['file'][1:-4]);source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];backup=OUT/'chain-trigger-before-delay-repair'
  assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
  assert item['variable']+':SetProperty('+item['variable']+':GetProperty()|EFFECT_FLAG_DELAY)' in source.read_text(encoding='utf-8');assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Add missing delayed flag to existing EVENT_CHAINING optional trigger; preserves event type/other flags and after-chain timing. Ten bounded native full-source isolated registration accept/decline probes withold10failures; Starry9full effectcompatibility diagnostic cases/old5failures/controls7/1/3/9. Explicit legacy chain attribute constant mapping forStarry; no nativeOmega/fullcard certification. Exactbothbackup/installparity.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-talismandrake-embers-pendulum-revival-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==8
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==8 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 code=256928871;source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';backup=OUT/'embers-before-extra-redirect-repair'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert not any(v['passcode']==code for v in rows)
 rows.append({'passcode':code,'name':roster[code],'repair':'Pendulum revival leave-field redirect uses supported LOCATION_DECK so Fusion returns to Extra; LOCATION_EXTRA was ignored. Eight actual native cases with original GY/banish failures and four fault controls. Neutral Fusion recipe, other effects and nativeOmega/fullcard OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-talismandrake-embers-pendulum-interruption-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==8
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==8 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 assert rows[-1]['passcode']==256928871
 rows[-1]['interruption_batch']=p.name;rows[-1]['interruption_batch_sha256']=sha(p)
 rows[-1]['repair']+=' Eight additional native interruption cases verify actual target relation, source/target leave, late capacity/lock and negation; baseline redirects to Extra.'
 p=OUT/'current-talismandrake-embers-pendulum-use-reset-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==3
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==3 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 assert rows[-1]['passcode']==256928871
 rows[-1]['shared_use_reset_batch']=p.name;rows[-1]['shared_use_reset_batch_sha256']=sha(p)
 p=OUT/'current-talismandrake-sear-material-followup-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==5
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==5 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 code=245935439;source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';backup=OUT/'sear-before-pzone-original-type-repair'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert (backup/source.name).read_bytes()==(backup/('installed-'+source.name)).read_bytes()
 assert pre_sear_native_type_source(source)==(backup/source.name).read_bytes().replace(b'return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_MONSTER)',b'return c:IsSetCard(SET_TALISMANDRAKE) and c:IsOriginalType(TYPE_MONSTER)')
 assert not any(v['passcode']==code for v in rows)
 rows.append({'passcode':code,'name':roster[code],'repair':'Fusion-material followup checks original Monster type of partner in PZone (current type is Spell). Five actual followup cases, old source3failures, controls2/1/3. Explicit test-only absent-mandatory-material API adapter for neutral Fusion recipe; qualified compatibility diagnostic, not liveOmega/fullcard certification. Exact backup and installed parity.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-talismandrake-sear-material-interruption-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==7
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==7 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 assert rows[-1]['passcode']==245935439
 rows[-1]['followup_interruption_batch']=p.name;rows[-1]['followup_interruption_batch_sha256']=sha(p)
 rows[-1]['repair']+=' Seven additional compatibility diagnostic interruption cases verify independent optional placement after late summon failure, actual CL2 negation/source/partner banish/full field/summon lock. Controls6/2/4 exact failures.'
 p=OUT/'current-talismandrake-sear-material-use-reset-batch.json';batch=json.loads(p.read_text());assert batch['baseline_cases']==3
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['artifact_sha256'];d=json.loads(a.read_text());assert len(d['results'])==3 and all(not v['logs'] for v in d['results'])
  assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 assert rows[-1]['passcode']==245935439
 rows[-1]['secondary_use_reset_batch']=p.name;rows[-1]['secondary_use_reset_batch_sha256']=sha(p)
 rows[-1]['repair']+=' Three additional native secondary shared use/reset cases, no Lua API adapter: real material reason/Fusion/proper completion via neutral fixed-recipe operation; second copy excluded same turn after success/negated activation/negated effect, third copy next own turn summons. PerCopy3/noReset3/noSummon3 controls.'
 p=OUT/'current-symphonic-disccs-monster-batch.json';batch=json.loads(p.read_text())
 assert batch['status']=='PARTIAL_NATIVE_DELAYED_SEARCH_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 assert any(r['fixture']=='monster-chain' and r['flag']=='old-source' and r['expected_failures']==[1] for r in batch['runs'])
 code=238273770;source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';backup=OUT/'disccs-before-delayed-search-chain-repair'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 original=(backup/source.name).read_bytes();assert original==(backup/('installed-'+source.name)).read_bytes()
 assert source.read_bytes()==original.replace(b' e2:SetCondition(s.chaincon)',b' --Check the chain guard at activation cost, not when a delayed summon event occurs.')
 assert not any(v['passcode']==code for v in rows)
 rows.append({'passcode':code,'name':roster[code],'repair':'Delay the summon-search chain guard until activation cost: a summon during another Disccs effect must retain its new-chain trigger. Removed only the event-time condition; shared uses and same-chain exclusions retained. Native grouped regressions include both simultaneous trigger orders, original-source lost-search failure, restrictions/counters/recruitment and natural resets. Neutral fixed native Synchro recipe; no Lua API adapter. Omega helper compatibility and live Omega remain distinct/open.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-origins-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ORIGINS_TWO_BOUNDED_REPAIRS_VERIFIED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 assert any(r['control']=='old-source' and r['expected_failures']==[2,3] for r in batch['runs'])
 assert any(r['control']=='old-cost' and r['expected_failures']==[3] for r in batch['runs'])
 code=244986323;source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';backup=OUT/'pendulum-before-placement-relation-repair'
 assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 original=(backup/source.name).read_bytes();middle=(backup/('before-empty-gy-'+source.name)).read_bytes();nl=b'\r\n' if b'\r\n' in original else b'\n'
 assert original==(backup/('installed-'+source.name)).read_bytes();assert middle==(backup/('installed-before-empty-gy-'+source.name)).read_bytes()
 assert middle==original.replace(b'function s.penop(e,tp,eg,ep,ev,re,r,rp)',b'function s.penop(e,tp,eg,ep,ev,re,r,rp)'+nl+b'\tif not e:GetHandler():IsRelateToEffect(e) then return end')
 signature=b'function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)';helper=nl.join([b'function s.detachedfilter(c)',b'\treturn c:IsAbleToGraveAsCost() and c:IsAbleToRemove()',b'\t\tand not Duel.IsPlayerAffectedByEffect(c:GetOwner(),EFFECT_NECRO_VALLEY)',b'end',signature])
 old=b'and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(Card.IsAbleToRemove),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,nil) end'
 new=b'and (Duel.IsExistingMatchingCard(aux.NecroValleyFilter(Card.IsAbleToRemove),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,nil)'+nl+b'\t\tor e:GetHandler():GetOverlayGroup():IsExists(s.detachedfilter,1,nil)) end'
 assert pre_origins_damage_source(source)==middle.replace(signature,helper).replace(old,new)
 assert not any(v['passcode']==code for v in rows)
 rows.append({'passcode':code,'name':roster[code],'repair':'Self-placement respects source relation after CL2 moves to GY/banishment. Destroy/banish activation may use GY cards supplied by detaching its own materials; prospective detach checks retain redirect/Necrovalley restrictions. Native removal/placement/Quick effect/actual SpellTrap targeting tests and exact original-source failures. Attachment and Xyz recipe evidence use bounded test-only absent IsCanOverlay/IsFaceupEx/CheckXyzMaterial/SelectXyzMaterial adapters with separate unadapted probes. General Omega recipes, named-use/reset scope beyond evidence and live Omega remain OPEN.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-glitchling-monster-batch.json';batch=json.loads(p.read_text());assert batch['status']=='PUBLIC_REVEAL_COST_FAMILY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 assert any(r['control']=='old-source' and r['args']==[] and r['expected_failures']==[7,15] for r in batch['runs'])
 assert any(r['control']=='old-source' and r['args'] and r['expected_failures']==[1,4,7,10,14] for r in batch['runs'])
 for item in json.loads((OUT/'public-reveal-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']);assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  existing=next((v for v in rows if v['passcode']==code),None)
  description='Reject already-public Hand cards when paying reveal cost. Native full Witch/Mage search/public-source/partner/restriction/Extra-history checks; five sibling full-source bounded cost callbacks under actual PUBLIC effect with private/wrong-set controls and Proto Deck control. All seven old-code public failures reproduced. No Lua API adapter; no live Omega/full-card certification.'
  if existing:
   existing['repair']+=' '+description;existing['public_reveal_repair_batch']=p.name;existing['public_reveal_repair_batch_sha256']=sha(p);existing['historical_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact cost-only guard or separate cost wrapper; prior generic material, summon and resolution functions byte-preserved. Earlier evidence remains explicitly historical.'}
  else:
   rows.append({'passcode':code,'name':roster[code],'repair':description,'script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-glitchling-followup-batch.json';batch=json.loads(p.read_text());assert batch['status']=='RITUAL_REVIVAL_FAMILY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'ritual-revival-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];pre_revival_source(source);assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  existing=next((v for v in rows if v['passcode']==code),None)
  description='Remove extra Ritual-only Special Summon condition while retaining native first-proper-Summon requirement. Full-source native paid Ritual to GY/faceup Extra then ordinary revival, unprepared Hand/GY exclusions and original-source failures. Witch/Mage followup and Leotron recruitment/negation evidence bounded in grouped batch. Neutral Ritual setup; no Lua API adapter, full-card or live Omega certification.'
  if existing:
   existing['repair']+=' '+description;existing['ritual_revival_batch']=p.name;existing['ritual_revival_batch_sha256']=sha(p);existing['ritual_revival_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact removal of e0 aux.ritlimit block; EnableReviveLimit retained. Earlier evidence remains historical.'}
  else:rows.append({'passcode':code,'name':roster[code],'repair':description,'script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-terrarumian-dynamic-count-batch.json';batch=json.loads(p.read_text());assert batch['status']=='NATIVE_FACEUP_COUNT_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 code=284639720;source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';item=json.loads((OUT/'terrarumian-faceup-count-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==code for v in rows)
 rows.append({'passcode':code,'name':roster[code],'repair':'DEF multiplier excludes face-down Terrarumian monsters on either field. Native dynamic own/opponent category/position counts, actual position change/banishment and source removal; original-source own/opponent facedown failures and effective bonus controls. Exact source/install backups/parity; no adapter/full-card/live Omega certification.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-patrician-extra-limit-batch.json';batch=json.loads(p.read_text());assert batch['status']=='PATRICIAN_EXTRA_LIMIT_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 code=259882493;source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';item=json.loads((OUT/'patrician-extra-limit-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==code for v in rows)
 rows.append({'passcode':code,'name':roster[code],'repair':'Shared facedown-Extra summon activity counter covers Fusion and alternative Tribute methods, closing both mixed-method bypasses. Native original Tribute procedure, paid fixed two-Vaylantz Fusion history, second-method exclusions, natural reset and faceup-Extra revival exclusion. Original-source/removed-counter failures retained. Exact source/install backups/parity. General Fusion procedure, coin compatibility and live Omega remain separate/open.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-glitchling-corruption-material-batch.json';batch=json.loads(p.read_text());assert batch['status']=='MAGE_CORRUPTION_MATERIAL_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 code=259072906;source=ROOT/f'public/CCG Downloads/CCG_Scripts/c{code}.lua';item=json.loads((OUT/'mage-corruption-material-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 row=next(v for v in rows if v['passcode']==code);row['repair']+=' Support Corruption Counter supplementation for eligible Hand-only followup materials and field-material Pendulum Ritual groups, including multiple targets. Deck groups cannot use counter subsidy. Native actual counter/payment and ordinary sufficient-level preservation, original-source failures and cap/payment controls; no Lua adapter. Earlier evidence reconciled through exact counter-material patch.'
 row['corruption_material_batch']=p.name;row['corruption_material_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['corruption_material_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact helper-verified counter eligibility/payment additions; previous reveal/revival stages composed and retained historically.'}
 p=OUT/'current-corruption-disabled-batch.json';batch=json.loads(p.read_text());assert batch['status']=='DISABLED_CORRUPTION_FAMILY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'disabled-corruption-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  row=next(v for v in rows if v['passcode']==code);row['repair']+=' Corruption Counter subsidy requires a faceup non-disabled grant. Native counter retention/negation/second-active/facedown/absent states tested via bounded full-source helper callbacks; full Leotron effect/payment/CL2 counter-loss checks separate. Original five failures, exact one-filter guards/backups/parity. No API adapter or live Omega claim.';row['disabled_corruption_batch']=p.name;row['disabled_corruption_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['disabled_corruption_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact not-IsDisabled guard on corruptionfilter only; prior counter/revival/reveal stages retained and composed.'}
 p=OUT/'current-pendulum-unprinted-limit-batch.json';batch=json.loads(p.read_text());assert batch['status']=='UNPRINTED_PENDULUM_LIMITS_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'pendulum-unprinted-limit-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  row=next(v for v in rows if v['passcode']==code);row['repair']+=' Remove unprinted Pendulum once-per-turn limit. Native same-turn repeated full effects after success/activation or effect negation; original-source and omitted-operation controls. Six Pendulums with no printed limit checked. Historical Seraphina named Pendulum limit assertion superseded; monster limits preserved. No API adapter/live Omega claim.';row['unprinted_limit_batch']=p.name;row['unprinted_limit_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['unprinted_limit_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact e1 count-limit line removal only, composed before prior Leotron disabled-Corruption/revival stages.'}
 p=OUT/'current-seraphina-wipe-batch.json';batch=json.loads(p.read_text());assert batch['status']=='SERAPHINA_INDEPENDENT_WIPE_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==9 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c218142234.lua';item=json.loads((OUT/'seraphina-wipe-relation-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
 row=next(v for v in rows if v['passcode']==218142234);row['repair']+=' Independent opponent-field destruction resolves after source banishment/face-down or equip loss. Actual LP payment and all opposing monster/Spell/Trap destruction, native CL2 activation/effect negation, missing Arms/LP exclusions and original-source/omitted-operation controls. Field-seeded source/neutral equip setup; no API adapter or live Omega claim.';row['independent_wipe_batch']=p.name;row['independent_wipe_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['independent_wipe_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact single desop source-relation/faceup guard removal; earlier Pendulum limit/capacity stages retained.'}
 p=OUT/'current-stained-avatar-destruction-batch.json';batch=json.loads(p.read_text());assert batch['status']=='STAINED_AVATAR_INDEPENDENT_DESTRUCTION_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==7 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c244790302.lua';item=json.loads((OUT/'stained-avatar-relation-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==244790302 for v in rows)
 rows.append({'passcode':244790302,'name':roster[244790302],'repair':'Independent destroy-other effect resolves after source banishment. Exact single desop relation guard removed in source/install with before-byte backups. Native paid two-different-Attribute Stain Fusion by neutral operation with real Abstain identity; full Avatar trigger/op/source-loss/face-down/negation/wrong-spell/non-Fusion boundaries and original-source/omitted-operation controls. No Lua API adapter. Full Abstain/general Fusion recipe/other Avatar effects/live Omega remain open. Same-pattern Yajna GY source-removal candidate explicitly pending.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-yajna-set-batch.json';batch=json.loads(p.read_text());assert batch['status']=='YAJNA_INDEPENDENT_DESTRUCTION_BEFORE_SET_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==7 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c247755867.lua';item=json.loads((OUT/'yajna-set-order-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==247755867 for v in rows)
 rows.append({'passcode':247755867,'name':roster[247755867],'repair':'GY target destruction resolves after source banishment, then source relation checked before own Set. Native current installed metadata/corrected transport/no API adapter: actual CL2 source/target removal and negation, full-zone target freeing space, facedown Set and leave-field redirect. Original source failure; deleting final relation incorrectly Sets banished source, retained as effective control. Exact order-only source/install backup/parity. Four Hand/GY destroy-then-summon patterns are unconfirmed followups. Other effects/limits/full-card/live Omega remain open.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-destroy-then-summon-batch.json';batch=json.loads(p.read_text());assert batch['status']=='THREE_DESTROY_THEN_SUMMON_SEQUENCES_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==18 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'destroy-summon-order-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Independent other-card destruction resolves after activated Hand source is banished; later self summon remains relation-dependent. Angulimala GY origin also native tested. Torus late-full field evaluates space after resource destruction. Full sources/current installed metadata/corrected transport/no Lua API adapter, actual CL2 resource/source loss and true negation, original-source/omitted-operation/later-guard controls. Exact before-byte backups/source-install parity. Other effects/initial full-field capacity/Jarita followup/full-card/live Omega remain separate/open.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-jarita-revival-batch.json';batch=json.loads(p.read_text());assert batch['status']=='JARITA_INDEPENDENT_DESTRUCTION_BEFORE_REVIVAL_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==10 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c247755871.lua';item=json.loads((OUT/'jarita-revival-order-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==247755871 for v in rows)
 rows.append({'passcode':247755871,'name':roster[247755871],'repair':'Remove only early GY revop source-relation guard so independent resource destruction resolves after source banishment; later guard prevents moved-source revival. Genuine neutral paid two-Level4-Kali Xyz with native overlay/type/proper status then GY, full Jarita/current installed metadata/corrected transport/no Lua API adapter. Actual revival, optional opposing Spell overlay, full-field/category boundaries, leave-field banish redirect and CL2 resource/source loss/negation. Original-code/final-guard/redirect/no-proper-completion controls; exact source/install backups/parity. General original Xyz procedure, other effects/limits/full-card/live Omega remain open.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-destroy-summon-capacity-batch.json';batch=json.loads(p.read_text());assert batch['status']=='PROJECTED_MAIN_ZONE_CAPACITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'destroy-summon-capacity-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  note=' Project actual Main Zone capacity after removing a destroyable own resource. Rex/Torus permit full-field activation with Main resource; all eight Terrarumians exclude Extra-only resource that cannot free Main space. Native actual Hand/PZone placement, resource destruction/self summon and geometry exclusions; effective original/no-projection/omitted-operation controls. Extra Fusion resource field-seeded for geometry, no original recipe/history/live Omega claim. Exact helper-proved stage/backups/parity.'
  row=next((v for v in rows if v['passcode']==code),None)
  if row:row['repair']+=note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['capacity_batch']=p.name;row['capacity_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['capacity_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact projected-Main-zone helper patch; composed before older Rex/Torus operation-order and Nerve count-filter stages.'}
 p=OUT/'current-kali-zone-capacity-batch.json';batch=json.loads(p.read_text());assert batch['status']=='KALI_PROJECTED_MAIN_CAPACITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'kali-zone-capacity-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==code);row['repair']+=' Activation requires actual projected Main Zone capacity; Extra-only resource cannot free a Main Zone. Existing destruction/revival operations untouched. Native full Main resource and open non-Main resource positives/Extra and full non-Main exclusions, original/no-projection/omitted-operation controls. Jarita keeps genuine paid Xyz history and no-proper-completion control. Exact source/install backup and composed older order-guard reconciliation; no API adapter/full-card/live Omega claim.';row['kali_capacity_batch']=p.name;row['kali_capacity_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['kali_capacity_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact helper-verified activation-only projected-space predicate, before previous operation-guard stages.'}
 p=OUT/'current-stagger-capacity-batch.json';batch=json.loads(p.read_text());assert batch['status']=='STAGGER_TWO_CARD_MAIN_CAPACITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c253934904.lua';item=json.loads((OUT/'stagger-capacity-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==253934904 for v in rows)
 rows.append({'passcode':253934904,'name':roster[253934904],'repair':'GY revival activation requires a destroyable two-DARK subgroup projecting positive Main Zone capacity. Full Main field plus only DARK pair in Extra Zones cannot activate. Native mutual-link path verifies both own Extra Zones connected; pair freeing Main space and Extra pair with open Main space actually destroy two/revive; one-DARK negative. Full source/current installed metadata/corrected transport/no Lua API adapter. Field-seeded neutral Link geometry, not paid resource history; original/no-projection/omitted-operation controls and exact source/install backup/parity. Resolution selection/other effects/limits/full-card/live Omega remain separate.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-ritual-zone-subgroup-batch.json';batch=json.loads(p.read_text());assert batch['status']=='RITUAL_PROJECTED_DESTINATION_SUBGROUP_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==3 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'ritual-zone-subgroup-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes()
  row=next((v for v in rows if v['passcode']==code),None)
  note=' Ritual material eligibility/selection now checks projected destination space together with Levels/counter allowance. Both blocked Extra Zones exclude faceup-Extra target; paying eligible Extra-zone material frees destination and actually Ritual Summons. Leotron full-source; Corruption/Data-Transfert bounded production callbacks via neutral ignition, original-source and omitted-material controls. Genuine neutral prior Ritual/Extra history; no Lua API adapter/full-card/live Omega claim.'
  if row:row['repair']+=note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['ritual_zone_batch']=p.name;row['ritual_zone_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['ritual_zone_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact helper-verified four substitutions; normalized before historical unprinted-limit/disabled-Corruption/revival stages.'}
 p=OUT/'current-ritual-main-space-batch.json';batch=json.loads(p.read_text());assert batch['status']=='RITUAL_DESTINATION_SPECIFIC_MAIN_SPACE_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==(7 if run['passcode']==259072906 else 4) and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'ritual-main-space-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==code)
  row['repair']+=' Destination-specific Ritual space: full Main/open EMZ permits faceup-Extra target, Hand remains excluded. Mage full monster effect also verifies actual CL2 late Main fill: Extra succeeds, Hand stops. Leotron full PZone effect; Corruption/Data-Transfert bounded production callbacks. Earlier subgroup projection and both-blocked-Extra exclusion retained. Genuine neutral prior Ritual/Extra history; exact payments/counters/type/proper status and original/omitted-material/response controls; no Lua API adapter/full-card/live Omega claim.'
  row['ritual_main_batch']=p.name;row['ritual_main_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['ritual_main_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact helper-verified destination-specific Mage guards/three redundant sibling guards; composed before historical subgroup/counter/limit/revival repairs.'}
 p=OUT/'current-mage-mixed-group-batch.json';batch=json.loads(p.read_text());assert batch['status']=='MAGE_MIXED_RITUAL_DESTINATION_CAPACITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==10 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259072906.lua';item=json.loads((OUT/'mage-group-zone-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==259072906)
 row['repair']+=' Group replacement Ritual now requires projected Main space only for Hand targets and projected total usable space for the whole group; existing Extra count and summed Level checks retained. Full native actual Mage2/Leotron4 targets and Mage5/Witch0 scales, real materials/reasons/type/completion. Full Main+Main Tribute permits Hand+Extra; full Main+Extra Tribute permits single Extra. Actual selected negative groups exclude low total Levels, blocked/two Extra, insufficient Main, and one linked Main shared by both destinations. Negative group predicates run inside native diagnostic; positives actually summon. Effective old-source/payment/completion/Hand/Extra/total/max-Level controls, exact backups/helper reconciliation. Neutral paid prior Ritual/Extra history and field-seeded Link geometry qualified; no Lua API adapter/full-card/live Omega claim.'
 row['mage_group_batch']=p.name;row['mage_group_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['mage_group_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact single capacity-expression replacement, normalized before older Ritual destination/counter/limit/revival stages.'}
 p=OUT/'current-dragar-also-batch.json';batch=json.loads(p.read_text());assert batch['status']=='DRAGAR_INDEPENDENT_ALSO_POSITION_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==10 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c247580036.lua';item=json.loads((OUT/'dragar-also-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==247580036 for v in rows)
 rows.append({'passcode':247580036,'name':roster[247580036],'repair':'Target relation/faceup check now guards only dependent LP gain; independent also changes other opponent monsters face-down after target banishment, bounce or Set. Full source/current installed metadata/corrected transport/no Lua API adapter; neutral paid printed-category two-Stain Fusion, real own Tribute/target/CL2 and actual LP/positions. Source banish/zeroATK/negations/untargetable other/Link exclusions and original target exclusion verified. Effective original/no-response/no-position controls. Exact source/install backups/helper reconciliation; same-pattern position/also scan and four matching current literal mention lists recorded. General Fusion/other clauses/limits/full-card/live Omega remain open.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-summon-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='DRAGAR_MEADOW_FACEUP_SUMMON_VISIBILITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==(7 if run['family']=='dragar' else 6) and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'summon-visibility-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  note=' Property-dependent summon-event predicate now requires faceup, excluding face-down Special Summons. Dragar original self branch unchanged; native own non-LIGHT Stain Normal/Special/mixed group positives and LIGHT/non-Stain/opponent negatives. Meadow full Hand activation and actual opponent summon player/Normal/Special/mixed group/native GY revival; own/LIGHT/face-down negatives. Effective original-source/outcome controls, installed metadata/corrected transport/no Lua API adapter, neutral supports; general recipes/other effects/full-card/live Omega remain open.'
  if row:row['repair']+=note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['visibility_batch']=p.name;row['visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['visibility_source_reconciliation']={'before_sha256':item['before_sha256'],'after_sha256':item['after_sha256'],'scope':'Exact single faceup predicate insertion; Dragar earlier independent-also stage composed separately.'}
 p=OUT/'current-property-summon-batch.json';batch=json.loads(p.read_text());assert batch['status']=='KALEIDRAGON_PIPESIREN_FACEUP_EVENT_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for item in json.loads((OUT/'summon-visibility-family-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Property-dependent summon-event filter now requires faceup, excluding face-down archetype summons. Full actual source/installed metadata/corrected transport/no Lua API adapter. Native own Special Summon and mixed-group positives, Normal/wrong-set/opponent/face-down negatives. Kaleidragon actual Hand/face-down field confirmations with field-seeded source (no Fusion/proper-history inference); Pipesiren starts Hand and actually recruits (subsequent search no candidate). Effective original-source and omitted-look/recruitment controls; exact source/install before-byte backups/helper/parity. Only predicate changed, self/summon-player/count/other effects unchanged. General recipes/other effects/limits/full-card/live Omega remain separate.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-arms-united-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ARMS_UNITED_FACEUP_RECIPIENT_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==3 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c215034223.lua';item=json.loads((OUT/'arms-united-visibility-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==215034223)
 row['repair']=row.get('repair','')+' Shared Pyro Fusion recipient filter requires faceup at trigger/target and resolution. Full United/installed metadata/corrected transport/no Lua API adapter. Native neutral ordinary Fusion Special Summon faceup positive banishes United as COST/equips Suppressor identity/gains500; native facedown now excludes without paying cost, wrong race excludes. Original-source/omitted-equip controls, exact source/install backups/helper/parity. Neutral Fusion has no proper-history claim; Suppressor own script neutral, full original support/other effects/full-card/live Omega separate. Earlier discard-source-exclusion evidence reconciled only by exact new filter insertion.'
 row['united_visibility_batch']=p.name;row['united_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-sanctuary-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='SANCTUARY_FACEUP_SUMMON_EVENT_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==7 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259160760.lua';item=json.loads((OUT/'sanctuary-visibility-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==259160760),None)
 note=' Insect-or-Wyvernal summon-event filter now requires faceup; original own-effect exclusion retained. Full source/installed metadata/corrected transport/no Lua API adapter. Actual Field activation, own/opponent/Insect-only/Wyvernal-only/mixed group Special Summon positives; Normal/wrong-race-no-set/face-down negatives. Original full Fusion operation with neutral direct two-code recipe really shuffles Hand materials into Deck and Fusion Summons/completes with exact material group/reasons. Original-source/omitted-Fusion controls and exact backups/helper/parity. General recipient helpers/Chain Material/other effects/limits/full-card/live Omega remain open.'
 if row:row['repair']=row.get('repair','')+note
 else:
  row={'passcode':259160760,'name':roster[259160760],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
 row['sanctuary_visibility_batch']=p.name;row['sanctuary_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-azeriel-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='AZERIEL_FACEUP_EVENT_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==7 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c237089049.lua';item=json.loads((OUT/'azeriel-visibility-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==237089049),None)
 note=' GY revival event requires faceup Arckcestial Xyz/Synchro card; ordinary Special Summons still qualify. Full source/installed metadata/corrected transport/no Lua API adapter; source actually paid Xyz material group/overlay/type/proper completion then GY, no fake proper-status GY seed. Event Synchro/Xyz also actually pays/properly summons/enters GY, then native ordinary type0 revival. Own faceup and mixed group positives actually revive source in Defense; face-down/wrong-set/wrong-type/opponent negatives. Original-source/omitted-revival controls and exact source/install backup/helper/parity. Neutral fixed paid preparations/field-seeded material identities, not original general recipe/helper certification; RUM followup/other effects/limits/full-card/live Omega separate.'
 if row:row['repair']=row.get('repair','')+note
 else:
  row={'passcode':237089049,'name':roster[237089049],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
 row['azeriel_visibility_batch']=p.name;row['azeriel_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-silphia-pair-batch.json';batch=json.loads(p.read_text());assert batch['status']=='SILPHIA_DISTINCT_BANISH_PAIR_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==2 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c247789143.lua';item=json.loads((OUT/'silphia-pair-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==247789143 for v in rows)
 rows.append({'passcode':247789143,'name':roster[247789143],'repair':'Resolution first banish selection uses existing valid-pair predicate, preserving distinct own Stain for second selection. Full source/installed metadata/corrected transport/no Lua API adapter; field-seeded Silphia on own turn native2200ATK, real opponent Trap CL2/Quick CL3/second option/exact2000ATK loss, two native temporary banishments with one or two own Stains. Original source actually banishes only one when sole Stain chosen first; omitted-banish controls fail. Exact backup/helper/manifest/source-install parity. Same nested first-selection exclusion pattern scan finds only Silphia. Source Fusion history/original recipe/return phase/other effects/full-card/live Omega unverified.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-deck-monster-type-batch.json';batch=json.loads(p.read_text());assert batch['status']=='THREE_MONSTER_ONLY_DECK_SEND_FILTERS_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==3 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'deck-monster-type-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  note=' Printed monster-only archetype Deck-to-GY filter now requires TYPE_MONSTER. Full actual source and actual archetype Meadow/Calling/Eclipse Spell scripts/installed metadata/corrected transport/no Lua API adapter. Native original-source counterexamples really send forbidden Spells in Spell-only and mixed pools; corrected original paid fixed Xyz trigger (Azeriel), Hand discard ignition/native cost (Asthenosoma), field ignition (Grayling) exclude Spells and really send neutral monster. Effective omitted-send controls, exact source/install backups/helper/manifest/parity. Sixteen matching predicate/Deck-caller candidates reviewed against current text; other card-worded filters/explicit Trap guard retained. Earlier Azeriel visibility repair reconciled only via exact new one-filter patch. Other effects/general recipes/full-card/live Omega remain separate.'
  if row:row['repair']=row.get('repair','')+note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['deck_monster_type_batch']=p.name;row['deck_monster_type_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-stain-departures-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TWO_STAIN_LEAVE_WATCHERS_REPAIRED' and batch['same_pattern_cards']==[248453205,256608976]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==7 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'stain-departure-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Granted single continuous leave watcher survives first departure, resets itself before transfer, retains TURN_SET/TOFIELD resets. If card already entered opposing Deck, shuffle/make faceup without toggling existing faceup state. Full original Silhouette Hand summon after actual opposing Deck event or full Shattering actual Hand tribute cost/Deck recruit; installed metadata/corrected transport/no Lua API adapter. Native destroy/GY/Hand/faceup and facedown banish/own Deck/opponent Deck outcomes all become opposing faceup Deck. Original watchers fail all seven destinations, effective no-watch/no-reverse controls, exact source/install backups/helper/manifest/parity. Exact same-pattern scan finds only these two. Neutral departure/event/tribute/recruit identities, setting/control change/other effects/full-card/live Omega separate.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-avatar-copy-identity-batch.json';batch=json.loads(p.read_text());assert batch['status']=='AVATAR_COPIED_SOURCE_AND_TARGET_LABEL_REPAIRED' and batch['same_pattern_identity']==batch['same_pattern_label']==[244790302]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  for i,v in enumerate(d['results']):
   if v['logs']:assert run['control']=='old-source' and i==2 and run['expected_assertion_logs']==[2] and all(l['type'] in [0,2] for l in v['logs']) and any('assertion failed!' in l['message'] and 'c900008301.lua' in l['message'] for l in v['logs'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c244790302.lua';item=json.loads((OUT/'avatar-copy-state-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==244790302)
 row['repair']+=' Copied activation source now retrieved from stored effect handler independently of copied target list; target-time numeric label propagated to stored effect. Native original-source failures for non-target copy, target metadata, copied-source removal and copied-recipient removal; corrected full Avatar/installed metadata/corrected transport/no Lua API adapter applies actual independent500damage/target destruction/label907 plus label-object state. Actual CL2 source disappearance cancels application, recipient loss retains independent damage. Exact backups/helper/manifest/parity; old explicit metadata assertion logs retained only expected case2; omitted-copy/response controls. Exact retrieval/no-op-label scan only Avatar, adjacent copy implementations inspected. Earlier independent destroy repair reconciled only through exact new copy-state patch. Field-seeded source/neutral copied Spell and targets; original general Fusion recipe/other copy API edge cases/live Omega remain open.'
 row['avatar_copy_state_batch']=p.name;row['avatar_copy_state_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-destroy-replacement-batch.json';batch=json.loads(p.read_text());assert batch['status']=='AVATAR_AND_SABRE_DESTROY_REPLACEMENT_REPAIRED' and batch['same_pattern_missing_before']==[244790302,248788543,255832330]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['cases'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'destroy-replacement-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  note=' Field destruction replacement now has a value predicate selecting eligible own monsters (Avatar) or equipped monster (Blaze Sabre). Original full-source native effect/battle replacement fails; corrected actual protection/payment and accept/decline pass. Native GY equip on installed field-seeded Seraphina for Sabre; Avatar hidden/wrong-set/wrong-type Deck exclusions and simultaneous opponent-card destruction retained. Exact backups/helper/manifest/parity and previous Avatar stages composed strictly. Same-pattern Shield passes through existing send-replacement fallback and is unchanged. No Lua API adapter/original Fusion history/full-card/live Omega certification.'
  if row:row['repair']+=note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['destroy_replacement_batch']=p.name;row['destroy_replacement_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-adamantios-replacement-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ADAMANTIOS_REPLACEMENT_HANDLER_IDENTITY_REPAIRED' and batch['same_pattern_mismatch']==[259315827]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==5 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259315827.lua';item=json.loads((OUT/'adamantios-replacement-identity-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==259315827 for v in rows)
 rows.append({'passcode':259315827,'name':roster[259315827],'repair':'Leave-field replacement requires handler itself in pending group and eligible; prior same-name filter let an unaffected copy offer replacement and destroy an Equip without protecting affected copy. Full original/two field-seeded copies/current installed metadata/corrected transport/no Lua API adapter: actual Equip setup, native opponent GY-send/banish, affected accept/decline, unaffected exclusion, real REASON_REPLACE Equip destruction. All five original-source cases fail; omitted-payment controls fail both positives. Exact source/install backups/helper/manifest/parity; all eleven send-replacement cards reviewed, other values match their filters/actual equip or explicitly chosen target. Other cards static review only. Original Xyz history/Quick equip/other effects/full-card/live Omega remain unverified.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-adamantios-name-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ADAMANTIOS_THIS_CARD_NAME_RESTRICTION_REPAIRED' and batch['same_pattern']==[259315827]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259315827.lua';item=json.loads((OUT/'adamantios-name-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==259315827)
 row['repair']+=' Removed current-name requirement from handler-only this-card protection. Native Equip then EFFECT_CHANGE_CODE retains original source identity but changed queried code; actual opponent GY-send/banish accept/decline and unaffected-copy exclusion pass. Original affected cases fail; omitted-payment positives fail. Exact backups/helper/manifest/parity, strict prior-identity-stage reconciliation. Same-pattern scan only this card. Original Xyz/Quick equip/full-card/live Omega remain open.';row['adamantios_name_batch']=p.name;row['adamantios_name_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-vylon-aid-interrupted-lock-batch.json';batch=json.loads(p.read_text());assert batch['status']=='VYLON_AID_INDEPENDENT_LIGHT_LOCK_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c238274861.lua';item=json.loads((OUT/'vylon-aid-independent-lock-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();assert not any(v['passcode']==238274861 for v in rows)
 rows.append({'passcode':238274861,'name':roster[238274861],'repair':'Independent also LIGHT-only restriction now applied at resolution before revival feasibility returns. Actual full original activation/current installed metadata/corrected transport with explicit TARGET_CARDS8 mapping: CL2 removes both targets or leaves only one free Main Zone; no revivals but native LIGHT/nonLIGHT summon eligibility and actual summons/expiry correct. Effect/activation negation allow nonLIGHT. Original/no-lock/persistent-lock/block-LIGHT controls; exact backups/helper/manifest/parity. Nineteen same-wording candidates reviewed, Crystal Shards/Bauy Magician/Soleil remain pending native interrupted-summon tests. Explicit API mapping is test-only, not live Omega/full-card certification.','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-independent-summon-locks-batch.json';batch=json.loads(p.read_text());assert batch['status']=='THREE_INDEPENDENT_SUMMON_LOCKS_REPAIRED' and batch['same_pattern_confirmed']==[259366591,220856437,259472680]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert not d['legacy_chaininfo_adapter'] and len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'independent-summon-locks-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  note=' Independent also summon restriction now registered before resolution-time summon feasibility returns. Full original source/native activation costs/current installed metadata/corrected engine/no Lua API adapter: CL2 fills Main Zones and native Chain End clears neutral blockers only after source resolution, prohibited/allowed real summon probes and natural expiry; successful source summons and CL2 activation/effect negation controls. Crystal Shards discard/Bauy source and Hand banish/Soleil three face-down Extra banish asserted. Original/no-lock/persistent/block-allowed controls effective. Exact backups/helper/manifest/parity. Neutral Link effect-summon probe is not original/proper Link history. Other effects/full-card/live Omega remain open.'
  if row:row['repair']+=note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['independent_summon_lock_batch']=p.name;row['independent_summon_lock_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 row=next(v for v in rows if v['passcode']==238274861);row['repair']+=' Three same-pattern suspects now confirmed and repaired in current-independent-summon-locks-batch.json; earlier pending classification is historical.'
 p=OUT/'current-underroot-projected-space-batch.json';batch=json.loads(p.read_text());assert batch['status']=='UNDERROOT_SELF_BANISH_PROJECTED_SPACE_REPAIRED' and batch['same_pattern_confirmed']==[238272437]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==5 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c238272437.lua';item=json.loads((OUT/'underroot-projected-space-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==238272437),None)
 note=' Activation capacity projects removal of handler banished as original cost; full Main field with field source now legal, Hand source/full field and no candidate excluded. Full original/native self-banish cost and Deck recruit moves/current installed metadata/corrected public engine/no Lua API adapter. Original full-field case fails; omitted-cost positives fail. Exact backups/helper/manifest/parity. Six actual self-banish/raw-zone cost-target pairs reviewed; other five effect ranges are GY or Hand/GY and free no field zone, no second bug. Static other-card review only; non-Tuner/recovery/other effects/full-card/live Omega remain unverified.'
 if row:row['repair']+=note
 else:
  row={'passcode':238272437,'name':roster[238272437],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
 row['underroot_space_batch']=p.name;row['underroot_space_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-send-arrival-batch.json';batch=json.loads(p.read_text());assert batch['status']=='NETHER_AND_ZOSTERA_THEN_BANISH_ARRIVAL_REPAIRED' and batch['same_pattern_confirmed']==[238272436,284636661]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['cases'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'send-arrival-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  note=' Then-banish followup requires actual Deck-monster GY arrival, not only SendtoGrave operated count. Full original/current installed metadata/corrected public engine/no Lua API adapter: original Nether native summon/SS trigger or pre-Set Zostera native Trap Monster activation, Macro-style native GY redirect preserves existing GY card instead of incorrectly banishing it. Normal send/followup and selected newly sent Nether card, empty GY/optional Zostera decline retained. Original redirect failures and omitted-followup controls; exact source/install backups/helper/manifest/parity. Five same-function send/remove candidates reviewed: one already guards arrival, others separate Fusion material groups or mutually exclusive costs. Other-card review static; other clauses/full-card/live Omega unverified.'
  if row:row['repair']+=note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['send_arrival_batch']=p.name;row['send_arrival_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-shuffle-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='NETHER_TRICERON_FACEDOWN_BANISH_SHUFFLE_REPAIRED' and batch['same_pattern_confirmed']==[238272436,259640854]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==2 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  for v in d['results']:
   if run['known_compatibility_failure']:assert any('Passed invalid CHAININFO flag' in x['message'] for x in v['logs']) and all(x['type'] in [0,2] for x in v['logs'])
   else:assert not v['logs']
 for item in json.loads((OUT/'shuffle-visibility-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  note=' Name/archetype-specific shuffle filter excludes face-down banishment while preserving GY/faceup banished resources. Original native menus offered hidden cards; corrected menus and actual Deck moves pass. Nether original self-banish cost and neutral field Fusion/Synchro type count, archetype and explicit named Trap whitelist; Triceron original native Quick cost/target destruction/Trap shuffle with explicit TARGET_CARDS8 test mapping. Unadapted invalid-flag failures retained separately, no production constant change. Original/omitted-shuffle controls, exact backups/helper/manifest/parity; previous Nether arrival repair reconciled only through exact new visibility guard. Three other raw filters are only GY/Deck callers. Original Fusion/Synchro recipes/full-card/live Omega remain open.'
  if row:row['repair']+=note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['shuffle_visibility_batch']=p.name;row['shuffle_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-nether-move-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='NETHER_HIDDEN_BANISH_MONSTER_EVENT_REPAIRED' and batch['same_pattern_before']==[{'passcode':238272436,'callback':'mvfilter'}]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c238272436.lua';item=json.loads((OUT/'nether-move-visibility-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==238272436)
 row['repair']+=' Monster-specific event/target filter excludes face-down banishment. Native real Deck monster GY/faceup banishment still moves target/summons source; hidden banishment with Hand/GY/banished source and nonmonster GY events excluded, real hidden position/destinations asserted. Original hidden-event failures and omitted-move controls. Full original/current installed metadata/corrected engine/no Lua API adapter; exact backups/helper/manifest/parity and strict earlier shuffle/arrival-stage reconciliation. Same EVENT_MOVE/REMOVE raw monster+banishment filter scan only Nether. Source-identity ruling/runtime probe remains unresolved; no full-card/live Omega conclusion.';row['nether_move_visibility_batch']=p.name;row['nether_move_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-triceron-independent-shuffle-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TRICERON_INDEPENDENT_OPTIONAL_SHUFFLE_REPAIRED' and batch['pending_native_confirmation']==[224822244,259429721]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==7 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  for i,v in enumerate(d['results']):
   if run['known_compatibility_failure'] and i in run['expected_failures']:assert any('Passed invalid CHAININFO flag' in x['message'] for x in v['logs']) and all(x['type'] in [0,2] for x in v['logs'])
   else:assert not v['logs']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259640854.lua';item=json.loads((OUT/'triceron-independent-shuffle-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==259640854)
 row['repair']+=' Independent optional also-after-that shuffle no longer gated by destroyed count2. Full original/current installed metadata/corrected engine with explicit TARGET_CARDS8 test mapping: actual half-LP4000 cost, native CL2 removes/protects one/both targets, zero/partial destruction and real shuffle; decline/effect-negation exclude shuffle. Original/omitted-shuffle controls; unadapted invalid-flag compatibility failures separate. Exact backups/helper/manifest/parity, strict prior visibility-stage reconciliation. Six same-wording cards reviewed; Rollo/Champion remain pending native confirmation, not fixed by assumption. No original Fusion/full-card/live Omega conclusion.';row['triceron_independent_shuffle_batch']=p.name;row['triceron_independent_shuffle_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-independent-followups-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ROLLO_CHAMPION_INDEPENDENT_FOLLOWUPS_REPAIRED' and batch['same_wording_confirmed']==[224822244,259429721]
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==5 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'independent-followups-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  note=' Independent also-after-that followup no longer depends on previous operation success. Full original/current installed metadata/corrected public engine/no Lua API adapter: Champion native GY Quick summon/equip and column destruction survives target banish/Set/full SZone; Rollo actual opponent-turn attack/battle trigger, source banish/Deck prohibition still topdecks opponent monster. Normal equip/faceup opposing Deck transfer and actual Deck-top position retained; effect negation/removed attacker exclusions, original/omitted-followup controls. Exact backups/helpers/manifest/source-install parity. Resolves Triceron same-wording suspects; earlier dependent operations unchanged. Initially field/GY sources and neutral supports, other clauses/full-card/live Omega unverified.'
  if row:row['repair']+=note
  else:
   row={'passcode':code,'name':roster[code],'repair':note.strip(),'script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['independent_followups_batch']=p.name;row['independent_followups_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 row=next(v for v in rows if v['passcode']==259640854);row['repair']+=' Rollo/Champion same-wording suspects now confirmed and repaired in current-independent-followups-batch.json; earlier pending label is historical.';row['followup_suspects_resolved_batch']=p.name;row['followup_suspects_resolved_batch_sha256']=sha(p)
 p=OUT/'current-champion-hand-arrival-batch.json';batch=json.loads(p.read_text());assert batch['status']=='CHAMPION_ACTUAL_HAND_ADDITION_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  if run['known_compatibility_failure']:assert all(v['logs'] and 'nil value' in v['failure'] for v in d['results'])
  else:assert all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259429721.lua';item=json.loads((OUT/'champion-hand-arrival-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==259429721)
 row['repair']+=' Hand effect now requires actual target Hand arrival before source summon. Original Fusion genuinely dumped Extra-to-GY then returned to Extra excludes source summon; Main Deck Hand-add/source summon and direct revival retained. Original/omitted-source controls; exact backups/helper/manifest/parity, strict prior-column reconciliation. Original Link/Synchro helper compatibility failures separate; Scion238276248 same-pattern suspect pending. No full-card/live Omega certification.';row['hand_arrival_batch']=p.name;row['hand_arrival_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-scion-hand-arrival-batch.json';batch=json.loads(p.read_text());assert batch['status']=='SCION_ACTUAL_HAND_ADDITION_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==3 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c238276248.lua';item=json.loads((OUT/'scion-hand-arrival-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==238276248),None)
 if row is None:
  row={'passcode':238276248,'name':roster[238276248],'repair':'','script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
 row['repair']+=' GY recovery requires actual Hand arrival before optional self revival. Original Scion/native source and official Phoenix destruction, own Standby/Phoenix activation; neutral Nephthys Link genuinely dumped Extra-to-GY then returned Extra excludes revival, Main Deck recovery/revival and decline retained. Original/omitted-revival controls; helper/backups/manifest/parity, corrected public transport/no Lua API adapter. Neutral recipient recipe and live Omega unverified.';row['hand_arrival_batch']=p.name;row['hand_arrival_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 row=next(v for v in rows if v['passcode']==259429721);row['repair']+=' Scion same-pattern suspect subsequently confirmed and repaired in current-scion-hand-arrival-batch.json; pending label above is historical.';row['same_pattern_resolved_batch']=p.name;row['same_pattern_resolved_batch_sha256']=sha(p)
 p=OUT/'current-trumpet-destroyed-origin-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TRUMPET_DESTROYED_MONSTER_ORIGIN_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==8 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c284639724.lua';item=json.loads((OUT/'trumpet-destroyed-origin-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==284639724)
 row['repair']+=' Hand summon destruction event now requires previous MZone: own faceup/facedown destroyed monsters accepted; Hand/Deck/SZone/opponent/wrong-set/nonPendulum excluded. Original full source/current installed metadata/corrected public transport/no Lua API adapter, native actual destruction and summon outcomes/original/omitted-summon controls. Exact backups/helper/manifest/parity, strict older capacity-stage reconciliation. Cassiopeia/Carina raw history filters pending same-pattern confirmation; full-card/live Omega open.';row['destroyed_origin_batch']=p.name;row['destroyed_origin_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-eldora-destroyed-history-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ELDORA_MONSTER_HISTORY_AND_REASON_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==11 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'eldora-destroyed-history-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' Destroyed-monster history requires previous MZone; excludes destroyed Hand/Deck/Spells and mixed one-monster groups. Effect-origin uses reason-effect handler so own Eldora destruction qualifies. Original full source/current installed metadata/corrected public transport/no Lua API adapter, actual both original Hand summon procedures after native own faceup/facedown MZone destruction by opponent or neutral Eldora-identity effect. Self nonEldora/opponent monsters excluded; original/omitted-history controls, exact backups/helper/manifest/parity. Neutral reason actors, not original Eldora effects/full-card/live Omega certification.';row['destroyed_history_batch']=p.name;row['destroyed_history_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 row=next(v for v in rows if v['passcode']==284639724);row['repair']+=' Cassiopeia/Carina same-pattern suspects subsequently confirmed/repaired in current-eldora-destroyed-history-batch.json; pending label above historical.';row['same_pattern_resolved_batch']=p.name;row['same_pattern_resolved_batch_sha256']=sha(p)
 p=OUT/'current-krawler-effect-origin-batch.json';batch=json.loads(p.read_text());assert batch['status']=='KRAWLER_EFFECT_ORIGIN_AND_FACEDOWN_CARD_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['count'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259322868.lua';item=json.loads((OUT/'krawler-effect-origin-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==259322868),None)
 if row is None:
  row={'passcode':259322868,'name':roster[259322868],'repair':'','script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
 row['repair']+=' GY position trigger reads reason effect and requires Krawler monster effect; actual target changes both directions, Krawler Spell/nonKrawler monster excluded, native paid fixed Link preserves Link-material branch. Hand procedure now searches facedown cards on entire field; actual own/opponent monster/Spell/Trap releases and original summon, faceup excluded. Full source/current installed metadata/corrected public transport/no Lua API adapter, original/omitted-position/release controls, exact backups/helper/manifest/parity. Neutral actors/fixed Link recipe and first procedure use, other clauses/full-card/live Omega unverified.';row['effect_origin_batch']=p.name;row['effect_origin_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-arktos-extra-columns-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ARKTOS_EXTRA_COLUMNS_AND_FACEDOWN_SUMMON_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==8 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259537607.lua';item=json.loads((OUT/'arktos-extra-column-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==259537607)
 row['repair']+=' Automatic movement maps opposing Extra Monster Zones to physical columns and accepts facedown opposing summons. Original source actually Pendulum Summoned, native paid fixed opposing Link material/type/completion, independent GetColumnGroup witness; both Extra zones, direction/same/blocked/edge and actual facedown Main summons. Original/omitted-movement controls; exact helper/backups/manifest/parity, strict historical source reconciliation. Corrected public transport/no Lua API adapter, neutral Link recipe and full-card/live Omega qualifications retained.';row['extra_columns_batch']=p.name;row['extra_columns_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-coin-defense-requirement-batch.json';batch=json.loads(p.read_text());assert batch['status']=='COIN_DEFENSE_MONSTERS_REQUIREMENT_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==8 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c284639718.lua';item=json.loads((OUT/'coin-defense-requirement-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==284639718)
 row['repair']+=' Hand-banish condition counts any own faceup Defense Terrarumian monsters, not only Pendulum; separate ATK-reduction Pendulum filter preserved. Full original/current installed metadata/corrected public transport/no Lua API adapter: actual destruction, random Hand temporary banishment/native End return with ordinary/mixed/Pendulum pairs. One/opponent/attack/wrong-set/facedown second excludes Hand and retains actual GY route. Original/omitted-Hand-banish controls, exact backups/helper/manifest/parity and strict prior capacity/limit-stage reconciliation. Neutral count identities; full-card/live Omega remain open.';row['defense_requirement_batch']=p.name;row['defense_requirement_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-terrarumian-field-set-capacity-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TERRARUMIAN_FIELD_SET_CAPACITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['count'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'terrarumian-field-set-capacity-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' Field Spell Set uses separate Field Zone despite full ordinary SZone row; ordinary Spells/Traps still need row capacity. Original Sword Normal Summon/Deck Set and Nerve actual PZone activation/destruction/self summon/GY followup with native CL2 zone disable; actual original Terrarium Field Zone Set, open Trap/full Trap/mixed selection boundaries. Corrected public transport/no Lua API adapter, original/no-Set controls. Exact backups/helper/manifest/parity and strict prior capacity/count-stage reconciliation; Growth same-pattern suspect pending. Other effects/full-card/live Omega open.';row['field_set_capacity_batch']=p.name;row['field_set_capacity_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-growth-field-set-capacity-batch.json';batch=json.loads(p.read_text());assert batch['status']=='GROWTH_FIELD_SET_CAPACITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c284636589.lua';item=json.loads((OUT/'growth-field-set-capacity-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==284636589),None)
 if row is None:
  row={'passcode':284636589,'name':roster[284636589],'repair':'','script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
 row['repair']+=' GY Set permits separate Field Zone despite full ordinary row, while normal Spells/Traps still require row space. Full Growth/Terrarium/current installed metadata/corrected public transport/no Lua API adapter, actual GY ignition/self-banish cost/targeted Field Spell Set and open Trap/full Trap/mixed-target boundaries; original/no-Set controls. Exact backups/helper/manifest/parity, same-pattern Sword/Nerve suspect resolved. Other effects/full-card/live Omega remain open.';row['field_set_capacity_batch']=p.name;row['field_set_capacity_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-harpie-field-set-capacity-batch.json';batch=json.loads(p.read_text());assert batch['status']=='HARPIE_FIELD_SET_CAPACITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259794136.lua';item=json.loads((OUT/'harpie-field-set-capacity-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==259794136),None)
 if row is None:
  row={'passcode':259794136,'name':roster[259794136],'repair':'','script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
 row['repair']+=' Field Spell Set uses separate Field Zone despite full ordinary row. Original Cyber Dancer/installed metadata, original official Hunting Ground/pinned metadata, corrected public transport/no Lua API adapter; actual source field-to-GY trigger/Deck Field Spell Set with five backrow. Listed neutral GY Trap baseline/full-row exclusion/mixed menu; original/no-Set controls, exact backups/helper/manifest/parity. Actual alias metadata retained; other original GY code-list recipients/full-card/live Omega unverified.';row['field_set_capacity_batch']=p.name;row['field_set_capacity_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-ivy-battle-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='IVY_BATTLE_ARCHETYPE_VISIBILITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==2 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c284639722.lua';item=json.loads((OUT/'ivy-battle-visibility-repair-files.json').read_text())['files'][0];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==284639722)
 row['repair']+=' Battle activation lock only recognizes faceup archetype participants: native opponent Trap available before hidden defender flips, unavailable after actual battle flip, restored after Damage Step end. Full original/current installed metadata/corrected public transport/no Lua API adapter, actual Hand/PZone placement and natural battle, faceup baseline/original/no-lock controls. Exact backups/helper/manifest/parity and strict capacity-stage reconciliation. Konami Performapal Ballad FAQ analogy, not direct custom-card ruling; Galactican250829750 pending same-pattern confirmation. Other clauses/full-card/live Omega open.';row['battle_visibility_batch']=p.name;row['battle_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-continuous-condition-contract-batch.json';batch=json.loads(p.read_text());assert batch['status']=='CONTINUOUS_CONDITION_PLAYER_AND_BATTLE_VISIBILITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['count'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  for i,v in enumerate(d['results']):
   if str(i) in run['expected_script_errors']:assert v['logs'] and any(run['expected_script_errors'][str(i)] in x['message'] for x in v['logs']) and all(x['type'] in [0,2] for x in v['logs'])
   else:assert not v['logs']
 for item in json.loads((OUT/'continuous-condition-contract-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' Continuous field condition obtains player from handler; no absent tp callback argument. Grounds additionally requires faceup battle participants: native Continuous Spell activation/attack/hidden reveal interval, player-only intermediate/omitted-lock controls. Candee native Candy counter, actual ATK loss/opponent ignition exclusion with no-counter/GY-source/own-target boundaries and omitted ATK/lock controls. Original script-error failures retained; full originals/current installed metadata/corrected public transport/no Lua API adapter in passing scope. Grounds empty own Deck/Station resources avoids unrelated filter; original IsFaceupEx failure separately retained. Exact backups/helpers/manifest/parity. Named initial FIELD-condition scan found these two; other effects/full-card/live Omega open.';row['condition_contract_batch']=p.name;row['condition_contract_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 row=next(v for v in rows if v['passcode']==284639722);row['repair']+=' Grounds same-pattern suspect subsequently confirmed and repaired in current-continuous-condition-contract-batch.json; earlier pending label historical.';row['same_pattern_resolved_batch']=p.name;row['same_pattern_resolved_batch_sha256']=sha(p)
 p=OUT/'current-terrarumian-condition-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TERRARUMIAN_PRIMARY_FACEUP_CONDITION_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==32 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for item in json.loads((OUT/'terrarumian-condition-visibility-repair-files.json').read_text())['files']:
  code=item['passcode'];source=ROOT/'public/CCG Downloads/CCG_Scripts'/item['file'];assert source_hash_matches(source,item['before_sha256']) and source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();row=next(v for v in rows if v['passcode']==code)
  row['repair']+=' Primary Pendulum own-archetype-monster condition requires faceup. Full original/current installed metadata/corrected public transport/no Lua API adapter, native Hand-to-PZone and activation menus: hidden alone/hidden plus opponent excluded, own faceup/additional faceup allowed. Cushion different OR condition unchanged; native comparison controls. Original14/no-condition17 semantic failures; exact backups/helper/manifest/parity, strict older per-card repair-stage reconciliation. Analogous official Six Samurai control-family ruling inferred, not custom FAQ. Activation eligibility only; other destruction-resource/resolution/full-card/live Omega scopes unchanged.';row['condition_visibility_batch']=p.name;row['condition_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-trumpet-destroyed-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TRUMPET_DESTROYED_PREVIOUS_VISIBILITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==8 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c284639724.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_trumpet_visibility_source(source);row=next(v for v in rows if v['passcode']==284639724)
 row['repair']+=' Previous faceup position required for archetype-destruction Hand trigger. Official Dinomist Eruption ruling analogy excludes hidden effect destruction; earlier origin-suite hidden positive is superseded and invalid eligibility evidence. Current full-source native faceup positive/hidden and all previous origin negatives, before-visibility and no-summon controls; no actual battle-flip/live Omega/full-card claim.';row['destroyed_visibility_batch']=p.name;row['destroyed_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-terrarumian-destroy-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TERRARUMIAN_DESTRUCTION_RESOURCE_VISIBILITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==24 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for code in range(284639717,284639725):
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_terrarumian_destroy_source(source);row=next(v for v in rows if v['passcode']==code)
  row['repair']+=' Archetype-specific destruction resource requires faceup; hidden Spell/monster selection excluded, visible Spell retained in actual native primary resolution selection prompt for all eight. Original16 hidden selection failures, exact backups/helper/manifest/parity and strict prior-stage composition. Official True Draco Apocalypse faceup archetype-destruction target note plus Infernoid Devyaty hidden archetype-name ruling support inferred custom semantics. No new full resolution or live Omega/full-card claim.';row['destroy_resource_visibility_batch']=p.name;row['destroy_resource_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-trumpet-battle-flip-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TRUMPET_BATTLE_DAMAGE_STEP_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c284639724.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_trumpet_damage_source(source);row=next(v for v in rows if v['passcode']==284639724)
 row['repair']+=' Hand destruction trigger explicitly permits Damage Step. Natural opponent battle destroys initial faceup or actually battle-flipped own Pendulum defender, native faceup Extra move and actual Hand summon verified; wrong-set/nonPendulum exclusions. Original-source/no-summon controls each fail both positives. Previous hidden-effect-destruction exclusion remains unchanged. Exact backups/helper/manifest/parity, strict historical composition; no full-card/live Omega claim.';row['damage_step_batch']=p.name;row['damage_step_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-murugan-battle-trigger-batch.json';batch=json.loads(p.read_text());assert batch['status']=='MURUGAN_BATTLE_DAMAGE_STEP_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c247755869.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_murugan_damage_source(source);row=next(v for v in rows if v['passcode']==247755869)
 row['repair']+=' GY destruction trigger permits Damage Step. Natural opponent battle/actual defender flip/destruction and GY-to-Hand recovery with native2000LP followup; nonPendulum archetype positive and wrong-set negative, original/no-recover controls. Exact backups/helper/manifest/parity and strict earlier source reconciliation; initial GY source, no full-card/live Omega claim.';row['damage_step_batch']=p.name;row['damage_step_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-octantis-battle-trigger-batch.json';batch=json.loads(p.read_text());assert batch['status']=='OCTANTIS_BATTLE_DAMAGE_STEP_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c235051048.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_octantis_damage_source(source);assert not any(v['passcode']==235051048 for v in rows)
 rows.append({'passcode':235051048,'name':roster[235051048],'repair':'GY archetype destruction trigger explicitly permits Damage Step. Natural opponent battle/actual defender flip/destruction, real GY source banishment cost and neutral Hand recipient summon; nonPendulum archetype positive/wrong-set negative, original/no-recruit controls. Exact backups/helper/manifest/parity; initial GY source, original alternative source summon procedure/other effects/full-card/live Omega remain open.','script_sha256':sha(source),'current_script_sha256':sha(source),'damage_step_batch':p.name,'damage_step_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-destroyed-previous-identity-batch.json';batch=json.loads(p.read_text());assert batch['status']=='DESTROYED_PREVIOUS_VISIBILITY_FILTERS_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['count'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all((len(v['logs'])==1 and v['logs'][0]['type']==1 and v['logs'][0]['message'].startswith('IdentityPredicate:')) if run['kind']=='predicate' else not v['logs'] for v in d['results'])
 for code in [235051048,247755869,239935098]:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_previous_visibility_source(source);row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','script_sha256':sha(source),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' Destruction identity filter requires previous faceup position: native saved set/type/attribute cache recognizes hidden card identity. Exact original filters called during actual native EVENT_DESTROYED by neutral observer; faceup/hidden/wrong-set and Hydra WATER Reptile controls, original4 failures. Callback identity scope only, Deck source instances; not full trigger/operation/live Omega certification. Exact backups/helper/manifest/parity; strict earlier Damage Step and Spirit Dragon stages retained.';row['previous_visibility_batch']=p.name;row['previous_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-destroy-resource-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='DESTRUCTION_RESOURCE_VISIBILITY_FILTERS_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==19 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(len(v['logs'])==1 and v['logs'][0]['type']==1 and v['logs'][0]['message'].startswith('IdentityPredicate:') for v in d['results'])
 for code in [238276248,284636589,247755871]:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_resource_visibility_source(source);row=next(v for v in rows if v['passcode']==code)
  row['repair']+=' Archetype-specific destruction resource excludes hidden field monsters; Scion/Growth Hand resources retained and Jarita generic hidden Spell/Trap retained. Exact original filters called in neutral Spell operation with native Hand/MZone/SZone resources and actual destruction; original3 hidden failures. Original source instances in banishment avoid independent Jarita Xyz helper compatibility failure. Callback eligibility only, not full original trigger/operation/live Omega; exact backups/helper/manifest/parity and strict historical stages.';row['resource_visibility_batch']=p.name;row['resource_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-field-destroy-damage-step-batch.json';batch=json.loads(p.read_text());assert batch['status']=='FIELD_DESTRUCTION_DAMAGE_STEP_FLAGS_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for code in [238276251,251236672]:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_field_destroy_damage_source(source);assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'Optional FIELD destruction trigger explicitly permits Damage Step. Original sources/current installed metadata/corrected public transport/no Lua API adapter. Natural opponent battle/actual defender flip/destruction; Brazier actually destroys opposing attacker with archetype/wrong-set boundary, Laplace gives surviving own monster500ATK/DEF for generic own destruction. Original-source/omitted-outcome controls, exact backups/helper/manifest/parity. Initially faceup source/neutral combatants; other clauses/limits/expiry/full-card/live Omega remain open.','script_sha256':sha(source),'current_script_sha256':sha(source),'damage_step_batch':p.name,'damage_step_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-tristegsaurus-damage-step-batch.json';batch=json.loads(p.read_text());assert batch['status']=='TRISTEGSAURUS_DAMAGE_STEP_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  if run['known_compatibility_failure']:assert all(v['logs'] and 'invalid CHAININFO flag' in v['failure'] for v in d['results'])
  else:assert all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c244162598.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_tristegsaurus_damage_source(source);assert not any(v['passcode']==244162598 for v in rows)
 rows.append({'passcode':244162598,'name':roster[244162598],'repair':'FIELD Battle Phase destruction trigger explicitly permits Damage Step. Natural battle/defender flip/destruction, actual own and opposing target destruction, each-GY summons to respective owners. Explicit public TARGET_CARDS8 test-only mapping; unadapted invalid CHAININFO flag retained and production constant unchanged. Original-source/no-outcome controls. Exact backup/helper/manifest/parity; initially field source/neutral combatants, original Synchro recipe/proper source history/shared uses/interruptions/other clauses/full-card/live Omega remain open.','script_sha256':sha(source),'current_script_sha256':sha(source),'damage_step_batch':p.name,'damage_step_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-observatory-damage-step-batch.json';batch=json.loads(p.read_text());assert batch['status']=='OBSERVATORY_DAMAGE_STEP_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==4 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  if run['known_compatibility_failure']:assert all((v['logs'] and 'invalid CHAININFO flag' in v['failure']) if i==0 else (not v['logs'] and not v['failure']) for i,v in enumerate(d['results']))
  else:assert all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c238274862.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_observatory_damage_source(source);assert not any(v['passcode']==238274862 for v in rows)
 rows.append({'passcode':238274862,'name':roster[238274862],'repair':'Optional destruction trigger permits Damage Step. Natural battle/actual neutral Flip destroys ordinary faceup S/T during Damage Step; actual neutral GY Vylon monster moves to SZone and native Equip packet attaches to own Vylon recipient before end. Hidden S/T/wrong GY/no-resource negatives, original-source/no-equip controls. Explicit test-only TARGET_CARDS8; unadapted invalid flag kept separate, production constant unchanged. Exact backups/helper/manifest/parity; initial source and neutral setup, activation/search/material/limits/other clauses/full-card/live Omega remain open.','script_sha256':sha(source),'current_script_sha256':sha(source),'damage_step_batch':p.name,'damage_step_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-brazier-destroyed-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='BRAZIER_DESTROYED_VISIBILITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['count'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c238276251.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_brazier_visibility_source(source);row=next(v for v in rows if v['passcode']==238276251)
 row['repair']+=' Destruction identity condition excludes hidden field archetype Monster/S-T while retaining faceup/Hand/Deck events. Full original native trigger and actual opposing target destruction, original hidden2/no-destroy4 controls; native battle/flip replay preserves Damage Step behavior. Exact backups/helper/manifest/parity and strict earlier Damage Step reconstruction. Direct eg:IsExists(Card.IsSetCard) roster scan found only this site; not whole-card/live Omega certification.';row['destroyed_visibility_batch']=p.name;row['destroyed_visibility_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-prayer-visibility-batch.json';batch=json.loads(p.read_text());assert batch['status']=='PRAYER_FIELD_RESOURCE_AND_DESTROYED_VISIBILITY_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['count'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c238276252.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_prayer_visibility_source(source);assert not any(v['passcode']==238276252 for v in rows)
 rows.append({'passcode':238276252,'name':roster[238276252],'repair':'Field Level8 archetype destruction resource requires faceup while Hand remains legal; Ritual-destruction identity requires previous-faceup for field origins while Hand/Deck remain legal. Full original reused native search/pair harnesses, actual banish cost/recovery and resource destruction/two summons/negation/End destruction, original/omitted outcome controls. Corrected transport/current installed metadata/no Lua API adapter. Exact backups/helper/manifest/parity; initial neutral Ritual/resources/recipients, original Ritual procedures/shared limits/other targets/full-card/live Omega remain open.','script_sha256':sha(source),'current_script_sha256':sha(source),'visibility_batch':p.name,'visibility_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-rigel-material-atk-batch.json';batch=json.loads(p.read_text());assert batch['status']=='RIGEL_COMBINED_LINK_RATING_ATK_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==3 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  if run['known_compatibility_failure']:assert all(v['logs'] and 'GetMustMaterial' in v['failure'] for v in d['results'])
  else:assert all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c215853847.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_rigel_rating_source(source);assert not any(v['passcode']==215853847 for v in rows)
 rows.append({'passcode':215853847,'name':roster[215853847],'repair':'ATK combined material Link Ratings count non-Link as0, not1. Full source effect/current installed metadata/corrected transport, native paid fixed Link4 history with four Effect bodies/mixed genuine Link2/two genuine Link2, actual GetLink material sums0/2/4/proper source status and ATK2000/4000/6000. Original/no-bonus controls; test-only fixed procedure qualification, unadapted general Link helper errors separate. Exact backups/helper/manifest/parity; roster GetLink same-pattern review, other effects/expiry/full-card/live Omega remain open.','script_sha256':sha(source),'current_script_sha256':sha(source),'link_rating_batch':p.name,'link_rating_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-aldrez-queen-support-batch.json';batch=json.loads(p.read_text());assert batch['status']=='QUEEN_DIFFERENT_NAME_SUPPORT_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['count'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c231892575.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_queen_support_source(source);assert not any(v['passcode']==231892575 for v in rows)
 rows.append({'passcode':231892575,'name':roster[231892575],'repair':'Different-name faceup Aldrez Monster required for Hand summon and battle/effect-target protection. Preserve targeting protection for another Queen when a valid different-name supporter exists. Full source/current installed metadata/corrected transport/no Lua API adapter, native Hand arrival/targeted activation availability/declared attack target menus, original-source failures and effective omitted protections. Same-pattern711 scan matched only Queen. Exact backups/helper/manifest/parity; initial protection source/history, completed battle/search/limits/other clauses/full-card/live Omega remain separate.','script_sha256':sha(source),'current_script_sha256':sha(source),'support_batch':p.name,'support_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-aldrez-revival-damage-step-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ALDREZ_REVIVAL_DAMAGE_STEP_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['count'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  if run['known_compatibility_failure']:assert all(('IsCanOverlay' in v['failure'] and v['logs']) if i in [0,1,2,11,12] else (not v['failure'] and not v['logs']) for i,v in enumerate(d['results']))
  else:assert all(not v['logs'] for v in d['results'])
 for code in [238282350,231129918]:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_aldrez_revival_damage_source(source);assert not any(v['passcode']==code for v in rows)
  rows.append({'passcode':code,'name':roster[code],'repair':'FIELD TO_GRAVE revival trigger permits Damage Step. Paid proper neutral Xyz recipient, actual opponent battle/destruction2000 damage/banish cost/revival, wrong archetype negative and exact original flag failure. Optional Knight either-GY/Rook either-field overlay uses explicit neutral-only missing IsCanOverlay test mapping; unadapted errors retained separately, no ignored errors. Effective outcome/reason/response controls, exact backups/helper/manifest/parity. Whole-roster same-pattern five candidates: these two confirmed; Origins/Matriarch/Underworld pending native review. Original recipes/shared limits/other clauses/full-card/live Omega remain open.','script_sha256':sha(source),'current_script_sha256':sha(source),'damage_step_batch':p.name,'damage_step_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-origins-battle-attachment-batch.json';batch=json.loads(p.read_text());assert batch['status']=='ORIGINS_DAMAGE_STEP_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==2 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  if run['known_compatibility_failure']:assert 'IsCanOverlay' in d['results'][0]['failure'] and d['results'][0]['logs'] and not d['results'][1]['logs']
  else:assert all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c244986323.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_origins_damage_source(source);row=next(v for v in rows if v['passcode']==244986323);row['repair']+=' FIELD TO_GRAVE attachment trigger explicitly permits Damage Step. Actual opponent battle victim to GY and remaining opposing faceup S/T Overlay; own victim negative, original flag/no-attach controls. Explicit neutral field-only missing IsCanOverlay mapping, unadapted failure separate. Exact source/install backups/helper/manifest and strict prior placement/empty-GY repair composition. Initial field source/proper history/general recipe/live Omega remain qualified.';row['damage_step_batch']=p.name;row['damage_step_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 for code,label,batchname,status,count in [(259093260,'matriarch','current-matriarch-battle-revival-batch.json','MATRIARCH_DAMAGE_STEP_REPAIRED',4),(259265448,'underworld','current-underworld-damage-step-batch.json','UNDERWORLD_DAMAGE_STEP_REPAIRED',5)]:
  p=OUT/batchname;batch=json.loads(p.read_text());assert batch['status']==status
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==count and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();(pre_matriarch_damage_source if label=='matriarch' else pre_underworld_damage_source)(source);assert not any(v['passcode']==code for v in rows)
  detail='Native opponent-turn WATER battle-to-GY/Defense revival; own turn/wrong Attribute/actually borrowed opponent-owner negatives. Initially field source/general Synchro/proper source history qualified.' if label=='matriarch' else 'Actual Field Spell activation and legal battle Flip sending Hand Level1 Beast/Winged Beast to GY during Damage Step, actual shuffle/different-name search; wrong Level/race/field-origin negatives.'
  rows.append({'passcode':code,'name':roster[code],'repair':'FIELD TO_GRAVE trigger explicitly permits Damage Step. '+detail+' Full original source/current installed metadata/corrected transport/no Lua API adapter. Original flag/omitted-outcome controls, exact backups/helper/manifest/parity. Narrow five-card scan now repaired; shared limits/interruptions/other effects/full-card/live Omega remain open.','script_sha256':sha(source),'current_script_sha256':sha(source),'damage_step_batch':p.name,'damage_step_batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False})
 p=OUT/'current-underworld-search-interruption-batch.json';batch=json.loads(p.read_text());assert batch['status']=='UNDERWORLD_THEN_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==6 and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259265448.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_underworld_then_source(source);row=next(v for v in rows if v['passcode']==259265448);row['repair']+=' Then-conjunction resolution: retain initial activation search eligibility, but shuffle eligible event card even when CL2 removes the only later Deck search resource. Actual natural battle Flip event, CL2 removals/negations, exact pre-repair failure and effective outcome/response controls. Primary Konami rule and narrow711 same-pattern review recorded. Exact backups/helper/manifest/strict Damage-Step repair composition.';row['then_batch']=p.name;row['then_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 for code,batchname,status,count in [(259265448,'current-underworld-battle-recruit-batch.json','UNDERWORLD_BATTLE_PHASE_REPAIRED',11),(228169392,'current-bael-battle-limit-batch.json','BAEL_BATTLE_PHASE_LIMIT_REPAIRED',2)]:
  p=OUT/batchname;batch=json.loads(p.read_text());assert batch['status']==status
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==count and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_phase_limit_source(source)
  detail='Removed unprinted turn limit from persistent Battle-start recruitment; native extra-Battle Spell produces two Battle starts on one natural turn, each recruits/disposes actual bodies. Exact original fails second recruitment; retained outcome/response/lifecycle/reset controls.' if code==259265448 else 'Printed once-per-Battle-Phase cost flag now prevents repeated material/top-four banishment and resets at Battle end. Paid fixed three-Level1-Tuner Xyz history, actual costs, native two-Battle same-turn reset; exact original overuses effect in both scenarios. General original recipe qualified.'
  row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' '+detail+' Exact approved source/install backups/proposed hashes/patch and strict normalizer in phase-limit-repair-review. Public-engine evidence, not live Omega certification.';row['phase_limit_batch']=p.name;row['phase_limit_batch_sha256']=sha(p);row['current_script_sha256']=sha(source);row['script_sha256']=sha(source)
 p=OUT/'current-shuffle-search-timing-batch.json';batch=json.loads(p.read_text());assert batch['status']=='SHUFFLE_SEARCH_TIMING_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['cases'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for code in [259265448,220749574]:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_shuffle_timing_source(source);row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' Shuffle then search now separates sequential event timing with BreakEffect only after a search resource remains available. Actual optional-when TO_DECK listener misses after search, delayed listener positive; exact prior-source timing failure. Underworld actual CL2 search-resource removal preserves shuffle-only optional listener. Full current effects/installed metadata/corrected transport/no Lua API adapter; original summon/full-card/live Omega remain qualified. Exact backups/helper/manifest and strict repair composition.';row['shuffle_timing_batch']=p.name;row['shuffle_timing_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-nautica-bottom-order-batch.json';batch=json.loads(p.read_text());assert batch['status']=='NAUTICA_BOTTOM_ORDER_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['cases'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures'] and all(not v['logs'] for v in d['results'])
 for code in [220749574,223158720]:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_bottom_order_source(source);row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  detail='Original Hand procedure now offers actual two-card bottom ordering; eligibility/cost/native summon and both requested bottom sequences verified.' if code==220749574 else 'GY effect orders actual Main Deck returns before draw; eligible Extra Deck monsters return to Extra Deck and are excluded only from the Main Deck ordering menu. Initial over-restrictive resource filter corrected using official Favorite Contact FAQ; actual mixed returns/chosen sequences/draw and rejected exclusion fault verified.'
  row['repair']+=' '+detail+' Exact old-source/fault controls and backups/helper/manifest. Explicit test-only SORT_CARD response correction (primary core permutation protocol), original encoder native RETRY retained; no Lua API adapter, no live Omega/full-card claim.';row['bottom_order_batch']=p.name;row['bottom_order_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 for code,name,status,count in [(220749574,'current-scarlet-summon-followup-review.json','SCARLET_NORMAL_SUMMON_ATK_REPAIRED',9),(223158720,'current-backwashing-summon-followup-review.json','BACKWASHING_NORMAL_SUMMON_ATK_REPAIRED',8),(218905439,'current-adventures-summon-followup-review.json','ADVENTURES_NORMAL_SUMMON_ATK_REPAIRED',8),(248946297,'current-exploring-summon-followup-review.json','EXPLORING_NORMAL_SUMMON_ATK_REPAIRED',10),(225109525,'current-evander-summon-followup-review.json','EVANDER_NORMAL_SUMMON_ATK_REPAIRED',8),(259114562,'current-bobbie-summon-followup-review.json','BOBBIE_NORMAL_SUMMON_FOLLOWUPS_REPAIRED',10)]:
  p=OUT/name;batch=json.loads(p.read_text());assert batch['status']==status
  for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
  for run in batch['runs']:
   a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==count and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_normal_zero_source(source);row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' Deferred opponent Normal Summon now applies ATK0 through a one-shot successful-summon listener, preserving source ownership/immunity. Original native effect activation/payment/return or search verified with per-card setup qualifications retained in the batch. Exploring independently preserves Deck-only negation; Evander uses initially-field source and neutral native overlay setup, not original Xyz history proof. Native Normal/Special modes, decline/no-resource, disabled/immune target, leave-field reset and negated summon then revival checked. Exact prior-source failures and rejected pre-summon immunity fault retained. Explicit test-only chain-info mappings where required and transport corrections; no live Omega/full-card claim. Yurei and Oceanica related source candidates remain separately pending. Bobbie additionally defers conditional all-own-Nautica negation with independently effective omitted-ATK/negation controls.';row['normal_zero_batch']=p.name;row['normal_zero_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-sear-native-original-type-review.json';batch=json.loads(p.read_text());assert batch['status']=='NATIVE_SEAR_TYPE_REPAIR_SCOPED_VERIFIED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==3 and all(not v['logs'] for v in d['results']) and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 native=json.loads((OUT/batch['native_postrepair_evidence']).read_text());assert native['source']['245935439']['source_sha256']==hashlib.sha256(pre_necro_deck_cost_source(ROOT/'public/CCG Downloads/CCG_Scripts/c245935439.lua')).hexdigest();assert sha(OUT/native['outcome_screenshot']['artifact'])==native['outcome_screenshot']['sha256']
 row=next(v for v in rows if v['passcode']==245935439);source=ROOT/'public/CCG Downloads/CCG_Scripts/c245935439.lua';assert source.read_bytes()==(FILES/'Scripts/c245935439.lua').read_bytes();pre_sear_native_type_source(source);row['current_script_sha256']=sha(source);row['repair']+=' Native Omega v2.9.306 reproduced nil IsOriginalType in material followup. Exact GetOriginalType bitmask replacement preserves original-monster eligibility; native pre-repair failure retained separately. See current-native-omega-pendulum-session.json for old failure and current-native-omega-sear-postrepair-session.json for actual fresh-process recruitment/placement and original PZone Fusion positive. Full-card/live certification remains open.'
 p=OUT/'current-remaining-normal-summon-review.json';batch=json.loads(p.read_text());assert batch['status']=='REPAIRED_DEFERRED_SUMMON_FAMILY'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['cases'] and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for code in [259844716,259941091,226645052,228040066,214349717]:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_remaining_normal_source(source);row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','script_sha256':sha(source),'batch':p.name,'batch_sha256':sha(p),'installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' '+(batch['findings'][str(code)] if str(code) in batch['findings'] else batch['findings']['metadata'])+' Actual original trigger/integration and exact old-source/independent fault controls; current metadata, no Lua API mapping. Scope remains bounded; full-card/live Omega open.';row['remaining_normal_batch']=p.name;row['remaining_normal_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 p=OUT/'current-yurei-tribute-resolution-review.json';batch=json.loads(p.read_text());assert batch['status']=='YUREI_TRIBUTE_RESOLUTION_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['cases'] and all(not v['logs'] for v in d['results']) and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 source=ROOT/'public/CCG Downloads/CCG_Scripts/c259844716.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_yurei_tribute_source(source);row=next(v for v in rows if v['passcode']==259844716);row['current_script_sha256']=sha(source);row['tribute_resolution_batch']=p.name;row['tribute_resolution_batch_sha256']=sha(p);row['repair']+=' '+batch['finding']+' Primary Konami PSCT punctuation supports effect Tribute after semicolon; exact prior stage composition preserved. Full-card/live Omega remains open.'
 p=OUT/'current-necrovalley-deck-cost-review.json';batch=json.loads(p.read_text());assert batch['status']=='NECROVALLEY_DECK_COST_REPAIRED'
 for dependency,h in batch['runtime_dependencies_sha256'].items():verify_dependency(dependency,h)
 for run in batch['runs']:
  a=OUT/run['artifact'];assert sha(a)==run['sha256'];d=json.loads(a.read_text());assert len(d['results'])==run['cases'] and all(not v['logs'] for v in d['results']) and [i for i,v in enumerate(d['results']) if v['failure']]==run['expected_failures']
 for code in batch['passcodes']:
  source=ROOT/'public/CCG Downloads/CCG_Scripts'/f'c{code}.lua';assert source.read_bytes()==(FILES/'Scripts'/source.name).read_bytes();pre_necro_deck_cost_source(source);row=next((v for v in rows if v['passcode']==code),None)
  if row is None:
   row={'passcode':code,'name':roster[code],'repair':'','installed_matches':True,'full_card_audit':'OPEN','native_omega_verified':False};rows.append(row)
  row['repair']+=' '+batch['finding']+' Exact original cost callback tests only; actual official Necrovalley and cost payments. Sorceress public IsFaceupEx mapping qualified; original full effects/native Omega remain open.';row['necrovalley_deck_cost_batch']=p.name;row['necrovalley_deck_cost_batch_sha256']=sha(p);row['current_script_sha256']=sha(source)
 report={'scope':'Documented script repairs with current source/install parity. Public-engine regressions and explicitly bounded callback/shared-effect evidence are distinguished per row. Not full-card or native Omega certification.', 'fixed_cards_minimum':len(rows),'cards':rows}
 (OUT/'repair-ledger.json').write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8');print(json.dumps({'fixed_cards_minimum':len(rows),'status':'CURRENT_EVIDENCE_VERIFIED'}))
if __name__=='__main__':main()
