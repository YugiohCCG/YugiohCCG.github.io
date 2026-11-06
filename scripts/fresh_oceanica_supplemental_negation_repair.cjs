'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const a='function s.chcon(e,tp,eg,ep,ev,re,r,rp) if rp~=tp';assert.equal(s.split(a).length,2);return s.replace(a,'function s.chcon(e,tp,eg,ep,ev,re,r,rp) if Duel.IsChainDisabled(ev) then return false end if rp~=tp');};
