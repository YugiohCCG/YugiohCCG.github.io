'use strict';
const assert=require('assert/strict');
exports.corrected=s=>{const a='return Duel.GetAttacker():IsControler(1-tp)',b='return Duel.GetAttacker()~=nil';assert.equal(s.split(a).length,2);return s.replace(a,b);};
