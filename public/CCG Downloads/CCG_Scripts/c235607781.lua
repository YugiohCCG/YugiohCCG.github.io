--The Yellow Frute
local s,id=GetID()
local SET_FRUTE=0x813
function s.initial_effect(c)
	--Send this card; Special Summon 1 "Frute" monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND+LOCATION_MZONE)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.spcost)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--If Tributed: draw
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_DRAW+CATEGORY_HANDES)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_RELEASE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.drtg)
	e2:SetOperation(s.drop)
	c:RegisterEffect(e2)
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToGraveAsCost() and (c:IsLocation(LOCATION_HAND) or c:IsFaceup()) end
	Duel.SendtoGrave(c,REASON_COST)
end
function s.spfilter(c,e,tp)
	return c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER) and not c:IsCode(id)
		and (c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
			or (not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
				and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)))
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
	if not tc then return end
	local b1=tc:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
	local b2=not Duel.IsPlayerAffectedByEffect(tp,EFFECT_DIVINE_LIGHT)
		and tc:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
	local pos=POS_FACEUP_DEFENSE
	if b1 and b2 then
		local op=Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))
		if op==1 then pos=POS_FACEDOWN_DEFENSE end
	elseif b2 then
		pos=POS_FACEDOWN_DEFENSE
	elseif not b1 then
		return
	end
	Duel.SpecialSummon(tc,0,tp,tp,false,false,pos)
end
function s.drtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local fd=e:GetHandler():IsPreviousPosition(POS_FACEDOWN_DEFENSE)
	if chk==0 then return Duel.IsPlayerCanDraw(tp,1) or (fd and Duel.IsPlayerCanDraw(tp,2)) end
	local ct=1
	if fd and Duel.IsPlayerCanDraw(tp,2) and (not Duel.IsPlayerCanDraw(tp,1) or Duel.SelectOption(tp,aux.Stringid(id,4),aux.Stringid(id,5))==1) then
		ct=2
	end
	e:SetLabel(ct)
	Duel.SetTargetPlayer(tp)
	Duel.SetTargetParam(ct)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,ct)
	if ct==2 then
		Duel.SetOperationInfo(0,CATEGORY_HANDES,nil,0,tp,1)
	end
end
function s.drop(e,tp,eg,ep,ev,re,r,rp)
	local p,ct=Duel.GetChainInfo(0,CHAININFO_TARGET_PLAYER,CHAININFO_TARGET_PARAM)
	if Duel.Draw(p,ct,REASON_EFFECT)==ct and ct==2 then
		Duel.BreakEffect()
		Duel.DiscardHand(p,aux.TRUE,1,1,REASON_EFFECT+REASON_DISCARD,nil)
	end
end
