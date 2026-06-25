--Wicked Puppeteer Tragedy
local s,id=GetID()
local SET_WICKED_PUPPETEER=0xe0a9
local CARD_ORCHIS=236818346
function s.initial_effect(c)
	--Activate and Ritual Summon "Wicked Puppeteer Orchis"
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_RELEASE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.rittg)
	e1:SetOperation(s.ritop)
	c:RegisterEffect(e1)
	--Banish this card; send 1 "Wicked Puppeteer" monster from Deck to the GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOGRAVE)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id+100)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.tgtg)
	e2:SetOperation(s.tgop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_WICKED_PUPPETEER}
s.listed_names={CARD_ORCHIS}
function s.matfilter(c,rc)
	return c:IsLocation(LOCATION_HAND+LOCATION_MZONE) and c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc)
end
function s.materialgroup(tp,rc)
	local mg=Duel.GetRitualMaterial(tp):Filter(s.matfilter,nil,rc)
	mg:RemoveCard(rc)
	return mg
end
function s.matcheck(g,tp)
	local fm=g:Filter(Card.IsLocation,nil,LOCATION_MZONE)
	return g:GetSum(Card.GetLevel)>=4 and Duel.GetMZoneCount(tp,fm)>0
end
function s.ritfilter(c,e,tp)
	if not (c:IsCode(CARD_ORCHIS) and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)) then return false end
	local mg=s.materialgroup(tp,c)
	return #mg>0 and mg:CheckSubGroup(s.matcheck,1,#mg,tp)
end
function s.rittg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.ritfilter),tp,
		LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_RELEASE,nil,1,tp,LOCATION_HAND+LOCATION_MZONE)
end
function s.ritop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local rc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.ritfilter),tp,
		LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
	if not rc then return end
	local mg=s.materialgroup(tp,rc)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local mat=mg:SelectSubGroup(tp,s.matcheck,false,1,#mg,tp)
	if not mat then return end
	rc:SetMaterial(mat)
	Duel.ReleaseRitualMaterial(mat)
	Duel.BreakEffect()
	if Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0 then
		rc:CompleteProcedure()
	end
end
function s.tgfilter(c)
	return c:IsSetCard(SET_WICKED_PUPPETEER) and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 then
		Duel.SendtoGrave(g,REASON_EFFECT)
	end
end
