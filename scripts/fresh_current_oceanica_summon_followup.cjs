'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=259941091,starter=Number((process.argv.find(v=>v.startsWith("--starter="))||"=226645052").split("=")[1]),initial=900009511,recipient=900009512,filler=900009513,counter=900009514,reset=900009515;
 const control=['candidate','meta-only','no-zero','no-immunity','prior-source','old-lock'].find(x=>process.argv.includes('--'+x)),results=[];
 for(const test of [{},{special:true},{decline:true},{absent:true},{negated:true},{immune:true},{reset:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[starter,candidateCard(starter)],[initial,{...base,code:initial}],[recipient,{...base,code:recipient}],[filler,{...base,code:filler,type:2}],[counter,{...base,code:counter,type:0x100004}],[reset,{...base,code:reset,type:2}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) local d=Effect.CreateEffect(c) d:SetType(EFFECT_TYPE_SINGLE) d:SetCode(EFFECT_UPDATE_DEFENSE) d:SetValue(700) c:RegisterEffect(d) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) x:SetCode(EVENT_SUMMON_SUCCESS) x:SetProperty(EFFECT_FLAG_DELAY) x:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(x) local y=x:Clone() y:SetCode(EVENT_SPSUMMON_SUCCESS) c:RegisterEffect(y) ${test.immune?'local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_SINGLE) z:SetCode(EFFECT_IMMUNE_EFFECT) z:SetValue(function(e,re) return re:GetHandler():IsCode('+boss+') end) c:RegisterEffect(z)':''} end`;
   if([initial,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+reset+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE+LOCATION_GRAVE,nil,${recipient}):GetFirst() assert(tc) Duel.SendtoGrave(tc,REASON_EFFECT) Duel.SpecialSummon(tc,0,1-tp,1-tp,false,false,POS_FACEUP_ATTACK) end) c:RegisterEffect(x) end`;
   if(name==='c'+counter+'.lua')return `local s,id=GetID() function s.initial_effect(c) local a=Effect.CreateEffect(c) a:SetType(EFFECT_TYPE_SINGLE) a:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN) a:SetProperty(EFFECT_FLAG_SET_AVAILABLE) c:RegisterEffect(a) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_SUMMON) x:SetCondition(function(e,tp,eg) return eg:IsExists(Card.IsCode,1,nil,${recipient}) end) x:SetOperation(function(e,tp,eg) Duel.NegateSummon(eg) Duel.SendtoGrave(eg,REASON_EFFECT) end) c:RegisterEffect(x) end`;
   const p=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(p=>fs.existsSync(p));assert(p,'Missing '+name);let lua=fs.readFileSync(p,'utf8');if([boss,starter].some(c=>name==='c'+c+'.lua')&&control)lua=fs.readFileSync(path.join(OUT,'remaining-normal-summon-before-repair',name),'utf8');if(name==='c'+starter+'.lua'&&control&&control!=='prior-source')lua=require('./fresh_remaining_normal_summon_repair.cjs').handmeta(lua);if(name==='c'+boss+'.lua'&&control&&!['meta-only','prior-source'].includes(control))lua=require('./fresh_remaining_normal_summon_repair.cjs').oceanica(lua);if(name==='c'+boss+'.lua'&&control==='old-lock')lua=lua.replace(' and not e:GetHandler():IsImmuneToEffect(e)','');if(name==='c'+boss+'.lua'&&control==='no-zero')lua=lua.replace('ea:SetValue(0)','ea:SetValue(1000)');if(name==='c'+boss+'.lua'&&control==='no-immunity')lua=lua.replace('tc:RegisterEffect(ei)','do end');return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,started=false,accepted=false,done=false,turn=0,resetDone=false,addonOffers=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.SZONE,0,P.FACEUP_ATTACK,5);add(starter,L.HAND);add(initial,L.HAND,1);if(!test.absent)add(recipient,L.HAND,1);if(test.negated)add(counter,L.SZONE,0,P.FACEDOWN_DEFENSE);if(test.reset)add(reset,L.HAND);for(const p of [0,1])for(let i=0;i<10;i++)add(filler,L.DECK,p);
   core.startDuel(duel);const query=(loc,p=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.DEFENSE|Q.POSITION,controller:p,location:loc}).filter(Boolean);
   for(let step=0;step<230&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);turn+=messages.filter(m=>m.type===M.NEW_TURN).length;
    if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));if(state===S.END)throw Error('Unexpected duel end');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!started){if(p.player===0){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.summons.findIndex(c=>c.code===initial);assert(index>=0);started=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});continue;}
     assert(accepted,'Original Harmony Hand trigger accepted');assert(query(L.MZONE).some(c=>c.code===starter),'Original Harmony actually self summoned');assert.equal(addonOffers,1,'Original own-Hand source metadata offers Oceanica additional effect');
     const expected=!test.decline&&!test.absent&&!test.negated;const tc=query(L.MZONE,1).find(c=>c.code===recipient);assert.equal(!!tc,expected,'Oceanica native opponent Hand summon');
     if(tc){assert.equal(tc.attack,resetDone||test.immune?1000:0,'Oceanica followup ATK zero and reset');assert.equal(tc.defense,1900,'Recipient own effect remains active');const recovers=trace.filter(m=>m.type===M.RECOVER&&m.player===1);assert.equal(recovers.length,resetDone?2:1,'Hand followup is unaffected by Oceanica; later GY revival also remains outside the Hand-only lock');}
     if(test.reset&&!resetDone){if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===reset);assert(index>=0);resetDone=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     done=true;
    }
    else if(p.type===M.SELECT_CHAIN){const wanted=p.player===0?(test.negated&&p.selects.some(c=>c.code===counter)?counter:starter):recipient;const i=p.selects.findIndex(c=>c.code===wanted);if(i>=0){if(wanted===starter)accepted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:i});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===starter)accepted=true;assert([starter,recipient].includes(p.code));core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_YESNO){addonOffers++;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.special?1:0});
    else if(p.type===M.SELECT_CARD){const i=p.selects.findIndex(c=>c.code===recipient);assert(i>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[i]});}
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0)),seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert.notEqual(seq,undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   assert(done,'Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({test,failure,accepted,addonOffers,trace,logs});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-oceanica-summon-followup'+(starter===226645052?'':'-'+starter)+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Original Oceanica Field continuous effect and original Harmony Hand trigger/current installed metadata/corrected transport/no Lua API mapping. Candidate source metadata separately fixed for actual Hand report; neutral recipient trigger and actual opponent summons. No full-card/live Omega claim.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
