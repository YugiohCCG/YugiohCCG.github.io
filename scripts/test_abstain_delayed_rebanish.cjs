'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=process.env.CCG_OMEGA_SCRIPTS||path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const boss=232449539, ally=900006202, top=225091736, filler=216958556, probe=900006204, mode=process.argv[2]||'current';
 for(const scenario of ['normal','rebanish']){
  const logs=[],base={alias:0,setcodes:[0xbc5],type:17,level:2,attribute:2,race:4n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[ally,{...base,code:ally,type:0x61,race:0x4000n,attribute:16}],[top,{...base,code:top}],[filler,{...base,code:filler}],[probe,{...base,code:probe}]]);
  const reader=name=>{
   if(name==='c0.lua')return ''; if([top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+probe+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_REMOVED,nil,225091736) assert(tc) Duel.SendtoGrave(tc,REASON_EFFECT) Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(name==='c'+ally+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_FUSION_MATERIAL) e:SetCondition(function(e,g) return g and g:IsExists(Card.IsCode,1,nil,216958556) and g:IsExists(Card.IsCode,1,nil,225091736) end) e:SetOperation(function(e,tp,eg) Duel.SetFusionMaterial(Group.FromCards(eg:Filter(Card.IsCode,nil,216958556):GetFirst(),eg:Filter(Card.IsCode,nil,225091736):GetFirst())) end) c:RegisterEffect(e) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,name);
   if(name==='c'+boss+'.lua'&&mode==='before')return fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/abstain-deck-material-movement-before-repair',name),'utf8');
   let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'&&mode==='candidate'){lua=lua.replace('local rg=g:Filter(Card.IsLocation,nil,LOCATION_REMOVED)','local rg=g:Filter(function(c,fid) return c:IsLocation(LOCATION_REMOVED) and c:GetFlagEffectLabel(id+300)==fid end,nil,e:GetLabel())').replace('if #g==0 then return end\n\tg:KeepAlive()','if #g==0 then return end\n\tlocal fid=e:GetHandler():GetFieldID() for tc in aux.Next(g) do tc:RegisterFlagEffect(id+300,RESET_EVENT+RESETS_STANDARD,0,1,fid) end\n\tg:KeepAlive()').replace('e1:SetLabelObject(g)\n\te1:SetOperation(s.retop)','e1:SetLabelObject(g)\n\te1:SetLabel(fid)\n\te1:SetOperation(s.retop)')}return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let activated=false,done=false,moved=false,ended=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(probe,L.MZONE);core.duelNewCard(duel,{team:1,duelist:0,code:top,controller:1,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});core.duelNewCard(duel,{team:1,duelist:0,code:filler,controller:1,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});
   add(ally,L.EXTRA);for(const player of [0,1])for(let i=0;i<8;i++)add(probe,L.DECK,player);
   assert(core.loadScript(duel,'neutral-eligibility.lua','Duel.RegisterFlagEffect(0,232449539,RESET_PHASE+PHASE_END,0,1)'));
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:location===L.REMOVED?1:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===boss);assert(index>=0,'Fusion activation available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(p.player===1){const removed=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.REMOVED}).filter(Boolean);const grave=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.GRAVE}).filter(Boolean);assert.equal(removed.some(c=>c.code===top),scenario==='rebanish','rebanished card location mismatch');assert(grave.some(c=>c.code===filler),'unchanged banished material did not return');if(scenario==='normal')assert(grave.some(c=>c.code===top),'normal material did not return');done=true;continue;}
     if(scenario==='rebanish'&&!moved){const idx=p.activates.findIndex(x=>x.code===probe);assert(idx>=0,'rebanish fixture unavailable');moved=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:idx});continue;}if(!ended){ended=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});

    }else if(p.type===M.SELECT_CHAIN){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:Number(p.description)===133410628*16+3});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done);console.log('PASS '+scenario);
  }catch(e){console.log('FAIL '+scenario+' '+e.message);process.exitCode=1}finally{core.destroyDuel(duel);}
 }
}main().catch(e=>{console.error(e);process.exitCode=1});
