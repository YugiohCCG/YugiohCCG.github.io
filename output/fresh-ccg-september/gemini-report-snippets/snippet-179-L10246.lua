     if Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)>0 then
         Duel.ConfirmCards(1-tp,sc)
         Duel.Draw(1-tp,2,REASON_EFFECT)
     end
