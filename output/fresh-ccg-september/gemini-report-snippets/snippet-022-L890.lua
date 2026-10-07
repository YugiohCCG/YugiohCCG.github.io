   function s.rmcon(e,tp,eg,ep,ev,re,r,rp)
       local c=e:GetHandler()
       return c:IsSummonType(SUMMON_TYPE_SYNCHRO) and c:GetMaterial():FilterCount(aux.NOT(Card.IsSetCard),nil,0x21fc)==0
   end
