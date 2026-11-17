--Terrarumian Terrarium
--Omega references: c12801833 (per-monster battle destruction count),
-- c17228908 (Field Spell effects and Deck card handling).
local s,id=GetID()
local SET_TERRARUMIAN=0xA122
local MSG_ID=132636586
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetOperation(s.activate)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetType(EFFECT_TYPE_FIELD)
 e2:SetCode(EFFECT_INDESTRUCTABLE_COUNT)
 e2:SetRange(LOCATION_FZONE)
 e2:SetTargetRange(LOCATION_MZONE,0)
 e2:SetTarget(s.terrariumtarget)
 e2:SetValue(s.indvalue)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetType(EFFECT_TYPE_FIELD)
 e3:SetCode(EFFECT_UPDATE_ATTACK)
 e3:SetRange(LOCATION_FZONE)
 e3:SetTargetRange(LOCATION_MZONE,0)
 e3:SetCondition(s.damagecon)
 e3:SetTarget(s.pendulumtarget)
 e3:SetValue(900)
 c:RegisterEffect(e3)
end
function s.deckfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
  and c:IsType(TYPE_MONSTER) and (c:IsAbleToHand() or c:IsDestructable())
end
function s.activate(e,tp)
 if not Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,0)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil)
 local tc=g:GetFirst()
 if not tc then return end
 Duel.HintSelection(g)
 local canhand=tc:IsAbleToHand()
 local candestroy=tc:IsDestructable()
 local option=canhand and candestroy and Duel.SelectOption(tp,aux.Stringid(MSG_ID,1),aux.Stringid(MSG_ID,2))
  or (canhand and 0 or 1)
 if option==0 then
  if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
 else
  Duel.Destroy(tc,REASON_EFFECT)
 end
end
function s.terrariumtarget(e,c)
 return c:IsFaceup() and c:IsSetCard(SET_TERRARUMIAN)
end
function s.indvalue(e,re,r,rp)
 return r&REASON_BATTLE~=0 and 1 or 0
end
function s.damagecon(e)
 return Duel.GetCurrentPhase()==PHASE_DAMAGE_CAL
end
function s.pendulumtarget(e,c)
 return s.terrariumtarget(e,c) and c:IsType(TYPE_PENDULUM)
end
