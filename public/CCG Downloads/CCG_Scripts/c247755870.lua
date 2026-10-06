--Kali Yuga - Mayavada
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755870
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c)
 e0:SetDescription(aux.Stringid(MSG_ID,0))
 e0:SetCategory(CATEGORY_DESTROY+CATEGORY_HANDES)
 e0:SetType(EFFECT_TYPE_ACTIVATE)
 e0:SetCode(EVENT_FREE_CHAIN)
 e0:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e0:SetTarget(s.acttg)
 e0:SetOperation(s.desop)
 c:RegisterEffect(e0)
 local e1=e0:Clone()
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetRange(LOCATION_SZONE)
 e1:SetCondition(function(e,tp) return Duel.GetFlagEffect(tp,id)==0 end)
 e1:SetTarget(s.destg)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_PHASE+PHASE_END)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCost(s.cost)
 e2:SetTarget(s.placetg)
 e2:SetOperation(s.placeop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.oppfilter(c)
 return c:IsFaceup() and c:IsDestructable()
end
function s.ownfilter(c)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsDestructable()
end
function s.possible(e,tp)
 return Duel.GetFlagEffect(tp,id)==0 and Duel.IsExistingTarget(s.oppfilter,tp,0,LOCATION_ONFIELD,1,nil)
  and (Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>0
   or Duel.IsExistingMatchingCard(s.ownfilter,tp,LOCATION_ONFIELD,0,1,e:GetHandler()))
end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) end
 if chk==0 then return true end
 e:SetLabel(0)
 if s.possible(e,tp) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,0)) then s.destg(e,tp,eg,ep,ev,re,r,rp,1) end
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(1-tp) and chkc:IsOnField() and s.oppfilter(chkc) end
 if chk==0 then return s.possible(e,tp) end
 Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
 e:SetLabel(1)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectTarget(tp,s.oppfilter,tp,0,LOCATION_ONFIELD,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
end
function s.desop(e,tp)
 local c=e:GetHandler()
 local tc=Duel.GetFirstTarget()
 if e:GetLabel()==0 or not c:IsRelateToEffect(e) or not c:IsFaceup()
  or not tc or not tc:IsRelateToEffect(e) or Duel.Destroy(tc,REASON_EFFECT)==0 then return end
 local destroy=Duel.IsExistingMatchingCard(s.ownfilter,tp,LOCATION_ONFIELD,0,1,c)
 local discard=Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>0
 if not destroy and not discard then return end
 local option=0
 if destroy and discard then option=Duel.SelectOption(tp,aux.Stringid(MSG_ID,2),aux.Stringid(MSG_ID,3))
 elseif discard then option=1 end
 if option==1 then Duel.DiscardHand(tp,nil,1,1,REASON_EFFECT+REASON_DISCARD)
 else
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  local g=Duel.SelectMatchingCard(tp,s.ownfilter,tp,LOCATION_ONFIELD,0,1,1,c)
  if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
 end
end
function s.costfilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsAttribute(ATTRIBUTE_FIRE) and c:IsAbleToRemoveAsCost()
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_GRAVE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_GRAVE,0,1,1,nil)
 Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.placetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not e:GetHandler():IsForbidden() end
end
function s.placeop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0
  or not Duel.MoveToField(c,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then return end
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_SINGLE)
 e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
 e1:SetValue(LOCATION_REMOVED)
 e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
 c:RegisterEffect(e1,true)
end
