'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{execFileSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september'),source=path.join(root,'public/CCG Downloads/CCG_Scripts/c232038002.lua');
const hash=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
const plans=[{control:null,failed:[]},{control:'no-search',failed:[{},{grave:true}]},{control:'any-set',failed:[{wrongSet:true},{monster:true},{trap:true}]},{control:'any-type',failed:[{monster:true},{trap:true}]}].map(p=>({...p,h:'search',artifact:'search',cases:6,support:215142357}));
// These cases use the original public decoder; no Set-message adapter is needed.
const runtimeDir=path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist');
const dependencyFiles=[...['constant.lua','utility.lua','procedure.lua'].map(n=>path.join(root,'tmp/omega_scripts',n)),...fs.readdirSync(runtimeDir).filter(n=>/\.(js|wasm)$/.test(n)).map(n=>path.join(runtimeDir,n))];
dependencyFiles.push(path.join(root,'public/CCG Downloads/CCG_Scripts/c215142357.lua'));
const dependencies=Object.fromEntries(dependencyFiles.map(f=>[path.relative(root,f).replaceAll('\\','/'),hash(f)]));
const verifyDependencies=()=>{for(const [relative,sha] of Object.entries(dependencies))assert.equal(hash(path.join(root,relative)),sha,'Runtime dependency changed during batch: '+relative);};
plans.push(...[{control:null,failed:[]},{control:'no-search',failed:[{},{grave:true}]},{control:'no-special-trigger',failed:[{},{grave:true}]}].map(p=>({...p,h:'special_search',artifact:'special-search',cases:3,support:215142357})));
plans.push(...[{control:null,failed:[]},{control:'ignore-prior-summon',failed:[{archetype:false}]}].map(p=>({...p,h:'prior_summon',artifact:'prior-summon',cases:2,support:215142357})));
plans.push(...[{control:null,failed:[]},{control:'no-lock',failed:[{archetype:false}]},{control:'lock-all',failed:[{archetype:true}]}].map(p=>({...p,h:'later_summon',artifact:'later-summon',cases:2,support:215142357})));
plans.push(...[{control:null,failed:[]},{control:'no-expiry',failed:[{archetype:false}]}].map(p=>({...p,h:'lock_expiry',artifact:'lock-expiry',cases:1,support:215142357})));
plans.push(...[{control:null,failed:[]},{control:'no-limit',failed:[{}]},{control:'per-copy-limit',failed:[{}]}].map(p=>({...p,h:'count',artifact:'count',cases:1,support:215142357})));
plans.push(...[{control:null,failed:[]},{control:'no-renewal',failed:[{}]}].map(p=>({...p,h:'renewal',artifact:'renewal',cases:1,support:215142357})));
plans.push(...[{control:null,failed:[]},{control:'no-grant',failed:[{}]}].map(p=>({...p,h:'material',artifact:'material',cases:3})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{}]}].map(p=>({...p,h:'material_count',artifact:'material-count',cases:1})));
plans.push(...[{control:null,failed:[]},{control:'no-renewal',failed:[{}]}].map(p=>({...p,h:'material_renewal',artifact:'material-renewal',cases:1})));
plans.push(...[{control:null,failed:[]},{control:'no-grant',failed:[{}]}].map(p=>({...p,h:'material_grave',artifact:'material-grave',cases:4})));
plans.push(...[{control:null,failed:[]},{control:'no-count',failed:[{copies:true},{copies:true,hosts:true}]}].map(p=>({...p,h:'material_copies',artifact:'material-copies',cases:2})));
const database=path.join(out,'candidate-CCG_v1.db'),databaseHash=hash(database);
const sourceHash=hash(source),runs=[];
for(const plan of plans){
 verifyDependencies();
 const harness=path.join(__dirname,'fresh_shining_forward_'+plan.h+'.cjs'),harnessHash=hash(harness);
 const started=Date.now(),args=['--no-warnings',harness,...(plan.args||[]),...(plan.control?['--'+plan.control]:[])];let status=0;
 try{execFileSync(process.execPath,args,{cwd:root,timeout:30000,stdio:'pipe'});}catch(e){assert.equal(e.signal,null,'Timed out/terminated child');status=e.status;}
 const file=path.join(out,'shining-forward-'+(plan.artifact||plan.h)+(plan.control?'-'+plan.control:'')+'.json');assert(fs.statSync(file).mtimeMs>=started-2000,'Stale result');const result=JSON.parse(fs.readFileSync(file,'utf8'));
 assert.equal(result.script_sha256,sourceHash);if(plan.support)assert.equal(result.supporting_script_sha256,hash(path.join(root,'public/CCG Downloads/CCG_Scripts/c'+plan.support+'.lua')));assert.equal(result.results.length,plan.cases);assert.deepEqual(result.results.filter(r=>r.failure).map(r=>r.test),plan.failed);assert.equal(status,plan.failed.length?1:0);assert.equal(hash(source),sourceHash);assert.equal(hash(harness),harnessHash);
 verifyDependencies();assert.equal(hash(database),databaseHash);runs.push({harness:plan.h,harness_sha256:harnessHash,control:plan.control,status,expected_failures:plan.failed,artifact_sha256:hash(file)});
}
fs.writeFileSync(path.join(out,'shining-forward-batch.json'),JSON.stringify({scope:'Forward Division: 27 focused cases covering Normal/Special Summon search, eligible Spell filters, prior and later summon restrictions, restriction expiry, shared search count, and next-turn renewal. Includes actual material attachment to a neutral Xyz and opponent Spell damage negation with wrong-archetype/missing-material negatives. Public engine evidence; proper Xyz Summon, chained resolution ordering and native Omega verification remain open.',script_sha256:sourceHash,candidate_database_sha256:databaseHash,runtime_dependencies_sha256:dependencies,runs},null,2)+'\n');console.log(JSON.stringify({runs:runs.length,baseline_cases:plans.filter(p=>!p.control).reduce((n,p)=>n+p.cases,0),status:'PASS'}));
