   function s.chainop(e,tp,eg,ep,ev)
       if ev<3 then return end
       for p=0,1 do if Duel.IsExistingMatchingCard(s.linkfilter,p,LOCATION_MZONE,0,1,nil) then Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1) end end
   end
