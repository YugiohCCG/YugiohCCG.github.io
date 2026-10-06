"use strict";
const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto');
const root=path.resolve(__dirname,'..'),ref=path.join(root,'tmp/omega_scripts'),out=path.join(root,'output/fresh-ccg-september');
const hash=b=>crypto.createHash('sha256').update(b).digest('hex');
const lua=require('luaparse');
const parseFailures=[];
const extract=(s,file)=>{
 let ast;
 try{ast=lua.parse(s,{luaVersion:'5.3',locations:true});}
 catch(e){parseFailures.push({file,error:e.message});return [];}
 const calls=[];
 const walk=node=>{
  if(!node||typeof node!=='object')return;
  if(node.type==='FunctionDeclaration'&&node.identifier?.type==='MemberExpression'){
   const id=node.identifier;
   if(id.indexer==='.'&&id.base.type==='Identifier'&&['aux','Auxiliary'].includes(id.base.name))calls.push({api:'aux.'+id.identifier.name,line:node.loc.start.line,evidence_kind:'helper_definition'});
  }
  if(['CallExpression','TableCallExpression','StringCallExpression'].includes(node.type)){
   const base=node.base;
   if(base?.type==='MemberExpression'){
    let api;
    if(base.indexer===':')api='method.'+base.identifier.name;
    else if(base.base.type==='Identifier'&&['Duel','Card','Effect','Group','aux','Auxiliary'].includes(base.base.name))api=(base.base.name==='Auxiliary'?'aux':base.base.name)+'.'+base.identifier.name;
    if(api)calls.push({api,evidence_kind:'call',line:node.loc.start.line,argument_count:node.arguments?.length,receiver_type_verified:false});
   }
  }
  for(const [key,value] of Object.entries(node)){if(key==='loc')continue;if(Array.isArray(value))value.forEach(walk);else if(value&&typeof value==='object')walk(value);}
 };
 walk(ast);return calls;
};
const evidence=new Map();let refCount=0;
const referenceFiles=(dir,prefix='')=>fs.readdirSync(dir,{withFileTypes:true}).sort((a,b)=>a.name.localeCompare(b.name)).flatMap(e=>e.isDirectory()?referenceFiles(path.join(dir,e.name),prefix+e.name+'/'):e.name.endsWith('.lua')?[prefix+e.name]:[]);
for(const name of referenceFiles(ref)){
 const file=path.join(ref,name),src=fs.readFileSync(file,'utf8');refCount++;
 for(const {api,line} of extract(src,name)){const e=evidence.get(api);if(e)e.files.add(name);else evidence.set(api,{files:new Set([name]),reference:name,line,reference_sha256:hash(src)});}
}
const roster=JSON.parse(fs.readFileSync(path.join(out,'baseline-remote.json'),'utf8')).cards;
const cards=roster.map(c=>{const file=path.join(root,'public/CCG Downloads/CCG_Scripts/c'+c.passcode+'.lua'),src=fs.readFileSync(file,'utf8');return {passcode:c.passcode,name:c.name,script_sha256:hash(src),calls:extract(src,file).map(call=>{const e=evidence.get(call.api);return {...call,reference_file:e?.reference,reference_line:e?.line,reference_sha256:e?.reference_sha256,reference_file_count:e?.files.size||0,status:e?'REFERENCE_CALL_EXISTS':'REVIEW_NO_REFERENCE_CALL'};}),native_omega_verified:false};});
const missing=[...new Set(cards.flatMap(c=>c.calls.filter(a=>!a.reference_file).map(a=>a.api)))].sort();
fs.writeFileSync(path.join(out,'omega-api-reference-review.json'),JSON.stringify({scope:'All 711 parsed Lua namespace and colon-method call sites against designated Omega corpus. Method names do not verify receiver type. Argument counts recorded for triage only; no signature, callback, semantic, dynamic-call or native runtime certification. Missing names are review hints, not proof of unsupported APIs.',reference_file_count:refCount,parse_failures:parseFailures,summary:{cards:cards.length,unique_unreferenced_calls:missing},cards},null,2)+'\n');
console.log(JSON.stringify({cards:cards.length,reference_files:refCount,parse_failures:parseFailures,unreferenced_calls:missing},null,2));
