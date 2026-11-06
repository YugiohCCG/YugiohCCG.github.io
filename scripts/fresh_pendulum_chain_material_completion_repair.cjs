'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,id)=>{
 assert([210506870,245935439].includes(id));
 const re=/local fop=ce:GetOperation\(\)\r?\n\t\tfop\(ce,e,tp,fc,mat\)\r?\n\t\tfc:CompleteProcedure\(\)/;
 assert(re.test(s));
 return s.replace(re,`local fop=ce:GetOperation()
		--Chain Material callbacks do not return the summon result.
		local complete=Effect.CreateEffect(e:GetHandler())
		complete:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		complete:SetCode(EVENT_SPSUMMON_SUCCESS)
		complete:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		complete:SetOperation(function(se,sp,sg)
			if sg:IsContains(fc) and fc:IsSummonType(SUMMON_TYPE_FUSION) then fc:CompleteProcedure() end
		end)
		Duel.RegisterEffect(complete,tp)
		fop(ce,e,tp,fc,mat)
		complete:Reset()`);
};
