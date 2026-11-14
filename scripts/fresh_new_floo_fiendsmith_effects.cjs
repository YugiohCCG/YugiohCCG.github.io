'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
process.env.CCG_INSTALLED_CARD_DB ||= require('node:path').resolve(__dirname,'../public/CCG Downloads/CCG_Database/CCG_v1.db');
const {candidateCard}=require('./fresh_installed_card.cjs');
const {loadCorrectedTransport}=require('./fresh_corrected_card_data_transport.cjs');
const installed=process.env.CCG_OMEGA_SCRIPTS||path.resolve(__dirname,'../public/CCG Downloads/CCG_Scripts');
const omega=path.resolve(__dirname,'../tmp/omega_scripts');
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
 for(const locked of [false,true])add('Crystal Shards native Synchro recovery '+(locked?'under a cost-only discard restriction':'baseline'),[[shards,F],[body,F],[fusion,E],[link,B],[wing,H],[helper,H]],locked?[helper,fusion]:[fusion],[[link,E],[wing,G]],{family:shards,materialSynchro:true,costLockRecovery:locked,pick:wing,expectedFamilyUses:1,op:discardCostLock});
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
 if(process.argv.includes('--musicale-only'))testCases.splice(0,testCases.length,...testCases.filter(t=>t.musicaleSummon));
 for(const t of testCases){
  const data=new Map();
  for(const code of [hot,sky,journey,soprana,offer])data.set(code,candidateCard(code));
  if(t.family)data.set(t.family,candidateCard(t.family));
  const put=(code,over={})=>data.set(code,{...base,code,...over});
  put(helper,{type:2});put(body);put(dark,{attribute:32,attack:t.battle?3000:100});put(wing,{type:t.effectWing?33:17,attribute:t.effectWing?32:16,race:512n,level:t.levelEight?8:t.boss?7:2,setcodes:t.family===formation?[0x9c9]:[grayseer,grayling].includes(t.family)?[0x575d]:floo});
  put(spell,{type:t.family===booster?0x40002:t.field?0x80002:0x20002,setcodes:[grayhex,graylock].includes(t.family)?[0x575d]:floo});put(trap,{type:4,setcodes:fiend});
  put(fusion,{type:0x61,setcodes:fiend});put(link,{type:t.family===nullbind?0x800021:0x4000021,level:2,link_marker:5,setcodes:t.family===formation?[0x9c9]:[grayrover,nullbind].includes(t.family)?[0x575d]:fiend});
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
  if(t.musicaleSummon){put(helper,{type:2,setcodes:t.musicaleGeneric?[]:[0x8f0]});put(body,{type:33,setcodes:[0x8f0]});}
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
  if(t.supremacyNeg)put(dark,{type:t.monsterActivation?33:2});
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
  if(t.storyCopiedCode){data.set(t.storyCopiedCode,candidateCard(t.storyCopiedCode));put(body,{type:17,setcodes:[0xbc5]});put(dark,{type:33});put(wing,{type:t.storyCopyKind==='feness'?33:17});}
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
  if(t.nauticaOverlay){put(body,{type:0x800021,level:2,attribute:2});put(fusion,{type:17,level:2});}
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
  const reader=name=>{
   if(t.musicaleSummon&&name==='c'+helper+'.lua')return `local s,id=GetID()
    function s.initial_effect(c)
     local e=Effect.CreateEffect(c)
     e:SetType(EFFECT_TYPE_ACTIVATE)
     e:SetCode(EVENT_FREE_CHAIN)
     e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk)
      if chk==0 then return true end
      local loc=${t.musicaleFromGY?'LOCATION_GRAVE':'LOCATION_HAND'}
      Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,Duel.GetFirstMatchingCard(Card.IsCode,tp,loc,0,nil,${body}),1,tp,loc)
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
   if(t.materialSynchro&&name==='c'+fusion+'.lua')return require('./fresh_native_two_material_synchro.cjs').recipe(data.get(t.family).type&0x1000?t.family:body,data.get(t.family).type&0x1000?body:t.family);
   if(t.detachProbe&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) '+(t.detachMode==='effect'?'e:SetOperation(function(e,tp) e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_EFFECT) end)':'e:SetCost(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST) end)')+' c:RegisterEffect(e) end';
   if(t.immuneReplace&&name==='c'+body+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e:SetRange(LOCATION_GRAVE) e:SetValue(function() return true end) c:RegisterEffect(e) end';
   if(t.rewrite&&name==='c'+dark+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType('+(t.graveActivation||t.monsterActivation?'EFFECT_TYPE_IGNITION':'EFFECT_TYPE_ACTIVATE')+') e:SetCode(EVENT_FREE_CHAIN) '+(t.graveActivation||t.monsterActivation?'e:SetRange('+(t.monsterActivation?'LOCATION_MZONE':'LOCATION_GRAVE')+') e:SetCountLimit(1)':'')+' '+(t.ophielResponse?'e:SetProperty(EFFECT_FLAG_CARD_TARGET) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SelectTarget(tp,Card.IsCode,tp,LOCATION_MZONE,0,1,1,nil,'+wing+') end)':'')+' '+(t.opponentOp?'e:SetOperation(function(e,tp) '+t.opponentOp+' end)':'')+' c:RegisterEffect(e) end';
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
   if([...fixtures,engraver,bauWorld,bau,dysmandr,extinction,token,grayToken].some(code=>name==='c'+code+'.lua'))return neutral;
   const source=path.resolve(__dirname,'../public/CCG Downloads/CCG_Scripts',name);
   const file=[process.env.CCG_TEST_SOURCE&&t.family&&source,path.join(installed,name),path.resolve(__dirname,'../tmp/ohmen-reference',name),path.join(omega,name)].find(f=>f&&fs.existsSync(f));
   assert(file,name);let lua=fs.readFileSync(file,'utf8');if(t.stainOptionalFixture&&name==='c248453205.lua')lua=lua.replace('local rg=','local fixture=Duel.GetFieldGroup(tp,0,LOCATION_DECK):Filter(Card.IsCode,nil,'+wing+'):GetFirst() fixture:ReverseInDeck() assert(fixture:IsFaceup()) local rg=');if(t.nauticaOverlay&&process.argv.includes('--nautica-control-before')&&name==='c218905439.lua')lua=lua.replace('tc:IsControler(tp) and not tc:IsImmuneToEffect(e)) then return end','not tc:IsImmuneToEffect(e)) then return end');if(t.chainLimitCopies&&process.argv.includes('--shared-chain-no-flag')&&name==='c284639726.lua')lua=lua.replace('return e:GetHandler():GetFlagEffect(id)==0','return true').replace('return Duel.GetFlagEffect(e:GetHandlerPlayer(),id)==0','return true');if(t.megalSharedChain&&process.argv.includes('--megal-chain-no-flag')&&name==='c259179054.lua')lua=lua.replaceAll('Duel.GetFlagEffect(tp,id)==0','true');if(t.disccsChainCallbacks&&process.argv.includes('--disccs-chain-no-flag')&&name==='c238273770.lua')lua=lua.replaceAll('Duel.GetFlagEffect(tp,id+400)==0','true');if((t.pendulumLeaveBattle&&process.argv.includes('--pendulum-leave-no-damage')||process.argv.includes('--leave-field-no-damage'))&&name==='c'+t.family+'.lua')lua=lua.replaceAll('EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DELAY','EFFECT_FLAG_DELAY');if(t.damageBanishEvent&&process.argv.includes('--damage-banish-permissive')&&name==='c'+t.family+'.lua'){const v=({212413422:'e3',216620496:'e2',253128790:'e1',259542408:'e6',259605536:'e4'})[t.family];lua=lua.replace(v+':SetProperty(',v+':SetProperty(EFFECT_FLAG_DAMAGE_STEP+');}return lua;
  };
  const logs=[],team={startingLP:8000,startingDrawCount:0,drawCountPerTurn:0};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:t.diceSeed?Array.from({length:4},(_,i)=>(BigInt(t.diceSeed+i)*0x9e3779b97f4a7c15n)&0xffffffffffffffffn):[1n,2n,3n,4n],team1:team,team2:team,cardReader:code=>data.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  try{
   for(const file of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,file,reader(file)));
   if(t.nauticaOverlay||t.aeroNecro||t.cutiferSet||[nullbind,chapter,graysentry,vazagiel,graydeux,orb,ophiel,shards,burning,prism,failuresAip,ghostXyz,aeroXyz,shade,ghostTransfer,claw,rook,knight,227531376,244986323,215885404,284639726,210696007,233212369].includes(t.family))assert(core.loadScript(duel,'chain-target-compat.lua','CHAININFO_TARGET_CARDS=8 Card.IsCanOverlay=Card.IsCanOverlay or function(c) return c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TOKEN) end'));
// OCGCore lacks Omega's Duel.CheckXyzMaterial. Isolate the unchanged alternate
   // procedure here. The ordinary Level 12 Xyz recipe remains outside this case.
   if(t.aeroNecro||t.nativeSpecial||t.pastrygeistSet||t.mirageSet||t.oniQuickRecipient||t.cutiferSet)assert(core.loadScript(duel,'isolate-xyz-recipe.lua','aux.AddXyzProcedure=function() end'));
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
    '-- and live Omega are outside these Level 12 recipe cases.',
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
   if(t.pillarReturn||t.damageBanishEvent&&t.family===212413422)assert(core.loadScript(duel,'omega-related-targets-api.lua','Duel.GetTargetsRelateToChain=Duel.GetTargetsRelateToChain or function() local e=Duel.GetChainInfo(0,1) local g=Duel.GetChainInfo(0,8) return g:Filter(Card.IsRelateToEffect,nil,e) end'));
   if(t.family===ghostXyz||t.brigadeSummon||t.armadaRevive||t.lovingMaterial||t.brigadeXyz||t.brigadeFieldBoth||t.megalSharedChain||t.galaxixFieldRecovery||t.myutantRecovery)assert(core.loadScript(duel,'faceup-grave-fixture-api.lua','Card.IsFaceupEx=Card.IsFaceupEx or function(c) return not c:IsLocation(LOCATION_ONFIELD+LOCATION_REMOVED+LOCATION_EXTRA) or c:IsFaceup() end'));
   if(t.standDraw||t.armadaDraw)assert(core.loadScript(duel,'omega-draw-chaininfo-api.lua','CHAININFO_TARGET_PLAYER=9 CHAININFO_TARGET_PARAM=10'));
   if(t.roarEquipCapacity)assert(core.loadScript(duel,'omega-accepted-target-stage-api.lua','Effect.IsCostChecked=Effect.IsCostChecked or function() return true end'));
   if(t.lastStandNeg)assert(core.loadScript(duel,'omega-trigger-location-api.lua','CHAININFO_TRIGGERING_LOCATION=4'));
   if(t.originsAttach==='spell-target')assert(core.loadScript(duel,'omega-faceup-field-overlay-api.lua','Card.IsCanOverlay=function(c) return c:IsLocation(LOCATION_ONFIELD) and not c:IsType(TYPE_TOKEN) end'));
   if(t.nauticaOverlay)assert(core.loadScript(duel,'omega-grave-trap-overlay-api.lua','local old=Card.IsCanOverlay Card.IsCanOverlay=function(c) return old(c) or c:IsCode(218905439) and c:IsLocation(LOCATION_GRAVE) end'));
   if(t.aquaUseLock)assert(core.loadScript(duel,'omega-fusion-mandatory-api.lua','Duel.GetMustMaterial=function() return Group.CreateGroup() end Duel.CheckMustMaterial=function() return true end'));
   const next={};
   const place=(code,location,player=0)=>{
    const key=player+':'+location,sequence=next[key]||0;next[key]=sequence+1;
    core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location:location===L.FZONE?T:location,sequence:location===L.FZONE?5:location===T||location===F?sequence:0,position:t.cutiferSet&&code===wing||t.oniQuickRecipient===75367227&&code===dark&&location===T||location===E||location===D||t.myutantRecovery?.includes('facedown')&&location===B&&code===34572613||t.galaxixFieldRecovery?.includes('facedown')&&location===B&&code===body||t.setSourceSpell&&location===T&&code===t.family||t.banishedTrapFacedown&&location===B&&code===trap?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   };
   for(const args of t.setup)place(...args);
   for(const player of [0,1])for(let i=0;i<8;i++)place(dark,D,player);
   core.startDuel(duel);
   let familyTriggers=0,step=0,done=false,opponentTurn=false,quickUsed=false,attacked=false,opponentActivated=false,secondSpell=false,recoveredAmount=0,recoverySeen=false,protectionChecked=false,burnDamage=0,revengeDamage=0,diceRoll=0,sharedChainActive=false,sharedChainChecked=false,placedResource=false;
   const respond=(type,rest)=>core.duelSetResponse(duel,{type,...rest});
   for(let i=0;i<200&&!done;i++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);
    assert(!logs.some(x=>x.type===0),logs.map(x=>x.message).join('\n'));
    for(const m of messages){
     if((t.chainLimitCopies||t.megalSharedChain)&&m.type===M.CHAINING&&m.code===t.family&&Number(m.description)===(t.chainStartDescription??t.actionDescription))sharedChainActive=true;
     if((t.chainLimitCopies||t.megalSharedChain)&&m.type===M.CHAIN_SOLVED)sharedChainActive=false;
     if(t.joyousDice&&m.type===M.TOSS_DICE){assert.equal(diceRoll,0,'One native die roll');diceRoll=m.results[0];}
     if(t.revengeRevive&&m.type===M.DAMAGE&&m.player===1)revengeDamage+=m.amount;
     if(t.burnResolution&&m.type===M.DAMAGE&&m.player===1)burnDamage+=m.amount;
     if(t.forwardMaterial&&m.type===M.RECOVER&&m.player===1)recoveredAmount+=m.amount;
     if((t.negateUrphiel||t.lastStandNeg||t.supremacyNeg||t.stainDragar)&&m.type===M.RECOVER)recoverySeen=true;
     if(t.stainDragar&&m.type===M.RECOVER&&m.player===0)recoveredAmount+=m.amount;
     if(t.capacityFollowup&&m.type===M.MOVE&&m.card===body&&m.to.location===T)placedResource=true;
     if(m.type===M.NEW_TURN)opponentTurn=m.player===1;
     if(m.type===M.CHAINING&&t.steps[step]===m.code)step++;
     if(m.type===M.CHAINING&&t.family===m.code&&(!t.clawSelfRevive||Number(m.description)===133137697*16+2))familyTriggers++;
     if(m.type===M.CHAINING&&m.code===soprana&&t.opponent)quickUsed=true;
    }
    assert(state!==S.END);if(state!==S.WAITING)continue;
    const p=messages.at(-1);
    switch(p.type){
    case M.SELECT_IDLECMD:{
     const code=t.steps[step];
     if(code){
      if(t.ghostTransferFamily&&code===ghostTransfer&&!opponentTurn){respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
      if(t.oniExpiry&&code===helper&&opponentTurn){respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});continue;}
      const special=(t.brigadeXyz||t.brigadeLink)&&code===t.family||t.procedureSource&&code===t.family||t.materialNative&&code===body||t.nativeSpecial&&code===graydeux||(t.linkRecipe||t.xyzRecipe)&&code===t.family||t.materialSynchro&&code===fusion;
      if(t.chainLimitCopies&&code===t.family)assert(p.activates.some(c=>c.code===t.family&&c.sequence===1&&Number(c.description)===132639726*16),'Second copy draw effect is legal before the Chain');
      if(t.megalSharedChain&&code===helper)assert(p.activates.some(c=>c.code===t.family&&Number(c.description)===133179054*16+1),'Other copy Quick Effect legal before Chain');
      const setting=code<0&&t.setMonsterCodes?.includes(-code);
      const list=special?p.special_summons:setting?p.monster_sets:code<0?p.summons:p.activates,index=list.findIndex(x=>x.code===Math.abs(code)&&(!t.actionDescription||x.code===helper||Number(x.description)===t.actionDescription)&&(!t.activationSequence||x.code===helper||x.sequence===t.activationSequence)&&(!t.activationLocation||x.code===helper||x.location===t.activationLocation));
      assert(index>=0,'Action unavailable '+code+(t.materialNative?' '+JSON.stringify(p.special_summons)+' fields '+JSON.stringify(core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location:F})) :''));
      respond(R.SELECT_IDLECMD,{action:special?A.SELECT_SPECIAL_SUMMON:setting?A.SELECT_MONSTER_SET:code<0?A.SELECT_SUMMON:A.SELECT_ACTIVATE,index});if(code<0||special)step++;
     }else if(t.battle&&!attacked)respond(R.SELECT_IDLECMD,{action:opponentTurn?A.TO_BP:A.TO_EP,index:0});
     else if((t.opponent||t.rewrite||t.endRecovery||t.tempLevel==='expiry'||t.statExpiry)&&!opponentTurn&&!(t.supremacyReturn&&opponentActivated))respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else if(t.supremacyReturn&&opponentTurn&&opponentActivated)respond(R.SELECT_IDLECMD,{action:A.TO_EP,index:0});
     else if(t.forwardMaterial&&opponentActivated&&!secondSpell){const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0,'Second Spell activation available');secondSpell=true;respond(R.SELECT_IDLECMD,{action:A.SELECT_ACTIVATE,index});}
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
      if(t.rewrite)assert.equal(familyTriggers,t.noRewrite?0:1,'Effect rewrite activation matches available resources');
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
      if(t.checkDefense){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:F}).filter(Boolean).find(x=>x.code===wing);assert.equal(c.position,P.FACEUP_DEFENSE);}
      if(t.tempLevel){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location:F}).filter(Boolean).find(x=>x.code===t.family);assert.equal(c.level,t.tempLevel==='synchro'?4:8,'Temporary Level and expiration');}
      if(t.protectionProbe||t.companionProtect||t.originsProtect)assert(protectionChecked,'Actual opponent target options checked');
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
      if(t.supremacyNeg){assert(!recoverySeen,'Opponent activation negated');assert.equal(core.duelQueryCount(duel,1,B),t.supremacyBanishCount??3,'Activated card and same-name GY copies banished');}
      if(t.originsDes){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===244986323);assert.equal(c.overlayCards.length,t.originsDes==='one-material'?1:0,'Detach two materials as cost');}
      if(t.revengeRevive&&t.battle)assert.equal(familyTriggers,t.expectedFamilyUses,'Battle revival trigger count');
      if(t.revengeRevive)assert.equal(revengeDamage,t.revengeRevive==='opponent'?1400:['battle','battle-facedown'].includes(t.revengeRevive)?3000:0,'Highest opponent ATK damage and trigger boundaries');
      if(t.brigadeXyz==='legal'){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===t.family);assert.deepEqual(c.overlayCards.slice().sort(),t.recipeMaterials.slice().sort(),'Actual Brigade Xyz materials');}
      if(t.brigadeLink&&t.recipeLegal)assert.equal(core.duelQueryCount(duel,0,G),t.recipeMaterials.length,'Actual Link materials sent to GY');
      if(t.armadaDraw){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).find(c=>c.code===223750159);assert.equal(c.overlayCards.length,0,'Material detached for draw');}
      if(t.hexatronIdentity){const own=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:0,location:F}).filter(Boolean).find(c=>c.code===t.family);const opp=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:1,location:F}).filter(Boolean).find(c=>c.code===body);assert.equal(opp.attack,t.standReset?600:100,'Stored monster identity and effect negation');assert.equal(own.attack,data.get(t.family).attack+(t.standReset?0:400),'ATK gain requires successful negation');}
      if(t.storyCopyKind==='feness'){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:1,location:F}).filter(Boolean).find(c=>c.code===wing);assert.equal(c.attack,100,'Copied negation still resolves');}
      if(t.storyCopiedCode&&!t.storyShuffleProbe)assert(core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:B}).filter(Boolean).some(c=>c.code===t.storyCopiedCode),'Sent monster stays banished');
      if(t.floweringCount)assert.equal(core.duelQueryCount(duel,0,G),1,'Unused legal shuffle cost remains for second copy');
      if(t.armadaCountCopies){const cards=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:F}).filter(Boolean).filter(c=>c.code===223750159);assert.equal(cards.reduce((sum,c)=>sum+c.overlayCards.length,0),1,'Second copy retains a payable draw cost');}
      if(t.joyousDice){assert(diceRoll>=1&&diceRoll<=6,'Native die result');assert.equal(core.duelQueryCount(duel,1,B),Math.ceil(diceRoll/2),'Half-roll banish cap rounded up');assert.equal(core.duelQueryCount(duel,1,G),4-Math.ceil(diceRoll/2),'Unselected GY cards retained');}
      if(t.chainLimitCopies||t.megalSharedChain)assert(sharedChainChecked,'Actual own response window checked before Chain resolution');
      if(t.expectedHandCount!==undefined)assert.equal(core.duelQueryCount(duel,0,H),t.expectedHandCount,'Draw count');
      if(t.selfEquipCapacity){const c=core.duelQueryLocation(duel,{flags:Q.CODE|Q.EQUIP_CARD,controller:0,location:T}).filter(Boolean).find(c=>c.code===t.family);assert.equal(c.equipCard?.controller,0,'Equip target controller');assert.equal(c.equipCard?.location,F,'Actual equip target location');assert.equal(c.equipCard?.sequence,0,'Equipped to seeded monster');}
      if(t.expectedPlacement!==undefined)assert.equal(placedResource,t.expectedPlacement,'Actual SZONE placement before destruction');
      if(t.expectedFamilyUses!==undefined)assert.equal(familyTriggers,t.expectedFamilyUses,'Named revival limit');
      if(t.expectTrigger!==undefined)assert.equal(familyTriggers,t.expectTrigger?1:0,'Unexpected Ivy trigger result');
      if(t.noTrigger)assert.equal(familyTriggers,t.family===grayrover?1:0,'An illegal Link Summon triggered');
      if(t.opponent)assert(quickUsed,'Opponent-turn Quick Effect did not activate');
      if(t.forbidden)assert(!p.activates.some(x=>x.code===t.forbidden),'Restricted activation available');
      if(t.dragarTargetLeaves||t.dragarAttack!==undefined){
       const other=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:1,location:F}).filter(Boolean).find(c=>c.code===dark);
       assert.equal(other?.position,P.FACEDOWN_DEFENSE,'Dragar resolves the independent position change');
       assert.equal(recoveredAmount,t.dragarAttack??0,'Dragar gains LP equal to the remaining target ATK');
      }
      if(t.stainTwoPlacements){
       const remaining=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:1,location:D}).filter(Boolean).find(c=>c.code===216958556);
       assert.equal(remaining?.position,P.FACEUP_DEFENSE,'The remaining Stain stays face-up in the opponent’s Deck');
      }
      if(t.nauticaOverlay){
       const controller=t.overlayControlChanged?1:0;
       const host=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller,location:F}).filter(Boolean).find(x=>x.code===body);
       assert.deepEqual(host?.overlayCards.slice().sort(),[wing,fusion,...(controller?[]:[t.family])].sort(),'Nautical Adventures follows current Xyz control');
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
       const queryLoc=loc===L.FZONE?T:loc;
       assert(core.duelQueryLocation(duel,{flags:Q.CODE,controller:player,location:queryLoc}).filter(Boolean).some(x=>x.code===id),'Missing '+id+' in '+loc+' for player '+player);
      }
      done=true;
     }
     break;
    }
    case M.SELECT_BATTLECMD:{
     const index=p.attacks.findIndex(x=>x.code===dark);
     if(!attacked){assert(index>=0,'Attacker unavailable');attacked=true;}
     else {respond(R.SELECT_BATTLECMD,{action:Battle.TO_M2,index:0});break;}
     respond(R.SELECT_BATTLECMD,{action:Battle.SELECT_BATTLE,index});break;
    }
    case M.SELECT_CHAIN:{
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
     const index=p.selects.findIndex(x=>t.musicaleSummon&&x.code===t.family||t.stainDragar&&x.code===t.family||t.nauticaOverlay&&x.code===t.family||t.aeroNecro&&x.code===t.family||t.slimeTarget&&x.code===t.family||t.setCapacityChain&&x.code===dark||t.solemnSet&&x.code===t.family&&Number(x.description)===132049334*16||t.mirageSet&&x.code===t.family&&Number(x.description)===133072169*16+1||t.pastrygeistSet&&x.code===t.family&&Number(x.description)===133851064*16+2||t.myutantRecovery&&x.code===t.family||t.galaxixFieldRecovery&&x.code===t.family||t.gravinityInterrupt&&x.code===dark||t.megalSharedChain&&x.code===t.family&&Number(x.description)===t.chainStartDescription||(t.heartbeatNegate||t.chainNecro)&&x.code===dark||t.bitronCopyRemoved&&x.code===dark||t.bhodiReset&&x.code===trap||(t.hopeDeckRemoval||t.standReset)&&x.code===dark||t.heartbeatMaterial&&x.code===body||x.code===dark&&!!t.burnResolution||(!t.immuneOrbHost||t.ghostTransferFamily&&opponentTurn)&&x.code===t.steps[step]&&!t.sequentialActions&&(!t.actionDescription||x.code===helper||Number(x.description)===t.actionDescription)&&(!t.activationSequence||x.code===helper||x.sequence===t.activationSequence)&&(!t.activationLocation||x.code===helper||x.location===t.activationLocation)||x.code===soprana&&(!t.opponent||opponentTurn)&&!quickUsed||x.code===hot&&x.location===B||x.code===t.family&&[formation,grayrover,ivy,grayshade,chapter,grayhex,graylock,grayling,graysentry,gorgonia,brilliance,graydimm,graydeux,pillar,descend,burning,fireball,urphiel,malphiel,vazagiel,azeriel,ophiel,shards,feather,prism,sarifiel,grayterror,ghostXyz,aeroXyz,claw,rook,knight,227531376,standTogether,249629457,241504188,244986323,220124524,232038002,255668557,236616849,212413422,216620496,253128790,259542408,259605536,218142234,238273772,224751741,239245471,259669838,259883230,244408495,259072745,247298564].includes(t.family)&&(x.location!==H||t.family===chapter||t.ghostResponse||t.damageBanishEvent&&t.family===253128790));
     respond(R.SELECT_CHAIN,{index:index>=0?index:p.forced?0:null});break;
    }
    case M.SELECT_EFFECTYN:respond(R.SELECT_EFFECTYN,{yes:[hot,soprana,t.family].includes(p.code)&&!(t.urphielBattleLeave&&Number(p.description)===133105971*16+2)});break;
    case M.SELECT_YESNO:assert(!t.noYes,'An unavailable optional effect was offered');respond(R.SELECT_YESNO,{yes:!!t.yes});break;
    case M.SELECT_OPTION:if(t.options)assert.equal(p.options.length,t.options);respond(R.SELECT_OPTION,{index:t.option||0});break;
    case M.SELECT_CARD:
     if(t.stainDiscardHelper&&p.selects.some(c=>c.code===helper&&c.location===H)){
      respond(R.SELECT_CARD,{indicies:[p.selects.findIndex(c=>c.code===helper)]});break;
     }
     if(t.stainTributeMode==='mixed-tributes')assert(!p.selects.some(c=>c.code===wing),'Level 5 Tribute would leave no Summon candidate');
     if(t.windborneCapacity&&p.selects.some(c=>c.code===body||c.code===wing))assert.equal(p.max,t.windborneCapacity,'Set target count respects actual free zones');
     if(t.gravinityColumn&&p.selects.some(c=>c.code===dark||c.code===spell||c.code===trap)){assert(!p.selects.some(c=>c.code===fusion),'Off-column opponent card excluded');}
{
     if(t.companionUnprotectedBattle&&p.player===1&&p.selects.some(c=>c.code===body))assert(p.selects.some(c=>c.code===232824319),'Unsupported Companion remains an attack target');
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
     const oniRecipientSelection=t.oniQuickRecipient&&p.selects.some(x=>x.code===ghostTransfer);
     const preferred=p.selects.findIndex(x=>x.code===(oniRecipientSelection?t.oniQuickRecipient:t.pick));
     const indicies=p.min===1&&preferred>=0?[preferred]:p.selects.map((_,i)=>i).slice(0,t.selectMax?p.max:p.min);
     respond(R.SELECT_CARD,{indicies});break;
    }
    case M.SELECT_UNSELECT_CARD:if(t.windborneCapacity===1&&p.unselect_cards.some(c=>c.code===body))assert(!p.select_cards.some(c=>c.code===wing),'No second ordinary Set target without room');respond(R.SELECT_UNSELECT_CARD,{index:t.selectMax&&p.select_cards.length?Math.max(0,p.select_cards.findIndex(c=>c.code===body)):p.can_finish?null:0});break;
    case M.SELECT_POSITION:respond(R.SELECT_POSITION,{position:p.positions&P.FACEUP_ATTACK?P.FACEUP_ATTACK:P.FACEUP_DEFENSE});break;
    case M.SELECT_PLACE:{
     let mask=p.field_mask;const places=[];
     for(let i=0;i<Math.max(1,p.count);i++){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6,7].some(j=>(mask&(1<<(v+j)))===0));assert(shift!==undefined,'Enough distinct placement zones');const sequence=[0,1,2,3,4,5,6,7].find(j=>(mask&(1<<(shift+j)))===0);places.push({player:shift>=16?1-p.player:p.player,location:shift%16===8?T:F,sequence});mask|=1<<(shift+sequence);}
     respond(R.SELECT_PLACE,{places});break;
    }
    default:throw Error('Unhandled '+JSON.stringify(p));
    }
   }
   assert(done,'Step limit');results.push({name:t.name,status:'PASS',...(t.joyousDice?{roll:diceRoll}:{})});console.log('PASS',t.name);
  }catch(e){failures++;results.push({name:t.name,status:'FAIL',error:e.message});console.log('FAIL',t.name,e.message);}
  finally{core.destroyDuel(duel);}
 }
 const crypto=require('node:crypto');
 const files=new Map();
 for(const code of new Set(testCases.map(t=>t.family).filter(Boolean).concat([hot,sky,journey,soprana,offer]))){
  const file=path.join(installed,'c'+code+'.lua');
  files.set(code,{file,sha256:crypto.createHash('sha256').update(fs.readFileSync(file)).digest('hex')});
 }
 if(!process.env.CCG_TEST_SOURCE)fs.writeFileSync(path.resolve(__dirname,'../output/fresh-ccg-september',process.argv.includes('--musicale-only')?'musicale-installed.json':process.argv.includes('--stain-tribute-only')?'stain-tribute-installed.json':process.argv.includes('--claw-self-only')?'claw-self-installed.json':process.argv.includes('--self-overlay-necro-only')?'self-overlay-necro-installed.json':process.argv.includes('--aero-necro-only')?'aero-necro-installed.json':process.argv.includes('--ghostrick-destination-only')?'ghostrick-destination-installed.json':process.argv.includes('--oni-quick-only')?'oni-quick-installed.json':process.argv.includes('--field-recovery-family-only')?'field-recovery-family-installed.json':'current-installed-effects-regression.json'),JSON.stringify({
  scope:'Listed OCGCore scenarios with installed scripts and installed card data. Neutral fixture resources and API adapters are used. Full-card and live Omega verification remain open.',
  compatibility:'Legacy Link and fixture Xyz argument translation and procedures, selected chain target mapping, basic Level 12 Xyz material eligibility/selection bridge for ordinary fixture monsters, ordinary fixture overlay eligibility. Graydeux alternate Xyz cases isolate that procedure from the unsupported ordinary Xyz API.',
  pendingCases:['A Stainless Story: --story-shuffle-probe tests whether copied self-shuffle must move the activating Spell instead of the sent monster; current source moves the sent monster. Ruling/intent unresolved.','Ghostrick Oni: the printed Xyz Summon wording and the existing field-to-material implementation still need reconciliation.', 'Sarifiel: hypothetical effect immunity of a GY material. The --grave-immune-probe reproduces attachment; expected ruling needs confirmation before a production change.'],
  installedScripts:Object.fromEntries(files),results
 },null,2)+'\n');
 if(failures)process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1;});
