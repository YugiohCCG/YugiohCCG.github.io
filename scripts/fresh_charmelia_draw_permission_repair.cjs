'use strict';
const assert=require('assert/strict');
exports.corrected=s=>{
 const a='if chk==0 then return c:IsAbleToHand() and aux.NecroValleyFilter()(c) end';
 const b='if chk==0 then\n\t\tlocal ct=s.drawcount(tp)\n\t\treturn c:IsAbleToHand() and aux.NecroValleyFilter()(c)\n\t\t\tand (ct==0 or Duel.IsPlayerCanDraw(tp,ct))\n\tend';
 assert.equal(s.split(a).length,2);return s.replace(a,b);
};
