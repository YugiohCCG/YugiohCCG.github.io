--Azale, the Sylvan High Sovereign
local s,id=GetID()
local MSG_ID=132276580
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddXyzProcedure(c,nil,8,3)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCountLimit(1,id)
 e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_XYZ) end)
 e1:SetCost(s.cost)
 e1:SetTarget(s.target)
 e1:SetOperation(s.operation)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetType(EFFECT_TYPE_SINGLE)
 e2:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
 e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
 e2:SetRange(LOCATION_MZONE)
 e2:SetValue(aux.tgoval)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_DESTROY)
 e3:SetType(EFFECT_TYPE_QUICK_O)
 e3:SetCode(EVENT_FREE_CHAIN)
 e3:SetRange(LOCATION_MZONE)
 e3:SetCountLimit(1,id+100)
 e3:SetCondition(function(e,tp) return Duel.GetTurnPlayer()~=tp end)
 e3:SetTarget(s.quicktg)
 e3:SetOperation(s.quickop)
 c:RegisterEffect(e3)
end
s.listed_series={0x90}
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return true end
 local ct=c:GetOverlayCount()
 e:SetLabel(ct>0 and c:RemoveOverlayCard(tp,0,ct,REASON_COST) or 0)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)>0 end
end
function s.plant(c)
 return c:IsType(TYPE_MONSTER) and c:IsRace(RACE_PLANT)
end
function s.spfilter(c,e,tp)
 return c:IsType(TYPE_MONSTER) and c:IsSetCard(0x90) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.operation(e,tp)
 local n=math.min(e:GetLabel(),Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
 if n==0 then return end
 Duel.ConfirmDecktop(tp,n)
 local g=Duel.GetDecktopGroup(tp,n)
 local ct=math.min(g:FilterCount(s.plant,nil),Duel.GetLocationCount(tp,LOCATION_MZONE))
 if Duel.IsPlayerAffectedByEffect(tp,59822133) then ct=math.min(ct,1) end
 if ct>0 then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
  local sg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,0,ct,nil,e,tp)
  if #sg>0 then Duel.SpecialSummon(sg,0,tp,tp,false,false,POS_FACEUP) end
 end
 --Each excavated card may be placed on either end, with both groups ordered.
 g=g:Filter(Card.IsLocation,nil,LOCATION_DECK)
 if #g==0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,aux.Stringid(MSG_ID,2))
 local top=g:Select(tp,0,#g,nil)
 local bottom=g:Clone()
 bottom:Sub(top)
 Duel.DisableShuffleCheck()
 s.orderbottom(bottom,tp)
 if #top>1 then Duel.SortDecktop(tp,tp,#top) end

end
function s.quicktg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)>0
  and Duel.IsExistingMatchingCard(Card.IsDestructable,tp,0,LOCATION_ONFIELD,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,1-tp,LOCATION_ONFIELD)
end
function s.quickop(e,tp)
 local total=Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)
 local g=Group.CreateGroup()
 for n=1,total do
  local ng=Duel.GetDecktopGroup(tp,n)
  local last=ng:Clone()
  last:Sub(g)
  g=ng
  if not s.plant(last:GetFirst()) then break end
 end
 if #g==0 then return end
 Duel.ConfirmDecktop(tp,#g)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local dg=Duel.SelectMatchingCard(tp,Card.IsDestructable,tp,0,LOCATION_ONFIELD,0,#g,nil)
 if #dg>0 then Duel.Destroy(dg,REASON_EFFECT) end
 g=g:Filter(Card.IsLocation,nil,LOCATION_DECK)
 Duel.DisableShuffleCheck()
 s.orderbottom(g,tp)
end

--Omega ordering pattern: order on top, then move each card to the bottom.
function s.orderbottom(g,tp)
 if #g==0 then return end
 for tc in aux.Next(g) do Duel.MoveSequence(tc,SEQ_DECKTOP) end
 if #g>1 then Duel.SortDecktop(tp,tp,#g) end
 for i=1,#g do
  local tc=Duel.GetDecktopGroup(tp,1):GetFirst()
  Duel.MoveSequence(tc,SEQ_DECKBOTTOM)
 end
end
