'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244163206,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{normalSummon:true},{decline:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(ally,{...base,code:ally,type:0x800021,level:test.wrongRank?11:12});cards.set(refill,{...base,code:refill});
  cards.set(top,{...base,code:top});cards.set(900001121,{...base,code:900001121,type:0x20002,level:0});cards.set(900001122,{...base,code:900001122,type:0x20004,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+boss+'):GetFirst() Duel.SpecialSummon(tc,'+(test.normalSummon?'0':'SUMMON_TYPE_XYZ')+',tp,tp,true,true,POS_FACEUP) tc:CompleteProcedure() end) c:RegisterEffect(e) local p=e:Clone() p:SetDescription(1) p:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsFaceup,tp,0,LOCATION_ONFIELD,nil) local count=g:FilterCount(Card.IsDisabled,nil) Duel.Hint(HINT_NUMBER,tp,700+count) Duel.Hint(HINT_NUMBER,tp,e:GetHandler():IsDisabled() and 711 or 710) end) c:RegisterEffect(p) end';
   if(name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) Duel.Recover(tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([ally,top,filler,900001121,900001122].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-negation'))source=source.replace('e3:SetOperation(s.negop)','e3:SetOperation(function() end)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-summon'))source=source.replace('e3:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_XYZ) end)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--turn-expiry'))source=source.replace(/e1:SetReset\(RESET_EVENT\+RESETS_STANDARD\)/g,'e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);add(refill,L.MZONE);add(top,L.MZONE,1);core.duelNewCard(duel,{team:1,duelist:0,code:900001121,controller:1,location:L.SZONE,sequence:0,position:P.FACEUP_ATTACK});core.duelNewCard(duel,{team:1,duelist:0,code:900001122,controller:1,location:L.SZONE,sequence:1,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!prepared){const index=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='0');assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){assert(query(L.MZONE).some(x=>x.code===boss),'Fixture source not Summoned');const index=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='1');assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(trace.filter(x=>x.type===M.CHAINING&&x.code===top).length,turn>=3?2:1,'Opponent effect did not actually activate in each tested turn');const recoveries=trace.filter(x=>x.type===M.RECOVER);assert.equal(recoveries.length,test.normalSummon||test.decline?1:0,'Opponent operation suppression mismatch');if(recoveries.length)assert.equal(recoveries[0].amount,1000);
     const hints=trace.filter(x=>x.type===M.HINT&&x.hint_type===9).map(x=>Number(x.hint));assert.equal(hints.at(-2),test.normalSummon||test.decline?700:703,'Negated card count mismatch');assert.equal(hints.at(-1),710,'Own fixture disabled');
     if(turn===1&&!test.normalSummon&&!test.decline){activated=false;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}done=true;
    }else if(p.type===M.SELECT_CHAIN){if(activated&&p.player===1){const oi=p.selects.findIndex(x=>x.code===top);if(oi>=0){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:oi});continue;}}const index=p.selects.findIndex(x=>x.code===boss);if(test.normalSummon)assert.equal(index,-1,'Non-Xyz summon trigger');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:!test.decline&&index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===boss);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN){assert(!test.normalSummon,'Non-Xyz trigger prompt');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-negation')?'no-negation':process.argv.includes('--any-summon')?'any-summon':process.argv.includes('--turn-expiry')?'turn-expiry':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/ruby-negation'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Ruby/candidate; neutral fixture Special Summon stamped XYZ versus normal type; native disable count/persistence, not actual Xyz procedure',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



