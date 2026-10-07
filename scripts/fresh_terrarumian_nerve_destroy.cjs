'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),nerve=284639720,spell=900000481,fodder=900000482,ally=900000483,target=900000484,filler=900000485;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(nerve);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[nerve,{...base,code:nerve,setcodes:[0xA122],type:Number(r.type),level:Number(r.level)&255,lscale:(Number(r.level)>>>24)&255,rscale:(Number(r.level)>>>16)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[spell,{...base,code:spell,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[fodder,{...base,code:fodder,setcodes:[0xA122],type:0x20002,level:0,attribute:0,race:0n,attack:0,defense:0}],[ally,{...base,code:ally,setcodes:[0xA122]}],[target,{...base,code:target,type:0x20002,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
 const spellScript='local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,284639720) Duel.Destroy(g,REASON_EFFECT) end) c:RegisterEffect(e) end';
 const results=[];
 for(const mode of ['normal','special','destroyed','no-target']){
  const trace=[],logs=[];
  const reader=name=>{if(name===`c${spell}.lua`)return spellScript;if([`c${fodder}.lua`,`c${ally}.lua`,`c${target}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,stage=0,triggered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:P.FACEUP_ATTACK});
   add(nerve,mode==='destroyed'?L.MZONE:L.HAND);if(mode==='destroyed')add(spell,L.HAND);if(mode==='special'){add(ally,L.MZONE);add(fodder,L.SZONE,0,1);}if(mode!=='no-target')add(target,L.SZONE,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<140&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if((mode==='normal'||mode==='no-target')&&stage===0){const index=p.summons.findIndex(c=>c.code===nerve);if(index<0)throw Error('Normal Summon unavailable');stage=1;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});}else if(mode==='destroyed'&&stage===0){const index=p.activates.findIndex(c=>c.code===spell);if(index<0)throw Error('Destroy Spell unavailable');stage=1;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else if(mode==='special'&&stage<2){const location=stage===0?L.HAND:L.SZONE,index=p.activates.findIndex(c=>c.code===nerve&&c.location===location);if(index<0)throw Error('Pendulum action unavailable at stage '+stage);stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{const z=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.SZONE}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.GRAVE});if(mode==='no-target'){if(triggered)throw Error('Trigger offered without Spell/Trap');}else if(!triggered||z.some(c=>c?.code===target)||!g.some(c=>c?.code===target))throw Error('Spell/Trap destruction failed');done=true;}}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==nerve||mode==='no-target')throw Error('Unexpected optional trigger');triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===target);if(index<0)index=p.selects.findIndex(c=>c.code===fodder);if(index<0)throw Error('Expected target unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No open zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({mode,status:failure?'FAIL':'PASS',failure,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${mode}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-nerve-destroy.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
