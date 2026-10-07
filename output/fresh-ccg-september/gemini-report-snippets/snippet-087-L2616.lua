   function s.fusfilter(c,e,tp,mg,chkf)
       return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_FUSION)
           and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
           and c:CheckFusionMaterial(mg,nil,chkf)
   end
