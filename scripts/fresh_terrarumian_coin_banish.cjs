'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),coin=284639718,spell=900000431,ally=900000432,gy=900000433,hand=900000434,filler=900000435;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(coin);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[coin,{...base,code:coin,setcodes:[0xA122],type:Number(r.type),level:Number(r.level),attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[spell,{...base,code:spell,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[ally,{...base,code:ally,setcodes:[0xA122],type:0x1000021}],[gy,{...base,code:gy}],[hand,{...base,code:hand}],[filler,{...base,code:filler}]]);
 const destroy='local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,284639718) Duel.Destroy(g,REASON_EFFECT) end) c:RegisterEffect(e) end';
 const results=[];
 for(const handRoute of [false,true]){
  const trace=[],logs=[];
  const reader=name=>{if(name===`c${spell}.lua`)return destroy;if([`c${ally}.lua`,`c${gy}.lua`,`c${hand}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggered=false,observed=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position});
   add(coin,L.MZONE);add(spell,L.HAND);add(hand,L.HAND,1);if(handRoute){add(ally,L.MZONE,0,1,P.FACEUP_DEFENSE);add(ally,L.MZONE,0,2,P.FACEUP_DEFENSE);}add(gy,L.GRAVE,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<130&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===spell);if(index<0)throw Error('Test destroy spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else if(!observed){const removed=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.REMOVED});const expected=handRoute?hand:gy;if(!removed.some(c=>c?.code===expected))throw Error('Wrong card banished');if(handRoute&&core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.HAND}).some(c=>c?.code===hand))throw Error('Hand card not banished');observed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}else if(p.player===1){if(handRoute&&!core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.HAND}).some(c=>c?.code===hand))throw Error('Hand card did not return at End Phase');done=true;}else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}
    else if(p.type===M.SELECT_EFFECTYN){triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===gy);if(index<0)throw Error('Expected GY card absent');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO){if(!handRoute)throw Error('Hand option offered without two defense-position Terrarumians');core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);if(seq===undefined)throw Error('No Spell zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence:seq}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done||!triggered||!observed)throw Error('Incomplete banish test');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({handRoute,status:failure?'FAIL':'PASS',failure,triggered,observed,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${handRoute?'hand until End Phase':'opponent GY'}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-coin-banish.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
