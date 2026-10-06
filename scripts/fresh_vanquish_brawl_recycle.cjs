'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),brawl=244161941,source=900000111,victim=900000112,vs1=900000113,vs2=900000114,filler=900000115;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(brawl);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[source,{...base,code:source,setcodes:[0x195]}],[victim,{...base,code:victim}],[vs1,{...base,code:vs1,setcodes:[0x195]}],[vs2,{...base,code:vs2,setcodes:[0x195]}],[filler,{...base,code:filler}]]);
 const b=r.setcode;cards.set(brawl,{...base,code:brawl,setcodes:Array.from({length:b.length/2},(_,i)=>b[i*2]|b[i*2+1]<<8).filter(Boolean),type:Number(r.type),level:0,attribute:0,race:0n,attack:0,defense:0});
 const sourceScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCategory(CATEGORY_TOGRAVE) e:SetTarget(s.tg) e:SetOperation(s.op) c:RegisterEffect(e) end function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_MZONE,1,nil) end end function s.op(e,tp) local g=Duel.GetMatchingGroup(nil,tp,0,LOCATION_MZONE,nil) Duel.SendtoGrave(g,REASON_EFFECT) end`;
 const results=[];
 for(const validSource of [false,true]){
  const trace=[],logs=[];
  const reader=name=>{
   if(name===`c${source}.lua`)return sourceScript;
   if(['c0.lua',`c${victim}.lua`,`c${vs1}.lua`,`c${vs2}.lua`,`c${filler}.lua`].includes(name))return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const cardReader=code=>{if(!cards.has(code))throw Error('Missing card '+code);return code===source&&!validSource?{...cards.get(code),setcodes:[]}:cards.get(code)};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader,scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,used=false,triggered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(source,L.MZONE);add(victim,L.MZONE,1);add(brawl,L.GRAVE);add(vs1,L.GRAVE);add(vs2,L.GRAVE);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(used){
      if(core.duelQueryCount(duel,1,L.MZONE)!==0)throw Error('Opponent monster was not removed');
      const actual=core.duelQueryCount(duel,0,L.GRAVE);
      if(actual!==(validSource?0:3))throw Error('Recycling outcome wrong: GY='+actual);
      if(triggered!==validSource)throw Error('Brawl trigger legality wrong');
      done=true;break;
     }
     const index=p.activates.findIndex(c=>c.code===source);if(index<0)throw Error('Source effect unavailable');used=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===brawl);if(index>=0)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:Array.from({length:p.min??1},(_,i)=>i)});
    else if(p.type===M.SELECT_EFFECTYN){triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({validSource,status:failure?'FAIL':'PASS',failure,used,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} VS-source=${validSource}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/vanquish-brawl-recycle.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
