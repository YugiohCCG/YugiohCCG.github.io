'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217700538,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-set','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{activation:true},{effect:true},{sourceBanish:true},{fill:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,type:0x800021,level:4,setcodes:test.wrongSet?[]:[0xc1c]}],[cost,{...base,code:cost}],[original,{...base,code:original,type:33}],[900001196,{...base,code:900001196,type:2}],[900001197,{...base,code:900001197,type:0x100004}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c900001196.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c900001197.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.sourceBanish?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':'local g=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_HAND,0,nil,900001196) for c in aux.Next(g) do Duel.SSet(1-tp,c) end'} end) c:RegisterEffect(e) end`;

   if(name==='c'+partner+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_SPSUMMON_PROC) e:SetProperty(EFFECT_FLAG_UNCOPYABLE) e:SetRange(LOCATION_EXTRA) e:SetValue(${test.ordinary?'0':'SUMMON_TYPE_XYZ'}) e:SetCondition(function(e,c) if c==nil then return true end local tp=c:GetControler() local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,900001193) return #g==2 and Duel.GetLocationCountFromEx(tp,tp,g,c)>0 end) e:SetOperation(function(e,tp,eg,ep,ev,re,r,rp,c) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,900001193) c:SetMaterial(g) Duel.Overlay(c,g) end) c:RegisterEffect(e) end`;
   if(name==='c'+cost+'.lua'||name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-set')lua=lua.replace('Duel.SSet(tp,c)','do end');
    if(control==='ignore-set')lua=lua.replaceAll('c:IsSetCard(SET_ALDREZ)','true');
    if(control==='ignore-summon-type')lua=lua.replace('c:IsSummonType(SUMMON_TYPE_XYZ)','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,offered=false,interrupted=false;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.GRAVE);add(partner,L.EXTRA,test.opponent?1:0);for(let i=0;i<2;i++)add(cost,L.MZONE,test.opponent?1:0,P.FACEUP_ATTACK,i);if(test.full)for(let i=0;i<5;i++)add(filler,L.SZONE,0,P.FACEDOWN_DEFENSE,i);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   if(Object.keys(test).length)add(900001197,L.SZONE,1);if(test.fill)for(let i=0;i<5;i++)add(900001196,L.HAND);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player!==(test.opponent?1:0)){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!activated){const index=p.special_summons.findIndex(c=>c.code===partner);assert(index>=0,'Native two-material Extra procedure');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     assert(query(L.MZONE,test.opponent?1:0).some(c=>c.code===partner),'Actual neutral Xyz source summoned');assert(!query(L.MZONE,test.opponent?1:0).some(c=>c.code===cost),'Actual two materials overlaid');assert.equal(trace.filter(m=>m.type===M.MOVE&&m.card===cost&&m.from.location===L.MZONE&&m.to.overlay_sequence!==undefined).length,2,'Two native material Overlay moves');assert(offered,'Actual optional trigger');assert.equal(interrupted,Object.keys(test).length>0,'Actual CounterTrapCL2');if(test.sourceBanish)assert(query(L.REMOVED).some(c=>c.code===boss),'Actual source banished');if(test.fill)assert.equal(query(L.SZONE).filter(c=>c.code===900001196).length,5,'Actual late five Spell sets');const set=query(L.SZONE).find(c=>c.code===boss);assert.equal(!!set,Object.keys(test).length===0,'Actual source Set fromGY');if(set)assert(set.position&P.FACEDOWN_DEFENSE,'Actually facedown Set');done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss);offered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===900001197);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-aldrez-blitz-set-interruption'+(process.argv.includes('--faceup-compat')?'-faceup-compat':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:process.argv.includes('--faceup-compat')?{method:'Card.IsFaceupEx',definition:'return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK)',source:'https://raw.githubusercontent.com/Fluorohydride/ygopro-core/master/libcard.cpp',lines:[2644,2649],qualification:'Compatibility diagnostic only; not native Omega or adapter-free production certification'}:null,scope:'Full Blitz GYSet trigger after actual neutral two-material native Xyz procedure, real CounterTrapCL2 activation/effect negation/sourcebanishment/five sequential late Spell Sets. Real material attachments/source destinations checked; no adapters; production Xyz recipes/shared Set use/Omega/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
