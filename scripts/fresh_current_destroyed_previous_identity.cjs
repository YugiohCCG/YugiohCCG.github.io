'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_terrarumian_trumpet_hand.cjs');let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep("const fs=require('node:fs')","const assert=require('node:assert/strict');const fs=require('node:fs')");
rep("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
rep('for(const test of [{set:true,pendulum:true,allowed:true},{set:false,pendulum:true,allowed:false},{set:true,pendulum:false,allowed:false}])',"for(const subject of [{code:235051048,set:0x163,fn:'desfilter'},{code:247755869,set:0xa121,fn:'destroyed'},{code:239935098,set:0xa124,fn:'destroyed'}])for(const test of [{set:true,hidden:false,allowed:true},{set:true,hidden:true,allowed:false},{set:false,hidden:false,allowed:false},...(subject.code===239935098?[{set:false,water:true,hidden:false,allowed:true},{set:false,water:true,hidden:true,allowed:false}]:[])])");
rep('test.set?[0xA122]:[]','test.set?[subject.set]:[]');
rep('test.pendulum?0x1000021:33','33');
rep('type:33}],[spell,','type:33,attribute:test.water?2:2,race:test.water?0x80000n:0x400n}],[spell,');
rep('Duel.Destroy(g,REASON_EFFECT) end) c:RegisterEffect(e) end',"assert(Duel.Destroy(g,REASON_EFFECT)==1) end) c:RegisterEffect(e) local watch=Effect.CreateEffect(c) watch:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) watch:SetCode(EVENT_DESTROYED) watch:SetOperation(function(e,tp,eg) for tc in aux.Next(eg) do if tc:IsCode(${pend}) then Debug.Message('IdentityPredicate:'..tostring(_G['c${subject.code}']['${subject.fn}'](tc,tp))) end end end) Duel.RegisterEffect(watch,0) end");
rep("if(!cards.has(code))throw Error('Missing card '+code)","if(code===subject.code)return require('./fresh_installed_card.cjs').candidateCard(code);if(!cards.has(code))throw Error('Missing card '+code)");

rep('add(trumpet,L.HAND);add(pend,L.MZONE);',"add(subject.code,L.DECK);core.duelNewCard(duel,{team:0,duelist:0,code:pend,controller:0,location:L.MZONE,sequence:0,position:test.hidden?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});");
const a=s.indexOf('const m=core.duelQueryLocation'),b=s.indexOf('done=true;',a);assert(a>0&&b>a);
s=s.slice(0,a)+"const records=logs.filter(v=>v.message.startsWith('IdentityPredicate:'));assert.equal(records.length,1,'One native destruction observation');assert.equal(records[0].message,'IdentityPredicate:'+String(test.allowed),'Previous identity predicate');assert(trace.some(m=>m.type===M.MOVE&&m.card===pend&&m.from.location===L.MZONE&&m.to.location===L.GRAVE),'Actual MZone-to-GY effect destruction');"+s.slice(b);
rep('results.push({test,','results.push({passcode:subject.code,test,');
rep("'output/fresh-ccg-september/terrarumian-trumpet-hand.json'","'output/fresh-ccg-september/current-destroyed-previous-identity.json'");
rep("engine:'public OCGCore with Omega Lua; not native Omega'","scope:'Unmodified original Octantis/Murugan/Hydra destruction filters called by neutral continuous observer on actual native EVENT_DESTROYED. Faceup/hidden own archetype and faceup wrong-set monsters; native prior identity cache only. Original source instance in Deck only; no full trigger/effect operation or live Omega certification. Debug identity records expected; no Lua API adapter.'");
rep("return fs.readFileSync(file,'utf8')","let lua=fs.readFileSync(file,'utf8');if(name==='c'+subject.code+'.lua'){if(process.argv.includes('--old-source'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/destroyed-before-previous-visibility-repair',name),'utf8');if(process.argv.includes('--candidate'))lua=require('./fresh_destroyed_previous_visibility_repair.cjs').corrected(lua,subject.code);}return lua");
rep("'output/fresh-ccg-september/current-destroyed-previous-identity.json'","'output/fresh-ccg-september/current-destroyed-previous-identity'+(process.argv.includes('--old-source')?'-old-source':process.argv.includes('--candidate')?'-candidate':'')+'.json'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
