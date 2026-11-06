"use strict";
const fs=require('node:fs'),path=require('node:path');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273770,nonTuner=900002040,synchro=900002041,member=900002042,holder=900002043,setup=900002044,third=900002045,repeat=900002046,filler=900002047;
 const base={alias:0,setcodes:[],type:33,level:4,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 const control=['old-source','no-chain-guard','per-copy-recruit','per-copy-material','no-recruit-reset','no-material-reset'].find(f=>process.argv.includes('--'+f));
 for(const scenario of ['searchFirst','materialFirst']){
  const cards=new Map([[boss,candidateCard(boss)],[nonTuner,{...base,code:nonTuner,type:17}],[synchro,{...base,code:synchro,type:0x2001,level:5}],[member,{...base,code:member,type:17,setcodes:[0x1066]}],[holder,{...base,code:holder,type:0x20002}],[filler,{...base,code:filler}]]);
  for(const code of [setup,third,repeat])cards.set(code,{...base,code,type:2});
  const summon=`local b=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}):GetFirst() assert(b and Duel.SpecialSummon(b,0,tp,tp,false,false,POS_FACEUP)>0,'Hand Disccs summon missing')`;
  const syn=`local sc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${synchro}):GetFirst() assert(sc and sc:IsSynchroSummonable(),'Native recipe unavailable') Duel.SynchroSummon(tp,sc)`;
  const reader=name=>{
   if(name===`c${synchro}.lua`)return require('./fresh_native_two_material_synchro.cjs').recipe(boss,nonTuner);
   if(name===`c${holder}.lua`)return 'local s,id=GetID() function s.initial_effect(c) c:EnableCounterPermit(0x35) end';
   if([setup,third,repeat].some(c=>name===`c${c}.lua`)){const op=name===`c${setup}.lua`?`Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,${holder}):GetFirst():AddCounter(0x35,9) ${syn} ${summon}`:name===`c${third}.lua`?summon:`Duel.SendtoHand(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}),nil,REASON_EFFECT) local n=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${nonTuner}):GetFirst() assert(n and Duel.SpecialSummon(n,0,tp,tp,false,false,POS_FACEUP)>0,'NonTuner revival failed') ${summon} ${syn}`;return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${op} end) c:RegisterEffect(e) end`;}
   if([nonTuner,member,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(control==='old-source')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/disccs-before-delayed-search-chain-repair/c238273770.lua'),'utf8');if(control==='no-chain-guard')lua=lua.replace('return Duel.GetFlagEffect(tp,id+400)==0','return true');if(control==='per-copy-recruit')lua=lua.replace('e4:SetCountLimit(1,id+200)','e4:SetCountLimit(1)');if(control==='per-copy-material')lua=lua.replace('e5:SetCountLimit(1,id+300)','e5:SetCountLimit(1)');if(control==='no-recruit-reset')lua=lua.replace('e4:SetCountLimit(1,id+200)','e4:SetCountLimit(1,id+200,2)');if(control==='no-material-reset')lua=lua.replace('e5:SetCountLimit(1,id+300)','e5:SetCountLimit(1,id+300,2)');}return lua;
  };
  const logs=[],trace=[],duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,turn=0,stage=0,firstChosen=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,position,sequence});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(nonTuner,L.MZONE,0,P.FACEUP_ATTACK,1);add(boss,L.HAND);add(boss,L.HAND);add(member,L.HAND);add(holder,L.SZONE);for(const code of [setup,third,repeat,repeat])add(code,L.HAND);for(let i=0;i<3;i++)add(synchro,L.EXTRA,0,P.FACEDOWN_DEFENSE);for(let i=0;i<5;i++)add(member,L.DECK);for(const player of [0,1])for(let i=0;i<7;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<400&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    const chains=offset=>trace.filter(t=>t.type===M.CHAINING&&t.code===boss&&String(t.description)===String(132273770*16+offset));
    const activate=(code,offset)=>{const index=p.activates.findIndex(c=>c.code===code&&(offset===undefined||String(c.description)===String(132273770*16+offset)));if(index<0)throw Error('Native activation unavailable '+code+'/'+offset);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});};
    if(p.type===M.SELECT_IDLECMD){
     if(turn===2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(stage===0){stage++;activate(setup);continue;}
     if(stage===1){const wanted=scenario==='searchFirst'?1:3,other=wanted===1?3:1;if(chains(wanted).length!==1||chains(other).length!==0)throw Error('Simultaneous different monster effects bypassed chain guard/preference');stage++;activate(boss,2);continue;}
     if(stage===2){if(chains(1).length!==1||chains(2).length!==1)throw Error('New-chain search/recruit availability failed');stage++;activate(third);continue;}
     if(stage===3){if(p.activates.some(c=>c.code===boss&&String(c.description)===String(132273770*16+2)))throw Error('Another copy bypassed named recruit use');stage++;activate(repeat);continue;}
     if(stage===4){if(chains(1).length!==1||chains(2).length!==1||chains(3).length!==1)throw Error('Material named shared use/new-chain availability failed');stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(turn===3&&stage===5){const index=p.summons.findIndex(c=>c.code===boss);if(index<0)throw Error('Next-turn normal summon unavailable');stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});continue;}
     if(stage===6){if(chains(1).length!==2)throw Error('Search reset missing');stage++;activate(boss,2);continue;}
     if(stage===7){if(chains(2).length!==2)throw Error('Recruit reset missing');stage++;activate(repeat);continue;}
     if(turn!==3||stage!==8||chains(3).length!==2)throw Error('Material reset missing');
     if(trace.filter(t=>t.type===M.REMOVE_COUNTER&&t.counter_type===0x35).reduce((n,t)=>n+t.count,0)!==6)throw Error('Expected material costs missing');
     if(trace.filter(t=>t.type===M.MOVE&&t.card===boss&&t.from.location===L.MZONE&&t.to.location===L.EXTRA).length!==3)throw Error('Native material transitions missing');done=true;
    }
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss)throw Error('Wrong optional trigger');const wanted=scenario==='searchFirst'?L.MZONE:L.EXTRA,yes=stage!==1||firstChosen||p.location===wanted;if(stage===1&&yes)firstChosen=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes});}
    else if(p.type===M.SELECT_CHAIN){let index=-1;if(stage===1&&!firstChosen){const wanted=scenario==='searchFirst'?1:3;index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(132273770*16+wanted));}if(index<0)index=p.selects.findIndex(c=>c.code===boss&&[1,3].some(i=>String(c.description)===String(132273770*16+i)));if(stage===1&&index>=0)firstChosen=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const current=trace.filter(t=>t.type===M.CHAINING&&t.code===boss).at(-1),wanted=String(current?.description)===String(132273770*16+2)?boss:member,index=p.selects.findIndex(c=>c.code===wanted);if(index<0)throw Error('Search/recruit selection missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_COUNTER){let left=p.count;const counters=p.cards.map(c=>{const n=Math.min(left,c.count);left-=n;return n;});if(left)throw Error('Counter budget missing');core.duelSetResponse(duel,{type:R.SELECT_COUNTER,counters});}
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({scenario,failure,turn,stage,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${scenario}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-symphonic-disccs-monster-chain${control?'-'+control:''}.json`),JSON.stringify({scope:'Complete Disccs/current installed metadata/corrected transport/no Lua API adapter. Neutral native fixed Synchro recipe. Simultaneous material/search triggers tested in both chosen orders; only one monster effect per chain, independent subsequent-chain effects; named recruit/material use across copies, all monster uses restored next own turn. Real counter costs/material transitions. Live Omega/general recipes not certified.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
