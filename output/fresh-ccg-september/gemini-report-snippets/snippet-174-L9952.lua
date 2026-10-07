     if tc:IsRelateToEffect(e) and tc:IsFaceup() and tc:IsAbleToRemove() then
         Duel.NegateRelatedChain(tc,RESET_TURN_SET)
         ...
         Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)
     end
