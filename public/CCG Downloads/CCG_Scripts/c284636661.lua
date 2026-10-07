--Aquamarine Seagrass Zostera
--Omega references: c20726052 (Set-turn Trap activation), c101204071 (Effect Trap Monster).
local s,id=GetID()
local SET_AQUAMARINE=0x0f3c
local MSG_ID=132636661
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOGRAVE+CATEGORY_REMOVE)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetCost(s.actcost)
 e1:SetTarget(s.acttg)
 e1:SetOperation(s.actop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetType(EFFECT_TYPE_SINGLE)
 e2:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
 e2:SetProperty(EFFECT_FLAG_SET_AVAILABLE+EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 e2:SetValue(id)
 e2:SetCondition(s.setcon)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_REMOVE)
 e3:SetType(EFFECT_TYPE_QUICK_O)
 e3:SetCode(EVENT_FREE_CHAIN)
 e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e3:SetRange(LOCATION_MZONE)
 e3:SetCountLimit(1,id+100)
 e3:SetTarget(s.rmtg)
 e3:SetOperation(s.rmop)
 c:RegisterEffect(e3)
end
function s.setcon(e)
 local c=e:GetHandler()
 return c:IsStatus(STATUS_SET_TURN) and c:IsLocation(LOCATION_ONFIELD)
  and Duel.IsExistingMatchingCard(s.discardfilter,e:GetHandlerPlayer(),LOCATION_HAND,0,1,nil)
end
function s.discardfilter(c)
 return c:IsSetCard(SET_AQUAMARINE) and c:IsDiscardable()
end
function s.actcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local setturn=e:GetHandler():IsStatus(STATUS_SET_TURN)
 if chk==0 then return not setturn or Duel.IsExistingMatchingCard(s.discardfilter,tp,LOCATION_HAND,0,1,nil) end
 if setturn then Duel.DiscardHand(tp,s.discardfilter,1,1,REASON_COST+REASON_DISCARD) end
end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsPlayerCanSpecialSummonMonster(tp,id,0,TYPES_EFFECT_TRAP_MONSTER,500,2300,6,RACE_AQUA,ATTRIBUTE_WATER) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_SZONE)
end
function s.sendfilter(c)
 return c:IsSetCard(SET_AQUAMARINE) and c:IsType(TYPE_MONSTER)
  and c:IsLevelBelow(4) and c:IsAbleToGrave()
end
function s.banishmonster(c)
 return c:IsSetCard(SET_AQUAMARINE) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemove()
end
function s.actop(e,tp)
 local c=e:GetHandler()
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or not Duel.IsPlayerCanSpecialSummonMonster(tp,id,0,TYPES_EFFECT_TRAP_MONSTER,500,2300,6,RACE_AQUA,ATTRIBUTE_WATER) then return end
 c:AddMonsterAttribute(TYPE_EFFECT+TYPE_TRAP)
 if Duel.SpecialSummon(c,SUMMON_VALUE_SELF,tp,tp,true,false,POS_FACEUP)==0 then return end
 if not Duel.IsExistingMatchingCard(s.sendfilter,tp,LOCATION_DECK,0,1,nil)
  or not Duel.IsExistingMatchingCard(s.banishmonster,tp,LOCATION_GRAVE,0,1,nil)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
 local g=Duel.SelectMatchingCard(tp,s.sendfilter,tp,LOCATION_DECK,0,1,1,nil)
 local sent=g:GetFirst()
 if not sent or Duel.SendtoGrave(sent,REASON_EFFECT)==0
  or not Duel.IsExistingMatchingCard(s.banishmonster,tp,LOCATION_GRAVE,0,1,sent) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local rg=Duel.SelectMatchingCard(tp,s.banishmonster,tp,LOCATION_GRAVE,0,1,1,sent)
 if #rg>0 then Duel.Remove(rg,POS_FACEUP,REASON_EFFECT) end
end
function s.banfilter(c)
 return c:IsSetCard(SET_AQUAMARINE) and c:IsAbleToRemove()
end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_GRAVE) and chkc:IsControler(tp) and s.banfilter(chkc) end
 if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.banfilter),tp,LOCATION_GRAVE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.banfilter),tp,LOCATION_GRAVE,0,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,tp,LOCATION_GRAVE)
end
function s.rmop(e,tp)
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) and s.banfilter(tc) then
  Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)
 end
end
