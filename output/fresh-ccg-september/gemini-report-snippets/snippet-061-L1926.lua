   -- Line 21
   if code==10698416 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.ranvier),tp,LOCATION_GRAVE,0,1,nil) end
   -- Line 34
   elseif code==10698416 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local tg=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.ranvier),tp,LOCATION_GRAVE,0,1,2,nil); Duel.SetOperationInfo(0,CATEGORY_TOHAND,tg,#tg,0,0) end
