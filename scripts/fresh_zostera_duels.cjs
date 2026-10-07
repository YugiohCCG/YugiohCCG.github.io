'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),zostera=284636661,discard=900000221,send=900000222,filler=900000223;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(zostera);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[zostera,{...base,code:zostera,setcodes:[0x0f3c],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[discard,{...base,code:discard,setcodes:[0x0f3c]}],[send,{...base,code:send,setcodes:[0x0f3c],level:3}],[filler,{...base,code:filler}]]);
 const results=[];
 for(const test of [{discard:false,send:false},{discard:true,send:false},{discard:true,send:true}]){
  const trace=[],logs=[];
  const reader=name=>{if([`c${discard}.lua`,`c${send}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,set=false,activated=false,quickActivated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence:0,position:P.FACEUP_ATTACK});
   add(zostera,L.HAND);if(test.discard)add(discard,L.HAND);if(test.send)add(send,L.DECK);
   for(const player of [0,1])for(let i=0;i<5;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});
   core.startDuel(duel);
   for(let step=0;step<140&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(!set){const index=p.spell_sets.findIndex(c=>c.code===zostera);if(index<0)throw Error('Cannot Set Zostera');set=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPELL_SET,index});}
     else if(!test.discard){if(p.activates.some(c=>c.code===zostera))throw Error('Same-turn activation offered without discard');done=true;break;}
     else if(!activated){const index=p.activates.findIndex(c=>c.code===zostera);if(index<0)throw Error('Same-turn activation unavailable with discard');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else {
      const m=core.duelQueryCount(duel,0,L.MZONE),g=core.duelQueryCount(duel,0,L.GRAVE),b=core.duelQueryCount(duel,0,L.REMOVED);
      if(m!==1||g!==(quickActivated?0:1)||b!==(test.send||quickActivated?1:0))throw Error(`Trap-Monster/send/banish wrong: M=${m} G=${g} B=${b}`);
      const all=core.duelQueryLocation(duel,{flags:mod.OcgQueryFlags.CODE|mod.OcgQueryFlags.TYPE|mod.OcgQueryFlags.LEVEL|mod.OcgQueryFlags.RACE|mod.OcgQueryFlags.ATTRIBUTE|mod.OcgQueryFlags.ATTACK|mod.OcgQueryFlags.DEFENSE,controller:0,location:L.MZONE});
      const q=all.find(card=>card?.attack===500);
      if(!q||Number(q.race)!==64||q.attribute!==2||q.defense!==2300)throw Error('Trap-Monster combat stats wrong: '+JSON.stringify(all,(_,v)=>typeof v==='bigint'?String(v):v));
      if(!test.send&&!quickActivated){const index=p.activates.findIndex(c=>c.code===zostera&&c.location===L.MZONE);if(index<0)throw Error('Quick banish unavailable');quickActivated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
      else {done=true;break;}
     }
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===send);if(index<0)index=p.selects.findIndex(c=>c.code===discard);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(seq===undefined){location=L.SZONE;seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,set,activated,quickActivated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/zostera-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
