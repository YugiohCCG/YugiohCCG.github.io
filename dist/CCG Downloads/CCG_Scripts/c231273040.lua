local s,id=GetID()
local STRING_ID=133273040
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	CCG_GLOBAL_CHECKS=CCG_GLOBAL_CHECKS or {}
	if not CCG_GLOBAL_CHECKS[231273040] then
		CCG_GLOBAL_CHECKS[231273040]=true
		local ge1=Effect.CreateEffect(c)
		ge1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge1:SetCode(EVENT_TO_HAND)
		ge1:SetOperation(function(e,tp,eg,ep,ev,re,r,rp)
			for p=0,1 do
				local ct=eg:FilterCount(function(c,tp) return c:IsSetCard(0x21fc) and c:IsControler(tp) and c:IsPreviousLocation(LOCATION_DECK) end,nil,p)
				for i=1,ct do
					Duel.RegisterFlagEffect(p,231273040,RESET_PHASE+PHASE_END,0,1)
				end
			end
		end)
		Duel.RegisterEffect(ge1,0)
	end
end
s.listed_series={0x21fc}
function s.tgfilter(c)
	return c:IsAbleToHand()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return false end
	if chk==0 then return Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingTarget(s.tgfilter,tp,0,LOCATION_MZONE,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g1=Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_MZONE,0,1,1,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g2=Duel.SelectTarget(tp,s.tgfilter,tp,0,LOCATION_MZONE,1,1,nil)
	g1:Merge(g2)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g1,2,0,0)
	if Duel.GetFlagEffect(tp,231273040)>=3 then
		Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND)
	end
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(0x21fc) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then
		if Duel.GetFlagEffect(tp,231273040)>=3 and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 
			and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_HAND,0,1,nil,e,tp) 
			and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then
			Duel.BreakEffect()
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
			local sg=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_HAND,0,1,1,nil,e,tp)
			if #sg>0 and Duel.SpecialSummon(sg,0,tp,tp,false,false,POS_FACEUP)>0 then
				local tc=sg:GetFirst()
				if tc:GetLevel()>0 then
					local e1=Effect.CreateEffect(e:GetHandler())
					e1:SetDescription(aux.Stringid(STRING_ID,1))
					e1:SetType(EFFECT_TYPE_FIELD)
					e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_CLIENT_HINT)
					e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
					e1:SetTargetRange(1,0)
					e1:SetTarget(s.splimit)
					e1:SetLabel(tc:GetLevel())
					e1:SetReset(RESET_PHASE+PHASE_END)
					Duel.RegisterEffect(e1,tp)
				end
			end
		end
	end
end
function s.splimit(e,c,sump,sumtype,sumpos,targetp,se)
	return not c:IsSetCard(0x21fc) and c:GetLevel()>0 and c:IsLevel(e:GetLabel())
end
