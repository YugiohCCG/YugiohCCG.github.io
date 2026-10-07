'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=247755870,ally=900001021,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{opponent:true},{wrongattribute:true},{noFire:true},{full:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,setcodes:test.unrelated?[]:[0xa121]}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(ally,{...cards.get(ally),attribute:test.wrongattribute?2:4});cards.set(top,{...base,code:top,type:0x20002,level:0});if(test.full)cards.set(ally,{...cards.get(ally),type:0x20002,level:0});cards.set(refill,{...base,code:refill,type:33,level:2});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([ally,top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-redirect'))source=source.replace('c:RegisterEffect(e1,true)','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);if(!test.noFire)add(ally,L.GRAVE);core.duelNewCard(duel,{team:0,duelist:0,code:refill,controller:0,location:L.MZONE,sequence:3,position:P.FACEUP_ATTACK});if(test.full)for(let sequence=0;sequence<5;sequence++)core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:L.SZONE,sequence,position:P.FACEUP_ATTACK});for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(turn===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(test.opponent&&turn===2&&!activated){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const negative=test.wrongattribute||test.noFire||test.full;
     if(negative){assert(!query(L.SZONE).some(x=>x.code===boss),'Illegal placement occurred');assert(query(L.GRAVE).some(x=>x.code===boss),'Source left GY illegally');assert(!query(L.REMOVED).some(x=>x.code===ally),'Cost paid for invalid placement');done=true;continue;}
     if(!refilled){const placed=query(L.SZONE).find(x=>x.code===boss);assert(placed,'End Phase placement missing');assert(placed.position&P.FACEUP_ATTACK,'Source not face-up');assert(query(L.REMOVED).some(x=>x.code===ally&&(x.reason&0x80)),'FIRE banish cost missing');if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(x=>x.code===refill);assert(index>=0);refilled=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.REMOVED).some(x=>x.code===boss),'Placed source not banished on leaving');assert(!query(L.GRAVE).some(x=>x.code===boss),'Source reached GY despite redirect');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss&&String(x.description)===String(133755870*16+1));if(index>=0&&!(test.opponent&&turn===1)){assert(!(test.wrongattribute||test.noFire||test.full),'Invalid End Phase effect offered');activated=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0&&!(test.opponent&&turn===1)?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===(ally));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!(test.opponent&&turn===1)});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-redirect')?'no-redirect':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/kali-mayavada-placement'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, production Mayavada and actual candidate metadata; neutral Kali ally, actual End Phase FIRE cost/face-up placement and leave-field banishment; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



