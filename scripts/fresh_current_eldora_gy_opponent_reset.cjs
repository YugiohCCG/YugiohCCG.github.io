'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=214552846,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['per-copy','no-reset','no-response'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{interrupt:'activation'},{interrupt:'effect'}]){ const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spellTarget?0x20002:33,setcodes:[]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:17}]]);
  cards.set(900001195,{...base,code:900001195,type:test.spell?2:17});cards.set(spellCost,{...base,code:spellCost,type:17,setcodes:[0x103]});
  const targetCode=test.excluded?223512283:recipient;cards.set(targetCode,{...base,code:targetCode,type:test.normal?17:33,race:test.match==='race'?1n:2n,attribute:test.match==='attribute'?1:2,level:test.match==='level'?2:3,attack:test.match==='attack'?1000:900,defense:test.match==='defense'?1200:800});cards.set(lab,{...base,code:lab});
  if(test.group)cards.set(spellCost,{...base,code:spellCost,type:33,race:2n,attribute:1,level:3,attack:900,defense:800});
  const setCode=test.wrongCode?spellCost:229786055;cards.set(229786055,candidateCard(229786055));cards.set(spellCost,{...base,code:spellCost,type:2});cards.set(filler,{...base,code:filler,type:2});
  cards.set(900001196,{...base,code:900001196,type:0x100004});
  const reader=name=>{
 if(name==='c900001196.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev) ${test.interrupt==='activation'?'Duel.NegateActivation(ev)':'Duel.NegateEffect(ev)'} end) c:RegisterEffect(e) end`;
 if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${test.indestructible?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_INDESTRUCTABLE_EFFECT) e:SetValue(1) c:RegisterEffect(e)':''} end`;
 if(name==='c900001195.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_FZONE,0,nil,${boss}) if not tc then tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_HAND,0,nil,${boss}) Duel.MoveToField(tc,0,0,LOCATION_FZONE,POS_FACEUP,true) end Duel.Destroy(tc,REASON_EFFECT) end) c:RegisterEffect(e) end`;if([lab,filler,spellCost,recipient,223512283].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(control==='per-copy')lua=lua.replace('e2:SetCountLimit(1,id)','e2:SetCountLimit(1)');if(control==='no-reset')lua=lua.replace('e2:SetCountLimit(1,id)','e2:SetCountLimit(1,id,2)');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(test.interrupt)add(900001196,L.SZONE,1,P.FACEDOWN_DEFENSE);add(boss,L.SZONE,0,P.FACEUP_ATTACK,5);add(boss,L.HAND);add(boss,L.HAND);add(lab,L.MZONE,0,P.FACEUP_ATTACK,0);add(900001195,L.MZONE,0,P.FACEUP_ATTACK,2);add(900001195,L.MZONE,1,P.FACEUP_ATTACK,2);for(const player of [0,1])for(let i=0;i<(test.emptyDeck&&player===0?0:8);i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE|Q.OVERLAY_CARD,controller,location}).filter(Boolean);let placements=0,attached=false,attempts=0,negations=0,responseChecked=false,responded=false,uses=0;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(uses){assert.equal(query(L.GRAVE).filter(c=>c.code===boss).length,uses,'Actual distinct source copies destroyed');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss&&String(m.description)===String(132552846*16+1)).length,uses===3?2:1,'Actual named trigger shared use/reset');}if(uses===2&&turn<2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}if(uses===3){assert.equal(turn,2);assert(query(L.MZONE).some(c=>c.code===lab),'Actual target remains');if(test.interrupt){assert(responded);assert(trace.some(m=>m.type===M.CHAINING&&m.code===900001196&&m.chain_size===2));}done=true;continue;}uses++;const index=p.activates.findIndex(c=>c.code===900001195);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(p.selects.some(c=>c.code===setCode)?setCode:lab));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((c,i)=>c.code===lab?i:-1).filter(i=>i>=0).slice(0,p.min).length===p.min?p.selects.map((c,i)=>c.code===lab?i:-1).filter(i=>i>=0).slice(0,p.min):[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>c.code===spellCost);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x1f)!==0x1f;const shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===boss);const counter=p.selects.findIndex(c=>c.code===900001196);if(test.interrupt&&uses===1&&counter>=0&&!responded&&control!=='no-response'){responded=true;index=counter;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-eldora-gy-opponent-reset'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current Eldora three actual distinct copies; initial Field plus actual native MoveToField Hand copies/Destroy. First full forced GY trigger success/native CL2 activation/effect negation, second ownturn1 source destruction shares used named limit; third immediately opponentturn2 fresh trigger. Normal anchor no matching Effect monsters/resources; no seeded use/adapters/nativeOmega/fullcard certification',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
