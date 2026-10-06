    Duel.SetChainLimit(s.chainlm)
    function s.chainlm(e,rp,tp)
        return tp==rp or not e:IsMonsterEffect()
    end
