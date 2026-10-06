'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935102,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{removed:true},{secondCopy:true},{costTarget:true},{trap:true},{monster:true},{wrongset:true},{facedown:true},{noCost:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:test.monster?33:test.trap?4:2,setcodes:test.wrongset?[]:[0xa123],level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:test.spell?2:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  const reader=name=>{
   if([ally,top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--persistent-count'))source=source.replace('e2:SetCost(s.cost)','e2:SetCost(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetFlagEffect(tp,id+500)==0 and s.cost(e,tp,eg,ep,ev,re,r,rp,0) end Duel.RegisterFlagEffect(tp,id+500,0,0,1) s.cost(e,tp,eg,ep,ev,re,r,rp,1) end)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-count'))source=source.replace('e2:SetCountLimit(1,id)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--grave-only'))source=source.replace('local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.addfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED', 'local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.addfilter),tp,LOCATION_GRAVE');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-cost'))source=source.replace('e2:SetCost(s.cost)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-type'))source=source.replace('and c:IsType(TYPE_SPELL)','');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-set'))source=source.replace('c:IsSetCard(0xa123) and','');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   if(test.secondCopy){add(boss,L.GRAVE);add(ally,L.GRAVE);add(top,L.GRAVE);}
   add(boss,L.GRAVE);if(!test.noCost&&!test.costTarget)add(ally,L.GRAVE);
   core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:test.removed||test.facedown||test.noCost?L.REMOVED:L.GRAVE,sequence:0,position:test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(133935102*16+1));
     if(test.trap||test.monster||test.wrongset||test.facedown||test.noCost){assert.equal(index,-1,'Invalid recovery offered');assert(query(L.GRAVE).some(x=>x.code===boss),'Invalid activation paid cost');done=true;continue;}
     if(!activated){assert(index>=0,'Recovery unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.HAND).some(x=>x.code===top),'Target not added');if(test.secondCopy){assert(query(L.GRAVE).some(x=>x.code===boss),'Spare source missing');assert(query(L.GRAVE).some(x=>x.code===ally),'Spare cost missing');assert(query(L.GRAVE).some(x=>x.code===top),'Spare target missing');if(turn===1){assert.equal(index,-1,'Second-copy same-turn recovery offered');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert.equal(turn,3);assert(index>=0,'Recovery count failed to reset on next own turn');}
     const paid=query(L.REMOVED).filter(x=>x.code===boss||x.code===ally);assert.equal(paid.length,test.costTarget?1:2,'Two-card banishment cost missing');assert(paid.every(x=>(x.reason&0x80)!==0),'Banishment not COST');if(test.costTarget){const moves=trace.filter(x=>x.type===M.MOVE&&x.card===top);assert(moves.some(x=>x.from.location===L.GRAVE&&x.to.location===L.REMOVED),'Recovery target not actually banished as cost');assert(moves.some(x=>x.from.location===L.REMOVED&&x.to.location===L.HAND),'Cost target not recovered from banishment');}
     assert(trace.some(x=>x.type===M.CONFIRM_CARDS&&x.cards.some(c=>c.code===top)),'Recovered card not revealed');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){if(test.costTarget&&!query(L.GRAVE).some(x=>x.code===boss)){const paidTarget=query(L.REMOVED).find(x=>x.code===top);assert(paidTarget&&(paidTarget.reason&0x80)!==0,'Recovery target lacks COST reason before recovery');}const index=p.selects.findIndex(x=>x.code===(p.selects.some(x=>x.code===ally)&&!process.argv.includes('--no-cost')&&!test.costTarget?ally:top));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.pay?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--persistent-count')?'persistent-count':process.argv.includes('--no-count')?'no-count':process.argv.includes('--grave-only')?'grave-only':process.argv.includes('--no-cost')?'no-cost':process.argv.includes('--any-type')?'any-type':process.argv.includes('--any-set')?'any-set':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-fog-recovery'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Fog and actual candidate metadata; neutral recovery target/cost; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



