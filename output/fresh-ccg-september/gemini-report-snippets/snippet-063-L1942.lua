   local pos=Duel.SelectPosition(tp,tc,POS_FACEUP_ATTACK+POS_FACEDOWN_DEFENSE); if Duel.SpecialSummon(tc,0,tp,tp,false,false,pos)>0 and tc:IsFacedown() then Duel.ConfirmCards(1-tp,tc) end
