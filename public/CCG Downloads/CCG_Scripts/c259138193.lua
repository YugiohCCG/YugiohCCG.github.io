--Digita Leet
local s,id=GetID()
local SET_LEET=0xfe88
local STRING_ID=id
function s.initial_effect(c)
	--Target a Cyberse monster; Special Summon this card, then maybe banish that target
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_REMOVE)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Quick Effect: Fusion Summon a Cyberse Fusion Monster using this card
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END)
	e2:SetTarget(s.fustg)
	e2:SetOperation(s.fusop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_LEET}
function s.haspositiveatkdef(c)
	return c:GetAttack()>0 or (not c:IsType(TYPE_LINK) and c:GetDefense()>0)
end
function s.zeroatkdef(c)
	return c:GetAttack()==0 and (c:IsType(TYPE_LINK) or c:GetDefense()==0)
end
function s.spfilter(c,e)
	return c:IsFaceup() and c:IsRace(RACE_CYBERSE) and c:IsCanBeEffectTarget(e)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.spfilter(chkc,e) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false)
		and Duel.IsExistingTarget(s.spfilter,tp,LOCATION_MZONE,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,s.spfilter,tp,LOCATION_MZONE,0,1,1,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,tp,LOCATION_MZONE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not c:IsRelateToEffect(e) then return end
	local should_banish=tc and tc:IsRelateToEffect(e) and tc:IsControler(tp)
		and tc:IsLocation(LOCATION_MZONE) and tc:IsFaceup() and s.haspositiveatkdef(tc)
	if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 and should_banish
		and tc:IsRelateToEffect(e) and tc:IsControler(tp)
		and tc:IsLocation(LOCATION_MZONE) and tc:IsAbleToRemove() then
		Duel.BreakEffect()
		Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)
	end
end
function s.matfilter(c,e)
	return c:IsRace(RACE_CYBERSE) and c:IsCanBeFusionMaterial() and not c:IsImmuneToEffect(e)
end
function s.fusfilter(c,e,tp,mg,gc,chkf)
	return c:IsType(TYPE_FUSION) and c:IsRace(RACE_CYBERSE)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
		and c:CheckFusionMaterial(mg,gc,chkf)
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local chkf=tp
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e)
	if chk==0 then return c:IsCanBeFusionMaterial()
		and Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg,c,chkf) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.fusop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and c:IsFaceup() and c:IsCanBeFusionMaterial()) then return end
	local chkf=tp
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e)
	if not mg:IsContains(c) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,s.fusfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp,mg,c,chkf)
	local fc=g:GetFirst()
	if not fc then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
	local mat=Duel.SelectFusionMaterial(tp,fc,mg,c,chkf)
	if not mat or mat:GetCount()==0 or not mat:IsContains(c) then return end
	if Duel.GetLocationCountFromEx(tp,tp,mat,fc)<=0 then return end
	local bonus=mat:FilterCount(s.zeroatkdef,nil)*1000
	fc:SetMaterial(mat)
	if mat:IsExists(Card.IsFacedown,1,nil) then
		local cg=mat:Filter(Card.IsFacedown,nil)
		Duel.ConfirmCards(1-tp,cg)
	end
	Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
	if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then
		fc:CompleteProcedure()
		if bonus>0 then
			local e1=Effect.CreateEffect(c)
			e1:SetDescription(aux.Stringid(STRING_ID,2))
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetCode(EFFECT_UPDATE_ATTACK)
			e1:SetProperty(EFFECT_FLAG_CLIENT_HINT)
			e1:SetReset(RESET_EVENT+RESETS_STANDARD)
			e1:SetValue(bonus)
			fc:RegisterEffect(e1,true)
			local e2=e1:Clone()
			e2:SetCode(EFFECT_UPDATE_DEFENSE)
			fc:RegisterEffect(e2,true)
		end
	end
end
