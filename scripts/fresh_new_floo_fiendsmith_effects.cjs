'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
process.env.CCG_INSTALLED_CARD_DB ||= require('node:path').resolve(__dirname,'../public/CCG Downloads/CCG_Database/CCG_v1.db');
const {candidateCard}=require('./fresh_installed_card.cjs');
const {loadCorrectedTransport}=require('./fresh_corrected_card_data_transport.cjs');
const installed=process.env.CCG_OMEGA_SCRIPTS||path.resolve(__dirname,'../public/CCG Downloads/CCG_Scripts');
const omega=path.resolve(__dirname,'../tmp/omega_scripts');
const [hot,sky,journey,soprana,offer]=[239932270,239932271,239932272,239934743,239934744];
const fixtures=Array.from({length:8},(_,i)=>900009001+i);
const [helper,body,wing,spell,trap,fusion,link,dark]=fixtures;
const engraver=60764609,formation=239127930,grayrover=259937399,grayseer=259632020,mayavada=247755870,nullbind=259269688,booster=259628203,ivy=284639722,bauSpell=254215159,bauWorld=226950506,bau=221511784;
const neutral='local s,id=GetID() function s.initial_effect(c) end';
async function main(){
 const mod=await loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:Battle,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const base={alias:0,setcodes:[],type:17,level:2,attribute:16,race:8n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
 const floo=[0x16d],fiend=[0x1b0];
 const H=L.HAND,D=L.DECK,G=L.GRAVE,B=L.REMOVED,F=L.MZONE,T=L.SZONE,E=L.EXTRA;
 const testCases=[];
 const add=(name,setup,steps,expected,opts={})=>testCases.push({name,setup,steps,expected,...opts});
 add('Hot Winds places a Field Spell from GY',[[hot,H],[spell,G]],[hot],[[spell,L.FZONE]],{field:true});
 add('Hot Winds banishes both monsters',[[hot,H],[wing,H],[body,F,1]],[-wing,hot],[[wing,B],[body,B,1]]);
 add('Hot Winds returns from banishment',[[hot,G],[helper,H],[body,H]],[helper],[[hot,H],[body,B]],{yes:true,op:'Duel.Remove(find('+hot+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)'});
 add('Hot Winds offers both options after a Tribute Summon',[[hot,H],[sky,T],[wing,H],[body,H],[wing,D],[spell,G],[body,F,1]],[-wing,hot],[[spell,T],[wing,B],[body,B,1]],{boss:true,option:2});
 add('Hot Winds cannot apply both without a Tribute Summon',[[hot,H],[wing,H],[spell,G],[body,F,1]],[-wing,hot],[[spell,T],[wing,F],[body,F,1]],{options:2});
 add('Magnificent Sky cannot replace a regular Normal Summon',[[sky,T],[wing,H],[body,H],[wing,D]],[-wing],[[wing,F],[wing,D],[body,H]],{noBanish:true});
 add('Magnificent Sky can banish a monster from the field',[[sky,T],[wing,H],[body,F],[wing,D]],[-wing],[[body,B],[wing,B],[wing,F]],{boss:true});
 add('Soprana is unavailable during its controller turn',[[soprana,H],[body,T]],[],[[soprana,H],[body,T]],{forbidden:soprana});
 add('Soprana bounces from field on Normal Summon',[[soprana,H],[fusion,E],[body,F,1]],[-soprana],[[fusion,G],[body,H,1]],{yes:true});
 add('Soprana bounces from GY on Special Summon',[[soprana,G],[helper,H],[fusion,E],[body,G,1]],[helper],[[fusion,G],[body,H,1]],{yes:true,op:'Duel.SpecialSummon(find('+soprana+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 for(const loc of [H,G])add('Soprana summons equipped monster from '+(loc===H?'hand':'GY'),[[soprana,loc],[body,T]],[],[[body,F],[soprana,G]],{opponent:true});
 for(const loc of [D,B])add('Offertorium sets trap from '+(loc===D?'Deck':'banishment'),[[offer,G],[helper,H],[body,G],[trap,loc]],[helper,offer],[[offer,B],[trap,T]],{op:'Duel.Remove(find('+body+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)'});
 add('Offertorium GY effect blocks later non-LIGHT Fiend summons',[[offer,G],[helper,H],[helper,H],[body,G],[dark,G],[trap,D]],[helper,offer,helper],[[offer,B],[trap,T],[dark,G]],{op:'local c=find('+body+',LOCATION_GRAVE) if c then Duel.Remove(c,POS_FACEUP,REASON_EFFECT) else Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP) end'});
 add('Offertorium GY effect rejects an earlier non-LIGHT Fiend summon',[[offer,G],[helper,H],[body,G],[dark,G],[trap,D]],[helper],[[offer,G],[trap,D],[dark,F]],{forbidden:offer,op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP) Duel.Remove(find('+body+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)'});
 add('Offertorium GY effect requires a LIGHT Fiend to leave',[[offer,G],[trap,D]],[],[[offer,G],[trap,D]],{forbidden:offer});
 add('Offertorium Link Summons with Engraver from hand',[[offer,H],[engraver,H],[link,E],[body,F]],[offer],[[link,F],[engraver,G]],{yes:true});
 add('Offertorium cannot use an opponent monster to Link Summon',[[offer,H],[engraver,H],[link,E],[body,F,1]],[offer],[[link,E],[engraver,F],[body,F,1]],{noYes:true});
 add('Offertorium blocks a non-LIGHT Fiend summon after activation',[[offer,H],[engraver,D],[helper,H],[dark,G]],[offer,helper],[[dark,G],[engraver,F]],{op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Offertorium unavailable after an earlier non-LIGHT Fiend summon',[[offer,H],[engraver,D],[helper,H],[dark,G]],[helper],[[dark,F],[offer,H]],{forbidden:offer,op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 for(const [code,loc,resource,target] of [[17827173,B,[wing,B],H],[18940725,H,[wing,D],H],[54334420,F,[wing,D],H],[80433039,H,[body,G,1],B],[80611581,H,[spell,D],H]]){
  add('Mythic Journey copies '+code,[[journey,H],[journey,H],[code,loc],resource],[journey],[[resource[0],target,resource[2]||0]],{copied:code,boss:code===54334420,forbidden:journey});
 }
 add('Mythic Journey grants the copied extra Normal Summon',[[journey,H],[18940725,H],[wing,D]],[journey],[[wing,F]],{copied:18940725,yes:true,pick:wing});
 add('Mythic Journey protects a Winged Beast in battle',[[journey,G],[wing,F],[dark,F,1]],[],[[journey,B],[wing,F]],{boss:true,battle:true,yes:true});
 for(const code of [spell,wing])add('Mythic Journey protects '+(code===spell?'a Floo Spell':'a high-Level Winged Beast'),[[journey,G],[helper,H],[code,code===spell?T:F]],[helper],[[journey,B],[code,code===spell?T:F]],{boss:true,yes:true,op:'Duel.Destroy(find('+code+',LOCATION_ONFIELD),REASON_EFFECT)'});
 add('Link material family: Formation uses your field',[[formation,G],[wing,H],[body,F],[link,E]],[-wing],[[formation,B],[link,F],[body,G]],{family:formation});
 add('Link material family: Formation excludes otherwise available opposing material',[[formation,G],[wing,H],[body,F,1],[link,E]],[-wing],[[formation,G],[wing,F],[body,F,1],[link,E]],{family:formation,opposingMaterial:true,noTrigger:true});
 add('Link material family: Grayrover uses your hand',[[grayrover,H],[body,H],[wing,F,1],[link,E]],[grayrover],[[grayrover,G],[body,G],[link,F],[wing,F,1]],{family:grayrover});
 add('Link material family: Grayrover uses your field',[[grayrover,H],[body,F],[wing,F,1],[link,E]],[grayrover],[[grayrover,G],[body,G],[link,F],[wing,F,1]],{family:grayrover});
 add('Link material family: Grayrover cannot use an opposing monster',[[grayrover,H],[wing,F,1],[link,E]],[grayrover],[[grayrover,F],[wing,F,1],[link,E]],{family:grayrover,noTrigger:true});
 add('Grayseer discards before summoning from Deck',[[grayseer,F],[body,H],[wing,D]],[grayseer],[[body,G],[wing,F]],{family:grayseer});
 add('Grayseer cannot activate when discarding is prohibited',[[grayseer,F],[helper,H],[body,H],[wing,D]],[helper],[[body,H],[wing,D]],{family:grayseer,forbidden:grayseer,op:'local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DISCARD_HAND) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(1,0) Duel.RegisterEffect(lock,tp)'});
 add('Mayavada cannot activate with only a prohibited discard available',[[mayavada,T],[helper,H],[body,H],[wing,F,1]],[helper],[[body,H],[wing,F,1]],{family:mayavada,forbidden:mayavada,op:'local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DISCARD_HAND) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(1,0) Duel.RegisterEffect(lock,tp)'});
 add('Mayavada can destroy and discard',[[mayavada,T],[body,H],[wing,F,1]],[mayavada],[[body,G],[wing,G,1]],{family:mayavada});
 const permitTrap='local c=find('+nullbind+',LOCATION_HAND) local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit)';
 add('Nullbind rejects a Normal Monster as its only target',[[nullbind,H],[helper,H],[link,F],[wing,F,1]],[helper],[[nullbind,H],[wing,F,1]],{family:nullbind,forbidden:nullbind,op:permitTrap});
 add('Nullbind negates and attaches a non-LIGHT Effect Monster',[[nullbind,H],[helper,H],[link,F],[wing,F,1]],[helper,nullbind],[[nullbind,G]],{family:nullbind,op:permitTrap,effectWing:true,yes:true,attached:true});
 add('Booster Dragon rejects a Normal Monster as its only target',[[booster,F],[spell,T],[wing,F,1]],[],[[spell,T],[wing,F,1]],{family:booster,forbidden:booster});
 add('Booster Dragon pays its Equip cost to negate an Effect Monster',[[booster,F],[spell,T],[wing,F,1]],[booster],[[spell,G],[wing,F,1]],{family:booster,effectWing:true});
 for(const effectWing of [false,true])add('Ivy '+(effectWing?'negates a Special Summoned Effect Monster':'rejects a Special Summoned Normal Monster'),[[ivy,F],[helper,H],[wing,H,1]],[helper],[[wing,F,1]],{family:ivy,effectWing,expectTrigger:effectWing,op:'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_HAND,nil,'+wing+') Duel.SpecialSummon(tc,0,tp,1-tp,false,false,POS_FACEUP) Duel.Destroy(find('+ivy+',LOCATION_MZONE),REASON_EFFECT)'});
 add('Bau Spell banishes the monster it just negated',[[bauSpell,H],[helper,H],[bauWorld,H],[bau,F],[body,D],[wing,F,1]],[helper,bauSpell],[[bauSpell,G],[wing,B,1],[body,F]],{family:bauSpell,yes:true,effectWing:true,pick:wing,op:'Duel.MoveToField(find('+bauWorld+',LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true)'});
 let failures=0;
 for(const t of testCases){
  const data=new Map();
  for(const code of [hot,sky,journey,soprana,offer])data.set(code,candidateCard(code));
  if(t.family)data.set(t.family,candidateCard(t.family));
  const put=(code,over={})=>data.set(code,{...base,code,...over});
  put(helper,{type:2});put(body);put(dark,{attribute:32,attack:t.battle?3000:100});put(wing,{type:t.effectWing?33:17,attribute:t.effectWing?32:16,race:512n,level:t.boss?7:2,setcodes:t.family===formation?[0x9c9]:t.family===grayseer?[0x575d]:floo});
  put(spell,{type:t.family===booster?0x40002:t.field?0x80002:0x20002,setcodes:floo});put(trap,{type:4,setcodes:fiend});
  put(fusion,{type:0x61,setcodes:fiend});put(link,{type:t.family===nullbind?0x800021:0x4000021,level:2,link_marker:5,setcodes:t.family===formation?[0x9c9]:[grayrover,nullbind].includes(t.family)?[0x575d]:fiend});
  if(t.family===bauSpell){put(bauWorld,{type:0x80002});put(bau);put(body,{type:0x1021,setcodes:[0xba8]});}
  put(engraver,{type:33,setcodes:fiend});if(t.copied)put(t.copied,{type:33,race:512n,setcodes:floo});
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+helper+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(s.op) c:RegisterEffect(e) end function s.op(e,tp) local function find(code,loc) return Duel.GetMatchingGroup(Card.IsCode,tp,loc,0,nil,code):GetFirst() end '+t.op+' end';
   if(name==='c'+link+'.lua')return `local s,id=GetID()
-- Translate the Omega API at the fixture boundary. This duel has no external
-- mandatory-material effects. Offertorium itself is loaded from disk as-is.
local isLinkSummonable,linkSummon=Card.IsLinkSummonable,Duel.LinkSummon
if ${t.opposingMaterial?'true':'false'} then
 local defaultMaterials=aux.GetLinkMaterials
 function aux.GetLinkMaterials(tp,f,c,e)
  local pool=defaultMaterials(tp,f,c,e)
  pool:Merge(Duel.GetMatchingGroup(aux.LConditionFilter,tp,0,LOCATION_MZONE,nil,f,c,e))
  return pool
 end
end
function Card.IsLinkSummonable(c,pool,required) return isLinkSummonable(c,required,pool) end
function Duel.LinkSummon(tp,c,pool,required) return linkSummon(tp,c,required,pool) end
if not Duel.GetMustMaterial then Duel.GetMustMaterial=function() return Group.CreateGroup() end end
function s.initial_effect(c)
 Card.IsLinkType=Card.IsLinkType or Card.IsType
 c:EnableReviveLimit()
 local e=aux.AddLinkProcedure(c,nil,2,2)
 local function fixed(required) return required and required:GetFirst() end
 local condition,target,operation=e:GetCondition(),e:GetTarget(),e:GetOperation()
 e:SetCondition(function(e,c,required,pool,min,max) return condition(e,c,pool,fixed(required),min,max) end)
 e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk,c,required,pool,min,max)
  return target(e,tp,eg,ep,ev,re,r,rp,chk,c,pool,fixed(required),min,max)
 end)
 e:SetOperation(function(e,tp,eg,ep,ev,re,r,rp,c,required,pool,min,max)
  return operation(e,tp,eg,ep,ev,re,r,rp,c,pool,fixed(required),min,max)
 end)
end`;
   if([...fixtures,engraver,bauWorld,bau].some(code=>name==='c'+code+'.lua'))return neutral;
   const source=path.resolve(__dirname,'../public/CCG Downloads/CCG_Scripts',name);
   const file=[process.env.CCG_TEST_SOURCE&&t.family&&source,path.join(installed,name),path.resolve(__dirname,'../tmp/ohmen-reference',name),path.join(omega,name)].find(f=>f&&fs.existsSync(f));
   assert(file,name);return fs.readFileSync(file,'utf8');
  };
  const logs=[],team={startingLP:8000,startingDrawCount:0,drawCountPerTurn:0};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:team,team2:team,cardReader:code=>data.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  try{
   for(const file of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,file,reader(file)));
   if(t.family===nullbind)assert(core.loadScript(duel,'chain-target-compat.lua','CHAININFO_TARGET_CARDS=8 Card.IsCanOverlay=Card.IsCanOverlay or function(c) return c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TOKEN) end'));
   const next={};
   const place=(code,location,player=0)=>{
    const key=player+':'+location,sequence=next[key]||0;next[key]=sequence+1;
    core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:location===T||location===F?sequence:0,position:location===E?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   };
   for(const args of t.setup)place(...args);
   for(const player of [0,1])for(let i=0;i<8;i++)place(dark,D,player);
   core.startDuel(duel);
   let familyTriggers=0,step=0,done=false,opponentTurn=false,quickUsed=false,attacked=false;
   const respond=(type,rest)=>core.duelSetResponse(duel,{type,...rest});
   for(let i=0;i<200&&!done;i++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);
    assert(!logs.some(x=>x.type===0),logs.map(x=>x.message).join('\n'));
    for(const m of messages){
     if(m.type===M.NEW_TURN)opponentTurn=m.player===1;
     if(m.type===M.CHAINING&&t.steps[step]===m.code)step++;
     if(m.type===M.CHAINING&&t.family===m.code)familyTriggers++;
     if(m.type===M.CHAINING&&m.code===soprana&&t.opponent)quickUsed=true;
    }
    assert(state!==S.END);if(state!==S.WAITING)continue;
    const p=messages.at(-1);
    switch(p.type){
    case M.SELECT_IDLECMD:{
     const code=t.steps[step];
     if(code){
      const list=code<0?p.summons:p.activates,index=list.findIndex(x=>x.code===Math.abs(code));
      assert(index>=0,'Action unavailable '+code);
      respond(R.SELECT_IDLECMD,{action:code<0?A.SELECT_SUMMON:A.SELECT_ACTIVATE,index});if(code<0)step++;
     }else if(t.battle&&!attacked)respond(R.SELECT_IDLECMD,{action:opponentTurn?A.TO_BP:A.TO_EP,index:0});
     else if(t.opponent&&!opponentTurn)respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else{
      if(t.expectTrigger!==undefined)assert.equal(familyTriggers,t.expectTrigger?1:0,'Unexpected Ivy trigger result');
      if(t.noTrigger)assert.equal(familyTriggers,t.family===grayrover?1:0,'An illegal Link Summon triggered');
      if(t.opponent)assert(quickUsed,'Opponent-turn Quick Effect did not activate');
      if(t.forbidden)assert(!p.activates.some(x=>x.code===t.forbidden),'Restricted activation available');
      if(t.attached)assert.equal(core.duelQueryCount(duel,1,F),0,'Monster was not attached');
      if(t.noBanish)assert.equal(core.duelQueryCount(duel,0,B),0,'Unexpected banished material');
      for(const [id,loc,player=0] of t.expected){
       const queryLoc=loc===L.FZONE?T:loc;
       assert(core.duelQueryLocation(duel,{flags:Q.CODE,controller:player,location:queryLoc}).filter(Boolean).some(x=>x.code===id),'Missing '+id+' in '+loc+' for player '+player);
      }
      done=true;
     }
     break;
    }
    case M.SELECT_BATTLECMD:{
     const index=p.attacks.findIndex(x=>x.code===dark);
     if(!attacked){assert(index>=0,'Attacker unavailable');attacked=true;}
     else {respond(R.SELECT_BATTLECMD,{action:Battle.TO_M2,index:0});break;}
     respond(R.SELECT_BATTLECMD,{action:Battle.SELECT_BATTLE,index});break;
    }
    case M.SELECT_CHAIN:{
     const index=p.selects.findIndex(x=>x.code===t.steps[step]||x.code===soprana&&(!t.opponent||opponentTurn)&&!quickUsed||x.code===hot&&x.location===B||x.code===t.family&&[formation,grayrover,ivy].includes(t.family)&&x.location!==H);
     respond(R.SELECT_CHAIN,{index:index>=0?index:p.forced?0:null});break;
    }
    case M.SELECT_EFFECTYN:respond(R.SELECT_EFFECTYN,{yes:[hot,soprana,t.family].includes(p.code)});break;
    case M.SELECT_YESNO:assert(!t.noYes,'An illegal Link Summon was offered');respond(R.SELECT_YESNO,{yes:!!t.yes});break;
    case M.SELECT_OPTION:if(t.options)assert.equal(p.options.length,t.options);respond(R.SELECT_OPTION,{index:t.option||0});break;
    case M.SELECT_CARD:{
     const preferred=p.selects.findIndex(x=>x.code===t.pick);
     const indicies=p.min===1&&preferred>=0?[preferred]:p.selects.map((_,i)=>i).slice(0,p.min);
     respond(R.SELECT_CARD,{indicies});break;
    }
    case M.SELECT_UNSELECT_CARD:respond(R.SELECT_UNSELECT_CARD,{index:p.finishable?null:0});break;
    case M.SELECT_POSITION:respond(R.SELECT_POSITION,{position:P.FACEUP_ATTACK});break;
    case M.SELECT_PLACE:{
     const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6,7].some(j=>(p.field_mask&(1<<(v+j)))===0));
     const sequence=[0,1,2,3,4,5,6,7].find(j=>(p.field_mask&(1<<(shift+j)))===0);
     respond(R.SELECT_PLACE,{places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?T:F,sequence}]});break;
    }
    default:throw Error('Unhandled '+JSON.stringify(p));
    }
   }
   assert(done,'Step limit');console.log('PASS',t.name);
  }catch(e){failures++;console.log('FAIL',t.name,e.message);}
  finally{core.destroyDuel(duel);}
 }
 if(failures)process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1;});



