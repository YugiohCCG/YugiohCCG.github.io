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
replace('[{},{duplicate:true},{wrongRace:true},{missingHeart:true},{blocked:true},{centerMaterial:true},{heartSpell:true}]','[{},{replacement:true},{redirect:true}]');
replace("   if([heart,blocker,...mats]",String.raw`   if(name==='c'+blocker+'.lua'&&test.replacement)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetCode(EFFECT_SEND_REPLACE) e:SetRange(LOCATION_MZONE) e:SetTarget(function(e,tp,eg) return eg:IsExists(Card.IsCode,1,nil,900001172) end) e:SetValue(function(e,tc) return tc:IsCode(900001172) end) c:RegisterEffect(e) end';
   if(name==='c'+mats[1]+'.lua'&&test.redirect)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_TO_DECK_REDIRECT) e:SetValue(LOCATION_REMOVED) c:RegisterEffect(e) end';
   if([heart,blocker,...mats]`);
replace('if(test.blocked)add(blocker,L.MZONE,0,2);','if(test.replacement)add(blocker,L.MZONE,0,4);');
replace("current-hydra-fusion'","current-aegis-procedure-payment'");

replace('boss=239935098','boss=221924008');
replace('setcodes:[],type:33','setcodes:[],type:4129');
const setupStart=source.indexOf('   add(boss,L.EXTRA);');
const setupEnd=source.indexOf('core.startDuel(duel);',setupStart);
assert(setupStart>=0&&setupEnd>setupStart);
source=source.slice(0,setupStart)+"   add(boss,L.EXTRA);add(mats[0],L.GRAVE);add(mats[1],L.GRAVE);add(mats[2],L.GRAVE);if(test.replacement)add(blocker,L.MZONE,0,4);for(const p of [0,1])for(let i=0;i<8;i++)add(blocker,L.DECK,p);"+source.slice(setupEnd);
if(process.env.CCG_OMEGA_SCRIPTS&&!process.argv.includes('--before')){
 replace("const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name)", "const file=[path.join(process.env.CCG_OMEGA_SCRIPTS,name),path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name)");
}
replace("const eligible=!test.duplicate&&!test.wrongRace&&!test.missingHeart&&!test.blocked;", "const eligible=!test.duplicate&&!test.wrongRace&&!test.missingHeart&&!test.blocked&&(!test.redirect||!process.argv.includes('--expect-cost-filter'));");
replace("if(!eligible){done=true;continue;}", "if(!eligible){assert(!query(L.MZONE).some(c=>c.code===boss));assert(query(L.GRAVE).some(c=>c.code===mats[1]));assert(!query(L.REMOVED).some(c=>c.code===mats[1]));done=true;continue;}");
const resultStart=source.indexOf('const b=query(L.MZONE)');
const resultEnd=source.indexOf('done=true;}',resultStart);
assert(resultStart>=0&&resultEnd>resultStart);
source=source.slice(0,resultStart)+"const b=query(L.MZONE).find(c=>c.code===boss);assert.equal(Boolean(b),!test.replacement&&!test.redirect||process.argv.includes('--before'));assert(query(L.DECK).some(c=>c.code===mats[0]));assert.equal(query(L.GRAVE).some(c=>c.code===mats[1]),Boolean(test.replacement));if(test.redirect)assert(query(L.REMOVED).some(c=>c.code===mats[1]));"+source.slice(resultEnd);
replace("   const add=", "   core.loadScript(duel,'neutral-grave-faceup.lua','Card.IsFaceupEx=function(c) return c:IsLocation(LOCATION_GRAVE) or c:IsFaceup() end'); const add=");
if(process.argv.includes('--before')){
 replace("let lua=fs.readFileSync(file,'utf8');","let lua=fs.readFileSync(name==='c'+boss+'.lua'?path.join(ROOT,'output/fresh-ccg-september/aegis-procedure-payment-before-repair',name):file,'utf8');");
 replace("current-aegis-procedure-payment'","current-aegis-procedure-payment-before'");
}
replace('else if(p.type===M.SELECT_CHAIN)', 'else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false}); else if(p.type===M.SELECT_CHAIN)');
const fixture=new Module(file,module);
fixture.filename=file;
fixture.paths=module.paths;
fixture._compile(source,file);
