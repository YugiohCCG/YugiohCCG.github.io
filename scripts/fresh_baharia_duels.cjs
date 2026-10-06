'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244168521,dino=900000151,material=900000152,other=900000153,adj=900000154,filler=900000155;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,{...base,code:boss,type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:0,link_marker:Number(r.def)}],[dino,{...base,code:dino,race:65536n,attribute:4}],[material,{...base,code:material,race:65536n,attribute:4}],[other,{...base,code:other}],[adj,{...base,code:adj}],[filler,{...base,code:filler}]]);
 const results=[];
 for(const valid of [false,true]){
  const trace=[],logs=[];
  const reader=name=>{if(['c0.lua',`c${dino}.lua`,`c${material}.lua`,`c${other}.lua`,`c${adj}.lua`,`c${filler}.lua`].includes(name))return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const cardReader=code=>{if(!cards.has(code))throw Error('Missing card '+code);return code===material&&!valid?{...cards.get(code),race:0x20n,attribute:16}:cards.get(code)};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader,scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,summoned=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.EXTRA);add(material,L.MZONE,0,0);for(let i=1;i<4;i++)add(other,L.MZONE,0,i);add(dino,L.GRAVE);add(adj,L.MZONE,1,1);add(adj,L.MZONE,1,3);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(!valid){if(p.special_summons.some(c=>c.code===boss))throw Error('Link offered without FIRE/Dinosaur');done=true;break;}
     if(summoned){if(core.duelQueryCount(duel,0,L.MZONE)!==1||core.duelQueryCount(duel,1,L.MZONE)!==0||core.duelQueryCount(duel,1,L.GRAVE)!==2)throw Error('Adjacent destruction failed');done=true;break;}
     const index=p.special_summons.findIndex(c=>c.code===boss);if(index<0)throw Error('Link Summon unavailable');summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===dino);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});}
    else if(p.type===M.SELECT_PLACE){const isOwn=p.player===0,offset=isOwn&&summoned&&core.duelQueryCount(duel,0,L.MZONE)>0?0:0;const seq=isOwn?[5,6,0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0):[2,0,1,3,4].find(i=>(p.field_mask&(1<<(16+i)))===0);if(seq===undefined)throw Error('No place');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:isOwn?0:1,location:L.MZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({valid,status:failure?'FAIL':'PASS',failure,summoned,trace,logs});console.log(`${failure?'FAIL':'PASS'} valid-material=${valid}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/baharia-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
