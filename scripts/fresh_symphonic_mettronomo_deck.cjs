'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273771,first=900000791,second=900000792,filler=900000793,spirit=59822133,response=900000794;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{levels:[2,3],tribute:5,occupied:0,legal:true},{levels:[2,2],tribute:4,occupied:0,duplicate:true,legal:false},{levels:[2,2],tribute:5,occupied:0,legal:false},{levels:[2,3],tribute:5,occupied:4,legal:false},{levels:[5],tribute:5,occupied:4,legal:true},{levels:[2,3],tribute:5,occupied:0,oneAtATime:true,legal:false},{levels:[5],tribute:5,occupied:0,oneAtATime:true,legal:true},{levels:[2,4],tribute:5,occupied:0,boosted:true,legal:true},{levels:[2,3],tribute:5,occupied:0,boosted:true,legal:false},{levels:[2,3],tribute:5,occupied:0,chainRestriction:true,legal:true},{levels:[5],tribute:5,occupied:0,chainRestriction:true,legal:true}]){
  const logs=[],trace=[],codes=test.levels.map((_,i)=>test.duplicate?first:i?second:first),cards=new Map([[boss,{...base,code:boss,setcodes:[0x1066],type:Number(r.type),level:test.tribute,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[filler,{...base,code:filler}]]);
  codes.forEach((code,i)=>cards.set(code,{...base,code,setcodes:[0x1066],level:test.levels[i]}));
  cards.set(spirit,{...base,code:spirit,type:0x2021,level:9,race:8192n,attribute:16,attack:3000,defense:2500});
  cards.set(response,{...base,code:response,type:0x10002,level:0});
  const reader=name=>{if(test.boosted&&name===`c${filler}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_UPDATE_LEVEL) e:SetRange(LOCATION_MZONE) e:SetTargetRange(LOCATION_MZONE,0) e:SetTarget(function(e,c) return c:IsCode(${boss}) end) e:SetValue(1) c:RegisterEffect(e) end`;if([first,second,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const chainReader=name=>name===`c${response}.lua`?`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_REMOVED,0,nil,${spirit}):GetFirst() assert(Duel.SpecialSummon(tc,0,tp,tp,true,true,POS_FACEUP)>0,'Restriction fixture Summon failed') end) c:RegisterEffect(e) end`:reader(name);
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:chainReader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,responded=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});add(boss,L.MZONE);codes.forEach(c=>add(c,L.DECK));for(let i=1;i<=test.occupied;i++)add(filler,L.MZONE,0,i);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   if(test.oneAtATime)add(spirit,L.MZONE,1);
   if(test.boosted)add(filler,L.MZONE,0,1);
   if(test.chainRestriction){add(spirit,L.REMOVED,1);core.duelNewCard(duel,{team:1,duelist:0,code:response,controller:1,location:L.SZONE,sequence:0,position:P.FACEDOWN_DEFENSE});}
   core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(test.chainRestriction&&activated&&p.type===M.SELECT_IDLECMD){
     const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE}),opp=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.MZONE});
     if(!responded||!opp.some(c=>c?.code===spirit)||!g.some(c=>c?.code===boss))throw Error('Chained restriction/cost fixture failed');
     const summoned=codes.filter(code=>m.some(c=>c?.code===code));if(summoned.length!==(codes.length===1?1:0))throw Error('Resolution did not respect arriving restriction');
     done=true;continue;
    }
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132273771*16));if(test.legal&&!activated){if(index<0)throw Error('Exact-Level effect unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{if(!test.legal&&index>=0)throw Error('Illegal subset offered');if(test.legal){const m=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location:L.MZONE}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE});if(!g.some(c=>c?.code===boss)||!codes.every(code=>m.some(c=>c?.code===code)))throw Error('Tribute/Summon mismatch');}done=true;}}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===boss);if(index<0)throw Error('Tribute missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_CHAIN){const index=test.chainRestriction&&activated&&!responded&&p.player===1?p.selects.findIndex(c=>c.code===response):-1;if(index>=0)responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/symphonic-mettronomo-deck.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
