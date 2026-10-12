--Fruteification
local s,id=GetID()
local STRING_ID=132930605
local SET_FRUTE=0x813
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_RELEASE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	--Banish this card; send 1 WATER Ritual Monster from your Deck to the GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+EFFECT_COUNT_CODE_DUEL)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.tgtg)
	e2:SetOperation(s.tgop)
	c:RegisterEffect(e2)
end
function s.ritfilter(c,e,tp,mg,needextra)
	local lv=c:GetLevel()
	return c:IsAttribute(ATTRIBUTE_WATER) and c:IsType(TYPE_RITUAL)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)
		and s.ritcheck(mg,tp,c,lv,needextra)
end
function s.ritmatcheck(g,tp,c,lv,greater_or_equal,needextra)
	return Auxiliary.RitualCheck(g,tp,c,lv,greater_or_equal)
		and (not needextra or Duel.GetMZoneCount(tp,g,tp)>1)
end
function s.ritcheck(mg,tp,c,lv,needextra)
	if lv<=0 then return false end
	Auxiliary.GCheckAdditional=Auxiliary.RitualCheckAdditional(c,lv,"Greater")
	local res=mg:CheckSubGroup(s.ritmatcheck,1,lv,tp,c,lv,"Greater",needextra)
	Auxiliary.GCheckAdditional=nil
	return res
end
function s.rvtgfilter(c,e,tp)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_RITUAL)
		and c:IsCanBeEffectTarget(e) and aux.NecroValleyFilter()(c)
		and not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
end
function s.rvopfilter(c,e,tp)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_RITUAL)
		and aux.NecroValleyFilter()(c) and not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local mg=Duel.GetRitualMaterial(tp)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE) and s.rvtgfilter(chkc,e,tp) end
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.ritfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp,mg,false) end
	local canrv=Duel.GetFlagEffect(tp,id)==0
		and Duel.IsExistingTarget(s.rvtgfilter,tp,LOCATION_GRAVE,0,1,nil,e,tp)
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.ritfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp,mg,true)
	if canrv and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
		Duel.SelectTarget(tp,s.rvtgfilter,tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
		Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,EFFECT_FLAG_OATH,1)
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_RELEASE,nil,1,tp,LOCATION_HAND+LOCATION_MZONE)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
	local mg=Duel.GetRitualMaterial(tp)
	local tc=Duel.GetFirstTarget()
	local needextra=tc and tc:IsRelateToEffect(e) and s.rvopfilter(tc,e,tp)
	if not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.ritfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp,mg,needextra) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.ritfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp,mg,needextra)
	local ritual=sg:GetFirst()
	if not ritual then return end
	local lv=ritual:GetLevel()
	Auxiliary.GCheckAdditional=Auxiliary.RitualCheckAdditional(ritual,lv,"Greater")
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local mat=mg:SelectSubGroup(tp,s.ritmatcheck,true,1,lv,tp,ritual,lv,"Greater",needextra)
	Auxiliary.GCheckAdditional=nil
	if not mat or #mat==0 then return end
	ritual:SetMaterial(mat)
	Duel.ReleaseRitualMaterial(mat)
	if needextra and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)
	end
	if ritual:IsRelateToEffect(e) and (not ritual:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(ritual))
		and Duel.SpecialSummon(ritual,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0 then
		ritual:CompleteProcedure()
	end
end
function s.tgfilter(c)
	return c:IsAttribute(ATTRIBUTE_WATER) and c:IsType(TYPE_RITUAL) and c:IsAbleToGrave()
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local tc=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if tc then
		Duel.SendtoGrave(tc,REASON_EFFECT)
	end
end
