'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const a='c:IsOriginalType(TYPE_MONSTER)';assert.equal(s.split(a).length,2);return s.replace(a,'(c:GetOriginalType()&TYPE_MONSTER)~=0');};
