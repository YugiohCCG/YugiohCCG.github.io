'use strict';
const assert=require('node:assert/strict');
exports.named=s=>{const a='return re:GetOwner()==e:GetOwner()';assert.equal(s.split(a).length,2);return s.replace(a,'return re:GetOwner():IsCode(id)');};
exports.active=s=>{const a='return fc:IsFaceup() and fc:IsLocation(LOCATION_FZONE)';assert.equal(s.split(a).length,2);return s.replace(a,'return fc:IsFaceup() and not fc:IsDisabled() and fc:IsLocation(LOCATION_FZONE)');};
exports.corrected=s=>exports.active(exports.named(s));
