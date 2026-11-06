--Nether Skull from Underroot
--Omega patterns: EVENT_MOVE destination filtering, targeted zone movement, banish-as-cost.
local s,id=GetID()
local SET_UNDERROOT=0xA111
local SET_RROOT=0xA110
local MSG_ID=132272436
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_REMOVE+CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e1:SetCode(EVENT_MOVE)
 e1:SetRange(LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.mvcon)
 e1:SetTarget(s.mvtg)
 e1:SetOperation(s.mvop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOGRAVE+CATEGORY_REMOVE)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.sendtg)
 e2:SetOperation(s.sendop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TODECK)
 e3:SetType(EFFECT_TYPE_IGNITION)
 e3:SetRange(LOCATION_GRAVE)
 e3:SetCountLimit(1,id+200)
 e3:SetCost(s.tdcost)
 e3:SetTarget(s.tdtg)
 e3:SetOperation(s.tdop)
 c:RegisterEffect(e3)
end
function s.mvfilter(c,e,tp)
 return c:IsControler(tp) and c:IsType(TYPE_MONSTER)
  and (c:IsLocation(LOCATION_GRAVE) and c:IsAbleToRemove()
   or c:IsLocation(LOCATION_REMOVED) and c:IsAbleToGrave())
  and c:IsCanBeEffectTarget(e)
end
function s.mvcon(e,tp,eg)
 return eg:IsExists(s.mvfilter,1,nil,e,tp)
end
function s.mvtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 local c=e:GetHandler()
 if chkc then return eg:IsContains(chkc) and s.mvfilter(chkc,e,tp) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and eg:IsExists(s.mvfilter,1,nil,e,tp) end
 local g=eg:Filter(s.mvfilter,nil,e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 local sg=g:Select(tp,1,1,nil)
 Duel.SetTargetCard(sg)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,c:GetLocation())
end
function s.mvop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) then return end
 local moved=0
 if tc:IsLocation(LOCATION_GRAVE) then moved=Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)
 elseif tc:IsLocation(LOCATION_REMOVED) then moved=Duel.SendtoGrave(tc,REASON_EFFECT+REASON_RETURN) end
 if moved==0 or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 local c=e:GetHandler()
 if c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
  and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then
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
 end
end
function s.sendfilter(c)
 return c:IsSetCard(SET_UNDERROOT) and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()
end
function s.sendtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.removefilter(c)
 return c:IsAbleToRemove()
end
function s.sendop(e,tp)
 if not Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_DECK,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
 local g=Duel.SelectMatchingCard(tp,s.sendfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g==0 or Duel.SendtoGrave(g,REASON_EFFECT)==0
  or not Duel.IsExistingMatchingCard(s.removefilter,tp,LOCATION_GRAVE,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local rg=Duel.SelectMatchingCard(tp,s.removefilter,tp,LOCATION_GRAVE,0,1,1,nil)
 if #rg>0 then Duel.Remove(rg,POS_FACEUP,REASON_EFFECT) end
end
function s.typecount(tp)
 local g=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil)
 local types={TYPE_FUSION,TYPE_SYNCHRO,TYPE_XYZ,TYPE_LINK}
 local n=0
 for _,v in ipairs(types) do
  if g:IsExists(Card.IsType,1,nil,v) then n=n+1 end
 end
 return n
end
function s.tdfilter(c)
 return (c:IsSetCard(SET_RROOT) or c:IsCode(11110218,63086455,85698115)) and c:IsAbleToDeck()
end
function s.tdcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToRemoveAsCost() end
 Duel.Remove(c,POS_FACEUP,REASON_COST)
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return s.typecount(tp)>0 and
  (Duel.IsExistingMatchingCard(s.tdfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil)
   or e:GetHandler():IsSetCard(SET_RROOT)) end
 Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED)
end
function s.tdop(e,tp)
 local n=s.typecount(tp)
 if n==0 then return end
 local g=Duel.GetMatchingGroup(s.tdfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,nil)
 if #g==0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
 local sg=g:Select(tp,1,math.min(n,#g),nil)
 if #sg>0 then Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end
end
