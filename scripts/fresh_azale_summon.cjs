'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276580,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{bottom:true},{zeroDetach:true},{onePlant:true},{wrongSet:true},{onePlant:true,mixed:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(ally,{...base,code:ally,type:0x800021,level:test.wrongRank?11:12});cards.set(refill,{...base,code:refill});
  cards.set(top,{...base,code:top});cards.set(900001121,{...base,code:900001121,type:0x20002,level:0});cards.set(900001122,{...base,code:900001122,type:0x20004,level:0});
  cards.set(900001131,{...base,code:900001131,race:1024n});cards.set(900001141,{...base,code:900001141,type:2,level:0});cards.set(900001142,{...base,code:900001142,setcodes:test.wrongSet?[]:[0x90]});cards.set(filler,{...base,code:filler,type:2,level:0});
  cards.set(900001143,{...base,code:900001143,type:2,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) '+(test.onePlant?'Duel.MoveSequence(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,900001143):GetFirst(),SEQ_DECKTOP)':'')+' local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,900001131) for tc in aux.Next(g) do Duel.MoveSequence(tc,SEQ_DECKTOP) end local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+boss+'):GetFirst() Duel.SpecialSummon(tc,SUMMON_TYPE_XYZ,tp,tp,true,true,POS_FACEUP) tc:CompleteProcedure() Duel.Overlay(tc,Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,900001141)) end) c:RegisterEffect(e) end';
   if([ally,top,filler,900001131,900001141,900001142,900001143].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'&&process.argv.includes('--no-revival'))source=source.replace('Duel.SpecialSummon(sg,0,tp,tp,false,false,POS_FACEUP)','do end');if(name==='c'+boss+'.lua'&&process.argv.includes('--force-detach'))source=source.replace('RemoveOverlayCard(tp,0,ct,REASON_COST)','RemoveOverlayCard(tp,1,ct,REASON_COST)');if(name==='c'+boss+'.lua'&&process.argv.includes('--all-excavated-count'))source=source.replace('g:FilterCount(s.plant,nil)',' #g');if(name==='c'+boss+'.lua'&&process.argv.includes('--any-set'))source=source.replace('and c:IsSetCard(0x90)','');if(name==='c'+boss+'.lua'&&process.argv.includes('--no-split'))source=source.replace('bottom:Sub(top)','do end');return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);add(refill,L.MZONE);add(900001141,L.GRAVE);add(900001141,L.GRAVE);add(900001142,L.GRAVE);add(900001142,L.GRAVE);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);add(900001131,L.DECK);add(test.onePlant?900001143:900001131,L.DECK);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===refill);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(query(L.MZONE).filter(x=>x.code===900001142).length,test.zeroDetach||test.wrongSet?0:test.onePlant?1:2,'Sylvan revival count mismatch');
     assert.equal(query(L.MZONE).find(x=>x.code===boss).overlayCards.length,test.zeroDetach?2:0,'Detach count mismatch');
     if(test.mixed){const deck=query(L.DECK);assert.equal(deck.at(-1).code,900001131,'Chosen top card not on top');assert.equal(deck[0].code,900001143,'Chosen bottom card not on bottom');}
     if(!test.zeroDetach){assert.equal(query(L.GRAVE).filter(x=>x.code===900001141&&(x.reason&0x80)).length,2,'Detach costs missing');const deck=query(L.DECK);assert.equal((test.bottom?deck.slice(0,2):deck.slice(-2)).filter(x=>x.code===900001131).length,test.onePlant?1:2,'Excavated placement mismatch');}done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const code=p.selects[0].code;if(code===900001141&&test.zeroDetach)assert.equal(p.min,0,'Zero detach disallowed');const indices=code===900001141&&test.zeroDetach||code===900001131&&test.bottom?[]:test.mixed&&(code===900001131||code===900001143)?[p.selects.findIndex(x=>x.code===900001131)]:p.selects.slice(0,p.max).map((_,i)=>i);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SORT_CARD){const order=p.cards.map((_,i)=>i);core.duelSetResponse(duel,{type:R.SORT_CARD,order:{length:order[0],*[Symbol.iterator](){yield*order.slice(1);}}});}
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
 const control=process.argv.includes('--no-split')?'no-split':process.argv.includes('--all-excavated-count')?'all-excavated-count':process.argv.includes('--any-set')?'any-set':process.argv.includes('--no-revival')?'no-revival':process.argv.includes('--force-detach')?'force-detach':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/azale-summon'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Azale/candidate; fixture XYZ-stamped GY Special Summon and actual overlay2, detach/excavate/Sylvan revival',adapter:'SORT_CARD byte encoding',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



