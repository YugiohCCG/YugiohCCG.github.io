'use strict';
const assert = require('node:assert/strict');

exports.corrected = (source, code) => {
  assert(code >= 284639717 && code <= 284639724);
  const old = code === 284639723
    ? 'if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then'
    : 'local g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_ONFIELD,0,1,1,c,c)';
  const start = source.indexOf('function s.pop(');
  const end = source.indexOf('\nfunction ', start + 1);
  const limit = end < 0 ? source.length : end;
  const operation = source.slice(start, limit);
  assert(start >= 0 && operation.split(old).length === 2);
  const newline = operation.includes('\r\n') ? '\r\n' : '\n';
  const canFreeZone = 'Duel.IsExistingMatchingCard(s.zonefilter,tp,LOCATION_MZONE,0,1,c,c)';
  let corrected;
  if (code === 284639723) {
    const select = 'g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_MZONE,0,1,1,c,c)';
    assert.equal(operation.split(select).length, 2);
    corrected = operation.replace(old, 'if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0' + newline
      + '  and ' + canFreeZone + ' then').replace(select, select.replace('s.destroyfilter', 's.zonefilter'));
  } else {
    corrected = operation.replace(old, [
      'local freeZone=Duel.GetLocationCount(tp,LOCATION_MZONE)<=0',
      '  and ' + canFreeZone,
      ' local filter=freeZone and s.zonefilter or s.destroyfilter',
      ' local location=freeZone and LOCATION_MZONE or LOCATION_ONFIELD',
      ' local g=Duel.SelectMatchingCard(tp,filter,tp,location,0,1,1,c,c)',
    ].join(newline));
  }
  return source.slice(0, start) + corrected + source.slice(limit);
};
