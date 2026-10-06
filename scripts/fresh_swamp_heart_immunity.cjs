'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935093,ally=900001051,top=239935101,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{removeSwamp:true},{own:true},{noSwamp:true},{opponentSwamp:true},{facedownSwamp:true},{notcontinuous:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,candidateCard(top));cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:test.spell?2:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE+LOCATION_MZONE,LOCATION_SZONE+LOCATION_MZONE,nil,'+boss+'):GetFirst() '+(test.removeSwamp?'local swamp=Duel.GetMatchingGroup(Card.IsCode,0,LOCATION_ONFIELD,0,nil,'+top+'):GetFirst() Duel.SendtoGrave(swamp,REASON_EFFECT) ':'')+'Duel.Destroy(tc,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(name==='c900001030.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if([ally,top,filler,17228909].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-summon-count'))source=source.replace('e1:SetCountLimit(1,id)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-redirect'))source=source.replace('c:RegisterEffect(redirect,true)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-detach'))source=source.replace('e1:SetCost(s.placecost)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-type-change'))source=source.replace('c:RegisterEffect(change)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-redirect'))source=source.replace('c:RegisterEffect(redirect,true)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-protection'))source=source.replace('e3:SetTarget(s.deckreptg)','e3:SetTarget(function() return false end)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-reason'))source=source.replace('and c:IsReason(REASON_EFFECT) and not c:IsReason(REASON_REPLACE)','and not c:IsReason(REASON_REPLACE)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--protect-facedown'))source=source.replace('return c:IsFaceup() and c:IsControler(tp)','return c:IsControler(tp)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-immunity'))source=source.replace('e2:SetCondition(s.protectcon)','e2:SetCondition(function() return false end)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-player'))source=source.replace('return rp~=e:GetHandlerPlayer()','return true');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   if(test.notcontinuous)add(boss,L.SZONE);else add(boss,L.HAND);
   add(refill,L.MZONE,test.own?0:1);add(ally,L.DECK);if(!test.noSwamp)core.duelNewCard(duel,{team:test.opponentSwamp?1:0,duelist:0,code:top,controller:test.opponentSwamp?1:0,location:L.SZONE,sequence:5,position:test.facedownSwamp?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated&&!test.notcontinuous){const pi=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(133935093*16));assert(pi>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}
     if(!test.own&&turn===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!repeated){const ri=p.activates.findIndex(x=>x.code===refill);assert(ri>=0);repeated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:ri});continue;}
     const protectedCard=!(test.removeSwamp||test.own||test.noSwamp||test.opponentSwamp||test.facedownSwamp||test.notcontinuous);
     assert.equal(query(L.SZONE).some(x=>x.code===boss),protectedCard,'Heart destruction immunity mismatch');
     assert.equal(query(L.GRAVE).some(x=>x.code===boss&&(x.reason&1)&&(x.reason&0x40)),!protectedCard,'Actual effect destruction mismatch');
     if(test.removeSwamp)assert(query(L.GRAVE).some(x=>x.code===top),'Swamp not actually removed before destruction');
     assert(trace.some(x=>x.type===M.CHAINING&&x.code===refill&&x.triggering_controller===(test.own?0:1)),'Intended effect player not proven');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===ally||x.code===900001030);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.pay?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-immunity')?'no-immunity':process.argv.includes('--any-player')?'any-player':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-heart-immunity'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Heart/candidate metadata; actual placement except raw SZONE negative; neutral candidate Swamp fixture, actual own/opponent destruction ignition and effect-player chain asserted; does not certify Swamp production effects, native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



