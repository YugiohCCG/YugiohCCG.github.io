   if chkc then return chkc:IsLocation(LOCATION_REMOVED) and chkc:IsControler(tp) and aux.NecroValleyFilter(s.thfilter2)(chkc) end
   if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.thfilter2),tp,LOCATION_REMOVED,0,1,nil) end
   Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
   local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.thfilter2),tp,LOCATION_REMOVED,0,1,1,nil)
   ...
   if tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter()(tc) then
