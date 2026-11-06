'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='if Duel.Destroy(g,REASON_EFFECT)==2 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.rdf)';assert.equal(s.split(a).length,2);return s.replace(a,'Duel.Destroy(g,REASON_EFFECT); if Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.rdf)');};
