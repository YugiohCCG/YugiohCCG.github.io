'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=259826112,ally=900004401,top=900004402,filler=900004403,results=[];
 for(const test of [{},{decline:true},{immune:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:2,race:4n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[ally,{...base,code:ally,type:0x61,setcodes:[0x173]}],[top,{...base,code:top}],[filler,{...base,code:filler}]]);
  cards.set(900004450,{...base,code:900004450,type:4,setcodes:[0x173]});
  const reader=name=>{
   if(name==='c'+ally+'.lua'&&test.three)return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcFunRep(c,aux.FilterBoolFunction(Card.IsCode,'+top+'),3,true) end';
   if(name==='c'+ally+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcFun2(c,aux.FilterBoolFunction(Card.IsCode,'+top+'),aux.FilterBoolFunction(Card.IsCode,'+filler+'),true) end';
   if(name==='c'+top+'.lua'&&test.immune)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetValue(function(e,re) return re:GetOwner():IsCode('+boss+') end) c:RegisterEffect(e) end';
   if([top,filler,900004450].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'&&process.argv.includes('--old-faceup-filter'))lua=lua.replace('(not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())','c:IsFaceupEx()');if(name==='c'+boss+'.lua'&&process.argv.includes('--no-two-limit'))lua=lua.replace('return #sg==2','return true');if(name==='c'+boss+'.lua'&&process.argv.includes('--old-material-pool'))lua=lua.replace('local mg=Duel.GetFusionMaterial(tp):Filter(function(c) return not c:IsImmuneToEffect(e) end,nil)','local mg=Duel.GetFusionMaterial(tp)');return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   core.loadScript(duel,'legacy_faceup_adapter.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   if(process.argv.includes('--neutral-mandatory-adapter'))core.loadScript(duel,'neutral_mandatory_adapter.lua','Duel.GetMustMaterial=function() return Group.CreateGroup() end Duel.CheckMustMaterial=function() return true end');
   core.duelNewCard(duel,{team:0,duelist:0,code:boss,controller:0,location:L.SZONE,sequence:0,position:P.FACEDOWN_DEFENSE});add(900004450,L.DECK);add(ally,L.EXTRA);core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:test.hand?L.HAND:test.deck||test.three?L.DECK:L.MZONE,sequence:0,position:test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   core.duelNewCard(duel,{team:0,duelist:0,code:test.three?top:filler,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});if(test.three)add(top,L.HAND);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
          if(!activated){const index=p.activates.findIndex(x=>x.code===boss);if(test.three){assert.equal(index,-1,'Three-material Fusion excluded');done=true;continue;}assert(index>=0,'Aqua Fusion first activation available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.SZONE).some(x=>x.code===900004450&&(x.position&10)!==0),'Actual Dinomorphia Trap set');if(test.decline||test.immune){assert(!query(L.MZONE).some(x=>x.code===ally),'Optional/immune Fusion absent');assert(!query(L.GRAVE).some(x=>x.code===top),'Unused material remains');done=true;continue;}
     assert(query(L.MZONE).some(x=>x.code===ally),'Actual Fusion Summon');assert(query(L.GRAVE).some(x=>x.code===top),'Material sent GY');assert.equal(query(L.GRAVE).filter(x=>x.reason&0x40000).length,2,'Exactly two Fusion materials');assert(query(L.GRAVE).some(x=>x.code===boss),'Spell sent GY');assert(trace.some(x=>x.type===M.SPSUMMONED),'Native Special Summon completion');done=true;
    }else if(p.type===M.SELECT_CHAIN){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const crypto=require('node:crypto'),sha=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-dinomorphia-provocation-fusion'+(process.argv.includes('--neutral-mandatory-adapter')?'-neutral-mandatory-adapter':'')+(process.argv.includes('--old-material-pool')?'-old-material-pool':'')+'.json'),JSON.stringify({scope:'Full canonical Provocation Set followed by optional actual neutral Dinomorphia Fusion; optional decline; second material immunity. Canonical Omega recipe/sterile mandatory adapters; recipient neutral, native Omega and GY effect open.',control:process.argv.includes('--old-material-pool')?'old-material-pool':null,script_sha256:sha(path.join(CUSTOM,'c'+boss+'.lua')),harness_sha256:sha(__filename),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
