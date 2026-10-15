'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[],control=['no-response','no-material','no-complete'].find(c=>process.argv.includes('--'+c));
 const material=900002301,target=900002302,probe=900002303,filler=900002304,response=900002305,late=900002306;
 const boss=259873115;
 for(const scenario of ['hand','extra','grave','protected','insufficient','wrongSet','sameName','fullHand','fullField','activation','effect','sourceBanish','targetBanish','materialBanish','lateFull']){
  const base={alias:0,setcodes:[],type:17,level:6,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0},trace=[],logs=[];
  const actualTarget=scenario==='sameName'?boss:target;
  const cards=new Map([[boss,candidateCard(boss)],[material,{...base,code:material,level:scenario==='insufficient'?5:6}],[target,{...base,code:target,type:0x10000a1,setcodes:scenario==='wrongSet'?[]:[0x9894]}],[probe,{...base,code:probe,type:33,level:0}],[filler,{...base,code:filler,level:0}],[response,{...base,code:response,type:0x100004}],[late,{...base,code:late,level:0}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+target+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() end';
   if(name==='c'+probe+'.lua')return `local s,id=GetID() function s.initial_effect(c) local prohibit=Effect.CreateEffect(c) prohibit:SetType(EFFECT_TYPE_SINGLE) prohibit:SetCode(EFFECT_UNRELEASABLE_NONSUM) prohibit:SetValue(1) c:RegisterEffect(prohibit) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetDescription(901) e:SetOperation(function(e,tp) ${['extra','grave'].includes(scenario)?`local rc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${target}) assert(Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0) rc:CompleteProcedure() assert(rc:IsSummonType(SUMMON_TYPE_RITUAL)) ${scenario==='extra'?'Duel.Destroy(rc,REASON_EFFECT)':'Duel.SendtoGrave(rc,REASON_EFFECT)'} Duel.Hint(HINT_NUMBER,tp,701)`:'Duel.Hint(HINT_NUMBER,tp,701)'} end) c:RegisterEffect(e) local ck=e:Clone() ck:SetDescription(902) ck:SetOperation(function(e,tp) local rc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${target}) local ok=rc and rc:IsSummonType(SUMMON_TYPE_RITUAL) and rc:IsStatus(STATUS_PROC_COMPLETE) Duel.Hint(HINT_NUMBER,tp,ok and 988 or 989) end) c:RegisterEffect(ck) end`;
   if(name==='c'+response+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:IsHasType(EFFECT_TYPE_IGNITION) and re:GetHandler():IsCode(${boss}) and re:GetHandler():IsLocation(LOCATION_PZONE) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':scenario==='activation'?'Duel.NegateActivation(ev)':scenario==='effect'?'Duel.NegateEffect(ev)':scenario==='sourceBanish'?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':scenario==='targetBanish'||scenario==='materialBanish'?`Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_HAND,0,nil,${scenario==='targetBanish'?target:material}),POS_FACEUP,REASON_EFFECT)`:`Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,${late}),0,1-tp,1-tp,false,false,POS_FACEUP)`} end) c:RegisterEffect(e) end`;
   if(name==='c'+material+'.lua')return 'local s,id=GetID() function s.initial_effect(c) '+(scenario==='protected'?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UNRELEASABLE_NONSUM) e:SetValue(1) c:RegisterEffect(e)':'')+' end';
   if([filler,late].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UNRELEASABLE_NONSUM) e:SetValue(1) c:RegisterEffect(e) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){if(process.argv.includes('--old-source'))lua=fs.readFileSync(path.join(OUT,'ritual-material-before-release-guard','c'+boss+'.lua'),'utf8');if(process.argv.includes('--candidate'))lua=lua.replace('return c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc)','return c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc) and c:IsReleasableByEffect()');if(control==='no-material')lua=lua.replace('Duel.ReleaseRitualMaterial(mat)','do end');if(control==='no-complete')lua=lua.replace('rc:CompleteProcedure()','do end');}return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),String(code));return cards.get(code);},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,prepared=false,activated=false,interrupted=false,observed=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(actualTarget,L.HAND);add(probe,L.MZONE,0,P.FACEUP_ATTACK,4);add(material,scenario==='fullField'?L.MZONE:L.HAND);
   if(['fullHand','fullField'].includes(scenario))for(let i=scenario==='fullField'?1:0;i<4;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);
   if(['activation','effect','sourceBanish','targetBanish','materialBanish','lateFull'].includes(scenario))add(response,L.SZONE,1,P.FACEDOWN_DEFENSE,1);
   if(scenario==='lateFull')for(let i=0;i<4;i++)add(late,L.DECK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location}).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(c=>c.code===probe&&Number(c.description)===901);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!placed){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);assert(index>=0);placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.SZONE);const eligible=!['protected','insufficient','wrongSet','sameName','fullHand'].includes(scenario);assert.equal(index>=0,eligible,'Printed Ritual eligibility');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const success=['hand','extra','grave','fullField'].includes(scenario);assert.equal(query(L.MZONE).some(c=>c.code===target),success,'Actual Ritual summon outcome');
     const released=trace.filter(m=>m.type===M.MOVE&&m.card===material&&m.to.location===L.GRAVE);assert.equal(released.length,success?1:0,'Actual Ritual material payment');
     const destroyed=trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.from.location===L.SZONE&&m.to.location===L.EXTRA);assert.equal(destroyed,!['activation','effect','sourceBanish'].includes(scenario),'Actual self destruction');
     const interruptedScenario=['activation','effect','sourceBanish','targetBanish','materialBanish','lateFull'].includes(scenario);assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===response&&m.chain_size===2).length,interruptedScenario?1:0,'Actual response CL2');
     if(['extra','grave'].includes(scenario))assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===701),'Actual prior Ritual history');
     if(scenario==='sourceBanish')assert(query(L.REMOVED).some(c=>c.code===boss));if(scenario==='targetBanish')assert(query(L.REMOVED).some(c=>c.code===target));if(scenario==='materialBanish')assert(query(L.REMOVED).some(c=>c.code===material));if(scenario==='lateFull')assert.equal(query(L.MZONE).filter(c=>c.code===late).length,4);
     if(success&&!observed){const index=p.activates.findIndex(c=>c.code===probe&&Number(c.description)===902);assert(index>=0);observed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(success)assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===988),'Native Ritual type/proper-summon status');done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);assert(index>=0,'Expected Ritual target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>c.code===material);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:(p.positions&P.FACEUP_ATTACK)?P.FACEUP_ATTACK:P.FACEUP_DEFENSE});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===response);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({passcode:boss,scenario,failure,trace,logs});if(failure)console.log('FAIL '+boss+' '+scenario+': '+failure);
 }
 fs.writeFileSync(path.join(OUT,'current-glitchling-leotron-pendulum-ritual'+(process.argv.includes('--old-source')?'-old-source':'')+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full Leotron native primary Pendulum Ritual effect, real self-destruction/material payments/Ritual type/proper-summon status. Current-spec Leotron, neutral Ritual Pendulum/resources and actual prior Ritual history for Extra/GY fixtures; native CL2 interruptions/late boundaries. Other Leotron effects, actual full Glitchling Ritual targets/counter supplementation/live Omega/fullcard remain open. No API shim',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');console.log(JSON.stringify({cases:results.length,passed:results.filter(r=>!r.failure).length}));if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
