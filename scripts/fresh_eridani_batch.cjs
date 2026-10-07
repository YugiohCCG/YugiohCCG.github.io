'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c213990492.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'any-controller',failed:[{opponent:true},{grave:true,opponent:true}]},{control:'any-position',failed:[{facedown:true}]},{control:'no-summon',failed:[{},{grave:true}]}].map(p=>({...p,h:'summon',cases:8}));
plans.push(...[{control:null,failed:[]},{control:'no-lock',failed:[{}]},{control:'any-controller',failed:[{opponent:true}]},{control:'field-too',failed:[{field:true}]}].map(p=>({...p,h:'attack_lock',artifact:'attack-lock',cases:8})));
plans.push(...[{control:null,failed:[]},{control:'always-lock',failed:[{}]},{control:'no-lock',failed:[{return:true}]},{control:'no-movement',failed:[{}]}].map(p=>({...p,h:'lock_movement',artifact:'lock-movement',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'slow-effect',failed:[{},{grave:true}]},{control:'no-summon',failed:[{},{grave:true}]}].map(p=>({...p,h:'opponent',cases:5})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{}]},{control:'no-renewal',failed:[{renewal:true}]}].map(p=>({...p,h:'count',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-relation',failed:[{mode:'leave'},{mode:'return'}]},{control:'no-interruption',failed:[{mode:'leave'},{mode:'return'},{mode:'negate'}]}].map(p=>({...p,h:'interrupt',cases:3})));
plans.push(...[{control:null,failed:[]},{control:'any-controller',failed:[{}]},{control:'any-reason',failed:[{opponent:true,cost:true}]}].map(p=>({...p,h:'destroy_trigger',artifact:'destroy-trigger',cases:5})));
plans.push(...[{control:null,failed:[]},{control:'no-eldora-branch',failed:[{}]}].map(p=>({...p,h:'eldora_destruction',artifact:'eldora-destruction',cases:2,support:214552846})));
plans.push(...[{control:null,failed:[]},{control:'no-protection',failed:[{opponent:true},{opponent:true,recipientOpponent:true}]}].map(p=>({...p,h:'protection',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-expiry',failed:[{opponent:true,expiry:true}]},{control:'any-name',failed:[{opponent:true,wrongName:true}]}].map(p=>({...p,h:'protection_expiry',artifact:'protection-expiry',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'field-only',failed:[{opponent:true},{opponent:true,recipientOpponent:true}]},{control:'no-protection',failed:[{opponent:true},{opponent:true,recipientOpponent:true}]}].map(p=>({...p,h:'protection_hand',artifact:'protection-hand',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-battle-protection',failed:[{opponent:true}]},{control:'any-name',failed:[{opponent:true,wrongName:true}]}].map(p=>({...p,h:'protection_battle',artifact:'protection-battle',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{opponent:true}]},{control:'no-renewal',failed:[{opponent:true,renewal:true}]}].map(p=>({...p,h:'declaration_count',artifact:'declaration-count',cases:2})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_eridani_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'eridani-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.support)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c'+plan.support+'.lua')));if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'eridani-batch.json'),JSON.stringify({scope:'Eridani full source Hand Quick8/attacklock8/lockmovement2/opponent5/count2/interrupt3/destroytrigger5/eldoradestruction2/protection2/expiry2/handprotection2/battleprotection2/declarationcount2 with canonical Eldora metadata neutral effects. Protection test-only declaration/chaininfo adapters; no summon bypass; Eldora integration/count/protection/native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:45,status:'PASS'}));
