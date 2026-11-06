'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='return c:IsSetCard(0x4ac0) and c:IsAbleToGrave()',b='return c:IsSetCard(0x4ac0) and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()';assert.equal(s.split(a).length,2);return s.replace(a,b);};
