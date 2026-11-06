--Over Skull from Underroot
--Omega patterns: c14391625 (conditional non-Tuner), c100211050 (banish-as-cost).
local s,id=GetID()
local SET_UNDERROOT=0xA111
local SET_RROOT=0xA110
local MSG_ID=132272437
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND+LOCATION_MZONE)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.spcost)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SUMMON_SUCCESS)
 e2:SetRange(LOCATION_MZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.lvcon)
 e2:SetOperation(s.lvop)
 c:RegisterEffect(e2)
 local e3=e2:Clone()
 e3:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,2))
 e4:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY)
 e4:SetCode(EVENT_MOVE)
 e4:SetCountLimit(1,id+200)
 e4:SetCondition(s.gravecon)
 e4:SetTarget(s.rettg)
 e4:SetOperation(s.retop)
 c:RegisterEffect(e4)
 local e5=e4:Clone()
 e5:SetCode(EVENT_TO_HAND)
 e5:SetCondition(s.handcon)
 c:RegisterEffect(e5)
end
function s.spfilter(c,e,tp)
 return c:IsSetCard(SET_UNDERROOT) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToRemoveAsCost() end
 Duel.Remove(c,POS_FACEUP,REASON_COST)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.spop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or not Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_DECK,0,1,nil,e,tp) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp)
 local tc=g:GetFirst()
 if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
end
function s.lvfilter(c,tp)
 return c:IsFaceup() and c:IsControler(tp) and c:IsSetCard(SET_UNDERROOT)
end
function s.lvcon(e,tp,eg)
 return eg:IsExists(s.lvfilter,1,nil,tp)
end
function s.ntval(e,sc)
 return sc and sc:IsSetCard(SET_RROOT)
end
function s.lvop(e,tp)
 local c=e:GetHandler()
 if not c:IsFaceup() or not c:IsRelateToEffect(e) then return end
 local options={0}
 if c:GetLevel()>1 then options[#options+1]=1 end
 if c:GetLevel()>2 then options[#options+1]=2 end
 local n=Duel.AnnounceNumber(tp,table.unpack(options))
 if n>0 then
  local lv=Effect.CreateEffect(c)
  lv:SetType(EFFECT_TYPE_SINGLE)
  lv:SetCode(EFFECT_UPDATE_LEVEL)
  lv:SetValue(-n)
  lv:SetReset(RESET_EVENT+RESETS_STANDARD)
  c:RegisterEffect(lv)
 end
 if Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then
  local nt=Effect.CreateEffect(c)
  nt:SetType(EFFECT_TYPE_SINGLE)
  nt:SetCode(EFFECT_NONTUNER)
  nt:SetValue(s.ntval)
  nt:SetReset(RESET_EVENT+RESETS_STANDARD)
  c:RegisterEffect(nt)
 end
end
function s.gravecon(e,tp)
 local c=e:GetHandler()
 return c:IsPreviousLocation(LOCATION_REMOVED) and c:IsLocation(LOCATION_GRAVE)
end
function s.handcon(e,tp)
 local c=e:GetHandler()
 return c:IsPreviousLocation(LOCATION_REMOVED) and c:IsLocation(LOCATION_HAND)
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,c:GetLocation())
end
function s.retop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
 end
end
