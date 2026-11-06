'use strict';
const assert = require('node:assert/strict');

function correctScion(source) {
  const newline = source.includes('\r\n') ? '\r\n' : '\n';
  const capacity = ' and (Duel.GetLocationCount(tp,LOCATION_MZONE)>0 or c:IsLocation(LOCATION_MZONE) and Duel.GetMZoneCount(tp,c)>0)';
  assert.equal(source.split(capacity).length, 2);
  const boundary = newline + 'end' + newline + 'function s.handtg(';
  assert(source.includes(capacity + boundary));
  const eligibility = ['','end','function s.spacefilter(c,tp)',
    ' return s.destroyfilter(c,tp)' + capacity,'end','function s.handtg('].join(newline);
  const choice = 'local g=Duel.SelectMatchingCard(tp,s.destroyfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,nil,tp)';
  assert.equal(source.split(choice).length, 2);
  return source.replace(capacity + boundary, eligibility)
    .replace('Duel.IsExistingMatchingCard(s.destroyfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,nil,tp)',
      'Duel.IsExistingMatchingCard(s.spacefilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,nil,tp)')
    .replace(choice, [
      'local opensZone=Duel.GetLocationCount(tp,LOCATION_MZONE)<=0',
      '  and Duel.IsExistingMatchingCard(s.spacefilter,tp,LOCATION_MZONE,0,1,nil,tp)',
      ' local filter=opensZone and s.spacefilter or s.destroyfilter',
      ' local location=opensZone and LOCATION_MZONE or LOCATION_HAND+LOCATION_MZONE',
      ' local g=Duel.SelectMatchingCard(tp,filter,tp,location,0,1,1,nil,tp)',
    ].join(newline));
};

function correctStagger(source) {
  const old = 'local dg=g:Select(tp,2,2,nil)';
  assert.equal(source.split(old).length, 2);
  const newline = source.includes('\r\n') ? '\r\n' : '\n';
  return source.replace(old, [
    'local dg',
    '\tif Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 and g:CheckSubGroup(s.spacecheck,2,2,tp) then',
    '\t\tdg=g:SelectSubGroup(tp,s.spacecheck,false,2,2,tp)',
    '\telse',
    '\t\tdg=g:Select(tp,2,2,nil)',
    '\tend',
    '\tif not dg then return end',
  ].join(newline).replaceAll('\\t','\t'));
};

exports.corrected = (source, code) => {
  if (code === 238276248) return correctScion(source);
  assert.equal(code, 253934904);
  return correctStagger(source);
};
