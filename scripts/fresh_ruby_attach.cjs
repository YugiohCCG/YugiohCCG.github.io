'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244163206,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{grave:true},{field:true},{wrongSet:true},{maxGroup:true},{opponentGroup:true},{opponentGroup:true,decline:true},{detach:true},{secondCopy:true},{opponentGroup:true,dualType:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(top,{...base,code:top,type:test.spellVictim?0x20002:33});cards.set(ally,{...base,code:ally,setcodes:test.wrongSet?[]:[0xa120]});
  for(const code of [900001101,900001102,900001103,900001104])cards.set(code,{...base,code,type:code===900001102?4:33});
  for(const code of [900001105,900001106,900001107,900001108,900001109])cards.set(code,{...base,code,type:code===900001106||code===900001109?0x20002:code===900001107?4:33});
  cards.set(900001110,{...base,code:900001110,setcodes:[0xa120]});
  const reader=name=>{
   if(name==='c900001105.lua'&&test.dualType)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_ADD_TYPE) e:SetValue(TYPE_TRAP) c:RegisterEffect(e) end';
   if(name==='c'+refill+'.lua'&&test.dualType)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE,nil,900001105):GetFirst() Duel.Hint(HINT_NUMBER,tp,tc:IsType(TYPE_MONSTER) and tc:IsType(TYPE_TRAP) and 701 or 700) end) c:RegisterEffect(e) end';
   if(name==='c'+refill+'.lua'&&test.secondCopy)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+boss+'):GetFirst() tc:CompleteProcedure() Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) end';
   if(name==='c'+top+'.lua'&&test.detach)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+'):GetFirst():RemoveOverlayCard(tp,1,1,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([ally,top,filler,900001101,900001102,900001103,900001104,900001105,900001106,900001107,900001108,900001109,900001110].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--monster-first-only'))source=source.replace('cards[i]:IsType(types[j])','cards[i]:IsType(types[j]) and (j==1 or not cards[i]:IsType(TYPE_MONSTER))');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-count'))source=source.replace('e4:SetCountLimit(1,id+100)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-defense'))source=source.replace('c:RegisterEffect(e2)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-stats'))source=source.replace('GetOverlayCount()*200','GetOverlayCount()*0');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--opponent-two-fields'))source=source.replace('g:FilterCount(Card.IsLocation,nil,LOCATION_ONFIELD)>1','g:FilterCount(Card.IsLocation,nil,LOCATION_ONFIELD)>2');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--opponent-any-types'))source=source.replace('return assign(1,0)','return true');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--five-allowed'))source=source.replace('s.owncheck,false,1,4','s.owncheck,false,1,5');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--two-fields'))source=source.replace('g:FilterCount(Card.IsLocation,nil,LOCATION_ONFIELD)<=1','g:FilterCount(Card.IsLocation,nil,LOCATION_ONFIELD)<=2');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-set'))source=source.replace('and c:IsSetCard(0xa120)','');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-overlay'))source=source.replace('Duel.Overlay(c,sg)','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:test.grave?L.GRAVE:test.field?L.MZONE:L.HAND,sequence:1,position:P.FACEUP_ATTACK});
   if(test.maxGroup){core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});core.duelNewCard(duel,{team:0,duelist:0,code:900001104,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});add(900001101,L.GRAVE);add(900001102,L.HAND);add(900001103,L.HAND);}
   if(test.opponentGroup){add(900001105,L.MZONE,1);add(900001109,L.SZONE,1);add(900001106,L.GRAVE,1);add(900001107,L.GRAVE,1);add(900001108,L.GRAVE,1);}
   if(test.detach)core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});
   if(test.secondCopy){add(boss,L.GRAVE);add(900001110,L.HAND);core.duelNewCard(duel,{team:0,duelist:0,code:refill,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});}
   if(test.dualType)core.duelNewCard(duel,{team:0,duelist:0,code:refill,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const index=p.activates.findIndex(x=>x.code===boss);
     if(test.dualType&&!prepared){const ii=p.activates.findIndex(x=>x.code===refill);assert(ii>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:ii});continue;}if(test.dualType)assert(trace.some(x=>x.type===M.HINT&&Number(x.hint)===701),'Opponent not natively Monster and Trap');
     if(test.wrongSet){assert.equal(index,-1,'Non-Killamity attachment offered');done=true;continue;}
     if(test.secondCopy&&repeated){assert.equal(query(L.MZONE).filter(x=>x.code===boss).length,2,'Second Ruby not actually Summoned');assert(query(L.HAND).some(x=>x.code===900001110),'Spare Killamity resource missing');if(turn===1){assert.equal(index,-1,'Second-copy attachment offered');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(turn>=3);assert(index>=0,'Attachment did not renew next own turn');done=true;continue;}
     if(test.detach&&repeated){const host=query(L.MZONE).find(x=>x.code===boss);assert.equal(host.overlayCards.length,0,'Material not detached');assert.equal(host.attack,cards.get(boss).attack,'ATK bonus persisted');assert.equal(host.defense,cards.get(boss).defense,'DEF bonus persisted');assert(query(L.GRAVE).some(x=>x.code===ally),'Detached material missing');done=true;continue;}
     if(!activated){const host=query(L.MZONE).find(x=>x.code===boss);assert.equal(host.attack,cards.get(boss).attack);assert.equal(host.defense,cards.get(boss).defense);assert(index>=0,'Ruby unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const host=query(L.MZONE).find(x=>x.code===boss);assert.equal(host.overlayCards.length,test.maxGroup?4:test.opponentGroup&&!test.decline?4:1,'Own card not attached');assert.equal(host.attack,cards.get(boss).attack+200*host.overlayCards.length,'Overlay ATK bonus mismatch');assert.equal(host.defense,cards.get(boss).defense+200*host.overlayCards.length,'Overlay DEF bonus mismatch');assert(trace.some(x=>x.type===M.MOVE&&x.card===ally&&x.from.location===(test.grave?L.GRAVE:test.field?L.MZONE:L.HAND)&&x.to.overlay_sequence!==undefined),'Attachment origin missing');if(test.maxGroup){assert(query(L.MZONE).some(x=>x.code===900001104),'Second field card attached');assert.equal(trace.filter(x=>x.type===M.MOVE&&x.from.location===L.MZONE&&x.to.overlay_sequence!==undefined).length,1,'More than one field attachment');}if(test.opponentGroup){const eq=loc=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:loc}).filter(Boolean);assert.equal(eq(L.GRAVE).some(x=>x.code===900001108),!test.dualType,'Opponent Monster dual-slot assignment mismatch');if(test.dualType)assert(eq(L.GRAVE).some(x=>x.code===900001107),'Separate Trap should remain');assert(eq(L.SZONE).some(x=>x.code===900001109),'Second opponent field card selected');for(const [code,loc] of [[900001105,L.MZONE],[900001106,L.GRAVE],[test.dualType?900001108:900001107,L.GRAVE]])assert.equal(trace.some(x=>x.type===M.MOVE&&x.card===code&&x.from.location===loc&&x.to.overlay_sequence!==undefined),!test.decline,'Opponent attachment origin/decline mismatch');}if(test.secondCopy){const ii=p.activates.findIndex(x=>x.code===refill);assert(ii>=0);repeated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:ii});continue;}if(test.detach){const ii=p.activates.findIndex(x=>x.code===top);assert(ii>=0);repeated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:ii});continue;}done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_UNSELECT_CARD){const priorities=test.maxGroup?[ally,top,900001104,900001101,900001102,900001103]:test.opponentGroup?[ally,900001105,900001109,900001108,900001106,900001107]:[ally];let index=-1;for(const code of priorities){index=p.select_cards.findIndex(x=>x.code===code);if(index>=0)break;}assert(index>=0||p.can_finish,'No valid subgroup selection');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:index>=0?index:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===(test.selfCost&&p.selects.some(x=>x.code===boss)?boss:p.selects.some(x=>x.code===ally)?ally:top));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO){assert(!(test.handCost||test.graveCost),'Non-field cost incorrectly offers banishment');core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--monster-first-only')?'monster-first-only':process.argv.includes('--no-count')?'no-count':process.argv.includes('--no-defense')?'no-defense':process.argv.includes('--no-stats')?'no-stats':process.argv.includes('--opponent-two-fields')?'opponent-two-fields':process.argv.includes('--opponent-any-types')?'opponent-any-types':process.argv.includes('--five-allowed')?'five-allowed':process.argv.includes('--two-fields')?'two-fields':process.argv.includes('--any-set')?'any-set':process.argv.includes('--no-overlay')?'no-overlay':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/ruby-attach'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Ruby/candidate, actual attachment of neutral Killamity from hand/field/GY; no actual Xyz procedure',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



