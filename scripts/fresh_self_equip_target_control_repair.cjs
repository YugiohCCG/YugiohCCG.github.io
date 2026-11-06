'use strict';
const assert = require('node:assert/strict');

const guards = new Map([
  [259992800, 'tc:IsRelateToEffect(e) and tc:IsControler(tp)'],
  [259184310, 'tc:IsRelateToEffect(e) and tc:IsControler(tp)'],
  [219826457, 'tc:IsFaceup() and tc:IsControler(tp)'],
]);

exports.corrected = (source, code) => {
  const guard = guards.get(code);
  assert(guard);
  assert.equal(source.split(guard).length, 2);
  return source.replace(guard, guard.replace(' and tc:IsControler(tp)', ''));
};
