'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c211699737.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const protectedTypes={beast:'monster',mist:'spell',arsenal:'trap'},branches=['beast','mist','arsenal'];
const targets=branches.map(branch=>({branch,test:{incoming:protectedTypes[branch]}}));
const otherTypes=branches.flatMap(branch=>['spell','trap','monster'].filter(x=>x!==protectedTypes[branch]).map(incoming=>({branch,test:{incoming}})));
const own=branches.map(branch=>({branch,test:{incoming:protectedTypes[branch],own:true}}));
const resets=branches.flatMap(branch=>['grave','banish'].map(reset=>({branch,test:{incoming:protectedTypes[branch],reset}})));
const destroyed=branches.map(branch=>({branch,test:{}}));
const plans=[
 ...[{control:null,failed:[]},{control:'no-copy',failed:targets},{control:'no-protection',failed:targets},{control:'any-type',failed:otherTypes},{control:'any-player',failed:own},{control:'no-reset',failed:resets}].map(p=>({...p,h:'protection',cases:18})),
 ...[{control:null,failed:[]},{control:'old-reset',failed:destroyed},{control:'no-copy',failed:destroyed},{control:'no-return',failed:destroyed},{control:'any-player',failed:branches.map(branch=>({branch,test:{own:true}}))},{control:'any-type',failed:branches.map(branch=>({branch,test:{wrongType:true}}))}].map(p=>({...p,h:'destruction',cases:15}))
];
const referenceHashes=[34695290,61089209,7574904].map(code=>({code,sha256:hash(path.join(root,'tmp/omega_scripts/c'+code+'.lua'))}));
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 const harness=path.join(__dirname,'fresh_myutant_amalgamate_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'myutant-amalgamate-'+plan.h+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);assert.deepEqual(result.official_sources,referenceHashes);assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>({branch:r.branch,test:r.test})),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'myutant-amalgamate-lifecycle-batch.json'),JSON.stringify({scope:'18 native copied target-protection cases and 15 native copied destruction-recovery cases; exact mutation checks and prior-reset regression control. Neutral official stats/support and seeded source; no adapters; native Omega remains unverified',script_sha256:sourceHash,official_sources:referenceHashes,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:33,status:'PASS'}));
