'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const old='e2:SetProperty(EFFECT_FLAG_DELAY)';assert.equal(s.split(old).length,2);return s.replace(old,'e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_DAMAGE_STEP)');};
