--Kali Yuga - Vritra
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755864
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_MZONE)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.sstg)
 e1:SetOperation(s.ssop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_HANDES)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_TO_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.revcon)
 e2:SetTarget(s.revtg)
 e2:SetOperation(s.revop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.ssfilter(c,e,tp)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_ATTACK)
end
function s.sstg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsDestructable() and Duel.GetMZoneCount(tp,c)>0
  and Duel.IsExistingMatchingCard(s.ssfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,c,1,0,0)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.ssop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.Destroy(c,REASON_EFFECT)==0 or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.ssfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp)
 if #g>0 then Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP_ATTACK) end
end
function s.revcon(e)
 local c=e:GetHandler()
 return c:IsReason(REASON_DESTROY) and (c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT))
end
function s.revtg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
 local rc=c:GetReasonCard()
 local dre=c:GetReasonEffect()
 e:SetLabel((rc and rc:IsCode(id) or dre and dre:GetHandler():IsCode(id)) and 1 or 0)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.revop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 and e:GetLabel()==1 then
  Duel.DiscardHand(tp,nil,1,1,REASON_EFFECT+REASON_DISCARD)
 end
end
