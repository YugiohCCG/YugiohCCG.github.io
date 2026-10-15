'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=212822164,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-banish','ignore-set','ignore-type','no-lock'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{three:true},{one:true},{wrongSet:true},{spell:true},{sourceLock:true},{deckLock:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:17,setcodes:test.wrongSet?[]:[0x18a]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:17}]]);
  cards.set(spellCost,{...base,code:spellCost,type:17,setcodes:[0x103]});
  const reader=name=>{
   if(name==='c'+lab+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${test.deckLock&&control!=='no-lock'?'local l=Effect.CreateEffect(c) l:SetType(EFFECT_TYPE_SINGLE) l:SetCode(EFFECT_CANNOT_REMOVE) c:RegisterEffect(l)':''} end`;if([recipient,filler,spellCost].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(test.sourceLock&&control!=='no-lock')lua=lua.replace('c:EnableReviveLimit()','c:EnableReviveLimit() local l=Effect.CreateEffect(c) l:SetType(EFFECT_TYPE_SINGLE) l:SetCode(EFFECT_CANNOT_REMOVE) c:RegisterEffect(l)');if(control==='no-banish')lua=lua.replace('Duel.Remove(sg,POS_FACEUP,REASON_EFFECT)','do end');if(control==='ignore-set')lua=lua.replace('c:IsSetCard(SET_GHOTI) and c:IsType(TYPE_MONSTER)','c:IsCode('+lab+') and c:IsType(TYPE_MONSTER)');if(control==='ignore-type')lua=lua.replace('c:IsSetCard(SET_GHOTI) and c:IsType(TYPE_MONSTER)','c:IsSetCard(SET_GHOTI)');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);for(let i=0;i<(test.one?1:test.three?3:2);i++)add(lab,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller,location}).filter(Boolean);let placements=0,placed=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===boss);const eligible=!(test.one||test.wrongSet||test.spell||test.sourceLock||test.deckLock);assert.equal(index>=0,eligible,'Printed self and two Deck monster banish eligibility');if(!eligible){assert(query(L.MZONE).some(c=>c.code===boss));assert.equal(query(L.REMOVED).length,0);done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.REMOVED).some(c=>c.code===boss),'Actual source banished');assert.equal(query(L.REMOVED).filter(c=>c.code===lab).length,2,'Exactly two Deck monsters actually banished');assert.equal(query(L.DECK).filter(c=>c.code===lab).length,test.three?1:0);assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Actual full printed effect activated');done=true;}
    else if(p.type===M.SELECT_CARD){assert.equal(p.min,2);assert.equal(p.max,2);assert(p.selects.every(c=>c.code===lab));core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0,1]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>c.code===spellCost);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x1f)!==0x1f;const shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-bray-deck-banish'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current initial-field Bray actual printed Quick selfbanish and exactly two own Ghoti Deck monsters banished; minimum/type/set/native source-resource locks. No adapters. Initial field does not certify proper Synchro arrival; Fish restriction/battle protection/interruptions/shared use/native Omega/fullcard open.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
