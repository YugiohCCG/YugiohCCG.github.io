'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),boss=238273772,spell=900004901,trap=900004902,filler=900004903;
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod,core=await mod.default({sync:true,print(){},printErr(){}}),results=[],control=['no-protection','protect-own','no-destruction'].find(x=>process.argv.includes('--'+x));
 for(const scenario of ['opponent','own','disabled']){
  const trace=[],logs=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0},cards=new Map([[boss,candidateCard(boss)],[spell,{...base,code:spell,type:2}],[trap,{...base,code:trap,type:4}],[filler,{...base,code:filler}]]);
  const destroy=`local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,${boss}) assert(tc) ${scenario==='disabled'?`assert(tc:IsDisabled())`:''} local n=${control==='no-destruction'?'0':'Duel.Destroy(tc,REASON_EFFECT)'} Duel.Hint(HINT_NUMBER,0,990+n)`;
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+spell+'.lua'||name==='c'+trap+'.lua'){const own=name==='c'+spell+'.lua';return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(${own?'EVENT_FREE_CHAIN':'EVENT_CHAINING'}) e:SetOperation(function(e,tp) ${own?(scenario==='own'?destroy:scenario==='disabled'?`local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,${boss}) if not tc then return end local d=Effect.CreateEffect(e:GetHandler()) d:SetType(EFFECT_TYPE_SINGLE) d:SetCode(EFFECT_DISABLE) tc:RegisterEffect(d) local q=d:Clone() q:SetCode(EFFECT_DISABLE_EFFECT) tc:RegisterEffect(q)`:'do end'):destroy} end) c:RegisterEffect(e) end`;}
   const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(p,name);let s=fs.readFileSync(p,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-protection')s=s.replace('e5:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)','e5:SetCode(EFFECT_INDESTRUCTABLE_BATTLE)');if(control==='protect-own')s=s.replace('return rp~=e:GetHandlerPlayer()','return true');}return s;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let prepared=scenario!=='disabled';let failure=null,activated=false,chained=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,n,reader(n)));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});
   add(boss,L.MZONE);add(spell,L.HAND);if(scenario==='disabled')add(spell,L.HAND);if(scenario!=='own')add(trap,L.SZONE,1,P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   for(let step=0;step<140&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!prepared){prepared=true;const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const destroyed=scenario!=='opponent';assert.equal(chained,scenario!=='own');assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===(destroyed?991:990)),'Native destruction result');assert.equal(core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}).some(c=>c?.code===boss),!destroyed,'Native protected source versus destroyed source');assert.equal(trace.filter(m=>m.type===M.MOVE&&m.card===boss&&m.from.location===L.MZONE&&m.to.location===L.EXTRA).length,destroyed?1:0,'Actual native Pendulum Extra redirection');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=prepared&&!chained?p.selects.findIndex(c=>c.code===trap):-1;if(index>=0)chained=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}results.push({scenario,failure,trace,logs});console.log((failure?'FAIL ':'PASS ')+scenario+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-megastaar-destruction'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full Mega Staar source/current installed metadata/corrected transport/native non-targeting effect destruction. Field-seeded source; opponent effect fails to destroy, own effect succeeds, externally owned native disable permits opponent destruction. Actual destruction result and MZone-to-faceup Extra moves asserted. No Lua API adapter; original Synchro recipe/proper history/battle immunity excluded, no live Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(v=>v.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
