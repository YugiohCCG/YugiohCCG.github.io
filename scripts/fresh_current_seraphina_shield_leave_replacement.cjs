'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=218142234,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-replacement','no-replacement-cost','no-probe'].find(c=>process.argv.includes('--'+c));
 const tests=[{arms:255832330,mode:'destroy'},{arms:255832330,mode:'banish'},{arms:255832330,mode:'hand'},{arms:255832330,mode:'deck'},{arms:255832330,mode:'destroy',declineReplace:true},{arms:255832330,mode:'destroy',own:true},{arms:255832330,mode:'banish',own:true},{arms:255832330,mode:'destroy',decline:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const extraCodes=[900001211,900001212,900001213];
  const resourceCodes=test.duplicate?[partner,partner,cost]:[partner,cost,900001194];
  const cards=new Map([[boss,candidateCard(boss)],[original,{...base,code:original,type:33}],[filler,{...base,code:filler}],[partner,{...base,code:partner,setcodes:[0xb47]}],[cost,{...base,code:cost,setcodes:[0xb47]}],[900001194,{...base,code:900001194,setcodes:test.wrongSet?[]:[0xb47]}],[900001201,{...base,code:900001201,setcodes:[0xb47]}],[900001202,{...base,code:900001202,setcodes:[0xb47]}],[900001203,{...base,code:900001203,type:0x1000011,race:128n}]]);
  if(test.mixed)for(const code of extraCodes)cards.set(code,{...base,code,setcodes:[0xb47]});
  cards.set(test.arms,test.wrongCode?{...base,code:test.arms,type:2,setcodes:[0x452f]}:candidateCard(test.arms));
  cards.set(900001199,{...base,code:900001199,type:33});
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c900001199.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,218142234) Duel.Hint(HINT_NUMBER,tp,991) ${control==='no-probe'?'do end':test.mode==='destroy'?'Duel.Destroy(c,REASON_EFFECT)':test.mode==='banish'?'Duel.Remove(c,POS_FACEUP,REASON_EFFECT)':test.mode==='hand'?'Duel.SendtoHand(c,nil,REASON_EFFECT)':'Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)'} end) c:RegisterEffect(e) end`;
if(name==='c900001198.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local fc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,218142234) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(900001201,900001202,900001203) end,tp,LOCATION_HAND,0,nil) assert(#g==3 and g:FilterCount(Card.IsSetCard,nil,0xb47)==2 and g:IsExists(function(c) return c:IsRace(RACE_PYRO) and c:IsType(TYPE_PENDULUM) end,1,nil)) fc:SetMaterial(g) Duel.SendtoGrave(g,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then fc:CompleteProcedure() assert(fc:IsSummonType(SUMMON_TYPE_FUSION)) Duel.Hint(HINT_NUMBER,tp,701) Duel.Remove(g,POS_FACEUP,REASON_EFFECT) Duel.MoveToField(fc,tp,tp,LOCATION_PZONE,POS_FACEUP,true) ${test.full?'Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,900001192),0,tp,tp,false,false,POS_FACEUP)':''} end end) c:RegisterEffect(e) local o=Effect.CreateEffect(c) o:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) o:SetRange(LOCATION_MZONE) o:SetCode(EVENT_CHAIN_END) o:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,218142234) if not tc then return end local ok=pcall(function() local ec=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_SZONE,0,nil,${test.arms}) ${test.decline||test.wrongCode?'assert(not ec and tc:GetAttack()==tc:GetBaseAttack() and tc:GetDefense()==tc:GetBaseDefense())':`assert(ec and ec:GetEquipTarget()==tc and ec:IsType(TYPE_SPELL) and ec:IsType(TYPE_EQUIP)) assert(tc:GetAttack()==tc:GetBaseAttack()+${test.arms===255832330?0:500} and tc:GetDefense()==tc:GetBaseDefense()+${test.arms===255832330?500:0}) ${test.arms===215921734?'assert(tc:IsHasEffect(EFFECT_PIERCE))':test.arms===238136421?'assert(tc:IsHasEffect(EFFECT_CANNOT_BE_EFFECT_TARGET))':''}`} end) Duel.Hint(HINT_NUMBER,tp,ok and 988 or 989) end) c:RegisterEffect(o) local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) z:SetRange(LOCATION_MZONE) z:SetCode(EVENT_TO_GRAVE) z:SetOperation(function(e,tp,eg) local ec=eg:Filter(Card.IsCode,nil,255832330):GetFirst() if ec and ec:IsReason(REASON_REPLACE) then Duel.Hint(HINT_NUMBER,tp,990) end end) c:RegisterEffect(z) end`;
   if([partner,cost,900001194,900001201,900001202,900001203,filler,...extraCodes].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8'); if(name==='c'+boss+'.lua'&&process.argv.includes('--candidate'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/seraphina-capacity-candidate.lua'),'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-replacement')lua=lua.replace('s.leave_replace(ec)','do end');
    if(control==='no-replacement-cost')lua=lua.replace('Duel.Destroy(e:GetHandler(),REASON_EFFECT+REASON_REPLACE)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,prepared=false,choices=0,turn=0,probed=false,replacement=false,verified=false;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   if(process.argv.includes('--faceup-compat'))core.loadScript(duel,'tide-faceup-compat.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.EXTRA);add(original,L.MZONE,0,P.FACEUP_ATTACK,4);for(const code of [900001201,900001202,900001203])add(code,L.HAND);for(let i=0;i<3;i++)add(resourceCodes[i],test.fieldCost?L.MZONE:L.GRAVE,0,P.FACEUP_ATTACK,i);
   if(test.mixed)for(const code of extraCodes)add(code,L.GRAVE,0,P.FACEUP_ATTACK);
   if(test.full)for(let i=0;i<(test.fieldCost?1:4);i++)add(filler,L.DECK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(900001194,L.DECK,player);
   add(test.arms,L.GRAVE,0,P.FACEUP_ATTACK);
   add(900001199,L.MZONE,test.own?0:1,P.FACEUP_ATTACK,3);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<300&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===701),'Actual prior printed-category Fusion history');
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss);const eligible=!(test.duplicate||test.wrongSet||test.full&&!test.fieldCost);assert.equal(index>=0,eligible,'Printed Pendulum summon eligibility after cost');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!verified){assert(query(L.MZONE).some(c=>c.code===boss),'Actual Pendulum summon');assert.equal(query(L.SZONE).some(c=>c.code===test.arms),!test.decline,'Actual initial Shield equip');assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===988),'Initial native Shield effect observer');verified=true;}
     const controller=test.own?0:1;if(p.player!==controller){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!probed){const index=p.activates.findIndex(c=>c.code===900001199);assert(index>=0);probed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===991),'Actual probe operation');const eligible=!(test.own||test.decline),saved=eligible&&!test.declineReplace;assert.equal(replacement,eligible,'Opposing-effect Shield replacement offered');assert.equal(query(L.MZONE).some(c=>c.code===boss),saved,'Actual source preserved/replaced');assert(query(L.GRAVE).some(c=>c.code===test.arms),'Actual ShieldGY');assert.equal(trace.some(m=>m.type===M.HINT&&Number(m.hint)===990),saved,'Native Shield replacement sacrifice reason');if(test.mode==='banish'&&!saved)assert(query(L.REMOVED).some(c=>c.code===boss),'Actual unprotected source banished');done=true;
    }else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:(test.mixed?p.select_cards.findIndex(c=>extraCodes.includes(c.code)):-1)>=0?p.select_cards.findIndex(c=>extraCodes.includes(c.code)):p.select_cards.findIndex(c=>resourceCodes.includes(c.code));assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===test.arms);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===test.arms){replacement=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.declineReplace});}else {assert.equal(p.code,boss);core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});}}
    else if(p.type===M.SELECT_YESNO){choices++;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-seraphina-shield-leave-replacement'+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:process.argv.includes('--faceup-compat')?{method:'Card.IsFaceupEx',definition:'return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK)',source:'https://raw.githubusercontent.com/Fluorohydride/ygopro-core/master/libcard.cpp',lines:[2644,2649],qualification:'Compatibility diagnostic only; not native Omega or adapter-free production certification'}:null,scope:'Full Seraphina Pendulum/Shield equip then actual opposing non-targeting destruction/banishment/hand/deck effects; decline/own-effect/noEquip boundaries. Actual source preservation and native Shield sacrifice REASON_REPLACE checked. No adapters; neutral printed-category Fusion history/recipe/other effects/Omega/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
