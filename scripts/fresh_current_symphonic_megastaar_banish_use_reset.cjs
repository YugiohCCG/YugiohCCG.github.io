'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_current_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273772,amp=75304793,holder=900000851,target=900000852,grave=900000853,setup=900000854,filler=900000855,tuner=900000856,nonTuner=900000857,counter=900000858;

 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:5000,defense:4000,lscale:0,rscale:0,link_marker:0},results=[];
 for(const scenario of ['baseline','negateActivation','negateEffect']){
 const test={remove:1,take:1};
  const legal=!test.pendulum&&!test.absent&&!test.opponent&&!test.facedown&&!test.zero,logs=[],trace=[],cards=new Map([[boss,candidateCard(boss)],[counter,{...base,code:counter,type:0x100004}],[amp,{...base,code:amp,type:0x80002,level:0}],[holder,{...base,code:holder,type:0x20002,level:0}],[target,{...base,code:target}],[grave,{...base,code:grave}],[setup,{...base,code:setup,type:2,level:0}],[filler,{...base,code:filler}],[tuner,{...base,code:tuner,type:0x1011,level:2}],[nonTuner,{...base,code:nonTuner,type:0x1002011,level:8}]]);
  const reader=name=>{if(name===`c${counter}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) and re:GetDescription()==${132273772*16+1} end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${process.argv.includes('--no-response')?'do end':scenario==='negateActivation'?'Duel.NegateActivation(ev)':scenario==='negateEffect'?'Duel.NegateEffect(ev)':scenario==='sourceBanish'?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':scenario==='ampBanish'?`Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_FZONE,0,nil,${amp}),POS_FACEUP,REASON_EFFECT)`:`Duel.SendtoDeck(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${grave}),nil,SEQ_DECKSHUFFLE,REASON_EFFECT)`} end) c:RegisterEffect(e) end`;
   if(name===`c${holder}.lua`)return 'local s,id=GetID() function s.initial_effect(c) c:EnableCounterPermit(0x35) end';
   if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp)
    local bg=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}) assert(#bg==2) for b in aux.Next(bg) do assert(b:IsSummonType(SUMMON_TYPE_SYNCHRO) and b:IsStatus(STATUS_PROC_COMPLETE),"Actual proper Synchro missing") Duel.Hint(HINT_NUMBER,tp,701) end
    ${test.zero?'':`local h=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_ONFIELD,0,nil,${holder}):GetFirst() h:AddCounter(0x35,2) local o=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_ONFIELD,nil,${holder}):GetFirst() o:AddCounter(0x35,1)`}
    ${test.pendulum?`local b=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() Duel.MoveToField(b,tp,tp,LOCATION_PZONE,POS_FACEUP,true)`:''}
   end) c:RegisterEffect(e) end`;
   if([target,grave,filler,tuner,nonTuner].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--shared-count'))source=source.replace('e8:SetCountLimit(1)','e8:SetCountLimit(1,id)');if(process.argv.includes('--no-reset'))source=source.replace('e8:SetCountLimit(1)','_G.MegaNoReset=(_G.MegaNoReset or 0)+1 e8:SetCountLimit(1,900001+_G.MegaNoReset,2)');if(process.argv.includes('--no-limit'))source=source.replace('e8:SetCountLimit(1)','');if(process.argv.includes('--no-banish'))source=source.replace('Duel.Remove(g,POS_FACEUP,REASON_EFFECT)','do end');if(process.argv.includes('--no-cost'))source=source.replace('Duel.RemoveCounter(tp,1,1,COUNTER_SYMPHONIC,removed,REASON_COST)','do end');if(process.argv.includes('--no-field-check'))source=source.replace('e8:SetCondition(s.banishcon)','');}return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,summoned=0,prepared=false,activated=0,interrupted=false,done=false,turn=0,firstSequence=null;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   core.loadScript(duel,'bounded_synchro_compat.lua',`assert(Duel.CheckSynchroMaterial==nil)
local modernNotTuner=Card.IsNotTuner Card.IsNotTuner=function(c,sc) return modernNotTuner(c,sc,sc:GetControler()) end
local function materials(c,f1,f2,minc,maxc)
 local tp=c:GetControler()
 local t=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${tuner}):GetFirst()
 local n=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${nonTuner}):GetFirst()
 if not t or not n or minc>1 or maxc<1 or not t:IsFaceup() or not n:IsFaceup() or not t:IsType(TYPE_TUNER) or not f1(t,c) or not f2(n,c) or t:GetLevel()+n:GetLevel()~=c:GetLevel() or not t:IsCanBeSynchroMaterial(c) or not n:IsCanBeSynchroMaterial(c) then return nil end
 local g=Group.FromCards(t,n) return g
end
Duel.CheckSynchroMaterial=function(c,f1,f2,minc,maxc) return materials(c,f1,f2,minc,maxc)~=nil end
Duel.SelectSynchroMaterial=function(tp,c,f1,f2,minc,maxc) return materials(c,f1,f2,minc,maxc) end`);
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,L.EXTRA,0,0,P.FACEDOWN_DEFENSE);add(boss,L.EXTRA,0,0,P.FACEDOWN_DEFENSE);add(tuner,L.MZONE,0,0);add(nonTuner,L.MZONE,0,1);add(tuner,L.MZONE,0,2);add(nonTuner,L.MZONE,0,3);add(setup,L.HAND);if(scenario!=='baseline')add(counter,L.SZONE,1,2,P.FACEDOWN_DEFENSE);add(holder,L.SZONE,0,1);add(holder,L.SZONE,1,1);add(target,L.MZONE,1);add(filler,L.MZONE,1,1);add(grave,L.GRAVE,1);if(!test.absent)add(amp,L.SZONE,test.opponent?1:0,5,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<400&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(turn===2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(summoned<2){const index=p.special_summons.findIndex(c=>c.code===boss);if(index<0)throw Error('Two actual native Synchro procedures missing');summoned++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     if(!prepared){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Setup missing');prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const offers=p.activates.map((c,i)=>({...c,index:i})).filter(c=>c.code===boss&&String(c.description)===String(132273772*16+1));
     if(turn===1&&activated<2||turn===3&&activated<3){if(turn===1&&activated===1&&offers.some(c=>c.sequence===firstSequence))throw Error('First copy illegally reusable same turn');const choice=offers.find(c=>activated===0||(turn===1?c.sequence!==firstSequence:c.sequence===firstSequence));if(!choice)throw Error('Independent copy or next-turn reset unavailable');if(!activated)firstSequence=choice.sequence;activated++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:choice.index});continue;}
     if(turn===1&&offers.length)throw Error('Same copy count limit bypass');
     const removed=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.REMOVED}),expected=activated-(scenario==='baseline'?0:1);if(removed.filter(c=>[target,grave,filler].includes(c?.code)).length!==expected)throw Error('Actual per-copy banish outcomes missing');
     if(turn===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(turn!==3||activated!==3||JSON.stringify(trace.filter(t=>t.type===M.NEW_TURN).map(t=>t.player))!=='[0,1,0]')throw Error('Actual turn reset progression missing');
     if(trace.filter(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===701).length!==2)throw Error('Both actual proper Synchro histories missing');const sourceChains=trace.map((t,i)=>t.type===M.CHAINING&&t.code===boss&&String(t.description)===String(132273772*16+1)?i:-1).filter(i=>i>=0);if(sourceChains.length!==3)throw Error('Three actual source chains missing');for(const start of sourceChains){const end=trace.findIndex((t,i)=>i>start&&t.type===M.CHAINED);if(trace.slice(start,end).filter(t=>t.type===M.REMOVE_COUNTER&&t.counter_type===0x35).reduce((n,t)=>n+t.count,0)!==1)throw Error('Each actual counter cost before CHAINED missing');}const paid=trace.filter(t=>t.type===M.REMOVE_COUNTER&&t.counter_type===0x35).reduce((n,t)=>n+t.count,0);if(paid!==3)throw Error('Three actual counter costs missing');if(trace.filter(t=>t.type===M.CHAINING&&t.code===counter&&t.chain_size===2).length!==(scenario==='baseline'?0:1))throw Error('Actual first-use negation missing');done=true;

    }
    else if(p.type===M.ANNOUNCE_NUMBER){const index=p.options.findIndex(n=>Number(n)===test.remove);if(index<0)throw Error('Counter choice missing');core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:index});}
    else if(p.type===M.SELECT_COUNTER){let left=p.count;const counters=p.cards.map(c=>{const n=Math.min(left,c.count);left-=n;return n;});if(left)throw Error('Insufficient selectable counters');core.duelSetResponse(duel,{type:R.SELECT_COUNTER,counters});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>[target,grave,filler].includes(c.code));if(index<0)throw Error('Valid banish reserve missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===counter);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_EFFECTYN||p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({scenario,failure,summoned,activated,turn,firstSequence,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify({scenario})}${failure?': '+failure:''}`);
 }
 const control=['shared-count','no-reset','no-limit'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-symphonic-megastaar-banish-use-reset'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'public OCGCore with full Mega Staar and official Amplifire; not native Omega',qualifiers:['Fixture holders permit actual Counters; setup Spell adds Counters on both fields','Actual native Synchro history with bounded test-only legacy Synchro API/IsNotTuner adapters; not actual Omega/general recipe certification','Pendulum case uses real MoveToField setup'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
