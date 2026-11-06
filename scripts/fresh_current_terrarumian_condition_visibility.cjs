'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_terrarumian_cushion_pendulum.cjs');let s=fs.readFileSync(file,'utf8');
function replace(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
replace("const fs=require('node:fs')","const assert=require('node:assert/strict');const fs=require('node:fs')");
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

replace("for(const test of cushion===284639717?[{own:false,opp:false,allowed:true},{own:true,opp:false,allowed:false},{own:true,opp:true,allowed:true}]:[{own:false,opp:false,allowed:false},{own:true,opp:false,allowed:true},{own:false,opp:true,allowed:false}])", "for(const test of [{own:true,faceup:true,opp:false,allowed:cushion!==284639717},{own:true,faceup:false,opp:false,allowed:false},{own:true,faceup:false,opp:true,allowed:cushion===284639717},{own:true,faceup:false,extraFaceup:true,opp:false,allowed:cushion!==284639717}])");
replace('if(test.own)add(own,L.MZONE);',"if(test.own)core.duelNewCard(duel,{team:0,duelist:0,code:own,controller:0,location:L.MZONE,sequence:0,position:test.faceup?P.FACEUP_ATTACK:P.FACEDOWN_DEFENSE});if(test.extraFaceup)core.duelNewCard(duel,{team:0,duelist:0,code:own,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});");
replace("return process.argv.includes('--no-condition')?fs.readFileSync(file,'utf8').replace(':SetCondition(s.pcon)',':SetCondition(function() return true end)'):fs.readFileSync(file,'utf8')", "let lua=fs.readFileSync(file,'utf8');if(name==='c'+cushion+'.lua'&&cushion!==284639717){if(process.argv.includes('--old-source'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-before-condition-visibility-repair',name),'utf8');if(process.argv.includes('--candidate'))lua=require('./fresh_terrarumian_condition_visibility_repair.cjs').corrected(lua);}if(process.argv.includes('--no-condition'))lua=lua.replace(':SetCondition(s.pcon)',':SetCondition(function() return true end)');return lua");

s=s.replace('current-terrarumian-conditions','current-terrarumian-condition-visibility');
replace("(process.argv.includes('--no-condition')?'-no-condition':'')+'.json'", "(process.argv.includes('--old-source')?'-old-source':process.argv.includes('--candidate')?'-candidate':process.argv.includes('--no-condition')?'-no-condition':'')+'.json'");
s=s.replace("engine:'public OCGCore with Omega Lua; not native Omega'","scope:'Full original eight sources/current installed metadata/corrected public transport/no Lua API adapter. Actual Hand-to-PZone placement and native ignition-menu eligibility. Own faceup/hidden/hidden plus opponent/hidden plus additional faceup witnesses distinguish public archetype condition; Cushion different no-monsters OR opponent condition preserved. Faceup neutral destruction resource keeps other activation requirements available. No primary-resolution/full-card/live Omega claim.'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
