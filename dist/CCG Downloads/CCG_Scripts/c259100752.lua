--Pot of Rage
--Omega references: Supply Squad (c17626381), Morale Boost (c93671934)
local s,id=GetID()
function s.initial_effect(c)
 if not s.global_check then s.global_check=true
  local ge=Effect.CreateEffect(c); ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); ge:SetCode(EVENT_DESTROYED); ge:SetOperation(s.count); Duel.RegisterEffect(ge,0)
  local ge2=ge:Clone(); ge2:SetCode(EVENT_REMOVE); Duel.RegisterEffect(ge2,0)
 end
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_DRAW); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
end
function s.count(e,tp,eg) for p=0,1 do local n=eg:FilterCount(function(c,p) return c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-p and (c:GetPreviousControler()==p or c:GetOwner()==p) end,nil,p) if n>0 then local old=Duel.GetFlagEffectLabel(p,id) or 0; Duel.ResetFlagEffect(p,id); Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1,old+n) end end end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) local n=math.floor((Duel.GetFlagEffectLabel(tp,id) or 0)/2) if chk==0 then return n>0 and Duel.IsPlayerCanDraw(tp,n) end Duel.SetTargetPlayer(tp); Duel.SetTargetParam(n); Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,n) end
function s.op(e,tp) local p,n=Duel.GetChainInfo(0,CHAININFO_TARGET_PLAYER,CHAININFO_TARGET_PARAM); Duel.Draw(p,n,REASON_EFFECT) end
