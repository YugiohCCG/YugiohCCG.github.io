'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935100,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{place:true},{fullSZONE:true},{fullMZONE:true,place:true},{removed:true},{removed:true,place:true},{wrongrace:true},{wrongattribute:true},{facedown:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+'):GetFirst() tc:CompleteProcedure() '+(test.noMaterial?'':'for i=1,2 do Duel.Overlay(tc,Group.FromCards(Duel.CreateToken(tp,900001030))) end')+' end) c:RegisterEffect(e) end';
   if(name==='c900001030.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+ally+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS) e:SetCode(EVENT_DESTROY) e:SetOperation(function(e,tp) local c=e:GetHandler() Duel.Hint(HINT_NUMBER,tp,c:IsType(TYPE_SPELL) and c:IsType(TYPE_CONTINUOUS) and not c:IsType(TYPE_MONSTER) and 701 or c:IsType(TYPE_MONSTER) and 702 or 700) end) c:RegisterEffect(e) local g=Effect.CreateEffect(c) g:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS) g:SetCode(EVENT_TO_GRAVE) g:SetOperation(function(e,tp) local c=e:GetHandler() Duel.Hint(HINT_NUMBER,tp,c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_SPELL) and 703 or 700) end) c:RegisterEffect(g) end';
   if([top,filler,17228909].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-summon-count'))source=source.replace('e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-redirect'))source=source.replace('c:RegisterEffect(redirect,true)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-detach'))source=source.replace('e1:SetCost(s.placecost)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-type-change'))source=source.replace('tc:RegisterEffect(change)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-destroy'))source=source.replace('Duel.Destroy(dg,REASON_EFFECT)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-monster'))source=source.replace('c:IsType(TYPE_MONSTER) and s.waterreptile(c)','c:IsType(TYPE_MONSTER)');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   if(test.fullSZONE||test.fullMZONE)for(let sequence=0;sequence<5;sequence++)core.duelNewCard(duel,{team:0,duelist:0,code:test.fullSZONE?top:filler,controller:0,location:test.fullSZONE?L.SZONE:L.MZONE,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(boss,L.HAND);
   core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:test.removed||test.facedown?L.REMOVED:L.GRAVE,sequence:0,position:test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(x=>x.code===boss);
     if(test.wrongrace||test.wrongattribute||test.facedown||test.fullSZONE){assert.equal(index,-1,'Illegal destruction offered');done=true;continue;}
     if(!activated){assert(index>=0,'Rage unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.fullSZONE||test.fullMZONE){assert.equal(trace.filter(x=>x.type===M.SELECT_OPTION).length,0,'Unavailable branch choice offered');assert.equal(query(test.fullSZONE?L.SZONE:L.MZONE).filter(x=>x.code===(test.fullSZONE?top:filler)).length,5,'Capacity fixture altered');}
     const dest=test.place?L.SZONE:L.MZONE;
     assert(trace.some(x=>x.type===M.MOVE&&x.card===ally&&x.from.location===(test.removed?L.REMOVED:L.GRAVE)&&x.to.location===dest),'Recipient not actually moved');
     assert(query(L.GRAVE).some(x=>x.code===ally&&(x.reason&1)&&(x.reason&0x40)),'Recipient not effect-destroyed');
     assert(trace.some(x=>x.type===M.MOVE&&x.card===ally&&x.from.location===dest&&x.to.location===L.GRAVE),'Recipient not destroyed from intended destination');
     assert(trace.some(x=>x.type===M.HINT&&Number(x.hint)===(test.place?701:702)),'Recipient field type incorrect at destruction');assert(trace.some(x=>x.type===M.HINT&&Number(x.hint)===703),'Recipient type failed to reset in GY');
     if(!test.place)assert(trace.some(x=>x.type===M.SPSUMMONED),'Actual Special Summon not completed');
     assert(query(L.HAND).some(x=>x.code===boss),'Spare source missing');assert.equal(p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(133935100*16)),-1,'Second activation allowed');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===ally);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-type-change')?'no-type-change':process.argv.includes('--no-summon-count')?'no-summon-count':process.argv.includes('--no-destroy')?'no-destroy':process.argv.includes('--any-monster')?'any-monster':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-perseverance-movement'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Perseverance/actual candidate metadata; neutral recipient; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



