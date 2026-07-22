-- Carcel, the Ohmechanic Light
local s,id=GetID()
local STRING_ID=133033429
local COUNTER_CURRENT = 0x18f0
local SET_OHMEN = 0x8de0
local SET_OHMECHANIC = 0x8de1
function s.initial_effect(c)
	-- Link Summon
	c:EnableReviveLimit()
	aux.AddLinkProcedure(c,nil,3,99,s.lcheck)
	-- GY Special Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.spcon)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	-- Double ATK
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_SET_ATTACK_FINAL)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCondition(s.atkcon)
	e2:SetValue(s.atkval)
	c:RegisterEffect(e2)
	-- Co-link counter placement
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e3:SetCode(EVENT_ADJUST)
	e3:SetRange(LOCATION_MZONE)
	e3:SetOperation(s.adjustop)
	c:RegisterEffect(e3)
	-- Destroy opponent's monsters
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,1))
	e4:SetCategory(CATEGORY_DESTROY)
	e4:SetType(EFFECT_TYPE_QUICK_O)
	e4:SetCode(EVENT_CHAINING)
	e4:SetRange(LOCATION_MZONE)
	e4:SetCountLimit(1,id+200)
	e4:SetCondition(s.descon)
	e4:SetCost(s.descost)
	e4:SetTarget(s.destg)
	e4:SetOperation(s.desop)
	c:RegisterEffect(e4)
end
s.listed_series={SET_OHMEN, SET_OHMECHANIC}

function s.lcheck(g,lc,sumtype,tp)
	return g:IsExists(Card.IsSetCard,1,nil,SET_OHMECHANIC,lc,sumtype,tp)
end

function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_LINK)
end
function s.spfilter(tc,e,tp)
	return tc:IsSetCard(SET_OHMEN) and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
	if #g>0 then
		Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)
	end
end

function s.atkcon(e)
	return e:GetHandler():GetCounter(COUNTER_CURRENT) > 0
end
function s.atkval(e,c)
	return c:GetBaseAttack() * 2
end

function s.adjustop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:GetMutualLinkedGroupCount() > 0 then
		if c:GetFlagEffect(id) == 0 and Duel.GetFlagEffect(tp, id) == 0 then
			c:RegisterFlagEffect(id, RESET_EVENT+RESETS_STANDARD, 0, 1)
			Duel.RegisterFlagEffect(tp, id, RESET_PHASE+PHASE_END, 0, 1)
			
			local lg=c:GetMutualLinkedGroup()
			local ratings = 0
			for tc in aux.Next(lg) do
				ratings = ratings + tc:GetLink()
			end
			
			c:AddCounter(COUNTER_CURRENT, ratings)
			for tc in aux.Next(lg) do
				if tc:IsControler(tp) then
					tc:AddCounter(COUNTER_CURRENT, ratings)
				end
			end
		end
	else
		c:ResetFlagEffect(id)
	end
end

function s.descon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp
end
function s.descost(e,tp,eg,ep,ev,re,r,rp,chk)
	local g=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_ONFIELD,0,nil)
	local total=0
	for tc in aux.Next(g) do total=total+tc:GetCounter(COUNTER_CURRENT) end
	if chk==0 then return total>=5 end
	for tc in aux.Next(g) do
		local ct=tc:GetCounter(COUNTER_CURRENT)
		if ct>0 then tc:RemoveCounter(tp,COUNTER_CURRENT,ct,REASON_COST) end
	end
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		return Duel.IsExistingMatchingCard(nil,tp,0,LOCATION_MZONE,1,nil)
	end
	local dg=Duel.GetMatchingGroup(nil,tp,0,LOCATION_MZONE,nil)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,dg,#dg,0,0)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local dg=Duel.GetMatchingGroup(nil,tp,0,LOCATION_MZONE,nil)
	if #dg>0 then
		Duel.Destroy(dg,REASON_EFFECT)
	end
end
