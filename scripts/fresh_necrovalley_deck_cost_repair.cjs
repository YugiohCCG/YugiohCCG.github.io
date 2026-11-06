'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,code)=>{
 const replacements={
  218142234:['aux.NecroValleyFilter(s.pcostfilter)','s.pcostfilter',1],
  256287781:['aux.NecroValleyFilter(s.costfilter)','s.costfilter',1],
  256462992:['c:IsAbleToExtraAsCost() and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter(s.excostfilter)(c))','c:IsAbleToExtraAsCost()',1],
  259360287:['aux.NecroValleyFilter(s.tdfilter)','s.tdfilter',2]
 };
 const [before,after,count]=replacements[code];assert.equal(s.split(before).length-1,count);
 return s.split(before).join(after);
};
