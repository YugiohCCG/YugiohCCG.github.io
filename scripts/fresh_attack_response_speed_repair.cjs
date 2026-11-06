'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,code)=>{assert([259844716,259235389].includes(code));const v=code===259844716?'e2':'e4',a=v+':SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)';assert.equal(s.split(a).length,2);return s.replace(a,v+':SetType(EFFECT_TYPE_QUICK_O)');};
