'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const old='and c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE)';assert.equal(s.split(old).length,2);assert(!s.includes('and c:IsPreviousPosition(POS_FACEUP)'));return s.replace(old,old+' and c:IsPreviousPosition(POS_FACEUP)');};
