'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_current_glitchling_counter_followup.cjs');let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep("[259678739,259072906]","[259072906]");rep("['active','insufficient','absent','facedown','deckMaterial','enemyCounters','deckEnough','handEnough','enemyOnly']","['extraFull','extraOpen','extraBlocked','handFull','handOpen','extraLateFull','handLateFull']");
s=s.replaceAll("scenario==='extra'","scenario.startsWith('extra')");
rep("const eligible=['active','enemyCounters','handEnough'].includes(scenario)||!witch&&scenario==='deckEnough'","const eligible=['extraFull','extraOpen','handOpen','extraLateFull','handLateFull'].includes(scenario)");
rep('success=eligible','success=eligible&&scenario!=="handLateFull"');
rep("['old-source','no-cap','no-payment']","['old-source','no-cap','no-payment','no-material','no-complete','no-response']");
s=s.replaceAll("['effect','sourceBanish','targetBanish']","['effect','sourceBanish','targetBanish','extraLateFull','handLateFull']");
rep("scenario==='effect'?'Duel.NegateEffect(ev)'","scenario.endsWith('LateFull')?'local g=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,900002304) local sg=Group.CreateGroup() for tc in aux.Next(g) do if #sg<3 then sg:AddCard(tc) end end assert(Duel.SpecialSummon(sg,0,1-tp,1-tp,false,false,POS_FACEUP)==3)':scenario==='effect'?'Duel.NegateEffect(ev)'");
rep("if(success&&!observed)","if(scenario.endsWith('LateFull'))assert(trace.filter(m=>m.type===M.MOVE&&m.card===filler&&m.from.location===L.DECK&&m.to.location===L.MZONE).length===3,'Actual late fill missing');if(success&&!observed)");
rep('add(boss,L.HAND);',"if(['extraFull','handFull'].includes(scenario))for(let i=1;i<4;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);if(scenario==='extraBlocked'){add(filler,L.MZONE,0,P.FACEUP_ATTACK,5);add(filler,L.MZONE,1,P.FACEUP_ATTACK,5);}add(boss,L.HAND);");
rep("}return lua;","}if(name==='c'+boss+'.lua'){if(process.argv.includes('--zone-old'))lua=fs.readFileSync(path.join(OUT,'ritual-before-main-space-repair',name),'utf8');if(process.argv.includes('--zone-candidate'))lua=corrected(lua);}return lua;");
rep("'current-glitchling-counter-followup'","'current-mage-monster-zone'+(process.argv.includes('--zone-old')?'-zone-old':process.argv.includes('--zone-candidate')?'-candidate':'')");
s=s.replace(/scope:'[^']*'/,"scope:'Full Mage/current installed metadata/corrected transport/no Lua API adapter. Native source paid Ritual history, neutral target prior paid Ritual-to-faceup-Extra, full Main versus open/blocked Extra destination. Actual Hand payment/counters/Ritual status. No general target-family/live Omega claim.'");
function corrected(s){for(const [a,b] of [
 ['function s.ritfilter(c,e,tp)\n\treturn c:IsRace', 'function s.ritfilter(c,e,tp)\n\treturn (c:IsLocation(LOCATION_EXTRA) or Duel.GetLocationCount(tp,LOCATION_MZONE)>0) and c:IsRace'],
 ['function s.rittg(e,tp,eg,ep,ev,re,r,rp,chk)\n\tif chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0\n\t\tand Duel.GetLocationCount(tp,LOCATION_MZONE)>0','function s.rittg(e,tp,eg,ep,ev,re,r,rp,chk)\n\tif chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0'],
 ['function s.ritop(e,tp,eg,ep,ev,re,r,rp)\n\tif Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end','function s.ritop(e,tp,eg,ep,ev,re,r,rp)']]){const aa=s.includes('\r\n')?a.replaceAll('\n','\r\n'):a,bb=s.includes('\r\n')?b.replaceAll('\n','\r\n'):b;assert.equal(s.split(aa).length-1,1,a);s=s.replace(aa,bb);}return s;}
module.exports={corrected};if(require.main===module){const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile('const corrected=require("./fresh_current_mage_monster_zone.cjs").corrected;\n'+s,file);}
