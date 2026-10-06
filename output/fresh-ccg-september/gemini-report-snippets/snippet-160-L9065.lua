     function s.selfsetfilter(c)
         return c:IsSetCard(0x8d) and c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsCode(id) and c:IsSSetable()
     end
