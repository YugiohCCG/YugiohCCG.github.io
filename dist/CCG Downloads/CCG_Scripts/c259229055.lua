local s,id=GetID()
local SET_GRAYSCALE=SET_GRAYSCALE or 0x575d
local XYZ_INFINITE_MATS=(Xyz and Xyz.InfiniteMats) or 99
local STRING_ID=id
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Xyz Summon procedure
	if Xyz and Xyz.AddProcedure then
		Xyz.AddProcedure(c,s.xyzfilter,12,2,nil,nil,XYZ_INFINITE_MATS)
	elseif aux.AddXyzProcedure then
		aux.AddXyzProcedure(c,s.xyzfilter,12,2,nil,nil,99)
	end
	--Xyz Summon using a Rank 8 "Grayscale" Xyz and Link-4 "Grayscale"
	local e0=Effect.CreateEffect(c)
	e0:SetDescription(aux.Stringid(STRING_ID,0))
	e0:SetType(EFFECT_TYPE_FIELD)
	e0:SetProperty(EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_PROC)
	e0:SetRange(LOCATION_EXTRA)
	e0:SetCondition(s.altcon)
	e0:SetTarget(s.alttg)
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
function s.altcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	return Duel.IsExistingMatchingCard(s.r8filter,tp,LOCATION_MZONE,0,1,nil)
		and Duel.IsExistingMatchingCard(s.l4filter,tp,LOCATION_MZONE,0,1,nil)
end
function s.alttg(e,tp,eg,ep,ev,re,r,rp,chk,c)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local g1=Duel.SelectMatchingCard(tp,s.r8filter,tp,LOCATION_MZONE,0,1,1,nil)
	local tc=g1:GetFirst()
	if not tc then return false end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local g2=Duel.SelectMatchingCard(tp,s.l4filter,tp,LOCATION_MZONE,0,1,1,tc)
	if #g2==0 then return false end
	g1:Merge(g2)
	g1:KeepAlive()
	e:SetLabelObject(g1)
	return true
end
function s.altop(e,tp,eg,ep,ev,re,r,rp,c)
	local g=e:GetLabelObject()
	if not g then return end
	if c then
		c:SetMaterial(g)
		Duel.Overlay(c,g)
	end
	g:DeleteGroup()
end
function s.xyzsummoncon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_XYZ)
end
function s.graymonster(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_MONSTER)
end
function s.oppmatfilter(c)
	return c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TOKEN)
end
function s.attachtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=Duel.GetMatchingGroupCount(s.graymonster,tp,LOCATION_MZONE,0,nil)
	if chk==0 then return ct>0 and Duel.IsExistingMatchingCard(s.oppmatfilter,tp,0,LOCATION_MZONE,1,nil) end
end
function s.attachop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	local ct=Duel.GetMatchingGroupCount(s.graymonster,tp,LOCATION_MZONE,0,nil)
	if ct<=0 then return end
	local g=Duel.GetMatchingGroup(s.oppmatfilter,tp,0,LOCATION_MZONE,nil)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local sg=g:Select(tp,1,math.min(ct,#g),nil)
	if #sg>0 then
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
function s.chop(e,tp,eg,ep,ev,re,r,rp)
	re:SetLabel(tp)
	Duel.ChangeChainOperation(ev,s.repop)
end
function s.xyzgray(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_XYZ)
end
function s.fieldmat(c,xc)
	return c~=xc and c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TOKEN)
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	local p=e:GetLabel()
	if p~=0 and p~=1 then p=1-tp end
	if not Duel.IsExistingMatchingCard(s.xyzgray,p,LOCATION_MZONE,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_FACEUP)
	local xc=Duel.SelectMatchingCard(p,s.xyzgray,p,LOCATION_MZONE,0,1,1,nil):GetFirst()
	if not xc then return end
	if not Duel.IsExistingMatchingCard(s.fieldmat,p,LOCATION_MZONE,LOCATION_MZONE,1,nil,xc) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_XMATERIAL)
	local mg=Duel.SelectMatchingCard(p,s.fieldmat,p,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,xc)
	if xc and #mg>0 then
		Duel.Overlay(xc,mg)
	end
end
