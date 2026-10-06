'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c212737555.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'no-water',failed:[{wrongAttribute:true},{facedown:true}]},{control:'any-controller',failed:[{opponent:true}]},{control:'any-position',failed:[{facedown:true}]}].map(p=>({...p,h:'summon',cases:6}));
plans.push(...[{control:null,failed:[]},{control:'any-set',failed:[{wrongSet:true},{monster:true},{opponent:true},{absent:true}]},{control:'any-type',failed:[{monster:true}]},{control:'any-origin',failed:[{fieldOrigin:true}]},{control:'no-draw',failed:[{},{trap:true}]},{control:'no-shuffle',failed:[{},{trap:true}]}].map(p=>({...p,h:'banish',cases:7})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{},{renewal:true}]},{control:'no-renewal',failed:[{renewal:true}]}].map(p=>({...p,h:'summon_count',artifact:'summon-count',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{}]},{control:'no-renewal',failed:[{renewal:true}]}].map(p=>({...p,h:'banish_count',artifact:'banish-count',cases:3})));
plans.push({control:'shared-id',failed:[{independence:true}],h:'banish_count',artifact:'banish-count',cases:3});
plans.push(...[{control:null,failed:[]},{control:'no-relation',failed:[{mode:'leave'},{mode:'return'}]},{control:'no-interruption',failed:[{mode:'leave'},{mode:'return'},{mode:'negate'}]}].map(p=>({...p,h:'interrupt',cases:3})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_aqua_droplet_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'aqua-droplet-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'aqua_droplet-batch.json'),JSON.stringify({scope:'Aqua Droplet native GY summon6/banished shuffle-draw7/summon sharedcount-renewal2/banish sharedcount-renewal/independence3 and interruptions3 with actual canonical source, neutral WATER support and exact eligibility mutations; count/banished trigger/native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:21,status:'PASS'}));
