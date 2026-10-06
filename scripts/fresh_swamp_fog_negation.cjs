'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935102,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{spellEffect:true},{spellActivation:true},{removedEffect:true},{sharedCount:true},{convertedResource:true},{wrongResourceAttribute:true},{wrongResourceRace:true},{fieldEffect:true},{noSwamp:true},{equalMonsters:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:test.monster?33:test.trap?4:2,setcodes:test.wrongset?[]:[0xa123],level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:test.spell?2:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  const reader=name=>{
   if(name==='c'+top+'.lua'&&test.spellActivation)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Recover(tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_GRAVE+LOCATION_MZONE+LOCATION_SZONE+LOCATION_REMOVED) e:SetCost(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_ONFIELD,0,nil,'+ally+'):GetFirst() Duel.Hint(HINT_NUMBER,tp,tc and tc:IsType(TYPE_SPELL) and tc:IsType(TYPE_CONTINUOUS) and not tc:IsType(TYPE_MONSTER) and 701 or 700) end) e:SetOperation(function(e,tp) Duel.Recover(tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(name==='c'+ally+'.lua'&&test.convertedResource)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_CHANGE_TYPE) e:SetProperty(EFFECT_FLAG_CANNOT_DISABLE) e:SetValue(TYPE_SPELL+TYPE_CONTINUOUS) e:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET) c:RegisterEffect(e) end';
   if([ally,filler,239935101,900001061].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-szone-location'))source=source.replace('LOCATION_SZONE+LOCATION_GRAVE+LOCATION_REMOVED)~=0','LOCATION_GRAVE+LOCATION_REMOVED)~=0');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--current-monster-only'))source=source.replace('c:IsOriginalType(TYPE_MONSTER)', 'c:IsType(TYPE_MONSTER)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--separate-count'))source=source.replace('e2:SetCountLimit(1,id)','e2:SetCountLimit(1,id+100)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-removed-location'))source=source.replace('LOCATION_SZONE+LOCATION_GRAVE+LOCATION_REMOVED)~=0','LOCATION_SZONE+LOCATION_GRAVE)~=0');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-resource'))source=source.replace('and c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_REPTILE)','');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-handler-destroy'))source=source.replace('if rc:IsRelateToEffect(re) then g:AddCard(rc) end','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-negate'))source=source.replace('if not Duel.NegateEffect(ev) then return end','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-location'))source=source.replace('bit.band(re:GetActivateLocation(),LOCATION_SZONE+LOCATION_GRAVE+LOCATION_REMOVED)~=0','true');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--free-hand'))source=source.replace('hand:SetCondition(s.handcon)','hand:SetCondition(function() return true end)');
   return source;
  };
  cards.set(239935101,candidateCard(239935101));cards.set(top,{...base,code:top,type:test.spellEffect||test.spellActivation?0x20002:33});cards.set(ally,{...base,code:ally,attribute:test.wrongResourceAttribute?4:2,race:test.wrongResourceRace?1024n:524288n});
  cards.set(900001061,{...base,code:900001061,type:2,setcodes:[0xa123]});
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   if(test.sharedCount){add(boss,L.GRAVE);add(filler,L.GRAVE);add(900001061,L.GRAVE);}
   add(boss,L.HAND);add(ally,test.convertedResource?L.SZONE:L.MZONE);if(test.fieldEffect)core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});else add(top,test.spellActivation?L.HAND:test.spellEffect?L.SZONE:test.removedEffect?L.REMOVED:L.GRAVE);add(filler,L.MZONE,1);core.duelNewCard(duel,{team:1,duelist:0,code:filler,controller:1,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});
   if(test.fieldEffect)core.duelNewCard(duel,{team:1,duelist:0,code:filler,controller:1,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});
   if(test.equalMonsters)core.duelNewCard(duel,{team:0,duelist:0,code:filler,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});
   if(!test.noSwamp)core.duelNewCard(duel,{team:0,duelist:0,code:239935101,controller:0,location:L.SZONE,sequence:5,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!activated){const index=p.activates.findIndex(x=>x.code===top);assert(index>=0,'Neutral activation missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.convertedResource)assert(trace.some(x=>x.type===M.HINT&&Number(x.hint)===701),'Resource not actually Continuous Spell before Fog response');
     if(test.sharedCount){assert(query(L.GRAVE).some(x=>x.code===900001061),'Legal recovery target missing');assert(query(L.GRAVE).some(x=>x.code===filler),'Legal recovery cost missing');assert.equal(p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(133935102*16+1)),-1,'Recovery offered after negation consumed shared HOPT');}
     const negative=test.fieldEffect||test.noSwamp||test.equalMonsters||test.wrongResourceAttribute||test.wrongResourceRace;
     assert.equal(trace.filter(x=>x.type===M.CHAINING&&x.code===boss).length,negative?0:1,'Fog activation mismatch');
     assert.equal(trace.some(x=>x.type===M.RECOVER),!!negative,'Effect recovery not correctly negated');
     if(!negative){if(test.spellEffect||test.spellActivation){const victim=query(L.GRAVE).find(x=>x.code===top);assert(victim&&(victim.reason&0x40)!==0,'Activating Spell not destroyed');assert(trace.some(x=>x.type===M.MOVE&&x.card===top&&x.from.location===L.SZONE&&x.to.location===L.GRAVE),'Activating Spell did not move');}assert(query(L.GRAVE).some(x=>x.code===ally&&(x.reason&0x40)!==0),'Own WATER Reptile not effect-destroyed');assert(trace.some(x=>x.type===M.MOVE&&x.card===ally&&x.from.location===(test.convertedResource?L.SZONE:L.MZONE)&&x.to.location===L.GRAVE),'Own resource did not move');}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);if(test.fieldEffect||test.noSwamp||test.equalMonsters||test.wrongResourceAttribute||test.wrongResourceRace)assert.equal(index,-1,'Invalid Fog response offered');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===ally);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.pay?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===boss});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-szone-location')?'no-szone-location':process.argv.includes('--current-monster-only')?'current-monster-only':process.argv.includes('--separate-count')?'separate-count':process.argv.includes('--no-removed-location')?'no-removed-location':process.argv.includes('--any-resource')?'any-resource':process.argv.includes('--no-handler-destroy')?'no-handler-destroy':process.argv.includes('--no-negate')?'no-negate':process.argv.includes('--any-location')?'any-location':process.argv.includes('--free-hand')?'free-hand':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-fog-negation'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Fog, neutral ignition/resource/Swamp scripts; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



