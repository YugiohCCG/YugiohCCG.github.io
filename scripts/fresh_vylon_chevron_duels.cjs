'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),chevron=238274857,glome=238274858,cost=900000091,filler=900000092;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),query=db.prepare('select * from datas where id=?');
 const base={alias:0,setcodes:[],type:0x21,level:1,attribute:16,race:0x20n,attack:500,defense:500,lscale:0,rscale:0,link_marker:0};
 const data=new Map([[cost,{...base,code:cost,setcodes:[0x30],type:17}],[filler,{...base,code:filler,type:17,attribute:1,race:1n}]]);
 for(const code of [chevron,glome]){
  const r=query.get(code),b=r.setcode;
  data.set(code,{...base,code,setcodes:Array.from({length:b.length/2},(_,i)=>b[i*2]|b[i*2+1]<<8).filter(Boolean),type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)});
 }
 db.close();
 const results=[];
 for(const hasCost of [false,true]){
  const logs=[],trace=[];
  const reader=name=>{
   if(name==='c0.lua'||name===`c${filler}.lua`||name===`c${cost}.lua`)return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},
   cardReader:code=>{if(!data.has(code))throw Error('Missing '+code);return data.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,summoned=false,triggered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(chevron,L.HAND);if(hasCost)add(cost,L.HAND);add(glome,L.DECK);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<150&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(summoned){
      if(!triggered||core.duelQueryCount(duel,0,L.MZONE)!==(hasCost?2:1))throw Error('Chevron summon trigger outcome wrong');
      if(hasCost&&core.duelQueryCount(duel,0,L.GRAVE)!==1)throw Error('Vylon cost not sent');
      if(!hasCost&&core.duelQueryCount(duel,0,L.SZONE)!==1)throw Error('Self-sent Chevron did not equip to the summoned Vylon');
      done=true;break;
     }
     const index=p.summons.findIndex(c=>c.code===chevron);if(index<0)throw Error('Chevron Normal Summon unavailable');
     summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});
    }else if(p.type===M.SELECT_CHAIN){
     const index=p.selects.findIndex(c=>c.code===chevron);
     if(index>=0)triggered=true;
     core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});
    }else if(p.type===M.SELECT_EFFECTYN){triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CARD){
     const index=p.selects.findIndex(c=>c.code===cost||c.code===glome);
     core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});
    }else if(p.type===M.SELECT_PLACE){
     const location=!hasCost&&trace.some(m=>m.type===M.SPSUMMONED)?L.SZONE:L.MZONE;
     const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<((location===L.SZONE?8:0)+i)))===0);if(sequence===undefined)throw Error('No free zone');
     core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});
    }else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({hasCost,status:failure?'FAIL':'PASS',failure,logs,trace});console.log(`${failure?'FAIL':'PASS'} hasCost=${hasCost}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/vylon-chevron-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
