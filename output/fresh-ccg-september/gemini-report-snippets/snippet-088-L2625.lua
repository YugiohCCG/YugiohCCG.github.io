   if #gmat>0 and Duel.SendtoGrave(gmat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)==0 then ok=false end
   if ok and #banmat>0 and Duel.Remove(banmat,POS_FACEUP,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)==0 then ok=false end
