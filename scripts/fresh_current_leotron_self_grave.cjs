'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');const file=path.join(__dirname,'fresh_current_glitchling_leotron_monster.cjs');let s=fs.readFileSync(file,'utf8');function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep("['bitronHand','protronDeck','digitronGY','extra','wrongMention','decline','nonRitual','negatedRecruit','negOne','negTwo','negTrap','negMonster','negNoCost','negWrongRace','negWrongType','negGY']","['bitron','protron','digitron']");
rep("normal=names[scenario==='protronDeck'?1:scenario==='digitronGY'?2:0],buddy=scenario==='extra'?boss:friends[scenario==='protronDeck'||scenario==='wrongMention'?1:scenario==='digitronGY'?2:0]","normal=names[scenario==='protron'?1:scenario==='digitron'?2:0],buddy=boss");
rep('Duel.SendtoGrave(b,REASON_EFFECT)', 'Duel.Remove(b,POS_FACEUP,REASON_EFFECT) Duel.SendtoGrave(b,REASON_EFFECT)');
rep("if(stage===0){", "if(stage===0){");
rep('current-glitchling-leotron-monster${control?', 'current-leotron-self-grave${control?');
// Existing outcome assertions count the actual buddy revival; add explicit GY origin/proper-history movement.
rep("const fs=require('node:fs'),path=require('node:path');","const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');");
rep("done=true;", "assert(trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.from.location===L.GRAVE&&m.to.location===L.MZONE),'Actual same-name GY revival');done=true;");
s=s.replace(/scope:'[^']*'/,"scope:'Full original Leotron/current installed metadata/corrected transport/no Lua API adapter. Another actual Leotron first pays a fixed native Ritual recipe/completes then banishes and enters GY, source separately pays native Ritual recipe, recruits each named normal and revives proper same-name GY copy. Native origins/payment and actual recruitment/revival; normals neutral identity metadata. Not original named Ritual recipe/full-card/live Omega certification.'");const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
