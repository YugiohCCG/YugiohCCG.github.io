     function s.xyzfilter(c)
         return c:IsFaceup() and c:IsSetCard(0x8d) and c:IsType(TYPE_XYZ)
     end
     function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
         if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(tp) and s.xyzfilter(chkc) end
         if chk==0 then return Duel.IsExistingTarget(s.xyzfilter,tp,LOCATION_MZONE,0,1,nil) end
         ...
     end
     function s.ovop(e,tp,eg,ep,ev,re,r,rp)
         local c=e:GetHandler()
         local tc=Duel.GetFirstTarget()
         if c:IsRelateToEffect(e) and tc:IsRelateToEffect(e) and not tc:IsImmuneToEffect(e) then
             Duel.Overlay(tc,Group.FromCards(c))
             -- quick effect flag stub...
         end
     end
