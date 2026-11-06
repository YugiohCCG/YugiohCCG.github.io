'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,id)=>{
 assert([220150285,238035167,250339529,259348317].includes(id));
 const v=id===259348317?'fc':'tc';
 const call=`Duel.SpecialSummon(${v},SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)`;
 assert.equal(s.split(call).length,2);
 s=s.replace(call,`if ${call}>0 then ${v}:CompleteProcedure() end`);
 const tail=new RegExp(`(fop\\(ce,e,tp,${v},(?:mat2|mat)\\)\\r?\\n)([\\t ]*)end\\r?\\n[\\t ]*${v}:CompleteProcedure\\(\\)`);
 assert(tail.test(s));
 return s.replace(tail,(_,a,indent)=>a+indent+'\t'+v+':CompleteProcedure()\n'+indent+'end');
};
