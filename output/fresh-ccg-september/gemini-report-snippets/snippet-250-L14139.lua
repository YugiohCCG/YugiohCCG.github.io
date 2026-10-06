   function s.descost(e,tp,eg,ep,ev,re,r,rp,chk)
       if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_MZONE,0,1,nil) end
       Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
       local tc=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_MZONE,0,1,1,nil):GetFirst()
       Duel.SendtoHand(tc,nil,REASON_COST)
   end
