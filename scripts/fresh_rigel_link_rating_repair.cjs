'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const old='if c:IsType(TYPE_LINK) then return c:GetLink() end\n\treturn 1';assert.equal(s.split(old).length,2);return s.replace(old,'if c:IsType(TYPE_LINK) then return c:GetLink() end\n\treturn 0');};
