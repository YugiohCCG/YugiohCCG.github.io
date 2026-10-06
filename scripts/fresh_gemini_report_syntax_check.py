"""Compile report snippets without executing them or changing production scripts."""
import hashlib,json,re,subprocess
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1];OUT=ROOT/'output/fresh-ccg-september'
REPORT=Path(r'C:\Users\hclar\.gemini\antigravity\brain\2502d83b-69f1-4c3d-88d3-8f14eaacfb7b\CCG_Omega_Card_Effect_Bug_Audit_Report.md')
text=REPORT.read_text(encoding='utf-8');dest=OUT/'gemini-report-snippets';dest.mkdir(exist_ok=True);rows=[]
for i,m in enumerate(re.finditer(r'^[ \t]*```lua[^\n]*\n(.*?)^[ \t]*```',text,re.M|re.S),1):
 code=m.group(1);line=text[:m.start()].count('\n')+1;file=dest/f'snippet-{i:03d}-L{line}.lua';file.write_text(code,encoding='utf-8')
 # Lua loadfile parses only; returned function is deliberately never invoked.
 check='local f,e=loadfile('+json.dumps(str(file).replace('\\','/'))+'); if not f then io.stderr:write(e); os.exit(1) end'
 p=subprocess.run(['lua','-e',check],cwd=ROOT,capture_output=True,text=True)
 rows.append({'line':line,'file':file.name,'sha256':hashlib.sha256(file.read_bytes()).hexdigest(),'syntax_pass':p.returncode==0,'diagnostic':p.stderr.strip()})
result={'report_sha256':hashlib.sha256(REPORT.read_bytes()).hexdigest(),'scope':'Parse-only check of all Lua fences. Passing does not verify Omega APIs, card text, rulings or runtime behavior. Snippets were never executed.', 'snippets':rows}
(OUT/'gemini-report-syntax-check.json').write_text(json.dumps(result,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'snippets':len(rows),'syntax_pass':sum(r['syntax_pass'] for r in rows),'failures':[r for r in rows if not r['syntax_pass']]}))
