'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),torus=238274860,glome=238274858,volt=238274859,spell=900000081,filler=900000082;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),query=db.prepare('select * from datas where id=?');
 const base={alias:0,setcodes:[],type:0x21,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[spell,{...base,code:spell,setcodes:[0x30],type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],
  [filler,{...base,code:filler,type:17,setcodes:[],attribute:1,race:1n}]]);
 for(const code of [torus,glome,volt]){
  const r=query.get(code),b=r.setcode;
  cards.set(code,{...base,code,setcodes:Array.from({length:b.length/2},(_,i)=>b[i*2]|b[i*2+1]<<8).filter(Boolean),type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)});
 }
 db.close();
 const results=[];
 for(const test of [{other:false,spell:true},{other:true,spell:false},{other:true,spell:true}]){
  const trace=[],logs=[];
  const reader=name=>{
   if(name===`c${spell}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   if(['c0.lua',`c${filler}.lua`].includes(name))return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},
   cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(torus,L.HAND);if(test.other)add(glome,L.HAND);add(volt,L.DECK);if(test.spell)add(spell,L.DECK);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<140&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(!test.other){if(p.activates.some(c=>c.code===torus))throw Error('Torus offered without Vylon to destroy');done=true;break;}
     if(activated){
      if(core.duelQueryCount(duel,0,L.MZONE)!==1||core.duelQueryCount(duel,0,L.GRAVE)!==(test.spell?2:1))throw Error('Destruction, discard or Special Summon failed');
      if(test.spell&&(!triggered||core.duelQueryCount(duel,0,L.HAND)!==1))throw Error('Search and discard failed');
      if(!test.spell&&triggered)throw Error('Search offered without Vylon Spell');
      done=true;break;
     }
     const index=p.activates.findIndex(c=>c.code===torus);if(index<0)throw Error('Torus hand effect unavailable');
     activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(p.type===M.SELECT_CHAIN){
     const index=p.selects.findIndex(c=>c.code===torus&&c.location===L.MZONE);
     if(index>=0)triggered=true;
     core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});
    }else if(p.type===M.SELECT_EFFECTYN){triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CARD){
     const desired=p.selects.findIndex(c=>c.code===glome||c.code===volt||c.code===spell);
     core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[desired>=0?desired:0]});
    }else if(p.type===M.SELECT_PLACE){
     const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined)throw Error('No monster zone');
     core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});
    }else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/vylon-torus-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
