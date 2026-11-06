'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='local g1=Duel.GetMatchingGroup(s.banfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil)',b='local g1=Duel.GetMatchingGroup(s.banpairfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil,tp)';assert.equal(s.split(a).length,2);return s.replace(a,b);};
