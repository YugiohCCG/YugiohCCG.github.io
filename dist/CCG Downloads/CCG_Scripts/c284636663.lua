--Aquamarine Seafan Gorgonia
--Omega references: c39753577 (turn-wide Extra Deck oath), c35550352 (Set Trap from Deck).
local s,id=GetID()
local SET_AQUAMARINE=0x0f3c
local MSG_ID=132636663
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.counterfilter)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.handcon)
 e1:SetCost(s.lockcost)
 e1:SetTarget(s.handtg)
 e1:SetOperation(s.handop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SSET)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetCost(s.lockcost)
 e2:SetTarget(s.settg)
 e2:SetOperation(s.setop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TOHAND+CATEGORY_HANDES)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_REMOVE)
 e3:SetCountLimit(1,id+200)
 e3:SetCondition(s.thcon)
 e3:SetCost(s.lockcost)
 e3:SetTarget(s.thtg)
 e3:SetOperation(s.thop)
 c:RegisterEffect(e3)
end
function s.counterfilter(c)
 return not c:IsSummonLocation(LOCATION_EXTRA) or c:IsSetCard(SET_AQUAMARINE)
end
function s.splimit(e,c)
 return c:IsLocation(LOCATION_EXTRA) and not c:IsSetCard(SET_AQUAMARINE)
end
function s.lockcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 end
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
 lock:SetTargetRange(1,0)
 lock:SetTarget(s.splimit)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
end
function s.aquafilter(c)
 return c:IsFaceup() and c:IsSetCard(SET_AQUAMARINE)
end
function s.handcon(e,tp)
 local ph=Duel.GetCurrentPhase()
 return (ph==PHASE_MAIN1 or ph==PHASE_MAIN2)
  and Duel.IsExistingMatchingCard(s.aquafilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.handtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
end
function s.handop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
 end
end
function s.setfilter(c)
 return c:IsSetCard(SET_AQUAMARINE) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_DECK)
end
function s.setop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
 local g=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 then Duel.SSet(tp,g) end
end
function s.thcon(e,tp)
 return e:GetHandler():IsPreviousLocation(LOCATION_GRAVE)
  and Duel.IsExistingMatchingCard(s.aquafilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.thfilter(c)
 return c:IsCode(284636665) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.thop(e,tp)
 if not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
 if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
 Duel.ConfirmCards(1-tp,g)
 if Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil) then
  Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_EFFECT+REASON_DISCARD)
 end
end
