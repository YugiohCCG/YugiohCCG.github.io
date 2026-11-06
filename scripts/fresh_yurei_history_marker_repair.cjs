'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const a='e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS); e4:SetCode(EVENT_SUMMON_SUCCESS)';assert.equal(s.split(a).length,2);return s.replace(a,'e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS); e4:SetProperty(EFFECT_FLAG_CANNOT_DISABLE); e4:SetCode(EVENT_SUMMON_SUCCESS)');};
