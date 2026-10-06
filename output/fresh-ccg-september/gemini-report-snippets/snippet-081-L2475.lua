   function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
       local ct=Duel.GetCurrentChain()
       if chk==0 then
           ct=ct+1
           return Duel.GetMatchingGroupCount(Card.IsDestructable,tp,0,LOCATION_ONFIELD,nil)>=ct
       end
       e:SetLabel(ct)
       Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,ct,1-tp,LOCATION_ONFIELD)
   end
