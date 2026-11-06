local s,id=GetID()
local STRING_ID=133932272
local SET_FLOO=0x16d
local summon_effects={
	{17827173,"thtg","thop",true},
	{18940725,"thtg","thop",false},
	{54334420,"thtg","thop",false},
	{80433039,"rmtg","rmop",true},
	{80611581,"thtg","thop",false}
}
function s.initial_effect(c)
	for _,entry in ipairs(summon_effects) do
		local e=Effect.CreateEffect(c)
		e:SetDescription(aux.Stringid(entry[1],0))
		e:SetType(EFFECT_TYPE_ACTIVATE)
		e:SetCode(EVENT_FREE_CHAIN)
		if entry[4] then e:SetProperty(EFFECT_FLAG_CARD_TARGET) end
		e:SetCost(s.showcost(entry))
		e:SetTarget(s.copytarget(entry))
		e:SetOperation(s.copyoperation(entry))
		c:RegisterEffect(e)
	end
	local e=Effect.CreateEffect(c)
	e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e:SetCode(EFFECT_DESTROY_REPLACE)
	e:SetRange(LOCATION_GRAVE)
	e:SetCountLimit(1,id)
	e:SetTarget(s.reptg)
	e:SetValue(s.repval)
	c:RegisterEffect(e)
end
function s.showfilter(c,code)
	return c:IsCode(code) and c:IsType(TYPE_MONSTER)
		and (c:IsLocation(LOCATION_HAND) or c:IsFaceup())
end
function s.callbacks(entry)
	return _G["c"..entry[1]]
end
function s.showcost(entry)
	return function(e,tp,eg,ep,ev,re,r,rp,chk)
		local code=entry[1]
		local locations=LOCATION_HAND+LOCATION_MZONE+LOCATION_REMOVED
		if chk==0 then
			local script=s.callbacks(entry)
			return Duel.GetFlagEffect(tp,code+id)==0 and script and script[entry[2]] and script[entry[3]]
				and Duel.IsExistingMatchingCard(s.showfilter,tp,locations,0,1,nil,code)
				and script[entry[2]](e,tp,eg,ep,ev,re,r,rp,0)
		end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
		local g=Duel.SelectMatchingCard(tp,s.showfilter,tp,locations,0,1,1,nil,code)
		Duel.ConfirmCards(1-tp,g)
		if g:IsExists(Card.IsLocation,1,nil,LOCATION_HAND) then Duel.ShuffleHand(tp) end
		Duel.RegisterFlagEffect(tp,code+id,RESET_PHASE+PHASE_END,0,1)
	end
end
function s.copytarget(entry)
	return function(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
		local script=s.callbacks(entry)
		if not script or not script[entry[2]] then return false end
		return script[entry[2]](e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	end
end
function s.copyoperation(entry)
	return function(e,tp,eg,ep,ev,re,r,rp)
		s.callbacks(entry)[entry[3]](e,tp,eg,ep,ev,re,r,rp)
	end
end
function s.repfilter(c,tp)
	return c:IsControler(tp) and c:IsFaceup() and c:IsLocation(LOCATION_ONFIELD)
		and (c:IsSetCard(SET_FLOO) and c:IsType(TYPE_SPELL)
			or c:IsLocation(LOCATION_MZONE) and c:IsRace(RACE_WINDBEAST) and c:IsLevelAbove(7))
		and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE)
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToRemove() and eg:IsExists(s.repfilter,1,nil,tp) end
	if not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then return false end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESREPLACE)
	local tc=eg:FilterSelect(tp,s.repfilter,1,1,nil,tp):GetFirst()
	if not tc or Duel.Remove(c,POS_FACEUP,REASON_EFFECT+REASON_REPLACE)==0 then return false end
	e:SetLabelObject(tc)
	return true
end
function s.repval(e,c)
	return c==e:GetLabelObject()
end
