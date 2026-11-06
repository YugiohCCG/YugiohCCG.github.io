"use strict";
const fs=require('node:fs'),path=require('node:path');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273770,member=900002010,filler=900002011,pend=900002012,prep=900002013,probe=900002014,second=900002015,expiry=900002016,counter=900002017;
 const darkFusion=900002020,windFusion=900002021,darkSynchro=900002022,windSynchro=900002023,prior=900002024;
 const base={alias:0,setcodes:[],type:33,level:4,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 const control=['no-activity','no-lock','no-expiry','per-copy','no-use-reset'].find(f=>process.argv.includes('--'+f));
 for(const scenario of ['baseline','priorDarkFusion','priorWindFusion','priorDarkSynchro','priorWindSynchro','priorFaceup','negateActivation','negateEffect','sourceBanish']){
  const forbidden=['priorDarkFusion','priorWindFusion','priorDarkSynchro'].includes(scenario),hasPrior=scenario.startsWith('prior'),locked=!forbidden&&scenario!=='negateActivation',negated=scenario.startsWith('negate');
  const cards=new Map([[boss,candidateCard(boss)],[member,{...base,code:member,setcodes:[0x1066]}],[filler,{...base,code:filler}],[pend,{...base,code:pend,type:0x1000021,lscale:7,rscale:7}]]);
  for(const code of [prep,probe,second,expiry,counter])cards.set(code,{...base,code,type:code===counter?0x100004:2});
  for(const [code,type,attribute] of [[darkFusion,0x41,32],[windFusion,0x41,8],[darkSynchro,0x2001,32],[windSynchro,0x2001,8],[prior,scenario.includes('Synchro')?0x2001:0x41,scenario.includes('Wind')?8:32]])cards.set(code,{...base,code,type,attribute});
  const priorCode=scenario==='priorFaceup'?pend:prior;
  const reader=name=>{
   if(name===`c${prep}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${pend}):GetFirst() assert(c,'Hand Pendulum missing') assert(Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0,'Hand preparation failed') assert(c:IsLocation(LOCATION_MZONE),'Preparation field origin missing') Duel.SendtoGrave(c,REASON_EFFECT) assert(c:IsLocation(LOCATION_EXTRA) and c:IsFaceup(),'Pendulum redirect missing') ${hasPrior?`local p=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${priorCode}):GetFirst() assert(p and Duel.SpecialSummon(p,0,tp,tp,true,true,POS_FACEUP)>0,'Prior Extra summon failed')`:''} end) c:RegisterEffect(e) end`;
   if(name===`c${second}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}):GetFirst() assert(c and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0,'Second Disccs summon failed') end) c:RegisterEffect(e) end`;
   if(name===`c${probe}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local function card(code) return Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,code):GetFirst() end for _,code in ipairs({${darkFusion},${windFusion},${darkSynchro}}) do assert(card(code):IsCanBeSpecialSummoned(e,0,tp,true,true)==${locked?'false':'true'},'Facedown Extra restriction mismatch') end assert(card(${windSynchro}):IsCanBeSpecialSummoned(e,0,tp,true,true),'WIND Synchro blocked') ${scenario==='priorFaceup'?'':`assert(card(${pend}):IsFaceup() and card(${pend}):IsCanBeSpecialSummoned(e,0,tp,false,false),'Faceup Extra blocked')`} ${!hasPrior?`assert(Duel.SpecialSummon(card(${windSynchro}),0,tp,tp,true,true,POS_FACEUP)>0,'Actual permitted WIND Synchro-type summon failed') assert(Duel.SpecialSummon(card(${pend}),0,tp,tp,false,false,POS_FACEUP)>0,'Actual permitted faceup Pendulum summon failed')`:''} Duel.Hint(HINT_NUMBER,tp,731) end) c:RegisterEffect(e) end`;
   if(name===`c${expiry}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local dark=Duel.GetMatchingGroup(Card.IsCode,0,LOCATION_EXTRA,0,nil,${darkFusion}):GetFirst() assert(dark:IsCanBeSpecialSummoned(e,0,0,true,true),'Oath expiry failed') assert(Duel.SpecialSummon(dark,0,0,0,true,true,POS_FACEUP)>0,'Actual expired-lock DARK Extra summon failed') Duel.SendtoHand(Duel.GetMatchingGroup(Card.IsCode,0,LOCATION_MZONE,0,nil,${boss}),nil,REASON_EFFECT) Duel.Hint(HINT_NUMBER,tp,732) end) c:RegisterEffect(e) end`;
   if(name===`c${counter}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) and re:GetDescription()==${132273770*16+1} end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${scenario==='negateActivation'?'Duel.NegateActivation(ev)':scenario==='negateEffect'?'Duel.NegateEffect(ev)':'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)'} end) c:RegisterEffect(e) end`;
   if(name===`c${pend}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if([member,filler,darkFusion,windFusion,darkSynchro,windSynchro,prior].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name===`c${boss}.lua`){if(control==='no-activity')lua=lua.replace('Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0','true');if(control==='no-lock')lua=lua.replace('Duel.RegisterEffect(lock,tp)','do end');if(control==='no-expiry')lua=lua.replace('lock:SetReset(RESET_PHASE+PHASE_END)','do end');if(control==='per-copy')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1)');if(control==='no-use-reset')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1,id+100,2)');}return lua;
  };
  const logs=[],trace=[],duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,turn=0,stage=0,offers=0,interrupted=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,position,sequence});
   for(const code of [boss,boss,pend,prep,probe,second])add(code,L.HAND);add(expiry,L.HAND,1);
   for(const code of [darkFusion,windFusion,darkSynchro,windSynchro,prior])add(code,L.EXTRA,0,P.FACEDOWN_DEFENSE);
   for(let i=0;i<3;i++)add(member,L.DECK);if(negated||scenario==='sourceBanish')add(counter,L.SZONE,1,P.FACEDOWN_DEFENSE);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<350&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    const activate=code=>{const index=p.activates.findIndex(c=>c.code===code);if(index<0)throw Error('Fixture activation unavailable '+code);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});};
    const normal=()=>{const index=p.summons.findIndex(c=>c.code===boss);if(index<0)throw Error('Normal Disccs unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});};
    if(p.type===M.SELECT_IDLECMD){
     if(turn===1){if(stage===0){stage++;activate(prep);continue;}if(stage===1){stage++;normal();continue;}if(stage===2){if(offers!==(forbidden?0:1))throw Error('Prior activity/search offer mismatch');const h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND});if(h.filter(c=>c?.code===member).length!==(!forbidden&&!negated?1:0))throw Error('First search resolution mismatch');stage++;activate(probe);continue;}if(stage===3){stage++;activate(second);continue;}if(offers!==(forbidden?0:1))throw Error('Second copy bypassed shared search use');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(turn===2){if(stage===4){stage++;activate(expiry);continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(turn===3&&stage===5){stage++;normal();continue;}
     if(turn!==3||offers!==(forbidden?1:2))throw Error('Next-turn search count/activity reset missing');
     const h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND});if(h.filter(c=>c?.code===member).length!==(!forbidden&&!negated?2:1))throw Error('Next-turn search outcome mismatch');
     for(const marker of [731,732])if(!trace.some(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===marker))throw Error('Restriction/expiry probe did not resolve');
     if(!trace.some(t=>t.type===M.MOVE&&t.card===pend&&t.from.location===L.HAND&&t.to.location===L.MZONE)||!trace.some(t=>t.type===M.MOVE&&t.card===pend&&t.from.location===L.MZONE&&t.to.location===L.EXTRA))throw Error('Native Pendulum origin moves missing');
     if(hasPrior&&!trace.some(t=>t.type===M.MOVE&&t.card===priorCode&&t.from.location===L.EXTRA&&t.to.location===L.MZONE))throw Error('Native prior Extra summon missing');
     if(!trace.some(t=>t.type===M.MOVE&&t.card===darkFusion&&t.from.location===L.EXTRA&&t.to.location===L.MZONE))throw Error('Native expired-lock Extra move missing');
     if(negated||scenario==='sourceBanish'){if(!trace.some(t=>t.type===M.CHAINING&&t.code===counter&&t.chain_size===2))throw Error('Actual interruption missing');}
     done=true;
    }
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss)throw Error('Unexpected optional effect');offers++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CHAIN){const ci=p.selects.findIndex(c=>c.code===counter);if(ci>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:ci});continue;}const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(132273770*16+1));if(index>=0)offers++;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===member);if(index<0)throw Error('Search member missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({scenario,failure,turn,offers,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${scenario}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-symphonic-disccs-monster-lifecycle${control?'-'+control:''}.json`),JSON.stringify({scope:'Full Disccs/current installed metadata/corrected transport/no Lua API adapter. Native prior Extra activity, search shared use/reset, oath negations/source removal, facedown Extra type/attribute restriction and faceup Pendulum exception, natural next-turn expiry with actual DARK Extra summon. Neutral fixed Extra summons isolate restriction and do not certify Extra recipes. Live Omega not verified.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
