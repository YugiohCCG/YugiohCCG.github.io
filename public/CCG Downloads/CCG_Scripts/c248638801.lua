local s,id=GetID()
local STRING_ID=132638801
function s.initial_effect(c)
	aux.AddLinkProcedure(c,s.matfilter,2,2)
	c:EnableReviveLimit()
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetCode(EFFECT_ADD_ATTRIBUTE)
	e0:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e0:SetRange(LOCATION_MZONE)
	e0:SetValue(ATTRIBUTE_DARK)
	c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_LINK) end)
	e1:SetOperation(s.regop)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_ATKCHANGE+CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_PRE_DAMAGE_CALCULATE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL)
	e2:SetCondition(s.atkcon)
	e2:SetCost(s.atkcost)
	e2:SetOperation(s.atkop)
	c:RegisterEffect(e2)
end
function s.matfilter(c) return c:IsType(TYPE_EFFECT) and c:IsAttribute(ATTRIBUTE_LIGHT+ATTRIBUTE_DARK) end
function s.regop(e)
	local c=e:GetHandler()
	local g=c:GetMaterial()
	if g:IsExists(Card.IsAttribute,1,nil,ATTRIBUTE_LIGHT) then c:RegisterFlagEffect(id,0,0,1) end
	if g:IsExists(Card.IsAttribute,1,nil,ATTRIBUTE_DARK) then c:RegisterFlagEffect(id+100,0,0,1) end
end
function s.battlemonster(c,bc)
	local ac=Duel.GetAttacker()
	local dc=Duel.GetAttackTarget()
	return dc and (ac==bc and dc or dc==bc and ac)
end
function s.atkcon(e,tp)
	local c=e:GetHandler()
	local ac=Duel.GetAttacker()
	local dc=Duel.GetAttackTarget()
	if not dc then return false end
	local lg=c:GetLinkedGroup()
	local val=0
	if lg:IsContains(ac) and ac:IsAttribute(ATTRIBUTE_LIGHT+ATTRIBUTE_DARK) then val=val|1 end
	if lg:IsContains(dc) and dc:IsAttribute(ATTRIBUTE_LIGHT+ATTRIBUTE_DARK) then val=val|2 end
	e:SetLabel(val)
	return val~=0
end
function s.atkcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToGraveAsCost() end
	local val=e:GetLabel()
	if c:GetFlagEffect(id)>0 then val=val|4 end
	if c:GetFlagEffect(id+100)>0 then val=val|8 end
	e:SetLabel(val)
	Duel.SendtoGrave(c,REASON_COST)
end
function s.atkop(e,tp)
	local ac=Duel.GetAttacker()
	local dc=Duel.GetAttackTarget()
	if not dc then return end
	local g=Group.CreateGroup()
	local val=e:GetLabel()
	if val&1~=0 and ac:IsRelateToBattle() then g:AddCard(ac) end
	if val&2~=0 and dc:IsRelateToBattle() then g:AddCard(dc) end
	if #g==0 then return end
	local tc
	if #g==1 then
		tc=g:GetFirst()
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
		tc=g:Select(tp,1,1,nil):GetFirst()
	end
	local oc=tc==ac and dc or ac
	if not tc:IsRelateToBattle() or not oc:IsRelateToBattle() then return end
	if val&4~=0 then
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(math.max(0,oc:GetAttack()))
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		tc:RegisterEffect(e1)
	end
	if val&8~=0 then
		local e2=Effect.CreateEffect(e:GetHandler())
		e2:SetType(EFFECT_TYPE_SINGLE)
		e2:SetCode(EFFECT_UPDATE_ATTACK)
		e2:SetValue(-math.max(0,oc:GetAttack()))
		e2:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		oc:RegisterEffect(e2)
	end
end
