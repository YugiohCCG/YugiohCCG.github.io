--Chaos Fusion
local s,id=GetID()
local STRING_ID=133277197
function s.initial_effect(c)
	--Fusion Summon 1 LIGHT or DARK Fusion Monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON+CATEGORY_REMOVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_FUSION_SUMMON)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.fustg)
	e1:SetOperation(s.fusop)
	c:RegisterEffect(e1)
	--Banish this card; return 1 LIGHT and 1 DARK monster from banishment to the GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_REMOVE+CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.retcon)
	e2:SetCost(s.retcost)
	e2:SetTarget(s.rettg)
	e2:SetOperation(s.retop)
	c:RegisterEffect(e2)
end
function s.matfilter(c,e)
	return c:IsType(TYPE_MONSTER) and c:IsCanBeFusionMaterial() and c:IsAbleToRemove()
		and not c:IsImmuneToEffect(e)
end
function s.gymatfilter(c,e)
	return s.matfilter(c,e) and c:IsAttribute(ATTRIBUTE_LIGHT+ATTRIBUTE_DARK)
end
function s.fusfilter(c,e,tp,m,chkf)
	return c:IsType(TYPE_FUSION) and c:IsAttribute(ATTRIBUTE_LIGHT+ATTRIBUTE_DARK)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
		and c:CheckFusionMaterial(m,nil,chkf)
end
function s.gylight(c)
	return c:IsLocation(LOCATION_GRAVE) and c:IsAttribute(ATTRIBUTE_LIGHT)
end
function s.gydark(c)
	return c:IsLocation(LOCATION_GRAVE) and c:IsAttribute(ATTRIBUTE_DARK)
end
function s.fcheck(tp,sg,fc)
	return sg:FilterCount(s.gylight,nil)<=1 and sg:FilterCount(s.gydark,nil)<=1
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
	local chkf=tp
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e)
	if Duel.IsExistingMatchingCard(aux.TRUE,tp,0,LOCATION_MZONE,1,nil) then
		local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.gymatfilter),tp,LOCATION_GRAVE,0,nil,e)
		mg:Merge(g)
	end
	aux.FCheckAdditional=s.fcheck
	local res=Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg,chkf)
	aux.FCheckAdditional=nil
	if chk==0 then return res end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_GRAVE)
end
function s.fusop(e,tp,eg,ep,ev,re,r,rp)
	local chkf=tp
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e)
	if Duel.IsExistingMatchingCard(aux.TRUE,tp,0,LOCATION_MZONE,1,nil) then
		local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.gymatfilter),tp,LOCATION_GRAVE,0,nil,e)
		mg:Merge(g)
	end
	aux.FCheckAdditional=s.fcheck
	local sg=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg,chkf)
	if #sg>0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
		local tc=sg:Select(tp,1,1,nil):GetFirst()
		if tc then
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
			local mat=Duel.SelectFusionMaterial(tp,tc,mg,nil,chkf)
			aux.FCheckAdditional=nil
			if mat and #mat>0 and Duel.GetLocationCountFromEx(tp,tp,mat,tc)>0 and not aux.NecroValleyNegateCheck(mat) then
				tc:SetMaterial(mat)
				if Duel.Remove(mat,POS_FACEUP,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)>0 then
					Duel.BreakEffect()
					if Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then
						tc:CompleteProcedure()
						local e1=Effect.CreateEffect(e:GetHandler())
						e1:SetType(EFFECT_TYPE_SINGLE)
						e1:SetCode(EFFECT_CANNOT_ATTACK)
						e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
						tc:RegisterEffect(e1)
					end
				end
			end
		else
			aux.FCheckAdditional=nil
		end
	else
		aux.FCheckAdditional=nil
	end
end
function s.retcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetTurnID()~=Duel.GetTurnCount()
end
function s.retcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToRemoveAsCost() end
	Duel.Remove(c,POS_FACEUP,REASON_COST)
end
function s.retfilter(c,e,att)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAttribute(att)
		and c:IsAbleToGrave() and c:IsCanBeEffectTarget(e)
end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return false end
	if chk==0 then
		return Duel.IsExistingTarget(aux.NecroValleyFilter(s.retfilter),tp,LOCATION_REMOVED,0,1,nil,e,ATTRIBUTE_LIGHT)
			and Duel.IsExistingTarget(aux.NecroValleyFilter(s.retfilter),tp,LOCATION_REMOVED,0,1,nil,e,ATTRIBUTE_DARK)
	end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g1=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.retfilter),tp,LOCATION_REMOVED,0,1,1,nil,e,ATTRIBUTE_LIGHT)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g2=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.retfilter),tp,LOCATION_REMOVED,0,1,1,g1:GetFirst(),e,ATTRIBUTE_DARK)
	g1:Merge(g2)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,g1,2,0,0)
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
	if #g==2 and not aux.NecroValleyNegateCheck(g) then
		Duel.SendtoGrave(g,REASON_EFFECT)
	end
end
