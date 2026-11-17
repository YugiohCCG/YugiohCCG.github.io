'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=process.env.CCG_STOCK_SCRIPTS||path.join(ROOT,'tmp/omega_scripts'),INSTALLED=process.env.CCG_OMEGA_SCRIPTS||CUSTOM;
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const musicaleProbe=process.argv.includes('--bobbie-musicale-check');
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=musicaleProbe?259797813:259941091,starter=Number((process.argv.find(v=>v.startsWith("--starter="))||"=259114562").split("=")[1]),initial=900009511,recipient=900009512,filler=900009513,counter=900009514,reset=900009515;
 const installed=process.argv.includes('--installed');
 if(installed)assert(process.env.CCG_OMEGA_SCRIPTS,'Installed script directory is required');
 const mode=installed?'installed':process.argv.includes('--no-bottom')?'no-bottom':process.argv.includes('--no-recovery')?'no-recovery':process.argv.includes('--handler-only')?'handler-only':process.argv.includes('--candidate')?'candidate':'prior-source',control=null,results=[];
 const bothHands=process.argv.includes('--both-hands-check');
 const competingSummons=bothHands&&process.argv.includes('--competing-summons');
 const competingUpper=competingSummons&&process.argv.includes('--upper-link');
 const musicaleCases=[
  ...[false,true].flatMap(secondLink=>[true,false].map(special=>({special,secondLink}))),
  ...[false,true].map(activation=>({special:true,negated:true,activation})),
  ...[false,true].map(changedNames=>({special:true,opponentTurnLock:true,changedNames})),
  {generic:true,special:true},
  ...[false,true].map(activation=>({generic:true,special:true,negated:true,activation}))
 ];
 for(const test of musicaleProbe?musicaleCases:bothHands?(competingSummons?[false,true].flatMap(originalNormal=>[false,true].map(followupNormal=>({bothHands:true,ownMode:true,originalNormal,followupNormal,secondLink:competingUpper}))):[{bothHands:true},{bothHands:true,ownMode:true}]):process.argv.includes('--redirect-check')?[{},{redirect:true},{grave:true},{grave:true,redirect:true}]:[{},{grave:true},{bottomRecovered:true},{special:true},{decline:true},{noResource:true},{skillDrain:true},{negated:true},{negated:true,activation:true}].slice(0,process.argv.includes('--unadapted')?1:9)){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[starter,candidateCard(starter)],[initial,{...base,code:initial}],[recipient,{...base,code:recipient}],[filler,{...base,code:filler,type:2}],[counter,{...base,code:counter,type:0x100004}],[reset,{...base,code:reset,type:2}]]);
  const search=226645052,bottom=900009846,extraRecipient=900009847;cards.set(extraRecipient,{...base,code:extraRecipient});cards.set(search,candidateCard(search));cards.set(bottom,{...base,code:bottom,type:2});cards.set(82732705,{...base,code:82732705,type:0x20004});
  const reader=name=>{
   if(name==='c'+boss+'.lua'&&process.argv.includes('--current-source'))return fs.readFileSync(path.join(CUSTOM,name),'utf8');
   if(name==='c0.lua')return '';
   if(name==='c'+starter+'.lua'&&test.generic)return `
    local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
     e:SetCode(EVENT_SUMMON_SUCCESS)
     e:SetProperty(EFFECT_FLAG_DELAY)
     e:SetRange(LOCATION_HAND)
     e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk)
      if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 end
      Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
     end)
     e:SetOperation(function(e,tp)
      Duel.SpecialSummon(e:GetHandler(),0,tp,tp,false,false,POS_FACEUP)
     end)
     c:RegisterEffect(e)
    end`;
   if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) local d=Effect.CreateEffect(c) d:SetType(EFFECT_TYPE_SINGLE) d:SetCode(EFFECT_UPDATE_DEFENSE) d:SetValue(700) c:RegisterEffect(d) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) x:SetCode(EVENT_SUMMON_SUCCESS) x:SetProperty(EFFECT_FLAG_DELAY) x:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(x) local y=x:Clone() y:SetCode(EVENT_SPSUMMON_SUCCESS) c:RegisterEffect(y) ${test.immune?'local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_SINGLE) z:SetCode(EFFECT_IMMUNE_EFFECT) z:SetValue(function(e,re) return re:GetHandler():IsCode('+boss+') end) c:RegisterEffect(z)':''} end`;
   if(name==='c'+search+'.lua'&&test.redirect)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_TO_HAND_REDIRECT) e:SetValue(LOCATION_REMOVED) c:RegisterEffect(e) end';
   if(name==='c'+initial+'.lua'&&test.secondLink)return `
    local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
     e:SetCode(EVENT_SUMMON_SUCCESS)
     e:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end)
     c:RegisterEffect(e)
     ${competingUpper?'local imm=Effect.CreateEffect(c) imm:SetType(EFFECT_TYPE_SINGLE) imm:SetCode(EFFECT_IMMUNE_EFFECT) imm:SetValue(function(e,re) return re:GetOwner():IsCode(259941091) end) c:RegisterEffect(imm)':''}
    end`;
   if(test.opponentTurnLock&&[initial,extraRecipient].some(code=>name==='c'+code+'.lua'))return `
    local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_IGNITION)
     e:SetDescription(id)
     e:SetRange(id==${initial} and LOCATION_MZONE or LOCATION_HAND+LOCATION_MZONE)
     e:SetOperation(function() end)
     c:RegisterEffect(e)
     local q=e:Clone()
     q:SetType(EFFECT_TYPE_QUICK_O)
     q:SetCode(EVENT_CHAINING)
     q:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${reset}) end)
     c:RegisterEffect(q)
     if ${!!test.changedNames} then
      local name=Effect.CreateEffect(c)
      name:SetType(EFFECT_TYPE_SINGLE)
      name:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
      name:SetRange(LOCATION_MZONE)
      name:SetCode(EFFECT_CHANGE_CODE)
      name:SetValue(id==${initial} and ${extraRecipient} or ${initial})
      c:RegisterEffect(name)
     end
    end`;
   if([initial,filler,bottom,extraRecipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+reset+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) ${test.opponentTurnLock?'':`x:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE+LOCATION_GRAVE,nil,${recipient}):GetFirst() assert(tc) Duel.SendtoGrave(tc,REASON_EFFECT) Duel.SpecialSummon(tc,0,1-tp,1-tp,false,false,POS_FACEUP_ATTACK) end)`} c:RegisterEffect(x) end`;
   if(name==='c'+counter+'.lua')return `local s,id=GetID() function s.initial_effect(c) local a=Effect.CreateEffect(c) a:SetType(EFFECT_TYPE_SINGLE) a:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN) a:SetProperty(EFFECT_FLAG_SET_AVAILABLE) c:RegisterEffect(a) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_CHAINING) x:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${starter}) end) x:SetOperation(function(e,tp,eg,ep,ev) ${test.activation?'Duel.NegateActivation(ev)':'Duel.NegateEffect(ev)'} end) c:RegisterEffect(x) end`;
   if(installed&&[boss,starter].some(code=>name==='c'+code+'.lua'))return fs.readFileSync(path.join(process.env.CCG_OMEGA_SCRIPTS,name),'utf8');
   const p=[...((bothHands||musicaleProbe||process.argv.includes('--redirect-check'))?[path.join(mode==='candidate'&&[boss,starter].some(code=>name==='c'+code+'.lua')?CUSTOM:INSTALLED,name)]:[]),path.join(CUSTOM,name),path.join(OMEGA,name)].find(p=>fs.existsSync(p));assert(p,'Missing '+name);let lua=fs.readFileSync(p,'utf8');if(name==='c'+boss+'.lua'&&!bothHands&&!musicaleProbe&&!process.argv.includes('--redirect-check')){lua=fs.readFileSync(path.join(OUT,'oceanica-before-supplemental-negation-repair',name),'utf8');if(mode!=='prior-source')lua=require('./fresh_oceanica_supplemental_negation_repair.cjs').corrected(lua);if(mode==='handler-only')lua=lua.replace('Duel.IsChainDisabled(ev)','re:GetHandler():IsDisabled()');if(mode==='no-bottom')lua=lua.replace('Duel.SendtoDeck(bg,nil,SEQ_DECKBOTTOM,REASON_EFFECT)','do end');if(mode==='no-recovery')lua=lua.replace('Duel.SendtoHand(g,nil,REASON_EFFECT)','0');}if([boss,starter].some(c=>name==='c'+c+'.lua')&&control)lua=fs.readFileSync(path.join(OUT,'remaining-normal-summon-before-repair',name),'utf8');if(name==='c'+starter+'.lua'&&control&&control!=='prior-source')lua=require('./fresh_remaining_normal_summon_repair.cjs').handmeta(lua);if(name==='c'+boss+'.lua'&&control&&!['meta-only','prior-source'].includes(control))lua=require('./fresh_remaining_normal_summon_repair.cjs').oceanica(lua);if(name==='c'+boss+'.lua'&&control==='old-lock')lua=lua.replace(' and not e:GetHandler():IsImmuneToEffect(e)','');if(name==='c'+boss+'.lua'&&control==='no-zero')lua=lua.replace('ea:SetValue(0)','ea:SetValue(1000)');if(name==='c'+boss+'.lua'&&control==='no-immunity')lua=lua.replace('tc:RegisterEffect(ei)','do end');return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,started=false,accepted=false,done=false,turn=0,resetDone=false,addonOffers=0,modeOffers=0,lockResponseChecked=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   if(!process.argv.includes('--unadapted'))core.loadScript(duel,'explicit-chain-disabled-query-adapter.lua',require('./fresh_test_chain_disabled_adapter.cjs').lua);
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.SZONE,0,P.FACEUP_ATTACK,musicaleProbe?0:5);add(starter,L.HAND);add(bottom,L.HAND);if(!test.noResource)add(search,test.grave?L.GRAVE:L.DECK);if(test.skillDrain)add(82732705,L.SZONE,1,P.FACEUP_ATTACK,0);add(initial,L.HAND,1);if(musicaleProbe)add(extraRecipient,L.DECK,1);if(!test.absent)add(recipient,L.HAND,1);if(bothHands)add(extraRecipient,L.HAND,1);if(test.negated)add(counter,L.SZONE,1,P.FACEDOWN_DEFENSE);if(test.reset)add(reset,L.HAND);for(const p of [0,1])for(let i=0;i<10;i++)add(filler,L.DECK,p);
   if(test.changedNames)add(extraRecipient,L.MZONE,1,P.FACEUP_ATTACK,2);
   if(test.opponentTurnLock)add(reset,L.HAND);
   core.startDuel(duel);const query=(loc,p=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.DEFENSE|Q.POSITION,controller:p,location:loc}).filter(Boolean);
   for(let step=0;step<230&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);turn+=messages.filter(m=>m.type===M.NEW_TURN).length;
    if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));if(state===S.END)throw Error('Unexpected duel end');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!started){if(p.player===0){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.summons.findIndex(c=>c.code===initial);assert(index>=0);started=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});continue;}
     if(musicaleProbe){
      const summonType=test.special?M.SPSUMMONING:M.SUMMONING;
      const chains=trace.filter(m=>m.type===M.CHAINING).map(m=>m.code);
      assert(accepted,'Bobbie activated');
      if(test.secondLink){
       assert.deepEqual(chains.slice(0,2),[initial,starter],'Bobbie activates above the mandatory trigger');
       const lowerLink=trace.findIndex(m=>m.type===M.RECOVER&&m.player===1&&m.amount===100);
       const firstChainEnd=trace.findIndex(m=>m.type===M.CHAIN_END);
       const musicaleLink=trace.findIndex(m=>m.type===M.CHAINING&&m.code===boss);
       assert(lowerLink>=0&&firstChainEnd>lowerLink&&musicaleLink>firstChainEnd,'Musicale waits for the lower link and starts in a new chain');
      }
      if(test.negated)assert(trace.some(m=>m.type===(test.activation?M.CHAIN_NEGATED:M.CHAIN_DISABLED)),'Native negation occurred');
      const expectedTrigger=!test.activation;
      assert.equal(trace.some(m=>m.type===summonType&&m.code===recipient),!test.generic&&!test.negated,'Bobbie performs the chosen opponent Summon when resolving');
      assert.equal(chains.filter(code=>code===boss).length,Number(expectedTrigger),'Musicale activation count');
      assert.equal(query(L.HAND,1).some(c=>c.code===extraRecipient),expectedTrigger,'Musicale opposing search result');
      assert.equal(query(L.MZONE).some(c=>c.code===starter),!test.negated,'Bobbie reaches the field when resolving');
      if(test.opponentTurnLock){
       if(p.player===1){
        const offered=(description,location)=>p.activates.some(c=>Number(c.description)===description&&c.location===location);
        assert.equal(offered(initial,L.MZONE),!test.changedNames||turn>=4,'Field effect is restricted only while its current name matches');
        assert.equal(offered(extraRecipient,L.HAND),turn>=4,'Searched monster activation returns on the following opponent turn');
        if(test.changedNames)assert(offered(extraRecipient,L.MZONE),'Copy whose name changed away stays available');
       }
       if(turn===3&&!resetDone){
        const index=p.activates.findIndex(c=>c.code===reset);
        assert(index>=0,'Next-turn response probe is available');
        resetDone=true;
        core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
        continue;
       }
       if(turn<4){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
       assert(lockResponseChecked,'Next-turn response availability was checked');
       assert.equal(p.player,1,'Expiry checked on the following opponent turn');
      }
      done=true;
      continue;
     }
     assert(accepted,'Original Harmony Hand trigger accepted');assert.equal(query(L.MZONE).some(c=>c.code===starter),!test.negated,'Original source outcome follows actual negation');assert.equal(addonOffers,test.negated?0:1,'Original opponent-Hand source offers recovery unless its effect is negated');
     const expected=!test.negated;const tc=query(L.MZONE,1).find(c=>c.code===recipient);assert.equal(!!tc,expected,'Oceanica native opponent Hand summon');
     if(tc){assert.equal(tc.attack,0,'Original Bobbie recipient ATK zero');}
     if(test.reset&&!resetDone){if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===reset);assert(index>=0);resetDone=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.redirect)assert(query(L.REMOVED).some(c=>c.code===search),'Recovered card actually redirected to banishment');
     const reveal=trace.filter(m=>m.type===M.CONFIRM_CARDS&&m.player===1&&m.cards.some(c=>c.code===search)).length;
     if(process.argv.includes('--redirect-check'))assert.deepEqual([reveal,query(L.HAND).some(c=>c.code===bottom)],[test.redirect?0:1,!!test.redirect],'Successful receipt gates reveal and bottom');
     if(bothHands){const extra=query(L.MZONE,1).find(c=>c.code===extraRecipient);assert.equal(modeOffers,1,'Oceanica offers both supplemental modes');assert.equal(!!extra,!!test.ownMode,'Only own-Hand mode summons a second opponent monster');if(extra)assert.equal(extra.attack,0);}
     if(competingUpper){
      const lower=trace.findIndex(m=>m.type===M.CHAIN_SOLVING&&m.chain_size===1);
      const upper=trace.findIndex(m=>m.type===M.CHAIN_SOLVED&&m.chain_size===2);
      const first=trace.findIndex(m=>[M.SUMMONING,M.SPSUMMONING].includes(m.type)&&m.code===recipient);
      const second=trace.findIndex(m=>[M.SUMMONING,M.SPSUMMONING].includes(m.type)&&m.code===extraRecipient);
      assert(upper>=0&&upper<first&&first<second&&second<lower,'Both instructed summons occur between the two links: '+[upper,first,second,lower]);
     }
     const recovered=!test.ownMode&&!test.redirect&&!test.decline&&!test.noResource&&!test.negated;assert.equal(trace.filter(m=>m.type===M.MOVE&&m.card===search&&m.to.location===L.HAND).length,recovered?1:0,'Actual Deck/GY to Hand recovery even when recovered card is bottomed');assert.equal(query(L.HAND).some(c=>c.code===search),recovered&&!test.bottomRecovered,'Actual Nautica recovery outcome');assert.equal(query(L.HAND).some(c=>c.code===bottom),!recovered||!!test.bottomRecovered,'Chosen pre-existing versus recovered bottom resource');if(recovered){const code=test.bottomRecovered?search:bottom;assert.equal(query(L.DECK)[0]?.code,code,'Actual chosen bottom-of-Deck card');}done=true;
    }
    else if(p.type===M.SELECT_CHAIN){
     if(test.opponentTurnLock&&turn===3&&p.player===1&&p.selects.length){
      const offered=(description,location)=>p.selects.some(c=>Number(c.description)===description&&c.location===location);
      assert(!offered(extraRecipient,L.HAND),'Same-name Hand response is restricted through the next turn');
      assert(offered(test.changedNames?extraRecipient:initial,L.MZONE),'Different-name field response stays available');
      lockResponseChecked=true;
     }
     const wanted=p.selects.some(c=>c.code===counter)?counter:p.player===0?(musicaleProbe&&p.selects.some(c=>c.code===boss)?boss:starter):recipient;
     const i=p.selects.findIndex(c=>c.code===wanted);
     if(i>=0&&wanted===starter)accepted=true;
     core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:i>=0?i:null});
    }
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===starter)accepted=true;assert([starter,recipient,search,boss].includes(p.code));core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code!==search});}
    else if(p.type===M.SELECT_YESNO){addonOffers++;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_OPTION){
     const oceanicaChoice=p.player===0&&p.options.map(Number).includes(133941091*16+1);
     if(bothHands&&oceanicaChoice)modeOffers++;
     const normalRequested=test.ownMode&&(addonOffers?test.followupNormal:test.originalNormal);
     const index=oceanicaChoice?Number(!!test.ownMode):Number(!normalRequested&&!!(test.special||test.ownMode));
     core.duelSetResponse(duel,{type:R.SELECT_OPTION,index});
    }
    else if(p.type===M.SELECT_CARD){const i=p.selects.findIndex(c=>c.code===(p.player===1?(test.ownMode&&addonOffers?p.selects.find(c=>c.code===extraRecipient)?.code??recipient:p.selects.some(c=>c.code===recipient)?recipient:extraRecipient):p.selects.some(c=>c.location===L.DECK||c.location===L.GRAVE)?search:test.bottomRecovered?search:bottom));assert(i>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[i]});}
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0)),seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert.notEqual(seq,undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   assert(done,'Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({test,failure,accepted,addonOffers,modeOffers,trace,logs});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-oceanica-recovery'+(bothHands?competingSummons?(competingUpper?'-competing-upper':'-competing-summons'):'-both-hands':musicaleProbe?'-bobbie-musicale':'')+(process.argv.includes('--redirect-check')?'-redirect-check':'')+(starter===226645052?'':'-'+starter)+'-'+mode+(process.argv.includes('--unadapted')?'-unadapted':'')+'.json'),JSON.stringify({scope:"Original Oceanica and original Bobbie Hand effect; actual Deck/GY recovery, chosen bottom card, decline/resource/Skill Drain/source-negation boundaries. Explicit test-only IsChainDisabled query backed by native EVENT_CHAIN_DISABLED and CHAIN_END; no production API replacement. Unadapted/public query gap and original-runtime verification remain open. No full-card/live Omega certification.",control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
