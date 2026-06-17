--Spellbook of Eclipse
local s,id=GetID()
function s.initial_effect(c)
	--Xyz Summon 1 Spellcaster Xyz Monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCost(s.cost)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.counterfilter)
end
function s.counterfilter(c)
	return c:IsRace(RACE_SPELLCASTER)
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 end
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetReset(RESET_PHASE+PHASE_END)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.splimit)
	Duel.RegisterEffect(e1,tp)
end
function s.splimit(e,c)
	return not c:IsRace(RACE_SPELLCASTER)
end
function s.xyzfilter(c,e,tp,mc)
	local lv=mc:GetLevel()
	local rk=c:GetRank()
	return c:IsType(TYPE_XYZ) and c:IsRace(RACE_SPELLCASTER) and rk>=lv
		and mc:IsCanBeXyzMaterial(c)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_XYZ,tp,false,false)
		and Duel.GetLocationCountFromEx(tp,tp,mc,c)>0
		and (rk==lv or Duel.IsPlayerCanDraw(1-tp,rk-lv))
end
function s.tgfilter(c,e,tp)
	return c:IsFaceup() and c:IsRace(RACE_SPELLCASTER) and c:GetLevel()>0
		and c:IsCanBeEffectTarget(e)
		and aux.MustMaterialCheck(c,tp,EFFECT_MUST_BE_XMATERIAL)
		and Duel.IsExistingMatchingCard(s.xyzfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,c)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.tgfilter(chkc,e,tp) end
	if chk==0 then return e:GetHandler():IsCanOverlay()
		and Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_MZONE,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
	local g=Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_MZONE,0,1,1,nil,e,tp)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
	local tc=g:GetFirst()
	local maxdiff=0
	local xg=Duel.GetMatchingGroup(s.xyzfilter,tp,LOCATION_EXTRA,0,nil,e,tp,tc)
	for sc in aux.Next(xg) do
		maxdiff=math.max(maxdiff,sc:GetRank()-tc:GetLevel())
	end
	if maxdiff>0 then
		Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,maxdiff)
	end
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsFaceup() and tc:IsControler(tp) and not tc:IsImmuneToEffect(e)) then return end
	if not aux.MustMaterialCheck(tc,tp,EFFECT_MUST_BE_XMATERIAL) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sc=Duel.SelectMatchingCard(tp,s.xyzfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp,tc):GetFirst()
	if not sc then return end
	local lv=tc:GetLevel()
	sc:SetMaterial(Group.FromCards(tc))
	Duel.Overlay(sc,Group.FromCards(tc))
	if Duel.SpecialSummon(sc,SUMMON_TYPE_XYZ,tp,tp,false,false,POS_FACEUP)>0 then
		sc:CompleteProcedure()
		if c:IsRelateToEffect(e) and c:IsCanOverlay() then
			c:CancelToGrave()
			Duel.Overlay(sc,c)
		end
		local diff=sc:GetRank()-lv
		if diff>0 then
			Duel.Draw(1-tp,diff,REASON_EFFECT)
		end
	end
end
