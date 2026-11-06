'use strict';
const fs=require('node:fs');
const path=require('node:path');
const Module=require('node:module');
const assert=require('node:assert/strict');

const file=path.join(__dirname,'fresh_current_hydra_fusion.cjs');
let source=fs.readFileSync(file,'utf8');
function replace(oldText,newText){
 assert(source.includes(oldText),oldText);
 source=source.replace(oldText,newText);
}
replace('[{},{duplicate:true},{wrongRace:true},{missingHeart:true},{blocked:true},{centerMaterial:true},{heartSpell:true}]','[{},{replacement:true}]');
replace("   if([heart,blocker,...mats]",String.raw`   if(name==='c'+blocker+'.lua'&&test.replacement)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetCode(EFFECT_RELEASE_REPLACE) e:SetRange(LOCATION_MZONE) e:SetTarget(function(e,tp,eg) return eg:IsExists(function(tc) return tc:IsCode(240299293) and tc:GetSequence()==2 end,1,nil) end) e:SetValue(function(e,tc) return tc:IsCode(240299293) and tc:GetSequence()==2 end) c:RegisterEffect(e) end';
   if([heart,blocker,...mats]`);
replace('if(test.blocked)add(blocker,L.MZONE,0,2);','if(test.replacement)add(blocker,L.MZONE,0,4);');
const code=Number(process.argv[2]);
assert([254065048,212684822].includes(code));
replace("current-hydra-fusion'","current-to-proto-release-payment-"+code+"'");

replace('boss=239935098','boss='+code);
replace('mats=[900001171,900001172,900001173,900001174]','mats=[240299293,224225695,246380598,900001174]');
replace('setcodes:[],type:33','setcodes:[0xe80d],type:0x4011');
const setupStart=source.indexOf('   add(boss,L.EXTRA);');
const setupEnd=source.indexOf('core.startDuel(duel);',setupStart);
assert(setupStart>=0&&setupEnd>setupStart);
source=source.slice(0,setupStart)+"   add(boss,L.EXTRA);add(mats[0],L.MZONE,0,2);add(mats[0],L.MZONE,0,3);add(boss===254065048?mats[1]:mats[2],L.MZONE,0,1);if(test.replacement)add(blocker,L.MZONE,0,4);for(const p of [0,1])for(let i=0;i<8;i++)add(blocker,L.DECK,p);"+source.slice(setupEnd);
const resultStart=source.indexOf('const b=query(L.MZONE)');
const resultEnd=source.indexOf('done=true;}',resultStart);
assert(resultStart>=0&&resultEnd>resultStart);
source=source.slice(0,resultStart)+"const b=query(L.MZONE).find(c=>c.code===boss);assert.equal(Boolean(b),!test.replacement||process.argv.includes('--before'));assert.equal(query(L.MZONE).filter(c=>c.code===mats[0]).length,test.replacement?1:0);"+source.slice(resultEnd);
if(process.argv.includes('--before')){
 replace("let lua=fs.readFileSync(file,'utf8');","let lua=fs.readFileSync(name==='c'+boss+'.lua'?path.join(ROOT,'output/fresh-ccg-september/to-proto-release-payment-before-repair',name):file,'utf8');");
 replace("current-to-proto-release-payment-"+code+"'","current-to-proto-release-payment-"+code+"-before'");
}
replace('else if(p.type===M.SELECT_CHAIN)', 'else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)}); else if(p.type===M.SORT_CARD)core.duelSetResponse(duel,{type:R.SORT_CARD,order:{length:0,*[Symbol.iterator](){yield 1;}}}); else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false}); else if(p.type===M.SELECT_CHAIN)');
const fixture=new Module(file,module);
fixture.filename=file;
fixture.paths=module.paths;
fixture._compile(source,file);
