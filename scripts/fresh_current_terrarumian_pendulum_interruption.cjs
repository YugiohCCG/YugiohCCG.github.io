'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[],control=['no-response','no-summon'].find(c=>process.argv.includes('--'+c));
 const fodder=900002001,ally=900002002,deckPend=900002003,filler=900002004,response=900002005,late=900002006;
 for(let boss=284639717;boss<=284639724;boss++)for(const scenario of ['baseline','activation','effect','sourceBanish','resourcesBanish','lateFull','lateLock']){
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
    if(control==='no-relation')lua=lua.replace(/not c:IsRelateToEffect\(e\)\s+or /g,'');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),String(code));return cards.get(code);},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,activated=false,interrupted=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(fodder,L.SZONE,0,P.FACEUP_ATTACK,1);add(ally,L.MZONE);add(filler,L.MZONE,1);add(deckPend,L.DECK);
   if(scenario!=='baseline')add(response,L.SZONE,1,P.FACEDOWN_DEFENSE,1);
   if(scenario==='lateFull'||scenario==='lateLock')for(let i=0;i<(scenario==='lateFull'?4:1);i++)add(late,L.DECK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location}).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!placed){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);assert(index>=0,'Actual Pendulum card placement');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.SZONE);assert(index>=0,'Primary Pendulum effect available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(interrupted,scenario!=='baseline','Actual CL2 response');
     assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===response&&m.chain_size===2).length,scenario==='baseline'?0:1,'Native response actually chains at CL2');
     assert.equal(query(L.MZONE).some(c=>c.code===boss),scenario==='baseline'||boss===284639723&&scenario==='lateFull','Actual self summon outcome');
     const destruction=trace.some(m=>m.type===M.MOVE&&m.card===fodder&&m.to.location===L.GRAVE);
     assert.equal(destruction,['baseline','lateFull','lateLock'].includes(scenario)&&!(boss===284639723&&scenario==='lateFull'),'Destruction occurs only when resolving related source with resources');
     if(boss===284639723&&scenario==='lateFull')assert(trace.some(m=>m.type===M.MOVE&&m.card===ally&&m.to.location===L.GRAVE),'Sundew actually frees its full monster zone');
     if(scenario==='sourceBanish')assert(query(L.REMOVED).some(c=>c.code===boss),'Actual source banishment');
     if(scenario==='resourcesBanish')for(const code of [fodder,ally])assert(query(L.REMOVED).some(c=>c.code===code),'Actual resource banishment');
     if(scenario==='lateFull'||scenario==='lateLock')assert.equal(query(L.MZONE).filter(c=>c.code===late).length,scenario==='lateFull'?4:1,'Actual late zone fill/lock');
     if(scenario==='baseline'&&boss<=284639719)assert(query(L.SZONE).some(c=>c.code===deckPend),'Actual subsequent Deck-to-Pendulum placement');
     assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Native primary effect chain');done=true;
    }else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===fodder);if(index<0)index=p.selects.findIndex(c=>c.code===deckPend);if(index<0&&boss===284639723&&scenario==='lateFull')index=p.selects.findIndex(c=>c.code===ally);assert(index>=0,'Expected native resolution choice');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:(p.positions&P.FACEUP_ATTACK)?P.FACEUP_ATTACK:P.FACEUP_DEFENSE});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===response);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({passcode:boss,scenario,failure,trace,logs});if(failure)console.log('FAIL '+boss+' '+scenario+': '+failure);
 }
 fs.writeFileSync(path.join(OUT,'current-terrarumian-pendulum-interruption'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'All eight full production Terrarumian Pendulum scripts; actual native hand-to-PZone activation, primary self-summon with real CL2 negation/source removal/resource removal/late capacity/late summon lock. Current-spec metadata; neutral resources and CounterTrap. Optional secondary summons declined. No API adapter, live Omega or full-card certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');console.log(JSON.stringify({cases:results.length,passed:results.filter(r=>!r.failure).length}));if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
