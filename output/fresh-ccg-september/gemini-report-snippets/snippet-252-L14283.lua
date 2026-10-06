   function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
       local c=e:GetHandler()
       if chk==0 then return c:IsAbleToGraveAsCost() end
       Duel.SendtoGrave(c,REASON_COST)
   end
