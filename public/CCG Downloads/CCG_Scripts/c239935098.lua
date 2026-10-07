--Terrifying Hydra
local s,id=GetID()
local HEART=239935093
local TOKEN=239935103
local MSG_ID=133935098
local HYDRA=0xa124
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddCodeList(c,HEART)
 local p=Effect.CreateEffect(c)
 p:SetType(EFFECT_TYPE_FIELD)
 p:SetCode(EFFECT_SPSUMMON_PROC)
 p:SetProperty(EFFECT_FLAG_UNCOPYABLE+EFFECT_FLAG_CANNOT_DISABLE)
 p:SetRange(LOCATION_EXTRA)
 p:SetCondition(s.proccon)
 p:SetOperation(s.procop)
 --Check prospective zones in s.matcheck, then constrain the actual placement.
 --This also supports cores that check procedure zones before material removal.
 p:SetValue(function(e) return SUMMON_TYPE_FUSION,e:GetLabel()==1 and 0x4 or 0xff end)
 c:RegisterEffect(p)
 local limit=Effect.CreateEffect(c)
 limit:SetType(EFFECT_TYPE_SINGLE)
 limit:SetCode(EFFECT_SPSUMMON_CONDITION)
 limit:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 limit:SetValue(function(e,se) return not e:GetHandler():IsLocation(LOCATION_EXTRA) or se==nil end)
 c:RegisterEffect(limit)
 local boost=Effect.CreateEffect(c)
 boost:SetType(EFFECT_TYPE_FIELD)
 boost:SetCode(EFFECT_UPDATE_ATTACK)
 boost:SetRange(LOCATION_MZONE)
 boost:SetTargetRange(LOCATION_MZONE,0)
 boost:SetTarget(function(e,tc) return tc:IsSetCard(HYDRA) end)
 boost:SetValue(function(e) return 900*Duel.GetMatchingGroupCount(s.waterreptile,e:GetHandlerPlayer(),LOCATION_MZONE,0,nil) end)
 c:RegisterEffect(boost)
 local defense=boost:Clone()
 defense:SetCode(EFFECT_UPDATE_DEFENSE)
 c:RegisterEffect(defense)
 local trigger=Effect.CreateEffect(c)
 trigger:SetDescription(aux.Stringid(MSG_ID,0))
 trigger:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOKEN)
 trigger:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F)
 trigger:SetCode(EVENT_DESTROYED)
 trigger:SetRange(LOCATION_MZONE+LOCATION_GRAVE+LOCATION_REMOVED)
 trigger:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_DAMAGE_STEP)
 trigger:SetCondition(s.destroycon)
 trigger:SetTarget(s.tokentg)
 trigger:SetOperation(s.tokenop)
 c:RegisterEffect(trigger)
 local wipe=Effect.CreateEffect(c)
 wipe:SetDescription(aux.Stringid(MSG_ID,1))
 wipe:SetCategory(CATEGORY_DESTROY)
 wipe:SetType(EFFECT_TYPE_QUICK_O)
 wipe:SetCode(EVENT_FREE_CHAIN)
 wipe:SetRange(LOCATION_MZONE)
 wipe:SetCountLimit(1)
 wipe:SetCondition(s.wipecon)
 wipe:SetTarget(s.wipetg)
 wipe:SetOperation(s.wipeop)
 c:RegisterEffect(wipe)
end
s.listed_names={HEART,TOKEN}
s.listed_series={HYDRA}
function s.waterreptile(c)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_REPTILE)
end
function s.material(c)
 return (c:IsLocation(LOCATION_GRAVE) or c:IsFaceup()) and c:IsAbleToRemoveAsCost()
  and (c:IsCode(HEART) or (c:IsType(TYPE_MONSTER) and c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_REPTILE)))
end
function s.matcheck(g,tp,c)
 if #g~=5 then return false end
 local hearts=g:Filter(Card.IsCode,nil,HEART)
 for hc in aux.Next(hearts) do
  local others=g:Clone()
  others:RemoveCard(hc)
  if others:FilterCount(function(tc) return tc:IsType(TYPE_MONSTER) and tc:IsAttribute(ATTRIBUTE_WATER) and tc:IsRace(RACE_REPTILE) end,nil)==4
   and others:GetClassCount(Card.GetCode)==4
   and Duel.GetMZoneCount(tp,g,tp,LOCATION_REASON_TOFIELD,0x4)>0
   and Duel.GetLocationCountFromEx(tp,tp,g,c)>0 then return true end
 end
 return false
end
function s.proccon(e,c)
 if c==nil then return true end
 e:SetLabel(0)
 local tp=c:GetControler()
 local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.material),tp,LOCATION_ONFIELD+LOCATION_GRAVE,0,nil)
 return g:CheckSubGroup(s.matcheck,5,5,tp,c)
end
function s.procop(e,tp,eg,ep,ev,re,r,rp,c)
 local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.material),tp,LOCATION_ONFIELD+LOCATION_GRAVE,0,nil)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local sg=g:SelectSubGroup(tp,s.matcheck,false,5,5,tp,c)
 if not sg then return end
 e:SetLabel(1)
 c:SetMaterial(sg)
 Duel.Remove(sg,POS_FACEUP,REASON_COST+REASON_MATERIAL+REASON_FUSION)
end
function s.destroyed(c,tp)
 return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE)
  and bit.band(c:GetPreviousTypeOnField(),TYPE_MONSTER)~=0
  and ((bit.band(c:GetPreviousAttributeOnField(),ATTRIBUTE_WATER)~=0 and bit.band(c:GetPreviousRaceOnField(),RACE_REPTILE)~=0) or c:IsPreviousSetCard(HYDRA))
end
function s.destroycon(e,tp,eg)
 return eg:IsExists(s.destroyed,1,nil,tp)
end
function s.centerfree(tp)
 return Duel.GetLocationCount(tp,LOCATION_MZONE,tp,LOCATION_REASON_TOFIELD,0x4)>0
end
function s.tokentg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then
  if c:IsLocation(LOCATION_MZONE) then return Duel.GetLocationCount(tp,LOCATION_MZONE)>=2
   and Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN,HYDRA,TYPE_MONSTER+TYPE_NORMAL+TYPE_TOKEN,0,0,1,RACE_REPTILE,ATTRIBUTE_WATER)
   and not Duel.IsPlayerAffectedByEffect(tp,59822133) end
  return c:IsFaceup() and s.centerfree(tp) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,tp,0x4)
 end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,c:IsLocation(LOCATION_MZONE) and 2 or 1,tp,0)
end
function s.tokenop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) then return end
 local ct=2
 if not c:IsLocation(LOCATION_MZONE) then
  if not s.centerfree(tp) or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP,0x4)==0 then return end
  ct=1
 end
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<ct or (ct==2 and Duel.IsPlayerAffectedByEffect(tp,59822133))
  or not Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN,HYDRA,TYPE_MONSTER+TYPE_NORMAL+TYPE_TOKEN,0,0,1,RACE_REPTILE,ATTRIBUTE_WATER) then return end
 for i=1,ct do
  local token=Duel.CreateToken(tp,TOKEN)
  Duel.SpecialSummonStep(token,0,tp,tp,false,false,POS_FACEUP)
 end
 Duel.SpecialSummonComplete()
end
function s.wipecon(e,tp)
 return Duel.GetMatchingGroupCount(s.waterreptile,tp,LOCATION_MZONE,0,nil)>=5
  and Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsCode(HEART) end,tp,LOCATION_ONFIELD,0,1,nil)
end
function s.wipetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(Card.IsDestructable,tp,0,LOCATION_ONFIELD,1,nil) end
 local g=Duel.GetFieldGroup(tp,0,LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,#g,0,0)
end
function s.wipeop(e,tp)
 local g=Duel.GetFieldGroup(tp,0,LOCATION_ONFIELD)
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end
