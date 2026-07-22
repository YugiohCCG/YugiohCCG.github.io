local s,id=GetID()
local STRING_ID=133307285
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c) e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON) e1:SetType(EFFECT_TYPE_ACTIVATE) e1:SetCode(EVENT_ATTACK_ANNOUNCE) e1:SetCondition(s.atkcon) e1:SetOperation(s.atkop) c:RegisterEffect(e1)
	local e2=e1:Clone() e2:SetCode(EVENT_CHAINING) e2:SetCondition(s.negcon) e2:SetTarget(s.negtg) e2:SetOperation(s.negop) c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c) e3:SetType(EFFECT_TYPE_SINGLE) e3:SetCode(EFFECT_TRAP_ACT_IN_HAND) e3:SetCondition(s.handcon) c:RegisterEffect(e3)
end
function s.atkcon(e,tp) return Duel.GetAttacker():IsControler(1-tp) end
function s.handcon(e,tp) return Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)==0 and Duel.GetFieldGroupCount(tp,0,LOCATION_MZONE)>0 end
function s.spfilter(c,e,tp) return c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_ATTACK) end
function s.retreg(e,tp,tc)
	local te=Effect.CreateEffect(e:GetHandler()) te:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) te:SetCode(EVENT_PHASE+PHASE_BATTLE) te:SetLabelObject(tc) te:SetReset(RESET_PHASE+PHASE_BATTLE) te:SetOperation(function(te) local rc=te:GetLabelObject() if rc and rc:IsLocation(LOCATION_MZONE) then Duel.SendtoHand(rc,nil,REASON_EFFECT) end end) Duel.RegisterEffect(te,tp)
end
function s.trysp(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_HAND,0,1,nil,e,tp) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,1)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON) local tc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_HAND,0,1,1,nil,e,tp):GetFirst() if tc and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK)>0 then s.retreg(e,tp,tc) end end end
function s.atkop(e,tp) local ac=Duel.GetAttacker() if Duel.NegateAttack() and ac and Duel.Destroy(ac,REASON_EFFECT)>0 then s.trysp(e,tp) end end
function s.negcon(e,tp,eg,ep,ev,re,r,rp) return Duel.IsBattlePhase() and rp==1-tp and Duel.IsChainNegatable(ev) end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.negop(e,tp,eg,ep,ev,re,r,rp) local rc=re:GetHandler() if Duel.NegateActivation(ev) and rc:IsRelateToEffect(re) and Duel.Destroy(rc,REASON_EFFECT)>0 then s.trysp(e,tp) end end
