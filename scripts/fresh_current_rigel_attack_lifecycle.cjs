'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_current_rigel_material_atk.cjs');let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep('filler=900009103;','filler=900009103,prep=900009205,leave=900009206;');
rep('SelectIdleCMDAction:A,OcgQueryFlags:Q}', 'SelectIdleCMDAction:A,OcgQueryFlags:Q,SelectBattleCMDAction:B}');
rep("[['ordinary',0,0],['mixed',1,2],['links',2,4]]","[['attackAll',1,2],['replacementCopy',1,2]]");
rep(' const procedure=(final)=>'," cards.set(prep,{...base,code:prep,type:2});cards.set(leave,{...base,code:leave,type:2});const procedure=(final)=>");
rep("if(name==='c0.lua')return '';", "if(name==='c0.lua')return '';if(name==='c'+prep+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) if '${scenario}'=='replacementCopy' then local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${body}):Select(tp,2,2,nil) local lc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${link}) assert(lc and lc:IsStatus(STATUS_PROC_COMPLETE)) g:AddCard(lc) assert(Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)==3) else local g=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_GRAVE,nil,${filler}) assert(#g==2) assert(Duel.SpecialSummon(g,0,tp,1-tp,false,false,POS_FACEUP)==2) end end) c:RegisterEffect(e) end`;if(name==='c'+leave+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetFieldCard(tp,LOCATION_MZONE,5) assert(tc and tc:IsCode(${boss})) assert(Duel.SendtoGrave(tc,REASON_EFFECT)==1) end) c:RegisterEffect(e) end`;");
rep("if(process.argv.includes('--no-bonus'))lua=lua.replace('e1:SetValue(val)','e1:SetValue(0)');", "if(process.argv.includes('--per-copy'))lua=lua.replace('e5:SetCountLimit(1,id)','e5:SetCountLimit(1)');if(process.argv.includes('--no-attack-all'))lua=lua.replace('e2:SetCode(EFFECT_ATTACK_ALL)','e2:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)');if(process.argv.includes('--no-atk-expiry'))lua=lua.replace('e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)','e1:SetReset(RESET_EVENT+RESETS_STANDARD)');if(process.argv.includes('--no-all-expiry'))lua=lua.replace('e2:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)','e2:SetReset(RESET_EVENT+RESETS_STANDARD)');if(process.argv.includes('--no-other-lock'))lua=lua.replace('Duel.RegisterEffect(e3,tp)','do end');if(process.argv.includes('--source-dependent-lock'))lua=lua.replace('Duel.RegisterEffect(e3,tp)','e3:SetRange(LOCATION_MZONE) c:RegisterEffect(e3)');");
rep('activated=false,done=false','activated=false,stage="setup",turn=0,attacks=0,reused=false,done=false');
rep('add(boss,L.EXTRA,0,0,P.FACEDOWN_DEFENSE);',"add(boss,L.EXTRA,0,0,P.FACEDOWN_DEFENSE);if(scenario==='replacementCopy')add(boss,L.EXTRA,0,0,P.FACEDOWN_DEFENSE);add(filler,L.MZONE,0,4);add(filler,L.MZONE,1,0);add(filler,L.MZONE,1,1);add(prep,L.HAND);if(scenario==='replacementCopy')add(leave,L.HAND);");
rep('step<150','step<350');
rep("const sequence=[5,6,0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);assert.notEqual(sequence,undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});", "const places=[];for(const player of [0,1])for(const location of [L.MZONE,L.SZONE])for(const sequence of [5,6,0,1,2,3,4]){if(location===L.SZONE&&sequence>4)continue;const shift=player*16+(location===L.SZONE?8:0)+sequence;if((p.field_mask&(1<<shift))===0)places.push({player,location,sequence});}assert(places.length,'Native legal placement');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:places.slice(0,p.count)});");
rep('trace.push(...ms);','trace.push(...ms);turn+=ms.filter(m=>m.type===M.NEW_TURN).length;');
const a=s.indexOf('  if(p.type===M.SELECT_IDLECMD)'),b=s.indexOf('  else if(p.type===M.SELECT_CARD)',a);assert(a>0&&b>a);
s=s.slice(0,a)+`  if(p.type===M.SELECT_IDLECMD){
   const send=action=>core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action});
   const activate=code=>{const i=p.activates.findIndex(c=>c.code===code);assert(i>=0,'Expected activation '+code);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:i});};
   const summon=code=>{const i=p.special_summons.findIndex(c=>c.code===code);assert(i>=0,'Expected paid Link summon');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index:i});};
   const field=()=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:0,location:L.MZONE}).filter(Boolean),own=()=>field().filter(c=>c.code===boss);
   if(p.player!==0||turn<3){send(A.TO_EP);continue;}
   if(stage==='setup'){
    if(made<preps){made++;summon(link);}else if(!summoned){summoned=true;summon(boss);}else if(!activated){activated=true;activate(boss);}else{assert.equal(own()[0].attack,4000,'Actual initial boost');assert(!p.activates.some(c=>c.code===boss),'Same-turn first-source use excluded');if(scenario==='replacementCopy'){stage='replenish';activate(prep);}else{stage='battle3';send(A.TO_BP);}}
   }else if(stage==='replenish'){stage='second';summon(boss);
   }else if(stage==='second'){assert.equal(own().length,2,'Two native paid Link copies');assert(!p.activates.some(c=>c.code===boss),'Named other-copy use excluded');stage='leave';activate(leave);
   }else if(stage==='leave'){assert.equal(own().length,1);assert(trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.from.location===L.MZONE&&m.from.sequence===5&&m.to.location===L.GRAVE),'First source actually left');stage='battle3';send(A.TO_BP);
   }else if(stage==='afterBattle3'){assert.equal(turn,5);assert.equal(own()[0].attack,2000,'ATK expires or fresh second-copy base');assert(p.activates.some(c=>c.code===boss),'Named use resets naturally');if(scenario==='attackAll'){stage='ready5';activate(prep);}else{stage='battle5';send(A.TO_BP);}
   }else if(stage==='ready5'){stage='battle5';send(A.TO_BP);
   }else if(stage==='m2'){if(!reused){reused=true;activate(boss);}else{assert.equal(own()[0].attack,4000,'Actual reuse after natural reset');assert(!p.activates.some(c=>c.code===boss));done=true;}}
   else throw Error('Unexpected Main stage '+stage);
  }else if(p.type===M.SELECT_BATTLECMD){
   const act=(action,index)=>core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action,index});
   const source=p.attacks.findIndex(c=>c.code===boss),ally=p.attacks.some(c=>c.code===filler);
   if(stage==='battle3'){
    assert(!ally,'Other-monster attack restriction');
    if(scenario==='replacementCopy'){assert(source<0,'Independent attack lock persists after original source leaves');stage='afterBattle3';attacks=0;act(B.TO_EP);}
    else if(attacks<2){assert(source>=0,'Attack each opposing monster');attacks++;act(B.SELECT_BATTLE,source);}
    else{assert(source<0,'No third or direct attack after both targets');assert.equal(core.duelQueryCount(duel,1,L.MZONE),0,'Two opposing monsters actually destroyed');stage='afterBattle3';attacks=0;act(B.TO_EP);}
   }else if(stage==='battle5'){
    assert(ally,'Other-monster attack restriction expires');
    if(attacks===0){assert(source>=0);attacks++;act(B.SELECT_BATTLE,source);}else{assert(source<0,'Attack-all expires or fresh second copy attacks once');assert.equal(core.duelQueryCount(duel,1,L.MZONE),1);stage='m2';act(B.TO_M2);}
   }else throw Error('Unexpected Battle stage '+stage);
  }
`+s.slice(b);
rep("const suffix=process.argv.includes('--old-source')?'-old-source':process.argv.includes('--candidate')?'-candidate':process.argv.includes('--no-bonus')?'-no-bonus':process.argv.includes('--original-procedure')?'-original-procedure':'';", "const control=['per-copy','no-attack-all','no-atk-expiry','no-all-expiry','no-other-lock','source-dependent-lock'].find(v=>process.argv.includes('--'+v));const suffix=control?'-'+control:'';");
rep('current-rigel-material-atk','current-rigel-attack-lifecycle');
s=s.replace(/scope:'Full Rigel effect source[^']*'/,"scope:'Full Rigel effect source/current installed metadata/corrected transport, paid fixed native Link setup from existing material harness. Natural own turns3/5, actual two opposing attacks, boost and attack-all expiry, named same/other-copy exclusion and actual reset reuse, other-monster attack restriction including after first source leaves. Proper second Link copy uses genuine GY-revived Link2 plus two bodies. Test-only fixed procedures; not original general Link helper/full-card/live Omega.'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
