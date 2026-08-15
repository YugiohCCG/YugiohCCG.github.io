--Bob, but Stronger!
local s,id=GetID()
local CARD_BOB=259722826
local CARD_UMI=22702055
function s.initial_effect(c)
	aux.AddCodeList(c,CARD_BOB,CARD_UMI)
	--Must first be Special Summoned by sending "Bob" and "Umi" you control to the GY
	c:EnableReviveLimit()
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_FIELD)
	e0:SetCode(EFFECT_SPSUMMON_PROC)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetRange(LOCATION_EXTRA)
	e0:SetCondition(s.spcon)
	e0:SetTarget(s.sptg)
	e0:SetOperation(s.spop)
	c:RegisterEffect(e0)
	--spsummon condition
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetCode(EFFECT_SPSUMMON_CONDITION)
	e1:SetValue(s.splimit)
	c:RegisterEffect(e1)
	--unique
	c:SetUniqueOnField(1,0,id)
	--attack all
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_ATTACK_ALL)
	e2:SetValue(1)
	c:RegisterEffect(e2)
	--defense attack
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD)
	e3:SetCode(EFFECT_DEFENSE_ATTACK)
	e3:SetRange(LOCATION_MZONE)
	e3:SetTargetRange(LOCATION_MZONE,0)
	e3:SetTarget(s.deftg)
	e3:SetValue(1)
	c:RegisterEffect(e3)
	--pierce
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_SINGLE)
	e4:SetCode(EFFECT_PIERCE)
	e4:SetValue(DOUBLE_DAMAGE)
	c:RegisterEffect(e4)
end
s.listed_names={CARD_BOB,CARD_UMI}
s.material_setcode={0x92B1}
function s.matfilter(c)
	return c:IsAbleToGraveAsCost() and c:IsCode(CARD_BOB,CARD_UMI)
end
function s.matcheck(g,tp,sc)
	return #g==2 and g:IsExists(Card.IsCode,1,nil,CARD_BOB)
		and g:IsExists(Card.IsCode,1,nil,CARD_UMI)
		and Duel.GetLocationCountFromEx(tp,tp,g,sc)>0
end
function s.spcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_ONFIELD,0,nil)
	return mg:CheckSubGroup(s.matcheck,2,2,tp,c)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,c)
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_ONFIELD,0,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=mg:SelectSubGroup(tp,s.matcheck,true,2,2,tp,c)
	if not g then return false end
	g:KeepAlive()
	e:SetLabelObject(g)
	return true
end
function s.spop(e,tp,eg,ep,ev,re,r,rp,c)
	local g=e:GetLabelObject()
	if not g then return end
	c:SetMaterial(g)
	Duel.SendtoGrave(g,REASON_COST)
	g:DeleteGroup()
end
function s.splimit(e,se,sp,st)
	return e:GetHandler():GetLocation()~=LOCATION_EXTRA
end
function s.deftg(e,c)
	return c:IsCode(CARD_BOB) or aux.IsCodeListed(c,CARD_BOB)
end
