'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=218142234,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-cost','no-summon','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{activation:true},{effect:true},{sourceBanish:true},{fill:true},{lateLock:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const extraCodes=[900001211,900001212,900001213];
  const resourceCodes=test.duplicate?[partner,partner,cost]:[partner,cost,900001194];
  const cards=new Map([[boss,candidateCard(boss)],[original,{...base,code:original,type:33}],[filler,{...base,code:filler}],[partner,{...base,code:partner,setcodes:[0xb47]}],[cost,{...base,code:cost,setcodes:[0xb47]}],[900001194,{...base,code:900001194,setcodes:test.wrongSet?[]:[0xb47]}],[900001201,{...base,code:900001201,setcodes:[0xb47]}],[900001202,{...base,code:900001202,setcodes:[0xb47]}],[900001203,{...base,code:900001203,type:0x1000011,race:128n}]]);
  if(test.mixed)for(const code of extraCodes)cards.set(code,{...base,code,setcodes:[0xb47]});
  cards.set(900001197,{...base,code:900001197,type:0x100004});cards.set(900001196,{...base,code:900001196,type:33});
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c900001196.lua')return `local s,id=GetID() function s.initial_effect(c) ${test.lateLock?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetRange(LOCATION_MZONE) e:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON) e:SetProperty(EFFECT_FLAG_PLAYER_TARGET) e:SetTargetRange(1,0) e:SetTarget(function(e,c) return c:IsCode(218142234) end) c:RegisterEffect(e)':''} end`;
   if(name==='c900001197.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.sourceBanish?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':'Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,900001196),0,1-tp,1-tp,false,false,POS_FACEUP)'} end) c:RegisterEffect(e) end`;

   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local fc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,218142234) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(900001201,900001202,900001203) end,tp,LOCATION_HAND,0,nil) assert(#g==3 and g:FilterCount(Card.IsSetCard,nil,0xb47)==2 and g:IsExists(function(c) return c:IsRace(RACE_PYRO) and c:IsType(TYPE_PENDULUM) end,1,nil)) fc:SetMaterial(g) Duel.SendtoGrave(g,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then fc:CompleteProcedure() assert(fc:IsSummonType(SUMMON_TYPE_FUSION)) Duel.Hint(HINT_NUMBER,tp,701) Duel.Remove(g,POS_FACEUP,REASON_EFFECT) Duel.MoveToField(fc,tp,tp,LOCATION_PZONE,POS_FACEUP,true) ${test.full?'Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,900001192),0,tp,tp,false,false,POS_FACEUP)':''} end end) c:RegisterEffect(e) end`;
   if([partner,cost,900001194,900001201,900001202,900001203,filler,...extraCodes].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8'); if(name==='c'+boss+'.lua'&&process.argv.includes('--candidate'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/seraphina-capacity-candidate.lua'),'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='old-source')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/seraphina-before-capacity-repair/c218142234.lua'),'utf8');
    if(control==='ignore-capacity')lua=lua.replace('aux.dncheck(g) and Duel.GetMZoneCount(tp,g)>0','aux.dncheck(g)');
    if(control==='no-cost')lua=lua.replace('Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_COST)','do end');
    if(control==='no-summon')lua=lua.replace('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0','0>0');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,prepared=false,interrupted=false;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   if(process.argv.includes('--faceup-compat'))core.loadScript(duel,'tide-faceup-compat.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.EXTRA);add(original,L.MZONE,0,P.FACEUP_ATTACK,4);for(const code of [900001201,900001202,900001203])add(code,L.HAND);for(let i=0;i<3;i++)add(resourceCodes[i],test.fieldCost?L.MZONE:L.GRAVE,0,P.FACEUP_ATTACK,i);
   if(test.mixed)for(const code of extraCodes)add(code,L.GRAVE,0,P.FACEUP_ATTACK);
   if(test.full)for(let i=0;i<(test.fieldCost?1:4);i++)add(filler,L.DECK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(900001194,L.DECK,player);
   if(Object.keys(test).length)add(900001197,L.SZONE,1);if(test.fill||test.lateLock)for(let i=0;i<(test.fill?4:1);i++)add(900001196,L.DECK);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===701),'Actual prior printed-category Fusion history');
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss);const eligible=!(test.duplicate||test.wrongSet||test.full&&!test.fieldCost);assert.equal(index>=0,eligible,'Printed Pendulum summon eligibility after cost');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(interrupted,Object.keys(test).length>0,'Actual CounterTrapCL2');assert.equal(query(L.MZONE).some(c=>c.code===boss),Object.keys(test).length===0,'Actual source Pendulum-to-Monster summon');if(test.sourceBanish)assert(query(L.REMOVED).some(c=>c.code===boss),'Actual source banished');if(test.fill||test.lateLock)assert.equal(query(L.MZONE).filter(c=>c.code===900001196).length,test.fill?4:1,'Actual late summon of filler/lock source');const paid=trace.filter(m=>m.type===M.MOVE&&[...resourceCodes,...(test.mixed?extraCodes:[])].includes(m.card)&&(m.to.location===L.DECK||m.to.location===L.EXTRA));assert.equal(paid.length,3,'Three actual shuffled cost cards');const start=trace.findIndex(m=>m.type===M.CHAINING&&m.code===boss);assert(start>=0,'Actual source chain');const chained=start+trace.slice(start).findIndex(m=>m.type===M.CHAINED);assert(chained>start,'Actual source CHAINED');for(const m of paid)assert(trace.indexOf(m)<chained,'Shuffle cost paid before CHAINED');assert.equal(new Set(paid.map(m=>m.card)).size,3,'Three different names paid');if(test.mixed){assert(paid.some(m=>m.from.location===L.GRAVE),'Preferred GY cost paid');assert(paid.some(m=>m.from.location===L.MZONE),'Cost actually frees monster zone');}done=true;
    }else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:(test.mixed?p.select_cards.findIndex(c=>extraCodes.includes(c.code)):-1)>=0?p.select_cards.findIndex(c=>extraCodes.includes(c.code)):p.select_cards.findIndex(c=>resourceCodes.includes(c.code));assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss);core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===900001197);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-seraphina-pendulum-interruption'+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:process.argv.includes('--faceup-compat')?{method:'Card.IsFaceupEx',definition:'return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK)',source:'https://raw.githubusercontent.com/Fluorohydride/ygopro-core/master/libcard.cpp',lines:[2644,2649],qualification:'Compatibility diagnostic only; not native Omega or adapter-free production certification'}:null,scope:'Full repaired Seraphina native Pendulum cost/SS after actual printed-category neutral Fusion history; real CounterTrapCL2 activation/effect negation/sourcebanishment/late4zonefill/late source-only player summon lock. Actual three shuffle costs persist. No adapters; Fusion recipe/equip/other effects/Omega/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
