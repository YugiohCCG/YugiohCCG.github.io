from pathlib import Path
R=Path.cwd();O=R/'output/fresh-ccg-september';S=R/'scripts'
src=R/'public/CCG Downloads/CCG_Scripts/c214552846.lua';installed=Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts\c214552846.lua')
assert src.read_bytes()==installed.read_bytes()
backup=O/'eldora-before-self-destruction-attribution-repair';backup.mkdir(exist_ok=False)
(backup/src.name).write_bytes(src.read_bytes());(backup/('installed-'+src.name)).write_bytes(installed.read_bytes())
for old,new in [('reason_candidate_reason','reason_repaired'),('reason_candidate_lifecycle','lifecycle_repaired')]:
 for ext in ['.cjs','_batch.py']:
  p=S/('fresh_current_eldora_'+old+ext);t=p.read_text(encoding='utf-8')
  t=t.replace(old,new).replace(old.replace('_','-'),new.replace('_','-'))
  if ext=='.cjs':
   if old.endswith('_reason'):
    t=t.replace("if(control!=='old-wrapper')lua=fs.readFileSync(path.join(ROOT,'scripts/fresh_current_eldora_reason_candidate.lua'),'utf8');", "if(control==='old-wrapper')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/eldora-before-self-destruction-attribution-repair/c214552846.lua'),'utf8');")
   else:
    t=t.replace("lua=fs.readFileSync(path.join(ROOT,'scripts/fresh_current_eldora_reason_candidate.lua'),'utf8');",'')
  else:
   t=t.replace("ROOT/'scripts/fresh_current_eldora_reason_candidate.lua',",'')
   t=t.replace("OUT/'eldora-before-resolution-timing-repair/c214552846.lua'","OUT/'eldora-before-self-destruction-attribution-repair/c214552846.lua'")
   t=t.replace('nine cases/four controls verified.', 'production attribution/lifecycle verified.')
  (S/('fresh_current_eldora_'+new+ext)).write_text(t,encoding='utf-8')
p=S/'fresh_current_eldora_original_operation.cjs'
t=p.read_text(encoding='utf-8').replace("if original then original(ce,cp,cg,cep,cev,cre,cr,crp) end","if not negated and original then original(ce,cp,cg,cep,cev,cre,cr,crp) end")
p.write_text(t,encoding='utf-8')
candidate=(S/'fresh_current_eldora_reason_candidate.lua').read_bytes();src.write_bytes(candidate);installed.write_bytes(candidate)
print('Both source and installed Eldora updated; exact backups saved.')
