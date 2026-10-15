'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217332244,partner=240299293,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['per-copy','no-reset','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{pay:777},{pay:777,activation:true},{pay:777,effect:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,type:0x4011}],[filler,{...base,code:filler}],[900001191,{...base,code:900001191,type:17,attack:100,defense:100}],[cost,{...base,code:cost,type:0x100004}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+cost+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) and re:IsHasCategory(CATEGORY_RECOVER) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':'Duel.SendtoGrave(re:GetHandler(),REASON_EFFECT)'} end) c:RegisterEffect(e) end`;

   if([partner,filler,900001191].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(process.argv.includes('--candidate'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/psychi-payment-candidate.lua'),'utf8');
    if(control==='per-copy')lua=lua.replace('e4:SetCountLimit(1,id+200)','e4:SetCountLimit(1)');
    if(control==='no-reset')lua=lua.replace('e4:SetCountLimit(1,id+200)','e4:SetCountLimit(1,id+200,2)');
    if(control==='require-source')lua=lua.replace('Duel.Recover(tp,ev,REASON_EFFECT)','if e:GetHandler():IsRelateToEffect(e) then Duel.Recover(tp,ev,REASON_EFFECT) end');
    if(control==='no-recover')lua=lua.replace('Duel.Recover(tp,ev,REASON_EFFECT)','do end');
    if(control==='wrong-amount')lua=lua.replace('Duel.Recover(tp,ev,REASON_EFFECT)','Duel.Recover(tp,1,REASON_EFFECT)');
    if(control==='no-trigger')lua=lua.replace('return ep==1-tp','return false');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lp||8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,digitStep=0,turn=0,attacked=false,look=false,interrupted=false,boosts=0,attacks=0,offers=0;
  const eligible=!(test.wrong||test.absent||test.lp===1);
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);if(!test.absent)add(test.wrong?900001191:partner,L.MZONE,0,P.FACEUP_ATTACK,1);
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,2);add(partner,L.MZONE,0,P.FACEUP_ATTACK,3);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   if(test.defender||test.defense||test.lose)add(900001191,L.MZONE,1,test.defense?P.FACEUP_DEFENSE:P.FACEUP_ATTACK,0);
   if(test.activation||test.effect||test.sourceGY)add(cost,L.SZONE,1);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller:0,location}).filter(Boolean);
   for(let step=0;step<500&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(boosts===0||boosts===1&&turn===3){const sequence=boosts===0?0:2,index=p.activates.findIndex(c=>c.code===boss&&c.sequence===sequence);assert(index>=0,'Actual independent Token boost');boosts++;digitStep=0;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(turn<3||turn===4||turn===3&&attacks===2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(turn===3||turn===5);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP});


    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(attacked?900001191:partner));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_BATTLECMD){if(attacks<2||turn===5&&attacks===2){if(attacks===1)assert.equal(offers,1,'First actual recovery');if(attacks===2)assert.equal(offers,1,'Second copy cannot reuse recovery same turn');const sequence=attacks===1?2:0,index=p.attacks.findIndex(c=>c.code===boss&&c.sequence===sequence);assert(index>=0);attacks++;attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});continue;}if(turn===3){assert.equal(offers,1,'Shared named recovery consumed across copies');core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.TO_M2,index:0});continue;}assert.equal(turn,5);assert.equal(offers,2,'Actual next-ownturn recovery reset');assert.equal(trace.filter(m=>m.type===M.ATTACK).length,3);assert.equal(trace.filter(m=>m.type===M.DAMAGE&&m.player===1).reduce((n,m)=>n+Number(m.amount),0),2331);assert.equal(trace.filter(m=>m.type===M.RECOVER&&m.player===0).reduce((n,m)=>n+Number(m.amount),0),test.activation||test.effect?777:1554);assert.equal(trace.filter(m=>m.type===M.PAY_LPCOST&&m.player===0).length,2);if(test.activation||test.effect)assert(trace.some(m=>m.type===M.CHAINING&&m.code===cost&&m.chain_size===2));done=true;}
    else if(p.type===M.SELECT_EFFECTYN){look=true;offers++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.ANNOUNCE_NUMBER){const digits=String(test.pay).padStart(String((test.lp||8000)-1).length,'0');const wanted=Number(digits[digitStep++]);const index=p.options.findIndex(n=>Number(n)===wanted);assert(index>=0,'Printed any-amount LP choice '+test.pay+' unavailable');core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:index});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===cost);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-psychi-recovery-use-reset'+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Two full Psychi copies actual separate-turn Token777LP boosts, native ownturn3 two direct attacks/ownturn5 third. Recovery success/CL2 activation/effect negation consumes shared named use across copies; native next-ownturn reset. Exact actual damage/recovery/payments, no seeded history/adapters; fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
