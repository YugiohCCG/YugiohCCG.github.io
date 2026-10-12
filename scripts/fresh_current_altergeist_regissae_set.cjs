'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=211873618,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-set','allow-set','allow-type','no-removal'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{wrongSet:true},{spell:true},{monster:true},{fromRemoved:true}]){
  const targetCode=test.selfTarget?boss:lab;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:test.monster?33:4,setcodes:test.wrongSet?[]:[0x103]}],[filler,{...base,code:filler}]]);
  cards.set(spellCost,{...base,code:spellCost,type:33});
  cards.set(recipient,{...base,code:recipient,type:2});
  const reader=name=>{
   if((test.targetLost||test.targetReturned)&&name==='c'+spellCost+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetRange(LOCATION_MZONE) e:SetCode(EVENT_CHAINING) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+boss+') end) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_REMOVED,nil,'+lab+'):GetFirst() Duel.SendtoGrave(c,REASON_EFFECT) '+(test.targetReturned?'Duel.Remove(c,POS_FACEUP,REASON_EFFECT)':'')+' end) c:RegisterEffect(e) end';
   if(name==='c'+recipient+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,'+(test.fromRemoved?'LOCATION_REMOVED':'LOCATION_MZONE')+',0,nil,'+boss+')'+(test.count?'':':GetFirst()')+(control==='no-removal'?' do end':' Duel.SendtoGrave(c,REASON_EFFECT)')+' end) c:RegisterEffect(e) end';
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){

    
    if(control==='no-set')lua=lua.replace('Duel.SSet(tp,tc)','do end');if(control==='allow-set')lua=lua.replace('c:IsSetCard(0x103) and c:IsType(TYPE_TRAP) and c:IsSSetable()','c:IsType(TYPE_TRAP) and c:IsSSetable()');if(control==='allow-type')lua=lua.replace('c:IsSetCard(0x103) and c:IsType(TYPE_TRAP) and c:IsSSetable()','c:IsSetCard(0x103) and c:IsSSetable()');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(test.targetLost||test.targetReturned)add(spellCost,L.MZONE,1,P.FACEUP_ATTACK);
   add(boss,test.fromRemoved?L.REMOVED:L.MZONE,0,P.FACEUP_ATTACK);add(recipient,L.HAND);add(targetCode,L.GRAVE,0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(test.independent)add(lab,L.DECK);if(test.count){add(boss,L.GRAVE,0,P.FACEUP_ATTACK);add(lab,L.REMOVED,0,P.FACEUP_ATTACK);}for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(test.independent&&!secondary){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Actual Tribute effect available');secondary=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!activated){if(test.independent){const cost=query(L.GRAVE).find(c=>c.code===boss);assert(cost&&(cost.reason&0x80),'First effect actually Tributes source as cost');assert(query(L.MZONE).some(c=>c.code===lab),'First effect actually summons Deck target');}const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0,'Actual removal effect available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.GRAVE).some(c=>c.code===boss),'Actual full field/banishment-to-GY departure');const eligible=!test.wrongSet&&!test.spell&&!test.monster&&!test.fromRemoved;assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.location===L.GRAVE),eligible,'Actual native set-trigger eligibility');const tc=query(L.SZONE).find(c=>c.code===lab);assert.equal(!!tc,eligible,'Actual Trap set from GY');if(tc)assert(tc.position&P.FACEDOWN_DEFENSE);if(!eligible)assert(query(L.GRAVE).some(c=>c.code===lab),'Excluded actual GY target retained');done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===targetCode);assert(index>=0,'Actual recovery target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const monsterZone=test.independent&&!activated;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<((monsterZone?0:8)+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:monsterZone?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.player===1&&(test.targetLost||test.targetReturned)?p.selects.findIndex(c=>c.code===spellCost):p.selects.findIndex(c=>c.code===boss&&c.location===L.GRAVE);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-altergeist-regissae-set'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,engine:'Full current Regissae initially MZONE/banishment, actual native effect SendGY and GY Trap setting. Neutral removal Spell/targets, no adapters. Initial source does not prove native Link arrival; Link procedure GetMustMaterial/native Omega and other effect gaps open.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
