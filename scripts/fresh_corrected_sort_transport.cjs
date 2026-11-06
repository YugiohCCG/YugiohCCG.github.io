'use strict';
// Test-only SORT_CARD response correction; does not change Omega or installed libraries.
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url');
exports.loadCorrectedSortTransport=async()=>{
 await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const dist=path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist');
 const source=fs.readFileSync(path.join(dist,'index-card-data-transport-candidate.mjs'),'utf8');
 const wrong='t.i8(e.order.length);for(let r of e.order)t.i8(r)',correct='for(let r of e.order)t.i8(r)';
 assert.equal(source.split(wrong).length,2);
 const candidate=source.replace(wrong,correct),file=path.join(dist,'index-card-data-sort-transport-candidate.mjs');
 if(!fs.existsSync(file)||fs.readFileSync(file,'utf8')!==candidate)fs.writeFileSync(file,candidate);
 return import(pathToFileURL(file).href);
};
