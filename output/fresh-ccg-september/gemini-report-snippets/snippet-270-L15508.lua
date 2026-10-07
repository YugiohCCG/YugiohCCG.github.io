   local flag=Duel.SelectDisableField(tp,1,0,LOCATION_MZONE+LOCATION_SZONE,0)
   local bitpos=math.floor(math.log(flag/0x10000,2)+0.5)
   local seq=bitpos>=8 and bitpos-8 or bitpos
   local g=Duel.GetMatchingGroup(function(c,sq) return c:GetSequence()<=4 and math.abs(c:GetSequence()-sq)<=1 and c:IsDestructable() end,tp,0,LOCATION_MZONE+LOCATION_SZONE,nil,seq)
