'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const speeaker=process.argv.includes('--speeaker');
 const source=process.argv.includes('--recruit-extra')?'extra':process.argv.includes('--recruit-hand')?'hand':'deck';
 const prior=process.argv.find(v=>v.startsWith('--prior='))?.slice(8),priorCard=900000704,priorSpell=900000705;
 const later=process.argv.find(v=>v.startsWith('--later='))?.slice(8),laterCard=900000706,laterSpell=900000707;
 if(later&&(!speeaker||prior||source!=='deck'))throw Error('Later-lock fixture requires --speeaker with Deck recruitment and no prior fixture');
 const blocked=prior==='fusion'||prior==='pendulum-fusion';
 const core=await mod.default({sync:true,print(){},printErr(){}}),terror=speeaker?238273768:238272434,under=900000701,spell=900000702,filler=900000703;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(terror);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const special of [false,true]){
  const trace=[],logs=[],cards=new Map([[terror,{...base,code:terror,setcodes:[0xA110,0xA111],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[under,{...base,code:under,setcodes:[0xA110,0xA111]}],[spell,{...base,code:spell,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
  const reader=name=>{if(name===`c${spell}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${terror}) local tc=g:GetFirst() if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end end) c:RegisterEffect(e) end`;if([`c${under}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  if(prior){cards.set(priorCard,{...base,code:priorCard,type:prior==='wind-synchro'?0x2021:prior==='faceup-pendulum'?0x1000021:prior==='pendulum-fusion'?0x1000061:0x61,attribute:prior==='wind-synchro'?8:1});}
  if(prior||speeaker&&source==='extra')cards.set(priorSpell,{...base,code:priorSpell,type:2,level:0});
  if(later){cards.set(laterCard,{...base,code:laterCard,type:later==='wind-synchro'?0x2021:later==='faceup-pendulum'?0x1000021:later==='pendulum-fusion'?0x1000061:0x61,attribute:later==='wind-synchro'?8:1});cards.set(laterSpell,{...base,code:laterSpell,type:2,level:0});}
  const priorReader=name=>{
   if(name===`c${laterCard}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name===`c${laterSpell}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${later==='faceup-pendulum'?`Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${laterCard}),REASON_EFFECT)` : ''} local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${laterCard}):GetFirst() assert(tc,'Later target absent from Extra Deck') assert(tc:IsCanBeSpecialSummoned(e,0,tp,false,false)==${later==='wind-synchro'||later==='faceup-pendulum'?'true':'false'},'Later lock eligibility mismatch') ${later==='wind-synchro'||later==='faceup-pendulum'?'assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0,\'Allowed later Summon failed\')':''} Duel.Damage(tp,777,REASON_EFFECT) end) c:RegisterEffect(e) end`;
   if(name===`c${priorSpell}.lua`&&!prior)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${under}):GetFirst() assert(tc,'Preparation target missing') Duel.SendtoGrave(tc,REASON_EFFECT) assert(tc:IsLocation(LOCATION_EXTRA) and tc:IsFaceup(),'Pendulum not moved to face-up Extra Deck') end) c:RegisterEffect(e) end`;
   if(name===`c${priorCard}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name===`c${priorSpell}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${prior==='faceup-pendulum'?`Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${priorCard}),REASON_EFFECT)` : ''} local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${priorCard}):GetFirst() assert(tc,'Prior card absent from Extra Deck') assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0,'Prior Summon failed') Duel.SendtoGrave(tc,REASON_EFFECT) end) c:RegisterEffect(e) end`;
   return reader(name);
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:priorReader,errorHandler:(type,message)=>logs.push({type,message})});
  if(speeaker){cards.get(terror).setcodes=[0x1066];cards.get(under).setcodes=[0x1066];if(source==='extra')cards.get(under).type|=0x1000000;}
  let failure=null,started=false,triggered=false,priorStarted=false,laterStarted=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence:0,position:P.FACEUP_ATTACK});add(terror,L.HAND);add(under,speeaker&&source==='extra'?L.MZONE:speeaker&&source==='hand'?L.HAND:L.DECK);if(special)add(spell,L.HAND);for(const player of [0,1])for(let i=0;i<5;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});
   if(speeaker&&source==='extra'&&!prior)add(priorSpell,L.HAND);
   if(prior){add(priorSpell,L.HAND);core.duelNewCard(duel,{team:0,duelist:0,code:priorCard,controller:0,location:prior==='faceup-pendulum'?L.MZONE:L.EXTRA,sequence:0,position:prior==='faceup-pendulum'?P.FACEUP_ATTACK:P.FACEDOWN_DEFENSE});}
   if(later){add(laterSpell,L.HAND);core.duelNewCard(duel,{team:0,duelist:0,code:laterCard,controller:0,location:later==='faceup-pendulum'?L.MZONE:L.EXTRA,sequence:0,position:later==='faceup-pendulum'?P.FACEUP_ATTACK:P.FACEDOWN_DEFENSE});}
   core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(later&&started&&p.type===M.SELECT_IDLECMD){if(!triggered)throw Error('Recruitment did not establish lock');if(!laterStarted){const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE});if(!m.some(c=>c?.code===under))throw Error('Recruitment failed before lock probe');const index=p.activates.findIndex(c=>c.code===laterSpell);if(index<0)throw Error('Later probe unavailable');laterStarted=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!trace.some(t=>t.type===M.DAMAGE))throw Error('Later probe did not complete');done=true;continue;}
    if((prior||speeaker&&source==='extra')&&!priorStarted&&p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===priorSpell);if(index<0)throw Error('Preparation/Prior Summon Spell unavailable');priorStarted=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
    if(blocked&&started&&p.type===M.SELECT_IDLECMD){if(triggered)throw Error('Recruitment offered after prohibited earlier Summon');const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE});if(m.some(c=>c?.code===under))throw Error('Prohibited recruitment resolved');done=true;continue;}
    if(p.type===M.SELECT_IDLECMD){if(!started){const code=special?spell:terror,items=special?p.activates:p.summons,index=items.findIndex(c=>c.code===code);if(index<0)throw Error('Summon unavailable');started=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:special?A.SELECT_ACTIVATE:A.SELECT_SUMMON,index});}else{const h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:speeaker?L.MZONE:L.HAND});if(!triggered||!h.some(c=>c?.code===under))throw Error('Search/recruitment failed');done=true;}}
    else if(p.type===M.SELECT_CHAIN){const index=p.player===0?p.selects.findIndex(c=>c.code===terror):-1;if(index>=0&&blocked)throw Error('Recruitment offered after prohibited earlier Summon');if(index>=0)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN){const yes=p.code===terror;if(yes&&blocked)throw Error('Recruitment offered after prohibited earlier Summon');if(yes)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===under);if(index<0)throw Error('Underroot search target unavailable');if(speeaker&&p.selects[index].location!==(source==='extra'?L.EXTRA:source==='hand'?L.HAND:L.DECK))throw Error('Recruitment source mismatch');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({special,status:failure?'FAIL':'PASS',failure,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} special=${special}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/${speeaker?'symphonic-speeaker-recruit-'+source:'underroot-terror-search'}${prior?'-prior-'+prior:''}${later?'-later-'+later:''}.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',source,prior,later,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
