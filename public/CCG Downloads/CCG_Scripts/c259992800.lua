--Red-Eyes Moon Dragon
local s,id=GetID()
local SET_REDEYES=0x3b
local SET_REDEYES_CUSTOM=0xfacc
local STRING_ID=id
function s.initial_effect(c)
	--Equip this card from hand/GY to a monster you control
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_EQUIP)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND+LOCATION_GRAVE)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.eqtg)
	e1:SetOperation(s.eqop)
	c:RegisterEffect(e1)
	--Equipped: destroy another Dragon/Warrior/Fiend Monster Card; add 1 "Red-Eyes" monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_DESTROY+CATEGORY_TOHAND+CATEGORY_SEARCH)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_SZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.descon)
	e2:SetTarget(s.destg)
	e2:SetOperation(s.desop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_REDEYES,SET_REDEYES_CUSTOM}
function s.isredeyes(c)
	return c:IsSetCard(SET_REDEYES) or c:IsSetCard(SET_REDEYES_CUSTOM)
end
function s.eqlimit(e,c)
	return c==e:GetLabelObject()
end
function s.equipcard(e,tp,ec,tc,redirect)
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return false end
	if not Duel.Equip(tp,ec,tc) then return false end
	local e0=Effect.CreateEffect(e:GetHandler())
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetCode(EFFECT_CHANGE_TYPE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e0:SetReset(RESET_EVENT+RESETS_STANDARD)
	e0:SetValue(TYPE_SPELL+TYPE_EQUIP)
	ec:RegisterEffect(e0)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_EQUIP_LIMIT)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	e1:SetLabelObject(tc)
	e1:SetValue(s.eqlimit)
	ec:RegisterEffect(e1)
	if redirect then
		local e2=Effect.CreateEffect(e:GetHandler())
		e2:SetType(EFFECT_TYPE_SINGLE)
		e2:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
		e2:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		e2:SetReset(RESET_EVENT+RESETS_STANDARD)
		e2:SetValue(LOCATION_REMOVED)
		ec:RegisterEffect(e2)
	end
	return true
end
function s.eqtarget(c,e)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsCanBeEffectTarget(e)
end
function s.eqtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(tp) and s.eqtarget(chkc,e) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and (not e:GetHandler():IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(e:GetHandler()))
		and Duel.IsExistingTarget(s.eqtarget,tp,LOCATION_MZONE,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
	Duel.SelectTarget(tp,s.eqtarget,tp,LOCATION_MZONE,0,1,1,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_EQUIP,e:GetHandler(),1,0,0)
end
function s.eqop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	local from_gy=c:IsLocation(LOCATION_GRAVE)
	if c:IsRelateToEffect(e) and aux.NecroValleyFilter()(c)
		and tc and tc:IsRelateToEffect(e) and tc:IsControler(tp)
		and tc:IsLocation(LOCATION_MZONE) and tc:IsFaceup() then
		s.equipcard(e,tp,c,tc,from_gy)
	end
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:GetEquipTarget()~=nil
end
function s.desfilter(c,ec)
	local race=c:GetOriginalRace()
	return c~=ec and (c:GetOriginalType()&TYPE_MONSTER)~=0
		and (race&(RACE_DRAGON+RACE_WARRIOR+RACE_FIEND))~=0
		and c:IsDestructable()
end
function s.thfilter(c)
	return s.isredeyes(c) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_MZONE+LOCATION_SZONE,LOCATION_MZONE+LOCATION_SZONE,1,nil,e:GetHandler())
		and Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,PLAYER_ALL,LOCATION_MZONE+LOCATION_SZONE)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local dg=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_MZONE+LOCATION_SZONE,LOCATION_MZONE+LOCATION_SZONE,1,1,nil,e:GetHandler())
	if #dg>0 and Duel.Destroy(dg,REASON_EFFECT)>0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
		if #g>0 then
			Duel.BreakEffect()
			Duel.SendtoHand(g,nil,REASON_EFFECT)
			Duel.ConfirmCards(1-tp,g)
		end
	end
end
