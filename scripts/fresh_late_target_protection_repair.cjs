'use strict';
const assert = require('node:assert/strict');

const equipCards = new Set([215921734, 238136421, 248788543, 255832330]);

exports.corrected = (source, code) => {
  if (code === 215034223) {
    const guard = 'tc:IsRelateToEffect(e) and s.cfilter(tc,tp,e)';
    assert.equal(source.split(guard).length, 2);
    return source.replace(guard, 'tc:IsRelateToEffect(e) and s.cfilter(tc,tp)');
  }

  const name = code === 259943152 ? 'tgfilter' : 'fmeqfilter';
  const filterCall = equipCards.has(code) ? 's.eqfilter(tc,e)' : `s.${name}(tc,e)`;
  assert.equal(source.split(filterCall).length, 2);
  if (equipCards.has(code)) return source.replace(filterCall, 's.eqfilter(tc)');

  assert([259943152, 259184310].includes(code));
  const newline = source.includes('\r\n') ? '\r\n' : '\n';
  const start = `function s.${name}(c,e)`;
  const at = source.indexOf(start);
  assert(at >= 0);
  const end = source.indexOf(newline + 'end', at) + newline.length + 3;
  const original = source.slice(at, end);
  const eligible = name + '_eligible';
  const body = original.replace(start, `function s.${eligible}(c)`)
    .replace(/\s+and c:IsCanBeEffectTarget\(e\)/, '');
  assert(!body.includes('IsCanBeEffectTarget'));
  const activation = [start, `	return s.${eligible}(c) and c:IsCanBeEffectTarget(e)`, 'end'].join(newline);
  return source.replace(original, body + newline + activation)
    .replace(filterCall, `s.${eligible}(tc)`);
};
