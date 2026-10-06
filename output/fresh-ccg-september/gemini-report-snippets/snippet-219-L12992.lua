   function s.ffilter1(c,e)
       return c:IsAbleToRemove() and not c:IsImmuneToEffect(e)
   end
