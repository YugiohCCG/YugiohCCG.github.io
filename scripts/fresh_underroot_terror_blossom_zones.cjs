'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const eventCheck=process.argv.includes('--event-check'),ordinaryControl=process.argv.includes('--ordinary-send-control');
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),blossom=238272438,graveCard=900000731,banishedCard=900000732,filler=900000733;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(blossom);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const targets of [true,false]){
  const trace=[],logs=[],cards=new Map([[blossom,{...base,code:blossom,setcodes:[0xA110,0xA111],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[graveCard,{...base,code:graveCard}],[banishedCard,{...base,code:banishedCard}],[filler,{...base,code:filler}]]);
  const reader=name=>{if([`c${graveCard}.lua`,`c${banishedCard}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const originalReader=reader;
  const eventReader=name=>{
   if(eventCheck&&name===`c${banishedCard}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F) e:SetCode(EVENT_TO_GRAVE) e:SetOperation(function(e,tp) Duel.Damage(tp,777,REASON_EFFECT) end) c:RegisterEffect(e) end`;
   const source=originalReader(name);
   // Explicit negative control, never written back to the production script.
   return ordinaryControl&&name===`c${blossom}.lua`?source.replace('Duel.SendtoGrave(fromBanish,REASON_EFFECT+REASON_RETURN)','Duel.SendtoGrave(fromBanish,REASON_EFFECT)'):source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:eventReader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});add(blossom,L.MZONE);if(targets){add(graveCard,L.GRAVE,1);add(banishedCard,L.REMOVED,1);}for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<95&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===blossom);if(!activated&&targets){if(index<0)throw Error('Zone swap unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{if(!targets&&index>=0)throw Error('Zone swap offered without opponent cards');const g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.GRAVE}),x=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.REMOVED});if(targets&&(!x.some(c=>c?.code===graveCard)||!g.some(c=>c?.code===banishedCard)))throw Error('Opposing zone swap mismatch');done=true;}}
    else if(p.type===M.SELECT_CARD){const picks=p.selects.map((c,i)=>[c,i]).filter(([c])=>c.code===graveCard||c.code===banishedCard).map(([,i])=>i);if(picks.length!==2)throw Error('Both opponent targets unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:picks});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
   if(eventCheck){const damaged=trace.some(t=>t.type===M.DAMAGE);if(damaged!==(targets&&ordinaryControl))throw Error(`Return event mismatch: damage=${damaged}, ordinaryControl=${ordinaryControl}`);}
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({targets,status:failure?'FAIL':'PASS',failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} targets=${targets}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/underroot-terror-blossom-zones${eventCheck?ordinaryControl?'-ordinary-control':'-return-event':''}.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',eventCheck,ordinaryControl,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
