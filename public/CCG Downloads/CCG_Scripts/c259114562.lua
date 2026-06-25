--Bobbie Bluefin & the Nautical Nocturnes
local s,id=GetID()
local SET_NAUTICA=0x08f0
function s.initial_effect(c)
	--Cannot be Normal Summoned/Set
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetCode(EFFECT_CANNOT_SUMMON)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_CANNOT_MSET)
	c:RegisterEffect(e2)
	--Special Summon this card, then your opponent Special Summons from their hand
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,0))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_SUMMON_SUCCESS)
	e3:SetRange(LOCATION_HAND)
	e3:SetCountLimit(1,id)
	e3:SetCondition(s.spcon)
	e3:SetTarget(s.sptg)
	e3:SetOperation(s.spop)
	c:RegisterEffect(e3)
	local e4=e3:Clone()
	e4:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e4)
end
s.listed_series={SET_NAUTICA}
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(Card.IsSummonPlayer,1,nil,1-tp)
end
function s.oppfilter(c,e,p)
	return c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,p,false,false,POS_FACEUP_ATTACK,p)
end
function s.canoppsummon(e,tp)
	local p=1-tp
	return Duel.GetLocationCount(p,LOCATION_MZONE)>0 and Duel.IsPlayerCanSpecialSummon(p)
		and Duel.IsExistingMatchingCard(s.oppfilter,p,LOCATION_HAND,0,1,nil,e,p)
end
function s.nonnautica(c)
	return not (c:IsFaceup() and c:IsSetCard(SET_NAUTICA))
end
function s.allnautica(tp)
	return Duel.IsExistingMatchingCard(Card.IsFaceup,tp,LOCATION_MZONE,0,1,nil)
		and not Duel.IsExistingMatchingCard(s.nonnautica,tp,LOCATION_MZONE,0,1,nil)
end
function s.atkzero(e,c)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_SET_ATTACK_FINAL)
	e1:SetValue(0)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
end
function s.negate(e,c)
	if not (c and c:IsFaceup() and c:IsLocation(LOCATION_MZONE)) then return end
	Duel.NegateRelatedChain(c,RESET_TURN_SET)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_DISABLE_EFFECT)
	e2:SetValue(RESET_TURN_SET)
	c:RegisterEffect(e2)
end
function s.oppsummon(e,tp)
	local p=1-tp
	if not s.canoppsummon(e,tp) then return nil end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(p,s.oppfilter,p,LOCATION_HAND,0,1,1,nil,e,p):GetFirst()
	if tc and Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP_ATTACK)>0 then
		s.atkzero(e,tc)
		return tc
	end
	return nil
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and s.canoppsummon(e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,1-tp,LOCATION_HAND)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0) then return end
	Duel.BreakEffect()
	local tc=s.oppsummon(e,tp)
	if tc and s.allnautica(tp) then
		s.negate(e,tc)
	end
end
