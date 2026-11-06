'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_reconciled_glitchling_leotron_pendulum_ritual.cjs');let s=fs.readFileSync(file,'utf8');
function replace(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
replace("['hand','extra','grave','protected','insufficient','wrongSet','sameName','fullHand','fullField','activation','effect','sourceBanish','targetBanish','materialBanish','lateFull']","['hand','activation','effect']");
replace("'ritual-material-before-release-guard'","'pendulum-before-unprinted-limit-repair'");
replace("if(process.argv.includes('--candidate'))lua=lua.replace('return c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc)','return c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc) and c:IsReleasableByEffect()');", "if(process.argv.includes('--candidate'))lua=lua.replace(/\\te1:SetCountLimit\\(1,id\\+200\\)\\r?\\n/,'');");
replace('let failure=null,placed=false','let round=0,turn=0;const phases=[];let failure=null,placed=false');
replace('add(boss,L.HAND);add(actualTarget,L.HAND);','add(boss,L.HAND);add(actualTarget,L.HAND);add(boss,L.HAND);add(actualTarget,L.HAND);add(material,L.HAND);');
replace('trace.push(...messages);assert(!logs.length', 'trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length');
replace("const success=['hand','extra','grave','fullField'].includes(scenario);assert.equal(query(L.MZONE).some(c=>c.code===target),success,'Actual Ritual summon outcome');", "const success=round===1||scenario==='hand';assert.equal(query(L.MZONE).filter(c=>c.code===target).length,(scenario==='hand'?round:0)+(success?1:0),'Actual repeated Ritual outcomes');");
replace("!['activation','effect','sourceBanish'].includes(scenario),'Actual self destruction'", "success,'Actual self destruction'");
replace('interruptedScenario?1:0,\'Actual response CL2\'',"interruptedScenario&&round===0?1:0,'Actual response CL2'");
// The separate original suite already checks completion; preserve actual native
// Ritual summons/payment here without consuming its once-only neutral probe twice.
replace('if(success&&!observed){','if(false&&success&&!observed){');
replace("if(success)assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===988),'Native Ritual type/proper-summon status');done=true;", "assert.equal(turn,1);phases.push([...trace]);if(round===0){round=1;trace.length=0;placed=true;activated=false;const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);assert(index>=0,'Second real source placement');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}done=true;");
replace('results.push({passcode:boss,scenario,failure,trace,logs})','results.push({passcode:boss,scenario,failure,phases,trace,logs})');
replace("'current-reconciled-glitchling-leotron-pendulum-ritual'","'current-leotron-unlimited-pendulum'");
s=s.replace(/scope:'[^']*'/,"scope:'Two same-turn full-source Leotron Pendulum Ritual activations after success/negated activation/negated effect; actual native source placement/self destruction/material payment and neutral Ritual targets. Current installed metadata/corrected transport/no API adapter; completion and general recipes covered separately, no live Omega certification.'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
