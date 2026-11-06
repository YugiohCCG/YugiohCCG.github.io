'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_current_seraphina_pendulum_use_reset.cjs'),control=process.argv.includes('--old-source')?'old-source':process.argv.includes('--no-summon')?'no-summon':null;
let s=fs.readFileSync(file,'utf8');
function replace(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
replace("require('./fresh_current_card.cjs')","require('./fresh_installed_card.cjs')");
replace("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
replace("const control=['per-copy','no-reset','no-response'].find(c=>process.argv.includes('--'+c));",`const control=${JSON.stringify(control)};`);
replace("if(control==='old-source')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/seraphina-before-capacity-repair/c218142234.lua'),'utf8');", "if(control==='old-source')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/seraphina-before-unprinted-limit-repair/c218142234.lua'),'utf8');if(process.argv.includes('--candidate'))lua=lua.replace(/\\te1:SetCountLimit\\(1,id\\)\\r?\\n/,'');");
// The reused fixture previously asserted the unprinted named limit. Both paid
// activations must instead resolve on turn one, including after either negation.
replace("if(stage===1&&turn===1){assert(!p.activates.some(c=>c.code===boss),'Shared named Pendulum use excludes second copy');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}", "");
replace('assert.equal(turn,3);','assert.equal(turn,1,\'No printed Pendulum once-per-turn limit\');');
replace("if(control==='ignore-capacity')", "if(control==='no-summon')lua=lua.replace('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0','0>0');if(control==='ignore-capacity')");
// Avoid the archived candidate flag's unrelated capacity candidate loader.
replace("&&process.argv.includes('--candidate'))lua=fs.readFileSync", "&&false)lua=fs.readFileSync");
s=s.replace(/'output\/fresh-ccg-september\/current-seraphina-pendulum-use-reset'/g,"'output/fresh-ccg-september/current-seraphina-unlimited-pendulum'");
s=s.replace(/scope:'[^']*'/,"scope:'Same-turn two-copy printed Pendulum reuse after success/negated activation/negated effect. Full source/current installed metadata/corrected transport/native costs and paid neutral Fusion histories; no Lua API adapter. No original Fusion recipe or live Omega certification.'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
