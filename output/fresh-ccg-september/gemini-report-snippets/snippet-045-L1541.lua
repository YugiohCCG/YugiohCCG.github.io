-- c219002796.lua (Intergalacticanes Majoris)
-- Opponent cannot declare an attack
local e2=Effect.CreateEffect(c)
e2:SetType(EFFECT_TYPE_FIELD)
e2:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
e2:SetCode(EFFECT_CANNOT_ATTACK_ANNOUNCE)
e2:SetRange(LOCATION_MZONE)
e2:SetTargetRange(0,1)
c:RegisterEffect(e2)

-- Banish trigger with EFFECT_FLAG_DELAY
local e4=Effect.CreateEffect(c)
e4:SetDescription(aux.Stringid(STRING_ID,0))
e4:SetCategory(CATEGORY_REMOVE)
e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
e4:SetProperty(EFFECT_FLAG_DELAY)
e4:SetCode(EVENT_BATTLE_DESTROYING)
e4:SetCondition(aux.bdocon)
e4:SetCost(s.btcost)
e4:SetTarget(s.rmtg)
e4:SetOperation(s.rmop)
c:RegisterEffect(e4)
local e5=e4:Clone()
e5:SetCode(EVENT_BATTLE_DAMAGE)
e5:SetCondition(function(e,tp,eg,ep) return ep==1-tp end)
c:RegisterEffect(e5)

function s.rmfilter(c)
	return c:IsAbleToRemove()
end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.rmfilter,tp,0,LOCATION_ONFIELD,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,1-tp,LOCATION_ONFIELD)
end
function s.rmop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,s.rmfilter,tp,0,LOCATION_ONFIELD,1,1,nil)
	if #g>0 then
		Duel.Remove(g,POS_FACEUP,REASON_EFFECT)
	end
end
