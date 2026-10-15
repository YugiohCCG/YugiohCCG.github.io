'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=216958556,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['per-copy','no-reset','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{activation:true},{effect:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongSet?[]:[0xf3c]}],[cost,{...base,code:cost,race:test.wrongRace?1n:64n,attribute:test.wrongAttribute?1:2}],[original,{...base,code:original}],[filler,{...base,code:filler}]]);
  cards.set(900001196,{...base,code:900001196,type:0x100004});cards.set(original,{...base,code:original});
  const reader=name=>{
   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_HAND,0,nil,${boss}) Duel.SpecialSummon(tc,0,0,0,false,false,POS_FACEUP) end) c:RegisterEffect(e) end`;
   if(name==='c900001196.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev) ${test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.target?'Duel.Remove(Duel.GetFirstMatchingCard(Card.IsCode,0,0,LOCATION_MZONE,nil,'+partner+'),POS_FACEUP,REASON_EFFECT)':'Duel.Remove(Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,'+boss+'),POS_FACEUP,REASON_EFFECT)'} end) c:RegisterEffect(e) end`;
   if(name==='c'+partner+'.lua'&&test.indestructible)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_INDESTRUCTABLE_EFFECT) e:SetValue(1) c:RegisterEffect(e) end';
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='per-copy')lua=lua.replace('e1:SetCountLimit(1,id)','e1:SetCountLimit(1)');if(control==='no-reset')lua=lua.replace('e1:SetCountLimit(1,id)','e1:SetCountLimit(1,id,2)');
    if(control==='no-return')lua=lua.replace('Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,responded=false,stage=0,turn=0;
  const eligible=!test.absent;let interrupted=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   for(let i=0;i<3;i++)add(boss,L.HAND);add(original,L.MZONE,0,P.FACEUP_ATTACK,0);add(original,L.MZONE,1,P.FACEUP_ATTACK,3);for(let i=0;i<3;i++)add(partner,L.MZONE,1,P.FACEUP_ATTACK,i);if(test.activation||test.effect)add(900001196,L.SZONE,1);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(stage){const executed=(stage===3?2:1)-(test.activation||test.effect?1:0);assert.equal(query(L.GRAVE,1).filter(c=>c.code===partner).length,executed,'Actual destruction per allowed trigger');assert.equal(query(L.DECK).filter(c=>c.code===boss).length,executed,'Actual source returns');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,stage===3?2:1,'Normal and Special triggers share named use');}
     if(stage===3){assert.equal(turn,2);assert(trace.some(m=>m.type===M.CHAINING&&m.code===original&&m.triggering_controller===1));assert.equal(trace.filter(m=>m.type===M.SPSUMMONED).length,2);if(test.activation||test.effect)assert(interrupted);done=true;continue;}
     if(stage===2&&turn<2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const list=stage?p.activates:p.summons;const index=list.findIndex(c=>c.code===(stage?original:boss));assert(index>=0);const action=stage?A.SELECT_ACTIVATE:A.SELECT_SUMMON;stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action,index});
    }else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===boss);const counter=p.selects.findIndex(c=>c.code===900001196);if(counter>=0&&!interrupted&&control!=='no-response'){interrupted=true;index=counter;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-dante-summon-opponent-reset'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Three full Hand Dante copies, actual first NormalSummon then same-ownturn second native SpecialSummon then third native SpecialSummon earliest opponentturn2; shared named Normal/Special trigger use consumed after success/native CL2 activation/effect negation, actual destruction/source return/trigger counts and reset; opposing target destroyed and source shuffled, absent target/native indestructible exclusion. Actual CL2 activation/effect negation and target/source banish; source departure still permits destruction but no return. No adapters/seeded summons. GY reveal/search/shared use/nativeOmega/fullcard OPEN.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
