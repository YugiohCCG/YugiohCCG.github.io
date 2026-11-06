'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='elseif canhand and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then';assert.equal(s.split(a).length,2);return s.replace(a,'elseif canhand and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_HAND) then');};
