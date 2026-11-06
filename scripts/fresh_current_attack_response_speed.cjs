'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv.includes('--no-attack-negate')?'no-attack-negate':process.argv.includes('--no-double')?'no-double':process.argv.includes('--candidate')?'candidate':'prior-source',candidate=mode!=='prior-source',results=[];
 for(const tcg of [false,true])for(const boss of [259844716,259235389])for(const test of [{},{late:true},{handFirst:true}]){
  const ally=900009781,enemy=900009782,filler=900009783,logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[ally,{...base,code:ally,type:boss===259844716?0x221:33,race:boss===259235389?0x10000n:1n}],[enemy,{...base,code:enemy,attack:500}],[filler,{...base,code:filler,type:2}]]);
  cards.set(900009784,{...base,code:900009784});
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c900009784.lua')return 'local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O) x:SetCode(EVENT_ATTACK_ANNOUNCE) x:SetRange(LOCATION_HAND) x:SetOperation(function(e,tp) Duel.Recover(tp,1,REASON_EFFECT) end) c:RegisterEffect(x) end';
   if(name==='c'+boss+'.lua'){let lua=fs.readFileSync(path.join(OUT,'attack-response-speed-before-repair',name),'utf8');if(candidate)lua=require('./fresh_attack_response_speed_repair.cjs').corrected(lua,boss);if(mode==='no-attack-negate'&&boss===259235389)lua=lua.replace('Duel.NegateAttack()','do end');if(mode==='no-double'&&boss===259844716)lua=lua.replace('s.double(e,tc,fid) te:Reset()','te:Reset()');return lua;}
   if([ally,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+enemy+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F) x:SetCode(EVENT_ATTACK_ANNOUNCE) x:SetRange(LOCATION_MZONE) x:SetCategory(CATEGORY_RECOVER) x:SetOperation(function(e,tp) Duel.Recover(tp,1,REASON_EFFECT) end) c:RegisterEffect(x) local y=Effect.CreateEffect(c) y:SetType(EFFECT_TYPE_QUICK_O) y:SetCode(EVENT_CHAINING) y:SetRange(LOCATION_MZONE) y:SetCondition(function(e,tp,eg,ep,ev,re) return ev==1 and re:GetHandler():IsCode(id) end) y:SetOperation(function(e,tp) Duel.Recover(tp,1,REASON_EFFECT) end) c:RegisterEffect(y) end`;
   const p=path.join(ROOT,'tmp/omega_scripts',name);assert(fs.existsSync(p),name);return fs.readFileSync(p,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE|(tcg?mod.OcgDuelMode.TCG_SEGOC_NONPUBLIC:0n),seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,attacked=false,done=false,accepted=false,turn=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,boss===259844716?L.HAND:L.MZONE,0,1);add(ally,L.MZONE);if(test.handFirst)add(900009784,L.HAND);add(enemy,L.MZONE,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<220&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);turn+=messages.filter(m=>m.type===M.NEW_TURN).length;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:!attacked&&p.player===1&&turn>1&&p.to_bp?A.TO_BP:A.TO_EP});
    else if(p.type===M.SELECT_BATTLECMD){if(!attacked){const index=p.attacks.findIndex(c=>c.code===enemy);assert(index>=0);attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}else{
     assert(accepted,'Original attack response available at requested chain link');const activation=trace.find(m=>m.type===M.CHAINING&&m.code===boss);assert(activation);assert.equal(activation.chain_size,test.late||test.handFirst?3:2,'Requested Quick response chain order');
     if(boss===259844716){assert(query(L.MZONE).some(c=>c.code===boss),'Original deferred Normal Summon');assert.equal(query(L.MZONE).find(c=>c.code===ally)?.attack,2000,'Original Spirit ATK double');}
     else {assert(query(L.GRAVE).some(c=>c.code===boss&&(c.reason&64)),'Original Tricera effect destruction');assert(trace.some(m=>m.type===M.ATTACK_DISABLED),'Original attack actually negated');}done=true;
    }}else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===ally);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){assert([boss,900009784].includes(p.code));const use=p.code===900009784?!!test.handFirst:!test.late&&!test.handFirst;if(p.code===boss)accepted||=use;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:use});}
    else if(p.type===M.SELECT_CHAIN){const probeChained=trace.some(m=>m.type===M.CHAINING&&m.code===(test.handFirst?900009784:enemy)&&m.chain_size===2);const wanted=p.player===0?(test.handFirst&&!probeChained?900009784:boss):enemy,index=p.selects.findIndex(c=>c.code===wanted),use=index>=0&&(p.player!==0||(!test.late&&!test.handFirst)||probeChained||wanted===900009784);if(use&&p.player===0&&wanted===boss)accepted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:use?index:p.forced?0:null});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({tcg,boss,test,failure,logs,trace});console.log((failure?'FAIL ':'PASS ')+(tcg?'TCG ':'default ')+boss+' '+JSON.stringify(test)+(failure?' '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-attack-response-speed'+'-'+mode+'.json'),JSON.stringify({scope:'Complete original source effects/native attack/installed metadata. Neutral mandatory attack trigger CL1 and Quick probe CL2 distinguish later same-chain response. Candidate changes only attack-branch type. No Lua API mapping. Not full-card/live Omega certification.',candidate,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
