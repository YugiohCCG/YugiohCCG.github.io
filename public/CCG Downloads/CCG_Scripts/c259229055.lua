local s,id=GetID()
local SET_GRAYSCALE=SET_GRAYSCALE or 0x575d
local STRING_ID=133229055
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Xyz Summon procedure
	aux.AddXyzProcedure(c,s.xyzfilter,12,2,nil,nil,99)
	--Xyz Summon using a Rank 8 "Grayscale" Xyz and Link-4 "Grayscale"
	local e0=Effect.CreateEffect(c)
	e0:SetDescription(aux.Stringid(STRING_ID,0))
	e0:SetType(EFFECT_TYPE_FIELD)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_PROC)
	e0:SetRange(LOCATION_EXTRA)
	e0:SetCondition(aux.XyzLevelFreeCondition(s.altfilter,s.altcheck,2,2))
	e0:SetTarget(aux.XyzLevelFreeTarget(s.altfilter,s.altcheck,2,2))
	e0:SetOperation(s.altop)
	e0:SetValue(SUMMON_TYPE_XYZ)
	c:RegisterEffect(e0)
	--Attach opponent monsters to this card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,1))
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.xyzsummoncon)
	e1:SetTarget(s.attachtg)
	e1:SetOperation(s.attachop)
	c:RegisterEffect(e1)
	--Detach 2 materials; change that activated effect
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,2))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.chcon)
	e2:SetCost(s.detach2)
	e2:SetTarget(s.chtg)
	e2:SetOperation(s.chop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_GRAYSCALE}
function s.xyzfilter(c)
	return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsRace(RACE_FIEND)
end
function s.r8filter(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_XYZ) and c:IsRank(8)
end
function s.l4filter(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_LINK) and c:GetLink()==4
end
function s.altfilter(c,sc)
	return c:IsControler(sc:GetControler()) and c:IsLocation(LOCATION_MZONE)
		and (s.r8filter(c) or s.l4filter(c))
end
function s.altcheck(g,sc,tp)
	return g:FilterCount(s.r8filter,nil)==1 and g:FilterCount(s.l4filter,nil)==1
end
function s.altop(e,tp,eg,ep,ev,re,r,rp,c,og,min,max)
	local kept=not (og and not min)
	local g=kept and e:GetLabelObject() or og
	if not g then return end
	local r8=g:Filter(s.r8filter,nil):GetFirst()
	if not r8 then
		if kept then g:DeleteGroup() end
		return
	end
	local mg=r8:GetOverlayGroup()
	if #mg>0 then Duel.Overlay(c,mg) end
	c:SetMaterial(g)
	Duel.Overlay(c,g)
	if kept then g:DeleteGroup() end
end
function s.xyzsummoncon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_XYZ)
end
function s.graymonster(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_MONSTER)
end
function s.oppmatfilter(c,e)
	return c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TOKEN)
		and c:IsCanOverlay() and not c:IsImmuneToEffect(e)
end
function s.attachtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=Duel.GetMatchingGroupCount(s.graymonster,tp,LOCATION_MZONE,0,nil)
	if chk==0 then return ct>0 and Duel.IsExistingMatchingCard(s.oppmatfilter,tp,0,LOCATION_MZONE,1,nil,e) end
end
function s.attachop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	local ct=Duel.GetMatchingGroupCount(s.graymonster,tp,LOCATION_MZONE,0,nil)
	if ct<=0 then return end
	local g=Duel.GetMatchingGroup(s.oppmatfilter,tp,0,LOCATION_MZONE,nil,e)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local sg=g:Select(tp,1,math.min(ct,#g),nil)
	if #sg>0 then
		local og=Group.CreateGroup()
		for tc in aux.Next(sg) do og:Merge(tc:GetOverlayGroup()) end
		if #og>0 then Duel.SendtoGrave(og,REASON_RULE) end
		Duel.Overlay(c,sg)
	end
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp
end
function s.detach2(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,2,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,2,2,REASON_COST)
end
function s.xyzgray(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_XYZ)
end
function s.fieldmat(c,xc,e)
	return c~=xc and c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TOKEN)
		and c:IsCanOverlay() and not c:IsImmuneToEffect(e)
end
function s.xyzwithmat(c,tp,e)
	return s.xyzgray(c) and Duel.IsExistingMatchingCard(s.fieldmat,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,c,e)
end
function s.chtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.xyzwithmat,tp,LOCATION_MZONE,0,1,nil,tp,e) end
end
function s.chop(e,tp,eg,ep,ev,re,r,rp)
	Duel.ChangeTargetCard(ev,Group.CreateGroup())
	Duel.ChangeChainOperation(ev,s.repop)
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	local p=1-tp
	if not Duel.IsExistingMatchingCard(s.xyzwithmat,p,LOCATION_MZONE,0,1,nil,p,e) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_FACEUP)
	local xc=Duel.SelectMatchingCard(p,s.xyzwithmat,p,LOCATION_MZONE,0,1,1,nil,p,e):GetFirst()
	if not xc then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_XMATERIAL)
	local mg=Duel.SelectMatchingCard(p,s.fieldmat,p,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,xc,e)
	if xc and #mg>0 then
		local og=mg:GetFirst():GetOverlayGroup()
		if #og>0 then Duel.SendtoGrave(og,REASON_RULE) end
		Duel.Overlay(xc,mg)
	end
end
