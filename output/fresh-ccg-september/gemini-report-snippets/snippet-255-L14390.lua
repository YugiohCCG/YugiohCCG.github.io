   function s.spcon(e,c)
       if c==nil then return true end
       local tp=c:GetControler()
       local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.rmfilter),tp,LOCATION_GRAVE,0,c)
       return #g>=3 and g:CheckSubGroup(s.rescon,3,3)
   end
