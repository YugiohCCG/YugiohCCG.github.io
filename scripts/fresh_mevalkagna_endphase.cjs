'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),meval=244165675,defender=900000131,bystander=900000132,filler=900000133;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(meval);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[meval,{...base,code:meval,type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[defender,{...base,code:defender,attack:1000,defense:3000}],[bystander,{...base,code:bystander}],[filler,{...base,code:filler}]]);
 const trace=[],logs=[];
 const reader=name=>{if(['c0.lua',`c${defender}.lua`,`c${bystander}.lua`,`c${filler}.lua`].includes(name))return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,attacked=false,enteredEnd=false,done=false;
 try{
  for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
  const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
  add(meval,L.MZONE);add(bystander,L.MZONE,0,P.FACEUP_ATTACK,1);add(defender,L.MZONE,1,P.FACEUP_DEFENSE);
  for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
  core.startDuel(duel);
  for(let step=0;step<160&&!done;step++){
   const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
   if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
   if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
   const p=messages.at(-1);if(!p)throw Error('Missing prompt');
   if(p.type===M.SELECT_IDLECMD){
    if(p.player===1&&attacked){const own=core.duelQueryCount(duel,0,L.MZONE),other=core.duelQueryCount(duel,1,L.MZONE);if(!enteredEnd||own!==1||other!==0)throw Error(`End Phase battle destruction wrong: own=${own} opponent=${other}`);done=true;break;}
    core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:p.player===1||attacked||!p.to_bp?A.TO_EP:A.TO_BP});
   }else if(p.type===M.SELECT_BATTLECMD){
    if(!attacked){const index=p.attacks.findIndex(c=>c.code===meval);if(index<0)throw Error('Mevalkagna cannot attack');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}
    else core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.TO_EP,index:null});
   }else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});
   else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
   else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
   else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
   else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   if(trace.some(m=>m.type===M.NEW_PHASE&&m.phase===mod.OcgPhase.END))enteredEnd=true;
  }
  if(!done)throw Error('Step limit');
 }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/mevalkagna-endphase.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',status:failure?'FAIL':'PASS',failure,attacked,enteredEnd,trace,logs},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 console.log(`${failure?'FAIL':'PASS'} Mevalkagna End Phase destruction${failure?': '+failure:''}`);if(failure)process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
