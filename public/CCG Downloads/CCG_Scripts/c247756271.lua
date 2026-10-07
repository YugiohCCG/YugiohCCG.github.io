--Kali Yuga - Bheki
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133756271
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_DAMAGE)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.destg)
 e1:SetOperation(s.desop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY+CATEGORY_TOHAND+CATEGORY_RECOVER)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_DESTROYED)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.retcon)
 e2:SetTarget(s.rettg)
 e2:SetOperation(s.retop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.deckfilter(c)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsType(TYPE_MONSTER) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_DECK)
 Duel.SetOperationInfo(0,CATEGORY_DAMAGE,nil,0,1-tp,400)
end
function s.desop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 and Duel.Destroy(g,REASON_EFFECT)>0 then Duel.Damage(1-tp,400,REASON_EFFECT) end
end
function s.retcon(e)
 local c=e:GetHandler()
 return c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT)
end
function s.ownfilter(c)
 return c:IsSetCard(SET_KALI_YUGA) and c:IsDestructable()
  and (c:IsLocation(LOCATION_HAND) or c:IsFaceup())
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsLocation(LOCATION_GRAVE) and c:IsAbleToHand()
  and Duel.IsExistingMatchingCard(s.ownfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND+LOCATION_ONFIELD)
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,c,1,0,0)
 Duel.SetOperationInfo(0,CATEGORY_RECOVER,nil,0,tp,400)
end
function s.retop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectMatchingCard(tp,s.ownfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,nil)
 if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 then return end
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and c:IsLocation(LOCATION_GRAVE) and Duel.SendtoHand(c,nil,REASON_EFFECT)>0 then
  Duel.ConfirmCards(1-tp,c)
  Duel.Recover(tp,400,REASON_EFFECT)
 end
end
