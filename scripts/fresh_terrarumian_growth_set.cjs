'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),growth=284636589,trap=900000391,fodder=900000392,pendulum=900000393,filler=900000394;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(growth);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[growth,{...base,code:growth,setcodes:[0xA122],type:Number(r.type),level:0,attribute:0,race:0n,attack:0,defense:0}],[trap,{...base,code:trap,setcodes:[0xA122],type:4,level:0,attribute:0,race:0n,attack:0,defense:0}],[fodder,{...base,code:fodder,setcodes:[0xA122]}],[pendulum,{...base,code:pendulum,setcodes:[0xA122],type:0x1000021}],[filler,{...base,code:filler}]]);
 const results=[];
 for(const test of [{target:false,secondCopy:false},{target:true,secondCopy:false},{target:true,secondCopy:true}]){
  const trace=[],logs=[];
  const reader=name=>{if([`c${trap}.lua`,`c${fodder}.lua`,`c${pendulum}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:P.FACEUP_ATTACK});
   add(growth,L.GRAVE);if(test.target)add(trap,L.GRAVE);if(test.secondCopy){add(growth,L.HAND);add(fodder,L.HAND);add(pendulum,L.DECK);}for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===growth);
     if(!test.target){if(index>=0)throw Error('GY Set offered without Terrarumian Spell/Trap');done=true;break;}
     if(!activated){if(index<0)throw Error('GY Set unavailable with target');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else{const z=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}).filter(c=>c?.code===trap),b=core.duelQueryCount(duel,0,L.REMOVED);if(z.length!==1||b!==1)throw Error(`GY Set failed: Set trap=${z.length} banished=${b}`);if(test.secondCopy&&index>=0)throw Error('Hand activation offered after GY effect same turn');done=true;break;}
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===trap);if(index<0)throw Error('No Trap target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);if(seq===undefined)throw Error('No SZONE');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-growth-set.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
