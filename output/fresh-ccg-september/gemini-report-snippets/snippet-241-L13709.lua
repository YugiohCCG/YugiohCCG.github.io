   if chk==0 then return ct>0 and (Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_SZONE,1,nil)
       or Duel.IsExistingMatchingCard(Card.IsAbleToHand,tp,0,LOCATION_MZONE,1,nil)) end
   local b1=Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_SZONE,1,nil)
   local b2=Duel.IsExistingMatchingCard(Card.IsAbleToHand,tp,0,LOCATION_MZONE,1,nil)
