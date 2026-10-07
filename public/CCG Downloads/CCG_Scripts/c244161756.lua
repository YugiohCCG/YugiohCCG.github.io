--Lunalophosaur
local s,id=GetID()
local WORLD=17228908
local TOKEN=17228909
local MSG_ID=132161756
function s.initial_effect(c)
 aux.AddCodeList(c,WORLD,TOKEN)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_SPECIAL_SUMMON+CATEGORY_TOKEN)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCost(s.cost)
 e1:SetTarget(s.searchtg)
 e1:SetOperation(s.searchop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetCountLimit(1,id+100)
 e2:SetCost(aux.bfgcost)
 e2:SetTarget(s.destg)
 e2:SetOperation(s.desop)
 c:RegisterEffect(e2)
end
s.listed_names={WORLD,TOKEN}
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsDiscardable() end
 Duel.SendtoGrave(e:GetHandler(),REASON_COST+REASON_DISCARD)
end
function s.searchfilter(c)
 return c:IsCode(WORLD) and c:IsAbleToHand()
end
function s.searchtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.searchfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.dinofilter(c)
 return c:IsFaceup() and c:IsRace(RACE_DINOSAUR) and c:IsType(TYPE_MONSTER)
end
function s.tokenspossible(tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 or Duel.GetLocationCount(1-tp,LOCATION_MZONE)<=0
  or Duel.IsPlayerAffectedByEffect(tp,59822133) then return false end
 for player=0,1 do
  if not Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN,0,TYPES_TOKEN_MONSTER,0,0,1,RACE_DINOSAUR,ATTRIBUTE_EARTH,POS_FACEUP_DEFENSE,player) then return false end
 end
 return true
end
function s.searchop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.searchfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
 if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
 Duel.ConfirmCards(1-tp,g)
 if not Duel.IsExistingMatchingCard(s.dinofilter,tp,LOCATION_MZONE,0,1,nil)
  or not s.tokenspossible(tp) or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then return end
 for player=0,1 do
  local token=Duel.CreateToken(tp,TOKEN)
  Duel.SpecialSummonStep(token,0,tp,player,false,false,POS_FACEUP_DEFENSE)
 end
 Duel.SpecialSummonComplete()
end
function s.desfilter(c)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsRace(RACE_DINOSAUR)
  and c:IsLevelBelow(3) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_MZONE,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_MZONE)
end
function s.desop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_MZONE,0,1,1,nil)
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end
