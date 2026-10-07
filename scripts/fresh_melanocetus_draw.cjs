'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239937489,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{handCost:true},{graveCost:true},{decline:true},{spellVictim:true},{selfCost:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(top,{...base,code:top,type:test.spellVictim?0x20002:33});cards.set(ally,{...base,code:ally,race:131072n});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+'):GetFirst():CompleteProcedure() end) c:RegisterEffect(e) end';
   if([ally,top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-cost'))source=source.replace('Duel.Remove(tc,POS_FACEUP,REASON_COST)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--split-count'))source=source.replace('e3:SetCountLimit(1,id)','e3:SetCountLimit(1,id+100)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-origin'))source=source.replace('and e:GetLabel()==1','');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:test.handCost?L.HAND:test.graveCost?L.GRAVE:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});add(top,test.selfCost?L.GRAVE:test.spellVictim?L.SZONE:L.MZONE,1);
   if(test.selfCost)core.duelNewCard(duel,{team:0,duelist:0,code:refill,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const index=p.activates.findIndex(x=>x.code===boss);
     if(test.selfCost&&!prepared){const pi=p.activates.findIndex(x=>x.code===refill);assert(pi>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}
     if(!activated){assert(index>=0,'Melanocetus unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.selfCost){assert(query(L.REMOVED).some(x=>x.code===boss&&(x.reason&0x80)),'Self-banish cost missing');assert.equal(query(L.HAND).filter(x=>x.code===filler).length,1,'Self cost did not draw');assert(query(L.MZONE).some(x=>x.code===ally),'Revival tribute resource lost');assert(core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.GRAVE}).filter(Boolean).some(x=>x.code===top),'Revival GY victim lost');if(turn===1){assert.equal(index,-1,'Revival offered after draw effect same turn');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(turn>=3);assert(index>=0,'Revival did not renew next own turn');done=true;continue;}
     assert(query(L.REMOVED).some(x=>x.code===ally&&(x.reason&0x80)),'Fish banishment cost missing');
     assert(trace.some(x=>x.type===M.MOVE&&x.card===ally&&x.from.location===(test.handCost?L.HAND:test.graveCost?L.GRAVE:L.MZONE)&&x.to.location===L.REMOVED),'Cost origin incorrect');
     assert.equal(query(L.HAND).filter(x=>x.code===filler).length,1,'Did not draw exactly one');
     const enemyRemoved=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.REMOVED}).filter(Boolean);assert.equal(enemyRemoved.some(x=>x.code===top),!test.decline&&!test.handCost&&!test.graveCost,'Conditional opponent banishment mismatch');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===(test.selfCost&&p.selects.some(x=>x.code===boss)?boss:p.selects.some(x=>x.code===ally)?ally:top));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO){assert(!(test.handCost||test.graveCost),'Non-field cost incorrectly offers banishment');core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--split-count')?'split-count':process.argv.includes('--no-cost')?'no-cost':process.argv.includes('--any-origin')?'any-origin':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/melanocetus-draw'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Melanocetus/candidate metadata; actual Fish banishment/draw/conditional removal with neutral cards; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



