'use strict';
const assert=require('node:assert/strict');
exports.marker=s=>{const a='e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)';assert.equal(s.split(a).length,2);return s.replace(a,a+'\n\te1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)');};
exports.attributes=s=>{const a='g:IsExists(Card.IsAttribute,1,nil,';assert.equal(s.split(a).length,3);return s.split(a).join('g:IsExists(function(tc,att) return (tc:GetPreviousAttributeOnField()&att)~=0 end,1,nil,');};
exports.corrected=s=>exports.attributes(exports.marker(s));
