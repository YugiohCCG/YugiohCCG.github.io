  Duel.SendtoDeck(c,1-tp,SEQ_DECKSHUFFLE,REASON_EFFECT)
  if not c:IsLocation(LOCATION_DECK) then return end
  Duel.ShuffleDeck(1-tp)
  c:ReverseInDeck()
