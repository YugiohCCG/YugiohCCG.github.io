'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{
 const needle='\t\t\tDuel.Summon(p,tc,true,nil)';assert.equal(s.split(needle).length,2);
 s=s.replace(needle,'\t\t\ts.normalzero(e,tc)\n'+needle);
 assert(!s.includes('function s.normalzero'));
 return s+`
--The Normal Summon is performed after the resolving effect finishes.
function s.normalzero(e,tc)
 local e1=Effect.CreateEffect(e:GetHandler())
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
 e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 e1:SetCode(EVENT_SUMMON_SUCCESS)
 e1:SetOperation(function(te) s.atkzero(e,te:GetHandler()) te:Reset() end)
 e1:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TOFIELD+RESET_PHASE+PHASE_END)
 tc:RegisterEffect(e1)
end
`;
};
