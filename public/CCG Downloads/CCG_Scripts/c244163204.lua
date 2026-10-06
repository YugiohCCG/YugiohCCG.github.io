--Killamity Apparition
local s,id=GetID()
local SET_KILLAMITY=0xa120
local MSG_ID=132163204
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.revealcost)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DRAW)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCost(s.drawcost)
 e2:SetTarget(s.drawtg)
 e2:SetOperation(s.drawop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KILLAMITY}
function s.addfilter(c,attribute)
 return c:IsType(TYPE_MONSTER) and c:IsSetCard(SET_KILLAMITY) and c:GetAttribute()~=attribute and c:IsAbleToHand()
end
function s.revealfilter(c,tp)
 return c:IsType(TYPE_MONSTER) and not c:IsPublic()
  and Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil,c:GetAttribute())
end
function s.revealcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.revealfilter,tp,LOCATION_HAND,0,1,nil,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
 local g=Duel.SelectMatchingCard(tp,s.revealfilter,tp,LOCATION_HAND,0,1,1,nil,tp)
 Duel.ConfirmCards(1-tp,g)
 e:SetLabel(g:GetFirst():GetAttribute())
 Duel.ShuffleHand(tp)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.operation(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.addfilter,tp,LOCATION_DECK,0,1,1,nil,e:GetLabel())
 if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
end
function s.xyzfilter(c,tp)
 return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetRank()==12 and c:CheckRemoveOverlayCard(tp,1,REASON_COST)
end
function s.drawcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsAbleToRemoveAsCost() and Duel.IsExistingMatchingCard(s.xyzfilter,tp,LOCATION_MZONE,0,1,nil,tp) end
 Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_COST)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVEXYZ)
 local g=Duel.SelectMatchingCard(tp,s.xyzfilter,tp,LOCATION_MZONE,0,1,1,nil,tp)
 g:GetFirst():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.drawtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end
 Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,1,tp,1)
end
function s.drawop(e,tp)
 if Duel.Draw(tp,1,REASON_EFFECT)==0 then return end
 if Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD)>Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)
  and Duel.IsPlayerCanDraw(tp,1) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then Duel.Draw(tp,1,REASON_EFFECT) end
end
