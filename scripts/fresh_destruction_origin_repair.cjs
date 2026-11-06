'use strict';
const assert=require('assert/strict');
exports.corrected=(s,code)=>{
 let a,b;
 if(code===224049334){a='tc:IsType(TYPE_SPELL+TYPE_TRAP) and tc:IsPreviousLocation(LOCATION_ONFIELD)';b='tc:IsType(TYPE_SPELL+TYPE_TRAP)';}
 else if(code===214552846){a='return c:IsReason(REASON_DESTROY) and c:IsPreviousLocation(LOCATION_ONFIELD)';b='return c:IsReason(REASON_DESTROY)';}
 else throw Error('Unexpected origin candidate '+code);
 assert.equal(s.split(a).length,2);return s.replace(a,b);
};
