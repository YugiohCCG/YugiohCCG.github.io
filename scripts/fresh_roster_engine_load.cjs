'use strict';
// Fresh full-roster loading evidence, not all-effects verification.
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const roster=JSON.parse(fs.readFileSync(path.join(OUT,'baseline-remote.json'),'utf8'));
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href),core=await mod.default({sync:true,print(){},printErr(){}});
 const filler=900019999,neutral={code:filler,alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const results=[],limit=Number(process.env.CCG_LOAD_LIMIT||roster.cards.length),offset=Number(process.env.CCG_LOAD_OFFSET||0),metadata=new Map([[filler,neutral]]),scripts=new Map();
 const reader=name=>{
  if(name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
  if(!scripts.has(name)){const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing script '+name);scripts.set(name,fs.readFileSync(file,'utf8'));}return scripts.get(name);
 };
 const requested=process.env.CCG_LOAD_CODES?new Set(process.env.CCG_LOAD_CODES.split(',').map(Number)):null;
 const selected=requested?roster.cards.filter(c=>requested.has(c.passcode)):roster.cards.slice(offset,offset+limit);
 if(requested&&selected.length!==requested.size)throw Error('Unknown requested passcode');
 const report=()=>fs.writeFileSync(path.join(OUT,'current-roster-engine-load'+(requested?'-selected':offset||limit<roster.cards.length?'-'+offset+'-'+limit:'')+'.json'),JSON.stringify({scope:'Current pinned roster: public OCGCore load/initialization and first decision only. No effect resolution, native Omega or complete-card certification.',source_revision:roster.source_revision||roster.revision,offset,limit,requested_codes:requested?[...requested]:undefined,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 for(const card of selected){
  const logs=[],loaded=new Set(),code=card.passcode,source=fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts','c'+code+'.lua'));
  let duel,status='load_fail',error=null;
  try{
   const data=candidateCard(code);metadata.set(code,data);
   const scriptReader=name=>{loaded.add(name);return reader(name);};
   duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:id=>{if(!metadata.has(id))metadata.set(id,candidateCard(id));return metadata.get(id);},scriptReader,errorHandler:(type,message)=>logs.push({type,message})});
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,scriptReader(name));
   const extra=!!(data.type&(0x40|0x2000|0x800000|0x4000000));
   core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location:extra?mod.OcgLocation.EXTRA:mod.OcgLocation.HAND,sequence:0,position:extra?mod.OcgPosition.FACEDOWN_DEFENSE:mod.OcgPosition.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:mod.OcgLocation.DECK,sequence:0,position:mod.OcgPosition.FACEDOWN_DEFENSE});
   core.startDuel(duel);
   for(let step=0;step<16;step++){
    const state=core.duelProcess(duel);core.duelGetMessage(duel);
    if(logs.some(x=>x.type===0))throw Error(logs.filter(x=>x.type===0).map(x=>x.message).join('; '));
    if(state===mod.OcgProcessResult.WAITING){status='first_decision_pass';break;}if(state===mod.OcgProcessResult.END)throw Error('Unexpected duel end');
   }
   if(status!=='first_decision_pass')throw Error('No first decision in 16 process steps');
  }catch(e){error=e.message;}finally{if(duel)core.destroyDuel(duel);}
  results.push({passcode:code,name:card.name,status,error,script_sha256:crypto.createHash('sha256').update(source).digest('hex'),loaded_scripts:[...loaded],logs});
  if(results.length%50===0){report();console.log('Processed '+results.length+' of '+Math.min(limit,roster.cards.length-offset));}
 }
 report();const failed=results.filter(r=>r.status!=='first_decision_pass');console.log(JSON.stringify({total:results.length,passed:results.length-failed.length,failed:failed.map(r=>({passcode:r.passcode,name:r.name,error:r.error}))},null,2));if(failed.length)process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
