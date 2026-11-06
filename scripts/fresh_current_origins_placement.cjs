"use strict";
const fs=require('node:fs'),path=require('node:path');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=Number(process.argv.find(a=>a.startsWith('--card='))?.split('=')[1]||244986323),setup=900003001,counter=900003002,pend=900003003,filler=900003004;
 const msg={244986323:132986323,218142234:132142234}[boss],offset=boss===244986323?3:2;
 const base={alias:0,setcodes:[],type:17,level:2,attribute:8,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 const control=['old-source','no-placement'].find(f=>process.argv.includes('--'+f));
 for(const scenario of ['destroy','tribute','sourceBanish','sourceGrave','negateActivation','negateEffect','lateFull','oneZone','fullZones','plainSend','initialBanish']){
  const interrupt=['sourceBanish','sourceGrave','negateActivation','negateEffect','lateFull'].includes(scenario),eligible=scenario!=='fullZones'&&(boss!==244986323||scenario!=='plainSend'),placed=['destroy','tribute','oneZone','initialBanish'].includes(scenario)||(boss!==244986323&&scenario==='plainSend');
  const cards=new Map([[boss,candidateCard(boss)],[setup,{...base,code:setup,type:2}],[counter,{...base,code:counter,type:0x100004}],[pend,{...base,code:pend,type:0x1000021,lscale:7,rscale:7}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   const removal=`local c=Duel.GetMatchingGroup(Card.IsCode,0,LOCATION_MZONE,0,nil,${boss}):GetFirst() ${scenario==='initialBanish'?`local r=Effect.CreateEffect(c) r:SetType(EFFECT_TYPE_SINGLE) r:SetCode(EFFECT_TO_GRAVE_REDIRECT) r:SetProperty(EFFECT_FLAG_CANNOT_DISABLE) r:SetValue(LOCATION_REMOVED) c:RegisterEffect(r)`:''} ${scenario==='tribute'?'Duel.Release(c,REASON_EFFECT)':scenario==='plainSend'?'Duel.SendtoGrave(c,REASON_EFFECT)':'Duel.Destroy(c,REASON_EFFECT)'} assert(c:IsLocation(${scenario==='initialBanish'?'LOCATION_REMOVED':'LOCATION_EXTRA'}) and c:IsFaceup(),'Native Pendulum removal origin missing')`;
   if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${removal} end) c:RegisterEffect(e) end`;
   if(name===`c${counter}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) and re:GetDescription()==${msg*16+offset} end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${scenario==='sourceBanish'?"assert(Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)>0 and re:GetHandler():IsLocation(LOCATION_REMOVED),'CL2 banish failed')":scenario==='sourceGrave'?"assert(Duel.SendtoGrave(re:GetHandler(),REASON_EFFECT)>0 and re:GetHandler():IsLocation(LOCATION_GRAVE),'CL2 Grave move failed')":scenario==='negateActivation'?'Duel.NegateActivation(ev)':scenario==='negateEffect'?'Duel.NegateEffect(ev)':`for i=1,2 do local c=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_HAND,0,nil,${pend}):GetFirst() assert(c and Duel.MoveToField(c,1-tp,1-tp,LOCATION_PZONE,POS_FACEUP,true),'Late PZone fill failed') end`} end) c:RegisterEffect(e) end`;
   if(name===`c${pend}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';if(name==='c0.lua')return '';if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(control==='old-source')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/pendulum-before-placement-relation-repair/c'+boss+'.lua'),'utf8');if(control==='no-placement')lua=lua.replace(/Duel.MoveToField\((?:e:GetHandler\(\)|c),tp,tp,LOCATION_PZONE,POS_FACEUP,true\)/g,'do end');}return lua;
  };
  const logs=[],trace=[],duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,offers=0,interrupted=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,position,sequence});
   add(boss,L.MZONE);add(setup,L.HAND);if(interrupt)add(counter,L.SZONE,1,P.FACEDOWN_DEFENSE);if(scenario==='lateFull'){add(pend,L.HAND);add(pend,L.HAND);}if(['oneZone','fullZones'].includes(scenario))add(pend,L.SZONE,0,P.FACEUP_ATTACK,0);if(scenario==='fullZones')add(pend,L.SZONE,0,P.FACEUP_ATTACK,4);for(const player of [0,1])for(let i=0;i<6;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Native removal setup missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(offers!==(eligible?1:0))throw Error('Destroyed/Tributed trigger eligibility mismatch');
     const z=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.SZONE});if(z.some(c=>c?.code===boss)!==placed)throw Error('Placement source relation/zone/negation outcome mismatch');if(placed&&scenario==='oneZone'&&z[4]?.code!==boss)throw Error('Sole open Pendulum Zone not used');
     if(!trace.some(t=>t.type===M.MOVE&&t.card===boss&&t.from.location===L.MZONE&&t.to.location===(scenario==='initialBanish'?L.REMOVED:L.EXTRA)))throw Error('Native destruction/Tribute redirect move missing');
     if(interrupt&&!trace.some(t=>t.type===M.CHAINING&&t.code===counter&&t.chain_size===2))throw Error('Native CL2 placement interruption missing');
     const expected=scenario==='sourceBanish'?L.REMOVED:scenario==='sourceGrave'?L.GRAVE:L.EXTRA;if(!placed){const q=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:expected});if(!q.some(c=>c?.code===boss))throw Error('Source was improperly recovered from new location');}done=true;
    }
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss)throw Error('Unexpected trigger source');offers++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CHAIN){const ci=p.selects.findIndex(c=>c.code===counter);if(ci>=0&&!interrupted){interrupted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:ci});continue;}const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+offset));if(index>=0)offers++;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({boss,scenario,failure,offers,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${scenario}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-origins-placement${boss===244986323?'':'-'+boss}${control?'-'+control:''}.json`),JSON.stringify({scope:'Full source/actual installed metadata/corrected transport/no Lua API adapter. Native field destruction/Tribute/leave and faceup Extra/banished origin, placement and source/negation/zone interruptions. Source starts in MZone; summon recipe/history and other effects not certified; not live Omega.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
