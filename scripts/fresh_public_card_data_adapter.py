"""Isolated public WASM card-data layout probe; never changes Omega or node_modules."""
from pathlib import Path
import hashlib,json,re
root=Path(__file__).resolve().parents[1]
source=root/'node_modules/@n1xx1/ocgcore-wasm/dist/index.js'
s=source.read_text(encoding='utf-8')
old='e.setUint32(40,t.lscale??0,!0),e.setUint32(48,t.rscale??0,!0),e.setUint32(52,t.link_marker??0,!0)):'
new='e.setUint32(40,t.lscale??0,!0),e.setUint32(44,t.rscale??0,!0),e.setUint32(48,t.link_marker??0,!0)):'
assert s.count(old)==1,'Wrapper layout changed; re-review before adapting'
s=s.replace(old,new)
s=re.sub(r'"\./([^"\n]+)"',lambda m:'"'+(source.parent/m.group(1)).resolve().as_uri()+'"',s)
out=root/'output/fresh-ccg-september/public-core-card-data-adapter.mjs'
out.write_text(s,encoding='utf-8')
print(json.dumps({'source_sha256':hashlib.sha256(source.read_bytes()).hexdigest(),'adapter_sha256':hashlib.sha256(out.read_bytes()).hexdigest(),'production_changed':False}))
