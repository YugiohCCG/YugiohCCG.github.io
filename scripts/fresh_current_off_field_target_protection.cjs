'use strict';const fs=require('fs'),path=require('path'),assert=require('assert/strict'),ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod,core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'old',target=900011271,responder=900011272,observer=900011273,filler=900011274,results=[];
for(const [boss,setup,destination] of [[259652372,"draw",L.DECK],[259926839,"draw",L.HAND],[259646610,"idle",L.GRAVE],[259223502,"fusion",L.MZONE],[222257685,"idle",L.MZONE]])for(const lock of [false,true]){const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0},cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[target,{...base,code:target,type:boss===259926839?0x10002:33,attribute:16,setcodes:[0xf2f4,0x11b]}],[responder,{...base,code:responder}],[observer,{...base,code:observer}],[filler,{...base,code:filler,type:2}],[222257686,{...base,code:222257686,type:0x4011}]]);
const reader=n=>{if(n==='c0.lua')return '';if([target,filler,222257686].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(n===`c${responder}.lua`)return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_QUICK_O)
 e:SetCode(EVENT_CHAINING)
 e:SetRange(LOCATION_MZONE)
 e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end)
 e:SetOperation(function(e,tp)
  local tc=Duel.GetMatchingGroup(Card.IsCode,0,LOCATION_GRAVE+LOCATION_REMOVED,0,nil,${target}):GetFirst()
  local restriction=Effect.CreateEffect(c)
  restriction:SetType(EFFECT_TYPE_SINGLE)
  restriction:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
  restriction:SetValue(1)
  tc:RegisterEffect(restriction)
 end)
 c:RegisterEffect(e)
end`;
if(n===`c${observer}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) ${setup==='draw'?'assert(Duel.Draw(1-tp,2,REASON_EFFECT)==2)':`local sc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}):GetFirst() assert(Duel.SpecialSummon(sc,${setup==='synchro'?'SUMMON_TYPE_SYNCHRO':'SUMMON_TYPE_FUSION'},tp,tp,false,false,POS_FACEUP_ATTACK)==1)`} end) c:RegisterEffect(e) end`;
const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){
  const backup=path.join(OUT,'off-field-target-protection-before-repair',n);
  if(fs.existsSync(backup))s=fs.readFileSync(backup,'utf8');
  if(mode==='candidate')s=require('./fresh_off_field_target_protection_repair.cjs').corrected(s,boss);
}return s;};
const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,placed=false,triggered=false,started=false,responded=false,done=false;
try{for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));const add=(code,location,p=0,seq=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location,sequence:seq,position});const origin=[259646610,259576196].includes(boss)?L.REMOVED:L.GRAVE;const needsSummon=setup==="synchro"||setup==="fusion";add(boss,needsSummon?L.EXTRA:boss===222257685?L.GRAVE:L.MZONE,0,needsSummon?0:2,needsSummon?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);add(target,origin,0);add(observer,L.MZONE,0,4);if(lock)add(responder,L.MZONE,1,4);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);const query=(location,controller=0)=>core.duelQueryLocation(d,{flags:Q.CODE|Q.LEVEL,controller,location}).filter(Boolean);
for(let step=0;step<170&&!done;step++){const state=core.duelProcess(d),ms=core.duelGetMessage(d);trace.push(...ms);if(ms.some(m=>m.type===M.CHAINING&&m.code===boss))triggered=true;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=ms.at(-1);if(p.type===M.SELECT_IDLECMD){if(!started){const index=p.activates.findIndex(c=>c.code===(setup==="idle"?boss:observer));assert(index>=0);started=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.chain_size===1),'Original effect activated');if(lock)assert(responded&&trace.some(m=>m.type===M.CHAINING&&m.code===responder&&m.chain_size===2),'Actual late targeting protection');if(boss===222257685){assert(query(L.REMOVED).some(c=>c.code===boss),'Original banish cost');assert(query(L.MZONE).some(c=>c.code===222257686||c.code===target),'Guidance Token summoned');}else assert(query(destination).some(c=>c.code===target),'Original target reached expected destination');done=true;}

else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>(!triggered&&c.code===boss)||(lock&&!responded&&c.code===responder));if(index>=0){if(p.selects[index].code===responder)responded=true;else if(p.selects[index].code===boss)triggered=true;}core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
else if(p.type===M.SELECT_CARD){core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:Array.from({length:p.min},(_,i)=>i)});}
else if(p.type===M.SELECT_PLACE){const places=[];for(const rel of [0,1])for(const location of [L.MZONE,L.SZONE])for(let sequence=0;sequence<6;sequence++)if((p.field_mask&(1<<(16*rel+(location===L.SZONE?8:0)+sequence)))===0)places.push({player:rel?1-p.player:p.player,location,sequence});assert(places.length);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:places.slice(0,p.count)});}
else if(p.type===M.SELECT_YESNO)core.duelSetResponse(d,{type:R.SELECT_YESNO,yes:true});
else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(d,{type:R.SELECT_EFFECTYN,yes:true});
else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));}assert(done,'Step limit');}catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({boss,setup,lock,failure,logs,trace});console.log(boss,setup,lock,failure||'PASS');}fs.writeFileSync(path.join(OUT,`current-off-field-target-protection-${mode}.json`),JSON.stringify({mode,scope:'Original five GY or banished target effects and actual chained targeting protection. Neutral draw and summon setups. Original Fusion and Synchro recipes remain open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));}main().catch(e=>{console.error(e);process.exitCode=1});
