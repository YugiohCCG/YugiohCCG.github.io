--Talismandrake Arms United
local s,id=GetID()
local SET_TALISMANDRAKE=0xb47
local CARD_SUPPRESSOR=238136421
local CARD_HALBERD=215921734
local CARD_SABRE=248788543
local CARD_SHIELD=255832330
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id,EFFECT_COUNT_CODE_OATH)
	e1:SetCost(s.cost)
	e1:SetTarget(s.pztg)
	e1:SetOperation(s.pzop)
	c:RegisterEffect(e1)
	--Equip an Arms card from the Deck
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_EQUIP)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100,EFFECT_COUNT_CODE_OATH)
	e2:SetCondition(s.eqcon)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.eqtg)
	e2:SetOperation(s.eqop)
	c:RegisterEffect(e2)
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil) end
	Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_COST+REASON_DISCARD,nil)
end
function s.pzfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_PENDULUM) and c:IsType(TYPE_MONSTER)
		and (c:IsLocation(LOCATION_DECK) or c:IsFaceup())
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
	local g=Duel.SelectMatchingCard(tp,s.pzfilter,tp,LOCATION_DECK+LOCATION_EXTRA,0,1,math.min(2,ct),nil)
	for tc in aux.Next(g) do
		if Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1) then
			Duel.MoveToField(tc,tp,tp,LOCATION_PZONE,POS_FACEUP,true)
		end
	end
end
function s.cfilter(c,tp)
	return c:IsControler(tp) and c:IsRace(RACE_PYRO) and c:IsType(TYPE_FUSION)
		and Duel.IsExistingMatchingCard(s.armsfilter,tp,LOCATION_DECK,0,1,nil,c)
end
function s.eqcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetCurrentPhase()&(PHASE_DAMAGE+PHASE_DAMAGE_CAL)==0 and eg:IsExists(s.cfilter,1,nil,tp)
end
function s.armsfilter(c,tc)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_SPELL+TYPE_TRAP)
		and c:IsCode(CARD_SUPPRESSOR,CARD_HALBERD,CARD_SABRE,CARD_SHIELD)
		and not c:IsForbidden()
		and (not c:IsCode(CARD_SHIELD) or (tc:IsRace(RACE_PYRO) and tc:IsAttribute(ATTRIBUTE_DARK) and tc:IsType(TYPE_FUSION)))
		and (c:IsCode(CARD_SHIELD) or (tc:IsRace(RACE_PYRO) and tc:IsAttribute(ATTRIBUTE_DARK)))
end
function s.eqtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and eg:IsContains(chkc) and s.cfilter(chkc,tp) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and eg:IsExists(s.cfilter,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
	local g=eg:FilterSelect(tp,s.cfilter,1,1,nil,tp)
	Duel.SetTargetCard(g)
	Duel.SetOperationInfo(0,CATEGORY_EQUIP,nil,1,tp,LOCATION_DECK)
end
function s.eqop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsFaceup() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
	local g=Duel.SelectMatchingCard(tp,s.armsfilter,tp,LOCATION_DECK,0,1,1,nil,tc)
	local ec=g:GetFirst()
	if ec then
		s.equipcard(e,tp,ec,tc)
	end
end
function s.equipcard(e,tp,ec,tc)
	if not Duel.Equip(tp,ec,tc) then return false end
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
	e2:SetReset(RESET_EVENT+RESETS_STANDARD)
	e2:SetValue(function(e,c) return c==e:GetLabelObject() end)
	e2:SetLabelObject(tc)
	ec:RegisterEffect(e2)
	s.register_equip_effects(ec)
	return true
end
function s.register_equip_effects(ec)
	local code=ec:GetOriginalCode()
	if code==CARD_SUPPRESSOR then
		s.equip_atk(ec,500)
		local e1=Effect.CreateEffect(ec)
		e1:SetType(EFFECT_TYPE_EQUIP)
		e1:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
		e1:SetValue(aux.tgoval)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		ec:RegisterEffect(e1)
	elseif code==CARD_HALBERD then
		s.equip_atk(ec,500)
		local e1=Effect.CreateEffect(ec)
		e1:SetType(EFFECT_TYPE_EQUIP)
		e1:SetCode(EFFECT_PIERCE)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		ec:RegisterEffect(e1)
	elseif code==CARD_SABRE then
		local e1=Effect.CreateEffect(ec)
		e1:SetType(EFFECT_TYPE_EQUIP)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(s.sabreval)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		ec:RegisterEffect(e1)
		s.battle_replace(ec)
	elseif code==CARD_SHIELD then
		local e1=Effect.CreateEffect(ec)
		e1:SetType(EFFECT_TYPE_EQUIP)
		e1:SetCode(EFFECT_UPDATE_DEFENSE)
		e1:SetValue(s.shieldval)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		ec:RegisterEffect(e1)
		s.leave_replace(ec)
	end
end
function s.equip_atk(ec,val)
	local e1=Effect.CreateEffect(ec)
	e1:SetType(EFFECT_TYPE_EQUIP)
	e1:SetCode(EFFECT_UPDATE_ATTACK)
	e1:SetValue(val)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	ec:RegisterEffect(e1)
end
function s.eqspellfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_EQUIP) and c:GetEquipTarget()~=nil
end
function s.sabreval(e,c)
	return Duel.GetMatchingGroupCount(s.eqspellfilter,c:GetControler(),LOCATION_SZONE,0,nil)*500
end
function s.shieldval(e,c)
	return Duel.GetMatchingGroupCount(s.eqspellfilter,c:GetControler(),LOCATION_SZONE,0,nil)*500
end
function s.battle_replace(ec)
	local e1=Effect.CreateEffect(ec)
	e1:SetType(EFFECT_TYPE_EQUIP+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EFFECT_DESTROY_REPLACE)
	e1:SetTarget(s.reptg)
	e1:SetOperation(s.repop)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	ec:RegisterEffect(e1)
end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local tc=c:GetEquipTarget()
	if chk==0 then return tc and eg:IsContains(tc) and r&REASON_BATTLE~=0 and not c:IsStatus(STATUS_DESTROY_CONFIRMED) end
	return Duel.SelectEffectYesNo(tp,c,96)
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Destroy(e:GetHandler(),REASON_EFFECT+REASON_REPLACE)
end
function s.leave_replace(ec)
	local e1=Effect.CreateEffect(ec)
	e1:SetType(EFFECT_TYPE_EQUIP+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EFFECT_DESTROY_REPLACE)
	e1:SetTarget(s.shdreptg)
	e1:SetOperation(s.repop)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	ec:RegisterEffect(e1)
	local e2=Effect.CreateEffect(ec)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e2:SetCode(EFFECT_SEND_REPLACE)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTarget(s.shdsendt)
	e2:SetValue(s.shdsendv)
	e2:SetOperation(s.repop)
	e2:SetReset(RESET_EVENT+RESETS_STANDARD)
	ec:RegisterEffect(e2)
end
function s.shdreptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local tc=c:GetEquipTarget()
	if chk==0 then return tc and eg:IsContains(tc) and r&REASON_EFFECT~=0 and rp==1-tp
		and not c:IsStatus(STATUS_DESTROY_CONFIRMED) end
	return Duel.SelectEffectYesNo(tp,c,96)
end
function s.shdsendt(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local tc=c:GetEquipTarget()
	if chk==0 then return tc and eg:IsContains(tc) and r&REASON_EFFECT~=0 and rp==1-tp
		and not c:IsStatus(STATUS_DESTROY_CONFIRMED) end
	return Duel.SelectEffectYesNo(tp,c,96)
end
function s.shdsendv(e,c)
	return c==e:GetHandler():GetEquipTarget()
end
