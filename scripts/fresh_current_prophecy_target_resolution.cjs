'use strict';const fs=require('fs'),path=require('path'),assert=require('assert/strict'),ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod,core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'old',target=900011271,responder=900011272,observer=900011273,filler=900011274,results=[];
for(const [boss,attribute] of [[223558392,1],[251058567,2],[229327103,4],[223592011,8],[244920555,16],[243920845,32]])for(const scenario of ["normal","change","protect"]){const change=scenario==="change",respond=scenario!=="normal";const source=fs.readFileSync(path.join(ROOT,"public/CCG Downloads/CCG_Scripts",`c${boss}.lua`),"utf8");const resource=Number(source.match(/\[(\d+)\]=true/)[1]);const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:0x1000000n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0},cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[target,{...base,code:target,type:0x41,attribute}],[responder,{...base,code:responder}],[observer,{...base,code:observer}],[filler,{...base,code:filler,type:2}],[resource,{...base,code:resource,type:2}]]);
const reader=n=>{if(n==='c0.lua')return '';if([target,filler,resource].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(n===`c${responder}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():GetOriginalCode()==${boss} end) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,${target}):GetFirst() if ${change} then
 assert(Duel.GetControl(tc,1)==1)
 else
 local protect=Effect.CreateEffect(e:GetHandler())
 protect:SetType(EFFECT_TYPE_SINGLE)
 protect:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
 protect:SetValue(1)
 tc:RegisterEffect(protect)
 end end) c:RegisterEffect(e) end`;
if(n===`c${observer}.lua`)return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_IGNITION)
 e:SetRange(LOCATION_MZONE)
 e:SetCountLimit(1)
 e:SetOperation(function(e,tp)
  local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${target}):GetFirst()
  assert(Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP_ATTACK)==1)
  assert(tc:IsSummonLocation(LOCATION_EXTRA))
 end)
 c:RegisterEffect(e)
end`;
const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){
  const backup=path.join(OUT,'prophecy-target-resolution-before-repair',n);
  if(fs.existsSync(backup))s=fs.readFileSync(backup,'utf8');
  if(mode!=='old')s=require('./fresh_prophecy_target_resolution_repair.cjs').corrected(s,boss);
  if(mode==='no-controller')s=s.replace(' and tc:IsControler(tp) and tc:IsLocation(LOCATION_MZONE)',' and tc:IsLocation(LOCATION_MZONE)');
  if(mode==='recheck-targetability')s=s.replace('and s.rteligible(tc) and Duel.GetMZoneCount','and s.rteligible(tc) and tc:IsCanBeEffectTarget(e) and Duel.GetMZoneCount');
}return s;};
const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,setup=false,started=false,responded=false,done=false;
try{for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));const add=(code,location,p=0,seq=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location,sequence:seq,position});add(boss,L.HAND);add(resource,L.DECK);add(target,L.EXTRA,0,0,P.FACEDOWN_DEFENSE);add(observer,L.MZONE,0,4);if(respond)add(responder,L.MZONE,1,4);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);const query=(location,controller=0)=>core.duelQueryLocation(d,{flags:Q.CODE|Q.ATTACK,controller,location}).filter(Boolean);
for(let step=0;step<170&&!done;step++){const state=core.duelProcess(d),ms=core.duelGetMessage(d);trace.push(...ms);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=ms.at(-1);if(p.type===M.SELECT_IDLECMD){if(!setup){const index=p.activates.findIndex(c=>c.code===observer);assert(index>=0);setup=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!started){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0);started=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(respond)assert(responded&&trace.some(m=>m.type===M.CHAINING&&m.code===responder&&m.chain_size===2),'Actual CL2 interruption');assert.equal(query(L.EXTRA).some(c=>c.code===target),!change,'Return qualifying target to Extra Deck');assert.equal(query(L.MZONE).some(c=>c.code===boss),!change,'Original hand summon follows return');assert.equal(query(L.HAND).some(c=>c.code===resource),!change,'Printed eligible search follows summon');if(change)assert(query(L.MZONE,1).some(c=>c.code===target),'Target stays with new controller');done=true;}

else if(p.type===M.SELECT_CHAIN){const index=started&&respond&&!responded?p.selects.findIndex(c=>c.code===responder):-1;if(index>=0)responded=true;core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>(c.code===target||c.code===resource));assert(index>=0);core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:[index]});}
else if(p.type===M.SELECT_PLACE){const places=[];for(const rel of [0,1])for(let sequence=0;sequence<5;sequence++)if((p.field_mask&(1<<(16*rel+sequence)))===0)places.push({player:rel?1-p.player:p.player,location:L.MZONE,sequence});assert(places.length);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:places.slice(0,p.count)});}
else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));}assert(done,'Step limit');}catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({boss,scenario,failure,logs,trace});console.log(boss,scenario,failure||'PASS');}fs.writeFileSync(path.join(OUT,`current-prophecy-target-resolution-${mode}.json`),JSON.stringify({mode,scope:'Six original Prophecy activations with neutral Extra Deck summon history. Native control change and target protection chained after target selection. Return, hand summon and eligible search verified.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));}main().catch(e=>{console.error(e);process.exitCode=1});
