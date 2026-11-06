'use strict';
const assert=require('node:assert/strict');function corrected(s){const a='return (c:IsSetCard(SET_WYVERNAL) or c:IsRace(RACE_INSECT)) and c:IsType(TYPE_MONSTER)',b='return c:IsFaceup() and (c:IsSetCard(SET_WYVERNAL) or c:IsRace(RACE_INSECT)) and c:IsType(TYPE_MONSTER)';assert.equal(s.split(a).length-1,1);return s.replace(a,b);}module.exports={corrected};
