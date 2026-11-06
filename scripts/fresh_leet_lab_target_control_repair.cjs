'use strict';
const assert = require('node:assert/strict');

const occurrences = new Map([[259138193, 2], [259943152, 1]]);

exports.corrected = (source, code) => {
  const expected = occurrences.get(code);
  assert(expected);
  const guard = 'tc:IsRelateToEffect(e) and tc:IsControler(tp)';
  assert.equal(source.split(guard).length - 1, expected);
  return source.replaceAll(guard, 'tc:IsRelateToEffect(e)');
};
