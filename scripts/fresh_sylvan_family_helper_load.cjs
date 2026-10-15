'use strict';
// Loader-only regression: actual full scripts, unavailable helper, native Lua.
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),DIR=path.join(ROOT,'public/CCG Downloads/CCG_Scripts');
const missing=process.argv.includes('--missing-helper'),old=process.argv.includes('--old-source');
const codes=fs.readdirSync(DIR).filter(n=>/^c\d+\.lua$/.test(n)&&fs.readFileSync(path.join(DIR,n),'utf8').includes('Duel.LoadScript("ccg_sylvan.lua")'));
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href),core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 for(const name of codes){
  const logs=[],loaded={};
  const reader=n=>{if(n==='c0.lua')return '';if(n==='ccg_sylvan.lua'&&missing)return '';const file=[path.join(DIR,n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);if(!file)throw Error('Missing '+n);let s=fs.readFileSync(file,'utf8');if(n===name){const backup=path.join(OUT,'sylvan-family-before-helper-fallback',name);if(old&&fs.existsSync(backup))s=fs.readFileSync(backup,'utf8');s+='\nassert(CCGSylvan and type(CCGSylvan.Excavate)=="function" and type(CCGSylvan.Plant)=="function" and type(CCGSylvan.ForcedSend)=="function", "SYLVAN_HELPER_UNAVAILABLE")\n'+name.slice(0,-4)+'.initial_effect=function(c) end\n';}loaded[path.relative(ROOT,file).replaceAll('\\','/')]=crypto.createHash('sha256').update(s).digest('hex');return s;};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>({code,alias:0,setcodes:[],type:17,level:1,attribute:1,race:1n,attack:0,defense:0,lscale:0,rscale:0,link_marker:0}),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
  const backup=path.join(OUT,'sylvan-family-before-helper-fallback',name),file=old&&fs.existsSync(backup)?backup:path.join(DIR,name);
  const source=fs.readFileSync(file,'utf8');
  core.duelNewCard(duel,{team:0,duelist:0,code:Number(name.slice(1,-4)),controller:0,location:mod.OcgLocation.HAND,sequence:0,position:mod.OcgPosition.FACEUP_ATTACK});const ok=!logs.some(x=>x.type===0);
  results.push({script:name,pass:!!ok&&!logs.some(x=>x.type===0),logs,source_sha256:crypto.createHash('sha256').update(source).digest('hex'),loaded_dependencies_sha256:loaded});core.destroyDuel(duel);
 }
 const file='sylvan-family-helper-load'+(missing?'-missing-helper':'')+(old?'-old-source':'')+'.json';fs.writeFileSync(path.join(OUT,file),JSON.stringify({scope:'Native card-script loading and required helper functions only; initial_effect replaced after full source definitions solely to isolate loading from unrelated legacy registration APIs. No card effect or native Omega certification.',missing_helper:missing,old_source:old,results},null,2)+'\n');console.log(JSON.stringify({total:results.length,passed:results.filter(r=>r.pass).length,failed:results.filter(r=>!r.pass).map(r=>({script:r.script,logs:r.logs}))}));if(results.some(r=>!r.pass))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
