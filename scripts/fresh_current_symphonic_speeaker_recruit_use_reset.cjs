'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(x){if(process.argv.includes('--probe-material'))console.log(x)},printErr(){}}),boss=238273768,target=900001301,filler=900001302,partner=900001303,mat1=900001304,mat2=900001305,adjust=900001307,counter=900001308;
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const scenario of ['baseline','negateActivation','negateEffect']){
 const test={pzone:true,useSource:true,full:scenario==='fullField'};
  const legal=!test.hand&&!test.wrongSet&&!test.immune,logs=[],trace=[],basePend={...base,type:0x1000021,lscale:7,rscale:7},cards=new Map([[counter,{...base,code:counter,type:0x100004}],[target,{...base,code:target,type:0x20002}],[boss,candidateCard(boss)],[filler,{...base,code:filler}],[partner,{...basePend,code:partner,type:scenario==='facedownExtra'?0x41:scenario==='nonMonster'?2:basePend.type,setcodes:scenario==='wrongSet'?[]:[0x1066]}],[mat1,{...base,code:mat1,type:17}],[mat2,{...basePend,code:mat2,setcodes:scenario==='wrongPartner'?[]:[0x1066]}]]);
  const reader=name=>{
   if(name===`c${counter}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) and re:GetDescription()==${132273768*16+2} end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${process.argv.includes('--no-response')?'do end':scenario==='negateActivation'?'Duel.NegateActivation(ev)':scenario==='negateEffect'?'Duel.NegateEffect(ev)':scenario==='sourceBanish'?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':scenario==='lateLock'?`local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DRAW) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(0,1) lock:SetReset(RESET_PHASE+PHASE_END) Duel.RegisterEffect(lock,tp)`:`Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_MZONE,0,nil,${partner}),POS_FACEUP,REASON_EFFECT)`} end) c:RegisterEffect(e) end`;

   if(name===`c${target}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_SZONE) e:SetOperation(function(e,tp) local sc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}):GetFirst() assert(sc and Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)==1) end) c:RegisterEffect(e) end`;
   if(name===`c${partner}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(name===`c${mat2}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(name===`c${mat1}.lua`)return `local s,id=GetID() function s.initial_effect(c) ${test.immune?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetValue(function(e,re) return re:GetHandler():IsCode('+boss+') end) c:RegisterEffect(e)':''} end`;
   if(name==='c0.lua')return '';if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--per-copy'))source=source.replace('e3:SetCountLimit(1,id+200)','e3:SetCountLimit(1)');if(process.argv.includes('--no-reset'))source=source.replace('e3:SetCountLimit(1,id+200)','e3:SetCountLimit(1,id+200,2)');if(process.argv.includes('--split-summon'))source=source.replace('e4:SetCode(EVENT_SPSUMMON_SUCCESS)','e4:SetCode(EVENT_SPSUMMON_SUCCESS) e4:SetCountLimit(1,id+901)');if(process.argv.includes('--no-result')){source=source.replace('Duel.Draw(p,d,REASON_EFFECT)','do end').replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)','do end');}} return source;
  };

  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=0,triggerChoices=0,done=false,interrupted=false,turn=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   if(process.argv.includes('--chaininfo-compat'))core.loadScript(duel,'embers_chaininfo_compat.lua','CHAININFO_TARGET_PLAYER=9 CHAININFO_TARGET_PARAM=10');
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});for(let i=0;i<3;i++)add(boss,scenario==='flipFirst'&&i===0?L.MZONE:L.HAND,0,scenario==='flipFirst'&&i===0?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);add(target,L.SZONE,0,P.FACEUP_ATTACK,2);if(boss===256928871)add(partner,L.MZONE,0,P.FACEUP_ATTACK,4);else for(let i=0;i<3;i++)add(partner,L.DECK);if(['negateActivation','negateEffect'].includes(scenario))add(counter,L.SZONE,1,P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<7;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<350&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(turn===2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     const expected=activated===0?0:activated<3?1:2;
     if(triggerChoices!==expected)throw Error('Shared summon-trigger use/reset mismatch');
     const hand=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),negated=['negateActivation','negateEffect'].includes(scenario),expectedResult=expected-(negated&&expected>0?1:0);
     if(hand.filter(c=>c?.code===partner).length!==expectedResult)throw Error('Actual search/draw count mismatch');
     if(turn===1&&activated<2||turn===3&&activated===2){const first=activated===0,list=first?(scenario==='flipFirst'?p.pos_changes:p.summons):p.activates,index=list.findIndex(c=>c.code===(first?boss:target));if(index<0)throw Error('Actual summon option missing');activated++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:first?(scenario==='flipFirst'?A.SELECT_POS_CHANGE:A.SELECT_SUMMON):A.SELECT_ACTIVATE,index});continue;}
     if(turn===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(turn!==3||JSON.stringify(trace.filter(t=>t.type===M.NEW_TURN).map(t=>t.player))!=='[0,1,0]')throw Error('Natural next turn missing');
     if(core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}).filter(c=>c?.code===boss).length!==3)throw Error('Three actual source summons missing');
     if(trace.filter(t=>t.type===M.CHAINING&&t.code===counter&&t.chain_size===2).length!==(negated?1:0))throw Error('Actual first-use negation missing');done=true;
    }
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>[boss,mat1,mat2].includes(c.code));if(index!==null&&index<0)throw Error('Actual recipe material selection missing');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((c,i)=>[partner,boss,mat2].includes(c.code)?i:-1).filter(i=>i>=0).slice(0,p.max);if(indices.length<p.min)throw Error('Actual Fusion selection missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss)throw Error('Wrong material trigger source');triggerChoices++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_YESNO)throw Error('Unexpected yes/no');
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===counter);if(index>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({scenario,failure,turn,triggerChoices,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify({scenario})}${failure?': '+failure:''}`);
 }
 const control=['per-copy','no-reset','split-summon','no-result'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-symphonic-speeaker-recruit-use-reset${process.argv.includes('--chaininfo-compat')?'-chaininfo-compat':''}${control?'-'+control:''}.json`),JSON.stringify({material_api_compat:process.argv.includes('--material-api-compat'),scope:'Full Speeaker/current installed metadata/corrected transport/no Lua API adapter. Actual first Normal then other-copy Special Summon and third-copy next-own-turn Special Summon; shared named recruitment use after success or actual CL2 negation. Exact native recruited/source counts and turns. Recruitment restriction/liveOmega/fullcard open',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
