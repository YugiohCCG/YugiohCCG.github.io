local s,id=GetID()
local SET_GRAYSCALE=SET_GRAYSCALE or 0x575d
local STRING_ID=id
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e1)
	--All monsters lose 800 ATK, except LIGHT Fiend monsters
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_UPDATE_ATTACK)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTargetRange(LOCATION_MZONE,LOCATION_MZONE)
	e2:SetTarget(s.atktg)
	e2:SetValue(-800)
	c:RegisterEffect(e2)
	--Discard 1 "Grayscale" monster; draw, or discard 1 card; Set 1 "Grayscale" Spell/Trap
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,2))
	e3:SetCategory(CATEGORY_DRAW)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_SZONE)
	e3:SetCountLimit(1,id)
	e3:SetCost(s.effcost)
	e3:SetTarget(s.efftg)
	e3:SetOperation(s.effop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_GRAYSCALE}
function s.atktg(e,c)
	return not (c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsRace(RACE_FIEND))
end
function s.graymonster(c)
	return c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_MONSTER)
end
function s.graycostfilter(c)
	return s.graymonster(c) and c:IsDiscardable()
end
function s.setfilter(c)
	return c:IsSetCard(SET_GRAYSCALE) and not c:IsCode(id)
		and (c:IsType(TYPE_SPELL) or c:IsType(TYPE_TRAP)) and c:IsSSetable()
end
function s.setcostfilter(c)
	return c:IsDiscardable() and s.setfilter(c)
end
function s.effcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local can1=Duel.IsPlayerCanDraw(tp,1)
		and Duel.IsExistingMatchingCard(s.graycostfilter,tp,LOCATION_HAND,0,1,nil)
	local can2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingTarget(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE,0,1,nil)
		and Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil)
	if chk==0 then return can1 or can2 end
	local opt=0
	if can1 and can2 then
		opt=Duel.SelectOption(tp,aux.Stringid(STRING_ID,0),aux.Stringid(STRING_ID,1))
	elseif can2 then
		opt=1
	end
	e:SetLabel(opt)
	if opt==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISCARD)
		Duel.DiscardHand(tp,s.graycostfilter,1,1,REASON_COST+REASON_DISCARD)
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISCARD)
		Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_COST+REASON_DISCARD)
	end
end
function s.efftg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local opt=e:GetLabel()
	if chkc then return opt==1 and chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE)
		and aux.NecroValleyFilter(s.setfilter)(chkc) end
	if chk==0 then 
		local can1=Duel.IsPlayerCanDraw(tp,1) and Duel.IsExistingMatchingCard(s.graycostfilter,tp,LOCATION_HAND,0,1,nil)
		local can2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.IsExistingTarget(aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE,0,1,nil) and Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil)
		return can1 or can2
	end
	if opt==0 then
		Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
		local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.setfilter),tp,LOCATION_GRAVE,0,1,1,nil)
		Duel.SetOperationInfo(0,CATEGORY_LEAVE_GRAVE,g,1,tp,LOCATION_GRAVE)
	end
end
function s.effop(e,tp,eg,ep,ev,re,r,rp)
	local opt=e:GetLabel()
	if opt==0 then
		if Duel.IsPlayerCanDraw(tp,1) then
			Duel.Draw(tp,1,REASON_EFFECT)
		end
	else
		local tc=Duel.GetFirstTarget()
		if tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter()(tc)
			and Duel.GetLocationCount(tp,LOCATION_SZONE)>0 then
			Duel.SSet(tp,tc)
		end
	end
end
