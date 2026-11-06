'use strict';
const assert = require('node:assert/strict');

const cards = new Set([223558392, 251058567, 229327103, 223592011, 244920555, 243920845]);

exports.corrected = (source, code) => {
  assert(cards.has(code));
  const newline = source.includes('\r\n') ? '\r\n' : '\n';
  const filter = 'function s.rtfilter(c,e,tp)\n\treturn c:IsFaceup() and c:IsAttribute(ATTRIBUTE_SEARCH) and c:IsSummonLocation(LOCATION_EXTRA)\n\t\tand c:IsAbleToExtra() and c:IsCanBeEffectTarget(e) and Duel.GetMZoneCount(tp,c)>0\nend'.replaceAll('\n', newline);
  const eligible = 'function s.rteligible(c)\n\treturn c:IsFaceup() and c:IsAttribute(ATTRIBUTE_SEARCH) and c:IsSummonLocation(LOCATION_EXTRA)\n\t\tand c:IsAbleToExtra()\nend\nfunction s.rtfilter(c,e,tp)\n\treturn s.rteligible(c) and c:IsCanBeEffectTarget(e) and Duel.GetMZoneCount(tp,c)>0\nend'.replaceAll('\n', newline);
  const guard = 'tc and tc:IsRelateToEffect(e) and s.rtfilter(tc,e,tp)';
  assert.equal(source.split(filter).length, 2);
  assert.equal(source.split(guard).length, 2);
  return source.replace(filter, eligible).replace(guard,
    'tc and tc:IsRelateToEffect(e) and tc:IsControler(tp) and tc:IsLocation(LOCATION_MZONE) and s.rteligible(tc) and Duel.GetMZoneCount(tp,tc)>0');
};
