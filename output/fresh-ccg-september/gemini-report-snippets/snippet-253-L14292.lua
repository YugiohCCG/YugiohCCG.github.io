   function s.sptg2(e,tp,eg,ep,ev,re,r,rp,chk)
       if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
           and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter2),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
