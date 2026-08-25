--Yurei
--Omega references: Effect Veiler (c97268402), Nikitama (c24701235), Yaksha (c94215860)
local s,id=GetID(); local STRING_ID=133844716
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SPSUMMON_CONDITION); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetValue(aux.FALSE); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_NEGATE); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_CHAINING); e1:SetRange(LOCATION_HAND); e1:SetCountLimit(1,id); e1:SetCondition(s.negcon); e1:SetCost(s.negcost); e1:SetTarget(s.negtg); e1:SetOperation(s.negop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_SUMMON+CATEGORY_ATKCHANGE); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_ATTACK_ANNOUNCE); e2:SetRange(LOCATION_HAND); e2:SetCountLimit(1,id); e2:SetCondition(s.atkcon); e2:SetTarget(s.sumtg); e2:SetOperation(s.sumop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e3:SetCode(EVENT_PHASE+PHASE_END); e3:SetRange(LOCATION_MZONE+LOCATION_GRAVE+LOCATION_REMOVED); e3:SetCountLimit(1); e3:SetCondition(s.retcon); e3:SetTarget(s.rtg); e3:SetOperation(s.rop); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS); e4:SetCode(EVENT_SUMMON_SUCCESS); e4:SetOperation(s.mark); c:RegisterEffect(e4); local e5=e4:Clone(); e5:SetCode(EVENT_FLIP); c:RegisterEffect(e5); local e6=e4:Clone(); e6:SetCode(EVENT_RELEASE); c:RegisterEffect(e6)
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp) local ex,g,_,_,loc=Duel.GetOperationInfo(ev,CATEGORY_DESTROY); return rp==1-tp and re:IsHasCategory(CATEGORY_DESTROY) and ex and (g and g:IsExists(Card.IsOnField,1,nil) or loc and loc&LOCATION_ONFIELD~=0) and Duel.IsChainDisablable(ev) end
function s.spirit(c) return c:IsType(TYPE_SPIRIT) and c:IsReleasable() end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,e:GetHandler()) end Duel.ConfirmCards(1-tp,e:GetHandler()); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE); local g=Duel.SelectMatchingCard(tp,s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,e:GetHandler()); Duel.Release(g,REASON_COST) end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.negop(e,tp,eg,ep,ev) Duel.NegateEffect(ev) end
function s.atkcon(e,tp) local a=Duel.GetAttacker(); local d=Duel.GetAttackTarget(); return (a and a:IsControler(tp) and a:IsType(TYPE_SPIRIT)) or (d and d:IsControler(tp) and d:IsType(TYPE_SPIRIT)) end
function s.sumtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsSummonable(true,nil) end Duel.SetOperationInfo(0,CATEGORY_SUMMON,e:GetHandler(),1,0,0) end
function s.sumop(e,tp) local c=e:GetHandler(); local tc=Duel.GetAttacker(); if not (tc:IsControler(tp) and tc:IsType(TYPE_SPIRIT)) then tc=Duel.GetAttackTarget() end if c:IsRelateToEffect(e) and Duel.Summon(tp,c,true,nil)>0 and tc and tc:IsFaceup() then local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_SET_ATTACK_FINAL); ex:SetValue(tc:GetAttack()*2); ex:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END); tc:RegisterEffect(ex) end end
function s.mark(e) e:GetHandler():RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1) end
function s.retcon(e) return e:GetHandler():GetFlagEffect(id)>0 end
function s.rtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsAbleToHand() end Duel.SetOperationInfo(0,CATEGORY_TOHAND,e:GetHandler(),1,0,0) end
function s.rop(e) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SendtoHand(c,nil,REASON_EFFECT) end end
