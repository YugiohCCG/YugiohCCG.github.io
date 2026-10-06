   function s.damtg(e,tp,eg,ep,ev,re,r,rp,chk)
       if chk==0 then return true end
       e:SetLabel(ev+1)
       Duel.SetOperationInfo(0,CATEGORY_DAMAGE,nil,0,1-tp,(ev+1)*200)
   end
   function s.damop(e,tp) Duel.Damage(1-tp,e:GetLabel()*200,REASON_EFFECT) end
