--Fruteaching
local s,id=GetID()
local STRING_ID=133458749
local SET_FRUTE=0x813
local CARD_FRUTEONIA=246830897
function s.initial_effect(c)
	--Special Summon 1 "Frute" monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Change 1 monster you control to face-up or face-down Defense Position
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_POSITION)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.poscon)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.postg)
	e2:SetOperation(s.posop)
	c:RegisterEffect(e2)
end
function s.fruteoniafilter(c)
	return c:IsFaceup() and c:IsCode(CARD_FRUTEONIA)
end
function s.controls_fruteonia(tp)
	return Duel.IsExistingMatchingCard(s.fruteoniafilter,tp,LOCATION_ONFIELD,0,1,nil)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER)
		and (c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
			or (not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
				and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)))
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local loc=LOCATION_HAND+LOCATION_GRAVE
	if s.controls_fruteonia(tp) then loc=loc+LOCATION_DECK end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,loc,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,loc)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	local loc=LOCATION_HAND+LOCATION_GRAVE
	if s.controls_fruteonia(tp) then loc=loc+LOCATION_DECK end
	if not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,loc,0,1,nil,e,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,loc,0,1,1,nil,e,tp):GetFirst()
	if not tc then return end
	local b1=tc:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
	local b2=not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
		and tc:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
	local pos=POS_FACEUP_DEFENSE
	if b1 and b2 then
		if Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3))==1 then
			pos=POS_FACEDOWN_DEFENSE
		end
	elseif b2 then
		pos=POS_FACEDOWN_DEFENSE
	elseif not b1 then
		return
	end
	Duel.SpecialSummon(tc,0,tp,tp,false,false,pos)
end
function s.poscon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase() and Duel.GetTurnPlayer()==tp
end
function s.posfilter(c,tp)
	return c:IsControler(tp) and c:IsLocation(LOCATION_MZONE)
		and ((c:IsFacedown() or c:IsAttackPos())
			or (c:IsFaceup() and c:IsCanTurnSet() and not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)))
end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return s.posfilter(chkc,tp) end
	if chk==0 then return Duel.IsExistingTarget(s.posfilter,tp,LOCATION_MZONE,0,1,nil,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,s.posfilter,tp,LOCATION_MZONE,0,1,1,nil,tp)
	Duel.SetOperationInfo(0,CATEGORY_POSITION,g,1,0,0)
end
function s.posop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e)) then return end
	local b1=tc:IsFacedown() or tc:IsAttackPos()
	local b2=tc:IsFaceup() and tc:IsCanTurnSet() and not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
	if not (b1 or b2) then return end
	if b1 and b2 then
		if Duel.SelectOption(tp,aux.Stringid(STRING_ID,4),aux.Stringid(STRING_ID,5))==0 then
			Duel.ChangePosition(tc,POS_FACEUP_DEFENSE)
		else
			Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)
		end
	elseif b1 then
		Duel.ChangePosition(tc,POS_FACEUP_DEFENSE)
	else
		Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)
	end
end
