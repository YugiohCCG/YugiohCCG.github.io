'use strict';
// Engine tests for Vylon's Aid, with staged database metadata and real targets.
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite'),{createHash}=require('node:crypto');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),id=238274861,light1=900000051,light2=900000052,dark=900000053,filler=900000054;
 const dbpath=path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),db=new DatabaseSync(dbpath,{readOnly:true});
 const row=db.prepare('select * from datas where id=?').get(id);db.close();
 const bytes=row.setcode,setcodes=bytes instanceof Uint8Array?Array.from({length:bytes.length/2},(_,i)=>bytes[i*2]|bytes[i*2+1]<<8).filter(Boolean):[Number(BigInt(bytes)&65535n)];
 if(!setcodes.includes(0x53))throw Error('Candidate DB lacks printed Constellar treatment');
 const base={alias:0,setcodes:[],type:0x21,level:4,attribute:16,race:0x1000n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const results=[];
 for(const twoLight of [false,true]){
  const logs=[],trace=[];
  const data=new Map([[id,{...base,code:id,setcodes,type:Number(row.type),level:0,attribute:0,race:0n,attack:0,defense:0}],
   [light1,{...base,code:light1}],[light2,{...base,code:light2}],[dark,{...base,code:dark,attribute:32}],
   [filler,{...base,code:filler,type:17,attribute:1,race:1n}]]);
  const reader=name=>{
   if([`c${light1}.lua`,`c${light2}.lua`,`c${dark}.lua`].includes(name))return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK)
 e:SetValue(1000) c:RegisterEffect(e)
end`;
   if(['c0.lua',`c${filler}.lua`].includes(name))return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},
   cardReader:code=>{if(!data.has(code))throw Error('Missing card '+code);return data.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,spellPlaced=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(id,L.HAND);add(light1,L.GRAVE);add(twoLight?light2:dark,L.GRAVE);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(activated){
      if(core.duelQueryCount(duel,0,L.MZONE)!==2)throw Error('Two LIGHT targets were not Summoned');
      const monsters=core.duelQueryLocation(duel,{team:0,location:L.MZONE,flags:mod.OcgQueryFlags.CODE|mod.OcgQueryFlags.ATTACK});
      if(monsters.filter(c=>c?.code===light1||c?.code===light2).some(c=>c.attack!==1000))throw Error('Summoned monster effects were not negated');
      done=true;break;
     }
     const index=p.activates.findIndex(c=>c.code===id);
     if((index>=0)!==twoLight)throw Error('Wrong activation availability for LIGHT count');
     if(index<0){done=true;break;}
     activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0,1]});
    else if(p.type===M.SELECT_PLACE){
     const location=spellPlaced?L.MZONE:L.SZONE;
     const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<((location===L.SZONE?8:0)+i)))===0);
     if(sequence===undefined)throw Error('No free zone for requested placement');
     spellPlaced=true;
     core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});
    }else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({twoLight,status:failure?'FAIL':'PASS',failure,logs,trace});console.log(`${failure?'FAIL':'PASS'} twoLight=${twoLight}${failure?': '+failure:''}`);
 }
 const hash=file=>createHash('sha256').update(fs.readFileSync(file)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/vylon-aid-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',script_sha256:hash(path.join(CUSTOM,`c${id}.lua`)),database_sha256:hash(dbpath),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
