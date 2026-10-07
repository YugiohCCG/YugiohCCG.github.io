--Talismandrake Arms United
--Cleaned and audited replacement script for YGO Omega
local s,id=GetID()
local SET_TALISMANDRAKE=0xb47
local SET_TALISMANDRAKE_ARMS=0x452f
function s.initial_effect(c)
	--Activate: Discard 1; place up to 2 "Talismandrake" Pendulum Monsters in Pendulum Zones
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.cost)
	e1:SetTarget(s.pztg)
	e1:SetOperation(s.pzop)
	c:RegisterEffect(e1)
	--Equip 1 "Talismandrake Arms" from Deck to a Special Summoned Pyro Fusion Monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_EQUIP)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,{id,1})
	e2:SetCondition(s.eqcon)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.eqtg)
	e2:SetOperation(s.eqop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_TALISMANDRAKE,SET_TALISMANDRAKE_ARMS}

function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,e:GetHandler()) end
	Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_COST+REASON_DISCARD,e:GetHandler())
end
function s.pzfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_PENDULUM) and not c:IsForbidden()
		and (c:IsLocation(LOCATION_DECK) or (c:IsLocation(LOCATION_EXTRA) and c:IsFaceup()))
end
function s.pztg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=0
	if Duel.CheckLocation(tp,LOCATION_PZONE,0) then ct=ct+1 end
	if Duel.CheckLocation(tp,LOCATION_PZONE,1) then ct=ct+1 end
	if chk==0 then return ct>0 and Duel.IsExistingMatchingCard(s.pzfilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,1,nil) end
end
function s.pzop(e,tp,eg,ep,ev,re,r,rp)
	local ct=0
	if Duel.CheckLocation(tp,LOCATION_PZONE,0) then ct=ct+1 end
	if Duel.CheckLocation(tp,LOCATION_PZONE,1) then ct=ct+1 end
	if ct<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
	local g=Duel.SelectMatchingCard(tp,s.pzfilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,1,ct,nil)
	for tc in aux.Next(g) do
		Duel.MoveToField(tc,tp,tp,LOCATION_PZONE,POS_FACEUP,true)
	end
end
function s.armsfilter(c,tc)
	return c:IsSetCard(SET_TALISMANDRAKE_ARMS) and c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsForbidden()
end
function s.cfilter(c,tp,e)
	return c:IsControler(tp) and c:IsRace(RACE_PYRO) and c:IsType(TYPE_FUSION) and c:IsFaceup()
		and (not e or c:IsCanBeEffectTarget(e))
		and Duel.IsExistingMatchingCard(s.armsfilter,tp,LOCATION_DECK,0,1,nil,c)
end
function s.eqcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetCurrentPhase()&(PHASE_DAMAGE+PHASE_DAMAGE_CAL)==0 and eg:IsExists(s.cfilter,1,nil,tp,nil)
end
function s.eqtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and eg:IsContains(chkc) and s.cfilter(chkc,tp,e) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and eg:IsExists(s.cfilter,1,nil,tp,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=eg:FilterSelect(tp,s.cfilter,1,1,nil,tp,e)
	Duel.SetTargetCard(g)
	Duel.SetOperationInfo(0,CATEGORY_EQUIP,nil,1,tp,LOCATION_DECK)
end
function s.eqop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsFaceup() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
	local g=Duel.SelectMatchingCard(tp,s.armsfilter,tp,LOCATION_DECK,0,1,1,nil,tc)
	local ec=g:GetFirst()
	if not ec then return end
	if not Duel.Equip(tp,ec,tc) then return end
	--Equip limit and state
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CHANGE_TYPE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetValue(TYPE_SPELL+TYPE_EQUIP)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	ec:RegisterEffect(e1)
	local e2=Effect.CreateEffect(e:GetHandler())
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_EQUIP_LIMIT)
	e2:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e2:SetValue(function(e,c) return c==tc end)
	e2:SetReset(RESET_EVENT+RESETS_STANDARD)
	ec:RegisterEffect(e2)
end
