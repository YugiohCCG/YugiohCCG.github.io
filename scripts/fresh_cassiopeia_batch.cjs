'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c212377618.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'no-membership',failed:[{},{set:true}]},{control:'wrong-type',failed:[{},{set:true}]}].map(p=>({...p,h:'normal',cases:2}));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_cassiopeia_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'cassiopeia-'+plan.h+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'cassiopeia-batch.json'),JSON.stringify({scope:'Cassiopeia Normal Summon/Set and native membership/type/stats in five locations; two database metadata mutations. No adapters. Native Omega remains unverified',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:2,status:'PASS'}));
