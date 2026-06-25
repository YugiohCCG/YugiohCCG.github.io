local s,id=GetID()
local SET_GRAYSCALE=SET_GRAYSCALE or 0x575d
local STRING_ID=id
function s.initial_effect(c)
	--Cannot be used as Xyz or Link Material, except for a "Grayscale" monster
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_CANNOT_BE_XYZ_MATERIAL)
	e0:SetValue(s.matlimit)
	c:RegisterEffect(e0)
	local e0b=e0:Clone()
	e0b:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	c:RegisterEffect(e0b)
	--Special Summon this card from your hand
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.handcon)
	e1:SetTarget(s.handsptg)
	e1:SetOperation(s.handspop)
	c:RegisterEffect(e1)
	--Immediately Link Summon 1 "Grayscale" Link Monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.linktg)
	e2:SetOperation(s.linkop)
	c:RegisterEffect(e2)
	--Discard 1 card; Special Summon this card from your GY
	local e3=Effect.CreateEffect(c)
function s.initial_effect(c)
	--Cannot be used as Xyz or Link Material, except for a "Grayscale" monster
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_CANNOT_BE_XYZ_MATERIAL)
	e0:SetValue(s.matlimit)
	c:RegisterEffect(e0)
	local e0b=e0:Clone()
	e0b:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	c:RegisterEffect(e0b)
	--Special Summon this card from your hand
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.handcon)
	e1:SetTarget(s.handsptg)
	e1:SetOperation(s.handspop)
	c:RegisterEffect(e1)
	--Immediately Link Summon 1 "Grayscale" Link Monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.linktg)
	e2:SetOperation(s.linkop)
	c:RegisterEffect(e2)
	--Discard 1 card; Special Summon this card from your GY
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,2))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetRange(LOCATION_GRAVE)
	e3:SetCountLimit(1,id+200)
	e3:SetCondition(s.gycon)
	e3:SetCost(s.gyspcost)
	e3:SetTarget(s.gysptg)
	e3:SetOperation(s.gyspop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_GRAYSCALE}
function s.matlimit(e,c)
	if not c then return false end
	return not c:IsSetCard(SET_GRAYSCALE)
end
function s.handcon(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	return (ph==PHASE_MAIN1 or ph==PHASE_MAIN2)
		and Duel.IsExistingMatchingCard(s.oppmon,tp,0,LOCATION_MZONE,1,nil)
end
function s.oppmon(c)
	return c:IsType(TYPE_MONSTER)
end
function s.handsptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_HAND)
end
function s.handspop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
		Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.linkfilter(c,mc)
	local mg=Group.FromCards(mc)
	return Card.IsLinkSummonable and c:IsSetCard(SET_GRAYSCALE)
		and c:IsType(TYPE_LINK) and c:IsLinkSummonable(mg)
end
function s.linktg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then
		local ex=s.registerextra(c)
		local res=Duel.IsExistingMatchingCard(s.linkfilter,tp,LOCATION_EXTRA,0,1,nil,c)
		if ex then ex:Reset() end
		return res
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.linkop(e,tp,eg,ep,ev,re,r,rp)
	if not Card.IsLinkSummonable then return end
	local c=e:GetHandler()
	local ex=nil
	if c:IsRelateToEffect(e) then
		ex=s.registerextra(c)
	end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.linkfilter,tp,LOCATION_EXTRA,0,1,1,nil,c):GetFirst()
	if tc then
		Duel.LinkSummon(tp,tc,Group.FromCards(c))
		if ex then
			s.resetextra(c,tp,ex)
		end
	elseif ex then
		ex:Reset()
	end
end
function s.registerextra(c)
	if not EFFECT_EXTRA_MATERIAL then return nil end
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetCode(EFFECT_EXTRA_MATERIAL)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(1,0)
	e1:SetOperation(s.extracon)
	e1:SetValue(s.extraval)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	c:RegisterEffect(e1)
	return e1
end
function s.resetextra(c,tp,ex)
	local ev=Duel.GetCurrentChain()==1 and EVENT_SPSUMMON or EVENT_SPSUMMON_SUCCESS
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(ev)
	e1:SetOperation(function(e) ex:Reset() e:Reset() end)
	Duel.RegisterEffect(e1,tp)
end
function s.handmatfilter(c)
	return c:IsSetCard(SET_GRAYSCALE) and c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsRace(RACE_FIEND)
		and c:IsCanBeLinkMaterial()
end
function s.extracon(c,e,tp,sg,mg,lc,og,chk)
	return sg:IsContains(e:GetHandler())
end
function s.extraval(chk,summon_type,e,...)
	if chk==0 then
		local tp,sc=...
		if summon_type~=SUMMON_TYPE_LINK or not sc:IsSetCard(SET_GRAYSCALE) then
			return Group.CreateGroup()
		end
		return Duel.GetMatchingGroup(s.handmatfilter,tp,LOCATION_HAND,0,nil)
	elseif chk==1 then
		local sg,sc,tp=...
		if (summon_type&SUMMON_TYPE_LINK)==SUMMON_TYPE_LINK and #sg>0 then
			Duel.Hint(HINT_CARD,tp,id)
		end
	end
end
function s.xyzspfilter(c,tp)
	return c:IsControler(tp) and c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_XYZ)
end
function s.gycon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.xyzspfilter,1,nil,tp)
end
function s.gyspcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil) end
	Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_COST+REASON_DISCARD)
end
function s.gysptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return aux.NecroValleyFilter()(c)
		and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_GRAVE)
end
function s.gyspop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and aux.NecroValleyFilter()(c) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
		Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
	end
end
end
