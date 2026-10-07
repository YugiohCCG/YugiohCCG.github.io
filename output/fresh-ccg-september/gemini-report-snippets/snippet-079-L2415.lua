   function s.rdf(c,e) return c~=e:GetHandler() and c:IsSetCard(SET_AEROCAT) and c:IsAbleToDeck() and (c:IsLocation(LOCATION_REMOVED) or aux.NecroValleyFilter(Card.IsAbleToDeck)(c,e)) end
