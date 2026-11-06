'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(x){if(process.argv.includes('--probe-material'))console.log(x)},printErr(){}}),boss=256928871,target=900001301,filler=900001302,partner=900001303,mat1=900001304,mat2=900001305,adjust=900001307;
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const scenario of ['normal','special','flip','noAlly','sameName','wrongSet','facedownAlly','opponentAlly','allyPZone']){
 const test={pzone:true,useSource:true,full:scenario==='fullField'};
  const legal=!test.hand&&!test.wrongSet&&!test.immune,logs=[],trace=[],basePend={...base,type:0x1000021,lscale:7,rscale:7},cards=new Map([[target,{...base,code:target,type:2}],[boss,candidateCard(boss)],[filler,{...base,code:filler}],[partner,{...basePend,code:partner,setcodes:scenario==='wrongSet'?[]:[0xb47]}],[mat1,{...base,code:mat1,type:17}],[mat2,{...basePend,code:mat2,setcodes:scenario==='wrongPartner'?[]:[0xb47]}]]);
  const reader=name=>{
   if(name===`c${target}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${scenario==='allyPZone'?`local pc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${partner}):GetFirst() assert(Duel.MoveToField(pc,tp,tp,LOCATION_PZONE,POS_FACEUP,true))`:''} local sc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}):GetFirst() assert(sc and Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)==1) end) c:RegisterEffect(e) end`;
   if(name===`c${partner}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(name===`c${mat2}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(name===`c${mat1}.lua`)return `local s,id=GetID() function s.initial_effect(c) ${test.immune?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetValue(function(e,re) return re:GetHandler():IsCode('+boss+') end) c:RegisterEffect(e)':''} end`;
   if(name==='c0.lua')return '';if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--no-draw'))source=source.replace('Duel.Draw(p,d,REASON_EFFECT)','do end');if(process.argv.includes('--allow-self-name'))source=source.replace(' and not c:IsCode(id)','');if(process.argv.includes('--allow-set'))source=source.replace('c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_MONSTER)','c:IsType(TYPE_MONSTER)');if(process.argv.includes('--allow-facedown'))source=source.replace('return c:IsFaceup() and c:IsSetCard','return c:IsSetCard');} return source;
  };

  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggerChoices=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   if(process.argv.includes('--chaininfo-compat'))core.loadScript(duel,'embers_chaininfo_compat.lua','CHAININFO_TARGET_PLAYER=9 CHAININFO_TARGET_PARAM=10');
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,scenario==='flip'?L.MZONE:L.HAND,0,scenario==='flip'?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(!['normal','flip'].includes(scenario))add(target,L.HAND);if(scenario!=='noAlly')add(scenario==='sameName'?boss:partner,scenario==='allyPZone'?L.HAND:L.MZONE,scenario==='opponentAlly'?1:0,scenario==='facedownAlly'?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<90&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const list=scenario==='normal'?p.summons:scenario==='flip'?p.pos_changes:p.activates,index=list.findIndex(c=>c.code===(['normal','flip'].includes(scenario)?boss:target));if(index<0)throw Error('Actual summon option unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:scenario==='normal'?A.SELECT_SUMMON:scenario==='flip'?A.SELECT_POS_CHANGE:A.SELECT_ACTIVATE,index});continue;}
     const eligible=['normal','special','flip'].includes(scenario),hand=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND});
     if(triggerChoices!==(eligible?1:0)||hand.filter(c=>c?.code===filler).length!==(eligible?1:0))throw Error('Summon draw eligibility/outcome mismatch');done=true;
    }
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>[boss,mat1,mat2].includes(c.code));if(index!==null&&index<0)throw Error('Actual recipe material selection missing');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((c,i)=>[partner,boss,mat1,mat2].includes(c.code)?i:-1).filter(i=>i>=0).slice(0,p.max);if(indices.length<p.min)throw Error('Actual Fusion selection missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss)throw Error('Wrong material trigger source');triggerChoices++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_YESNO)throw Error('Unexpected yes/no');
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({scenario,failure,triggerChoices,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify({scenario})}${failure?': '+failure:''}`);
 }
 const control=['no-draw','allow-self-name','allow-set','allow-facedown'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-talismandrake-embers-summon-draw${process.argv.includes('--chaininfo-compat')?'-chaininfo-compat':''}${control?'-'+control:''}.json`),JSON.stringify({material_api_compat:process.argv.includes('--material-api-compat'),scope:'Full Embers/current installed metadata/corrected transport/explicit test-only modern CHAININFO target-player/param mapping when flagged; actual Normal/Special/Flip summon and draw, companion eligibility. Focused native cases; shared limits/interruptions/liveOmega/fullcard open',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
