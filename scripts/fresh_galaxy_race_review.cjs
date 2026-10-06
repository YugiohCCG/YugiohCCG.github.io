'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto');
const root=path.resolve(__dirname,'..'),baseline=JSON.parse(fs.readFileSync(path.join(root,'output/fresh-ccg-september/baseline-remote.json'),'utf8'));
const results=[];
for(const card of baseline.cards){
 if(!/Galaxy|Celestial Warrior/.test(card.text))continue;
 const file=path.join(root,'public/CCG Downloads/CCG_Scripts','c'+card.passcode+'.lua'),bytes=fs.readFileSync(file),source=bytes.toString('utf8');
 const lines=source.split(/\r?\n/);
 results.push({passcode:card.passcode,name:card.name,text:card.text,script_sha256:crypto.createHash('sha256').update(bytes).digest('hex'),race_evidence:lines.flatMap((text,i)=>/RACE_GALAXY|IsRace\(0x(?:80000000|40000000)\)|IsSetCard\(0x7b\)/i.test(text)?[{line:i+1,text}]:[]),literal_galaxy_archetype_gate:/IsSetCard\(0x7b\)/i.test(source),status:'source_review_only',remaining:'Full effects/material procedures/token metadata and runtime behavior not certified by this scan.'});
}
const report={scope:'All711 pinned texts searched; Galaxy/Celestial Warrior keyword subset source evidence. Named aliases/complex predicates require manual reading; no full-card certification.',mapping_source:'scripts/sync_omega_ccg_db.py',expected_races:{Galaxy:'0x80000000','Celestial Warrior':'0x40000000'},results};
fs.writeFileSync(path.join(root,'output/fresh-ccg-september/galaxy-race-review.json'),JSON.stringify(report,null,2)+'\n');
console.log(JSON.stringify({roster:baseline.cards.length,reviewed:results.length,literal_archetype_gate:results.filter(r=>r.literal_galaxy_archetype_gate).map(r=>r.passcode)},null,2));
