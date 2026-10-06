   -- Line 96:
   return c:IsPreviousPosition(POS_FACEUP) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsSummonType(SUMMON_TYPE_XYZ)
       and rp==1-tp and c:GetPreviousControler()==tp
