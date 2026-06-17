--Wyvernal Sphinx
local s,id=GetID()
local SET_WYVERNAL=0x4714
function s.initial_effect(c)
	--Reveal this card; Fusion Summon while not controlling an Insect Fusion Monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.igncon)
	e1:SetCost(s.revcost)
	e1:SetTarget(s.fustg)
	e1:SetOperation(s.fusop)
	c:RegisterEffect(e1)
	--Quick Effect version while you control an Insect Fusion Monster
	local e2=e1:Clone()
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e2:SetCondition(s.quickcon)
	c:RegisterEffect(e2)
	--If sent to the GY except by its own effect: banish 1 other card, add this card
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_REMOVE+CATEGORY_TOHAND)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_TO_GRAVE)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.thcon)
	e3:SetTarget(s.thtg)
	e3:SetOperation(s.thop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_WYVERNAL}
function s.insectfusion(c)
	return c:IsFaceup() and c:IsRace(RACE_INSECT) and c:IsType(TYPE_FUSION)
end
function s.igncon(e,tp,eg,ep,ev,re,r,rp)
	return not Duel.IsExistingMatchingCard(s.insectfusion,tp,LOCATION_MZONE,0,1,nil)
end
function s.quickcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(s.insectfusion,tp,LOCATION_MZONE,0,1,nil)
end
function s.revcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return not c:IsPublic() end
	Duel.ConfirmCards(1-tp,c)
	Duel.ShuffleHand(tp)
end
function s.matfilter(c,e)
	return c:IsType(TYPE_MONSTER) and c:IsCanBeFusionMaterial() and not c:IsImmuneToEffect(e)
end
function s.fusfilter(c,e,tp,mg,f,chkf)
	return c:IsSetCard(SET_WYVERNAL) and c:IsType(TYPE_FUSION)
		and (not f or f(c))
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
		and c:CheckFusionMaterial(mg,nil,chkf)
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
	local chkf=tp
	local mg=Duel.GetFusionMaterial(tp):Filter(s.matfilter,nil,e)
	if chk==0 then
		local res=Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg,nil,chkf)
		if not res then
			local ce=Duel.GetChainMaterial(tp)
			if ce then
				local fgroup=ce:GetTarget()
				local mg2=fgroup(ce,e,tp)
				local mf=ce:GetValue()
				res=Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg2,mf,chkf)
			end
		end
		return res
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.fusop(e,tp,eg,ep,ev,re,r,rp)
	local chkf=tp
	local mg=Duel.GetFusionMaterial(tp):Filter(s.matfilter,nil,e)
	local sg1=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg,nil,chkf)
	local mg2=nil
	local sg2=nil
	local ce=Duel.GetChainMaterial(tp)
	if ce then
		local fgroup=ce:GetTarget()
		mg2=fgroup(ce,e,tp)
		local mf=ce:GetValue()
		sg2=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg2,mf,chkf)
	end
	if #sg1==0 and (not sg2 or #sg2==0) then return end
	local sg=sg1:Clone()
	if sg2 then sg:Merge(sg2) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local fc=sg:Select(tp,1,1,nil):GetFirst()
	if not fc then return end
	if sg1:IsContains(fc) and (not sg2 or not sg2:IsContains(fc) or not Duel.SelectYesNo(tp,ce:GetDescription())) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
		local mat=Duel.SelectFusionMaterial(tp,fc,mg,nil,chkf)
		if not mat or #mat==0 or Duel.GetLocationCountFromEx(tp,tp,mat,fc)<=0 then return end
		fc:SetMaterial(mat)
		if mat:IsExists(Card.IsFacedown,1,nil) then
			Duel.ConfirmCards(1-tp,mat:Filter(Card.IsFacedown,nil))
		end
		Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
		Duel.BreakEffect()
		Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)
	elseif ce and mg2 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
		local mat=Duel.SelectFusionMaterial(tp,fc,mg2,nil,chkf)
		local fop=ce:GetOperation()
		fop(ce,e,tp,fc,mat)
	end
	fc:CompleteProcedure()
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return not (re and re:GetHandler()==e:GetHandler())
end
function s.rmfilter(c)
	return c:IsAbleToRemove()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToHand() and aux.NecroValleyFilter()(c)
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.rmfilter),tp,LOCATION_GRAVE,0,1,c) end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,tp,LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,c,1,tp,LOCATION_GRAVE)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and c:IsAbleToHand() and aux.NecroValleyFilter()(c)) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.rmfilter),tp,LOCATION_GRAVE,0,1,1,c)
	if #g>0 and Duel.Remove(g,POS_FACEUP,REASON_EFFECT)>0 then
		Duel.BreakEffect()
		Duel.SendtoHand(c,nil,REASON_EFFECT)
	end
end
