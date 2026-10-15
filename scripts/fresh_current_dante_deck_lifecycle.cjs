'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=216958556,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-transfer','no-draw','no-return'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{special:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongShowSet?[]:[0xbc5]}],[cost,{...base,code:cost,type:test.nonmonster?2:17,setcodes:test.wrongSearchSet?[]:[0xbc5]}],[original,{...base,code:original}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) s.drawn=false local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) if not s.drawn then local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_DECK,0,nil,${boss}) Duel.MoveSequence(tc,0) ${control==='no-draw'?'do end':'Duel.Draw(tp,1,REASON_EFFECT)'} s.drawn=true else local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}) Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end end) c:RegisterEffect(e) end`;
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){if(control==='no-return')lua=lua.replace('Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)','do end');if(control==='no-transfer')lua=lua.replace('s.faceupoppdeck(c,tp,REASON_EFFECT)','do end');if(control==='ignore-show')lua=lua.replace('and Duel.IsExistingMatchingCard(s.showfilter,tp,LOCATION_ONFIELD,LOCATION_DECK,1,nil)','and true');if(control==='ignore-search-set')lua=lua.replace('return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()','return c:IsCode(900001193) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()');if(control==='ignore-search-type')lua=lua.replace('and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()','and c:IsAbleToHand()');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,stage=0,turn=0;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(original,L.MZONE,1,P.FACEUP_ATTACK,0);add(boss,L.GRAVE);if(!test.absent)add(partner,L.MZONE,0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,0);add(cost,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!stage){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0);stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(stage===1){assert(query(L.HAND).some(c=>c.code===cost));const source=query(L.DECK,1).find(c=>c.code===boss);assert(source&&source.position&(P.FACEUP_ATTACK|P.FACEUP_DEFENSE));if(turn<2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(stage===2){assert(query(L.HAND,1).some(c=>c.code===boss),'Transferred source actually drawn into opponent Hand');assert(!query(L.DECK,1).some(c=>c.code===boss));const list=test.special?p.activates:p.summons;const index=list.findIndex(c=>c.code===(test.special?original:boss));assert(index>=0);stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:test.special?A.SELECT_ACTIVATE:A.SELECT_SUMMON,index});continue;}
     assert.equal(turn,2);assert(query(L.GRAVE).some(c=>c.code===partner),'Opposing borrowed source destroys own original owner target');assert(query(L.DECK).some(c=>c.code===boss),'Borrowed source returns to original owner Deck');assert(!query(L.DECK,1).some(c=>c.code===boss));assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.triggering_controller===1),'Actual opponent summon trigger');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner||c.code===cost);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-dante-deck-lifecycle'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full same Dante actual GY ignition and transfer/search, neutral native MoveSequence then opponent Draw on turn2, actual borrowed Normal or SpecialSummon and opposing trigger destroys original owner target then returns source to original owner Deck; real own faceup neutral Stain card shown, source transferred faceup to opposing Deck and real Stain monster searched. No adapters. Show and search set/type qualification boundaries; interruptions/use/nativeOmega/fullcard OPEN.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
