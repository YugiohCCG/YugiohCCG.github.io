'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const boss=244959812, ally=900006202, top=900006203, filler=900006201, probe=900006204, mode=process.argv[2]||'current';
 for(const scenario of ['normal','replace']){
  const logs=[],base={alias:0,setcodes:[],type:17,level:2,attribute:2,race:4n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[ally,{...base,code:ally,type:0xa1,setcodes:[0x11f],attribute:2}],[top,{...base,code:top}],[filler,{...base,code:filler}],[probe,{...base,code:probe}]]);
  const reader=name=>{
   if(name==='c0.lua')return ''; if([top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+probe+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local start=Effect.CreateEffect(c) start:SetType(EFFECT_TYPE_IGNITION) start:SetRange(LOCATION_MZONE) start:SetCountLimit(1) start:SetOperation(function(e,tp) Duel.Destroy(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,244959812),REASON_EFFECT) end) c:RegisterEffect(start) '+(scenario==='replace'?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetCode(EFFECT_RELEASE_REPLACE) e:SetRange(LOCATION_MZONE) e:SetTarget(function(e,tp,eg) return eg:IsExists(function(tc) return tc:IsCode(244959812) end,1,nil) end) e:SetValue(function(e,tc) return tc:IsCode(244959812) end) c:RegisterEffect(e) ':'')+'end';
   if(name==='c'+ally+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,name);
   if(name==='c'+boss+'.lua'&&mode==='before')return fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/phoenix-ritual-payment-before-repair',name),'utf8');
   return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let activated=false,done=false,turn=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:probe,controller:0,location:L.MZONE,sequence:4,position:P.FACEUP_ATTACK});
   add(ally,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(probe,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);
    turn+=messages.filter(m=>m.type===M.NEW_TURN).length;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===probe);assert(index>=0,'Fusion activation available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const locations=Object.fromEntries([L.MZONE,L.GRAVE,L.DECK].map(location=>[location,query(location).map(x=>x.code)]));
     assert.equal(locations[L.MZONE].includes(ally),scenario!=='replace'||mode!=='current','Ritual outcome');
     assert.equal(locations[L.MZONE].includes(boss),scenario==='replace','Retained Phoenix');
     console.log(JSON.stringify({boss,scenario,mode,locations}));done=true;
    }else if(p.type===M.SELECT_CHAIN){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.selects.some(x=>x.code===boss)?p.selects.findIndex(x=>x.code===boss):p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===boss});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done);
  }finally{core.destroyDuel(duel);}
 }
}main().catch(e=>{console.error(e);process.exitCode=1});
