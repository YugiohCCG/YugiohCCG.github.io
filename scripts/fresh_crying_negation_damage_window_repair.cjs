'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,id)=>{
 assert([220305422,234296128,233499093].includes(id));
 const flags='e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL)';assert.equal(s.split(flags).length,2);
 if(id!==234296128)return s.replace('\t'+flags+'\r\n','').replace('\t'+flags+'\n','');
 s=s.replace(flags,'e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP)');
 const f='function s.negcon(e,tp,eg,ep,ev,re,r,rp)';assert.equal(s.split(f).length,2);
 return s.replace(f,f+'\n\tif Duel.GetCurrentPhase()==PHASE_DAMAGE and Duel.IsDamageCalculated() then return false end');
};
