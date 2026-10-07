"use strict";
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september');
const read=name=>JSON.parse(fs.readFileSync(path.join(out,name),'utf8'));
const roster=read('baseline-remote.json').cards,syntax=new Map(read('current-roster-syntax.json').results.map(r=>[r.passcode,r])),load=new Map(read('current-roster-engine-load.json').results.map(r=>[r.passcode,r]));
const sha=s=>crypto.createHash('sha256').update(s).digest('hex');
const harnesses=fs.readdirSync(__dirname).filter(n=>/^fresh_.*\.cjs$/.test(n)).map(name=>({name,source:fs.readFileSync(path.join(__dirname,name),'utf8')}));
const cards=roster.map(c=>{
 const file=path.join(root,'public/CCG Downloads/CCG_Scripts/c'+c.passcode+'.lua');
 const hash=fs.existsSync(file)?sha(fs.readFileSync(file)):null;
 const refs=harnesses.filter(h=>new RegExp('(?<![0-9])'+c.passcode+'(?![0-9])').test(h.source)).map(h=>h.name);
 const sy=syntax.get(c.passcode),lo=load.get(c.passcode);
 return {passcode:c.passcode,name:c.name,script_sha256:hash,syntax_current:!!hash&&sy?.script_sha256===hash,syntax_status:sy?.status,load_current:!!hash&&lo?.script_sha256===hash,load_status:lo?.status,load_error:lo?.error,literal_harness_references:refs,effect_audit:'OPEN: literal references are discovery hints, not tested-effect or completion evidence'};
});
const summary={total:cards.length,missing:cards.filter(c=>!c.script_sha256).length,syntax_stale:cards.filter(c=>!c.syntax_current).length,load_stale:cards.filter(c=>!c.load_current).length,first_decision_pass:cards.filter(c=>c.load_current&&c.load_status==='first_decision_pass').length,load_fail:cards.filter(c=>c.load_current&&c.load_status!=='first_decision_pass').length,with_literal_harness_reference:cards.filter(c=>c.literal_harness_references.length).length,without_literal_harness_reference:cards.filter(c=>!c.literal_harness_references.length).length};
fs.writeFileSync(path.join(out,'audit-inventory.json'),JSON.stringify({scope:'All 711 pinned cards; current source hashes versus syntax/load evidence and literal harness discovery only. Full effect audits remain open. Dynamic passcodes and transitive production dependencies may be missed by reference discovery.',summary,cards},null,2)+'\n');
console.log(JSON.stringify(summary,null,2));
console.log('Next discovery candidates: '+cards.filter(c=>c.load_current&&c.load_status==='first_decision_pass'&&!c.literal_harness_references.length).slice(0,12).map(c=>c.passcode+' '+c.name).join('; '));
if(summary.missing||summary.syntax_stale||summary.load_stale)process.exitCode=1;
