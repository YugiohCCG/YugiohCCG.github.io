'use strict';
const assert=require('node:assert/strict');
function corrected(code,s){const a=code===247580036?'return c==sc or c:IsControler(tp) and c:IsSetCard(SET_STAIN)':'return c:IsSummonPlayer(1-tp) and not c:IsAttribute(ATTRIBUTE_LIGHT)',b=code===247580036?'return c==sc or c:IsFaceup() and c:IsControler(tp) and c:IsSetCard(SET_STAIN)':'return c:IsFaceup() and c:IsSummonPlayer(1-tp) and not c:IsAttribute(ATTRIBUTE_LIGHT)';assert.equal(s.split(a).length-1,1);return s.replace(a,b);}module.exports={corrected};
