'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),gorg=284636663,sanctuary=284636665,aqua=900000201,banisher=900000202,filler=900000203;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),query=db.prepare('select * from datas where id=?');
 const base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const spell={...base,type:2,level:0,attribute:0,race:0n,attack:0,defense:0};
 const cards=new Map([[aqua,{...base,code:aqua,setcodes:[0x0f3c]}],[banisher,{...spell,code:banisher}],[filler,{...base,code:filler}]]);
 for(const code of [gorg,sanctuary]){const r=query.get(code),b=r.setcode;cards.set(code,{...base,code,setcodes:Array.from({length:b.length/2},(_,i)=>b[i*2]|b[i*2+1]<<8).filter(Boolean),type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)});}db.close();
 const banishScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(s.op) c:RegisterEffect(e) end function s.op(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${gorg}) Duel.Remove(g,POS_FACEUP,REASON_EFFECT) end`;
 const results=[];
 for(const haveAqua of [false,true]){
  const trace=[],logs=[];
  const reader=name=>{if(name===`c${banisher}.lua`)return banishScript;if(name==='c0.lua'||name===`c${aqua}.lua`||name===`c${filler}.lua`)return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(gorg,L.GRAVE);add(sanctuary,L.DECK);add(banisher,L.HAND);add(filler,L.HAND);if(haveAqua)add(aqua,L.MZONE);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<110&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(activated){const hand=core.duelQueryCount(duel,0,L.HAND),grave=core.duelQueryCount(duel,0,L.GRAVE),removed=core.duelQueryCount(duel,0,L.REMOVED);if(triggered!==haveAqua||hand!==(haveAqua?1:1)||grave!==(haveAqua?2:1)||removed!==1)throw Error(`Banish search/discard wrong: trigger=${triggered} hand=${hand} grave=${grave} removed=${removed}`);done=true;break;}
     const index=p.activates.findIndex(c=>c.code===banisher);if(index<0)throw Error('Test banisher unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===gorg);if(index>=0)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===gorg)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===sanctuary||c.code===filler);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);if(sequence===undefined)throw Error('No Spell zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({haveAqua,status:failure?'FAIL':'PASS',failure,activated,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} controls-Aquamarine=${haveAqua}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/gorgonia-banish.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; test-only banish effect',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
