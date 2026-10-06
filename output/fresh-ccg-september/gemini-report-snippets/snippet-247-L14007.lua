   function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
       if chk==0 then return Duel.IsExistingMatchingCard(s.disfilter,tp,0,LOCATION_ONFIELD,1,nil) end
       local ct=Duel.GetCurrentChain()
       e:SetLabel(ct)
       Duel.SetOperationInfo(0,CATEGORY_DISABLE,nil,1,1-tp,LOCATION_ONFIELD)
   end
