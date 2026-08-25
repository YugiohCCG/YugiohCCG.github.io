--Vaylantz Duality
--Omega references: Vaylantz Wars - The Place of Beginning (c13179234), Vaylantz Genesis Grand Duke (c76075139)
local s,id=GetID(); local SET_VAYLANTZ=0x17d
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_ACTIVATE); e0:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(e0)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_DESTROY+CATEGORY_TOHAND+CATEGORY_SEARCH); e:SetType(EFFECT_TYPE_IGNITION); e:SetRange(LOCATION_SZONE); e:SetCountLimit(1,id); e:SetTarget(s.thtg); e:SetOperation(s.thop); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetCategory(CATEGORY_DESTROY); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e2:SetCode(EVENT_MOVE); e2:SetRange(LOCATION_SZONE); e2:SetCondition(s.mvcon); e2:SetOperation(s.mvop); c:RegisterEffect(e2)
end
function s.costf(c) return c:IsFaceup() and c:IsType(TYPE_PENDULUM) and c:IsDestructable() end
function s.thf(c) return c:IsSetCard(SET_VAYLANTZ) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.costf,tp,LOCATION_ONFIELD,0,1,nil) and Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD); Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) if not e:GetHandler():IsRelateToEffect(e) then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local tc=Duel.SelectMatchingCard(tp,s.costf,tp,LOCATION_ONFIELD,0,1,1,nil):GetFirst(); if tc and Duel.Destroy(tc,REASON_EFFECT)>0 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end end
function s.mvcon(e,tp,eg) return not Duel.IsDamageStep() and eg:IsExists(function(c) return c:IsLocation(LOCATION_MZONE) and c:GetPreviousLocation()==LOCATION_MZONE and c:GetPreviousSequence()~=c:GetSequence() end,1,nil) end
function s.mvop(e,tp,eg) local seqs={} for tc in aux.Next(eg) do if tc:IsLocation(LOCATION_MZONE) and tc:GetPreviousLocation()==LOCATION_MZONE and tc:GetPreviousSequence()~=tc:GetSequence() then local seq=tc:GetSequence(); if tc:IsControler(tp) then seq=4-seq end; seqs[seq]=true end end local g=Duel.GetMatchingGroup(function(c,t) return t[c:GetSequence()] end,tp,0,LOCATION_ONFIELD,nil,seqs); if #g>0 then Duel.Destroy(g,REASON_EFFECT) end end
