'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244168521,dino=900000161,adj=900000162,summoner=900000163,destroyer=900000164,fodder=900000165,filler=900000166;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const spell={...base,type:2,level:0,attribute:0,race:0n,attack:0,defense:0};
 const cards=new Map([[boss,{...base,code:boss,type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:0,link_marker:Number(r.def)}],[dino,{...base,code:dino,race:65536n,attribute:4}],[adj,{...base,code:adj}],[summoner,{...spell,code:summoner}],[destroyer,{...spell,code:destroyer}],[fodder,{...spell,code:fodder}],[filler,{...base,code:filler}]]);
 const summonScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(s.op) c:RegisterEffect(e) end function s.op(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}) local c=g:GetFirst() if c and Duel.SpecialSummon(c,0,tp,tp,true,true,POS_FACEUP)>0 then c:CompleteProcedure() end end`;
 const destroyScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(s.op) c:RegisterEffect(e) end function s.op(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}) Duel.Destroy(g,REASON_EFFECT) end`;
 const trace=[],logs=[];
 const reader=name=>{if(name===`c${summoner}.lua`)return summonScript;if(name===`c${destroyer}.lua`)return destroyScript;if(name===`c${fodder}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';if(['c0.lua',`c${dino}.lua`,`c${adj}.lua`,`c${filler}.lua`].includes(name))return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let script=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){const call=' aux.AddLinkProcedure(c,nil,2,4,s.lcheck)';if(!script.includes(call))throw Error('Link adapter mismatch');script=script.replace(call,' -- Link procedure omitted: public core lacks Card.GetMustMaterial');if(process.argv.includes('--omit-zone'))script=script.replace(' c:RegisterEffect(e0)',' -- Zone effect omitted for diagnostic')}return script};
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,stepName='summon',firstTriggered=false,revived=false,done=false;
 try{
  for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
  const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
  add(boss,L.EXTRA);add(dino,L.GRAVE);add(summoner,L.HAND);add(destroyer,L.HAND);add(destroyer,L.HAND);add(fodder,L.HAND);add(adj,L.MZONE,1,1);add(adj,L.MZONE,1,3);
  for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
  core.startDuel(duel);
  for(let step=0;step<190&&!done;step++){
   const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
   if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
   if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
   const p=messages.at(-1);if(!p)throw Error('Missing prompt');
   if(p.type===M.SELECT_IDLECMD){
    if(stepName==='summon'){
     const index=p.activates.findIndex(c=>c.code===summoner);if(index<0)throw Error('Test summoner unavailable');stepName='first-effect';core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(stepName==='first-effect'){
     if(!firstTriggered||core.duelQueryCount(duel,0,L.MZONE)!==1||core.duelQueryCount(duel,1,L.MZONE)!==0||core.duelQueryCount(duel,1,L.GRAVE)!==2)throw Error('Summon-to-opponent or adjacent destruction failed');
     const index=p.activates.findIndex(c=>c.code===destroyer);if(index<0)throw Error('Test destroyer unavailable');stepName='revive';core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(stepName==='revive'){
     if(!revived||core.duelQueryCount(duel,0,L.MZONE)!==1||core.duelQueryCount(duel,0,L.GRAVE)!==4)throw Error('Cost or revival failed');
     const index=p.activates.findIndex(c=>c.code===destroyer);if(index<0)throw Error('Second test destroyer unavailable');stepName='banish';core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(stepName==='banish'){
     if(core.duelQueryCount(duel,0,L.MZONE)!==0||core.duelQueryCount(duel,0,L.REMOVED)!==1)throw Error('Revived Bahariasaurus did not banish on leaving');
     done=true;break;
    }
   }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);if(index>=0){if(stepName==='first-effect')firstTriggered=true;if(stepName==='revive')revived=true}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
   else if(p.type===M.SELECT_EFFECTYN){if(p.code===boss){if(stepName==='first-effect')firstTriggered=true;if(stepName==='revive')revived=true}core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
   else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===dino||c.code===fodder);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});}
   else if(p.type===M.SELECT_PLACE){let player=0,location=L.MZONE,seq=[5,6,0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(seq===undefined){seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);if(seq!==undefined)location=L.SZONE;}if(seq===undefined){seq=[2,0,4,1,3].find(i=>(p.field_mask&(1<<(16+i)))===0);player=1;}if(seq===undefined)throw Error('No place: '+p.field_mask);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location,sequence:seq}]});}
   else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
   else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
  }
  if(!done)throw Error('Step limit');
 }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/baharia-effects.json'),JSON.stringify({engine:'public OCGCore with Bahariasaurus triggered effect code intact; Link procedure omitted because Card.GetMustMaterial is unavailable; field-zone effect omitted only when --omit-zone because Card.GetLinkedZone is unavailable; test-only Special Summon, not Link Summon',zoneEffectOmitted:process.argv.includes('--omit-zone'),status:failure?'FAIL':'PASS',failure,firstTriggered,revived,trace,logs},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 console.log(`${failure?'FAIL':'PASS'} Bahariasaurus effects${failure?': '+failure:''}`);if(failure)process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
