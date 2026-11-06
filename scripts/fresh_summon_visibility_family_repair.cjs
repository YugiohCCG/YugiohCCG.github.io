'use strict';
const assert=require('node:assert/strict');
function corrected(code,s){const a=code===217174535?'return c==sc or c:IsControler(tp) and c:IsSetCard(SET_STAIN)':'return c:IsSetCard(SET_ALTERGEIST) and c:IsSummonPlayer(tp)',b=code===217174535?'return c==sc or c:IsFaceup() and c:IsControler(tp) and c:IsSetCard(SET_STAIN)':'return c:IsFaceup() and c:IsSetCard(SET_ALTERGEIST) and c:IsSummonPlayer(tp)';assert.equal(s.split(a).length-1,1);return s.replace(a,b);}module.exports={corrected};
