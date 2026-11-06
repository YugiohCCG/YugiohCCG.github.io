"use strict";
const assert=require('node:assert/strict');
exports.corrected=s=>{
const marker='function s.descost(e,tp,eg,ep,ev,re,r,rp,chk)';assert.equal(s.split(marker).length,2);
s=s.replace(marker,'function s.desreleasefilter(c,tp)\n\treturn Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,LOCATION_ONFIELD)>1+c:GetEquipCount()\nend\n'+marker);
for(const [a,b] of [['Duel.CheckReleaseGroup(tp,nil,1,nil)','Duel.CheckReleaseGroup(tp,s.desreleasefilter,1,nil,tp)'],['Duel.SelectReleaseGroup(tp,nil,1,1,nil)','Duel.SelectReleaseGroup(tp,s.desreleasefilter,1,1,nil,tp)']]){assert.equal(s.split(a).length,2);s=s.replace(a,b);}return s;
};
