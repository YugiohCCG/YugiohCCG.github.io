'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244163202,ally=900001071,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{decline:true},{wrongLevel:true},{wrongRank:true},{multiple:true},{multiple:true,decline:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:test.wrongLevel?11:12,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(ally,{...base,code:ally,attribute:test.wrongattribute?4:2,race:test.wrongrace?1024n:524288n});cards.set(239935101,candidateCard(239935101));cards.set(900001021,{...base,code:900001021,type:0x80002,level:0});cards.set(top,{...base,code:top,type:65538,level:0});cards.set(refill,{...base,code:refill,type:65538,level:0});cards.set(top,{...base,code:top,type:0x800021,level:test.wrongRank?11:12});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local host=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+top+'):GetFirst() local mat=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+boss+'):GetFirst() Duel.Overlay(host,mat) local victim=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+ally+')'+(test.multiple?'':':GetFirst()')+' Duel.Destroy(victim,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c900001021.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if([ally,filler,239935101].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--first-victim-only'))source=source.replace('return s.repfilter(c,e:GetHandlerPlayer())','return c:GetSequence()==1 and s.repfilter(c,e:GetHandlerPlayer())');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-replacement'))source=source.replace('e3:SetTarget(s.reptg)','e3:SetTarget(function() return false end)');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);add(refill,L.HAND);add(top,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});
   if(test.multiple)core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===refill);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const protects=!(test.decline||test.wrongLevel||test.wrongRank);
     assert.equal(query(L.MZONE).filter(x=>x.code===ally).length,protects?(test.multiple?2:1):0,'Victim preservation mismatch');
     if(!protects)assert.equal(query(L.GRAVE).filter(x=>x.code===ally).length,test.multiple?2:1,'Destruction destination mismatch');
     assert.equal(query(L.GRAVE).some(x=>x.code===boss),protects,'Azure detachment mismatch');
     if(protects){const paid=query(L.GRAVE).find(x=>x.code===boss);assert(paid.reason&0x40);assert(paid.reason&0x1000000);assert.equal(paid.reason&0x80,0);}
     done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,top,'Unexpected replacement host');assert(!(test.wrongLevel||test.wrongRank),'Illegal replacement choice');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_YESNO){assert(!(test.wrongLevel||test.wrongRank),'Illegal replacement choice');core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--first-victim-only')?'first-victim-only':process.argv.includes('--no-replacement')?'no-replacement':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/killamity-azure-replacement'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core; full Azure production and candidate, neutral seeded Xyz and actual overlay/destruction fixture',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



