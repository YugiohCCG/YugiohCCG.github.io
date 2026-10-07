'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto');
async function main(){
 const {pathToFileURL}=require('node:url');
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href),core=await mod.default({sync:true,print(){},printErr(){}}),logs=[];
 const lua=`function c900003801.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetLabel(17,23)
 local first,second=e:GetLabel()
 assert(first==17 and second==23,"SetLabel/GetLabel must preserve both integers")
 assert((REASON_EFFECT|REASON_MATERIAL|REASON_FUSION)&REASON_FUSION~=0,"bitwise reason syntax must work")
 Debug.Message("WAVE2_MULTIPLE_LABELS_AND_BITWISE_PASS")
 end`;
 const root=path.resolve(__dirname,'..'),reader=name=>name==='c0.lua'?'':name==='c900003801.lua'?lua:fs.readFileSync(path.join(root,'tmp/omega_scripts',name),'utf8');
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>({code,alias:0,setcodes:[],type:17,level:1,attribute:1,race:1n,attack:0,defense:0,lscale:0,rscale:0,link_marker:0}),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 try{
  for(const name of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,name,reader(name)));
  core.duelNewCard(duel,{team:0,duelist:0,code:900003801,controller:0,location:mod.OcgLocation.MZONE,sequence:0,position:mod.OcgPosition.FACEUP_ATTACK});
  assert(!logs.some(l=>l.type===0),JSON.stringify(logs));
  assert(logs.some(l=>l.message.includes('WAVE2_MULTIPLE_LABELS_AND_BITWISE_PASS')),'Native initialization probe executed');
 }finally{core.destroyDuel(duel);}
 const result={scope:'Public engine API probe with local Omega helpers; not native Omega or a complete card scenario',status:'PASS',logs,harness_sha256:crypto.createHash('sha256').update(fs.readFileSync(__filename)).digest('hex')};
 fs.writeFileSync(path.join(root,'output/fresh-ccg-september/gemini-wave2-api-probe.json'),JSON.stringify(result,null,2)+'\n');
 console.log(JSON.stringify(result));
}main().catch(e=>{console.error(e);process.exitCode=1;});
