'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(x){if(process.argv.includes('--probe-material'))console.log(x)},printErr(){}}),boss=238273768,target=900001301,filler=900001302,partner=900001303,mat1=900001304,mat2=900001305,adjust=900001307;
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const scenario of ['normal','special','hand','faceupExtra','wrongSet','grave','fullMainDeck','fullMainExtra','noCandidate','decline']){
 const test={pzone:true,useSource:true,full:scenario==='fullField'};
  const legal=!test.hand&&!test.wrongSet&&!test.immune,logs=[],trace=[],basePend={...base,type:0x1000021,lscale:7,rscale:7},cards=new Map([[target,{...base,code:target,type:2}],[boss,candidateCard(boss)],[filler,{...base,code:filler}],[partner,{...basePend,code:partner,type:basePend.type,setcodes:scenario==='wrongSet'?[]:[0x1066]}],[mat1,{...base,code:mat1,type:17}],[mat2,{...basePend,code:mat2,setcodes:scenario==='wrongPartner'?[]:[0xb47]}]]);
  const reader=name=>{
   if(name===`c${target}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${['faceupExtra','fullMainExtra'].includes(scenario)?`local pc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${partner}):GetFirst() assert(Duel.SpecialSummon(pc,0,tp,tp,false,false,POS_FACEUP)==1) assert(Duel.SendtoGrave(pc,REASON_EFFECT)==1 and pc:IsLocation(LOCATION_EXTRA))`:''} ${scenario==='allyPZone'?`local pc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${partner}):GetFirst() assert(Duel.MoveToField(pc,tp,tp,LOCATION_PZONE,POS_FACEUP,true))`:''} local sc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}):GetFirst() assert(sc and Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)==1) end) c:RegisterEffect(e) end`;
   if(name===`c${partner}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(name===`c${mat2}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(name===`c${mat1}.lua`)return `local s,id=GetID() function s.initial_effect(c) ${test.immune?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetValue(function(e,re) return re:GetHandler():IsCode('+boss+') end) c:RegisterEffect(e)':''} end`;
   if(name==='c0.lua')return '';if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--no-summon'))source=source.replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)','do end');if(process.argv.includes('--allow-set')&&scenario==='wrongSet')source=source.replace('return c:IsSetCard(SET_SYMPHONIC) and (not c:IsLocation','return (not c:IsLocation');if(process.argv.includes('--allow-grave'))source=source.replaceAll('LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA','LOCATION_HAND+LOCATION_DECK+LOCATION_EXTRA+LOCATION_GRAVE');if(process.argv.includes('--no-extra-capacity'))source=source.replace('Duel.GetLocationCountFromEx(tp,tp,nil,c)>0','Duel.GetLocationCount(tp,LOCATION_MZONE)>0');} if(name===`c${boss}.lua`&&process.argv.includes('--probe-extra'))source+='\nlocal old=s.spfilter s.spfilter=function(c,e,tp) if true then Debug.Message("EXTRA code="..c:GetCode().." loc="..c:GetLocation().." cnt="..Duel.GetLocationCountFromEx(tp,tp,nil,c).." can="..tostring(c:IsCanBeSpecialSummoned(e,0,tp,false,false)).." wide="..tostring(c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,tp,0xff))) end return old(c,e,tp) end';return source;
  };

  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggerChoices=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,L.HAND);if(scenario!=='normal')add(target,L.HAND);if(scenario!=='noCandidate')add(partner,scenario==='hand'?L.HAND:['faceupExtra','fullMainExtra'].includes(scenario)?L.HAND:scenario==='grave'?L.GRAVE:L.DECK,0,['faceupExtra','fullMainExtra'].includes(scenario)?P.FACEUP_DEFENSE:P.FACEUP_ATTACK);if(['fullMainDeck','fullMainExtra'].includes(scenario))for(let i=0;i<4;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<90&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const list=scenario==='normal'?p.summons:scenario==='flip'?p.pos_changes:p.activates,index=list.findIndex(c=>c.code===(['normal','flip'].includes(scenario)?boss:target));if(index<0)throw Error('Actual summon option unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:scenario==='normal'?A.SELECT_SUMMON:scenario==='flip'?A.SELECT_POS_CHANGE:A.SELECT_ACTIVATE,index});continue;}
     const eligible=!['wrongSet','grave','fullMainDeck','noCandidate'].includes(scenario),summoned=eligible&&scenario!=='decline',field=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE});
     if(summoned&&['faceupExtra','fullMainExtra'].includes(scenario)&&!trace.some(t=>t.type===M.MOVE&&t.card===partner&&t.from.location===L.EXTRA&&t.to.location===L.MZONE))throw Error('Actual Extra summon missing');
     if(triggerChoices!==(eligible?1:0)||field.some(c=>c?.code===partner)!==summoned||!field.some(c=>c?.code===boss))throw Error('Recruit availability/native summon outcomes mismatch');done=true;
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
 const control=['probe-extra','no-summon','allow-set','allow-grave','no-extra-capacity'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-symphonic-speeaker-recruit${process.argv.includes('--chaininfo-compat')?'-chaininfo-compat':''}${control?'-'+control:''}.json`),JSON.stringify({material_api_compat:process.argv.includes('--material-api-compat'),scope:'Full Speeaker/current installed metadata/corrected transport/no Lua API adapter. Actual Normal/Special Summon recruitment from Hand/Deck/faceup Extra; full Main Monster Zone still allows Extra-zone recruitment. Focused eligibility, not shared-use/Extra activity restriction/liveOmega/fullcard certification',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
