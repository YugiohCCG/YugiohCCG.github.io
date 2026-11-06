'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{for(const [a,b] of [['local os=4-oc:GetSequence();','local os=oc:GetSequence()==5 and 3 or oc:GetSequence()==6 and 1 or 4-oc:GetSequence();'],['if not c:IsFaceup() or not oc:IsFaceup() then return end','if not c:IsFaceup() then return end']]){assert.equal(s.split(a).length,2);s=s.replace(a,b);}return s;};
