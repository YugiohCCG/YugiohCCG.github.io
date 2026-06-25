--Aldrez Grandmaster
local s,id=GetID()
local SET_ALDREZ=0xc1c
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e1)
	--Opponent cannot activate Spell/Trap effects while an "Aldrez" monster battles
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_CANNOT_ACTIVATE)
	e2:SetRange(LOCATION_FZONE)
	e2:SetTargetRange(0,1)
	e2:SetCondition(s.actlimcon)
	e2:SetValue(s.actlimit)
	c:RegisterEffect(e2)
	--Reveal or target an "Aldrez" monster; Special Summon another with the same Link/non-Link type
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,0))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_IGNITION)
	e3:SetRange(LOCATION_FZONE)
	e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e3:SetCountLimit(1,id)
	e3:SetCondition(s.spcon)
	e3:SetTarget(s.sptg)
	e3:SetOperation(s.spop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_ALDREZ}
function s.aldrezbattle(c,tp)
	return c and c:IsFaceup() and c:IsControler(tp) and c:IsSetCard(SET_ALDREZ)
end
function s.actlimcon(e)
	local tp=e:GetHandlerPlayer()
	return s.aldrezbattle(Duel.GetAttacker(),tp) or s.aldrezbattle(Duel.GetAttackTarget(),tp)
end
function s.actlimit(e,re,tp)
	return re:IsActiveType(TYPE_SPELL+TYPE_TRAP)
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	return ph==PHASE_MAIN1 or ph==PHASE_MAIN2
end
function s.spfilter(c,e,tp,code,islink)
	return c:IsSetCard(SET_ALDREZ) and c:IsType(TYPE_MONSTER) and not c:IsCode(code)
		and c:IsType(TYPE_LINK)==(islink==1)
		and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.reffilter(c,e,tp)
	if not (c:IsSetCard(SET_ALDREZ) and c:IsType(TYPE_MONSTER)) then return false end
	if c:IsLocation(LOCATION_MZONE) and (c:IsFacedown() or not c:IsControler(tp)) then return false end
	local islink=c:IsType(TYPE_LINK) and 1 or 0
	return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,
		LOCATION_HAND+LOCATION_REMOVED,0,1,nil,e,tp,c:GetCode(),islink)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.reffilter(chkc,e,tp) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.reffilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local g=Duel.SelectMatchingCard(tp,s.reffilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,nil,e,tp)
	local rc=g:GetFirst()
	local islink=rc:IsType(TYPE_LINK) and 1 or 0
	local loc=rc:IsLocation(LOCATION_MZONE) and 1 or 0
	e:SetLabel(rc:GetCode(),islink,loc)
	if loc==1 then
		Duel.SetTargetCard(g)
	else
		Duel.ConfirmCards(1-tp,rc)
		Duel.ShuffleHand(tp)
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_REMOVED)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local code,islink,loc=e:GetLabel()
	if loc==1 then
		local rc=Duel.GetFirstTarget()
		if not (rc and rc:IsRelateToEffect(e) and rc:IsFaceup() and rc:IsControler(tp)
			and rc:IsSetCard(SET_ALDREZ) and rc:IsType(TYPE_MONSTER)) then return end
		code=rc:GetCode()
		islink=rc:IsType(TYPE_LINK) and 1 or 0
	end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,
		LOCATION_HAND+LOCATION_REMOVED,0,1,1,nil,e,tp,code,islink)
	local tc=g:GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	end
end
