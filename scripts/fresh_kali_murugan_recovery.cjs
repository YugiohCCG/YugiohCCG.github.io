'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=247755869,ally=900001021,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{pay:true},{self:true},{unrelated:true},{send:true},{hand:true},{opponent:true},{spell:true},{lost:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(ally,{...base,code:ally,setcodes:test.unrelated?[]:[0xa121],type:test.spell?2:33});cards.set(top,{...base,code:top,type:65538,level:0});cards.set(refill,{...base,code:refill,type:65538,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND+LOCATION_ONFIELD,LOCATION_ONFIELD,nil,'+ally+'):GetFirst() '+(test.send?'Duel.SendtoGrave(tc,REASON_EFFECT)':'Duel.Destroy(tc,REASON_EFFECT)')+' end) c:RegisterEffect(e) end';

   if(name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetCondition(function(e,tp) return Duel.GetCurrentChain()>0 and Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,1,nil,'+boss+') end) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+boss+'):GetFirst() Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([ally,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-payment'))source=source.replace('Duel.PayLPCost(tp,2000)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-destruction'))source=source.replace('return eg:IsExists(s.destroyed,1,nil,tp)','return true');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--separate-count'))source=source.replace('e2:SetCountLimit(1,id)','e2:SetCountLimit(1,id+100)');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);add(filler,L.HAND);add(refill,L.HAND);if(test.lost)add(top,L.HAND);core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:test.opponent?1:0,team:test.opponent?1:0,location:test.hand?L.HAND:test.spell?L.SZONE:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===refill);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const valid=!(test.send||test.unrelated||test.hand||test.opponent||test.spell);
     assert.equal(query(L.HAND).some(x=>x.code===boss),valid&&!test.lost&&!test.self,'Murugan return mismatch');
     const payments=trace.filter(x=>x.type===M.PAY_LPCOST);assert.equal(payments.length,valid&&test.pay?1:0,'Payment mismatch');if(valid&&test.pay)assert.equal(payments[0].amount,2000);
     const resource=query(L.GRAVE).some(x=>x.code===filler&&(x.reason&1)&&(x.reason&0x40));assert.equal(resource,valid&&!test.lost&&!test.pay&&!test.self,'Follow-up destruction mismatch');
     if(test.self){assert(query(L.GRAVE).some(x=>x.code===boss&&(x.reason&1)&&(x.reason&0x40)),'Returned source not destroyed');const moves=trace.filter(x=>x.type===M.MOVE&&x.card===boss);assert(moves.some(x=>x.from.location===L.GRAVE&&x.to.location===L.HAND),'Source not actually returned before destruction');assert(moves.some(x=>x.from.location===L.HAND&&x.to.location===L.GRAVE),'Returned source not sent after destruction');}
     if(valid&&!test.lost&&!test.self){assert.equal(p.activates.some(x=>x.code===boss),false,'Recovery did not consume shared revival limit');}
     if(test.lost){assert(query(L.REMOVED).some(x=>x.code===boss));assert(trace.some(x=>x.type===M.CHAINING&&x.code===top&&x.chain_size===2));}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);if(test.send||test.unrelated||test.hand||test.opponent||test.spell)assert.equal(index,-1,'Illegal recovery trigger offered');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:test.lost&&p.selects.some(x=>x.code===top)?p.selects.findIndex(x=>x.code===top):p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===(test.self?boss:filler));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.pay?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===boss)assert(!(test.send||test.unrelated||test.hand||test.opponent||test.spell),'Illegal trigger offered');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===boss});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-payment')?'no-payment':process.argv.includes('--any-destruction')?'any-destruction':process.argv.includes('--separate-count')?'separate-count':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/kali-murugan-recovery'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, production Murugan and actual candidate metadata; neutral fixture Spell destroys/sends Kali resource; GY return then destruction/payment, battle and native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



