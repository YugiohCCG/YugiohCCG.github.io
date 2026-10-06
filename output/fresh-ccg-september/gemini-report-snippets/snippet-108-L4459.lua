   aux.AddXyzProcedureLevelFree(c,s.xyzfilter,nil,3,3)
   c:EnableReviveLimit()
   ...
   function s.xyzfilter(c,xyzc)
       return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(9) and c:IsRace(RACE_DRAGON)
   end
