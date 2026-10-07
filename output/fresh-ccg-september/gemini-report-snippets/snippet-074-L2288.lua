   -- Line 29
   function s.spfilter(c,e,tp) return c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_LINK) and c:IsLink(2) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
   -- Line 30
   function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return (e:GetHandler():IsAbleToDeck() or e:GetHandler():IsAbleToRemove()) and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp) end end
