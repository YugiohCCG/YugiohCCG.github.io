'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),boss=218142234,arms=238136421,united=215034223,probe=900004801,actor=900004802,response=900004803,filler=900004804,mats=[900004811,900004812,900004813];
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod,core=await mod.default({sync:true,print(){},printErr(){}}),results=[],control=['no-recovery','no-equip','no-response'].find(x=>process.argv.includes('--'+x));
 const cases=[{fusion:true},{fusion:true,equip:true},{},{equip:true},{united:true},{banishSource:true},{banishTarget:true},{negateActivation:true},{negateEffect:true}];
 for(const test of cases){
  const trace=[],logs=[],target=test.united?united:arms,base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:4n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[target,candidateCard(target)],[probe,{...base,code:probe}],[actor,{...base,code:actor,type:4}],[response,{...base,code:response,type:0x100004}],[filler,{...base,code:filler}],...mats.map((code,i)=>[code,{...base,code,setcodes:i<2?[0xb47]:[],type:i===2?0x1000021:33,race:i===2?128n:1n}])]);
  const interrupted=!!(test.banishSource||test.banishTarget||test.negateActivation||test.negateEffect);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+probe+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) ${test.fusion?`local fc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(${mats.join(',')}) end,tp,LOCATION_HAND,0,nil) assert(#g==3 and g:FilterCount(Card.IsSetCard,nil,0xb47)==2 and g:IsExists(function(c) return c:IsRace(RACE_PYRO) and c:IsType(TYPE_PENDULUM) end,1,nil)) fc:SetMaterial(g) Duel.SendtoGrave(g,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) assert(Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0) fc:CompleteProcedure() assert(fc:IsSummonType(SUMMON_TYPE_FUSION) and fc:IsStatus(STATUS_PROC_COMPLETE)) Duel.Hint(HINT_NUMBER,tp,701)`:'do end'} end) c:RegisterEffect(e) local o=Effect.CreateEffect(c) o:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) o:SetRange(LOCATION_MZONE) o:SetCode(EVENT_CHAIN_END) o:SetOperation(function(e,tp) local ec=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_SZONE,0,nil,${target}) if ec then local fc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}) assert(fc and ec:GetEquipTarget()==fc and ec:IsType(TYPE_EQUIP) and fc:GetAttack()==fc:GetBaseAttack()+500 and fc:IsHasEffect(EFFECT_CANNOT_BE_EFFECT_TARGET)) Duel.Hint(HINT_NUMBER,tp,988) end end) c:RegisterEffect(o) end`;
   if(name==='c'+actor+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) c:RegisterEffect(e) end';
   if(name==='c'+response+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':test.banishSource?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':test.banishTarget?`Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_GRAVE,0,nil,${target}),POS_FACEUP,REASON_EFFECT)`:test.negateActivation?'Duel.NegateActivation(ev)':'Duel.NegateEffect(ev)'} end) c:RegisterEffect(e) end`;
   if([filler,...mats].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-recovery')lua=lua.replace('Duel.SendtoHand(tc,nil,REASON_EFFECT)>0','0>0');
    if(control==='no-equip')lua=lua.replace('s.equipcard(e,tp,tc,c)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,started=false,offered=false,opponentActed=false,responded=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,n,reader(n)));
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,test.fusion?L.EXTRA:L.MZONE);add(target,L.GRAVE);add(probe,L.MZONE,0,4);if(test.fusion)for(const code of mats)add(code,L.HAND);else add(actor,L.SZONE,1,0,P.FACEDOWN_DEFENSE);if(interrupted)add(response,L.SZONE,1,1,P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location}).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!started){const index=p.activates.findIndex(c=>c.code===probe);assert(index>=0);started=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(offered,'Actual full-source recovery activation');assert.equal(opponentActed,!test.fusion);assert.equal(responded,interrupted);
     assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss&&m.chain_size===1).length,1,'Actual Fusion/opponent-activation recovery starts a new chain');
     if(!test.fusion){const a=trace.findIndex(m=>m.type===M.CHAINING&&m.code===actor),b=trace.findIndex(m=>m.type===M.CHAINING&&m.code===boss);assert(a>=0&&b>a&&trace.slice(a,b).some(m=>m.type===M.CHAIN_END),'Opponent activation recovery delayed until new chain');}
     if(interrupted)assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===response&&m.chain_size===2).length,1,'Actual recovery-chain CL2 intervention');
     if(test.fusion){assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===701),'Native paid Fusion history');for(const code of mats)assert(trace.some(m=>m.type===M.MOVE&&m.card===code&&m.from.location===L.HAND&&m.to.location===L.GRAVE),'Actual three-material Fusion payment');}
     const success=!(test.banishTarget||test.negateActivation||test.negateEffect);assert.equal(query(L.HAND).some(c=>c.code===target),success&&!test.equip,'Native GY-to-Hand recovery');assert.equal(query(L.SZONE).some(c=>c.code===target),success&&!!test.equip,'Native GY equip');
     if(test.equip)assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===988),'Native equip relationship/stat/protection');if(test.banishSource)assert(query(L.REMOVED).some(c=>c.code===boss));if(test.banishTarget)assert(query(L.REMOVED).some(c=>c.code===target));
     done=true;
    }else if(p.type===M.SELECT_EFFECTYN){const yes=p.code===boss&&!offered;if(yes)offered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes});}
    else if(p.type===M.SELECT_CHAIN){let index=-1;if(p.player===1&&!opponentActed){index=p.selects.findIndex(c=>c.code===actor);if(index>=0)opponentActed=true;}if(index<0&&p.player===0&&!offered){index=p.selects.findIndex(c=>c.code===boss&&Number(c.description)===132142234*16+1);if(index>=0)offered=true;}if(index<0&&p.player===1&&offered&&!responded){index=p.selects.findIndex(c=>c.code===response);if(index>=0)responded=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.equip&&p.options.length>1?1:0});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}results.push({test,failure,trace,logs});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-seraphina-recovery'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full Seraphina and selected Arms source/current installed metadata/corrected transport. Actual neutral paid printed-category Fusion setup versus field-seeded opponent-response source. Native GY add/equip, actual Equip relationship/ATK/protection, United add-only and new-chain CL2 source/target loss/negation. No API shim; general Fusion recipe, shared monster-use wording and live Omega remain separate.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(v=>v.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
