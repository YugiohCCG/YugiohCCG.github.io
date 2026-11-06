'use strict';
const assert=require('assert/strict');
exports.corrected=s=>{
 const a='if Duel.Destroy(tc,REASON_EFFECT)>0 and e:GetLabel()>=7 then';
 assert.equal(s.split(a).length,2);return s.replace(a,'Duel.Destroy(tc,REASON_EFFECT)\n\tif e:GetLabel()>=7 then');
};
