'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935097,ally=900001021,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{unrelated:true},{summon:true},{cost:true},{normal:true},{normal:true,fieldrecipient:true},{normal:true,selfplace:true},{highlevel:true},{nomention:true},{spell:true},{full:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:test.spell?2:33,level:test.highlevel?4:2});cards.set(ally,{...base,code:ally,attribute:2,race:524288n});cards.set(900001030,{...base,code:900001030});cards.set(refill,{...base,code:refill,type:65538,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) '+(!test.unrelated?'aux.AddCodeList(c,239935101) ':'')+'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) '+(test.cost?'e:SetCost(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_COST) end) ':'')+'e:SetOperation(function(e,tp) '+(test.cost?'Duel.Recover(tp,100,REASON_EFFECT)':test.summon?'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)':'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_EFFECT)')+' end) c:RegisterEffect(e) end';

   if(name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) '+(test.nomention?'':'aux.AddCodeList(c,239935101) ')+'end';
   if(name==='c900001030.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+(test.selfplace?boss:ally)+'):GetFirst() Duel.Hint(HINT_NUMBER,tp,tc and tc:IsType(TYPE_SPELL) and tc:IsType(TYPE_CONTINUOUS) and not tc:IsType(TYPE_MONSTER) and 701 or 700) end) c:RegisterEffect(e) end';
   if([ally,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&test.self)source=source.replace('aux.AddCodeList(c,SWAMP)', 'aux.AddCodeList(c,SWAMP) local f=Effect.CreateEffect(c) f:SetType(EFFECT_TYPE_IGNITION) f:SetCode(EVENT_FREE_CHAIN) f:SetRange(LOCATION_MZONE) f:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_EFFECT) end) c:RegisterEffect(f)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--allow-self'))source=source.replace('return mentions and not rc:IsCode(id)','return mentions');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-source'))source=source.replace('return re and s.mentions(re:GetHandler())','return re~=nil');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-level'))source=source.replace('and c:GetLevel()<=3','');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-type-change'))source=source.replace('c:RegisterEffect(change)','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(refill,L.HAND);add(top,L.DECK);if(test.fieldrecipient)core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});else add(ally,L.GRAVE);core.duelNewCard(duel,{team:0,duelist:0,code:900001030,controller:0,location:L.MZONE,sequence:4,position:P.FACEUP_ATTACK});
   if(test.full)for(let sequence=0;sequence<5;sequence++)core.duelNewCard(duel,{team:0,duelist:0,code:refill,controller:0,location:L.SZONE,sequence,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated&&(test.normal||test.full)){const index=p.summons.findIndex(x=>x.code===boss);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});continue;}
     if(!activated){const index=p.activates.findIndex(x=>x.code===(test.self?boss:refill));assert(index>=0,'Fixture activation unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const valid=!(test.unrelated||test.highlevel||test.nomention||test.spell||test.full);
     assert.equal(query(L.HAND).some(x=>x.code===top),valid,'Low-Level search result mismatch');
     assert.equal(query(L.SZONE).some(x=>x.code===(test.selfplace?boss:ally)),valid,'Recipient placement mismatch');
     if(!valid){done=true;continue;}
     if(!(test.normal||test.summon)){assert(query(L.GRAVE).some(x=>x.code===boss&&(x.reason&(test.cost?0x80:0x40))),'Actual source send reason missing');}
     const moved=trace.find(x=>x.type===M.MOVE&&x.card===(test.selfplace?boss:ally)&&x.to.location===L.SZONE);assert(moved,'Placement movement missing');assert.equal(moved.from.location,test.selfplace||test.fieldrecipient?L.MZONE:L.GRAVE,'Wrong recipient origin');
     assert(trace.some(x=>x.type===M.CONFIRM_CARDS&&x.cards.some(c=>c.code===top)),'Search card not revealed');
     if(!refilled){const pi=p.activates.findIndex(x=>x.code===900001030);assert(pi>=0);refilled=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}
     assert(trace.some(x=>x.type===M.HINT&&x.hint_type===9&&Number(x.hint)===701),'Placed card not Continuous Spell');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss&&String(x.description)===String(133935097*16));if(test.unrelated||test.highlevel||test.nomention||test.spell||test.full)assert.equal(index,-1,'Unrelated source triggered destruction');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===(p.selects.some(x=>x.location===L.DECK)?top:test.selfplace?boss:ally));assert(index>=0,'Destruction target absent');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===boss){assert(!(test.unrelated||test.highlevel||test.nomention||test.spell||test.full),'Excluded source offered trigger');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}else core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--any-source')?'any-source':process.argv.includes('--any-level')?'any-level':process.argv.includes('--no-type-change')?'no-type-change':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-threeheaded-placement'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Three-Headed Snake/candidate metadata; neutral mention source and search/recipient cards, actual Normal/Special/GY send, Continuous Spell placement/type and search; banishment once-per-Duel branch/native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



