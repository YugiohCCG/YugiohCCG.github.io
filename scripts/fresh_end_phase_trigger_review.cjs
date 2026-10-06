'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto');
const root=path.resolve(__dirname,'..');
const baseline=JSON.parse(fs.readFileSync(path.join(root,'output/fresh-ccg-september/baseline-remote.json'),'utf8'));
const results=[];
for(const card of baseline.cards){
 const file=path.join(root,'public/CCG Downloads/CCG_Scripts','c'+card.passcode+'.lua');
 const bytes=fs.readFileSync(file),source=bytes.toString('utf8'),effects=[];
 for(const match of source.matchAll(/(\w+):SetCode\(EVENT_PHASE\s*\+\s*PHASE_END\)/g)){
  const variable=match[1],prefix=source.slice(0,match.index);
  const declarations=[...prefix.matchAll(new RegExp('(?:local\\s+)?'+variable+'\\s*=\\s*Effect.CreateEffect','g'))];
  const start=declarations.length?declarations.at(-1).index:Math.max(0,match.index-600);
  const tail=source.slice(match.index+match[0].length);
  const registration=tail.match(new RegExp('(?:Duel.RegisterEffect\\('+variable+'|\\w+:RegisterEffect\\('+variable+')'));
  const stop=registration?match.index+match[0].length+registration.index+registration[0].length:Math.min(source.length,match.index+400);
  const block=source.slice(start,stop),trigger=block.includes('EFFECT_TYPE_TRIGGER');
  const count=new RegExp(variable+':SetCountLimit').test(block);
  effects.push({line:prefix.split('\n').length,variable,trigger,local_count:count,status:trigger&&!count?'manual_review':'no_missing_local_trigger_count_detected',block});
 }
 results.push({passcode:card.passcode,name:card.name,script_sha256:crypto.createHash('sha256').update(bytes).digest('hex'),effects});
}
const candidates=results.flatMap(r=>r.effects.filter(e=>e.status==='manual_review').map(e=>({passcode:r.passcode,name:r.name,...e})));
const report={scope:'Pinned roster711; heuristic End Phase registration-block scan only. Does not certify effect correctness or prove missing-count defects. Clones/dynamic phase expressions/condition consumption require separate review.',source_revision:baseline.source_revision||baseline.revision,results,candidates};
fs.writeFileSync(path.join(root,'output/fresh-ccg-september/end-phase-trigger-review.json'),JSON.stringify(report,null,2)+'\n');
console.log(JSON.stringify({scanned:results.length,end_phase_blocks:results.reduce((n,r)=>n+r.effects.length,0),manual_review:candidates.map(({passcode,name,line})=>({passcode,name,line}))},null,2));
