'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,code)=>{assert([235051048,247755869,239935098].includes(Number(code)));const fn=Number(code)===235051048?'desfilter':'destroyed';const pattern=new RegExp('(function s\\.'+fn+'\\(c,tp\\)\\r?\\n[ \\t]*return )');assert.equal(s.split(pattern).length,3);return s.replace(pattern,'$1c:IsPreviousPosition(POS_FACEUP) and ');};
