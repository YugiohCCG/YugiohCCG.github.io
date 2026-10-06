   function s.mzonecheck(tp,c)
       return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
           or (c and c:IsLocation(LOCATION_MZONE) and c:GetSequence()<5)
   end
