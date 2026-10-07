'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const afterroot=process.argv.includes('--afterroot');
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=afterroot?238272440:238272439,trap=afterroot?85698115:63086455,helper=900000751,filler=900000752;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const full of [false,true]){
  const logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0xA110,0xA112],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[trap,{...base,code:trap,setcodes:[],type:4,level:0}],[helper,{...base,code:helper}],[filler,{...base,code:filler,type:4,level:0}]]);
  const reader=name=>{
   if(name===`c${helper}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.SendtoGrave(e:GetHandler(),REASON_EFFECT) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}) Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) end`;
   // Diagnostic Trap: tests same-turn activation, not the official Trap's effect.
   if(name===`c${trap}.lua`)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Damage(tp,555,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(name==='c0.lua')return '';
   if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);
   const source=fs.readFileSync(file,'utf8');
   // Isolate the Set effect from the unsupported public-core IsCanOverlay API.
   return name===`c${boss}.lua`?source.replace('c:RegisterEffect(e2)','--other Quick Effect omitted only in this diagnostic fixture').replace('aux.AddXyzProcedure(c,nil,1,2)','--Xyz procedure omitted; fixture uses an effect Summon').replace('aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsLevel,3),aux.NonTuner(nil),1,1)','--Synchro procedure omitted; fixture uses an effect Summon'):source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,started=false,triggered=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.EXTRA);add(helper,L.MZONE);add(trap,L.DECK);if(full)for(let i=0;i<5;i++)add(filler,L.SZONE,0,i,P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!started){const index=p.activates.findIndex(c=>c.code===helper);if(index<0)throw Error('Helper unavailable');started=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else if(!full&&!activated){const z=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.SZONE});if(!triggered||!z.some(c=>c?.code===trap&&(c.position&P.FACEDOWN_DEFENSE)!==0))throw Error('Trap not Set');const index=p.activates.findIndex(c=>c.code===trap);if(index<0)throw Error('Set Trap unavailable this turn');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{if(full&&triggered)throw Error('Set effect offered with full zones');if(!full&&!trace.some(t=>t.type===M.DAMAGE))throw Error('Trap did not resolve');done=true;}}
    else if(p.type===M.SELECT_EFFECTYN){if(full&&p.code===boss)throw Error('Set trigger offered with full zones');triggered=p.code===boss;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:triggered});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);if(index>=0&&full)throw Error('Set trigger offered with full zones');if(index>=0)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===trap);if(index<0)throw Error('Official Trap not selectable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(sequence===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({full,failure,triggered,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} full=${full}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/underroot-${afterroot?'afterroot':'overroot'}-set.json`),JSON.stringify({engine:'public OCGCore; other Quick Effect and Extra Deck procedure registration omitted; diagnostic Trap activation',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
