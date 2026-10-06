'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c213849997.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'any-set',failed:[{wrongSet:true}]},{control:'any-controller',failed:[{opponent:true}]},{control:'no-summon',failed:[{},{banished:true}]}].map(p=>({...p,h:'revive',cases:8}));
plans.push(...[{control:null,failed:[]},{control:'any-set',failed:[{wrongSet:true}]},{control:'any-controller',failed:[{opponent:true}]},{control:'any-position',failed:[{facedown:true}]},{control:'no-negate',failed:[{}]}].map(p=>({...p,h:'negate',cases:5})));
plans.push(...[{control:null,failed:[]},{control:'always-highest',failed:[{opponentHighest:true}]},{control:'exclude-tie',failed:[{tie:true}]},{control:'destroy-target',failed:[{},{tie:true},{facedownOther:true}]},{control:'no-destroy',failed:[{},{tie:true},{facedownOther:true},{ownTarget:true}]}].map(p=>({...p,h:'destroy',cases:6})));
plans.push(...[{control:null,failed:[]},{control:'any-set',failed:[{wrongSet:true}]},{control:'any-controller',failed:[{opponent:true}]},{control:'any-position',failed:[{facedown:true}]},{control:'any-monster',failed:[{notXyz:true},{wrongSet:true},{opponent:true},{facedown:true},{absent:true}]}].map(p=>({...p,h:'hand',cases:6})));
plans.push(...[{control:null,failed:[]},{control:'no-relation',failed:[{mode:'leave'},{mode:'return'}]},{control:'no-interruption',failed:[{mode:'leave'},{mode:'return'},{mode:'facedown'},{mode:'negate'}]}].map(p=>({...p,h:'interrupt',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'no-relation',failed:[{mode:'leave'},{mode:'return'}]},{control:'no-interruption',failed:[{mode:'leave'},{mode:'return'},{mode:'negate'}]}].map(p=>({...p,h:'revive_interrupt',artifact:'revive-interrupt',cases:3})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{}]},{control:'no-renewal',failed:[{renewal:true}]}].map(p=>({...p,h:'count',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{mode:'effect'}]},{control:'no-oath',failed:[{mode:'activation'}]},{control:'no-negation',failed:[{mode:'effect'},{mode:'activation'}]}].map(p=>({...p,h:'oath',cases:2})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_checkmate_aldrez_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'checkmate-aldrez-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'checkmate_aldrez-batch.json'),JSON.stringify({scope:'Checkmate full source native GY/faceupbanishment revive8 and setTrap support/negation5/massdestroy6/hand6/interrupt4/revive-interrupt3/count2/oath2; test-only IsFaceupEx and OATH registration adapters. Native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:36,status:'PASS'}));
