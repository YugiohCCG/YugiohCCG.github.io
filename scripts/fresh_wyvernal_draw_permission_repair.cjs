'use strict';
const assert=require('assert/strict');
exports.corrected=s=>{
 const a='local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE,0,1,4,nil,e)';
 const b='local max=4\n\tif not Duel.IsPlayerCanDraw(tp,1) then max=1\n\telseif not Duel.IsPlayerCanDraw(tp,2) then max=3 end\n\tlocal g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_GRAVE,0,1,max,nil,e)';
 assert.equal(s.split(a).length,2);return s.replace(a,b);
};
