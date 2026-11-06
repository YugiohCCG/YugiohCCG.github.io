'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{
 const old='Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0';assert.equal(s.split(old).length,2);
 s=s.replace(old,'Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP)');
 const mark='tc:RegisterEffect(e1,true)';assert.equal(s.split(mark).length,2);
 return s.replace(mark,mark+'\n\t\tDuel.SpecialSummonComplete()');
};
