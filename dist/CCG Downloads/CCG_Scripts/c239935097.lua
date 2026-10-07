--Three-Headed Snake of the Swamp
local s,id=GetID()
local SWAMP=239935101
local MSG_ID=133935097
function s.initial_effect(c)
 aux.AddCodeList(c,SWAMP)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.placetg)
 e1:SetOperation(s.placeop)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e2)
 local e3=e1:Clone()
 e3:SetCode(EVENT_TO_GRAVE)
 e3:SetCondition(s.sendcon)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,1))
 e4:SetCategory(CATEGORY_TOHAND)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY)
 e4:SetCode(EVENT_REMOVE)
 e4:SetCountLimit(1,id+100)
 e4:SetCondition(s.fusioncon)
 e4:SetCost(s.duelcost)
 e4:SetTarget(s.rettg)
 e4:SetOperation(s.retop)
 c:RegisterEffect(e4)
end
s.listed_names={SWAMP}
function s.mentions(c)
 return aux.IsCodeListed(c,SWAMP) or c:IsCode(239935093,239935094,239935095,239935096,239935097,239935099,239935100,239935101,239935102)
end
function s.sendcon(e,tp,eg,ep,ev,re)
 return re and s.mentions(re:GetHandler())
end
function s.waterreptile(c)
 return c:IsType(TYPE_MONSTER) and c:IsAttribute(ATTRIBUTE_WATER) and c:IsRace(RACE_REPTILE)
end
function s.placefilter(c)
 return s.waterreptile(c) and not c:IsForbidden() and Duel.GetLocationCount(c:GetOwner(),LOCATION_SZONE)>0
end
function s.addfilter(c)
 return c:IsType(TYPE_MONSTER) and c:GetLevel()>0 and c:GetLevel()<=3 and s.mentions(c) and c:IsAbleToHand()
end
function s.placetg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.placefilter),tp,LOCATION_MZONE+LOCATION_GRAVE,0,1,nil)
  and Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.place(c,e,tp,player)
 if Duel.GetLocationCount(player,LOCATION_SZONE)<=0 or not Duel.MoveToField(c,tp,player,LOCATION_SZONE,POS_FACEUP,true) then return false end
 local change=Effect.CreateEffect(e:GetHandler())
 change:SetType(EFFECT_TYPE_SINGLE)
 change:SetCode(EFFECT_CHANGE_TYPE)
 change:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 change:SetValue(TYPE_SPELL+TYPE_CONTINUOUS)
 change:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET)
 c:RegisterEffect(change)
 return true
end
function s.placeop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.placefilter),tp,LOCATION_MZONE+LOCATION_GRAVE,0,1,1,nil)
 local tc=g:GetFirst()
 if not tc or not s.place(tc,e,tp,tc:GetOwner()) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local ag=Duel.SelectMatchingCard(tp,s.addfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #ag>0 and Duel.SendtoHand(ag,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,ag) end
end
function s.fusioncon(e)
 local c=e:GetHandler()
 local rc=c:GetReasonCard()
 return c:IsReason(REASON_MATERIAL) and c:IsReason(REASON_FUSION) and rc
  and rc:IsType(TYPE_FUSION) and rc:IsAttribute(ATTRIBUTE_WATER) and rc:IsRace(RACE_REPTILE)
end
function s.duelcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetFlagEffect(tp,id+100)==0 end
 Duel.RegisterFlagEffect(tp,id+100,0,0,1)
end
function s.retfilter(c,e,tp)
 return c~=e:GetHandler() and c:IsFaceup() and s.waterreptile(c)
  and (c:IsAbleToHand() or (Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not c:IsForbidden()))
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.retfilter,tp,LOCATION_REMOVED,0,1,nil,e,tp) end
end
function s.retop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SELECT)
 local g=Duel.SelectMatchingCard(tp,s.retfilter,tp,LOCATION_REMOVED,0,1,1,nil,e,tp)
 local tc=g:GetFirst()
 if not tc then return end
 local hand=tc:IsAbleToHand()
 local place=Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not tc:IsForbidden()
 local option=0
 if hand and place then option=Duel.SelectOption(tp,aux.Stringid(MSG_ID,2),aux.Stringid(MSG_ID,3))
 elseif place then option=1 end
 if option==0 then
  if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,tc) end
 else s.place(tc,e,tp,tp) end
end
