local s,id=GetID()
local STRING_ID=132950506
local SET_BAU=0xba8
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCost(s.actcost)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_UPDATE_ATTACK)
	e2:SetRange(LOCATION_FZONE)
	e2:SetTargetRange(0,LOCATION_MZONE)
	e2:SetValue(s.atkval)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,0))
	e3:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_REMOVE)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_FZONE)
	e3:SetCountLimit(1,id)
	e3:SetCondition(s.thcon)
	e3:SetTarget(s.thtg)
	e3:SetOperation(s.thop)
	c:RegisterEffect(e3)
end
function s.linklimit(e,c)
	return c:IsType(TYPE_LINK)
end
function s.actcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	local c=e:GetHandler()
	c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
	Duel.RegisterFlagEffect(tp,id,0,0,1)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.linklimit)
	Duel.RegisterEffect(e1,tp)
end
function s.lkfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_LINK)
end
function s.atkval(e,c)
	local g=Duel.GetMatchingGroup(s.lkfilter,e:GetHandlerPlayer(),LOCATION_MZONE,LOCATION_MZONE,nil)
	return -g:GetSum(Card.GetLink)*250
end
function s.thcon(e)
	return e:GetHandler():GetFlagEffect(id)>0 and Duel.IsMainPhase()
end
function s.baufilter(c)
	return c:IsSetCard(SET_BAU) and c:IsType(TYPE_MONSTER) and (c:IsAbleToHand()
		or c:IsAbleToRemove() and Duel.IsExistingMatchingCard(s.handfilter,c:GetControler(),LOCATION_HAND,0,1,nil))
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.baufilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,tp,LOCATION_DECK+LOCATION_HAND)
end
function s.handfilter(c)
	return c:IsAbleToRemove()
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local tc=Duel.SelectMatchingCard(tp,s.baufilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if not tc then return end
	local b1=tc:IsAbleToHand()
	local b2=tc:IsAbleToRemove() and Duel.IsExistingMatchingCard(s.handfilter,tp,LOCATION_HAND,0,1,nil)
	local op
	if b1 and b2 then op=Duel.SelectOption(tp,1190,aux.Stringid(STRING_ID,1)) elseif b1 then op=0 else op=1 end
	local ok=false
	if op==0 then
		ok=Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_HAND)
		if ok then Duel.ConfirmCards(1-tp,tc) end
	else
		ok=Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_REMOVED)
	end
	if ok and Duel.IsExistingMatchingCard(s.handfilter,tp,LOCATION_HAND,0,1,nil) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
		local rc=Duel.SelectMatchingCard(tp,s.handfilter,tp,LOCATION_HAND,0,1,1,nil):GetFirst()
		if rc then Duel.Remove(rc,POS_FACEUP,REASON_EFFECT) end
	end
end
