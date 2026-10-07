"""Create an isolated public WASM wrapper adapter; never edit installed Omega or node_modules."""
from pathlib import Path
import re, hashlib, json
root=Path(__file__).resolve().parent.parent
source=root/'node_modules/@n1xx1/ocgcore-wasm/dist/index.js'
s=source.read_text(encoding='utf-8')
old='case 36:return{type:t,location:e.u8(),cards:Array.from({length:e.u32()},()=>({from:p(e),to:p(e)}))};'
new='case 36:{let l=e.u8(),n=e.u8(),f=Array.from({length:n},()=>p(e)),z=Array.from({length:n},()=>p(e));return{type:t,location:l,cards:f.map((from,i)=>({from,to:z[i]}))};}'
assert s.count(old)==1, 'Public wrapper changed; re-review protocol before applying adapter'
s=s.replace(old,new)
s=re.sub(r'"\./([^"\n]+)"', lambda m:'"'+(source.parent/m.group(1)).resolve().as_uri()+'"',s)
out=root/'output/fresh-ccg-september/public-core-set-message-adapter.mjs'
out.write_text(s,encoding='utf-8')
print(json.dumps({'source_sha256':hashlib.sha256(source.read_bytes()).hexdigest(),'adapter_sha256':hashlib.sha256(out.read_bytes()).hexdigest(),'production_changed':False}))
