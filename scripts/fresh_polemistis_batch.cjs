'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c254065048.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[];
plans.push(...[{control:null,failed:[]},{control:'no-proto',failed:[{noProto:true},{protoFacedown:true}]},{control:'any-token',failed:[{oneToken:true},{wrongToken:true},{opponentToken:true}]},{control:'no-release',failed:[{},{zeroLevel:true},{full:true}]},{control:'any-controller',failed:[{opponentToken:true}]}].map(p=>({...p,h:'tribute',cases:8})));
plans.push(...[{control:null,failed:[]},{control:'old-limit',failed:[{fusion:true}]}].map(p=>({...p,h:'summon_limit',artifact:'summon-limit',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'old-limit',failed:[{}]},{control:'no-revival',failed:[{},{fusion:true}]}].map(p=>({...p,h:'revival',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-search',failed:[{},{trap:true},{send:true},{send:true,trap:true}]}].map(p=>({...p,h:'tribute_search',artifact:'tribute-search',cases:4})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_polemistis_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'polemistis-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'polemistis-batch.json'),JSON.stringify({scope:'Polemistis actual native tribute8/restrictions4/properrevival2/searchintegration4. Real Token/ToProtoAtaxia metadata with neutral initial effects. ZeroLevel seeded Token clamps1. Stat gains/attack-all/fullsupport/native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:18,status:'PASS'}));
