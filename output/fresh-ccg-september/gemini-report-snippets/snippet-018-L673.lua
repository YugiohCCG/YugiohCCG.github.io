   function s.xyzctrl(c)
       return c:IsType(TYPE_XYZ)
   end
   function s.xyzalt(c,e,tp,xyzc)
       return c:IsFaceup() and c:IsSetCard(SET_STELLAER) and c:IsLevel(9)
           and not Duel.IsExistingMatchingCard(s.xyzctrl,tp,LOCATION_MZONE,0,1,nil)
   end
