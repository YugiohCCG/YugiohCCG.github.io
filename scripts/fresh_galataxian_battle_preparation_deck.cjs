'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=210696007,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=process.argv.includes('--no-count')?'no-count':process.argv.includes('--no-cost')?'no-cost':process.argv.includes('--any-set')?'any-set':null;
 for(const test of [{},{send:true},{trap:true},{wrongSet:true},{monster:true},{noCost:true},{selfTarget:true},{count:true},{count:true,reverse:true}]){
  const targetCode=test.selfTarget?boss:lab;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.monster?33:test.trap?4:2,level:test.monster?2:0,setcodes:test.wrongSet?[]:[0x9c9]}],[filler,{...base,code:filler}],[spellCost,{...base,code:spellCost,type:2}]]);
  const reader=name=>{
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='no-count')lua=lua.replace('e2:SetCountLimit(1,id)','do end');if(control==='no-cost')lua=lua.replace('Duel.Remove(Group.FromCards(c,tc),POS_FACEUP,REASON_COST)','do end');if(control==='any-set')lua=lua.replace('c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsCode(id) and (c:IsAbleToHand() or c:IsAbleToGrave())','c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsCode(id) and (c:IsAbleToHand() or c:IsAbleToGrave())');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});
   add(boss,L.GRAVE,0,P.FACEUP_ATTACK);if(test.count){add(boss,test.reverse?L.SZONE:L.GRAVE,0,test.reverse?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(test.reverse)add(lab,L.REMOVED,0,P.FACEUP_ATTACK);add(spellCost,L.GRAVE,0,P.FACEUP_ATTACK);add(lab,L.DECK);}if(!test.noCost)add(spellCost,L.GRAVE,0,P.FACEUP_ATTACK);add(targetCode,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.GRAVE);assert.equal(index>=0,!test.wrongSet&&!test.monster&&!test.noCost&&!test.selfTarget,'Deck effect availability');if(index<0){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(test.send?L.GRAVE:L.HAND).some(c=>c.code===lab),'Actual chosen Deck destination');for(const code of [boss,spellCost]){const cost=query(L.REMOVED).find(c=>c.code===code);assert(cost,'Both cost cards actually banished');assert(cost.reason&0x80,'Actual cost reason');}if(test.count){assert.equal(query(L.DECK).filter(c=>c.code===lab).length,1,'Second legal Deck target retained');assert.equal(query(test.reverse?L.SZONE:L.GRAVE).filter(c=>c.code===boss).length,1,'Second production copy retained');if(test.reverse)assert(query(L.REMOVED).some(c=>c.code===lab),'Legal Set target retained banished');assert(query(L.GRAVE).some(c=>c.code===spellCost),'Second legal cost retained GY');if(turn===1)assert(!p.activates.some(c=>c.code===boss),'Shared GY effect limit blocks second copy');if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(p.activates.some(c=>c.code===boss),'GY effect renewed next own turn');}else assert(!query(L.DECK).some(c=>c.code===lab),'Target left Deck');done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===spellCost||c.code===lab);assert(index>=0,'Cost or Deck selection');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/galataxian-battle-preparation-deck'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Battle Preparation/candidate metadata; neutral cost and Deck targets. Actual two-card banishment cost and Deck choice; no native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
