local s,id=GetID()
local SET_GLADIATOR=SET_GLADIATOR or 0x19
local SET_GLADIATOR_BEAST=SET_GLADIATOR_BEAST or 0x1019
local STRING_ID=id
local TEST_MONSTERS={
	[3030892]=true,
	[62076252]=true,
	[66863374]=true,
	[92373006]=true,
}
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Special Summon from the Extra Deck by returning 2 "Gladiator Beast" and/or "Test" monsters
	local e0=Effect.CreateEffect(c)
	e0:SetDescription(aux.Stringid(STRING_ID,2))
	e0:SetType(EFFECT_TYPE_FIELD)
	e0:SetProperty(EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_PROC)
	e0:SetRange(LOCATION_EXTRA)
	e0:SetCondition(s.contactcon)
	e0:SetTarget(s.contacttg)
	e0:SetOperation(s.contactop)
	c:RegisterEffect(e0)
	--Must be Special Summoned by its own procedure first
	local e0b=Effect.CreateEffect(c)
	e0b:SetType(EFFECT_TYPE_SINGLE)
	e0b:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0b:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0b:SetValue(s.splimit)
	c:RegisterEffect(e0b)
	--Special Summon 1 Level 4 or lower "Gladiator Beast" monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.decksptg)
	e1:SetOperation(s.deckspop)
	c:RegisterEffect(e1)
	--"Gladiator Beast" monsters you control gain 300 ATK
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_UPDATE_ATTACK)
	e2:SetRange(LOCATION_MZONE)
	e2:SetTargetRange(LOCATION_MZONE,0)
	e2:SetTarget(s.atktg)
	e2:SetValue(300)
	c:RegisterEffect(e2)
	--Return this card to the Extra Deck; Special Summon 1 "Gladiator Beast" monster
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_PHASE|PHASE_BATTLE)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCondition(s.battlecon)
	e3:SetCost(s.extracost)
	e3:SetTarget(s.gbsptg)
	e3:SetOperation(s.gbspop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_GLADIATOR,SET_GLADIATOR_BEAST}
s.listed_names={3030892,62076252,66863374,92373006}
s.material_setcode={SET_GLADIATOR,SET_GLADIATOR_BEAST}
function s.isgb(c)
	return c:IsType(TYPE_MONSTER) and (c:IsSetCard(SET_GLADIATOR_BEAST) or c:IsSetCard(SET_GLADIATOR))
end
function s.istest(c)
	return c:IsType(TYPE_MONSTER) and (TEST_MONSTERS[c:GetCode()] or TEST_MONSTERS[c:GetOriginalCode()])
end
function s.matfilter(c,fc,sumtype,tp)
	return s.isgb(c) or s.istest(c)
end
function s.contactfilter(c)
	return s.matfilter(c) and c:IsAbleToDeckAsCost()
end
function s.contactcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	if not Duel.IsExistingMatchingCard(s.contactfilter,tp,LOCATION_HAND|LOCATION_MZONE,0,2,nil) then return false end
	return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		or Duel.IsExistingMatchingCard(s.contactfilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.contacttg(e,tp,eg,ep,ev,re,r,rp,chk,c)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local sg=nil
	if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
		sg=Duel.SelectMatchingCard(tp,s.contactfilter,tp,LOCATION_HAND|LOCATION_MZONE,0,2,2,nil)
	else
		sg=Duel.SelectMatchingCard(tp,s.contactfilter,tp,LOCATION_MZONE,0,1,1,nil)
		local tc=sg:GetFirst()
		local sg2=Duel.SelectMatchingCard(tp,s.contactfilter,tp,LOCATION_HAND|LOCATION_MZONE,0,1,1,tc)
		sg:Merge(sg2)
	end
	if #sg~=2 then return false end
	sg:KeepAlive()
	e:SetLabelObject(sg)
	return true
end
function s.contactop(e,tp,eg,ep,ev,re,r,rp,c)
	local g=e:GetLabelObject()
	if not g then return end
	if c then
		c:SetMaterial(g)
	end
	Duel.ConfirmCards(1-tp,g)
	Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_COST|REASON_MATERIAL)
	g:DeleteGroup()
end
function s.splimit(e,se,sp,st)
	return e:GetHandler():GetLocation()~=LOCATION_EXTRA
end
function s.deckspfilter(c,e,tp)
	return s.isgb(c) and c:IsLevelBelow(4) and c:IsCanBeSpecialSummoned(e,100,tp,false,false)
end
function s.decksptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.deckspfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.deckspop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.deckspfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	if tc and Duel.SpecialSummon(tc,100,tp,tp,false,false,POS_FACEUP)>0 then
		tc:RegisterFlagEffect(tc:GetOriginalCode(),RESET_EVENT+RESETS_STANDARD,0,0)
	end
end
function s.atktg(e,c)
	return s.isgb(c)
end
function s.battlecon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetBattledGroupCount()>0
end
function s.extracost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToDeckAsCost()
		or (Card.IsAbleToExtraAsCost and c:IsAbleToExtraAsCost()) end
	Duel.SendtoDeck(c,nil,SEQ_DECKTOP,REASON_COST)
end
function s.gbfilter(c,e,tp)
	return s.isgb(c) and c:IsCanBeSpecialSummoned(e,100,tp,false,false)
end
function s.mzonecheck(tp,c)
	return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		or (c and c:IsLocation(LOCATION_MZONE) and c:GetSequence()<5)
end
function s.gbsptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return s.mzonecheck(tp,e:GetHandler())
		and Duel.IsExistingMatchingCard(s.gbfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.gbspop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.gbfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst()
	if tc and Duel.SpecialSummon(tc,100,tp,tp,false,false,POS_FACEUP)>0 then
		tc:RegisterFlagEffect(tc:GetOriginalCode(),RESET_EVENT+RESETS_STANDARD,0,0)
	end
end
