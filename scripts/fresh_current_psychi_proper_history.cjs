'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217332244,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-revival','no-limit','no-procedure','old-source'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{improperGY:true},{externalHand:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrong?[]:[0xe80d]}],[filler,{...base,code:filler}],[original,{...base,code:original}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,${test.externalHand?'LOCATION_HAND':test.improperGY?'LOCATION_GRAVE':'LOCATION_MZONE'},0,nil,${boss}) assert(tc) ${test.improperGY||test.externalHand?'':`assert(Duel.SendtoGrave(tc,REASON_EFFECT)>0) Duel.BreakEffect()`} if tc:IsCanBeSpecialSummoned(e,0,tp,false,false) then Duel.Hint(HINT_NUMBER,tp,701) ${control==='no-revival'?'do end':'assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0)'} else Duel.Hint(HINT_NUMBER,tp,702) end end) c:RegisterEffect(e) end`;
   if(name==='c'+partner+'.lua'||name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(process.argv.includes('--candidate'))lua=lua.replace('e0:SetCode(EFFECT_SPSUMMON_CONDITION)','e0:SetCode(EFFECT_SPSUMMON_CONDITION)\n\te0:SetValue(function(e,se,sp,st) return e:GetHandler():IsStatus(STATUS_PROC_COMPLETE) end)');
    if(control==='old-source')lua=lua.replace('e0:SetValue(function(e,se,sp,st) return e:GetHandler():IsStatus(STATUS_PROC_COMPLETE) end)','do end');
    if(control==='no-limit')lua=lua.replace('c:EnableReviveLimit()','do end').replace('c:RegisterEffect(e0)','do end');
    if(control==='no-procedure')lua=lua.replace('c:RegisterEffect(e3)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,helperUsed=false;
  const eligible=!(test.improperGY||test.externalHand);
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,test.improperGY?L.GRAVE:L.HAND);add(original,L.MZONE,0,P.FACEUP_ATTACK,1);add(partner,L.MZONE,0,P.FACEUP_ATTACK,0);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     assert(!p.summons.some(c=>c.code===boss),'Normal Summon forbidden');assert(!p.monster_sets.some(c=>c.code===boss),'Normal Set forbidden');
     if(!activated&&eligible){const index=p.special_summons.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Native procedure eligibility');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     if(!helperUsed){helperUsed=true;const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(query(L.MZONE).some(c=>c.code===boss),eligible,'Actual proper-history revival qualification');assert(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)===(eligible?'701':'702')),'Native summon eligibility diagnostic');if(eligible){assert(query(L.REMOVED).some(c=>c.code===partner&&(c.reason&0x80)));assert.equal(trace.filter(m=>m.type===M.SPSUMMONED).length,2,'Real procedure summon then real revival');assert(trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.from.location===L.MZONE&&m.to.location===L.GRAVE));}else assert(query(test.improperGY?L.GRAVE:L.HAND).some(c=>c.code===boss));done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-psychi-proper-history'+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full Psychi native actual Hand procedure paying To Proto banish, actual sendGY followed by non-bypass native revival. Initial improperGY and external Hand effect summon excluded. No seeded proper status/CompleteProcedure/adapters; other effects/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
