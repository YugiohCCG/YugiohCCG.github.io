   for _,te in ipairs{tc:GetCardEffect()} do
       if te:GetCode()==EVENT_PHASE+PHASE_STANDBY then
           local tg=te:GetTarget()
           local op=te:GetOperation()
           if tg and not tg(te,tp,eg,ep,ev,re,r,rp,0) then return end
           tc:CreateEffectRelation(te)
           if tg then tg(te,tp,eg,ep,ev,re,r,rp,1) end
           if op then op(te,tp,eg,ep,ev,re,r,rp) end
           tc:ReleaseEffectRelation(te)
           return
       end
   end
