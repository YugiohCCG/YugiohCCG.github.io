--Sylvan Goleaf
-- Standalone helper: Omega installs card scripts only.
if type(CCGSylvan)~="table" then
--Shared handling for the custom Sylvan excavation instructions.
CCGSylvan={}
function CCGSylvan.Plant(c)
 return c:IsType(TYPE_MONSTER) and c:IsRace(RACE_PLANT)
end
function CCGSylvan.ForcedSend(c,e)
 return e:GetHandler():IsSetCard(0x90) and c:IsCode(238276575,238276576,238276577)
end
function CCGSylvan.Excavate(e,tp,ct,addmax)
 Duel.ConfirmDecktop(tp,ct)
 local g=Duel.GetDecktopGroup(tp,ct)
 local first=g:GetFirst()
 local lv=first and CCGSylvan.Plant(first) and first:GetLevel() or 0
 local sends=g:Filter(function(c) return CCGSylvan.Plant(c) or CCGSylvan.ForcedSend(c,e) end,nil)
 local rest=g:Clone()
 rest:Sub(sends)
 if addmax and addmax>0 then
  local choices=rest:Filter(function(c) return c:IsSetCard(0x90) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToHand() end,nil)
  if #choices>0 and Duel.SelectYesNo(tp,aux.Stringid(132276575,1)) then
   Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
   local adds=choices:Select(tp,1,math.min(addmax,#choices),nil)
   Duel.SendtoHand(adds,nil,REASON_EFFECT)
   Duel.ConfirmCards(1-tp,adds)
   rest:Sub(adds)
  end
 end
 if #sends>0 then Duel.DisableShuffleCheck() Duel.SendtoGrave(sends,REASON_EFFECT+REASON_REVEAL) end
 local remaining=rest:Filter(Card.IsLocation,nil,LOCATION_DECK)
 if #remaining>0 then
  if #remaining>1 then Duel.SortDecktop(tp,tp,#remaining) end
  for i=1,#remaining do Duel.MoveSequence(Duel.GetDecktopGroup(tp,1):GetFirst(),SEQ_DECKBOTTOM) end
 end
 return lv
end

end
local s,id=GetID()
local SET_SYLVAN=0x90
local MSG_ID=132276573
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetCode(EVENT_SUMMON_SUCCESS)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetTarget(s.toptg)
 e1:SetOperation(s.topop)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_DECKDES)
 e3:SetType(EFFECT_TYPE_IGNITION)
 e3:SetRange(LOCATION_MZONE)
 e3:SetCountLimit(1)
 e3:SetTarget(s.exctg)
 e3:SetOperation(s.excop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,2))
 e4:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetCode(EVENT_TO_GRAVE)
 e4:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e4:SetCountLimit(1,id)
 e4:SetCondition(s.spcon)
 e4:SetTarget(s.sptg)
 e4:SetOperation(s.spop)
 c:RegisterEffect(e4)
end
s.listed_series={SET_SYLVAN}
function s.topfilter(c)
 return c:IsSetCard(SET_SYLVAN) and c:IsType(TYPE_MONSTER)
end
function s.toptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.topfilter,tp,LOCATION_DECK,0,1,nil) end
end
function s.topop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
 local tc=Duel.SelectMatchingCard(tp,s.topfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
 if not tc then return end
 Duel.ShuffleDeck(tp)
 Duel.MoveSequence(tc,SEQ_DECKTOP)
 Duel.ConfirmDecktop(tp,1)
end
function s.exctg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDiscardDeck(tp,1) end
end
function s.excop(e,tp)
 if not Duel.IsPlayerCanDiscardDeck(tp,1) then return end
 local lv=CCGSylvan.Excavate(e,tp,1)
 if lv>0 then
  local c=e:GetHandler()
  if lv>0 and c:IsFaceup() and c:IsRelateToEffect(e) then
   local le=Effect.CreateEffect(c)
   le:SetType(EFFECT_TYPE_SINGLE)
   le:SetCode(EFFECT_CHANGE_LEVEL)
   le:SetValue(lv)
   le:SetReset(RESET_EVENT+RESETS_STANDARD)
   c:RegisterEffect(le)
  end
 end
end
function s.spcon(e)
 local c=e:GetHandler()
 return c:IsPreviousLocation(LOCATION_DECK) and c:IsReason(REASON_REVEAL) and c:IsReason(REASON_EFFECT)
end
function s.spfilter(c,e,tp)
 return c:IsSetCard(SET_SYLVAN) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and s.spfilter(chkc,e,tp) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingTarget(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,1,tp,LOCATION_GRAVE)
end
function s.spop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
end
