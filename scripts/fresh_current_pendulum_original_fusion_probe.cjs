'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_terrarumian_trumpet_hand.cjs');let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep("const fs=require('node:fs')","const assert=require('node:assert/strict');const fs=require('node:fs')");
rep("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
rep('for(const test of [{set:true,pendulum:true,allowed:true},{set:false,pendulum:true,allowed:false},{set:true,pendulum:false,allowed:false}])',"for(const subject of [{code:218142234,set:0xb47,count:3},{code:259882493,set:0x17d,count:2}])for(const test of [{}])");
rep('test.set?[0xA122]:[]','[subject.set]');rep('test.pendulum?0x1000021:33','0x1000021');
rep('race:0x400n','race:0x20n');
rep('[filler,{...base,code:filler}]','[filler,{...base,code:filler,setcodes:[subject.set]}]');
rep('local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${pend}) Duel.Destroy(g,REASON_EFFECT)',"local fc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${subject.code}) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(${pend},${filler}) end,tp,LOCATION_HAND,0,nil) assert(#g==${subject.count}) Debug.Message('FusionRecipeAPIs:IsFusionSetCard='..type(Card.IsFusionSetCard)..';IsFusionType='..type(Card.IsFusionType)..';GetMustMaterial='..type(Duel.GetMustMaterial)) Debug.Message('OriginalRecipeEligible:'..tostring(fc:CheckFusionMaterial(g,nil,tp)))");
rep("if(!cards.has(code))throw Error('Missing card '+code)","if(code===subject.code)return require('./fresh_installed_card.cjs').candidateCard(code);if(!cards.has(code))throw Error('Missing card '+code)");
rep('add(trumpet,L.HAND);add(pend,L.MZONE);',"core.duelNewCard(duel,{team:0,duelist:0,code:subject.code,controller:0,location:L.EXTRA,sequence:0,position:P.FACEDOWN_DEFENSE});add(pend,L.HAND);for(let i=1;i<subject.count;i++)add(filler,L.HAND);");
const a=s.indexOf('const m=core.duelQueryLocation'),b=s.indexOf('done=true;',a);assert(a>0&&b>a);
s=s.slice(0,a)+"assert(logs.some(v=>v.type===1&&v.message==='OriginalRecipeEligible:true'),'Original registered material eligibility');"+s.slice(b);
rep('results.push({test,','results.push({passcode:subject.code,test,');
rep("'output/fresh-ccg-september/terrarumian-trumpet-hand.json'","'output/fresh-ccg-september/current-pendulum-original-fusion-probe.json'");
rep("engine:'public OCGCore with Omega Lua; not native Omega'","scope:'Diagnostic only. Original Seraphina/Patrician source and registered Fusion material procedure/current installed metadata/corrected public transport. Neutral native Hand material groups: one Pyro Pendulum plus two Talismandrakes, or two Vaylantz monsters. Normal Spell invokes native CheckFusionMaterial on original source; no adapter, replacement recipe, payment or summon. Failures identify public helper compatibility, not production bugs or full-card/live Omega certification.'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
