'use strict';
const assert = require('node:assert/strict');

exports.corrected = (source, code) => {
  assert.equal(code, 238274860);
  const start = source.indexOf('function s.thop(e,tp)');
  const end = source.indexOf('function s.matcon', start);
  assert(start >= 0 && end > start);
  const original = source.slice(start, end);
  assert(original.includes('if #g==2 then'));
  const lines = [
    'function s.thop(e,tp)',
    ' if not (Duel.IsExistingMatchingCard(s.monfilter,tp,LOCATION_DECK,0,1,nil)',
    '  and Duel.IsExistingMatchingCard(s.spellfilter,tp,LOCATION_DECK,0,1,nil)) then return end',
    ' Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)',
    ' local g=Duel.SelectMatchingCard(tp,s.monfilter,tp,LOCATION_DECK,0,1,1,nil)',
    ' Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)',
    ' g:Merge(Duel.SelectMatchingCard(tp,s.spellfilter,tp,LOCATION_DECK,0,1,1,nil))',
    ' if #g~=2 then return end',
    ' Duel.SendtoHand(g,nil,REASON_EFFECT)',
    ' local added=g:Filter(Card.IsLocation,nil,LOCATION_HAND)',
    ' if #added>0 then Duel.ConfirmCards(1-tp,added) end',
    ' if #added~=2 then return end',
    ' Duel.BreakEffect()',
    ' Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISCARD)',
    ' Duel.DiscardHand(tp,aux.TRUE,1,1,REASON_EFFECT+REASON_DISCARD)',
    'end',
    '',
  ];
  const newline = original.includes('\r\n') ? '\r\n' : '\n';
  return source.slice(0, start) + lines.join(newline) + source.slice(end);
};
