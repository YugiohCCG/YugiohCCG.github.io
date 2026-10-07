'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),cushion=Number(process.argv[2]||284639717),opponent=900000421,filler=900000422;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(cushion);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[cushion,{...base,code:cushion,setcodes:[0xA122],type:Number(r.type),level:Number(r.level),attribute:Number(r.attribute),race:BigInt(r.race),attack:900,defense:3000}],[opponent,{...base,code:opponent,attack:1000}],[filler,{...base,code:filler}]]);
 const logs=[],trace=[];
 const reader=name=>{if([`c${opponent}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,attacked=false,done=false;
 try{
  for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
  const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});
  add(cushion,L.MZONE,0,P.FACEUP_DEFENSE);add(opponent,L.MZONE,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
  core.startDuel(duel);
  for(let step=0;step<120&&!done;step++){
   const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
   if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
   if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
   const p=messages.at(-1);if(!p)throw Error('Missing prompt');
   if(p.type===M.SELECT_IDLECMD)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:p.player===1||attacked||!p.to_bp?A.TO_EP:A.TO_BP});
   else if(p.type===M.SELECT_BATTLECMD){if(!attacked){const index=p.attacks.findIndex(c=>c.code===cushion);if(index<0)throw Error('Face-up Defense Position attack unavailable');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}else{const own=core.duelQueryCount(duel,0,L.MZONE),enemy=core.duelQueryCount(duel,1,L.MZONE);if(own!==0||enemy!==1)throw Error(`ATK-based calculation mismatch: own=${own}, enemy=${enemy}`);done=true;}}
   else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===opponent);if(index<0)throw Error('Opponent not targetable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
   else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
   else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
   else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
  }
  if(!done)throw Error('Step limit');
 }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/terrarumian-${cushion}-defense-attack.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',cardId:cushion,testOnlyDefenseOverride:3000,actualDefense:Number(r.def),status:failure?'FAIL':'PASS',failure,attacked,trace,logs},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 console.log(`${failure?'FAIL':'PASS'} ${cushion} Defense Position attack uses ATK${failure?': '+failure:''}`);if(failure)process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
