'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
process.env.CCG_INSTALLED_CARD_DB ||= require('node:path').resolve(__dirname,'../public/CCG Downloads/CCG_Database/CCG_v1.db');
const {candidateCard}=require('./fresh_installed_card.cjs');
const {loadCorrectedTransport}=require('./fresh_corrected_card_data_transport.cjs');
const installed=process.env.CCG_OMEGA_SCRIPTS||path.resolve(__dirname,'../public/CCG Downloads/CCG_Scripts');
const omega=process.env.CCG_STOCK_SCRIPTS||path.resolve(__dirname,'../tmp/omega_scripts');
const [hot,sky,journey,soprana,offer]=[239932270,239932271,239932272,239934743,239934744];
const fixtures=Array.from({length:8},(_,i)=>900009001+i);
const [helper,body,wing,spell,trap,fusion,link,dark]=fixtures;
const engraver=60764609,formation=239127930,grayrover=259937399,grayseer=259632020,mayavada=247755870,nullbind=259269688,booster=259628203,ivy=284639722,bauSpell=254215159,bauWorld=226950506,bau=221511784,grayshade=259626409,chapter=241957394,dysmandr=223512283,extinction=242009896,token=240299293,grayling=259934043,grayhex=259688514,graylock=259724129,graysentry=259341133,vazagiel=228386117,sarifiel=231089172,fireball=245354354,gorgonia=284636663,sanctuary=284636665,brilliance=259417461,recollection=211086520,revelation=259923860,grayToken=98090004,graydimm=259245496,graydeux=259229055,grayterror=259624110,descend=258328859,orb=228860650,pillar=235051716,burning=239235967,feather=241440521,meadow=258590942,urphiel=215105971,behemoth=259352030,faceOff=259758294,malphiel=257176166,azeriel=237089049,ophiel=251710981,shards=259366591,prism=214511076,raven=259454809,glint=259767503,melody=243420199,failuresAip=259883029,ghostXyz=235687149,aeroXyz=259095349,shade=259615843,ghostTransfer=239335848,claw=259137697,rook=231129918,knight=238282350,standTogether=215142357,showdown=244163205;
const neutral='local s,id=GetID() function s.initial_effect(c) end';
async function main(){
 const mod=await loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:Battle,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const base={alias:0,setcodes:[],type:17,level:2,attribute:16,race:8n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
 const floo=[0x16d],fiend=[0x1b0];
 const H=L.HAND,D=L.DECK,G=L.GRAVE,B=L.REMOVED,F=L.MZONE,T=L.SZONE,E=L.EXTRA;
 const testCases=[];
 const add=(name,setup,steps,expected,opts={})=>testCases.push({name,setup,steps,expected,...opts});
 add('Hot Winds places a Field Spell from GY',[[hot,H],[spell,G]],[hot],[[spell,L.FZONE]],{field:true});
 add('Hot Winds banishes both monsters',[[hot,H],[wing,H],[body,F,1]],[-wing,hot],[[wing,B],[body,B,1]]);
 add('Hot Winds returns from banishment',[[hot,G],[helper,H],[body,H]],[helper],[[hot,H],[body,B]],{yes:true,op:'Duel.Remove(find('+hot+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)'});
 add('Hot Winds offers both options after a Tribute Summon',[[hot,H],[sky,T],[wing,H],[body,H],[wing,D],[spell,G],[body,F,1]],[-wing,hot],[[spell,T],[wing,B],[body,B,1]],{boss:true,option:2});
 add('Hot Winds cannot apply both without a Tribute Summon',[[hot,H],[wing,H],[spell,G],[body,F,1]],[-wing,hot],[[spell,T],[wing,F],[body,F,1]],{options:2});
 add('Magnificent Sky cannot replace a regular Normal Summon',[[sky,T],[wing,H],[body,H],[wing,D]],[-wing],[[wing,F],[wing,D],[body,H]],{noBanish:true});
 add('Magnificent Sky can banish a monster from the field',[[sky,T],[wing,H],[body,F],[wing,D]],[-wing],[[body,B],[wing,B],[wing,F]],{boss:true});
 add('Soprana is unavailable during its controller turn',[[soprana,H],[body,T]],[],[[soprana,H],[body,T]],{forbidden:soprana});
 add('Soprana bounces from field on Normal Summon',[[soprana,H],[fusion,E],[body,F,1]],[-soprana],[[fusion,G],[body,H,1]],{yes:true});
 add('Soprana bounces from GY on Special Summon',[[soprana,G],[helper,H],[fusion,E],[body,G,1]],[helper],[[fusion,G],[body,H,1]],{yes:true,op:'Duel.SpecialSummon(find('+soprana+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 for(const loc of [H,G])add('Soprana summons equipped monster from '+(loc===H?'hand':'GY'),[[soprana,loc],[body,T]],[],[[body,F],[soprana,G]],{opponent:true});
 for(const loc of [D,B])add('Offertorium sets trap from '+(loc===D?'Deck':'banishment'),[[offer,G],[helper,H],[body,G],[trap,loc]],[helper,offer],[[offer,B],[trap,T]],{op:'Duel.Remove(find('+body+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)'});
 add('Offertorium GY effect blocks later non-LIGHT Fiend summons',[[offer,G],[helper,H],[helper,H],[body,G],[dark,G],[trap,D]],[helper,offer,helper],[[offer,B],[trap,T],[dark,G]],{op:'local c=find('+body+',LOCATION_GRAVE) if c then Duel.Remove(c,POS_FACEUP,REASON_EFFECT) else Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP) end'});
 add('Offertorium GY effect rejects an earlier non-LIGHT Fiend summon',[[offer,G],[helper,H],[body,G],[dark,G],[trap,D]],[helper],[[offer,G],[trap,D],[dark,F]],{forbidden:offer,op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP) Duel.Remove(find('+body+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)'});
 add('Offertorium GY effect requires a LIGHT Fiend to leave',[[offer,G],[trap,D]],[],[[offer,G],[trap,D]],{forbidden:offer});
 add('Offertorium Link Summons with Engraver from hand',[[offer,H],[engraver,H],[link,E],[body,F]],[offer],[[link,F],[engraver,G]],{yes:true});
 add('Offertorium cannot use an opponent monster to Link Summon',[[offer,H],[engraver,H],[link,E],[body,F,1]],[offer],[[link,E],[engraver,F],[body,F,1]],{noYes:true});
 add('Offertorium blocks a non-LIGHT Fiend summon after activation',[[offer,H],[engraver,D],[helper,H],[dark,G]],[offer,helper],[[dark,G],[engraver,F]],{op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Offertorium unavailable after an earlier non-LIGHT Fiend summon',[[offer,H],[engraver,D],[helper,H],[dark,G]],[helper],[[dark,F],[offer,H]],{forbidden:offer,op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 for(const [code,loc,resource,target] of [[17827173,B,[wing,B],H],[18940725,H,[wing,D],H],[54334420,F,[wing,D],H],[80433039,H,[body,G,1],B],[80611581,H,[spell,D],H]]){
  add('Mythic Journey copies '+code,[[journey,H],[journey,H],[code,loc],resource],[journey],[[resource[0],target,resource[2]||0]],{copied:code,boss:code===54334420,forbidden:journey});
 }
 add('Mythic Journey grants the copied extra Normal Summon',[[journey,H],[18940725,H],[wing,D]],[journey],[[wing,F]],{copied:18940725,yes:true,pick:wing});
 add('Mythic Journey protects a Winged Beast in battle',[[journey,G],[wing,F],[dark,F,1]],[],[[journey,B],[wing,F]],{boss:true,battle:true,yes:true});
 for(const code of [spell,wing])add('Mythic Journey protects '+(code===spell?'a Floo Spell':'a high-Level Winged Beast'),[[journey,G],[helper,H],[code,code===spell?T:F]],[helper],[[journey,B],[code,code===spell?T:F]],{boss:true,yes:true,op:'Duel.Destroy(find('+code+',LOCATION_ONFIELD),REASON_EFFECT)'});
 add('Link material family: Formation uses your field',[[formation,G],[wing,H],[body,F],[link,E]],[-wing],[[formation,B],[link,F],[body,G]],{family:formation});
 add('Formation responds to a Galactica Special Summon',[[formation,G],[helper,H],[wing,G],[body,F],[link,E]],[helper],[[formation,B],[link,F],[body,G]],{family:formation,op:'Duel.SpecialSummon(find('+wing+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Formation Link resolution timing trace',[[formation,G],[helper,H],[wing,G],[body,F],[link,E]],[helper],[[formation,B],[link,F],[body,G]],{family:formation,formationTiming:true,op:'Duel.SpecialSummon(find('+wing+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Formation Link with lower unresolved trigger',[[formation,G],[helper,H],[wing,G],[body,F],[link,E]],[helper],[[formation,B],[link,F],[body,G]],{family:formation,formationMultiChain:true,op:'Duel.SpecialSummon(find('+wing+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Formation Link interrupted after activation',[[formation,G],[helper,H],[wing,G],[body,F],[dark,F,1],[link,E]],[helper],[[formation,B],[link,E],[body,G],[wing,F]],{family:formation,formationInterrupt:true,expectedFamilyUses:1,op:'Duel.SpecialSummon(find('+wing+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Formation Link trigger shared limit across copies',[[formation,G],[formation,G],[helper,H],[helper,H],[wing,G],[body,F],[link,E],[link,E]],[helper,helper],[[formation,B],[formation,G],[link,F],[link,E],[wing,F]],{family:formation,formationLinkLimit:true,expectedFamilyUses:1,op:'Duel.SpecialSummon(find('+wing+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Formation Link trigger resets next turn',[[formation,G],[formation,G],[helper,H],[helper,H],[wing,G],[body,F],[link,E],[link,E]],[helper,helper],[[formation,B],[link,F],[wing,G]],{family:formation,formationLinkReset:true,expectedFamilyUses:2,op:'Duel.SpecialSummon(find('+wing+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Formation Link use limit after activation negation',[[formation,G],[formation,G],[helper,H],[helper,H],[wing,G],[wing,G],[body,F],[dark,F,1],[link,E]],[helper,helper],[[formation,B],[formation,G],[link,E],[body,F],[wing,F]],{family:formation,formationInterrupt:true,formationNegate:true,formationLinkLimit:true,expectedFamilyUses:1,op:'Duel.SpecialSummon(find('+wing+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Formation ignores non-Galactica Special Summon',[[formation,G],[helper,H],[body,G],[wing,F],[link,E]],[helper],[[formation,G],[body,F],[wing,F],[link,E]],{family:formation,noTrigger:true,op:'Duel.SpecialSummon(find('+body+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Formation ignores opponent Galactica Special Summon',[[formation,G],[helper,H],[wing,G],[body,F],[link,E]],[helper],[[formation,G],[wing,F,1],[body,F],[link,E]],{family:formation,noTrigger:true,op:'Duel.SpecialSummon(find('+wing+',LOCATION_GRAVE),0,1-tp,1-tp,false,false,POS_FACEUP)'});
 add('Link material family: Formation excludes otherwise available opposing material',[[formation,G],[wing,H],[body,F,1],[link,E]],[-wing],[[formation,G],[wing,F],[body,F,1],[link,E]],{family:formation,opposingMaterial:true,noTrigger:true});
 add('Link material family: Grayrover uses your hand',[[grayrover,H],[body,H],[wing,F,1],[link,E]],[grayrover],[[grayrover,G],[body,G],[link,F],[wing,F,1]],{family:grayrover});
 add('Link material family: Grayrover uses your field',[[grayrover,H],[body,F],[wing,F,1],[link,E]],[grayrover],[[grayrover,G],[body,G],[link,F],[wing,F,1]],{family:grayrover});
 add('Link material family: Grayrover cannot use an opposing monster',[[grayrover,H],[wing,F,1],[link,E]],[grayrover],[[grayrover,F],[wing,F,1],[link,E]],{family:grayrover,noTrigger:true});
 add('Grayseer discards before summoning from Deck',[[grayseer,F],[body,H],[wing,D]],[grayseer],[[body,G],[wing,F]],{family:grayseer});
 add('Grayseer cannot activate when discarding is prohibited',[[grayseer,F],[helper,H],[body,H],[wing,D]],[helper],[[body,H],[wing,D]],{family:grayseer,forbidden:grayseer,op:'local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DISCARD_HAND) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(1,0) Duel.RegisterEffect(lock,tp)'});
 add('Mayavada cannot activate with only a prohibited discard available',[[mayavada,T],[helper,H],[body,H],[wing,F,1]],[helper],[[body,H],[wing,F,1]],{family:mayavada,forbidden:mayavada,op:'local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DISCARD_HAND) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(1,0) Duel.RegisterEffect(lock,tp)'});
 add('Mayavada can destroy and discard',[[mayavada,T],[body,H],[wing,F,1]],[mayavada],[[body,G],[wing,G,1]],{family:mayavada});
 const permitTrap='local c=find('+nullbind+',LOCATION_HAND) local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit)';
 add('Nullbind rejects a Normal Monster as its only target',[[nullbind,H],[helper,H],[link,F],[wing,F,1]],[helper],[[nullbind,H],[wing,F,1]],{family:nullbind,forbidden:nullbind,op:permitTrap});
 add('Nullbind negates and attaches a non-LIGHT Effect Monster',[[nullbind,H],[helper,H],[link,F],[wing,F,1]],[helper,nullbind],[[nullbind,G]],{family:nullbind,op:permitTrap,effectWing:true,yes:true,attached:true});
 add('Booster Dragon rejects a Normal Monster as its only target',[[booster,F],[spell,T],[wing,F,1]],[],[[spell,T],[wing,F,1]],{family:booster,forbidden:booster});
 add('Booster Dragon pays its Equip cost to negate an Effect Monster',[[booster,F],[spell,T],[wing,F,1]],[booster],[[spell,G],[wing,F,1]],{family:booster,effectWing:true});
 for(const effectWing of [false,true])add('Ivy '+(effectWing?'negates a Special Summoned Effect Monster':'rejects a Special Summoned Normal Monster'),[[ivy,F],[helper,H],[wing,H,1]],[helper],[[wing,F,1]],{family:ivy,effectWing,expectTrigger:effectWing,op:'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_HAND,nil,'+wing+') Duel.SpecialSummon(tc,0,tp,1-tp,false,false,POS_FACEUP) Duel.Destroy(find('+ivy+',LOCATION_MZONE),REASON_EFFECT)'});
 add('Bau Spell banishes the monster it just negated',[[bauSpell,H],[helper,H],[bauWorld,H],[bau,F],[body,D],[wing,F,1]],[helper,bauSpell],[[bauSpell,G],[wing,B,1],[body,F]],{family:bauSpell,yes:true,effectWing:true,pick:wing,op:'Duel.MoveToField(find('+bauWorld+',LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true)'});
 for(const reset of [false,true])add('Grayshade replacement '+(reset?'rejects a target that left and returned':'attaches its selected Spell'),[[grayshade,F],[body,G],[spell,G],[helper,H],[dark,H,1]],[helper],reset?[[spell,G]]:[],{family:grayshade,rewrite:true,reset,pick:spell,op:'Duel.Overlay(find('+grayshade+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE)))'});
 add('Chapter II replacement applies the selected monster properties',[[chapter,H],[dysmandr,E],[extinction,D],[body,F],[wing,F],[token,F,1],[helper,H],[dark,H,1]],[helper],[[wing,G]],{family:chapter,rewrite:true,pick:body,op:'local c=find('+chapter+',LOCATION_HAND) local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit)'});
 add('Chapter II replacement rejects a chosen monster that left and returned',[[chapter,H],[dysmandr,E],[extinction,D],[body,F],[wing,F],[token,F,1],[helper,H],[dark,H,1]],[helper],[[wing,F],[body,F]],{family:chapter,rewrite:true,reset:true,pick:body,op:'local c=find('+chapter+',LOCATION_HAND) local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit)'});
 for(const option of [0,1])add('Grayhex takes a Deck card '+(option?'to the GY':'to hand'),[[grayhex,H],[spell,D]],[grayhex],[[grayhex,F],[spell,option?G:H]],{family:grayhex,option});
 add('Grayhex cannot summon alongside a non-Grayscale monster',[[grayhex,H],[body,F]],[],[[grayhex,H]],{family:grayhex,forbidden:grayhex});
 add('Graylock summons and Sets its Deck Spell',[[graylock,H],[spell,D],[body,F,1]],[graylock],[[graylock,F],[spell,T]],{family:graylock});
 add('Graylock cannot summon without an opponent monster',[[graylock,H],[spell,D]],[],[[graylock,H]],{family:graylock,forbidden:graylock});
 add('Grayling sends another Grayscale monster from Deck',[[grayling,F],[wing,D]],[grayling],[[wing,G]],{family:grayling});
 add('Grayling cannot send another copy of itself',[[grayling,F],[grayling,D]],[],[[grayling,D]],{family:grayling,forbidden:grayling});
 add('Grayling GY trigger discards and searches Level 8',[[grayling,H],[helper,H],[body,H],[wing,D]],[helper],[[grayling,G],[body,G],[wing,H]],{family:grayling,levelEight:true,op:'Duel.SendtoGrave(find('+grayling+',LOCATION_HAND),REASON_EFFECT)'});
 add('Grayling can discard by effect under a discard-cost restriction',[[grayling,H],[helper,H],[body,H],[wing,D]],[helper],[[grayling,G],[body,G],[wing,H]],{family:grayling,levelEight:true,op:'local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DISCARD_HAND) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(1,0) lock:SetTarget(function(e,c,re,r) return r&REASON_COST~=0 end) lock:SetValue(1) Duel.RegisterEffect(lock,tp) Duel.SendtoGrave(find('+grayling+',LOCATION_HAND),REASON_EFFECT)'});
 for(const code of [grayhex,graylock,grayrover,graysentry])add('Grayscale effect discard remains legal for '+code,[[code,G],[helper,H],[body,H],[wing,E]],[helper],[[code,F],[body,G]],{family:code,revival:true,op:'local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DISCARD_HAND) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(1,0) lock:SetTarget(function(e,c,re,r) return r&REASON_COST~=0 end) lock:SetValue(1) Duel.RegisterEffect(lock,tp) Duel.SpecialSummon(find('+wing+',LOCATION_EXTRA),0,tp,tp,true,true,POS_FACEUP)'});
 const discardCostLock='local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DISCARD_HAND) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(1,0) lock:SetTarget(function(e,c,re,r) return r&REASON_COST~=0 end) lock:SetValue(1) Duel.RegisterEffect(lock,tp) ';
 for(const code of [vazagiel,sarifiel,fireball])add('Discard family permits effect discard for '+code,[[code,F],[helper,H],[wing,H],[body,code===fireball?H:G],[spell,G]],[helper,code],[[body,F],[wing,G]],{family:code,discardFamily:true,pick:body,op:discardCostLock+(code===sarifiel?'Duel.Overlay(find('+code+',LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)))':'')});
 add('Aquasanctuary searches then discards despite a cost-only restriction',[[sanctuary,H],[helper,H],[wing,H],[body,D]],[helper,sanctuary],[[wing,G],[body,H]],{family:sanctuary,discardFamily:true,yes:true,pick:wing,op:discardCostLock});
 add('Gorgonia searches then discards despite a cost-only restriction',[[gorgonia,G],[sanctuary,D],[body,F],[helper,H],[wing,H]],[helper],[[gorgonia,B],[sanctuary,H],[wing,G]],{family:gorgonia,discardFamily:true,yes:true,pick:wing,op:discardCostLock+'Duel.Remove(find('+gorgonia+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)'});
 add('Brilliance optionally discards despite a cost-only restriction',[[brilliance,G],[body,G],[helper,H],[wing,H],[dark,H,1]],[helper],[[brilliance,H],[wing,G]],{family:brilliance,discardFamily:true,rewrite:true,yes:true,pick:wing,op:discardCostLock,opponentOp:'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+body+') Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)'});
 add('Recollection searches and discards under a cost-only restriction',[[recollection,H],[helper,H],[body,D],[wing,H]],[helper,recollection],[[body,H],[wing,G]],{family:recollection,discardFamily:true,pick:wing,op:discardCostLock});
 add('Revelation searches a different name then discards',[[revelation,H],[body,H],[wing,D]],[revelation],[[revelation,G],[wing,H],[body,G]],{family:revelation,pick:body,forbidden:revelation});
 add('Revelation cannot search only the revealed name',[[revelation,H],[body,H],[body,D]],[],[[revelation,H]],{family:revelation,forbidden:revelation});
 add('Revelation summons its token and shares the effect limit',[[revelation,G],[revelation,H],[body,F],[body,H],[wing,D]],[revelation],[[revelation,B],[grayToken,F]],{family:revelation,activationLocation:G,forbidden:revelation});
 add('Revelation token effect needs a Grayscale monster',[[revelation,G],[dark,F]],[],[[revelation,G]],{family:revelation,forbidden:revelation});
 add('Revelation restricts Special Summons after the token effect',[[revelation,G],[body,F],[helper,H],[dark,G]],[revelation,helper],[[grayToken,F],[dark,G]],{family:revelation,op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Revelation token allows only Grayscale Link Material use',[[revelation,G],[body,F],[helper,H],[link,E],[fusion,E]],[revelation,helper],[[grayToken,F]],{family:revelation,tokenMaterials:true,op:'local c=find('+grayToken+',LOCATION_MZONE) local gray=find('+fusion+',LOCATION_EXTRA) local other=find('+link+',LOCATION_EXTRA) assert(c:IsCanBeLinkMaterial(gray)) assert(not c:IsCanBeLinkMaterial(other))'});
 add('Graydimm rewrites an opponent GY effect into your linked-zone revival',[[graydimm,F],[link,F],[wing,G],[body,G],[helper,H],[dark,G,1]],[helper],[[wing,F]],{family:graydimm,rewrite:true,graveActivation:true,op:'Duel.Overlay(find('+graydimm+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE)))'});
 add('Graydimm rejects resources controlled only by the opponent',[[graydimm,F],[link,F,1],[wing,G,1],[body,G],[helper,H],[dark,G,1]],[helper],[[wing,G,1]],{family:graydimm,rewrite:true,noRewrite:true,graveActivation:true,op:'Duel.Overlay(find('+graydimm+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE)))'});
 add('Graydimm rejects an occupied linked zone',[[graydimm,F],[link,F],[fusion,F],[wing,G],[body,G],[helper,H],[dark,G,1]],[helper],[[wing,G]],{family:graydimm,rewrite:true,noRewrite:true,graveActivation:true,op:'Duel.Overlay(find('+graydimm+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE)))'});
 for(const controller of [0,1])add('Graydeux rewrites into attaching a monster from player '+controller,[[graydeux,F],[wing,F,controller],[body,G],[spell,G],[helper,H],[dark,H,1]],[helper],[],{family:graydeux,rewrite:true,pick:wing,checkAttached:controller,op:'local g=Group.FromCards(find('+body+',LOCATION_GRAVE),find('+spell+',LOCATION_GRAVE)) Duel.Overlay(find('+graydeux+',LOCATION_MZONE),g)'});
 add('Graydeux Xyz Summon trigger attaches up to your Grayscale count',[[graydeux,G],[body,F],[wing,F,1],[dark,F,1],[helper,H]],[helper],[[graydeux,F]],{family:graydeux,xyzTrigger:true,attached:true,selectMax:true,op:'local c=find('+graydeux+',LOCATION_GRAVE) Duel.SpecialSummon(c,SUMMON_TYPE_XYZ,tp,tp,true,true,POS_FACEUP) c:CompleteProcedure()'});
 add('Graydeux alternative Xyz Summon transfers Rank 8 materials',[[graydeux,E],[body,F],[link,F],[spell,G],[helper,H]],[helper,graydeux],[[graydeux,F]],{family:graydeux,nativeSpecial:true,op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)))'});
 add('Graydeux alternative procedure rejects two Rank 8 monsters',[[graydeux,E],[body,F],[link,F],[spell,G],[helper,H]],[helper],[[graydeux,E]],{family:graydeux,nativeSpecial:true,wrongRecipe:true,op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)))'});
 for(const materials of [1,2])add('Grayshade End Phase recovery with '+materials+' materials',[[grayshade,F],[body,G],[spell,G],[wing,G],[helper,H]],[helper],[[wing,materials===2?H:G]],{family:grayshade,endRecovery:true,materials,pick:wing,op:'local g=Group.FromCards(find('+body+',LOCATION_GRAVE)) '+(materials===2?'g:AddCard(find('+spell+',LOCATION_GRAVE))':'')+' Duel.Overlay(find('+grayshade+',LOCATION_MZONE),g)'});
 add('Grayshade recovery requires a legal Grayscale target',[[grayshade,F],[body,G],[spell,G],[wing,G],[helper,H]],[helper],[[wing,G]],{family:grayshade,endRecovery:true,materials:2,noRecoveryTarget:true,op:'Duel.Overlay(find('+grayshade+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE),find('+spell+',LOCATION_GRAVE)))'});
 add('Grayseer protects its linked monster from opponent effects',[[body,F],[grayseer,F],[wing,F],[helper,H],[dark,H,1]],[helper],[[body,F],[wing,G]],{family:grayseer,rewrite:true,noRewrite:true,op:'',opponentOp:'local g=Duel.GetMatchingGroup(function(c) return c:IsCode('+body+','+wing+') end,tp,0,LOCATION_MZONE,nil) Duel.Destroy(g,REASON_EFFECT)'});
 add('Grayseer permits your effects on its linked monster',[[body,F],[grayseer,F],[wing,F],[helper,H]],[helper],[[body,G],[wing,G]],{family:grayseer,op:'local g=Duel.GetMatchingGroup(function(c) return c:IsCode('+body+','+wing+') end,tp,LOCATION_MZONE,0,nil) Duel.Destroy(g,REASON_EFFECT)'});
 for(const removed of [false,true])add('Grayseer protection ends when its source is '+(removed?'removed':'negated'),[[body,F],[grayseer,F],[wing,F],[helper,H],[dark,H,1]],[helper],[[body,G],[wing,G]],{family:grayseer,rewrite:true,noRewrite:true,op:'',opponentOp:'local source=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+grayseer+') '+(removed?'Duel.SendtoGrave(source,REASON_EFFECT)':'local disable=Effect.CreateEffect(e:GetHandler()) disable:SetType(EFFECT_TYPE_SINGLE) disable:SetCode(EFFECT_DISABLE) source:RegisterEffect(disable) Duel.AdjustInstantly(source)')+' local g=Duel.GetMatchingGroup(function(c) return c:IsCode('+body+','+wing+') end,tp,0,LOCATION_MZONE,nil) Duel.Destroy(g,REASON_EFFECT)'});
 add('Nullbind revives a Grayscale monster with effects negated',[[nullbind,G],[wing,G],[helper,H]],[nullbind,helper],[[nullbind,B],[wing,F]],{family:nullbind,reviveNull:true,op:'assert(find('+wing+',LOCATION_MZONE):IsDisabled())'});
 add('Nullbind cannot revive a non-Grayscale monster',[[nullbind,G],[wing,G]],[],[[nullbind,G],[wing,G]],{family:nullbind,forbidden:nullbind});
 add('Nullbind shares its effect limit across copies',[[nullbind,G],[nullbind,G],[wing,G],[body,G]],[nullbind],[[nullbind,B],[wing,F]],{family:nullbind,reviveNull:true,pick:wing,forbidden:nullbind});
 add('Nullbind revival prevents activating its field effect that turn',[[nullbind,G],[nullbind,H],[wing,G],[link,F],[body,F,1],[helper,H]],[nullbind,helper],[[nullbind,B],[wing,F]],{family:nullbind,reviveNull:true,pick:wing,activationLocation:G,forbidden:nullbind,op:'local c=find('+nullbind+',LOCATION_HAND) local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit)'});
 add('Graysentry performs an immediate Xyz Summon with a Grayscale material',[[graysentry,H],[body,F],[fusion,E]],[graysentry],[[fusion,F]],{family:graysentry,xyzFixture:true});
 add('Graysentry rejects a material with the wrong Level',[[graysentry,H],[body,F],[fusion,E]],[graysentry],[[graysentry,F],[body,F],[fusion,E]],{family:graysentry,xyzFixture:true,wrongXyzLevel:true,expectTrigger:true});
 add('Graysentry cannot use an opposing material',[[graysentry,H],[body,F,1],[fusion,E]],[graysentry],[[graysentry,F],[body,F,1],[fusion,E]],{family:graysentry,xyzFixture:true,opposingXyzMaterial:true,expectTrigger:true});
 for(const code of [grayhex,graylock,grayrover,graysentry])add('Grayscale hand summon limit is shared across copies of '+code,[[code,H],[code,H],[body,F,1]],[code],[[code,F],[code,H]],{family:code,forbidden:code});
 add('Grayling Deck-send limit is shared across copies',[[grayling,F],[grayling,F],[wing,D],[wing,D]],[grayling],[[wing,G],[wing,D]],{family:grayling,graylingLimit:true,forbidden:grayling});
 for(const code of [grayhex,graylock,grayrover,graysentry])add('Grayscale GY revival limit is shared across copies of '+code,[[code,G],[code,G],[helper,H],[body,H],[body,H],[wing,E]],[helper],[[code,F],[code,G]],{family:code,revival:true,expectedFamilyUses:1,op:'Duel.SpecialSummon(find('+wing+',LOCATION_EXTRA),0,tp,tp,true,true,POS_FACEUP)'});
 for(const code of [grayling,grayhex,graylock,grayrover,graysentry,grayseer,grayterror,graydimm,grayshade])for(const negated of [false,true]){
  const mainDeck=[grayling,grayhex,graylock,grayrover,graysentry].includes(code);
  add('Grayscale material restriction '+code+(negated?' while negated':''),[[code,F],[helper,H],[link,E],[fusion,E],[body,E],[wing,E]],[helper],[[code,F]],{family:code,materialGate:true,op:'local c=find('+code+',LOCATION_MZONE) '+(negated?'local disable=Effect.CreateEffect(e:GetHandler()) disable:SetType(EFFECT_TYPE_SINGLE) disable:SetCode(EFFECT_DISABLE) c:RegisterEffect(disable) Duel.AdjustInstantly(c) ':'')+' assert(c:IsCanBeLinkMaterial(find('+fusion+',LOCATION_EXTRA))) assert(not c:IsCanBeLinkMaterial(find('+link+',LOCATION_EXTRA))) '+(mainDeck?'assert(c:IsCanBeXyzMaterial(find('+body+',LOCATION_EXTRA))) assert(not c:IsCanBeXyzMaterial(find('+wing+',LOCATION_EXTRA)))':'')});
 }
 for(const code of [grayseer,grayterror])for(const invalid of [null,'race','attribute','archetype']){
  const setup=[[code,E],[body,F],[wing,F]];
  if(code===grayterror)setup.push([body,F],[body,F]);
  add('Grayscale native Link recipe '+code+' '+(invalid||'valid'),setup,invalid?[]:[code],[[code,invalid?E:F]],{family:code,linkRecipe:true,invalidLinkMaterial:invalid});
 }
 add('Grayterror Link Summon can use a Link 3 and one other monster',[[grayterror,E],[link,F],[body,F]],[grayterror],[[grayterror,F]],{family:grayterror,linkRecipe:true,linkThree:true});
 for(const code of [graydimm,grayshade])for(const invalid of [null,'level','lightfiend']){
  add('Grayscale ordinary Xyz recipe '+code+' '+(invalid||'valid'),[[code,E],[body,F],[wing,F]],invalid?[]:[code],[[code,invalid?E:F]],{family:code,xyzRecipe:true,invalidXyzMaterial:invalid});
 }
 for(const invalid of [null,'level','lightfiend','race'])add('Graydeux ordinary Level 12 recipe '+(invalid||'valid'),[[graydeux,E],[body,F],[wing,F]],invalid?[]:[graydeux],[[graydeux,invalid?E:F]],{family:graydeux,xyzRecipe:true,standardXyz:true,invalidXyzMaterial:invalid});
 add('Graydimm detaches one material to revive a Grayscale monster',[[graydimm,F],[wing,G],[body,G],[helper,H]],[helper,graydimm],[[body,G],[wing,F]],{family:graydimm,pick:wing,op:'Duel.Overlay(find('+graydimm+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE)))'});
 add('Grayterror grants 800 ATK only to your Grayscale monsters',[[grayterror,F],[body,F],[wing,F],[helper,H]],[helper],[[body,F],[wing,F]],{family:grayterror,atkAura:true,op:'assert(find('+body+',LOCATION_MZONE):GetAttack()==900) assert(find('+wing+',LOCATION_MZONE):GetAttack()==100)'});
 add('Grayling rejects an earlier non-LIGHT Fiend Special Summon',[[grayling,F],[helper,H],[dark,G],[wing,D]],[helper],[[dark,F],[wing,D]],{family:grayling,forbidden:grayling,op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Grayling blocks later non-LIGHT Fiend Special Summons',[[grayling,F],[helper,H],[dark,G],[wing,D]],[grayling,helper],[[dark,G],[wing,G]],{family:grayling,op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 add('Arckcestial Descend rejects a Spell as its only Deck candidate',[[descend,H],[body,D]],[],[[descend,H],[body,D]],{family:descend,descendType:2,forbidden:descend});
 for(const option of [0,1])add('Arckcestial Descend takes a monster '+(option?'to GY':'to hand'),[[descend,H],[body,D]],[descend],[[body,option?G:H]],{family:descend,descendType:17,option});
 add('Arckcestial Orb cannot pay a prohibited discard cost',[[orb,H],[body,H],[helper,H]],[helper],[[orb,H],[body,H]],{family:orb,orbCost:true,forbidden:orb,op:discardCostLock});
 add('Arckcestial Orb discards another Arckcestial card to summon',[[orb,H],[body,H]],[orb],[[orb,F],[body,G]],{family:orb,orbCost:true});
 add('Orb attaches itself from GY to an Arckcestial Xyz',[[orb,G],[body,F]],[orb],[],{family:orb,arcGY:true,checkOrb:true});
 add('Orb cannot attach to an unrelated Xyz',[[orb,G],[body,F]],[],[[orb,G]],{family:orb,arcGY:true,wrongArcXyz:true,forbidden:orb});
 add('Descend revives in Defense Position',[[descend,G],[body,F],[wing,G]],[descend],[[descend,B],[wing,F]],{family:descend,arcGY:true,checkDefense:true});
 add('Descend requires your own Arckcestial Extra Deck monster',[[descend,G],[body,F,1],[wing,G]],[],[[descend,G],[wing,G]],{family:descend,arcGY:true,forbidden:descend});
 add('Descend revival limit is shared across copies',[[descend,G],[descend,G],[body,F],[wing,G],[wing,G]],[descend],[[descend,B],[wing,F],[wing,G]],{family:descend,arcGY:true,forbidden:descend,checkDefense:true});
 for(const count of [1,2])add('Pillar returns '+count+' banished Arckcestial cards',[[pillar,T],[body,B],...(count===2?[[wing,B]]:[])],[pillar],[[body,G],...(count===2?[[wing,G]]:[])],{family:pillar,pillarReturn:true,selectMax:true});
 for(const kind of ['effect','cost','unrelated'])add('Pillar self-Set trigger for '+kind,[[pillar,G],[helper,H]],[helper],[[pillar,kind==='effect'?T:B]],{family:pillar,pillarSource:kind,op:'Duel.Remove(find('+pillar+',LOCATION_GRAVE),POS_FACEUP,'+(kind==='cost'?'REASON_COST':'REASON_EFFECT')+')'});
 for(const code of [descend,burning,fireball])for(const mode of ['effect-discard','cost-discard','send']){
  const discarding=mode!=='send';
  add('Arckcestial GY trigger '+code+' '+mode,[[code,H],[helper,H]],[helper],[[code,discarding?(code===fireball?F:T):G]],{family:code,op:discarding?'Duel.DiscardHand(tp,Card.IsCode,1,1,REASON_DISCARD+'+(mode==='cost-discard'?'REASON_COST':'REASON_EFFECT')+',nil,'+code+')':'Duel.SendtoGrave(find('+code+',LOCATION_HAND),REASON_EFFECT)'});
 }
 for(const spellOnly of [false,true])add('Feather search '+(spellOnly?'rejects a Spell':'adds a monster'),[[feather,H],[body,D]],[-feather],[[body,spellOnly?D:H]],{family:feather,featherSearch:true,spellOnly,expectTrigger:!spellOnly});
 for(const spellOnly of [false,true])add('Meadow activation search '+(spellOnly?'rejects a Spell':'adds a monster'),[[meadow,H],[body,D],[wing,H]],[meadow],[[body,spellOnly?D:H]],{family:meadow,featherSearch:true,spellOnly,yes:true,noYes:spellOnly,pick:wing});
 for(const immune of [false,true])add('Urphiel destruction replacement '+(immune?'requires a successful banish':'banishes a GY card'),[[urphiel,F],[body,G],[helper,H]],[helper],[[urphiel,immune?G:F],[body,immune?G:B]],{family:urphiel,replaceUrphiel:true,immuneReplace:immune,yes:true,op:'Duel.Destroy(find('+urphiel+',LOCATION_MZONE),REASON_EFFECT)'});
 for(const code of [behemoth,faceOff])for(const immune of [false,true]){
  const defended=code===faceOff?wing:code;
  add('Banish replacement '+code+' '+(immune?'rejects immune substitute':'protects after banish'),[[code,code===faceOff?T:F],...(code===faceOff?[[wing,F]]:[]),[body,G],[helper,H]],[helper],[[defended,immune?G:F],[body,immune?G:B]],{family:code,replaceFamily:true,immuneReplace:immune,yes:true,op:'Duel.Destroy(find('+defended+',LOCATION_MZONE),REASON_EFFECT)'});
 }
 for(const mode of ['hand-cost','grave-cost','no-companion','no-material']){
  const valid=mode==='hand-cost'||mode==='grave-cost';
  add('Urphiel negate and banish '+mode,[[urphiel,F],[body,F],[wing,mode==='grave-cost'?G:H],[spell,G],[helper,H],[dark,H,1]],[helper],[[dark,valid?B:G,1],...(valid?[[wing,B],[spell,G]]:[])],{family:urphiel,rewrite:true,noRewrite:!valid,negateUrphiel:true,negateMode:mode,op:mode==='no-material'?'':'Duel.Overlay(find('+urphiel+',LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)))',opponentOp:'Duel.Recover(tp,500,REASON_EFFECT)'});
 }
 for(const code of [malphiel,vazagiel,azeriel])for(const mode of ['cost','effect','unrelated']){
  const target=code===vazagiel?H:F;
  add('Arckcestial detach trigger '+code+' '+mode,[[code,G],[body,F],[helper,H],[wing,target,1]],[helper,body],[[wing,mode==='cost'?G:target,1]],{family:code,detachProbe:true,detachMode:mode,pick:wing,expectedFamilyUses:mode==='cost'?1:0,op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find('+code+',LOCATION_GRAVE)))'});
 }
 for(const valid of [true,false])add('Ophiel GY response '+(valid?'tributes and revives':'rejects a non-Arckcestial target'),[[ophiel,G],[body,F],[wing,F,1],[helper,H],[dark,H,1]],[helper],[[ophiel,valid?F:G],[body,valid?G:F]],{family:ophiel,rewrite:true,noRewrite:!valid,ophielResponse:true,targetIsArc:valid,pick:wing,op:'find('+ophiel+',LOCATION_GRAVE):CompleteProcedure()'});
 for(const xyz of [true,false])add('Ophiel search requires an Xyz Summon '+xyz,[[ophiel,G],[body,D],[helper,H]],[helper],[[body,xyz?H:D]],{family:ophiel,ophielSearch:true,expectedFamilyUses:xyz?1:0,op:'local c=find('+ophiel+',LOCATION_GRAVE) Duel.SpecialSummon(c,'+(xyz?'SUMMON_TYPE_XYZ':'0')+',tp,tp,true,true,POS_FACEUP) c:CompleteProcedure()'});
 add('Ophiel detach trigger recovers a Spell then discards',[[ophiel,G],[body,F],[spell,G],[wing,H],[helper,H]],[helper,body],[[spell,H],[wing,G]],{family:ophiel,detachProbe:true,detachMode:'cost',ophielDetach:true,pick:wing,expectedFamilyUses:1,op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find('+ophiel+',LOCATION_GRAVE)))'});
 for(const monster of [true,false])add('Azeriel Xyz Summon sends only an Arckcestial monster '+monster,[[azeriel,G],[body,D],[helper,H]],[helper],[[body,monster?G:D]],{family:azeriel,azerielMill:true,monster,expectedFamilyUses:monster?1:0,op:'local c=find('+azeriel+',LOCATION_GRAVE) Duel.SpecialSummon(c,SUMMON_TYPE_XYZ,tp,tp,true,true,POS_FACEUP) c:CompleteProcedure()'});
 for(const spellCard of [true,false])add('Azeriel detach search requires a Rank-Up-Magic Spell '+spellCard,[[azeriel,F],[body,D],[spell,G],[helper,H]],spellCard?[helper,azeriel]:[helper],[[body,spellCard?H:D]],{family:azeriel,azerielSearch:true,spellCard,forbidden:azeriel,op:'Duel.Overlay(find('+azeriel+',LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)))'});
 for(const mode of ['recover','decline','wrong-type','wrong-archetype']){
  const valid=mode==='recover'||mode==='decline';
  add('Azeriel GY revival '+mode,[[azeriel,G],[wing,E],[spell,G],[helper,H]],[helper],[[azeriel,valid?F:G],[spell,mode==='recover'?H:G]],{family:azeriel,azerielRevive:true,reviveMode:mode,yes:mode==='recover',expectedFamilyUses:valid?1:0,checkDefense:false,op:'find('+azeriel+',LOCATION_GRAVE):CompleteProcedure() Duel.SpecialSummon(find('+wing+',LOCATION_EXTRA),0,tp,tp,true,true,POS_FACEUP)'});
 }
 add('Crystal Shards discards and summons from Deck in Defense Position',[[shards,F],[wing,H],[body,D]],[shards],[[wing,G],[body,F]],{family:shards,shardsProbe:true,pick:wing});
 add('Crystal Shards rejects a Level 5 Deck monster',[[shards,F],[wing,H],[body,D]],[],[[body,D]],{family:shards,shardsProbe:true,highLevel:true,forbidden:shards});
 add('Crystal Shards respects a discard-cost prohibition',[[shards,F],[wing,H],[body,D],[helper,H]],[helper],[[wing,H],[body,D]],{family:shards,shardsProbe:true,forbidden:shards,op:discardCostLock});
 add('Crystal Shards restricts later Special Summons',[[shards,F],[wing,H],[body,D],[helper,H],[dark,G]],[shards,helper],[[body,F],[dark,G]],{family:shards,shardsProbe:true,pick:wing,op:'Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)'});
 for(const locked of [false,true])add('Crystal Shards returns the Extra Deck card without discarding '+(locked?'under a cost-only discard restriction':'baseline'),[[shards,F],[body,F],[fusion,E],[link,B],[wing,H],[helper,H]],locked?[helper,fusion]:[fusion],[[link,E],[wing,H]],{family:shards,materialSynchro:true,costLockRecovery:locked,pick:wing,expectedFamilyUses:1,op:discardCostLock});
 add('Crystal Shards can return a banished Extra Deck card with an empty hand',
  [[shards,F],[body,F],[fusion,E],[link,B]],[fusion],[[link,E]],
  {family:shards,materialSynchro:true,shardsEmptyHand:true,expectedFamilyUses:1,expectedHandCount:0});
 add('Crystal Shards recovery requires a LIGHT Synchro Monster',[[shards,F],[body,F],[fusion,E],[link,B],[wing,H]],[fusion],[[link,B],[wing,H]],{family:shards,materialSynchro:true,darkSynchro:true,expectedFamilyUses:0});
 add('Crystal Shards recovers a banished Main Deck card',[[shards,F],[body,F],[fusion,E],[link,B],[wing,H]],[fusion],[[link,H],[wing,G]],{family:shards,materialSynchro:true,mainDeckRecovery:true,pick:wing,expectedFamilyUses:1});
 for(const code of [feather,fireball])for(const mode of ['valid','dark-synchro','invalid-target']){
  const initial=code===feather?G:D,valid=mode==='valid';
  add('Arckcestial native Synchro recovery '+code+' '+mode,[[code,F],[body,F],[fusion,E],[link,initial],[wing,H]],[fusion],[[link,valid?H:initial],...(code===fireball?[[wing,valid?G:H]]:[])],{family:code,materialSynchro:true,materialRecovery:true,darkSynchro:mode==='dark-synchro',invalidMaterialTarget:mode==='invalid-target',pick:wing,expectedFamilyUses:valid?1:0});
 }
 for(const code of [malphiel,vazagiel])for(const mode of ['synchro','ordinary-special','expiry'])add('Arckcestial temporary Level '+code+' '+mode,[[code,G],[helper,H]],[helper],[[code,F]],{family:code,tempLevel:mode,op:'local c=find('+code+',LOCATION_GRAVE) Duel.SpecialSummon(c,'+(mode==='ordinary-special'?'0':'SUMMON_TYPE_SYNCHRO')+',tp,tp,true,true,POS_FACEUP) c:CompleteProcedure()'});
 add('Malphiel protects other LIGHT monsters from opposing targeting',[[malphiel,F],[body,F],[wing,F],[helper,H],[dark,H,1]],[helper],[[body,F],[wing,F]],{family:malphiel,protectionProbe:true,rewrite:true,noRewrite:true,op:''});
 for(const mode of ['normal','blocked','left-field'])add('Burning resolution '+mode,[[burning,H],[body,G],[wing,F,1],[helper,H],...(mode==='normal'?[]:[[dark,F,1]])],[helper,burning],[[wing,mode==='blocked'?F:H,1]],{family:burning,burnResolution:mode,pick:wing,expectedFamilyUses:1,op:'local c=find('+burning+',LOCATION_HAND) local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit)'});
 for(const mode of ['valid','dark-synchro','high-level'])add('Prism native Synchro Material revival '+mode,[[prism,F],[body,F],[fusion,E],[link,G]],[fusion],[[link,mode==='valid'?F:G]],{family:prism,materialSynchro:true,prismMaterial:true,darkSynchro:mode==='dark-synchro',highPrismTarget:mode==='high-level',expectedFamilyUses:mode==='valid'?1:0});
 for(const mode of ['opponent','own','not-xyz','two-copies']){
  const valid=mode==='opponent'||mode==='two-copies';
  const setup=[[urphiel,G],[body,G],[wing,G],[helper,H],...(mode==='two-copies'?[[urphiel,G]]:[]),...(mode==='own'?[]:[[dark,H,1]])];
  add('Urphiel leave-field revival '+mode,setup,[helper],[[body,valid?F:G],[wing,valid?F:G]],{family:urphiel,urphielLeave:true,rewrite:mode!=='own',noRewrite:!valid,selectMax:true,expectedFamilyUses:valid?1:0,op:'local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+urphiel+') Duel.SpecialSummon(g,'+(mode==='not-xyz'?'0':'SUMMON_TYPE_XYZ')+',tp,tp,true,true,POS_FACEUP) for c in aux.Next(g) do c:CompleteProcedure() end '+(mode==='own'?'Duel.SendtoGrave(g,REASON_EFFECT)':''),opponentOp:'local g=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+urphiel+') Duel.SendtoGrave(g,REASON_EFFECT)'});
 }
 for(const mode of ['grave','banished','spell',...(process.argv.includes('--grave-immune-probe')?['immune']:[])]){
  const valid=mode==='grave'||mode==='banished',loc=mode==='banished'?B:G;
  add('Sarifiel on-summon attachment '+mode,[[sarifiel,G],[body,loc],[helper,H]],[helper],valid?[]:[[body,loc]],{family:sarifiel,sarifielAttach:true,attachMode:mode,immuneReplace:mode==='immune',expectedFamilyUses:mode==='spell'?0:1,op:'local c=find('+sarifiel+',LOCATION_GRAVE) Duel.SpecialSummon(c,0,tp,tp,true,true,POS_FACEUP) c:CompleteProcedure()'});
 }
 add('Orb cannot attach itself to an effect-immune recipient',[[orb,G],[body,F],[helper,H]],[helper,orb],[[orb,G]],{family:orb,arcGY:true,immuneOrbHost:true,op:'local c=find('+body+',LOCATION_MZONE) local immune=Effect.CreateEffect(e:GetHandler()) immune:SetType(EFFECT_TYPE_SINGLE) immune:SetCode(EFFECT_IMMUNE_EFFECT) immune:SetValue(function() return true end) c:RegisterEffect(immune)'});
 const immunityToOpponent=code=>' local c=find('+code+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function(e,re) return re:GetOwnerPlayer()==1 end) c:RegisterEffect(ex)';
 for(const [name,host,expected] of [
  ['Graydeux rewrites into attaching a monster from player 1',graydeux,[[wing,F,1]]],
  ['Grayshade replacement attaches its selected Spell',grayshade,[[spell,G]]]
 ]){
  const original=testCases.find(t=>t.name===name);assert(original,name);
  const test={...original,name:name+' respects recipient immunity',op:original.op+immunityToOpponent(host),blockedRecipient:host,expected};
  delete test.checkAttached;testCases.push(test);
 }
 {
  const original=testCases.find(t=>t.name==='Nullbind negates and attaches a non-LIGHT Effect Monster');assert(original);
  const test={...original,name:'Nullbind respects recipient immunity',op:original.op+' local c=find('+link+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) c:RegisterEffect(ex)',blockedRecipient:link,expected:[[nullbind,G],[wing,F,1]]};
  delete test.attached;testCases.push(test);
 }
 add('Grayterror rewrite respects recipient immunity',[[grayterror,F],[body,F],[fusion,F],[wing,H],[spell,G],[helper,H],[dark,F,1]],[helper],[[wing,F],[spell,G]],{family:grayterror,grayterrorHost:true,monsterActivation:true,rewrite:true,yes:true,pick:spell,blockedRecipient:fusion,op:immunityToOpponent(fusion)});
 for(const code of [raven,glint])for(const immune of [false,true])add('Aerocat attachment '+code+' '+(immune?'respects recipient immunity':'baseline'),[[code,G],[body,F],[helper,H]],immune?[helper,code]:[code],immune?[[code,G]]:[],{family:code,aeroAttachment:true,immuneOrbHost:immune,checkAeroAttachment:!immune,op:'local c=find('+body+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) c:RegisterEffect(ex)'});
 for(const code of [melody,failuresAip])for(const immune of [false,true]){
  const aip=code===failuresAip,loc=aip?F:D,player=aip?1:0;
  add('Recipient immunity family '+code+' '+(immune?'immune':'baseline'),[[code,aip?H:G],[body,F],[wing,loc,player],[helper,H]],aip||immune?[helper,code]:[code],immune?[[wing,loc,player]]:[],{family:code,genericHostFamily:true,blockedRecipient:immune?body:undefined,checkHostAttachment:!immune,pick:wing,op:(aip?'local c=find('+code+',LOCATION_HAND) local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit) ':'')+(immune?'local host=find('+body+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) host:RegisterEffect(ex)':'')});
 }
 for(const code of [ghostXyz,aeroXyz])for(const immune of [false,true]){
  const ghost=code===ghostXyz,host=ghost?wing:body,material=ghost?body:wing;
  const protect='local recipient=find('+host+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) recipient:RegisterEffect(ex) ';
  add('Attachment family '+code+' '+(immune?'respects recipient immunity':'baseline'),[[code,ghost?F:G],[host,F],[material,G],[helper,H]],[helper],immune?[[material,G]]:[],{family:code,overlayFamily:true,overlayHost:host,overlayMaterial:material,blockedRecipient:immune?host:undefined,verifyOverlay:!immune,yes:true,pick:ghost?body:body,op:(immune?protect:'')+(ghost?'Duel.SendtoGrave(find('+code+',LOCATION_MZONE),REASON_EFFECT)':'local c=find('+code+',LOCATION_GRAVE) Duel.SpecialSummon(c,SUMMON_TYPE_XYZ,tp,tp,true,true,POS_FACEUP) c:CompleteProcedure()')});
 }
 for(const code of [shade,ghostTransfer])for(const immune of [false,true]){
  const shadeCase=code===shade;
  const expected=immune?[[wing,shadeCase?F:L.OVERLAY,shadeCase?1:0]]:[];
  // Overlay location is verified through its host query below.
  if(immune&&!shadeCase)expected.length=0;
  add('Attachment family '+code+' '+(immune?'immune recipient':'baseline'),[[code,F],[body,F],[wing,shadeCase?F:D,shadeCase?1:0],[helper,H]],immune?[helper,code]:[code],expected,{family:code,shadeFamily:shadeCase,ghostTransferFamily:!shadeCase,immuneOrbHost:immune,blockedRecipient:immune?body:undefined,expectedRecipient:immune?[]:shadeCase?[wing]:[wing,code],pick:wing,op:'local host=find('+body+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) host:RegisterEffect(ex)'});
 }
 for(const recipient of [ghostXyz,259851064,75367227,32224143]){
  const setup=[[ghostTransfer,F],[recipient,F],[wing,D]];
  let expected;
  if(recipient===ghostXyz){setup.push([body,D]);expected=[[body,H]];}
  else if(recipient===259851064){setup.push([body,D]);expected=[[body,T]];}
  else{setup.push([dark,recipient===75367227?T:F,1]);expected=[[dark,G,1]];}
  add('Ghostrick Oni grants a Quick Effect to '+recipient,setup,[ghostTransfer,recipient],expected,
   {family:ghostTransfer,ghostTransferFamily:true,oniQuickRecipient:recipient,pick:wing,expectedFamilyUses:1});
 }
 for(const mode of ['two-grants','expiry']){
  const twice=mode==='two-grants';
  add('Ghostrick Oni Quick Effect '+mode,
   [[ghostTransfer,F],[ghostXyz,F],[wing,D],[body,D],[body,D],...(twice?[[ghostTransfer,F],[wing,D]]:[[helper,H]])],
   twice?[ghostTransfer,ghostTransfer,ghostXyz]:[ghostTransfer,ghostXyz,helper],
   [[body,H],[body,D]],
   {family:ghostTransfer,ghostTransferFamily:true,oniQuickRecipient:ghostXyz,oniExpiry:!twice,oniTwoGrants:twice,
    pick:wing,expectedFamilyUses:twice?2:1,
    op:'local c=find('+ghostXyz+',LOCATION_MZONE) for _,te in ipairs({c:GetCardEffect()}) do assert(not te:IsHasType(EFFECT_TYPE_QUICK_O),"Granted timing expired at End Phase") end'});
 }

 for(const immune of [false,true])add('Claw revive-then-attach '+(immune?'recipient immunity':'baseline'),[[claw,F],[body,G],[helper,H],[dark,F,1]],[helper],[[body,F],...(immune?[[claw,G]]:[])],{family:claw,clawRevive:true,revivingRecipient:immune,monsterActivation:true,rewrite:true,yes:true,pick:body,expectedRecipient:immune?[]:[claw],op:'find('+body+',LOCATION_GRAVE):CompleteProcedure()'});
 for(const code of [rook,knight])for(const immune of [false,true])add('Aldrez revive-then-attach '+code+' '+(immune?'recipient immunity':'baseline'),[[code,G],[body,F],[wing,code===rook?F:G],[helper,H],[dark,H,1]],[helper],[[body,F],...(immune?[[wing,code===rook?F:G]]:[])],{family:code,aldrezRevive:true,revivingRecipient:immune,rewrite:true,yes:true,pick:body,expectedRecipient:immune?[]:[wing],op:'find('+body+',LOCATION_MZONE):CompleteProcedure()',opponentOp:'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+body+') Duel.SendtoGrave(c,REASON_EFFECT)'});
 for(const code of [standTogether,showdown])for(const immune of [false,true]){
  const stand=code===standTogether;
  const prepare='Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE))) ';
  const permit=stand?'':'local c=find('+code+',LOCATION_HAND) local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit) ';
  const protect=immune?'local host=find('+body+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) host:RegisterEffect(ex)':'';
  add('Attachment family '+code+' '+(immune?'recipient immunity':'baseline'),[[code,stand?T:H],[body,F],[spell,G],[wing,stand?G:F,stand?0:1],[helper,H]],[helper,code],immune?[[wing,stand?G:F,stand?0:1]]:[],{family:code,standProbe:stand,showdownProbe:!stand,immuneOrbHost:immune,pick:wing,expectedRecipient:immune?(stand?[]:[spell]):stand?[wing]:[spell,wing],op:prepare+permit+protect});
 }
 for(const immune of [false,true])add('Ghostrick response recipient '+(immune?'immunity':'baseline'),[[227531376,H],[body,F],[helper,H],[dark,F,1]],[helper],[[227531376,F],...(immune?[[dark,F,1]]:[])],{family:227531376,ghostResponse:true,monsterActivation:true,rewrite:true,yes:true,pick:body,expectedRecipient:immune?[]:[dark],op:''+(immune?'local host=find('+body+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) host:RegisterEffect(ex)':'')});
 for(const immune of [false,true])add('Brigade summon-then-attach '+(immune?'recipient immunity':'baseline'),[[238976759,H],[body,E],[wing,G],[spell,H],[trap,H],[helper,H]],[helper,238976759],[[body,F],...(immune?[[wing,G]]:[])],{family:238976759,brigadeSummon:true,revivingRecipient:immune,yes:true,pick:body,expectedRecipient:immune?[]:[wing],op:'Duel.MoveToField(find(238976759,LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true)'});
 for(const mode of ['field','wrong-set','grave'])add('Stand Together draw '+mode,[[standTogether,T],[body,mode==='grave'?G:F]],[body],mode==='field'?[[dark,H]]:[],{family:standTogether,standDraw:mode,expectedFamilyUses:mode==='field'?1:0,expectedHandCount:mode==='field'?1:0});
 add('Heartbeat attached by effect grants banish response',[[220124524,G],[body,F],[helper,H],[dark,F,1]],[helper],[[dark,B,1]],{family:220124524,heartbeatMaterial:true,monsterActivation:true,rewrite:true,noRewrite:true,yes:true,expectedRecipient:[],op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find(220124524,LOCATION_GRAVE)))'});
 add('Heartbeat material requires Brigade recipient',[[220124524,G],[body,F],[helper,H],[dark,F,1]],[helper],[[dark,F,1]],{family:220124524,heartbeatMaterial:true,wrongBrigadeHost:true,monsterActivation:true,rewrite:true,noRewrite:true,yes:true,expectedRecipient:[220124524],op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find(220124524,LOCATION_GRAVE)))'});
 add('Joyous attached by effect grants grave banish',[[255668557,G],[body,F],[helper,H],[wing,G,1]],[helper,body],[[wing,B,1]],{family:255668557,heartbeatMaterial:true,expectedRecipient:[255668557],op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find(255668557,LOCATION_GRAVE)))'});
 add('Heartbeat detached material no longer grants response',[[220124524,G],[body,F],[helper,H],[dark,F,1]],[helper],[[dark,F,1]],{family:220124524,heartbeatMaterial:true,monsterActivation:true,rewrite:true,noRewrite:true,yes:true,expectedRecipient:[],op:'local mc=find(220124524,LOCATION_GRAVE) Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(mc)) Duel.SendtoGrave(mc,REASON_COST)'});
 for(const mode of ['wrong-host','detached'])add('Joyous material '+mode,[[255668557,G],[body,F],[helper,H],[wing,G,1]],[helper],[[wing,G,1]],{family:255668557,heartbeatMaterial:true,wrongBrigadeHost:mode==='wrong-host',forbidden:body,expectedRecipient:mode==='detached'?[]:[255668557],op:'local mc=find(255668557,LOCATION_GRAVE) Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(mc)) '+(mode==='detached'?'Duel.SendtoGrave(mc,REASON_COST)':'')});
 add('Heartbeat native Xyz material grants response',[[220124524,F],[wing,F],[body,E],[dark,F,1]],[body],[[dark,B,1]],{family:220124524,heartbeatMaterial:true,materialNative:true,standardXyz:true,monsterActivation:true,rewrite:true,noRewrite:true,yes:true,pick:220124524,expectedRecipient:[wing]});
 for(const ct of [0,1,2])add('Armada destroyed revives up to opponent card count '+ct,[[223750159,F],[body,G],[wing,B],[helper,H],...(ct>0?[[dark,F,1]]:[]),...(ct>1?[[spell,T,1]]:[])],[helper],[[223750159,G],...(ct>0?[[body,F]]:[[body,G]]),...(ct>1?[[wing,F]]:[[wing,B]])],{family:223750159,armadaRevive:true,armadaCount:ct,expectedFamilyUses:1,selectMax:true,op:'Duel.Destroy(find(223750159,LOCATION_MZONE),REASON_EFFECT)'});
 for(const mode of ['normal','immune','expiry'])add('Revenge Division doubles stats '+mode,[[236616849,F],[body,F],[spell,G],[trap,G],[helper,H]],[helper,236616849],[],{family:236616849,revengeStats:mode,statExpiry:mode==='expiry',immuneOrbHost:true,op:'Duel.Overlay(find(236616849,LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE),find('+trap+',LOCATION_GRAVE))) '+(mode==='immune'?'local host=find('+body+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) host:RegisterEffect(ex)':'')});
 for(const mode of ['normal','one-target','wrong-level','prior-non-brigade']){
 const prior=mode==='prior-non-brigade',ok=mode==='normal';
 add('Hope Division two-monster summon '+mode,[[243194249,F],[body,D],[wing,mode==='one-target'?G:D],...(prior?[[helper,H],[fusion,H]]:[])],ok?[243194249]:prior?[helper]:[],ok?[[243194249,G],[body,F],[wing,F]]:[[243194249,F],[body,D]],{family:243194249,hopeProbe:mode,forbidden:ok?body:243194249,expectedFamilyUses:ok?1:0,op:prior?'Duel.SpecialSummon(find('+fusion+',LOCATION_HAND),0,tp,tp,false,false,POS_FACEUP)':''});
 }
 add('Hope Division needs two legal monsters at resolution',[[243194249,F],[body,D],[wing,D],[dark,F,1]],[243194249],[[243194249,G],[body,D],[wing,G]],{family:243194249,hopeProbe:'lost-target',hopeDeckRemoval:true,expectedFamilyUses:1});
 for(const lost of [false,true])add('Shrieker exact-two summon '+(lost?'lost target':'baseline'),[[259664027,F],[body,D],[wing,D],...(lost?[[dark,F,1]]:[])],[259664027],[[259664027,G],[body,lost?D:F],[wing,lost?G:F]],{family:259664027,hopeProbe:'shrieker',hopeDeckRemoval:lost,expectedFamilyUses:1});
 for(const n of [0,1,2])add('Last Stand recycling Brigade count '+n,[[249629457,T],[body,G],[wing,B],[spell,G]],[],[],{family:249629457,lastStandEnd:n+1,statExpiry:true,selectMax:true,expectedFamilyUses:1,expectedHandCount:n>=2?1:0});
 for(const mode of ['spell','field-monster','grave-monster'])add('Last Stand negate '+mode,[[249629457,T],[body,F],[dark,mode==='spell'?H:mode==='field-monster'?F:G,1]],[],[[body,mode==='grave-monster'?F:H]],{family:249629457,lastStandNeg:mode,rewrite:true,noRewrite:mode==='grave-monster',monsterActivation:mode==='field-monster',graveActivation:mode==='grave-monster',opponentOp:'Duel.Recover(tp,500,REASON_EFFECT)'});
 for(const mode of ['faceup','facedown','wrong-set'])add('Stand Together protection '+mode,[[standTogether,T],[body,F],[wing,F],[helper,H]],[helper],[[standTogether,mode==='faceup'?T:G]],{family:standTogether,standProtect:mode,op:(mode==='facedown'?'Duel.ChangePosition(find('+wing+',LOCATION_MZONE),POS_FACEDOWN_DEFENSE) ':'')+'Duel.Destroy(find('+standTogether+',LOCATION_SZONE),REASON_EFFECT)'});
 for(const mode of ['faceup','facedown','wrong-set']){
 add('Aurelia summon requires faceup archetype '+mode,[[238035167,H],[body,F],[helper,H]],[helper],[],{family:238035167,aureliaCondition:mode,specialAvailability:mode==='faceup',op:mode==='facedown'?'Duel.ChangePosition(find('+body+',LOCATION_MZONE),POS_FACEDOWN_DEFENSE)':''});
 const original=testCases.find(t=>t.name==='Stand Together protection '+mode);
 testCases.push({...original,name:'Stand Together banish protection '+mode,expected:[[standTogether,mode==='faceup'?T:B]],op:original.op.replace('Duel.Destroy(find('+standTogether+',LOCATION_SZONE),REASON_EFFECT)','Duel.Remove(find('+standTogether+',LOCATION_SZONE),POS_FACEUP,REASON_EFFECT)')});
 }
 for(const mode of ['faceup','facedown','wrong-set','grave'])add('Argalia support condition '+mode,[[259748623,H],[body,mode==='grave'?G:F],[helper,H]],[helper],[],{family:259748623,argaliaCondition:mode,specialAvailability:['faceup','grave'].includes(mode),op:mode==='facedown'?'Duel.ChangePosition(find('+body+',LOCATION_MZONE),POS_FACEDOWN_DEFENSE)':''});
 for(const mode of ['faceup','facedown','wrong-set']){
 add('DDJ hand summon condition '+mode,[[238273769,H],[body,F],[helper,H]],[helper],[],{family:238273769,ddjCondition:mode,activationDescription:132273769*16+3,activationAvailable:mode==='faceup',op:mode==='facedown'?'Duel.ChangePosition(find('+body+',LOCATION_MZONE),POS_FACEDOWN_DEFENSE)':''});
 add('Axis column condition '+mode,[[256831125,H],[body,F],[dark,F,1],[helper,H]],[helper],[],{family:256831125,axisCondition:mode,op:'Duel.MoveToField(find(256831125,LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true) Duel.MoveSequence(find('+body+',LOCATION_MZONE),4) '+(mode==='facedown'?'Duel.ChangePosition(find('+body+',LOCATION_MZONE),POS_FACEDOWN_DEFENSE)':'')});
 }
 for(const mode of ['hand','grave','wrong-set','self-only']){
 const valid=['hand','grave'].includes(mode),loc=mode==='hand'||mode==='wrong-set'?H:G;
 add('Loving Division self summon '+mode,[[230812008,loc],...(mode==='self-only'?[]:[[body,G]])],valid?[230812008]:[],[[230812008,valid?F:loc],...(mode==='self-only'?[]:[[body,valid?B:G]])],{family:230812008,lovingSummon:mode,forbidden:valid?undefined:230812008,expectedFamilyUses:valid?1:0});
 }
 for(const loc of [D,G,B])add('Loving material sets activatable Trap from '+loc,[[230812008,G],[body,F],[trap,loc],[helper,H]],[helper,body,trap],[[trap,G]],{family:230812008,lovingMaterial:true,heartbeatMaterial:true,expectedRecipient:[230812008],op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find(230812008,LOCATION_GRAVE)))'});
 for(const mode of ['grave','banished','facedown','wrong-host']){
 const valid=['grave','banished'].includes(mode),loc=mode==='banished'?B:G;
 add('Flowering inherited recovery '+mode,[[232100722,G],[body,F],[wing,loc],[helper,H]],valid?[helper,body]:[helper],[[wing,valid?H:mode==='facedown'?B:G]],{family:232100722,floweringRecovery:true,heartbeatMaterial:true,wrongBrigadeHost:mode==='wrong-host',forbidden:body,expectedRecipient:[232100722],op:(mode==='facedown'?'Duel.Remove(find('+wing+',LOCATION_GRAVE),POS_FACEDOWN,REASON_EFFECT) ':'')+'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find(232100722,LOCATION_GRAVE)))'});
 }
 for(const loc of [G,B])add('Flowering native hand summon cost '+loc,[[232100722,H],[wing,loc]],[232100722],[[232100722,F],[wing,D]],{family:232100722,floweringRecovery:true,procedureSource:true});
 add('Flowering summon rejects facedown banished cost',[[232100722,H],[wing,G],[helper,H]],[helper],[[232100722,H],[wing,B]],{family:232100722,floweringRecovery:true,specialAvailability:false,op:'Duel.Remove(find('+wing+',LOCATION_GRAVE),POS_FACEDOWN,REASON_EFFECT)'});
 for(const mode of ['attached','wrong-host','detached','monster-first'])add('Forward inherited first Spell negation '+mode,[[232038002,G],[body,F],[helper,H],[dark,mode==='monster-first'?F:H,1],[spell,H,1]],[helper],[],{family:232038002,forwardMaterial:mode,monsterActivation:mode==='monster-first',heartbeatMaterial:true,wrongBrigadeHost:mode==='wrong-host',rewrite:true,noRewrite:true,opponentOp:'Duel.Recover(tp,500,REASON_EFFECT)',op:'local mc=find(232038002,LOCATION_GRAVE) Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(mc)) '+(mode==='detached'?'Duel.SendtoGrave(mc,REASON_COST)':'')});
 for(const mode of ['summon','controlled-monster','grave-search'])add('Lets Go Brigade '+mode,[[238841732,mode==='grave-search'?G:H],[body,D],[spell,D],...(mode==='controlled-monster'?[[wing,F]]:[]),...(mode==='grave-search'?[[238841732,H]]:[])],mode==='controlled-monster'?[]:[238841732],mode==='summon'?[[body,F],[238841732,G]]:mode==='grave-search'?[[spell,H],[238841732,B]]:[[body,D]],{family:238841732,letsGo:mode,activationLocation:mode==='grave-search'?G:undefined,forbidden:238841732,expectedFamilyUses:mode==='controlled-monster'?0:1});
 for(const light of [false,true])add('Lets Go prior summon LIGHT restriction '+light,[[238841732,H],[body,D],[fusion,H],[helper,H]],light?[helper,238841732]:[helper],[[body,light?F:D]],{family:238841732,letsGo:'prior',priorLight:light,forbidden:238841732,expectedFamilyUses:light?1:0,op:'local c=find('+fusion+',LOCATION_HAND) Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) Duel.SendtoGrave(c,REASON_EFFECT)'});
 add('Lets Go applies LIGHT summon lock',[[238841732,H],[body,D],[wing,H],[fusion,H],[helper,H]],[238841732,helper],[[body,F]],{family:238841732,letsGo:'lock',forbidden:238841732,expectedFamilyUses:1,op:'assert(not find('+fusion+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"DARK summon must be blocked") assert(find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"LIGHT summon remains legal")'});
 for(const mode of ['one-copy','two-copies','wrong-set'])add('Melody extra Normal Summon '+mode,[[melody,F],...(mode==='two-copies'?[[melody,F]]:[]),[body,H],[wing,H],[fusion,H]],mode==='wrong-set'?[-body]:[-body,-wing],[[body,F],[wing,mode==='wrong-set'?H:F],[fusion,H]],{family:melody,melodySummons:mode,forbiddenSummon:mode==='wrong-set'?wing:fusion});
 for(const setFirst of [false,true])add('Melody shared summon-set allowance '+setFirst,[[melody,F],[body,H],[wing,H],[fusion,H]],[-body,-wing],[[body,F],[wing,F],[fusion,H]],{family:melody,melodySummons:'mixed',setMonsterCodes:[setFirst?body:wing],forbiddenSummon:fusion});
 for(const mode of ['faceup','facedown','wrong-set'])add('Companion Team targeting protection '+mode,[[232824319,F],[body,F],[wing,F],[helper,H],[dark,H,1]],[helper],[],{family:232824319,companionProtect:mode,rewrite:true,noRewrite:true,op:mode==='facedown'?'Duel.ChangePosition(find('+body+',LOCATION_MZONE),POS_FACEDOWN_DEFENSE)':''});
 add('Companion Team summons on opponent attack',[[232824319,F],[body,F],[wing,D],[dark,F,1]],[],[[232824319,F],[wing,F]],{family:232824319,companionAttack:true,battle:true,pick:wing,expectedFamilyUses:1});
 for(const mode of ['spell','monster','return'])add('Absolute Supremacy negate '+mode,[[241504188,F],[dark,mode==='monster'?F:H,1],[dark,G,1],[dark,G,1]],[],[[241504188,mode==='return'?F:B]],{family:241504188,supremacyNeg:true,supremacyReturn:mode==='return',monsterActivation:mode==='monster',rewrite:true,opponentOp:'Duel.Recover(tp,500,REASON_EFFECT)'});
 for(const mode of ['normal','indestructible','one-material'])add('Origins destroy then banish '+mode,[[244986323,F],[body,G],[spell,G],[trap,G],[wing,F,1],[helper,H]],mode==='one-material'?[helper]:[helper,244986323],[[wing,mode==='normal'?G:F,1],[body,mode==='normal'?B:G]],{family:244986323,originsDes:mode,immuneOrbHost:true,forbidden:mode==='one-material'?244986323:undefined,pick:body,op:'Duel.Overlay(find(244986323,LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)'+(mode==='one-material'?'':',find('+trap+',LOCATION_GRAVE)')+')) '+(mode==='indestructible'?'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+wing+') local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_INDESTRUCTABLE_EFFECT) ex:SetValue(1) c:RegisterEffect(ex)':'')});
 for(const tribute of [false,true])add('Origins Pendulum placement '+(tribute?'Tribute':'destroyed'),[[244986323,F],[helper,H]],[helper],[[244986323,T]],{family:244986323,originsPendulum:true,expectedFamilyUses:1,op:'Duel.'+(tribute?'Release':'Destroy')+'(find(244986323,LOCATION_MZONE),'+(tribute?'REASON_COST':'REASON_EFFECT')+')'});
 for(const mode of ['opponent-grave','own-grave','immune','summoned','spell-target']){
 const attach=!['own-grave','immune'].includes(mode);
 add('Origins attachment trigger '+mode,[[244986323,mode==='summoned'?G:F],[body,F,mode==='own-grave'?0:1],[wing,mode==='spell-target'?T:F,1],[helper,H]],[helper],attach?[]:[[wing,F,1]],{family:244986323,originsAttach:mode,pick:wing,expectedFamilyUses:mode==='own-grave'?0:1,verifyOverlay:attach,overlayHost:244986323,overlayMaterial:wing,blockedRecipient:attach?undefined:244986323,op:(mode==='immune'?'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+wing+') local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_IMMUNE_EFFECT) ex:SetValue(function() return true end) tc:RegisterEffect(ex) ':'')+(mode==='summoned'?'local c=find(244986323,LOCATION_GRAVE) c:CompleteProcedure() Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)':'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,'+(mode==='own-grave'?'LOCATION_MZONE,0':'0,LOCATION_MZONE')+',nil,'+body+') Duel.SendtoGrave(c,REASON_EFFECT)')});
 }
 for(const code of [220124524,232038002])for(const prior of [false,true])add('Brigade summon trigger '+code+' prior outsider '+prior,[[code,H],[body,H],[spell,D],[wing,H],[fusion,H],[helper,H]],prior?[helper,-code]:[-code,helper],[[body,!prior&&code===220124524?F:H],[spell,!prior&&code===232038002?H:D]],{family:code,brigadeOnSummon:true,expectedFamilyUses:prior?0:1,op:prior?'local c=find('+wing+',LOCATION_HAND) Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) Duel.SendtoGrave(c,REASON_EFFECT)':'assert(not find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Outsider summon blocked") assert(find('+fusion+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Brigade summon allowed")'});
 for(const code of [220124524,232038002])for(const prior of [false,true]){
 const original=testCases.find(t=>t.name==='Brigade summon trigger '+code+' prior outsider '+prior);
 testCases.push({...original,name:'Brigade Special Summon trigger '+code+' prior outsider '+prior,steps:[helper],op:(prior?'local c=find('+wing+',LOCATION_HAND) Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) Duel.SendtoGrave(c,REASON_EFFECT) ':'')+'Duel.SpecialSummon(find('+code+',LOCATION_HAND),0,tp,tp,false,false,POS_FACEUP)'});
 }
 for(const mode of ['grave','banished','facedown','wrong-set','opponent','missed-timing']){
 const valid=!['facedown','wrong-set','missed-timing'].includes(mode);
 add('Joyous revival trigger '+mode,[[255668557,mode==='banished'?B:G],[body,H],[helper,H]],[helper],[[255668557,valid?F:mode==='facedown'?B:G]],{family:255668557,joyousRevive:mode,expectedFamilyUses:valid?1:0,op:(mode==='facedown'?'Duel.Remove(find(255668557,LOCATION_GRAVE),POS_FACEDOWN,REASON_EFFECT) ':'')+'Duel.SpecialSummon(find('+body+',LOCATION_HAND),0,tp,'+(mode==='opponent'?'1-tp':'tp')+',false,false,POS_FACEUP) '+(mode==='missed-timing'?'Duel.BreakEffect() Duel.Draw(tp,1,REASON_EFFECT)':'')});
 }
 for(const mode of ['opponent','own','wrong-set','empty-field'])add('Revenge revival and highest ATK damage '+mode,[[236616849,G],[body,F],...(mode==='empty-field'?[]:[[wing,F,1],[fusion,F,1]]),[helper,H],...(mode==='own'?[]:[[dark,H,1]])],[helper],[[236616849,['opponent','empty-field'].includes(mode)?F:G]],{family:236616849,revengeRevive:mode,rewrite:mode!=='own',noRewrite:mode==='wrong-set',expectedFamilyUses:['opponent','empty-field'].includes(mode)?1:0,op:'find(236616849,LOCATION_GRAVE):CompleteProcedure() '+(mode==='own'?'Duel.Destroy(find('+body+',LOCATION_MZONE),REASON_EFFECT)':''),opponentOp:'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+body+') Duel.Destroy(c,REASON_EFFECT)'});
 for(const mode of ['battle','battle-wrong-set','battle-facedown'])add('Revenge revival after '+mode,[[236616849,G],[body,F],[helper,H],[dark,F,1]],[helper],[[236616849,mode==='battle-wrong-set'?G:F],[body,G]],{family:236616849,revengeRevive:mode,battle:true,pick:body,expectedFamilyUses:mode==='battle-wrong-set'?0:1,op:'find(236616849,LOCATION_GRAVE):CompleteProcedure() '+(mode==='battle-facedown'?'Duel.ChangePosition(find('+body+',LOCATION_MZONE),POS_FACEDOWN_DEFENSE)':'')});
 for(const mode of ['monster','spell','wrong-set','own-only'])add('Revenge Standby attachment '+mode,[[236616849,F],[wing,D],...(mode==='own-only'?[[wing,D]]:[])],[],mode==='wrong-set'?[[wing,D]]:[],{family:236616849,revengeStandby:mode,statExpiry:mode==='own-only',pick:wing,expectedFamilyUses:1,verifyOverlay:mode!=='wrong-set',overlayHost:236616849,overlayMaterial:wing,blockedRecipient:mode==='wrong-set'?236616849:undefined});
 for(const code of [223750159,236616849,244986323])for(const mode of ['legal','wrong-level','wrong-set']){
 const mats=code===244986323?[body,wing,fusion]:[body,wing];
 add('Brigade native Xyz recipe '+code+' '+mode,[[code,E],...mats.map(c=>[c,F])],mode==='legal'?[code]:[],mode==='legal'?[[code,F]]:[[code,E]],{family:code,brigadeXyz:mode,recipeMaterials:mats,standardXyz:true,specialAvailability:mode==='legal'?undefined:false});
 }
 for(const code of [232824319,241504188])for(const mode of ['legal','wrong-set','link-material']){
 const mats=code===232824319?[body]:[body,wing,fusion,spell],valid=mode==='legal'||mode==='link-material'&&code===241504188;
 add('Brigade native Link recipe '+code+' '+mode,[[code,E],...mats.map(c=>[c,F])],valid?[code]:[],[[code,valid?F:E]],{family:code,brigadeLink:mode,recipeMaterials:mats,recipeLegal:valid,specialAvailability:valid?undefined:false});
 }
 for(const materials of [0,1])add('Armada draw detach cost '+materials,[[223750159,F],[spell,G],[helper,H]],materials?[helper,223750159]:[helper],[],{family:223750159,armadaDraw:true,immuneOrbHost:true,forbidden:223750159,expectedHandCount:materials,expectedFamilyUses:materials,op:materials?'Duel.Overlay(find(223750159,LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)))':''});
 for(const loc of [H,G])for(const opponent of [false,true])add('Hope own summon location '+loc+' opponent '+opponent,[[243194249,loc],...(opponent?[[body,F,1]]:[])],opponent?[243194249]:[],[[243194249,opponent?F:loc]],{family:243194249,procedureSource:true,specialAvailability:opponent?undefined:false});
 for(const valid of [false,true])add('Brigade Field Spell activation search '+valid,[[238976759,H],[body,D]],[238976759],[[238976759,L.FZONE],[body,valid?H:D]],{family:238976759,brigadeFieldSearch:valid,yes:true,expectedFamilyUses:1,expectedHandCount:valid?1:0});
 add('Stand Together rejects recipient that left and returned',[[standTogether,T],[body,F],[spell,G],[wing,G],[helper,H],[dark,F,1]],[helper,standTogether],[[wing,G]],{family:standTogether,standReset:true,standProbe:true,immuneOrbHost:true,expectedRecipient:[],pick:wing,op:'local c=find('+body+',LOCATION_MZONE) c:CompleteProcedure() Duel.Overlay(c,Group.FromCards(find('+spell+',LOCATION_GRAVE)))'});
 for(const reset of [false,true])add('Hexatron stored counter monster '+(reset?'left-returned':'baseline'),[[259253032,F],[wing,F],[body,F,1],[36211150,G],[helper,H],...(reset?[[dark,F,1]]:[])],[helper,259253032],[[wing,G]],{family:259253032,hexatronIdentity:true,standReset:reset,immuneOrbHost:true,pick:wing,op:'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+body+') c:AddCounter(0x1994,2)'});
 for(const reset of [false,true])add('Silia stored GY recovery '+(reset?'left-returned':'baseline'),[[244408495,H],[body,D],[wing,H],[helper,H],...(reset?[[dark,F,1]]:[])],[helper],[[body,reset?G:H]],{family:244408495,siliaIdentity:true,standReset:reset,expectedFamilyUses:1,pick:body,op:'Duel.SendtoGrave(find(244408495,LOCATION_HAND),REASON_EFFECT)'});
 for(const missing of ['discard','deck-card'])add('Silia recovery requires '+missing,[[244408495,H],[helper,H],...(missing==='discard'?[[body,D]]:[[wing,H]])],[helper],[[244408495,G]],{family:244408495,siliaIdentity:true,expectedFamilyUses:0,op:'Duel.SendtoGrave(find(244408495,LOCATION_HAND),REASON_EFFECT)'});
 for(const reset of [false,true])add('Bhodi stored Tribute equip '+(reset?'left-returned':'baseline'),[[259072745,F],[wing,F],[dark,F,1],...(reset?[[trap,F,1]]:[])],[],[[wing,reset?G:T]],{family:259072745,bhodiIdentity:true,bhodiReset:reset,rewrite:true,monsterActivation:true,pick:wing});
 add('Bhodi equips Tribute redirected to banishment',[[259072745,F],[wing,F],[dark,F,1],[helper,H]],[helper],[[wing,T]],{family:259072745,bhodiIdentity:true,rewrite:true,monsterActivation:true,pick:wing,op:'local c=find('+wing+',LOCATION_MZONE) local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_TO_GRAVE_REDIRECT) ex:SetValue(LOCATION_REMOVED) c:RegisterEffect(ex)'});
 for(const mode of ['own','opponent','wrong-set'])add('Supremacy battle protection '+mode,[[241504188,F,mode==='opponent'?1:0],[body,F],[dark,F,1]],[],[[body,mode==='wrong-set'?G:F]],{family:241504188,supremacyBattle:mode,battle:true,pick:body,expectedFamilyUses:0});
 for(const mode of ['own','opponent','wrong-set']){
 const t=testCases.find(t=>t.name==='Supremacy battle protection '+mode);
 testCases.push({...t,name:'Yummy global battle protection '+mode,family:253152295,yummyGlobal:true,setup:t.setup.map(([code,...rest])=>[code===241504188?253152295:code,...rest])});
 }
 for(const mode of ['spell','trap','monster','wrong-set'])add('Origins Pendulum targeting protection '+mode,[[244986323,F],[body,F],[wing,F],[helper,H],[dark,mode==='monster'?F:H,1]],[helper],[],{family:244986323,originsProtect:mode,rewrite:true,noRewrite:true,monsterActivation:mode==='monster',op:'Duel.MoveToField(find(244986323,LOCATION_MZONE),tp,tp,LOCATION_PZONE,POS_FACEUP,true)'});
 for(const mode of ['no-material','no-attach-card'])add('Stand Together cost resource boundary '+mode,[[standTogether,T],[body,F],[spell,G],...(mode==='no-material'?[[wing,G]]:[]),[helper,H]],[helper],[],{family:standTogether,standProbe:true,forbidden:standTogether,expectedFamilyUses:0,op:mode==='no-attach-card'?'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)))':''});
 add('Hope both summon restrictions expire after End Phase',[[243194249,F],[body,D],[wing,D],[spell,G],[helper,H]],[243194249,helper],[[body,F],[wing,F],[spell,H]],{family:243194249,hopeProbe:'normal',statExpiry:true,expectedFamilyUses:1,op:'for _,code in ipairs({'+body+','+wing+'}) do local c=find(code,LOCATION_MZONE) assert(c:IsHasEffect(EFFECT_CANNOT_ATTACK),"Attack restriction present") assert(c:IsHasEffect(EFFECT_CANNOT_TRIGGER),"Activation restriction present") end local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) ex:SetCode(EVENT_PREDRAW) ex:SetCountLimit(1) ex:SetOperation(function() for _,code in ipairs({'+body+','+wing+'}) do local c=find(code,LOCATION_MZONE) assert(not c:IsHasEffect(EFFECT_CANNOT_ATTACK),"Attack restriction expired") assert(not c:IsHasEffect(EFFECT_CANNOT_TRIGGER),"Activation restriction expired") end Duel.SendtoHand(find('+spell+',LOCATION_GRAVE),nil,REASON_EFFECT) end) Duel.RegisterEffect(ex,tp)'});
 add('Companion attack targeting without Brigade support',[[232824319,F],[body,F],[dark,F,1]],[],[[232824319,F],[body,G]],{family:232824319,companionUnprotectedBattle:true,battle:true,pick:body});
 add('Companion Team unique control restriction',[[232824319,F],[232824319,E],[helper,H]],[helper],[[232824319,F],[232824319,E]],{family:232824319,linkApiOnly:true,specialAvailability:false,expectedFamilyUses:0,op:'local c=find(232824319,LOCATION_EXTRA) c:CompleteProcedure() assert(not c:IsCanBeSpecialSummoned(e,0,tp,false,false),"Second Companion cannot be summoned")'});
 add('Origins cannot occupy full Pendulum Zones',[[244986323,F],[body,H],[wing,H],[helper,H]],[helper],[[244986323,E],[body,T],[wing,T]],{family:244986323,originsFullPendulum:true,expectedFamilyUses:0,op:'Duel.MoveSequence(e:GetHandler(),2) Duel.MoveToField(find('+body+',LOCATION_HAND),tp,tp,LOCATION_PZONE,POS_FACEUP,true) Duel.MoveToField(find('+wing+',LOCATION_HAND),tp,tp,LOCATION_PZONE,POS_FACEUP,true) assert(not Duel.CheckLocation(tp,LOCATION_PZONE,0),"Left occupied") assert(not Duel.CheckLocation(tp,LOCATION_PZONE,1),"Right occupied") Duel.Destroy(find(244986323,LOCATION_MZONE),REASON_EFFECT)'});
 for(const battle of [false,true])for(const material of ['nautica','control','detached']){
  const family=238711686;
  const melissa='find('+family+',LOCATION_MZONE)';
  const attach='local xyz='+melissa+' local mc=find('+body+',LOCATION_GRAVE) Duel.Overlay(xyz,Group.FromCards(mc)) assert(xyz:GetOverlayCount()==1)';
  const detach=material==='detached'?' xyz:RemoveOverlayCard(tp,1,1,REASON_COST) assert(xyz:GetOverlayCount()==0)':'';
  const destruction=battle?'':' Duel.Destroy('+melissa+',REASON_EFFECT)';
  add('Melissa '+(battle?'battle':'effect')+' destruction with '+material+' material',
   [[family,F],[body,G],[helper,H],...(battle?[[dark,F,1]]:[])],[helper],[[family,material==='nautica'?F:G]],
   {family,melissaProtection:material,battle,op:attach+detach+destruction});
 }
 for(const mode of ['two','three','one','wrong-level','wrong-race']){
  const family=238711686;
  const materials=mode==='three'?[body,wing,dark]:mode==='one'?[body]:[body,wing];
  const legal=mode==='two'||mode==='three';
  add('Melissa Xyz recipe '+mode,[[family,E],...materials.map(code=>[code,F])],legal?[family]:[],
   [[family,legal?F:E]],{family,levelOneXyzRecipe:mode,standardXyz:true,recipeMaterials:materials,
    selectMax:mode==='three',specialAvailability:legal?undefined:false});
 }
 for(const mode of ['set-spell','set-trap','choose-set','choose-add','one-material','wrong-set']){
  const family=238711686;
  const materials=mode==='one-material'?[wing]:[wing,link,dark];
  const both=mode.startsWith('choose');
  const addMonster=mode==='choose-add';
  const legal=!['one-material','wrong-set'].includes(mode);
  const setCard=mode==='set-trap'?trap:spell;
  const candidates=both?[setCard,body]:[setCard];
  const op='Duel.Overlay(find('+family+',LOCATION_MZONE),Group.FromCards('+
   materials.map(code=>'find('+code+',LOCATION_GRAVE)').join(',')+'))';
  add('Melissa Quick Effect '+mode,[[family,F],[helper,H],...materials.map(code=>[code,G]),...candidates.map(code=>[code,D])],
   legal?[helper,family]:[helper],candidates.map(code=>[code,legal&&code===(addMonster?body:setCard)?(addMonster?H:T):D]),
   {family,melissaQuick:mode,op,option:Number(addMonster),options:both?2:undefined,forbidden:legal?undefined:family,
    pick:addMonster?body:setCard,expectedFamilyUses:Number(legal),melissaRemaining:materials.length-2*Number(legal)});
 }
 for(const mode of ['full-normal','full-field','full-add']){
  const family=238711686;
  const legal=mode!=='full-normal';
  const setCard=mode==='full-field'?trap:spell;
  const candidates=mode==='full-add'?[setCard,body]:[setCard];
  const op='Duel.Overlay(find('+family+',LOCATION_MZONE),Group.FromCards(find('+wing+',LOCATION_GRAVE),find('+dark+',LOCATION_GRAVE))) '+
   'Duel.SendtoGrave(e:GetHandler(),REASON_EFFECT) assert(Duel.MoveToField(find('+fusion+',LOCATION_GRAVE),tp,tp,LOCATION_SZONE,POS_FACEDOWN,true))';
  add('Melissa Quick Effect '+mode,[[family,F],[helper,H],[wing,G],[dark,G],[fusion,G],
   ...Array.from({length:4},()=>[link,T]),...candidates.map(code=>[code,D])],
   legal?[helper,family]:[helper],mode==='full-field'?[[setCard,L.FZONE]]:mode==='full-add'?[[setCard,D],[body,H]]:[[setCard,D]],
   {family,melissaQuick:mode,op,pick:mode==='full-add'?body:setCard,
    forbidden:legal?undefined:family,expectedFamilyUses:Number(legal),melissaRemaining:legal?0:2});
 }
 {
  const family=238711686;
  const materials=[wing,link,trap,fusion];
  const op='Duel.Overlay(find('+family+',LOCATION_MZONE),Group.FromCards('+
   materials.map(code=>'find('+code+',LOCATION_GRAVE)').join(',')+'))';
  add('Melissa Quick Effect is limited on its turn and resets on the opponent turn',
   [[family,F],[helper,H],[dark,H,1],[body,D],[body,D],...materials.map(code=>[code,G])],
   [helper,family],[[body,H]],{family,melissaQuick:'turn-limit',melissaTurn:true,rewrite:true,noRewrite:true,
    op,pick:body,opponentOp:'Duel.Recover(tp,100,REASON_EFFECT)',expectedFamilyUses:2,melissaRemaining:0});
 }
 for(const mode of ['prior-water','prior-nonwater','after','expiry','count']){
  const family=248946297;
  const prior=mode.startsWith('prior');
  const count=mode==='count';
  const legal=mode!=='prior-nonwater';
  const expiry=mode==='expiry';
  const water='Duel.SpecialSummon(find('+trap+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)';
  const nonwater='Duel.SpecialSummon(find('+dark+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)';
  const op=prior?'assert('+(legal?water:nonwater)+'==1)':mode==='after'?'assert('+water+'==1) assert('+nonwater+'==0)':expiry?'assert('+nonwater+'==1)':'';
  add('Exploring WATER restriction and activation '+mode,
   [[family,H],[body,D],[wing,D,1],...(count?[[family,H],[body,D],[wing,D,1]]:[[helper,H],[trap,G],[dark,G]])],
   count?[family,family]:prior?(legal?[helper,family]:[helper]):[family,helper],
   count?[[body,H],[wing,F,1]]:[[body,legal?H:D],[wing,legal?F:D,1],[trap,legal&&!expiry?F:G],[dark,legal&&!expiry?G:F]],
   {family,exploringBoundary:mode,op,forbidden:legal?undefined:family,expectedFamilyUses:count?2:Number(legal),option:0,pick:wing});
 }
 for(const mode of ['two-aqua','wrong-race','cannot-draw','trap-first','grave-first']){
  const family=223158720;
  const shared=mode.endsWith('first');
  const aquas=mode==='two-aqua'?[wing,spell]:[wing,spell,trap];
  const drawBlocked=mode==='cannot-draw';
  const extraCopies=mode==='trap-first'?[[family,T]]:mode==='grave-first'?[[family,G]]:[];
  const op=drawBlocked?'local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD) ex:SetCode(EFFECT_CANNOT_DRAW) ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET) ex:SetTargetRange(1,0) Duel.RegisterEffect(ex,tp)':'';
  add('Backwashing recycle '+mode,
   [[family,G],...aquas.map(code=>[code,G]),...(shared?[[family,T],[body,G],[dark,H,1],[fusion,G],...extraCopies]:[]),...(drawBlocked?[[helper,H]]:[])],
   shared?[family,family]:drawBlocked?[helper]:[],shared?[[family,B],[body,H],[dark,F,1]]:[[family,G],...aquas.map(code=>[code,G])],
   {family,backwashingBoundary:mode,backwashingShared:shared,setSourceSpell:true,
    forbidden:shared?undefined:family,pick:body,sequentialActions:true,op});
 }
 for(const mode of ['wrong-target','opponent-grave','no-opponent-hand']){
  const family=223158720;
  const owner=Number(mode==='opponent-grave');
  add('Backwashing return '+mode,
   [[family,T],[body,G,owner],...(mode==='no-opponent-hand'?[]:[[dark,H,1]])],
   [],[[family,T],[body,G,owner]],{family,backwashingBoundary:mode,setSourceSpell:true,forbidden:family});
 }
 for(const mode of ['normal','special','counter','upper','wrong-level','wrong-race','wrong-rank','wrong-set','opponent-material']){
  const family=227043533,recipient=231825514;
  const counter=mode==='counter';
  const upper=mode==='upper';
  const legal=mode==='normal'||mode==='special'||counter||upper;
  const special=mode==='special';
  add('Lokaeo instructed Xyz Summon '+mode,
   [[family,special?G:H],[recipient,E],[body,F,Number(mode==='opponent-material')],...(special?[[helper,H]]:[]),...(counter||upper?[[spell,T,1]]:[]),...(upper?[[dark,F,1]]:[])],
   special?[helper]:[-family],
   [[recipient,counter?G:legal?F:E],...(legal?[]:[[family,F],[body,F,Number(mode==='opponent-material')]])],
   {family,lokaeoXyz:mode,standardXyz:true,pick:recipient,expectedFamilyUses:Number(legal),
    op:special?'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)':undefined});
 }
 for(const mode of ['grave','banished','redirect','wrong-set','wrong-type','facedown','revive','decline-revive']){
  const family=227043533;
  const legal=!['wrong-set','wrong-type','facedown'].includes(mode);
  const standby=mode==='revive'||mode==='decline-revive';
  const origin=['banished','facedown'].includes(mode)?B:G;
  const target=mode==='facedown'?trap:body;
  const start=mode==='banished'?F:H;
  add('Lokaeo recycle '+mode,[[family,start],[target,origin],[dark,H,1]],[],
   [[family,mode==='revive'?F:legal?B:start],...(!legal||mode==='redirect'?[[target,legal?B:origin]]:[])],
   {family,lokaeoRecycle:mode,lokaeoStandby:standby,rewrite:true,noRewrite:!legal,pick:target,
    banishedTrapFacedown:mode==='facedown',expectedFamilyUses:Number(legal)+Number(mode==='revive')});
 }
 for(const [mode,origin,faceDown] of [['external-grave',G,false],['external-field',F,false],['external-facedown',G,true]]){
  const family=227043533;
  add('Lokaeo revive '+mode,[[family,origin],[helper,H]],[helper],[[family,faceDown?B:F]],
   {family,lokaeoRecycle:mode,lokaeoExternal:true,lokaeoRevivalTurn:2,lokaeoExpectedOffers:Number(!faceDown),
    lokaeoAcceptRevival:!faceDown,noRewrite:true,expectedFamilyUses:Number(!faceDown),
    op:'assert(Duel.Remove(find('+family+','+(origin===G?'LOCATION_GRAVE':'LOCATION_MZONE')+'),'+
     (faceDown?'POS_FACEDOWN':'POS_FACEUP')+',REASON_EFFECT)==1)'});
 }
 {
  const family=227043533,recipient=231825514;
  const reviveBoth='assert(Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+family+'),POS_FACEUP,REASON_EFFECT)==2)';
  add('Lokaeo revival limit across copies',[[family,G],[family,G],[helper,H]],[helper],[[family,F],[family,B]],
   {family,lokaeoRecycle:'revival-limit',lokaeoExternal:true,lokaeoRevivalTurn:2,lokaeoExpectedOffers:1,
    lokaeoAcceptRevival:true,noRewrite:true,expectedFamilyUses:1,op:reviveBoth});
  add('Lokaeo recycle limit across two opponent activations',
   [[family,H],[family,H],[body,G],[body,G],[dark,H,1],[dark,H,1]],[],[[family,B],[family,H],[body,G]],
   {family,lokaeoRecycle:'recycle-limit',rewrite:true,expectedFamilyUses:1,pick:body});
  add('Lokaeo Xyz trigger limit across Normal and Special Summon',
   [[family,H],[family,G],[body,F],[body,G],[recipient,E],[recipient,E],[helper,H]],
   [-family,helper],[[family,F],[body,F],[recipient,F],[recipient,E]],
   {family,lokaeoXyz:'xyz-limit',standardXyz:true,pick:recipient,expectedFamilyUses:1,
    op:'assert(Duel.SpecialSummon(find('+body+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1) assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)'});
  add('Lokaeo can Xyz Summon during the same Standby as its revival',
   [[family,G],[body,F],[recipient,E],[helper,H]],[helper],[[recipient,F]],
   {family,lokaeoRecycle:'revival-xyz',lokaeoXyz:'revival',lokaeoExternal:true,lokaeoRevivalTurn:2,
    lokaeoExpectedOffers:1,lokaeoAcceptRevival:true,noRewrite:true,standardXyz:true,pick:recipient,
    expectedFamilyUses:2,op:'assert(Duel.Remove(find('+family+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)==1)'});
 }
 for(const [family,name] of [[231825514,'Koai'],[250556612,'Zao']])for(const mode of ['two','three','one','wrong-level','wrong-race']){
  const materials=mode==='three'?[body,wing,dark]:mode==='one'?[body]:[body,wing];
  const legal=mode==='two'||mode==='three';
  add(name+' Xyz recipe '+mode,[[family,E],...materials.map(code=>[code,F])],legal?[family]:[],
   [[family,legal?F:E]],{family,koai:family===231825514,zao:family===250556612,levelOneXyzRecipe:mode,standardXyz:true,recipeMaterials:materials,
    selectMax:mode==='three',specialAvailability:legal?undefined:false});
 }
 for(const [family,name] of [[231825514,'Koai'],[250556612,'Zao']])for(const mode of ['cost','effect','host-leaves']){
  const detach=mode==='cost'?'assert(xyz:RemoveOverlayCard(tp,1,1,REASON_COST))':
   mode==='effect'?'assert(Duel.SendtoGrave(mc,REASON_EFFECT)==1)':'assert(Duel.SendtoGrave(xyz,REASON_EFFECT)==1)';
  add(name+' material destination '+mode,[[family,F],[body,G],[helper,H]],[helper],
   [[body,mode==='host-leaves'?G:B],[family,mode==='host-leaves'?G:F]],
   {family,koai:family===231825514,zao:family===250556612,isolateXyzRecipe:true,op:'local xyz=find('+family+',LOCATION_MZONE) local mc=find('+body+
    ',LOCATION_GRAVE) Duel.Overlay(xyz,Group.FromCards(mc)) assert(xyz:GetOverlayCount()==1) '+detach});
 }
 for(const mode of ['protected','detached','own-effect']){
  const family=231825514,own=mode==='own-effect';
  const op='local xyz=find('+family+',LOCATION_MZONE) Duel.Overlay(xyz,Group.FromCards(find('+body+
   ',LOCATION_GRAVE))) '+(mode==='detached'?'assert(xyz:RemoveOverlayCard(tp,1,1,REASON_COST)) assert(xyz:GetOverlayCount()==0)':'');
  add('Koai targeting protection '+mode,[[family,F],[body,G],[wing,F],[helper,H],[dark,H,Number(!own)]],
   own?[helper,dark]:[helper],[[family,F],[wing,F]],{family,koai:true,isolateXyzRecipe:true,koaiProtect:mode,
    rewrite:!own,noRewrite:true,op});
 }
 for(const mode of ['one','two','extra','redirect','partial-redirect','decline']){
  const family=231825514;
  const two=['two','extra','partial-redirect'].includes(mode);
  add('Koai Quick Effect '+mode,[[family,F],[helper,H],[body,G],[wing,B],...(two?[[fusion,B]]:[]),[spell,D],[trap,D]],
   [helper,family],[[family,F],[body,B],[wing,['redirect','partial-redirect'].includes(mode)?G:D],...(two?[[fusion,mode==='extra'?E:D]]:[])],
   {family,koai:true,isolateXyzRecipe:true,koaiQuick:mode,selectMax:true,sequentialActions:true,yes:mode!=='decline',
    expectedFamilyUses:1,op:'Duel.Overlay(find('+family+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE)))'});
 }
 for(const mode of ['opponent','cost-only','cost-target','copy-limit']){
  const family=231825514;
  const opponent=mode==='opponent',costOnly=mode==='cost-only',limit=mode==='copy-limit';
  const op=limit?'local host=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+family+') for xyz in aux.Next(host) do Duel.Overlay(xyz,Group.FromCards(find('+body+',LOCATION_GRAVE))) end':
   'Duel.Overlay(find('+family+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE)))';
  add('Koai Quick Effect '+mode,
   [[family,F],[helper,H],[body,G],...(costOnly?[]:[[wing,B]]),[spell,D],[trap,D],
    ...(opponent?[[dark,H,1]]:[]),...(limit?[[family,F],[body,G],[fusion,B]]:[])],
   opponent||costOnly?[helper]:[helper,family],
   [[family,F],...(costOnly?[]:[[body,mode==='cost-target'?D:B],[wing,D]]),...(limit?[[fusion,B]]:[])],
   {family,koai:true,isolateXyzRecipe:true,koaiQuick:mode,sequentialActions:true,selectMax:!limit,yes:true,
    forbidden:limit||costOnly?family:undefined,expectedFamilyUses:Number(!costOnly),pick:limit?wing:undefined,
    rewrite:opponent,op});
 }
 for(const opponent of [false,true])for(const material of [false,true]){
  const family=250556612;
  const attach=material?'local xyz=find('+family+',LOCATION_MZONE) Duel.Overlay(xyz,Group.FromCards(find('+body+
   ',LOCATION_GRAVE))) assert(xyz:GetOverlayCount()==1) ':'';
  const destroy=opponent?'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+family+') Duel.Destroy(tc,REASON_EFFECT)':
   'Duel.Destroy(find('+family+',LOCATION_MZONE),REASON_EFFECT)';
  add('Zao effect destruction '+(opponent?'opponent':'own')+' '+(material?'with material':'without material'),
   [[family,F],[body,G],[helper,H],...(opponent?[[dark,H,1]]:[])],[helper],[[family,material?F:G]],
   {family,zao:true,isolateXyzRecipe:true,rewrite:opponent,noRewrite:true,
    opponentOp:opponent?destroy:undefined,op:attach+(opponent?'':destroy)});
 }
 for(const mode of ['forward','reverse','upper','real','copy-limit','interrupted','one-spell','wrong-set','unusable-spell']){
  const family=250556612;
  const real=mode==='real',upper=mode==='upper',limit=mode==='copy-limit',interrupted=mode==='interrupted';
  const first=real?236542835:spell,second=real?246421842:trap;
  const legal=!['one-spell','wrong-set','unusable-spell'].includes(mode);
  add('Zao Sacred Treasure sequence '+mode,
   [[family,F],[helper,H],[body,G],[first,H],...(mode==='one-spell'?[]:[[second,G]]),...(real?[[wing,F,1],[dark,T,1]]:upper?[[dark,H,1]]:interrupted?[[dark,F,1]]:[]),
    ...(limit?[[family,F],[body,G],[first,H],[second,G]]:[])],
   legal&&!upper?[helper,family]:[helper],[[family,F],...(legal?[[body,B],...(interrupted?[[first,H],[second,D]]:[[first,B],[second,B]])]:[]),...(real?[[wing,G,1],[dark,G,1]]:[])],
   {family,zao:true,zaoSequence:mode,isolateXyzRecipe:true,sequentialActions:true,expectedFamilyUses:Number(legal),
    rewrite:upper,opponentOp:upper?'Duel.Recover(tp,300,REASON_EFFECT)':undefined,
    pick:mode==='reverse'?second:first,forbidden:!legal||limit?family:undefined,
    op:(limit?'for xyz in aux.Next(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+family+')) do Duel.Overlay(xyz,Group.FromCards(find('+body+',LOCATION_GRAVE))) end':'Duel.Overlay(find('+family+',LOCATION_MZONE),Group.FromCards(find('+body+',LOCATION_GRAVE)))')+' local observer=Effect.CreateEffect(e:GetHandler()) observer:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) observer:SetCode(EVENT_CHAIN_SOLVED) observer:SetOperation(function(_,p,eg,ep,ev,re) if re:GetHandler():IsCode(250556612) then Duel.RegisterFlagEffect(tp,900009001,RESET_CHAIN,0,1) end end) Duel.RegisterEffect(observer,tp)'});
 }
 for(const [family,name] of [[236542835,'Bojin'],[229499914,'Chunyin'],[246421842,'Huangjin']]){
  for(const mode of ['together','alone','wrong-set','separate']){
   const pair=mode==='together';
   const ownHand=family===236542835;
   const remove=code=>'Duel.Remove(find('+code+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)';
   const op=mode==='separate'?remove(family)+' '+remove(body):mode==='alone'?remove(family):
    'assert(Duel.Remove(Group.FromCards(find('+family+',LOCATION_GRAVE),find('+body+',LOCATION_GRAVE)),POS_FACEUP,REASON_EFFECT)==2)';
   add(name+' simultaneous banish '+mode,
    [[family,G],[helper,H],...(mode==='alone'?[]:[[body,G]]),...(ownHand?[[wing,H],[dark,H,1]]:[])],
    [helper],[[family,B],...(ownHand?[[wing,pair?G:H],[dark,pair?G:H,1]]:[]),
     ...(mode==='alone'?[]:[[body,pair&&family===229499914?H:B]])],
    {family,zao:true,treasureBanish:mode,expectedFamilyUses:Number(pair),
     expectedHandCount:family===246421842?Number(pair):undefined,pick:body,op});
  }
 }
 for(const mode of ['destroy-opponent','destroy-own','choose-destroy','choose-summon','opponent-only','facedown','full-field','copy-limit']){
  const family=236542835;
  const legal=!['opponent-only','facedown'].includes(mode);
  const otherSide=Number(mode==='opponent-only');
  const choice=mode.startsWith('choose');
  const summon=mode==='choose-summon';
  const own=mode==='destroy-own';
  const limit=mode==='copy-limit';
  add('Bojin activation '+mode,
   [[family,H],[body,F,otherSide],...(own?[]:[[wing,F,1]]),...(choice||mode==='full-field'?[[trap,H]]:[]),
    ...(limit?[[family,H],[wing,F,1]]:[]),...(mode==='full-field'?Array.from({length:4},()=>[spell,F]):[])],
   legal?[family]:[],
   legal?(summon?[[trap,F],[wing,F,1]]:own?[[body,G]]:[[wing,G,1],...(limit?[[wing,F,1],[family,H]]:[])]):[[family,H],[body,F,otherSide]],
   {family,bojin:mode,pick:summon?trap:own?body:wing,option:Number(summon),options:choice?2:undefined,
    forbidden:!legal||limit?family:undefined,expectedFamilyUses:Number(legal)});
 }
 for(const mode of ['position','deck','deck-only','same-name','no-branch','opponent-only','copy-limit','source-leaves']){
  const family=229499914,deck=['deck','deck-only','source-leaves'].includes(mode),legal=!['opponent-only','no-branch'].includes(mode);
  const duplicate=['same-name','no-branch'].includes(mode),limit=mode==='copy-limit';
  add('Chunyin activation '+mode,
   [[family,H],[body,F,Number(mode==='opponent-only')],[dark,F,1],[wing,D],[wing,D],
    ...(duplicate?[]:[[trap,D]]),...(limit?[[family,H]]:[])],
   legal?[family]:[],
   deck?[[wing,B],[trap,B],[wing,D]]:legal?[[dark,F,1],[wing,D],...(limit?[[family,H]]:[])]:[[family,H],[wing,D],...(duplicate?[]:[[trap,D]])],
   {family,chunyin:mode,treasureSourceLeaves:mode==='source-leaves',pick:dark,option:Number(deck),forbidden:!legal||limit?family:undefined,
    expectedFamilyUses:Number(legal)});
 }
 for(const mode of ['destroy-own','destroy-opponent','banish-own','banish-opponent','opponent-only','copy-limit','source-leaves']){
  const family=246421842;
  const legal=mode!=='opponent-only',banish=mode.startsWith('banish')||mode==='source-leaves';
  const owner=Number(mode.endsWith('opponent')),limit=mode==='copy-limit',leaves=mode==='source-leaves';
  const target=banish?wing:spell;
  add('Huangjin activation '+mode,
   [[family,H],[body,F,Number(!legal)],[target,banish?G:T,owner],...(limit?[[family,H],[trap,G]]:[]),
    ...(leaves?[[dark,F,1]]:[])],
   legal?[family]:[],
   legal?[[target,banish?B:G,owner],...(limit?[[family,H],[trap,G]]:[])]:[[family,H],[target,T,owner]],
   {family,huangjin:mode,treasureSourceLeaves:leaves,pick:target,option:Number(banish),
    options:banish||limit?2:undefined,forbidden:!legal||limit?family:undefined,expectedFamilyUses:Number(legal)});
 }
 for(const sourceLeaves of [false,true]){
  const family=237917359,umi=22702055;
  add('Shrine places Umi '+(sourceLeaves?'after source destruction':'normally'),[[family,H],[umi,D],...(sourceLeaves?[[dark,F,1]]:[])],
   [family],[[umi,L.FZONE]],{family,shrinePlacement:true,treasureSourceLeaves:sourceLeaves,expectedFamilyUses:1});
 }
 for(const mode of ['hand','grave','banished','special-trigger','wrong-set','facedown','full','necrovalley']){
  const family=218600459;
  const special=mode==='special-trigger';
  const legal=['hand','grave','banished','special-trigger'].includes(mode);
  const target=mode==='facedown'?trap:body;
  const origin=mode==='hand'?H:['banished','facedown'].includes(mode)?B:G;
  add('Bauba summon '+mode,
   [[family,special?G:H],[target,origin],...(special?[[helper,H]]:[]),
    ...(mode==='full'?Array.from({length:4},()=>[wing,F]):[]),...(mode==='necrovalley'?[[47355498,L.FZONE]]:[])],
   special?[helper]:[-family],[[family,F],[target,legal?F:origin]],
   {family,baubaSummon:mode,pick:target,expectedFamilyUses:Number(legal),banishedTrapFacedown:mode==='facedown',
    op:special?'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)':undefined});
 }
 for(const redirect of [false,true]){
  const family=218600459;
  add('Bauba Spell receipt '+(redirect?'redirect':'success'),
   [[family,H],[body,D],[dark,G,1]],[],[[family,B],[body,redirect?B:H]],
   {family,baubaReceipt:true,redirect,rewrite:true,graveActivation:true,
    expectedFamilyUses:1,pick:body});
 }
 for(const [family,name] of [[232232676,'Oro'],[212055290,'Advent']])for(const redirect of [false,true]){
  const monster=family===232232676;
  add(name+' search reveal '+(redirect?'redirect':'success'),[[family,H],[body,D]],
   monster?[-family]:[family],[[family,monster?F:G],[body,redirect?B:H]],
   {family,baubaReceipt:true,handRevealProbe:monster?'oro':'advent',redirect,expectedFamilyUses:1,pick:body});
 }
 for(const mode of ['success','redirect','wrong set','wrong type']){
  const family=232232676;
  const redirect=mode==='redirect';
  const legal=mode==='success'||redirect;
  add('Oro Special Summon search '+mode,[[family,G],[helper,H],[body,D]],
   [helper],[[family,F],[body,legal?(redirect?B:H):D]],
   {family,baubaReceipt:true,oroSearch:mode,redirect,baubaExpectedReceipt:legal&&!redirect,
    expectedFamilyUses:Number(legal),pick:body,
    op:'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)'});
 }
 for(const [trigger,mode] of [['Normal','legal'],['Special','legal'],['Special','wrong set'],['Special','wrong type']]){
  const family=235789995,special=trigger==='Special',legal=mode==='legal';
  add('Hikam '+trigger+' Summon Deck banish '+mode,
   [[family,special?G:H],[body,D],...(special?[[helper,H]]:[])],
   special?[helper]:[-family],[[family,F],[body,legal?B:D]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,hikamSummon:mode,expectedFamilyUses:Number(legal),pick:body,
    op:special?'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)':undefined});
 }
 for(const [mode,origin,special,legal] of [
  ['NiuHao GY',G,false,true],['Sacred Treasure banishment',B,true,true],
  ['wrong set',G,false,false],['face-down banishment',B,true,false],['Necrovalley',G,false,false]
 ]){
  const family=215629896;
  add('Zaoka summon recovery '+mode,
   [[family,special?G:H],[body,origin],...(special?[[helper,H]]:[]),...(mode==='Necrovalley'?[[47355498,L.FZONE]]:[])],
   special?[helper]:[-family],[[family,F],[body,legal?H:origin]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,zaokaRecovery:mode,expectedFamilyUses:Number(legal),pick:body,
    op:special?'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)':undefined});
 }
 for(const [mode,source,origin,legal] of [
  ['field from Hand',H,F,true],['banishment from field',F,B,true],
  ['opponent GY',H,G,false],['short Deck',H,F,false],['all match',H,F,true]
 ]){
  const family=215629896,short=mode==='short Deck';
  add('Zaoka excavation '+mode,
   [[family,source],[body,D],[wing,D],...(short?[]:[[trap,D]]),[dark,origin,1]],[],
   [[family,legal?B:source],[body,legal?G:D],[wing,legal?G:D],...(short?[]:[[trap,mode==='all match'?G:D]])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,zaokaExcavation:mode,rewrite:true,noRewrite:!legal,
    graveActivation:origin===G,banishedActivation:origin===B,monsterActivation:origin===F,expectedFamilyUses:Number(legal)});
 }
 {
  const family=215629896;
  add('Zaoka recovery limit across Normal and Special Summon',
   [[family,H],[family,G],[body,G],[body,G],[helper,H]],[-family,helper],
   [[family,F],[body,H],[body,G]],{family,baubaReceipt:true,baubaExpectedReceipt:false,
    zaokaRecovery:'NiuHao GY',expectedFamilyUses:1,pick:body,
    op:'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)'});
  add('Zaoka excavation limit with three non-matches left',
   [[family,H],[family,H],[trap,D],[trap,D],[trap,D],[dark,B,1],[dark,B,1]],[],
   [[family,B],[family,H],[trap,D]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,zaokaExcavation:'copy-limit',
    baubaSource:'copy-limit',rewrite:true,banishedActivation:true,expectedFamilyUses:1});
 }
 for(const mode of ['success','redirect','decline','wrong set','both effects']){
  const family=247831166,redirect=mode==='redirect',both=mode==='both effects';
  const receipt=['success','both effects'].includes(mode);
  add('Leoship activation search '+mode,[[family,H],[body,D]],
   both?[family,family]:[family],[[family,T],[body,both?F:receipt?H:redirect?B:D]],
   {family,baubaReceipt:true,leoship:mode,redirect,yes:mode!=='decline',noYes:mode==='wrong set',
    baubaExpectedReceipt:receipt,expectedFamilyUses:both?2:1,pick:body});
 }
 for(const mode of ['wrong monster set','Spell in Hand','full field','summon limit','activation limit']){
  const family=247831166,activation=mode==='activation limit',legal=mode==='summon limit';
  const zone=activation?H:T;
  add('Leoship '+mode,[[family,zone],[body,activation?D:H],
    ...(activation||legal?[[family,zone],[body,activation?D:H]]:[]),
    ...(mode==='full field'?Array.from({length:5},()=>[wing,F]):[])],
   activation||legal?[family]:[],[[body,legal?F:H],...(legal?[[body,H]]:activation?[[body,D]]:[])],
   {family,baubaReceipt:true,leoship:mode,yes:activation,baubaExpectedReceipt:activation,
    expectedFamilyUses:Number(activation||legal),forbidden:activation?undefined:family,pick:body});
 }
 for(const mode of ['Hand Tribute','field Tribute','Leoship','wrong Tribute Level','wrong Synchro Level']){
  const family=235051048,replace=mode==='Leoship';
  const cost=replace?G:mode==='field Tribute'?F:H;
  const legal=!mode.startsWith('wrong');
  add('Octantis upgrade '+mode,[[family,F],[body,cost],[wing,E],...(replace?[[247831166,T]]:[])],
   legal?[family]:[],[[family,legal&&!replace?G:F],[body,legal?(replace?B:G):cost],[wing,legal?F:E]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,octantisUpgrade:mode,
    expectedFamilyUses:Number(legal),forbidden:legal?undefined:family,pick:body});
 }
 for(const mode of ['GY recruit','wrong set','opposing card','sent without destruction','copy limit','Necrovalley']){
  const family=235051048,repeat=mode==='copy limit',legal=mode==='GY recruit'||repeat;
  const opposing=mode==='opposing card';
  const target=opposing?'Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+wing+')':
   'find('+wing+',LOCATION_MZONE)';
  const action=mode==='sent without destruction'?'SendtoGrave':'Destroy';
  add('Octantis destruction '+mode,
   [[family,G],[body,G],[wing,F,Number(opposing)],[helper,H],
    ...(repeat?[[family,G],[body,G],[wing,F],[helper,H]]:[]),
    ...(mode==='Necrovalley'?[[47355498,L.FZONE]]:[])],
   repeat?[helper,helper]:[helper],
   [[family,legal?B:G],[body,legal?F:G],[wing,G,Number(opposing)],...(repeat?[[family,G],[body,G]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,octantisRecruit:mode,
    expectedFamilyUses:Number(legal),pick:body,op:'assert(Duel.'+action+'('+target+',REASON_EFFECT)==1)'});
 }
 for(const [family,name] of [[235051048,'Octantis'],[244921711,'Hextanius'],[249093610,'Nordbar']]){
  add(name+' rejects the Synchro Summon type',[[family,E],[wing,E],[helper,H]],[helper],
   [[family,E],[wing,F]],{family,baubaReceipt:true,baubaExpectedReceipt:false,octantisSynchroCheck:true,
    expectedFamilyUses:0,
    op:'local source=find('+family+',LOCATION_EXTRA) local control=find('+wing+',LOCATION_EXTRA) '+
     'assert(not source:IsCanBeSpecialSummoned(e,SUMMON_TYPE_SYNCHRO,tp,false,false),"Restricted card cannot be Synchro Summoned") '+
     'assert(control:IsCanBeSpecialSummoned(e,SUMMON_TYPE_SYNCHRO,tp,false,false),"Unrestricted Synchro is legal") '+
     'assert(Duel.SpecialSummon(control,SUMMON_TYPE_SYNCHRO,tp,tp,false,false,POS_FACEUP_ATTACK)==1)'});
 }
 for(const mode of ['700 ATK','700 DEF','wrong attribute','wrong stats','copy limit']){
  const family=244921711,repeat=mode==='copy limit';
  const legal=!mode.startsWith('wrong');
  add('Hextanius Deck summon '+mode,
   [[family,E],[body,D],[helper,H],...(repeat?[[family,E],[body,D],[helper,H]]:[])],
   repeat?[helper,helper]:[helper],[[family,F],[body,legal?F:D],...(repeat?[[body,D]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,hextaniusRecruit:mode,expectedFamilyUses:Number(legal),pick:body,
    op:'assert(Duel.SpecialSummon(find('+family+',LOCATION_EXTRA),0,tp,tp,true,false,POS_FACEUP_ATTACK)==1)'});
 }
 for(const mode of ['legal','wrong set','Necrovalley','full field','copy limit']){
  const family=249093610,repeat=mode==='copy limit',legal=mode==='legal'||repeat;
  add('Nordbar GY summon '+mode,[[family,E],[body,G],[helper,H],
   ...(repeat?[[family,E],[body,G],[helper,H]]:[]),
   ...(mode==='full field'?Array.from({length:4},()=>[wing,F]):[]),
   ...(mode==='Necrovalley'?[[47355498,L.FZONE]]:[])],
   repeat?[helper,helper]:[helper],[[family,F],[body,legal?F:G],...(repeat?[[body,G]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,nordbarRevive:mode,
    expectedFamilyUses:Number(legal),pick:body,
    op:'assert(Duel.SpecialSummon(find('+family+',LOCATION_EXTRA),0,tp,tp,true,false,POS_FACEUP_ATTACK)==1)'});
 }
 for(const mode of ['legal','redirect','wrong set','wrong type','copy limit']){
  const family=249093610,repeat=mode==='copy limit',redirect=mode==='redirect';
  const legal=!mode.startsWith('wrong');
  add('Nordbar opponent Standby search '+mode,[[family,F],[body,D],...(repeat?[[family,F],[body,D]]:[])],[],
   [[body,legal?(redirect?B:H):D],...(repeat?[[body,D]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:legal&&!redirect,nordbarSearch:mode,redirect,
    expectedFamilyUses:Number(legal),pick:body});
 }
 for(const mode of ['Spell','monster','destruction protected','copy limit',...(process.argv.includes('--nordbar-negation-protection-probe')?['cannot negate']:[])]){
  const family=249093610,repeat=mode==='copy limit',protectedCard=mode==='destruction protected';
  const cannotNegate=mode==='cannot negate',monster=mode!=='Spell';
  add('Nordbar activation negation '+mode,
   [[family,F],[dark,monster?F:H,1],...(repeat?[[family,F],[dark,F,1]]:[]),...(protectedCard?[[helper,H]]:[])],
   protectedCard?[helper]:[],[[dark,protectedCard||cannotNegate?F:G,1],...(repeat?[[dark,F,1]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,nordbarNegate:mode,rewrite:true,monsterActivation:monster,
    baubaSource:repeat?'copy-limit':undefined,noRewrite:cannotNegate,expectedFamilyUses:Number(!cannotNegate),
    opponentOp:'Duel.Recover(tp,500,REASON_EFFECT)',
    op:protectedCard?'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+dark+') local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_INDESTRUCTABLE_EFFECT) ex:SetValue(1) c:RegisterEffect(ex)':undefined});
 }
 if(process.argv.includes('--nordbar-negation-protection-probe')){
  for(const protectedSpell of [false,true]){
   const family=84815190;
   add('Stock Baronne negation '+(protectedSpell?'protected':'ordinary'),[[family,F],[dark,protectedSpell?F:H,1]],[],
    [[dark,protectedSpell?F:G,1]],{family,stockNegationControl:true,baubaReceipt:true,baubaExpectedReceipt:false,
     nordbarNegate:protectedSpell?'cannot negate':'Spell',rewrite:true,noRewrite:protectedSpell,monsterActivation:protectedSpell,
     expectedFamilyUses:Number(!protectedSpell),opponentOp:'Duel.Recover(tp,500,REASON_EFFECT)'});
  }
 }
 for(const mode of ['legal','wrong attribute','face-down','same turn','copy limit']){
  const family=255277197,repeat=mode==='copy limit',sameTurn=mode==='same turn';
  const legal=mode==='legal'||repeat;
  add('Chaos Fusion GY return '+mode,
   [[family,sameTurn?H:G],[body,B],[wing,B],
    ...(repeat?[[family,G],[body,B],[wing,B]]:[]),...(sameTurn?[[helper,H]]:[])],
   legal?[family]:sameTurn?[helper]:[],[[family,legal?B:G],[body,legal?G:B],[wing,legal?G:B],
    ...(repeat?[[family,G],[body,B],[wing,B]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,chaosReturn:mode,activationLocation:G,
    expectedFamilyUses:Number(legal),forbidden:family,
    op:sameTurn?'assert(Duel.SendtoGrave(find('+family+',LOCATION_HAND),REASON_EFFECT)==1)':undefined});
 }
 {
  const family=255277197;
  add('Chaos Fusion GY return target leaves at Chain Link 2',
   [[family,G],[body,B],[wing,B],[dark,F,1]],[family],[[family,B],[body,H],[wing,B]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,chaosReturn:'target leaves',activationLocation:G,
    expectedFamilyUses:1,pick:body});
 }
 for(const [family,name] of [[234179728,'Galacticarina'],[227335484,'Galacticassiopeia']])
 for(const mode of ['Hand start','forced attack','damage','destruction','both triggers','no cost',
  'wrong recruit Level','banished recruit','face-down recruit','same name','wrong cost type']){
  const fromHand=mode==='Hand start',forced=mode==='forced attack';
  const own=!fromHand&&!forced;
  const recruit=own&&!['no cost','wrong recruit Level','face-down recruit','same name','wrong cost type'].includes(mode);
  const destroys=['destruction','both triggers'].includes(mode);
  const origin=['banished recruit','face-down recruit'].includes(mode)?B:D;
  const recipient=mode==='same name'?family:body;
  add(name+' battle '+mode,[[family,fromHand?H:F],
    ...(fromHand||forced||destroys?[[dark,F,1]]:[]),
    ...(forced?[[wing,F]]:[]),...(own?[[recipient,origin]]:[]),...(own&&mode!=='no cost'?[[trap,B]]:[])],
   [],[[family,recruit?B:F],...(own?[[recipient,recruit?F:origin]]:[]),
    ...(own&&mode!=='no cost'?[[trap,recruit?D:B]]:[]),...(destroys?[[dark,G,1]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,galacticaBattle:mode,
    galacticaOwnBattle:own&&mode!=='both triggers',battle:true,expectedFamilyUses:Number(fromHand||recruit),pick:body});
 }
 for(const mode of ['Normal','Special Attack','Special Defense','full zones','shared limit']){
  const family=229021849,token=229021850;
  const special=mode.startsWith('Special'),repeat=mode==='shared limit';
  const legal=mode!=='Special Defense'&&mode!=='full zones';
  add('Venatici token '+mode,[[family,special?G:H],...(special||repeat?[[helper,H]]:[]),
    ...(repeat?[[family,G]]:[]),...(mode==='full zones'?Array.from({length:4},()=>[wing,F]):[])],
   special?[helper]:repeat?[-family,helper]:[-family],[[family,F],...(legal?[[token,F]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,venaticiToken:mode,expectedFamilyUses:Number(legal),
    op:special||repeat?'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,'+
     (mode==='Special Defense'?'POS_FACEUP_DEFENSE':'POS_FACEUP_ATTACK')+')==1)':undefined});
 }
 for(const mode of ['damage','destruction','both triggers','wrong set']){
  const family=229021849,destroys=['destruction','both triggers'].includes(mode),legal=mode!=='wrong set';
  add('Venatici Deck banish '+mode,
   [[family,F],[body,D],...(destroys?[[dark,F,1]]:[]),...(mode==='both triggers'?[[wing,D]]:[])],[],
   [[family,F],[body,legal?B:D],...(destroys?[[dark,G,1]]:[]),...(mode==='both triggers'?[[wing,D]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,venaticiBattle:mode,
    galacticaOwnBattle:true,battle:true,expectedFamilyUses:Number(legal),pick:body});
 }
 {
  const family=229021849;
  add('Venatici Deck banish in two separate battles',
   [[family,F],[body,D],[wing,D],[helper,H],[dark,F,1],[dark,F,1]],[helper],
   [[family,F],[body,B],[wing,B],[dark,G,1]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,venaticiBattle:'two battles',galacticaOwnBattle:true,
    battle:true,expectedFamilyUses:2,pick:body,
    op:'local extra=Effect.CreateEffect(e:GetHandler()) extra:SetType(EFFECT_TYPE_SINGLE) '+
     'extra:SetCode(EFFECT_EXTRA_ATTACK) extra:SetValue(1) find('+family+',LOCATION_MZONE):RegisterEffect(extra)'});
 }
 for(const mode of ['halve to zero','double','decline','wrong cost type','same-name cost','copy limit','expires']){
  const family=226902471,repeat=mode==='copy limit';
  const resource=mode==='same-name cost'?family:body;
  const pay=!['decline','wrong cost type','same-name cost'].includes(mode);
  add('Battle Tactics activation '+mode,[[family,H],[resource,D],[dark,F,1],[wing,F,1],[trap,F],
    ...(repeat?[[family,H],[body,D]]:[])],[family],
   [[family,G],[resource,pay?G:D],...(repeat?[[family,H],[body,D]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,battleTactics:mode,yes:mode!=='decline',
    noYes:['wrong cost type','same-name cost'].includes(mode),option:mode==='halve to zero'?0:1,
    forbidden:repeat?family:undefined,expectedFamilyUses:1,pick:body});
 }
 {
  const family=226902471;
  add('Battle Tactics applies to the field at resolution',
   [[family,H],[body,D],[dark,F,1],[wing,F,1],[trap,F]],[family],[[family,G],[body,G],[dark,G,1]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,battleTactics:'opponent leaves',
    yes:true,option:1,expectedFamilyUses:1,pick:body});
  add('Battle Tactics cannot activate on opponent turn',
   [[family,T],[dark,F,1],[wing,F,1],[trap,F]],[],[[family,T]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,battleTactics:'opponent turn',
    rewrite:true,noRewrite:true,monsterActivation:true,setSourceSpell:true,expectedFamilyUses:0});
 }
 for(const mode of ['two names','duplicate names','wrong type','same name']){
  const family=226902471,legal=!mode.startsWith('wrong')&&mode!=='same name';
  const resources=mode==='same name'?[family]:mode==='duplicate names'?[body,body]:mode==='two names'?[body,wing]:[body];
  add('Battle Tactics banished trigger '+mode,[[family,G],[helper,H],...resources.map(code=>[code,D])],
   [helper],[[family,B],...(legal?[[body,B]]:[]),...(mode==='two names'?[[wing,B]]:[]),
    ...(mode==='duplicate names'?[[body,D]]:[]),...(!legal?[[resources[0],D]]:[])],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,tacticsBanish:mode,
    expectedFamilyUses:Number(legal),pick:body,
    op:'assert(Duel.Remove(find('+family+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)==1)'});
 }
 for(const [mode,origin,redirect] of [['Deck',D,false],['GY',G,false],['redirected Deck',D,true],['redirected GY',G,true]]){
  add('Battle Formation search '+mode,[[formation,H],[body,origin]],[formation],
   [[formation,G],[body,redirect?B:H]],{family:formation,baubaReceipt:true,formationSearch:true,redirect,
    expectedFamilyUses:1,pick:body});
 }
 for(const mode of ['success','partial redirect','all redirected']){
  const family=259758604,redirect=mode!=='success',redirectAll=mode==='all redirected';
  add('Charmelia Deal group reveal '+mode,[[family,H],[body,D],[wing,D]],
   [family],[[family,T],[body,redirect?B:H],[wing,redirectAll?B:H]],
   {family,baubaReceipt:true,revealGroup:true,redirect,redirectAll,selectMax:true,expectedFamilyUses:1,pick:body});
 }
 for(const [mode,origin,source] of [['hand',H,H],['grave-from-field',G,F],['field',F,H],['own-grave',G,H]]){
  const family=218600459,own=mode==='own-grave';
  const legal=mode==='hand'||mode==='grave-from-field';
  add('Bauba response origin '+mode,
   [[family,source],[body,D],[dark,origin,Number(!own)]],own?[dark]:[],
   [[family,legal?B:source],[body,legal?H:D]],
   {family,baubaReceipt:true,baubaSource:mode,baubaExpectedReceipt:legal,rewrite:!own,noRewrite:!legal,
    monsterActivation:origin===F,graveActivation:origin===G,expectedFamilyUses:Number(legal),pick:body});
 }
 for(const [mode,source,origin,owner,legal] of [
  ['opponent GY from Hand',H,G,1,true],['opponent banishment from field',F,B,1,true],
  ['opponent field',H,F,1,false],['own GY',H,G,0,false]
 ]){
  const family=232232676;
  add('Oro Quick Effect response '+mode,[[family,source],[body,D],[dark,origin,owner]],
   owner?[]:[dark],[[family,legal?B:source],[body,legal?G:D]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,rewrite:Boolean(owner),noRewrite:!legal,
    baubaSource:owner?undefined:'own-grave',graveActivation:origin===G,banishedActivation:origin===B,
    monsterActivation:origin===F,expectedFamilyUses:Number(legal),pick:body});
 }
 for(const mode of ['wrong set','wrong type','facedown','banish blocked']){
  const family=232232676,source=mode==='facedown'?F:H;
  const blocked=mode==='banish blocked';
  add('Oro Quick Effect restriction '+mode,
   [[family,source],[body,D],[dark,G,1],...(blocked?[[helper,H]]:[])],
   blocked?[helper]:[],[[family,source],[body,D]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,oroSearch:mode,rewrite:true,noRewrite:true,
    graveActivation:true,expectedFamilyUses:0,
    op:blocked?'local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD) ex:SetCode(EFFECT_CANNOT_REMOVE) ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET) ex:SetTargetRange(1,0) Duel.RegisterEffect(ex,tp)':undefined});
 }
 {
  const family=232232676;
  add('Oro search limit across Normal and Special Summon',
   [[family,H],[family,G],[body,D],[body,D],[helper,H]],[-family,helper],
   [[family,F],[body,H],[body,D]],{family,baubaReceipt:true,expectedFamilyUses:1,pick:body,
    op:'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)'});
 }
 for(const [mode,source,origin,legal] of [
  ['field from Hand',H,F,true],['GY from field',F,G,true],['banishment',H,B,false],
  ['own GY',H,G,false],['wrong set',H,G,false],['wrong type',H,G,false],
  ['facedown',F,G,false],['full Spell Trap Zones',H,G,false],['banish blocked',H,G,false]
 ]){
  const family=235789995,own=mode==='own GY',blocked=mode==='banish blocked';
  const filled=mode==='full Spell Trap Zones'?Array.from({length:5},()=>[trap,T]):[];
  add('Hikam Quick Effect Set '+mode,
   [[family,source],[body,D],[dark,origin,Number(!own)],...filled,...(blocked?[[helper,H]]:[])],
   own?[dark]:blocked?[helper]:[],[[family,legal?B:source],[body,legal?T:D]],
   {family,baubaReceipt:true,baubaExpectedReceipt:false,oroSearch:mode,rewrite:!own,noRewrite:!legal,
    baubaSource:own?'own-grave':undefined,graveActivation:origin===G,banishedActivation:origin===B,
    monsterActivation:origin===F,expectedFamilyUses:Number(legal),pick:body,checkHikamSet:legal,
    op:blocked?'local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD) ex:SetCode(EFFECT_CANNOT_REMOVE) ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET) ex:SetTargetRange(1,0) Duel.RegisterEffect(ex,tp)':undefined});
 }
 {
  const family=235789995;
  add('Hikam Deck banish limit across Normal and Special Summon',
   [[family,H],[family,G],[body,D],[body,D],[helper,H]],[-family,helper],
   [[family,F],[body,B],[body,D]],{family,baubaReceipt:true,baubaExpectedReceipt:false,
    hikamSummon:'legal',expectedFamilyUses:1,pick:body,
    op:'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)'});
 }
 for(const [family,name] of [[218600459,'Bauba'],[232232676,'Oro'],[235789995,'Hikam'],[215629896,'Zaoka']])
 for(const [mode,origin,faceDown] of [['grave',G,false],['field',F,false],['facedown',G,true]]){
  add(name+' Standby revival '+mode,[[family,origin],[helper,H]],[helper],[[family,faceDown?B:F]],
   {family,baubaRevival:true,lokaeoRecycle:'external-'+mode,lokaeoExternal:true,lokaeoRevivalTurn:2,
    lokaeoExpectedOffers:Number(!faceDown),lokaeoAcceptRevival:!faceDown,noRewrite:true,expectedFamilyUses:Number(!faceDown),
    op:'assert(Duel.Remove(find('+family+','+(origin===G?'LOCATION_GRAVE':'LOCATION_MZONE')+'),'+
     (faceDown?'POS_FACEDOWN':'POS_FACEUP')+',REASON_EFFECT)==1)'});
 }
 {
  const family=218600459;
  add('Bauba summon limit across Normal and Special Summon',
   [[family,H],[family,G],[body,G],[trap,G],[helper,H]],[-family,helper],
   [[family,F],[body,F],[trap,G]],{family,baubaSummon:'copy-limit',expectedFamilyUses:1,pick:body,
    op:'assert(Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP_ATTACK)==1)'});
 }
 for(const [family,name,destination] of [[218600459,'Bauba',H],[232232676,'Oro',G],[235789995,'Hikam',T]]){
  add(name+' Quick Effect limit across two opponent activations',
   [[family,H],[family,H],[body,D],[body,D],[dark,G,1],[dark,G,1]],[],[[family,B],[family,H],[body,destination],[body,D]],
   {family,baubaReceipt:true,baubaExpectedReceipt:destination===H,baubaSource:'copy-limit',
    rewrite:true,graveActivation:true,expectedFamilyUses:1,pick:body});
 }
 for(const [family,name] of [[218600459,'Bauba'],[232232676,'Oro'],[235789995,'Hikam'],[215629896,'Zaoka']]){
  add(name+' revival limit across two eligible copies',[[family,G],[family,G],[helper,H]],[helper],[[family,F],[family,B]],
   {family,baubaRevival:true,lokaeoRecycle:'external-limit',lokaeoExternal:true,lokaeoRevivalTurn:2,
    lokaeoExpectedOffers:1,lokaeoAcceptRevival:true,noRewrite:true,expectedFamilyUses:1,
    op:'assert(Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+family+'),POS_FACEUP,REASON_EFFECT)==2)'});
  add(name+' declined revival expires before the following Standby',[[family,G],[helper,H]],[helper],[[family,B]],
   {family,baubaRevival:true,lokaeoRecycle:'external-decline',lokaeoExternal:true,lokaeoRevivalTurn:2,lokaeoObserveUntil:3,
    lokaeoExpectedOffers:1,lokaeoAcceptRevival:false,noRewrite:true,expectedFamilyUses:0,
    op:'assert(Duel.Remove(find('+family+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)==1)'});
 }
 if(process.argv.includes('--full-pendulum-probe'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.originsFullPendulum));
 for(const removed of [false,true])add('Glitchling Bitron copied effect '+(removed?'cost card banished':'baseline'),[[259247807,F],[259546637,D],[body,D],[wing,H],...(removed?[[dark,F,1]]:[])],[259247807],[[body,H],[259546637,removed?B:G]],{family:259247807,bitronCopy:true,bitronCopyRemoved:removed,yes:true,expectedFamilyUses:1});
 for(const removed of [false,true])add('Stainless Story copied search '+(removed?'cost card banished':'baseline'),[[245970073,H],[221822671,D],[body,D],[dark,F,1],[wing,F,1]],[245970073],[[body,H],[221822671,removed?B:G]],{family:245970073,stainlessCopy:true,bitronCopyRemoved:removed,expectedFamilyUses:1});
 for(const [kind,code] of [['bria',225091736],['dante',216958556],['feness',247499445],['rollo',224822244]])add('Stainless copied '+kind+' cost monster banished',[[245970073,H],[code,D],[body,G],[dark,F,1],[wing,F,1]],[245970073],kind==='bria'?[[body,H]]:kind==='dante'?[[wing,G,1]]:kind==='rollo'?[[body,F]]:[],{family:245970073,storyCopyKind:kind,storyCopiedCode:code,bitronCopyRemoved:true,pick:['bria','rollo'].includes(kind)?body:wing,expectedFamilyUses:1});
 if(process.argv.includes('--story-shuffle-probe')){
 testCases.splice(0,testCases.length);
 add('Stainless copied self-shuffle identity needs ruling',[[245970073,H],[216958556,D],[dark,F,1],[wing,F,1]],[245970073],[[245970073,D],[216958556,G],[wing,G,1]],{family:245970073,storyCopyKind:'dante',storyCopiedCode:216958556,pick:wing,storyShuffleProbe:true,expectedFamilyUses:1});
 }
 for(const secondLoc of [H,G])add('Hope summon limit shared with copy in '+secondLoc,[[243194249,H],[243194249,secondLoc],[body,F,1]],[243194249],[[243194249,F],[243194249,secondLoc]],{family:243194249,procedureSource:true,activationLocation:H,specialAvailability:false});
 add('Flowering summon limit shared across copies',[[232100722,H],[232100722,H],[body,G],[wing,G]],[232100722],[[232100722,F],[232100722,H]],{family:232100722,procedureSource:true,floweringRecovery:true,floweringCount:true,specialAvailability:false});
 add('Brigade Field Spell both effects same turn',[[238976759,H],[body,E],[wing,D],[spell,H],[trap,H]],[238976759,238976759],[[body,F],[238976759,L.FZONE]],{family:238976759,brigadeFieldBoth:true,yes:true,expectedFamilyUses:2,forbidden:238976759});
 add('Brigade Field Spell needs two discard cards',[[238976759,H],[body,E],[wing,H],[helper,H]],[helper],[[body,E],[wing,H]],{family:238976759,brigadeFieldBoth:true,forbidden:238976759,expectedFamilyUses:0,op:'Duel.MoveToField(find(238976759,LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true)'});
 add('Armada draw limit shared across loaded copies',[[223750159,F],[223750159,F],[body,G],[spell,G],[helper,H]],[helper,223750159],[],{family:223750159,armadaDraw:true,armadaCountCopies:true,immuneOrbHost:true,forbidden:223750159,expectedHandCount:1,expectedFamilyUses:1,op:'local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,223750159) local a=g:GetFirst() local b=g:GetNext() Duel.Overlay(a,Group.FromCards(find('+body+',LOCATION_GRAVE))) Duel.Overlay(b,Group.FromCards(find('+spell+',LOCATION_GRAVE)))'});
 add('Heartbeat summon lock survives effect negation',[[220124524,H],[body,H],[wing,H],[fusion,H],[helper,H],[dark,F,1]],[-220124524,helper],[[body,H]],{family:220124524,brigadeOnSummon:true,heartbeatNegate:true,expectedFamilyUses:1,op:'assert(not find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Outsider remains blocked after negation") assert(find('+fusion+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Brigade remains legal")'});
 add('Forward summon lock survives effect negation',[[232038002,H],[spell,D],[wing,H],[fusion,H],[helper,H],[dark,F,1]],[-232038002,helper],[[spell,D]],{family:232038002,brigadeOnSummon:true,heartbeatNegate:true,expectedFamilyUses:1,op:'assert(not find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Outsider remains blocked after search negation") assert(find('+fusion+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Brigade remains legal")'});
 add('Supremacy negates banish-protected monster',[[241504188,F],[dark,F,1],[helper,H]],[helper],[[dark,F,1],[241504188,B]],{family:241504188,supremacyNeg:true,supremacyBanishCount:0,rewrite:true,monsterActivation:true,opponentOp:'Duel.Recover(tp,500,REASON_EFFECT)',op:'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+dark+') local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD) ex:SetCode(EFFECT_CANNOT_REMOVE) ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET) ex:SetTargetRange(1,1) ex:SetTarget(function(e,tc) return tc==c end) Duel.RegisterEffect(ex,tp)'});
 add('Supremacy banishes activated card without GY copies',[[241504188,F],[dark,H,1]],[],[[241504188,B]],{family:241504188,supremacyNeg:true,supremacyBanishCount:1,rewrite:true,opponentOp:'Duel.Recover(tp,500,REASON_EFFECT)'});
 for(const code of [220124524,232038002]){
 const base=testCases.find(t=>t.name===(code===220124524?'Heartbeat':'Forward')+' summon lock survives effect negation');
 testCases.push({...base,name:(code===220124524?'Heartbeat':'Forward')+' use lock survives activation negation',activationNegation:true});
 }
 for(const code of [247298564,259998396])add('Use lock activation negation '+code,[[code,H],[body,code===247298564?F:H],[fusion,D],[wing,H],[spell,H],[helper,H],[dark,F,1]],code===247298564?[body,helper]:[code,helper],[[fusion,D]],{family:code,useLockProbe:true,heartbeatNegate:true,activationNegation:true,pick:body,expectedFamilyUses:1,op:'assert(not find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Forbidden Special Summon remains blocked") assert(find('+spell+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Allowed attribute Special Summon legal")'+(code===259998396?' assert(not find('+wing+',LOCATION_HAND):IsSummonable(false,nil),"Forbidden Normal Summon blocked")':'')});
 for(const mode of ['normal','effect-negated','activation-negated'])add('Pot Fortune use lock '+mode,[[215885404,H],[body,F],...Array.from({length:5},()=>[spell,G]),...(mode==='normal'?[]:[[dark,F,1]])],[215885404],[],{family:215885404,potUseLock:true,heartbeatNegate:mode!=='normal',activationNegation:mode==='activation-negated',forbidden:body,expectedFamilyUses:1,expectedHandCount:mode==='normal'?2:0});
 for(const code of [248946297,259780273])add('Use lock activation negation '+code,[[code,H],[body,D],[wing,H],[spell,H],[helper,H],[dark,F,1]],[code,helper],[[body,D]],{family:code,extraUseLockProbe:true,heartbeatNegate:true,activationNegation:true,expectedFamilyUses:1,op:'assert(not find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Forbidden Special Summon remains blocked") assert(find('+spell+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Allowed summon remains legal")'});
 add('Aqua Fusion use lock activation negation',[[227035644,H],[body,H],[wing,H],[fusion,E],[link,E],[helper,H],[dark,F,1]],[227035644,helper],[[fusion,E]],{family:227035644,aquaUseLock:true,heartbeatNegate:true,activationNegation:true,expectedFamilyUses:1,op:'assert(not find('+link+',LOCATION_EXTRA):IsCanBeSpecialSummoned(e,0,tp,false,false),"Non-WATER-Fusion Extra summon blocked") assert(find('+fusion+',LOCATION_EXTRA):IsCanBeSpecialSummoned(e,0,tp,false,false),"WATER Fusion remains allowed")'});
 add('Offertorium hand use lock activation negation',[[offer,H],[engraver,D],[wing,H],[spell,H],[helper,H],[dark,F,1]],[offer,helper],[[engraver,D]],{family:offer,heartbeatNegate:true,activationNegation:true,offertoriumUseLock:true,expectedFamilyUses:1,op:'assert(not find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Non-LIGHT-Fiend summon blocked") assert(find('+spell+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"LIGHT Fiend remains allowed")'});
 add('Offertorium grave use lock activation negation',[[offer,G],[body,G],[trap,D],[wing,H],[spell,H],[helper,H],[helper,H],[dark,F,1]],[helper,offer,helper],[[offer,B],[trap,D]],{family:offer,heartbeatNegate:true,activationNegation:true,offertoriumUseLock:true,expectedFamilyUses:1,op:'local c=find('+body+',LOCATION_GRAVE) if c then Duel.Remove(c,POS_FACEUP,REASON_EFFECT) else assert(not find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Non-LIGHT-Fiend summon blocked") assert(find('+spell+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"LIGHT Fiend remains allowed") end'});
 add('Activation-worded Bitron lock lifts on negated activation',[[259247807,F],[259546637,D],[body,H],[wing,H],[spell,H],[helper,H],[dark,F,1]],[259247807,helper],[[body,G],[259546637,G]],{family:259247807,bitronCopy:true,activateWordingControl:true,heartbeatNegate:true,activationNegation:true,pick:body,expectedFamilyUses:1,op:'assert(find('+wing+',LOCATION_HAND):IsCanBeSpecialSummoned(e,0,tp,false,false),"Activation-worded restriction lifts after negated activation")'});
 for(const seed of [1,2,3,5,7,8])add('Joyous native die banish cap seed '+seed,[[255668557,G],[body,F],[helper,H],[wing,G,1],[spell,G,1],[trap,G,1],[fusion,G,1]],[helper,body],[],{family:255668557,heartbeatMaterial:true,joyousDice:true,diceSeed:seed,selectMax:true,expectedRecipient:[255668557],op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find(255668557,LOCATION_GRAVE)))'});
 for(const code of [230812008,232100722,243420199])add('Brigade GY restriction under official Necrovalley '+code,[[code,code===243420199?G:H],[body,F],[wing,G],[47355498,H],[helper,H]],[helper],[[code,code===243420199?G:H],[wing,G]],{family:code,necroValley:true,specialAvailability:code===232100722?false:undefined,forbidden:code===232100722?undefined:code,op:'Duel.MoveToField(find(47355498,LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true)'});
 add('Flowering banished cost remains legal under Necrovalley',[[232100722,H],[body,F],[wing,B],[47355498,H],[helper,H]],[helper,232100722],[[232100722,F],[wing,D]],{family:232100722,necroValley:true,procedureSource:true,op:'Duel.MoveToField(find(47355498,LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true)'});
 for(const code of [230812008,243420199])add('Chained official Necrovalley blocks Brigade GY movement '+code,[[code,code===230812008?H:G],[body,F],[wing,G],[47355498,H,1],[dark,F,1]],[code],[[code,code===230812008?H:B],[wing,G]],{family:code,necroValley:true,chainNecro:true,expectedFamilyUses:1,blockedRecipient:code===243420199?body:undefined,pick:wing});
 {const t=testCases.find(t=>t.name==='Companion Team summons on opponent attack');testCases.push({...t,name:'Companion Team summons from hand on attack',setup:t.setup.map(([code,loc,...rest])=>[code,code===wing?H:loc,...rest])});}
 add('Venus Flytrap shared Chain limit across copies',[[284639726,F],[284639726,F],[body,F],[wing,F],[helper,H]],[helper,284639726],[],{family:284639726,chainLimitCopies:true,actionDescription:132639726*16+1,activationSequence:5,pick:body,expectedFamilyUses:1,op:'Duel.MoveSequence(find(284639726,LOCATION_MZONE),5)'});
 if(process.argv.includes('--shared-chain-no-flag')||process.argv.includes('--shared-chain-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.chainLimitCopies));
 add('Megalopyge shared Chain limit across copies',[[259179054,G],[259179054,F],[body,F],[wing,G],[helper,H]],[helper],[[wing,H]],{family:259179054,megalSharedChain:true,chainStartDescription:133179054*16,expectedFamilyUses:1,op:'local c=find(259179054,LOCATION_GRAVE) c:CompleteProcedure() Duel.SpecialSummon(c,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)'});
 if(process.argv.includes('--megal-chain-no-flag'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.megalSharedChain));
 add('Disccs shared Chain guard and reset callbacks',[[238273770,F],[238273770,F],[wing,D],[helper,H],[helper,H]],[helper,helper],[],{family:238273770,disccsChainCallbacks:true,expectedFamilyUses:0,op:'local cs=_G["c238273770"] local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,238273770) assert(#g==2,"Two real copies present") local a=g:GetFirst() local b=g:GetNext() local ea=Effect.CreateEffect(a) ea:SetType(EFFECT_TYPE_SINGLE) ea:SetCode(EFFECT_UPDATE_ATTACK) ea:SetValue(0) a:RegisterEffect(ea) local eb=ea:Clone() b:RegisterEffect(eb) if Duel.GetFlagEffect(tp,900009100)==0 then assert(cs.searchcost(ea,tp,nil,0,0,nil,0,0,0),"Search legal before flag") assert(cs.returncost(eb,tp,nil,0,0,nil,0,0,0),"Other copy recruit legal before flag") cs.searchcost(ea,tp,nil,0,0,nil,0,0,1) assert(not cs.searchcost(eb,tp,nil,0,0,nil,0,0,0),"Other copy search blocked in Chain") assert(not cs.returncost(eb,tp,nil,0,0,nil,0,0,0),"Other copy recruit blocked in Chain") assert(not cs.chaincon(eb,tp),"Shared material condition guard blocked") Duel.RegisterFlagEffect(tp,900009100,0,0,1) else assert(Duel.GetFlagEffect(tp,238274170)==0,"Shared guard resets after Chain") assert(cs.searchcost(eb,tp,nil,0,0,nil,0,0,0),"Search legal next Chain") assert(cs.returncost(eb,tp,nil,0,0,nil,0,0,0),"Recruit legal next Chain") end'});
 if(process.argv.includes('--disccs-chain-no-flag'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.disccsChainCallbacks));
 for(const [code,boss] of [[224751741,223512283],[239245471,245099829]])add('Azrynior GY recovery after battle '+code,[[code,G],[boss,F],[wing,G],[dark,F,1]],[],[[code,H],[boss,G]],{family:code,eventBattleBoss:boss,battle:true,pick:boss,expectedFamilyUses:1});
 for(const code of [259669838,259883230])for(const valid of [true,false])add('Opponent-card leave trigger battle '+code+' matching '+valid,[[code,code===259669838?G:T],[body,F],...(code===259669838?[[wing,G]]:[]),[dark,F,1]],[],[[code,valid?(code===259669838?E:G):(code===259669838?G:T)]],{family:code,opponentCardBattle:valid?'matching':'wrong-set',battle:true,pick:body,expectedFamilyUses:valid?1:0,expectedHandCount:code===259883230?(valid?1:0):undefined});
 for(const code of [218142234,238273772])for(const full of [false,true])add('Leave-field Pendulum battle '+code+' full '+full,[[code,F],[dark,F,1],...(full?[[body,H],[wing,H],[helper,H]]:[])],full?[helper]:[],[[code,full?E:T]],{family:code,pendulumLeaveBattle:true,originsFullPendulum:full,battle:true,pick:code,expectedFamilyUses:full?0:1,op:full?'Duel.MoveSequence(e:GetHandler(),2) Duel.MoveToField(find('+body+',LOCATION_HAND),tp,tp,LOCATION_PZONE,POS_FACEUP,true) Duel.MoveToField(find('+wing+',LOCATION_HAND),tp,tp,LOCATION_PZONE,POS_FACEUP,true) assert(not Duel.CheckLocation(tp,LOCATION_PZONE,0),"Left occupied") assert(not Duel.CheckLocation(tp,LOCATION_PZONE,1),"Right occupied")':''});
 for(const xyz of [true,false])add('Urphiel battle leave revival proper Xyz '+xyz,[[urphiel,G],[body,G],[wing,G],[helper,H],[dark,F,1]],[helper],[[urphiel,G],[body,xyz?F:G],[wing,xyz?F:G]],{family:urphiel,urphielLeave:true,urphielBattleLeave:true,battle:true,pick:urphiel,selectMax:true,expectedFamilyUses:xyz?1:0,op:'local c=find('+urphiel+',LOCATION_GRAVE) Duel.SpecialSummon(c,'+(xyz?'SUMMON_TYPE_XYZ':'0')+',tp,tp,true,true,POS_FACEUP) c:CompleteProcedure()'});
 if(process.argv.includes('--pendulum-leave-no-damage'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.pendulumLeaveBattle&&!t.originsFullPendulum));
 if(process.argv.includes('--leave-field-no-damage'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.pendulumLeaveBattle||t.urphielBattleLeave||t.eventBattleBoss||t.opponentCardBattle||t.revengeRevive&&t.battle));
 for(const code of [212413422,216620496,253128790,259542408,259605536])for(const phase of ['main','damage']){const loc=code===212413422?B:code===216620496?G:code===253128790?H:code===259605536?T:F;const remove='local c=find('+body+','+(code===253128790?'LOCATION_MZONE':code===259605536?'LOCATION_EXTRA':'LOCATION_GRAVE')+') assert(c,"Resource found") Duel.Remove(c,'+(code===259605536?'POS_FACEDOWN':'POS_FACEUP')+',REASON_EFFECT)';add('Banishment field trigger phase '+phase+' '+code,[[code,loc],[body,code===253128790?F:code===259605536?E:G],[wing,F],[helper,H],[dark,F,1]],[helper],phase==='damage'?[[code,loc],[body,B]]:[[code,code===212413422?D:code===216620496?B:code===259605536?T:F],...(code===212413422?[[body,G]]:code===216620496?[[body,H]]:code===259542408?[[dark,G,1]]:code===259605536?[[dark,B,1]]:[[body,B]])],{family:code,damageBanishEvent:true,damageBanishPhase:phase,battle:phase==='damage',pick:wing,expectedFamilyUses:phase==='main'?1:0,op:phase==='main'?remove:'local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) ex:SetCode(EVENT_BATTLE_START) ex:SetCountLimit(1) ex:SetOperation(function() assert(Duel.GetCurrentPhase()==PHASE_DAMAGE,"Native Damage Step reached") '+remove+' end) Duel.RegisterEffect(ex,tp)'});}
 if(process.argv.includes('--damage-banish-permissive'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.damageBanishEvent&&t.damageBanishPhase==='damage'));
 if(process.argv.includes('--damage-banish-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.damageBanishEvent));
 add('Loving material excludes face-down banished Trap',[[230812008,G],[body,F],[trap,B],[helper,H]],[helper],[[trap,B]],{family:230812008,lovingMaterial:true,heartbeatMaterial:true,banishedTrapFacedown:true,forbidden:body,expectedRecipient:[230812008],op:'Duel.Overlay(find('+body+',LOCATION_MZONE),Group.FromCards(find(230812008,LOCATION_GRAVE)))'});
 for(const [code,msg] of [[249680945,133680945],[235538173,133538173],[215768254,133768254]])for(const mode of ['normal','removed','blink'])add('Gravinity Continuous Trap interruption '+code+' '+mode,[[code,H],[body,D],[helper,H],...(mode==='normal'?[]:[[dark,F,1]])],[helper,code],[[code,mode==='removed'?G:T],[body,mode==='normal'?(code===249680945?H:T):D]],{family:code,gravinityInterrupt:mode,actionDescription:msg*16+1,expectedFamilyUses:1,op:'local c=find('+code+',LOCATION_HAND) Duel.MoveToField(c,tp,tp,LOCATION_SZONE,POS_FACEUP,true) _G["c'+code+'"].trapify(c)'});
 if(process.argv.includes('--gravinity-interruption-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.gravinityInterrupt));
 for(const code of [256172827,249680945,235538173,215768254])add('Gravinity trap type survives negation '+code,[[code,H],[helper,H]],[code,helper],[[code,T]],{family:code,gravinityTypeNegation:true,expectedFamilyUses:1,op:'local c=find('+code+',LOCATION_SZONE) assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Placed as Continuous Trap") local dis=Effect.CreateEffect(e:GetHandler()) dis:SetType(EFFECT_TYPE_SINGLE) dis:SetCode(EFFECT_DISABLE) c:RegisterEffect(dis) local dis2=dis:Clone() dis2:SetCode(EFFECT_DISABLE_EFFECT) c:RegisterEffect(dis2) Duel.AdjustInstantly(c) assert(c:IsDisabled(),"Effects actually negated") assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Applied Trap type survives negation")'});
 for(const code of [212429024,238184015,256831125])add('Gravinity placement helper type survives negation '+code,[[code,G],[body,H],[helper,H]],[helper],[[body,T]],{family:code,gravinityTypeHelper:true,expectedFamilyUses:0,op:'local c=find('+body+',LOCATION_HAND) Duel.MoveToField(c,tp,tp,LOCATION_SZONE,POS_FACEUP,true) _G["c'+code+'"].trapify(c) assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Placed as Continuous Trap") local dis=Effect.CreateEffect(e:GetHandler()) dis:SetType(EFFECT_TYPE_SINGLE) dis:SetCode(EFFECT_DISABLE) c:RegisterEffect(dis) local dis2=dis:Clone() dis2:SetCode(EFFECT_DISABLE_EFFECT) c:RegisterEffect(dis2) Duel.AdjustInstantly(c) assert(c:IsDisabled(),"Effects actually negated") assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Applied Trap type survives negation")'});
 add('Transfer Call applied Trap type survives negation',[[223505382,H],[body,D],[helper,H]],[223505382,helper],[[body,T]],{family:223505382,gravinityTypeTransfer:true,expectedFamilyUses:1,op:'local c=find('+body+',LOCATION_SZONE) assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Placed as Continuous Trap") local dis=Effect.CreateEffect(e:GetHandler()) dis:SetType(EFFECT_TYPE_SINGLE) dis:SetCode(EFFECT_DISABLE) c:RegisterEffect(dis) local dis2=dis:Clone() dis2:SetCode(EFFECT_DISABLE_EFFECT) c:RegisterEffect(dis2) Duel.AdjustInstantly(c) assert(c:IsDisabled(),"Effects actually negated") assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Applied Trap type survives negation")'});
 for(const t of testCases.filter(t=>t.gravinityTypeNegation||t.gravinityTypeHelper||t.gravinityTypeTransfer)){const i=t.op.indexOf('assert(c:GetType()');testCases.push({...t,name:t.name.replace('survives negation','survives setting'),gravinitySetReset:true,op:t.op.slice(0,i)+'assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Placed as Continuous Trap") Duel.ChangePosition(c,POS_FACEDOWN_DEFENSE) assert(c:IsFacedown(),"Actually turned face-down") Duel.ChangePosition(c,POS_FACEUP_ATTACK) assert(c:IsFaceup(),"Actually turned face-up") assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Applied Trap type survives setting")'});}
 for(const t of testCases.filter(t=>(t.gravinityTypeNegation||t.gravinityTypeHelper||t.gravinityTypeTransfer)&&!t.gravinitySetReset)){const i=t.op.indexOf('assert(c:GetType()');testCases.push({...t,name:t.name.replace('survives negation','resets after leaving'),gravinityLeaveReset:true,expected:[[t.gravinityTypeHelper||t.gravinityTypeTransfer?body:t.family,G]],op:t.op.slice(0,i)+'assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Placed as Continuous Trap") assert(Duel.SendtoGrave(c,REASON_EFFECT)>0,"Actually left field") assert(c:IsLocation(LOCATION_GRAVE),"Reached GY") assert(c:GetType()==c:GetOriginalType(),"Applied Trap type resets after leaving")'});}
 if(process.argv.includes('--gravinity-type-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.gravinityTypeNegation||t.gravinityTypeHelper||t.gravinityTypeTransfer));
 for(const mode of ['two-columns','one-column','wrong-columns'])add('Gravity Protection column shuffle '+mode,[[247919552,H],[body,T],[wing,T],[dark,F,1],[spell,F,1],[fusion,F,1],[trap,T,1],[helper,H],...(mode==='two-columns'?[[247919552,H]]:[])],mode==='wrong-columns'?[helper]:[helper,247919552],[[body,mode==='wrong-columns'?T:D],[wing,mode==='two-columns'?D:T],[fusion,F,1],...(mode==='wrong-columns'?[]:[[247919552,G]]),...(mode==='two-columns'?[[247919552,H]]:[])],{family:247919552,gravinityColumn:mode,selectMax:true,forbidden:247919552,expectedFamilyUses:mode==='wrong-columns'?0:1,op:'_G["c247919552"].trapify(find('+body+',LOCATION_SZONE)) _G["c247919552"].trapify(find('+wing+',LOCATION_SZONE)) '+(mode==='wrong-columns'?'':'Duel.MoveSequence(Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+dark+'),4) Duel.MoveSequence(Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_SZONE,nil,'+trap+'),4) ')+(mode==='two-columns'?'Duel.MoveSequence(Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+spell+'),3)':'')});
 if(process.argv.includes('--gravinity-column-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.gravinityColumn));
 for(const mode of ['two-slots','one-slot','wrong-set'])add('Gravity Protection Trap placement '+mode,[[247919552,H],[body,F],[wing,G],[helper,H],...(mode==='one-slot'?[[spell,T],[trap,T],[fusion,T]]:[])],mode==='wrong-set'?[]:[247919552,helper],[[body,mode==='wrong-set'?F:T],[wing,mode==='two-slots'?T:G]],{family:247919552,gravinityPlace:mode,selectMax:true,forbidden:247919552,expectedFamilyUses:mode==='wrong-set'?0:1,op:'for _,code in ipairs({'+body+','+wing+'}) do local c=find(code,LOCATION_SZONE) if c then assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Actual placed Continuous Trap") end end'});
 for(const mode of ['valid','wrong-material-set','wrong-Synchro-set'])add('Gravity Protection Synchro '+mode,[[247919552,H],[body,F],[wing,F],[fusion,E],[spell,T],[spell,T],[spell,T],[spell,T],[helper,H]],mode==='valid'?[helper,247919552]:[helper],[[fusion,mode==='valid'?F:E],[body,mode==='valid'?G:F],[wing,mode==='valid'?G:F]],{family:247919552,gravinitySynchro:mode,op:'Duel.RegisterFlagEffect(tp,247919552,RESET_PHASE+PHASE_END,0,1)',forbidden:mode==='valid'?undefined:247919552,expectedFamilyUses:mode==='valid'?1:0});
 if(process.argv.includes('--gravity-protection-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.gravinityColumn||t.gravinityPlace||t.gravinitySynchro));
 for(const code of [247919552,223505382])for(const set of [false,true])for(const n of [3,4]){const ok=n===3;add('Gravinity Spell placement capacity '+code+' set '+set+' occupied '+n,[[code,set?T:H],[body,code===223505382?D:G],...Array.from({length:n},()=>[spell,T]),[helper,H]],ok?[code,helper]:[],[[body,ok?T:code===223505382?D:G],[code,ok?G:set?T:H]],{family:code,gravinityPlacementCapacity:true,setSourceSpell:set,forbidden:ok?undefined:code,expectedFamilyUses:ok?1:0,op:'local c=find('+body+',LOCATION_SZONE) assert(c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS,"Placement retained available slot")'});}
 if(process.argv.includes('--placement-capacity-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.gravinityPlacementCapacity));
 for(const set of [false,true])for(const n of [3,4]){const ok=n===3;add('Galataxian Trap placement capacity set '+set+' occupied '+n,[[210696007,set?T:H],[body,B],...Array.from({length:n},()=>[spell,T]),...(set?[]:[[helper,H]])],set?(ok?[210696007]:[]):(ok?[helper,210696007]:[helper]),[[body,ok?T:B],[210696007,ok?G:set?T:H]],{family:210696007,galacticPlacementCapacity:true,setSourceSpell:set,forbidden:ok?undefined:210696007,expectedFamilyUses:ok?1:0,op:'local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD) ex:SetCode(EFFECT_TRAP_ACT_IN_HAND) ex:SetTargetRange(LOCATION_HAND,0) Duel.RegisterEffect(ex,tp)'});}
 for(const n of [2,3])add('Windborne Set target capacity occupied '+n,[[233212369,H],[body,G],[wing,G],...Array.from({length:n},()=>[spell,T])],[233212369],[[body,T],[wing,n===2?T:G]],{family:233212369,windborneCapacity:4-n,option:1,selectMax:true,expectedFamilyUses:1});
 for(const n of [3,4])add('Windborne only Set mode capacity occupied '+n,[[233212369,H],[body,G],...Array.from({length:n},()=>[spell,T])],n===3?[233212369]:[],[[body,n===3?T:G]],{family:233212369,windborneOnlySet:true,forbidden:n===4?233212369:undefined,expectedFamilyUses:n===3?1:0});
 for(const code of [210696007,233212369])for(const mode of ['field-only-full','field-plus-normal','two-fields']){const loc=code===210696007?B:G;add('Set capacity independent Field Zone '+code+' '+mode,[[code,H],[body,loc],...(mode==='field-only-full'?[[fusion,H]]:[[wing,loc]]),...Array.from({length:mode==='field-plus-normal'?3:4},()=>[spell,T]),[helper,H]],[helper,code],[[body,mode==='field-plus-normal'?T:L.FZONE],...(mode==='field-only-full'?[[fusion,G]]:mode==='two-fields'?[[wing,loc]]:[[wing,L.FZONE]])],{family:code,capacityField:mode,sequentialActions:true,selectMax:true,option:1,expectedFamilyUses:1,op:'local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD) ex:SetCode(EFFECT_TRAP_ACT_IN_HAND) ex:SetTargetRange(LOCATION_HAND,0) Duel.RegisterEffect(ex,tp) '+(mode==='field-only-full'?'Duel.MoveToField(find('+fusion+',LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true)':'')});}
 if(process.argv.includes('--activation-capacity-family-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.gravinityPlacementCapacity||t.galacticPlacementCapacity||t.windborneCapacity||t.windborneOnlySet||t.capacityField));
 for(const code of [239932270,239935100,259766646,259820516,259826112])for(const mode of ['room','last-slot',...([239932270,259766646,259820516].includes(code)?['field-zone']:[])]){const ok=mode!=='last-slot',grave=code===239935100;add('Activation placement follow-up '+code+' '+mode,[[code,H],[body,grave?G:D],...Array.from({length:mode==='room'?3:4},()=>[spell,T]),...(code===259766646?[[70155677,H]]:[]),...(code===259820516?[[wing,F]]:[]),...(code===259826112?[[helper,H]]:[])],code===259826112?(ok?[helper,code]:[helper]):ok?[code]:[],[[body,ok&&code!==239935100?(mode==='field-zone'?L.FZONE:T):grave?G:D],[code,ok?G:H],...(code===259766646&&ok?[[70155677,E]]:[])],{family:code,capacityFollowup:mode,forbidden:ok?undefined:code,expectedFamilyUses:ok?1:0,expectedPlacement:code===239935100?ok:undefined,op:'local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD) ex:SetCode(EFFECT_TRAP_ACT_IN_HAND) ex:SetTargetRange(LOCATION_HAND,0) Duel.RegisterEffect(ex,tp)'});}
 if(process.argv.includes('--capacity-followup-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.capacityFollowup));
 for(const set of [false,true])add('Crewal Meeting placement cost frees zone set '+set,[[210366076,set?T:H],[body,D],[trap,T],[spell,T],[spell,T],[spell,T]],[210366076],[[body,T],[trap,G],[210366076,G]],{family:210366076,capacityCostRelease:true,setSourceSpell:set,expectedFamilyUses:1});
 for(const set of [false,true])for(const n of [3,4]){const ok=n===3;add('Red-Eyes Roar additional equip space set '+set+' occupied '+n,[[259562343,set?T:H],[body,F],[wing,G],...Array.from({length:n},()=>[spell,T]),[helper,H]],ok?[259562343,helper]:[],[[259562343,ok?G:set?T:H],[wing,ok?T:G]],{family:259562343,roarEquipCapacity:true,setSourceSpell:set,forbidden:ok?undefined:259562343,expectedFamilyUses:ok?1:0,op:'local ec=find('+wing+',LOCATION_SZONE) assert(ec:GetEquipTarget()==find('+body+',LOCATION_MZONE),"Actual extra monster equipped")'});}
 add('Red-Eyes Roar search remains legal in final slot',[[259562343,H],[body,F],[wing,D],[spell,T],[spell,T],[spell,T],[spell,T]],[259562343],[[259562343,G],[wing,H]],{family:259562343,roarEquipCapacity:true,expectedFamilyUses:1});
 for(const code of [219047593,229875953,248801935])add('Self Equip uses activating card slot '+code,[[code,H],[body,F],[spell,T],[spell,T],[spell,T],[spell,T]],[code],[[code,T],[body,F]],{family:code,selfEquipCapacity:true,expectedFamilyUses:1,op:'assert(find('+code+',LOCATION_SZONE):GetEquipTarget()==find('+body+',LOCATION_MZONE),"Activating card itself equipped in final slot")'});
 if(process.argv.includes('--roar-capacity-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.roarEquipCapacity||t.selfEquipCapacity));
 for(const mode of ['field-GY-full','field-banished-full','Trap-GY-full','Trap-GY-room','field-banished-facedown-full','wrong-set-field-GY-full']){const field=mode.includes('field'),full=mode.endsWith('full'),ok=(field||!full)&&!mode.includes('facedown')&&!mode.startsWith('wrong-set');add('Galaxix recovered Set capacity '+mode,[[249454272,G],[body,mode.includes('banished')?B:G],[helper,F],...Array.from({length:full?5:4},()=>[spell,T])],[helper],[[body,ok?(field?L.FZONE:T):mode.includes('banished')?B:G]],{family:249454272,galaxixFieldRecovery:mode,expectedFamilyUses:ok?1:0});}
 for(const mode of ['field-GY-full','Trap-GY-room']){const t=testCases.find(t=>t.name==='Galaxix recovered Set capacity '+mode);testCases.push({...t,name:'Galaxix recovered card activates same turn '+mode,steps:[helper,body],expected:[[body,mode.startsWith('field')?L.FZONE:G]]});}
 if(process.argv.includes('--galaxix-recovery-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.galaxixFieldRecovery));
 for(const mode of ['field-Deck-full','field-GY-full','field-banished-full','field-banished-facedown-full','Trap-GY-full','Trap-GY-room']){const field=mode.startsWith('field'),full=mode.endsWith('full'),ok=(field||!full)&&!mode.includes('facedown'),resource=field?34572613:body,loc=mode.includes('Deck')?D:mode.includes('banished')?B:G;add('Myutant Amalgamate recovered Set capacity '+mode,[[211699737,G],[resource,loc],[helper,F],...Array.from({length:full?5:4},()=>[spell,T])],[helper],[[resource,ok?(field?L.FZONE:T):loc]],{family:211699737,myutantRecovery:mode,expectedFamilyUses:ok?1:0});}
 if(process.argv.includes('--myutant-recovery-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.myutantRecovery));
 const pastrygeist=259851064,mansion=99795159;
 for(const fromDeck of [true,false])for(const kind of ['field','trap','monster'])for(const full of [false,true]){
  const resource={field:mansion,trap:body,monster:wing}[kind],loc=fromDeck?D:G;
  const occupied=kind==='monster'?F:T,legal=!full||kind==='field';
  const fillers=Array.from({length:full?(occupied===F?(fromDeck?3:4):5):0},()=>[dark,occupied]);
  if(occupied===T)for(const slot of fillers)slot[0]=spell;
  const steps=fromDeck&&legal?[helper,pastrygeist]:[helper];
  const op=fromDeck?'Duel.Overlay(find('+pastrygeist+',LOCATION_MZONE),Group.FromCards(find('+link+',LOCATION_GRAVE)))':'Duel.SendtoGrave(find('+pastrygeist+',LOCATION_EXTRA),REASON_EFFECT)';
  add('Pastrygeist '+(fromDeck?'Deck':'GY')+' '+kind+' '+(full?'full':'open'),
   [[pastrygeist,fromDeck?F:E],[resource,loc],[helper,F],[link,G],...fillers],steps,
   [[resource,legal?{field:L.FZONE,trap:T,monster:F}[kind]:loc]],
   {family:pastrygeist,pastrygeistSet:true,blockedDeckSet:fromDeck&&!legal,actionDescription:133851064*16,expectedFamilyUses:legal?1:0,op});
 }
 const mirage=259072169,huntingGround=75782277,harpieLady=76812113;
 for(const mode of ['field-open','field-full','trap-full','mixed']){
  const field=mode!=='trap-full',trapResource=mode==='trap-full'||mode==='mixed';
  const slots=mode==='field-open'?0:mode==='mixed'?4:5;
  add('Mirage Formation Dragon Set capacity '+mode,
   [[mirage,E],[helper,F],...(mode==='mixed'?[[harpieLady,F]]:[]),...(field?[[huntingGround,D]]:[]),
    ...(trapResource?[[body,D]]:[]),...Array.from({length:slots},()=>[spell,T])],
   [helper], [...(field?[[huntingGround,L.FZONE]]:[]),...(trapResource?[[body,mode==='mixed'?T:D]]:[])],
   {family:mirage,mirageSet:true,selectMax:true,expectedFamilyUses:field?1:0,
    op:'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,'+mirage+') assert(Duel.SpecialSummon(c,0,tp,tp,false,true,POS_FACEUP)>0)'});
 }
 const solemnRebirth=224049334;
 for(const mode of ['field','mixed','ordinary','cost-frees-slot','too-many','destroyed-source','only-destroyed-source']){
  const hasField=mode==='field'||mode==='mixed',hasTrap=mode!=='field';
  const source=['cost-frees-slot','destroyed-source','only-destroyed-source'].includes(mode)?T:G;
  const fill=mode==='cost-frees-slot'||mode==='too-many'||mode==='destroyed-source';
  const onlySource=mode==='only-destroyed-source';
  const codes=[...(hasField?[wing]:[]),...(hasTrap&&!onlySource?[body]:[]),...(mode==='too-many'?[trap]:[]),...(mode==='destroyed-source'||onlySource?[solemnRebirth]:[])];
  const legal=mode!=='field'&&mode!=='too-many'&&!onlySource;
  const opponentOp='local g=Duel.GetMatchingGroup(function(c) return c:IsCode('+codes.join(',')+') end,tp,0,LOCATION_ONFIELD,nil) '
   +'assert(Duel.Destroy(g,REASON_EFFECT)=='+codes.length+') '
   +(fill?'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_HAND,nil,'+fusion+') assert(Duel.MoveToField(c,tp,1-tp,LOCATION_SZONE,POS_FACEDOWN,true)) ':'');
  add('Solemn Rebirth Set destination '+mode,
   [[solemnRebirth,source],...(hasField?[[wing,L.FZONE]]:[]),...(hasTrap&&!onlySource?[[body,T]]:[]),...(mode==='too-many'?[[trap,T]]:[]),
    ...Array.from({length:fill?3:0},()=>[spell,T]),
    ...(fill?[[fusion,H]]:[]),[dark,H,1]],
   [],[[solemnRebirth,legal?B:onlySource?G:source],...(hasField?[[wing,G]]:[]),...(hasTrap&&!onlySource?[[body,legal?T:G]]:[]),...(mode==='too-many'?[[trap,G]]:[])],
   {family:solemnRebirth,solemnSet:true,rewrite:true,noRewrite:!legal,expectedFamilyUses:legal?1:0,opponentOp});
 }
 for(const code of [210696007,233212369]){
  const baseline=testCases.find(t=>t.family===code&&t.capacityField==='field-plus-normal');
  const loc=code===210696007?B:G;
  testCases.push({...baseline,name:'Set capacity after chain fills row '+code,
   setup:[...baseline.setup,[fusion,H],[dark,F,1]],
   expected:[[body,loc],[wing,L.FZONE],[fusion,T]],setCapacityChain:true});
 }
 const cutifer=228472690,ghostSlime=257677549;
 for(const mode of ['field-full','field-replace','trap-open','trap-full','monster-open','monster-full']){
  const field=mode.startsWith('field'),monster=mode.startsWith('monster');
  const legal=field||!mode.endsWith('full');
  const resourceLocation=field?L.FZONE:monster?F:T;
  add('Ghostrick Cutifer steals a Set card '+mode,
   [[cutifer,F],[wing,resourceLocation,1],[link,G],[helper,F],
    ...(mode==='field-replace'?[[body,L.FZONE]]:[]),
    ...Array.from({length:mode.endsWith('full')?(monster?3:5):0},()=>monster?[dark,F]:[spell,T])],
   legal?[helper,cutifer]:[helper],
   [[wing,resourceLocation,legal?0:1],...(mode==='field-replace'?[[body,G]]:[])],
   {family:cutifer,cutiferSet:mode,actionDescription:132472690*16+1,expectedFamilyUses:legal?1:0,forbidden:legal?undefined:cutifer,
    op:'Duel.Overlay(find('+cutifer+',LOCATION_MZONE),Group.FromCards(find('+link+',LOCATION_GRAVE)))'});
 }
 for(const target of ['monster','link']){
  add('Ghostrick Slime can respond to a summoned '+target,
   [[ghostSlime,H],[dark,F,1],[wing,G,1]],[],[[ghostSlime,F],[wing,F,1]],
   {family:ghostSlime,slimeTarget:target,rewrite:true,monsterActivation:true,yes:true,noYes:target==='link',expectedFamilyUses:1,
    opponentOp:'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+wing+') assert(Duel.SpecialSummon(c,0,tp,tp,true,true,POS_FACEUP_ATTACK)>0)'});
 }
 if(process.argv.includes('--field-recovery-family-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.setCapacityChain||t.solemnSet||t.mirageSet||t.pastrygeistSet||t.myutantRecovery||t.galaxixFieldRecovery));
 const results=[];
 let failures=0;
 if(process.argv.includes('--oni-quick-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.oniQuickRecipient));
 if(process.argv.includes('--ghostrick-destination-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.cutiferSet||t.slimeTarget));
 for(const code of [aeroXyz,259548744])for(const mode of ['open','necro',...(code===259548744?['banished']:[])]){
  const loc=mode==='banished'?B:G, blocked=mode==='necro';
  add('Aerocat GY attachment '+code+' '+mode,
   [[code,G],[wing,loc],[helper,H],...(mode!=='open'?[[47355498,H]]:[])],[helper],
   blocked?[[wing,G]]:[],
   {family:code,aeroNecro:true,yes:true,noYes:blocked,verifyOverlay:!blocked,
    overlayHost:code,overlayMaterial:wing,expectedFamilyUses:1,
    op:(mode!=='open'?'Duel.MoveToField(find(47355498,LOCATION_HAND),tp,tp,LOCATION_FZONE,POS_FACEUP,true) ':'')
     +'local c=find('+code+',LOCATION_GRAVE) assert(Duel.SpecialSummon(c,SUMMON_TYPE_XYZ,tp,tp,true,true,POS_FACEUP)>0)'});
 }
 if(process.argv.includes('--aero-necro-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.aeroNecro));
 for(const code of [244163199,259113182,259454809,259767503,259748623]){
  const goldenrod=code===244163199;
  for(const mode of ['open','blocked','chained','control-changed','face-down-recipient',...(!goldenrod?['hand']:[])]){
   const loc=mode==='hand'?H:G, blocked=mode==='blocked', chained=mode==='chained';
   const controlChanged=mode==='control-changed';
   const faceDownRecipient=mode==='face-down-recipient';
   const attaches=!blocked&&!chained&&!controlChanged;
   add('Self-attachment under Necrovalley '+code+' '+mode,
    [[code,loc],[body,F],...(blocked||mode==='hand'?[[47355498,L.FZONE]]:[]),...(chained?[[47355498,H,1]]:[]),...(chained||controlChanged||faceDownRecipient?[[dark,F,1]]:[])],
    blocked?[]:[code],attaches?[]:[[code,loc],...(controlChanged?[[body,F,1]]:[])],
    {family:code,selfOverlayNecro:true,chainNecro:chained||controlChanged||faceDownRecipient,overlayControlChanged:controlChanged,faceDownRecipient,yes:false,expectedFamilyUses:blocked?0:1,
     actionDescription:(goldenrod?132163199*16+2:(code-126000000)*16+2),
     verifyOverlay:attaches,overlayHost:body,overlayMaterial:code,blockedRecipient:attaches||controlChanged?undefined:body});
  }
 }
 add('Orb does not attach after its recipient changes control',[[orb,G],[body,F],[dark,F,1]],[orb],[[orb,G],[body,F,1]],
  {family:orb,arcGY:true,selfOverlayNecro:true,chainNecro:true,overlayControlChanged:true,expectedFamilyUses:1});
 add('Orb attaches to its face-down recipient',[[orb,G],[body,F],[dark,F,1]],[orb],[],
  {family:orb,arcGY:true,selfOverlayNecro:true,chainNecro:true,faceDownRecipient:true,
   expectedFamilyUses:1,verifyOverlay:true,overlayHost:body,overlayMaterial:orb});
 for(const mode of ['open','control changed','face-down recipient']){
  const stolen=mode==='control changed',faceDownRecipient=mode==='face-down recipient';
  add('Nautical Adventures native Xyz trigger '+mode,
  [[218905439,G],[body,E],[wing,F],[fusion,F],...(stolen||faceDownRecipient?[[dark,F,1]]:[])],[body],
  [[body,F,stolen?1:0],...(stolen?[[218905439,G]]:[])],
  {family:218905439,nauticaOverlay:true,materialNative:true,standardXyz:true,selfOverlayNecro:true,
   chainNecro:stolen||faceDownRecipient,overlayControlChanged:stolen,faceDownRecipient,expectedFamilyUses:1});
 }
 for(const mode of ['detach-cost','detach-effect','host-leaves','wrong-attribute','two-copies']){
  const family=218905439;
  const removes=mode.startsWith('detach')||mode==='host-leaves';
  const host='find('+body+',LOCATION_MZONE)';
  const operations={
   'detach-cost':'assert('+host+':RemoveOverlayCard(tp,1,1,REASON_COST))',
   'detach-effect':'assert(Duel.SendtoGrave('+host+':GetOverlayGroup():Filter(Card.IsCode,nil,'+family+'),REASON_EFFECT)==1)',
   'host-leaves':'assert(Duel.SendtoGrave('+host+',REASON_EFFECT)==1)'
  };
  const expected=mode.startsWith('detach')?[[family,B]]:mode==='host-leaves'?[[family,G],[body,G]]:
   mode==='wrong-attribute'||mode==='two-copies'?[[family,G]]:[];
  add('Nautical Adventures Xyz attachment '+mode,
   [[family,G],[body,E],[wing,F],[fusion,F],...(removes?[[helper,H]]:[]),...(mode==='two-copies'?[[family,G]]:[])],
   removes?[body,helper]:[body],expected,
   {family,nauticaOverlay:true,adventuresOverlay:mode,materialNative:true,standardXyz:true,selfOverlayNecro:true,
    expectedFamilyUses:Number(mode!=='wrong-attribute'),op:operations[mode],pick:removes?family:undefined});
 }
 {
  const family=218905439;
  add('Nautical Adventures Trap use permits a same-turn Xyz attachment',
   [[family,T],[family,T],[family,G],[body,E],[wing,F],[fusion,F],[spell,F],[trap,F],[dark,F,1],[dark,H,1],[dark,H,1]],
   [family,body,family],[[spell,H],[trap,H],[dark,F,1]],{family,nauticaOverlay:true,adventuresOverlay:'independent',
    materialNative:true,standardXyz:true,selfOverlayNecro:true,expectedFamilyUses:3,setSourceSpell:true,
    sequentialActions:true,pick:spell});
 }
 {
  const family=218905439;
  add('Nautical Adventures GY use resets for another WATER Xyz Summon',
   [[family,G],[family,G],[body,E],[body,E],[wing,F],[fusion,F],[spell,F],[link,F]],
   [body,body],[[body,F]],{family,nauticaOverlay:true,adventuresOverlay:'grave-reset',
    materialNative:true,standardXyz:true,selfOverlayNecro:true,expectedFamilyUses:2});
 }
 if(process.argv.includes('--self-overlay-necro-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.selfOverlayNecro));
 for(const locked of [false,true])add('Claw self-revival with Necrovalley '+locked,
  [[claw,F],[dark,F,1],...(locked?[[47355498,L.FZONE]]:[])],[],[[claw,F]],
  {family:claw,clawRevive:true,clawSelfRevive:true,rewrite:true,noRewrite:locked,monsterActivation:true,expectedFamilyUses:locked?0:1});
 add('Claw uses the zone freed by its own Tribute',[[claw,F],[dark,F,1],...Array.from({length:4},()=>[wing,F])],[],[[claw,F]],
  {family:claw,clawRevive:true,clawSelfRevive:true,rewrite:true,monsterActivation:true,expectedFamilyUses:1});
 if(process.argv.includes('--claw-self-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.clawSelfRevive));
 for(const level of [3,4,5])add('Shattering Sustained Tribute is the only revival candidate, Level '+level,
  [[248453205,H],[body,F]],level<=4?[248453205]:[],[[body,F]],
  {family:248453205,stainTributeLevel:level,expectedFamilyUses:level<=4?1:0,forbidden:level===5?248453205:undefined});
 for(const mode of ['full-row','mixed-tributes','necrovalley']){
  const blocked=mode==='necrovalley';
  add('Shattering Sustained Tribute '+mode,
   [[248453205,H],[body,F],...(mode==='mixed-tributes'?[[wing,F]]:[]),
    ...(mode==='full-row'?Array.from({length:4},()=>[dark,F]):[]),...(blocked?[[47355498,L.FZONE]]:[])],
   blocked?[]:[248453205],[[body,F],...(mode==='mixed-tributes'?[[wing,F]]:[])],
   {family:248453205,stainTributeLevel:4,stainTributeMode:mode,expectedFamilyUses:blocked?0:1,forbidden:blocked?248453205:undefined});
 }
 for(const visible of [false,true])add('Shattering Sustained opponent Deck Tribute face-up '+visible,
  [[248453205,H],[body,D,1],[wing,G],[helper,H]],visible?[helper,248453205]:[helper],
  [[body,visible?G:D,1],[wing,visible?F:G]],
  {family:248453205,stainTributeLevel:4,stainTributeMode:'opponent-deck',expectedFamilyUses:visible?1:0,
   forbidden:visible?undefined:248453205,pick:body,
   op:visible?'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_DECK,nil,'+body+') tc:ReverseInDeck() assert(tc:IsFaceup())':''});
 add('Shattering Sustained leaves Bria in the Deck when paying with a field Tribute',
  [[225091736,H],[248453205,H],[body,F],[wing,D],[helper,H]],[225091736,248453205],
  [[body,F],[225091736,D,1]],{family:248453205,stainTributeLevel:4,stainBria:true,stainDiscardHelper:true,expectedFamilyUses:1,pick:body,op:''});
 add('Shattering Sustained resolves the optional Deck Tribute with a face-up card at resolution',
  [[248453205,H],[body,F],[wing,D,1],[helper,H]],[helper,248453205],[[body,F],[wing,G,1]],
  {family:248453205,stainTributeLevel:4,stainTributeMode:'opponent-deck',expectedFamilyUses:1,pick:body,yes:true,
   stainOptionalFixture:true,op:''});
 add('Bria remains a Tribute option after a second Stain is placed face-up',
  [[225091736,H],[216958556,G],[248453205,H],[body,F],[wing,D],[wing,D],[helper,H],[dark,F,1]],
  [225091736,216958556,248453205],[[body,F],[225091736,G],[216958556,D,1]],
  {family:248453205,stainTributeLevel:4,stainBria:true,stainTwoPlacements:true,expectedFamilyUses:1,yes:true,pick:body,op:""});
 for(const visible of [false,true])add('Dragar opponent Deck Tribute face-up '+visible,
  [[247580036,G],[wing,D,1],[dark,F,1],[helper,H]],[helper],[[wing,visible?G:D,1]],
  {family:247580036,stainDragar:true,expectedFamilyUses:1,pick:wing,
   op:(visible?'Duel.GetFieldGroup(tp,0,LOCATION_DECK):Filter(Card.IsCode,nil,'+wing+'):GetFirst():ReverseInDeck() ':'')
    +'assert(Duel.SpecialSummon(find(247580036,LOCATION_GRAVE),SUMMON_TYPE_FUSION,tp,tp,true,true,POS_FACEUP)>0)'});
 add('Dragar sets the other monster after its LP target leaves',
  [[247580036,G],[body,F],[wing,F,1],[dark,F,1],[helper,H]],[helper],[[wing,G,1],[dark,F,1]],
  {family:247580036,stainDragar:true,dragarTargetLeaves:true,chainNecro:true,pick:wing,expectedFamilyUses:1,
   op:'assert(Duel.SpecialSummon(find(247580036,LOCATION_GRAVE),SUMMON_TYPE_FUSION,tp,tp,true,true,POS_FACEUP)>0)'});
 for(const attack of [0,1700])add('Dragar resolves both clauses with target ATK '+attack,
  [[247580036,G],[body,F],[wing,F,1],[dark,F,1],[helper,H]],[helper],[[wing,F,1],[dark,F,1]],
  {family:247580036,stainDragar:true,dragarAttack:attack,pick:wing,expectedFamilyUses:1,
   op:'assert(Duel.SpecialSummon(find(247580036,LOCATION_GRAVE),SUMMON_TYPE_FUSION,tp,tp,true,true,POS_FACEUP)>0)'});
 if(process.argv.includes('--stain-tribute-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.stainTributeLevel||t.stainDragar));
 add('Musicale responds to a Nautica hand Summon',[[259797813,T],[helper,H],[body,H],[wing,D,1]],[helper],
  [[body,F],[wing,H,1]],{family:259797813,musicaleSummon:true,expectedFamilyUses:1,pick:wing});
 add('Musicale skips a Nautica GY Summon',[[259797813,T],[helper,H],[body,G],[wing,D,1]],[helper],
  [[body,F],[wing,D,1]],{family:259797813,musicaleSummon:true,musicaleFromGY:true,expectedFamilyUses:0});
 add('Musicale responds when a generic effect Summons Nautica from hand',[[259797813,T],[helper,H],[body,H],[wing,D,1]],[helper],
  [[body,F],[wing,H,1]],{family:259797813,musicaleSummon:true,musicaleGeneric:true,expectedFamilyUses:1,pick:wing});
 for(const report of ['group-only','mixed'])for(const fromGY of [false,true])add(
  'Musicale '+report+' report from '+(fromGY?'GY':'hand'),
  [[259797813,T],[helper,H],[body,fromGY?G:H],[wing,D,1]],[helper],
  [[body,F],[wing,fromGY?D:H,1]],
  {family:259797813,musicaleSummon:true,musicaleGeneric:true,musicaleReport:report,musicaleFromGY:fromGY,expectedFamilyUses:Number(!fromGY),pick:wing});
 for(const fromGY of [false,true])add('Musicale after Yummy Kuriboh summons Harmony from '+(fromGY?'GY':'hand'),
  [[259797813,T],[253152295,H],[226645052,fromGY?G:H],[dark,F,1],[wing,D,1]],[],
  [[253152295,F],[226645052,F],[wing,fromGY?D:H,1]],
  {family:259797813,musicaleYummy:true,battle:true,expectedFamilyUses:Number(!fromGY),pick:wing});
 for(const nautica of [true,false]){
  const waterHazard=49669730, summon=nautica?226645052:body;
  add('Musicale after stock Water Hazard summons '+(nautica?'Harmony':'another WATER monster'),
   [[259797813,T],[waterHazard,T],[summon,H],[wing,D,1]],[waterHazard],
   [[summon,F],[wing,nautica?H:D,1]],
   {family:259797813,musicaleStock:true,musicaleSummon:true,musicaleGeneric:true,expectedFamilyUses:Number(nautica),pick:wing});
 }
 add('Musicale ignores an earlier summon by the same effect instance',
  [[259797813,T],[49669730,T],[226645052,H],[body,H],[wing,D,1],[wing,D,1]],[49669730,49669730],
  [[226645052,F],[body,F],[wing,H,1],[wing,D,1]],
  {family:259797813,musicaleStock:'repeat',musicaleSummon:true,musicaleGeneric:true,expectedFamilyUses:1,pick:wing});
 for(const nautica of [true,false]){
  const transcend=259225324, summon=nautica?226645052:body;
  add('Transcend Pendulum Summon '+(nautica?'Nautica':'other monster')+' from hand',
   [[259797813,T],[transcend,F],[helper,H],[spell,H],[trap,H],[summon,H],[wing,D,1]],
   [helper,transcend],[[summon,F],[wing,D,1]],
   {family:259797813,musicaleTranscend:summon,expectedFamilyUses:0,
    op:'Duel.SendtoGrave(e:GetHandler(),REASON_EFFECT) assert(Duel.MoveToField(find('+spell+',LOCATION_HAND),tp,tp,LOCATION_PZONE,POS_FACEUP,true,1)) assert(Duel.MoveToField(find('+trap+',LOCATION_HAND),tp,tp,LOCATION_PZONE,POS_FACEUP,true,16)) local l,r=Duel.GetFieldCard(tp,LOCATION_PZONE,0),Duel.GetFieldCard(tp,LOCATION_PZONE,1) assert(l and r and l:GetLeftScale()+r:GetRightScale()==8,"Both fixture scales placed")'});
 }
 for(const mode of ['success','redirect','no-candidate','draw-blocked'])add('Musicale opponent search: '+mode,
  [[259797813,T],[helper,H],[body,H],[wing,D,1],[wing,F,1],[wing,G,1],[wing,H,1],[wing,B,1],[dark,F,1]],[helper],
  [[body,F],[wing,mode==='success'?H:mode==='redirect'?G:mode==='draw-blocked'?D:B,1]],
  {family:259797813,musicaleSummon:true,musicaleSearch:mode,expectedFamilyUses:1,pick:wing,opponent:true});
 for(const family of [259797813,248946297])for(const redirect of [false,true])
  add('Nautica activation search '+family+' '+(redirect?'redirect':'success'),
   [[family,family===259797813?T:H],[body,D],[wing,D,1],[dark,F,1]],[family],
   [[body,redirect?G:H],[wing,family===248946297&&!redirect?F:D,1]],
   {family,ownSearch:true,redirect,setSourceSpell:true,yes:true,pick:body});
 add('Musicale activation recovers a Nautica monster from the GY',
  [[259797813,T],[body,G],[dark,F,1]],[259797813],[[body,H]],
  {family:259797813,ownSearch:true,redirect:false,setSourceSpell:true,yes:true,pick:body});
 for(const hasCandidate of [true,false])add('Musicale activation '+(hasCandidate?'declines the optional search':'has no search candidate'),
  [[259797813,T],...(hasCandidate?[[body,D]]:[])],[259797813],hasCandidate?[[body,D]]:[],
  {family:259797813,musicaleActivation:true,setSourceSpell:true,yes:false,noYes:!hasCandidate,expectedFamilyUses:1});
 add('Musicale cannot activate a second copy while controlling the first',
  [[259797813,T],[259797813,H]],[],[[259797813,T],[259797813,H]],
  {family:259797813,musicaleUnique:true,forbidden:259797813,expectedFamilyUses:0});
 for(const family of [226645052,228040066])for(const mode of ['success','decline','redirect',...(family===228040066?['trap']:[])]){
  const origin=family===226645052?D:G;
  add((family===226645052?'Harmony Pearlwood':'Melody Merheart')+' search '+mode,
  [[family,H],[helper,H],[body,origin],[dark,G,1]],[helper],
  [[family,F],[dark,F,1],[body,['success','trap'].includes(mode)?H:mode==='decline'?origin:B]],
  {family,harmonySearch:mode==='trap'?'success':mode,harmonyRecoveryTrap:mode==='trap',yes:mode!=='decline',expectedFamilyUses:1,pick:body,
   op:'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+dark+') assert(Duel.SpecialSummon(tc,0,1-tp,1-tp,false,false,POS_FACEUP)>0)'});
 }
 for(const [family,origin,modes] of [[226645052,D,['self','level','race']],[228040066,G,['self','set']]]){
  for(const mode of modes){
   const target=mode==='self'?family:body;
   add('Nautica Hand trigger rejects search candidate '+family+' '+mode,
    [[family,H],[helper,H],[target,origin],[dark,G,1]],[helper],[[family,F],[target,origin],[dark,F,1]],
    {family,harmonySearch:'decline',harmonyInvalidSearch:mode,noYes:true,expectedFamilyUses:1,
     op:'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+dark+') assert(Duel.SpecialSummon(tc,0,1-tp,1-tp,false,false,POS_FACEUP)>0)'});
  }
 }
 for(const family of [226645052,228040066]){
  const origin=family===226645052?D:G;
  add('Nautica Hand trigger requires a free monster zone '+family,
   [[family,H],[helper,H],[body,origin],[dark,G,1],...Array.from({length:5},()=>[wing,F])],
   [helper],[[family,H],[body,origin],[dark,F,1]],
   {family,harmonySearch:'decline',noYes:true,expectedFamilyUses:0,
    op:'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+dark+') assert(Duel.SpecialSummon(tc,0,1-tp,1-tp,false,false,POS_FACEUP)>0)'});
 }
 const nauticaHandTriggers=[[226645052,'Harmony'],[228040066,'Melody'],[259114562,'Bobbie']];
 for(const [family,name] of nauticaHandTriggers)for(const normalFirst of [true,false])add(
  name+' shares one activation across '+(normalFirst?'Normal then Special':'Special then Normal')+' Summons',
  [[family,H],[family,H],[helper,H],[helper,H],[wing,H,1],[dark,G,1],...(family===259114562?[[body,H,1],[body,H,1]]:[])],
  [helper,helper],[[family,F],[family,H],[wing,F,1],[dark,F,1]],
  {family,harmonySearch:'decline',harmonyLimit:true,expectedFamilyUses:1,noYes:true,pick:body,option:1,
   op:`local p=1-tp
    local first=Duel.GetFlagEffect(tp,900009001)==0
    Duel.RegisterFlagEffect(tp,900009001,RESET_PHASE+PHASE_END,0,1)
    if first==${normalFirst} then
     local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_HAND,nil,${wing})
     Duel.Summon(p,tc,true,nil)
    else
     local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,${dark})
     assert(Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP)>0)
    end`});
 for(const [family,name] of nauticaHandTriggers)for(const scenario of ['reset','own-special','own-normal']){
  const reset=scenario==='reset',normal=scenario==='own-normal';
  add(name+' '+(reset?'can activate again on a new turn':'ignores your own '+(normal?'Normal':'Special')+' Summon'),
   [...Array.from({length:reset?2:1},()=>[family,H]),[helper,H],[helper,H],[dark,G,1],[wing,normal?H:G,reset?1:0],...(family===259114562?[[body,H,1],[body,H,1]]:[])],
   [helper,helper],[[family,F],[dark,F,1],[wing,F,reset?1:0]],
   {family,harmonySearch:'decline',harmonyTurnReset:reset,harmonyOwnSummon:!reset,expectedFamilyUses:reset?2:1,noYes:true,pick:body,option:1,
    op:`local first=Duel.GetFlagEffect(tp,900009002)==0
     Duel.RegisterFlagEffect(tp,900009002,0,0,1)
     local p=first and ${reset?'1-tp':'tp'} or 1-tp
     local code=first and ${wing} or ${dark}
     local tc=Duel.GetFirstMatchingCard(Card.IsCode,p,first and ${normal?'LOCATION_HAND':'LOCATION_GRAVE'} or LOCATION_GRAVE,0,nil,code)
     if first and ${normal} then
      assert(tc)
      Duel.Summon(p,tc,true,nil)
     else
      assert(tc and Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP)>0)
     end`});
 }
 add('Harmony received monster activation returns after the End Phase',
  [[226645052,H],[helper,H],[body,D],[dark,G,1]],[helper],
  [[226645052,F],[body,H],[dark,F,1]],
  {family:226645052,harmonySearch:'success',harmonyLockExpiry:true,yes:true,expectedFamilyUses:1,pick:body,
   op:`local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,${dark})
    assert(Duel.SpecialSummon(tc,0,1-tp,1-tp,false,false,POS_FACEUP)>0)`});
 for(const redirect of [false,true])add('Scarlet search '+(redirect?'redirect':'success'),
  [[220749574,H],[dark,H],[248946297,D]],[220749574],
  [[220749574,D],[dark,G],[248946297,redirect?B:H]],
  {family:220749574,scarletReceipt:true,redirect,expectedFamilyUses:1,pick:248946297});
 add('Scarlet redirected self-shuffle does not search',
  [[220749574,H],[dark,H],[248946297,D]],[220749574],[[220749574,B],[dark,G],[248946297,D]],
  {family:220749574,scarletReceipt:true,scarletShuffleRedirect:true,expectedFamilyUses:1,pick:248946297});
 add('Scarlet cannot revive before its proper first summon',
  [[220749574,G],[helper,H]],[helper],[[220749574,G]],
  {family:220749574,scarletRevival:true,expectedFamilyUses:0,
   op:'local tc=find(220749574,LOCATION_GRAVE) assert(tc and not tc:IsCanBeSpecialSummoned(e,0,tp,false,false),"Improper Scarlet revival is unavailable")'});
 for(const mode of ['summon','normal-trigger','decline','wrong-material','wrong-race','wrong-archetype','own-normal','own-special','counter','three-materials']){
  const emma=214349717, evander=225109525;
  const own=mode.startsWith('own-'),counter=mode==='counter';
  const three=mode==='three-materials';
  const normal=mode==='normal-trigger'||mode==='own-normal',take=mode==='summon'||mode==='normal-trigger'||counter||three,allowed=take||mode==='decline';
  add('Emma’s optional Xyz Summon '+mode,
   [[emma,H],[helper,H],[body,F],[evander,E],[dark,normal?H:G,own?0:1],...(counter?[[spell,T,1]]:[]),...(three?[[wing,F]]:[])],[helper],
   [[evander,counter?G:take?F:E],[dark,F,own?0:1],...(counter?[[emma,G],[body,G]]:take?[]:[[emma,own?H:F],[body,F]])],
   {family:emma,emma:mode,standardXyz:true,noYes:!allowed,yes:take,pick:evander,selectMax:three,expectedFamilyUses:Number(!own),
    op:`local p=${own?'tp':'1-tp'}
     local tc=Duel.GetFirstMatchingCard(Card.IsCode,p,${normal?'LOCATION_HAND':'LOCATION_GRAVE'},0,nil,${dark})
     ${normal?'Duel.Summon(p,tc,true,nil)':'assert(Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP)>0)'}`});
 }
 const intensity=259479044,vylonTorus=238274860;
 for(const [family,setcode] of [[recollection,0x39e2],[meadow,0x4ac0],[sanctuary,0xf3c],[revelation,0x575d],[intensity,0x8de0],[vylonTorus,0x30],[behemoth,0x11c]]){
  const normal=family===vylonTorus,special=family===behemoth,counter=family===intensity;
  const trigger=normal||special,two=trigger,source=trigger?G:counter?F:T;
  for(const redirect of [false,true]){
   const second=two?[[spell,D]]:[],setup=[[family,source],[body,D],[wing,H],...second];
   if(family===revelation)setup.push([wing,H]);
   if(redirect)setup.push([dark,F,1]);
   if(counter||trigger)setup.push([helper,H]);
   const steps=counter||trigger?[helper,family]:[family];
   const discard=!redirect||special;
   const expected=[[body,redirect?G:H],[wing,discard?G:H],...(two?[[spell,H]]:[])];
   add('Search-discard receipt '+family+': '+(redirect?'redirect':'success'),setup,steps,expected,
    {family,ownSearch:true,discardReceipt:true,redirect,setSourceSpell:true,pick:wing,setcode,yes:true,
     selectMax:two,discardReveal:two&&redirect?[spell]:redirect?[]:two?[body,spell]:[body],
     op:counter?'find('+family+',LOCATION_MZONE):EnableCounterPermit(0x18f0) find('+family+',LOCATION_MZONE):AddCounter(0x18f0,1)':trigger?'Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,true,true,POS_FACEUP)':undefined});
  }
 }
 add('Behemoth skips discard when both cards redirect',[[behemoth,G],[body,D],[spell,D],[wing,H],[dark,F,1],[helper,H]],
  [helper,behemoth],[[body,G],[spell,G],[wing,H]],
  {family:behemoth,ownSearch:true,discardReceipt:true,redirect:true,redirectBoth:true,yes:true,pick:wing,
   setcode:0x11c,selectMax:true,discardReveal:[],op:'Duel.SpecialSummon(find('+behemoth+',LOCATION_GRAVE),0,tp,tp,true,true,POS_FACEUP)'});
 for(const family of [fireball,shards,gorgonia])for(const redirect of [false,true]){
  const synchro=family!==gorgonia,resource=synchro?link:sanctuary;
  const origin=family===fireball||!synchro?D:B;
  const setup=synchro?[[family,F],[body,F],[fusion,E],[resource,origin],[wing,H]]:[[gorgonia,G],[sanctuary,D],[body,F],[helper,H],[wing,H]];
  if(redirect)setup.push([dark,F,1]);
  add('Search-discard recovery '+family+': '+(redirect?'redirect':'success'),setup,synchro?[fusion,family]:[helper,family],
   [[resource,redirect?G:H],[wing,redirect?H:G]],
   {family,ownSearch:true,discardReceipt:true,redirect,yes:true,pick:wing,setcode:synchro?0x4ac0:0xf3c,
    discardResource:resource,discardOrigin:origin,discardReveal:redirect?[]:[resource],
    materialSynchro:synchro,materialRecovery:family===fireball,mainDeckRecovery:family===shards,
    op:synchro?undefined:'Duel.Remove(find('+gorgonia+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)'});
 }
 const bria=225091736,charmeliaBeast=259226799,observatory=259721372;
 for(const family of [bria,charmeliaBeast,observatory]){
  for(const mode of family===bria?['success','redirect','equal']:['success','redirect']){
   const redirect=mode==='redirect',beast=family===charmeliaBeast,eclipse=family===observatory;
   const origin=beast?G:D,resource=beast?family:body,destination=beast?B:G;
   const setup=beast?[[family,H],[helper,H],[body,F]]:eclipse?[[family,T],[body,D],[spell,D]]:[[family,H],[wing,H],[body,D]];
   if(redirect||family===bria&&mode!=='equal')setup.push([dark,F,1]);
   const expected=[[resource,redirect?destination:H],...(eclipse?[[spell,H]]:family===bria?[[wing,G],[family,D,1]]:[])];
   add('Dependent draw '+family+': '+mode,setup,beast?[helper,family]:[family],expected,
    {family,drawReceipt:true,ownSearch:true,redirect,setSourceSpell:eclipse,yes:true,pick:wing,
     discardResource:resource,discardOrigin:origin,redirectDestination:destination,
     expectedDraw:mode==='success'?(eclipse?2:1):0,drawPlayer:eclipse?1:0,
     op:beast?'Duel.SendtoGrave(find('+family+',LOCATION_HAND),REASON_EFFECT)':undefined});
  }
 }
 const stainlessStory=245970073;
 for(const family of [bria,stainlessStory])for(const toHand of [true,false])for(const redirect of [false,true]){
  const copy=family===stainlessStory,mode=toHand?'hand':'bottom';
  const setup=[[family,H],[body,G],...(copy?[[bria,D],[wing,F,1],[dark,F,1]]:redirect?[[dark,F,1]]:[])];
  const expected=[[body,redirect?B:toHand?H:D],[bria,redirect?(copy?G:F):D]];
  add('Bria recycle '+family+' '+mode+' '+(redirect?'redirect':'success'),setup,copy?[family]:[-family,family],expected,
   {family,briaRecycle:true,redirect,storyCopyKind:copy?'bria':undefined,storyCopiedCode:copy?bria:undefined,
    pick:body,option:copy?Number(!toHand):Number(toHand),redirectDeck:!toHand});
 }
 for(const family of [bria,stainlessStory]){
  const copy=family===stainlessStory;
  const setup=[[family,H],[body,G],...(copy?[[bria,D],[wing,F,1],[dark,F,1]]:[])];
  add('Bria recycle '+family+' Extra Deck receipt',setup,copy?[family]:[-family,family],[[body,E],[bria,D]],
   {family,briaRecycle:true,briaExtraReceipt:true,storyCopyKind:copy?'bria':undefined,
    storyCopiedCode:copy?bria:undefined,pick:body});
 }
 const janna=237684285;
 for(const redirect of [false,true]){
  add('Janna delayed search '+(redirect?'Deck redirect':'success'),
   [[helper,H],[janna,E],[body,F],[wing,F],[spell,H],[link,D],[dark,F,1]],[helper,janna],
   [[dark,H,1],[spell,redirect?B:D],[link,redirect?D:H]],
   {family:janna,jannaSearch:true,redirect,statExpiry:true,pick:spell});
 }
 for(const family of [259395418,259883971])for(const redirect of [false,true]){
  const gladiator=family===259395418;
  const setup=gladiator?[[helper,H],[family,G],[body,F],[wing,D]]:[[family,T],[body,B],[wing,H],...Array.from({length:9},()=>[spell,B])];
  add('Deck receipt count '+family+' '+(redirect?'redirect':'success'),setup,gladiator?[helper,family]:[family],
   [[body,redirect?G:D],[wing,redirect?(gladiator?D:H):F]],
   {family,deckReceiptCount:true,redirect,setSourceSpell:!gladiator,yes:true,pick:body,expectedFamilyUses:1});
 }
 for(const family of [223158720,259820516])for(const redirect of [false,true]){
  const origin=family===223158720?G:B;
  add('Exact Deck return '+family+' '+(redirect?'redirect':'success'),
   [[family,G],[body,origin],[wing,origin],[spell,origin]],[family],
   [[body,redirect?(origin===G?B:G):H],[wing,D],[spell,D]].filter(([code])=>code!==body||redirect),
   {family,exactDeckReturn:true,redirect,activationLocation:G,expectedHandCount:redirect?0:1});
 }
 for(const family of [238276576,248940511,259273394,259669838])for(const redirect of [false,true]){
  const sylvan=family===238276576,moon=family===248940511,jelly=family===259273394;
  let setup,steps,expected,op;
  if(sylvan){
   setup=[[family,T],[body,G],[wing,G],[spell,G]];
   steps=[family]; expected=[[body,redirect?B:D],[wing,D],[spell,redirect?G:F]];
  }else if(moon){
   setup=[[helper,H],[family,E],[body,G],[wing,G],[spell,G],[trap,G],[link,G]];
   steps=[helper,family]; expected=redirect?[[body,B]]:[];
   op='local c=find('+family+',LOCATION_EXTRA) assert(Duel.SpecialSummon(c,SUMMON_TYPE_SYNCHRO,tp,tp,true,true,POS_FACEUP)==1) c:CompleteProcedure()';
  }else if(jelly){
   setup=[[family,G],[body,G],[259177849,E]];
   steps=[family]; expected=[[body,redirect?B:D],[259177849,redirect?E:F]];
  }else{
   setup=[[family,G],[body,G],[spell,G],[wing,F],[dark,F,1],[trap,F]];
   steps=[]; expected=[[body,redirect?B:D],[family,E]];
  }
  add('Exact Deck return '+family+' '+(redirect?'redirect':'success'),setup,steps,expected,
   {family,exactDeckReturn:true,redirect,setSourceSpell:sylvan,battle:family===259669838,
    pick:sylvan?spell:body,op,expectedHandCount:moon?(redirect?0:1):undefined});
 }
 for(const family of [227035644,245395343,259160760])for(const redirect of [false,true]){
  const galactica=family===245395343,wyvernal=family===259160760,origin=galactica?B:G;
  add('Fusion Deck payment '+family+' '+(redirect?'redirect':'success'),
   [[family,galactica?H:wyvernal?L.FZONE:G],[body,origin],[wing,origin],[fusion,E],...(wyvernal?[[helper,H],[link,H]]:[])],
   wyvernal?[helper,family]:[family],[[body,redirect?(galactica?G:B):D],[wing,D],[fusion,redirect?E:F]],
   {family,exactDeckReturn:true,fusionDeckPayment:true,redirect,
    op:wyvernal?'Duel.SpecialSummon(find('+link+',LOCATION_HAND),0,tp,tp,false,false,POS_FACEUP)':undefined});
 }
 if(process.argv.includes('--shards-empty-hand-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.shardsEmptyHand));
 for(const family of [212737555,259499577,259630851,259883029])for(const redirect of [false,true]){
  const droplet=family===212737555,hive=family===259499577;
  add('Single Deck return and draw '+family+' '+(redirect?'redirect':'success'),
   [[family,hive?T:G],[body,G],...(droplet?[[helper,H]]:[])],droplet?[helper,family]:[family],
   redirect?[[body,B]]:[],
   {family,singleDeckDraw:true,redirect,expectedHandCount:redirect?0:1,pick:body,
    op:droplet?'Duel.Remove(find('+family+',LOCATION_GRAVE),POS_FACEUP,REASON_EFFECT)':undefined});
 }
 for(const family of [212429024,244921711,246393365,259391738])for(const mode of ['success','partial','all']){
  const nebulix=family===212429024,aero=family===259391738,rei=family===246393365;
  const setup=[[family,nebulix?E:rei?T:G],[body,G],[wing,G]];
  if(nebulix||aero)setup.push([helper,H]);
  if(aero)setup.push([link,F],[spell,G]);
  const op=nebulix?'local c=find('+family+',LOCATION_EXTRA) assert(Duel.SpecialSummon(c,SUMMON_TYPE_SYNCHRO,tp,tp,true,true,POS_FACEUP)==1) c:CompleteProcedure()':
   aero?'Duel.Overlay(find('+link+',LOCATION_MZONE),Group.FromCards(find('+spell+',LOCATION_GRAVE)))':undefined;
  add('Grouped Deck draw '+family+' '+mode,setup,nebulix||aero?[helper,family]:[family],
   [[body,mode==='success'?D:B],[wing,mode==='all'?B:D],...(family===244921711?[[family,B]]:[])],
   {family,groupedDeckDraw:mode,expectedHandCount:mode==='all'?0:1,selectMax:true,yes:true,op});
 }
 for(const mode of ['face-up banishment','face-down banishment','Extra Deck','four resources','copy limit','wrong set','self only']){
  const family=244921711,legal=!['face-down banishment','wrong set','self only'].includes(mode);
  const banished=mode.endsWith('banishment'),extra=mode==='Extra Deck',repeat=mode==='copy limit',four=mode==='four resources';
  const origin=banished?B:G;
  add('Hextanius recycle '+mode,[[family,G],...(mode==='self only'?[]:[[body,origin]]),
    ...(repeat?[[family,G],[wing,G]]:[]),...(four?[[wing,G],[spell,G],[trap,G]]:[])],
   legal?[family]:[],[[family,legal?B:G],
    ...(four||mode==='self only'?[]:[[body,legal?(extra?E:D):origin]]),
    ...(repeat?[[family,G],[wing,G]]:[])],
   {family,hextaniusRecycle:mode,groupedDeckDraw:'success',expectedHandCount:Number(legal),
    expectedFamilyUses:Number(legal),forbidden:family,selectMax:four,pick:repeat?body:undefined});
 }
 for(const family of [212837324,236473882,253520299,256005703])for(const mode of ['return','banish','redirect']){
  const linkRecipient=[236473882,256005703].includes(family),remove=family===253520299;
  const target=linkRecipient?fusion:body,origin=linkRecipient?E:D;
  add('Galactica battle follow-up '+family+' '+mode,[[family,F],[target,origin]],[],
   [[family,mode==='return'?E:B],[target,mode==='redirect'?origin:remove?B:F]],
   {family,galacticaLeave:mode,battle:true,option:mode==='banish'?1:0,expectedFamilyUses:1});
 }
 for(const family of [210506870,238272435,259177849,259937946,248760718,259635008])for(const redirect of [false,true]){
  const heat=family===210506870,blossom=family===238272435,princess=family===259177849;
  const prince=family===259937946,queen=family===248760718,spirit=family===259635008;
  const setup=heat?[[family,H],[helper,H],[body,G]]:
   blossom?[[family,H],[body,F],[wing,E]]:
   princess?[[family,F],[helper,H],[body,B],[wing,F]]:
   prince?[[family,F],[body,G],[wing,D]]:
   queen?[[family,H],[helper,H],[dark,F,1],[wing,H]]:
   [[family,E],[helper,H],[body,G],[wing,G]];
  const steps=queen||spirit?[helper]:heat||princess?[helper,family]:[family];
  const expected=heat?[[body,redirect?B:E],[family,redirect?T:H]]:
   blossom?[[body,redirect?B:E],[wing,redirect?E:F]]:
   princess?[[body,redirect?G:D]]:
   prince?[[body,redirect?B:D],[wing,redirect?D:G]]:
   queen?[[wing,redirect?H:F],[family,redirect?B:D]]:
   [[family,redirect?B:E],[body,redirect?G:F],[wing,redirect?G:F]];
  const op=heat||queen?'assert(Duel.MoveToField(find('+family+',LOCATION_HAND),tp,tp,LOCATION_PZONE,POS_FACEUP,true))':
   princess?'Duel.SendtoGrave(find('+family+',LOCATION_MZONE),REASON_EFFECT)':
   spirit?'local c=find('+family+',LOCATION_EXTRA) assert(Duel.SpecialSummon(c,SUMMON_TYPE_SYNCHRO,tp,tp,true,true,POS_FACEUP)==1) c:CompleteProcedure()':undefined;
  add('Single Deck successor '+family+' '+(redirect?'redirect':'success'),setup,steps,expected,
   {family,singleDeckSuccessor:true,redirect,yes:true,pick:queen?wing:body,op,
    rewrite:queen,monsterActivation:queen,opponentOp:queen?'Duel.Recover(tp,100,REASON_EFFECT)':undefined,
    statExpiry:spirit,expectedFamilyUses:spirit?2:1});
 }
 if(process.argv.includes('--single-deck-successor-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.singleDeckSuccessor));
 if(process.argv.includes('--galactica-leave-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.galacticaLeave));
 if(process.argv.includes('--grouped-deck-draw-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.groupedDeckDraw));
 if(process.argv.includes('--single-deck-draw-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.singleDeckDraw));
 if(process.argv.includes('--exact-deck-return-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.exactDeckReturn));
 add('Janna does not reveal a redirected delayed search',
  [[helper,H],[janna,E],[body,F],[wing,F],[spell,H],[link,D],[dark,F,1]],[helper,janna],
  [[dark,H,1],[spell,D],[link,B]],
  {family:janna,jannaSearch:true,jannaRevealRedirect:true,statExpiry:true,pick:spell});
 for(const family of [janna,215006791])for(const redirect of [false,true])
  add('Windborne delayed GY reveal '+family+' '+(redirect?'redirect':'success'),
   [[family,F],[link,G]],[],[[link,redirect?B:H]],
   {family,windborneRecovery:true,jannaRevealRedirect:redirect,yes:true,expectedFamilyUses:2});
 for(const mode of ['success','partial','all']){
  const family=234599395;
  add('Melville excavation receipt '+mode,
   [[family,F],[helper,H],[body,D],[wing,D],[spell,D],[link,G],[trap,G],[fusion,G]],[helper,family],
   [[family,T],[body,mode==='success'?H:B],[wing,mode==='all'?B:H],[spell,D]],
   {family,melvilleReceipt:mode,yes:true,selectMax:true,op:'Duel.Overlay(find('+family+',LOCATION_MZONE),Group.FromCards(find('+link+',LOCATION_GRAVE),find('+trap+',LOCATION_GRAVE),find('+fusion+',LOCATION_GRAVE)))'});
 }
 for(const mode of ['success','partial','all'])
  add('Sylvan Greetings excavation receipt '+mode,
   [[238276575,H],[body,D],[wing,D],[spell,D],[trap,D],[fusion,D]],[238276575],
   [[body,mode==='success'?H:B],[wing,mode==='all'?B:H],[spell,D]],
   {family:238276575,melvilleReceipt:mode,yes:true,selectMax:true});
 for(const mode of ['success','partial','all'])
  add('Chandra excavation receipt '+mode,
   [[259126370,F],[helper,H],[body,D],[wing,D],[link,G]],[helper,259126370],
   [[body,mode==='success'?H:B],[wing,mode==='all'?B:H]],
   {family:259126370,melvilleReceipt:mode,yes:true,selectMax:true,
    op:'Duel.Overlay(find(259126370,LOCATION_MZONE),Group.FromCards(find('+link+',LOCATION_GRAVE))) Duel.Draw(1-tp,2,REASON_EFFECT)'});
 for(const family of [221822671,238711686,240511702,245970073,246216813,259578863,221759221])for(const redirect of [false,true]){
  const copy=family===245970073,oracle=family===259578863,cart=family===221759221;
  const release=family===246216813,hunter=family===240511702,melissa=family===238711686;
  const target=release?246830897:body;
  const setup=[[family,copy?H:oracle?G:F],[target,D]];
  if(copy)setup.push([221822671,D],[dark,F,1],[wing,F,1]);
  else if(oracle)setup.push([dark,F,1]);
  else if(cart)setup.push([wing,F],[fusion,E]);
  else setup.push([helper,H]);
  if(melissa)setup.push([wing,G],[spell,G]);
  const op=release?'Duel.Release(find('+family+',LOCATION_MZONE),REASON_EFFECT)':
   hunter?'Duel.SendtoGrave(find('+family+',LOCATION_MZONE),REASON_EFFECT)':
   melissa?'Duel.Overlay(find('+family+',LOCATION_MZONE),Group.FromCards(find('+wing+',LOCATION_GRAVE),find('+spell+',LOCATION_GRAVE)))':
   'Duel.SendtoGrave(find('+family+',LOCATION_MZONE),REASON_EFFECT) Duel.SpecialSummon(find('+family+',LOCATION_GRAVE),0,tp,tp,false,false,POS_FACEUP)';
  add('Alternative search receipt '+family+' '+(redirect?'redirect':'success'),setup,
   copy||oracle?[family]:cart?[fusion,family]:[helper,family],[[target,redirect?B:H]],
   {family,alternativeReceipt:true,receiptTarget:target,redirect,op,pick:target,stainlessCopy:copy,
    materialSynchro:cart,yes:true,option:oracle?1:0});
 }
 add('Preparation sets remaining target after interruption',[[210696007,T],[body,B],[wing,B],[dark,F,1]],[210696007],[[body,G],[wing,T]],{family:210696007,preparationTargetInterrupt:true,setSourceSpell:true,selectMax:true,expectedFamilyUses:1});
 add('Preparation rejects stolen opponent-owned banished Spell',[[210696007,T],[body,T,1],[wing,B],[helper,H]],[helper,210696007],[[body,B,1],[wing,T]],{family:210696007,preparationOwnership:true,setSourceSpell:true,sequentialActions:true,expectedFamilyUses:1,op:'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_SZONE,nil,'+body+') assert(c and c:GetOwner()==1-tp) assert(Duel.MoveToField(c,tp,tp,LOCATION_SZONE,POS_FACEUP,true)) assert(c:IsControler(tp) and c:GetOwner()==1-tp) assert(Duel.Remove(c,POS_FACEUP,REASON_EFFECT)>0)'});
 add('Preparation excludes opponent, non-Galactica and monster targets',[[210696007,T],[body,B],[wing,B],[spell,B,1],[trap,B]],[210696007],[[body,T],[wing,B],[spell,B,1],[trap,B]],{family:210696007,preparationSetEligibility:true,setSourceSpell:true,expectedFamilyUses:1});
 for(const mode of ['trap','quick-play'])add('Preparation set-turn permission expires '+mode,[[210696007,T],[body,B],[helper,H]],[210696007,helper,body],[[body,G]],{family:210696007,preparationImmediate:mode,preparationExpiry:true,setSourceSpell:true,sequentialActions:true,expectedFamilyUses:1,op:'local c=find('+body+',LOCATION_SZONE) assert(c and not c:IsHasEffect('+(mode==='trap'?'EFFECT_TRAP_ACT_IN_SET_TURN':'EFFECT_QP_ACT_IN_SET_TURN')+'),"Set-turn permission expired")'});
 for(const mode of ['trap','quick-play'])add('Preparation enables same-turn '+mode,[[210696007,T],[body,B]],[210696007,body],[[body,G]],{family:210696007,preparationImmediate:mode,setSourceSpell:true,sequentialActions:true,expectedFamilyUses:1});
 add('Preparation excludes face-down banished Galactica',[[210696007,T],[body,B],[trap,B]],[210696007],[[body,T],[trap,B]],{family:210696007,preparationFacedown:true,banishedTrapFacedown:true,setSourceSpell:true,expectedFamilyUses:1});
 add('Preparation sets up to three of four banished cards',[[210696007,T],[body,B],[wing,B],[spell,B],[trap,B]],[210696007],[],{family:210696007,preparationSetThree:true,setSourceSpell:true,selectMax:true,expectedFamilyUses:1});
 for(const locked of [false,true])add('Preparation GY cost under Necrovalley '+(locked?'locked':'open'),[[210696007,G],[body,D],[spell,G],...(locked?[[47355498,L.FZONE]]:[])],locked?[]:[210696007],locked?[[210696007,G],[spell,G],[body,D]]:[[210696007,B],[spell,B],[body,H]],{family:210696007,preparationNecro:true,preparationCost:'valid-spell',alternativeReceipt:true,sendChoice:true,receiptTarget:body,pick:body,option:0,revealExpected:Number(!locked),activationLocation:G,forbidden:locked?210696007:undefined});
 for(const mode of ['valid-spell','valid-trap','missing','monster-only']){
  const code=210696007,legal=mode.startsWith('valid');
  add('Preparation GY cost '+mode,[[code,G],[body,D],...(mode==='missing'?[]:[[spell,G]])],legal?[code]:[],legal?[[code,B],[spell,B],[body,H]]:[[code,G],[body,D]],{family:code,preparationCost:mode,alternativeReceipt:true,sendChoice:true,receiptTarget:body,pick:body,option:0,revealExpected:Number(legal),activationLocation:G,forbidden:legal?undefined:code});
 }
 for(const mode of ['activation','effect'])add('Preparation shared limit after GY '+mode+' negation',[[210696007,T],[210696007,G],[body,B],[wing,D],[spell,G],[dark,F,1]],[210696007,210696007],[[body,T],[wing,D]],{family:210696007,preparationShared:'grave-first',preparationNegation:mode,setSourceSpell:true,sequentialActions:true,selectMax:true,option:0,expectedFamilyUses:2});
 for(const mode of ['activation','effect'])add('Preparation shared limit after '+mode+' negation',[[210696007,T],[210696007,G],[body,B],[wing,D],[spell,G],[dark,F,1]],[210696007,210696007],[[body,B],[wing,H]],{family:210696007,preparationShared:'trap-first',preparationNegation:mode,setSourceSpell:true,sequentialActions:true,selectMax:true,option:0,expectedFamilyUses:2});
 for(const mode of ['trap-first','grave-first']){
  const code=210696007;
  add('Preparation shared effect limit '+mode,[[code,T],[code,G],[body,B],[wing,D],[spell,G]], [code,code],[[body,T],[wing,H]],{family:code,preparationShared:mode,setSourceSpell:true,sequentialActions:true,selectMax:true,option:0,expectedFamilyUses:2});
 }
 for(const family of [210696007,259187643,258328859])for(const mode of ['add','redirect','send']){
  const preparation=family===210696007;
  add('Add or send receipt '+family+' '+mode,[[family,preparation?G:H],[body,D],...(preparation?[[spell,G]]:[])],
   [family],[[body,mode==='redirect'?B:mode==='send'?G:H]],
   {family,alternativeReceipt:true,sendChoice:true,receiptTarget:body,redirect:mode==='redirect',
    revealExpected:mode==='add'?1:0,yes:true,option:mode==='send'?1:0,pick:body,activationLocation:preparation?G:undefined});
 }
 for(const family of [212684822,227362839,247755865,254065048,259177849,259688514])for(const mode of ['add','redirect','send']){
  const origin=family===259688514?G:family===247755865?H:E;
  add('Summon add or send receipt '+family+' '+mode,[[family,origin],[helper,H],[body,D]],
   [helper,family],[[body,mode==='redirect'?B:mode==='send'?G:H]],
   {family,alternativeReceipt:true,sendChoice:true,receiptTarget:body,redirect:mode==='redirect',
    revealExpected:mode==='add'?1:0,yes:true,option:mode==='send'?1:0,pick:body,
    op:'assert(Duel.SpecialSummon(find('+family+','+(origin===H?'LOCATION_HAND':origin===G?'LOCATION_GRAVE':'LOCATION_EXTRA')+'),0,tp,tp,true,true,POS_FACEUP)==1)'});
 }
 for(const route of ['spires','aquila-deck','aquila-grave'])for(const redirect of [false,true]){
  const eldora=214552846,spires=route==='spires',grave=route==='aquila-grave';
  const family=spires?244972185:259366507,target=route==='aquila-deck'?eldora:body;
  const setup=spires?[[family,H],[eldora,L.FZONE],[body,D]]:
   [[family,F],[eldora,L.FZONE],...(grave?[[body,G]]:[[eldora,D],[eldora,G]])];
  add('Zephorion receipt '+route+' '+(redirect?'redirect':'success'),setup,spires?[family]:[eldora,family],
   [[target,redirect?B:H]],{family,alternativeReceipt:true,zephorionReceipt:route,receiptTarget:target,redirect,option:route==="aquila-deck"?1:0,pick:target,expectedFamilyUses:1});
 }
 if(process.argv.includes('--zephorion-receipt-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.zephorionReceipt));
 if(process.argv.includes('--add-or-send-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.sendChoice));
 if(process.argv.includes('--alternative-receipt-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.alternativeReceipt));
 if(process.argv.includes('--melville-receipt-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.melvilleReceipt));
 if(process.argv.includes('--windborne-reveal-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.jannaSearch||t.windborneRecovery));
 if(process.argv.includes('--janna-search-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.jannaSearch||t.deckReceiptCount));
 if(process.argv.includes('--bria-recycle-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.briaRecycle));
 if(process.argv.includes('--dependent-draw-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.drawReceipt));
 if(process.argv.includes('--search-discard-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.discardReceipt));
 if(process.argv.includes('--own-search-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.ownSearch&&!t.discardReceipt&&!t.drawReceipt));
 if(process.argv.includes('--musicale-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.musicaleSummon||t.musicaleUnique||t.musicaleActivation||t.musicaleTranscend||t.musicaleYummy||t.ownSearch&&t.family===259797813));
 if(process.argv.includes('--musicale-stock-probe'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.musicaleStock));
 if(process.argv.includes('--harmony-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.harmonySearch||t.scarletReceipt||t.scarletRevival));
 if(process.argv.includes('--melissa-protection-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.melissaProtection));
 if(process.argv.includes('--melissa-recipe-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.levelOneXyzRecipe&&t.family===238711686));
 if(process.argv.includes('--melissa-quick-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.melissaQuick||t.alternativeReceipt&&t.family===238711686));
 if(process.argv.includes('--exploring-boundaries-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.exploringBoundary||t.extraUseLockProbe&&t.family===248946297));
 if(process.argv.includes('--backwashing-boundaries-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.backwashingBoundary));
 if(process.argv.includes('--adventures-overlay-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.nauticaOverlay));
 if(process.argv.includes('--lokaeo-xyz-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.lokaeoXyz));
 if(process.argv.includes('--lokaeo-recycle-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.lokaeoRecycle&&!t.baubaRevival));
 if(process.argv.includes('--bauba-revival-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.baubaRevival));
 if(process.argv.includes('--bauba-receipt-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.baubaReceipt));
 if(process.argv.includes('--bauba-summon-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.baubaSummon));
 if(process.argv.includes('--shrine-placement-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.shrinePlacement));
 if(process.argv.includes('--huangjin-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.huangjin));
 if(process.argv.includes('--chunyin-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.chunyin));
 if(process.argv.includes('--bojin-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.bojin));
 if(process.argv.includes('--zao-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.zao));
 if(process.argv.includes('--koai-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.koai));
 if(process.argv.includes('--emma-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.emma));
 if(process.argv.includes('--nordbar-negation-protection-probe'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.nordbarNegate));
 if(process.argv.includes('--formation-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.family===formation));
 if(process.argv.includes('--preparation-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.family===210696007));
 if(process.argv.includes('--battle-tactics-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.battleTactics||t.tacticsBanish));
 if(process.argv.includes('--venatici-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.venaticiToken||t.venaticiBattle));
 if(process.argv.includes('--galactica-battle-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.galacticaBattle));
 for(const t of testCases){
  const data=new Map();
  for(const code of [hot,sky,journey,soprana,offer])data.set(code,candidateCard(code));
  if(t.family&&!t.stockNegationControl)data.set(t.family,candidateCard(t.family));
  const put=(code,over={})=>data.set(code,{...base,code,...over});
  if(t.stockNegationControl)put(t.family,{type:0x2021,level:10});
  put(helper,{type:2});put(body);put(dark,{attribute:32,attack:t.battle?3000:100});put(wing,{type:t.effectWing?33:17,attribute:t.effectWing?32:16,race:512n,level:t.levelEight?8:t.boss?7:2,setcodes:t.family===formation?[0x9c9]:[grayseer,grayling].includes(t.family)?[0x575d]:floo});
  put(spell,{type:t.family===booster?0x40002:t.field?0x80002:0x20002,setcodes:[grayhex,graylock].includes(t.family)?[0x575d]:floo});put(trap,{type:4,setcodes:fiend});
  put(fusion,{type:0x61,setcodes:fiend});put(link,{type:t.family===nullbind?0x800021:0x4000021,level:2,link_marker:5,setcodes:t.family===formation?[0x9c9]:[grayrover,nullbind].includes(t.family)?[0x575d]:fiend});
  if(t.backwashingBoundary){
   put(body,{setcodes:t.backwashingBoundary==='wrong-target'?[]:[0x8f0]});
   put(dark,{type:33});
   for(const code of [wing,spell,trap,fusion])put(code,{race:code===trap&&t.backwashingBoundary==='wrong-race'?1n:64n});
  }
  if(t.exploringBoundary){
   put(body,{type:33,setcodes:[0x8f0]});
   put(wing,{type:33,attribute:32});
   put(trap,{type:17,attribute:2});
  }
  if(t.melissaQuick){
   const setcodes=t.melissaQuick==='wrong-set'?[]:[0x8f0];
   put(body,{setcodes});
   put(spell,{type:2,setcodes});
   put(trap,{type:t.melissaQuick==='full-field'?0x80002:4,setcodes});
   put(link,{type:t.melissaQuick.startsWith('full')?2:17});
   if(t.melissaQuick.startsWith('full'))put(fusion,{type:2});
  }
  if(t.melissaProtection)put(body,{setcodes:t.melissaProtection==='control'?[]:[0x8f0]});
  if(t.family===bauSpell){put(bauWorld,{type:0x80002});put(bau);put(body,{type:0x1021,setcodes:[0xba8]});}
  if(t.discardFamily)put(body,{setcodes:[vazagiel,sarifiel,fireball].includes(t.family)?[0x4ac0]:t.family===brilliance?[0x67ee]:t.family===recollection?[0x39e2]:[0xf3c]});
  if(t.family===gorgonia)data.set(sanctuary,candidateCard(sanctuary));
  if(t.family===revelation){put(body,{setcodes:[0x575d]});put(wing,{setcodes:[0x575d]});put(grayToken,{type:0x4011,level:4,setcodes:[0x575d],attack:800,defense:800});}
  if(t.reviveNull){put(wing,{type:33,setcodes:[0x575d]});put(body,{type:33,setcodes:[0x575d]});}
  if(t.revival)put(wing,{type:t.family===graysentry?0x4000021:0x800021,level:2,setcodes:[0x575d],link_marker:5});
  if(t.rewrite)put(dark,{type:2});
  if(t.family===chapter){put(dysmandr,{type:0x61});put(extinction,{type:2});put(token);put(body,{type:33});put(wing,{type:33});}
  if(t.nativeSpecial){put(body,{type:0x800021,level:8,setcodes:[0x575d]});put(link,{type:0x4000021,level:4,link_marker:0x55,setcodes:[0x575d]});}
  if(t.wrongRecipe)put(link,{type:0x800021,level:8,setcodes:[0x575d]});
  if(t.endRecovery)put(wing,{setcodes:t.noRecoveryTarget?[]:[0x575d]});
  if(t.xyzFixture){put(body,{level:t.wrongXyzLevel?7:8,setcodes:[0x575d]});put(fusion,{type:0x800021,level:8,setcodes:[0x575d]});}
  if(t.xyzTrigger)put(body,{setcodes:[0x575d]});
  if(t.family===graydimm){put(wing,{setcodes:[0x575d]});put(link,{type:0x4000021,level:2,link_marker:0x20,setcodes:[0x575d]});}
  if(t.tokenMaterials)put(fusion,{type:0x4000021,level:2,link_marker:5,setcodes:[0x575d]});
  put(engraver,{type:33,setcodes:fiend});if(t.copied)put(t.copied,{type:33,race:512n,setcodes:floo});
  if(t.materialGate){put(link,{type:0x4000021,level:2,link_marker:5});put(fusion,{type:0x4000021,level:2,link_marker:5,setcodes:[0x575d]});put(body,{type:0x800021,level:8,setcodes:[0x575d]});put(wing,{type:0x800021,level:8});}
  if(t.linkRecipe){
   put(body,{setcodes:t.invalidLinkMaterial==='archetype'?[]:[0x575d]});
   put(wing,{race:t.invalidLinkMaterial==='race'?512n:8n,attribute:t.invalidLinkMaterial==='attribute'?32:16});
  }
  if(t.linkThree)put(link,{type:0x4000021,level:3,link_marker:0x15,setcodes:[0x575d]});
  if(t.xyzRecipe){put(body,{level:8,attribute:t.invalidXyzMaterial==='lightfiend'?32:16});put(wing,{level:t.invalidXyzMaterial==='level'?7:8,attribute:32,race:512n});}
  if(t.standardXyz){put(body,{level:12});put(wing,{level:t.invalidXyzMaterial==='level'?11:12,attribute:t.invalidXyzMaterial==='lightfiend'?32:16,race:t.invalidXyzMaterial==='race'?512n:8n});}
  if(t.levelOneXyzRecipe)for(const code of t.recipeMaterials){
   put(code,{level:code===wing&&t.levelOneXyzRecipe==='wrong-level'?2:1,race:code===wing&&t.levelOneXyzRecipe==='wrong-race'?1n:(t.koai||t.zao)?512n:64n});
  }
  if(t.revealGroup){put(body,{type:0x91,setcodes:[0x12b1]});put(wing,{type:0x82,setcodes:[0x12b1]});}
  else if(t.zaokaRecovery)put(body,{type:33,setcodes:t.zaokaRecovery==='wrong set'?[]:
   [t.zaokaRecovery==='Sacred Treasure banishment'?0x8a20:0xb69]});
  else if(t.zaokaExcavation){
   put(body,{type:33,setcodes:[0xb69]});
   put(wing,{type:2,setcodes:[0x8a20]});
   put(trap,{type:33,setcodes:t.zaokaExcavation==='all match'?[0xb69]:[]});
  }
  else if(t.leoship)put(body,{type:t.leoship==='Spell in Hand'?2:33,
   setcodes:['wrong set','wrong monster set'].includes(t.leoship)?[]:[0x163]});
  else if(t.octantisRecruit){
   put(body,{type:33,setcodes:[0x163]});
   put(wing,{type:33,setcodes:t.octantisRecruit==='wrong set'?[]:[0x163]});
   if(t.octantisRecruit==='Necrovalley')put(47355498,{type:0x80002});
  }
  else if(t.hextaniusRecruit)put(body,{type:33,attribute:t.hextaniusRecruit==='wrong attribute'?16:2,
   attack:['700 DEF','wrong stats'].includes(t.hextaniusRecruit)?600:700,
   defense:t.hextaniusRecruit==='700 DEF'?700:600});
  else if(t.battleTactics||t.tacticsBanish){
   put(body,{type:(t.battleTactics==='wrong cost type'||t.tacticsBanish==='wrong type')?33:2,setcodes:[0x9c9]});
   put(dark,{type:33,attack:700,defense:300});
   put(wing,t.tacticsBanish?{type:4,setcodes:[0x9c9]}:{type:33,attack:800,defense:400});
   put(trap,{type:33,attack:600,defense:200});
  }
  else if(t.formationSearch)put(body,{type:33,setcodes:[0x9c9]});
  else if(t.venaticiToken)data.set(229021850,candidateCard(229021850));
  else if(t.venaticiBattle){
   put(body,{type:2,setcodes:t.venaticiBattle==='wrong set'?[]:[0x9c9]});
   put(wing,{type:33,setcodes:[0x9c9]});
   put(dark,{type:33,attack:500,defense:500});
  }
  else if(t.galacticaBattle){
   put(body,{type:33,level:t.galacticaBattle==='wrong recruit Level'?3:2,setcodes:[0x9c9]});
   put(trap,{type:t.galacticaBattle==='wrong cost type'?33:4,setcodes:[0x9c9]});
   put(dark,{type:33,attack:500,defense:500});
  }
  else if(t.chaosReturn){
   put(body,{type:33,attribute:16});
   put(wing,{type:33,attribute:t.chaosReturn==='wrong attribute'?16:32});
  }
  else if(t.nordbarRevive||t.nordbarSearch){
   put(body,{type:t.nordbarSearch==='wrong type'?2:33,
    setcodes:(t.nordbarRevive||t.nordbarSearch)==='wrong set'?[]:[0x163]});
   if(t.nordbarRevive==='Necrovalley')put(47355498,{type:0x80002});
  }
  else if(t.octantisSynchroCheck)put(wing,{type:0x2021,level:1,setcodes:[0x163]});
  else if(t.octantisUpgrade){
   put(body,{type:33,level:t.octantisUpgrade==='wrong Tribute Level'||t.octantisUpgrade==='Leoship'?7:8,setcodes:[0x163]});
   put(wing,{type:0x2021,level:t.octantisUpgrade==='wrong Synchro Level'?8:7,setcodes:[0x163]});
  }
  else if(t.hikamSummon)put(body,{type:t.hikamSummon==='wrong type'?2:33,setcodes:t.hikamSummon==='wrong set'?[]:[0xb69]});
  else if(t.baubaReceipt)put(body,
   t.handRevealProbe==='advent'?{type:17,race:0x80000000n}:{
    type:t.oroSearch==='wrong type'?33:2,setcodes:t.oroSearch==='wrong set'?[]:[0x8a20]
   });
  if(t.baubaSummon){
   put(body,{type:33,setcodes:t.baubaSummon==='wrong-set'?[]:[0xb69]});
   put(trap,{type:33,setcodes:[0xb69]});
   if(t.baubaSummon==='necrovalley')put(47355498,{type:0x80002});
  }
  if(t.shrinePlacement)put(22702055,{type:0x80002});
  if(t.huangjin)put(body,{setcodes:[0xb69]});
  if(t.chunyin){
   for(const code of [body,wing,trap])put(code,{type:33,setcodes:[0xb69]});
   if(['deck-only','no-branch'].includes(t.chunyin))for(const code of [body,dark])put(code,{type:0x4000021,level:1,link_marker:1,setcodes:[0xb69]});
  }
  if(t.bojin){put(body,{setcodes:[0xb69]});put(trap,{type:33,setcodes:[0xb69]});}
  if(t.treasureBanish)put(body,{type:2,setcodes:t.treasureBanish==='wrong-set'?[]:[0x8a20]});
  if(t.zaoSequence==='real'){
   for(const code of [236542835,246421842])data.set(code,candidateCard(code));
   put(dark,{type:2});
  }
  if(t.zaoSequence==='interrupted')put(dark,{type:33});
  if(t.zaoSequence){
   put(spell,{type:2,setcodes:[0x8a20]});
   put(trap,{type:2,setcodes:t.zaoSequence==='wrong-set'?[]:[0x8a20]});
  }
  if(t.koaiProtect)put(dark,{type:2});
  if(t.koaiQuick){
   if(['cost-only','cost-target'].includes(t.koaiQuick))put(body,{setcodes:[0xb69]});
   put(wing,{setcodes:[0xb69]});
   put(fusion,{type:t.koaiQuick==='extra'?0x61:17,setcodes:[0xb69]});
   for(const code of [spell,trap])put(code,{type:2,setcodes:[0x8a20]});
  }
  if(t.lokaeoRecycle){
   put(body,{type:t.lokaeoRecycle==='wrong-type'?17:2,setcodes:t.lokaeoRecycle==='wrong-set'?[]:[0x8a20]});
   put(trap,{type:2,setcodes:[0x8a20]});
  }
  if(t.lokaeoXyz){
   if(['counter','upper'].includes(t.lokaeoXyz))put(spell,{type:0x100004});
   const xyz=candidateCard(231825514);
   data.set(xyz.code,{...xyz,level:t.lokaeoXyz==='wrong-rank'?2:xyz.level,setcodes:t.lokaeoXyz==='wrong-set'?[]:xyz.setcodes});
   put(body,{level:t.lokaeoXyz==='wrong-level'?2:1,race:t.lokaeoXyz==='wrong-race'?1n:512n});
  }
  if(t.emma){
   const evander=candidateCard(225109525);
   data.set(evander.code,t.emma==='wrong-archetype'?{...evander,setcodes:[]}:evander);
   put(body,{level:t.emma==='wrong-material'?2:1,race:t.emma==='wrong-race'?1n:64n});
   if(t.emma==='counter')put(spell,{type:0x100004});
   if(t.emma==='three-materials')put(wing,{level:1,race:64n,setcodes:[0x8f0]});
  }
  if(t.atkAura)put(body,{setcodes:[0x575d]});
  if(t.descendType)put(body,{type:t.descendType,level:t.descendType===2?0:2,setcodes:[0x4ac0]});
  if(t.orbCost)put(body,{setcodes:[0x4ac0]});
  if(t.arcGY){put(body,{type:0x800021,level:4,setcodes:t.wrongArcXyz?[]:[0x4ac0]});put(wing,{setcodes:[0x4ac0],race:2n});}
  if(t.pillarReturn){put(body,{setcodes:[0x4ac0]});put(wing,{setcodes:[0x4ac0]});}
  if(t.pillarSource!=='unrelated'&&t.pillarSource)put(helper,{type:2,setcodes:[0x4ac0]});
  if(t.featherSearch)put(body,{type:t.spellOnly?2:17,setcodes:[0x4ac0],level:t.spellOnly?0:2});
  if(t.replaceUrphiel)put(body,{type:33,setcodes:[0x4ac0]});
  if(t.replaceFamily){put(body,{type:33,race:t.family===behemoth?4096n:128n,attribute:32});put(wing,{setcodes:[0x1ad]});}
  if(t.negateUrphiel){put(body,{setcodes:t.negateMode==='no-companion'?[]:[0x4ac0]});put(wing,{setcodes:[0x4ac0]});}
  if(t.detachProbe)put(body,{type:0x800021,level:4,setcodes:t.detachMode==='unrelated'?[]:[0x4ac0]});
  if(t.ophielResponse){put(body,{setcodes:[0x4ac0]});put(wing,{setcodes:t.targetIsArc?[0x4ac0]:[]});}
  if(t.ophielSearch)put(body,{type:2,setcodes:[0x4ac0]});
  if(t.ophielDetach)put(spell,{type:2,setcodes:[0x4ac0]});
  if(t.azerielMill)put(body,{type:t.monster?17:2,setcodes:[0x4ac0]});
  if(t.azerielSearch)put(body,{type:t.spellCard?2:17,setcodes:[0x95]});
  if(t.azerielRevive){put(wing,{type:t.reviveMode==='wrong-type'?0x61:0x800021,setcodes:t.reviveMode==='wrong-archetype'?[]:[0x4ac0],level:4});put(spell,{type:2,setcodes:[0x95]});}
  if(t.shardsProbe)put(body,{type:17,level:t.highLevel?5:2,setcodes:[0x4ac0],race:2n});
  if(t.materialSynchro){
   put(body,{type:data.get(t.family).type&0x1000?17:0x1011,level:2});
   put(fusion,{type:0x2001,level:data.get(t.family).level+2,attribute:t.darkSynchro?32:16});
   put(link,{type:t.mainDeckRecovery?17:0x800021,level:4,setcodes:[0x4ac0]});
   if(t.materialRecovery)put(link,{type:t.family===fireball&&!t.invalidMaterialTarget?2:17,level:t.invalidMaterialTarget?5:2,setcodes:[0x4ac0]});
  }
  if(t.protectionProbe){put(body,{attribute:16});put(wing,{attribute:32});}
  if(t.burnResolution)put(body,{type:0x2021,race:2n});
  if(t.prismMaterial)put(link,{type:17,level:t.highPrismTarget?5:2,setcodes:[0x4ac0]});
  if(t.urphielLeave){put(body,{setcodes:[0x4ac0]});put(wing,{setcodes:[0x4ac0]});}
  if(t.sarifielAttach)put(body,{type:t.attachMode==='spell'?2:33,setcodes:[0x4ac0]});
  if(t.grayterrorHost){put(body,{setcodes:[0x575d]});put(wing,{setcodes:[0x575d]});put(fusion,{type:0x800021,level:4,setcodes:[0x575d]});put(spell,{type:17});put(dark,{type:33});}
  if(t.aeroAttachment)put(body,{type:0x800021,level:6,attribute:8});
  if(t.genericHostFamily){put(body,{type:0x800021,level:4,setcodes:[t.family===melody?0x7a34:0x715b]});put(wing,{type:17,setcodes:[0x7a34]});}
  if(t.overlayFamily){put(t.overlayHost,{type:0x800021,level:6,setcodes:t.family===ghostXyz?[0x8d]:[]});put(t.overlayMaterial,{type:17,setcodes:[t.family===ghostXyz?0x8d:0x3de1]});}
  if(t.shadeFamily||t.ghostTransferFamily){put(body,{type:0x800021,level:3,setcodes:[t.shadeFamily?0x3de1:0x8d]});put(wing,{type:17,setcodes:[0x8d]});}
  if(t.oniQuickRecipient){
   const code=t.oniQuickRecipient;
   if([ghostXyz,259851064].includes(code))data.set(code,candidateCard(code));
   else put(code,{type:0x800021,level:code===75367227?3:2,setcodes:[0x8d],attack:1800});
   put(body,{type:code===259851064?4:33,setcodes:[0x8d]});
   put(dark,{type:code===75367227?4:33});
  }
  if(t.ghostResponse){put(body,{type:0x800021,level:3,setcodes:[0x8d]});put(dark,{type:0x61});}
  if(t.clawRevive){put(body,{type:0x800021,level:4,setcodes:[0x715b]});put(dark,{type:33,race:16384n});}
  if(t.clawSelfRevive)put(47355498,{type:0x80002});
  if(t.stainTributeLevel)put(body,{type:33,level:t.stainTributeLevel,setcodes:[0xbc5]});
  if(t.stainTributeMode==='mixed-tributes')put(wing,{type:33,level:5,setcodes:[0xbc5]});
  if(t.stainTributeMode==='necrovalley')put(47355498,{type:0x80002});
  if(t.stainTributeMode==='opponent-deck')put(wing,{type:33,level:4,setcodes:[0xbc5]});
  if(t.stainBria){data.set(225091736,candidateCard(225091736));put(wing,{type:33,level:4,setcodes:[0xbc5]});}
  if(t.stainTwoPlacements)data.set(216958556,candidateCard(216958556));
  if(t.dragarAttack!==undefined)put(wing,{attack:t.dragarAttack});
  if(t.musicaleActivation||t.ownSearch&&!t.discardReceipt&&!t.drawReceipt){put(body,{type:33,setcodes:[0x8f0]});put(wing,{type:33});put(dark,{type:33});}
  if(t.exactDeckReturn){
   const setcode=({238276576:0x90,248940511:0xe6,259273394:0x67ee,259669838:0x104})[t.family];
   for(const code of [body,wing,spell])put(code,{type:17,race:t.family===223158720?64n:128n,setcodes:setcode?[setcode]:[]});
   if(t.family===248940511)for(const code of [trap,link])put(code,{type:17,setcodes:[0xe6]});
   if(t.family===259273394)put(259177849,{type:0x61,setcodes:[0x67ee]});
   if(t.family===259669838){put(dark,{attack:3000});put(wing,{type:17,setcodes:[0x104],attack:50});put(trap,{type:17,setcodes:[0x104],attack:500});}
  }
  if(t.fusionDeckPayment){
   const setcode=({227035644:0xf3c,245395343:0x9c9,259160760:0x4714})[t.family];
   for(const code of [body,wing,link])put(code,{type:17,race:2048n,setcodes:[setcode]});
   put(fusion,{type:0x61,attribute:2,setcodes:[setcode]});
  }
  if(t.singleDeckSuccessor){
   if(t.family===210506870)put(body,{type:0x61,attribute:32,race:128n});
   if(t.family===238272435){put(body,{type:0x61,level:4});put(wing,{type:0x61,level:4});}
   if([259177849,259937946].includes(t.family))put(wing,{type:33,setcodes:[0x67ee]});
   if(t.family===248760718){put(wing,{type:33,level:7,attribute:16,race:8192n});put(dark,{type:33,attribute:32});}
   if(t.family===259635008){put(body,{type:0x1221,level:2});put(wing,{type:0x221,level:4});}
  }
  if(t.galacticaLeave){
   data.set(t.family,{...data.get(t.family),attack:2500});
   put(body,{type:33,level:2,setcodes:[0x9c9]});
   put(fusion,{type:0x4000021,level:2,link_marker:5,setcodes:[0x9c9]});
  }
  if(t.groupedDeckDraw){
   const sets={212429024:0x760,244921711:0x163,259391738:0x3de1};
   for(const code of [body,wing])put(code,{type:t.family===246393365?0x221:33,setcodes:sets[t.family]?[sets[t.family]]:[]});
   if(t.hextaniusRecycle==='Extra Deck')put(body,{type:0x2021,setcodes:[0x163]});
   if(t.hextaniusRecycle==='wrong set')put(body,{setcodes:[]});
   if(t.hextaniusRecycle==='four resources'){put(spell,{type:2,setcodes:[0x163]});put(trap,{type:4,setcodes:[0x163]});}
   if(t.family===259391738)put(link,{type:0x800021,level:2});
  }
  if(t.singleDeckDraw)put(body,t.family===259499577?{type:17}:{type:4,setcodes:[t.family===212737555?0xf3c:0xa979]});
  if(t.deckReceiptCount)put(wing,{type:33,setcodes:[t.family===259395418?0x1019:0x191]});
  if(t.melvilleReceipt)for(const code of [body,wing])put(code,{type:t.family===238276575?2:33,setcodes:[t.family===238276575?0x90:0xe2f]});
  if(t.windborneRecovery)put(link,{type:t.family===janna?2:33,setcodes:[0x21fc]});
  if(t.jannaSearch){
   put(body,{type:0x1011,level:2,setcodes:[0x21fc]});
   put(wing,{type:17,level:data.get(janna).level-2,setcodes:[0x21fc]});
   put(link,{type:17,setcodes:[0x21fc]});
  }
  if(t.briaRecycle)put(body,t.briaExtraReceipt?{type:0x61}:{type:33,setcodes:[0xbc5]});
  if(t.drawReceipt){
   if(t.family===bria)put(body,{type:33,setcodes:[0xbc5]});
   if(t.family===observatory){put(body,{type:33,setcodes:[0xeb17]});put(spell,{type:0x10002,setcodes:[0xf2f4]});}
   if(t.family===charmeliaBeast){put(body,{type:0xa1,setcodes:[0x12b1]});put(helper,{type:2,setcodes:[0x12b1]});}
  }
  if(t.discardReceipt){
   if(!t.materialSynchro)put(body,{type:33,setcodes:[t.setcode]});
   if(t.family===revelation)put(wing,{setcodes:[t.setcode]});
   if([vylonTorus,behemoth].includes(t.family))put(spell,{type:t.family===vylonTorus?2:33,setcodes:[t.setcode]});
  }
  if(t.musicaleSearch){put(wing,{type:33});put(dark,{type:33});}
  if(t.musicaleSummon){put(helper,{type:2,setcodes:t.musicaleGeneric?[]:[0x8f0]});put(body,{type:33,setcodes:[0x8f0]});}
  if(t.musicaleYummy)for(const code of [253152295,226645052])data.set(code,candidateCard(code));
  if(t.musicaleStock){
   data.set(226645052,candidateCard(226645052));
   put(49669730,{type:0x20002});
   put(body,{type:33,attribute:2,level:1,race:64n});
  }
  if(t.harmonySearch)put(body,{type:t.harmonyRecoveryTrap?4:33,attribute:2,level:t.harmonyInvalidSearch==='level'?2:1,race:t.harmonyInvalidSearch==='race'?1n:64n,setcodes:t.harmonyInvalidSearch==='set'?[]:[0x8f0]});
  if(t.scarletReceipt)data.set(248946297,candidateCard(248946297));
  if(t.musicaleTranscend){
   for(const code of [259225324,226645052])data.set(code,candidateCard(code));
   put(spell,{type:0x2000021,lscale:0,rscale:0});
   put(trap,{type:0x2000021,lscale:8,rscale:8});
   put(body,{type:0x2000021,level:1});
  }
  if(t.aldrezRevive){put(body,{type:0x800021,level:4,setcodes:[0xc1c]});put(wing,{type:17});}
  if(t.heartbeatMaterial){put(body,{type:0x800021,level:2,setcodes:t.wrongBrigadeHost?[]:[0x7a34]});put(dark,{type:33});}
  if(t.standDraw)put(body,{type:33,setcodes:t.standDraw==='wrong-set'?[]:[0x7a34]});
  if(t.brigadeSummon){put(body,{type:0x800021,level:4,setcodes:[0x7a34]});put(wing,{type:17,setcodes:[0x7a34]});}
  if(t.standProbe||t.showdownProbe){put(body,{type:0x800021,level:t.standProbe?4:12,setcodes:t.standProbe?[0x7a34]:[]});put(wing,{type:17,setcodes:[0x7a34]});put(spell,{type:17});}
  if(t.revengeStats)put(body,{type:33,setcodes:[0x7a34]});
  if(t.armadaRevive){put(body,{type:33,setcodes:[0x7a34]});put(wing,{type:33,setcodes:[0x7a34]});}
  if(t.hopeDeckRemoval)put(dark,{type:33});
  if(t.hopeProbe){put(body,{type:33,setcodes:[t.family===259664027?0x715b:0x7a34]});put(wing,{type:33,level:t.hopeProbe==='wrong-level'?3:2,setcodes:[t.family===259664027?0x715b:0x7a34]});put(fusion,{type:17});}
  if(t.lastStandEnd){put(body,{type:17,setcodes:t.lastStandEnd>=2?[0x7a34]:[]});put(wing,{type:17,setcodes:t.lastStandEnd>=3?[0x7a34]:[]});put(spell,{type:2,setcodes:[]});}
  if(t.lastStandNeg){put(body,{type:33,setcodes:[0x7a34]});put(dark,{type:t.lastStandNeg==='spell'?2:33});}
  if(t.standProtect){put(body,{type:17,setcodes:[0x7a34]});put(wing,{type:17,setcodes:t.standProtect==='wrong-set'?[]:[0x7a34]});}
  if(t.aureliaCondition)put(body,{type:17,setcodes:t.aureliaCondition==='wrong-set'?[]:[0xf3c]});
  if(t.argaliaCondition||t.ddjCondition||t.axisCondition){const mode=t.argaliaCondition||t.ddjCondition||t.axisCondition;put(body,{type:17,setcodes:mode==='wrong-set'?[]:[t.argaliaCondition?0x3de1:t.ddjCondition?0x1066:0x760]});if(t.axisCondition)put(dark,{type:17,level:4});}
  if(t.lovingSummon)put(body,{type:17,setcodes:t.lovingSummon==='wrong-set'?[]:[0x7a34]});
  if(t.lovingMaterial)put(trap,{type:4,setcodes:[0x7a34]});
  if(t.floweringRecovery)put(wing,{type:17,setcodes:[0x7a34]});
  if(t.letsGo){put(body,{type:17,attribute:16,setcodes:[0x7a34]});put(spell,{type:2,setcodes:[0x7a34]});}
  if(t.letsGo){put(fusion,{type:17,attribute:t.priorLight?16:32});put(wing,{type:17,attribute:16});}
  if(t.melodySummons){put(body,{type:17,setcodes:[0x7a34]});put(wing,{type:17,setcodes:t.melodySummons==='wrong-set'?[]:[0x7a34]});put(fusion,{type:17,setcodes:[0x7a34]});}
  if(t.companionProtect){put(body,{type:17,setcodes:t.companionProtect==='wrong-set'?[]:[0x7a34]});put(wing,{type:17,setcodes:[]});}
  if(t.companionAttack){put(body,{type:17,attack:4000,setcodes:[0x7a34]});put(wing,{type:17,setcodes:[0x7a34]});}
  if(t.supremacyNeg||t.nordbarNegate)put(dark,{type:t.monsterActivation?33:2});
  if(t.originsAttach==='spell-target')put(wing,{type:2});
  if(t.brigadeOnSummon){put(body,{type:17,setcodes:[0x7a34]});put(spell,{type:2,setcodes:[0x7a34]});put(wing,{type:17,setcodes:[]});put(fusion,{type:17,setcodes:[0x7a34]});}
  if(t.joyousRevive)put(body,{type:17,setcodes:t.joyousRevive==='wrong-set'?[]:[0x7a34]});
  if(t.revengeRevive){put(body,{type:17,setcodes:['wrong-set','battle-wrong-set'].includes(t.revengeRevive)?[]:[0x7a34]});put(wing,{type:17,attack:700});put(fusion,{type:17,attack:1400});}
  if(t.revengeStandby)put(wing,{type:t.revengeStandby==='spell'?2:17,setcodes:t.revengeStandby==='wrong-set'?[]:[0x7a34]});
  if(t.brigadeXyz)for(const [i,code] of t.recipeMaterials.entries())put(code,{type:17,level:t.brigadeXyz==='wrong-level'&&i===t.recipeMaterials.length-1?3:2,setcodes:t.brigadeXyz==='wrong-set'&&i===t.recipeMaterials.length-1?[]:[0x7a34]});
  if(t.brigadeLink)for(const [i,code] of t.recipeMaterials.entries())put(code,{type:i===0&&t.brigadeLink==='link-material'?0x4000021:17,level:1,link_marker:1,setcodes:i===0&&t.brigadeLink!=='wrong-set'?[0x7a34]:[]});
  if(t.brigadeFieldSearch!==undefined)put(body,{type:17,setcodes:t.brigadeFieldSearch?[0x7a34]:[]});
  if(t.standReset)put(dark,{type:33});
  if(t.hexatronIdentity){put(wing,{type:33,setcodes:[0x9894]});put(body,{type:33});put(36211150,{type:17,race:16777216n});}
  if(t.siliaIdentity)put(body,{type:17,setcodes:[0xbc5]});
  if(t.bhodiIdentity){put(wing,{type:17,race:8n});put(dark,{type:33});put(trap,{type:33});}
  if(t.supremacyBattle)put(body,{type:17,attack:100,setcodes:t.supremacyBattle==='wrong-set'?[]:[0x7a34]});
  if(t.yummyGlobal)put(body,{type:17,attack:100,level:t.supremacyBattle==='wrong-set'?2:1});
  if(t.originsProtect){put(body,{type:17,setcodes:t.originsProtect==='wrong-set'?[]:[0x7a34]});put(wing,{type:17,setcodes:[]});put(dark,{type:t.originsProtect==='monster'?33:t.originsProtect==='trap'?4:2});}
  if(t.originsFullPendulum){put(body,{type:0x1000011,lscale:1,rscale:1});put(wing,{type:0x1000011,lscale:8,rscale:8});}
  if(t.bitronCopy){data.set(259546637,candidateCard(259546637));put(body,{type:17,setcodes:[0x9894]});put(dark,{type:33});}
  if(t.stainlessCopy){data.set(221822671,candidateCard(221822671));put(body,{type:17,setcodes:[0xbc5]});put(dark,{type:33});}
  if(t.storyCopiedCode){data.set(t.storyCopiedCode,candidateCard(t.storyCopiedCode));put(body,t.briaExtraReceipt?{type:0x61}:{type:17,setcodes:[0xbc5]});put(dark,{type:33});put(wing,{type:t.storyCopyKind==='feness'?33:17});}
  if(t.floweringCount)put(body,{type:17,setcodes:[0x7a34]});
  if(t.brigadeFieldBoth){put(body,{type:0x800021,level:4,setcodes:[0x7a34]});put(wing,{type:17,setcodes:[0x7a34]});put(spell,{type:2,setcodes:[]});put(trap,{type:4,setcodes:[]});}
  if(t.heartbeatNegate)put(dark,{type:33});
  if(t.useLockProbe){put(body,{type:33,race:4n});put(fusion,{type:17,race:t.family===247298564?4n:64n,attribute:t.family===247298564?16:2});put(wing,{type:17,attribute:32});put(spell,{type:17,attribute:t.family===247298564?16:2});}
  if(t.potUseLock){put(body,{type:33});put(dark,{type:33});put(spell,{type:2});}
  if(t.extraUseLockProbe){put(body,{type:17,setcodes:[t.family===259780273?0x8de0:0x8f0]});put(wing,{type:17,attribute:32,setcodes:[]});put(spell,{type:17,attribute:2,setcodes:t.family===259780273?[0x8de0]:[]});}
  if(t.aquaUseLock)put(fusion,{type:0x61,attribute:2,setcodes:[0xf3c]});
  if(t.offertoriumUseLock){put(wing,{type:17,attribute:32});put(spell,{type:17,attribute:16,race:8n});}
  if(t.necroValley){put(47355498,{type:0x80002});put(body,{type:0x800021,setcodes:[0x7a34]});put(wing,{type:17,setcodes:[0x7a34]});}
  if(t.aeroNecro){put(47355498,{type:0x80002});put(wing,{type:17,setcodes:[0x3de1]});}
  if(t.selfOverlayNecro){put(47355498,{type:0x80002});if(!t.arcGY)put(body,{type:0x800021,level:t.family===244163199?12:6,attribute:8});}
  if(t.nauticaOverlay){put(body,{type:0x800021,level:2,attribute:t.adventuresOverlay==='wrong-attribute'?32:2});put(fusion,{type:17,level:2});}
  if(t.adventuresOverlay==='grave-reset')for(const code of [spell,link])put(code,{type:17,level:2});
  if(t.adventuresOverlay==='independent'){
   put(spell,{type:33,setcodes:[0x8f0]});
   put(trap,{type:33,setcodes:[0x8f0]});
   put(dark,{type:33});
  }
  if(t.chainNecro)put(dark,{type:33});
  if(t.chainLimitCopies){put(body,{type:17,setcodes:[0xa122]});put(wing,{type:17,setcodes:[0xa122]});}
  if(t.myutantRecovery){put(helper,{type:33});put(34572613,{type:0x80002,setcodes:[0x157]});put(body,{type:4,setcodes:[0x157]});put(spell,{type:2});}
  if(t.pastrygeistSet){put(helper,{type:33});put(mansion,{type:0x80002,setcodes:[0x8d]});put(body,{type:4,setcodes:[0x8d]});put(wing,{type:33,setcodes:[0x8d]});put(spell,{type:2});}
  if(t.mirageSet){put(helper,{type:33});put(huntingGround,{type:0x80002,setcodes:[0x64]});put(harpieLady,{type:17,setcodes:[0x64]});put(body,{type:4});put(spell,{type:2});}
  if(t.solemnSet){put(wing,{type:0x80002});put(body,{type:4});put(spell,{type:2});put(fusion,{type:2});}
  if(t.setCapacityChain){put(fusion,{type:2});put(dark,{type:33});}
  if(t.cutiferSet){put(helper,{type:33});put(wing,{type:t.cutiferSet.startsWith('field')?0x80002:t.cutiferSet.startsWith('monster')?33:4});put(body,{type:0x80002});put(spell,{type:2});}
  if(t.slimeTarget)put(wing,{type:t.slimeTarget==='link'?0x4000021:33,link_marker:t.slimeTarget==='link'?2:0});
  if(t.galaxixFieldRecovery){put(helper,{type:33});put(body,{type:t.galaxixFieldRecovery.includes('field')?0x80002:4,setcodes:t.galaxixFieldRecovery.startsWith('wrong-set')?[]:[0x760]});put(spell,{type:2});}
  if(t.selfEquipCapacity){put(body,{type:t.family===248801935?0x221:17,setcodes:t.family===229875953?[0x39e2]:[]});put(spell,{type:2});}
  if(t.roarEquipCapacity){put(body,{type:17});put(wing,{type:17,level:4,setcodes:[0x3b]});put(spell,{type:2});}
  if(t.capacityCostRelease){put(body,{type:17,race:16n,level:5});put(trap,{type:0x20004});put(spell,{type:2});}
  if(t.capacityFollowup){const sets={239932270:0x16d,259766646:0x191,259820516:0x3135,259826112:0x173};put(body,{type:t.family===239935100?65:t.capacityFollowup==='field-zone'?0x80002:t.family===239932270?0x20002:t.family===259826112?4:2,setcodes:[sets[t.family]||0],attribute:2,race:t.family===239935100?524288n:8n});put(spell,{type:2});if(t.family===259820516)put(wing,{type:17,race:128n});if(t.family===259766646)put(70155677,{type:0x1000021,level:1,race:4n,attribute:16,lscale:8,rscale:8});}
  if(t.preparationImmediate)put(body,{type:t.preparationImmediate==='trap'?4:0x10002,setcodes:[0x9c9]});
  if(t.preparationFacedown)for(const code of [body,trap])put(code,{type:2,setcodes:[0x9c9]});
  if(t.preparationTargetInterrupt)for(const code of [body,wing])put(code,{type:2,setcodes:[0x9c9]});
  if(t.preparationOwnership){put(body,{type:2,setcodes:[0x9c9]});put(wing,{type:2,setcodes:[0x9c9]});}
  if(t.preparationSetEligibility){put(body,{type:2,setcodes:[0x9c9]});put(wing,{type:2,setcodes:[]});put(spell,{type:2,setcodes:[0x9c9]});put(trap,{type:33,setcodes:[0x9c9]});}
  if(t.preparationSetThree)for(const code of [body,wing,spell,trap])put(code,{type:2,setcodes:[0x9c9]});
  if(t.preparationNecro)put(47355498,{type:0x80002});
  if(t.preparationCost)put(spell,{type:t.preparationCost==='monster-only'?33:t.preparationCost==='valid-trap'?4:2});
  if(t.preparationShared){put(body,{type:2,setcodes:[0x9c9]});put(wing,{type:2,setcodes:[0x9c9]});put(spell,{type:2});}
  if(t.capacityField){const set=t.family===210696007?0x9c9:0x21fc;put(body,{type:t.capacityField==='field-plus-normal'?2:0x80002,setcodes:[set]});put(wing,{type:0x80002,setcodes:[set]});put(fusion,{type:0x80002});put(spell,{type:2});}
  if(t.galacticPlacementCapacity){put(body,{type:2,setcodes:[0x9c9]});put(spell,{type:2});}
  if(t.windborneCapacity||t.windborneOnlySet){put(body,{type:2,setcodes:[0x21fc]});put(wing,{type:2,setcodes:[0x21fc]});put(spell,{type:2});}
  if(t.gravinityPlacementCapacity){put(body,{type:17,setcodes:[0x760]});put(spell,{type:2});}
  if(t.gravinityPlace){put(body,{type:17,setcodes:t.gravinityPlace==='wrong-set'?[]:[0x760]});put(wing,{type:17,setcodes:t.gravinityPlace==='wrong-set'?[]:[0x760]});for(const c of [spell,trap,fusion])put(c,{type:2});}
  if(t.gravinitySynchro){put(body,{type:0x1011,level:2,setcodes:[0x760]});put(wing,{type:17,level:2,setcodes:t.gravinitySynchro==='wrong-material-set'?[]:[0x760]});put(fusion,{type:0x2021,level:4,setcodes:t.gravinitySynchro==='wrong-Synchro-set'?[]:[0x760]});put(spell,{type:2});}
  if(t.gravinityColumn){put(body,{type:17,setcodes:[0x760]});put(wing,{type:17,setcodes:[0x760]});put(spell,{type:17});put(fusion,{type:17});put(trap,{type:2});}
  if(t.gravinityTypeTransfer)put(body,{type:17,setcodes:[0x760]});
  if(t.gravinityInterrupt){put(body,{type:t.family===215768254?4:17,setcodes:[0x760]});put(dark,{type:33});}
  if(t.damageBanishEvent){put(body,{type:t.family===259605536?65:[216620496,259542408].includes(t.family)?2:17,setcodes:t.family===212413422?[0xbd]:t.family===259542408?[0x3135]:[]});put(wing,{type:17});}
  if(t.pendulumLeaveBattle||t.urphielBattleLeave)put(dark,{type:17,attack:10000});
  if(t.opponentCardBattle){const set=t.family===259669838?0x104:0x3135;put(body,{type:17,setcodes:t.opponentCardBattle==='matching'?[set]:[]});put(wing,{type:17,setcodes:[set]});}
  if(t.eventBattleBoss){put(t.eventBattleBoss,{type:17});put(wing,{type:17,race:8192n,attribute:16});}
  if(t.disccsChainCallbacks)put(wing,{type:17,setcodes:[0x1066]});
  if(t.megalSharedChain){put(body,{type:17,attribute:8,race:2048n});put(wing,{type:17,setcodes:[0x4714]});}
  if(t.materialNative)put(wing,{type:17,level:2});
  if(t.forwardMaterial)put(dark,{type:t.forwardMaterial==='monster-first'?33:2});
  if(t.alternativeReceipt){
   const sets={212684822:0x27e9,227362839:0xb47,247755865:0xa121,254065048:0x7398,259177849:0x67ee,259688514:0x575d,210696007:0x9c9,259187643:0xfe,258328859:0x4ac0,221822671:0xbc5,238711686:0x8f0,240511702:0x6f4,245970073:0xbc5,246216813:0x813,259578863:0x67ee,221759221:0x21fc};
   put(t.receiptTarget,{type:[212684822,227362839,254065048,210696007,259187643,246216813,259578863,221759221].includes(t.family)?2:33,setcodes:[sets[t.family]]});
   if(t.family===227362839)put(body,{type:2,setcodes:[0xb47,0x452f]});
   if(t.family===221759221)put(wing,{type:17,level:2});
  }
  if(t.zephorionReceipt)put(214552846,{type:0x80002});
  const reader=name=>{
   if(t.preparationTargetInterrupt&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function() local ce=Duel.GetChainInfo(0,1) return ce and ce:GetHandler():IsCode(210696007) end) e:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_REMOVED,nil,'+body+') assert(c and Duel.SendtoGrave(c,REASON_EFFECT)>0) end) c:RegisterEffect(e) end';
   if(t.preparationNegation&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e) local ce=Duel.GetChainInfo(0,1) return e:GetHandler():GetFlagEffect(id)==0 and ce and ce:GetHandler():IsCode(210696007) end) e:SetOperation(function(e) e:GetHandler():RegisterFlagEffect(id,0,0,1) '+(t.preparationNegation==='activation'?'assert(Duel.NegateActivation(1))':'assert(Duel.NegateEffect(1))')+' end) c:RegisterEffect(e) end';
   if(t.preparationImmediate&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function() end) c:RegisterEffect(e) end';
   if(t.formationMultiChain&&name==='c'+wing+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F) e:SetCode(EVENT_SPSUMMON_SUCCESS) e:SetOperation(function() end) c:RegisterEffect(e) end';
   if(t.lokaeoXyz==='upper'&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F) e:SetRange(LOCATION_MZONE) e:SetCode(EVENT_SUMMON_SUCCESS) e:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if((t.emma==='counter'||['counter','upper'].includes(t.lokaeoXyz))&&name==='c'+spell+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local a=Effect.CreateEffect(c)
     a:SetType(EFFECT_TYPE_SINGLE)
     a:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
     a:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
     c:RegisterEffect(a)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_ACTIVATE)
     e:SetCode(EVENT_SPSUMMON)
     e:SetCondition(function(e,tp,eg) return eg:IsExists(Card.IsCode,1,nil,${t.lokaeoXyz?231825514:225109525}) end)
     e:SetOperation(function(e,tp,eg) Duel.NegateSummon(eg) Duel.SendtoGrave(eg,REASON_EFFECT) end)
     c:RegisterEffect(e)
    end`;
   if((t.harmonySearch&&name==='c'+body+'.lua')||(t.scarletReceipt&&name==='c248946297.lua'))return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_IGNITION)
     e:SetRange(LOCATION_HAND+LOCATION_REMOVED)
     e:SetOperation(function() end)
     c:RegisterEffect(e)
     if ${t.harmonySearch==='redirect'||!!t.scarletReceipt&&t.redirect} then
      local r=Effect.CreateEffect(c)
      r:SetType(EFFECT_TYPE_SINGLE)
      r:SetCode(EFFECT_TO_HAND_REDIRECT)
      r:SetValue(LOCATION_REMOVED)
      c:RegisterEffect(r)
     end
    end`;
   if(t.musicaleTranscend&&[spell,trap].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';
   if(t.zephorionReceipt&&name==='c214552846.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     ${t.zephorionReceipt==='spires'?'':`local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_IGNITION)
     e:SetRange(LOCATION_FZONE)
     e:SetCountLimit(1)
     e:SetOperation(function(e,tp)
      local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${t.family})
      ${t.receiptTarget===214552846&&t.redirect?`local target=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_DECK,0,nil,214552846)
      local redirect=Effect.CreateEffect(e:GetHandler())
      redirect:SetType(EFFECT_TYPE_SINGLE)
      redirect:SetCode(EFFECT_TO_HAND_REDIRECT)
      redirect:SetValue(LOCATION_REMOVED)
      target:RegisterEffect(redirect)`:''}
      assert(Duel.Destroy(tc,REASON_EFFECT)==1)
     end)
     c:RegisterEffect(e)`}
    end`;

   if(t.galacticaLeave&&name==='c'+fusion+'.lua')return neutral;
   if(t.alternativeReceipt&&name==='c'+t.receiptTarget+'.lua')return `local s,id=GetID()
    ${t.zephorionReceipt?'s.listed_names={214552846}':''}
    function s.initial_effect(c)
     ${t.zephorionReceipt?'aux.AddCodeList(c,214552846)':''}
     ${t.redirect?`local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_SINGLE)
     e:SetCode(EFFECT_TO_HAND_REDIRECT)
     e:SetValue(LOCATION_REMOVED)
     c:RegisterEffect(e)`:''}
    end`;
   if(t.melvilleReceipt&&[body,wing].some(code=>name==='c'+code+'.lua')){
    const redirected=t.melvilleReceipt==='all'||t.melvilleReceipt==='partial'&&name==='c'+body+'.lua';
    return redirected?`local s,id=GetID()
     function s.initial_effect(c)
      local e=Effect.CreateEffect(c)
      e:SetType(EFFECT_TYPE_SINGLE)
      e:SetCode(EFFECT_TO_HAND_REDIRECT)
      e:SetValue(LOCATION_REMOVED)
      c:RegisterEffect(e)
     end`:neutral;
   }
   if(t.melvilleReceipt&&[link,trap,fusion].some(code=>name==='c'+code+'.lua'))return neutral;
   if(t.groupedDeckDraw&&[body,wing].some(code=>name==='c'+code+'.lua')){
    const redirected=t.groupedDeckDraw==='all'||t.groupedDeckDraw==='partial'&&name==='c'+body+'.lua';
    return redirected?`local s,id=GetID()
     function s.initial_effect(c)
      local e=Effect.CreateEffect(c)
      e:SetType(EFFECT_TYPE_SINGLE)
      e:SetCode(EFFECT_TO_DECK_REDIRECT)
      e:SetValue(LOCATION_REMOVED)
      c:RegisterEffect(e)
     end`:neutral;
   }
   if(t.groupedDeckDraw&&name==='c'+link+'.lua')return neutral;
   if((t.fusionDeckPayment||t.exactDeckReturn&&t.family===248940511)&&name==='c'+link+'.lua')return neutral;
   if(t.fusionDeckPayment&&name==='c'+fusion+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     c:EnableReviveLimit()
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_SINGLE)
     e:SetCode(EFFECT_FUSION_MATERIAL)
     e:SetCondition(function(e,g) return g and g:IsExists(Card.IsCode,1,nil,${body}) and g:IsExists(Card.IsCode,1,nil,${wing}) end)
     e:SetOperation(function(e,tp,eg) Duel.SetFusionMaterial(eg:Filter(function(mc) return mc:IsCode(${body},${wing}) end,nil)) end)
     c:RegisterEffect(e)
    end`;
   if(t.exactDeckReturn&&name==='c259177849.lua')return neutral;
   if(t.octantisUpgrade&&name==='c'+wing+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_SPSUMMON_CONDITION) c:RegisterEffect(e) end';
   if(t.baubaReceipt&&t.redirect&&(name==='c'+body+'.lua'||t.revealGroup&&t.redirectAll&&name==='c'+wing+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_TO_HAND_REDIRECT) e:SetValue(LOCATION_REMOVED) c:RegisterEffect(e) end';
   if(t.lokaeoRecycle==='redirect'&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_TO_DECK_REDIRECT) e:SetValue(LOCATION_REMOVED) c:RegisterEffect(e) end';
   if((t.deckReceiptCount||t.exactDeckReturn||t.singleDeckDraw||t.singleDeckSuccessor&&![248760718,259635008].includes(t.family))&&name==='c'+body+'.lua')return t.redirect?`local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_SINGLE)
     e:SetCode(EFFECT_TO_DECK_REDIRECT)
     e:SetValue(${(t.singleDeckDraw||t.singleDeckSuccessor&&t.family!==259177849||t.exactDeckReturn&&![259820516,245395343].includes(t.family))?"LOCATION_REMOVED":"LOCATION_GRAVE"})
     c:RegisterEffect(e)
    end`:neutral;
   if(t.deckReceiptCount&&t.family===259395418&&name==='c'+helper+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_ACTIVATE)
     e:SetCode(EVENT_FREE_CHAIN)
     e:SetOperation(function(e,tp)
      local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,nil,259395418)
      assert(Duel.SpecialSummon(tc,100,tp,tp,false,false,POS_FACEUP)==1)
      tc:RegisterFlagEffect(259395418,RESET_EVENT+RESETS_STANDARD,0,1)
     end)
     c:RegisterEffect(e)
    end`;
   if(t.windborneRecovery&&!t.jannaRevealRedirect&&name==='c'+link+'.lua')return neutral;
   if(t.jannaRevealRedirect&&name==='c'+link+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_SINGLE)
     e:SetCode(EFFECT_TO_HAND_REDIRECT)
     e:SetValue(LOCATION_REMOVED)
     c:RegisterEffect(e)
    end`;
   if(t.jannaSearch&&name==='c'+helper+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_ACTIVATE)
     e:SetCode(EVENT_FREE_CHAIN)
     e:SetOperation(function(e,tp)
      local j=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${janna})
      local g=Duel.GetMatchingGroup(function(mc) return mc:IsCode(${body},${wing}) end,tp,LOCATION_MZONE,0,nil)
      assert(#g==2)
      j:SetMaterial(g)
      Duel.SendtoGrave(g,REASON_MATERIAL+REASON_SYNCHRO)
      assert(Duel.SpecialSummon(j,SUMMON_TYPE_SYNCHRO,tp,tp,true,true,POS_FACEUP)==1)
      j:CompleteProcedure()
      ${t.redirect?`local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${spell})
      local redirect=Effect.CreateEffect(c)
      redirect:SetType(EFFECT_TYPE_SINGLE)
      redirect:SetCode(EFFECT_TO_DECK_REDIRECT)
      redirect:SetValue(LOCATION_REMOVED)
      tc:RegisterEffect(redirect)`:''}
     end)
     c:RegisterEffect(e)
    end`;
   if(t.briaRecycle&&t.redirect&&name==='c'+dark+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_QUICK_O)
     e:SetCode(EVENT_CHAINING)
     e:SetRange(LOCATION_MZONE)
     e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${t.family}) end)
     e:SetOperation(function(e,tp)
      local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,${body})
      local redirect=Effect.CreateEffect(c)
      redirect:SetType(EFFECT_TYPE_SINGLE)
      redirect:SetCode(${t.redirectDeck?'EFFECT_TO_DECK_REDIRECT':'EFFECT_TO_HAND_REDIRECT'})
      redirect:SetValue(LOCATION_REMOVED)
      tc:RegisterEffect(redirect)
     end)
     c:RegisterEffect(e)
    end`;
   if(t.ownSearch&&t.redirect&&name==='c'+dark+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_QUICK_O)
     e:SetCode(EVENT_CHAINING)
     e:SetRange(LOCATION_MZONE)
     e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${t.family}) end)
     e:SetOperation(function(e,tp)
      local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,${t.discardOrigin??D},nil,${t.discardResource??body})
      local redirect=Effect.CreateEffect(c)
      redirect:SetType(EFFECT_TYPE_SINGLE)
      redirect:SetCode(EFFECT_TO_HAND_REDIRECT)
      redirect:SetValue(${t.redirectDestination??G})
      tc:RegisterEffect(redirect)
      ${t.redirectBoth?"Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_DECK,nil,"+spell+"):RegisterEffect(redirect:Clone())":""}
     end)
     c:RegisterEffect(e)
    end`;
   if(t.musicaleSearch&&name==='c'+wing+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_IGNITION)
     e:SetRange(LOCATION_MZONE+LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED)
     e:SetOperation(function() end)
     c:RegisterEffect(e)
    end`;
   if(t.musicaleSearch==='success'&&name==='c'+dark+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_IGNITION)
     e:SetRange(LOCATION_MZONE)
     e:SetOperation(function() end)
     c:RegisterEffect(e)
    end`;
   if(t.musicaleSearch&&t.musicaleSearch!=='success'&&name==='c'+dark+'.lua'){
    const disrupt=t.musicaleSearch==='no-candidate'
     ?'assert(Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0)'
     :t.musicaleSearch==='draw-blocked'
     ?'local lock=Effect.CreateEffect(c) lock:SetType(EFFECT_TYPE_FIELD) lock:SetCode(EFFECT_CANNOT_DRAW) lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET) lock:SetTargetRange(0,1) lock:SetReset(RESET_PHASE+PHASE_END) Duel.RegisterEffect(lock,tp)'
     :'local redirect=Effect.CreateEffect(c) redirect:SetType(EFFECT_TYPE_SINGLE) redirect:SetCode(EFFECT_TO_HAND_REDIRECT) redirect:SetValue(LOCATION_GRAVE) tc:RegisterEffect(redirect)';
    return `local s,id=GetID()
     function s.initial_effect(c)
      local e=Effect.CreateEffect(c)
      e:SetType(EFFECT_TYPE_QUICK_O)
      e:SetCode(EVENT_CHAINING)
      e:SetRange(LOCATION_MZONE)
      e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(259797813) end)
      e:SetOperation(function(e,tp)
       local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_DECK,0,nil,${wing})
       ${disrupt}
      end)
      c:RegisterEffect(e)
     end`;
   }
   if(t.musicaleSummon&&name==='c'+helper+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_ACTIVATE)
     e:SetCode(EVENT_FREE_CHAIN)
     e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk)
      if chk==0 then return true end
      local loc=${t.musicaleFromGY?'LOCATION_GRAVE':'LOCATION_HAND'}
      local reportedLocation=${t.musicaleReport==='group-only'?'0':t.musicaleReport==='mixed'?'LOCATION_HAND+LOCATION_GRAVE':'loc'}
      Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,Duel.GetFirstMatchingCard(Card.IsCode,tp,loc,0,nil,${body}),1,${t.musicaleReport==='group-only'?'0':'tp'},reportedLocation)
     end)
     e:SetOperation(function(e,tp)
      Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,tp,${t.musicaleFromGY?'LOCATION_GRAVE':'LOCATION_HAND'},0,nil,${body}),0,tp,tp,false,false,POS_FACEUP)
     end)
     c:RegisterEffect(e)
    end`;
   if(t.chainNecro&&name==='c'+dark+'.lua'){
    const operation=t.dragarTargetLeaves
     ?'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+wing+') assert(Duel.SendtoGrave(tc,REASON_EFFECT)>0)'
     :t.faceDownRecipient
     ?'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+body+') assert(Duel.ChangePosition(c,POS_FACEDOWN_DEFENSE)>0)'
     :t.overlayControlChanged
     ?'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+body+') assert(Duel.GetControl(c,tp)>0)'
     :'local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,47355498) Duel.MoveToField(c,tp,tp,LOCATION_FZONE,POS_FACEUP,true)';
    return 'local s,id=GetID() function s.initial_effect(c) local ex=Effect.CreateEffect(c) ex:SetType(EFFECT_TYPE_QUICK_O) ex:SetCode(EVENT_CHAINING) ex:SetRange(LOCATION_MZONE) ex:SetCountLimit(1) ex:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+t.family+') end) ex:SetOperation(function(e,tp) '+operation+' end) c:RegisterEffect(ex) end';
   }
   if(t.aquaUseLock&&name==='c'+fusion+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcFunRep(c,aux.TRUE,2,true) end';
   if(t.potUseLock&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) c:RegisterEffect(e) end';
   if(t.useLockProbe&&t.family===247298564&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local ex=Effect.CreateEffect(c) ex:SetType(EFFECT_TYPE_IGNITION) ex:SetRange(LOCATION_MZONE) ex:SetCountLimit(1) ex:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,247298564) Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(ex) end';
   if(t.heartbeatNegate&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local ex=Effect.CreateEffect(c) ex:SetType(EFFECT_TYPE_QUICK_O) ex:SetCode(EVENT_CHAINING) ex:SetRange(LOCATION_MZONE) ex:SetCountLimit(1) ex:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+t.family+') end) ex:SetOperation(function(e,tp,eg,ep,ev) Duel.'+(t.activationNegation?'NegateActivation':'NegateEffect')+'(ev) end) c:RegisterEffect(ex) end';
   if(t.storyCopyKind==='feness'&&name==='c'+wing+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetValue(500) c:RegisterEffect(e) end';
   if(t.bitronCopyRemoved&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local ex=Effect.CreateEffect(c) ex:SetType(EFFECT_TYPE_QUICK_O) ex:SetCode(EVENT_CHAINING) ex:SetRange(LOCATION_MZONE) ex:SetCountLimit(1) ex:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+t.family+') end) ex:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+(t.storyCopiedCode||(t.stainlessCopy?221822671:259546637))+') Duel.Remove(c,POS_FACEUP,REASON_EFFECT) end) c:RegisterEffect(ex) end';
  if(t.shrinePlacement&&name==='c22702055.lua')return neutral;
   if(t.battleTactics==='opponent leaves'&&name==='c'+dark+'.lua')return `
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_QUICK_O)
 e:SetCode(EVENT_CHAINING)
 e:SetRange(LOCATION_MZONE)
 e:SetCountLimit(1)
 e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${t.family}) end)
 e:SetOperation(function(e) assert(Duel.SendtoGrave(e:GetHandler(),REASON_EFFECT)==1) end)
 c:RegisterEffect(e)
end`;
   if(t.chaosReturn==='target leaves'&&name==='c'+dark+'.lua')return `
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_QUICK_O)
 e:SetCode(EVENT_CHAINING)
 e:SetRange(LOCATION_MZONE)
 e:SetCountLimit(1)
 e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${t.family}) end)
 e:SetOperation(function(e,tp)
  local target=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_REMOVED,nil,${body})
  assert(target and Duel.SendtoHand(target,1-tp,REASON_EFFECT)==1)
 end)
 c:RegisterEffect(e)
end`;
   if(t.treasureSourceLeaves&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+t.family+') end) e:SetOperation(function(e,tp,eg,ep,ev,re) assert(Duel.Destroy(re:GetHandler(),REASON_EFFECT)==1) end) c:RegisterEffect(e) end';
   if(t.zaoSequence==='interrupted'&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(250556612) end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+trap+') assert(Duel.SendtoDeck(tc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==1) end) c:RegisterEffect(e) end';
   if(t.zaoSequence&&[spell,trap].some(code=>name==='c'+code+'.lua')){
    const amount=name==='c'+spell+'.lua'?100:200;
    const condition=t.zaoSequence==='unusable-spell'&&amount===200?' e:SetCondition(function() return false end)':'';
    return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)'+condition+' e:SetOperation(function(e,tp) Duel.Recover(tp,'+amount+'+(Duel.GetFlagEffect(tp,900009001)>0 and 0 or 1000),REASON_EFFECT) end) c:RegisterEffect(e) end';
   }
   if(t.koaiProtect&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetProperty(EFFECT_FLAG_CARD_TARGET) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SelectTarget(tp,Card.IsFaceup,'+(t.koaiProtect==='own-effect'?'tp,LOCATION_MZONE,0':'tp,0,LOCATION_MZONE')+',1,1,nil) end) c:RegisterEffect(e) end';
   if(['redirect','partial-redirect'].includes(t.koaiQuick)&&name==='c'+wing+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_TO_DECK_REDIRECT) e:SetValue(LOCATION_GRAVE) c:RegisterEffect(e) end';
   if(t.originsProtect&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType('+(t.originsProtect==='monster'?'EFFECT_TYPE_IGNITION':'EFFECT_TYPE_ACTIVATE')+') '+(t.originsProtect==='monster'?'e:SetRange(LOCATION_MZONE) e:SetCountLimit(1)':'')+' e:SetCode(EVENT_FREE_CHAIN) e:SetProperty(EFFECT_FLAG_CARD_TARGET) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SelectTarget(tp,Card.IsFaceup,tp,0,LOCATION_MZONE,1,1,nil) end) c:RegisterEffect(e) '+(t.originsProtect==='trap'?'local permit=Effect.CreateEffect(c) permit:SetType(EFFECT_TYPE_SINGLE) permit:SetCode(EFFECT_TRAP_ACT_IN_HAND) c:RegisterEffect(permit)':'')+' end';
   if(t.bhodiReset&&name==='c'+trap+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local ex=Effect.CreateEffect(c) ex:SetType(EFFECT_TYPE_QUICK_O) ex:SetCode(EVENT_CHAINING) ex:SetRange(LOCATION_MZONE) ex:SetCountLimit(1) ex:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(259072745) end) ex:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+wing+') Duel.SendtoHand(c,nil,REASON_EFFECT) Duel.SendtoGrave(c,REASON_EFFECT) end) c:RegisterEffect(ex) end';
   if(t.siliaIdentity&&t.standReset&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local ex=Effect.CreateEffect(c) ex:SetType(EFFECT_TYPE_QUICK_O) ex:SetCode(EVENT_CHAINING) ex:SetRange(LOCATION_MZONE) ex:SetCountLimit(1) ex:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(244408495) end) ex:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+body+') Duel.SendtoHand(c,nil,REASON_EFFECT) Duel.SendtoGrave(c,REASON_EFFECT) end) c:RegisterEffect(ex) end';
   if(t.hexatronIdentity&&name==='c36211150.lua')return neutral;
   if(t.hexatronIdentity&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableCounterPermit(0x1994) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetValue(500) c:RegisterEffect(e) end';
   if(t.standReset&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local ex=Effect.CreateEffect(c) ex:SetType(EFFECT_TYPE_QUICK_O) ex:SetCode(EVENT_CHAINING) ex:SetRange(LOCATION_MZONE) ex:SetCountLimit(1) ex:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+t.family+') end) ex:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,'+(t.hexatronIdentity?'LOCATION_MZONE,0':'0,LOCATION_MZONE')+',nil,'+body+') Duel.SendtoGrave(c,REASON_EFFECT) Duel.SpecialSummon(c,0,'+(t.hexatronIdentity?'tp,tp':'1-tp,1-tp')+',false,false,POS_FACEUP) end) c:RegisterEffect(ex) end';
   if(t.forwardMaterial&&name==='c'+spell+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Recover(tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(t.lovingMaterial&&name==='c'+trap+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) c:RegisterEffect(e) end';
   if(t.hopeDeckRemoval&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+t.family+') end) e:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_DECK,nil,'+wing+') Duel.SendtoGrave(c,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(t.hopeProbe&&[body,wing].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) c:RegisterEffect(e) end';
   if(t.eventBattleBoss&&name==='c'+t.eventBattleBoss+'.lua')return neutral;
   if(t.armadaRevive&&[body,wing].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetValue(500) c:RegisterEffect(e) end';
   if(t.materialNative&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddXyzProcedure(c,nil,2,2) end';
   if(t.standDraw&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange('+(t.standDraw==='grave'?'LOCATION_GRAVE':'LOCATION_MZONE')+') e:SetCountLimit(1) c:RegisterEffect(e) end';
   if(t.aldrezRevive&&t.revivingRecipient&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e:SetRange(LOCATION_MZONE) e:SetValue(function(e,re) return re:GetOwnerPlayer()==0 end) c:RegisterEffect(e) end';
   if(t.revivingRecipient&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e:SetRange(LOCATION_MZONE) e:SetValue(function() return true end) c:RegisterEffect(e) end';
   if(t.prismMaterial&&name==='c'+link+'.lua')return neutral;
   if(t.myutantRecovery&&name==='c'+helper+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,nil,211699737) Duel.SpecialSummon(c,SUMMON_TYPE_FUSION,tp,tp,true,true,POS_FACEUP) c:CompleteProcedure() end) c:RegisterEffect(e) end';
   if(t.mirageSet&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) aux.AddCodeList(c,'+harpieLady+') end';
   if(t.mirageSet&&name==='c'+harpieLady+'.lua')return neutral;
   if(t.setCapacityChain&&name==='c'+dark+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_QUICK_O)
     e:SetCode(EVENT_CHAINING)
     e:SetRange(LOCATION_MZONE)
     e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${t.family}) end)
     e:SetOperation(function(e,tp)
      local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_HAND,nil,${fusion})
      assert(Duel.MoveToField(c,tp,1-tp,LOCATION_SZONE,POS_FACEDOWN,true))
     end)
     c:RegisterEffect(e)
    end`;
   if((t.pastrygeistSet||t.mirageSet||t.cutiferSet)&&name==='c'+helper+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local function find(code,loc) return Duel.GetFirstMatchingCard(Card.IsCode,tp,loc,0,nil,code) end '+t.op+' end) c:RegisterEffect(e) end';
   if(t.galaxixFieldRecovery&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) c:RegisterEffect(e) end';
   if(t.galaxixFieldRecovery&&name==='c'+helper+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_GRAVE,0,nil,249454272) Duel.SpecialSummon(c,SUMMON_TYPE_SYNCHRO,tp,tp,true,true,POS_FACEUP) c:CompleteProcedure() end) c:RegisterEffect(e) end';
   if(t.capacityFollowup&&t.family===239935100&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() end';
   if(t.windborneOnlySet&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local ex=Effect.CreateEffect(c) ex:SetType(EFFECT_TYPE_SINGLE) ex:SetCode(EFFECT_CANNOT_TO_HAND) c:RegisterEffect(ex) end';
   if(t.gravinityInterrupt&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+t.family+') and re:GetDescription()=='+t.actionDescription+' end) e:SetOperation(function(e,tp,eg,ep,ev,re) local c=re:GetHandler() Duel.SendtoGrave(c,REASON_EFFECT) '+(t.gravinityInterrupt==='blink'?'Duel.MoveToField(c,1-tp,1-tp,LOCATION_SZONE,POS_FACEUP,true) _G["c'+t.family+'"].trapify(c)':'')+' end) c:RegisterEffect(e) end';
   if(t.burnResolution&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+burning+') end) e:SetOperation(function(e,tp) local c=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+wing+') '+(t.burnResolution==='left-field'?'Duel.SendtoHand(c,nil,REASON_EFFECT)':'local lock=Effect.CreateEffect(e:GetHandler()) lock:SetType(EFFECT_TYPE_SINGLE) lock:SetCode(EFFECT_CANNOT_TO_HAND) c:RegisterEffect(lock)')+' end) c:RegisterEffect(e) end';
   if((t.protectionProbe||t.companionProtect)&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetProperty(EFFECT_FLAG_CARD_TARGET) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SelectTarget(tp,Card.IsFaceup,tp,0,LOCATION_MZONE,1,1,nil) end) c:RegisterEffect(e) end';
   if(t.gravinitySynchro&&name==='c'+fusion+'.lua')return require('./fresh_native_two_material_synchro.cjs').recipe(body,wing);
   if(t.alternativeReceipt&&t.family===221759221&&name==='c'+fusion+'.lua')return require('./fresh_native_two_material_synchro.cjs').recipe(t.family,wing);
   if(t.materialSynchro&&name==='c'+fusion+'.lua')return require('./fresh_native_two_material_synchro.cjs').recipe(data.get(t.family).type&0x1000?t.family:body,data.get(t.family).type&0x1000?body:t.family);
   if(t.detachProbe&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) '+(t.detachMode==='effect'?'e:SetOperation(function(e,tp) e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_EFFECT) end)':'e:SetCost(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST) end)')+' c:RegisterEffect(e) end';
   if(t.immuneReplace&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e:SetRange(LOCATION_GRAVE) e:SetValue(function() return true end) c:RegisterEffect(e) end';
   if(['hand','own-grave'].includes(t.baubaSource)&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange('+(t.baubaSource==='hand'?'LOCATION_HAND':'LOCATION_GRAVE')+') e:SetCountLimit(1) e:SetOperation(function() end) c:RegisterEffect(e) end';
   if(t.nordbarNegate==='cannot negate'&&name==='c'+dark+'.lua')return `
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_IGNITION)
 e:SetRange(LOCATION_MZONE)
 e:SetCountLimit(1)
 e:SetProperty(EFFECT_FLAG_CANNOT_INACTIVATE)
 e:SetOperation(function(e,tp) Duel.Recover(tp,500,REASON_EFFECT) end)
 c:RegisterEffect(e)
 local protection=Effect.CreateEffect(c)
 protection:SetType(EFFECT_TYPE_FIELD)
 protection:SetCode(EFFECT_CANNOT_INACTIVATE)
 protection:SetRange(LOCATION_MZONE)
 protection:SetValue(1)
 c:RegisterEffect(protection)
end`;
   if(t.rewrite&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType('+(t.graveActivation||t.monsterActivation||t.banishedActivation?'EFFECT_TYPE_IGNITION':'EFFECT_TYPE_ACTIVATE')+') e:SetCode(EVENT_FREE_CHAIN) '+(t.graveActivation||t.monsterActivation||t.banishedActivation?'e:SetRange('+(t.monsterActivation?'LOCATION_MZONE':t.banishedActivation?'LOCATION_REMOVED':'LOCATION_GRAVE')+') e:SetCountLimit(1)':'')+' '+(t.ophielResponse?'e:SetProperty(EFFECT_FLAG_CARD_TARGET) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SelectTarget(tp,Card.IsCode,tp,LOCATION_MZONE,0,1,1,nil,'+wing+') end)':'')+' '+(t.opponentOp?'e:SetOperation(function(e,tp) '+t.opponentOp+' end)':'')+' c:RegisterEffect(e) end';
   if(t.formationInterrupt&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp) local ce=Duel.GetChainInfo(0,1) return ce and ce:GetHandler():IsCode('+formation+') end) e:SetOperation(function(e,tp,eg,ep,ev) '+(t.formationNegate?(process.argv.includes('--formation-negate-effect')?'assert(Duel.NegateEffect(1))':'assert(Duel.NegateActivation(1))'):'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+body+') if tc then Duel.Destroy(tc,REASON_EFFECT) end')+' end) c:RegisterEffect(e) end';
   if(name==='c0.lua')return '';
   if(t.xyzFixture&&name==='c'+fusion+'.lua')return 'local s,id=GetID() local check,summon=Card.IsXyzSummonable,Duel.XyzSummon function Card.IsXyzSummonable(c,pool,min,max) return check(c,nil,pool,min,max) end function Duel.XyzSummon(tp,c,pool,min,max) return summon(tp,c,nil,pool,min,max) end if not Duel.GetMustMaterial then Duel.GetMustMaterial=function() return Group.CreateGroup() end end function s.filter(c,xc) return c:IsFaceup() and c:IsLevel(8) end function s.check(g) return g:IsExists(function(c) return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsRace(RACE_FIEND) end,1,nil) end function s.initial_effect(c) c:EnableReviveLimit() local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_SPSUMMON_PROC) e:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE) e:SetRange(LOCATION_EXTRA) e:SetCondition(aux.XyzLevelFreeCondition(s.filter,s.check,2,2)) e:SetTarget(aux.XyzLevelFreeTarget(s.filter,s.check,2,2)) e:SetOperation(aux.XyzLevelFreeOperation(s.filter,s.check,2,2)) e:SetValue(SUMMON_TYPE_XYZ) local con,tg,op=e:GetCondition(),e:GetTarget(),e:GetOperation() e:SetCondition(function(e,c,must,pool,min,max) return con(e,c,pool,min,max) end) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk,c,must,pool,min,max) return tg(e,tp,eg,ep,ev,re,r,rp,chk,c,pool,min,max) end) e:SetOperation(function(e,tp,eg,ep,ev,re,r,rp,c,must,pool,min,max) return op(e,tp,eg,ep,ev,re,r,rp,c,pool,min,max) end) c:RegisterEffect(e) end';
   if(name==='c'+helper+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(s.op) c:RegisterEffect(e) '+(t.reset?'local observer=Effect.CreateEffect(c) observer:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) observer:SetCode(EVENT_CHAIN_SOLVED) observer:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+t.family+') end) observer:SetOperation(function() local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,'+(t.family===chapter?'LOCATION_MZONE':'LOCATION_GRAVE')+',0,nil,'+(t.family===chapter?body:spell)+') assert(tc) assert(Duel.SendtoHand(tc,nil,REASON_EFFECT)==1) '+(t.family===chapter?'assert(Duel.SpecialSummon(tc,0,0,0,false,false,POS_FACEUP)==1)':'assert(Duel.SendtoGrave(tc,REASON_EFFECT)==1)')+' end) Duel.RegisterEffect(observer,0)':'')+' end function s.op(e,tp) local function find(code,loc) return Duel.GetMatchingGroup(Card.IsCode,tp,loc,0,nil,code):GetFirst() end '+t.op+' end';
   if(name==='c'+link+'.lua')return `local s,id=GetID()
-- Translate the Omega API at the fixture boundary. This duel has no external
-- mandatory-material effects. Offertorium itself is loaded from disk as-is.
local isLinkSummonable,linkSummon=Card.IsLinkSummonable,Duel.LinkSummon
if ${t.opposingMaterial?'true':'false'} then
 local defaultMaterials=aux.GetLinkMaterials
 function aux.GetLinkMaterials(tp,f,c,e)
  local pool=defaultMaterials(tp,f,c,e)
  pool:Merge(Duel.GetMatchingGroup(aux.LConditionFilter,tp,0,LOCATION_MZONE,nil,f,c,e))
  return pool
 end
end
function Card.IsLinkSummonable(c,pool,required) return isLinkSummonable(c,required,pool) end
function Duel.LinkSummon(tp,c,pool,required) return linkSummon(tp,c,required,pool) end
if not Duel.GetMustMaterial then Duel.GetMustMaterial=function() return Group.CreateGroup() end end
function s.initial_effect(c)
 Card.IsLinkType=Card.IsLinkType or Card.IsType
 c:EnableReviveLimit()
 local e=aux.AddLinkProcedure(c,nil,2,2)
 local function fixed(required) return required and required:GetFirst() end
 local condition,target,operation=e:GetCondition(),e:GetTarget(),e:GetOperation()
 e:SetCondition(function(e,c,required,pool,min,max) return condition(e,c,pool,fixed(required),min,max) end)
 e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk,c,required,pool,min,max)
  return target(e,tp,eg,ep,ev,re,r,rp,chk,c,pool,fixed(required),min,max)
 end)
 e:SetOperation(function(e,tp,eg,ep,ev,re,r,rp,c,required,pool,min,max)
  return operation(e,tp,eg,ep,ev,re,r,rp,c,pool,fixed(required),min,max)
 end)
end`;
   if(t.venaticiToken&&name==='c229021850.lua')return neutral;
   if([...fixtures,engraver,bauWorld,bau,dysmandr,extinction,token,grayToken].some(code=>name==='c'+code+'.lua'))return neutral;
   const source=path.resolve(__dirname,'../public/CCG Downloads/CCG_Scripts',name);
   const revealCandidate=process.env.CCG_HAND_REVEAL_CANDIDATE;
   const file=[revealCandidate&&path.join(revealCandidate,name),process.env.CCG_NAUTICA_CANDIDATE&&['c259797813.lua','c248946297.lua','c259941091.lua'].includes(name)&&source,process.env.CCG_TEST_SOURCE&&t.family&&source,path.join(installed,name),path.resolve(__dirname,'../tmp/ohmen-reference',name),path.join(omega,name)].find(f=>f&&fs.existsSync(f));
   assert(file,name);let lua=fs.readFileSync(file,'utf8');if(t.preparationExpiry&&process.argv.includes('--preparation-no-expiry')&&name==='c210696007.lua')lua=lua.replace('te:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)','te:SetReset(RESET_EVENT+RESETS_STANDARD)');if(t.preparationTargetInterrupt&&process.argv.includes('--preparation-ignore-relation')&&name==='c210696007.lua')lua=lua.replace('return c:IsRelateToEffect(te) and c:IsSSetable()','return c:IsSSetable()');if(t.preparationNecro&&process.argv.includes('--preparation-ignore-necro')&&name==='c210696007.lua')lua=lua.replace('aux.NecroValleyFilter(s.selfcostfilter)(c)','s.selfcostfilter(c)').replaceAll('aux.NecroValleyFilter(s.costfilter)','s.costfilter');if(t.preparationImmediate&&process.argv.includes('--preparation-no-set-permission')&&name==='c210696007.lua')lua=lua.replace('and (tc:IsType(TYPE_TRAP) or tc:IsType(TYPE_QUICKPLAY))','and false');if(t.preparationFacedown&&process.argv.includes('--preparation-allow-facedown')&&name==='c210696007.lua')lua=lua.replace('return c:IsFaceup() and c:IsSetCard(SET_GALACTICA)','return c:IsSetCard(SET_GALACTICA)');if(t.preparationSetEligibility&&process.argv.includes('--preparation-any-target')&&name==='c210696007.lua')lua=lua.replace('c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_SPELL+TYPE_TRAP)','true');if(t.preparationSetThree&&process.argv.includes('--preparation-four-target-control')&&name==='c210696007.lua')lua=lua.replaceAll('1,3,ft','1,4,ft');if(t.preparationCost&&process.argv.includes('--preparation-any-cost')&&name==='c210696007.lua')lua=lua.replace('c~=ec and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToRemoveAsCost()','c~=ec and c:IsAbleToRemoveAsCost()');if(t.preparationShared&&process.argv.includes('--preparation-separate-limit')&&name==='c210696007.lua')lua=lua.replace('e2:SetCountLimit(1,id)','e2:SetCountLimit(1,id+100)');if(t.formationLinkLimit&&process.argv.includes('--formation-link-per-copy')&&name==='c'+formation+'.lua')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1)');if(t.formationLinkReset&&process.argv.includes('--formation-link-no-reset')&&name==='c'+formation+'.lua')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1,id+100,2)');
   if(t.musicaleStock==='repeat'&&name==='c49669730.lua'){
    // Reuse the same effect object twice while leaving its first summon on the field.
    lua=lua.replace('e1:SetCountLimit(1)','').replace('e1:SetCondition(c49669730.condition)','')
     .replace('if Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)>0 then return end','');
   }
   if((t.scarletShuffleRedirect||t.galacticaLeave==='redirect'||t.singleDeckSuccessor&&t.redirect&&[248760718,259635008].includes(t.family))&&name==='c'+t.family+'.lua')lua+=`
local initial=s.initial_effect
function s.initial_effect(c)
 initial(c)
 local redirect=Effect.CreateEffect(c)
 redirect:SetType(EFFECT_TYPE_SINGLE)
 redirect:SetCode(EFFECT_TO_DECK_REDIRECT)
 redirect:SetValue(LOCATION_REMOVED)
 c:RegisterEffect(redirect)
end`;
if(t.stainOptionalFixture&&name==='c248453205.lua')lua=lua.replace('local rg=','local fixture=Duel.GetFieldGroup(tp,0,LOCATION_DECK):Filter(Card.IsCode,nil,'+wing+'):GetFirst() fixture:ReverseInDeck() assert(fixture:IsFaceup()) local rg=');if(t.nauticaOverlay&&process.argv.includes('--nautica-control-before')&&name==='c218905439.lua')lua=lua.replace('tc:IsControler(tp) and not tc:IsImmuneToEffect(e)) then return end','not tc:IsImmuneToEffect(e)) then return end');if(t.chainLimitCopies&&process.argv.includes('--shared-chain-no-flag')&&name==='c284639726.lua')lua=lua.replace('return e:GetHandler():GetFlagEffect(id)==0','return true').replace('return Duel.GetFlagEffect(e:GetHandlerPlayer(),id)==0','return true');if(t.megalSharedChain&&process.argv.includes('--megal-chain-no-flag')&&name==='c259179054.lua')lua=lua.replaceAll('Duel.GetFlagEffect(tp,id)==0','true');if(t.disccsChainCallbacks&&process.argv.includes('--disccs-chain-no-flag')&&name==='c238273770.lua')lua=lua.replaceAll('Duel.GetFlagEffect(tp,id+400)==0','true');if((t.pendulumLeaveBattle&&process.argv.includes('--pendulum-leave-no-damage')||process.argv.includes('--leave-field-no-damage'))&&name==='c'+t.family+'.lua')lua=lua.replaceAll('EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DELAY','EFFECT_FLAG_DELAY');if(t.damageBanishEvent&&process.argv.includes('--damage-banish-permissive')&&name==='c'+t.family+'.lua'){const v=({212413422:'e3',216620496:'e2',253128790:'e1',259542408:'e6',259605536:'e4'})[t.family];lua=lua.replace(v+':SetProperty(',v+':SetProperty(EFFECT_FLAG_DAMAGE_STEP+');}return lua;
  };
  const logs=[],team={startingLP:8000,startingDrawCount:0,drawCountPerTurn:0};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:t.diceSeed?Array.from({length:4},(_,i)=>(BigInt(t.diceSeed+i)*0x9e3779b97f4a7c15n)&0xffffffffffffffffn):[1n,2n,3n,4n],team1:team,team2:team,cardReader:code=>data.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  try{
   for(const file of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,file,reader(file)));
   if(t.deckReceiptCount&&t.family===259395418)assert(core.loadScript(duel,'gladiator-summon-source-fixture.lua','aux.gbspcon=function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_SPECIAL) end'));
   if(t.singleDeckSuccessor)assert(core.loadScript(duel,'single-deck-fixture-api.lua','CHAININFO_TARGET_CARDS=8 CHAININFO_TRIGGERING_ATTRIBUTE=22 Card.IsAbleToExtra=Card.IsAbleToExtra or Card.IsAbleToDeck aux.AddSynchroProcedure=function() end'));
   if(t.alternativeReceipt&&t.family===259578863)assert(core.loadScript(duel,"isolate-oracle-link.lua","aux.AddLinkProcedure=function() end"));
   if(t.galacticaLeave)assert(core.loadScript(duel,'isolate-galactica-link-procedure.lua','aux.AddLinkProcedure=function() end'));
   if(t.groupedDeckDraw){
    assert(core.loadScript(duel,'grouped-deck-fixture-api.lua',[
     'CHAININFO_TARGET_CARDS=8',
     'Duel.GetTargetsRelateToChain=Duel.GetTargetsRelateToChain or function() return Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS) end',
     'aux.NecroValleyNegateCheck=aux.NecroValleyNegateCheck or function() return false end'
    ].join('\n')));
    if(t.family===212429024)assert(core.loadScript(duel,'isolate-nebulix-synchro.lua','aux.AddSynchroProcedure=function() end'));
   }
   if(t.jannaSearch||t.windborneRecovery||t.exactDeckReturn&&t.family===248940511)assert(core.loadScript(duel,'isolate-janna-synchro-recipe.lua','aux.AddSynchroProcedure=function() end'));
   if(t.preparationImmediate==='quick-play')assert(core.loadScript(duel,'preparation-quickplay-compat.lua','EFFECT_QP_ACT_IN_SET_TURN=19'));
   if(t.koaiQuick||t.jannaSearch||t.windborneRecovery||t.deckReceiptCount||t.exactDeckReturn||t.singleDeckDraw||t.nauticaOverlay||t.aeroNecro||t.cutiferSet||[nullbind,chapter,graysentry,vazagiel,graydeux,orb,ophiel,shards,burning,prism,failuresAip,ghostXyz,aeroXyz,shade,ghostTransfer,claw,rook,knight,227531376,244986323,215885404,284639726,210696007,233212369].includes(t.family))assert(core.loadScript(duel,'chain-target-compat.lua','CHAININFO_TARGET_CARDS=8 Card.IsCanOverlay=Card.IsCanOverlay or function(c) return c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TOKEN) end'));
// OCGCore lacks Omega's Duel.CheckXyzMaterial. Isolate the unchanged alternate
   // procedure here. The ordinary Level 12 Xyz recipe remains outside this case.
   if(t.isolateXyzRecipe||t.melissaQuick||t.melissaProtection||t.melvilleReceipt||t.alternativeReceipt&&t.family===238711686||t.aeroNecro||t.nativeSpecial||t.pastrygeistSet||t.mirageSet||t.oniQuickRecipient||t.cutiferSet)assert(core.loadScript(duel,'isolate-xyz-recipe.lua','aux.AddXyzProcedure=function() end'));
   if(t.linkRecipe||t.brigadeLink||t.linkApiOnly)assert(core.loadScript(duel,'omega-link-procedure-api.lua',[
    'Card.IsLinkType=Card.IsLinkType or Card.IsType',
    'Duel.GetMustMaterial=Duel.GetMustMaterial or function() return Group.CreateGroup() end',
    'local add=aux.AddLinkProcedure',
    'function aux.AddLinkProcedure(c,...)',
    ' local e=add(c,...) local con,tg,op=e:GetCondition(),e:GetTarget(),e:GetOperation()',
    ' local function fixed(g) return g and g:GetFirst() end',
    ' e:SetCondition(function(e,c,required,pool,min,max) return con(e,c,pool,fixed(required),min,max) end)',
    ' e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk,c,required,pool,min,max) return tg(e,tp,eg,ep,ev,re,r,rp,chk,c,pool,fixed(required),min,max) end)',
    ' e:SetOperation(function(e,tp,eg,ep,ev,re,r,rp,c,required,pool,min,max) return op(e,tp,eg,ep,ev,re,r,rp,c,pool,fixed(required),min,max) end)',
    ' return e end'
   ].join('\n')));
   if(t.xyzRecipe)assert(core.loadScript(duel,'omega-level-free-xyz-api.lua',[
    'Duel.GetMustMaterial=Duel.GetMustMaterial or function() return Group.CreateGroup() end',
    'local condition,target,operation=aux.XyzLevelFreeCondition,aux.XyzLevelFreeTarget,aux.XyzLevelFreeOperation',
    'function aux.XyzLevelFreeCondition(...) local f=condition(...) return function(e,c,required,pool,min,max) return f(e,c,pool,min,max) end end',
    'function aux.XyzLevelFreeTarget(...) local f=target(...) return function(e,tp,eg,ep,ev,re,r,rp,chk,c,required,pool,min,max) return f(e,tp,eg,ep,ev,re,r,rp,chk,c,pool,min,max) end end',
    'function aux.XyzLevelFreeOperation(...) local f=operation(...) return function(e,tp,eg,ep,ev,re,r,rp,c,required,pool,min,max) return f(e,tp,eg,ep,ev,re,r,rp,c,pool,min,max) end end'
   ].join('\n')));
   if(t.standardXyz)assert(core.loadScript(duel,'omega-basic-xyz-material-api.lua',[
    '-- Adapter for ordinary fixture monsters only. Exotic Xyz material modifiers',
    '-- and live Omega are outside these recipe cases.',
    'local function pool(c,f,lv,og)',
    ' local g=og or Duel.GetFieldGroup(c:GetControler(),LOCATION_MZONE,0)',
    ' return g:Filter(function(mc) return aux.XyzLevelFreeFilter(mc,c) and mc:IsXyzLevel(c,lv) and (not f or f(mc,c)) end,nil)',
    'end',
    'function Duel.CheckXyzMaterial(c,f,lv,min,max,og)',
    ' if min>max then return false end',
    ' return pool(c,f,lv,og):CheckSubGroup(aux.XyzLevelFreeGoal,min,max,c:GetControler(),c,nil)',
    'end',
    'function Duel.SelectXyzMaterial(tp,c,f,lv,min,max,og)',
    ' return pool(c,f,lv,og):SelectSubGroup(tp,aux.XyzLevelFreeGoal,false,min,max,tp,c,nil)',
    'end',
    'local condition,target,operation=aux.XyzCondition,aux.XyzTarget,aux.XyzOperation',
    'function aux.XyzCondition(...) local f=condition(...) return function(e,c,required,pool,min,max) return f(e,c,pool,min,max) end end',
    'function aux.XyzTarget(...) local f=target(...) return function(e,tp,eg,ep,ev,re,r,rp,chk,c,required,pool,min,max) return f(e,tp,eg,ep,ev,re,r,rp,chk,c,pool,min,max) end end',
    'function aux.XyzOperation(...) local f=operation(...) return function(e,tp,eg,ep,ev,re,r,rp,c,required,pool,min,max) return f(e,tp,eg,ep,ev,re,r,rp,c,pool,min,max) end end'
   ].join('\n')));
   if(t.emma||t.lokaeoXyz)assert(core.loadScript(duel,'omega-xyz-call-arguments.lua',[
    'local check,summon=Card.IsXyzSummonable,Duel.XyzSummon',
    'function Card.IsXyzSummonable(c,pool,min,max) return check(c,nil,pool,min,max) end',
    'function Duel.XyzSummon(tp,c,pool,min,max) return summon(tp,c,nil,pool,min,max) end'
   ].join('\n')));
   if(t.pillarReturn||t.damageBanishEvent&&t.family===212413422)assert(core.loadScript(duel,'omega-related-targets-api.lua','Duel.GetTargetsRelateToChain=Duel.GetTargetsRelateToChain or function() local e=Duel.GetChainInfo(0,1) local g=Duel.GetChainInfo(0,8) return g:Filter(Card.IsRelateToEffect,nil,e) end'));
   if(t.family===ghostXyz||t.brigadeSummon||t.armadaRevive||t.lovingMaterial||t.brigadeXyz||t.brigadeFieldBoth||t.megalSharedChain||t.galaxixFieldRecovery||t.myutantRecovery)assert(core.loadScript(duel,'faceup-grave-fixture-api.lua','Card.IsFaceupEx=Card.IsFaceupEx or function(c) return not c:IsLocation(LOCATION_ONFIELD+LOCATION_REMOVED+LOCATION_EXTRA) or c:IsFaceup() end'));
   if(t.standDraw||t.armadaDraw)assert(core.loadScript(duel,'omega-draw-chaininfo-api.lua','CHAININFO_TARGET_PLAYER=9 CHAININFO_TARGET_PARAM=10'));
   if(t.stockNegationControl)assert(core.loadScript(duel,'stock-negation-control-no-synchro-recipe.lua','aux.AddSynchroProcedure=function() end aux.NonTuner=function() return function() return true end end'));
   if(t.chaosReturn)assert(core.loadScript(duel,'omega-chaos-target-chaininfo.lua','CHAININFO_TARGET_CARDS=8'));
   if(t.galacticaBattle)assert(core.loadScript(duel,'omega-galacticarina-faceup-api.lua','Card.IsFaceupEx=Card.IsFaceupEx or function(c) return not c:IsLocation(LOCATION_ONFIELD+LOCATION_REMOVED+LOCATION_EXTRA) or c:IsFaceup() end'));
   if(t.octantisUpgrade)assert(core.loadScript(duel,'omega-octantis-open-zone-cost-stage.lua','Effect.IsCostChecked=Effect.IsCostChecked or function() return false end'));
   if(t.roarEquipCapacity)assert(core.loadScript(duel,'omega-accepted-target-stage-api.lua','Effect.IsCostChecked=Effect.IsCostChecked or function() return true end'));
   if(t.lastStandNeg||t.baubaReceipt)assert(core.loadScript(duel,'omega-trigger-location-api.lua','CHAININFO_TRIGGERING_LOCATION=4'));
   if(t.originsAttach==='spell-target')assert(core.loadScript(duel,'omega-faceup-field-overlay-api.lua','Card.IsCanOverlay=function(c) return c:IsLocation(LOCATION_ONFIELD) and not c:IsType(TYPE_TOKEN) end'));
   if(t.nauticaOverlay)assert(core.loadScript(duel,'omega-grave-trap-overlay-api.lua','local old=Card.IsCanOverlay Card.IsCanOverlay=function(c) return old(c) or c:IsCode(218905439) and c:IsLocation(LOCATION_GRAVE) end'));
   if(t.aquaUseLock)assert(core.loadScript(duel,'omega-fusion-mandatory-api.lua','Duel.GetMustMaterial=function() return Group.CreateGroup() end Duel.CheckMustMaterial=function() return true end'));
   const next={};
   const place=(code,location,player=0)=>{
    const key=player+':'+location,sequence=t.musicaleTranscend&&code===259797813?2:next[key]||0;next[key]=sequence+1;
    core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location:location===L.FZONE?T:location,sequence:location===L.FZONE?5:location===T||location===F?sequence:0,position:(t.galacticaBattle==='destruction'||['destruction','two battles'].includes(t.venaticiBattle))&&code===dark?P.FACEUP_DEFENSE:t.galacticaBattle==='face-down recruit'&&code===body||t.chaosReturn==='face-down'&&code===wing||t.hextaniusRecycle==='face-down banishment'&&code===body||t.zaokaRecovery==='face-down banishment'&&code===body||t.oroSearch==='facedown'&&code===t.family||t.bojin==='facedown'&&code===body||(t.emma==='counter'||['counter','upper'].includes(t.lokaeoXyz))&&code===spell||t.cutiferSet&&code===wing||t.oniQuickRecipient===75367227&&code===dark&&location===T||location===E||location===D||t.myutantRecovery?.includes('facedown')&&location===B&&code===34572613||t.galaxixFieldRecovery?.includes('facedown')&&location===B&&code===body||t.setSourceSpell&&location===T&&code===t.family||t.banishedTrapFacedown&&location===B&&code===trap?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   };
   for(const args of t.setup)if(!t.melvilleReceipt||args[1]!==D)place(...args);
   for(const player of t.zaokaExcavation?[1]:[0,1])for(let i=0;i<8;i++)place(t.discardReceipt||t.drawReceipt?trap:t.backwashingShared?helper:t.musicaleSearch||t.ownSearch||t.exploringBoundary?spell:dark,D,player);
   if(t.melvilleReceipt)for(const args of t.setup)if(args[1]===D)place(...args);
   if(t.adventuresOverlay==='independent')assert(core.loadScript(duel,'adventures-chain-api.lua',
    'CHAININFO_TARGET_CARDS=8 CHAININFO_TARGET_PLAYER=9 CHAININFO_TARGET_PARAM=10'));
   if(t.backwashingBoundary)assert(core.loadScript(duel,'backwashing-chain-api.lua','CHAININFO_TARGET_CARDS=8 CHAININFO_TARGET_PLAYER=9 CHAININFO_TARGET_PARAM=10'));
   if(t.exploringBoundary)assert(core.loadScript(duel,'exploring-chaininfo-api.lua','CHAININFO_TARGET_PLAYER=9 CHAININFO_TARGET_PARAM=10'));
   core.startDuel(duel);
   let auditTurn=0,familyTriggers=0,step=0,done=false,opponentTurn=false,quickUsed=false,attacked=false,opponentActivated=false,secondSpell=false,recoveredAmount=0,recoverySeen=false,protectionChecked=false,burnDamage=0,revengeDamage=0,diceRoll=0,sharedChainActive=false,sharedChainChecked=false,placedResource=false;
   const discardRevealed=new Set();
   let musicaleDraw=0,musicaleReveal=0,musicaleBottom=0,musicaleResponse=0,musicaleSearchOffers=0;
   const zaoRecovery=[],zaokaConfirmed=[];
   let nordbarChain=false,nordbarNegated=0,venaticiAttacks=0;
   let zaokaShuffles=0;
   let treasureOptionPrompts=0,chunyinNameGuard=false;
   let lokaeoUpperSolved=false,lokaeoSummonedBeforeLower=false,lokaeoLowerStarted=false;
   let lokaeoDraws=0,lokaeoRevivalOffers=0,lokaeoDeckReturn=false,lokaeoPhase=0;
   const lokaeoRevivalTurn=t.lokaeoRevivalTurn??3;
   const lokaeoAcceptRevival=t.lokaeoAcceptRevival??(t.lokaeoRecycle==='revive');
   const formationTimingTrace=[];
   let harmonyNormalSeen=false,harmonySpecialSeen=false,bobbieRecipients=0;
   let emmaChainEnded=false,emmaXyzAfterChain=false,emmaCounterChained=false;
   const respond=(type,rest)=>core.duelSetResponse(duel,{type,...rest});
   for(let i=0;i<200&&!done;i++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);
    assert(!logs.some(x=>x.type===0),logs.map(x=>x.message).join('\n'));
    for(const m of messages){
     if((t.formationTiming||t.formationMultiChain)&&[M.CHAINING,M.CHAIN_SOLVING,M.CHAIN_SOLVED,M.SPSUMMONING,M.SPSUMMONED].includes(m.type))formationTimingTrace.push(m);
     if(t.zaokaExcavation&&m.type===M.CONFIRM_DECKTOP)zaokaConfirmed.push(m.cards.length);
     if(t.zaokaExcavation&&m.type===M.SHUFFLE_DECK&&m.player===0)zaokaShuffles++;
     if(t.melvilleReceipt&&m.type===M.CONFIRM_CARDS&&m.player===1)
      for(const c of m.cards)if([body,wing].includes(c.code))discardRevealed.add(c.code);
     if(t.revealGroup&&m.type===M.CONFIRM_CARDS&&m.player===1)for(const c of m.cards)if([body,wing].includes(c.code))discardRevealed.add(c.code);
     if((t.alternativeReceipt||t.baubaReceipt)&&m.type===M.CONFIRM_CARDS&&m.player===1&&m.cards.some(c=>c.code===(t.baubaReceipt?body:t.receiptTarget)))musicaleReveal++;
     if(t.discardReceipt&&m.type===M.CONFIRM_CARDS&&m.player===1)for(const c of m.cards)if([t.discardResource??body,spell].includes(c.code))discardRevealed.add(c.code);
     if((t.jannaSearch||t.windborneRecovery)&&m.type===M.CONFIRM_CARDS&&m.player===1&&m.cards.some(c=>c.code===link))musicaleReveal++;
     if(t.ownSearch&&m.type===M.CONFIRM_CARDS&&m.player===1&&m.cards.some(c=>c.code===body))musicaleReveal++;
     if(t.harmonySearch&&m.type===M.CONFIRM_CARDS&&m.player===1&&m.cards.some(c=>c.code===body))musicaleReveal++;
     if(t.scarletReceipt&&m.type===M.CONFIRM_CARDS&&m.player===1&&m.cards.some(c=>c.code===248946297))musicaleReveal++;
     if(t.harmonyLimit&&m.type===M.SUMMONING&&m.code===wing)harmonyNormalSeen=true;
     if(t.harmonyLimit&&m.type===M.SPSUMMONING&&m.code===dark)harmonySpecialSeen=true;
     if(t.harmonySearch&&t.family===259114562&&m.type===M.SPSUMMONING&&m.code===body)bobbieRecipients++;
     if(t.lokaeoXyz==='upper'){
      if(m.type===M.CHAIN_SOLVED&&m.chain_size===2)lokaeoUpperSolved=true;
      if(m.type===M.CHAIN_SOLVING&&m.chain_size===1)lokaeoLowerStarted=true;
      if(m.type===M.SPSUMMONING&&m.code===231825514)lokaeoSummonedBeforeLower=lokaeoUpperSolved&&!lokaeoLowerStarted;
     }
     if((t.emma||t.lokaeoXyz)&&m.type===M.CHAIN_END&&familyTriggers)emmaChainEnded=true;
     if(m.type===M.SPSUMMONING&&(t.emma&&m.code===225109525||t.lokaeoXyz&&m.code===231825514))emmaXyzAfterChain=emmaChainEnded;
     if((t.emma==='counter'||['counter','upper'].includes(t.lokaeoXyz))&&m.type===M.CHAINING&&m.code===spell)emmaCounterChained=true;
     if(t.ownSearch&&m.type===M.CHAINING&&m.code===dark)musicaleResponse++;
     if((t.chainLimitCopies||t.megalSharedChain)&&m.type===M.CHAINING&&m.code===t.family&&Number(m.description)===(t.chainStartDescription??t.actionDescription))sharedChainActive=true;
     if((t.chainLimitCopies||t.megalSharedChain)&&m.type===M.CHAIN_SOLVED)sharedChainActive=false;
     if(t.musicaleSearch){
      if(m.type===M.DRAW&&m.player===0)musicaleDraw++;
      if(m.type===M.CONFIRM_CARDS&&m.player===0&&m.cards.some(c=>c.code===wing))musicaleReveal++;
      if(m.type===M.MOVE&&m.from.location===H&&m.from.controller===0&&m.to.location===D)musicaleBottom++;
      if(m.type===M.RECOVER&&m.player===0)recoveredAmount+=m.amount;
      if(m.type===M.CHAINING&&m.code===dark)musicaleResponse++;
     }
     if(t.joyousDice&&m.type===M.TOSS_DICE){assert.equal(diceRoll,0,'One native die roll');diceRoll=m.results[0];}
     if(t.revengeRevive&&m.type===M.DAMAGE&&m.player===1)revengeDamage+=m.amount;
     if(t.burnResolution&&m.type===M.DAMAGE&&m.player===1)burnDamage+=m.amount;
     if(t.forwardMaterial&&m.type===M.RECOVER&&m.player===1)recoveredAmount+=m.amount;
     if(t.galacticaBattle==='forced attack'&&m.type===M.ATTACK)assert.equal(m.target?.sequence,0,'Must attack the Galactica source rather than the other monster');
     if(t.nordbarNegate&&m.type===M.CHAIN_NEGATED)nordbarNegated++;
     if((t.nordbarNegate||t.negateUrphiel||t.lastStandNeg||t.supremacyNeg||t.stainDragar)&&m.type===M.RECOVER)recoverySeen=true;
     if(t.stainDragar&&m.type===M.RECOVER&&m.player===0)recoveredAmount+=m.amount;
     if(t.capacityFollowup&&m.type===M.MOVE&&m.card===body&&m.to.location===T)placedResource=true;
     if(t.zaoSequence&&m.type===M.RECOVER)zaoRecovery.push(m.amount);
     if(m.type===M.NEW_TURN){opponentTurn=m.player===1;auditTurn++;}
     if(t.nordbarSearch&&m.type===M.CHAINING&&m.code===t.family)
      assert.deepEqual([auditTurn,lokaeoPhase],[2,2],'Nordbar searches during opponent Standby');
     if(m.type===M.CHAINING)nordbarChain=true;
     if(m.type===M.CHAIN_END)nordbarChain=false;
     if((t.lokaeoRecycle||t.nordbarSearch||t.galacticaBattle)&&m.type===M.NEW_PHASE)lokaeoPhase=m.phase;
     if(t.galacticaBattle==='Hand start'&&m.type===M.CHAINING&&m.code===t.family)assert.equal(lokaeoPhase,8,'Hand trigger occurs at Battle Phase start');
     if(t.lokaeoRecycle&&m.type===M.MOVE&&m.card===t.pick&&m.to.location===D)lokaeoDeckReturn=true;
     if(t.lokaeoRecycle&&m.type===M.DRAW&&m.player===0&&auditTurn===2)lokaeoDraws+=m.drawn.length;
     if(t.lokaeoRecycle&&m.type===M.CHAINING&&m.code===t.family&&m.triggering_location===B)
      assert.deepEqual([auditTurn,lokaeoPhase],[lokaeoRevivalTurn,2],'Revival activates in the following turn Standby');
     if(m.type===M.CHAINING&&t.steps[step]===m.code
      &&!(t.adventuresOverlay==='independent'&&Number(m.description)===132905439*16+1))step++;
     if(m.type===M.CHAINING&&t.family===m.code&&(!t.clawSelfRevive||Number(m.description)===133137697*16+2))familyTriggers++;
     if(m.type===M.CHAINING&&m.code===soprana&&t.opponent)quickUsed=true;
    }
    assert(state!==S.END);if(state!==S.WAITING)continue;
    const p=messages.at(-1);
    switch(p.type){
    case M.SELECT_IDLECMD:{
     const code=t.steps[step];
     if(t.windborneRecovery&&auditTurn<3){respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
     const adventuresResetStep=t.adventuresOverlay==='independent'?2:t.adventuresOverlay==='grave-reset'?1:0;
     if(adventuresResetStep&&step===adventuresResetStep&&auditTurn<3){
      assert.equal(familyTriggers,adventuresResetStep,'The first turn effects resolved');
      respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
      continue;
     }
     if(t.adventuresOverlay==='independent'&&step===1){
      assert.equal(familyTriggers,1,'The Trap has resolved this turn');
      assert(!p.activates.some(c=>c.code===t.family&&c.location===T),'The second Trap copy is unavailable');
     }
     if(t.preparationExpiry&&step===1&&auditTurn<3){respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
     if(t.preparationShared&&step===1&&auditTurn<3){if(auditTurn===1)assert(!p.activates.some(c=>c.code===t.family),'Other effect must be locked this turn');respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
     if(t.backwashingShared&&step===1&&auditTurn<3){
      if(auditTurn===1)assert(!p.activates.some(c=>c.code===t.family),'Both effects share the same use limit');
      respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
      continue;
     }
     if(['count','expiry'].includes(t.exploringBoundary)&&step===1&&auditTurn<3){
      if(t.exploringBoundary==='count'&&auditTurn===1)assert(!p.activates.some(c=>c.code===t.family),'A second copy cannot activate this turn');
      respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
      continue;
     }
     if(t.melissaTurn&&step===t.steps.length&&!opponentTurn){
      assert.equal(familyTriggers,1,'Melissa activated on its controller turn');
      assert(!p.activates.some(c=>c.code===t.family),'A second use is unavailable with two materials and another search target');
      respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
      continue;
     }
     if(t.formationLinkReset&&step===1&&auditTurn<3){assert.equal(familyTriggers,1,'First Link trigger must have resolved');respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
     if(t.harmonyTurnReset&&step===1&&auditTurn<3){
      assert.equal(familyTriggers,1,'First-turn use occurred');
      respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
      continue;
     }
     if(t.harmonyOwnSummon&&step===1)assert.equal(familyTriggers,0,'Your own summon leaves the Hand effect inactive');
     if(t.harmonyLockExpiry&&step===1&&auditTurn<3){
      if(auditTurn===1)assert(!p.activates.some(c=>c.code===body),'Actual receipt is locked on the search turn');
      respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
      continue;
     }
     if(code){
      if(t.fusionDeckPayment&&t.family===227035644&&auditTurn<3){respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
      if(t.ghostTransferFamily&&code===ghostTransfer&&!opponentTurn){respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
      if(t.oniExpiry&&code===helper&&opponentTurn){respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
      const special=(t.brigadeXyz||t.brigadeLink||t.levelOneXyzRecipe)&&code===t.family||t.procedureSource&&code===t.family||t.materialNative&&code===body||t.nativeSpecial&&code===graydeux||(t.linkRecipe||t.xyzRecipe)&&code===t.family||t.materialSynchro&&code===fusion;
      if(t.chainLimitCopies&&code===t.family)assert(p.activates.some(c=>c.code===t.family&&c.sequence===1&&Number(c.description)===132639726*16),'Second copy draw effect is legal before the Chain');
      if(t.megalSharedChain&&code===helper)assert(p.activates.some(c=>c.code===t.family&&Number(c.description)===133179054*16+1),'Other copy Quick Effect legal before Chain');
      const setting=code<0&&t.setMonsterCodes?.includes(-code);
      const activationLocation=t.preparationShared?((t.preparationShared==='trap-first')===(step===0)?T:G):t.backwashingShared?((t.backwashingBoundary==='trap-first')===(step===0)?T:G):t.activationLocation;
      const list=special?p.special_summons:setting?p.monster_sets:code<0?p.summons:p.activates,index=list.findIndex(x=>x.code===Math.abs(code)&&(!t.actionDescription||x.code===helper||Number(x.description)===t.actionDescription)&&(!t.activationSequence||x.code===helper||x.sequence===t.activationSequence)&&(!activationLocation||x.code===helper||x.location===activationLocation));
      if(t.harmonySearch||t.emma)assert(![...p.summons,...p.monster_sets].some(c=>c.code===t.family),'Nautica Hand trigger cannot be Normal Summoned or Set');
      assert(index>=0,'Action unavailable '+code+(t.backwashingBoundary?' '+JSON.stringify({auditTurn,step,activationLocation,options:p.activates.map(c=>[c.code,c.location])}):'')+(t.materialNative?' '+JSON.stringify(p.special_summons)+' fields '+JSON.stringify(core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location:F})) :''));
      respond(R.SELECT_IDLECMD,{action:special?A.SELECT_SPECIAL_SUMMON:setting?A.SELECT_MONSTER_SET:code<0?A.SELECT_SUMMON:A.SELECT_ACTIVATE,index});if(code<0||special)step++;
     }else if(t.battleTactics==='expires'&&auditTurn<2)respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else if(t.nordbarSearch&&auditTurn<3)respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else if(t.lokaeoExternal&&auditTurn<(t.lokaeoObserveUntil??lokaeoRevivalTurn)||t.lokaeoRecycle==='decline-revive'&&opponentActivated&&auditTurn<4)respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else if(t.lokaeoStandby&&opponentActivated&&auditTurn<3)respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else if(t.battle&&!attacked)respond(R.SELECT_IDLECMD,{action:(t.galacticaLeave||t.galacticaOwnBattle?auditTurn>=3:opponentTurn)?A.TO_BP:A.TO_EP,index:0});
     else if((t.musicaleSearch||t.opponent||t.rewrite||t.endRecovery||t.tempLevel==='expiry'||t.statExpiry)&&!opponentTurn&&!(t.supremacyReturn&&opponentActivated)&&!(t.lokaeoStandby&&auditTurn>=3))respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else if(t.musicaleSearch==='success'&&auditTurn===2){
      assert(!p.activates.some(x=>x.code===wing),'Same-name activation is forbidden during the next turn');
      assert(p.activates.some(x=>x.code===dark),'Different-name activation remains available during the lock');
      respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     }
     else if(t.supremacyReturn&&opponentTurn&&opponentActivated)respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else if(t.forwardMaterial&&opponentActivated&&!secondSpell){const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0,'Second Spell activation available');secondSpell=true;respond(R.SELECT_IDLECMD,{action:A.SELECT_ACTIVATE,index});}
     else if((t.lokaeoRecycle==='recycle-limit'||t.baubaSource==='copy-limit')&&opponentActivated&&!secondSpell){
      const index=p.activates.findIndex(c=>c.code===dark);
      assert(index>=0,'A second opponent activation is available');
      secondSpell=true;
      respond(R.SELECT_IDLECMD,{action:A.SELECT_ACTIVATE,index});
     }
     else if(t.rewrite&&!opponentActivated){
      const index=p.activates.findIndex(x=>x.code===dark);
      assert(index>=0,'Opponent Spell unavailable');opponentActivated=true;
      respond(R.SELECT_IDLECMD,{action:A.SELECT_ACTIVATE,index});
     }else{
      if(t.negateUrphiel){
       assert.equal(recoverySeen,!!t.noRewrite,'Opponent effect negation result');
       const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===urphiel);
       assert.equal(c.overlayCards.length,t.negateMode==='no-companion'?1:0,'Detach cost and illegal-activation boundaries');
      }
      if(t.rewrite&&!t.melissaTurn&&!t.lokaeoRecycle)assert.equal(familyTriggers,t.noRewrite?0:1,'Effect rewrite activation matches available resources');
      if(t.rewrite&&t.family===grayshade&&!t.reset&&!t.blockedRecipient)assert(!core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:G}).filter(Boolean).some(x=>x.code===spell),'Target Spell did not leave the GY');
      if(t.endRecovery){assert.equal(familyTriggers,t.materials===2&&!t.noRecoveryTarget?1:0,'End Phase activation legality');const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===grayshade);assert.equal(c.overlayCards.length,t.materials===2&&!t.noRecoveryTarget?0:t.materials,'Two material cost');}
      if(t.xyzFixture&&!t.wrongXyzLevel&&!t.opposingXyzMaterial){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===fusion);assert.deepEqual(c.overlayCards.slice().sort(),[body,graysentry].sort(),'Actual material selection includes Grayscale');}
      if(t.linkRecipe&&t.invalidLinkMaterial)assert(!p.special_summons.some(c=>c.code===t.family),'Invalid Link recipe offered');
      if(t.linkRecipe&&!t.invalidLinkMaterial)assert.equal(core.duelQueryCount(duel,0,G),t.family===grayseer||t.linkThree?2:4,'Native Link Materials sent to GY');
      if(t.xyzRecipe&&t.invalidXyzMaterial)assert(!p.special_summons.some(c=>c.code===t.family),'Invalid Xyz recipe offered');
      if(t.xyzRecipe&&!t.invalidXyzMaterial){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===t.family);assert.deepEqual(c.overlayCards.slice().sort(),[body,wing].sort(),'Actual ordinary Xyz Materials');}
      if(t.azerielRevive&&['recover','decline'].includes(t.reviveMode)){
       const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).filter(Boolean).find(x=>x.code===azeriel);
       assert.equal(c.position,P.FACEUP_DEFENSE,'Azeriel revived in Defense Position');
      }
      if(t.shardsProbe&&!t.forbidden){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).filter(Boolean).find(x=>x.code===body);assert.equal(c.position,P.FACEUP_DEFENSE);}
      if(t.checkOrb){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===body);assert.deepEqual(c.overlayCards,[orb],'Orb actually attached');}
      if(t.zaokaExcavation){
       assert.deepEqual(zaokaConfirmed,t.noRewrite?[]:[3],'Exactly the top three cards are excavated');
       assert.equal(zaokaShuffles,Number(!t.noRewrite&&t.zaokaExcavation!=='all match'),'Unsent cards are shuffled into the Deck');
      }
      if(t.checkHikamSet){
       const set=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:T}).find(c=>c?.code===body);
       assert(set&&set.position&P.FACEDOWN,'Sacred Treasure Spell was Set face-down');
      }
      if(t.checkDefense){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).filter(Boolean).find(x=>x.code===wing);assert.equal(c.position,P.FACEUP_DEFENSE);}
      if(t.tempLevel){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location:F}).filter(Boolean).find(x=>x.code===t.family);assert.equal(c.level,t.tempLevel==='synchro'?4:8,'Temporary Level and expiration');}
      if(t.koaiProtect||t.protectionProbe||t.companionProtect||t.originsProtect)assert(protectionChecked,'Actual opponent target options checked');
      if(t.burnResolution)assert.equal(burnDamage,t.burnResolution==='normal'?500:0,'Damage requires a successful return at resolution');
      if(t.sarifielAttach&&['grave','banished'].includes(t.attachMode)){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===sarifiel);assert.deepEqual(c.overlayCards,[body],'Actually attached selected monster');}
      if(t.blockedRecipient){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===t.blockedRecipient);assert.deepEqual(c.overlayCards,[],'Recipient immunity blocks attachment');}
      if(t.checkAeroAttachment){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===body);assert.deepEqual(c.overlayCards,[t.family],'Actual Aerocat attachment');}
      if(t.checkHostAttachment){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===body);assert.deepEqual(c.overlayCards,[wing],'Actual material moved onto recipient');}
      if(t.verifyOverlay){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===t.overlayHost);assert.deepEqual(c.overlayCards,[t.overlayMaterial],'Actual selected attachment');}
      if(t.expectedRecipient){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===body);assert.deepEqual(c.overlayCards.slice().sort(),t.expectedRecipient.slice().sort(),'Recipient material contents');}
      if(t.ghostTransferFamily&&t.blockedRecipient){const source=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===ghostTransfer);assert(source,'Transfer source remains on field');assert.deepEqual(source.overlayCards,[wing],'Initial Deck attachment is preserved');}
      if(t.revengeStats){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.DEFENSE,controller:0,location:F}).filter(Boolean).find(c=>c.code===body);assert.equal(c.attack,t.revengeStats==='normal'?200:100,'Doubled ATK and expiry');assert.equal(c.defense,t.revengeStats==='normal'?400:200,'Doubled DEF and expiry');}
      if(t.armadaRevive){const revived=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:0,location:F}).filter(Boolean).filter(c=>[body,wing].includes(c.code));assert.equal(revived.length,t.armadaCount,'Revival count');for(const c of revived)assert.equal(c.attack,100,'Revived effects negated');}
      if(t.lastStandNeg)assert.equal(recoverySeen,t.lastStandNeg==='grave-monster','Eligible effect negated; GY monster excluded');
      if(t.lastStandEnd){assert.equal(core.duelQueryCount(duel,0,G),0,'GY cards recycled');assert.equal(core.duelQueryCount(duel,0,B),0,'Banished cards recycled');}
      if(t.axisCondition){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:1,location:F}).filter(Boolean).find(c=>c.code===dark);assert.equal(c.level,t.axisCondition==='faceup'?3:4,'Column reduction requires faceup Gravinity');}
      if(t.activationDescription!==undefined)assert.equal(p.activates.some(c=>c.code===t.family&&Number(c.description)===t.activationDescription),t.activationAvailable,'Hand summon activation condition');
      if(t.specialAvailability!==undefined)assert.equal(p.special_summons.some(c=>c.code===t.family),t.specialAvailability,'Archetype summon condition');
      if(t.forwardMaterial)assert.equal(recoveredAmount,t.forwardMaterial==='attached'?1000:t.forwardMaterial==='monster-first'?500:1500,'First Spell negated, second resolves; host eligibility');
      if(t.forbiddenSummon)assert(![...p.summons,...p.monster_sets].some(c=>c.code===t.forbiddenSummon),'No extra Normal Summon/Set available');
      if(t.nordbarNegate){
       assert.equal(nordbarNegated,Number(!t.noRewrite),'Only a negatable activation is negated');
       assert.equal(recoverySeen,!!t.noRewrite||t.nordbarNegate==='copy limit','Unnegated activations resolve');
      }
      if(t.supremacyNeg){assert(!recoverySeen,'Opponent activation negated');assert.equal(core.duelQueryCount(duel,1,B),t.supremacyBanishCount??3,'Activated card and same-name GY copies banished');}
      if(t.originsDes){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===244986323);assert.equal(c.overlayCards.length,t.originsDes==='one-material'?1:0,'Detach two materials as cost');}
      if(t.revengeRevive&&t.battle)assert.equal(familyTriggers,t.expectedFamilyUses,'Battle revival trigger count');
      if(t.revengeRevive)assert.equal(revengeDamage,t.revengeRevive==='opponent'?1400:['battle','battle-facedown'].includes(t.revengeRevive)?3000:0,'Highest opponent ATK damage and trigger boundaries');
      if(t.backwashingShared)assert.equal(familyTriggers,2,'Both effects activate on different turns');
      if(t.exploringBoundary){
       assert.equal(familyTriggers,t.expectedFamilyUses,'Actual spell activations');
       if(t.exploringBoundary==='count'){
        const hand=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:H}).filter(Boolean);
        assert.equal(hand.filter(c=>c.code===body).length,2,'Both activations resolve a search');
       }
      }
      if(t.melissaQuick){
       const xyz=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===t.family);
       assert.equal(familyTriggers,t.expectedFamilyUses,'Quick Effect activation requires cost and a legal Deck card');
       assert.equal(xyz?.overlayCards.length,t.melissaRemaining,'Exactly two materials detach on activation');
       if(t.melissaTurn){
        const hand=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:H}).filter(Boolean);
        assert.equal(hand.filter(c=>c.code===body).length,2,'Each turn resolves a separate search');
       }
       if(['set-spell','set-trap','choose-set'].includes(t.melissaQuick)){
        const set=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:T}).filter(Boolean).find(c=>c.code===t.pick);
        assert(set&&set.position&P.FACEDOWN,'The selected card is set face-down');
       }
      }
      if(t.levelOneXyzRecipe==='two'||t.levelOneXyzRecipe==='three'){
       const xyz=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===t.family);
       assert.deepEqual(xyz?.overlayCards.slice().sort(),t.recipeMaterials.slice().sort(),'Selected Level 1 monsters become material');
      }
      if(t.brigadeXyz==='legal'){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===t.family);assert.deepEqual(c.overlayCards.slice().sort(),t.recipeMaterials.slice().sort(),'Actual Brigade Xyz materials');}
      if(t.brigadeLink&&t.recipeLegal)assert.equal(core.duelQueryCount(duel,0,G),t.recipeMaterials.length,'Actual Link materials sent to GY');
      if(t.armadaDraw){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===223750159);assert.equal(c.overlayCards.length,0,'Material detached for draw');}
      if(t.hexatronIdentity){const own=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:0,location:F}).filter(Boolean).find(c=>c.code===t.family);const opp=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:1,location:F}).filter(Boolean).find(c=>c.code===body);assert.equal(opp.attack,t.standReset?600:100,'Stored monster identity and effect negation');assert.equal(own.attack,data.get(t.family).attack+(t.standReset?0:400),'ATK gain requires successful negation');}
      if(t.storyCopyKind==='feness'){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:1,location:F}).filter(Boolean).find(c=>c.code===wing);assert.equal(c.attack,100,'Copied negation still resolves');}
      if(t.storyCopiedCode&&t.bitronCopyRemoved)assert(core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:B}).filter(Boolean).some(c=>c.code===t.storyCopiedCode),'Sent monster stays banished');
      if(t.floweringCount)assert.equal(core.duelQueryCount(duel,0,G),1,'Unused legal shuffle cost remains for second copy');
      if(t.armadaCountCopies){const cards=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).filter(c=>c.code===223750159);assert.equal(cards.reduce((sum,c)=>sum+c.overlayCards.length,0),1,'Second copy retains a payable draw cost');}
      if(t.joyousDice){assert(diceRoll>=1&&diceRoll<=6,'Native die result');assert.equal(core.duelQueryCount(duel,1,B),Math.ceil(diceRoll/2),'Half-roll banish cap rounded up');assert.equal(core.duelQueryCount(duel,1,G),4-Math.ceil(diceRoll/2),'Unselected GY cards retained');}
      if(t.chainLimitCopies||t.megalSharedChain)assert(sharedChainChecked,'Actual own response window checked before Chain resolution');
      if(t.expectedHandCount!==undefined)assert.equal(core.duelQueryCount(duel,0,H),t.expectedHandCount,'Draw count');
      if(t.selfEquipCapacity){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.EQUIP_CARD,controller:0,location:T}).filter(Boolean).find(c=>c.code===t.family);assert.equal(c.equipCard?.controller,0,'Equip target controller');assert.equal(c.equipCard?.location,F,'Actual equip target location');assert.equal(c.equipCard?.sequence,0,'Equipped to seeded monster');}
      if(t.expectedPlacement!==undefined)assert.equal(placedResource,t.expectedPlacement,'Actual SZONE placement before destruction');
      if(t.formationLinkReset){const banished=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:B}).filter(Boolean);assert.equal(banished.filter(c=>c.code===formation).length,2,'Both copies paid Link trigger cost on separate turns');}
      if(t.preparationSetThree){const a=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:T}).filter(Boolean);assert.equal(a.filter(c=>[body,wing,spell,trap].includes(c.code)).length,3,'Exactly three banished cards were Set');const b=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:B}).filter(Boolean);assert.equal(b.filter(c=>[body,wing,spell,trap].includes(c.code)).length,1,'Fourth card remains banished');}
      if(t.expectedFamilyUses!==undefined)assert.equal(familyTriggers,t.expectedFamilyUses,'Named revival limit');
      if(t.expectTrigger!==undefined)assert.equal(familyTriggers,t.expectTrigger?1:0,'Unexpected Ivy trigger result');
      if(t.noTrigger)assert.equal(familyTriggers,t.family===grayrover?1:0,'An illegal Link Summon triggered');
      if(t.exactDeckReturn&&t.family===259669838){
       const witness=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:0,location:F}).filter(Boolean).find(c=>c.code===trap);
       assert.equal(witness?.attack,t.redirect?500:800,'ATK bonus requires all three Deck returns');
      }
      if(t.battleTactics){
       const stats=(code,controller)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.DEFENSE,controller,location:F})
        .flatMap(c=>c?.code===code?[c.attack,c.defense]:[]);
       const factor=['expires','opponent turn'].includes(t.battleTactics)?1:t.option===0?0:2;
       assert.deepEqual(stats(dark,1),t.battleTactics==='opponent leaves'?[]:[700*factor,300*factor]);
       assert.deepEqual(stats(wing,1),[800*factor,400*factor]);
       assert.deepEqual(stats(trap,0),[600,200],'Own monster stats are unchanged');
      }
      if(t.venaticiToken){
       const tokens=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION|Q.LEVEL|Q.RACE|Q.ATTRIBUTE|Q.ATTACK|Q.DEFENSE,
        controller:0,location:F}).filter(c=>c?.code===229021850);
       assert.equal(tokens.length,t.expectedFamilyUses,'Exactly one token for a legal activation');
       if(tokens.length){
        const [token]=tokens;
        assert.deepEqual([token.position,token.level,Number(token.race),token.attribute,token.attack,token.defense],
         [P.FACEUP_ATTACK,4,32,16,1000,0],'Machinator Token has printed properties');
       }
      }
      if(t.galacticaBattle&&t.galacticaBattle!=='Hand start'&&t.expectedFamilyUses){
       const card=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).find(c=>c?.code===body);
       assert.equal(card?.position,P.FACEUP_ATTACK,'Replacement enters Attack Position');
      }
      if(t.galacticaBattle==='Hand start'){
       const card=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).find(c=>c?.code===t.family);
       assert.equal(card?.position,P.FACEUP_ATTACK,'Hand summon enters Attack Position');
      }
      if(t.hextaniusRecycle==='four resources'){
       const remaining=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:G}).filter(c=>c&&[body,wing,spell,trap].includes(c.code));
       assert.equal(remaining.length,1,'At most three of four eligible cards are returned');
      }
      if(t.groupedDeckDraw){
       const returned=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:D}).concat(core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:H})).filter(Boolean).map(c=>c.code);
       for(const [code,loc] of t.expected)if(loc===D)assert(returned.includes(code),'Selected card reached Deck or was subsequently drawn');
      }
      if(t.singleDeckSuccessor&&t.family===259177849){
       const witness=core.duelQueryLocation(duel,{flags:Q.CODE|Q.DEFENSE,controller:0,location:F}).filter(Boolean).find(c=>c.code===wing);
       assert.equal(witness?.defense,t.redirect?200:500,'DEF bonus requires a successful Deck return');
      }
      if(t.jannaSearch||t.windborneRecovery)assert.equal(musicaleReveal,t.redirect||t.jannaRevealRedirect?0:1,'Reveal only an actual hand arrival');
      if(t.melvilleReceipt){
       const expected=t.melvilleReceipt==='all'?[]:t.melvilleReceipt==='partial'?[wing]:[body,wing];
       assert.deepEqual([...discardRevealed].sort(),expected,'Only hand arrivals receive the search reveal');
       if(t.family===234599395){
        const deck=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:D}).filter(Boolean);
        assert.equal(deck.at(-1)?.code,spell,'Unselected excavation card went to the bottom');
       }
      }
      if(t.revealGroup)assert.deepEqual([...discardRevealed].sort(),t.redirectAll?[]:t.redirect?[wing]:[body,wing],'Reveal precisely the group members that reached the Hand');
      if(t.baubaSummon==='copy-limit'){
       const hosts=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:F}).filter(c=>c?.code===t.family);
       assert.equal(hosts.length,2,'Both copies were actually summoned');
      }
      if(t.baubaReceipt)assert.equal(musicaleReveal,Number(t.baubaExpectedReceipt??!t.redirect),'Only actual Hand receipt is revealed');
      if(t.alternativeReceipt)assert.equal(musicaleReveal,t.revealExpected??Number(!t.redirect),'Reveal only actual hand receipt');
      if(t.drawReceipt){
       assert.equal(musicaleResponse,Number(t.redirect),'Redirect response resolved');
       const hand=core.duelQueryLocation(duel,{flags:Q.CODE,controller:t.drawPlayer,location:H}).filter(Boolean); assert.equal(hand.filter(c=>c.code===trap).length,t.expectedDraw,'Draw count after hand receipt');
      }else if(t.discardReceipt){
       assert.equal(musicaleResponse,Number(t.redirect),'Redirect response resolved');
       assert.deepEqual([...discardRevealed].sort(),t.discardReveal.slice().sort(),'Only received cards were revealed');
      }else if(t.ownSearch){
       const summoned=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:1,location:F}).filter(Boolean).find(c=>c.code===wing);
       assert.deepEqual([musicaleResponse,musicaleReveal,!!summoned,summoned?.attack],
        [Number(t.redirect),Number(!t.redirect),t.family===248946297&&!t.redirect,t.family===248946297&&!t.redirect?0:undefined],
        'response, reveal, opponent Summon, ATK');
      }
      if(t.musicaleSearch){
       const success=t.musicaleSearch==='success';
       const outcome=[musicaleResponse,musicaleDraw,musicaleReveal,musicaleBottom,recoveredAmount,p.activates.some(x=>x.code===wing)];
       assert.deepEqual(outcome,[success?0:1,['no-candidate','draw-blocked'].includes(t.musicaleSearch)?0:1,success?1:0,success?1:0,200,true],'response, draw, reveal, bottom, LP, same-name activation after expiry or failed receipt');
       assert.deepEqual(new Set(p.activates.filter(x=>x.code===wing).map(x=>x.location)),new Set([F,H,G,B]),'Same-name activations are available from field, hand, GY and banishment after expiry or failed receipt');
      }
      if(t.musicaleActivation)assert.equal(musicaleSearchOffers,Number(!t.noYes),'Optional search is offered only when a candidate exists');
      if(t.harmonySearch){
       if(t.harmonyLimit)assert(harmonyNormalSeen&&harmonySpecialSeen,'Both opponent summon windows occurred');
       if(t.family===259114562)assert.equal(bobbieRecipients,t.expectedFamilyUses,'Each Bobbie use summons an actual opponent Hand resource');
       assert.equal(musicaleReveal,Number(t.harmonySearch==='success'),'Only an actual Hand receipt is revealed');
       if(!t.harmonyRecoveryTrap)assert.equal(p.activates.some(c=>c.code===body),!!t.harmonyLockExpiry||t.harmonySearch==='redirect'||t.family===228040066&&t.harmonySearch==='success','Harmony locks its received card for the search turn');
      }
      if(t.scarletReceipt)assert.equal(musicaleReveal,Number(!t.redirect&&!t.scarletShuffleRedirect),'Only an actual Scarlet Hand receipt is revealed');
      if(t.chunyin){
       assert.equal(treasureOptionPrompts,Number(['position','deck','copy-limit','source-leaves'].includes(t.chunyin)),'Only distinct names enable the Deck branch');
       const target=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:1,location:F}).find(c=>c?.code===dark);
       assert.equal(target?.position,['deck','deck-only','no-branch','opponent-only','source-leaves'].includes(t.chunyin)?P.FACEUP_ATTACK:P.FACEDOWN_DEFENSE,'Only the position branch turns the selected monster face-down');
       if(['deck','deck-only','source-leaves'].includes(t.chunyin))assert(chunyinNameGuard,'The duplicate name was excluded after selecting the first copy');
      }
      if(t.bojin)assert.equal(treasureOptionPrompts,Number(t.bojin.startsWith('choose')),'Offer a choice only when both branches are legal');
      if(t.zaoSequence){
       const expected=['forward','copy-limit'].includes(t.zaoSequence)?[100,200]:t.zaoSequence==='reverse'?[200,100]:t.zaoSequence==='upper'?[100,200,300]:[];
       assert.deepEqual(zaoRecovery,expected,'Spell operations follow the selected order after the native chain-solved event');
       const xyz=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).find(c=>c?.code===t.family);
       assert.equal(xyz?.overlayCards.length,Number(!t.expectedFamilyUses),'Only legal activation detaches material');
       if(t.zaoSequence==='copy-limit'){
        const hosts=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(c=>c?.code===t.family);
        assert.deepEqual(hosts.map(c=>c.overlayCards.length).sort(),[0,1],'The unused copy keeps its material');
       }
      }
      if(t.koaiQuick){
       const moved=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:B}).filter(c=>c&&[spell,trap].includes(c.code));
       const count=['redirect','decline','cost-only'].includes(t.koaiQuick)?0:['two','extra','cost-target'].includes(t.koaiQuick)?2:1;
       assert.equal(moved.length,count,'Treasure count follows actual Deck and Extra Deck receipts');
       if(['cost-only','copy-limit'].includes(t.koaiQuick)){
        const hosts=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(c=>c?.code===t.family);
        assert.equal(hosts.filter(c=>c.overlayCards.length===1).length,1,'One material remains available on the unused Koai');
       }
      }
      if(t.lokaeoRecycle){
       assert.equal(lokaeoDeckReturn,!t.noRewrite&&t.lokaeoRecycle!=='redirect','Actual Deck receipt before draw');
       assert.equal(lokaeoDraws,Number(!t.noRewrite&&t.lokaeoRecycle!=='redirect'),'Draw requires a real Deck return');
       assert.equal(lokaeoRevivalOffers,t.lokaeoExpectedOffers??Number(!!t.lokaeoStandby),'Optional revival offer');
      }
      if(t.lokaeoXyz&&t.expectedFamilyUses){
       if(t.lokaeoXyz==='upper')assert(lokaeoSummonedBeforeLower&&!emmaCounterChained,'Native Xyz follows Link 2 without a summon-negation response');
       else assert(emmaXyzAfterChain,'Lokaeo Xyz Summon follows the resolving chain');
       if(t.lokaeoXyz==='counter')assert(emmaCounterChained,'Summon-negating Trap activates in Lokaeo’s native Xyz window');
       else{
        const xyz=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).find(x=>x?.code===231825514);
        assert.deepEqual(xyz?.overlayCards.slice().sort(),[body,t.family].sort(),'Lokaeo itself must be attached');
       }
      }
      if(t.emma){
       assert.equal(musicaleSearchOffers,Number(!t.noYes),'Optional Xyz prompt requires a legal Nautica recipient');
       if(t.yes){
        assert(emmaXyzAfterChain,'Instructed Xyz Summon follows the trigger chain');
        if(t.emma==='counter')assert(emmaCounterChained,'Summon-negating Trap activates in the native Xyz window');
        else{
         const xyz=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===225109525);
         const three=t.emma==='three-materials';
         assert.deepEqual(xyz?.overlayCards.slice().sort(),[t.family,body,...(three?[wing]:[])].sort(),'The selected Aqua monsters become material');
         assert.equal(xyz.attack,data.get(225109525).attack+(three?1000:500),'Evander counts only Nautica materials');
        }
       }
      }
      if(t.musicaleTranscend){
       const summoned=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).filter(Boolean).find(c=>c.code===t.musicaleTranscend);
       assert.equal(summoned?.position,P.FACEUP_DEFENSE,'Transcend puts the selected Pendulum Monster in Defense Position');
      }
      if(t.opponent&&!t.musicaleSearch)assert(quickUsed,'Opponent-turn Quick Effect did not activate');
      if(t.leoship==='activation limit'){
       assert(!p.activates.some(x=>x.code===t.family&&x.location===H),'Second Hand activation is blocked');
       assert(p.activates.some(x=>x.code===t.family&&x.location===T),'Face-up summon effect has a separate limit');
      }
      if(t.forbidden)assert(!p.activates.some(x=>x.code===t.forbidden),'Restricted activation available');
      if(t.dragarTargetLeaves||t.dragarAttack!==undefined){
       const other=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:1,location:F}).filter(Boolean).find(c=>c.code===dark);
       assert.equal(other?.position,P.FACEDOWN_DEFENSE,'Dragar resolves the independent position change');
       assert.equal(recoveredAmount,t.dragarAttack??0,'Dragar gains LP equal to the remaining target ATK');
      }
      if(t.stainTwoPlacements){
       const remaining=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:1,location:D}).filter(Boolean).find(c=>c.code===216958556);
       assert.equal(remaining?.position,P.FACEUP_DEFENSE,"The remaining Stain stays face-up in the opponent's Deck");
      }
      if(t.adventuresOverlay==='grave-reset'){
       const hosts=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(c=>c?.code===body);
       assert.equal(hosts.length,2,'Both WATER Xyz Monsters were summoned');
       assert(hosts.every(c=>c.overlayCards.length===3&&c.overlayCards.includes(t.family)),'Each turn attaches one copy');
      }
      if(t.nauticaOverlay&&!['host-leaves','grave-reset'].includes(t.adventuresOverlay)){
       const controller=t.overlayControlChanged?1:0;
       const host=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller,location:F}).filter(Boolean).find(x=>x.code===body);
       const attached=!controller&&!['wrong-attribute','detach-cost','detach-effect'].includes(t.adventuresOverlay);
       assert.deepEqual(host?.overlayCards.slice().sort(),[wing,fusion,...(attached?[t.family]:[])].sort(),'Nautical Adventures follows current Xyz control and detaches independently');
      }
      if(t.faceDownRecipient){
       const host=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).filter(Boolean).find(x=>x.code===body);
       assert.equal(host?.position,P.FACEDOWN_DEFENSE,'The recipient remains face-down after attachment');
      }
      if(t.selfOverlayNecro&&t.expectedFamilyUses===0)assert(!p.activates.some(x=>x.code===t.family&&Number(x.description)===t.actionDescription),'Protected GY attachment was offered');
      if(t.cutiferSet==='monster-open')assert(p.pos_changes.some(x=>x.code===wing),'Stolen Set monster can Flip Summon immediately '+JSON.stringify([p.pos_changes, ...[0,1].map(controller=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller,location:F}).filter(Boolean))]));
      if(t.slimeTarget){
       const self=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).filter(Boolean).find(c=>c.code===t.family);
       const target=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:1,location:F}).filter(Boolean).find(c=>c.code===wing);
       assert.equal(self?.position,P.FACEDOWN_DEFENSE,'Slime Special Summons face-down');
       assert.equal(target?.position,t.slimeTarget==='link'?P.FACEUP_ATTACK:P.FACEDOWN_DEFENSE,'Optional Set respects target position legality');
      }
      if(t.blockedDeckSet)assert(!p.activates.some(x=>x.code===t.family&&Number(x.description)===t.actionDescription),'Pastrygeist offered a resource with no destination');
      if(t.wrongRecipe)assert(!p.special_summons.some(x=>x.code===graydeux),'Invalid alternate materials allowed');
      if(t.nativeSpecial&&!t.wrongRecipe){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===graydeux);assert(c,'Native Xyz Summon resolved');assert.deepEqual(c.overlayCards.slice().sort(),[body,link,spell].sort(),'Transferred materials');}
      if(t.checkAttached!==undefined){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(x=>x.code===graydeux);assert.deepEqual(c.overlayCards,[wing],'Two materials detached, selected monster attached');}
      if(t.checkAttached!==undefined)assert(!core.duelQueryLocation(duel,{flags:Q.CODE,controller:t.checkAttached,location:F}).filter(Boolean).some(x=>x.code===wing),'Chosen monster did not become material');
      if(t.attached)assert.equal(core.duelQueryCount(duel,1,F),0,'Monster was not attached');
      if(t.noBanish)assert.equal(core.duelQueryCount(duel,0,B),0,'Unexpected banished material');
      for(const [id,loc,player=0] of t.expected){
       if(t.groupedDeckDraw&&loc===D)continue;
       const queryLoc=loc===L.FZONE?T:loc;
       assert(core.duelQueryLocation(duel,{flags:Q.CODE,controller:player,location:queryLoc}).filter(Boolean).some(x=>x.code===id),'Missing '+id+' in '+loc+' for player '+player);
      }
      done=true;
     }
     break;
    }
    case M.SELECT_BATTLECMD:{
     const index=p.attacks.findIndex(x=>x.code===(t.galacticaLeave||t.galacticaOwnBattle?t.family:dark));
     if(t.venaticiBattle==='two battles'&&venaticiAttacks<2){
      assert(index>=0,'Both attacks are available');venaticiAttacks++;attacked=true;
     }else if(!attacked){assert(index>=0,'Attacker unavailable');if(t.galacticaBattle==='forced attack')assert(!p.to_m2&&!p.to_ep,'A legal attacker cannot skip the attack');attacked=true;}
     else {respond(R.SELECT_BATTLECMD,{action:Battle.TO_M2,index:0});break;}
     respond(R.SELECT_BATTLECMD,{action:Battle.SELECT_BATTLE,index});break;
    }
    case M.SELECT_CHAIN:{
     if(t.preparationTargetInterrupt&&p.player===1){const i=p.selects.findIndex(c=>c.code===dark);if(i>=0){respond(R.SELECT_CHAIN,{index:i});break;}}
     if(t.preparationNegation&&p.player===1){const i=p.selects.findIndex(c=>c.code===dark);if(i>=0){respond(R.SELECT_CHAIN,{index:i});break;}}
     if(t.formationInterrupt&&p.player===1){const i=p.selects.findIndex(c=>c.code===dark);if(i>=0){respond(R.SELECT_CHAIN,{index:i});break;}}
     if(t.melissaTurn&&opponentTurn&&opponentActivated&&p.player===0&&familyTriggers===1){
      const index=p.selects.findIndex(c=>c.code===t.family);
      if(index>=0){respond(R.SELECT_CHAIN,{index});break;}
     }
     if((t.nordbarNegate||t.battleTactics==='opponent turn')&&!opponentActivated){
      respond(R.SELECT_CHAIN,{index:p.forced?0:null});
      break;
     }
     if(t.nordbarRevive||t.nordbarSearch){
      const index=nordbarChain?-1:p.selects.findIndex(c=>c.code===t.family);
      respond(R.SELECT_CHAIN,{index:index>=0?index:p.forced?0:null});
      break;
     }
     if(t.chaosReturn==='target leaves'||t.battleTactics==='opponent leaves'){
      const index=p.selects.findIndex(c=>c.code===dark);
      respond(R.SELECT_CHAIN,{index:index>=0?index:p.forced?0:null});
      break;
     }
     if(t.baubaSummon||t.baubaReceipt){
      const index=p.selects.findIndex(c=>c.code===t.family);
      respond(R.SELECT_CHAIN,{index:index>=0?index:p.forced?0:null});
      break;
     }
     if(t.treasureSourceLeaves){
      const index=p.selects.findIndex(c=>c.code===dark);
      respond(R.SELECT_CHAIN,{index:index>=0?index:null});
      break;
     }
     if(t.treasureBanish){
      const index=p.selects.findIndex(c=>c.code===t.family);
      respond(R.SELECT_CHAIN,{index:index>=0?index:p.forced?0:null});
      break;
     }
     if(t.zaoSequence==='interrupted'){
      const index=p.selects.findIndex(c=>c.code===dark);
      respond(R.SELECT_CHAIN,{index:index>=0?index:null});
      break;
     }
     if(t.zaoSequence==='upper'&&opponentTurn&&opponentActivated&&familyTriggers===0){
      const index=p.selects.findIndex(c=>c.code===t.family);
      if(index>=0){respond(R.SELECT_CHAIN,{index});break;}
     }
     if(t.koaiQuick==='opponent'&&opponentTurn&&opponentActivated&&familyTriggers===0){
      const index=p.selects.findIndex(c=>c.code===t.family);
      if(index>=0){respond(R.SELECT_CHAIN,{index});break;}
     }
     if(t.lokaeoRecycle){
      const index=p.selects.findIndex(c=>c.code===t.family&&(!t.baubaRevival||c.location===B));
      if(index>=0&&p.selects[index].location===B){
       assert.deepEqual([auditTurn,lokaeoPhase],[lokaeoRevivalTurn,2],'Revival only offered in next Standby');
       lokaeoRevivalOffers++;
       respond(R.SELECT_CHAIN,{index:lokaeoAcceptRevival?index:null});
      }else respond(R.SELECT_CHAIN,{index:index>=0?index:null});
      break;
     }
     if(t.emma||t.lokaeoXyz){
      const index=p.selects.findIndex(c=>c.code===t.family||(t.emma==='counter'||['counter','upper'].includes(t.lokaeoXyz))&&c.code===spell);
      respond(R.SELECT_CHAIN,{index:index>=0?index:p.forced?0:null});
      break;
     }
     if(t.harmonySearch){
      const index=p.selects.findIndex(c=>c.code===t.family);
      respond(R.SELECT_CHAIN,{index:index>=0?index:null});
      break;
     }
     if(t.musicaleYummy){
      const index=p.selects.findIndex(c=>[253152295,259797813].includes(c.code));
      respond(R.SELECT_CHAIN,{index:index>=0?index:null});
      break;
     }
     if(t.oniTwoGrants&&t.steps[step]===ghostTransfer&&p.player===0){
      const index=p.selects.findIndex(x=>x.code===ghostTransfer&&x.sequence===step*2);
      if(index>=0){respond(R.SELECT_CHAIN,{index});break;}
     }
     if(t.oniQuickRecipient){
      const recipientEffects=p.selects.filter(x=>x.code===t.oniQuickRecipient);
      if(t.steps[step]===t.oniQuickRecipient&&recipientEffects.length>0)assert.equal(recipientEffects.length,1,'One granted effect');
      if(step>=t.steps.length)assert.equal(recipientEffects.length,0,'Grant preserves once-per-turn limit');
     }
     if((t.chainLimitCopies||t.megalSharedChain)&&sharedChainActive){if(p.player===0)sharedChainChecked=true;assert(!p.selects.some(c=>c.code===t.family),'Second copy cannot activate another effect in same Chain');}
     const index=p.selects.findIndex(x=>(t.singleDeckSuccessor||t.windborneRecovery)&&x.code===t.family||t.musicaleSummon&&x.code===t.family||(t.musicaleSearch||t.ownSearch||t.briaRecycle)&&x.code===dark||t.stainDragar&&x.code===t.family||(t.discardReceipt||t.drawReceipt)&&x.code===t.family&&x.code===t.steps[step]||t.nauticaOverlay&&x.code===t.family&&x.location===G||t.aeroNecro&&x.code===t.family||t.slimeTarget&&x.code===t.family||t.setCapacityChain&&x.code===dark||t.solemnSet&&x.code===t.family&&Number(x.description)===132049334*16||t.mirageSet&&x.code===t.family&&Number(x.description)===133072169*16+1||t.pastrygeistSet&&x.code===t.family&&Number(x.description)===133851064*16+2||t.myutantRecovery&&x.code===t.family||t.galaxixFieldRecovery&&x.code===t.family||t.gravinityInterrupt&&x.code===dark||t.megalSharedChain&&x.code===t.family&&Number(x.description)===t.chainStartDescription||(t.heartbeatNegate||t.chainNecro)&&x.code===dark||t.bitronCopyRemoved&&x.code===dark||t.bhodiReset&&x.code===trap||(t.hopeDeckRemoval||t.standReset)&&x.code===dark||t.heartbeatMaterial&&x.code===body||x.code===dark&&!!t.burnResolution||(!t.immuneOrbHost||t.ghostTransferFamily&&opponentTurn)&&!(t.exploringBoundary==='expiry'&&auditTurn<3&&x.code===helper)&&x.code===t.steps[step]&&!t.sequentialActions&&(!t.actionDescription||x.code===helper||Number(x.description)===t.actionDescription)&&(!t.activationSequence||x.code===helper||x.sequence===t.activationSequence)&&(!t.activationLocation||x.code===helper||x.location===t.activationLocation)||x.code===soprana&&(!t.opponent||opponentTurn)&&!quickUsed||x.code===hot&&x.location===B||x.code===t.family&&[formation,grayrover,ivy,grayshade,chapter,grayhex,graylock,grayling,graysentry,gorgonia,brilliance,graydimm,graydeux,pillar,descend,burning,fireball,urphiel,malphiel,vazagiel,azeriel,ophiel,shards,feather,prism,sarifiel,grayterror,ghostXyz,aeroXyz,claw,rook,knight,227531376,standTogether,249629457,241504188,244986323,220124524,232038002,255668557,236616849,212413422,216620496,253128790,259542408,259605536,218142234,238273772,224751741,239245471,259669838,259883230,244408495,259072745,247298564].includes(t.family)&&(x.location!==H||t.family===chapter||t.ghostResponse||t.damageBanishEvent&&t.family===253128790));
     respond(R.SELECT_CHAIN,{index:index>=0?index:p.forced?0:null});break;
    }
    case M.SELECT_EFFECTYN:
     if(t.baubaRevival&&p.code===t.family&&p.location!==B){
      respond(R.SELECT_EFFECTYN,{yes:false});
      break;
     }
     if(t.lokaeoRecycle&&p.code===t.family&&(t.lokaeoRecycle!=='revival-xyz'||!lokaeoRevivalOffers)){
      assert.deepEqual([auditTurn,lokaeoPhase],[lokaeoRevivalTurn,2],'Revival only offered in next Standby');
      lokaeoRevivalOffers++;
      respond(R.SELECT_EFFECTYN,{yes:lokaeoAcceptRevival});
      break;
     }
     respond(R.SELECT_EFFECTYN,{yes:[hot,soprana,t.family].includes(p.code)&&!(t.urphielBattleLeave&&Number(p.description)===133105971*16+2)});break;
    case M.SELECT_YESNO:assert(!t.noYes,'An unavailable optional effect was offered');if(t.musicaleActivation||t.emma)musicaleSearchOffers++;respond(R.SELECT_YESNO,{yes:!!t.yes});break;
    case M.SORT_CARD:{
     const order=p.cards.map((_,i)=>i);
     respond(R.SORT_CARD,{order:{length:order[0],*[Symbol.iterator](){yield*order.slice(1);}}});
     break;
    }
    case M.SELECT_OPTION:if(t.bojin||t.chunyin)treasureOptionPrompts++;if(t.options)assert.equal(p.options.length,t.options);respond(R.SELECT_OPTION,{index:t.option||0});break;
    case M.SELECT_CARD:
     if(t.stainDiscardHelper&&p.selects.some(c=>c.code===helper&&c.location===H)){
      respond(R.SELECT_CARD,{indicies:[p.selects.findIndex(c=>c.code===helper)]});break;
     }
     if(t.stainTributeMode==='mixed-tributes')assert(!p.selects.some(c=>c.code===wing),'Level 5 Tribute would leave no Summon candidate');
     if(t.windborneCapacity&&p.selects.some(c=>c.code===body||c.code===wing))assert.equal(p.max,t.windborneCapacity,'Set target count respects actual free zones');
     if(t.gravinityColumn&&p.selects.some(c=>c.code===dark||c.code===spell||c.code===trap)){assert(!p.selects.some(c=>c.code===fusion),'Off-column opponent card excluded');}
{
     if(t.companionUnprotectedBattle&&p.player===1&&p.selects.some(c=>c.code===body))assert(p.selects.some(c=>c.code===232824319),'Unsupported Companion remains an attack target');
     if(t.koaiProtect&&p.selects.some(c=>c.code===wing)){
      assert.equal(p.selects.some(c=>c.code===t.family),t.koaiProtect!=='protected','Only opposing targeting is blocked while Koai has material');
      protectionChecked=true;
     }
     if(t.originsProtect&&p.player===1){assert.equal(p.selects.some(c=>c.code===body),!['spell','trap'].includes(t.originsProtect),'Origins protects Brigade from Spell targeting only');assert(p.selects.some(c=>c.code===wing),'Unprotected control selectable');protectionChecked=true;}
     if(t.companionAttack&&p.player===1&&p.selects.some(c=>c.code===body)){assert(!p.selects.some(c=>c.code===232824319),'Supported Companion cannot be selected for attack');respond(R.SELECT_CARD,{indicies:[p.selects.findIndex(c=>c.code===body)]});break;}
     if(t.companionProtect&&p.player===1){assert.equal(p.selects.some(c=>c.code===232824319),t.companionProtect!=='faceup','Companion target eligibility');assert(p.selects.some(c=>c.code===wing),'Unprotected control target');protectionChecked=true;}
     if(t.armadaRevive&&p.selects.some(c=>c.code===body||c.code===wing)){respond(R.SELECT_CARD,{indicies:p.selects.map((c,i)=>[c,i]).filter(([c])=>[body,wing].includes(c.code)).slice(0,p.max).map(([,i])=>i)});break;}
     if(t.protectionProbe&&p.player===1){
      assert(p.selects.some(c=>c.code===malphiel),'Malphiel itself remains targetable');
      assert(p.selects.some(c=>c.code===wing),'Non-LIGHT monster remains targetable');
      assert(!p.selects.some(c=>c.code===body),'Other LIGHT monster is protected');
      protectionChecked=true;
     }
     if(t.exactDeckReturn&&t.family===248940511&&p.min===5){
      const indices=[body,wing,spell,trap,link].map(code=>p.selects.findIndex(c=>c.code===code));
      assert(indices.every(i=>i>=0));
      respond(R.SELECT_CARD,{indicies:indices});
      break;
     }
     if(t.exactDeckReturn&&t.family===259669838&&p.min===2){
      const indices=[body,spell].map(code=>p.selects.findIndex(c=>c.code===code));
      assert(indices.every(i=>i>=0));
      respond(R.SELECT_CARD,{indicies:indices});
      break;
     }
     if(t.groupedDeckDraw&&t.family===212429024&&p.max>1){
      const indices=[body,wing].map(code=>p.selects.findIndex(c=>c.code===code));
      assert(indices.every(i=>i>=0));
      respond(R.SELECT_CARD,{indicies:indices});
      break;
     }
     const oniRecipientSelection=t.oniQuickRecipient&&p.selects.some(x=>x.code===ghostTransfer);
     let preferredCode=oniRecipientSelection?t.oniQuickRecipient:t.pick;
     if(t.zaoSequence==='real'&&p.selects.some(c=>c.code===wing))preferredCode=wing;
     if(t.musicaleStock==='repeat'&&p.player===0&&step===1){
      preferredCode=p.selects.some(x=>x.code===226645052)?226645052:dark;
     }
     if(t.zaoSequence==='copy-limit'&&p.min===2){
      const indices=[spell,trap].map(code=>p.selects.findIndex(c=>c.code===code));
      assert(indices.every(i=>i>=0),'Both spell names are legal candidates');
      respond(R.SELECT_CARD,{indicies:indices});
      break;
     }
     const preferred=p.selects.findIndex(x=>x.code===preferredCode);
     const indicies=p.min===1&&preferred>=0?[preferred]:p.selects.map((_,i)=>i).slice(0,t.selectMax?p.max:p.min);
     respond(R.SELECT_CARD,{indicies});break;
    }
    case M.SELECT_UNSELECT_CARD:
     if(t.preparationOwnership){assert(p.select_cards.every(c=>c.code===wing),'Opponent-owned banished card must not be selected');respond(R.SELECT_UNSELECT_CARD,{index:p.can_finish?null:0});break;}
     if(t.preparationFacedown){assert(p.select_cards.every(c=>c.code===body),'Face-down banished card is not selectable');respond(R.SELECT_UNSELECT_CARD,{index:p.can_finish?null:0});break;}
     if(t.preparationSetEligibility){assert(p.select_cards.every(c=>c.code===body),'Only own Galactica Spell/Trap may be targeted');respond(R.SELECT_UNSELECT_CARD,{index:p.can_finish?null:0});break;}
     if(t.preparationSetThree){if(p.unselect_cards.length>=3){assert(!p.select_cards.length,'Fourth target should not be available');respond(R.SELECT_UNSELECT_CARD,{index:null});}else respond(R.SELECT_UNSELECT_CARD,{index:0});break;}
     if(t.tacticsBanish){
      const max=t.tacticsBanish==='two names'?2:1;
      respond(R.SELECT_UNSELECT_CARD,{index:p.can_finish&&p.unselect_cards.length>=max?null:0});
      break;
     }

     if(['deck','deck-only','source-leaves'].includes(t.chunyin)){
      if(p.unselect_cards.some(c=>c.code===wing)){
       assert(!p.select_cards.some(c=>c.code===wing),'A second copy of the selected name is unavailable');
       chunyinNameGuard=true;
      }
      const index=p.can_finish?null:Math.max(0,p.select_cards.findIndex(c=>c.code===wing));
      respond(R.SELECT_UNSELECT_CARD,{index});
      break;
     }
     if(t.windborneCapacity===1&&p.unselect_cards.some(c=>c.code===body))assert(!p.select_cards.some(c=>c.code===wing),'No second ordinary Set target without room');respond(R.SELECT_UNSELECT_CARD,{index:t.selectMax&&p.select_cards.length?Math.max(0,p.select_cards.findIndex(c=>c.code===body)):p.can_finish?null:0});break;
    case M.SELECT_POSITION:respond(R.SELECT_POSITION,{position:p.positions&P.FACEUP_ATTACK?P.FACEUP_ATTACK:P.FACEUP_DEFENSE});break;
    case M.SELECT_PLACE:{
     let mask=p.field_mask;const places=[];
     for(let i=0;i<Math.max(1,p.count);i++){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6,7].some(j=>(mask&(1<<(v+j)))===0));assert(shift!==undefined,'Enough distinct placement zones');const sequence=[0,1,2,3,4,5,6,7].find(j=>(mask&(1<<(shift+j)))===0);places.push({player:shift>=16?1-p.player:p.player,location:shift%16===8?T:F,sequence});mask|=1<<(shift+sequence);}
     respond(R.SELECT_PLACE,{places});break;
    }
    default:throw Error('Unhandled '+JSON.stringify(p));
    }
   }
   assert(done,'Step limit');if(t.formationMultiChain){const begin=formationTimingTrace.findIndex(m=>m.type===M.CHAINING&&m.code===formation&&m.chain_size===2),solved=formationTimingTrace.findIndex((m,i)=>i>begin&&m.type===M.CHAIN_SOLVED&&m.chain_size===2),summon=formationTimingTrace.findIndex((m,i)=>i>solved&&m.type===M.SPSUMMONING&&m.code===link),lower=formationTimingTrace.findIndex((m,i)=>i>solved&&m.type===M.CHAIN_SOLVING&&m.chain_size===1);assert(begin>=0&&solved>begin&&summon>solved&&lower>summon,'Link Summon should follow Formation before lower chain resolves');fs.writeFileSync(path.resolve(__dirname,'../output/fresh-ccg-september/formation-link-multichain.json'),JSON.stringify(formationTimingTrace,(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');}if(t.formationTiming){const begin=formationTimingTrace.findIndex(m=>m.type===M.CHAINING&&m.code===formation),solved=formationTimingTrace.findIndex((m,i)=>i>begin&&m.type===M.CHAIN_SOLVED),summon=formationTimingTrace.findIndex((m,i)=>i>begin&&m.type===M.SPSUMMONING&&m.code===link);assert(begin>=0&&solved>begin&&summon>solved,'Link Summon must follow resolution of Formation');fs.writeFileSync(path.resolve(__dirname,'../output/fresh-ccg-september/formation-link-timing.json'),JSON.stringify(formationTimingTrace,(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');}results.push({name:t.name,status:'PASS',...(t.joyousDice?{roll:diceRoll}:{})});console.log('PASS',t.name);
  }catch(e){failures++;results.push({name:t.name,status:'FAIL',error:e.message});console.log('FAIL',t.name,e.message);}
  finally{core.destroyDuel(duel);}
 }
 const crypto=require('node:crypto');
 const files=new Map();
 for(const code of new Set(testCases.map(t=>t.family).filter(Boolean).concat([hot,sky,journey,soprana,offer],testCases.some(t=>t.zaoSequence==='real')?[236542835,246421842]:[]))){
  const file=code===84815190&&testCases.some(t=>t.stockNegationControl)?path.join(omega,'c'+code+'.lua'):process.env.CCG_NAUTICA_CANDIDATE&&[259797813,248946297,259941091].includes(code)?path.resolve(__dirname,'../public/CCG Downloads/CCG_Scripts','c'+code+'.lua'):path.join(installed,'c'+code+'.lua');
  files.set(code,{file,sha256:crypto.createHash('sha256').update(fs.readFileSync(file)).digest('hex')});
 }
 if(!process.env.CCG_TEST_SOURCE)fs.writeFileSync(path.resolve(__dirname,'../output/fresh-ccg-september',process.argv.includes('--bauba-revival-only')?'bauba-revival-installed.json':process.argv.includes('--nordbar-negation-protection-probe')?'nordbar-negation-protection-probe.json':process.argv.includes('--formation-only')?'formation-installed.json':process.argv.includes('--battle-tactics-only')?'battle-tactics-installed.json':process.argv.includes('--venatici-only')?'venatici-installed.json':process.argv.includes('--galactica-battle-only')?'galactica-battle-installed.json':process.argv.includes('--bauba-receipt-only')?'bauba-receipt-installed.json':process.argv.includes('--bauba-summon-only')?'bauba-summon-installed.json':process.argv.includes('--shrine-placement-only')?'shrine-placement-installed.json':process.argv.includes('--huangjin-only')?'huangjin-installed.json':process.argv.includes('--chunyin-only')?'chunyin-installed.json':process.argv.includes('--bojin-only')?'bojin-installed.json':process.argv.includes('--zao-only')?'zao-installed.json':process.argv.includes('--koai-only')?'koai-installed.json':process.argv.includes('--lokaeo-recycle-only')?'lokaeo-recycle-installed.json':process.argv.includes('--lokaeo-xyz-only')?'lokaeo-xyz-installed.json':process.argv.includes('--adventures-overlay-only')?'adventures-overlay-installed.json':process.argv.includes('--backwashing-boundaries-only')?'backwashing-boundaries-installed.json':process.argv.includes('--exploring-boundaries-only')?'exploring-boundaries-installed.json':process.argv.includes('--melissa-quick-only')?'melissa-quick-installed.json':process.argv.includes('--melissa-recipe-only')?'melissa-recipe-installed.json':process.argv.includes('--melissa-protection-only')?'melissa-protection-installed.json':process.argv.includes('--zephorion-receipt-only')?'zephorion-receipt.json':process.argv.includes('--add-or-send-only')?'add-or-send.json':process.argv.includes('--alternative-receipt-only')?'alternative-receipt.json':process.argv.includes('--melville-receipt-only')?'melville-receipt.json':process.argv.includes('--single-deck-successor-only')?'single-deck-successor.json':process.argv.includes('--galactica-leave-only')?'galactica-leave.json':process.argv.includes('--grouped-deck-draw-only')?'grouped-deck-draw.json':process.argv.includes('--single-deck-draw-only')?'single-deck-draw.json':process.argv.includes('--shards-empty-hand-only')?'shards-empty-hand.json':process.argv.includes('--exact-deck-return-only')?'exact-deck-return.json':process.argv.includes('--windborne-reveal-only')?'windborne-reveal.json':process.argv.includes('--janna-search-only')?'janna-search.json':process.argv.includes('--bria-recycle-only')?'bria-recycle.json':process.argv.includes('--dependent-draw-only')?'dependent-draw-receipt.json':process.argv.includes('--search-discard-only')?'search-discard-receipt.json':process.argv.includes('--own-search-only')?'nautica-own-search.json':process.argv.includes('--musicale-stock-probe')?'musicale-stock-probe.json':process.argv.includes('--emma-only')?'emma-installed.json':process.argv.includes('--harmony-only')?'harmony-installed.json':process.argv.includes('--musicale-only')?'musicale-installed.json':process.argv.includes('--stain-tribute-only')?'stain-tribute-installed.json':process.argv.includes('--claw-self-only')?'claw-self-installed.json':process.argv.includes('--self-overlay-necro-only')?'self-overlay-necro-installed.json':process.argv.includes('--aero-necro-only')?'aero-necro-installed.json':process.argv.includes('--ghostrick-destination-only')?'ghostrick-destination-installed.json':process.argv.includes('--oni-quick-only')?'oni-quick-installed.json':process.argv.includes('--field-recovery-family-only')?'field-recovery-family-installed.json':'current-installed-effects-regression.json'),JSON.stringify({
  scope:'Listed OCGCore scenarios with installed scripts and installed card data. Neutral fixture resources and API adapters are used. Full-card and live Omega verification remain open.',
  compatibility:'Legacy Link and fixture Xyz argument translation and procedures, selected chain target mapping, basic Level 12 Xyz material eligibility/selection bridge for ordinary fixture monsters, ordinary fixture overlay eligibility. Graydeux alternate Xyz cases isolate that procedure from the unsupported ordinary Xyz API.',
  pendingCases:['A Stainless Story: --story-shuffle-probe tests whether copied self-shuffle must move the activating Spell instead of the sent monster; current source moves the sent monster. Ruling/intent unresolved.','Ghostrick Oni: the printed Xyz Summon wording and the existing field-to-material implementation still need reconciliation.', 'Sarifiel: hypothetical effect immunity of a GY material. The --grave-immune-probe reproduces attachment; expected ruling needs confirmation before a production change.'],
  installedScripts:Object.fromEntries(files),results
 },null,2)+'\n');
 if(failures)process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1;});
