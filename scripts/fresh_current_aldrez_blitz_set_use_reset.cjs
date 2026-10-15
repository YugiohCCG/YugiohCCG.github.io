'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217700538,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['per-copy','no-reset','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{decline:true},{activation:true},{effect:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,type:0x800021,level:4,setcodes:test.wrongSet?[]:[0xc1c]}],[cost,{...base,code:cost}],[original,{...base,code:original,type:33}],[900001196,{...base,code:900001196,type:2}],[900001197,{...base,code:900001197,type:0x100004}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+original+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,900001191),REASON_EFFECT) Duel.SendtoDeck(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,900001191),nil,SEQ_DECKBOTTOM,REASON_EFFECT) Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,900001193),0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) end';
   if(name==='c900001196.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c900001197.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.sourceBanish?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':'local g=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_HAND,0,nil,900001196) for c in aux.Next(g) do Duel.SSet(1-tp,c) end'} end) c:RegisterEffect(e) end`;

   if(name==='c'+partner+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_SPSUMMON_PROC) e:SetProperty(EFFECT_FLAG_UNCOPYABLE) e:SetRange(LOCATION_EXTRA) e:SetValue(${test.ordinary?'0':'SUMMON_TYPE_XYZ'}) e:SetCondition(function(e,c) if c==nil then return true end local tp=c:GetControler() local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,900001193) return #g==2 and Duel.GetLocationCountFromEx(tp,tp,g,c)>0 end) e:SetOperation(function(e,tp,eg,ep,ev,re,r,rp,c) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,900001193) c:SetMaterial(g) Duel.Overlay(c,g) end) c:RegisterEffect(e) end`;
   if(name==='c'+cost+'.lua'||name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='per-copy')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1)');if(control==='no-reset')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1,id+100,2)');
    if(control==='ignore-set')lua=lua.replaceAll('c:IsSetCard(SET_ALDREZ)','true');
    if(control==='ignore-summon-type')lua=lua.replace('c:IsSummonType(SUMMON_TYPE_XYZ)','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,offered=false,interrupted=false,attempts=0,pending=false,prepared=false,turn=0;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   for(let i=0;i<3;i++)add(boss,L.GRAVE);add(original,L.MZONE,0,P.FACEUP_ATTACK,2);add(partner,L.EXTRA,test.opponent?1:0);for(let i=0;i<2;i++)add(cost,L.MZONE,test.opponent?1:0,P.FACEUP_ATTACK,i);if(test.full)for(let i=0;i<5;i++)add(filler,L.SZONE,0,P.FACEDOWN_DEFENSE,i);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   if(Object.keys(test).length)add(900001197,L.SZONE,1);if(test.fill)for(let i=0;i<5;i++)add(900001196,L.HAND);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<400&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(pending){const count=query(L.SZONE).filter(c=>c.code===boss).length;const expected=attempts===1?(!(test.activation||test.effect||test.decline)?1:0):attempts===2?(test.activation||test.effect?0:1):(test.activation||test.effect?1:2);assert.equal(count,expected,'Actual shared GYSet use/reset');pending=false;if(attempts===3){assert.equal(turn,3);assert.equal(trace.filter(m=>m.type===M.MOVE&&m.card===cost&&m.from.location===L.MZONE&&m.to.overlay_sequence!==undefined).length,6,'Six actual material attachments');assert.equal(trace.filter(m=>m.type===M.SPSUMMONING&&m.code===partner).length,3,'Three native Xyz summons');done=true;continue;}}
     if(p.player!==0||attempts===2&&turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(attempts>0&&!prepared){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const index=p.special_summons.findIndex(c=>c.code===partner);assert(index>=0,'Actual next native Xyz procedure');attempts++;pending=true;prepared=false;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss);offered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!(test.decline&&attempts===1)});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!(test.decline&&attempts===1)});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===900001197);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else {const source=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:source>=0&&!(test.decline&&attempts===1)?source:p.forced?0:null});}}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,attempts,turn,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-aldrez-blitz-set-use-reset'+(process.argv.includes('--faceup-compat')?'-faceup-compat':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:process.argv.includes('--faceup-compat')?{method:'Card.IsFaceupEx',definition:'return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK)',source:'https://raw.githubusercontent.com/Fluorohydride/ygopro-core/master/libcard.cpp',lines:[2644,2649],qualification:'Compatibility diagnostic only; not native Omega or adapter-free production certification'}:null,scope:'Three full BlitzGY copies/three native neutral two-material Xyz procedures: successful/activation-negated/effect-negated first Set use shared, declined first preserves; second ownturn1 summon excludes spent uses, actual ownturn3 resets. Native material resurrection/recycling and six attachments checked. No adapters; production Xyz recipes/Omega/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
