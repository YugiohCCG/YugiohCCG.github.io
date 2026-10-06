'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244162598,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{decline:true},{sendOnly:true},{interrupt:true},{interrupt:true,returnGY:true},{blocked:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(ally,{...base,code:ally,type:0x800021,level:test.wrongRank||test.wrongLeavingRank?11:12});cards.set(refill,{...base,code:refill});
  cards.set(top,{...base,code:top,type:2,level:0});cards.set(900001094,{...base,code:900001094,type:0x800021,level:12});
  cards.set(900001096,{...base,code:900001096,type:2,level:0});
  const reader=name=>{
   if(name==='c900001096.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,LOCATION_GRAVE,nil,'+boss+'):GetFirst() Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) '+(test.returnGY?'Duel.SendtoGrave(tc,REASON_EFFECT)':'')+' end) c:RegisterEffect(e) end';
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+'):GetFirst():CompleteProcedure() end) c:RegisterEffect(e) local p=e:Clone() p:SetDescription(1) p:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+filler+') Duel.SendtoGrave(g,REASON_EFFECT) end) c:RegisterEffect(p) end';
   if(name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,'+boss+'):GetFirst() '+(test.sendOnly?'Duel.SendtoGrave(tc,REASON_EFFECT)':'Duel.Destroy(tc,REASON_EFFECT)')+' '+(test.blocked?'for i=1,4 do local token=Duel.CreateToken(0,'+filler+') Duel.SpecialSummon(token,0,tp,0,true,false,POS_FACEUP) end':'')+' end) c:RegisterEffect(e) end';
   if([ally,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-revival'))source=source.replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--keep-schedule'))source=source.replace('ge:SetCountLimit(1)','ge:SetCountLimit(1)').replace('ge:SetReset(RESET_PHASE+PHASE_BATTLE_START)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--ignore-stay'))source=source.replace('and tc:GetFlagEffectLabel(id)==e:GetLabel()','');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--immediate'))source=source.replace(' local fid=c:GetFieldID()',' Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) local fid=c:GetFieldID()');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);add(top,L.HAND,1);if(test.interrupt)add(900001096,L.HAND,1);core.duelNewCard(duel,{team:0,duelist:0,code:refill,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    const battleStarts=trace.filter(x=>x.type===M.NEW_PHASE&&x.phase===8).length;
    if(test.blocked&&activated&&battleStarts>0&&p.type===M.SELECT_BATTLECMD){assert(query(L.GRAVE).some(x=>x.code===boss),'Blocked schedule wrongly revived');if(battleStarts>=2){done=true;continue;}core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:mod.SelectBattleCMDAction.TO_EP});continue;}
    if(test.blocked&&activated&&battleStarts>0&&p.type===M.SELECT_IDLECMD){
     assert(query(L.GRAVE).some(x=>x.code===boss),'Blocked schedule wrongly revived');
     if(battleStarts>=2){done=true;continue;}
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!repeated){assert.equal(query(L.MZONE).filter(x=>x.code===filler).length,4,'Blocking fixture not full');const ii=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='1');assert(ii>=0);repeated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:ii});continue;}
     assert.equal(query(L.MZONE).filter(x=>x.code===filler).length,0,'Blockers not removed');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP});continue;
    }
    if(!test.blocked&&activated&&battleStarts>0&&(p.type===M.SELECT_IDLECMD||p.type===M.SELECT_BATTLECMD)){assert.equal(query(L.MZONE).some(x=>x.code===boss),!(test.decline||test.sendOnly||test.interrupt),'Delayed revival mismatch');done=true;continue;}
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared&&p.player===0){const index=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='0');assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){const index=p.activates.findIndex(x=>x.code===top);if(index>=0){activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(test.interrupt&&!refilled){assert(query(L.GRAVE).some(x=>x.code===boss),'Source not GY before interruption');const ii=p.activates.findIndex(x=>x.code===900001096);assert(ii>=0);refilled=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:ii});continue;}
     assert(query(test.interrupt&&!test.returnGY?L.REMOVED:L.GRAVE).some(x=>x.code===boss),'Source moved before next Battle Phase');if(test.interrupt){assert(trace.some(x=>x.type===M.MOVE&&x.card===boss&&x.from.location===L.GRAVE&&x.to.location===L.REMOVED),'Interruption did not actually banish source');if(test.returnGY)assert(trace.some(x=>x.type===M.MOVE&&x.card===boss&&x.from.location===L.REMOVED&&x.to.location===L.GRAVE),'Interruption did not return source to GY');}assert(p.to_bp,'Battle Phase unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP});
    }else if(p.type===M.SELECT_BATTLECMD){
     const revives=!(test.decline||test.sendOnly||test.interrupt);assert.equal(query(L.MZONE).some(x=>x.code===boss),revives,'Delayed revival mismatch');
     if(revives)assert(trace.some(x=>x.type===M.MOVE&&x.card===boss&&x.from.location===L.GRAVE&&x.to.location===L.MZONE),'Revival origin missing');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);if(test.sendOnly)assert.equal(index,-1,'Send-only destruction trigger');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:!test.decline&&index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD)throw Error('Unexpected card selection');
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN){assert(!test.sendOnly,'Send-only trigger');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_PLACE){let player=p.player,location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(16+i)))===0);if(sequence!==undefined)player=1-p.player;}if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--keep-schedule')?'keep-schedule':process.argv.includes('--ignore-stay')?'ignore-stay':process.argv.includes('--no-revival')?'no-revival':process.argv.includes('--immediate')?'immediate':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/tristegsaurus-delay'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full production/candidate Tristegsaurus; fixture CompleteProcedure and opponent destruction; actual next Battle Phase progression',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



