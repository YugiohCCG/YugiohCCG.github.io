-- c259792415.lua (The Intergalataxian)
-- Effect 2: End Battle Phase on battle destroy / damage with DELAY
local e2=Effect.CreateEffect(c)
e2:SetDescription(aux.Stringid(STRING_ID,1))
e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
e2:SetProperty(EFFECT_FLAG_DELAY)
e2:SetCode(EVENT_BATTLE_DESTROYING)
e2:SetRange(LOCATION_MZONE)
e2:SetCountLimit(1,id+100)
e2:SetCondition(s.bpcon)
e2:SetOperation(s.endbp)
c:RegisterEffect(e2)
local e3=e2:Clone()
e3:SetCode(EVENT_BATTLE_DAMAGE)
e3:SetCondition(s.bdcon)
c:RegisterEffect(e3)

function s.bpcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetTurnPlayer()==1-tp and eg:IsExists(Card.IsControler,1,nil,tp)
end
function s.bdcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetTurnPlayer()==1-tp and ep==1-tp and eg:IsExists(Card.IsControler,1,nil,tp)
end
function s.endbp(e,tp)
	Duel.SkipPhase(1-tp,PHASE_BATTLE,RESET_PHASE+PHASE_BATTLE,1)
end

-- Effect 4: Hard OPT End Phase Return
local e4=Effect.CreateEffect(c)
e4:SetDescription(aux.Stringid(STRING_ID,2))
e4:SetCategory(CATEGORY_TOHAND)
e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F)
e4:SetCode(EVENT_PHASE+PHASE_END)
e4:SetRange(LOCATION_MZONE)
e4:SetCountLimit(1,id+200)
e4:SetCondition(function(e,tp) return Duel.GetTurnPlayer()==1-tp end)
e4:SetTarget(s.rtg)
e4:SetOperation(s.rop)
c:RegisterEffect(e4)
