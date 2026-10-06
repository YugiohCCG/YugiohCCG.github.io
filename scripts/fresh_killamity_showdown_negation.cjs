'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244163205,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{secondCopy:true},{spellTarget:true},{trapTarget:true},{wrongRank:true},{wrongset:true},{hiddenTarget:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(ally,{...base,code:ally,type:0x800021,level:test.wrongRank?11:12,setcodes:test.wrongset?[]:[0xa120]});cards.set(top,{...base,code:top,type:test.spellTarget?0x20002:test.trapTarget?0x20004:33});
  const reader=name=>{
   if(name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetCountLimit(1) e:SetRange(LOCATION_MZONE+LOCATION_SZONE) e:SetOperation(function(e,tp) Duel.Recover(tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(name==='c'+ally+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_ONFIELD,nil,'+top+'):GetFirst() Duel.Hint(HINT_NUMBER,tp,tc:IsDisabled() and 701 or 700) end) c:RegisterEffect(e) end';
   if([filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-count'))source=source.replace('e2:SetCountLimit(1,id+100)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-negation'))source=source.replace('tc:RegisterEffect(disable)','do end').replace('tc:RegisterEffect(effects)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-reset'))source=source.replace('RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END','RESET_EVENT+RESETS_STANDARD');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,attempted=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   if(test.secondCopy){add(boss,L.GRAVE);core.duelNewCard(duel,{team:1,duelist:0,code:filler,controller:1,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});}
   add(boss,L.GRAVE);add(ally,L.MZONE);core.duelNewCard(duel,{team:1,duelist:0,code:top,controller:1,location:test.spellTarget||test.trapTarget?L.SZONE:L.MZONE,sequence:0,position:test.hiddenTarget?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(test.wrongRank||test.wrongset||test.hiddenTarget){assert.equal(p.activates.findIndex(x=>x.code===boss),-1,'Invalid negation offered');done=true;continue;}
     if(p.player===0){if(!activated){const index=p.activates.findIndex(x=>x.code===boss);assert(index>=0,'Negation unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.REMOVED).some(x=>x.code===boss&&(x.reason&0x80)),'Source not banished as cost');if(!refilled){const pi=p.activates.findIndex(x=>x.code===ally);assert(pi>=0);refilled=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}if(test.secondCopy){assert(query(L.GRAVE).some(x=>x.code===boss),'Spare source missing');assert.equal(p.activates.findIndex(x=>x.code===boss),-1,'Second-copy negation offered');}
assert(trace.some(x=>x.type===M.CHAINING&&x.code===top),'Opponent effect did not actually activate while negated');assert.equal(trace.filter(x=>x.type===M.RECOVER).length,0,'Disabled same-turn effect resolved');assert(trace.some(x=>x.type===M.HINT&&Number(x.hint)===701),'Target not natively disabled during activation turn');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(attempted!==turn){const index=p.activates.findIndex(x=>x.code===top);assert(index>=0,'Opponent ignition missing');attempted=turn;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const recoveries=trace.filter(x=>x.type===M.RECOVER);assert.equal(turn,2);assert.equal(recoveries.length,1,'Negation did not expire');assert.equal(recoveries[0].amount,1000);done=true;
    }else if(p.type===M.SELECT_CHAIN){let index=null;if(turn===1&&refilled&&attempted!==1){const pi=p.selects.findIndex(x=>x.code===top);if(pi>=0){index=pi;attempted=1;}}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index!==null?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===top);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-count')?'no-count':process.argv.includes('--no-negation')?'no-negation':process.argv.includes('--no-reset')?'no-reset':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/killamity-showdown-negation'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Showdown/candidate metadata; neutral seeded Rank12 and opponent ignition, actual resolution/reset; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



