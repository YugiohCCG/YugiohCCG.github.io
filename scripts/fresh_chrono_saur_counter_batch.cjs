'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c213530841.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'no-negate',failed:[{},{decline:true}]},{control:'any-set',failed:[{wrongSet:true}]},{control:'any-effect',failed:[{spellEffect:true}]}].map(p=>({...p,h:'negate',cases:6}));
plans.push(...[{control:null,failed:[]},{control:'any-turn',failed:[{opponentTurn:true}]},{control:'one-monster',failed:[{oneEnemy:true}]}].map(p=>({...p,h:'hand',cases:5})));
plans.push(...[{control:null,failed:[]},{control:'any-reason',failed:[{cost:true}]},{control:'no-draw',failed:[{},{handOrigin:true}]}].map(p=>({...p,h:'draw',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'handler-only',failed:[{choice:'hand'},{choice:'field'},{choice:'self'}]},{control:'no-draw',failed:[{choice:'self'}]}].map(p=>({...p,h:'destroy_choice',artifact:'destroy-choice',cases:3})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{}]},{control:'no-renewal',failed:[{renewal:true}]}].map(p=>({...p,h:'draw_count',artifact:'draw-count',cases:2})));
plans.push({control:'shared-id',failed:[{choice:'self'}],h:'destroy_choice',artifact:'destroy-choice',cases:3});
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{}]},{control:'no-renewal',failed:[{renewal:true}]}].map(p=>({...p,h:'negate_count',artifact:'negate-count',cases:2})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_chrono_saur_counter_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'chrono-saur-counter-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'chrono_saur_counter-batch.json'),JSON.stringify({scope:'ChronoSaurCounter full-source native negate/optional handler destruction6/hand activation5, native opponentturn2 exact mutations. Hand activation/draw/sharedcount/native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:22,status:'PASS'}));
