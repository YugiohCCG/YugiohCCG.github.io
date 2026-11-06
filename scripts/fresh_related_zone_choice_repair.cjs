'use strict';
const assert = require('node:assert/strict');

const choices = new Map([
  [236898203, ['desfilter', 'LOCATION_ONFIELD', 'c,e', 'c,e,tp']],
  [238274860, ['desfilter', 'LOCATION_HAND+LOCATION_ONFIELD', 'c', 'c,e,tp']],
  [247755865, ['desfilter', 'LOCATION_HAND+LOCATION_ONFIELD', 'c,tp', 'c,tp']],
  [247755871, ['destroyfilter', 'LOCATION_ONFIELD', 'nil,tp', 'nil,tp']],
]);

exports.corrected = (source, code) => {
  const [filter, pool, args, spaceArgs] = choices.get(code);
  const old = `local g=Duel.SelectMatchingCard(tp,s.${filter},tp,${pool},0,1,1,${args})`;
  assert.equal(source.split(old).length, 2);
  const newline = source.includes('\r\n') ? '\r\n' : '\n';
  const lines = [
    'local g',
    ' if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0',
    `  and Duel.IsExistingMatchingCard(s.spacefilter,tp,LOCATION_MZONE,0,1,${spaceArgs}) then`,
    `  g=Duel.SelectMatchingCard(tp,s.spacefilter,tp,LOCATION_MZONE,0,1,1,${spaceArgs})`,
    ' else',
    `  ${old.slice(6)}`,
    ' end',
  ];
  let corrected = source.replace(old, lines.join(newline));
  if (code === 247755865 || code === 247755871) {
    const capacity = newline + '  and (Duel.GetLocationCount(tp,LOCATION_MZONE)>0 or c:IsLocation(LOCATION_MZONE))';
    assert.equal(corrected.split(capacity).length, 2);
    corrected = corrected.replace(capacity, '');
  }
  return corrected;
};
