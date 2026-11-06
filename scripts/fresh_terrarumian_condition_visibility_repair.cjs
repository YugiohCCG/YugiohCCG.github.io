'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const lf=String.fromCharCode(10),crlf=String.fromCharCode(13,10),nl=s.includes(crlf)?crlf:lf,a='function s.ownmonster(c)'+nl+' return c:IsSetCard(SET_TERRARUMIAN)';assert.equal(s.split(a).length,2);return s.replace(a,a.replace('return c:IsSetCard','return c:IsFaceup() and c:IsSetCard'));};
