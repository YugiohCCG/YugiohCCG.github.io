'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=216958556,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-search','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{activation:true},{effect:true},{source:true},{show:true},{search:true},{down:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongShowSet?[]:[0xbc5]}],[cost,{...base,code:cost,type:test.nonmonster?2:17,setcodes:test.wrongSearchSet?[]:[0xbc5]}],[original,{...base,code:original}],[filler,{...base,code:filler}]]);
  cards.set(900001196,{...base,code:900001196,type:0x100004});
  const reader=name=>{
   if(name==='c900001196.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev) ${test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.down?'Duel.ChangePosition(Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,'+partner+'),POS_FACEDOWN_DEFENSE)':'Duel.Remove(Duel.GetFirstMatchingCard(Card.IsCode,0,'+(test.source?'LOCATION_GRAVE':test.show?'LOCATION_MZONE':'LOCATION_DECK')+',0,nil,'+(test.source?boss:test.show?partner:cost)+'),POS_FACEUP,REASON_EFFECT)'} end) c:RegisterEffect(e) end`;

   if(name==='c'+original+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,902) end) c:RegisterEffect(e) end';
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){if(control==='no-search')lua=lua.replace('Duel.SendtoHand(g,nil,REASON_EFFECT)','do end');if(control==='no-transfer')lua=lua.replace('s.faceupoppdeck(c,tp,REASON_EFFECT)','do end');if(control==='ignore-show')lua=lua.replace('and Duel.IsExistingMatchingCard(s.showfilter,tp,LOCATION_ONFIELD,LOCATION_DECK,1,nil)','and true');if(control==='ignore-search-set')lua=lua.replace('return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()','return c:IsCode(900001193) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()');if(control==='ignore-search-type')lua=lua.replace('and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()','and c:IsAbleToHand()');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,responded=false;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(Object.keys(test).length)add(900001196,L.SZONE,1);add(boss,L.GRAVE);if(!test.absent)add(partner,L.MZONE,0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,0);add(cost,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Native show and search qualification');if(!eligible){assert(query(L.GRAVE).some(c=>c.code===boss));done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const executes=!(test.activation||test.effect||test.show||test.down);
     assert.equal(query(L.HAND).some(c=>c.code===cost),executes&&!test.search,'Actual late Stain search');const source=query(L.DECK,1).find(c=>c.code===boss);assert.equal(!!source,executes&&!test.source,'Actual late source transfer');if(source)assert(source.position&(P.FACEUP_ATTACK|P.FACEUP_DEFENSE));
     assert.equal(query(L.GRAVE).some(c=>c.code===boss),!test.source&&!(executes&&!test.source));if(test.source||test.show||test.search)assert(query(L.REMOVED).some(c=>c.code===(test.source?boss:test.show?partner:cost)));
     if(test.down)assert(query(L.MZONE).find(c=>c.code===partner).position&P.FACEDOWN_DEFENSE);
     if(Object.keys(test).length){assert(responded);assert(trace.some(m=>m.type===M.CHAINING&&m.code===900001196&&m.chain_size===2));}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===900001196);if(index>=0&&!responded&&control!=='no-response'){responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner||c.code===cost);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-dante-gy-interruption'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current Dante actual GY ignition, real own faceup neutral Stain card shown, source transferred faceup to opposing Deck and real Stain monster searched. No adapters. Actual native CL2 activation/effect negation, source/show/search banish and show facedown: source banish still allows search, search loss still allows source transfer, show loss aborts both; interruptions/use/nativeOmega/fullcard OPEN.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
