'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[],control=['no-material','no-complete','no-checklist'].find(c=>process.argv.includes('--'+c));
 const material=900002301,target=900002302,probe=900002303,filler=900002304,response=900002305,late=900002306;
 const boss=259072906,partner=900002501;
 for(const scenario of ['baseline','protected','immune','wrongMaterialRace','wrongPartnerRace','noPartner','lowBoundary','highBoundary','two','shortTwo','fullOne','fullTwo']){
  const base={alias:0,setcodes:[],type:17,level:3,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0},trace=[],logs=[];
  const two=['two','shortTwo','fullTwo'].includes(scenario);const actualCount=scenario==='two'?2:1;
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,type:0x1000011,race:scenario==='wrongPartnerRace'?1n:0x1000000n,lscale:1,rscale:1}],[material,{...base,code:material,race:scenario==='wrongMaterialRace'?1n:0x1000000n,level:two?(scenario==='shortTwo'?5:6):3}],[target,{...base,code:target,type:0xa1,race:0x1000000n,level:scenario==='lowBoundary'?1:scenario==='highBoundary'?5:3}],[probe,{...base,code:probe,type:33}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+target+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_SPSUMMON_CONDITION) e:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE) e:SetValue(aux.ritlimit) c:RegisterEffect(e) end';
   if(name==='c'+partner+'.lua')return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_CHANGE_RSCALE) e:SetValue(1) c:RegisterEffect(e) end';
   if(name==='c'+material+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${['protected','immune'].includes(scenario)?`local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(${scenario==='protected'?'EFFECT_UNRELEASABLE_NONSUM':'EFFECT_IMMUNE_EFFECT'}) e:SetValue(${scenario==='protected'?'1':'function(e,re) return true end'}) c:RegisterEffect(e)`:''} end`;
   if(name==='c'+probe+'.lua')return `local s,id=GetID() function s.initial_effect(c) local diagnostic=Effect.CreateEffect(c) diagnostic:SetType(EFFECT_TYPE_IGNITION) diagnostic:SetRange(LOCATION_MZONE) diagnostic:SetCountLimit(1) diagnostic:SetDescription(903) diagnostic:SetOperation(function(e,tp) local l,r=c${boss}.scalelimits(tp) local rc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${target}) Duel.Hint(HINT_NUMBER,tp,10000+(l or 0)*100+(r or 0)*10+rc:GetLevel()) end) c:RegisterEffect(diagnostic) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetDescription(902) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${target}) local ok=#g==${actualCount} and (aux.PendulumChecklist&(1<<tp))~=0 for tc in aux.Next(g) do if not tc:IsSummonType(SUMMON_TYPE_RITUAL) or not tc:IsStatus(STATUS_PROC_COMPLETE) then ok=false end end Duel.Hint(HINT_NUMBER,tp,ok and 988 or 989) end) c:RegisterEffect(e) end`;
   if(name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){if(process.argv.includes('--old-source'))lua=fs.readFileSync(path.join(OUT,'mage-group-before-material-repair','c'+boss+'.lua'),'utf8');
    if(process.argv.includes('--candidate'))lua=lua.replace('function s.pzmatfilter(c)','function s.pzmatfilter(c,e)').replace('return c:IsFaceup() and c:IsRace(RACE_CYBERSE) and c:GetLevel()>0','return c:IsFaceup() and c:IsRace(RACE_CYBERSE) and c:GetLevel()>0 and c:IsReleasableByEffect() and not c:IsImmuneToEffect(e)').replace('Duel.GetMatchingGroup(s.pzmatfilter,tp,LOCATION_MZONE,0,nil)','Duel.GetMatchingGroup(s.pzmatfilter,tp,LOCATION_MZONE,0,nil,e)');
    if(control==='no-material')lua=lua.replace('Duel.ReleaseRitualMaterial(mat)','do end');if(control==='no-complete')lua=lua.replace('tc:CompleteProcedure()','do end');if(control==='no-checklist')lua=lua.replace('aux.PendulumChecklist=s.pendulumchecklist()|(0x1<<tp)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),String(code));return cards.get(code);},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,partnerPlaced=false,activated=false,observed=false,diagnosed=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);if(scenario!=='noPartner')add(partner,L.HAND);add(target,L.HAND);if(two)add(target,L.HAND);add(probe,L.MZONE,0,P.FACEUP_ATTACK,4);add(material,L.MZONE);
   if(['fullOne','fullTwo'].includes(scenario))for(let i=1;i<4;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location}).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!placed||!partnerPlaced&&scenario!=='noPartner'){const code=!placed?boss:partner;const index=p.activates.findIndex(c=>c.code===code&&c.location===L.HAND);assert(index>=0);if(!placed)placed=true;else partnerPlaced=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!diagnosed){const index=p.activates.findIndex(c=>c.code===probe&&Number(c.description)===903);assert(index>=0);diagnosed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){const index=p.special_summons.findIndex(c=>c.code===boss);const eligible=!['protected','immune','wrongMaterialRace','wrongPartnerRace','noPartner','lowBoundary','highBoundary'].includes(scenario);assert.equal(index>=0,eligible,'Native group Ritual procedure eligibility');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     assert.equal(query(L.MZONE).filter(c=>c.code===target).length,actualCount,'Actual grouped Ritual summons');assert.equal(trace.filter(m=>m.type===M.MOVE&&m.card===material&&m.to.location===L.GRAVE).length,1,'Actual field material Tributed');
     if(!observed){const index=p.activates.findIndex(c=>c.code===probe&&Number(c.description)===902);assert(index>=0);observed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===988),'Native Ritual type/proper status');assert(!p.special_summons.some(c=>c.code===boss||c.code===partner),'Shared Pendulum summon spent');done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);assert(index>=0,'Expected Ritual target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish&&!(scenario==='two'&&p.select_cards.some(c=>c.code===target))?null:p.select_cards.findIndex(c=>c.code===material||c.code===target);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_OPTION){const index=p.options.findIndex(v=>Number(v)!==1163);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_OPTION,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:(p.positions&P.FACEUP_ATTACK)?P.FACEUP_ATTACK:P.FACEUP_DEFENSE});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===response);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({passcode:boss,scenario,failure,trace,logs});if(failure)console.log('FAIL '+boss+' '+scenario+': '+failure);
 }
 fs.writeFileSync(path.join(OUT,'current-glitchling-mage-pendulum-group'+(process.argv.includes('--old-source')?'-old-source':'')+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full production Mage native group Pendulum Ritual procedure, actual left/right Hand-to-PZone placement, real field material releases and Ritual group summons/proper status. Current Mage metadata, neutral Cyberse Ritual targets and scale partner. No API shim/fullcard/liveOmega; other Mage effects and Extra targets/use-reset remain open',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');console.log(JSON.stringify({cases:results.length,passed:results.filter(r=>!r.failure).length}));if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
