   if chk==0 then return Duel.IsExistingTarget(s.protfilter,tp,LOCATION_MZONE,0,1,nil) end
   Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
   Duel.SelectTarget(tp,s.protfilter,tp,LOCATION_MZONE,0,1,1,nil)
