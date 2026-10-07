   function s.boosttg(e,tp,eg,ep,ev,re,r,rp,chk)
       if chk==0 then return Duel.IsExistingMatchingCard(s.scarmon,tp,LOCATION_MZONE,0,1,nil) end
       e:SetLabel(Duel.GetCurrentChain()*100)
   end
