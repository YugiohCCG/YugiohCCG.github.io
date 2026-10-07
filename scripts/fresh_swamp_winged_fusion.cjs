'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935094,ally=900001021,top=239935102,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{removed:true},{wrongrace:true},{wrongattribute:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,candidateCard(239935102));cards.set(ally,{...base,code:ally,type:0x61,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill,type:65538,level:0});
  const reader=name=>{
   if(name==='c'+ally+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcFun2(c,aux.FilterBoolFunction(Card.IsCode,'+boss+'),aux.FilterBoolFunction(Card.IsCode,'+filler+'),true) local e=aux.AddContactFusionProcedure(c,Card.IsAbleToRemove,LOCATION_MZONE,0,Duel.Remove,POS_FACEUP,REASON_MATERIAL+REASON_FUSION) e:SetValue(SUMMON_TYPE_FUSION) end';
   if([top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&test.self)source=source.replace('aux.AddCodeList(c,SWAMP)', 'aux.AddCodeList(c,SWAMP) local f=Effect.CreateEffect(c) f:SetType(EFFECT_TYPE_IGNITION) f:SetCode(EVENT_FREE_CHAIN) f:SetRange(LOCATION_MZONE) f:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_EFFECT) end) c:RegisterEffect(f)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--allow-self'))source=source.replace('return mentions and not rc:IsCode(id)','return mentions');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-source'))source=source.replace('return mentions','return true');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:filler,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});add(ally,L.EXTRA);add(top,test.removed?L.REMOVED:L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.special_summons.findIndex(x=>x.code===ally);assert(index>=0,'Contact Fusion unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     assert(query(L.MZONE).some(x=>x.code===ally),'Fusion monster not Summoned');assert(query(L.REMOVED).some(x=>x.code===boss&&(x.reason&8)&&(x.reason&0x40000)),'Fusion material banishment absent');const set=query(L.SZONE).find(x=>x.code===top);assert.equal(!!set,!(test.wrongrace||test.wrongattribute),'Fusion-trigger Set mismatch');if(set)assert.equal(set.position,P.FACEDOWN_DEFENSE);done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);if(test.wrongrace||test.wrongattribute)assert.equal(index,-1,'Wrong Fusion triggered');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.selectable.length?0:null});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===boss){assert(!(test.wrongrace||test.wrongattribute),'Wrong Fusion offered trigger');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}else core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--any-source')?'any-source':process.argv.includes('--allow-self')?'allow-self':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-winged-fusion'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Attempted public-core contact Fusion fixture using pinned Omega helper; no successful Fusion/material/Set proof: helper requires absent GetMustMaterial. Full Winged production loaded; neutral Fusion fixture, actual candidate Winged and Fog metadata; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



