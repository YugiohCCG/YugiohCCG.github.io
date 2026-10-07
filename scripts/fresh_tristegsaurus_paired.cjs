'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244162598,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{spellVictim:true},{secondCopy:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(top,{...base,code:top,type:test.spellVictim?0x20002:33});cards.set(ally,{...base,code:ally,race:test.wrongRace?1024n:131072n});
  cards.set(900001097,{...base,code:900001097});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+boss+'):GetFirst() tc:CompleteProcedure() Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) local p=e:Clone() p:SetDescription(1) c:RegisterEffect(p) end';
   if([ally,top,filler,900001097].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name==='constant.lua')source=source.replace(/(CHAININFO_TARGET_CARDS\s*=)0x40/,'$1 8');if(name==='c'+boss+'.lua'){if(process.argv.includes('--no-count'))source=source.replace('e1:SetCountLimit(1,id)','do end');if(process.argv.includes('--monster-only'))source=source.replace('Duel.IsExistingTarget(Card.IsDestructable,tp,0,LOCATION_ONFIELD','Duel.IsExistingTarget(function(c) return c:IsType(TYPE_MONSTER) and c:IsDestructable() end,tp,0,LOCATION_ONFIELD');if(process.argv.includes('--no-destroy'))source=source.replace('Duel.Destroy(g,REASON_EFFECT)','0');if(process.argv.includes('--wrong-owner'))source=source.replace('sc:GetOwner()','tp');if(process.argv.includes('--no-summon'))source=source.replace('Duel.SpecialSummonStep(sc,0,tp,sc:GetOwner(),false,false,POS_FACEUP)','do end');}return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);if(test.secondCopy)add(boss,L.GRAVE);add(refill,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});add(top,test.spellVictim?L.SZONE:L.MZONE,1);if(test.spellVictim)add(900001097,L.GRAVE,1);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!activated){const index=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='0');assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     for(const code of [ally,top])assert(trace.some(x=>x.type===M.MOVE&&x.card===code&&x.from.location===(code===top&&test.spellVictim?L.SZONE:L.MZONE)&&x.to.location===L.GRAVE),'Target not destroyed');
     for(const [code,controller] of [[ally,0],[test.spellVictim?900001097:top,1]]){
      assert(trace.some(x=>x.type===M.MOVE&&x.card===code&&x.from.location===L.GRAVE&&x.to.location===L.MZONE&&x.to.controller===controller),'Owner-field revival missing');
     }if(test.secondCopy){if(!repeated){assert.equal(query(L.GRAVE).filter(x=>x.code===boss).length,1,'Spare source missing');const ii=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='1');assert(ii>=0);repeated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:ii});continue;}assert.equal(query(L.MZONE).filter(x=>x.code===boss).length,2,'Second source not actually Summoned');for(const code of [ally,top])assert.equal(trace.filter(x=>x.type===M.MOVE&&x.card===code&&x.from.location===L.MZONE&&x.to.location===L.GRAVE).length,1,'Shared trigger repeated destruction');}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===(p.selects.some(x=>x.code===ally)?ally:p.selects.some(x=>x.code===900001097)?900001097:top));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_PLACE){let player=p.player,location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(16+i)))===0);if(sequence!==undefined)player=1-p.player;}if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-count')?'no-count':process.argv.includes('--monster-only')?'monster-only':process.argv.includes('--no-destroy')?'no-destroy':process.argv.includes('--wrong-owner')?'wrong-owner':process.argv.includes('--no-summon')?'no-summon':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/tristegsaurus-paired'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:'In-memory pinned constant.lua CHAININFO_TARGET_CARDS 0x40 mapped to public core enum8; production unchanged',engine:'Public core full Tristegsaurus production/candidate; fixture Special Summon then targeted destruction and owner-field paired revival with neutral cards; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



