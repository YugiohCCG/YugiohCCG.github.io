    Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.counterfilter)
    function s.counterfilter(c)
        return not c:IsSummonLocation(LOCATION_EXTRA) or c:IsAttribute(ATTRIBUTE_WATER)
    end
    function s.splimit(e,c,sump,sumtype,sumpos,targetp,se)
        return not c:IsAttribute(ATTRIBUTE_WATER) and c:IsLocation(LOCATION_EXTRA)
    end
