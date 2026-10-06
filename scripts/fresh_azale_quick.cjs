'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276580,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{stopMonster:true},{stopTrap:true},{firstStop:true},{allPlants:true},{ownTurn:true},{zeroDestroy:true}]){
  const excavated=test.allPlants?11:test.firstStop?1:3,destroyed=test.zeroDestroy?0:Math.min(excavated,4);
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(ally,{...base,code:ally,type:0x800021,level:test.wrongRank?11:12});cards.set(refill,{...base,code:refill});
  cards.set(900001131,{...base,code:900001131,race:1024n});cards.set(900001132,{...base,code:900001132,type:test.stopMonster||test.allPlants?33:test.stopTrap?4:2,race:test.stopMonster?1n:1024n,level:0});cards.set(filler,{...base,code:filler,type:test.allPlants?33:2,level:0});cards.set(top,{...base,code:top});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local stop=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,900001132):GetFirst() Duel.MoveSequence(stop,SEQ_DECKTOP) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,900001131) '+(test.firstStop?'':'for tc in aux.Next(g) do Duel.MoveSequence(tc,SEQ_DECKTOP) end')+' end) c:RegisterEffect(e) end';
   if([ally,top,filler,900001131,900001132].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--own-turn-allowed'))source=source.replace('e3:SetCondition(function(e,tp) return Duel.GetTurnPlayer()~=tp end)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--force-destroy'))source=source.replace('LOCATION_ONFIELD,0,#g,nil','LOCATION_ONFIELD,1,#g,nil');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-bottom'))source=source.replace('s.orderbottom(g,tp)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--plants-only-count'))source=source.replace('LOCATION_ONFIELD,0,#g,nil','LOCATION_ONFIELD,0,g:FilterCount(s.plant,nil),nil');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:refill,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});
   for(let seq=0;seq<4;seq++)core.duelNewCard(duel,{team:1,duelist:0,code:top,controller:1,location:L.MZONE,sequence:seq,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);add(900001131,L.DECK);add(900001131,L.DECK);add(900001132,L.DECK);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared&&p.player===0){const index=p.activates.findIndex(x=>x.code===refill);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.ownTurn){assert.equal(p.activates.findIndex(x=>x.code===boss),-1,'Own-turn Quick Effect offered');done=true;continue;}
     if(activated){assert.equal(core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.GRAVE}).filter(Boolean).filter(x=>x.code===top).length,destroyed,'Destruction count mismatch');assert.equal(query(L.DECK).length,11,'Excavated cards left Deck');if(!test.allPlants){const bottom=query(L.DECK).slice(0,excavated).map(x=>x.code);assert.equal(bottom.filter(x=>x===900001132).length,1,'Stopping card not on bottom');assert.equal(bottom.filter(x=>x===900001131).length,test.firstStop?0:2,'Excavated Plants not on bottom');}done=true;continue;}
     core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);if(turn===2&&!activated&&index>=0){activated=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){assert.equal(p.max,Math.min(excavated,4),'Excavation stopping count mismatch');if(test.zeroDestroy)assert.equal(p.min,0,'Zero destruction not allowed');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:Array.from({length:destroyed},(_,i)=>i)});}
    else if(p.type===M.SORT_CARD){assert.equal(p.cards.length,excavated,'Excavation stop mismatch');const order=p.cards.map((_,i)=>i);core.duelSetResponse(duel,{type:R.SORT_CARD,order:{length:order[0],*[Symbol.iterator](){yield*order.slice(1);}}});}
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
 const control=process.argv.includes('--own-turn-allowed')?'own-turn-allowed':process.argv.includes('--force-destroy')?'force-destroy':process.argv.includes('--no-bottom')?'no-bottom':process.argv.includes('--plants-only-count')?'plants-only-count':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/azale-quick'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Azale/candidate; neutral fixed top2 Plants then Spell; actual opponent turn excavation/destruction',adapter:'Public SORT_CARD permutation byte encoding',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



