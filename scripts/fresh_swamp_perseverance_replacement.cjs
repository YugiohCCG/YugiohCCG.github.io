'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935100,ally=900001071,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{banish:true},{banish:true,facedown:true},{banish:true,decline:true},{banish:true,wrongattribute:true},{banish:true,wrongrace:true},{banish:true,opponent:true},{send:true},{banish:true,cost:true},{banish:true,noSwamp:true},{banish:true,converted:true},{banish:true,multiple:true},{banish:true,multiple:true,decline:true},{banish:true,hiddenSwamp:true},{banish:true,opponentSwamp:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(ally,{...base,code:ally,attribute:test.wrongattribute?4:2,race:test.wrongrace?1024n:524288n});cards.set(239935101,candidateCard(239935101));cards.set(900001021,{...base,code:900001021,type:0x80002,level:0});cards.set(top,{...base,code:top,type:65538,level:0});cards.set(refill,{...base,code:refill,type:65538,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil,'+(test.wrongcode?900001021:ally)+')'+(test.multiple?'':' :GetFirst()')+' '+(test.converted?'Duel.Hint(HINT_NUMBER,tp,tc:IsType(TYPE_SPELL) and tc:IsType(TYPE_CONTINUOUS) and not tc:IsType(TYPE_MONSTER) and 701 or 700) ':'')+(test.banish?'Duel.Remove(tc,'+(test.facedown?'POS_FACEDOWN':'POS_FACEUP')+','+(test.cost?'REASON_COST':'REASON_EFFECT')+')':test.send?'Duel.SendtoGrave(tc,REASON_EFFECT)':'Duel.Destroy(tc,REASON_EFFECT)')+' end) c:RegisterEffect(e) end';
   if(name==='c900001021.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+ally+'.lua'&&test.converted)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_CHANGE_TYPE) e:SetProperty(EFFECT_FLAG_CANNOT_DISABLE) e:SetValue(TYPE_SPELL+TYPE_CONTINUOUS) e:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET) c:RegisterEffect(e) end';
   if([ally,filler,239935101].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--first-zone-only'))source=source.replace('return s.repfilter(c,e:GetHandlerPlayer())','return c:GetSequence()==0 and s.repfilter(c,e:GetHandlerPlayer())');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--current-monster-only'))source=source.replace('c:IsControler(tp) and c:IsLocation(LOCATION_ONFIELD) and c:IsFaceup() and c:IsOriginalType(TYPE_MONSTER)', 'c:IsControler(tp) and c:IsLocation(LOCATION_ONFIELD) and c:IsFaceup() and c:IsType(TYPE_MONSTER)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-water-reptile'))source=source.replace('c:IsControler(tp) and c:IsLocation(LOCATION_ONFIELD) and c:IsFaceup() and c:IsOriginalType(TYPE_MONSTER) and s.waterreptile(c)', 'c:IsControler(tp) and c:IsLocation(LOCATION_ONFIELD) and c:IsFaceup() and c:IsOriginalType(TYPE_MONSTER)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-swamp-condition'))source=source.replace('e2:SetCondition(s.repcon)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-replacement'))source=source.replace('e2:SetTarget(s.reptg)','e2:SetTarget(function() return false end)').replace('e3:SetTarget(s.remtg)','e3:SetTarget(function() return false end)');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);add(refill,L.HAND);add(ally,test.converted?L.SZONE:L.MZONE,test.opponent?1:0);
   if(test.multiple)core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});
   if(!test.noSwamp)core.duelNewCard(duel,{team:test.opponentSwamp?1:0,duelist:0,code:239935101,controller:test.opponentSwamp?1:0,location:L.SZONE,sequence:5,position:test.hiddenSwamp?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===refill);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.converted)assert(trace.some(x=>x.type===M.HINT&&Number(x.hint)===701),'Victim not actually converted before banishment');
     const protects=!(test.decline||test.wrongattribute||test.wrongrace||test.opponent||test.send||test.cost||test.noSwamp||test.hiddenSwamp||test.opponentSwamp);
     const victim=test.wrongcode?900001021:ally,controller=test.opponent?1:0;
     const field=core.duelQueryLocation(duel,{flags:Q.CODE,controller,location:test.converted?L.SZONE:L.MZONE}).filter(Boolean);assert.equal(field.filter(x=>x.code===victim).length,protects?(test.multiple?2:1):0,'Victim preservation mismatch');
     assert.equal(query(L.REMOVED).some(x=>x.code===boss),protects,'Replacement Rage banishment mismatch');if(protects){assert.equal(query(L.REMOVED).filter(x=>x.code===boss).length,1,'More than one replacement source paid');const rage=query(L.REMOVED).find(x=>x.code===boss);assert(rage.reason&0x40,'Replacement not effect banishment');assert(rage.reason&0x1000000,'Replacement reason missing');assert.equal(rage.reason&0x80,0,'Replacement incorrectly treated as cost');}assert.equal(query(L.GRAVE).some(x=>x.code===boss),!protects,'Rage GY state mismatch');
     if(!protects){const dest=core.duelQueryLocation(duel,{flags:Q.CODE,controller,location:test.banish?L.REMOVED:L.GRAVE}).filter(Boolean);assert.equal(dest.filter(x=>x.code===victim).length,test.multiple?2:1,'Unprotected victim group did not move');}done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss,'Unexpected replacement card');assert(!(test.wrongattribute||test.wrongrace||test.opponent||test.send||test.cost||test.noSwamp||test.hiddenSwamp||test.opponentSwamp),'Illegal replacement choice');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_YESNO){assert(!(test.wrongattribute||test.wrongrace||test.opponent||test.send||test.cost||test.noSwamp||test.hiddenSwamp||test.opponentSwamp),'Illegal replacement choice');core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--first-zone-only')?'first-zone-only':process.argv.includes('--current-monster-only')?'current-monster-only':process.argv.includes('--any-water-reptile')?'any-water-reptile':process.argv.includes('--no-swamp-condition')?'no-swamp-condition':process.argv.includes('--no-replacement')?'no-replacement':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-perseverance-replacement'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Perseverance/candidate metadata, neutral Terrifying Dark Swamp script with actual candidate metadata in field slot; neutral WATER Reptile victim and actual banishment/send attempts; does not certify Swamp production script or native Omega',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



