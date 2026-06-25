--Maiden of Talismandrakes Seraphina
local s,id=GetID()
local SET_TALISMANDRAKE=0xb47
local CARD_ARMS_UNITED=215034223
local CARD_SUPPRESSOR=238136421
local CARD_HALBERD=215921734
local CARD_SABRE=248788543
local CARD_SHIELD=255832330
function s.initial_effect(c)
	aux.EnablePendulumAttribute(c)
	c:EnableReviveLimit()
	aux.AddFusionProcFunFunRep(c,s.pyropend,aux.FilterBoolFunction(Card.IsFusionSetCard,SET_TALISMANDRAKE),2,2,true)
	--Pendulum effect: shuffle 3, Special Summon, then equip
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON+CATEGORY_EQUIP)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_PZONE)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCost(s.pcost)
	e1:SetTarget(s.psptg)
	e1:SetOperation(s.pspop)
	c:RegisterEffect(e1)
	--If Fusion Summoned: add or equip 1 "Talismandrake Arms" Spell/Trap
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_EQUIP)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e2:SetCondition(s.fuscon)
	e2:SetTarget(s.gytg)
	e2:SetOperation(s.gyop)
	c:RegisterEffect(e2)
	--If your opponent activates a card or effect: add or equip 1 "Talismandrake Arms" Spell/Trap
	local e3=e2:Clone()
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_CHAINING)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCondition(s.oppcon)
	c:RegisterEffect(e3)
	--Place this card in your Pendulum Zone
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,2))
	e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e4:SetProperty(EFFECT_FLAG_DELAY)
	e4:SetCode(EVENT_LEAVE_FIELD)
	e4:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e4:SetCondition(s.pencon)
	e4:SetTarget(s.pentg)
	e4:SetOperation(s.penop)
	c:RegisterEffect(e4)
	--Destroy all cards your opponent controls
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(id,3))
	e5:SetCategory(CATEGORY_DESTROY)
	e5:SetType(EFFECT_TYPE_QUICK_O)
	e5:SetCode(EVENT_FREE_CHAIN)
	e5:SetRange(LOCATION_MZONE)
	e5:SetCondition(s.descon)
	e5:SetCost(s.descost)
	e5:SetTarget(s.destg)
	e5:SetOperation(s.desop)
	c:RegisterEffect(e5)
end
function s.pyropend(c)
	return c:IsRace(RACE_PYRO) and c:IsFusionType(TYPE_PENDULUM)
end
function s.pcostfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_MONSTER)
		and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
		and c:IsAbleToDeckOrExtraAsCost()
end
function s.pcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.pcostfilter),tp,LOCATION_ONFIELD+LOCATION_GRAVE+LOCATION_EXTRA,0,c)
	if chk==0 then return g:CheckSubGroup(aux.dncheck,3,3) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local sg=g:SelectSubGroup(tp,aux.dncheck,false,3,3)
	Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_COST)
end
function s.psptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_EQUIP,nil,1,tp,LOCATION_GRAVE)
end
function s.pspop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0
		and c:IsFaceup() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0) then return end
	if Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.equiparmsfilter),tp,LOCATION_GRAVE,0,1,nil)
		and Duel.SelectYesNo(tp,aux.Stringid(id,5)) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
		local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.equiparmsfilter),tp,LOCATION_GRAVE,0,1,1,nil)
		local ec=g:GetFirst()
		if ec then
			s.equipcard(e,tp,ec,c)
		end
	end
end
function s.fuscon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_FUSION)
end
function s.oppcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp
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
function s.gytgfilter(c,e,tp)
	return s.armsfilter(c) and (c:IsAbleToHand()
		or (s.equiparmsfilter(c) and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and e:GetHandler():IsFaceup() and e:GetHandler():IsLocation(LOCATION_MZONE)))
end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE)
		and aux.NecroValleyFilter(s.gytgfilter)(chkc,e,tp) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.gytgfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.gytgfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
	local tc=g:GetFirst()
	if tc and tc:IsAbleToHand() then
		Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
	end
	if tc and s.equiparmsfilter(tc) and e:GetHandler():IsFaceup() and e:GetHandler():IsLocation(LOCATION_MZONE)
		and Duel.GetLocationCount(tp,LOCATION_SZONE)>0 then
		Duel.SetOperationInfo(0,CATEGORY_EQUIP,g,1,0,0)
	end
end
function s.gyop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter(s.gytgfilter)(tc,e,tp)) then return end
	local b1=tc:IsAbleToHand()
	local b2=s.equiparmsfilter(tc) and c:IsRelateToEffect(e) and c:IsFaceup()
		and c:IsLocation(LOCATION_MZONE) and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(id,4),aux.Stringid(id,5))
	elseif b1 then
		Duel.SelectOption(tp,aux.Stringid(id,4))
		op=0
	else
		Duel.SelectOption(tp,aux.Stringid(id,5))
		op=1
	end
	if op==0 then
		if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,tc)
		end
	else
		s.equipcard(e,tp,tc,c)
	end
end
function s.equipcard(e,tp,ec,tc)
	if not (ec and tc and s.equiparmsfilter(ec) and tc:IsFaceup() and Duel.GetLocationCount(tp,LOCATION_SZONE)>0) then return false end
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
function s.pencon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousPosition(POS_FACEUP) and c:IsPreviousControler(tp)
end
function s.pentg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1) end
end
function s.penop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) then
		Duel.MoveToField(c,tp,tp,LOCATION_PZONE,POS_FACEUP,true)
	end
end
function s.eqbycode(c,tc,code1,code2)
	return c:IsFaceup() and c:GetEquipTarget()==tc and c:IsCode(code1,code2)
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return Duel.IsExistingMatchingCard(s.eqbycode,tp,LOCATION_SZONE,LOCATION_SZONE,1,nil,c,CARD_SUPPRESSOR,CARD_SHIELD)
		and Duel.IsExistingMatchingCard(s.eqbycode,tp,LOCATION_SZONE,LOCATION_SZONE,1,nil,c,CARD_HALBERD,CARD_SABRE)
end
function s.descost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckLPCost(tp,1000) and Duel.GetFlagEffect(tp,id+200)==0 end
	Duel.PayLPCost(tp,1000)
	Duel.RegisterFlagEffect(tp,id+200,RESET_PHASE+PHASE_END,0,2)
end
function s.desfilter(c)
	return c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.desfilter,tp,0,LOCATION_ONFIELD,1,nil) end
	local g=Duel.GetMatchingGroup(s.desfilter,tp,0,LOCATION_ONFIELD,nil)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,#g,0,0)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and c:IsFaceup() and s.descon(e,tp,eg,ep,ev,re,r,rp)) then return end
	local g=Duel.GetMatchingGroup(s.desfilter,tp,0,LOCATION_ONFIELD,nil)
	if #g>0 then
		Duel.Destroy(g,REASON_EFFECT)
	end
end
