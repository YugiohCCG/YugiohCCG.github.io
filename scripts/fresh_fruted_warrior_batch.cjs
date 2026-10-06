'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c213615627.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'own-targets',failed:[{ownTarget:true},{link:true},{facedown:true},{absent:true}]},{control:'no-position',failed:[{},{sourceGrave:true}]}].map(p=>({...p,h:'position',cases:6}));
plans.push(...[{control:null,failed:[]},{control:'atk-only',failed:[{},{handCost:true},{expiry:true},{facedownCost:true}]},{control:'no-release',failed:[{},{handCost:true},{atkHigher:true},{expiry:true},{facedownCost:true}]},{control:'no-boost',failed:[{},{handCost:true},{atkHigher:true},{expiry:true},{facedownCost:true}]},{control:'no-expiry',failed:[{expiry:true}]}].map(p=>({...p,h:'atk',cases:8})));
plans.push(...[{control:null,failed:[]},{control:'slow-effect',failed:[{},{handCost:true},{facedownCost:true}]},{control:'no-boost',failed:[{},{handCost:true},{facedownCost:true}]}].map(p=>({...p,h:'opponent',cases:6})));
plans.push(...[{control:null,failed:[]},{control:'no-relation',failed:[{mode:'return'}]},{control:'no-interruption',failed:[{mode:'leave'},{mode:'return'},{mode:'negate'}]}].map(p=>({...p,h:'interrupt',cases:3})));
plans.push(...[{control:null,failed:[]},{control:'no-pierce',failed:[{},{facedown:true}]},{control:'always-pierce',failed:[{disabled:true}]}].map(p=>({...p,h:'battle',cases:5})));
plans.push(...[{control:null,failed:[]},{control:'any-phase',failed:[{phase:'end'},{phase:'battle'}]}].map(p=>({...p,h:'timing',cases:2})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_fruted_warrior_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'fruted-warrior-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'fruted_warrior-batch.json'),JSON.stringify({scope:'FrutedWarrior full source native position6/ATKquick8/opponentMainPhase6/interruption3/battle5/timing2; source fixture bypass only for position. ProperRitual/count/native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:30,status:'PASS'}));
