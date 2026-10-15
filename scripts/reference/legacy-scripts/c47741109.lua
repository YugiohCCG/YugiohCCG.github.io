--Official Sylvan Snapdrassin with custom excavation-send integration.
Duel.LoadScript("ccg_sylvan.lua")
local s,id=GetID()
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(id,0))
 e1:SetCategory(CATEGORY_DECKDES)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetCode(EVENT_TO_GRAVE)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCondition(s.condition)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
end
function s.condition(e)
 local c=e:GetHandler()
 return c:IsPreviousLocation(LOCATION_HAND+LOCATION_ONFIELD)
  or (c:IsPreviousLocation(LOCATION_DECK) and c:IsReason(REASON_REVEAL))
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDiscardDeck(tp,1) end
end
function s.operation(e,tp)
 if Duel.IsPlayerCanDiscardDeck(tp,1) then CCGSylvan.Excavate(e,tp,1) end
end
