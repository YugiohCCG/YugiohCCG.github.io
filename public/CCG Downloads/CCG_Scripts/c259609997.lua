--A.I.P Ex Larva
local s,id=GetID()
local SET_AIP=0xa979
local STRING_ID=id
local EFFECT_FLAG_SET_AVAILABLE=EFFECT_FLAG_SET_AVAILABLE or 0
local AIP_EX_MONSTERS={
	[259609997]=true,
	[259664027]=true,
	[259137697]=true,
	[259522807]=true,
	[259121126]=true,
	[259465391]=true,
	[259097228]=true,
}
function s.initial_effect(c)
	--Special Summon itself from the hand
	local e0=Effect.CreateEffect(c)
	e0:SetDescription(aux.Stringid(STRING_ID,0))
	e0:SetType(EFFECT_TYPE_FIELD)
	e0:SetProperty(EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_PROC)
	e0:SetRange(LOCATION_HAND)
	e0:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e0:SetCondition(s.spcon)
	c:RegisterEffect(e0)
	--Draw 1, reveal it, then Special Summon it if it is a Beast
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,1))
	e1:SetCategory(CATEGORY_DRAW+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SUMMON_SUCCESS)
	e1:SetCountLimit(1,id+100)
	e1:SetTarget(s.drtg)
	e1:SetOperation(s.drop)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e2)
	--Tribute this card; allow an "A.I.P" Trap to be activated the turn it is Set
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,2))
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_CHAINING)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+200)
	e3:SetCondition(s.trapcon)
	e3:SetCost(s.selfrelcost)
	e3:SetOperation(s.trapop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_AIP}
function s.isaip_ex(c)
	return c:IsFaceup() and c:IsSetCard(SET_AIP) and c:IsType(TYPE_MONSTER) and not c:IsCode(259275822)
end
function s.spcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.isaip_ex,tp,LOCATION_MZONE,0,1,nil)
end
function s.drtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
end
function s.drop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.Draw(tp,1,REASON_EFFECT)==0 then return end
	local g=Duel.GetOperatedGroup()
	local tc=g:GetFirst()
	if not tc then return end
	Duel.ConfirmCards(1-tp,Group.FromCards(tc))
	if tc:IsRace(RACE_BEAST) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,3)) then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	else
		Duel.ShuffleHand(tp)
	end
end
function s.trapcon(e,tp,eg,ep,ev,re,r,rp)
	return re:IsActiveType(TYPE_MONSTER) and re:GetHandler() and re:GetHandler():IsRace(RACE_BEAST)
end
function s.selfrelcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsReleasable() end
	Duel.Release(c,REASON_COST)
end
function s.trapfilter(e,c)
	return Duel.GetFlagEffect(e:GetHandlerPlayer(),id)==0
		and c:IsSetCard(SET_AIP) and c:IsType(TYPE_TRAP)
		and (not STATUS_SET_TURN or c:IsStatus(STATUS_SET_TURN))
end
function s.trapop(e,tp,eg,ep,ev,re,r,rp)
	if not EFFECT_TRAP_ACT_IN_SET_TURN then return end
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
	e1:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
	e1:SetTargetRange(LOCATION_SZONE,0)
	e1:SetTarget(s.trapfilter)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
	local e2=Effect.CreateEffect(e:GetHandler())
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e2:SetCode(EVENT_CHAINING)
	e2:SetOperation(s.trapused)
	e2:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e2,tp)
end
function s.trapused(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	if rp==tp and rc and rc:IsSetCard(SET_AIP) and rc:IsType(TYPE_TRAP)
		and (not STATUS_SET_TURN or rc:IsStatus(STATUS_SET_TURN)) then
		Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
		e:Reset()
	end
end
