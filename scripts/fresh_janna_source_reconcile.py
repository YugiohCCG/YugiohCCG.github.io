"""Preserve historical repair evidence while verifying a later specification change."""
import difflib, hashlib, json, subprocess
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / 'output/fresh-ccg-september'
CODE = 237684285
def sha(p): return hashlib.sha256(p.read_bytes()).hexdigest()

manifest = json.loads((OUT/'gemini-supported-fixes.json').read_text(encoding='utf-8'))
repair = next(r for r in manifest['changes'] if r['passcode'] == CODE)
source = ROOT/f'public/CCG Downloads/CCG_Scripts/c{CODE}.lua'
old = Path(repair['backup']).read_bytes().decode('utf-8')
assert sha(Path(repair['backup'])) == repair['before_sha256']
old = old.replace('return c:IsSummonType(SUMMON_TYPE_SYNCHRO) and c:GetMaterial():FilterCount',
                  'return c:IsSummonType(SUMMON_TYPE_SYNCHRO) and #c:GetMaterial()>0 and c:GetMaterial():FilterCount')
old = old.replace('if og:FilterCount(Card.IsLocation,nil,LOCATION_HAND)>0 then\n\t\t\tDuel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)\n\t\t\tlocal sg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,99,nil)',
                  'local returned=og:FilterCount(Card.IsLocation,nil,LOCATION_HAND)\n\t\tlocal available=Duel.GetMatchingGroupCount(Card.IsAbleToDeck,tp,LOCATION_HAND,0,nil)\n\t\tlocal ct=math.min(returned,available)\n\t\tif ct>0 then\n\t\t\tDuel.BreakEffect()\n\t\t\tDuel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)\n\t\t\tlocal sg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,ct,ct,nil)')
assert hashlib.sha256(old.encode()).hexdigest() == repair['after_sha256']
expected = old.replace('e1:SetValue(aux.tgoval)', 'e1:SetValue(s.targetlimit)') + '\nfunction s.targetlimit(e,re,rp)\n    return rp~=e:GetHandlerPlayer() or not re:GetHandler():IsSetCard(0x21fc)\nend\n'
assert source.read_bytes() == expected.encode(), 'Unreviewed source delta'
installed = Path(r'C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Scripts')/source.name
assert sha(installed) == sha(source)
cards = json.loads((ROOT/'src/data/cards.json').read_text(encoding='utf-8'))
card = next(c for c in cards if int(c['passcode']) == CODE)
assert 'Cannot be targeted by card effects, except your "Windborne" cards, the turn it is Synchro Summoned.' in card['text']
run = subprocess.run(['lua','scripts/fresh_gemini_callback_regression.lua'],cwd=ROOT,capture_output=True,text=True,check=True)
assert 'PASS 91 production callback assertions' in run.stdout
probe = '''local s={} GetID=function() return s,237684285 end
assert(loadfile('public/CCG Downloads/CCG_Scripts/c237684285.lua'))()
local e={GetHandlerPlayer=function() return 0 end}
for _,rp in ipairs{0,1} do for _,wind in ipairs{false,true} do
 local re={GetHandler=function() return {IsSetCard=function(_,set) assert(set==0x21fc) return wind end} end}
 assert(s.targetlimit(e,re,rp)==(rp~=0 or not wind),'Printed own-Windborne exception')
end end
for _,syn in ipairs{false,true} do for _,same in ipairs{false,true} do
 Duel={GetTurnCount=function() return 3 end}
 local c={IsSummonType=function() return syn end,GetTurnID=function() return same and 3 or 1 end}
 assert(s.indcon({GetHandler=function() return c end})==(syn and same),'Synchro and turn scope')
end end
print('PASS 8 targeting/turn callback assertions')
'''
run = subprocess.run(['lua','-'],input=probe,cwd=ROOT,capture_output=True,text=True,check=True)
assert 'PASS 8 targeting/turn callback assertions' in run.stdout
result = {'scope':'Exact later targeting-exception delta from reconstructed historical repair; current website text, installed parity, 91 prior callback assertions plus 8 targeting/turn callback checks. Candidate DB and baseline roster retain older text; no native targeting or full-card certification.',
          'passcode':CODE,'historical_repair_sha256':repair['after_sha256'],
          'historical_validation_sha256':sha(OUT/'gemini-validation.json'),
          'script_sha256':sha(source),'installed_sha256':sha(installed),
          'reconciliation_script_sha256':sha(Path(__file__)),
          'callback_harness_sha256':sha(ROOT/'scripts/fresh_gemini_callback_regression.lua'),
          'current_card_text':card['text'],'callback_assertions':99,
          'native_omega_verified':False,
          'delta':''.join(difflib.unified_diff(old.splitlines(True),expected.splitlines(True)))}
(OUT/'janna-source-reconciliation.json').write_text(json.dumps(result,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'source_reconciliation':'PASS','callback_assertions':99,'installed_parity':'PASS'}))
