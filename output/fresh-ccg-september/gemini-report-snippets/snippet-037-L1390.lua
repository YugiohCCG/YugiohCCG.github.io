-- c215142357.lua (Shining Brigade - Stand Together!)
-- Draw card
local e4=Effect.CreateEffect(c)
e4:SetDescription(aux.Stringid(STRING_ID,1))
e4:SetCategory(CATEGORY_DRAW)
e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
e4:SetCode(EVENT_CHAINING)
e4:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_PLAYER_TARGET)
e4:SetRange(LOCATION_SZONE)
e4:SetCountLimit(1,id)
e4:SetCondition(s.drcon)
e4:SetTarget(s.drtg)
e4:SetOperation(s.drop)
c:RegisterEffect(e4)

function s.drcon(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	return rp==tp and re:IsActiveType(TYPE_MONSTER) and rc:IsSetCard(SET_SHINING_BRIGADE)
		and re:GetActivateLocation()==LOCATION_MZONE
end
