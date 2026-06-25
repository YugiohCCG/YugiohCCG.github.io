local s,id,o=GetID()
local SET_NEMLERIA_OMEGA=0x191
local SET_NEMLERIA_PI=0x192
local STRING_ID=id
local FLAG_ID=id
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e1)
	--excavate
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_FZONE)
	e2:SetCountLimit(1,id)
	e2:SetTarget(s.extg)
	e2:SetOperation(s.exop)
	c:RegisterEffect(e2)
	--recover
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_TOHAND)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_FZONE)
	e3:SetCountLimit(1,id+o)
	e3:SetCost(s.thcost)
	e3:SetTarget(s.thtg)
	e3:SetOperation(s.thop)
	c:RegisterEffect(e3)
	--cannot disable
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_FIELD)
	e4:SetCode(EFFECT_CANNOT_DISABLE)
	e4:SetRange(LOCATION_FZONE)
	e4:SetTargetRange(LOCATION_ONFIELD,0)
	e4:SetCondition(s.negcon)
	e4:SetTarget(s.prottg)
	c:RegisterEffect(e4)
	local e5=Effect.CreateEffect(c)
	if EFFECT_CANNOT_DISEFFECT then
		e5:SetType(EFFECT_TYPE_FIELD)
		e5:SetCode(EFFECT_CANNOT_DISEFFECT)
		e5:SetRange(LOCATION_FZONE)
		e5:SetCondition(s.negcon)
		e5:SetValue(s.negval)
		c:RegisterEffect(e5)
	end
	if not s.global_check then
		s.global_check=true
		local ge1=Effect.CreateEffect(c)
		ge1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge1:SetCode(EVENT_REMOVE)
		ge1:SetOperation(s.checkop)
		Duel.RegisterEffect(ge1,0)
	end
end
function s.checkfilter(c,tp)
	return c:IsPreviousLocation(LOCATION_EXTRA) and c:IsPreviousControler(tp)
		and c:IsFacedown() and c:GetReasonPlayer()==tp
end
function s.checkop(e,tp,eg,ep,ev,re,r,rp)
	for p=0,1 do
		local ct=eg:FilterCount(s.checkfilter,nil,p)
		for i=1,ct do
			Duel.RegisterFlagEffect(p,FLAG_ID,RESET_PHASE+PHASE_END,0,1)
		end
	end
end
function s.spfilter(c,e,tp)
	return (c:IsSetCard(SET_NEMLERIA_OMEGA) or c:IsSetCard(SET_NEMLERIA_PI))
		and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.extg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=math.min(math.floor(Duel.GetMatchingGroupCount(Card.IsFacedown,tp,LOCATION_REMOVED,0,nil)/2),Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
	if chk==0 then return ct>0 end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,math.min(ct,2),tp,LOCATION_DECK)
end
function s.exop(e,tp,eg,ep,ev,re,r,rp)
	local ct=math.min(math.floor(Duel.GetMatchingGroupCount(Card.IsFacedown,tp,LOCATION_REMOVED,0,nil)/2),Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
	if ct<=0 then return end
	Duel.ConfirmDecktop(tp,ct)
	local g=Duel.GetDecktopGroup(tp,ct)
	local ft=math.min(2,Duel.GetLocationCount(tp,LOCATION_MZONE))
	local sg=g:Filter(s.spfilter,nil,e,tp)
	if ft>0 and #sg>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
		if Duel.DisableShuffleCheck then
			Duel.DisableShuffleCheck()
		end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local tg=sg:Select(tp,1,math.min(ft,#sg),nil)
		if #tg>0 then
			Duel.SpecialSummon(tg,0,tp,tp,false,false,POS_FACEUP)
		end
	end
end
function s.exfilter(c)
	return c:IsFacedown() and c:IsAbleToRemoveAsCost(POS_FACEDOWN) and not c:IsCode(70155677)
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local g=Duel.GetMatchingGroup(s.exfilter,tp,LOCATION_EXTRA,0,nil)
	if chk==0 then return #g>=2 end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local rg=g:Select(tp,2,2,nil)
	Duel.Remove(rg,POS_FACEDOWN,REASON_COST)
end
function s.thfilter(c)
	return (c:IsSetCard(SET_NEMLERIA_OMEGA) or c:IsSetCard(SET_NEMLERIA_PI)) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_GRAVE,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_GRAVE)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_GRAVE,0,1,1,nil)
	if #g>0 then
		Duel.SendtoHand(g,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,g)
	end
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetFlagEffect(tp,FLAG_ID)>=5
end
function s.prottg(e,c)
	return c:IsControler(e:GetHandlerPlayer())
end
function s.negval(e,ct)
	local tp=e:GetHandlerPlayer()
	local te,loc,p=Duel.GetChainInfo(ct,CHAININFO_TRIGGERING_EFFECT,CHAININFO_TRIGGERING_LOCATION,CHAININFO_TRIGGERING_PLAYER)
	local tc=te and te:GetHandler()
	return p==tp and tc and tc:IsOnField() and tc:IsControler(tp) and (loc&LOCATION_ONFIELD)~=0
end
