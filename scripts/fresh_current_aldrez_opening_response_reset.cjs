'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=210923192,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-limit','no-response-operation'].find(c=>process.argv.includes('--'+c));
 for(const test of [{normal:true},{}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:17,setcodes:test.wrongSet?[]:[0xc1c]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:33}]]);
  cards.set(spellCost,{...base,code:spellCost,type:33});
  const reader=name=>{
   if(name==='c'+spellCost+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${lab}) if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) else Duel.Hint(HINT_MESSAGE,tp,881) end end) c:RegisterEffect(e) end`;
   if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE) e:SetHintTiming(TIMING_SUMMON+TIMING_SPSUMMON) e:SetCondition(function() return Duel.IsExistingMatchingCard(Card.IsCode,0,LOCATION_MZONE,LOCATION_MZONE,1,nil,${lab}) end) e:SetOperation(function(e,tp) ${control==='no-response-operation'?'do end':'Duel.Hint(HINT_MESSAGE,tp,880)'} end) c:RegisterEffect(e) end`;
   if([lab,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(control==='no-limit')lua=lua.replaceAll('Duel.SetChainLimitTillChainEnd(s.chainlm)','do end');if(control==='allow-any'){const a=lua.indexOf('function s.limfilter'),b=lua.indexOf('function s.limcon');lua=lua.slice(0,a)+lua.slice(a,b).replace('c:IsSetCard(SET_ALDREZ) and ','')+lua.slice(b);}if(control==='any-summoner')lua=lua.replace(' and c:IsSummonPlayer(tp)','');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(!test.inactive)add(boss,L.HAND);add(lab,L.HAND);add(spellCost,L.MZONE,0,P.FACEUP_ATTACK,0);add(recipient,L.MZONE,0,P.FACEUP_ATTACK,1);add(recipient,L.MZONE,1,P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller,location}).filter(Boolean);let placements=0,summoned=false,ownOffers=0,oppOffers=0,accepted=false,later=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!placements&&!test.inactive){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);assert(index>=0);placements++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!summoned){const index=test.normal?p.summons.findIndex(c=>c.code===lab):p.activates.findIndex(c=>c.code===spellCost);assert(index>=0);summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:test.normal?A.SELECT_SUMMON:A.SELECT_ACTIVATE,index});continue;}assert(query(L.MZONE).some(c=>c.code===lab));if(!later){assert(accepted,'Own response actually accepted');assert(trace.some(m=>m.type===M.HINT&&String(m.hint)==='880'),'Actual protected own response operation');assert.equal(oppOffers,0,'Opponent excluded throughout protected response chain');later=true;ownOffers=0;oppOffers=0;const index=p.activates.findIndex(c=>c.code===spellCost);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(oppOffers>0,'Later chain restores actual opponent response');assert(trace.some(m=>m.type===M.HINT&&String(m.hint)==='881'),'Actual later nonsummon operation');done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0,'Actual recycle target choice');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!!test.draw});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){let place;for(const [relative,location,shift] of [[0,L.MZONE,0],[0,L.SZONE,8],[1,L.MZONE,16],[1,L.SZONE,24]]){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);if(sequence!==undefined){place={player:relative===0?p.player:1-p.player,location,sequence};break;}}assert(place);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
    else if(p.type===M.SELECT_CHAIN){if(summoned&&query(L.MZONE,test.opponent?1:0).some(c=>c.code===lab)&&p.selects.some(c=>c.code===recipient)){if(p.player===0){ownOffers++;if(!accepted&&!later){accepted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.selects.findIndex(c=>c.code===recipient)});continue;}}else if(later||!trace.some(m=>m.type===M.HINT&&String(m.hint)==='880'))oppOffers++;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-aldrez-opening-response-reset'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current Opening actual activation and Normal/Special Summon, accepted own Quick response with actual operation, opponent excluded throughout protected chain, actual later nonsummon chain restores opponent response. No adapters. Native Omega/recycle gaps remain open.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
