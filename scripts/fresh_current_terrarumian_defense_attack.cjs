'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module');
const control=['no-attack','use-defense'].find(v=>process.argv.includes('--'+v)),file=path.join(__dirname,'fresh_terrarumian_cushion_defense_attack.cjs');let text=fs.readFileSync(file,'utf8');
text=text.replace("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
text=text.replace('return cards.get(code)',"return code===cushion?{...require('./fresh_installed_card.cjs').candidateCard(code),attack:900,defense:3000}:cards.get(code)");
text=text.replace("return fs.readFileSync(file,'utf8')",`return fs.readFileSync(file,'utf8')${control==='no-attack'?".replace('SetCode(EFFECT_DEFENSE_ATTACK)','SetCode(EFFECT_CANNOT_ATTACK)')":control==='use-defense'?".replace(/(SetCode\\(EFFECT_DEFENSE_ATTACK\\)[\\s\\S]*?SetValue\\()0/,'$11')":''}`);
text=text.replace('terrarumian-${cushion}-defense-attack.json','current-terrarumian-${cushion}-defense-attack'+(control?'-'+control:'')+'.json');const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(text,file);
