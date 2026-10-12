'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=227035644,ally=900004401,top=900004402,filler=900004403,results=[];
 for(const test of [{prior:900004410},{prior:900004411},{prior:900004412},{prior:900004413}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:2,race:4n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[ally,{...base,code:ally,type:0x61,setcodes:[0xf3c]}],[top,{...base,code:top}],[filler,{...base,code:filler}]]);
  for(const [code,type,attribute] of [[900004410,0x61,2],[900004411,0x61,4],[900004412,0x2001,2],[900004413,17,4]])cards.set(code,{...base,code,type,attribute});
  const reader=name=>{
   if(name==='c'+ally+'.lua'&&test.three)return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcFunRep(c,aux.FilterBoolFunction(Card.IsCode,'+top+'),3,true) end';
   if(name==='c'+ally+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcFun2(c,aux.FilterBoolFunction(Card.IsCode,'+top+'),aux.FilterBoolFunction(Card.IsCode,'+filler+'),true) end';
   if(name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA+LOCATION_HAND,0,nil,'+test.prior+'):GetFirst() Duel.SpecialSummon(tc,tc:IsType(TYPE_FUSION) and SUMMON_TYPE_FUSION or tc:IsType(TYPE_SYNCHRO) and SUMMON_TYPE_SYNCHRO or 0,tp,tp,false,false,POS_FACEUP) Duel.SendtoGrave(tc,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([top,filler,900004410,900004411,900004412,900004413].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'&&process.argv.includes('--old-faceup-filter'))lua=lua.replace('(not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())','c:IsFaceupEx()');if(name==='c'+boss+'.lua'&&process.argv.includes('--no-two-limit'))lua=lua.replace('return #sg==2','return true');if(name==='c'+boss+'.lua'&&process.argv.includes('--no-history-check'))lua=lua.replace('return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0','return true');return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,priorActivated=false,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   core.loadScript(duel,'legacy_faceup_adapter.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   if(process.argv.includes('--neutral-mandatory-adapter'))core.loadScript(duel,'neutral_mandatory_adapter.lua','Duel.GetMustMaterial=function() return Group.CreateGroup() end Duel.CheckMustMaterial=function() return true end');
   add(boss,L.HAND);add(ally,L.EXTRA);core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:test.hand?L.HAND:test.deck||test.three?L.DECK:L.MZONE,sequence:0,position:test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   core.duelNewCard(duel,{team:0,duelist:0,code:test.three?top:filler,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});if(test.three)add(top,L.HAND);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);for(const code of [900004410,900004411,900004412])add(code,L.EXTRA);add(900004413,L.HAND);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
          if(!priorActivated){const index=p.activates.findIndex(x=>x.code===filler);assert(index>=0,'Prior summon fixture activation');priorActivated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.GRAVE).some(x=>x.code===test.prior),'Prior summoned card moved GY to free Extra zone');assert(trace.some(x=>x.type===M.SPSUMMONED),'Actual prior Special Summon event');
     if(!activated){const index=p.activates.findIndex(x=>x.code===boss);if(test.prior===900004411||test.prior===900004412){assert.equal(index,-1,'Prior prohibited Extra summon blocks Aqua Fusion');done=true;continue;}assert(index>=0,'Aqua Fusion first activation available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.MZONE).some(x=>x.code===ally),'Actual Fusion Summon');assert(query(L.GRAVE).some(x=>x.code===top),'Material sent GY');assert.equal(query(L.GRAVE).filter(x=>(x.reason&0x40000)&&[top,filler].includes(x.code)).length,2,'Exactly two Fusion materials');assert(query(L.GRAVE).some(x=>x.code===boss),'Spell sent GY');assert(trace.some(x=>x.type===M.SPSUMMONED),'Native Special Summon completion');done=true;
    }else if(p.type===M.SELECT_CHAIN){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const crypto=require('node:crypto'),sha=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-aqua-prior-summon'+(process.argv.includes('--neutral-mandatory-adapter')?'-neutral-mandatory-adapter':'')+(process.argv.includes('--no-history-check')?'-no-history-check':'')+'.json'),JSON.stringify({scope:'Actual prior effect Special Summon of neutral Extra WATER Fusion/non-WATER Fusion/WATER Synchro or Hand monster, then canonical Aqua Fusion activation eligibility. Permitted prior histories also complete first-effect Fusion. Explicit sterile mandatory-material adapters/neutral recipients; no general mandatory-material, proper summoning of prior fixtures, negation or native Omega proof.',control:process.argv.includes('--no-history-check')?'no-history-check':null,script_sha256:sha(path.join(CUSTOM,'c'+boss+'.lua')),harness_sha256:sha(__filename),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
