'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),colony=213990492,aqua=900000321,attacker=900000322,filler=900000323;
 const base={alias:0,setcodes:[],type:17,level:4,attribute:2,race:64n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const results=[];
 const control=['always-lock','no-lock','no-movement'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{return:true}]){
  const trace=[],logs=[];let turn=0;

 const cards=new Map([[colony,candidateCard(colony)],[aqua,{...base,code:aqua}],[attacker,{...base,code:attacker,attack:1000,defense:test.highDefense?4000:1000}],[filler,{...base,code:filler}]]);
  const eldora=214552846;cards.set(eldora,candidateCard(eldora));cards.set(aqua,{...base,code:aqua,type:2});
  const reader=name=>{if(name==='c'+aqua+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${control==='no-movement'?'do end':`local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,${eldora}) Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) ${test.return?'Duel.SendtoGrave(tc,REASON_EFFECT)':''}`} end) c:RegisterEffect(e) end`; if(name==='c'+eldora+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c'+aqua+'.lua'&&test.disabled)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_DISABLE) e:SetRange(LOCATION_MZONE) e:SetTargetRange(LOCATION_MZONE,0) e:SetTarget(function(e,c) return c:IsCode(${colony}) end) c:RegisterEffect(e) end`;if([`c${aqua}.lua`,`c${attacker}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+colony+'.lua'){if(control==='always-lock')lua=lua.replace('e2:SetCondition(s.atkcon)','e2:SetCondition(function() return true end)');if(control==='no-lock')lua=lua.replace('c:RegisterEffect(e2)','do end');if(control==='any-controller')lua=lua.replace('Card.IsCode,e:GetHandlerPlayer(),LOCATION_GRAVE,0,1','Card.IsCode,e:GetHandlerPlayer(),LOCATION_GRAVE,LOCATION_GRAVE,1');if(control==='field-too')lua=lua.replace('Card.IsCode,e:GetHandlerPlayer(),LOCATION_GRAVE,0,1','Card.IsCode,e:GetHandlerPlayer(),LOCATION_GRAVE+LOCATION_ONFIELD,0,1');}return lua};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,attacked=false,done=false,moved=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:code===colony&&test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   add(aqua,L.HAND,1);add(colony,L.MZONE);if(test.disabled)add(aqua,L.MZONE,0,1);add(attacker,L.MZONE,1);if(!test.absent)add(test.wrongCode?filler:eldora,test.field?L.SZONE:L.GRAVE,test.opponent?1:0,test.field?5:0);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<130&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(turn===2&&!moved){const index=p.activates.findIndex(c=>c.code===aqua);assert(index>=0);moved=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(p.player===(test.ownAttack?0:1)&&turn>1&&p.to_bp)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP});else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}
    else if(p.type===M.SELECT_BATTLECMD){
     const blocked=!!test.return;assert(moved&&trace.some(m=>m.type===M.CHAINING&&m.code===aqua),"Actual Eldora movement fixture resolved");
     assert.equal(p.attacks.some(c=>c.code===(test.ownAttack?colony:attacker)),!blocked,'Eldora own GY locks opponent attack only while source active');assert.equal(turn,test.ownAttack?3:2,'Native battle turn');done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===attacker);if(index<0)throw Error('Bubble Colony not a battle target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,attacked,trace,logs});console.log(`${failure?'FAIL':'PASS'} test=${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/eridani-lock-movement'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full canonical Eridani native opponentturn2 Spell moves own Eldora GY tobanishment or backGY before battle; lock absence/restoration actual command. Eldora canonical metadata neutral effects. No API adapters. Native Omega/declaration/count open',script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(CUSTOM,'c'+colony+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
