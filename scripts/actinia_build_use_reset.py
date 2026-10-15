from pathlib import Path
S=Path.cwd()/'scripts';t=(S/'fresh_current_actinia_interruption.cjs').read_text()
t=t.replace("['no-negate','no-response']","['per-copy','no-reset','no-response']")
t=t.replace("const tests=[{},{activation:true},{effect:true},{source:true},{partner:true},{original:true},{indestructible:true}];","const tests=[{},{activation:true},{effect:true}];")
t=t.replace("let failure=null,done=false,activated=false,responded=false;","let failure=null,done=false,activated=false,responded=false,attempts=0,negations=0,turn=0,checked=false;")
t=t.replace("if(control==='no-negate')lua=lua.replace('Duel.NegateActivation(ev)','false');","if(control==='per-copy')lua=lua.replace('e2:SetCountLimit(1,id)','e2:SetCountLimit(1)');if(control==='no-reset')lua=lua.replace('e2:SetCountLimit(1,id)','e2:SetCountLimit(1,id,2)');")
t=t.replace("e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,902) end) c:RegisterEffect(e) end'","e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,902) end) c:RegisterEffect(e) local l=Effect.CreateEffect(c) l:SetType(EFFECT_TYPE_SINGLE) l:SetCode(EFFECT_INDESTRUCTABLE_EFFECT) l:SetValue(1) c:RegisterEffect(l) end'")
t=t.replace("add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);","add(boss,L.MZONE,0,P.FACEUP_ATTACK,3);add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);")
t=t.replace("if(!test.noCost)add(cost,L.GRAVE);","add(cost,L.GRAVE);add(cost,L.GRAVE);")
t=t.replace("trace.push(...messages);assert(!logs.length", "trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length")
start=t.index('    if(p.type===M.SELECT_IDLECMD){');end=t.index('    else if(p.type===M.SELECT_CARD)',start)
t=t[:start]+'''    if(p.type===M.SELECT_IDLECMD){
     if(activated){
      assert.equal(negations,attempts===1?1:attempts===2?1:2,'Native shared named use/reset');
      const paid=query(L.REMOVED).filter(c=>c.code===cost);assert.equal(paid.length,negations,'Actual paid costs');assert(paid.every(c=>c.reason&0x80));
      assert(query(L.MZONE).some(c=>c.code===original),'Native indestructible original retained');
      const originals=trace.filter(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='902').length;
      assert.equal(originals,(attempts>=2?1:0)+(test.activation||test.effect?1:0),'Actual negated/unavailable operations');
      if(attempts===3){assert.equal(turn,3);if(test.activation||test.effect){assert(interrupted);assert(trace.some(m=>m.type===M.CHAINING&&m.code===900001196&&m.chain_size===3));}done=true;continue;}
      activated=false;
     }
     if(attempts===2&&turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);attempts++;activated=true;checked=false;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(p.type===M.SELECT_CHAIN){
     let index=-1;const counter=p.selects.findIndex(c=>c.code===900001196);
     if(counter>=0&&attempts===1&&!interrupted&&control!=='no-response'){index=counter;interrupted=true;}
     else if(attempts&&!checked&&p.player===0){const candidate=p.selects.findIndex(c=>c.code===boss);if(candidate>=0||attempts===2){checked=true;assert.equal(candidate>=0,attempts!==2,'Shared named availability');index=candidate;if(index>=0)negations++;}}
     core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});
    }
'''+t[end:]
t=t.replace('current-actinia-interruption','current-actinia-use-reset')
start=t.index("scope:'");end=t.index("',control,results}",start)
t=t[:start]+"scope:'Full current two initial-MZONE Actinia copies with actual own ignition CL1/Quick CL2, native indestructible original. First success or actual CounterTrapCL3 activation/effect negation consumes named shared use, second same-ownturn1 unavailable, next ownturn3 available. Two real WATER Aqua GY costs; actual operations/turns/chain counts asserted. No adapters, seeded count or proper Fusion history. Revival/opponent reset/nativeOmega/fullcard OPEN."+t[end:]
(S/'fresh_current_actinia_use_reset.cjs').write_text(t,encoding='utf-8')
t=(S/'fresh_current_actinia_interruption_batch.py').read_text().replace('actinia_interruption','actinia_use_reset').replace('actinia-interruption','actinia-use-reset')
t=t.replace("[(None,[]),('no-negate',[0,3,4,5,6]),('no-response',[1,2,3,4,5,6])]","[(None,[]),('per-copy',[0,1,2]),('no-reset',[0,1,2]),('no-response',[1,2])]")
t=t.replace("'baseline_cases':7","'baseline_cases':3").replace('seven cases/two controls','three cases/three controls')
(S/'fresh_current_actinia_use_reset_batch.py').write_text(t,encoding='utf-8')
