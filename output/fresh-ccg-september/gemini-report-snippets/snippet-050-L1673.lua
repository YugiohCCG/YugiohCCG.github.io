   -- Line 15:
   function s.bpcon(e,tp,eg,ep,ev,re,r,rp) local bc=e:GetHandler():GetBattleTarget(); return Duel.GetTurnPlayer()==1-tp and bc~=nil and eg:IsContains(bc) end
