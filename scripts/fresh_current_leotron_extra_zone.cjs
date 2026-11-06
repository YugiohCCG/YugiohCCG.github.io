'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_reconciled_glitchling_leotron_pendulum_ritual.cjs');let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep("['hand','extra','grave','protected','insufficient','wrongSet','sameName','fullHand','fullField','activation','effect','sourceBanish','targetBanish','materialBanish','lateFull']","['extra','blockedExtra','releaseExtra']");
rep("['extra','grave'].includes(scenario)","['extra','blockedExtra','releaseExtra','grave'].includes(scenario)");
rep("scenario==='extra'?'Duel.Destroy", "['extra','blockedExtra','releaseExtra'].includes(scenario)?'Duel.Destroy");
rep('add(boss,L.HAND);',"if(scenario==='blockedExtra'){add(filler,L.MZONE,0,P.FACEUP_ATTACK,5);add(filler,L.MZONE,1,P.FACEUP_ATTACK,5);}add(boss,L.HAND);");
rep("add(material,scenario==='fullField'?L.MZONE:L.HAND);","if(scenario==='releaseExtra'){add(material,L.MZONE,0,P.FACEUP_ATTACK,5);add(filler,L.MZONE,1,P.FACEUP_ATTACK,5);}else add(material,scenario==='fullField'?L.MZONE:L.HAND);");
rep("const success=['hand','extra','grave','fullField']","const success=['hand','extra','releaseExtra','grave','fullField']");
rep("'sameName','fullHand'].includes(scenario)","'sameName','fullHand','blockedExtra'].includes(scenario)");
rep("}return lua;", "}if(name==='c'+boss+'.lua'&&process.argv.includes('--zone-candidate'))lua=require('./fresh_ritual_zone_repair.cjs').corrected(lua);return lua;");
rep("'current-reconciled-glitchling-leotron-pendulum-ritual'","'current-leotron-extra-zone'+(process.argv.includes('--zone-candidate')?'-candidate':'')");
s=s.replace(/scope:'[^']*'/,"scope:'Current full Leotron/native paid Ritual operation with neutral target and genuine prior Ritual-to-faceup-Extra origin. Both Extra Zones occupied by non-material non-Link blockers; no Lua adapter/live Omega claim.'");
rep("}if(name==='c'+boss+'.lua'&&process.argv.includes('--zone-candidate'))", "}if(name==='c'+boss+'.lua'&&process.argv.includes('--zone-old'))lua=fs.readFileSync(path.join(OUT,'ritual-before-zone-subgroup-repair/c259873115.lua'),'utf8');if(name==='c'+boss+'.lua'&&process.argv.includes('--zone-candidate'))");
rep("'current-leotron-extra-zone'", "'current-leotron-extra-zone'+(process.argv.includes('--zone-old')?'-zone-old':'')");
const family=Number(process.argv.find(v=>v.startsWith('--family='))?.split('=')[1]||259873115);
if(family!==259873115){
 rep('race:1n','race:0x1000000n');
 const call=family===259546637?'s.ritualsummon(e,tp)':'s.ritualsummon(e,tp,LOCATION_EXTRA,s.ritfilter)';
 const init=` function s.initial_effect(c) aux.EnablePendulumAttribute(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_PZONE) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.ritfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp) end end) e:SetOperation(function(e,tp) if Duel.Destroy(e:GetHandler(),REASON_EFFECT)>0 then ${call} end end) c:RegisterEffect(e) end`;
 rep("if(name==='c'+boss+'.lua'&&process.argv.includes('--zone-candidate'))", "if(name==='c'+boss+'.lua')lua=fs.readFileSync((process.argv.includes('--zone-old')?path.join(OUT,'ritual-before-zone-subgroup-repair/c"+family+".lua'):path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c"+family+".lua')),'utf8')+"+JSON.stringify(init)+";if(name==='c'+boss+'.lua'&&process.argv.includes('--zone-candidate'))");
 rep("return lua;","if(name==='c'+boss+'.lua'&&control==='no-material')lua=lua.replace('Duel.ReleaseRitualMaterial(mat)','do end');return lua;");
 rep("'current-leotron-extra-zone'", "'current-ritual-extra-zone-"+family+"'");
}
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
