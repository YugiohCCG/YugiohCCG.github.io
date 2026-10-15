'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=214552846,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-destroy','ignore-type','ignore-exclusion'].find(c=>process.argv.includes('--'+c));
 for(const test of [{match:'race'},{match:'attribute'},{match:'level'},{match:'attack'},{match:'defense'},{},{match:'race',normal:true},{match:'race',facedown:true},{match:'race',opponent:true},{match:'race',excluded:true},{match:'race',group:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spellTarget?0x20002:33,setcodes:[]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:17}]]);
  cards.set(900001195,{...base,code:900001195,type:test.spell?2:17});cards.set(spellCost,{...base,code:spellCost,type:17,setcodes:[0x103]});
  const targetCode=test.excluded?223512283:recipient;cards.set(targetCode,{...base,code:targetCode,type:test.normal?17:33,race:test.match==='race'?1n:2n,attribute:test.match==='attribute'?1:2,level:test.match==='level'?2:3,attack:test.match==='attack'?1000:900,defense:test.match==='defense'?1200:800});cards.set(lab,{...base,code:lab});
  if(test.group)cards.set(spellCost,{...base,code:spellCost,type:33,race:2n,attribute:1,level:3,attack:900,defense:800});
  const reader=name=>{
 if(name==='c900001195.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.Destroy(Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_FZONE,0,nil,${boss}),REASON_EFFECT) end) c:RegisterEffect(e) end`;if([lab,filler,spellCost,recipient,223512283].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(control==='no-destroy')lua=lua.replace('Duel.Destroy(dg,REASON_EFFECT)==0','0==0');if(control==='ignore-type')lua=lua.replace('and c:IsType(TYPE_EFFECT) and not c:IsCode','and true and not c:IsCode');if(control==='ignore-exclusion')lua=lua.replace('not c:IsCode(CARD_DYSMANDR)','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(test.group)add(spellCost,L.MZONE,0,P.FACEUP_ATTACK,3);add(boss,L.SZONE,0,P.FACEUP_ATTACK,5);add(lab,L.MZONE,0,P.FACEUP_ATTACK,0);add(targetCode,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);add(900001195,L.MZONE,0,P.FACEUP_ATTACK,2);for(const player of [0,1])for(let i=0;i<(test.emptyDeck&&player===0?0:8);i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE|Q.OVERLAY_CARD,controller,location}).filter(Boolean);let placements=0,attached=false,attempts=0,negations=0,responseChecked=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===900001195);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const destroyed=!!test.match&&!(test.normal||test.facedown||test.opponent||test.excluded);assert(query(L.GRAVE).some(c=>c.code===boss),'Actual Field destruction/GY');assert(query(L.MZONE).some(c=>c.code===lab),'Selected monster retained');assert.equal(query(L.GRAVE,test.opponent?1:0).some(c=>c.code===targetCode),destroyed,'Actual matching Effect Monster destruction');assert.equal(query(L.MZONE,test.opponent?1:0).some(c=>c.code===targetCode),!destroyed);if(test.group)assert(query(L.GRAVE).some(c=>c.code===spellCost),'All other matching monsters destroyed');assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&String(m.description)===String(132552846*16+1)),'Actual full GY forced trigger');done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((c,i)=>c.code===lab?i:-1).filter(i=>i>=0).slice(0,p.min).length===p.min?p.selects.map((c,i)=>c.code===lab?i:-1).filter(i=>i>=0).slice(0,p.min):[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>c.code===spellCost);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x1f)!==0x1f;const shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-eldora-matching-destruction'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current Eldora actual native field destruction/GY forced trigger targets own Normal monster; destroys other own faceup Effect monster sharing only race/attribute/level/ATK/DEF. Nonmatch/Normal/facedown/opponent/listed Dysmandr exclusion; neutral metadata candidates explicit. No Set resource present; full matching group/Set/count/interruptions/nativeOmega/fullcard open',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
