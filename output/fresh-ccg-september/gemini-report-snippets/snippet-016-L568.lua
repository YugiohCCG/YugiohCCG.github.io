   function s.syntg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
       if chkc then return chkc:IsLocation(LOCATION_GRAVE) and chkc:IsControler(tp) and aux.NecroValleyFilter(s.spfilter2)(chkc,e,tp) end
       if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
           and Duel.IsExistingTarget(aux.NecroValleyFilter(s.spfilter2),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
       Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
       local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.spfilter2),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
       Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,1,0,0)
   end
