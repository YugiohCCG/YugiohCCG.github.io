--Talismandrake Enkindle
local s,id=GetID()
local SET_TALISMANDRAKE=0xb47
local CARD_ARMS_UNITED=215034223
local CARD_SUPPRESSOR=238136421
local CARD_HALBERD=215921734
local CARD_SABRE=248788543
local CARD_SHIELD=255832330
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddFusionProcFun2(c,aux.FilterBoolFunction(Card.IsFusionSetCard,SET_TALISMANDRAKE),s.darkpyro,true)
	--Add or equip 1 "Talismandrake Arms" Spell/Trap
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_EQUIP)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id,EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.armstg)
	e1:SetOperation(s.armsop)
	c:RegisterEffect(e1)
	--Banish the activated card
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_REMOVE)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100,EFFECT_COUNT_CODE_OATH)
	e2:SetCondition(s.rmcon)
	e2:SetTarget(s.rmtg)
	e2:SetOperation(s.rmop)
	c:RegisterEffect(e2)
end
function s.darkpyro(c)
	return c:IsRace(RACE_PYRO) and c:IsFusionAttribute(ATTRIBUTE_DARK)
end
function s.armsfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_SPELL+TYPE_TRAP)
		and c:IsCode(CARD_ARMS_UNITED,CARD_SUPPRESSOR,CARD_HALBERD,CARD_SABRE,CARD_SHIELD)
end
function s.thfilter(c)
	return s.armsfilter(c) and c:IsAbleToHand()
end
function s.equiparmsfilter(c)
	return s.armsfilter(c) and c:IsCode(CARD_SUPPRESSOR,CARD_HALBERD,CARD_SABRE,CARD_SHIELD)
		and not c:IsForbidden()
end
function s.eqmonster(c)
	return c:IsFaceup() and c:IsRace(RACE_PYRO) and c:IsAttribute(ATTRIBUTE_DARK)
end
function s.canequip(tp)
	return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.equiparmsfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
		and Duel.IsExistingMatchingCard(s.eqmonster,tp,LOCATION_MZONE,0,1,nil)
end
function s.armstg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
			or s.canequip(tp)
	end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_EQUIP,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.armsop(e,tp,eg,ep,ev,re,r,rp)
	local b1=Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil)
	local b2=s.canequip(tp)
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))
	elseif b1 then
		Duel.SelectOption(tp,aux.Stringid(id,2))
		op=0
	else
		Duel.SelectOption(tp,aux.Stringid(id,3))
		op=1
	end
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
		if #g>0 then
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
		local eg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.equiparmsfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
		local ec=eg:GetFirst()
		if not ec then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
		local mg=Duel.SelectMatchingCard(tp,s.eqmonster,tp,LOCATION_MZONE,0,1,1,nil)
		local tc=mg:GetFirst()
		if tc then
			s.equipcard(e,tp,ec,tc)
		end
	end
end
function s.equipcard(e,tp,ec,tc)
	if not (ec and tc and s.equiparmsfilter(ec) and s.eqmonster(tc) and Duel.GetLocationCount(tp,LOCATION_SZONE)>0) then return false end
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
function s.armseqfilter(c,tp)
	local tc=c:GetEquipTarget()
	return c:IsFaceup() and c:IsType(TYPE_EQUIP) and s.equiparmsfilter(c) and tc and tc:IsControler(tp)
end
function s.rmcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and Duel.IsExistingMatchingCard(s.armseqfilter,tp,LOCATION_SZONE,LOCATION_SZONE,1,nil,tp)
		and re:GetHandler():IsAbleToRemove()
end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,re:GetHandler(),1,0,0)
end
function s.rmop(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	if rc:IsRelateToEffect(re) then
		Duel.Remove(rc,POS_FACEUP,REASON_EFFECT)
	end
end
