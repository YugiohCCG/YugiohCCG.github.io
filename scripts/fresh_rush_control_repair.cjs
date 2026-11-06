'use strict';
const assert = require('node:assert/strict');

exports.corrected = (source, code) => {
  assert.equal(code, 259755133);
  const guard = 'tc:IsRelateToEffect(e) and tc:IsControler(1-tp)';
  assert.equal(source.split(guard).length, 2);
  return source.replace(guard, 'tc:IsRelateToEffect(e)');
};
