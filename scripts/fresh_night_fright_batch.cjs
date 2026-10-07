'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c215621622.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'no-summon',failed:['hand','deck','grave','removed'].map(source=>({source}))}].map(p=>({...p,h:'summon',artifact:'summon',cases:4}));
// These cases use the original public decoder; no Set-message adapter is needed.
const runtimeDir=path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist');
const dependencyFiles=[...['constant.lua','utility.lua','procedure.lua'].map(n=>path.join(root,'tmp/omega_scripts',n)),...fs.readdirSync(runtimeDir).filter(n=>/\.(js|wasm)$/.test(n)).map(n=>path.join(runtimeDir,n))];

dependencyFiles.push(...[250262550,231331942].map(code=>path.join(root,'public/CCG Downloads/CCG_Scripts/c'+code+'.lua')));
const dependencies=Object.fromEntries(dependencyFiles.map(f=>[path.relative(root,f).replaceAll('\\','/'),hash(f)]));
const verifyDependencies=()=>{for(const [relative,sha] of Object.entries(dependencies))assert.equal(hash(path.join(root,relative)),sha,'Runtime dependency changed during batch: '+relative);};
plans.push(...[{control:null,failed:[]},{control:'any-cost',failed:[{wrongCost:true}]},{control:'opponent-cost',failed:[{opponentCost:true}]}].map(p=>({...p,h:'eligibility',artifact:'eligibility',cases:5})));
plans.push(...[{control:null,failed:[]},{control:'no-limit',failed:[{}]},{control:'per-copy-limit',failed:[{}]}].map(p=>({...p,h:'count',artifact:'count',cases:1})));
plans.push(...[{control:null,failed:[]},{control:'no-renewal',failed:[{}]}].map(p=>({...p,h:'renewal',artifact:'renewal',cases:1})));
plans.push({control:null,failed:[{source:'hand'},{source:'deck'}],h:'canonical',artifact:'canonical',cases:2,diagnostic:true});
plans.push({control:'without-revive-limit',failed:[],h:'canonical',artifact:'canonical',cases:2,diagnostic:true},{control:'unconditional-hollow',failed:[{source:'hand'},{source:'deck'}],h:'canonical',artifact:'canonical',cases:2,diagnostic:true});
plans.push({control:'night-permission',failed:[],h:'canonical',artifact:'canonical',cases:2,diagnostic:true});
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 verifyDependencies();
 const harness=path.join(__dirname,'fresh_night_fright_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'night-fright-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.support)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c'+plan.support+'.lua')));if(plan.diagnostic){assert.deepEqual(result.results.map(r=>r.failure),plan.failed.length?['Night activation available','Night activation available']:[null,null]);for(const [code,sha] of Object.entries(result.supporting_scripts_sha256))assert.equal(sha,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c'+code+'.lua')));}assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 verifyDependencies();assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,diagnostic:!!plan.diagnostic,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'night-fright-batch.json'),JSON.stringify({scope:'Night of Fright: four source-location native cost/Special Summon cases with neutral support effects. Full support scripts, negative eligibility, count/phase/interruptions and native Omega remain open',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runtime_dependencies_sha256:dependencies,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:plans.filter(p=>!p.control&&!p.diagnostic).reduce((n,p)=>n+p.cases,0),status:'PASS'}));
