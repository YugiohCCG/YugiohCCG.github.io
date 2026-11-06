'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_reconciled_terrarumian_pendulum_interruption.cjs');let s=fs.readFileSync(file,'utf8');
function replace(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
replace("['baseline','activation','effect','sourceBanish','resourcesBanish','lateFull','lateLock']","['mainResource','extraResource']");
replace("['no-response','no-summon']","['old-source','no-projection','no-summon']");
replace('  const reader=name=>{',"  cards.set(ally,{...cards.get(ally),type:scenario==='extraResource'?0x41:17});const reader=name=>{");
replace("if(control==='no-summon')", "if(control==='old-source')lua=fs.readFileSync(path.join(OUT,'destroy-summon-before-capacity-repair',name),'utf8');if(process.argv.includes('--candidate'))lua=require('./fresh_current_destroy_summon_capacity.cjs').corrected(boss,lua);if(control==='no-projection')lua=lua.replace('Duel.GetMZoneCount(handler:GetControler(),Group.FromCards(c))>0','true');if(control==='no-summon')");
replace('add(ally,L.MZONE);',"add(ally,L.MZONE,0,P.FACEUP_ATTACK,scenario==='extraResource'?5:0);for(let seq=scenario==='extraResource'?0:1;seq<5;seq++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,seq);");
replace("if(scenario!=='baseline')add(response,L.SZONE,1,P.FACEDOWN_DEFENSE,1);",'');
replace("assert(index>=0,'Primary Pendulum effect available');", "const eligible=scenario==='mainResource';assert.equal(index>=0,eligible,'Projected Main Zone capacity');if(!eligible){done=true;continue;}");
const a=s.indexOf("     assert.equal(interrupted,scenario!=="),b=s.indexOf("done=true;",a);assert(a>=0&&b>a);s=s.slice(0,a)+"     assert(query(L.MZONE).some(c=>c.code===boss),'Actual primary summon after Main resource destruction');assert(trace.some(m=>m.type===M.MOVE&&m.card===ally&&m.from.location===L.MZONE&&m.to.location===L.GRAVE),'Actual Main resource destroyed');assert.equal(query(L.MZONE).length,5,'Main field remains full after replacing resource');"+s.slice(b);
replace("let index=p.selects.findIndex(c=>c.code===fodder)","let index=p.selects.findIndex(c=>c.code===ally)");
replace("'current-reconciled-terrarumian-pendulum-interruption'","'current-terrarumian-zone-capacity'+(process.argv.includes('--candidate')?'-candidate':'')");
s=s.replace(/scope:'[^']*'/,"scope:'Eight full Terrarumian sources/current installed metadata/corrected transport; actual Hand-to-PZone activation with full Main field. Own Main Terrarumian resource permits real destruction/self-summon; only Extra-Zone resource cannot free a Main Zone and excludes activation. Neutral field-seeded Fusion resource isolates geometry; no proper-history/general Fusion conclusion. No Lua API adapter or live Omega/full-card certification.'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
