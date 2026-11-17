--Killamity Pine
local s,id=GetID()
local MSG_ID=132163200
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.handcon)
 e1:SetTarget(s.handtg)
 e1:SetOperation(s.handop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,2))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_LEAVE_FIELD)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.revivecon)
 e2:SetTarget(s.revivetg)
 e2:SetOperation(s.reviveop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetType(EFFECT_TYPE_XMATERIAL)
 e3:SetCode(EFFECT_ATTACK_ALL)
 e3:SetCondition(function(e) return e:GetHandler():IsType(TYPE_XYZ) and e:GetHandler():GetRank()==12 end)
 e3:SetValue(1)
 c:RegisterEffect(e3)
end
s.listed_series={0xa120}
function s.levelrank(c)
 return c:IsFaceup() and ((c:IsType(TYPE_XYZ) and c:GetRank()==12) or (not c:IsType(TYPE_XYZ) and c:GetLevel()==12))
end
function s.handcon(e,tp)
 return Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)==0 or Duel.IsExistingMatchingCard(s.levelrank,tp,LOCATION_MZONE,0,1,nil)
end
function s.handtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
end
function s.xyzfilter(c,mg)
 return c:IsType(TYPE_XYZ) and c:GetRank()==12 and c:IsXyzSummonable(mg)
end
function s.handop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 or Duel.GetTurnPlayer()~=tp then return end
 local mg=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil)
 local g=Duel.GetMatchingGroup(s.xyzfilter,tp,LOCATION_EXTRA,0,nil,mg)
 if #g>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,1)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
  local tc=g:Select(tp,1,1,nil):GetFirst()
  Duel.XyzSummon(tp,tc,mg)
 end
end
function s.leavefilter(c,tp)
 return c:IsPreviousLocation(LOCATION_MZONE) and bit.band(c:GetPreviousTypeOnField(),TYPE_XYZ)~=0
  and c:GetPreviousRankOnField()==12 and c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp
end
function s.revivecon(e,tp,eg)
 return eg:IsExists(s.leavefilter,1,nil,tp)
end
function s.revivefilter(c,e,tp)
 return c:IsType(TYPE_XYZ) and c:GetRank()==12 and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.revivetg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>=2 and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.revivefilter),tp,LOCATION_GRAVE,0,1,c,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,tp,LOCATION_GRAVE)
end
function s.reviveop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<2 or not c:IsCanBeSpecialSummoned(e,0,tp,false,false) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.revivefilter),tp,LOCATION_GRAVE,0,1,1,c,e,tp):GetFirst()
 if not tc then return end
 local g=Group.FromCards(c,tc)
 for sc in aux.Next(g) do
  if Duel.SpecialSummonStep(sc,0,tp,tp,false,false,POS_FACEUP) then
   local e1=Effect.CreateEffect(c)
   e1:SetType(EFFECT_TYPE_SINGLE)
   e1:SetCode(EFFECT_DISABLE)
   e1:SetReset(RESET_EVENT+RESETS_STANDARD)
   sc:RegisterEffect(e1)
   local e2=e1:Clone()
   e2:SetCode(EFFECT_DISABLE_EFFECT)
   sc:RegisterEffect(e2)
  end
 end
 Duel.SpecialSummonComplete()
end
