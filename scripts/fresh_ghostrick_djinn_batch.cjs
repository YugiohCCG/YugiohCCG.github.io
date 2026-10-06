'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c212052682.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const normal=[{},{ally:true,facedown:true},{ally:true,wrongSet:true},{ally:true,opponent:true}];
const positive=[{set:true},{special:true},{special:true,facedown:true},{set:true,wrongSet:true},{set:true,multiple:true},{special:true,multiple:true}];
const flip=[{level:1},{level:2,multiple:true},{level:3,wrongSet:true},{level:3,xyz:true},{level:3,link:true},{level:3,facedown:true}];
const plans=[
 ...[{control:null,failed:[]},{control:'no-renewal',failed:[{count:true}]}].map(p=>({...p,h:'renewal',cases:1})),
 ...[{control:null,failed:[]},{control:'ignore-relation',failed:[{mode:'return'}]},{control:'no-cost',failed:['leave','return','face-down','host-leave','negate'].map(mode=>({mode}))}].map(p=>({...p,h:'interrupt',cases:5})),
 ...[{control:null,failed:[]},{control:'ignition',failed:[{}]},{control:'no-cost',failed:[{}]},{control:'no-position',failed:[{}]}].map(p=>({...p,h:'quick',cases:3})),
 ...[{control:null,failed:[]},{control:'no-grant',failed:[{},{count:true}]},{control:'no-cost',failed:[{},{count:true}]},{control:'no-position',failed:[{},{count:true}]},{control:'no-count',failed:[{count:true}]}].map(p=>({...p,h:'material',cases:6})),
 ...[{control:null,failed:[]},{control:'no-set',failed:[{},{reflip:true}]},{control:'hard-count',failed:[{reflip:true}]}].map(p=>({...p,h:'self_set',artifact:'self-set',cases:4})),
 ...[{control:null,failed:[]},{control:'no-restriction',failed:normal},{control:'allow-facedown',failed:[normal[1]]},{control:'any-set',failed:[normal[2]]}].map(p=>({...p,h:'normal',cases:5})),
 ...[{control:null,failed:[]},{control:'no-summon',failed:positive},{control:'any-player',failed:[{set:true,opponent:true},{special:true,opponent:true}]},{control:'any-set',failed:[{special:true,wrongSet:true}]}].map(p=>({...p,h:'hand',cases:11})),
 ...[{control:null,failed:[]},{control:'no-level',failed:flip},{control:'any-set',failed:[{level:3,wrongSet:true}]}].map(p=>({...p,h:'flip',cases:7}))
];
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_ghostrick_djinn_'+plan.h+'.cjs'),harnessHash=hash(harness),started=Date.now();let status=0;
 try{execFileSync(process.execPath,['--no-warnings',harness,...(plan.control?['--'+plan.control]:[])],{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null);status=e.status;}
 const file=path.join(out,'ghostrick-djinn-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000);const result=JSON.parse(fs.readFileSync(file));
 assert.equal(result.script_sha256,sourceHash);assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'ghostrick-djinn-batch.json'),JSON.stringify({scope:'42 focused Normal Summon/Set, hand summon, self-Set/reset, flip Level and Xyz material effect cases; test-only flip API adapters, neutral supporting cards. Legal summon procedures and native Omega remain open.',script_sha256:sourceHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:42,status:'PASS'}));
