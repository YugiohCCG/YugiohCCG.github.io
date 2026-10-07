'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),blossom=238272435,target=900000711,replacement=900000712,filler=900000713;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(blossom);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{rroot:false,match:true,accept:true},{rroot:true,match:true,accept:true},{rroot:false,match:false,accept:true},{rroot:false,match:true,accept:false}]){
  const {rroot,match,accept}=test;
  const trace=[],logs=[],cards=new Map([[blossom,{...base,code:blossom,setcodes:[0xA110,0xA111],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[target,{...base,code:target,type:0x21|0x40,level:4,attack:1000,defense:1000}],[replacement,{...base,code:replacement,setcodes:rroot?[0xA110]:[],type:0x21|0x40,level:match?4:5,attack:1000,defense:1000}],[filler,{...base,code:filler}]]);
  const reader=name=>{if(name===`c${replacement}.lua`)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e:SetCode(EVENT_SPSUMMON_SUCCESS) e:SetOperation(function(e,tp) Duel.Recover(tp,500,REASON_EFFECT) end) c:RegisterEffect(e) end';if([`c${target}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});add(blossom,L.HAND);add(target,L.MZONE,1);add(replacement,L.EXTRA,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<115&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===blossom);if(index<0)throw Error('Swap Quick Effect unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.MZONE}),ex=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.EXTRA}),gain=trace.filter(x=>x.type===M.RECOVER&&x.player===1).reduce((n,x)=>n+x.amount,0);if(m.some(c=>c?.code===replacement)!==(match&&accept)||!ex.some(c=>c?.code===target)||gain!==(rroot&&match&&accept?500:0))throw Error(`Swap/negation mismatch recover=${gain}`);done=true;}}
    else if(p.type===M.SELECT_CHAIN){const index=p.player===1?p.selects.findIndex(c=>c.code===replacement):-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===replacement});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:accept});
    else if(p.type===M.SELECT_CARD){const code=p.selects.some(c=>c.code===target)?target:replacement,index=p.selects.findIndex(c=>c.code===code);if(index<0)throw Error('Swap card unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(seq===undefined)throw Error('No opponent zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:1,location:L.MZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/underroot-blossom-swap.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
