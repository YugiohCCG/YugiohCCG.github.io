'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c211964444.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const searched=[{},{trap:true},{grave:true},{grave:true,trap:true},{count:true},{count:true,renewal:true}];
const plans=[
 ...[{control:null,failed:[]},{control:'no-cost',failed:searched},{control:'no-search',failed:searched},{control:'no-count',failed:[{count:true},{count:true,renewal:true}]}].map(p=>({...p,h:'search',cases:9})),
 ...[{control:null,failed:[]},{control:'old-query',failed:[{},{official:true}]},{control:'wrong-handler',failed:[{},{official:true}]},{control:'no-destroy',failed:[{},{official:true},{official:true,noSpace:true},{otherEffect:true}]},{control:'no-relation',failed:[{official:true}]},{control:'any-event',failed:[{official:true},{otherEffect:true}]}].map(p=>({...p,h:'standby',cases:7}))
];
const official=path.join(root,'tmp/omega_scripts/c52904476.lua'),officialHash=hash(official);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_priestess_nephthys_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'priestess-nephthys-'+plan.h+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(official),officialHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'priestess-nephthys-batch.json'),JSON.stringify({scope:'16 focused Priestess search/Standby cases and exact controls; real Omega c52904476 self-summon integration, neutral recipient stats/supporting cards and summon ignoring revive conditions; native Omega/Ritual procedure and other Nephthys integrations remain open',script_sha256:sourceHash,official_script_sha256:officialHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:16,status:'PASS'}));
