'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 assert.equal(typeof M.BECOME_TARGET,'number','Target-event decoder unavailable');
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244161756,ally=17228908,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{level3:true},{highlevel:true},{wrongrace:true},{opponent:true},{facedown:true},{xyz:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,race:test.wrongrace?1024n:65536n,level:test.level3?3:test.highlevel?4:2,type:test.xyz?0x800021:33});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:0x80002,level:0});cards.set(refill,{...base,code:refill,type:65538,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+ally+'):GetFirst() Duel.SendtoHand(tc,nil,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([ally,top,filler,17228909].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-level'))source=source.replace('and c:IsLevelBelow(3) and c:IsDestructable()','and c:IsDestructable()');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);core.duelNewCard(duel,{team:test.opponent?1:0,duelist:0,code:top,controller:test.opponent?1:0,location:L.MZONE,sequence:0,position:test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(132161756*16+1));
     if(test.highlevel||test.wrongrace||test.opponent||test.facedown||test.xyz){assert.equal(index,-1,'Illegal Dinosaur destruction offered');done=true;continue;}
     if(!activated){assert(index>=0,'Discard/send unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.REMOVED).some(x=>x.code===boss&&(x.reason&0x80)),'Banish cost missing');assert(query(L.GRAVE).some(x=>x.code===top&&(x.reason&1)&&(x.reason&0x40)),'Dinosaur not destroyed');assert(!trace.some(x=>x.type===M.BECOME_TARGET),'Non-targeting effect targeted');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){assert(!p.selects.some(x=>x.code===boss),'Same-name send target offered');const index=p.selects.findIndex(x=>x.code===top);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!!test.tokens});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let player=0,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){player=1;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(16+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location:L.MZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--any-level')?'any-level':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/lunalophosaur-destruction'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, production Lunalophosaur and actual candidate metadata; neutral Dinosaur target, actual banish cost and non-targeting destruction; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



