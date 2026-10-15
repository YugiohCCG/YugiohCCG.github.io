'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217174535,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['per-copy','no-reset','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{activation:true},{effect:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongSet?[]:[0xf3c]}],[cost,{...base,code:cost,setcodes:test.wrongSet?[]:[0xbc5]}],[original,{...base,code:original,setcodes:test.ownStain?[0xbc5]:[]}],[filler,{...base,code:filler}]]);
  for(const code of [900001197,900001198,900001199,900001200,900001201])cards.set(code,{...base,code,type:code===900001198?2:17});
  cards.set(900001196,{...base,code:900001196,type:0x100004});
  const reader=name=>{
   if(name==='c900001196.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev) ${test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.source?'Duel.Remove(Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,'+boss+'),POS_FACEUP,REASON_EFFECT)':test.handLoss?'Duel.Remove(Duel.GetFieldGroup(0,0,LOCATION_HAND),POS_FACEUP,REASON_EFFECT)':'Duel.ChangePosition(Duel.GetFirstMatchingCard(Card.IsCode,0,0,LOCATION_MZONE,nil,900001197),POS_FACEUP_ATTACK)'} end) c:RegisterEffect(e) end`;

   if([900001197,900001198,900001199,900001200,900001201].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCategory(CATEGORY_SPECIAL_SUMMON) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end ${test.noCategory?'do end':'Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)'} end) e:SetOperation(function(e,tp) Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${cost}),REASON_EFFECT) Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_DECK,0,nil,${cost}),0,0,${test.opponent?1:0},false,false,POS_FACEUP) Duel.Hint(HINT_NUMBER,tp,902) end) c:RegisterEffect(e) end`;
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='per-copy')lua=lua.replace('e3:SetCountLimit(1,id+100)','e3:SetCountLimit(1)');if(control==='no-reset')lua=lua.replace('e3:SetCountLimit(1,id+100)','e3:SetCountLimit(1,id+100,2)');if(control==='no-field')lua=lua.replace('Duel.ConfirmCards(tp,fg)','do end');
    if(control==='ignore-owner')lua=lua.replace('c:IsControler(tp) and c:IsSetCard(SET_STAIN)','c:IsSetCard(SET_STAIN)');if(control==='ignore-set')lua=lua.replace('c:IsControler(tp) and c:IsSetCard(SET_STAIN)','c:IsControler(tp)');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,responded=false,interrupted=false,uses=0;
  const eligible=!(test.wrongSet||test.opponent);let turn=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(Object.keys(test).length)add(900001196,L.SZONE,1,P.FACEDOWN_DEFENSE,1);const controller=0;add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(boss,L.MZONE,0,P.FACEUP_ATTACK,4);add(original,L.MZONE,0,P.FACEUP_ATTACK,1);add(partner,L.MZONE,0,P.FACEDOWN_DEFENSE,2);add(cost,L.DECK);add(cost,L.DECK);add(cost,L.DECK);if(!test.noDown){add(900001197,L.MZONE,1,P.FACEDOWN_DEFENSE,0);add(900001198,L.SZONE,1,P.FACEDOWN_DEFENSE,0);}add(900001199,L.MZONE,1,P.FACEUP_ATTACK,1);if(!test.emptyHand){add(900001200,L.HAND,1);add(900001201,L.HAND,1);}for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(turn===2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(uses){assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,uses===3?2:1,'Native shared look use');assert.equal(trace.filter(m=>m.type===M.SPSUMMONED).length,uses);const reveals=uses===3?2:1;const completed=reveals-(test.activation||test.effect?1:0);const confirmed=trace.filter(m=>m.type===M.CONFIRM_CARDS).flatMap(m=>m.cards.map(c=>c.code));assert.equal(confirmed.length,completed*4,'Actual reveals after success/negation/reset');for(const code of [900001197,900001198,900001200,900001201])assert.equal(confirmed.filter(c=>c===code).length,completed);assert.equal(query(L.GRAVE).filter(c=>c.code===cost).length,uses-1,'Real supporting monsters replaced');}
     if(uses===3){assert.equal(turn,3);if(test.activation||test.effect){assert(interrupted);assert(trace.some(m=>m.type===M.CHAINING&&m.code===900001196&&m.chain_size===2));}done=true;continue;}
     if(uses===2&&turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);uses++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===boss);const counter=p.selects.findIndex(c=>c.code===900001196);if(counter>=0&&!interrupted&&control!=='no-response'){index=counter;interrupted=true;}if(index>=0){responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===cost);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=(p.field_mask&31)===31?16:0;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift?1-p.player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-kaleidragon-look-use-reset'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Two full initial-MZONE Kaleidragon copies, three actual native Stain supporting summons, old supporting monster sent GY before next summon. First look success/native CL2 activation/effect negation consumes shared named use, second same-ownturn1 has no trigger, next ownturn3 restores trigger/reveals. Exact reveal code frequencies/real summon/chain/resource counts. No adapters/seeded activity/proper Fusion claim. Self summon/negation oath/nativeOmega/fullcard OPEN.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
