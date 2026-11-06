'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const mode=process.argv.find(v=>v.startsWith('--mode='))?.split('=')[1]||'leotron',target=Number(process.argv.find(v=>v.startsWith('--target='))?.split('=')[1]||259678739),meta=require('./fresh_installed_card.cjs').candidateCard(target);
const name=mode==='mage'?'fresh_current_glitchling_mage_counter_group.cjs':mode==='witch'?'fresh_current_glitchling_counter_followup.cjs':'fresh_reconciled_glitchling_leotron_pendulum_ritual.cjs',file=path.join(__dirname,name);let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep('target=900002302','target='+target);
if(mode==='leotron'){
 rep("['hand','extra','grave','protected','insufficient','wrongSet','sameName','fullHand','fullField','activation','effect','sourceBanish','targetBanish','materialBanish','lateFull']",target===259873115?"['hand']":"['hand','extra','grave','fullField']");
 rep("level:scenario==='insufficient'?5:6",'level:'+meta.level);
 rep("if(name==='c'+target+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() end';",'');
 rep('const reader=name=>{','cards.set(target,require("./fresh_installed_card.cjs").candidateCard(target));cards.set(900005701,{...base,code:900005701,level:'+meta.level+'});const reader=name=>{');
 rep("if(name==='c0.lua')return '';","if(name==='c0.lua')return '';if(name==='c900005701.lua')return 'local s,id=GetID() function s.initial_effect(c) end';");
 rep('assert(Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0)',"local mg=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,900005701) assert(#mg==1 and mg:GetSum(Card.GetLevel)==rc:GetLevel()) rc:SetMaterial(mg) Duel.ReleaseRitualMaterial(mg) assert(Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0)");
 rep("'Duel.SendtoGrave(rc,REASON_EFFECT)'","'Duel.Remove(rc,POS_FACEUP,REASON_EFFECT) Duel.SendtoGrave(rc,REASON_EFFECT) assert(rc:IsLocation(LOCATION_GRAVE))'");
 rep('add(boss,L.HAND);',"if(['extra','grave'].includes(scenario))add(900005701,L.HAND);add(boss,L.HAND);");
 rep("const eligible=!['protected'",'const eligible=target!==boss&&![\'protected\'');
 rep('if(!activated){',"if(!activated){if(['extra','grave'].includes(scenario))assert(query(scenario==='grave'?L.GRAVE:L.EXTRA).some(c=>c.code===target),'Native prepared target origin');");
 rep('if(success&&!observed)',"if(success&&['extra','grave'].includes(scenario))assert(trace.some(m=>m.type===M.MOVE&&m.card===target&&m.from.location===(scenario==='grave'?L.GRAVE:L.EXTRA)&&m.to.location===L.MZONE),'Actual target recruitment origin');if(success&&!observed)");
 rep("'current-reconciled-glitchling-leotron-pendulum-ritual'","'current-actual-ritual-target-leotron-'+target");
}else if(mode==='mage'){
 rep('partner=900002501','partner=259678739');rep("['baseline','two','insufficient','absent']","['baseline','two','noPartner']");
 rep("['old-source','no-cap','no-payment']","['no-material','no-complete','no-checklist']");
 rep('const reader=name=>{','cards.set(target,require("./fresh_installed_card.cjs").candidateCard(target));cards.set(partner,require("./fresh_installed_card.cjs").candidateCard(partner));cards.set(material,{...cards.get(material),level:cards.get(target).level*(two?2:1)});const reader=name=>{');
 s=s.replace(/   if\(name==='c'\+target\+'\.lua'\)return [^\r\n]+\r?\n/,'').replace(/   if\(name==='c'\+partner\+'\.lua'\)return [^\r\n]+\r?\n/,'');
 rep("scenario==='absent'?'':",'true?\'\':');
 rep("if(scenario!=='absent')add(corruption,L.SZONE,0,P.FACEUP_ATTACK,2);",'');
 rep("'current-glitchling-mage-counter-group'","'current-actual-ritual-target-mage-'+target");
 }else if(mode==='witch'){
 rep('[259678739,259072906]','[259678739]');rep("['active','insufficient','absent','facedown','deckMaterial','enemyCounters','deckEnough','handEnough','enemyOnly']","['handEnough','fieldMaterial','extra','fullField']");
 rep("['old-source','no-cap','no-payment']","['no-material','no-complete']");
 rep("const eligible=['active','enemyCounters','handEnough'].includes(scenario)||!witch&&scenario==='deckEnough'","const eligible=true");
 rep("const reader=name=>{",'cards.set(target,require("./fresh_installed_card.cjs").candidateCard(target));cards.set(material,{...cards.get(material),level:cards.get(target).level});cards.set(prepMat,{...cards.get(prepMat),level:cards.get(target).level});const reader=name=>{');
 s=s.replace(/   if\(name==='c'\+target\+'\.lua'\)return [^\r\n]+\r?\n/,'');
 rep("scenario==='absent'||scenario==='facedown'?'':", "true?'':");
 rep("if(!['absent','enemyOnly'].includes(scenario))add(corruption,L.SZONE,0,scenario==='facedown'?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,2);",'');
 rep("${['deckEnough','handEnough'].includes(scenario)?10:0}",'0');
 rep("assert.equal(query(L.MZONE).some(c=>c.code===target),success,'Actual Ritual follow-up result')","assert(trace.some(m=>m.type===M.MOVE&&m.card===target&&m.from.location===(scenario==='extra'?L.EXTRA:L.DECK)&&m.to.location===L.MZONE),'Actual original Witch target recruitment origin')");
 rep('local rc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${target})',"local rc=Duel.GetFirstMatchingCard(function(tc) return tc:IsCode(${target}) and tc:GetMaterial():IsExists(Card.IsCode,1,nil,${material}) end,tp,LOCATION_MZONE,0,nil)");
 rep("'current-glitchling-counter-followup'","'current-actual-ritual-target-witch-'+target");
}else throw Error('Unsupported mode '+mode);
rep('local ok=',"local mc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${material}) assert(mc and mc:IsReason(REASON_MATERIAL) and mc:IsReason(REASON_RITUAL),'Native material Ritual reasons') local ok=");
if(mode==='mage')rep('for tc in aux.Next(g) do if not tc:IsSummonType',"for tc in aux.Next(g) do assert(tc:GetMaterial():GetCount()==1 and tc:GetMaterial():IsContains(mc),'Actual Ritual material group') if not tc:IsSummonType");
else rep('local ok=rc and rc:IsSummonType',"assert(rc and rc:GetMaterial():GetCount()==1 and rc:GetMaterial():IsContains(mc),'Actual Ritual material group') local ok=rc and rc:IsSummonType");
s=s.replace(/scope:'[^']*'/,"scope:'Full original source/actual target scripts and installed metadata/corrected transport/no Lua API adapter. Native Ritual procedure/payment/type/proper status and material reasons; prior Extra/GY history where used is neutral paid native Ritual, distinct native origins asserted. Optional target followups declined. Not full-card/live Omega certification.'");
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
