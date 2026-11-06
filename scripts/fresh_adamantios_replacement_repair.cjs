'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='eg:IsExists(s.repfilter2,1,nil,tp)';assert.equal(s.split(a).length,2);return s.replace(a,'eg:IsContains(e:GetHandler()) and s.repfilter2(e:GetHandler(),tp)');};
