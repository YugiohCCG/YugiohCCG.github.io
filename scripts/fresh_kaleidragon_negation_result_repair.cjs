'use strict';
const assert=require('assert/strict');
exports.corrected=s=>{
 const before='if Duel.NegateEffect(ev)~=0 then';
 assert.equal(s.split(before).length,2);return s.replace(before,'if Duel.NegateEffect(ev) then');
};
