'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),fern=284639721,spell=900000491,trap=900000492,filler=900000493;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(fern);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const results=[];
 for(const test of [{terrarumian:true,accept:true},{terrarumian:true,accept:false},{terrarumian:false,accept:true}]){
  const trace=[],logs=[],cards=new Map([[fern,{...base,code:fern,setcodes:[0xA122],type:Number(r.type),level:Number(r.level)&255,lscale:(Number(r.level)>>>24)&255,rscale:(Number(r.level)>>>16)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[spell,{...base,code:spell,setcodes:test.terrarumian?[0xA122]:[],type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[trap,{...base,code:trap,type:4,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
  const reader=name=>{if(name===`c${spell}.lua`)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) c:RegisterEffect(e) end';if(name===`c${trap}.lua`)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Damage(1-tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) end';if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${fern}.lua`){/* Public core uses chain-info 1/2; Omega's local constants use 2/4. */source=source.replace('CHAININFO_TRIGGERING_EFFECT','1').replace('CHAININFO_TRIGGERING_PLAYER','2');}return source};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,ready=false,activated=false,chained=false,offered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});
   add(fern,L.HAND);add(spell,L.HAND);add(trap,L.SZONE,1,P.FACEDOWN);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<140&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(!placed){const index=p.activates.findIndex(c=>c.code===fern&&c.location===L.HAND);if(index<0)throw Error('Cannot place Staghorn Fern');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else if(!activated){ready=true;const index=p.activates.findIndex(c=>c.code===spell);if(index<0)throw Error('Own Spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{const z=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}).some(c=>c?.code===fern);const expected=test.terrarumian&&test.accept;if(!chained||offered!==test.terrarumian||z===expected)throw Error(`Negate/self-destroy mismatch chained=${chained} offered=${offered} fernInPZone=${z}`);const damage=trace.filter(m=>m.type===M.DAMAGE&&m.player===0).reduce((sum,m)=>sum+m.amount,0);if(damage!==(expected?0:1000))throw Error(`Response damage mismatch: ${damage}`);done=true;}}
    else if(p.type===M.SELECT_CHAIN){const index=ready&&!chained&&p.player===1?p.selects.findIndex(c=>c.code===trap):-1;if(index>=0)chained=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN||p.type===M.SELECT_YESNO){offered=true;if(!test.terrarumian)throw Error('Negation offered against non-Terrarumian');core.duelSetResponse(duel,{type:p.type===M.SELECT_EFFECTYN?R.SELECT_EFFECTYN:R.SELECT_YESNO,yes:test.accept});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);if(seq===undefined)throw Error('No Pendulum zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.SZONE,sequence:seq}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,offered,chained,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-staghorn-chain.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
