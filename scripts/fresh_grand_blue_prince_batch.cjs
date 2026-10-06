'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c259937946.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'old-limit',failed:[{}]},{control:'no-revival',failed:[{},{fusion:true}]}].map(p=>({...p,h:'revival',artifact:'revival',cases:2}));
plans.push(...[{control:null,failed:[]},{control:'any-controller',failed:[{opponentPrincess:true},{opponentGrandBlue:true},{lentPrincess:true},{lentGrandBlue:true}]},{control:'any-set',failed:[{wrongSet:true}]},{control:'any-princess',failed:[{wrongSet:true},{wrongPrincess:true}]}].map(p=>({...p,h:'materials',cases:11})));
plans.push({control:'owner-instead',failed:[{borrowedPrincess:true},{borrowedGrandBlue:true},{lentPrincess:true},{lentGrandBlue:true}],h:'materials',cases:11});
plans.push(...[{control:null,failed:[]},{control:'any-attribute',failed:[{wrongAttribute:true}]},{control:'no-negate',failed:[{},{sourceGrave:true}]},{control:'attack-position',failed:[{},{sourceGrave:true}]},{control:'no-revive',failed:[{},{sourceGrave:true}]}].map(p=>({...p,h:'water',cases:6})));
plans.push(...[{control:null,failed:[]},{control:'no-shuffle',failed:[{},{opponent:true},{decline:true},{wrongSet:true},{noDeckTarget:true}]},{control:'no-send',failed:[{},{opponent:true}]},{control:'any-set',failed:[{wrongSet:true},{noDeckTarget:true}]}].map(p=>({...p,h:'quick',cases:6})));
plans.push(...[{control:null,failed:[]},{control:'slow-effect',failed:[{},{opponent:true},{decline:true},{wrongSet:true},{noDeckTarget:true}]}].map(p=>({...p,h:'opponent',cases:6})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{},{opponent:true},{renewal:true},{opponent:true,renewal:true}]},{control:'no-renewal',failed:[{renewal:true},{opponent:true,renewal:true}]}].map(p=>({...p,h:'quick_count',artifact:'quick-count',cases:4})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_grand_blue_prince_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'grand-blue-prince-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'grand_blue_prince-batch.json'),JSON.stringify({scope:'GrandBluePrince first generic Extra restriction plus effect fixture Fusion/material check/explicit CompleteProcedure/GY generic or Fusion revival2 plus native material possession/identity11 and WATER revival6/quick shuffle-send6/opponent-chain6/sharedcount-renewal4. Test-only unchanged identity aliases and no mandatory material check; native Omega/substitute/identity-changing/full effects open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:35,status:'PASS'}));
