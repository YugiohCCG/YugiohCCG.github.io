--Pot of Longevity
--Omega references: Number 60: Dugares the Timeless (c66011101), Time-Tearing Morganite (c19403423)
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetOperation(s.op); c:RegisterEffect(e)
end
function s.op(e,tp)
 local c=e:GetHandler()
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD); e1:SetCode(EFFECT_DRAW_COUNT); e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET); e1:SetTargetRange(1,0); e1:SetValue(3); e1:SetReset(RESET_PHASE+PHASE_DRAW+RESET_SELF_TURN,1); Duel.RegisterEffect(e1,tp)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e2:SetCode(EVENT_DRAW); e2:SetCondition(s.drawcon); e2:SetOperation(s.drawop); e2:SetReset(RESET_PHASE+PHASE_DRAW+RESET_SELF_TURN,1); Duel.RegisterEffect(e2,tp)
end
function s.drawcon(e,tp,eg) return Duel.GetTurnPlayer()==tp and Duel.GetCurrentPhase()==PHASE_DRAW and #eg==3 and eg:FilterCount(Card.IsReason,nil,REASON_RULE)==3 end
function s.drawop(e,tp)
 local c=e:GetHandler()
 local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_SKIP_BP); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetReset(RESET_PHASE+PHASE_BATTLE+RESET_SELF_TURN,1); Duel.RegisterEffect(ex,tp)
 if Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)>Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD) and Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>0 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local g=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,1,nil); Duel.SendtoDeck(g,nil,SEQ_DECKBOTTOM,REASON_EFFECT) end
end
