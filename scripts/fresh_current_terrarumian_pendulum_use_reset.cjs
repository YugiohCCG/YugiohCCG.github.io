'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[],control=['per-copy','no-summon'].find(c=>process.argv.includes('--'+c));
 const fodder=900002001,ally=900002002,deckPend=900002003,filler=900002004,response=900002005,late=900002006;
 for(let boss=284639717;boss<=284639724;boss++)for(const scenario of ['success','activation','effect']){
  const base={alias:0,setcodes:[],type:17,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[fodder,{...base,code:fodder,type:0x20002,setcodes:[0xa122]}],[ally,{...base,code:ally,setcodes:[0xa122]}],[deckPend,{...base,code:deckPend,type:0x1000021,setcodes:[0xa122]}],[filler,{...base,code:filler}],[response,{...base,code:response,type:0x100004}],[late,{...base,code:late,type:33}]]),trace=[],logs=[];
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+response+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:IsHasType(EFFECT_TYPE_IGNITION) and re:GetHandler():IsCode(${boss}) and re:GetHandler():IsLocation(LOCATION_PZONE) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':scenario==='activation'?'Duel.NegateActivation(ev)':scenario==='effect'?'Duel.NegateEffect(ev)':scenario==='sourceBanish'?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':scenario==='resourcesBanish'?`Duel.Remove(Duel.GetMatchingGroup(function(c) return c:IsCode(${fodder},${ally}) end,1-tp,LOCATION_ONFIELD,0,nil),POS_FACEUP,REASON_EFFECT)`:`Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,${late}),0,1-tp,1-tp,false,false,POS_FACEUP)`} end) c:RegisterEffect(e) end`;
   if(name==='c'+late+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${scenario==='lateLock'?`local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetRange(LOCATION_MZONE) e:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON) e:SetProperty(EFFECT_FLAG_PLAYER_TARGET) e:SetTargetRange(1,0) e:SetTarget(function(e,c) return c:IsCode(${boss}) end) c:RegisterEffect(e)`:''} end`;
   if([fodder,ally,deckPend,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-summon')lua=lua.replaceAll('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)','(function() return 0 end)()').replaceAll('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP_DEFENSE)','(function() return 0 end)()');
    if(control==='per-copy'){const key=boss===284639721?'id+100':'id';lua=lua.replace(':SetCountLimit(1,'+key+')',':SetCountLimit(1)');}
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),String(code));return cards.get(code);},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=0,stage=0,turn=0,activated=false,interrupted=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(boss,L.HAND);for(let i=1;i<=3;i++)add(fodder,L.SZONE,0,P.FACEUP_ATTACK,i);add(ally,L.MZONE);add(filler,L.MZONE,1);for(let i=0;i<3;i++)add(deckPend,L.DECK);
   if(scenario!=='success')add(response,L.SZONE,1,P.FACEDOWN_DEFENSE,1);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location}).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);turn+=messages.filter(m=>m.type===M.NEW_TURN).length;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player!==0){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(placed<2&&stage===placed){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);assert(index>=0,'Actual next copy placement');placed++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(stage===1&&placed===2){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.SZONE);if(turn<3)assert(index<0,'Second-copy primary named use excluded');if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}}
     if(stage<2){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.SZONE);assert(index>=0,'Primary available initially/after reset');stage++;activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(interrupted,scenario!=='success','Real first-use CL2 negation');const count=trace.filter(m=>m.type===M.MOVE&&m.card===boss&&m.from.location===L.SZONE&&m.to.location===L.MZONE).length;assert.equal(count,scenario==='success'?2:1,'Actual primary outcomes across natural reset');assert(turn>=3,'Next own turn reached');done=true;
    }else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===fodder);if(index<0)index=p.selects.findIndex(c=>c.code===deckPend);if(index<0&&boss===284639723&&scenario==='lateFull')index=p.selects.findIndex(c=>c.code===ally);assert(index>=0,'Expected native resolution choice');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:(p.positions&P.FACEUP_ATTACK)?P.FACEUP_ATTACK:P.FACEUP_DEFENSE});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===response);if(index>=0&&!interrupted&&stage===1){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({passcode:boss,scenario,turn,failure,trace,logs});if(failure)console.log('FAIL '+boss+' '+scenario+': '+failure);
 }
 fs.writeFileSync(path.join(OUT,'current-terrarumian-pendulum-use-reset'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'All eight full production scripts/current installed metadata/corrected transport/no Lua adapter. Actual Hand-to-PZone placement of two copies: first successful/activation-negated/effect-negated use, second-copy same-turn exclusion, next-own-turn second-copy reuse with actual primary summon moves. Neutral resources and declined optional secondary effects. No full-card/live Omega certification',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');console.log(JSON.stringify({cases:results.length,passed:results.filter(r=>!r.failure).length}));if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
