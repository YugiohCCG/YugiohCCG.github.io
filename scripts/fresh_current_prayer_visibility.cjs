'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const main=process.argv.includes('--main'),file=path.join(__dirname,main?'fresh_current_prayer_pair.cjs':'fresh_current_prayer_search.cjs');let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep("require('./fresh_current_card.cjs')","require('./fresh_installed_card.cjs')");
rep("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
rep('return body;};',"if(name==='c'+source+'.lua'){if(process.argv.includes('--old-source'))body=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/prayer-before-visibility-repair',name),'utf8');if(process.argv.includes('--candidate'))body=require('./fresh_prayer_visibility_repair.cjs').corrected(body);if(process.argv.includes('--no-search'))body=body.replace('Duel.SendtoHand(g,nil,REASON_EFFECT)','(function() return 0 end)()');if(process.argv.includes('--no-pair'))body=body.replace('Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP)','(function() return false end)()');}return body;};");
if(main){
 rep('[{},{spirit:true},{wrongLevel:true},{oneZone:true}]','[{},{field:true},{field:true,hidden:true},{wrongLevel:true}]');
 rep('add(spell,L.HAND);',"if(test.field)core.duelNewCard(duel,{team:0,duelist:0,code:spell,controller:0,location:L.MZONE,sequence:0,position:test.hidden?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});else add(spell,L.HAND);");
 rep('if(test.spirit||test.wrongLevel||test.oneZone)', 'if(test.hidden||test.spirit||test.wrongLevel||test.oneZone)');
 rep('current-prayer-spirit-limit','current-prayer-visibility-main');
 rep("(process.argv.includes('--old-spirit-guard')?'-old-spirit-guard':process.argv.includes('--no-negation')?'-no-negation':process.argv.includes('--no-end-destruction')?'-no-end-destruction':'')+'.json'","(process.argv.includes('--old-source')?'-old-source':process.argv.includes('--candidate')?'-candidate':process.argv.includes('--no-pair')?'-no-pair':'')+'.json'");
}else{
 rep('[{},{grave:true},{banished:true},{banished:true,facedown:true},{wrongSet:true},{nonRitual:true},{simultaneous:true},{selfOnly:true},{wrongRitualSet:true},{phoenix:true}]','[{},{hidden:true},{hand:true},{deck:true},{wrongRitualSet:true},{nonRitual:true}]');
 rep("'constant.lua','utility.lua','procedure.lua','prayer-search-selection-fixture.lua'","'constant.lua','utility.lua','procedure.lua'");
 rep('tp,LOCATION_MZONE,0,nil,900004602','tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_DECK,0,nil,900004602');
 rep('code:filler,controller:0,location:L.MZONE,sequence:0,position:P.FACEUP_ATTACK','code:filler,controller:0,location:test.hand?L.HAND:test.deck?L.DECK:L.MZONE,sequence:0,position:test.hidden?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK');
 s=s.replaceAll('test.facedown||','test.hidden||test.facedown||');
 rep('current-prayer-search-leave-field','current-prayer-visibility-search');
 rep("(process.argv.includes('--allow-facedown')?'-allow-facedown':process.argv.includes('--allow-simultaneous')?'-allow-simultaneous':process.argv.includes('--allow-wrong-ritual-set')?'-allow-wrong-ritual-set':'')+'.json'","(process.argv.includes('--old-source')?'-old-source':process.argv.includes('--candidate')?'-candidate':process.argv.includes('--no-search')?'-no-search':'')+'.json'");
}
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
