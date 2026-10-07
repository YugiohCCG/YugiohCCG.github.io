'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c212684822.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const positives=[{},{trap:true},{send:true},{send:true,trap:true}];
const plans=[{control:null,failed:[]},{control:'any-set',failed:[{wrongSet:true},{monster:true},{absent:true}]},{control:'any-type',failed:[{monster:true}]},{control:'no-search',failed:positives},{control:'any-origin',failed:[{sourceGrave:true}]}].map(p=>({...p,h:'search',cases:8}));
const damaging=[{},{ownAttack:true},{odd:true},{defense:true,pierce:true}];
plans.push(...[{control:null,failed:[]},{control:'raw-omega',failed:[]},{control:'no-half',failed:damaging},{control:'no-reflect',failed:damaging}].map(p=>({...p,h:'battle',cases:8})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{},{send:true}]},{control:'no-renewal',failed:[{renewal:true},{send:true,renewal:true}]}].map(p=>({...p,h:'search_count',artifact:'search-count',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'no-proto',failed:[{noProto:true},{protoFacedown:true}]},{control:'any-token',failed:[{oneToken:true},{wrongToken:true},{opponentToken:true}]},{control:'no-release',failed:[{},{zeroLevel:true},{full:true}]},{control:'any-controller',failed:[{opponentToken:true}]}].map(p=>({...p,h:'tribute',cases:8})));
plans.push(...[{control:null,failed:[]},{control:'old-limit',failed:[{fusion:true}]}].map(p=>({...p,h:'summon_limit',artifact:'summon-limit',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'old-limit',failed:[{}]},{control:'no-revival',failed:[{},{fusion:true}]}].map(p=>({...p,h:'revival',cases:2})));
plans.push(...[{control:null,failed:[]},{control:'no-search',failed:[{},{trap:true},{send:true},{send:true,trap:true}]}].map(p=>({...p,h:'tribute_search',artifact:'tribute-search',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'always-hand',failed:[{graveOnly:true},{graveOnly:true,trap:true}]},{control:'always-send',failed:[{handOnly:true},{handOnly:true,trap:true}]},{control:'force-choice',failed:[{handOnly:true},{graveOnly:true},{handOnly:true,trap:true},{graveOnly:true,trap:true}]}].map(p=>({...p,h:'destinations',cases:6})));
for(const mode of ['actual-support','proper-support'])plans.push(...[{control:null,failed:[]},{control:'no-search',failed:[{},{trap:true},{send:true},{send:true,trap:true}]}].map(p=>({...p,h:'tribute_search',artifact:'tribute-search-'+mode,args:['--'+mode],cases:4})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_ektelestis_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'ektelestis-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.args)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c246380598.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'ektelestis-batch.json'),JSON.stringify({scope:'Ektelestis search8, battle8, sharedcount4 and native tribute8 and summon restriction4 and proper revival2 and tribute/search integration4 and destination restrictions6 and actual/proper support8 cases with exact mutations. Battle also passes raw Omega constants. Tribute uses real supporting metadata with neutral initial effects; zero-Level Token fixture is clamped to Level1. Proper native tribute then GY revival passes. Tribute/search integration passes; native Omega open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:52,status:'PASS'}));
