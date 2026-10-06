'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),meval=244165675,ids=[900000121,900000122,900000123],filler=900000124,opponent=900000125;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(meval);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[filler,{...base,code:filler}],[opponent,{...base,code:opponent,race:1n,attribute:8}],[meval,{...base,code:meval,type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}]]);
 const results=[];
 for(const valid of [false,true]){
  for(let i=0;i<3;i++)cards.set(ids[i],{...base,code:ids[i],race:BigInt(valid?[1,2,4][i]:[1,1,4][i]),attribute:valid?[1,2,4][i]:[1,1,4][i]});
  const trace=[],logs=[];
  const reader=name=>{
   if(name==='c0.lua'||name===`c${filler}.lua`||name===`c${opponent}.lua`||ids.some(id=>name===`c${id}.lua`))return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,controlActivated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(meval,L.HAND);add(ids[0],L.GRAVE);add(ids[1],L.GRAVE,1);add(ids[2],L.GRAVE);if(valid)add(opponent,L.MZONE,1);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<110&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(!valid){if(p.activates.some(c=>c.code===meval))throw Error('Offered without 3 distinct Type/Attribute pairs');done=true;break;}
     if(controlActivated){
      const q=core.duelQuery(duel,{flags:mod.OcgQueryFlags.CODE|mod.OcgQueryFlags.ATTACK,controller:0,location:L.MZONE,sequence:0,overlaySequence:0});
      if(q?.code!==meval||q.attack!==1500||core.duelQueryCount(duel,0,L.MZONE)!==2||core.duelQueryCount(duel,1,L.MZONE)!==0)throw Error('ATK reduction/control outcome wrong');
      done=true;break;
     }
     if(activated){
      if(core.duelQueryCount(duel,0,L.MZONE)!==1||core.duelQueryCount(duel,0,L.REMOVED)!==2||core.duelQueryCount(duel,1,L.REMOVED)!==1)throw Error('Banish/Summon failed');
      const q=core.duelQuery(duel,{flags:mod.OcgQueryFlags.CODE|mod.OcgQueryFlags.RACE|mod.OcgQueryFlags.ATTRIBUTE,controller:0,location:L.MZONE,sequence:0,overlaySequence:0});
      if(q?.code!==meval||Number(q.race)!==((Number(r.race)|7)>>>0)||q.attribute!==(Number(r.attribute)|7))throw Error('Banished Types/Attributes not gained: '+JSON.stringify(q,(_,v)=>typeof v==='bigint'?String(v):v));
      const index=p.activates.findIndex(c=>c.code===meval);if(index<0)throw Error('Control effect unavailable');controlActivated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
     }else{
      const index=p.activates.findIndex(c=>c.code===meval);if(index<0)throw Error('Hand Summon unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
     }
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:Array.from({length:p.min??3},(_,i)=>i)});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({valid,status:failure?'FAIL':'PASS',failure,activated,controlActivated,trace,logs});console.log(`${failure?'FAIL':'PASS'} triple-valid=${valid}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/mevalkagna-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
