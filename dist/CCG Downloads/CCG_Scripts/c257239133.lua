-- Phlogistic Uprising!
local s,id=GetID()
local STRING_ID=133239133
function s.initial_effect(c)
	-- activate
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON+CATEGORY_TODECK)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.fstg)
	e1:SetOperation(s.fsop)
	c:RegisterEffect(e1)
	-- set from GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id)
	e2:SetCost(s.setcost)
	e2:SetTarget(s.settg)
	e2:SetOperation(s.setop)
	c:RegisterEffect(e2)
end
function s.mfilter1(c,e)
	return c:IsLocation(LOCATION_HAND+LOCATION_MZONE) and not c:IsImmuneToEffect(e)
end
function s.mfilter2(c,e)
	return c:IsLocation(LOCATION_GRAVE) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
		and aux.NecroValleyFilter()(c) and not c:IsImmuneToEffect(e)
end
function s.ffilter(c,e,tp,m,f,chkf)
	return c:IsType(TYPE_FUSION) and c:IsAttribute(ATTRIBUTE_FIRE) and c:IsRace(RACE_DRAGON)
		and (not f or f(c)) and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,c:IsLocation(LOCATION_GRAVE),false)
		and c:CheckFusionMaterial(m,nil,chkf)
end
function s.fzone(tp,mat,fc)
	if fc:IsLocation(LOCATION_EXTRA) then
		return Duel.GetLocationCountFromEx(tp,tp,mat,fc)>0
	else
		return Duel.GetMZoneCount(tp,mat)>0
	end
end
function s.fstg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		local chkf=tp
		local mg1=Duel.GetMatchingGroup(s.mfilter1,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e)
		local mg2=Duel.GetMatchingGroup(s.mfilter2,tp,LOCATION_GRAVE,0,nil,e)
		mg1:Merge(mg2)
		return Duel.IsExistingMatchingCard(s.ffilter,tp,LOCATION_GRAVE+LOCATION_EXTRA,0,1,nil,e,tp,mg1,nil,chkf)
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE+LOCATION_EXTRA)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_GRAVE)
end
function s.fsop(e,tp,eg,ep,ev,re,r,rp)
	local chkf=tp
	local mg1=Duel.GetMatchingGroup(s.mfilter1,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e)
	local mg2=Duel.GetMatchingGroup(s.mfilter2,tp,LOCATION_GRAVE,0,nil,e)
	mg1:Merge(mg2)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,s.ffilter,tp,LOCATION_GRAVE+LOCATION_EXTRA,0,1,1,nil,e,tp,mg1,nil,chkf)
	local tc=g:GetFirst()
	if tc then
		local mat1=Duel.SelectFusionMaterial(tp,tc,mg1,nil,chkf)
		if not s.fzone(tp,mat1,tc) then return end
		tc:SetMaterial(mat1)
		local rg1=mat1:Filter(Card.IsLocation,nil,LOCATION_HAND+LOCATION_MZONE)
		local rg2=mat1:Filter(Card.IsLocation,nil,LOCATION_GRAVE)
		if #rg1>0 then
			Duel.SendtoGrave(rg1,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
		end
		if #rg2>0 then
			Duel.SendtoDeck(rg2,nil,SEQ_DECKSHUFFLE,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
		end
		Duel.BreakEffect()
		if Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,tc:IsLocation(LOCATION_GRAVE),false,POS_FACEUP)>0 then
			tc:CompleteProcedure()
			local maxlp=Duel.GetLP(tp)
			if maxlp>=300 then
				local max_multiples=math.floor(maxlp/300)
				local options={}
				for i=0,max_multiples do
					if i==0 or Duel.CheckLPCost(tp,i*300) then
						table.insert(options,i*300)
					end
				end
				if #options>1 then
					local op=Duel.AnnounceNumber(tp,table.unpack(options))
					if op>0 then
						Duel.PayLPCost(tp,op)
					end
				end
			end
		end
	end
end
function s.shuffilter(c)
	return c:IsCode(242094473) and c:IsAbleToDeckAsCost() and aux.NecroValleyFilter()(c)
end
function s.setcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.shuffilter,tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectMatchingCard(tp,s.shuffilter,tp,LOCATION_GRAVE,0,1,1,nil)
	Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_COST)
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsSSetable() and aux.NecroValleyFilter()(c) end
	Duel.SetOperationInfo(0,CATEGORY_LEAVE_GRAVE,c,1,0,0)
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and c:IsSSetable() and aux.NecroValleyFilter()(c) then
		Duel.SSet(tp,c)
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
		e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
		e1:SetValue(LOCATION_REMOVED)
		c:RegisterEffect(e1)
	end
end
