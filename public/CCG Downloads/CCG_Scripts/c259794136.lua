--Harpie Cyber Dancer
local s,id=GetID()
local SET_HARPIE=0x64
local SET_HARPIE_CUSTOM=0x079c
local CARD_HARPIE_LADY=76812113
local CARD_HARPIES_HUNTING_GROUND=75782277
local HARP_CODE_LIST={CARD_HARPIE_LADY,91932350,27927359,54415063,80316585,id}
function s.initial_effect(c)
	aux.AddCodeList(c,CARD_HARPIE_LADY,CARD_HARPIES_HUNTING_GROUND)
	--This card's name is treated as "Harpie Lady"
	aux.EnableChangeCode(c,CARD_HARPIE_LADY,LOCATION_MZONE+LOCATION_GRAVE)
	--Return 1 "Harpie Lady"; Special Summon this card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND+LOCATION_GRAVE)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Send 1 "Harpie" monster; Normal Summon 1 Winged Beast
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SUMMON)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.nstg)
	e2:SetOperation(s.nsop)
	c:RegisterEffect(e2)
	--If sent from field to GY: Set 1 Spell/Trap
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,2))
	e3:SetCategory(CATEGORY_SSET)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCode(EVENT_TO_GRAVE)
	e3:SetCountLimit(1,id+200)
	e3:SetCondition(s.setcon)
	e3:SetTarget(s.settg)
	e3:SetOperation(s.setop)
	c:RegisterEffect(e3)
end
function s.isharpielady(c)
	return c:IsCode(table.unpack(HARP_CODE_LIST))
end
function s.spfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER) and s.isharpielady(c) and c:IsAbleToHand()
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter(aux.TRUE)(c))
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_MZONE,0,1,c) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_MZONE)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,c:GetLocation())
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_MZONE,0,1,1,c)
	if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
	if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsRelateToEffect(e)
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter(aux.TRUE)(c)) then
		Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.harpiemon(c)
	return (c:IsSetCard(SET_HARPIE) or c:IsSetCard(SET_HARPIE_CUSTOM)) and c:IsType(TYPE_MONSTER) and c:IsAbleToGrave()
end
function s.nsfilter(c)
	return c:IsRace(RACE_WINDBEAST) and c:IsSummonable(true,nil)
end
function s.nstg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanSummon(tp)
		and Duel.IsExistingMatchingCard(s.harpiemon,tp,LOCATION_DECK,0,1,nil)
		and Duel.IsExistingMatchingCard(s.nsfilter,tp,LOCATION_HAND,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_SUMMON,nil,1,tp,LOCATION_HAND)
end
function s.nsop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.harpiemon,tp,LOCATION_DECK,0,1,1,nil)
	if #g==0 or Duel.SendtoGrave(g,REASON_EFFECT)==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SUMMON)
	local sg=Duel.SelectMatchingCard(tp,s.nsfilter,tp,LOCATION_HAND,0,1,1,nil)
	local sc=sg:GetFirst()
	if sc then
		Duel.Summon(tp,sc,true,nil)
	end
end
function s.setcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsPreviousLocation(LOCATION_ONFIELD)
end
function s.gysetfilter(c)
	return c:IsType(TYPE_SPELL+TYPE_TRAP) and aux.IsCodeListed(c,CARD_HARPIE_LADY) and c:IsSSetable()
end
function s.dksetfilter(c)
	return c:IsCode(CARD_HARPIES_HUNTING_GROUND) and c:IsSSetable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0
		and (Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.gysetfilter),tp,LOCATION_GRAVE,0,1,nil)
			or Duel.IsExistingMatchingCard(s.dksetfilter,tp,LOCATION_DECK,0,1,nil)) end
	Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.gysetfilter),tp,LOCATION_GRAVE,0,nil)
	local dg=Duel.GetMatchingGroup(s.dksetfilter,tp,LOCATION_DECK,0,nil)
	g:Merge(dg)
	if #g==0 then return end
	local sg=g:Select(tp,1,1,nil)
	local tc=sg:GetFirst()
	if tc then
		Duel.SSet(tp,tc)
	end
end
