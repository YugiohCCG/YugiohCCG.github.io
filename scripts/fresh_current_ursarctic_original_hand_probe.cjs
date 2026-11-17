'use strict';const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),compat=process.argv.includes('--core-compat'),CUSTOM=process.env.CCG_OMEGA_SCRIPTS||path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),STOCK=path.join(ROOT,'tmp/omega_scripts');(async()=>{const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
for(const source of [218837030,245378354])for(const mode of (compat?['low level','ordinary','lock and limit','opponent Main Phase','Departure','Big Dipper','Big Dipper wrong set','Leoship','Leoship wrong set','Leoship Hand','Leoship shared provider limit','Leoship full field','Leoship face-down full field']:['ordinary'])){const level=mode==='low level'?6:7,extended=mode==='lock and limit',opponentCase=mode==='opponent Main Phase';const providerLimit=mode==='Leoship shared provider limit';
 const other=source===218837030?245378354:218837030;
 const leoship=mode.startsWith('Leoship'),bigDipper=mode.startsWith('Big Dipper');
 const replacement=mode==='Departure'||bigDipper||leoship;
 const wrongSet=mode.endsWith('wrong set'),full=mode.endsWith('full field'),faceDown=mode.includes('face-down');
 const provider=mode==='Departure'?16471775:bigDipper?89264428:247831166;
 const cost=900010011,filler=900010012,helper=900010013,rank=900010014,leveled=900010015,logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:7,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0},cards=new Map([[source,candidateCard(source)],[cost,{...base,code:cost,level,setcodes:replacement&&!wrongSet?[0x163]:[]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper}],[rank,{...base,code:rank,type:0x800021,level:4}],[leveled,{...base,code:leveled}]]);if(providerLimit)cards.set(other,candidateCard(other));
if(replacement)cards.set(provider,provider===247831166?candidateCard(provider):{
 ...base,code:provider,type:provider===89264428?0x80002:2,setcodes:[0x163]
});const reader=n=>{if(n==='c0.lua')return '';if(n==='c'+helper+'.lua')return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_IGNITION)
 e:SetRange(LOCATION_MZONE)
 e:SetOperation(function(e,tp)
  local rank=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${rank}):GetFirst()
  local leveled=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${leveled}):GetFirst()
  if ${opponentCase} then return end
  rank:CompleteProcedure()
  local summoned=Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,1,nil,${source})
  local locked=summoned and Duel.GetTurnCount()==1
  assert(rank:IsCanBeSpecialSummoned(e,0,tp,false,false)==not locked,'Rank monster follows the active Level restriction')
  if leveled then
   assert(leveled:IsCanBeSpecialSummoned(e,0,tp,false,false),'Monster with a Level remains legal')
   if locked then assert(Duel.SpecialSummon(leveled,0,tp,tp,false,false,POS_FACEUP_ATTACK)==1) end
  end
 end)
 c:RegisterEffect(e)
 if ${opponentCase} then
  local standby=Effect.CreateEffect(c)
  standby:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F)
  standby:SetCode(EVENT_PHASE+PHASE_STANDBY)
  standby:SetRange(LOCATION_MZONE)
  standby:SetCountLimit(1)
  standby:SetCondition(function(e,tp) return Duel.GetTurnPlayer()==tp end)
  standby:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end)
  c:RegisterEffect(standby)
 end
end`;if([cost,filler,rank,leveled].some(i=>n==='c'+i+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const f=[path.join(CUSTOM,n),path.join(STOCK,n)].find(fs.existsSync);assert(f,n);return fs.readFileSync(f,'utf8')};const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,activated=false,done=false,checkedBefore=false,checkedAfter=false,expiryStarted=false,expiryChecked=false,opponentStarted=false,standbyChained=false,turn=0,phase=0;
try{for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));if(compat)assert(core.loadScript(d,'omega-ursarctic-hand-api.lua','Effect.IsCostChecked=Effect.IsCostChecked or function() return false end'));const add=(code,location,p=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location,sequence,position});
add(source,L.HAND);
if(replacement){
 if(provider===16471775)add(provider,L.GRAVE);
 else{
  add(provider,L.SZONE,0,bigDipper?5:0);
  if(full){
   add(cost,L.MZONE,0,0,faceDown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);
   for(let i=1;i<5;i++)add(leveled,L.MZONE,0,i);
  }else add(cost,mode==='Leoship Hand'?L.HAND:L.GRAVE);
 }
}else add(cost,L.HAND);if(providerLimit){add(other,L.HAND);add(cost,L.GRAVE);}
if(opponentCase)add(helper,L.MZONE,1);if(extended){add(source,L.HAND);add(cost,L.HAND);add(helper,L.MZONE);add(rank,L.GRAVE);add(leveled,L.GRAVE);}for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE,controller:0,location:loc}).filter(Boolean);
for(let step=0;step<90&&!done;step++){const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);for(const m of messages){if(m.type===M.NEW_TURN)turn++;if(m.type===M.NEW_PHASE)phase=m.phase;if(m.type===M.CHAINING&&m.code===helper&&phase===2&&turn===2)standbyChained=true;}if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Unexpected end');if(state!==S.WAITING)continue;const p=messages.at(-1);if(p.type===M.SELECT_IDLECMD){
 if(opponentCase){
  if(turn===1){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
  if(!opponentStarted){
   const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Opponent Main Phase ignition');
   opponentStarted=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;
  }
  assert(standbyChained,'Opponent Standby Phase chain occurred');
  assert(activated&&query(L.MZONE).some(c=>c.code===source)&&query(L.GRAVE).some(c=>c.code===cost),'Opponent Main Phase Hand summon resolved');
  done=true;continue;
 }
 if(expiryStarted){
  if(turn<3){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
  if(!expiryChecked){
   expiryChecked=true;
   const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Expiry check fixture is available');
   core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;
  }
  assert(p.activates.some(c=>c.code===source),'Remaining copy is available on a later turn');
  done=true;continue;
 }
 if(extended&&(!checkedBefore||activated&&!checkedAfter)){
 if(!checkedBefore)checkedBefore=true;else checkedAfter=true;
 const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'The summon check fixture is available');
 core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;
}if(!activated){const index=p.activates.findIndex(c=>c.code===source);assert.equal(index>=0,level>=7&&!wrongSet&&!faceDown,'Hand activation respects available payment');if(level<7||wrongSet||faceDown){done=true;continue;}if(providerLimit)assert(p.activates.some(c=>c.code===other),'Other Ursarctic can use Leoship before payment');if(extended)assert.equal(p.activates.filter(c=>c.code===source).length,2,'Both copies are legal with unused count');activated=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.MZONE).some(c=>c.code===source),'Actual original self-summon');if(replacement)assert(query(L.REMOVED).some(c=>c.code===(provider===16471775?provider:cost)),'Replacement was banished');
else assert(query(L.GRAVE).some(c=>c.code===cost),'Actual other Level7 Hand Tribute paid');
if(providerLimit){
 assert(query(L.HAND).some(c=>c.code===other)&&query(L.GRAVE).some(c=>c.code===cost),'Other source and replacement remain available');
 assert(!p.activates.some(c=>c.code===other),'Different Ursarctic sources share Leoship replacement limit');
}if(extended){assert(query(L.MZONE).some(c=>c.code===leveled),'Actual summon of monster with a Level');assert(query(L.HAND).some(c=>c.code===source)&&query(L.HAND).some(c=>c.code===cost),'Second copy and Tribute remain in Hand');assert(!p.activates.some(c=>c.code===source),'Second copy shares the summon limit');expiryStarted=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}done=true;}
else if(p.type===M.SELECT_CHAIN){
 const index=p.selects.findIndex(c=>c.code===source);
 if(opponentCase&&![4,256].includes(phase))assert.equal(index,-1,'Hand summon is unavailable outside a Main Phase');
 const use=opponentCase&&opponentStarted&&!activated&&index>=0;
 if(use)activated=true;
 core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:use?index:p.forced?0:null});
}else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(d,{type:R.SELECT_EFFECTYN,yes:false});else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(replacement&&provider===16471775?provider:cost));assert(index>=0);core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:[index]});}else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));}assert(done,'Step limit');}catch(e){failure=e.message}finally{core.destroyDuel(d)}results.push({source,mode,level,failure,logs,trace});console.log((failure?'FAIL ':'PASS ')+source+' '+mode+(failure?': '+failure:''));}fs.writeFileSync(path.join(OUT,'current-ursarctic-original-hand-probe'+(compat?'-core-compat':'')+'.json'),JSON.stringify({compat,scriptDirectory:CUSTOM,scope:'Full original two Ursarctic sources/installed metadata, Hand Tribute threshold, native self-summon, opponent Main Phase response, applied Level lock and expiry, cross-copy Hand use limit, and stock/custom replacement payments. Compatibility mode bridges IsCostChecked only for open-zone fixtures. Other effects/full cards/live Omega unverified.',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(compat&&results.some(r=>r.failure))process.exitCode=1;})().catch(e=>{console.error(e);process.exitCode=1});
