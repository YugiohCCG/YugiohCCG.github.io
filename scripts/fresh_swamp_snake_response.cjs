'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),ally=900001021,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [239935095,239935096].flatMap(boss=>["none","grave","field","facedown"].map(swamp=>({boss,swamp})))){
 const boss=test.boss,swamp=239935101,msg=132000000+boss%2000000;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:boss===239935095?0x20002:33});cards.set(ally,{...base,code:ally,type:boss===239935095?0x20002:33});cards.set(swamp,candidateCard(swamp));cards.set(refill,{...base,code:refill,type:65538,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) '+(!test.unrelated?'aux.AddCodeList(c,239935101) ':'')+'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) '+(test.cost?'e:SetCost(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_COST) end) ':'')+'e:SetOperation(function(e,tp) '+(test.cost?'Duel.Recover(tp,100,REASON_EFFECT)':test.summon?'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)':'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_EFFECT)')+' end) c:RegisterEffect(e) end';

   if([top,ally].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE+LOCATION_SZONE) e:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([swamp,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-limit'))source=source.replace('Duel.SetChainLimit(function(re,rp,tp) return rp==tp or re:GetHandler()~=tc end)','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false,targeted=false,checked=false,chainOpen=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);if(test.self)add(boss,L.MZONE);else add(refill,L.HAND);add(top,boss===239935095?L.SZONE:L.MZONE,1);core.duelNewCard(duel,{team:1,duelist:0,code:ally,controller:1,location:boss===239935095?L.SZONE:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});if(test.swamp!=='none')core.duelNewCard(duel,{team:0,duelist:0,code:swamp,controller:0,location:test.swamp==='grave'?L.GRAVE:L.SZONE,sequence:test.swamp==='grave'?0:5,position:test.swamp==='facedown'?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages){if(m.type===M.NEW_TURN)turn++;if(m.type===M.CHAINING)chainOpen=true;if(m.type===M.CHAIN_END)chainOpen=false;}
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===(test.self?boss:refill));assert(index>=0,'Fixture activation unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const targetGone=core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:1,location:L.GRAVE}).filter(Boolean).some(x=>x.code===top&&(x.reason&1)&&(x.reason&0x40));assert.equal(targetGone,!(test.unrelated||test.self),'Destruction trigger mismatch');if(test.summon)assert(query(L.MZONE).some(x=>x.code===boss),'Actual Special Summon missing');else assert(query(L.GRAVE).some(x=>x.code===boss&&(x.reason&(test.cost?0x80:0x40))),'Actual send reason missing');assert(checked,'No opponent response prompt checked');done=true;
    }else if(p.type===M.SELECT_CHAIN){if(targeted&&chainOpen&&p.player===1){assert(p.selects.some(x=>x.code===ally),'Unrelated opponent response blocked');assert.equal(p.selects.some(x=>x.code===top),test.swamp==='none'||test.swamp==='facedown','Target response restriction mismatch');checked=true;}const index=p.selects.findIndex(x=>x.code===boss&&String(x.description)===String(msg*16+1));if(test.unrelated||test.self)assert.equal(index,-1,'Unrelated source triggered destruction');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===top);assert(index>=0,'Destruction target absent');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});targeted=true;}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===boss){assert(!(test.unrelated||test.self),'Excluded source offered trigger');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}else core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-limit')?'no-limit':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-snake-response'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, production Fierce Snake and candidate metadata; neutral mention-registered source and target; actual send/destruction and target response availability; Swamp is metadata-only fixture, native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



