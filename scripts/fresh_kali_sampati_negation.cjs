'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=247755866,mat=900001031,top=900001032,setup=900001033,spell=900001034,filler=900001035,results=[];
 for(const test of [{},{spell:true},{trap:true},{own:true},{lowLP:true}]){
  test.monster=!(test.spell||test.trap);
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([mat,top,setup,spell,filler].map(code=>[code,{...base,code}]));
  cards.set(top,{...cards.get(top),race:test.nonplant?1n:1024n});for(const code of [setup,spell])cards.set(code,{...cards.get(code),type:2,level:0});if(test.trap)cards.set(spell,{...cards.get(spell),type:4});if(test.monster)cards.set(spell,{...base,code:spell,type:33});cards.set(boss,candidateCard(boss));
  if(test.continuous)cards.set(spell,{...cards.get(spell),type:0x20002});
  const reader=name=>{
   if(name==='c'+setup+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,'+top+'):GetFirst() Duel.MoveSequence(tc,SEQ_DECKTOP) '+(test.nomat?'':'local mc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+mat+'):GetFirst() local xc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+'):GetFirst() Duel.Overlay(xc,Group.FromCards(mc))')+' end) c:RegisterEffect(e) end';
   if(name==='c'+spell+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) '+(test.monster||test.continuous?'e:SetType(EFFECT_TYPE_IGNITION) e:SetRange('+(test.monster?'LOCATION_MZONE':'LOCATION_SZONE')+')':'e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)')+' e:SetOperation(function(e,tp) Duel.Recover(tp,500,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([mat,top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'&&process.argv.includes('--no-negate'))source=source.replace('Duel.NegateActivation(ev)','false');if(name==='c'+boss+'.lua'&&process.argv.includes('--any-type'))source=source.replace('re:IsActiveType(TYPE_MONSTER)','true');if(name==='c'+boss+'.lua'&&process.argv.includes('--no-soft-count'))source=source.replace('e1:SetCountLimit(1)','do end');return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?500:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=false,activated=false,done=false,turn=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);add(mat,L.HAND);add(mat,L.HAND);if(test.trap)core.duelNewCard(duel,{team:1,duelist:0,code:spell,controller:1,location:L.SZONE,sequence:0,position:P.FACEDOWN_DEFENSE});else if(test.own)core.duelNewCard(duel,{team:0,duelist:0,code:spell,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});else add(spell,test.monster?L.MZONE:L.HAND,1);add(top,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!test.own&&turn<2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!activated){const index=p.activates.findIndex(x=>x.code===spell);assert(index>=0,'Fixture Spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const eligible=test.monster&&!test.own&&!test.lowLP;
     assert.equal(trace.some(x=>x.type===M.RECOVER),!eligible||prepared,'Source effect resolution mismatch');const payments=trace.filter(x=>x.type===M.PAY_LPCOST&&x.player===0);assert.equal(payments.length,eligible?1:0,'Negation LP cost mismatch');if(eligible){assert.equal(payments[0].amount,1000);assert(query(L.GRAVE).some(x=>x.code===mat&&(x.reason&1)&&(x.reason&0x40)),'Selected hand card not destroyed');assert(query(L.MZONE,1).some(x=>x.code===spell),'Negated monster incorrectly automatically destroyed');}if(eligible&&!prepared){prepared=true;const again=p.activates.findIndex(x=>x.code===spell);assert(again>=0,'Second legal source activation unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:again});continue;}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss&&String(x.description)===String(133755866*16));core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_CARD){assert(!p.selects.some(x=>x.code===boss),'Sampati offered for own destruction');const index=p.selects.findIndex(x=>x.code===mat);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){const player=turn===1?0:1,offset=player===0?8:24,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(offset+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-negate')?'no-negate':process.argv.includes('--any-type')?'any-type':process.argv.includes('--no-soft-count')?'no-soft-count':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/kali-sampati-negation'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, complete production Sampati/candidate metadata; seeded Synchro, neutral source and hand destruction target; actual activation negation/LP cost, no Synchro procedure/native Omega certification',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});

