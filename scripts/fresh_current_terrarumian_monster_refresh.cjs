'use strict';
// Reuse historical scenarios, replacing only transport, production metadata and output names.
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module');
const root=path.resolve(__dirname,'..'),name=process.argv[2],control=process.argv.includes('--no-operation');
const operations={cushion_destroyed:'thop',coin_banish:'rmop',sword_fern_set:'stop',nerve_destroy:'desop',staghorn_destroyed:'desop',ivy_destroyed:'desop',trumpet_hand:'spop',trumpet_battle_chain:'desop'};
if(!Object.hasOwn(operations,name))throw Error('Unknown focused fixture');
const file=path.join(__dirname,'fresh_terrarumian_'+name+'.cjs');let text=fs.readFileSync(file,'utf8');
const old="await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)";
if(!text.includes(old))throw Error('Transport source changed');
text=text.replace(old,"await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
text=text.replace('return cards.get(code)',"return code<900000000?require('./fresh_installed_card.cjs').candidateCard(code):cards.get(code)");
const stem='terrarumian-'+name.replaceAll('_','-');text=text.replace(stem+'.json','current-'+stem+(control?'-no-operation':'')+'.json');
if(control){const pattern=':SetOperation(s.'+operations[name]+')';text=text.replace("return fs.readFileSync(file,'utf8')",`return fs.readFileSync(file,'utf8').replaceAll(${JSON.stringify(pattern)},':SetOperation(function() end)')`);}
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(text,file);
