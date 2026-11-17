--Ruby, Killamity Convergence
local s,id=GetID()
local MSG_ID=132163206
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddXyzProcedure(c,nil,12,2,nil,nil,99)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_SINGLE)
 e1:SetCode(EFFECT_UPDATE_ATTACK)
 e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
 e1:SetRange(LOCATION_MZONE)
 e1:SetValue(function(e) return e:GetHandler():GetOverlayCount()*200 end)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetCode(EFFECT_UPDATE_DEFENSE)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,0))
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetCode(EVENT_SPSUMMON_SUCCESS)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCountLimit(1,id)
 e3:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_XYZ) end)
 e3:SetTarget(s.negtg)
 e3:SetOperation(s.negop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,1))
 e4:SetType(EFFECT_TYPE_QUICK_O)
 e4:SetCode(EVENT_FREE_CHAIN)
 e4:SetRange(LOCATION_MZONE)
 e4:SetCountLimit(1,id+100)
 e4:SetCondition(s.attachcon)
 e4:SetTarget(s.attachtg)
 e4:SetOperation(s.attachop)
 c:RegisterEffect(e4)
end
s.listed_series={0xa120}
function s.negfilter(c,e)
 return c:IsFaceup() and not c:IsImmuneToEffect(e)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.negfilter,tp,0,LOCATION_ONFIELD,1,nil,e) end
end
function s.negop(e,tp)
 local g=Duel.GetMatchingGroup(s.negfilter,tp,0,LOCATION_ONFIELD,nil,e)
 for tc in aux.Next(g) do
  Duel.NegateRelatedChain(tc,RESET_TURN_SET)
  local e1=Effect.CreateEffect(e:GetHandler())
  e1:SetType(EFFECT_TYPE_SINGLE)
  e1:SetCode(EFFECT_DISABLE)
  e1:SetReset(RESET_EVENT+RESETS_STANDARD)
  tc:RegisterEffect(e1)
  local e2=e1:Clone()
  e2:SetCode(EFFECT_DISABLE_EFFECT)
  tc:RegisterEffect(e2)
 end
end
function s.attachcon()
 local ph=Duel.GetCurrentPhase()
 return ph==PHASE_MAIN1 or ph==PHASE_MAIN2 or ph==PHASE_BATTLE_START or ph==PHASE_BATTLE_STEP or ph==PHASE_BATTLE
end
function s.attachfilter(c,e)
 return not c:IsImmuneToEffect(e)
end
function s.killamity(c)
 return c:IsType(TYPE_MONSTER) and c:IsSetCard(0xa120)
end
function s.owncheck(g)
 return g:IsExists(s.killamity,1,nil) and g:FilterCount(Card.IsLocation,nil,LOCATION_ONFIELD)<=1
end
function s.attachtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then
  local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.attachfilter),tp,LOCATION_HAND+LOCATION_ONFIELD+LOCATION_GRAVE,0,e:GetHandler(),e)
  return g:IsExists(s.killamity,1,nil)
 end
end
function s.oppfilter(c,e)
 return c:IsType(TYPE_MONSTER+TYPE_SPELL+TYPE_TRAP) and not c:IsImmuneToEffect(e)
end
--Each selected opponent card consumes one distinct Monster/Spell/Trap slot.
--A card having more than one of these types can occupy either applicable slot.
function s.oppcheck(g)
 if #g>3 or g:FilterCount(Card.IsLocation,nil,LOCATION_ONFIELD)>1 then return false end
 local cards={}
 for tc in aux.Next(g) do cards[#cards+1]=tc end
 local types={TYPE_MONSTER,TYPE_SPELL,TYPE_TRAP}
 local function assign(i,used)
  if i>#cards then return true end
  for j=1,3 do
   local mask=2^(j-1)
   if bit.band(used,mask)==0 and cards[i]:IsType(types[j]) and assign(i+1,used+mask) then return true end
  end
  return false
 end
 return assign(1,0)
end
function s.attachop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsFaceup() then return end
 local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.attachfilter),tp,LOCATION_HAND+LOCATION_ONFIELD+LOCATION_GRAVE,0,c,e)
 if not g:IsExists(s.killamity,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
 local sg=g:SelectSubGroup(tp,s.owncheck,false,1,4)
 if not sg or #sg==0 then return end
 Duel.Overlay(c,sg)
 local og=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.oppfilter),tp,0,LOCATION_ONFIELD+LOCATION_GRAVE,nil,e)
 if #og>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
  local os=og:SelectSubGroup(tp,s.oppcheck,false,1,3)
  if os and #os>0 then Duel.Overlay(c,os) end
 end
end
