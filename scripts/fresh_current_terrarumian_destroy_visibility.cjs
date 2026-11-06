'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_terrarumian_cushion_pendulum.cjs');let s=fs.readFileSync(file,'utf8');
function replace(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
replace("const fs=require('node:fs')","const assert=require('node:assert/strict');const fs=require('node:fs')");
replace("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
replace('Number(process.argv[2]||284639717)','284639717');
replace('for(const test of cushion===284639717?[{own:false,opp:false,allowed:true},{own:true,opp:false,allowed:false},{own:true,opp:true,allowed:true}]:[{own:false,opp:false,allowed:false},{own:true,opp:false,allowed:true}])',"for(const cushion of [284639717,284639718,284639719,284639720,284639721,284639722,284639723,284639724])for(const test of [{monster:false,hidden:false,allowed:true},{monster:false,hidden:true,allowed:false},{monster:true,hidden:true,allowed:false}])");
replace("if(!cards.has(code))throw Error('Missing card '+code)","if(code<900000000)return require('./fresh_installed_card.cjs').candidateCard(code);if(code===fodder)return {...cards.get(code),type:test.monster?33:0x20002};if(!cards.has(code))throw Error('Missing card '+code)");
replace("return fs.readFileSync(file,'utf8')","let lua=fs.readFileSync(file,'utf8');if(process.argv.includes('--old-source')&&name==='c'+cushion+'.lua')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-before-destroy-visibility-repair',name),'utf8');if(process.argv.includes('--candidate')&&name==='c'+cushion+'.lua'){const old='return c~=handler and c:IsSetCard(SET_TERRARUMIAN)';assert(lua.includes(old));lua=lua.replace(old,'return c~=handler and c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN)');}return lua");
replace('add(cushion,L.HAND,0,0);add(fodder,L.SZONE,0,1);add(deckPend,L.DECK);if(test.own)add(own,L.MZONE);if(test.opp)add(opp,L.MZONE,1);',"add(cushion,L.HAND,0,0);core.duelNewCard(duel,{team:0,duelist:0,code:fodder,controller:0,location:test.monster?L.MZONE:L.SZONE,sequence:1,position:test.hidden?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});add(deckPend,L.DECK);add(own,L.MZONE);add(opp,L.MZONE,1);");
replace('if(!test.allowed){','if(false){');
replace('let index=p.selects.findIndex(c=>c.code===fodder);',"assert.equal(p.selects.some(c=>c.code===fodder),!test.hidden,'Hidden archetype resource selection mismatch');done=true;break;let index=p.selects.findIndex(c=>c.code===fodder);");
replace('results.push({test,','results.push({passcode:cushion,test,');
replace('cardId:cushion,results','cards:8,results');
replace('`output/fresh-ccg-september/terrarumian-${cushion}-pendulum.json`',"'output/fresh-ccg-september/current-terrarumian-destroy-visibility'+(process.argv.includes('--old-source')?'-old-source':process.argv.includes('--candidate')?'-candidate':'')+'.json'");
replace("engine:'public OCGCore with Omega Lua; not native Omega'","scope:'Diagnostic only: actual Hand-to-PZone and actual primary activation and native destruction selection menus with faceup own archetype condition witness, opponent monster for Cushion alternative, and a separate resource faceup Spell/hidden Spell/hidden monster. Candidate only adds faceup destruction filter. No resolution or live Omega claim.'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
