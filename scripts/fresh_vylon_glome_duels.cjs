'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),id=238274858,target=900000061,search=900000062,filler=900000063;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true});
 const row=db.prepare('select * from datas where id=?').get(id);db.close();
 const bytes=row.setcode,setcodes=Array.from({length:bytes.length/2},(_,i)=>bytes[i*2]|bytes[i*2+1]<<8).filter(Boolean);
 const base={alias:0,setcodes:[],type:0x21,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const results=[];
 for(const valid of [false,true]){
  const logs=[],trace=[];
  const cards=new Map([[id,{...base,code:id,setcodes,type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],
   [target,{...base,code:target,setcodes:valid?[0x30]:[]}],[search,{...base,code:search,setcodes:[0x30]}],
   [filler,{...base,code:filler,type:17,attribute:1,race:1n}]]);
  const reader=name=>{
   if([`c${target}.lua`,`c${search}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(['c0.lua',`c${filler}.lua`].includes(name))return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},
   cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,equipped=false,searchStarted=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(id,L.HAND);add(target,L.MZONE);add(search,L.DECK);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(!valid){if(p.activates.some(c=>c.code===id))throw Error('Union equip offered on non-Vylon');done=true;break;}
     if(searchStarted){
      if(core.duelQueryCount(duel,0,L.HAND)!==1)throw Error('Vylon search failed');
      if(p.activates.some(c=>c.code===id))throw Error('Glome offered a second Union action in the same turn');
      done=true;break;
     }
     if(equipped){
      if(core.duelQueryCount(duel,0,L.SZONE)!==1)throw Error('Union did not equip');
      const index=p.activates.findIndex(c=>c.code===id);if(index<0)throw Error('Equipped search unavailable');
      searchStarted=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
     }else{
      const index=p.activates.findIndex(c=>c.code===id);if(index<0)throw Error('Hand equip unavailable');
      equipped=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
     }
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});
    else if(p.type===M.SELECT_PLACE){
     const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);if(sequence===undefined)throw Error('No free Spell zone');
     core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});
    }else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({valid,status:failure?'FAIL':'PASS',failure,logs,trace});console.log(`${failure?'FAIL':'PASS'} valid=${valid}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/vylon-glome-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
