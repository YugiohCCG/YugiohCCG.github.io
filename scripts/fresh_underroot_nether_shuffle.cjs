'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const officialTraps=process.argv.includes('--official-traps');
 const core=await mod.default({sync:true,print(){},printErr(){}}),nether=238272436,fusion=900000671,synchro=900000672,root1=officialTraps?11110218:900000673,root2=officialTraps?63086455:900000674,other=900000675,filler=900000676;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(nether);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const typed of [true,false]){
  const trace=[],logs=[],cards=new Map([[nether,{...base,code:nether,setcodes:[0xA110,0xA111],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[fusion,{...base,code:fusion,type:0x21|0x40}],[synchro,{...base,code:synchro,type:0x21|0x2000}],[root1,{...base,code:root1,setcodes:[0xA110]}],[root2,{...base,code:root2,setcodes:[0xA110]}],[other,{...base,code:other}],[filler,{...base,code:filler}]]);
  const reader=name=>{if([`c${fusion}.lua`,`c${synchro}.lua`,`c${root1}.lua`,`c${root2}.lua`,`c${other}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  if(officialTraps)for(const code of [root1,root2])cards.set(code,{...base,code,setcodes:[],type:4,level:0,attribute:0,race:0n,attack:0,defense:0});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,sequence=0)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence,position:P.FACEUP_ATTACK});add(nether,L.GRAVE);add(root1,L.GRAVE);add(root2,L.REMOVED);add(other,L.GRAVE);if(typed){add(fusion,L.MZONE);add(synchro,L.MZONE,1);}else add(other,L.MZONE);for(const player of [0,1])for(let i=0;i<5;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});
   core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===nether);if(!activated&&typed){if(index<0)throw Error('Shuffle unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{if(!typed&&index>=0)throw Error('Shuffle offered with no Extra Deck types');const d=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.DECK}),x=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.REMOVED}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE});if(typed&&(!d.some(c=>c?.code===root1)||!d.some(c=>c?.code===root2)||!x.some(c=>c?.code===nether)||!g.some(c=>c?.code===other)))throw Error('Shuffle/cost mismatch');done=true;}}
    else if(p.type===M.SELECT_CARD){const i=p.selects.findIndex(c=>c.code===root1),j=p.selects.findIndex(c=>c.code===root2);if(i<0||j<0||p.max<2)throw Error('Two rroot choices not offered');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[i,j]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({typed,status:failure?'FAIL':'PASS',failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} typed=${typed}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/underroot-nether-shuffle${officialTraps?'-official-traps':''}.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
