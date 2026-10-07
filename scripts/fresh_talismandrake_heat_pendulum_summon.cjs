'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=210506870,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=process.argv.includes('--no-lock')?'no-lock':null;
 for(const test of [{},{wrongRace:true},{mixed:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:0x1000021,lscale:1,rscale:1}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,level:4,race:test.wrongRace?1n:128n}],[spellCost,{...base,code:spellCost,level:4,race:1n}]]);
  const reader=name=>{
   if(name==='c'+lab+'.lua')return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='no-lock')lua=lua.replace('e1:SetTarget(s.splimit)','e1:SetTarget(function() return false end)');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(lab,L.HAND);add(recipient,L.HAND);if(test.mixed)add(spellCost,L.HAND);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!placementStarted||!placementFinished){const wanted=placementStarted?lab:boss;const index=p.activates.findIndex(c=>c.code===wanted&&c.location===L.HAND);assert(index>=0,'Actual scale activation');if(placementStarted)placementFinished=true;else placementStarted=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const index=p.special_summons.findIndex(c=>c.code===boss||c.code===lab);if(!activated){assert.equal(index>=0,!test.wrongRace,'Actual Pendulum procedure availability');if(index<0){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}assert(query(L.MZONE).some(c=>c.code===recipient),'Actual Pyro Pendulum Summon');assert(trace.some(m=>m.type===M.SPSUMMONED),'Native summon completion');if(test.mixed)assert(query(L.HAND).some(c=>c.code===spellCost),'NonPyro retained Hand');done=true;}
    else if(p.type===M.SELECT_CARD){assert(!p.selects.some(c=>c.code===spellCost),'NonPyro excluded from native Pendulum choice');const index=p.selects.findIndex(c=>c.code===recipient);assert(index>=0,'Pyro native Pendulum choice');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){assert(!p.select_cards.some(c=>c.code===spellCost),'NonPyro excluded from native Pendulum choice');const index=p.select_cards.findIndex(c=>c.code===recipient);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:index>=0?index:null});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const location=activated?L.MZONE:L.SZONE;const shift=activated?0:8;const sequence=(activated?[0,1,2,3,4]:[0,4]).find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/talismandrake-heat-pendulum-summon'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,engine:'Public OCGCore, full production Talismandrake Heat/candidate metadata; neutral supporting cards. Actual scale activations and Pendulum Summon with neutral second scale and Hand monsters; native Omega unverified; no native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
