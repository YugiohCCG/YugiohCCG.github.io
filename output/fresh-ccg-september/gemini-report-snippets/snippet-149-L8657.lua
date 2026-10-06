     local loc=(tc:GetOriginalType()&TYPE_MONSTER)~=0 and LOCATION_MZONE or LOCATION_SZONE
     local pos=(loc==LOCATION_MZONE) and POS_FACEDOWN_DEFENSE or POS_FACEDOWN
     Duel.MoveToField(tc,tp,tp,loc,pos,true)
