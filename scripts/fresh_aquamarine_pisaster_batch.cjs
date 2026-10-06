"use strict";
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),{spawnSync}=require('node:child_process');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september');
const plan=[['hand',[],[]],['hand',['--no-count'],['count']],['tribute',[],[]],['tribute',['--no-cost'],['{}','full','count']],['tribute',['--no-count'],['count']],['recovery',[],[]],['recovery',['--allow-spell'],['spell','trap']],['recovery',['--ignore-relation'],['targetLost','targetReturned']],['recovery',['--no-count'],['count']],['recovery',['--shared-effects'],['independent']]];
const sha=file=>crypto.createHash('sha256').update(fs.readFileSync(file)).digest('hex');
const results=plan.map(([suite,args,expectedFailures])=>{
 const script=path.join(__dirname,'fresh_aquamarine_pisaster_'+suite+'.cjs');
 const started=Date.now();
 const run=spawnSync(process.execPath,['--no-warnings',script,...args],{cwd:root,encoding:'utf8',timeout:30000});
 const artifact=path.join(out,'aquamarine-pisaster-'+suite+(args.length?'-'+args[0].slice(2):'')+'.json');
 let report=null;try{report=JSON.parse(fs.readFileSync(artifact,'utf8'));}catch{}
 const failed=report?.results.filter(r=>r.failure).map(r=>JSON.stringify(r.test));
 const expected=expectedFailures.map(key=>key==='{}'?'{}':JSON.stringify({[key]:true}));
 const fresh=fs.existsSync(artifact)&&fs.statSync(artifact).mtimeMs>=started-1000;
 const valid=fresh&&!run.error&&run.status===(expected.length?1:0)&&failed&&JSON.stringify(failed.slice().sort())===JSON.stringify(expected.slice().sort());
 console.log((valid?'PASS ':'FAIL ')+suite+' '+args.join(' ')+' (expected failures: '+expected.length+')');
 return {suite,args,valid,exit_code:run.status,error:run.error?.message,expected_failures:expected,actual_failures:failed,cases:report?.results.length,harness_sha256:sha(script),artifact_sha256:fs.existsSync(artifact)?sha(artifact):null,stdout:run.stdout,stderr:run.stderr};
});
fs.writeFileSync(path.join(out,'aquamarine-pisaster-batch.json'),JSON.stringify({scope:'Focused public-core Pisaster suites and exact mutation-failure checks. No full-card, full-roster, or native Omega certification.',script_sha256:sha(path.join(root,'public/CCG Downloads/CCG_Scripts/c211682274.lua')),results},null,2)+'\n');
if(results.some(r=>!r.valid))process.exitCode=1;
