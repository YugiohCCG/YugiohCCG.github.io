   function s.spcon1(e,c)
       if c==nil then return true end
       if c:IsHasEffect(EFFECT_NECRO_VALLEY) then return false end
       local tp=c:GetControler()
       return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
           and Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_AQUA) end,tp,LOCATION_MZONE,0,1,nil)
   end
