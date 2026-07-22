-- Phlogiston Dragon
local s,id=GetID()
local STRING_ID=132094473
function s.initial_effect(c)
	-- fusion summon
	c:EnableReviveLimit()
	aux.AddFusionProcFun2(c,s.ffilter,s.ffilter,true)
	-- immune
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_IMMUNE_EFFECT)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetValue(s.efilter)
	c:RegisterEffect(e1)
	-- extra attacks
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_EXTRA_ATTACK_MONSTER)
	e2:SetValue(s.atkval)
	c:RegisterEffect(e2)
	-- lose ATK/DEF
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e3:SetCode(EVENT_PAY_LPCOST)
	e3:SetRange(LOCATION_MZONE)
	e3:SetOperation(s.paylpcheckop)
	c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_FIELD)
	e4:SetCode(EFFECT_UPDATE_ATTACK)
	e4:SetRange(LOCATION_MZONE)
	e4:SetTargetRange(0,LOCATION_MZONE)
	e4:SetValue(s.atkval2)
	c:RegisterEffect(e4)
	local e5=e4:Clone()
	e5:SetCode(EFFECT_UPDATE_DEFENSE)
	c:RegisterEffect(e5)
	-- send lists
	local e6=Effect.CreateEffect(c)
	e6:SetDescription(aux.Stringid(STRING_ID,0))
	e6:SetCategory(CATEGORY_TOGRAVE)
	e6:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e6:SetCode(EVENT_TO_GRAVE)
	e6:SetProperty(EFFECT_FLAG_DELAY)
	e6:SetCountLimit(1,id)
	e6:SetTarget(s.tgtg)
	e6:SetOperation(s.tgop)
	c:RegisterEffect(e6)
end
function s.ffilter(c)
	return c:IsAttribute(ATTRIBUTE_FIRE) and not c:IsCode(id)
end
function s.efilter(e,re)
	local c=e:GetHandler()
	return re:IsActiveType(TYPE_MONSTER) and re:GetHandler():GetAttack()<c:GetAttack()
end
function s.loweratkfilter(c,atk)
	return c:IsFaceup() and c:GetAttack()<atk
end
function s.atkval(e,c)
	local h=e:GetHandler()
	return Duel.GetMatchingGroupCount(s.loweratkfilter,h:GetControler(),0,LOCATION_MZONE,nil,h:GetAttack())
end
function s.paylpcheckop(e,tp,eg,ep,ev,re,r,rp)
	if ep==tp then
		local c=e:GetHandler()
		local flag=c:GetFlagEffect(id)
		if flag==0 then
			c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1,ev)
		else
			local label=c:GetFlagEffectLabel(id)
			c:SetFlagEffectLabel(id,label+ev)
		end
	end
end
function s.atkval2(e,c)
	local h=e:GetHandler()
	local flag=h:GetFlagEffect(id)
	if flag==0 then return 0 end
	return -h:GetFlagEffectLabel(id)
end
function s.tgfilter(c)
	return (aux.IsCodeListed(c,id) or c:IsCode(id)) and c:IsAbleToGrave()
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_DECK,0,1,2,nil)
	if #g>0 then
		Duel.SendtoGrave(g,REASON_EFFECT)
	end
end
