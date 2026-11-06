'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
assert(process.argv.includes('--mode=witch'),'Reuse monster-trigger fixture route');
const file=path.join(__dirname,'fresh_current_actual_ritual_targets.cjs');let outer=fs.readFileSync(file,'utf8');
const injection=String.raw`
rep('[259678739]','[259072906]');
rep("['handEnough','fieldMaterial','extra','fullField']",(meta.type&0x1000000)?"['handEnough','deckEnough','extra','fullHand']":"['handEnough','deckEnough','fullHand']");
rep('const eligible=true','const eligible=scenario!==\'fullHand\'');
rep("assert(trace.some(m=>m.type===M.MOVE&&m.card===target&&m.from.location===(scenario==='extra'?L.EXTRA:L.DECK)&&m.to.location===L.MZONE),'Actual original Witch target recruitment origin')","if(eligible)assert(trace.some(m=>m.type===M.MOVE&&m.card===target&&m.from.location===(scenario==='extra'?L.EXTRA:L.HAND)&&m.to.location===L.MZONE),'Actual original Mage target recruitment origin');else assert(!query(L.MZONE).some(c=>c.code===target&&c.code!==boss),'Full Main excludes Hand target')");
rep("'current-actual-ritual-target-witch-'","'current-mage-monster-target-'");
s=s.replace(/scope:'[^']*'/,"scope:'Full original Mage monster Special-Summon-trigger Ritual/full actual recipient scripts/installed metadata/corrected transport/no Lua API adapter. Hand or Deck material, Hand recipient and legal genuine faceup Extra recipient, full Main Hand exclusion. Native material group/reasons/Ritual type/completion. Neutral paid initial source and Extra history; target followups declined. Separate from Mage Pendulum replacement procedure, independent recipient procedures/full-card/live Omega.'");
`;
assert(outer.includes('const m=new Module(file,module);'));outer=outer.replace('const m=new Module(file,module);',injection+'\nconst m=new Module(file,module);');const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(outer,file);
