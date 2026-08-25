--Retaliation Rebound
--Omega references: Solemn Judgment (c41420027), Infinite Impermanence (c10045474)
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_NEGATE); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_CHAINING)
 e:SetCondition(s.con); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_SINGLE); e2:SetCode(EFFECT_TRAP_ACT_IN_HAND); e2:SetCondition(s.handcon); c:RegisterEffect(e2)
end
function s.handcon(e) return Duel.GetTurnPlayer()==e:GetHandlerPlayer() end
function s.con(e,tp,eg,ep,ev,re,r,rp)
 if rp~=1-tp or not Duel.IsChainNegatable(ev) or Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)>=Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD) then return false end
 local code=re:GetCode()
 local negsummon=re:IsHasCategory(CATEGORY_DISABLE_SUMMON) and (code==EVENT_SUMMON or code==EVENT_FLIP_SUMMON or code==EVENT_SPSUMMON)
 if negsummon then return true end
 if ev<=1 or not (re:IsHasCategory(CATEGORY_NEGATE) or re:IsHasCategory(CATEGORY_DISABLE)) then return false end
 return Duel.GetChainInfo(ev-1,CHAININFO_TRIGGERING_PLAYER)==tp
end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.op(e,tp,eg,ep,ev) Duel.NegateActivation(ev) end
