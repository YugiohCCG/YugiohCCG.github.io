--Symphonic Warrior DDJ
--Omega: c49919798 FLIP, c43210483 Pendulum return, c100212003 immediate Synchro.
local s,id=GetID()
local SET_SYMPHONIC=0x1066
local MSG_ID=132273769
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_PZONE)
 e1:SetCountLimit(1)
 e1:SetTarget(s.fliptg)
 e1:SetOperation(s.flipop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_CHAINING)
 e2:SetRange(LOCATION_PZONE)
 e2:SetCountLimit(1,id)
 e2:SetCondition(s.pcon)
 e2:SetTarget(s.ptg)
 e2:SetOperation(s.pop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_FLIP+EFFECT_TYPE_TRIGGER_F)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCountLimit(1,id+100)
 e3:SetTarget(s.decktarget)
 e3:SetOperation(s.deckop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,3))
 e4:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e4:SetType(EFFECT_TYPE_QUICK_O)
 e4:SetCode(EVENT_FREE_CHAIN)
 e4:SetRange(LOCATION_HAND)
 e4:SetCountLimit(1,id+200)
 e4:SetCondition(s.handcon)
 e4:SetTarget(s.handtg)
 e4:SetOperation(s.handop)
 c:RegisterEffect(e4)
 local e5=Effect.CreateEffect(c)
 e5:SetDescription(aux.Stringid(MSG_ID,4))
 e5:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e5:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e5:SetProperty(EFFECT_FLAG_DELAY)
 e5:SetCode(EVENT_SUMMON_SUCCESS)
 e5:SetCountLimit(1,id+300)
 e5:SetTarget(s.searchtg)
 e5:SetOperation(s.searchop)
 c:RegisterEffect(e5)
 local e6=e5:Clone()
 e6:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e6)
end
function s.flipfilter(c)
 return c:IsSetCard(SET_SYMPHONIC) and c:IsPosition(POS_FACEDOWN_DEFENSE) and c:IsCanChangePosition()
end
function s.fliptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.flipfilter,tp,LOCATION_MZONE,0,1,nil) end
end
function s.flipop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
 local tc=Duel.SelectMatchingCard(tp,s.flipfilter,tp,LOCATION_MZONE,0,1,1,nil):GetFirst()
 if tc then Duel.ChangePosition(tc,POS_FACEUP_DEFENSE) end
end
function s.pcon(e,tp,eg,ep,ev,re)
 return Duel.GetCurrentPhase()~=PHASE_DAMAGE and Duel.GetCurrentPhase()~=PHASE_DAMAGE_CAL
  and re:IsActiveType(TYPE_MONSTER) and re:GetHandler():IsSetCard(SET_SYMPHONIC)
end
function s.pfilter(c,e,tp)
 return c:IsSetCard(SET_SYMPHONIC)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsAbleToHand() and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(s.pfilter,tp,LOCATION_PZONE,0,1,e:GetHandler(),e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,e:GetHandler(),1,tp,LOCATION_PZONE)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_PZONE)
end
function s.pop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.SendtoHand(c,nil,REASON_EFFECT)==0 or not c:IsLocation(LOCATION_HAND)
  or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local tc=Duel.SelectMatchingCard(tp,s.pfilter,tp,LOCATION_PZONE,0,1,1,nil,e,tp):GetFirst()
 if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
end
function s.deckfilter(c,e,tp)
 return c:IsSetCard(SET_SYMPHONIC) and c:IsType(TYPE_MONSTER) and c:GetLevel()<=4
  and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
end
function s.decktarget(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.deckop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
  local tc=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
  if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE) end
 end
 --"also" applies independently of the Deck Summon's success, but only on resolution.
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetTargetRange(1,0)
 lock:SetTarget(function(e,c) return c:IsLocation(LOCATION_EXTRA) and not c:IsAttribute(ATTRIBUTE_WIND) end)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
end
function s.handcon(e,tp)
 return Duel.IsExistingMatchingCard(Card.IsSetCard,tp,LOCATION_MZONE,0,1,nil,SET_SYMPHONIC)
end
function s.handtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
end
function s.synfilter(sc,c,mg)
 return sc:IsSynchroSummonable(c,mg)
end
function s.handop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local mg=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil)
 if not Duel.IsExistingMatchingCard(s.synfilter,tp,LOCATION_EXTRA,0,1,nil,c,mg)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,5)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local sc=Duel.SelectMatchingCard(tp,s.synfilter,tp,LOCATION_EXTRA,0,1,1,nil,c,mg):GetFirst()
 if sc then Duel.SynchroSummon(tp,sc,c,mg) end
end
function s.searchfilter(c)
 return c:IsSetCard(SET_SYMPHONIC) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.searchtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.searchfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.searchop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.searchfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end
end
