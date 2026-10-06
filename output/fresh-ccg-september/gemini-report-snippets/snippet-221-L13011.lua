    local mg1=Duel.GetFusionMaterial(tp):Filter(s.filter1,nil,e)
    local mg2=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.filter3),tp,LOCATION_GRAVE,0,nil)
    mg1:Merge(mg2)
