--Terrifying Fog of the Dark Swamp
local s,id=GetID()
local SWAMP=239935101
local MSG_ID=133935102
function s.initial_effect(c)
 aux.AddCodeList(c,SWAMP)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DISABLE+CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_CHAINING)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.negcon)
 e1:SetTarget(s.negtg)
 e1:SetOperation(s.negop)
 c:RegisterEffect(e1)
 local hand=Effect.CreateEffect(c)
 hand:SetType(EFFECT_TYPE_SINGLE)
 hand:SetCode(EFFECT_TRAP_ACT_IN_HAND)
 hand:SetCondition(s.handcon)
 c:RegisterEffect(hand)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id)
 e2:SetCost(s.cost)
 e2:SetTarget(s.addtg)
 e2:SetOperation(s.addop)
 c:RegisterEffect(e2)
end
s.listed_names={SWAMP}
function s.swampfilter(c)
 return c:IsFaceup() and c:IsCode(SWAMP)
end
function s.handcon(e)
 local tp=e:GetHandlerPlayer()
 return Duel.IsExistingMatchingCard(s.swampfilter,tp,LOCATION_ONFIELD,0,1,nil)
  and Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)<Duel.GetFieldGroupCount(tp,0,LOCATION_MZONE)
end
function s.negcon(e,tp,eg,ep,ev,re)
 return re and bit.band(re:GetActivateLocation(),LOCATION_SZONE+LOCATION_GRAVE+LOCATION_REMOVED)~=0
  and Duel.IsChainDisablable(ev)
end
function s.watercard(c)
 return (c:GetOriginalType()&TYPE_MONSTER)~=0 and c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_REPTILE)
  and c:IsFaceup() and c:IsDestructable()
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.watercard,tp,LOCATION_ONFIELD,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DISABLE,eg,1,0,0)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,2,0,LOCATION_ONFIELD)
end
function s.negop(e,tp,eg,ep,ev,re)
 if not Duel.NegateEffect(ev) then return end
 local g=Group.CreateGroup()
 local rc=re:GetHandler()
 if rc:IsRelateToEffect(re) then g:AddCard(rc) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local own=Duel.SelectMatchingCard(tp,s.watercard,tp,LOCATION_ONFIELD,0,1,1,nil)
 g:Merge(own)
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToRemoveAsCost() and Duel.IsExistingMatchingCard(Card.IsAbleToRemoveAsCost,tp,LOCATION_GRAVE,0,1,c) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectMatchingCard(tp,Card.IsAbleToRemoveAsCost,tp,LOCATION_GRAVE,0,1,1,c)
 g:AddCard(c)
 Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.addfilter(c)
 return c:IsSetCard(0xa123) and c:IsType(TYPE_SPELL) and c:IsAbleToHand()
  and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
end
function s.addtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.addfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,e:GetHandler()) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED)
end
function s.addop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.addfilter),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil)
 if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
end
