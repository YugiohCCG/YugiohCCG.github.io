--Ursarctic Nordbar
local s,id=GetID()
local SET_URSARCTIC=0x163
local CARD_HEXTANIUS=244921711
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Cannot be Synchro Summoned
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	c:RegisterEffect(e0)
	--Must be Special Summoned by sending 2 monsters with a Level difference of 7
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetRange(LOCATION_EXTRA)
	e1:SetCondition(s.sprcon)
	e1:SetTarget(s.sprtg)
	e1:SetOperation(s.sprop)
	c:RegisterEffect(e1)
	--If Special Summoned: Special Summon 1 "Ursarctic" monster from your GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id)
	e2:SetTarget(s.gysptg)
	e2:SetOperation(s.gyspop)
	c:RegisterEffect(e2)
	--During your opponent's Standby Phase: add 1 "Ursarctic" monster
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_PHASE+PHASE_STANDBY)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.thcon)
	e3:SetTarget(s.thtg)
	e3:SetOperation(s.thop)
	c:RegisterEffect(e3)
	--Negate the activation, and if you do, destroy that card
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,2))
	e4:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetCode(EVENT_CHAINING)
	e4:SetRange(LOCATION_MZONE)
	e4:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL)
	e4:SetCountLimit(1,id+200)
	e4:SetCondition(s.negcon)
	e4:SetTarget(s.negtg)
	e4:SetOperation(s.negop)
	c:RegisterEffect(e4)
end
function s.matlevels(c,sc)
	local lv=c:GetLevel()
	if c:IsCode(CARD_HEXTANIUS) and sc:IsSetCard(SET_URSARCTIC) and sc:IsType(TYPE_SYNCHRO) then
		return {lv,7,8}
	end
	return {lv}
end
function s.haslevelabove(c,minlv,sc)
	for _,lv in ipairs(s.matlevels(c,sc)) do
		if lv>=minlv then return true end
	end
	return false
end
function s.leveldiff(c1,c2,dif,sc)
	for _,lv1 in ipairs(s.matlevels(c1,sc)) do
		for _,lv2 in ipairs(s.matlevels(c2,sc)) do
			if math.abs(lv1-lv2)==dif then return true end
		end
	end
	return false
end
function s.tgrfilter(c)
	return c:IsFaceup() and c:IsLevelAbove(1) and c:IsAbleToGraveAsCost()
end
function s.istuner8(c,sc)
	return c:IsType(TYPE_TUNER) and s.haslevelabove(c,8,sc)
end
function s.isnontunersynchro(c,sc)
	return c:IsType(TYPE_SYNCHRO) and (not c:IsType(TYPE_TUNER)
		or c:IsCode(CARD_HEXTANIUS) and sc:IsSetCard(SET_URSARCTIC) and sc:IsType(TYPE_SYNCHRO))
end
function s.fselect(g,tp,sc)
	if #g~=2 then return false end
	local c1=g:GetFirst()
	local c2=g:GetNext()
	return s.leveldiff(c1,c2,7,sc)
		and (s.istuner8(c1,sc) and s.isnontunersynchro(c2,sc) or s.istuner8(c2,sc) and s.isnontunersynchro(c1,sc))
		and Duel.GetLocationCountFromEx(tp,tp,g,sc)>0
end
function s.sprcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	local g=Duel.GetMatchingGroup(s.tgrfilter,tp,LOCATION_MZONE,0,nil)
	return g:CheckSubGroup(s.fselect,2,2,tp,c)
end
function s.sprtg(e,tp,eg,ep,ev,re,r,rp,chk,c)
	local g=Duel.GetMatchingGroup(s.tgrfilter,tp,LOCATION_MZONE,0,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local sg=g:SelectSubGroup(tp,s.fselect,true,2,2,tp,c)
	if sg then
		sg:KeepAlive()
		e:SetLabelObject(sg)
		return true
	end
	return false
end
function s.sprop(e,tp,eg,ep,ev,re,r,rp,c)
	local g=e:GetLabelObject()
	Duel.SendtoGrave(g,REASON_SPSUMMON)
	g:DeleteGroup()
end
function s.gyspfilter(c,e,tp)
	return c:IsSetCard(SET_URSARCTIC) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.gysptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.gyspfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE)
end
function s.gyspop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.gyspfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
	if tc and not aux.NecroValleyNegateCheck(tc) then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetTurnPlayer()==1-tp
end
function s.thfilter(c)
	return c:IsSetCard(SET_URSARCTIC) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 then
		Duel.SendtoHand(g,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,g)
	end
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return not e:GetHandler():IsStatus(STATUS_BATTLE_DESTROYED) and Duel.IsChainNegatable(ev)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
	if re:GetHandler():IsRelateToEffect(re) and re:GetHandler():IsDestructable() then
		Duel.SetOperationInfo(0,CATEGORY_DESTROY,eg,1,0,0)
	end
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.NegateActivation(ev) and re:GetHandler():IsRelateToEffect(re) then
		Duel.Destroy(eg,REASON_EFFECT)
	end
end
