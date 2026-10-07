   function s.checkfilter(c)
       return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsLocation(LOCATION_DECK)
           and not c:IsPreviousLocation(LOCATION_DECK) and c:IsReason(REASON_EFFECT)
   end
