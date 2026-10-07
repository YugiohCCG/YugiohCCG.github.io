'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c214511076.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'any-field',failed:[{unrelated:true}]},{control:'no-summon',failed:[{},{archetype:true},{opponent:true}]}].map(p=>({...p,h:'hand',artifact:'hand',cases:5}));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{},{archetype:true}]}].map(p=>({...p,h:'count',artifact:'count',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-relation',failed:[{mode:'leave'},{mode:'return'}]},{control:'no-interruption',failed:[{mode:'leave'},{mode:'return'},{mode:'negate'}]}].map(p=>({...p,h:'interrupt',artifact:'interrupt',cases:3})));
plans.push(...[{control:null,failed:[]},{control:'no-renewal',failed:[{renew:true}]}].map(p=>({...p,h:'renewal',artifact:'renewal',cases:1})));
plans.push(...[{control:null,failed:[]},{control:'any-set',failed:[{wrongSet:true}]},{control:'any-level',failed:[{highLevel:true}]},{control:'any-name',failed:[{sameName:true}]}].map(p=>({...p,h:'target_filter',artifact:'target-filter',cases:5})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_arckcestial_prism_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'arckcestial-prism-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.support)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c'+plan.support+'.lua')));if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'arckcestial-prism-batch.json'),JSON.stringify({scope:'ArckcestialPrism fullsource Hand summon5/no adapters/bypass; Sharedcount2 tested; Handinterruptions3 tested; Turnrenewal1 tested; Native targetfilter5 tested separately; actualmaterialtrigger/revival/native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:16,status:'PASS'}));
