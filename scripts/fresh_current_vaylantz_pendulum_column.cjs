'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod,core=await mod.default({sync:true,print(){},printErr(){}});
 const prep=900002101,fusion=900002102,material=900002103,filler=900002104,response=900002105,late=900002106;
 const control=['no-response','wrong-column','no-condition'].find(c=>process.argv.includes('--'+c)),results=[];
 for(const boss of [259882493,259537607])for(const side of [0,4])for(const scenario of ['baseline','full','activation','effect','sourceBanish','lateOccupied',...(boss===259537607?['noFusion','wrongSet','wrongType','facedownFusion']:[])]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[prep,{...base,code:prep,type:33}],[fusion,{...base,code:fusion,type:scenario==='wrongType'?33:0x41,setcodes:scenario==='wrongSet'?[]:[0x17d]}],[material,{...base,code:material,setcodes:[0x17d]}],[filler,{...base,code:filler}],[response,{...base,code:response,type:0x100004}],[late,{...base,code:late}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+prep+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local pc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND+LOCATION_EXTRA,0,nil,${boss}) ${boss===259882493?`local mat=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${material}) assert(#mat==2) pc:SetMaterial(mat) Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) assert(Duel.SpecialSummon(pc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0) pc:CompleteProcedure() assert(pc:IsSummonType(SUMMON_TYPE_FUSION)) Duel.Hint(HINT_NUMBER,tp,701)` :''} assert(Duel.MoveToField(pc,tp,tp,LOCATION_PZONE,POS_FACEUP,true,1<<${side===0?0:1})) end) c:RegisterEffect(e) end`;
   if(name==='c'+response+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:IsHasType(EFFECT_TYPE_IGNITION) and re:GetHandler():IsCode(${boss}) and re:GetHandler():IsLocation(LOCATION_PZONE) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':scenario==='activation'?'Duel.NegateActivation(ev)':scenario==='effect'?'Duel.NegateEffect(ev)':scenario==='sourceBanish'?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':`Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,${late}),0,1-tp,1-tp,false,false,POS_FACEUP,1<<${side})`} end) c:RegisterEffect(e) end`;
   if([fusion,material,filler,late].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){if(control==='wrong-column')lua=lua.replaceAll('1<<c:GetSequence()','1<<3');if(control==='no-condition'&&boss===259537607)lua=lua.replace('e1:SetCondition(s.pcon);','');}return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),String(code));return cards.get(code);},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=false,activated=false,interrupted=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,boss===259882493?L.EXTRA:L.HAND,0,P.FACEDOWN_DEFENSE);add(prep,L.MZONE,0,P.FACEUP_ATTACK,2);
   if(boss===259882493){add(material,L.HAND);add(material,L.HAND);}else if(scenario!=='noFusion')add(fusion,L.MZONE,0,scenario==='facedownFusion'?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);
   if(scenario==='full')for(const seq of [0,1,3,4])if(!(boss===259537607&&seq===1))add(filler,L.MZONE,0,P.FACEUP_ATTACK,seq);
   if(['activation','effect','sourceBanish','lateOccupied'].includes(scenario))add(response,L.SZONE,1,P.FACEDOWN_DEFENSE,1);
   if(scenario==='lateOccupied')add(late,L.DECK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location}).map((c,sequence)=>c&&({...c,sequence})).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(c=>c.code===prep);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(boss===259882493)assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===701),'Actual prior Fusion history');
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.SZONE);const eligible=!['full','noFusion','wrongSet','wrongType','facedownFusion'].includes(scenario);assert.equal(index>=0,eligible,'Printed same-column summon eligibility');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const monster=query(L.MZONE).find(c=>c.code===boss);assert.equal(!!monster,scenario==='baseline','Actual Pendulum self-summon');if(monster)assert.equal(monster.sequence,side,'Same column');
     assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===response&&m.chain_size===2).length,scenario==='baseline'?0:1,'Actual native responseCL2');
     if(scenario==='sourceBanish')assert(query(L.REMOVED).some(c=>c.code===boss),'Actual source removed');
     if(scenario==='lateOccupied'){const blocker=query(L.MZONE).find(c=>c.code===late);assert(blocker,'Actual late blocker');assert.equal(blocker.sequence,side,'Actual target column occupied');}
     done=true;
    }else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:0});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===response);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({passcode:boss,side,scenario,failure,trace,logs});if(failure)console.log('FAIL '+boss+' '+side+' '+scenario+': '+failure);
 }
 fs.writeFileSync(path.join(OUT,'current-vaylantz-pendulum-column'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Two complete production scripts: native PZone placement left/right, actual same-column summons and CL2 interruptions/late target occupancy; Arktos Fusion condition boundaries. Patrician neutral actual two Vaylantz material Fusion history; production Fusion recipe and alternative move/coin/monster effects remain open. No API shim/live Omega/full-card certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');console.log(JSON.stringify({cases:results.length,passed:results.filter(r=>!r.failure).length}));if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
