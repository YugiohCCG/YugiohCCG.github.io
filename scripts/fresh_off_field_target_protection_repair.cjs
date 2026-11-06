'use strict';
const assert = require('node:assert/strict');

const filters = new Map([
  [259652372, ['tdfilter', 'c,e']],
  [259926839, ['qpfilter', 'c,e']],
  [259646610, ['tgfilter', 'c,e']],
  [256928871, ['spfilter', 'c,e,tp']],
  [222257685, ['gyfilter', 'c,e,tp']],
  [259223502, ['spfilter', 'c,e,tp']],
]);

exports.corrected = (source, code) => {
  const [filter, args] = filters.get(code);
  const signature = `function s.${filter}(${args})`;
  const start = source.indexOf(signature);
  assert(start >= 0);
  const newline = source.startsWith('\r\n', start + signature.length) ? '\r\n' : '\n';
  const end = source.indexOf(newline + 'end', start) + newline.length + 3;
  const original = source.slice(start, end);
  const eligible = filter + '_eligible';
  const body = original.replace(signature, `function s.${eligible}(${args})`)
    .replace(/\s+and c:IsCanBeEffectTarget\(e\)/, '');
  assert(original.includes('IsCanBeEffectTarget') && !body.includes('IsCanBeEffectTarget'));
  const activation = [signature, `	return s.${eligible}(${args}) and c:IsCanBeEffectTarget(e)`, 'end'].join(newline);
  const call = `aux.NecroValleyFilter(s.${filter})(tc,${args.slice(2)})`;
  assert.equal(source.split(call).length, 2);
  return source.replace(original, body + newline + activation).replace(call, call.replace(filter, eligible));
};
