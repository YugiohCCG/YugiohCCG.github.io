'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const a='function s.discon(e,tp)';assert.equal(s.split(a).length,2);return s.replace(a,'function s.discon(e) local tp=e:GetHandlerPlayer()');};
