'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),nether=238272436,under=900000661,other=900000662,spell=900000663,filler=900000664;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(nether);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const eligible of [true,false]){
  const trace=[],logs=[],cards=new Map([[nether,{...base,code:nether,setcodes:[0xA110,0xA111],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[under,{...base,code:under,setcodes:[0xA110,0xA111]}],[other,{...base,code:other}],[spell,{...base,code:spell,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
  const reader=name=>{if(name===`c${spell}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${nether}) local tc=g:GetFirst() if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end end) c:RegisterEffect(e) end`;if([`c${under}.lua`,`c${other}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence:0,position:P.FACEUP_ATTACK});add(nether,L.HAND);add(spell,L.HAND);add(eligible?under:other,L.DECK);add(filler,L.GRAVE);for(const player of [0,1])for(let i=0;i<5;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});
   core.startDuel(duel);
   for(let step=0;step<110&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===spell);if(index<0)throw Error('Summon Spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE}),x=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.REMOVED});if(!m.some(c=>c?.code===nether)||triggered!==eligible||eligible&&(!g.some(c=>c?.code===under)||!x.some(c=>c?.code===filler)))throw Error(`Send/banish mismatch triggered=${triggered}`);done=true;}}
    else if(p.type===M.SELECT_CHAIN){const index=p.player===0?p.selects.findIndex(c=>c.code===nether):-1;if(index>=0){if(!eligible)throw Error('Effect offered without Deck target');triggered=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN){const yes=p.code===nether;if(yes){if(!eligible)throw Error('Effect offered without Deck target');triggered=true;}core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes});}
    else if(p.type===M.SELECT_CARD){const code=p.selects.some(c=>c.location===L.DECK)?under:filler,index=p.selects.findIndex(c=>c.code===code);if(index<0)throw Error('Send/banish card unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({eligible,status:failure?'FAIL':'PASS',failure,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} eligible=${eligible}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/underroot-nether-send.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
