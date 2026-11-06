'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end';assert.equal(s.split(a).length,2);return s.replace(a,'if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 or not g:GetFirst():IsLocation(LOCATION_HAND) then return end');};
