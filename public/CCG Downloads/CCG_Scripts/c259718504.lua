--Tove in the Wild
local s,id=GetID()
local SET_DOMESTICA=0xe302
local CARD_TOVE=259737127
local CARD_DOMESTIC_UNDERWORLD=259265448
function s.initial_effect(c)
	aux.AddMaterialCodeList(c,CARD_TOVE)
	aux.AddFusionProcFun2(c,aux.FilterBoolFunction(Card.IsFusionCode,CARD_TOVE),s.domfairy,true)
	c:EnableReviveLimit()
	--Cannot be Summoned while you control a monster
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0:SetValue(s.splimit)
	c:RegisterEffect(e0)
	--Tribute this card; return all Spell/Trap Zone cards except "Domestic Underworld"
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_RELEASE+CATEGORY_TOHAND)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.rthcon)
	e1:SetCost(s.rthcost)
	e1:SetTarget(s.rthtg)
	e1:SetOperation(s.rthop)
	c:RegisterEffect(e1)
	--If sent to the GY: return this card to the Extra Deck, then add "Tove, the Domesticated"
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TODECK+CATEGORY_TOHAND+CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
	e2:SetCode(EVENT_TO_GRAVE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetTarget(s.rettg)
	e2:SetOperation(s.retop)
	c:RegisterEffect(e2)
end
function s.domfairy(c)
	return c:IsFusionSetCard(SET_DOMESTICA) and c:IsRace(RACE_FAIRY)
end
function s.splimit(e,se,sp,st,pos,tp)
	return not Duel.IsExistingMatchingCard(aux.TRUE,sp,LOCATION_MZONE,0,1,nil)
end
function s.rthcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase() and not Duel.IsExistingMatchingCard(aux.TRUE,tp,LOCATION_MZONE,0,1,e:GetHandler())
end
function s.rthcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsReleasable() end
	Duel.Release(c,REASON_COST)
end
function s.rthfilter(c)
	return not c:IsCode(CARD_DOMESTIC_UNDERWORLD) and c:IsAbleToHand()
end
function s.rthtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.rthfilter,tp,LOCATION_SZONE,LOCATION_SZONE,1,nil) end
	local g=Duel.GetMatchingGroup(s.rthfilter,tp,LOCATION_SZONE,LOCATION_SZONE,nil)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,#g,0,0)
end
function s.rthop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(s.rthfilter,tp,LOCATION_SZONE,LOCATION_SZONE,nil)
	if #g>0 then
		Duel.SendtoHand(g,nil,REASON_EFFECT)
	end
end
function s.tovefilter(c)
	return c:IsCode(CARD_TOVE) and c:IsAbleToHand()
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToExtra() end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_HAND)
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 and c:IsLocation(LOCATION_EXTRA)) then return end
	if not Duel.IsExistingMatchingCard(s.tovefilter,tp,LOCATION_DECK,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local tc=Duel.SelectMatchingCard(tp,s.tovefilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_HAND) then
		Duel.ConfirmCards(1-tp,tc)
		Duel.BreakEffect()
		if tc:IsAbleToGrave() then
			Duel.SendtoGrave(tc,REASON_EFFECT)
		end
	end
end
