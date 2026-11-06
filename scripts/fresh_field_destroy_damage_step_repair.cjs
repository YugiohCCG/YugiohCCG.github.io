'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,code)=>{assert([238276251,251236672].includes(Number(code)));const old=Number(code)===238276251?'e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)':'e2:SetProperty(EFFECT_FLAG_DELAY)';assert.equal(s.split(old).length,2);return s.replace(old,old.slice(0,-1)+'+EFFECT_FLAG_DAMAGE_STEP)');};
