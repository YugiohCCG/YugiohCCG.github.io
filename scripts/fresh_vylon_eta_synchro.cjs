'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),id=238274863,tuner=900000041,nontuner=900000042,equip=900000043,filler=900000044;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true});
 const row=db.prepare('select * from datas where id=?').get(id);db.close();
 const bytes=row.setcode,setcodes=bytes instanceof Uint8Array?Array.from({length:bytes.length/2},(_,i)=>bytes[i*2]|bytes[i*2+1]<<8).filter(Boolean):[Number(BigInt(bytes)&65535n)];
 const base={alias:0,setcodes:[],type:0x21,level:2,attribute:16,race:0x1000n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const data=new Map([[id,{...base,code:id,setcodes,type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],
  [tuner,{...base,code:tuner,type:0x1021,level:2}],[nontuner,{...base,code:nontuner,level:3}],
  [equip,{...base,code:equip,type:0x40002,setcodes:[0x30],level:0,attribute:0,race:0n,attack:0,defense:0}],
  [filler,{...base,code:filler,type:17,attribute:1,race:1n}]]);
 const trace=[],logs=[];
 const reader=name=>{
  if(name===`c${equip}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
  if([`c${tuner}.lua`,`c${nontuner}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';
  if(['c0.lua',`c${filler}.lua`].includes(name))return '';
  const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},
  cardReader:code=>{if(!data.has(code))throw Error('Missing card '+code);return data.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,summoned=false,accepted=false,done=false;
 try{
  for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
  const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
  add(tuner,L.MZONE);add(nontuner,L.MZONE);add(id,L.EXTRA);add(equip,L.DECK);
  for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
  core.startDuel(duel);
  for(let step=0;step<150&&!done;step++){
   const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
   if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
   if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
   const p=messages.at(-1);if(!p)throw Error('No prompt');
   if(p.type===M.SELECT_IDLECMD){
    if(summoned){
     if(!accepted||core.duelQueryCount(duel,0,L.HAND)!==1||core.duelQueryCount(duel,0,L.MZONE)!==1)throw Error('Synchro search did not resolve');
     done=true;break;
    }
    const index=p.special_summons.findIndex(c=>c.code===id);if(index<0)throw Error('Eta Synchro Summon unavailable');
    summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});
   }else if(p.type===M.SELECT_CHAIN){
    const index=p.selects.findIndex(c=>c.code===id);
    if(index>=0)accepted=true;
    core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});
   }else if(p.type===M.SELECT_EFFECTYN){accepted=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
   else if(p.type===M.SELECT_CARD){
    let selected=p.selects.map((c,i)=>[c.code,i]).filter(([code])=>code===tuner||code===nontuner).map(([,i])=>i);
    if(!selected.length)selected=[0];
    core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:selected.slice(0,p.max)});
   }else if(p.type===M.SELECT_SUM){core.duelSetResponse(duel,{type:R.SELECT_SUM,indicies:[0,1]});}
   else if(p.type===M.SELECT_PLACE){
    const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined)throw Error('No monster zone');
    core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});
   }else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
   else throw Error('Unhandled prompt '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
  }
  if(!done)throw Error('Step limit');
 }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/vylon-eta-synchro.json'),JSON.stringify({status:failure?'FAIL':'PASS',failure,logs,trace},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 console.log(failure?'FAIL '+failure:'PASS Vylon Eta Synchro Summon and Equip Spell search');if(failure)process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
