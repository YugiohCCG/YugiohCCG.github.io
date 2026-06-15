--The Hanging Frute
local s,id=GetID()
local SET_FRUTE=0x813
local CARD_FRUTEIFICATION=256930605
local RESET_CHAIN_COMPAT=RESET_CHAIN or (RESET_PHASE+PHASE_END)
function s.initial_effect(c)
	c:EnableReviveLimit()
	--"Frute" monsters can attack all face-down Defense Position monsters once each
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_ATTACK_ANNOUNCE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetOperation(s.atkop)
	c:RegisterEffect(e1)
	--If Special Summoned: Special Summon 1 "Frute" monster from your GY face-down
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id)
	e2:SetTarget(s.sptg)
	e2:SetOperation(s.spop)
	c:RegisterEffect(e2)
	--Tribute 1 other WATER monster; protect your monsters
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_RELEASE+CATEGORY_POSITION)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_CHAINING)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.immcon)
	e3:SetCost(s.immcost)
	e3:SetTarget(s.immtg)
	e3:SetOperation(s.immop)
	c:RegisterEffect(e3)
end
s.listed_names={CARD_FRUTEIFICATION}
s.listed_series={SET_FRUTE}
function s.fddef(c)
	return c:IsFacedown() and c:IsDefensePos()
end
function s.atklimit(e,c)
	return not s.fddef(c)
end
function s.atkop(e,tp,eg,ep,ev,re,r,rp)
	local ac=Duel.GetAttacker()
	local bc=ac and ac:GetBattleTarget()
	if not (ac and bc and ac:IsControler(tp) and ac:IsFaceup() and ac:IsSetCard(SET_FRUTE)
		and bc:IsControler(1-tp) and s.fddef(bc) and ac:GetFlagEffect(id)==0) then return end
	local ct=Duel.GetMatchingGroupCount(s.fddef,tp,0,LOCATION_MZONE,nil)-1
	ac:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_BATTLE,0,1)
	if ct<=0 then return end
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_EXTRA_ATTACK_MONSTER)
	e1:SetValue(ct)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_BATTLE)
	ac:RegisterEffect(e1)
	local e2=Effect.CreateEffect(e:GetHandler())
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_CANNOT_SELECT_BATTLE_TARGET)
	e2:SetValue(s.atklimit)
	e2:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_BATTLE)
	ac:RegisterEffect(e2)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER) and aux.NecroValleyFilter()(c)
		and not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 or Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT) then return end
	if not Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_GRAVE,0,1,nil,e,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)
	end
end
function s.immcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp
end
function s.rlfilter(c,sc)
	return c:IsAttribute(ATTRIBUTE_WATER) and c:IsReleasable() and c~=sc
end
function s.immcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.IsExistingMatchingCard(s.rlfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,c,c) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=Duel.SelectMatchingCard(tp,s.rlfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,c,c)
	Duel.Release(g,REASON_COST)
end
function s.immtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	local g=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil)
	Duel.SetOperationInfo(0,CATEGORY_POSITION,nil,1,1-tp,LOCATION_MZONE)
end
function s.immfilter(e,re)
	for i=1,e:GetLabel() do
		local te=Duel.GetChainInfo(i,CHAININFO_TRIGGERING_EFFECT)
		if te==re then return true end
	end
	return false
end
function s.immop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
	e1:SetCode(EFFECT_IMMUNE_EFFECT)
	e1:SetTargetRange(LOCATION_MZONE,0)
	e1:SetValue(s.immfilter)
	e1:SetLabel(ev)
	e1:SetReset(RESET_CHAIN_COMPAT)
	Duel.RegisterEffect(e1,tp)
	local rc=re:GetHandler()
	if re:IsActiveType(TYPE_MONSTER) and rc:IsControler(1-tp) and rc:IsLocation(LOCATION_MZONE)
		and rc:IsFaceup() and rc:IsRelateToEffect(re) and rc:IsCanTurnSet()
		and not Duel.IsPlayerAffectedByEffect(1-tp,EFFECT_DIVINE_LIGHT) then
		Duel.BreakEffect()
		Duel.ChangePosition(rc,POS_FACEDOWN_DEFENSE)
	end
end
