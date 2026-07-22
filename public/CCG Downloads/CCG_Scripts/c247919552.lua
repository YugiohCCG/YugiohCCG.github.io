local s,id=GetID()
local STRING_ID=133919552
local SET_GRAVINITY=0x760
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TODECK)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.placefilter(c) return c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_MONSTER) end
function s.matfilter(c) return c:IsFaceup() and c:IsSetCard(SET_GRAVINITY) and (c:GetOriginalType()&TYPE_MONSTER)~=0 end
function s.synfilter(c,mg) return c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_SYNCHRO) and c:IsSynchroSummonable(nil,mg) end
function s.oppcolfilter(c,mc) return c:IsAbleToDeck() and mc:GetColumnGroup():IsContains(c) end
function s.zonefilter(c,tp)
	return c:IsFaceup() and c:IsSetCard(SET_GRAVINITY) and (c:GetOriginalType()&TYPE_MONSTER)~=0
		and c:IsLocation(LOCATION_SZONE) and c:IsAbleToDeck()
		and Duel.IsExistingMatchingCard(s.oppcolfilter,tp,0,LOCATION_ONFIELD,1,nil,c)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local b1=Duel.GetFlagEffect(tp,id)==0 and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.placefilter),tp,LOCATION_MZONE+LOCATION_GRAVE,0,1,nil)
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_MZONE+LOCATION_SZONE,0,nil)
	local b2=Duel.GetFlagEffect(tp,id+100)==0 and Duel.IsExistingMatchingCard(s.synfilter,tp,LOCATION_EXTRA,0,1,nil,mg)
	local b3=Duel.GetFlagEffect(tp,id+200)==0 and Duel.IsExistingMatchingCard(s.zonefilter,tp,LOCATION_SZONE,0,1,nil,tp)
	if chk==0 then return b1 or b2 or b3 end
	local opts={}
	local vals={}
	if b1 then opts[#opts+1]=aux.Stringid(STRING_ID,1) vals[#vals+1]=1 end
	if b2 then opts[#opts+1]=aux.Stringid(STRING_ID,2) vals[#vals+1]=2 end
	if b3 then opts[#opts+1]=aux.Stringid(STRING_ID,3) vals[#vals+1]=3 end
	local sel=Duel.SelectOption(tp,table.unpack(opts))
	local op=vals[sel+1]
	e:SetLabel(op)
	Duel.RegisterFlagEffect(tp,id+(op-1)*100,RESET_PHASE+PHASE_END,0,1)
end
function s.trapify(c)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CHANGE_TYPE)
	e1:SetValue(TYPE_TRAP+TYPE_CONTINUOUS)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
end
function s.activate(e,tp)
	local op=e:GetLabel()
	if op==1 then
		local ft=Duel.GetLocationCount(tp,LOCATION_SZONE)
		local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.placefilter),tp,LOCATION_MZONE+LOCATION_GRAVE,0,nil)
		if ft<=0 or #g==0 then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
		local sg=g:Select(tp,1,math.min(2,ft,#g),nil)
		for tc in aux.Next(sg) do if Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then s.trapify(tc) end end
	elseif op==2 then
		local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_MZONE+LOCATION_SZONE,0,nil)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local sc=Duel.SelectMatchingCard(tp,s.synfilter,tp,LOCATION_EXTRA,0,1,1,nil,mg):GetFirst()
		if sc then Duel.SynchroSummon(tp,sc,nil,mg) end
	else
		local g=Duel.GetMatchingGroup(s.zonefilter,tp,LOCATION_SZONE,0,nil,tp)
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
		local sg=g:Select(tp,1,math.min(2,#g),nil)
		local og=Duel.GetMatchingGroup(function(c,mg) return mg:IsExists(function(mc,oc) return s.oppcolfilter(oc,mc) end,1,nil,c) end,tp,0,LOCATION_ONFIELD,nil,sg)
		if #og<#sg then return end
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
		local rg=og:Select(tp,#sg,#sg,nil)
		sg:Merge(rg)
		Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
	end
end
