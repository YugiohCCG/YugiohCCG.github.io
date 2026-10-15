'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=214226989,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-negate','no-detach','no-history'].find(c=>process.argv.includes('--'+c));
 for(const test of [{materials:0},{materials:1},{materials:3}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spellTarget?0x20002:33,setcodes:[]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:17}]]);
  cards.set(900001195,{...base,code:900001195,type:test.spell?2:17});cards.set(spellCost,{...base,code:spellCost,type:17,setcodes:[0x103]});
  const reader=name=>{
   if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${lab}) if #g>0 then Duel.Overlay(tc,g) end Duel.Hint(HINT_NUMBER,tp,900+tc:GetOverlayCount()) end) c:RegisterEffect(e) end`;if(name==='c900001195.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,902) end) c:RegisterEffect(e) end';if([lab,filler,spellCost].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(control==='no-negate')lua=lua.replace('Duel.NegateActivation(ev)','do end');if(control==='no-detach')lua=lua.replace('c:RemoveOverlayCard(tp,ct,ct,REASON_COST)','do end');if(control==='no-history')lua=lua.replace('c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   for(let i=0;i<test.materials;i++)add(lab,L.HAND);add(900001195,L.MZONE,0,P.FACEUP_ATTACK,2);add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(recipient,L.MZONE,0,P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<(test.emptyDeck&&player===0?0:8);i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE|Q.OVERLAY_CARD,controller,location}).filter(Boolean);let placements=0,attached=false,attempts=0,negations=0,responseChecked=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!attached){const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0);attached=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const allowed=test.materials===0?1:test.materials===1?2:3;if(attempts){const paid=negations*(negations-1)/2;assert.equal(query(L.MZONE).find(c=>c.code===boss).overlayCards.length,test.materials-paid,'Actual escalating material costs');assert.equal(trace.filter(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='902').length,attempts>allowed?1:0,'Native activation negated before operation');}if(attempts===allowed+1){assert.equal(negations,allowed,'Actual consecutive available negations');const costs=query(L.GRAVE).filter(c=>c.code===lab);assert.equal(costs.length,allowed*(allowed-1)/2);assert(costs.every(c=>c.reason&0x80),'Real detach cost reasons');done=true;continue;}attempts++;responseChecked=false;const index=p.activates.findIndex(c=>c.code===900001195);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===900001195||c.code===lab);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((c,i)=>c.code===lab?i:-1).filter(i=>i>=0).slice(0,p.min).length===p.min?p.selects.map((c,i)=>c.code===lab?i:-1).filter(i=>i>=0).slice(0,p.min):[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>c.code===spellCost);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x1f)!==0x1f;const shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){let index=-1;if(attempts&&p.player===0&&!responseChecked){responseChecked=true;index=p.selects.findIndex(c=>c.code===boss);const expected=attempts<=(test.materials===0?1:test.materials===1?2:3);assert.equal(index>=0,expected,'Native required-cost availability');if(index>=0)negations++;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-stellaer-purity-negation'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current initial-MZONE Purity actual native repeated Quick negation CL2 against neutral own ignition CL1. Native helper Overlay zero/one/three real materials; consecutive costs0/1/2 and later unavailable, actual costGY and negated operations. No adapters/proper Xyz history. Other effects/reset/interruptions/Omega/fullcard open',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
