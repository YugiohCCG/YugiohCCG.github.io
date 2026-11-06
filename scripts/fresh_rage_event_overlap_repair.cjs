'use strict';
const assert = require('node:assert/strict');

exports.corrected = (source, code) => {
  assert.equal(code, 259100752);
  const original = 'return c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-p';
  assert.equal(source.split(original).length, 2);
  return source.replace(original, 'return (e:GetCode()~=EVENT_REMOVE or not c:IsReason(REASON_DESTROY)) and c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-p');
};
