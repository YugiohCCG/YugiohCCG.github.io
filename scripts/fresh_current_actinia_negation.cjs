'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=216258796,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-negate','no-destroy','no-cost','ignore-partner','ignore-cost-type'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{absent:true},{wrongSet:true},{facedown:true},{opponent:true},{noCost:true},{wrongRace:true},{wrongAttribute:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongSet?[]:[0xf3c]}],[cost,{...base,code:cost,race:test.wrongRace?1n:64n,attribute:test.wrongAttribute?1:2}],[original,{...base,code:original}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c'+original+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,902) end) c:RegisterEffect(e) end';
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-negate')lua=lua.replace('Duel.NegateActivation(ev)','false');
    if(control==='no-destroy')lua=lua.replace('Duel.Destroy(eg,REASON_EFFECT)','do end');
    if(control==='no-cost')lua=lua.replace('Duel.Remove(g,POS_FACEUP,REASON_COST)','do end');
    if(control==='ignore-partner')lua=lua.replace('and Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsSetCard(SET_AQUAMARINE) and c~=e:GetHandler() end,tp,LOCATION_MZONE,0,1,nil)','and true');
    if(control==='ignore-cost-type')lua=lua.replace('return c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_AQUA) and c:IsAbleToRemoveAsCost()','return c:IsAbleToRemoveAsCost()');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,responded=false;
  const eligible=!Object.keys(test).length;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);if(!test.absent)add(partner,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);if(!test.noCost)add(cost,L.GRAVE);add(original,L.MZONE,0,P.FACEUP_ATTACK,2);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(responded,eligible,'Native response qualification');assert.equal(query(L.GRAVE).some(c=>c.code===original),eligible,'Actual original card destruction');
     assert.equal(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='902'),!eligible,'Native original activation suppression');
     const paid=query(L.REMOVED).find(c=>c.code===cost);assert.equal(!!paid,eligible,'Actual WATER Aqua banish cost');if(paid){assert(paid.reason&0x80);assert(paid.position&P.FACEUP_ATTACK||paid.position&P.FACEUP_DEFENSE);}
     if(eligible)assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.chain_size===2));done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);if(index>=0){responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===cost);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-actinia-negation'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current Actinia initial MZONE, actual own neutral ignition CL1 and native Quick CL2. Real WATER Aqua GY cost/activation negation/destruction; another Aquamarine absent/wrongset/facedown/opponent and absent/wrongrace/wrongattribute costs excluded. No proper Fusion history, adapters or seeded use. Revival/once-use/interruption/nativeOmega/fullcard OPEN.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
