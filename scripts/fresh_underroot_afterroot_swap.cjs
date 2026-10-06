'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238272440,field=900000761,grave=900000762,filler=900000763,response=900000764;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 const tests=[{accept:true,hasGrave:true,extra:true},{accept:false,hasGrave:true,extra:true},{accept:true,hasGrave:false,extra:true},{accept:true,hasGrave:true,extra:false},{accept:true,hasGrave:true,extra:true,loss:'field'},{accept:true,hasGrave:true,extra:true,loss:'grave'},{accept:true,hasGrave:true,extra:true,full:true}];
 for(const type of [0x2000,0x800000,0x4000000])tests.push({accept:true,hasGrave:true,extra:true,fieldType:type,graveType:type});
 tests.push({accept:true,hasGrave:true,extra:true,fieldType:0x2000,graveType:0x800000},{accept:true,hasGrave:true,extra:true,graveType:0},{accept:true,hasGrave:true,extra:true,improper:true});
 for(const test of tests){
  const {accept,hasGrave,extra,loss,full,improper,fieldType=0x40,graveType=0x40}=test,legal=hasGrave&&extra&&graveType!==0&&!improper,logs=[],trace=[];
  const cards=new Map([[boss,{...base,code:boss,setcodes:[0xA110,0xA113],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[field,{...base,code:field,type:33|(extra?0x40:0)}],[grave,{...base,code:grave,type:33|0x40}],[filler,{...base,code:filler}]]);
  const extraData=(code,type)=>({...base,code,type:33|type,level:type===0x4000000?1:3,link_marker:type===0x4000000?1:0});
  cards.set(field,extraData(field,extra?fieldType:0));cards.set(grave,extraData(grave,graveType));
  const reader=name=>{
   if(name===`c${response}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,${loss==='field'?'LOCATION_MZONE':'LOCATION_GRAVE'},0,nil,${loss==='field'?field:grave}) if '${loss}'=='field' then Duel.SendtoGrave(g,REASON_EFFECT) else Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end end) c:RegisterEffect(e) end`;
   if(name===`c${grave}.lua`)return `local s,id=GetID() function s.initial_effect(c) ${improper?'c:EnableReviveLimit()':''} local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetValue(700) c:RegisterEffect(e) end`;
   if([`c${field}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  cards.set(response,{...base,code:response,type:0x10002,level:0});
  let failure=null,activated=false,prompted=false,responded=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});add(boss,L.MZONE);add(field,L.MZONE,1);if(hasGrave)add(grave,L.GRAVE,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   if(loss)core.duelNewCard(duel,{team:1,duelist:0,code:response,controller:1,location:L.SZONE,sequence:0,position:P.FACEDOWN_DEFENSE});
   if(full)for(let sequence=1;sequence<5;sequence++)core.duelNewCard(duel,{team:1,duelist:0,code:filler,controller:1,location:L.MZONE,sequence,position:P.FACEUP_ATTACK});
   core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);
    if(loss&&activated&&p.type===M.SELECT_IDLECMD){
     if(!responded||prompted)throw Error('Target-loss chain did not suppress revival');
     const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location});
     if(loss==='field'){
      if(!query(L.GRAVE).some(c=>c?.code===field)||!query(L.GRAVE).some(c=>c?.code===grave)||query(L.REMOVED).some(c=>c?.code===field))throw Error('Missing field target should stop the entire swap');
     }else if(!query(L.REMOVED).some(c=>c?.code===field)||!query(L.EXTRA).some(c=>c?.code===grave))throw Error('Missing GY target should not stop first target banishment');
     done=true;continue;
    }
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132272440*16+1));if(legal&&!activated){if(index<0)throw Error('Swap unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{if(!legal&&index>=0)throw Error('Illegal swap offered');if(legal){const x=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.REMOVED}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.GRAVE}),m=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:1,location:L.MZONE});if(!x.some(c=>c?.code===field)||!prompted)throw Error('Banish/opponent choice failed');if(accept){const tc=m.find(c=>c?.code===grave);if(!tc||tc.attack!==300)throw Error('Revival/negation failed: '+JSON.stringify(tc));}else if(!g.some(c=>c?.code===grave))throw Error('Declined monster left GY');if(index>=0)throw Error('Swap offered again this turn');}done=true;}}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===field||c.code===grave);if(index<0)throw Error('Target missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN){const index=loss&&activated&&!responded&&p.player===1?p.selects.findIndex(c=>c.code===response):-1;if(index>=0)responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_YESNO){if(p.player!==1)throw Error('Wrong player chooses revival');prompted=true;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:accept});}
    else if(p.type===M.SELECT_PLACE){const relative=p.player===1?0:16,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(relative+i)))===0);if(sequence===undefined)throw Error('No opposing zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:1,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,prompted,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/underroot-afterroot-swap.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
