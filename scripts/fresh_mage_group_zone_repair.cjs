'use strict';
const assert=require('node:assert/strict');
function corrected(s){const a='and Duel.GetMZoneCount(tp,g)>=ct and s.pzexcheck(sg,tp,g)',b='and Duel.GetMZoneCount(tp,g)>=sg:FilterCount(Card.IsLocation,nil,LOCATION_HAND)\n\t\tand Duel.GetUsableMZoneCount(tp)+#g>=ct and s.pzexcheck(sg,tp,g)';assert.equal(s.split(a).length-1,1);return s.replace(a,s.includes('\r\n')?b.replaceAll('\n','\r\n'):b);}
module.exports={corrected};
