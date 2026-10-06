--Kali Yuga - Yajna
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755867
function s.initial_effect(c)
 local a=Effect.CreateEffect(c)
 a:SetType(EFFECT_TYPE_ACTIVATE)
 a:SetCode(EVENT_FREE_CHAIN)
 c:RegisterEffect(a)
 local e0=Effect.CreateEffect(c)
 e0:SetType(EFFECT_TYPE_FIELD)
 e0:SetCode(EFFECT_UPDATE_ATTACK)
 e0:SetRange(LOCATION_SZONE)
 e0:SetTargetRange(LOCATION_MZONE,0)
 e0:SetTarget(function(e,c) return c:IsSetCard(SET_KALI_YUGA) end)
 e0:SetValue(300)
 c:RegisterEffect(e0)
 local d=e0:Clone()
 d:SetCode(EFFECT_UPDATE_DEFENSE)
 c:RegisterEffect(d)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_DRAW)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_SZONE)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.drawtg)
 e1:SetOperation(s.drawop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.settg)
 e2:SetOperation(s.setop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.desfilter(c)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsDestructable()
end
function s.drawtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDraw(tp,1)
  and Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND+LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,1,tp,1)
end
function s.drawop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsFaceup() then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,nil)
 if #g>0 and Duel.Destroy(g,REASON_EFFECT)>0 then Duel.Draw(tp,1,REASON_EFFECT) end
end
function s.setfilter(c,tp)
 return s.desfilter(c) and (Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  or c:IsLocation(LOCATION_SZONE) and c:GetSequence()<5)
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsOnField() and s.setfilter(chkc,tp) end
 if chk==0 then return not e:GetHandler():IsForbidden()
  and Duel.IsExistingTarget(s.setfilter,tp,LOCATION_ONFIELD,0,1,nil,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectTarget(tp,s.setfilter,tp,LOCATION_ONFIELD,0,1,1,nil,tp)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
end
function s.setop(e,tp)
 local c=e:GetHandler()
 local tc=Duel.GetFirstTarget()
 if not c:IsRelateToEffect(e) or not tc or not tc:IsRelateToEffect(e)
  or Duel.Destroy(tc,REASON_EFFECT)==0 or Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 or not c:IsSSetable() then return end
 if Duel.SSet(tp,c)>0 then
  local e1=Effect.CreateEffect(c)
  e1:SetType(EFFECT_TYPE_SINGLE)
  e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
  e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
  e1:SetValue(LOCATION_REMOVED)
  e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
  c:RegisterEffect(e1,true)
 end
end
