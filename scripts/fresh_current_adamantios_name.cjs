'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');const file=path.join(__dirname,'fresh_current_adamantios_replacement.cjs');let outer=fs.readFileSync(file,'utf8');const at=outer.indexOf('const m=new Module(file,module);');assert(at>0);
const additions=String.raw`
rep("['otherCopy','selfAccept','selfDecline','otherCopyBanish','selfBanish']","['renamedAccept','renamedDecline','renamedBanish','otherCopyRenamed']");
rep("eligible=['selfAccept','selfBanish'].includes(scenario)","eligible=['renamedAccept','renamedBanish'].includes(scenario)");
rep('assert(Duel.Equip(tp,eq,tc))','assert(Duel.Equip(tp,eq,tc)) local ce=Effect.CreateEffect(e:GetHandler()) ce:SetType(EFFECT_TYPE_SINGLE) ce:SetCode(EFFECT_CHANGE_CODE) ce:SetValue(900006105) tc:RegisterEffect(ce) assert(tc:GetCode()==900006105 and tc:GetOriginalCode()==259315827)');
rep('assert(tc and tc:IsCode(259315827))','assert(tc and tc:GetOriginalCode()==259315827)');
rep('field.filter(c=>c.code===boss).length','field.filter(c=>[boss,mixed].includes(c.code)).length');
rep('p.code===boss?(offers.push',"p.description===BigInt(133315827*16+1)?(offers.push");
rep("scenario!=='selfDecline'","scenario!=='renamedDecline'");
rep("'current-adamantios-replacement'","'current-adamantios-name'");
rep("'adamantios-before-replacement-identity-repair'","'adamantios-before-name-repair'");
rep('return lua;};',"if(name==='c'+boss+'.lua'&&process.argv.includes('--name-candidate'))lua=require('./fresh_adamantios_name_repair.cjs').corrected(lua);return lua;};");
rep('const suffix=',"const suffix=process.argv.includes('--name-candidate')?'-name-candidate':");
s=s.replace(/scope:'[^']*'/,"scope:'Full original Adamantios/current installed metadata/corrected public engine/no Lua API adapter. Native Equip then actual EFFECT_CHANGE_CODE on one of two field-seeded sources; opponent native GY send/banish, real replacement choice/payment, unrelated copy exclusion. Original Xyz/Quick equip/full-card/live Omega remain open.'");
`;
outer=outer.slice(0,at)+additions+outer.slice(at);const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(outer,file);
