'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=247756272,source=900001151,filler=900001152,results=[];
 const control=process.argv.includes('--no-negate')?'no-negate':process.argv.includes('--pay-instead')?'pay-instead':process.argv.includes('--faceup')?'faceup':process.argv.includes('--any-type')?'any-type':null;
 for(const test of [{},{banish:true},{trap:true},{monster:true},{own:true},{lowLP:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[source,{...base,code:source,type:test.monster?33:test.trap?4:2}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c'+source+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) '+(test.monster?'e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE)':'e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)')+' e:SetOperation(function(e,tp) Duel.Recover(tp,500,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);
   let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='no-negate')lua=lua.replace('Duel.NegateEffect(ev)','false');
    if(control==='pay-instead')lua=lua.replace('Duel.Damage(tp,2000,REASON_EFFECT)','Duel.PayLPCost(tp,2000)');
    if(control==='faceup')lua=lua.replace('Duel.Remove(c,POS_FACEDOWN,REASON_EFFECT)','Duel.Remove(c,POS_FACEUP,REASON_EFFECT)');
    if(control==='any-type')lua=lua.replace('re:IsActiveType(TYPE_SPELL+TYPE_TRAP)','true');
   }return lua;
  };
  const initialLP=test.lowLP?1500:8000;
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:initialLP,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,gateChecked=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE);const player=test.own?0:1;add(source,test.monster?L.MZONE:test.trap?L.SZONE:L.HAND,player,test.own?1:0,test.trap?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);
   for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(duel);
   const eligible=!test.monster&&!test.own;
   const verify=()=>{
    assert.equal(trace.some(m=>m.type===M.RECOVER),!eligible,'Actual source operation suppression');
    const damage=trace.filter(m=>m.type===M.DAMAGE&&m.player===0);
    assert.equal(damage.length,eligible&&!test.banish?1:0,'Damage event count');if(damage.length)assert.equal(damage[0].amount,2000,'Damage amount');
    assert.equal(trace.filter(m=>m.type===M.PAY_LPCOST&&m.player===0).length,0,'Damage must not be LP payment');
    const removed=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION|Q.REASON,controller:0,location:L.REMOVED}).filter(Boolean);
    if(test.banish){const c=removed.find(c=>c.code===boss);assert(c,'Jakarta banished');assert(c.position&P.FACEDOWN_DEFENSE,'Jakarta banished face-down');assert(c.reason&0x40,'Effect banishment');}
    else assert(!removed.some(c=>c.code===boss),'Jakarta retained');
    done=true;
   };
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END){assert(test.lowLP,'Unexpected duel end');verify();break;}if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!test.own&&turn<2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}if(activated){verify();continue;}const index=p.activates.findIndex(x=>x.code===source);assert(index>=0,'Source activation available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);if(activated&&p.player===0&&!gateChecked){assert.equal(index>=0,eligible,'Spell/Trap opponent gate');gateChecked=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.banish?1:0});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_PLACE){const offset=player===0?8:24,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(offset+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/kali-jakarta-negation'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore; full production Jakarta/candidate metadata, seeded field source. Actual effect negation and damage/face-down branches; no proper Synchro procedure or native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
