'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),trumpet=284639724,fodder=900000571,ally=900000572,extra=900000573,prep=900000574,filler=900000575;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(trumpet);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[trumpet,{...base,code:trumpet,setcodes:[0xA122],type:Number(r.type),level:Number(r.level)&255,lscale:(Number(r.level)>>>24)&255,rscale:(Number(r.level)>>>16)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[fodder,{...base,code:fodder,setcodes:[0xA122],type:0x20002,level:0,attribute:0,race:0n,attack:0,defense:0}],[ally,{...base,code:ally,setcodes:[0xA122]}],[extra,{...base,code:extra,setcodes:[0xA122],type:0x1000021}],[prep,{...base,code:prep,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
 const results=[];
 for(const test of [{own:false,extra:false},{own:true,extra:false},{own:true,extra:true}]){
  const trace=[],logs=[];
  const reader=name=>{if(name===`c${prep}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${extra}) Duel.Destroy(g,REASON_EFFECT) end) c:RegisterEffect(e) end`;if([`c${fodder}.lua`,`c${ally}.lua`,`c${extra}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,prepared=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,seq=0)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence:seq,position:P.FACEUP_ATTACK});
   add(trumpet,L.HAND);add(fodder,L.SZONE,1);if(test.own)add(ally,L.MZONE);if(test.extra){add(extra,L.MZONE,1);add(prep,L.HAND);}for(const player of [0,1])for(let i=0;i<5;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});
   core.startDuel(duel);
   for(let step=0;step<140&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(!placed){const index=p.activates.findIndex(c=>c.code===trumpet&&c.location===L.HAND);if(index<0)throw Error('Cannot place Trumpet');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(test.extra&&!prepared){const index=p.activates.findIndex(c=>c.code===prep);if(index<0)throw Error('Face-up Extra preparation unavailable');prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const index=p.activates.findIndex(c=>c.code===trumpet&&c.location===L.SZONE);
     if(!activated){if(!test.own){if(index>=0)throw Error('Pendulum action offered without own Terrarumian');done=true;break;}if(index<0)throw Error('Pendulum action unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else{const m=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.MZONE}),t=m.find(c=>c?.code===trumpet),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE});if(!t||t.position!==P.FACEUP_DEFENSE||!g.some(c=>c?.code===fodder)||m.some(c=>c?.code===extra)!==test.extra)throw Error('Pendulum Summon/optional Extra Summon mismatch');done=true;}}
    else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===fodder);if(index<0)index=p.selects.findIndex(c=>c.code===extra);if(index<0)throw Error('Expected card unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_DEFENSE});
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-trumpet-pendulum.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
