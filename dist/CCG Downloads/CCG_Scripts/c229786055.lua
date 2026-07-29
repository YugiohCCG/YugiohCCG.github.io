--Eldora in Depraevity
local s,id=GetID()
local STRING_ID=133786055
local CARD_ELDORA=214552846
local CARD_EXTINCTION=242009896
function s.initial_effect(c)
	--Special Summon a matching monster destroyed this turn
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
s.listed_names={CARD_ELDORA,CARD_EXTINCTION}
function s.match(c,tc)
	return c:IsRace(tc:GetRace()) or c:IsAttribute(tc:GetAttribute())
		or (c:GetLevel()>0 and tc:GetLevel()>0 and c:IsLevel(tc:GetLevel()))
		or (c:GetAttack()>=0 and tc:GetAttack()>=0 and c:GetAttack()==tc:GetAttack())
		or (not c:IsType(TYPE_LINK) and not tc:IsType(TYPE_LINK)
			and c:GetDefense()>=0 and tc:GetDefense()>=0 and c:GetDefense()==tc:GetDefense())
end
function s.spfilter(c,e,tp,tc)
	return c:IsType(TYPE_MONSTER) and not c:IsCode(tc:GetCode()) and s.match(c,tc)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_ATTACK)
end
function s.eldorafilter(c)
	return c:IsCode(CARD_ELDORA)
end
function s.splocations(tp)
	local locations=LOCATION_GRAVE
	if Duel.IsExistingMatchingCard(s.eldorafilter,tp,LOCATION_GRAVE,0,1,nil) then
		locations=locations|LOCATION_DECK
	end
	return locations
end
function s.hasmatch(e,tp,tc)
	return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(
			aux.NecroValleyFilter(s.spfilter),tp,s.splocations(tp),0,1,tc,e,tp,tc
		)
end
function s.destroyedfilter(c,e,tp)
	if not (
		c:IsType(TYPE_MONSTER) and c:IsReason(REASON_DESTROY)
		and c:IsReason(REASON_EFFECT) and c:GetTurnID()==Duel.GetTurnCount()
		and c:IsCanBeEffectTarget(e)
	) then
		return false
	end
	local reason_effect=c:GetReasonEffect()
	if type(reason_effect)~="userdata" and type(reason_effect)~="table" then
		return false
	end
	local handler=reason_effect:GetHandler()
	return handler
		and (handler:IsCode(CARD_ELDORA,CARD_EXTINCTION) or c:GetReasonPlayer()==1-tp)
		and s.hasmatch(e,tp,c)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then
		return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE)
			and s.destroyedfilter(chkc,e,tp)
	end
	if chk==0 then
		return Duel.IsExistingTarget(s.destroyedfilter,tp,LOCATION_GRAVE,0,1,nil,e,tp)
	end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local target=Duel.SelectTarget(tp,s.destroyedfilter,tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE+LOCATION_DECK)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (
		tc and tc:IsRelateToEffect(e) and tc:IsLocation(LOCATION_GRAVE)
		and tc:IsType(TYPE_MONSTER) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
	) then
		return
	end
	local locations=s.splocations(tp)
	local candidates=Duel.GetMatchingGroup(
		aux.NecroValleyFilter(s.spfilter),tp,locations,0,tc,e,tp,tc
	)
	if #candidates==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sc=candidates:Select(tp,1,1,nil):GetFirst()
	if sc then
		Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP_ATTACK)
	end
end
