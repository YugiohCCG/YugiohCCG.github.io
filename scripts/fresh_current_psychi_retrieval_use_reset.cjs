'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217332244,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['per-copy','no-reset','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{activation:true},{effect:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrong?[]:[0xe80d],type:test.spell?2:17}],[filler,{...base,code:filler}],[original,{...base,code:original}],[cost,{...base,code:cost,type:0x100004}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+cost+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.sourceGY?'Duel.SendtoGrave(re:GetHandler(),REASON_EFFECT)':`local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_REMOVED,0,nil,${partner}) assert(Duel.SendtoGrave(tc,REASON_EFFECT)>0) ${test.targetReentry?'assert(Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0)':''}`} end) c:RegisterEffect(e) end`;

   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}) assert(Duel.Remove(tc,${test.sourceDown?'POS_FACEDOWN':'POS_FACEUP'},REASON_EFFECT)>0) end) c:RegisterEffect(e) end`;
   if(name==='c'+partner+'.lua'||name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='per-copy')lua=lua.replace('e6:SetCountLimit(1,id+100)','e6:SetCountLimit(1)');
    if(control==='no-reset')lua=lua.replace('e6:SetCountLimit(1,id+100)','e6:SetCountLimit(1,id+100,2)');
    if(control==='ignore-relation')lua=lua.replace('tc:IsRelateToEffect(e)','true');
    if(control==='no-return')lua=lua.replace('Duel.SendtoHand(tc,nil,REASON_EFFECT)>0','false');
    if(control==='allow-wrong')lua=lua.replaceAll('c:IsSetCard(SET_TO_PROTO) and c:IsType(TYPE_MONSTER)','c:IsType(TYPE_MONSTER)');
    if(control==='allow-down')lua=lua.replace('return c:IsFaceup() and c:IsSetCard','return c:IsSetCard');
    if(control==='allow-same')lua=lua.replace('not c:IsCode(code) and','true and');
    if(control==='allow-spell')lua=lua.replaceAll('c:IsType(TYPE_MONSTER)','true');
    if(control==='no-reveal')lua=lua.replace('Duel.ConfirmCards(1-tp,tc)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,interrupted=false,turn=0,banishes=0,offers=0;
  const eligible=Object.keys(test).length===0||!!test.sourceGY;let offered=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(original,L.MZONE,0,P.FACEUP_ATTACK,1);
   if(!test.absent)add(test.sameName?boss:partner,L.REMOVED,test.opponent?1:0,test.down?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,0);
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,2);add(boss,L.MZONE,0,P.FACEUP_ATTACK,3);add(partner,L.REMOVED,0,P.FACEUP_ATTACK,1);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   if(Object.keys(test).length)add(cost,L.SZONE,1);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(banishes===1){assert.equal(offers,1);assert.equal(query(L.HAND).filter(c=>c.code===partner).length,Object.keys(test).length?0:1,'First actual retrieval');}
     if(banishes===2){assert.equal(offers,1,'Second copy shares consumed named use');assert.equal(query(L.REMOVED).filter(c=>c.code===boss).length,2);if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}}
     if(banishes<3){assert(turn===1||turn===3);banishes++;const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(turn,3);assert.equal(offers,2,'Actual next-ownturn reset');assert.equal(query(L.REMOVED).filter(c=>c.code===boss).length,3,'Three actual source banishes');assert.equal(query(L.HAND).filter(c=>c.code===partner).length,Object.keys(test).length?1:2,'Actual retrieved resources');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,2);assert.equal(trace.filter(m=>m.type===M.CONFIRM_CARDS&&m.player===1).flatMap(m=>m.cards).filter(c=>c.code===partner).length,Object.keys(test).length?1:2,'Exact actual reveals');if(Object.keys(test).length){assert(interrupted);assert(trace.some(m=>m.type===M.CHAINING&&m.code===cost&&m.chain_size===2));}done=true;

    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){offers++;offered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===cost);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-psychi-retrieval-use-reset'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Three full initial-MZONE Psychi copies/two banished To Proto resources, actual helper field banishes first/second same-ownturn1 then third ownturn3. First success/CL2 activation/effect negation consumes shared named use; nextturn resets with actual return. No seeded counters/proper history/adapters; fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
