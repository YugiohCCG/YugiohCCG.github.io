'use strict';
const assert = require('node:assert/strict');

exports.corrected = (source, code) => {
  assert([259114673, 259628203].includes(code));
  const guard = 'tc:IsRelateToEffect(e) and tc:IsControler(1-tp)';
  assert.equal(source.split(guard).length, 2);
  return source.replace(guard, 'tc:IsRelateToEffect(e)');
};
