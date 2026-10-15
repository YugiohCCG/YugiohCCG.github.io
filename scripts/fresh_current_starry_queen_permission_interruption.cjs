'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod,core=await mod.default({sync:true,print(){},printErr(){}});
 const boss=248760718,fairy=900002801,trap1=900002802,trap2=900002803,trap3=900002804,filler=900002805,counter=900002809;
 const control=['no-response','no-permission'].find(c=>process.argv.includes('--'+c)),results=[];
 for(const scenario of ['baseline','negateActivation','negateEffect','sourceBanish']){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:4n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[fairy,{...base,code:fairy}],[filler,{...base,code:filler}],[counter,{...base,code:counter,type:0x100004}],...[trap1,trap2,trap3].map(code=>[code,{...base,code,type:code===trap3&&scenario==='quickSpell'?0x10002:4,setcodes:code===trap3&&scenario==='wrongSet'?[]:[0x159],level:0,race:0n,attribute:0}])]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+counter+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) and re:GetActivateLocation()==LOCATION_MZONE end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':scenario==='negateActivation'?'Duel.NegateActivation(ev)':scenario==='negateEffect'?'Duel.NegateEffect(ev)':'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)'} Duel.Hint(HINT_NUMBER,tp,702) end) c:RegisterEffect(e) end`;
   if([fairy,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if([trap1,trap2,trap3].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,701) end) c:RegisterEffect(e) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='constant.lua')lua+='\nCHAININFO_TRIGGERING_ATTRIBUTE=22\n';
   if(name==='c'+boss+'.lua'){if(control==='no-permission')lua=lua.replace('Duel.RegisterEffect(e1,tp)','do end');if(control==='unlimited')lua=lua.replace('e1:SetCountLimit(1)','e1:SetCountLimit(3)');if(control==='wrong-target')lua=lua.replace('return c:IsSetCard(0x159) and c:IsType(TYPE_TRAP) and c:IsStatus(STATUS_SET_TURN)','return true');}return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),String(code));return cards.get(code);},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,setCount=0,activated=false,interrupted=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE);if(scenario!=='baseline')add(counter,L.SZONE,1,P.FACEDOWN_DEFENSE,1);if(scenario!=='noReveal')add(fairy,L.HAND);for(const code of [trap1,trap2,trap3])add(code,L.HAND);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);const query=location=>core.duelQueryLocation(duel,{flags:mod.OcgQueryFlags.CODE,controller:0,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(setCount<3){const code=[trap1,trap2,trap3][setCount++];const index=p.spell_sets.findIndex(c=>c.code===code);assert(index>=0,'Actual Hand Trap Set');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPELL_SET,index});continue;}
     if(!placed){assert(!p.activates.some(c=>[trap1,trap2,trap3].includes(c.code)),'Same-turn Set cards initially unavailable');const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,scenario!=='noReveal','Actual reveal/PZone cost eligibility');if(scenario==='noReveal'){done=true;continue;}placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(scenario==='sourceBanish'?L.REMOVED:L.SZONE).some(c=>c.code===boss),'Actual paid cost/source lifecycle');
     assert(trace.some(m=>m.type===M.CONFIRM_CARDS&&m.cards.some(c=>c.code===fairy)),'Actual LIGHT Fairy reveal');const start=trace.findIndex(m=>m.type===M.CHAINING&&m.code===boss);const chained=start+trace.slice(start).findIndex(m=>m.type===M.CHAINED);const moved=trace.findIndex(m=>m.type===M.MOVE&&m.card===boss&&m.from.location===L.MZONE&&m.to.location===L.SZONE);assert(start>=0&&chained>start&&moved>start&&moved<chained,'PZone movement paid as cost before CHAINED');
     assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===counter&&m.chain_size===2).length,scenario==='baseline'?0:1,'Actual CL2 interruption');
     if(['negateActivation','negateEffect'].includes(scenario)){assert(!p.activates.some(c=>[trap1,trap2,trap3].includes(c.code)),'Negated effect grants no Setturn permission');done=true;continue;}
     if(!activated){assert(p.activates.some(c=>c.code===trap1),'Resolving effect grants permission even after source banishment');activated=true;const index=p.activates.findIndex(c=>c.code===trap1);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.GRAVE).some(c=>c.code===trap1),'Trap actually resolves');assert(!p.activates.some(c=>[trap2,trap3].includes(c.code)),'Permission still limited to one');done=true;
    }else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===counter);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===fairy);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({scenario,failure,trace,logs});if(failure)console.log('FAIL '+scenario+': '+failure);
 }
 fs.writeFileSync(path.join(OUT,'current-starry-queen-permission-interruption'+(process.argv.includes('--modern-chain-info')?'-modern-chain-info':'')+(process.argv.includes('--old-source')?'-old-source':'')+(process.argv.includes('--quick-candidate')?'-quick-candidate':'')+(process.argv.includes('--solved-candidate')?'-solved-candidate':'')+(process.argv.includes('--delay-candidate')?'-delay-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full StarryQueen permission actualcost/reveal/PZoneMovebeforeCHAINED, nativeCL2 CounterTrap activationnegation/effectnegation/sourcebanishment. Negationgrantsnothing whilecostretained; sourcebanishmentstillpermitsonefreshTrapactivation. CorrectedCardData/legacychainattribute22mapping, compatibilitydiagnosticnotunadaptedOmega/fullcard. Sharednameduse/resetother effects open',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');console.log(JSON.stringify({cases:results.length,passed:results.filter(r=>!r.failure).length}));if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
