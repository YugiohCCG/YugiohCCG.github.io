'use strict';
// Test-only byte packing correction. Never changes the installed/original runtime.
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url');
exports.loadCorrectedTransport=async()=>{
 const dist=path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist'),original=path.join(dist,'index.js'),generated=path.join(dist,'index-card-data-transport-candidate.mjs');
 const source=fs.readFileSync(original,'utf8'),wrong='e.setUint32(40,t.lscale??0,!0),e.setUint32(48,t.rscale??0,!0),e.setUint32(52,t.link_marker??0,!0)',correct='e.setUint32(40,t.lscale??0,!0),e.setUint32(44,t.rscale??0,!0),e.setUint32(48,t.link_marker??0,!0)';
 if(source.split(wrong).length!==2)throw Error('Runtime layout changed: revalidate transport before generating a diagnostic module');
 const candidate=source.replace(wrong,correct);
 if(!fs.existsSync(generated)||fs.readFileSync(generated,'utf8')!==candidate)fs.writeFileSync(generated,candidate);
 return import(pathToFileURL(generated).href);
};
