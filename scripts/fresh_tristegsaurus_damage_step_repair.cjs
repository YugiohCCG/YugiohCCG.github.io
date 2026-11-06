'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const old='e2:SetCode(EVENT_DESTROYED)';assert.equal(s.split(old).length,2);return s.replace(old,old+'\n e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DAMAGE_STEP)');};
