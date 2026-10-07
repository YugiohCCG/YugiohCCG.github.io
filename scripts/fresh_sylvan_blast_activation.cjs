'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{sylvanCard}=require('./fresh_sylvan_metadata.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276577,a=900000991,b=900000992,c=900000993,p1=900000994,p2=900000995,filler=900000996,setup=900000997,msg=132276577,results=[];
 for(const test of [{count:0},{count:1},{count:2},{count:2,same:true},{count:2,decline:true},{count:2,nonplant:true},{excavate:'level'},{excavate:'rank'},{excavate:'link'},{excavate:'level',forced:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([a,b,c,p1,p2,filler].map(code=>[code,{...base,code}]));
  for(const code of [a,b,c])cards.set(code,{...cards.get(code),setcodes:[0x90]});
  cards.set(p2,{...cards.get(p2),attribute:test.same?4:8,race:test.nonplant?1n:1024n});
  cards.set(boss,sylvanCard(boss));
  cards.set(setup,{...base,code:setup,type:2,level:0});
  if(test.excavate){cards.set(p1,{...cards.get(p1),level:3,type:test.excavate==='rank'?0x800001:test.excavate==='link'?0x4000001:33,link_marker:test.excavate==='link'?7:0});cards.set(b,{...cards.get(b),race:1n});cards.set(c,{...cards.get(c),type:2,level:0});}
  const reader=name=>{
   if(name==='c'+setup+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) '+[test.forced?boss:c,b,a].map(code=>'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,'+code+'):GetFirst() Duel.MoveSequence(tc,SEQ_DECKTOP)').join(' ')+' end) c:RegisterEffect(e) end';
   if([a,b,c,p1,p2,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);
   let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--count-monsters'))source=source.replace('plants:GetClassCount(Card.GetAttribute)','#plants');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-order'))source=source.replace('Duel.SortDecktop(tp,tp,#returned)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-deck-move'))source=source.replace('Duel.MoveSequence(tc,SEQ_DECKTOP)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--level-only'))source=source.replace('if c:IsType(TYPE_LINK) then return c:GetLink() end','').replace('if c:IsType(TYPE_XYZ) then return c:GetRank() end','');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-soft-count'))source=source.replace('e2:SetCountLimit(1)','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,done=false,sorted=[],chosen=[];
  const expected=test.decline?0:test.same||test.nonplant?1:test.count;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(test.excavate){add(boss,L.SZONE);add(p1,L.MZONE);add(p2,L.MZONE,0,1);add(setup,L.HAND);add(a,L.DECK);add(b,L.DECK);add(test.forced?boss:c,L.DECK);}
   else{add(boss,L.SZONE,0,0,P.FACEDOWN_DEFENSE);add(boss,L.SZONE,0,1,P.FACEDOWN_DEFENSE);if(test.count>0)add(p1,L.MZONE);if(test.count>1)add(p2,L.MZONE,0,1);add(a,L.DECK);add(b,L.GRAVE);add(c,L.DECK);}
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(test.excavate){
      if(!prepared){const index=p.activates.findIndex(x=>x.code===setup);assert(index>=0,'Reorder setup unavailable');prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
      const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(msg*16+1));
      if(!activated){assert(index>=0,'Excavation effect unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
      assert(query(L.GRAVE).some(x=>x.code===p1&&(x.reason&0x80)&&(x.reason&0x2)),'Tribute COST/RELEASE reasons missing');
      assert(!query(L.MZONE).some(x=>x.code===p1),'Tributed monster still on field');
      assert(trace.some(x=>x.type===M.CONFIRM_DECKTOP&&x.cards.length===3&&x.cards[0].code===a),'Rating excavation count mismatch');
      assert(query(L.GRAVE).some(x=>x.code===a&&(x.reason&0x8000000)&&(x.reason&0x40)),'Excavated Plant send missing');
      if(test.forced)assert(query(L.GRAVE).some(x=>x.code===boss&&(x.reason&0x8000000)),'Excavated Blast mandatory send missing');
      const bottom=test.forced?[b]:sorted;assert.deepEqual(query(L.DECK).slice(0,bottom.length).map(x=>x.code),bottom,'Remaining card bottom order mismatch');
      assert.equal(index,-1,'Same-copy soft count failed');done=true;continue;
     }
     const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(msg*16));
     if(!activated){assert(index>=0,'Blast activation unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(chosen.length,expected,'Stack count mismatch');
     assert.equal(index,-1,'Second copy bypassed activation oath');
     assert.equal(query(L.SZONE).filter(x=>x.code===boss&&(x.position&5)).length,1,'Activated Trap not face-up');
     if(expected>0){assert.deepEqual(query(L.DECK).slice(-expected).map(x=>x.code),expected===1?chosen:sorted,'Exact Deck top order mismatch');assert.deepEqual(query(L.DECK).slice(-expected).map(x=>x.code).sort(),chosen.slice().sort(),'Selected cards not at Deck top');}
     assert.equal(query(L.GRAVE).some(x=>x.code===b),!chosen.includes(b),'GY stack source mismatch');
     assert.equal(trace.filter(x=>x.type===M.SELECT_YESNO).length,test.count===0?0:1,'Optional prompt mismatch');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_CARD){if(test.excavate){const index=p.selects.findIndex(x=>x.code===p1);assert(index>=0,'Rating Tribute unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});continue;}assert.equal(p.max,test.same||test.nonplant?1:test.count,'Attribute selection maximum mismatch');const wanted=expected===1?[b]:[a,b];const indices=p.selects.map((x,i)=>wanted.includes(x.code)?i:-1).filter(i=>i>=0);chosen=indices.map(i=>p.selects[i].code);assert.equal(indices.length,expected);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SORT_CARD){assert.deepEqual(p.cards.map(x=>x.code).sort(),test.excavate?[b,c].sort():chosen.slice().sort(),'Ordering prompt contains wrong cards');const order=p.cards.map((_,i)=>i);sorted=p.cards.map(x=>x.code).reverse();core.duelSetResponse(duel,{type:R.SORT_CARD,order:{length:order[0],*[Symbol.iterator](){yield*order.slice(1);}}});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=['--count-monsters','--no-order','--no-deck-move','--level-only','--no-soft-count'].find(x=>process.argv.includes(x));
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/sylvan-blast-activation'+(control?control.slice(1):'')+'.json'),JSON.stringify({engine:'Public OCGCore, complete production Blast and candidate DB metadata; neutral Plants and stack candidates; native Omega untested',adapter:'SORT_CARD permutation byte encoding',control:control||null,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});

