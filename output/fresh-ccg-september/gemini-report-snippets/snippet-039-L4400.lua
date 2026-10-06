	--Cannot be Xyz Material this turn
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetCode(EFFECT_CANNOT_BE_XYZ_MATERIAL)
	e1:SetCondition(s.xyzcon)
	e1:SetValue(1)
	c:RegisterEffect(e1)
...
function s.xyzop(e,tp,chk,mc)
	if chk==0 then return true end
	e:GetHandler():RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD-RESET_TOFIELD+RESET_PHASE+PHASE_END,0,1)
end
function s.xyzcon(e)
	return e:GetHandler():HasFlagEffect(id)
end
