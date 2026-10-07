--Kali Yuga - Murugan
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755869
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetRange(LOCATION_HAND+LOCATION_MZONE)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.sstg)
 e1:SetOperation(s.ssop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND+CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_DESTROYED)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id)
 e2:SetCondition(s.retcon)
 e2:SetTarget(s.rettg)
 e2:SetOperation(s.retop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.ssfilter(c,e,tp)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_ATTACK)
end
function s.sstg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 local c=e:GetHandler()
 local hand=c:IsLocation(LOCATION_HAND)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and s.ssfilter(chkc,e,tp) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>(hand and 1 or 0)
  and (not hand or c:IsCanBeSpecialSummoned(e,0,tp,false,false))
  and Duel.IsExistingTarget(aux.NecroValleyFilter(s.ssfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
 e:SetLabel(hand and 1 or 0)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.ssfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
 if hand then g:AddCard(c) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,#g,tp,0)
end
function s.ssop(e,tp)
 local c=e:GetHandler()
 local tc=Duel.GetFirstTarget()
 local summoned=false
 if tc and tc:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK) then
  summoned=true
  local neg=Effect.CreateEffect(c)
  neg:SetType(EFFECT_TYPE_SINGLE)
  neg:SetCode(EFFECT_DISABLE)
  neg:SetReset(RESET_EVENT+RESETS_STANDARD)
  tc:RegisterEffect(neg)
  local ne=neg:Clone()
  ne:SetCode(EFFECT_DISABLE_EFFECT)
  tc:RegisterEffect(ne)
 end
 if e:GetLabel()==1 and c:IsRelateToEffect(e) and c:IsLocation(LOCATION_HAND)
  and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.SpecialSummonStep(c,0,tp,tp,false,false,POS_FACEUP) then summoned=true end
 if summoned then Duel.SpecialSummonComplete() end
end
function s.destroyed(c,tp)
 return c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousControler(tp)
  and c:IsPreviousSetCard(SET_KALI_YUGA)
  and bit.band(c:GetPreviousTypeOnField(),TYPE_MONSTER)~=0
  and (c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT))
end
function s.retcon(e,tp,eg)
 return eg:IsExists(s.destroyed,1,nil,tp)
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToHand() and (c:IsDestructable() or Duel.CheckLPCost(tp,2000)
  or Duel.IsExistingMatchingCard(Card.IsDestructable,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil)) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,c,1,tp,LOCATION_GRAVE)
end
function s.retop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.SendtoHand(c,nil,REASON_EFFECT)==0 then return end
 Duel.ConfirmCards(1-tp,c)
 local destroy=Duel.IsExistingMatchingCard(Card.IsDestructable,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil)
 local pay=Duel.CheckLPCost(tp,2000)
 if not destroy and not pay then return end
 local option=0
 if destroy and pay then option=Duel.SelectOption(tp,aux.Stringid(MSG_ID,2),aux.Stringid(MSG_ID,3))
 elseif pay then option=1 end
 if option==1 then Duel.PayLPCost(tp,2000)
 else
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
  local g=Duel.SelectMatchingCard(tp,Card.IsDestructable,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,nil)
  if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
 end
end
