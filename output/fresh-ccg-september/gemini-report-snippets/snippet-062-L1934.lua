   -- Line 44
   function s.thf(c) return (c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) or c:IsSetCard(SET_WORLD_LEGACY) and c:IsType(TYPE_SPELL+TYPE_TRAP)) and not c:IsCode(id) and c:IsAbleToHand() end
   -- Line 46
   Duel.SendtoHand(sg,nil,REASON_EFFECT) -- Missing Duel.ConfirmCards(1-tp, sg)
