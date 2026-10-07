'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),harness=path.join(__dirname,'fresh_myutant_amalgamate_official.cjs'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c211699737.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const positives=[{branch:'beast',test:{incoming:'spell'}},{branch:'mist',test:{incoming:'trap'}},{branch:'arsenal',test:{incoming:'monster'}}];
const plans=[{control:null,failed:[]},{control:'no-copy',failed:positives},{control:'no-cost',failed:positives},{control:'no-result',failed:positives},{control:'raw-omega',failed:[positives[1]]}];
const referenceHashes=[34695290,61089209,7574904].map(code=>({code,sha256:hash(path.join(root,'tmp/omega_scripts/c'+code+'.lua'))}));
const sourceHash=hash(source),harnessHash=hash(harness),runs=[];
for(const plan of plans){
 const started=Date.now(),args=['--no-warnings',harness,...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'myutant-amalgamate-official'+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);assert.deepEqual(result.official_sources,referenceHashes);assert.equal(result.results.length,12);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>({branch:r.branch,test:r.test})),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 runs.push({control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'myutant-amalgamate-official-batch.json'),JSON.stringify({scope:'12 focused actual copied Omega response cases; four exact controls including raw public incompatibility. Neutral official stats and supporting cards; Mist-only in-memory ChainInfo enum adaptation. Native Omega, protection/destruction/reset effects and printed CopyEffect interpretation remain open',script_sha256:sourceHash,harness_sha256:harnessHash,official_sources:referenceHashes,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:12,status:'PASS'}));
