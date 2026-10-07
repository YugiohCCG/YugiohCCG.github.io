'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c213266433.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'any-set',failed:[{wrongSet:true}]},{control:'faceup-position',failed:[{},{sourceGrave:true}]},{control:'no-revive',failed:[{},{sourceGrave:true}]}].map(p=>({...p,h:'revival',cases:7}));
plans.push(...[{control:null,failed:[]},{control:'no-immunity',failed:[{},{monsterEffect:true},{handCost:true},{facedownProtected:true}]},{control:'no-cost',failed:[{},{monsterEffect:true},{handCost:true},{facedownProtected:true}]},{control:'no-position',failed:[{monsterEffect:true}]}].map(p=>({...p,h:'protection',cases:7})));
plans.push(...[{control:null,failed:[]},{control:'chain-reset',failed:[{}]},{control:'no-expiry',failed:[{expired:true}]}].map(p=>({...p,h:'duration',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'last-only',failed:[{},{expired:true}]},{control:'all-effects',failed:[{}]}].map(p=>({...p,h:'multichain',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-extra',failed:[{},{faceupThird:true}]},{control:'any-set',failed:[{wrongSet:true}]},{control:'any-target',failed:[{faceupThird:true}]}].map(p=>({...p,h:'battle',cases:5})));
plans.push(...[{control:null,failed:[]},{control:'no-tracking',failed:[{survive:true,resetDefender:true}]}].map(p=>({...p,h:'battle_survival',artifact:'battle-survival',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'global-tracking',failed:[{copies:2,resetDefender:true},{copies:3,resetDefender:true},{copies:2,resetDefender:true,renewal:true}]},{control:'keep-tracking',failed:[{copies:2,resetDefender:true,renewal:true}]}].map(p=>({...p,h:'battle_multiple',artifact:'battle-multiple',cases:3})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_hanging_frute_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'hanging-frute-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'hanging_frute-batch.json'),JSON.stringify({scope:'HangingFrute own Frute GY facedown revival7/protection7/duration2/multichain2/battle5, full source canonical metadata; source fixture SSHand/GY bypassconditions only. Ritual/count/battle/protection/native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:28,status:'PASS'}));
