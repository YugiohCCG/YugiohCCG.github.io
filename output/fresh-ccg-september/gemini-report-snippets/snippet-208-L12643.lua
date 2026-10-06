    function c39015.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
        if chk==0 then return Duel.GetMZoneCount(tp,e:GetHandler())>0
            and Duel.IsExistingMatchingCard(c39015.spfilter,tp,LOCATION_HAND+LOCATION_DECK,0,1,nil,e,tp) end
        Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_DECK)
    end
