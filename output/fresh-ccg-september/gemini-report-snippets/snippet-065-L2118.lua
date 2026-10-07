   if op==0 then ok=Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 else ok=Duel.Remove(c,POS_FACEUP,REASON_EFFECT)>0 end
