local s,id=GetID()
local SET_GALACTICA=0x9c9
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c) e1:SetType(EFFECT_TYPE_SINGLE) e1:SetCode(EFFECT_ADD_SETCODE) e1:SetValue(SET_GALACTICA) c:RegisterEffect(e1)
end
