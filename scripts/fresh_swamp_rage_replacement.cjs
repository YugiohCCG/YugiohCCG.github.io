'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935099,ally=239935101,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{banish:true},{banish:true,facedown:true},{decline:true},{banish:true,decline:true},{wrongcode:true},{opponent:true},{send:true},{banish:true,cost:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(ally,candidateCard(ally));cards.set(900001021,{...base,code:900001021,type:0x80002,level:0});cards.set(top,{...base,code:top,type:65538,level:0});cards.set(refill,{...base,code:refill,type:65538,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil,'+(test.wrongcode?900001021:ally)+'):GetFirst() '+(test.banish?'Duel.Remove(tc,'+(test.facedown?'POS_FACEDOWN':'POS_FACEUP')+','+(test.cost?'REASON_COST':'REASON_EFFECT')+')':test.send?'Duel.SendtoGrave(tc,REASON_EFFECT)':'Duel.Destroy(tc,REASON_EFFECT)')+' end) c:RegisterEffect(e) end';
   if(name==='c900001021.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if([ally,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-replacement'))source=source.replace('e2:SetTarget(s.reptg)','e2:SetTarget(function() return false end)').replace('e3:SetTarget(s.remtg)','e3:SetTarget(function() return false end)');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);add(refill,L.HAND);core.duelNewCard(duel,{team:test.opponent?1:0,duelist:0,code:test.wrongcode?900001021:ally,controller:test.opponent?1:0,location:L.SZONE,sequence:5,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===refill);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const protects=!(test.decline||test.wrongcode||test.opponent||test.send||test.cost);
     const victim=test.wrongcode?900001021:ally,controller=test.opponent?1:0;
     const field=core.duelQueryLocation(duel,{flags:Q.CODE,controller,location:L.SZONE}).filter(Boolean);assert.equal(field.some(x=>x.code===victim),protects,'Swamp preservation mismatch');
     assert.equal(query(L.REMOVED).some(x=>x.code===boss),protects,'Replacement Rage banishment mismatch');if(protects){const rage=query(L.REMOVED).find(x=>x.code===boss);assert(rage.reason&0x40,'Replacement not effect banishment');assert(rage.reason&0x1000000,'Replacement reason missing');assert.equal(rage.reason&0x80,0,'Replacement incorrectly treated as cost');}assert.equal(query(L.GRAVE).some(x=>x.code===boss),!protects,'Rage GY state mismatch');
     if(!protects){const dest=core.duelQueryLocation(duel,{flags:Q.CODE,controller,location:test.banish?L.REMOVED:L.GRAVE}).filter(Boolean);assert(dest.some(x=>x.code===victim),'Unprotected victim did not move');}done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss,'Unexpected replacement card');assert(!(test.wrongcode||test.opponent||test.send||test.cost),'Illegal replacement choice');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_YESNO){assert(!(test.wrongcode||test.opponent||test.send||test.cost),'Illegal replacement choice');core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-replacement')?'no-replacement':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-rage-replacement'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Rage/candidate metadata, neutral Terrifying Dark Swamp script with actual candidate metadata in field slot; neutral fixture actual destruction/banishment/send attempts; does not certify Swamp production script or native Omega',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



