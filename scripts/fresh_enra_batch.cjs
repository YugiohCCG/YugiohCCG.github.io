'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c214371067.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'any-player',failed:[{}]},{control:'any-type',failed:[{own:true,notSpirit:true}]},{control:'no-summon',failed:[{own:true}]}].map(p=>({...p,h:'normal_trigger',artifact:'normal-trigger',cases:3}));
plans.push(...[{control:null,failed:[]},{control:'any-type',failed:[{notSpirit:true}]},{control:'no-extra',failed:[{}]},{control:'reset-tofield',failed:[{}]},{control:'old-timing',failed:[{}]}].map(p=>({...p,h:'followup',artifact:'followup',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'no-return',failed:[{normal:true},{flip:true}]},{control:'no-flip',failed:[{flip:true}]}].map(p=>({...p,h:'return',artifact:'return',cases:3})));
plans.push(...[{control:null,failed:[]},{control:'allow-special',failed:[{},{grave:true}]}].map(p=>({...p,h:'special_limit',artifact:'special-limit',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{},{decline:true}]}].map(p=>({...p,h:'count',artifact:'count',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'any-type',failed:[{notSpirit:true}]},{control:'any-position',failed:[{facedown:true}]},{control:'any-controller',failed:[{opponent:true}]}].map(p=>({...p,h:'tribute_trigger',artifact:'tribute-trigger',cases:5})));
plans.push(...[{control:null,failed:[]},{control:'no-protection',failed:[{}]}].map(p=>({...p,h:'protection_battle',artifact:'protection-battle',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-expiry',failed:[{expired:true}]}].map(p=>({...p,h:'protection_expiry',artifact:'protection-expiry',cases:1})));
plans.push(...[{control:null,failed:[]},{control:'no-renewal',failed:[{renew:true,decline:true}]}].map(p=>({...p,h:'renewal',artifact:'renewal',cases:1})));
plans.push(...[{control:null,failed:[]},{control:'no-relation',failed:[{mode:'leave'},{mode:'return'}]},{control:'no-interruption',failed:[{mode:'leave'},{mode:'return'},{mode:'negate'}]}].map(p=>({...p,h:'interrupt',artifact:'interrupt',cases:3})));
plans.push(...[{control:null,failed:[]},{control:'no-tribute-trigger',failed:[{}]}].map(p=>({...p,h:'legal_tribute',artifact:'legal-tribute',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'over-protection',failed:[{effectDestruction:true}]}].map(p=>({...p,h:'effect_destruction',artifact:'effect-destruction',cases:1})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),historicalHash=hash(path.join(out,'enra-before-continuation.lua')),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_enra_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'enra-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.control==='old-timing')assert.equal(hash(path.join(out,'enra-before-continuation.lua')),historicalHash);if(plan.support)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c'+plan.support+'.lua')));if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'enra-batch.json'),JSON.stringify({scope:'Enra fullsource native extra NormalSummon ownSpirit condition3. No adapters/bypass. Optional followup4 and Spiritreturn3 and SpecialSummon prohibition2 tested; Shared summon count2 tested; Tribute target trigger5 tested; Battleprotection2 tested; Protection expiry1 tested; Summon turnrenewal1 tested; Hand interruptions3 tested; Legal Tribute trigger2 tested; Effectdestruction exclusion1 tested; other edges/native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,historical_source_sha256:historicalHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:29,status:'PASS'}));
