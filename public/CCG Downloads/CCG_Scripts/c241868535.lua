--Pedicaes Papa
local s,id=GetID()
local SET_VIR_PEDICAE_MORTIS=0x39e2
local CARD_BEAR_TRAP=251699681
local CARD_RECOLLECTION_STATIC=211086520
local CARD_RECOLLECTION_IRON=234984156
local CARD_RECOLLECTION_MINE=231872299
local CARD_RECOLLECTION_KABOOM=241447408
function s.initial_effect(c)
	--If Normal or Special Summoned: add "Bear Trap" or "Mine"
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
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
	--If your "Vir Pedicae Mortis" monster battles: send 1 "Recollection"; it gains 500 ATK
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_TOGRAVE+CATEGORY_ATKCHANGE)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_BATTLE_START)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.atkcon)
	e3:SetTarget(s.atktg)
	e3:SetOperation(s.atkop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_VIR_PEDICAE_MORTIS}
s.listed_names={CARD_BEAR_TRAP,CARD_RECOLLECTION_STATIC,CARD_RECOLLECTION_IRON,CARD_RECOLLECTION_MINE,CARD_RECOLLECTION_KABOOM}
function s.thfilter(c)
	return (c:IsCode(CARD_BEAR_TRAP) or (c:IsCode(CARD_RECOLLECTION_MINE) and c:IsType(TYPE_FIELD))) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then
		Duel.ConfirmCards(1-tp,g)
	end
end
function s.virbattler(c,tp)
	return c and c:IsControler(tp) and c:IsFaceup() and c:IsSetCard(SET_VIR_PEDICAE_MORTIS)
end
function s.atkcon(e,tp,eg,ep,ev,re,r,rp)
	return s.virbattler(Duel.GetAttacker(),tp) or s.virbattler(Duel.GetAttackTarget(),tp)
end
function s.recfilter(c)
	return c:IsCode(CARD_RECOLLECTION_STATIC,CARD_RECOLLECTION_IRON,CARD_RECOLLECTION_MINE,CARD_RECOLLECTION_KABOOM)
		and c:IsType(TYPE_SPELL) and c:IsAbleToGrave()
end
function s.atktg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.recfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.atkop(e,tp,eg,ep,ev,re,r,rp)
	local bc=Duel.GetAttacker()
	if not s.virbattler(bc,tp) then bc=Duel.GetAttackTarget() end
	if not (s.virbattler(bc,tp) and bc:IsRelateToBattle()) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.recfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 and Duel.SendtoGrave(g,REASON_EFFECT)>0 and bc:IsFaceup() and bc:IsRelateToBattle() then
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(500)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		bc:RegisterEffect(e1)
	end
end
