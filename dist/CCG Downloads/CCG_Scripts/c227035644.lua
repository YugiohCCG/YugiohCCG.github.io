--Aqua Fusion
local s,id=GetID()
local STRING_ID=133035644
local SET_AQUAMARINE=0xf3c
function s.initial_effect(c)
	--Treated as Aquamarine
	--Activate (Fusion from hand/Deck/field)
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.fstg)
	e1:SetOperation(s.fsop)
	c:RegisterEffect(e1)
	--Banish from GY to contact fusion
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON+CATEGORY_TODECK)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.cfcon)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.cftg)
	e2:SetOperation(s.cfop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_AQUAMARINE}

function s.ffilter1(c,e)
	return not c:IsImmuneToEffect(e)
end
function s.ffilter2(c,e,tp,m,f,chkf)
	return c:IsType(TYPE_FUSION) and c:IsSetCard(SET_AQUAMARINE) and (not f or f(c))
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false) and c:CheckFusionMaterial(m,nil,chkf)
end
function s.fstg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		local chkf=tp
		local m=Duel.GetFusionMaterial(tp)
		local mg2=Duel.GetMatchingGroup(nil,tp,LOCATION_DECK,0,nil) -- include Deck
		m:Merge(mg2)
		local res=Duel.IsExistingMatchingCard(s.ffilter2,tp,LOCATION_EXTRA,0,1,nil,e,tp,m,nil,chkf)
		if not res then
			local ce=Duel.GetChainMaterial(tp)
			if ce~=nil then
				local fgroup=ce:GetTarget()
				local mg3=fgroup(ce,e,tp)
				local mf=ce:GetValue()
				res=Duel.IsExistingMatchingCard(s.ffilter2,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg3,mf,chkf)
			end
		end
		return res
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.fsop(e,tp,eg,ep,ev,re,r,rp)
	local chkf=tp
	local m=Duel.GetFusionMaterial(tp)
	local mg2=Duel.GetMatchingGroup(nil,tp,LOCATION_DECK,0,nil)
	m:Merge(mg2)
	local sg1=Duel.GetMatchingGroup(s.ffilter2,tp,LOCATION_EXTRA,0,nil,e,tp,m,nil,chkf)
	local mg3=nil
	local filter=nil
	local ce=Duel.GetChainMaterial(tp)
	if ce~=nil then
		local fgroup=ce:GetTarget()
		mg3=fgroup(ce,e,tp)
		filter=ce:GetValue()
	end
	if #sg1>0 or (ce~=nil and #Duel.GetMatchingGroup(s.ffilter2,tp,LOCATION_EXTRA,0,nil,e,tp,mg3,filter,chkf)>0) then
		local sg=sg1:Clone()
		if ce~=nil then
			local sg2=Duel.GetMatchingGroup(s.ffilter2,tp,LOCATION_EXTRA,0,nil,e,tp,mg3,filter,chkf)
			sg:Merge(sg2)
		end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local tg=sg:Select(tp,1,1,nil)
		local tc=tg:GetFirst()
		if sg1:IsContains(tc) and (ce==nil or not Duel.SelectYesNo(tp,ce:GetDescription())) then
			local mat1=Duel.SelectFusionMaterial(tp,tc,m,nil,chkf)
			tc:SetMaterial(mat1)
			Duel.SendtoGrave(mat1,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
			Duel.BreakEffect()
			Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)
		else
			local mat2=ce:Select(ce,e,tp,tc,mg3,chkf)
			local fop=ce:GetOperation()
			fop(ce,e,tp,tc,mat2)
		end
		tc:CompleteProcedure()
	end
	-- Lock
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_CLIENT_HINT)
	e1:SetDescription(aux.Stringid(STRING_ID,2))
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.splimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.splimit(e,c)
	return c:IsLocation(LOCATION_EXTRA) and not (c:IsAttribute(ATTRIBUTE_WATER) and c:IsType(TYPE_FUSION))
end
function s.cfcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetTurnID()~=Duel.GetTurnCount()
end
function s.cffilter1(c)
	return c:IsFaceupEx() and c:IsAbleToDeck()
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
end
function s.cffilter2(c,e,tp,m,f,chkf)
	return c:IsType(TYPE_FUSION) and c:IsSetCard(SET_AQUAMARINE) and (not f or f(c))
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false) and c:CheckFusionMaterial(m,nil,chkf)
end
function s.cftg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		local chkf=tp
		local m=Duel.GetMatchingGroup(s.cffilter1,tp,LOCATION_ONFIELD+LOCATION_GRAVE+LOCATION_REMOVED,0,nil)
		local res=Duel.IsExistingMatchingCard(s.cffilter2,tp,LOCATION_EXTRA,0,1,nil,e,tp,m,nil,chkf)
		return res
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_ONFIELD+LOCATION_GRAVE+LOCATION_REMOVED)
end
function s.cfop(e,tp,eg,ep,ev,re,r,rp)
	local chkf=tp
	local m=Duel.GetMatchingGroup(s.cffilter1,tp,LOCATION_ONFIELD+LOCATION_GRAVE+LOCATION_REMOVED,0,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,s.cffilter2,tp,LOCATION_EXTRA,0,1,1,nil,e,tp,m,nil,chkf)
	local tc=g:GetFirst()
	if tc then
		local mat=Duel.SelectFusionMaterial(tp,tc,m,nil,chkf)
		tc:SetMaterial(mat)
		Duel.SendtoDeck(mat,nil,SEQ_DECKSHUFFLE,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
		Duel.BreakEffect()
		Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)
		tc:CompleteProcedure()
	end
end
