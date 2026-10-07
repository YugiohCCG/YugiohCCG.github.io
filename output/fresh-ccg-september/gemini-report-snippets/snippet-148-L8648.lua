     function s.setfilter(c,tp)
         local loc=(c:GetOriginalType()&TYPE_MONSTER)~=0 and LOCATION_MZONE or LOCATION_SZONE
         return c:IsFacedown() and Duel.GetLocationCount(tp,loc)>0
     end
