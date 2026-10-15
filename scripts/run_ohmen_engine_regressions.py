from pathlib import Path
import subprocess,json,concurrent.futures,sys,hashlib
import os
ROOT=Path(__file__).resolve().parents[1];NODE=os.environ.get('NODE','node');OUT=ROOT/'scripts/output/ohmen-lua-regressions';OUT.mkdir(parents=True,exist_ok=True)
recipes={
'beacon_hand_summon':259650969,'beacon_grave_summon':259650969,'beacon_movement_counters':259650969,'beacon_target_protection':259650969,
'capacitor_banish':259350270,'capacitor_grave_banish':259350270,'capacitor_recovery':259350270,
'carcel_dual_summon':259780273,'carcel_link_material':259780273,'carcel_prior_activity':259780273,
'conductor_control':259405917,'conductor_movement':259405917,'conductor_revival':259405917,
'intensity_battle_protection':259479044,'intensity_counter_placement':259479044,'intensity_effect_protection':259479044,'intensity_search_discard':259479044,
'coulomb_linked_summon':259881255,'ohmen_linked_summon':259174227,'ohmen_linked_search':259107906,'ohmen_linked_followup':259174227,'volt_linked_summon':259726853,'volt_linked_followup':259726853,
'ampere_network_counters':259650132,'ampere_two_link_search':259650132,'ampere_linked_search':259650132,'ampere_search_response':259650132,
'powerload_counter_destroy':259434499,'powerload_deck_summon':259434499,'powerload_negation':259434499,
'surge_colink_transitions':259869259,'surge_after_spell':259869259}
label=sys.argv[1] if len(sys.argv)>1 else 'baseline'
def run(pair):
 name,code=pair;fixture={'volt_linked_summon':'ohmen_linked_summon','volt_linked_followup':'ohmen_linked_followup'}.get(name,name);cmd=[NODE,'--no-warnings','scripts/replay_ohmen_engine_case.cjs','fresh_'+fixture+'.cjs',f'--source={code}',f"--target={259434499 if name=='ohmen_linked_search' else 259107906 if name=='ampere_two_link_search' else 259174227}",'--card-data-adapter']
 if name=='carcel_link_material':cmd.append('--public-link-fixture-adapter')
 try:
  p=subprocess.run(cmd,cwd=ROOT,capture_output=True,text=True,encoding='utf8',timeout=40);result={'case':name,'code':code,'status':p.returncode,'stdout':p.stdout,'stderr':p.stderr}
 except subprocess.TimeoutExpired as e:result={'case':name,'code':code,'status':'TIMEOUT','stdout':str(e.stdout),'stderr':str(e.stderr)}
 (OUT/f'{label}-{name}.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf8');return result
results=[]
with concurrent.futures.ThreadPoolExecutor(max_workers=2) as pool:
 for r in pool.map(run,recipes.items()):
  results.append(r);print(('PASS ' if r['status']==0 else 'FAIL ')+r['case']+': '+r['stdout'][-500:].replace('\n',' | '),flush=True)
(OUT/f'{label}-summary.json').write_text(json.dumps(results,ensure_ascii=False,indent=2),encoding='utf8')
print('Passed '+str(sum(r['status']==0 for r in results))+'/'+str(len(results))+' engine fixture families')
raise SystemExit(0 if all(r['status']==0 for r in results) else 1)
