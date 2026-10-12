-- Source-only candidate; production unchanged. Public-core player Grave redirect behavior differs from current upstream; native Omega unverified.
function s.gydestination(c) if c:IsType(TYPE_TOKEN) or (c:IsType(TYPE_PENDULUM) and c:IsAbleToExtra()) then return false end if c:GetDestination()~=LOCATION_GRAVE or c:GetLeaveFieldDest()~=0 then return false end for _,re in ipairs({c:IsHasEffect(EFFECT_TO_GRAVE_REDIRECT)}) do local v=re:GetValue() if type(v)=="function" then v=v(re,c,c:GetReason()) end if bit.band(v,LOCATION_HAND)~=0 and c:IsAbleToHand(re:GetHandlerPlayer()) then return false end if bit.band(v,LOCATION_DECK)~=0 and s.playercanreceive(c,re:GetHandlerPlayer(),EFFECT_CANNOT_TO_DECK) then return false end if bit.band(v,LOCATION_REMOVED)~=0 and not c:IsHasEffect(EFFECT_CANNOT_REMOVE) and Duel.IsPlayerCanRemove(re:GetHandlerPlayer(),c,REASON_EFFECT) then return false end if bit.band(v,LOCATION_GRAVE)~=0 and s.playercanreceive(c,re:GetHandlerPlayer(),EFFECT_CANNOT_TO_GRAVE) then return true end end return true end

function s.playercanreceive(c,tp,code)
 if c:IsHasEffect(code) then return false end
 for _,re in ipairs({Duel.GetPlayerEffect(tp,code)}) do
  local f=re:GetTarget()
  if not f or f(re,c,tp,REASON_EFFECT) then return false end
 end
 return true
end
