'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=process.env.CCG_OMEGA_SCRIPTS||path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const boss=255277197, ally=900006202, top=900006203, filler=900006201, probe=900006204, mode=process.argv[2]||'current';
 for(const scenario of ['normal','replace',...(mode==='installed'?['Hand and field','one GY material','LIGHT Fusion','wrong Fusion attribute','GY pair','GY pair same attribute','GY without opponent','GY wrong attribute','activation limit','independent limits']:[])]){
  const limit=scenario==='activation limit',independent=scenario==='independent limits';
  const gy=scenario.startsWith('GY')||scenario==='one GY material';
  const eligible=!['wrong Fusion attribute','GY pair same attribute','GY without opponent','GY wrong attribute'].includes(scenario);
  const logs=[],base={alias:0,setcodes:[],type:17,level:2,attribute:2,race:4n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[ally,{...base,code:ally,type:0x61,race:0x4000n,attribute:scenario==='wrong Fusion attribute'?2:scenario==='LIGHT Fusion'?16:32}],[top,{...base,code:top,attribute:scenario==='GY pair same attribute'?16:scenario==='GY wrong attribute'?2:32}],[filler,{...base,code:filler,attribute:16}],[probe,{...base,code:probe}]]);
  const reader=name=>{
   if(name==='c0.lua')return ''; if([top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+probe+'.lua'&&scenario==='Hand and field')return `
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_IGNITION)
 e:SetRange(LOCATION_MZONE)
 e:SetOperation(function(e,tp)
  local summoned=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${ally})
  assert(summoned and summoned:IsSummonType(SUMMON_TYPE_FUSION),'Actual Fusion summon type')
  assert(summoned:IsHasEffect(EFFECT_CANNOT_ATTACK),'Same-turn attack restriction applied')
 end)
 c:RegisterEffect(e)
end`;
   if(name==='c'+probe+'.lua')return 'local s,id=GetID() function s.initial_effect(c) '+(scenario==='replace'?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetCode(EFFECT_SEND_REPLACE) e:SetRange(LOCATION_MZONE) e:SetTarget(function(e,tp,eg) return eg:IsExists(function(tc) return tc:IsCode(900006203) and tc:IsReason(REASON_FUSION) end,1,nil) end) e:SetValue(function(e,tc) return tc:IsCode(900006203) end) c:RegisterEffect(e) ':'')+'end';
   if(name==='c'+ally+'.lua'&&mode==='installed')return `
local s,id=GetID()
local function materials(g)
 local first=g:Filter(Card.IsCode,nil,${filler}):GetFirst()
 local second=g:Filter(Card.IsCode,nil,${top}):GetFirst()
 if first and second then return Group.FromCards(first,second) end
end
function s.initial_effect(c)
 c:EnableReviveLimit()
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_SINGLE)
 e:SetCode(EFFECT_FUSION_MATERIAL)
 e:SetCondition(function(e,g,gc,chkf)
  if not g then return false end
  local pair=materials(g)
  return pair and (not aux.FCheckAdditional or aux.FCheckAdditional(chkf&0xff,pair,e:GetHandler()))
 end)
 e:SetOperation(function(e,tp,eg) Duel.SetFusionMaterial(materials(eg)) end)
 c:RegisterEffect(e)
end`;
   if(name==='c'+ally+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_FUSION_MATERIAL) e:SetCondition(function(e,g) return g and g:IsExists(Card.IsCode,1,nil,900006201) and g:IsExists(Card.IsCode,1,nil,900006203) end) e:SetOperation(function(e,tp,eg) Duel.SetFusionMaterial(Group.FromCards(eg:Filter(Card.IsCode,nil,900006201):GetFirst(),eg:Filter(Card.IsCode,nil,900006203):GetFirst())) end) c:RegisterEffect(e) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,name);
   if(name==='c'+boss+'.lua'&&mode==='before')return fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/chaos-fusion-material-movement-before-repair',name),'utf8');
   return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let activated=false,returned=false,checkedAttack=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   if(independent)assert(core.loadScript(duel,'omega-chaos-target-chaininfo.lua','CHAININFO_TARGET_CARDS=8'));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(probe,L.MZONE);add(top,gy?L.GRAVE:scenario==='Hand and field'?L.MZONE:L.HAND,0,1);add(filler,gy&&scenario!=='one GY material'?L.GRAVE:L.HAND);
   if(gy&&scenario!=='GY without opponent')add(probe,L.MZONE,1);
   add(ally,L.EXTRA);
   if(limit){add(boss,L.HAND);add(top,L.HAND);add(filler,L.HAND);add(ally,L.EXTRA);}
   if(independent){add(boss,L.GRAVE);add(top,L.REMOVED);add(filler,L.REMOVED);}
for(const player of [0,1])for(let i=0;i<8;i++)add(probe,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(independent&&!returned){
      const index=p.activates.findIndex(x=>x.code===boss&&x.location===L.GRAVE);assert(index>=0,'GY effect is available');
      returned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;
     }
     if(!activated){const index=p.activates.findIndex(x=>x.code===boss&&x.location===L.HAND);assert.equal(index>=0,eligible,'Fusion activation eligibility');if(!eligible){console.log(JSON.stringify({boss,scenario,mode,eligible}));done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(scenario==='Hand and field'&&!checkedAttack){
      const index=p.activates.findIndex(x=>x.code===probe);assert(index>=0,'Attack check available');
      checkedAttack=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;
     }
     const locations=Object.fromEntries([L.MZONE,L.HAND,L.REMOVED].map(location=>[location,query(location).map(x=>x.code)]));
     assert.equal(locations[L.MZONE].includes(ally),scenario!=='replace'||mode==='before','Fusion outcome');
     assert.equal(locations[L.HAND].includes(top),scenario==='replace'||limit,'Retained material');
     assert(locations[L.REMOVED].includes(filler),'Other material banished');
     if(scenario!=='replace')assert(locations[L.REMOVED].includes(top),'Second material banished');
     if(limit){
      assert(locations[L.HAND].includes(boss)&&locations[L.HAND].includes(filler)&&query(L.EXTRA).some(x=>x.code===ally),'Second Fusion still has a legal recipe');
      assert(!p.activates.some(x=>x.code===boss&&x.location===L.HAND),'Second Spell activation is blocked');
     }
     if(independent){
      assert(query(L.GRAVE).some(x=>x.code===top)&&query(L.GRAVE).some(x=>x.code===filler),'Both returned materials stayed in GY');
      assert(locations[L.REMOVED].includes(boss),'GY effect paid its separate banish cost');
     }
     console.log(JSON.stringify({boss,scenario,mode,locations}));done=true;
    }else if(p.type===M.SELECT_CHAIN){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:Number(p.description)===133410628*16+3});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done);
  }finally{core.destroyDuel(duel);}
 }
}main().catch(e=>{console.error(e);process.exitCode=1});
