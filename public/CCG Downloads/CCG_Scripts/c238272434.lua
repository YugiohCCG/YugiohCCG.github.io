--Terror Skull from Underroot
--Omega patterns: c12375297 (level then Synchro), c100233201 (Fusion material), c100256012 (Xyz).
local s,id=GetID()
local SET_UNDERROOT=0xA111
local SET_RROOT=0xA110
local MSG_ID=132272434
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.thtg)
 e1:SetOperation(s.thop)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_QUICK_O)
 e3:SetCode(EVENT_FREE_CHAIN)
 e3:SetRange(LOCATION_MZONE)
 e3:SetCountLimit(1,id+100)
 e3:SetTarget(s.extg)
 e3:SetOperation(s.exop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,2))
 e4:SetCategory(CATEGORY_TOHAND)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY)
 e4:SetCode(EVENT_MOVE)
 e4:SetCountLimit(1,id+200)
 e4:SetCondition(s.retcon)
 e4:SetTarget(s.rettg)
 e4:SetOperation(s.retop)
 c:RegisterEffect(e4)
end
function s.thfilter(c)
 return c:IsSetCard(SET_UNDERROOT) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp)
 if not Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
end
function s.matfilter(c,tp)
 return c:IsControler(tp) and c:IsLocation(LOCATION_HAND+LOCATION_MZONE)
end
function s.exfilter(c,e,tp)
 if not c:IsSetCard(SET_RROOT) then return false end
 if c:IsType(TYPE_FUSION) then
  local mg=Duel.GetFusionMaterial(tp):Filter(s.matfilter,nil,tp)
  return c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
   and c:CheckFusionMaterial(mg,nil,tp)
 end
 if c:IsType(TYPE_SYNCHRO) then return c:IsSynchroSummonable(nil) end
 if c:IsType(TYPE_XYZ) then return c:IsXyzSummonable(nil) end
 return false
end
function s.withlevel(c,n,callback)
 local lv=nil
 if n>0 then
  lv=Effect.CreateEffect(c)
  lv:SetType(EFFECT_TYPE_SINGLE)
  lv:SetCode(EFFECT_UPDATE_LEVEL)
  lv:SetValue(-n)
  lv:SetReset(RESET_EVENT+RESETS_STANDARD)
  c:RegisterEffect(lv,true)
  if Duel.AdjustAll then Duel.AdjustAll() end
 end
 local result=callback()
 if lv then lv:Reset() if Duel.AdjustAll then Duel.AdjustAll() end end
 return result
end
function s.leveloptions(e,tp)
 local c=e:GetHandler()
 local options={}
 for n=0,math.min(2,c:GetLevel()-1) do
  if s.withlevel(c,n,function()
   return Duel.IsExistingMatchingCard(s.exfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp)
  end) then options[#options+1]=n end
 end
 return options
end
function s.extg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return #s.leveloptions(e,tp)>0 end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.exop(e,tp)
 local c=e:GetHandler()
 if not c:IsFaceup() or not c:IsRelateToEffect(e) then return end
 local options=s.leveloptions(e,tp)
 if #options==0 then return end
 local n=Duel.AnnounceNumber(tp,table.unpack(options))
 if n>0 then
  local lv=Effect.CreateEffect(c)
  lv:SetType(EFFECT_TYPE_SINGLE)
  lv:SetCode(EFFECT_UPDATE_LEVEL)
  lv:SetValue(-n)
  lv:SetReset(RESET_EVENT+RESETS_STANDARD)
  c:RegisterEffect(lv)
  if Duel.AdjustAll then Duel.AdjustAll() end
 end
 local g=Duel.GetMatchingGroup(s.exfilter,tp,LOCATION_EXTRA,0,nil,e,tp)
 if #g==0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local tc=g:Select(tp,1,1,nil):GetFirst()
 if not tc then return end
 if tc:IsType(TYPE_FUSION) then
  local mg=Duel.GetFusionMaterial(tp):Filter(s.matfilter,nil,tp)
  local mat=Duel.SelectFusionMaterial(tp,tc,mg,nil,tp)
  if #mat==0 then return end
  tc:SetMaterial(mat)
  Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
  Duel.BreakEffect()
  if Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then tc:CompleteProcedure() end
 elseif tc:IsType(TYPE_SYNCHRO) then
  Duel.SynchroSummon(tp,tc,nil)
 elseif tc:IsType(TYPE_XYZ) then
  Duel.XyzSummon(tp,tc,nil)
 end
end
function s.retcon(e,tp)
 local c=e:GetHandler()
 return c:IsLocation(LOCATION_REMOVED) and c:IsPreviousLocation(LOCATION_GRAVE)
  or c:IsLocation(LOCATION_GRAVE) and c:IsPreviousLocation(LOCATION_REMOVED)
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsAbleToHand() end
 e:SetLabel(c:GetLocation())
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,c,1,tp,c:GetLocation())
end
function s.retop(e,tp)
 local c=e:GetHandler()
 local loc=e:GetLabel()
 if not c:IsRelateToEffect(e) or not c:IsLocation(loc)
  or Duel.SendtoHand(c,nil,REASON_EFFECT)==0 then return end
 Duel.ConfirmCards(1-tp,c)
 if Duel.IsExistingMatchingCard(s.otherfilter,tp,loc,0,1,nil,c)
  and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
  local g=Duel.SelectMatchingCard(tp,s.otherfilter,tp,loc,0,1,1,nil,c)
  if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
 end
end
function s.otherfilter(c,handler)
 return c~=handler and (c:IsSetCard(SET_UNDERROOT) or c:IsCode(11110218)) and c:IsAbleToHand()
end
