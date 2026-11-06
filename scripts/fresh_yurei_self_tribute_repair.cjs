'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const a='LOCATION_HAND+LOCATION_MZONE,0,1,e:GetHandler(),e)',b='LOCATION_HAND+LOCATION_MZONE,0,1,1,e:GetHandler(),e)';assert.equal(s.split(a).length,2);assert.equal(s.split(b).length,2);return s.replace(a,'LOCATION_HAND+LOCATION_MZONE,0,1,nil,e)').replace(b,'LOCATION_HAND+LOCATION_MZONE,0,1,1,nil,e)');};
