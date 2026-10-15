'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_current_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273768,target=900000831,filler=900000832,blocker=900000833;
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{},{wrongSet:true},{notPendulum:true},{sameName:true},{noTarget:true},{otherZoneOccupied:true},{full:true}]){
  const legal=!(test.wrongSet||test.notPendulum||test.sameName||test.noTarget),logs=[],trace=[],cards=new Map([[boss,candidateCard(boss)],[target,{...base,code:target,type:test.notPendulum?33:0x1000021,setcodes:test.wrongSet?[]:[0x1066],lscale:1,rscale:1}],[filler,{...base,code:filler}],[blocker,{...base,code:blocker,type:0x20002,level:0,race:0n,attribute:0}]]);
  const reader=name=>{if([target,filler,blocker].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(process.argv.includes('--no-operation')&&name==='c'+boss+'.lua')lua=lua.replace('Duel.MoveToField(tc,tp,tp,LOCATION_PZONE,POS_FACEUP,true)','(function() return false end)()');return lua};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});add(boss,L.HAND);if(!test.noTarget)add(test.sameName?boss:target,L.DECK);if(test.otherZoneOccupied)core.duelNewCard(duel,{team:0,duelist:0,code:blocker,controller:0,location:L.SZONE,sequence:4,position:P.FACEUP_ATTACK});if(test.full)for(let i=0;i<5;i++)core.duelNewCard(duel,{team:0,duelist:0,code:filler,controller:0,location:L.MZONE,sequence:i,position:P.FACEUP_ATTACK});for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<90&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!placed){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);if(index<0)throw Error('Pendulum activation missing');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132273768*16));if(legal&&!activated){if(index<0)throw Error('Flip ignition missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(index>=0)throw Error('Illegal/repeat ignition offered');if(legal){const extra=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.EXTRA}),zones=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE});if(!extra.some(c=>c?.code===boss)||!zones.some(c=>c?.code===target))throw Error('Actual self destruction/Deck Pendulum placement failed');if(trace.some(t=>t.type===M.BECOME_TARGET))throw Error('Non-targeting selection targeted');}done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);if(index<0)throw Error('Flip candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-symphonic-speeaker-pendulum'+(process.argv.includes('--no-operation')?'-no-operation':'')+'.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; complete Speeaker/current-spec metadata/correctedCardData, neutral companions; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
