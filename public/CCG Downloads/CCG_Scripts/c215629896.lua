--NiuHao - Zaoka
local s,id=GetID()
local SET_NIUHAO=0xb69
local SACRED_TREASURE_CODES={
	[236542835]=true,
	[229499914]=true,
	[246421842]=true,
}
function s.initial_effect(c)
	--If Normal or Special Summoned: add 1 "NiuHao" or "Sacred Treasure" card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SUMMON_SUCCESS)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.thtg)
	e1:SetOperation(s.thop)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e2)
	--Banish this card; excavate the top 3 cards
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_REMOVE+CATEGORY_TOGRAVE)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_CHAINING)
	e3:SetRange(LOCATION_HAND+LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.excon)
	e3:SetCost(s.selfcost)
	e3:SetTarget(s.extg)
	e3:SetOperation(s.exop)
	c:RegisterEffect(e3)
	--Register this card being banished
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
	e4:SetCode(EVENT_REMOVE)
	e4:SetOperation(s.regop)
	c:RegisterEffect(e4)
	--Special Summon this banished card during the next Standby Phase
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(id,2))
	e5:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e5:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e5:SetCode(EVENT_PHASE+PHASE_STANDBY)
	e5:SetRange(LOCATION_REMOVED)
	e5:SetCountLimit(1,id+200)
	e5:SetCondition(s.selfspcon)
	e5:SetTarget(s.selfsptg)
	e5:SetOperation(s.selfspop)
	c:RegisterEffect(e5)
end
function s.niucard(c)
	return c:IsSetCard(SET_NIUHAO) or SACRED_TREASURE_CODES[c:GetCode()]
end
function s.thfilter(c)
	return s.niucard(c) and c:IsAbleToHand()
		and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE+LOCATION_REMOVED) and s.thfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.thfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,s.thfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and s.thfilter(tc) then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
	end
end
function s.excon(e,tp,eg,ep,ev,re,r,rp)
	local loc=Duel.GetChainInfo(ev,CHAININFO_TRIGGERING_LOCATION)
	return rp==1-tp and ((loc&LOCATION_ONFIELD)~=0 or (loc&LOCATION_REMOVED)~=0)
end
function s.selfcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToRemoveAsCost()
		and (c:IsLocation(LOCATION_HAND) or c:IsFaceup()) end
	Duel.Remove(c,POS_FACEUP,REASON_COST)
end
function s.excfilter(c)
	return s.niucard(c) and c:IsAbleToGrave()
end
function s.extg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)>0 end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.exop(e,tp,eg,ep,ev,re,r,rp)
	local ct=math.min(3,Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
	if ct<=0 then return end
	Duel.ConfirmDecktop(tp,ct)
	local g=Duel.GetDecktopGroup(tp,ct)
	local sg=g:Filter(s.excfilter,nil)
	if #sg>0 then
		Duel.DisableShuffleCheck()
		Duel.SendtoGrave(sg,REASON_EFFECT)
	end
	if #sg<ct then
		Duel.ShuffleDeck(tp)
	end
end
function s.regop(e,tp,eg,ep,ev,re,r,rp)
	e:GetHandler():RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_STANDBY,0,2,Duel.GetTurnCount())
end
function s.selfspcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local ct=c:GetFlagEffectLabel(id)
	local tn=Duel.GetTurnCount()
	if not ct or tn==ct then
		c:ResetFlagEffect(id)
		return false
	end
	return tn==ct+1
end
function s.selfsptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.selfspop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
		Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
	end
end
