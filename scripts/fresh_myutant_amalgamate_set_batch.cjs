'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),harness=path.join(__dirname,'fresh_myutant_amalgamate_set.cjs'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c211699737.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'no-set',failed:[{},{trap:true},{grave:true},{removed:true},{removed:true,trap:true},{count:true},{count:true,renewal:true}]},{control:'no-count',failed:[{count:true},{count:true,renewal:true}]},{control:'any-summon',failed:[{nonFusion:true}]},{control:'allow-facedown',failed:[{removed:true,facedown:true}]}];
const sourceHash=hash(source),harnessHash=hash(harness),runs=[];
for(const plan of plans){
 const started=Date.now(),args=['--no-warnings',harness,...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'myutant-amalgamate-set'+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);assert.equal(result.results.length,13);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 runs.push({control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'myutant-amalgamate-set-batch.json'),JSON.stringify({scope:'13 focused Set cases and four exact mutation checks; fixture Fusion summon bypasses material procedure, documented public visibility adapter, native Omega and copy effect remain open',script_sha256:sourceHash,harness_sha256:harnessHash,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:13,status:'PASS'}));
