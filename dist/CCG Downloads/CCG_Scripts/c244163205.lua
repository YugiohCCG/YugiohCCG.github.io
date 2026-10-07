--Killamity Showdown
local s,id=GetID()
local SET_KILLAMITY=0xa120
local MSG_ID=132163205
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DISABLE)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.negcon)
 e2:SetCost(s.negcost)
 e2:SetTarget(s.negtg)
 e2:SetOperation(s.negop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KILLAMITY}
function s.xyzfilter(c)
 return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetRank()==12
end
function s.materialmatch(c,victim)
 return c:IsType(TYPE_MONSTER) and (c:IsRace(victim:GetRace()) or c:IsAttribute(victim:GetAttribute()))
end
function s.holdermatch(c,victim)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:GetOverlayGroup():IsExists(s.materialmatch,1,nil,victim)
end
function s.victimfilter(c,tp)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and Duel.IsExistingMatchingCard(s.holdermatch,tp,LOCATION_MZONE,0,1,nil,c)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_MZONE) and s.victimfilter(chkc,tp) end
 if chk==0 then return Duel.IsExistingMatchingCard(s.xyzfilter,tp,LOCATION_MZONE,0,1,nil)
  and Duel.IsExistingTarget(s.victimfilter,tp,0,LOCATION_MZONE,1,nil,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
 Duel.SelectTarget(tp,s.victimfilter,tp,0,LOCATION_MZONE,1,1,nil,tp)
end
function s.operation(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) or not tc:IsControler(1-tp) or not tc:IsLocation(LOCATION_MZONE) or tc:IsImmuneToEffect(e) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SELECT)
 local g=Duel.SelectMatchingCard(tp,s.xyzfilter,tp,LOCATION_MZONE,0,1,1,nil)
 if #g>0 then Duel.Overlay(g:GetFirst(),Group.FromCards(tc)) end
end
function s.negcon(e)
 return Duel.IsExistingMatchingCard(function(c) return s.xyzfilter(c) and c:IsSetCard(SET_KILLAMITY) end,e:GetHandlerPlayer(),LOCATION_MZONE,0,1,nil)
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsAbleToRemoveAsCost() end
 Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_COST)
end
function s.negfilter(c)
 return c:IsFaceup() and not c:IsDisabled()
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.negfilter,tp,0,LOCATION_ONFIELD,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DISABLE,nil,1,1-tp,LOCATION_ONFIELD)
end
function s.negop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
 local g=Duel.SelectMatchingCard(tp,s.negfilter,tp,0,LOCATION_ONFIELD,1,1,nil)
 local tc=g:GetFirst()
 if not tc or tc:IsImmuneToEffect(e) then return end
 Duel.NegateRelatedChain(tc,RESET_TURN_SET)
 local disable=Effect.CreateEffect(e:GetHandler())
 disable:SetType(EFFECT_TYPE_SINGLE)
 disable:SetCode(EFFECT_DISABLE)
 disable:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
 tc:RegisterEffect(disable)
 local effects=disable:Clone()
 effects:SetCode(EFFECT_DISABLE_EFFECT)
 tc:RegisterEffect(effects)
end
