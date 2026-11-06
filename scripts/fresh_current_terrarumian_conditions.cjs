'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_terrarumian_cushion_pendulum.cjs');let s=fs.readFileSync(file,'utf8');
function replace(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
replace('Number(process.argv[2]||284639717)','284639717');
replace("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
replace('for(const test of cushion===', 'for(const cushion of [284639717,284639718,284639719,284639720,284639721,284639722,284639723,284639724])for(const test of cushion===');
replace('[{own:false,opp:false,allowed:false},{own:true,opp:false,allowed:true}]','[{own:false,opp:false,allowed:false},{own:true,opp:false,allowed:true},{own:false,opp:true,allowed:false}]');
replace("if(!cards.has(code))throw Error('Missing card '+code)","if(code<900000000)return require('./fresh_installed_card.cjs').candidateCard(code);if(!cards.has(code))throw Error('Missing card '+code)");
replace("return fs.readFileSync(file,'utf8')","return process.argv.includes('--no-condition')?fs.readFileSync(file,'utf8').replace(':SetCondition(s.pcon)',':SetCondition(function() return true end)'):fs.readFileSync(file,'utf8')");
replace("if(!test.allowed){", "if((index>=0)!==test.allowed)throw Error('Printed primary activation condition mismatch');done=true;break;if(!test.allowed){");
replace('results.push({test,','results.push({passcode:cushion,test,');
replace('cardId:cushion,results','cards:8,results');
replace('`output/fresh-ccg-september/terrarumian-${cushion}-pendulum.json`',"'output/fresh-ccg-september/current-terrarumian-conditions'+(process.argv.includes('--no-condition')?'-no-condition':'')+'.json'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
