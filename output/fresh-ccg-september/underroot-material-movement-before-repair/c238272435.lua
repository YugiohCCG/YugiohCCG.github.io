--Blossom Skull from Underroot
--Omega patterns: c238272434 (Level-adjusted Extra Deck summon), c100211122 (discard cost).
local s,id=GetID()
local SET_RROOT=0xA110
local MSG_ID=132272435
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetRange(LOCATION_HAND)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.swapcost)
 e1:SetTarget(s.swaptg)
 e1:SetOperation(s.swapop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_MZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.extg)
 e2:SetOperation(s.exop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_MOVE)
 e3:SetCountLimit(1,id+200)
 e3:SetCondition(s.retcon)
 e3:SetTarget(s.rettg)
 e3:SetOperation(s.retop)
 c:RegisterEffect(e3)
end
function s.swapcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsDiscardable() end
 Duel.SendtoGrave(c,REASON_COST+REASON_DISCARD)
end
function s.swapfilter(c,e)
 return c:IsFaceup() and c:IsType(TYPE_FUSION+TYPE_SYNCHRO+TYPE_XYZ+TYPE_LINK)
  and c:IsAbleToExtra() and c:IsCanBeEffectTarget(e)
end
function s.swaptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_MZONE) and s.swapfilter(chkc,e) end
 if chk==0 then return Duel.IsExistingTarget(s.swapfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,e) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 local g=Duel.SelectTarget(tp,s.swapfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,e)
 Duel.SetOperationInfo(0,CATEGORY_TODECK,g,1,0,LOCATION_MZONE)
end
function s.replfilter(c,e,owner,types,lv,rk,ln,oldcode)
 if c:IsCode(oldcode) or not c:IsCanBeSpecialSummoned(e,0,owner,false,false) then return false end
 return (types&TYPE_FUSION~=0 and c:IsType(TYPE_FUSION) and c:IsLevel(lv))
  or (types&TYPE_SYNCHRO~=0 and c:IsType(TYPE_SYNCHRO) and c:IsLevel(lv))
  or (types&TYPE_XYZ~=0 and c:IsType(TYPE_XYZ) and c:IsRank(rk))
  or (types&TYPE_LINK~=0 and c:IsType(TYPE_LINK) and c:IsLink(ln))
end
function s.swapop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) or not tc:IsFaceup() then return end
 local owner=tc:GetOwner()
 local types=tc:GetType()
 local lv,rk,ln=tc:GetLevel(),tc:GetRank(),tc:GetLink()
 local oldcode=tc:GetCode()
 if Duel.SendtoDeck(tc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==0 then return end
 if Duel.GetLocationCountFromEx(owner)<=0
  or not Duel.IsExistingMatchingCard(s.replfilter,owner,LOCATION_EXTRA,0,1,nil,e,owner,types,lv,rk,ln,oldcode)
  or not Duel.SelectYesNo(owner,aux.Stringid(MSG_ID,3)) then return end
 Duel.Hint(HINT_SELECTMSG,owner,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(owner,s.replfilter,owner,LOCATION_EXTRA,0,1,1,nil,e,owner,types,lv,rk,ln,oldcode)
 local sc=g:GetFirst()
 if not sc or Duel.SpecialSummon(sc,0,owner,owner,false,false,POS_FACEUP)==0 then return end
 if not sc:IsSetCard(SET_RROOT) then
  local dis=Effect.CreateEffect(e:GetHandler())
  dis:SetType(EFFECT_TYPE_SINGLE)
  dis:SetCode(EFFECT_DISABLE)
  dis:SetReset(RESET_EVENT+RESETS_STANDARD)
  sc:RegisterEffect(dis)
  local dis2=dis:Clone()
  dis2:SetCode(EFFECT_DISABLE_EFFECT)
  sc:RegisterEffect(dis2)
 end
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
