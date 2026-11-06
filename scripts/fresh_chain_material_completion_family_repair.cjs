'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,id)=>{
 assert([220150285,227035644,238035167,250339529,259160760,259184310,259348317,259562343,259680842].includes(id));
 const re=/local fop=ce:GetOperation\(\)\r?\n([\t ]*)fop\(ce,e,tp,(tc|fc),(mat2|mat)\)\r?\n\1\2:CompleteProcedure\(\)/;
 assert(re.test(s));
 return s.replace(re,(_,indent,c,mat)=>[
 'local fop=ce:GetOperation()',
 '--Chain Material callbacks do not return the summon result.',
 'local complete=Effect.CreateEffect(e:GetHandler())',
 'complete:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)',
 'complete:SetCode(EVENT_SPSUMMON_SUCCESS)',
 'complete:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)',
 'complete:SetOperation(function(se,sp,sg)',
 `\tif sg:IsContains(${c}) and ${c}:IsSummonType(SUMMON_TYPE_FUSION) then ${c}:CompleteProcedure() end`,
 'end)',
 'Duel.RegisterEffect(complete,tp)',
 `fop(ce,e,tp,${c},${mat})`,
 'complete:Reset()'].join('\n'+indent));
};
