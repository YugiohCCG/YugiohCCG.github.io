"use strict";
const fs=require('node:fs'),path=require('node:path');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273770,nonTuner=900002030,synchro=900002031,target=900002032,holder=900002033,setup=900002034,filler=900002035,counter=900002036;
 const base={alias:0,setcodes:[],type:33,level:4,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 const control=['no-material-recruit','no-counter-cost','ignore-material-reason'].find(f=>process.argv.includes('--'+f));
 for(const scenario of ['hand','grave','opponentCounters','splitCounters','insufficient','noCandidate','effectMove','banishRedirect','negateActivation','negateEffect','targetBanish','sourceBanish']){
  const legal=!['insufficient','noCandidate','effectMove','banishRedirect'].includes(scenario),interruption=['negateActivation','negateEffect','targetBanish','sourceBanish'].includes(scenario),recruits=legal&&!['negateActivation','negateEffect','targetBanish'].includes(scenario),amount=scenario==='insufficient'?2:3;
  const cards=new Map([[boss,candidateCard(boss)],[nonTuner,{...base,code:nonTuner,type:17}],[synchro,{...base,code:synchro,type:0x2001,level:5}],[target,{...base,code:target,type:17,setcodes:[0x1066]}],[holder,{...base,code:holder,type:0x20002}],[setup,{...base,code:setup,type:2}],[counter,{...base,code:counter,type:0x100004}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name===`c${synchro}.lua`)return require('./fresh_native_two_material_synchro.cjs').recipe(boss,nonTuner);
   if(name===`c${holder}.lua`)return 'local s,id=GetID() function s.initial_effect(c) c:EnableCounterPermit(0x35) end';
   if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) for player=0,1 do local h=Duel.GetMatchingGroup(Card.IsCode,player,LOCATION_SZONE,0,nil,${holder}):GetFirst() if h then local n=player==0 and ${scenario==='opponentCounters'?0:scenario==='splitCounters'?1:amount} or ${scenario==='opponentCounters'?3:scenario==='splitCounters'?2:0} if n>0 then h:AddCounter(0x35,n) assert(h:GetCounter(0x35)==n,'Counter setup failed') end end end local b=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() ${scenario==='effectMove'?`Duel.SendtoGrave(b,REASON_EFFECT)`:scenario==='banishRedirect'?`local r=Effect.CreateEffect(b) r:SetType(EFFECT_TYPE_SINGLE) r:SetCode(EFFECT_TO_GRAVE_REDIRECT) r:SetProperty(EFFECT_FLAG_CANNOT_DISABLE) r:SetValue(LOCATION_REMOVED) b:RegisterEffect(r)`:''} end) c:RegisterEffect(e) end`;
   if(name===`c${counter}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) and re:GetDescription()==${132273770*16+3} end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${scenario==='negateActivation'?'Duel.NegateActivation(ev)':scenario==='negateEffect'?'Duel.NegateEffect(ev)':scenario==='sourceBanish'?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':`Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_HAND+LOCATION_GRAVE,0,nil,${target}),POS_FACEUP,REASON_EFFECT)`} end) c:RegisterEffect(e) end`;
   if([nonTuner,target,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(control==='no-material-recruit'){const i=lua.indexOf('function s.materialop');lua=lua.slice(0,i)+lua.slice(i).replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)','do end');}if(control==='no-counter-cost')lua=lua.replace('Duel.RemoveCounter(tp,1,1,COUNTER_SYMPHONIC,3,REASON_COST)','do end');if(control==='ignore-material-reason')lua=lua.replace('and c:IsPreviousLocation(LOCATION_MZONE) and c:IsReason(REASON_MATERIAL) and c:IsReason(REASON_SYNCHRO)','and c:IsPreviousLocation(LOCATION_MZONE)');}return lua;
  };
  const logs=[],trace=[],duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,stage=0,offers=0,interrupted=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,position,sequence});
   add(boss,L.HAND);add(nonTuner,L.MZONE);add(synchro,L.EXTRA,0,P.FACEDOWN_DEFENSE);add(setup,L.HAND);add(holder,L.SZONE,0);add(holder,L.SZONE,1);if(scenario!=='noCandidate')add(target,scenario==='grave'?L.GRAVE:L.HAND);if(interruption)add(counter,L.SZONE,1,P.FACEDOWN_DEFENSE,1);for(const player of [0,1])for(let i=0;i<6;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(stage===0){const index=p.summons.findIndex(c=>c.code===boss);if(index<0)throw Error('Native Disccs Normal summon missing');stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});continue;}
     if(stage===1){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Counter setup unavailable');stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(stage===2&&scenario!=='effectMove'){const index=p.special_summons.findIndex(c=>c.code===synchro);if(index<0)throw Error('Native fixed Synchro recipe unavailable');stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     if(offers!==(legal?1:0))throw Error('Material trigger availability mismatch');
     const field=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE});if(field.some(c=>c?.code===target)!==recruits)throw Error('Material recruit outcome mismatch');
     const paid=trace.filter(t=>t.type===M.REMOVE_COUNTER&&t.counter_type===0x35).reduce((n,t)=>n+t.count,0);if(paid!==(legal?3:0))throw Error('Material counter cost mismatch '+paid);
     const dest=scenario==='banishRedirect'||scenario==='sourceBanish'?L.REMOVED:L.EXTRA,ex=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION|Q.REASON,controller:0,location:dest});if(!ex.some(c=>c?.code===boss))throw Error('Material destination mismatch');
     if(scenario!=='effectMove'){if(!trace.some(t=>t.type===M.MOVE&&t.card===boss&&t.from.location===L.MZONE&&t.to.location===(scenario==='banishRedirect'?L.REMOVED:L.EXTRA)))throw Error('Native Synchro material move missing');if(!field.some(c=>c?.code===synchro))throw Error('Native Synchro absent');}
     if(legal){const ci=trace.findIndex(t=>t.type===M.CHAINING&&t.code===boss&&String(t.description)===String(132273770*16+3)),end=trace.findIndex((t,i)=>i>ci&&t.type===M.CHAINED),payments=trace.map((t,i)=>t.type===M.REMOVE_COUNTER?i:-1).filter(i=>i>=0);if(!payments.length||payments.some(i=>i<=ci||i>=end))throw Error('Counter payment not activation cost');}
     if(interruption&&!trace.some(t=>t.type===M.CHAINING&&t.code===counter&&t.chain_size===2))throw Error('Native material interruption missing');done=true;
    }
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss||p.location!==L.EXTRA)throw Error('Unexpected optional trigger');offers++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CHAIN){const ci=p.selects.findIndex(c=>c.code===counter);if(ci>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:ci});continue;}const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(132273770*16+3));if(index>=0)offers++;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);if(index<0)throw Error('Material recruit candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_COUNTER){let left=p.count;const counters=p.cards.map(c=>{const n=Math.min(left,c.count);left-=n;return n;});if(left)throw Error('Counter selection underfunded');core.duelSetResponse(duel,{type:R.SELECT_COUNTER,counters});}
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({scenario,failure,offers,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${scenario}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-symphonic-disccs-monster-material${control?'-'+control:''}.json`),JSON.stringify({scope:'Complete Disccs/current installed metadata/corrected transport/no Lua API adapter. Native fixed two-material Synchro procedure validates Tuner/nonTuner/levels/material permissions; actual Pendulum material move and trigger, native counter payment on both fields, Hand/GY recruit, negative eligibility and CL2 interruptions. Neutral fixed recipe does not certify general Omega Synchro helper/live Omega.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
