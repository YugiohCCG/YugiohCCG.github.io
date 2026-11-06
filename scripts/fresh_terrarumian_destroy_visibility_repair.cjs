'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const old='return c~=handler and c:IsSetCard(SET_TERRARUMIAN)';assert.equal(s.split(old).length,2);return s.replace(old,'return c~=handler and c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN)');};
