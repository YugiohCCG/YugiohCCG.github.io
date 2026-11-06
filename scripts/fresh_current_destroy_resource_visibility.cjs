'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_terrarumian_trumpet_hand.cjs');let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep("const fs=require('node:fs')","const assert=require('node:assert/strict');const fs=require('node:fs')");
rep("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
rep('for(const test of [{set:true,pendulum:true,allowed:true},{set:false,pendulum:true,allowed:false},{set:true,pendulum:false,allowed:false}])',"for(const subject of [{code:238276248,set:0x11f},{code:284636589,set:0xa122},{code:247755871,set:0xa121}])for(const test of [{kind:'faceupMonster',set:true,monster:true,allowed:true},{kind:'hiddenMonster',set:true,monster:true,hidden:true,allowed:false},{kind:'wrongMonster',set:false,monster:true,allowed:false},{kind:'hiddenGenericST',set:false,hidden:true,monster:false,allowed:subject.code===247755871},{kind:'faceupArchetypeST',set:true,monster:false,allowed:subject.code!==238276248},...(subject.code!==247755871?[{kind:'handMonster',set:true,hand:true,monster:true,allowed:true},{kind:'handST',set:true,hand:true,monster:false,allowed:subject.code===284636589}]:[])])");
rep('test.set?[0xA122]:[]','test.set?[subject.set]:[]');
rep('test.pendulum?0x1000021:33','test.monster?33:0x20002');

rep('LOCATION_MZONE,0,nil,${pend}) Duel.Destroy(g,REASON_EFFECT)',"0xff,0,nil,${pend}) assert(#g==1) Debug.Message('IdentityPredicate:'..tostring(_G['c${subject.code}'].destroyfilter(g:GetFirst(),tp))) assert(Duel.Destroy(g,REASON_EFFECT)==1)");
rep("if(!cards.has(code))throw Error('Missing card '+code)","if(code===subject.code)return require('./fresh_installed_card.cjs').candidateCard(code);if(!cards.has(code))throw Error('Missing card '+code)");

rep('add(trumpet,L.HAND);add(pend,L.MZONE);',"add(subject.code,L.REMOVED);core.duelNewCard(duel,{team:0,duelist:0,code:pend,controller:0,location:test.hand?L.HAND:test.monster?L.MZONE:L.SZONE,sequence:1,position:test.hidden?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});");
const a=s.indexOf('const m=core.duelQueryLocation'),b=s.indexOf('done=true;',a);assert(a>0&&b>a);
s=s.slice(0,a)+"const records=logs.filter(v=>v.message.startsWith('IdentityPredicate:'));assert.equal(records.length,1,'One native filter observation');assert.equal(records[0].message,'IdentityPredicate:'+String(test.allowed),'Destruction resource identity predicate');assert(trace.some(m=>m.type===M.MOVE&&m.card===pend&&m.from.location===(test.hand?L.HAND:test.monster?L.MZONE:L.SZONE)&&m.to.location===L.GRAVE),'Actual resource origin-to-GY effect destruction');"+s.slice(b);
rep('results.push({test,','results.push({passcode:subject.code,test,');
rep("'output/fresh-ccg-september/terrarumian-trumpet-hand.json'","'output/fresh-ccg-september/current-destroy-resource-visibility.json'");
rep("engine:'public OCGCore with Omega Lua; not native Omega'","scope:'Original Scion/Growth/Jarita destruction resource filters called inside neutral Spell operation before actual native destruction. Native Hand/MZone/SZone resources, hidden archetype monsters, generic hidden S/T and legal Hand resources distinguish location and identity rules. Original source instance in banishment only; no full trigger/effect operation or live Omega certification. Debug identity records expected; no Lua API adapter.'");
rep("return fs.readFileSync(file,'utf8')","let lua=fs.readFileSync(file,'utf8');if(name==='c'+subject.code+'.lua'){if(process.argv.includes('--old-source'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/destroy-before-resource-visibility-repair',name),'utf8');if(process.argv.includes('--candidate'))lua=require('./fresh_destroy_resource_visibility_repair.cjs').corrected(lua,subject.code);}return lua");
rep("'output/fresh-ccg-september/current-destroy-resource-visibility.json'","'output/fresh-ccg-september/current-destroy-resource-visibility'+(process.argv.includes('--old-source')?'-old-source':process.argv.includes('--candidate')?'-candidate':'')+'.json'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
