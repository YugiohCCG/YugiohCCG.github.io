--Harpie Cyber Dancer
local s,id=GetID()
local STRING_ID=133794136
local SET_HARPIE=0x64
local SET_HARPIE_CUSTOM=0x079c
local CARD_HARPIE_LADY=76812113
local CARD_HARPIES_HUNTING_GROUND=75782277
local HARP_CODE_LIST={CARD_HARPIE_LADY,91932350,27927359,54415063,80316585,id}
function s.initial_effect(c)
	aux.AddCodeList(c,CARD_HARPIE_LADY,CARD_HARPIES_HUNTING_GROUND)
	--This card's name is treated as "Harpie Lady"
	aux.EnableChangeCode(c,CARD_HARPIE_LADY,LOCATION_MZONE+LOCATION_GRAVE)
	--Special Summon itself by returning 1 "Harpie Lady"
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetRange(LOCATION_HAND+LOCATION_GRAVE)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCondition(s.spcon)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Send 1 "Harpie" monster; Normal Summon 1 Winged Beast
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SUMMON)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCost(s.nscost)
	e2:SetTarget(s.nstg)
	e2:SetOperation(s.nsop)
	c:RegisterEffect(e2)
	--If sent from field to GY: Set 1 Spell/Trap
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,2))
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
function s.spfilter(c,tp)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER) and s.isharpielady(c)
		and c:IsAbleToHandAsCost() and Duel.GetMZoneCount(tp,c)>0
end
function s.spcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	return (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_MZONE,0,1,nil,tp)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp,c)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_MZONE,0,1,1,nil,tp)
	Duel.SendtoHand(g,nil,REASON_COST)
end
function s.harpiemon(c)
	return (c:IsSetCard(SET_HARPIE) or c:IsSetCard(SET_HARPIE_CUSTOM))
		and c:IsType(TYPE_MONSTER) and c:IsAbleToGraveAsCost()
end
function s.nsfilter(c)
	return c:IsRace(RACE_WINDBEAST) and c:IsSummonable(true,nil)
end
function s.nscost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.harpiemon,tp,LOCATION_DECK,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.harpiemon,tp,LOCATION_DECK,0,1,1,nil)
	Duel.SendtoGrave(g,REASON_COST)
end
function s.nstg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanSummon(tp)
		and Duel.IsExistingMatchingCard(s.nsfilter,tp,LOCATION_HAND,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_SUMMON,nil,1,tp,LOCATION_HAND)
end
function s.nsop(e,tp,eg,ep,ev,re,r,rp)
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
