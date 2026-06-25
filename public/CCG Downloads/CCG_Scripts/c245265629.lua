--Stardrake of Gravitic Coils
local s,id=GetID()
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Xyz Summon by using the monster you control with the lowest ATK or DEF
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetRange(LOCATION_EXTRA)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.xyzcon)
	e1:SetTarget(s.xyztg)
	e1:SetOperation(s.xyzop)
	e1:SetValue(SUMMON_TYPE_XYZ)
	c:RegisterEffect(e1)
	--Cannot be used as Xyz or Link Material
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e2:SetCode(EFFECT_CANNOT_BE_XYZ_MATERIAL)
	e2:SetValue(1)
	c:RegisterEffect(e2)
	local e3=e2:Clone()
	e3:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	c:RegisterEffect(e3)
	--Your opponent cannot target other monsters for attacks
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_FIELD)
	e4:SetCode(EFFECT_CANNOT_SELECT_BATTLE_TARGET)
	e4:SetRange(LOCATION_MZONE)
	e4:SetTargetRange(0,LOCATION_MZONE)
	e4:SetCondition(s.atkcon)
	e4:SetValue(s.atlimit)
	c:RegisterEffect(e4)
	--ATK becomes the opponent's battling monster's ATK +100
	local e5=Effect.CreateEffect(c)
	e5:SetType(EFFECT_TYPE_SINGLE)
	e5:SetCode(EFFECT_SET_ATTACK_FINAL)
	e5:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e5:SetRange(LOCATION_MZONE)
	e5:SetCondition(s.atkvalcon)
	e5:SetValue(s.atkval)
	c:RegisterEffect(e5)
end
function s.highatkfilter(c,tp)
	if not (c:IsFaceup() and c:IsControler(1-tp) and c:GetAttack()>=3000) then return false end
	local g=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,LOCATION_MZONE,nil)
	local atk=c:GetAttack()
	return not g:IsExists(function(tc) return tc:GetAttack()>atk end,1,c)
end
function s.matfilter(c,sc,tp,minatk,mindef)
	return c:IsFaceup() and c:IsCanBeXyzMaterial(sc) and (c:GetAttack()==minatk or c:GetDefense()==mindef)
		and Duel.GetLocationCountFromEx(tp,tp,Group.FromCards(c),sc)>0
end
function s.getmatgroup(tp,sc)
	local g=Duel.GetMatchingGroup(function(c) return c:IsFaceup() and c:IsCanBeXyzMaterial(sc) end,tp,LOCATION_MZONE,0,nil)
	if #g==0 then return g end
	local minatk=g:GetFirst():GetAttack()
	local mindef=g:GetFirst():GetDefense()
	for tc in aux.Next(g) do
		minatk=math.min(minatk,tc:GetAttack())
		mindef=math.min(mindef,tc:GetDefense())
	end
	return g:Filter(s.matfilter,nil,sc,tp,minatk,mindef)
end
function s.xyzcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	return Duel.IsExistingMatchingCard(s.highatkfilter,tp,0,LOCATION_MZONE,1,nil,tp)
		and #s.getmatgroup(tp,c)>0
end
function s.xyztg(e,tp,eg,ep,ev,re,r,rp,chk,c)
	local g=s.getmatgroup(tp,c)
	if chk==0 then return #g>0 end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local sg=g:CancelableSelect(tp,1,1,nil)
	if sg then
		sg:KeepAlive()
		e:SetLabelObject(sg)
		return true
	else return false end
end
function s.xyzop(e,tp,eg,ep,ev,re,r,rp,c)
	local g=e:GetLabelObject()
	if not g then return end
	c:SetMaterial(g)
	Duel.Overlay(c,g)
	g:DeleteGroup()
end
function s.atkcon(e)
	local c=e:GetHandler()
	return c:IsSummonType(SUMMON_TYPE_XYZ)
end
function s.atlimit(e,c)
	return c~=e:GetHandler()
end
function s.atkvalcon(e)
	local c=e:GetHandler()
	return Duel.GetCurrentPhase()==PHASE_DAMAGE_CAL and c:GetBattleTarget()~=nil
end
function s.atkval(e,c)
	local bc=c:GetBattleTarget()
	if not bc then return c:GetAttack() end
	return math.max(bc:GetAttack(),0)+100
end
