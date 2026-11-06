'use strict';
const assert=require('node:assert/strict');function corrected(s){const a='return c:IsControler(tp) and c:IsRace(RACE_PYRO) and c:IsType(TYPE_FUSION)',b='return c:IsFaceup() and c:IsControler(tp) and c:IsRace(RACE_PYRO) and c:IsType(TYPE_FUSION)';assert.equal(s.split(a).length-1,1);return s.replace(a,b);}module.exports={corrected};
