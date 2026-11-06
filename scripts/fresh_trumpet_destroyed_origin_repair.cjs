'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='and c:IsPreviousControler(tp)';assert.equal(s.split(a).length,2);return s.replace(a,'and c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE)');};
