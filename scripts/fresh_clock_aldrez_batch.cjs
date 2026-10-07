"use strict";
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),{spawnSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september');
const positives=[{},{field:true},{trap:true},{spellEffect:true},{trapEffect:true}];
const plan=[['summon',[],[]],['summon',['--no-count'],[{count:true},{count:true,normalFirst:true}]],['summon',['--no-send'],[{},{normal:true},{spell:true},{trap:true},{count:true},{count:true,normalFirst:true}]],['rewrite',[],[]],['rewrite',['--no-cost'],positives],['rewrite',['--no-rewrite'],positives],['rewrite',['--no-negation'],positives],['rewrite',['--any-type'],[{monster:true}]],['rewrite',['--any-player'],[{own:true}]],['lock',[],[]],...['--no-lock','--no-exception','--all-locations'].map(flag=>['lock',[flag],[{allowed:'aldrez'},{allowed:'hand'},{allowed:'grave'},{allowed:'aldrez',renewal:true},{allowed:'aldrez',sourceLost:true}]]),['lock',['--no-expiry'],[{allowed:'aldrez',renewal:true}]],['lock',['--lock-on-revival'],[{allowed:'aldrez',sourceLost:true}]]];
const sha=file=>crypto.createHash('sha256').update(fs.readFileSync(file)).digest('hex');
const results=plan.map(([suite,args,expectedFailures])=>{
 const script=path.join(__dirname,'fresh_clock_aldrez_'+suite.replaceAll('-','_')+'.cjs');
 const started=Date.now();
 const run=spawnSync(process.execPath,['--no-warnings',script,...args],{cwd:root,encoding:'utf8',timeout:30000});
 const artifact=path.join(out,'clock-aldrez-'+suite+(args.length?'-'+args[0].slice(2):'')+'.json');
 let report=null;try{report=JSON.parse(fs.readFileSync(artifact,'utf8'));}catch{}
 const failed=report?.results.filter(r=>r.failure).map(r=>JSON.stringify(r.test));
 const expected=expectedFailures.map(test=>JSON.stringify(test));
 const fresh=fs.existsSync(artifact)&&fs.statSync(artifact).mtimeMs>=started-1000;
 const valid=fresh&&!run.error&&run.status===(expected.length?1:0)&&failed&&JSON.stringify(failed.slice().sort())===JSON.stringify(expected.slice().sort());
 console.log((valid?'PASS ':'FAIL ')+suite+' '+args.join(' ')+' (expected failures: '+expected.length+')');
 return {suite,args,valid,exit_code:run.status,error:run.error?.message,expected_failures:expected,actual_failures:failed,cases:report?.results.length,harness_sha256:sha(script),artifact_sha256:fs.existsSync(artifact)?sha(artifact):null,stdout:run.stdout,stderr:run.stderr};
});
fs.writeFileSync(path.join(out,'clock-aldrez-batch.json'),JSON.stringify({scope:'Focused public-core Clock suites and exact mutation-failure checks. No full-card, full-roster, or native Omega certification.',script_sha256:sha(path.join(root,'public/CCG Downloads/CCG_Scripts/c210716547.lua')),results},null,2)+'\n');
if(results.some(r=>!r.valid))process.exitCode=1;
