'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const boss=Number(process.argv[2]||239245471), ally=boss===239245471?245099829:223512283, top=900004402, filler=900004403, token=240299293, mode=process.argv[3]||'current';
 for(const scenario of ['normal','replace','redirect']){
  const logs=[],base={alias:0,setcodes:[0x67ee],type:17,level:9,attribute:16,race:8192n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[token,candidateCard(token)],[boss,candidateCard(boss)],[ally,candidateCard(ally)],[top,{...base,code:top}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c'+token+'.lua'||name==='c0.lua'||name==='c'+filler+'.lua')return '';
   if(name==='c'+top+'.lua')return scenario==='normal'?'':scenario==='replace'?
    'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetCode(EFFECT_SEND_REPLACE) e:SetRange(LOCATION_MZONE) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) return eg:IsContains(e:GetHandler()) and e:GetHandler():IsReason(REASON_FUSION) end) e:SetValue(function(e,tc) return tc==e:GetHandler() end) c:RegisterEffect(e) end':
    'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_LEAVE_FIELD_REDIRECT) e:SetProperty(EFFECT_FLAG_CANNOT_DISABLE) e:SetValue(LOCATION_REMOVED) c:RegisterEffect(e) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,name);
   if(name==='c'+boss+'.lua'&&mode==='before'){
    return fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/azrynior-material-movement-before-repair',name),'utf8');
   }
   const lua=fs.readFileSync(file,'utf8'); return name==='c'+boss+'.lua'&&mode==='candidate'?lua.replace('Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)','if Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)~=#mat then return end'):lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   core.loadScript(duel,'empty-mandatory.lua','aux.MustMaterialCheck=function() return true end');
   if(boss===224751741)core.loadScript(duel,'neutral-dragon-attribute.lua','Card.IsFusionAttribute=function(c,a) assert(c:IsCode(900004402)) return c:IsAttribute(a) end');
   add(boss,L.HAND);
   core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});
   
   add(ally,L.EXTRA);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===boss);assert(index>=0,'Fusion activation available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const locations=Object.fromEntries([L.MZONE,L.GRAVE,L.REMOVED].map(location=>[location,query(location).map(x=>x.code)]));
     assert.equal(locations[L.MZONE].includes(ally),scenario!=='replace'||mode==='before','Fusion outcome');
     assert.equal(locations[L.MZONE].includes(top),scenario==='replace','Retained material');
     assert.equal(locations[L.GRAVE].includes(top),scenario==='normal','Graveyard material');
     assert.equal(locations[L.REMOVED].includes(top),scenario==='redirect','Redirected material');
     assert(!locations[L.MZONE].includes(token),'Token consumed');
     console.log(JSON.stringify({boss,scenario,mode,locations}));done=true;
    }else if(p.type===M.SELECT_CHAIN){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done);
  }finally{core.destroyDuel(duel);}
 }
}main().catch(e=>{console.error(e);process.exitCode=1});
