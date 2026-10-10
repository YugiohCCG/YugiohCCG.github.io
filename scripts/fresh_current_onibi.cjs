'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),source=217713649,spirit=900004201,filler=900004202,STRING=133713649;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),control=['no-limit','no-search','no-return'].find(c=>process.argv.includes('--'+c))||null,results=[];
 for(const test of [{},{declineSearch:true},{tribute:true},{wrongDeckType:true}]){
  const trace=[],logs=[],neutral={alias:0,setcodes:[],type:17,level:1,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[source,candidateCard(source)],[spirit,{...neutral,code:spirit,type:!test.tribute&&test.wrongDeckType?17:0x221}],[filler,{...neutral,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if([spirit,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(p=>fs.existsSync(p));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+source+'.lua'&&process.argv.includes('--probe'))lua=lua.replace('if tc:IsCode(id) and tc:IsLocation(LOCATION_MZONE)', 'Debug.Message("After summon loc="..tc:GetLocation().." deckSpirit="..Duel.GetMatchingGroupCount(s.thfilter,tp,LOCATION_DECK,0,nil)) if tc:IsCode(id) and tc:IsLocation(LOCATION_MZONE)');
   if(name==='c'+source+'.lua'&&control==='no-search')lua=lua.replace('then s.searchop(tp) end','then do end end');
   if(name==='c'+source+'.lua'&&control==='no-return')lua=lua.replace('er:SetOperation(aux.SpiritReturnOperation)','er:SetOperation(function() end)');
   if(name==='c'+source+'.lua'&&control==='no-limit')lua=lua.replace('e2:SetCountLimit(1,id)','');return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,renewed=false,turn=0,searchPrompts=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEDOWN_DEFENSE});
   add(source,L.HAND);if(!test.tribute)add(source,L.HAND);if(test.tribute)add(spirit,L.HAND);else add(spirit,L.DECK);
   for(const player of [0,1])for(let i=0;i<6;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<250&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    assert(!logs.some(l=>l.type===0),JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===source);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(turn===1){assert(query(L.MZONE).some(c=>c.code===(test.tribute?spirit:source)),'Actual Normal Summon');assert(!p.activates.some(c=>c.code===source),'Named turn limit blocks both copies');
      if(test.tribute){assert(query(L.GRAVE).some(c=>c.code===source),'Onibi released from Hand');assert.equal(searchPrompts,0,'Non-Onibi summon does not search');done=true;continue;}
      assert.equal(query(L.HAND).some(c=>c.code===spirit),!test.declineSearch&&!test.wrongDeckType,'Optional Spirit search');assert.equal(searchPrompts,test.wrongDeckType?0:1,'Search prompt availability');
     }
     if(turn>=3&&renewed){assert(query(L.MZONE).some(c=>c.code===source),'Renewed activation actually Normal Summons');assert.equal(trace.filter(m=>m.type===M.SUMMONED).length,2,'Two actual Normal Summons across own turns');done=true;continue;}
     if(turn>=3){assert.equal(query(L.MZONE).filter(c=>c.code===source).length,0,'Onibi returned at actual End Phase');assert.equal(query(L.HAND).filter(c=>c.code===source).length,2,'Both copies retained in Hand');const index=p.activates.findIndex(c=>c.code===source);assert(index>=0,'Named use renewed next own turn');renewed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});
    }else if(p.type===M.SELECT_YESNO){const description=Number(p.description);if(description===STRING*16+2)searchPrompts++;assert([STRING*16+1,STRING*16+2].includes(description),'Known cost/search prompt '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:description===STRING*16+1?!!test.tribute:!test.declineSearch});}
    else if(p.type===M.SELECT_CARD){const want=p.selects[0].location===L.DECK?spirit:test.tribute?spirit:source;const index=p.selects.findIndex(c=>c.code===want);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');assert(trace.some(m=>m.type===M.SUMMONED),'Native Normal Summon message');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const sha=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-data/onibi'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Current canonical Onibi: actual Normal Summon/optional Spirit search/Hand Tribute, named limit across Hand/field copies, actual End return and turn renewal. Neutral Spirit recipients; native Omega, Flip/shared return limit and interruptions open.',control,database_snapshot_sha256:sha(path.join(ROOT,'output/fresh-ccg-september/current-spec-CCG_v1.db')),script_sha256:sha(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+source+'.lua')),harness_sha256:sha(__filename),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
