--Harpie Lady Sisters - Phoenix Formation
local s,id=GetID()
local STRING_ID=133269774
local SET_HARPIE=0x64
local SET_HARPIE_CUSTOM=0x079c
local CARD_HARPIE_LADY=76812113
local HARP_CODE_LIST={CARD_HARPIE_LADY,91932350,27927359,54415063,80316585,259794136}
function s.initial_effect(c)
	aux.AddCodeList(c,CARD_HARPIE_LADY)
	--Synchro Summon
	aux.AddSynchroProcedure(c,s.tunerfilter,aux.NonTuner(nil),1)
	c:EnableReviveLimit()
	--If Synchro Summoned: destroy face-up cards
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.descon)
	e1:SetTarget(s.destg)
	e1:SetOperation(s.desop)
	c:RegisterEffect(e1)
	--Tribute this card; Special Summon "Harpie Lady" monsters, then return cards
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetHintTiming(0,TIMING_MAIN_END)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.spcon)
	e2:SetCost(s.spcost)
	e2:SetTarget(s.sptg)
	e2:SetOperation(s.spop)
	c:RegisterEffect(e2)
end
function s.isharpielady(c)
	return c:IsCode(table.unpack(HARP_CODE_LIST))
end
function s.tunerfilter(c)
	return c:IsType(TYPE_TUNER) or c:IsSetCard(SET_HARPIE) or c:IsSetCard(SET_HARPIE_CUSTOM)
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_SYNCHRO)
end
function s.gyfilter(c,e)
	return s.isharpielady(c) and c:IsCanBeEffectTarget(e)
end
function s.faceuptg(c,e)
	return c:IsFaceup() and c:IsCanBeEffectTarget(e)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return false end
	local mg=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,nil,e)
	local fg=Duel.GetMatchingGroup(s.faceuptg,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil,e)
	if chk==0 then return #mg>0 and #fg>0 end
	local max=math.min(#mg,#fg)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g1=mg:Select(tp,1,max,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g2=Duel.SelectTarget(tp,s.faceuptg,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,#g1,#g1,nil,e)
	g1:Merge(g2)
	Duel.SetTargetCard(g1)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g2,#g2,0,0)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
	if not g then return end
	local dg=g:Filter(function(c) return c:IsRelateToEffect(e) and c:IsOnField()
		and c:IsFaceup() and c:IsDestructable() end,nil)
	if #dg>0 and Duel.Destroy(dg,REASON_EFFECT)>0 then
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_FIELD)
		e1:SetCode(EFFECT_CHANGE_BATTLE_DAMAGE)
		e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
		e1:SetTargetRange(0,1)
		e1:SetValue(0)
		e1:SetReset(RESET_PHASE+PHASE_END)
		Duel.RegisterEffect(e1,tp)
	end
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsMainPhase()
end
function s.spfilter(c,e,tp)
	return s.isharpielady(c) and c:IsCanBeEffectTarget(e)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local ct=c:GetMaterialCount()
	if chk==0 then return ct>0 and c:IsReleasable()
		and Duel.GetMZoneCount(tp,c)>=ct
		and Duel.IsExistingTarget(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,ct,nil,e,tp) end
	e:SetLabel(ct)
	Duel.Release(c,REASON_COST)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local ct=e:GetLabel()
	if chkc then return false end
	if chk==0 then return true end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,ct,ct,nil,e,tp)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,#g,tp,LOCATION_GRAVE)
	e:SetLabel(#g)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local ct=e:GetLabel()
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
	if not g or #g==0 then return end
	local sg=g:Filter(function(c) return c:IsRelateToEffect(e) and aux.NecroValleyFilter()(c)
		and s.spfilter(c,e,tp) end,nil)
	if #sg==0 or Duel.GetLocationCount(tp,LOCATION_MZONE)<#sg then return end
	local sc=Duel.SpecialSummon(sg,0,tp,tp,false,false,POS_FACEUP)
	if sc>0 then
		local fg=Duel.GetMatchingGroup(Card.IsAbleToHand,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil)
		if #fg>0 then
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
			local rc=math.min(ct,#fg)
			local rg=fg:Select(tp,rc,rc,nil)
			Duel.SendtoHand(rg,nil,REASON_EFFECT)
		end
		s.register_destroy(e,tp,ct)
	end
end
function s.register_destroy(e,tp,ct)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_PHASE+PHASE_END)
	e1:SetCountLimit(1)
	e1:SetLabel(ct)
	e1:SetOperation(s.destructop)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.destructop(e,tp,eg,ep,ev,re,r,rp)
	local ct=e:GetLabel()
	local g=Duel.GetMatchingGroup(Card.IsDestructable,tp,LOCATION_ONFIELD,0,nil)
	if #g==0 then return end
	local dc=math.min(ct,#g)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local sg=g:Select(tp,dc,dc,nil)
	Duel.Destroy(sg,REASON_EFFECT)
end
