   function s.contactfilter(c)
       return s.matfilter(c) and c:IsAbleToDeckAsCost()
   end
