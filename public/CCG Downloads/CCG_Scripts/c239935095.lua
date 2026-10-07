--Fierce Snake of the Swamp
local s,id=GetID()
local SWAMP=239935101
local MSG_ID=133935095
function s.initial_effect(c)
 aux.AddCodeList(c,SWAMP)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOGRAVE)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.cost)
 e1:SetTarget(s.sendtg)
 e1:SetOperation(s.sendop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.destg)
 e2:SetOperation(s.desop)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EVENT_TO_GRAVE)
 e3:SetCondition(s.sendcon)
 c:RegisterEffect(e3)
end
s.listed_names={SWAMP}
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsDiscardable() end
 Duel.SendtoGrave(e:GetHandler(),REASON_COST+REASON_DISCARD)
end
function s.sendfilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsRace(RACE_REPTILE) and c:IsAttribute(ATTRIBUTE_WATER)
  and not c:IsCode(id) and c:IsAbleToGrave()
end
function s.sendtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.sendop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
 local g=Duel.SelectMatchingCard(tp,s.sendfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 then Duel.SendtoGrave(g,REASON_EFFECT) end
end
function s.sendcon(e,tp,eg,ep,ev,re,r,rp)
 if not re then return false end
 local rc=re:GetHandler()
 --Pinned roster fallback supports mentioned cards whose scripts are not authored yet.
 local mentions=aux.IsCodeListed(rc,SWAMP) or rc:IsCode(239935093,239935094,239935095,239935096,239935097,239935099,239935100,239935101,239935102)
 return mentions and not rc:IsCode(id)
end
function s.desfilter(c)
 return c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsOnField() and s.desfilter(chkc) end
 if chk==0 then return Duel.IsExistingTarget(s.desfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectTarget(tp,s.desfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
 if Duel.IsExistingMatchingCard(s.swampfilter,tp,LOCATION_ONFIELD+LOCATION_GRAVE,0,1,nil) then
  local tc=g:GetFirst()
  Duel.SetChainLimit(function(re,rp,tp) return rp==tp or re:GetHandler()~=tc end)
 end
end
function s.swampfilter(c)
 return c:IsCode(SWAMP) and (c:IsLocation(LOCATION_GRAVE) or c:IsFaceup())
end
function s.desop(e,tp)
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end
end
