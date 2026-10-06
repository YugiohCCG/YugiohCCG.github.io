'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c212413422.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const positives=[{},{opponent:true},{count:true},{count:true,renewal:true}];
const plans=[{control:null,failed:[]},{control:'no-summon',failed:positives},{control:'any-race',failed:[{wrongRace:true}]},{control:'allow-facedown',failed:[{facedown:true},{opponent:true,facedown:true}]},{control:'own-only',failed:[{opponent:true}]},{control:'no-count',failed:[{count:true},{count:true,renewal:true}]}].map(p=>({...p,h:'hand',cases:9}));
plans.push(...[{control:null,failed:[]},{control:'no-cost',failed:[{},{opponent:true},{multiple:true}]},{control:'no-return',failed:[{},{opponent:true},{multiple:true}]},{control:'any-set',failed:[{wrongSet:true}]},{control:'allow-facedown',failed:[{facedown:true}]},{control:'any-type',failed:[{spell:true}]}].map(p=>({...p,h:'return',cases:7})));
const fusionPositives=[{},{opponent:true},{grave:true},{grave:true,opponent:true},{expiry:true}];
plans.push(...[{control:null,failed:[]},{control:'no-banish',failed:fusionPositives},{control:'no-summon',failed:fusionPositives},{control:'no-boost',failed:fusionPositives},{control:'no-expiry',failed:[{expiry:true}]},{control:'any-fusion',failed:[{wrongMaterial:true}]}].map(p=>({...p,h:'fusion',cases:9})));
for(const recipient of [15989522,2519690,66889139])plans.push(...[{control:null,failed:[]},{control:'no-legacy',failed:fusionPositives}].map(p=>({...p,h:'fusion',recipient,cases:8})));
const officialHashes=Object.fromEntries([15989522,2519690,66889139].map(code=>[code,hash(path.join(root,'tmp/omega_scripts/c'+code+'.lua'))]));
plans.push(...[{control:null,failed:[]},{control:'ignore-target',failed:[{mode:'target-leave'},{mode:'target-return'}]},{control:'ignore-instance',failed:[{mode:'source-return'}]}].map(p=>({...p,h:'fusion_interrupt',artifact:'fusion-interrupt',cases:5})));
const recoveryInterruptCases=[{mode:'leave'},{mode:'return'},{mode:'negate'},{mode:'leave',multiple:true}];
plans.push(...[{control:null,failed:[]},{control:'ignore-relation',failed:[{mode:'return'}]},{control:'no-cost',failed:recoveryInterruptCases}].map(p=>({...p,h:'return_interrupt',artifact:'return-interrupt',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{},{renewal:true}]},{control:'no-renewal',failed:[{renewal:true}]}].map(p=>({...p,h:'return_count',artifact:'return-count',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{}]},{control:'no-renewal',failed:[{renewal:true}]}].map(p=>({...p,h:'fusion_count',artifact:'fusion-count',cases:2})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_gaia_iron_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.control?['--'+plan.control]:[]),...(plan.recipient?['--official','--recipient='+plan.recipient]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'gaia-iron-'+(plan.artifact||plan.h)+(plan.recipient?'-official-'+plan.recipient:'')+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);for(const [code,h] of Object.entries(officialHashes))assert.equal(hash(path.join(root,'tmp/omega_scripts/c'+code+'.lua')),h);runs.push({recipient:plan.recipient||null,harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'gaia-iron-batch.json'),JSON.stringify({scope:'Gaia62 baseline cases: hand9/recovery7/neutral Fusion9 plus actual official Fusion scripts8 each for3 recipients with neutral stats. Recovery target-group adapter only. Exact mutations, DB/source/harness/official hashes and freshness. Effect independence/native Omega remain open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,official_script_hashes:officialHashes,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:62,status:'PASS'}));
