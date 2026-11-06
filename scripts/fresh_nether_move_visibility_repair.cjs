'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='or c:IsLocation(LOCATION_REMOVED) and c:IsAbleToGrave())';assert.equal(s.split(a).length,2);return s.replace(a,'or c:IsLocation(LOCATION_REMOVED) and c:IsFaceup() and c:IsAbleToGrave())');};
