'use strict';
const assert=require('assert/strict');exports.corrected=(s,code)=>{assert([229875953,219047593].includes(code));for(const [a,b,n] of [['chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE)','chkc:IsLocation(LOCATION_MZONE)',1],['tp,LOCATION_MZONE,0,1,','tp,LOCATION_MZONE,LOCATION_MZONE,1,',2]]){assert.equal(s.split(a).length,n+1);s=s.replaceAll(a,b);}return s;};
