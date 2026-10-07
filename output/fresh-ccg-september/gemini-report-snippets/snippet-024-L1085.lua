   -- Line 67:
   return c:IsSummonPlayer(1-tp) and aux.GetColumn(c)==col
   -- Line 71:
   return c:IsType(TYPE_TRAP) and c:IsType(TYPE_CONTINUOUS) and eg:IsExists(s.colfilter,1,nil,tp,aux.GetColumn(c))
