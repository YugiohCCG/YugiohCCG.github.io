'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),sundew=284639723,summon=900000551,oppSpell=900000552,pend=900000553,fodder=900000554,filler=900000555;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(sundew);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[sundew,{...base,code:sundew,setcodes:[0xA122],type:Number(r.type),level:Number(r.level)&255,lscale:(Number(r.level)>>>24)&255,rscale:(Number(r.level)>>>16)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[summon,{...base,code:summon,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[oppSpell,{...base,code:oppSpell,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[pend,{...base,code:pend,setcodes:[0xA122],type:0x1000021}],[fodder,{...base,code:fodder,type:0x20002,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
 const results=[];
 for(const test of [{pendulum:true,defense:true,destroyPend:true},{pendulum:true,defense:true,destroyPend:false},{pendulum:false,defense:true,destroyPend:false},{pendulum:true,defense:false,destroyPend:false}]){
  const trace=[],logs=[];
  const summonScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${sundew}) local tc=g:GetFirst() if tc then Duel.SpecialSummon(tc,${test.pendulum?'SUMMON_TYPE_PENDULUM':'0'},tp,tp,false,false,${test.defense?'POS_FACEUP_DEFENSE':'POS_FACEUP_ATTACK'}) end end) c:RegisterEffect(e) end`;
  const reader=name=>{if(name===`c${summon}.lua`)return summonScript;if(name===`c${oppSpell}.lua`)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) c:RegisterEffect(e) end';if([`c${pend}.lua`,`c${fodder}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,summoned=false,activated=false,quick=false,endOffered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:P.FACEUP_ATTACK});
   add(sundew,L.HAND);add(summon,L.HAND);add(oppSpell,L.HAND,1);add(pend,L.DECK);add(fodder,L.SZONE,0,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<190&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(p.player===0&&!summoned){const index=p.activates.findIndex(c=>c.code===summon);if(index<0)throw Error('Summon setup unavailable');summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else if(p.player===1&&!activated){const index=p.activates.findIndex(c=>c.code===oppSpell);if(index<0)throw Error('Opponent activation unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else if(p.player===0&&activated){const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),x=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.EXTRA});const shouldQuick=test.pendulum&&test.defense;if(quick!==shouldQuick||endOffered!==(shouldQuick&&test.destroyPend)||m.some(c=>c?.code===pend)!==(shouldQuick&&!test.destroyPend)||x.some(c=>c?.code===pend))throw Error(`Quick/End result mismatch quick=${quick} end=${endOffered} m=${JSON.stringify(m)} x=${JSON.stringify(x)}`);done=true;}else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}
    else if(p.type===M.SELECT_CHAIN){const index=p.player===0&&activated?p.selects.findIndex(c=>c.code===sundew):-1;if(index>=0)quick=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN){endOffered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CARD){const fromDeck=p.selects.some(c=>c.code===pend&&c.location===L.DECK),fromExtra=p.selects.some(c=>c.code===pend&&c.location===L.EXTRA),code=fromDeck||fromExtra||test.destroyPend?pend:fodder,index=p.selects.findIndex(c=>c.code===code);if(index<0)throw Error('Expected card unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_DEFENSE});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,quick,endOffered,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-sundew-quick-end.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
