'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=212822164,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-restriction','wrong-race','no-reset'].find(c=>process.argv.includes('--'+c));
 for(const test of [{fish:true},{},{opponent:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:17,setcodes:test.wrongSet?[]:[0x18a]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:17}]]);
  cards.set(spellCost,{...base,code:spellCost,type:17,setcodes:[0x103],race:test.fish?131072n:1n});
  const reader=name=>{
   if(name==='c'+lab+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${test.deckLock&&control!=='no-lock'?'local l=Effect.CreateEffect(c) l:SetType(EFFECT_TYPE_SINGLE) l:SetCode(EFFECT_CANNOT_REMOVE) c:RegisterEffect(l)':''} end`;if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) local tc=Duel.GetFirstMatchingCard(Card.IsCode,${test.opponent?1:0},LOCATION_GRAVE,0,nil,${spellCost}) if chk==0 then return tc and tc:IsCanBeSpecialSummoned(e,0,${test.opponent?1:0},false,false) end end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,${test.opponent?1:0},LOCATION_GRAVE,0,nil,${spellCost}) Duel.SpecialSummon(tc,0,${test.opponent?1:0},${test.opponent?1:0},false,false,POS_FACEUP) end) c:RegisterEffect(e) end`;if([filler,spellCost].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(control==='no-restriction')lua=lua.replace('Duel.RegisterEffect(e1,tp)','do end');if(control==='wrong-race')lua=lua.replace('return not c:IsRace(RACE_FISH)','return c:IsRace(RACE_FISH)');if(control==='no-reset')lua=lua.replace('e1:SetReset(RESET_PHASE+PHASE_END)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false,stage=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(recipient,L.MZONE,0,P.FACEUP_ATTACK,1);add(spellCost,L.GRAVE,test.opponent?1:0,P.FACEUP_ATTACK);add(spellCost,L.GRAVE,test.opponent?1:0,P.FACEUP_ATTACK);for(let i=0;i<(test.one?1:test.three?3:2);i++)add(lab,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller,location}).filter(Boolean);let placements=0,placed=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.REMOVED).some(c=>c.code===boss));assert.equal(query(L.REMOVED).filter(c=>c.code===lab).length,2);const player=test.opponent?1:0;if(stage===0){const index=p.activates.findIndex(c=>c.code===recipient);assert.equal(index>=0,!!test.fish||!!test.opponent,'Native registered Fish-only/player restriction');stage=1;if(index>=0){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}}if(turn<3){assert.equal(query(L.MZONE,player).filter(c=>c.code===spellCost).length,test.fish||test.opponent?1:0,'Actual current-turn summon result');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}if(stage===1){const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0,'Actual later-turn restriction expiry');stage=2;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert.equal(query(L.MZONE,player).filter(c=>c.code===spellCost).length,test.fish||test.opponent?2:1,'Actual renewed native summon after expiry');done=true;}
    else if(p.type===M.SELECT_CARD){assert.equal(p.min,2);assert.equal(p.max,2);assert(p.selects.every(c=>c.code===lab));core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0,1]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>c.code===spellCost);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){let place;for(const relative of [0,1])for(const [location,offset] of [[L.MZONE,0],[L.SZONE,8]])for(let sequence=0;sequence<5;sequence++)if(!place&&(p.field_mask&(1<<(relative*16+offset+sequence)))===0)place={player:relative?1-p.player:p.player,location,sequence};assert(place);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-bray-fish-restriction'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full initial-field Bray actual self and two Deck monsters banished; real neutral native summon target checks and summons prove own Fish allowed, own nonFish blocked, opposing summoning player nonFish allowed, actual ownturn3 restriction expiry. No adapters. Neutral helper explicitly supplies summon permission; native Synchro/battle/interruptions/shared use/Omega/fullcard open.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
