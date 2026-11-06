'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_terrarumian_trumpet_target_lock.cjs');let s=fs.readFileSync(file,'utf8');
function replace(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
replace("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
replace('return cards.get(code)',"return code<900000000?require('./fresh_installed_card.cjs').candidateCard(code):cards.get(code)");
replace("return fs.readFileSync(file,'utf8')","return process.argv.includes('--no-lock')?fs.readFileSync(file,'utf8').replace('SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)','SetCode(EFFECT_CANNOT_ATTACK)'):fs.readFileSync(file,'utf8')");
replace("'output/fresh-ccg-september/terrarumian-trumpet-target-lock.json'","'output/fresh-ccg-september/current-terrarumian-target-lock'+(process.argv.includes('--no-lock')?'-no-lock':'')+'.json'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
