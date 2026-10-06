     function s.ovfilter(c)
         return c:IsSetCard(0x8d) and aux.NecroValleyFilter(Card.IsCanOverlay)(c)
     end
