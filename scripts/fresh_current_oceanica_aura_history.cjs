'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=['candidate','field-only','disabled-history','any-location','any-position','current-position'].find(v=>process.argv.includes('--'+v))||'prior-source',candidate=mode!=='prior-source',results=[];
 for(const test of [{late:true},{disabled:true},{late:true,defense:true},{late:true,grave:true},{late:true,toDefense:true},{late:true,defense:true,toAttack:true},{reenter:true},{late:true,fromDeck:true}]){
  const boss=259941091,body=900009821,change=900009822,summoner=900009823,filler=900009824,logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[body,{...base,code:body}],[change,{...base,code:change,type:2}],[summoner,{...base,code:summoner,type:2}],[filler,{...base,code:filler,type:2}]]);
  cards.set(900009825,{...base,code:900009825,type:2});
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c900009825.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,${boss}):GetFirst() assert(tc) assert(Duel.SendtoHand(tc,nil,REASON_EFFECT)==1) end) c:RegisterEffect(x) end`;
   if(name==='c'+boss+'.lua'){let lua=fs.readFileSync(path.join(OUT,'oceanica-before-aura-history-repair',name),'utf8');if(candidate)lua=require('./fresh_oceanica_aura_history_repair.cjs').corrected(lua);if(mode==='field-only')lua=lua.replace('ge:SetOperation(s.track_hand_summon)','ge:SetCondition(function(e) return e:GetOwner():IsLocation(LOCATION_FZONE) end) ge:SetOperation(s.track_hand_summon)');if(mode==='disabled-history')lua=lua.replace('ge:SetOperation(s.track_hand_summon)','ge:SetCondition(function(e) return not e:GetOwner():IsDisabled() end) ge:SetOperation(s.track_hand_summon)');if(mode==='any-location')lua=lua.replace(' and tc:IsPreviousLocation(LOCATION_HAND)','');if(mode==='any-position')lua=lua.replace('tc:IsAttackPos() and ','');if(mode==='current-position')lua=lua.replace('return c:GetFlagEffect(id)>0','return c:GetFlagEffect(id)>0 and c:IsAttackPos()');return lua;}
   if(name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_IGNITION) x:SetRange(LOCATION_MZONE) x:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(x) end';
   if(name==='c'+summoner+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND+LOCATION_GRAVE,0,nil,${body}):GetFirst() assert(tc) assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,${test.defense?'POS_FACEUP_DEFENSE':'POS_FACEUP_ATTACK'})==1) end) c:RegisterEffect(x) end`;
   if(name==='c'+change+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) local fc=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_FZONE,nil,${boss}):GetFirst() assert(fc) ${test.reenter?'Duel.SendtoHand(fc,nil,REASON_EFFECT)':'local a=Effect.CreateEffect(e:GetHandler()) a:SetType(EFFECT_TYPE_SINGLE) a:SetCode(EFFECT_DISABLE) a:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END) fc:RegisterEffect(a) local b=a:Clone() b:SetCode(EFFECT_DISABLE_EFFECT) fc:RegisterEffect(b)'} end) c:RegisterEffect(x) end`;
   const p=path.join(ROOT,'tmp/omega_scripts',name);assert(fs.existsSync(p),name);return fs.readFileSync(p,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,summoned=false,changed=false,activated=false,fieldActivated=false,positionChanged=false,fetched=false,turn=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,test.fromDeck?L.DECK:test.late?L.HAND:L.SZONE,0,test.late?0:5);if(test.fromDeck)add(900009825,L.HAND);add(body,test.grave?L.GRAVE:L.HAND,1);if(test.disabled||test.reenter)add(change,L.HAND,1);if(test.defense||test.grave)add(summoner,L.HAND,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(duel);
   for(let step=0;step<280&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);turn+=messages.filter(m=>m.type===M.NEW_TURN).length;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===0){if(turn>=3&&(test.late||test.reenter)&&!fieldActivated){if(test.fromDeck&&!fetched){const j=p.activates.findIndex(c=>c.code===900009825);assert(j>=0);fetched=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:j});continue;}const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Original field activation from Hand available');fieldActivated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(turn>=4){
      if((test.toDefense||test.toAttack)&&!positionChanged){const index=p.pos_changes.findIndex(c=>c.code===body);assert(index>=0);positionChanged=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_POS_CHANGE,index});continue;}
      const index=p.activates.findIndex(c=>c.code===body),locked=!test.defense&&!test.grave;assert.equal(index<0,locked,'Aura applies by actual Hand/Attack summon history after source entry/restoration');assert.equal(trace.filter(m=>m.type===M.RECOVER&&m.player===1).length,1,'Body demonstrably activated before source entry/restoration');if(test.late||test.reenter)assert(fieldActivated,'Actual original field activation');done=true;continue;
     }
     if(test.disabled&&!changed){const index=p.activates.findIndex(c=>c.code===change);assert(index>=0);changed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!summoned){const special=test.defense||test.grave,list=special?p.activates:p.summons,index=list.findIndex(c=>c.code===(special?summoner:body));assert(index>=0);summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:special?A.SELECT_ACTIVATE:A.SELECT_SUMMON,index});continue;}
     const index=p.activates.findIndex(c=>c.code===body);
     if(test.reenter&&!changed){assert(index<0,'Initial active source locks native Hand summon');const j=p.activates.findIndex(c=>c.code===change);assert(j>=0);changed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:j});continue;}
     assert(index>=0,'Body is free before source entry/restoration');if(!activated){activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4,5].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,logs,trace});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?' '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-oceanica-aura-history'+'-'+mode+'.json'),JSON.stringify({scope:'Full original Oceanica native field activation/restoration after actual Hand Normal or Hand/GY Special Summon, subsequent actual position changes and native recipient ignition. Neutral negation/return/summon supports. No Lua API mapping; not full-card/live Omega certification.',candidate,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
