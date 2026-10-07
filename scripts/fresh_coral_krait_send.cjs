'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),krait=284636662,other=900000271,target=900000272,filler=900000273;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(krait);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:2,race:64n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[krait,{...base,code:krait,setcodes:[0xf3c],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[other,{...base,code:other,setcodes:[0xf3c],type:0x41,level:8}],[target,{...base,code:target,attribute:16}],[filler,{...base,code:filler}]]);
 const results=[];
 for(const n of [0,1,2]){
  const trace=[],logs=[];
  const reader=name=>{if([`c${other}.lua`,`c${target}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activations=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(krait,L.MZONE);for(let i=0;i<n;i++)add(other,L.MZONE,0,i+1);for(let i=0;i<2;i++)add(target,L.MZONE,1,i);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(c=>c.code===krait);
     if(activations<n){if(index<0)throw Error(`Activation ${activations+1} unavailable with ${n} other Fusions`);activations++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else{if(index>=0)throw Error('Quick Effect exceeded dynamic per-turn cap');const m=core.duelQueryCount(duel,1,L.MZONE),g=core.duelQueryCount(duel,1,L.GRAVE);if(m!==2-n||g!==n)throw Error(`Target send mismatch: M=${m} G=${g}`);done=true;break;}
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target&&c.controller===1);if(index<0)throw Error('No opponent target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({otherFusions:n,status:failure?'FAIL':'PASS',failure,activations,trace,logs});console.log(`${failure?'FAIL':'PASS'} otherFusions=${n}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/coral-krait-send.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
