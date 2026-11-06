'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),prior=process.argv.includes('--prior-source'),namedOnly=process.argv.includes('--named-only'),results=[];
 for(const test of [{},{disable:true},{remove:true},{disable:true,second:true},{disable:true,second:true,both:true},{disable:true,restore:true}]){
  const boss=259941091,body=900009801,change=900009802,filler=900009803,logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[body,{...base,code:body}],[change,{...base,code:change,type:2}],[filler,{...base,code:filler,type:2}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+boss+'.lua'){const lua=fs.readFileSync(path.join(OUT,'oceanica-before-named-immunity-repair',name),'utf8');return prior?lua:require('./fresh_oceanica_named_immunity_repair.cjs')[namedOnly?'named':'corrected'](lua);}
   if(name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_IGNITION) x:SetRange(LOCATION_MZONE) x:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(x) end';
   if(name==='c'+change+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,1,${test.both?'LOCATION_FZONE':'0'},LOCATION_FZONE,nil,${boss}) for fc in aux.Next(g) do ${test.remove?'Duel.SendtoGrave(fc,REASON_EFFECT)':'local a=Effect.CreateEffect(e:GetHandler()) a:SetType(EFFECT_TYPE_SINGLE) a:SetCode(EFFECT_DISABLE) a:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END) fc:RegisterEffect(a) local b=a:Clone() b:SetCode(EFFECT_DISABLE_EFFECT) fc:RegisterEffect(b)'} end end) c:RegisterEffect(x) local y=Effect.CreateEffect(c) y:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) y:SetCode(EVENT_CHAIN_SOLVED) y:SetOperation(function(e,tp,eg,ep,ev,re) if not re:GetHandler():IsCode(id) then return end local g=Duel.GetMatchingGroup(Card.IsCode,1,${test.both?'LOCATION_FZONE':'0'},LOCATION_FZONE,nil,${boss}) ${test.remove?'assert(#g==0,"Original source really removed")':'assert(#g>0) for fc in aux.Next(g) do assert(fc:IsDisabled(),"Original source really negated") end'} end) Duel.RegisterEffect(y,0) end`;
   const p=path.join(ROOT,'tmp/omega_scripts',name);assert(fs.existsSync(p),name);return fs.readFileSync(p,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,summoned=false,changed=false,activated=false,turn=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.SZONE,0,5);if(test.second)add(boss,L.SZONE,1,5);add(body,L.HAND,1);if(test.disable||test.remove)add(change,L.HAND,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(duel);
   for(let step=0;step<220&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);turn+=messages.filter(m=>m.type===M.NEW_TURN).length;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player!==1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!summoned){const index=p.summons.findIndex(c=>c.code===body);assert(index>=0);summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});continue;}
     const index=p.activates.findIndex(c=>c.code===body);if(test.restore&&activated&&turn>2){assert(index<0,'Original aura resumes after temporary source negation expires');done=true;continue;}
     if(!changed){assert(index<0,'Original Hand summon aura initially prevents ignition');if(!test.disable&&!test.remove){done=true;continue;}const j=p.activates.findIndex(c=>c.code===change);assert(j>=0);changed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:j});continue;}
     const free=!!test.remove||(!!test.disable&&(!test.second||!!test.both));assert.equal(index>=0,free,'Existing Hand-lock follows active original field source');
     if(free&&!activated){activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(trace.filter(m=>m.type===M.RECOVER&&m.player===1).length,free?1:0,'Actual previously locked ignition resolution');if(test.restore){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,logs,trace});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?' '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-oceanica-source-disable'+(prior?'-prior-source':namedOnly?'-named-only':'')+'.json'),JSON.stringify({scope:'Full original Oceanica aura on real native Hand Normal Summon; native temporary negation/removal of original field source and original recipient ignition. Neutral change Spell and recipient. No Lua API mapping; not full-card/live Omega certification.',prior,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
