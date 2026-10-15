'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217645912,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['per-copy','no-reset','no-response'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{decline:true},{activation:true},{effect:true}];const opponentReset=process.argv.includes('--opponent-reset'),resetTurn=opponentReset?2:3;
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,race:16n,setcodes:test.wrongSet?[]:[0xe2f]}],[cost,{...base,code:cost}],[original,{...base,code:original,type:33}],[900001194,{...base,code:900001194}],[900001197,{...base,code:900001197,type:0x100004}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c900001197.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.activation?'Duel.NegateActivation(ev)':test.effect?'Duel.NegateEffect(ev)':test.sourceBanish?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':test.resourceBanish?`Duel.Remove(Duel.GetFirstMatchingCard(Card.IsCode,1-tp,LOCATION_GRAVE,0,nil,${partner}),POS_FACEUP,REASON_EFFECT)`:'local g=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,900001194) Duel.SpecialSummon(g,0,1-tp,1-tp,false,false,POS_FACEUP)'} end) c:RegisterEffect(e) end`;
   if(name==='c900001194.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+original+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetTarget(s.tg) e:SetOperation(s.op) c:RegisterEffect(e) end function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(Card.IsCode,0,LOCATION_SZONE,0,1,nil,900001193) end end function s.op(e,tp) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(900001193,900001191) end,0,LOCATION_MZONE,0,nil) Duel.SendtoGrave(g,REASON_EFFECT) local c=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_SZONE,0,nil,900001193) if c then Duel.SpecialSummon(c,0,0,0,false,false,POS_FACEUP) end end';
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8'); if(name==='c'+boss+'.lua'&&process.argv.includes('--candidate'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/tide-optional-candidate.lua'),'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='per-copy')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1)');
    if(control==='no-reset')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1,id+100,2)');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,offered=0,interrupted=false,attempts=0,pending=false,replaced=false,turn=0;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   if(process.argv.includes('--faceup-compat'))core.loadScript(duel,'tide-faceup-compat.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.SZONE,0,P.FACEUP_ATTACK,5);add(boss,L.HAND);add(original,L.MZONE,0,P.FACEUP_ATTACK);if(opponentReset)add(original,L.MZONE,1,P.FACEUP_ATTACK);for(let i=0;i<3;i++)add(cost,L.SZONE,0,P.FACEUP_ATTACK,i);add(partner,L.GRAVE,0,P.FACEUP_ATTACK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   if(test.activation||test.effect)add(900001197,L.SZONE,1);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<300&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(pending){const revive=attempts===1?!(test.decline||test.activation||test.effect):attempts===2?!!test.decline:true;assert.equal(query(L.MZONE).some(c=>c.code===partner),revive,'Actual shared revival use/reset');assert(query(L.MZONE).some(c=>c.code===cost),'Actual new SZONE summon');assert.equal(offered,attempts===1?1:attempts===2?(test.decline?2:1):(test.decline?3:2),'Named trigger offer count');if(attempts===1)assert.equal(interrupted,!!(test.activation||test.effect),'Actual first CounterTrapCL2');pending=false;if(attempts===3){assert.equal(turn,resetTurn);assert(trace.filter(m=>m.type===M.MOVE&&m.card===cost&&m.from.location===L.SZONE&&m.to.location===L.MZONE).length===3,'Three actual SZONE summons');done=true;continue;}}
     if(attempts===1&&!replaced){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Actual second Field copy activation');replaced=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(attempts<2&&p.player!==0||attempts===2&&turn<resetTurn){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const index=p.activates.findIndex(c=>c.code===original);assert(index>=0,'Actual next helper activation');attempts++;pending=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss);offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!(test.decline&&attempts===1)});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!(test.decline&&attempts===1)});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const field=(p.field_mask&(1<<13))===0;const sequence=field?5:[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:field?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===900001197);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-tide-revival-use-reset'+(opponentReset?'-opponent-reset':'')+(process.argv.includes('--faceup-compat')?'-faceup-compat':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:process.argv.includes('--faceup-compat')?{method:'Card.IsFaceupEx',definition:'return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK)',source:'https://raw.githubusercontent.com/Fluorohydride/ygopro-core/master/libcard.cpp',lines:[2644,2649],qualification:'Compatibility diagnostic only; not native Omega or adapter-free production certification'}:null,scope:'Two full Tide copies, three actual SZONE summons: successful/activation-negated/effect-negated first use blocks replacement-copy revival same ownturn1, declined first preserves use; actual ownturn3 resets. Explicit IsFaceupEx diagnostic only; Omega/fullcard OPEN',control,resetTurn,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
