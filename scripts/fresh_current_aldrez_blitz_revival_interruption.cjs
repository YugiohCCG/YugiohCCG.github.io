'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217700538,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-summon','no-response','ignore-relation'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{activation:true},{effect:true},{targetBanish:true},{sourceBanish:true},{fill:5},{fill:4},{targetCycle:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongSet?[]:[0xc1c],level:test.level5?5:test.level3?3:4}],[900001196,{...base,code:900001196}],[900001197,{...base,code:900001197,type:0x100004}],[217700539,candidateCard(217700539)],[original,{...base,code:original,type:33}],[900001194,{...base,code:900001194,type:33}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c900001196.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c900001197.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.sourceBanish?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':test.fill?'Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,900001196),0,1-tp,1-tp,false,false,POS_FACEUP)':`local c=Duel.GetFirstMatchingCard(Card.IsCode,1-tp,LOCATION_GRAVE,0,nil,${partner}) Duel.Remove(c,POS_FACEUP,REASON_EFFECT) ${test.targetCycle?'Duel.SendtoGrave(c,REASON_EFFECT)':''}`} end) c:RegisterEffect(e) end`;

   if(name==='c'+original+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetRange(LOCATION_MZONE) e:SetCode(EVENT_SPSUMMON_SUCCESS) e:SetOperation(function(e,tp,eg) local c=eg:Filter(Card.IsCode,nil,217700539):GetFirst() if c then assert(c:IsLevel(4) and c:IsRace(RACE_SPELLCASTER) and c:IsAttribute(ATTRIBUTE_DARK) and c:GetAttack()==1000 and c:GetDefense()==1000 and c:IsType(TYPE_TOKEN)) Duel.Hint(HINT_NUMBER,0,987) end end) c:RegisterEffect(e) end';
   if(name==='c900001194.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetRange(LOCATION_MZONE) e:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON) e:SetProperty(EFFECT_FLAG_PLAYER_TARGET) e:SetTargetRange(1,0) e:SetTarget(function(e,c) return c:IsCode(217700539) end) c:RegisterEffect(e) end';
   if(name==='c'+partner+'.lua'||name==='c'+filler+'.lua'||name==='c217700539.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-summon')lua=lua.replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0','0>0');
    if(control==='ignore-relation')lua=lua.replace('tc:IsRelateToEffect(e)','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,choices=0,interrupted=false;
  const eligible=!(test.level5||test.wrongSet||test.down||test.opponent||test.absent||test.full);
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(original,L.MZONE,1,P.FACEUP_ATTACK);if(!test.absent)add(partner,test.removed?L.REMOVED:L.GRAVE,test.opponent?1:0,test.down?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(test.full||test.oneZone)for(let i=0;i<(test.full?5:4);i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);if(test.tokenLock)add(900001194,L.MZONE,0,P.FACEUP_ATTACK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   if(Object.keys(test).length)add(900001197,L.SZONE,1);if(test.fill)for(let i=0;i<test.fill;i++)add(900001196,L.DECK);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Printed revival target eligibility');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(interrupted,Object.keys(test).length>0,'Actual CounterTrapCL2');assert(query(test.sourceBanish?L.REMOVED:L.GRAVE).some(c=>c.code===boss),'Actual source destination');if(test.fill)assert.equal(query(L.MZONE).filter(c=>c.code===900001196).length,test.fill,'Actual late zonefill');if(test.targetBanish||test.targetCycle){assert(trace.some(m=>m.type===M.MOVE&&m.card===partner&&m.from.location===L.GRAVE&&m.to.location===L.REMOVED),'Actual target departure');if(test.targetCycle)assert(trace.some(m=>m.type===M.MOVE&&m.card===partner&&m.from.location===L.REMOVED&&m.to.location===L.GRAVE),'Actual target return');}
     const revived=!(test.activation||test.effect||test.targetBanish||test.targetCycle||test.fill===5),token=revived&&test.fill!==4;assert.equal(query(L.MZONE).some(c=>c.code===partner),revived,'Actual target revival');assert.equal(query(L.MZONE).some(c=>c.code===217700539),token,'Actual optional Token');assert.equal(choices,token?1:0,'Optional Token availability');assert.equal(trace.some(m=>m.type===M.HINT&&Number(m.hint)===987),token,'Native Token stats/type observer');done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO){choices++;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===900001197);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-aldrez-blitz-revival-interruption'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full Aldrez Blitz actual Hand activation with CounterTrapCL2 activation/effect negation, target departure/return, sourcebanish and late full/one-free-zone fill. Actual targeted revival/optional Token native stats asserted; no adapters. Shared use/actualXyzGYSet/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
