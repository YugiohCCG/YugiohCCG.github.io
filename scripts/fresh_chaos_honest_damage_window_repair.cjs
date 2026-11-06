'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const a='e2:SetCode(EVENT_PRE_DAMAGE_CALCULATE)',b='e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL)',c='function s.atkcon(e,tp)';for(const v of [a,b,c])assert.equal(s.split(v).length,2);return s.replace(a,'e2:SetCode(EVENT_FREE_CHAIN)\n\te2:SetHintTiming(TIMING_DAMAGE_STEP)').replace(b,'e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP)').replace(c,c+'\n\tif Duel.GetCurrentPhase()~=PHASE_DAMAGE or Duel.IsDamageCalculated() then return false end');};
