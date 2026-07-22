-- Phlogistic Scorching Dragon Horde
local s,id=GetID()
local STRING_ID=132303021
function s.initial_effect(c)
	-- fusion summon
	c:EnableReviveLimit()
	aux.AddFusionProcMixRep(c,true,true,s.ffilter2,2,2,s.ffilter1)
	-- name change
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CHANGE_CODE)
	e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e1:SetRange(LOCATION_MZONE+LOCATION_GRAVE)
	e1:SetValue(242094473)
	c:RegisterEffect(e1)
	-- destroy
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_DESTROY)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.descon)
	e2:SetTarget(s.destg)
	e2:SetOperation(s.desop)
	c:RegisterEffect(e2)
	-- send lists
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_TOGRAVE)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_TO_GRAVE)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id+1)
	e3:SetTarget(s.hordetg)
	e3:SetOperation(s.hordeop)
	c:RegisterEffect(e3)
	-- global tracking
	if not s.global_check then
		s.global_check=true
		s[0]=0
		s[1]=0
		local ge1=Effect.CreateEffect(c)
		ge1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge1:SetCode(EVENT_PAY_LPCOST)
		ge1:SetOperation(s.paylpcheckop)
		Duel.RegisterEffect(ge1,0)
		local ge2=Effect.CreateEffect(c)
		ge2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge2:SetCode(EVENT_TURN_END)
		ge2:SetOperation(s.clear)
		Duel.RegisterEffect(ge2,0)
	end
end
function s.ffilter1(c)
	return c:IsCode(242094473) and c:IsLevel(8)
end
function s.ffilter2(c)
	return c:IsAttribute(ATTRIBUTE_FIRE) and not c:IsCode(242094473)
end
function s.paylpcheckop(e,tp,eg,ep,ev,re,r,rp)
	if ep==tp and Duel.IsExistingMatchingCard(s.phlogfilter,tp,LOCATION_ONFIELD,0,1,nil) then
		s[tp]=s[tp]+ev
	end
end
function s.phlogfilter(c)
	return c:IsFaceup() and c:IsCode(242094473)
end
function s.clear(e,tp,eg,ep,ev,re,r,rp)
	s[0]=0
	s[1]=0
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_FUSION)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		local lp=s[tp]
		local ct=math.floor(lp/900)
		return ct>0 and Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_ONFIELD,1,nil)
	end
	local lp=s[tp]
	local ct=math.floor(lp/900)
	local g=Duel.GetMatchingGroup(nil,tp,0,LOCATION_ONFIELD,nil)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,math.min(#g,ct),0,0)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local lp=s[tp]
	local ct=math.floor(lp/900)
	if ct<=0 then return end
	local dg=Duel.GetMatchingGroup(nil,tp,0,LOCATION_ONFIELD,nil)
	local maxct=math.min(#dg,ct)
	if maxct==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g=dg:Select(tp,maxct,maxct,nil)
	if #g>0 then
		Duel.HintSelection(g)
		Duel.Destroy(g,REASON_EFFECT)
	end
end
function s.hordefilter(c)
	return c:IsType(TYPE_MONSTER) and aux.IsCodeListed(c,242094473) and c:IsAbleToGrave()
end
function s.hordetg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.hordefilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,3,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,3,tp,LOCATION_DECK+LOCATION_EXTRA)
end
function s.hordeop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.hordefilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,3,3,nil)
	if #g==3 then
		local field_g=Duel.GetMatchingGroup(aux.AND(Card.IsFaceup,Card.IsCode),tp,LOCATION_MZONE,0,nil,242094473)
		if #field_g>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
			local sg=field_g:Select(tp,1,1,nil)
			g:Merge(sg)
		end
		local tc=g:GetFirst()
		while tc do
			if Duel.SendtoGrave(tc,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_GRAVE) then
				local e1=Effect.CreateEffect(e:GetHandler())
				e1:SetType(EFFECT_TYPE_SINGLE)
				e1:SetCode(EFFECT_CANNOT_TRIGGER)
				e1:SetReset(RESET_EVENT+RESETS_STANDARD)
				tc:RegisterEffect(e1)
			end
			tc=g:GetNext()
		end
	end
end
