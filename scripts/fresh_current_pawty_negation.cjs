'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217632789,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-negate','no-destroy','ignore-owner','ignore-set'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{wrongSet:true},{down:true},{absent:true},{ownNeutral:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongSet?[]:[0xac74]}],[cost,{...base,code:cost,race:test.wrongRace?1n:64n,attribute:test.wrongAttribute?1:2}],[original,{...base,code:original,setcodes:test.ownStain?[0xbc5]:[]}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCategory(CATEGORY_SPECIAL_SUMMON) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end ${test.noCategory?'do end':'Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)'} end) e:SetOperation(function(e,tp) Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_DECK,0,nil,${cost}),0,tp,tp,false,false,POS_FACEUP) Duel.Hint(HINT_NUMBER,tp,902) end) c:RegisterEffect(e) end`;
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(process.argv.includes('--portable-regression'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/pawty-portable-activation-candidate.lua'),'utf8');
    if(control==='no-negate')lua=lua.replace('if not Duel.NegateActivation(ev) then return end','do return end');
    if(control==='no-destroy')lua=lua.replace('Duel.Destroy(eg,REASON_EFFECT)==0','true');
    if(control==='ignore-owner')lua=lua.replace('rp==1-tp','true');
    if(control==='ignore-set')lua=lua.replace('c:IsSetCard(SET_SKEWY)','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,responded=false;
  const eligible=!(test.ownNeutral||test.wrongSet||test.down||test.absent);let turn=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   const controller=test.ownStain||test.ownNeutral?0:1;add(boss,L.SZONE,0);if(!test.absent)add(partner,L.MZONE,0,test.down?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,0);add(original,L.MZONE,controller,P.FACEUP_ATTACK,1);add(cost,L.DECK,controller);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(turn<(test.ownStain||test.ownNeutral?1:2)){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}if(!activated){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(responded,eligible,'Native response qualification');assert.equal(query(L.GRAVE,controller).some(c=>c.code===original),eligible,'Actual original card destruction');
     assert.equal(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='902'),!eligible,'Native original activation suppression');
     assert.equal(query(L.MZONE,controller).some(c=>c.code===cost),!eligible,'Actual original native SpecialSummon suppression');
     if(eligible)assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.chain_size===2));done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);if(index>=0){responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===cost);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-pawty-negation'+(process.argv.includes('--portable-regression')?'-portable-regression':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full set Pawty Tyme actual opposing ignitionCL1/CounterTrapCL2 activation negation/destruction suppress native Deck summon; own effect/wrongset/facedown/absent Skewy monster exclude. No initial GY revival resource, Hand activation/revival/use/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
