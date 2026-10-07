     local pos=tc:IsFacedown() and POS_FACEUP_DEFENSE or POS_FACEDOWN_DEFENSE
     if Duel.ChangePosition(tc,pos)>0 then
