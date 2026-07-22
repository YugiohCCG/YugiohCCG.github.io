local s,id=GetID()
local STRING_ID=132110263
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON)
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
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_MZONE) and chkc:IsControler(tp) and chkc:IsAbleToRemove() end
	if chk==0 then return Duel.IsExistingTarget(Card.IsAbleToRemove,tp,LOCATION_MZONE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectTarget(tp,Card.IsAbleToRemove,tp,LOCATION_MZONE,0,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,0,0)
	if Duel.GetFlagEffect(tp,231273040)>=3 and g:GetFirst():IsAttribute(ATTRIBUTE_WIND) and g:GetFirst():IsType(TYPE_SYNCHRO) then
		Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
	end
end
function s.spfilter(c,e,tp,code)
	return c:IsSetCard(0x21fc) and c:IsType(TYPE_SYNCHRO) and not c:IsCode(code)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_SYNCHRO,tp,false,false)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not tc:IsRelateToEffect(e) then return end
	local is_wind_sync = tc:IsAttribute(ATTRIBUTE_WIND) and tc:IsType(TYPE_SYNCHRO)
	local code = tc:GetCode()
	if Duel.Remove(tc,POS_FACEUP,REASON_EFFECT+REASON_TEMPORARY)>0 then
		local oc=tc
		if oc:IsLocation(LOCATION_REMOVED) then
			oc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
			local e1=Effect.CreateEffect(e:GetHandler())
			e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
			e1:SetCode(EVENT_PHASE+PHASE_END)
			e1:SetReset(RESET_PHASE+PHASE_END)
			e1:SetLabelObject(oc)
			e1:SetCountLimit(1)
			e1:SetCondition(s.retcon)
			e1:SetOperation(s.retop)
			Duel.RegisterEffect(e1,tp)
			
			if is_wind_sync and Duel.GetFlagEffect(tp,231273040)>=3 then
				local exg=Duel.GetMatchingGroup(s.spfilter,tp,LOCATION_EXTRA,0,nil,e,tp,code)
				if #exg>0 and Duel.GetLocationCountFromEx(tp)>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then
					Duel.BreakEffect()
					Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
					local sg=exg:Select(tp,1,1,nil)
					if #sg>0 then
						local sc=sg:GetFirst()
						local mat=Group.FromCards(Duel.CreateToken(tp,215068354)) -- Janna, Goddess of the Temple
						sc:SetMaterial(mat)
						Duel.SpecialSummon(sc,SUMMON_TYPE_SYNCHRO,tp,tp,false,false,POS_FACEUP)
						sc:CompleteProcedure()
					end
				end
			end
		end
	end
end
function s.retcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetLabelObject():GetFlagEffect(id)~=0
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	Duel.ReturnToField(e:GetLabelObject())
end
