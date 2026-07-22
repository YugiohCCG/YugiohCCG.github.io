local s,id=GetID()
local STRING_ID=133212369
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	if not s.global_check then
		s.global_check=true
		local ge1=Effect.CreateEffect(c)
		ge1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge1:SetCode(EVENT_TO_HAND)
		ge1:SetOperation(s.checkop)
		Duel.RegisterEffect(ge1,0)
	end
end
s.listed_series={0x21fc}
s.listed_names={id}
function s.cfilter(c,tp)
	return c:IsControler(tp) and c:IsPreviousLocation(LOCATION_DECK) and c:IsSetCard(0x21fc)
end
function s.checkop(e,tp,eg,ep,ev,re,r,rp)
	for p=0,1 do
		local g=eg:Filter(s.cfilter,nil,p)
		if #g>0 then
			for i=1,#g do
				Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1)
			end
		end
	end
end
function s.thcardfilter(c)
	return c:IsSetCard(0x21fc) and not c:IsCode(id) and c:IsAbleToHand()
end
function s.setcardfilter(c)
	return c:IsSetCard(0x21fc) and not c:IsCode(id) and c:IsSSetable()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return false end
	local b1=Duel.IsExistingTarget(aux.NecroValleyFilter(s.thcardfilter),tp,LOCATION_GRAVE,0,1,nil)
	local b2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and Duel.IsExistingTarget(aux.NecroValleyFilter(s.setcardfilter),tp,LOCATION_GRAVE,0,1,nil)
	if chk==0 then return b1 or b2 end
	local op=b1 and b2 and Duel.SelectOption(tp,1190,1153) or (b1 and 0 or 1)
	e:SetLabel(op)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local f=op==0 and aux.NecroValleyFilter(s.thcardfilter) or aux.NecroValleyFilter(s.setcardfilter)
	Duel.SelectTarget(tp,f,tp,LOCATION_GRAVE,0,1,2,nil)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(0x21fc) and not c:IsType(TYPE_SYNCHRO) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local tg=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	if #tg==0 then return end
	local c=e:GetHandler()
	if e:GetLabel()==0 then
		tg=tg:Filter(aux.NecroValleyFilter(s.thcardfilter),nil)
		if #tg==0 then return end
		local fid=c:GetFieldID()
		for tc in aux.Next(tg) do
			tc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD,0,1,fid)
		end
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e1:SetCode(EVENT_PHASE+PHASE_STANDBY)
		e1:SetCountLimit(1)
		e1:SetReset(RESET_PHASE+PHASE_STANDBY,2)
		e1:SetLabel(fid,Duel.GetTurnCount())
		e1:SetLabelObject(tg)
		e1:SetCondition(s.thcon)
		e1:SetOperation(s.thop)
		tg:KeepAlive()
		Duel.RegisterEffect(e1,tp)
	else
		tg=tg:Filter(aux.NecroValleyFilter(s.setcardfilter),nil)
		if #tg==0 or Duel.SSet(tp,tg)==0 then return end
	end
	
	if Duel.GetFlagEffect(tp,id)>=3 then
		local sg=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,nil,e,tp)
		if #sg>0 and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then
			Duel.BreakEffect()
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
			local g=sg:Select(tp,1,1,nil)
			Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)
		end
	end
end
function s.thfilter(c,fid)
	return c:GetFlagEffectLabel(id)==fid
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	local fid,turnc=e:GetLabel()
	if Duel.GetTurnCount()==turnc then return false end
	local tg=e:GetLabelObject()
	if not tg:IsExists(s.thfilter,1,nil,fid) then
		tg:DeleteGroup()
		e:Reset()
		return false
	end
	return true
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local fid=e:GetLabel()
	local tg=e:GetLabelObject()
	local g=tg:Filter(s.thfilter,nil,fid)
	if #g>0 then
		for tc in aux.Next(g) do
			if aux.NecroValleyFilter()(tc) and tc:IsAbleToHand() then
				Duel.SendtoHand(tc,nil,REASON_EFFECT)
				Duel.ConfirmCards(1-tp,tc)
			end
		end
	end
	tg:DeleteGroup()
	e:Reset()
end
