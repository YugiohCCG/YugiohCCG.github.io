'use strict';
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),lua=require('luaparse');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),baseline=JSON.parse(fs.readFileSync(path.join(OUT,'baseline-remote.json'),'utf8'));
const results=baseline.cards.map(card=>{
 const file=path.join(ROOT,'public/CCG Downloads/CCG_Scripts','c'+card.passcode+'.lua');let source;
 try{source=fs.readFileSync(file);lua.parse(source.toString('utf8'),{luaVersion:'5.3'});return {passcode:card.passcode,name:card.name,status:'syntax_pass',script_sha256:crypto.createHash('sha256').update(source).digest('hex')};}
 catch(e){return {passcode:card.passcode,name:card.name,status:'syntax_fail',error:e.message,script_sha256:source&&crypto.createHash('sha256').update(source).digest('hex')};}
});
fs.writeFileSync(path.join(OUT,'current-roster-syntax.json'),JSON.stringify({scope:'All pinned production scripts; Lua 5.3 syntax only, no behavior certification.',source_revision:baseline.source_revision,results},null,2)+'\n');
const failed=results.filter(r=>r.status==='syntax_fail');console.log(JSON.stringify({total:results.length,passed:results.length-failed.length,failed},null,2));if(failed.length)process.exitCode=1;
