'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217174535,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-oath','no-reset','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{ownStain:true,activation:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongSet?[]:[0xf3c]}],[cost,{...base,code:cost,race:test.wrongRace?1n:64n,attribute:test.wrongAttribute?1:2}],[original,{...base,code:original,setcodes:test.ownStain?[0xbc5]:[]}],[filler,{...base,code:filler}]]);
  cards.set(900001197,{...base,code:900001197,setcodes:[0xbc5]});cards.set(900001196,{...base,code:900001196,type:0x100004});
  const reader=name=>{
   if(name==='c900001196.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev) ${test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':'Duel.Remove(Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,'+boss+'),POS_FACEUP,REASON_EFFECT)'} end) c:RegisterEffect(e) end`;
   if(name==='c'+partner+'.lua'||name==='c900001197.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,${name==='c'+partner+'.lua'?903:901}) end) c:RegisterEffect(e) end`;

   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCategory(CATEGORY_SPECIAL_SUMMON) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end ${test.noCategory?'do end':'Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)'} end) e:SetOperation(function(e,tp) Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_DECK,0,nil,${cost}),0,tp,tp,false,false,POS_FACEUP) Duel.Hint(HINT_NUMBER,tp,902) end) c:RegisterEffect(e) end`;
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-oath')lua=lua.replace('\ts.applylimit(e,tp)','\tdo end');if(control==='no-reset')lua=lua.replace('e1:SetReset(RESET_PHASE+PHASE_END)','do end');
    if(control==='no-destroy')lua=lua.replace('Duel.Destroy(rc,REASON_EFFECT)','do end');
    if(control==='allow-own-neutral')lua=lua.replaceAll('Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0','true').replace('(rp~=tp or re:GetHandler():IsSetCard(SET_STAIN))','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,responded=false,stage=0,interrupted=false;
  const eligible=!(test.ownNeutral||test.noCategory);let turn=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   const controller=test.ownStain||test.ownNeutral?0:1;add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(original,L.MZONE,controller,P.FACEUP_ATTACK,1);add(cost,L.DECK,controller);add(partner,L.MZONE,0,P.FACEUP_ATTACK,2);add(900001197,L.MZONE,0,P.FACEUP_ATTACK,3);if(test.activation||test.effect||test.source)add(900001196,L.SZONE,1);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(turn===2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!stage){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(stage===1){assert(responded);assert.equal(query(L.MZONE).some(c=>c.code===cost),!!(test.activation||test.effect),'Actual first effect outcome');if(test.activation||test.effect||test.source){assert(interrupted);assert(trace.some(m=>m.type===M.CHAINING&&m.code===900001196&&m.chain_size===3));}if(test.source)assert(query(L.REMOVED).some(c=>c.code===boss));}
     const neutral=p.activates.findIndex(c=>c.code===partner),stain=p.activates.findIndex(c=>c.code===900001197);
     assert(stain>=0,'Stain effect remains available');assert.equal(neutral>=0,true,'Native activation-negation oath removed');
     if(stage===1){stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:neutral});continue;}
     assert(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='903'),'Actual same-turn nonStain activation after activation negation');
     assert.equal(turn,1);done=true;continue;
     if(stage===2){stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:neutral});continue;}
     assert(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='903'),'Actual post-reset nonStain activation');done=true;
    }else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===boss);const counter=p.selects.findIndex(c=>c.code===900001196);if(counter>=0&&!interrupted&&control!=='no-response'){index=counter;interrupted=true;}if(index>=0){if(p.selects[index].code===boss)responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===cost);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-kaleidragon-activation-negation-oath-actual'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Diagnostic: full initial-MZONE Kaleidragon actual own Stain CL1/QuickCL2/CounterTrapCL3 NegateActivation. Observe native oath rollback/first original summon, source remains, Stain/nonStain availability and next-turn reset. Exact custom ruling interpretation unresolved; excluded production passing index pending source review. No adapters/seeded activation/proper Fusion claim.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
