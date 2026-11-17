--Terrarumian Misting
--Omega reference: c213849997 (targeted face-up negation).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_DISABLE)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
end
function s.ownfilter(c)
 return c:IsFaceup() and c:IsType(TYPE_PENDULUM)
  and c:IsSetCard(SET_TERRARUMIAN) and c:IsDestructable()
end
function s.oppfilter(c,e)
 return c:IsFaceup() and c:IsCanBeEffectTarget(e)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(1-tp) and chkc:IsOnField()
  and s.oppfilter(chkc,e) end
 local own=Duel.GetMatchingGroupCount(s.ownfilter,tp,LOCATION_MZONE,0,nil)
 if chk==0 then return own>0 and Duel.IsExistingTarget(s.oppfilter,tp,0,LOCATION_ONFIELD,1,nil,e) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
 local g=Duel.SelectTarget(tp,s.oppfilter,tp,0,LOCATION_ONFIELD,1,own,nil,e)
 e:SetLabel(#g)
 g:KeepAlive()
 e:SetLabelObject(g)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,#g,tp,LOCATION_MZONE)
 Duel.SetOperationInfo(0,CATEGORY_DISABLE,g,#g,0,0)
end
function s.operation(e,tp)
 local count=e:GetLabel()
 local stored=e:GetLabelObject()
 local targets=stored and stored:Filter(s.relatedfaceup,nil,e) or Group.CreateGroup()
 if stored then stored:DeleteGroup() end
 e:SetLabelObject(nil)
 local own=Duel.GetMatchingGroup(s.ownfilter,tp,LOCATION_MZONE,0,nil)
 if count<=0 or #own==0 then return end
 local n=math.min(count,#own)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local selected=own:Select(tp,n,n,nil)
 if #selected==0 or Duel.Destroy(selected,REASON_EFFECT)~=count then return end
 local tc=targets:GetFirst()
 while tc do
  if tc:IsCanBeDisabledByEffect(e,false) then
   Duel.NegateRelatedChain(tc,RESET_TURN_SET)
   local disable=Effect.CreateEffect(e:GetHandler())
   disable:SetType(EFFECT_TYPE_SINGLE)
   disable:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
   disable:SetCode(EFFECT_DISABLE)
   disable:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
   tc:RegisterEffect(disable)
   local disable_effect=disable:Clone()
   disable_effect:SetCode(EFFECT_DISABLE_EFFECT)
   disable_effect:SetValue(RESET_TURN_SET)
   tc:RegisterEffect(disable_effect)
  end
  tc=targets:GetNext()
 end
end
function s.relatedfaceup(c,e)
 return c:IsRelateToEffect(e) and c:IsFaceup()
end
