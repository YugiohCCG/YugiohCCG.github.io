"use strict";
const assert=require('node:assert/strict');
exports.corrected=s=>{
 const marker='function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)';assert.equal(s.split(marker).length,2);
 s=s.replace(marker,'function s.refilter(c,tp)\n\treturn s.efilter(c) and Duel.IsExistingMatchingCard(s.dgfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,c,c)\nend\n'+marker);
 for(const [a,b] of [['Duel.IsExistingMatchingCard(s.efilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil)','Duel.IsExistingMatchingCard(s.refilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,tp)'],['Duel.SelectMatchingCard(tp,s.efilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil)','Duel.SelectMatchingCard(tp,s.refilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,tp)']]){assert.equal(s.split(a).length,2);s=s.replace(a,b);}return s;
};
