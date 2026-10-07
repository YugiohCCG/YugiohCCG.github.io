'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276250,target=900000921,filler=900000922,setup=900000923,interference=900000924,msg=132276250,results=[];
 for(const test of [{},{sendOnly:true},{decline:true},{insufficient:true},{self:true},{ownStandby:true},{lostTarget:true},{lostTarget:true,returnedTarget:true}]){
  const legal=!test.sendOnly&&!test.decline&&!test.insufficient,logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,{...base,code:boss,setcodes:[0x11f],level:8}],[target,{...base,code:target,setcodes:[0x11f]}],[filler,{...base,code:filler}],[setup,{...base,code:setup,type:2,level:0}],[interference,{...base,code:interference,type:0x10002,level:0}]]);
  const reader=name=>{
   if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) ${test.ownStandby?'e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetCode(EVENT_PHASE+PHASE_STANDBY) e:SetRange(LOCATION_SZONE) e:SetCondition(function() return Duel.GetTurnCount()==1 end) e:SetCountLimit(1)':'e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)'} e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() Duel.${test.sendOnly?'SendtoGrave':'Destroy'}(c,REASON_EFFECT) end) c:RegisterEffect(e) end`;
   if(name===`c${interference}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetCondition(function() return Duel.GetCurrentChain()>0 and Duel.GetCurrentPhase()==PHASE_STANDBY end) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${target}):GetFirst() Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) ${test.returnedTarget?'Duel.SendtoGrave(tc,REASON_EFFECT)':''} end) c:RegisterEffect(e) end`;
   if([target,filler].some(id=>name===`c${id}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name==='constant.lua'&&!process.argv.includes('--legacy-chain-flag'))source=source.replace(/(CHAININFO_TARGET_CARDS\s*=)0x40/,'$1 8');if(name===`c${boss}.lua`){if(process.argv.includes('--no-relation'))source=source.replace(':Filter(Card.IsRelateToEffect,nil,e)','');if(process.argv.includes('--short-own-standby'))source=source.replace('ownStandby and 2 or 1','1');}return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=!!test.ownStandby,offered=false,interfered=false,done=false,turn=0,phase=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);add(setup,test.ownStandby?L.SZONE:L.HAND);if(test.lostTarget)add(interference,L.HAND);if(!test.insufficient)add(target,L.GRAVE);if(!test.insufficient&&!test.self)add(target,L.GRAVE);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const checkOffer=player=>{if(test.sendOnly||test.insufficient||turn!==3||phase!==mod.OcgPhase.STANDBY||player!==0)throw Error('Shuffle offered at wrong turn/phase or without two candidates');offered=true;};
   for(let step=0;step<150&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages){if(m.type===M.NEW_TURN)turn++;if(m.type===M.NEW_PHASE)phase=m.phase;}if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Destruction setup missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(turn>=5){const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location}),deck=query(L.DECK),gy=query(L.GRAVE);const shuffled=deck.filter(c=>c?.code===target).length+(test.self?deck.filter(c=>c?.code===boss).length:0);if(shuffled!==(legal?(test.lostTarget?1:2):0))throw Error('Actual shuffle-two outcome mismatch');if(test.lostTarget&&(!interfered||(test.returnedTarget?gy:query(L.REMOVED)).filter(c=>c?.code===target).length!==1))throw Error('Target-loss fixture outcome mismatch');if(!test.self&& !gy.some(c=>c?.code===boss))throw Error('Incarnation unexpectedly left GY');if(offered!==(!test.sendOnly&&!test.insufficient))throw Error('Delayed trigger registration mismatch');done=true;}
     else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});
    }else if(p.type===M.SELECT_EFFECTYN){checkOffer(p.player);core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_CHAIN){const loss=p.selects.findIndex(c=>c.code===interference);if(loss>=0&&!interfered){interfered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:loss});continue;}const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+2));if(index>=0)checkOffer(p.player);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?(p.forced?0:null):test.decline?null:index});}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((c,i)=>(c.code===target||(test.self&&c.code===boss))?i:-1).filter(i=>i>=0).slice(0,2);if(indices.length!==2)throw Error('Two target candidates missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,offered,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 const control=['--legacy-chain-flag','--no-relation','--short-own-standby'].find(flag=>process.argv.includes(flag));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/nephthys-incarnation-standby${control?control.slice(1):''}.json`),JSON.stringify({engine:'Public OCGCore with complete production Incarnation; neutral GY monsters and actual destruction/send Spell fixtures; actual turns through two own Standby Phases; not native Omega',control:control||null,adapter:process.argv.includes('--legacy-chain-flag')?null:'In-memory constant.lua maps only CHAININFO_TARGET_CARDS from Omega 0x40 to public core enum 8 (https://raw.githubusercontent.com/ProjectIgnis/CardScripts/master/constant.lua); production scripts/helpers unchanged by adapter',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1});
