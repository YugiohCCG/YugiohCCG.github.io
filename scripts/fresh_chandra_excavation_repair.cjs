'use strict';
const assert = require('node:assert/strict');

exports.corrected = (source, code) => {
  assert.equal(code, 259126370);
  const guard = 'Duel.ConfirmCards(1-tp,sg)\n\tDuel.ShuffleDeck(tp)';
  assert.equal(source.split(guard).length, 2);
  const add = 'Duel.SendtoHand(sg,nil,REASON_EFFECT)';
  assert.equal(source.split(add).length, 2);
  return source.replace(add, 'if Duel.SendtoHand(sg,nil,REASON_EFFECT)~=2 then return end').replace(guard, 'Duel.ConfirmCards(1-tp,sg)\n\tif #g>#sg then Duel.ShuffleDeck(tp) end');
};
