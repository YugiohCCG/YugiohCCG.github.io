from pathlib import Path
S=Path.cwd()/'scripts';t=(S/'fresh_current_aquamarine_pisaster_hand.cjs').read_text()
t=t.replace('boss=211682274','boss=216258796').replace("['no-count','allow-partner']","['ignore-revive-limit']")
t=t.replace("[{},{absent:true},{wrongRace:true},{wrongAttribute:true},{facedown:true},{full:true},{count:true},{opponent:true}]","[{}]")
start=t.index("    if(control==='no-count')");end=t.index('\n   }return lua;',start)
t=t[:start]+"    if(control==='ignore-revive-limit')lua=lua.replace('c:EnableReviveLimit()','do end');"+t[end:]
t=t.replace('add(boss,L.HAND);','add(boss,L.GRAVE);')
start=t.index('    if(p.type===M.SELECT_IDLECMD){');end=t.index('\n    else if',start)
t=t[:start]+"    if(p.type===M.SELECT_IDLECMD){assert(!p.special_summons.some(c=>c.code===boss),'Improperly summoned Fusion remains unavailable in GY despite eligible WATER Aqua partner');assert(query(L.GRAVE).some(c=>c.code===boss));assert(!trace.some(m=>m.type===M.SPSUMMONED));done=true;}"+t[end:]
t=t.replace('current-aquamarine-pisaster-hand','current-actinia-improper-revival')
start=t.index("engine:'");end=t.index("',control,results}",start)
t=t[:start]+"engine:'Public OCGCore full current Actinia initially GY without proper Fusion history. Real faceup own WATER Aqua partner and free MZONE still do not permit native revival procedure. No adapters, seeded proper history, or ignored restrictions; ignore-revive-limit negative control. Proper Fusion/revival/nativeOmega/fullcard OPEN."+t[end:]
(S/'fresh_current_actinia_improper_revival.cjs').write_text(t,encoding='utf-8')
t=(S/'fresh_current_actinia_negation_batch.py').read_text().replace('actinia_negation','actinia_improper_revival').replace('actinia-negation','actinia-improper-revival')
t=t.replace("[(None,[]),('no-negate',[0]),('no-destroy',[0]),('no-cost',[0]),('ignore-partner',[1,2,3,4]),('ignore-cost-type',[6,7])]","[(None,[]),('ignore-revive-limit',[0])]")
t=t.replace("'baseline_cases':8","'baseline_cases':1").replace("'scope':data['scope']","'scope':data['engine']").replace('eight cases/five controls','one case/one control')
(S/'fresh_current_actinia_improper_revival_batch.py').write_text(t,encoding='utf-8')
