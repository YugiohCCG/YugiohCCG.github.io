'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(x){if(process.argv.includes('--probe-material'))console.log(x)},printErr(){}}),boss=238273769,target=900001301,filler=900001302,partner=900001303,mat1=900001304,mat2=900001305,adjust=900001307;
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const scenario of ['baseline','level4','level5','wrongSet','sameName','nonMonster','fullField','noCandidate']){
 const test={pzone:true,useSource:true,full:scenario==='fullField'};
  const legal=!test.hand&&!test.wrongSet&&!test.immune,logs=[],trace=[],basePend={...base,type:0x1000021,lscale:7,rscale:7},cards=new Map([[adjust,{...base,code:adjust,type:2}],[target,{...base,code:target,type:0x41,attribute:32}],[boss,candidateCard(boss)],[filler,{...base,code:filler}],[partner,{...basePend,code:partner,type:scenario==='nonMonster'?2:17,level:scenario==='level4'?4:scenario==='level5'?5:3,setcodes:scenario==='wrongSet'?[]:[0x1066]}],[mat1,{...base,code:mat1,type:0x41,attribute:8}],[mat2,{...basePend,code:mat2,setcodes:scenario==='wrongPartner'?[]:[0xb47]}]]);
  const reader=name=>{
   if(name===`c${adjust}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local lock=Duel.IsPlayerAffectedByEffect(tp,EFFECT_CANNOT_SPECIAL_SUMMON) local dark=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${target}):GetFirst() local wind=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${mat1}):GetFirst() local f=lock and lock:GetTarget() Duel.Hint(HINT_NUMBER,tp,f and f(lock,dark) and not f(lock,wind) and 701 or 702) end) c:RegisterEffect(e) end`;
   if(name===`c${target}.lua`||name===`c${mat1}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name===`c${partner}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(name===`c${mat2}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(name===`c${mat1}.lua`)return `local s,id=GetID() function s.initial_effect(c) ${test.immune?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetValue(function(e,re) return re:GetHandler():IsCode('+boss+') end) c:RegisterEffect(e)':''} end`;
   if(name==='c0.lua')return '';if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--no-summon'))source=source.replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)','do end');if(process.argv.includes('--faceup'))source=source.replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)','Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)');if(process.argv.includes('--allow-level'))source=source.replace('c:GetLevel()<=4','true');if(process.argv.includes('--no-lock'))source=source.replace('Duel.RegisterEffect(lock,tp)','do end');} return source;
  };

  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggerChoices=0,done=false,probed=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,L.MZONE,0,P.FACEDOWN_DEFENSE);add(adjust,L.HAND);add(target,L.EXTRA,0,P.FACEDOWN_DEFENSE);add(mat1,L.EXTRA,0,P.FACEDOWN_DEFENSE);if(scenario!=='noCandidate')add(scenario==='sameName'?boss:partner,L.DECK);if(scenario==='fullField')for(let i=1;i<5;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<90&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.pos_changes.findIndex(c=>c.code===boss);if(index<0)throw Error('Native Flip summon missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_POS_CHANGE,index});continue;}
     const expected=['baseline','level4'].includes(scenario),field=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.MZONE}),pc=field.find(c=>c?.code===partner);
     if(Boolean(pc)!==expected||expected&&pc.position!==P.FACEDOWN_DEFENSE||trace.filter(t=>t.type===M.CHAINING&&t.code===boss&&String(t.description)===String(132273769*16+2)).length!==1)throw Error('Forced Flip recruitment outcomes mismatch');
     if(!probed){const index=p.activates.findIndex(c=>c.code===adjust);if(index<0)throw Error('Actual restriction probe missing');probed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!trace.some(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===701)||trace.some(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===702))throw Error('Resolved independent WIND lock missing');done=true;
    }
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>[boss,mat1,mat2].includes(c.code));if(index!==null&&index<0)throw Error('Actual recipe material selection missing');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((c,i)=>[partner,boss].includes(c.code)?i:-1).filter(i=>i>=0).slice(0,p.max);if(indices.length<p.min)throw Error('Actual Fusion selection missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss)throw Error('Wrong material trigger source');triggerChoices++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:scenario!=='decline'});}
    else if(p.type===M.SELECT_YESNO)throw Error('Unexpected yes/no');
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({scenario,failure,triggerChoices,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify({scenario})}${failure?': '+failure:''}`);
 }
 const control=['no-summon','faceup','allow-level','no-lock'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-symphonic-ddj-flip-recruit${process.argv.includes('--chaininfo-compat')?'-chaininfo-compat':''}${control?'-'+control:''}.json`),JSON.stringify({material_api_compat:process.argv.includes('--material-api-compat'),scope:'Full DDJ/installedmetadata/corrected transport/no Lua API adapter. Actual Flip Summon forced Deck recruitment into facedown Defense; native query verifies outcome. Resolved player restriction inspected through native effect and target callback for DARK/WIND Extra cards, including failed recruit cases. Actual future summons/interruptions/shared reset/liveOmega/fullcard open',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
