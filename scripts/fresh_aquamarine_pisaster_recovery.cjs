'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=211682274,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=process.argv.includes('--allow-spell')?'allow-spell':process.argv.includes('--ignore-relation')?'ignore-relation':process.argv.includes('--no-count')?'no-count':process.argv.includes('--shared-effects')?'shared-effects':null;
 for(const test of [{},{spell:true},{trap:true},{wrongSet:true},{selfTarget:true},{facedown:true},{fromHand:true},{fromField:true},{targetLost:true},{targetReturned:true},{count:true},{independent:true}]){
  const targetCode=test.selfTarget?boss:lab;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:test.trap?4:33,setcodes:test.wrongSet?[]:[0xf3c]}],[filler,{...base,code:filler}]]);
  cards.set(spellCost,{...base,code:spellCost,type:33});
  cards.set(recipient,{...base,code:recipient,type:2});
  const reader=name=>{
   if((test.targetLost||test.targetReturned)&&name==='c'+spellCost+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetRange(LOCATION_MZONE) e:SetCode(EVENT_CHAINING) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+boss+') end) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_REMOVED,nil,'+lab+'):GetFirst() Duel.SendtoGrave(c,REASON_EFFECT) '+(test.targetReturned?'Duel.Remove(c,POS_FACEUP,REASON_EFFECT)':'')+' end) c:RegisterEffect(e) end';
   if(name==='c'+recipient+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,'+(test.fromHand?'LOCATION_HAND':test.fromField?'LOCATION_MZONE':'LOCATION_GRAVE')+',0,nil,'+boss+')'+(test.count?'':':GetFirst()')+' Duel.Remove(c,POS_FACEUP,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){

    lua=lua.replace('c:IsFaceupEx()','c:IsFaceup()');
    if(control==='shared-effects')lua=lua.replace('e3:SetCountLimit(1,id+2)','e3:SetCountLimit(1,id+1)');
    if(control==='no-count')lua=lua.replace('e3:SetCountLimit(1,id+2)','do end');
    if(control==='ignore-relation')lua=lua.replace('tc:IsRelateToEffect(e)','true');
    if(control==='allow-spell')lua=lua.replace('and c:IsType(TYPE_MONSTER) and not c:IsCode(id) and c:IsFaceup()','and not c:IsCode(id) and c:IsFaceup()');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(test.targetLost||test.targetReturned)add(spellCost,L.MZONE,1,P.FACEUP_ATTACK);
   add(boss,test.fromHand?L.HAND:test.fromField||test.independent?L.MZONE:L.GRAVE,0,P.FACEUP_ATTACK);add(recipient,L.HAND);add(targetCode,L.REMOVED,0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(test.independent)add(lab,L.DECK);if(test.count){add(boss,L.GRAVE,0,P.FACEUP_ATTACK);add(lab,L.REMOVED,0,P.FACEUP_ATTACK);}for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(test.independent&&!secondary){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Actual Tribute effect available');secondary=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!activated){if(test.independent){const cost=query(L.GRAVE).find(c=>c.code===boss);assert(cost&&(cost.reason&0x80),'First effect actually Tributes source as cost');assert(query(L.MZONE).some(c=>c.code===lab),'First effect actually summons Deck target');}const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0,'Actual removal effect available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const source=query(L.REMOVED).find(c=>c.code===boss&&(c.reason&0x40));assert(source&&(source.reason&0x40),'Source actually banished by effect');const eligible=!test.spell&&!test.trap&&!test.wrongSet&&!test.selfTarget&&!test.facedown&&!test.fromHand&&!test.fromField;assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.location===L.REMOVED),eligible,'Native recovery trigger eligibility');if(test.targetLost||test.targetReturned){assert(trace.some(m=>m.type===M.CHAINING&&m.code===spellCost&&m.chain_size===2),'Actual opponent interruption CL2');assert(trace.some(m=>m.type===M.MOVE&&m.card===lab&&m.from.location===L.REMOVED&&m.to.location===L.GRAVE),'Target actually leaves banishment');if(test.targetReturned)assert(trace.some(m=>m.type===M.MOVE&&m.card===lab&&m.from.location===L.GRAVE&&m.to.location===L.REMOVED),'Target actually rebanished');assert(query(test.targetReturned?L.REMOVED:L.GRAVE).some(c=>c.code===lab),'Interrupted target retained outside Hand');assert(!query(L.HAND).some(c=>c.code===lab),'Lost target not recovered');}else if(eligible){assert(query(L.HAND).some(c=>c.code===lab),'Actual banished Monster recovered');assert.equal(query(L.REMOVED).filter(c=>c.code===lab).length,test.count?1:0,'Banished target remainder');if(test.count){assert.equal(query(L.REMOVED).filter(c=>c.code===boss).length,2,'Two production sources actually banished');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,1,'Shared recovery HOPT across simultaneously banished copies');assert.equal(query(L.HAND).filter(c=>c.code===lab).length,1,'Exactly one recovery');}}else assert(!query(L.HAND).some(c=>c.code===targetCode),'Ineligible target not recovered');done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===targetCode);assert(index>=0,'Actual recovery target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const monsterZone=test.independent&&!activated;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<((monsterZone?0:8)+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:monsterZone?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.player===1&&(test.targetLost||test.targetReturned)?p.selects.findIndex(c=>c.code===spellCost):p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/aquamarine-pisaster-recovery'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:'Test-only IsFaceupEx translated to IsFaceup for exclusively banished targets; production Omega method preserved',engine:'Public OCGCore, full production Pisaster Giga/candidate metadata; neutral banishment Spell and recovery target. Actual source banishment and production recovery trigger, neutral target; native Omega unverified; no native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
