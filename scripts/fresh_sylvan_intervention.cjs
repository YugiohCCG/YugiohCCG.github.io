'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{sylvanCard}=require('./fresh_sylvan_metadata.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276576,a=900000981,b=900000982,c=900000983,filler=900000984,destroy=900000985,results=[];
 for(const test of [{},{short:true},{full:true},{block:true},{lost:1},{lost:2},{protect:true},{protect:true,decline:true},{protect:true,nonplant:true},{protect:true,mixed:true},{protect:true,opponent:true},{protect:true,send:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[0x90],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([a,b,c,filler].map(code=>[code,{...base,code}]));
  cards.set(boss,sylvanCard(boss));
  cards.set(destroy,{...base,code:destroy,type:test.block||test.lost?0x10002:2,level:0,setcodes:[]});
  if(test.nonplant||test.mixed)cards.set(b,{...cards.get(b),race:1n});
  const reader=name=>{
   if(test.lost&&name==='c'+destroy+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetCondition(function() return Duel.GetCurrentChain()>0 end) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+c+(test.lost===2?','+b:'')+') Duel.Remove(g,POS_FACEUP,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(test.block&&name==='c'+destroy+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetCondition(function() return Duel.GetCurrentChain()>0 end) e:SetOperation(function(e,tp) local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(1,1) lock:SetReset(RESET_PHASE+PHASE_END) Duel.RegisterEffect(lock,tp) end) c:RegisterEffect(e) end';
   if(name==='c'+destroy+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(aux.TRUE,tp,LOCATION_MZONE,LOCATION_MZONE,nil) '+(test.send?'Duel.SendtoGrave':'Duel.Destroy')+'(g,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([a,b,c,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);
   let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua')source=source.replace('CHAININFO_TARGET_CARDS','8'); // Public core flag; pinned Omega uses 0x40.
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-summon'))source=source.replace('Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)','-- omitted summon');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-protection'))source=source.replace('e2:SetRange(LOCATION_GRAVE)','e2:SetRange(LOCATION_HAND)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--old-summon-gate'))source=source.replace('g:Filter(function(c) return g:FilterCount(Card.IsAbleToDeck,c)>=2 end,nil)','g:Filter(aux.NecroValleyFilter(s.choice),nil,g,e,tp)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--all-three-gate'))source=source.replace('if #g<2 then return end','if #g~=3 then return end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,sorted=[];
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   if(test.protect){add(boss,L.GRAVE);add(destroy,L.HAND);if(!test.nonplant)add(a,L.MZONE,test.opponent?1:0);add(b,L.MZONE,test.opponent?1:0,test.nonplant?0:1);}
   else{add(boss,L.HAND);add(boss,L.HAND);for(const code of test.short?[a,b]:[a,b,c])add(code,L.GRAVE);}
   if(test.block||test.lost)add(destroy,L.HAND);
   if(test.full)for(let i=0;i<5;i++)add(filler,L.MZONE,0,i);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(test.protect){
      if(!activated){const index=p.activates.findIndex(x=>x.code===destroy);assert(index>=0,'Destruction fixture unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
      const protects=!test.decline&&!test.nonplant&&!test.opponent&&!test.send,field=query(L.MZONE,test.opponent?1:0),gy=query(L.GRAVE),removed=query(L.REMOVED);
      assert.equal(removed.filter(x=>x.code===boss).length,protects?1:0,'Replacement banish mismatch');
      assert.equal(gy.filter(x=>x.code===boss).length,protects?0:1,'Replacement GY mismatch');
      if(!test.nonplant)assert.equal(field.some(x=>x.code===a),protects,'Plant survival mismatch');
      assert.equal(field.some(x=>x.code===b),protects&&!test.mixed,'Second monster survival mismatch');
      const prompts=trace.filter(x=>x.type===M.SELECT_EFFECTYN&&x.code===boss);
      assert.equal(prompts.length,test.nonplant||test.opponent||test.send?0:1,'Replacement prompt mismatch');
      const targetGY=query(L.GRAVE,test.opponent?1:0);
      for(const code of test.nonplant?[b]:[a,b])if(!field.some(x=>x.code===code))assert(targetGY.some(x=>x.code===code&&(x.reason&0x40)),'Unprotected monster not sent by effect');
      if(protects)assert(removed.some(x=>x.code===boss&&(x.reason&0x1000000)),'Missing replacement banish reason');done=true;continue;
     }
     const index=p.activates.findIndex(x=>x.code===boss);
     if(test.short||test.full){assert.equal(index,-1,'Illegal activation offered');done=true;continue;}
     if(!activated){assert(index>=0,'Intervention unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.GRAVE).some(x=>x.code===boss&&(x.reason&0x80)),'Handler not sent as cost');
     if(test.lost){
      assert.equal(query(L.REMOVED).filter(x=>[a,b,c].includes(x.code)).length,test.lost,'Target banish count mismatch');
      assert.equal(query(L.MZONE).filter(x=>[a,b,c].includes(x.code)).length,0,'Summoned after target loss');
      assert.equal(query(L.GRAVE).filter(x=>[a,b,c].includes(x.code)).length,test.lost===1?0:1,'Surviving target GY count mismatch');
      assert.equal(query(L.DECK).filter(x=>[a,b,c].includes(x.code)).length,test.lost===1?2:0,'Surviving target Deck count mismatch');
      if(test.lost===1)assert.deepEqual(query(L.DECK).slice(-2).map(x=>x.code),sorted,'Surviving target Deck order mismatch');
      assert(trace.some(x=>x.type===M.CHAINING&&x.code===destroy&&x.chain_size===2),'Target removal not chained');
      assert.equal(index,-1,'Target loss bypassed HOPT');done=true;continue;
     }
     assert.equal(query(L.MZONE).some(x=>x.code===c),!test.block,'Third target Summon result mismatch');
     assert.equal(query(L.GRAVE).filter(x=>[a,b,c].includes(x.code)).length,test.block?1:0,'Target GY count mismatch');
     if(test.block)assert(trace.some(x=>x.type===M.CHAINING&&x.code===destroy&&x.chain_size===2),'Summon restriction not chained');
     assert.deepEqual(query(L.DECK).slice(-2).map(x=>x.code),sorted,'Actual Deck top order differs');
     assert.equal(index,-1,'Second copy bypassed HOPT');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=(test.block||test.lost)&&activated?p.selects.findIndex(x=>x.code===destroy):-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===c);assert(index>=0,'Summon choice absent');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SORT_CARD){const order=p.cards.map((_,i)=>i);sorted=p.cards.map(x=>x.code).reverse();core.duelSetResponse(duel,{type:R.SORT_CARD,order:{length:order[0],*[Symbol.iterator](){yield*order.slice(1);}}});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-summon')?'no-summon':process.argv.includes('--no-protection')?'no-protection':process.argv.includes('--old-summon-gate')?'old-summon-gate':process.argv.includes('--all-three-gate')?'all-three-gate':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/sylvan-intervention'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Intervention, candidate DB metadata, neutral targets; native Omega untested',adapters:['CHAININFO_TARGET_CARDS public flag 8','SORT_CARD permutation byte encoding'],control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});

