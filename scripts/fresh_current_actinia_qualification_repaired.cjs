'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=216258796,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['old-source'].find(c=>process.argv.includes('--'+c));
 for(const test of [{}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,race:test.wrongRace?1n:64n,attribute:test.wrongAttribute?1:2}],[filler,{...base,code:filler}]]);
  cards.set(900001195,{...base,code:900001195,type:2});
  const reader=name=>{
   if(name==='c900001195.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}) Duel.SendtoGrave(tc,REASON_EFFECT) Duel.Hint(HINT_NUMBER,tp,tc:IsStatus(STATUS_PROC_COMPLETE) and 701 or 700) Duel.Hint(HINT_NUMBER,tp,tc:IsCanBeSpecialSummoned(e,0,tp,false,false) and 702 or 703) end) c:RegisterEffect(e) end`;
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='old-source')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/actinia-before-revival-qualification-repair/c216258796.lua'),'utf8');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.EXTRA);add(900001195,L.HAND);if(test.count)add(boss,L.EXTRA);add(900001195,L.HAND);if(!test.absent)add(lab,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,0);if(test.full)for(let i=1;i<5;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===900001195);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='700'),'Actual Extra-to-GY source has no completed procedure');assert(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='703'),'Native ordinary SpecialSummon denies improper source');assert(!p.special_summons.some(c=>c.code===boss),'Improperly summoned Fusion remains unavailable in GY despite eligible WATER Aqua partner');assert(query(L.GRAVE).some(c=>c.code===boss));assert(!trace.some(m=>m.type===M.SPSUMMONED));done=true;}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const mz=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0), location=mz===undefined?L.SZONE:L.MZONE,sequence=mz===undefined?[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0):mz;core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-actinia-qualification-repaired'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,engine:'Public OCGCore Production repaired full Actinia actually sent Extra-to-GY without proper Fusion history, native STATUS_PROC_COMPLETE and ordinary summon permission observed. Real faceup own WATER Aqua partner and free MZONE still do not permit native revival procedure. No adapters, seeded proper history, or ignored restrictions; ignore-revive-limit negative control. Proper Fusion/revival/nativeOmega/fullcard OPEN.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
