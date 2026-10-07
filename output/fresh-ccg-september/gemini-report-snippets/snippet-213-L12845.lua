   e1:SetCountLimit(1,id)
   ...
   if chk==0 then return max_uses>0 and Duel.GetFlagEffect(tp,id)<max_uses end
   Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
