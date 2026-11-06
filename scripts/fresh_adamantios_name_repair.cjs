'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='return c:IsCode(id) and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE)';assert.equal(s.split(a).length,2);return s.replace(a,'return c:IsControler(tp) and c:IsLocation(LOCATION_MZONE)');};
