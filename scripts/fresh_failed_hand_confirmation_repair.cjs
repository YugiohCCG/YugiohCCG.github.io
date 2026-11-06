'use strict';
const assert = require('node:assert/strict');

exports.corrected = (source, code) => {
  assert.equal(code, 223770816);
  const pair = /Duel\.SendtoHand\(tc,nil,REASON_EFFECT\)(\r?\n)([\t ]*)Duel\.ConfirmCards\(1-tp,tc\)/g;
  assert.equal([...source.matchAll(pair)].length, 1);
  return source.replace(pair, (_, newline, indent) =>
    'if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_HAND) then'
      + newline + indent + '\tDuel.ConfirmCards(1-tp,tc)'
      + newline + indent + 'end');
};
