'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217645912,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-summon','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{activation:true},{effect:true},{sourceBanish:true},{fill:true},{resourceBanish:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,race:16n,setcodes:test.wrongSet?[]:[0xe2f]}],[cost,{...base,code:cost}],[original,{...base,code:original,type:33}],[900001194,{...base,code:900001194}],[900001197,{...base,code:900001197,type:0x100004}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c900001197.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.sourceBanish?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':test.resourceBanish?`Duel.Remove(Duel.GetFirstMatchingCard(Card.IsCode,1-tp,LOCATION_GRAVE,0,nil,${partner}),POS_FACEUP,REASON_EFFECT)`:'local g=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,900001194) Duel.SpecialSummon(g,0,1-tp,1-tp,false,false,POS_FACEUP)'} end) c:RegisterEffect(e) end`;
   if(name==='c900001194.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+original+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetTarget(s.tg) e:SetOperation(s.op) c:RegisterEffect(e) end function s.filter(c,e,tp) return c:IsCode(900001193) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.filter,tp,LOCATION_HAND+LOCATION_SZONE,0,1,nil,e,tp) end end function s.op(e,tp) local c=Duel.GetFirstMatchingCard(s.filter,tp,LOCATION_HAND+LOCATION_SZONE,0,nil,e,tp) if c then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end';
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8'); if(name==='c'+boss+'.lua'&&process.argv.includes('--candidate'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/tide-optional-candidate.lua'),'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-summon')lua=lua.replace('if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end','do end');
    if(control==='ignore-set')lua=lua.replace('c:IsSetCard(SET_CREWAL) and c:IsLocation','c:IsLocation');
    if(control==='ignore-origin')lua=lua.replace('return eg:IsExists(s.evfilter,1,nil)','return true');
    if(control==='allow-down')lua=lua.replace('c:IsFaceupEx()','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,offered=false,interrupted=false;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   if(process.argv.includes('--faceup-compat'))core.loadScript(duel,'tide-faceup-compat.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.SZONE,0,P.FACEUP_ATTACK,5);add(original,L.MZONE,0,P.FACEUP_ATTACK);add(cost,test.handOrigin?L.HAND:L.SZONE,0,P.FACEUP_ATTACK);add(partner,test.szone?L.SZONE:test.removed?L.REMOVED:L.GRAVE,0,test.down?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);if(test.full)for(let i=1;i<4;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   if(Object.keys(test).length)add(900001197,L.SZONE,1);if(test.fill)for(let i=0;i<3;i++)add(900001194,L.DECK);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0,'Actual helper activation');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.MZONE).some(c=>c.code===cost),'Actual source-zone special summon');const eligible=true,revive=!(test.activation||test.effect||test.sourceBanish||test.fill);assert.equal(offered,eligible,'Printed trigger eligibility');assert.equal(interrupted,Object.keys(test).length>0,'Actual CounterTrapCL2');if(test.sourceBanish)assert(query(L.REMOVED).some(c=>c.code===boss),'Actual source banishment');if(test.resourceBanish)assert(trace.some(m=>m.type===M.MOVE&&m.card===partner&&m.from.location===L.GRAVE&&m.to.location===L.REMOVED),'Actual late resource banishment');if(test.fill)assert.equal(query(L.MZONE).filter(c=>c.code===900001194).length,3,'Actual late zone fill');assert.equal(query(L.MZONE).some(c=>c.code===partner),revive,'Actual chosen revival');if(revive)assert(!query(test.szone?L.SZONE:test.removed?L.REMOVED:L.GRAVE).some(c=>c.code===partner),'Actual resource leaves origin');done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss);offered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===900001197);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-tide-revival-interruption'+(process.argv.includes('--faceup-compat')?'-faceup-compat':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:process.argv.includes('--faceup-compat')?{method:'Card.IsFaceupEx',definition:'return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK)',source:'https://raw.githubusercontent.com/Fluorohydride/ygopro-core/master/libcard.cpp',lines:[2644,2649],qualification:'Compatibility diagnostic only; not native Omega or adapter-free production certification'}:null,scope:'Full Tide trigger with actual sourceSZONE summon and CounterTrapCL2 negation/sourcebanishment/late zonefill/resourcebanishment; explicit IsFaceupEx diagnostic mode distinguished. Shared use/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
