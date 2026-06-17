--Wyvernal Sanctuary
local s,id=GetID()
local SET_WYVERNAL=0x4714
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e1)
	--Send 1 Insect monster you control; Special Summon 1 "Wyvernal" monster from Deck
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_FZONE)
	e2:SetCountLimit(1,id)
	e2:SetCost(s.spcost)
	e2:SetTarget(s.sptg)
	e2:SetOperation(s.spop)
	c:RegisterEffect(e2)
	--If another effect Special Summons an Insect monster: Fusion Summon
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON+CATEGORY_TODECK)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetRange(LOCATION_FZONE)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.fuscon)
	e3:SetTarget(s.fustg)
	e3:SetOperation(s.fusop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_WYVERNAL}
function s.costfilter(c)
	return c:IsFaceup() and c:IsRace(RACE_INSECT) and c:IsType(TYPE_MONSTER) and c:IsAbleToGraveAsCost()
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_MZONE,0,1,1,nil)
	Duel.SendtoGrave(g,REASON_COST)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_WYVERNAL) and c:IsType(TYPE_MONSTER)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp)
	if #g>0 then Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP) end
end
function s.summonedinsect(c)
	return c:IsRace(RACE_INSECT) and c:IsType(TYPE_MONSTER)
end
function s.fuscon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.summonedinsect,1,nil)
		and not (re and re:GetHandler()==e:GetHandler())
end
function s.matfilter(c)
	return (c:IsLocation(LOCATION_HAND+LOCATION_GRAVE) or c:IsFaceup())
		and c:IsRace(RACE_INSECT) and c:IsType(TYPE_MONSTER) and c:IsCanBeFusionMaterial()
		and c:IsAbleToDeck()
end
function s.matfilter2(c,e)
	return s.matfilter(c) and not c:IsImmuneToEffect(e)
end
function s.fusfilter(c,e,tp,mg,f,chkf)
	return c:IsType(TYPE_FUSION) and (not f or f(c))
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
		and c:CheckFusionMaterial(mg,nil,chkf)
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
	local chkf=tp
	local mg=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.matfilter2),tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED,0,nil,e)
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
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED)
end
function s.fusop(e,tp,eg,ep,ev,re,r,rp)
	local chkf=tp
	local mg=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.matfilter2),tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED,0,nil,e)
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
		if Duel.SendtoDeck(mat,nil,SEQ_DECKSHUFFLE,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)==0 then return end
		Duel.BreakEffect()
		if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then
			fc:CompleteProcedure()
		end
	elseif ce and mg2 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
		local mat=Duel.SelectFusionMaterial(tp,fc,mg2,nil,chkf)
		if not mat or #mat==0 then return end
		local fop=ce:GetOperation()
		fop(ce,e,tp,fc,mat)
		fc:CompleteProcedure()
	end
end
