--Shining Brigade - Stand Together!
local s,id=GetID()
local STRING_ID=133142357
local SET_SHINING_BRIGADE = 0x7a34
function s.initial_effect(c)
	--Activate
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	--Protect Spells/Traps
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	e1:SetRange(LOCATION_SZONE)
	e1:SetTargetRange(LOCATION_ONFIELD,0)
	e1:SetTarget(s.prottg)
	e1:SetCondition(s.protcon)
	e1:SetValue(1)
	c:RegisterEffect(e1)
	-- Cannot banish Spells/Traps
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e2:SetCode(EFFECT_CANNOT_REMOVE)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTargetRange(1,1)
	e2:SetTarget(s.rmlimit)
	e2:SetCondition(s.protcon)
	c:RegisterEffect(e2)
	--Detach and Attach
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,0))
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_SZONE)
	e3:SetCountLimit(1)
	e3:SetCost(s.atcost)
	e3:SetTarget(s.attg)
	e3:SetOperation(s.atop)
	c:RegisterEffect(e3)
	--Draw card
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,1))
	e4:SetCategory(CATEGORY_DRAW)
	e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e4:SetCode(EVENT_CHAINING)
	e4:SetProperty(EFFECT_FLAG_DELAY)
	e4:SetRange(LOCATION_SZONE)
	e4:SetCountLimit(1,id)
	e4:SetCondition(s.drcon)
	e4:SetTarget(s.drtg)
	e4:SetOperation(s.drop)
	c:RegisterEffect(e4)
end
s.listed_series={SET_SHINING_BRIGADE}

function s.prottg(e,c)
	return c:IsSetCard(SET_SHINING_BRIGADE) and c:IsType(TYPE_SPELL+TYPE_TRAP)
end
function s.rmlimit(e,c,rp,r,re)
	return c:IsControler(e:GetHandlerPlayer()) and c:IsSetCard(SET_SHINING_BRIGADE) and c:IsType(TYPE_SPELL+TYPE_TRAP)
end
function s.protcon(e)
	return Duel.IsExistingMatchingCard(aux.FilterBoolFunction(Card.IsSetCard,SET_SHINING_BRIGADE),e:GetHandlerPlayer(),LOCATION_MZONE,0,2,nil)
end
function s.xyzfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_SHINING_BRIGADE) and c:IsType(TYPE_XYZ) and c:GetOverlayCount()>0
end
s.attfilter=aux.FilterBoolFunction(Card.IsSetCard,SET_SHINING_BRIGADE)
function s.atcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.xyzfilter,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.attfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local xyz=Duel.SelectMatchingCard(tp,s.xyzfilter,tp,LOCATION_MZONE,0,1,1,nil):GetFirst()
	if not xyz then return end
	xyz:RemoveOverlayCard(tp,1,1,REASON_COST)
	e:SetLabelObject(xyz)
end
function s.attg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.attfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil) end
end
function s.atop(e,tp,eg,ep,ev,re,r,rp)
	local xyz=e:GetLabelObject()
	if not (xyz and xyz:IsFaceup() and xyz:IsLocation(LOCATION_MZONE)
		and xyz:IsControler(tp) and xyz:IsSetCard(SET_SHINING_BRIGADE) and xyz:IsType(TYPE_XYZ)) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local g2=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.attfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil)
	if #g2>0 then
		Duel.Overlay(xyz,g2)
	end
end
function s.drcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==tp and re:GetHandler():IsSetCard(SET_SHINING_BRIGADE) and re:IsActiveType(TYPE_MONSTER)
end
function s.drtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end
	Duel.SetTargetPlayer(tp)
	Duel.SetTargetParam(1)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
end
function s.drop(e,tp,eg,ep,ev,re,r,rp)
	local p,d=Duel.GetChainInfo(0,CHAININFO_TARGET_PLAYER,CHAININFO_TARGET_PARAM)
	Duel.Draw(p,d,REASON_EFFECT)
end
