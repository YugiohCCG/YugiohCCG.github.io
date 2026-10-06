'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),cushion=Number(process.argv[2]||284639717),fodder=900000401,deckPend=900000402,own=900000403,opp=900000404,filler=900000405;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(cushion);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[cushion,{...base,code:cushion,setcodes:[0xA122],type:Number(r.type),level:Number(r.level),attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[fodder,{...base,code:fodder,setcodes:[0xA122],type:0x20002,level:0,attribute:0,race:0n,attack:0,defense:0}],[deckPend,{...base,code:deckPend,setcodes:[0xA122],type:0x1000021}],[own,{...base,code:own,setcodes:[0xA122]}],[opp,{...base,code:opp}],[filler,{...base,code:filler}]]);
 const results=[];
 for(const test of cushion===284639717?[{own:false,opp:false,allowed:true},{own:true,opp:false,allowed:false},{own:true,opp:true,allowed:true}]:[{own:false,opp:false,allowed:false},{own:true,opp:false,allowed:true}]){
  const trace=[],logs=[];
  const reader=name=>{if([`c${fodder}.lua`,`c${deckPend}.lua`,`c${own}.lua`,`c${opp}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:P.FACEUP_ATTACK});
   add(cushion,L.HAND,0,0);add(fodder,L.SZONE,0,1);add(deckPend,L.DECK);if(test.own)add(own,L.MZONE);if(test.opp)add(opp,L.MZONE,1);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(!placed){const handIndex=p.activates.findIndex(c=>c.code===cushion&&c.location===L.HAND);if(handIndex<0)throw Error('Cannot activate Pendulum card from hand');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:handIndex});continue;}const index=p.activates.findIndex(c=>c.code===cushion&&c.location===L.SZONE);
     if(!test.allowed){if(index>=0)throw Error('Pendulum effect offered with own monster and no opponent monster');done=true;break;}
     if(!activated){if(index<0)throw Error('Pendulum effect unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else{const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),s=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}),g=core.duelQueryCount(duel,0,L.GRAVE);if(!m.some(c=>c?.code===cushion)||!s.some(c=>c?.code===deckPend)||g!==1)throw Error(`Destroy/Summon/place failed: M=${JSON.stringify(m)} S=${JSON.stringify(s)} G=${g}`);done=true;break;}
    }else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===fodder);if(index<0)index=p.selects.findIndex(c=>c.code===deckPend);if(index<0)throw Error('No expected selectable card');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/terrarumian-${cushion}-pendulum.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',cardId:cushion,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
