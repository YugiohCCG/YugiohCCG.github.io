'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244163205,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{raceMatch:true},{distinctHolder:true},{noMatch:true},{wrongRank:true},{noMaterial:true},{spellMaterial:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(ally,{...base,code:ally,type:0x800021,level:test.wrongRank?11:12});cards.set(top,{...base,code:top,type:test.spellMaterial?2:33,attribute:2,race:524288n});cards.set(900001082,{...base,code:900001082,type:0x800021,level:4});cards.set(900001081,{...base,code:900001081,attribute:test.raceMatch?4:test.noMatch?4:2,race:test.raceMatch?524288n:1024n});cards.set(refill,{...base,code:refill});cards.set(filler,{...base,code:filler});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+(test.distinctHolder?900001082:ally)+'):GetFirst() tc:CompleteProcedure() '+(test.noMaterial?'':'for i=1,2 do Duel.Overlay(tc,Group.FromCards(Duel.CreateToken(tp,'+top+'))) end')+' end) c:RegisterEffect(e) end';
   if([ally,top,filler,900001081,900001082].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-material-type'))source=source.replace('c:IsType(TYPE_MONSTER) and (c:IsRace(victim:GetRace())', '(c:IsRace(victim:GetRace())');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-recipient-rank'))source=source.replace('c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetRank()==12','c:IsFaceup() and c:IsType(TYPE_XYZ)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--rank12-holder-only'))source=source.replace('c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:GetOverlayGroup()', 'c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:GetRank()==12 and c:GetOverlayGroup()');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-match'))source=source.replace('c:IsRace(victim:GetRace()) or c:IsAttribute(victim:GetAttribute())','true');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-overlay'))source=source.replace('Duel.Overlay(g:GetFirst(),Group.FromCards(tc))','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   core.duelNewCard(duel,{team:0,duelist:0,code:boss,controller:0,location:L.SZONE,sequence:0,position:P.FACEDOWN_DEFENSE});add(ally,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:refill,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});add(900001081,L.MZONE,1);if(test.distinctHolder)core.duelNewCard(duel,{team:0,duelist:0,code:900001082,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!prepared){const pi=p.activates.findIndex(x=>x.code===refill);assert(pi>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}
     if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(132163205*16));
     if(test.wrongRank||test.noMaterial||test.noMatch||test.spellMaterial){assert.equal(index,-1,'Invalid attachment offered');done=true;continue;}
     if(!activated){assert(index>=0,'Attachment unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(query(L.MZONE).find(x=>x.code===ally).overlayCards.length,test.distinctHolder?1:3,'Opponent monster not attached');
     if(test.distinctHolder)assert.equal(query(L.MZONE).find(x=>x.code===900001082).overlayCards.length,2,'Matching holder materials changed');
     const enemy=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.MZONE}).filter(Boolean);assert(!enemy.some(x=>x.code===900001081),'Opponent monster remained field');assert(trace.some(x=>x.type===M.MOVE&&x.card===900001081&&x.to.overlay_sequence!==undefined),'No actual overlay movement');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===900001081||x.code===ally);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--any-material-type')?'any-material-type':process.argv.includes('--any-recipient-rank')?'any-recipient-rank':process.argv.includes('--rank12-holder-only')?'rank12-holder-only':process.argv.includes('--any-match')?'any-match':process.argv.includes('--no-overlay')?'no-overlay':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/killamity-showdown-attachment'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Showdown/candidate metadata; neutral seeded Rank12 with fixture overlays/CompleteProcedure, not actual Xyz procedure certificate; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



