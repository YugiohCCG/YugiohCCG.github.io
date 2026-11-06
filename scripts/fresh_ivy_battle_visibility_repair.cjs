'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='return c and c:IsControler(tp) and c:IsSetCard(SET_TERRARUMIAN)';assert.equal(s.split(a).length,2);return s.replace(a,'return c and c:IsFaceup() and c:IsControler(tp) and c:IsSetCard(SET_TERRARUMIAN)');};
