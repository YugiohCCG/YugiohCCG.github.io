--Release of the Pyre
--Omega references: Fire Formation - Tenki (c57103969), Ground Collapse (c90502999)
local s,id=GetID(); local SET_PYRE=0x3135
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_ACTIVATE); e0:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_SZONE); e1:SetCountLimit(1,id); e1:SetCondition(function(e,tp) return Duel.IsExistingMatchingCard(Card.IsRace,tp,LOCATION_MZONE,0,1,nil,RACE_PYRO) end); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD); e2:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); e2:SetRange(LOCATION_SZONE); e2:SetProperty(EFFECT_FLAG_PLAYER_TARGET); e2:SetTargetRange(1,0); e2:SetTarget(function(e,c) return not c:IsRace(RACE_PYRO) end); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_IGNITION); e3:SetRange(LOCATION_SZONE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+100); e3:SetTarget(s.locktg); e3:SetOperation(s.lockop); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetCategory(CATEGORY_DRAW+CATEGORY_TOGRAVE); e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e4:SetCode(EVENT_LEAVE_FIELD); e4:SetRange(LOCATION_SZONE); e4:SetProperty(EFFECT_FLAG_DELAY); e4:SetCountLimit(1,id+200); e4:SetCondition(s.drcon); e4:SetTarget(s.drtg); e4:SetOperation(s.drop); c:RegisterEffect(e4)
end
function s.thf(c) return c:IsSetCard(SET_PYRE) and c:IsSpell() and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.pointsempty(c,tp) local zone=c:GetLinkedZone(1-tp)&0x1f; for seq=0,4 do if zone&(1<<seq)~=0 and Duel.CheckLocation(1-tp,LOCATION_MZONE,seq) then return true end end return false end
function s.lk(c,tp) return c:IsFaceup() and c:IsSetCard(SET_PYRE) and c:IsType(TYPE_LINK) and c:GetSequence()>4 and s.pointsempty(c,tp) end
function s.locktg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.lk(chkc,tp) end if chk==0 then return Duel.IsExistingTarget(s.lk,tp,LOCATION_MZONE,0,1,nil,tp) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP); Duel.SelectTarget(tp,s.lk,tp,LOCATION_MZONE,0,1,1,nil,tp) end
function s.lockcon(e) local tc=e:GetLabelObject(); return tc and tc:IsFaceup() and tc:IsLocation(LOCATION_MZONE) and tc:GetSequence()>4 and s.pointsempty(tc,e:GetLabel()) end
function s.lockop(e,tp) local tc=Duel.GetFirstTarget(); if not tc or not tc:IsRelateToEffect(e) then return end local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_DISABLE_FIELD); ex:SetCondition(s.lockcon); ex:SetLabel(tp); ex:SetLabelObject(tc); ex:SetValue(0x60<<16); Duel.RegisterEffect(ex,tp) end
function s.drcon(e,tp,eg,ep,ev,re,r,rp) return eg:IsExists(function(c,tp) return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsSetCard(SET_PYRE) and c:IsType(TYPE_MONSTER) and c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp end,1,nil,tp) end
function s.drtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1) end
function s.drop(e,tp) if Duel.Draw(tp,1,REASON_EFFECT)>0 and e:GetHandler():IsRelateToEffect(e) then Duel.BreakEffect(); Duel.SendtoGrave(e:GetHandler(),REASON_EFFECT) end end
