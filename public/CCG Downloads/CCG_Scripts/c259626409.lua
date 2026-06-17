local s,id=GetID()
local SET_GRAYSCALE=SET_GRAYSCALE or 0x575d
local XYZ_INFINITE_MATS=(Xyz and Xyz.InfiniteMats) or 99
local STRING_ID=id
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Xyz Summon procedure
	if Xyz and Xyz.AddProcedure then
		Xyz.AddProcedure(c,nil,8,2,nil,nil,XYZ_INFINITE_MATS,nil,nil,s.xyzcheck)
	elseif aux.AddXyzProcedure then
		aux.AddXyzProcedure(c,nil,8,2,nil,nil,99,nil,nil,s.xyzcheck)
	end
	--Cannot be used as Link Material, except for a "Grayscale" monster
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	e0:SetValue(s.linklimit)
	c:RegisterEffect(e0)
	--Detach 1 material; change that Spell/Trap effect
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCode(EVENT_CHAINING)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.chcon)
	e1:SetCost(s.detach1)
	e1:SetTarget(s.chtg)
	e1:SetOperation(s.chop)
	c:RegisterEffect(e1)
	--Detach 2 materials; add 1 "Grayscale" card from your GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_PHASE+PHASE_END)
	e2:SetRange(LOCATION_MZONE)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+100)
	e2:SetCost(s.detach2)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_GRAYSCALE}
function s.lightfiendmat(c)
	return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsRace(RACE_FIEND)
end
function s.xyzcheck(g,tp,xyz)
	return g:IsExists(s.lightfiendmat,1,nil)
end
function s.linklimit(e,c)
	return c and not c:IsSetCard(SET_GRAYSCALE)
end
function s.detach1(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.detach2(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,2,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,2,2,REASON_COST)
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and re:IsHasType(EFFECT_TYPE_ACTIVATE)
end
function s.spellfilter(c,e)
	return c:IsType(TYPE_SPELL) and c:IsCanBeEffectTarget(e)
end
function s.xyzgray(c)
	return c:IsFaceup() and c:IsSetCard(SET_GRAYSCALE) and c:IsType(TYPE_XYZ)
end
function s.chtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.spellfilter)(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.spellfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,nil,e)
		and Duel.IsExistingMatchingCard(s.xyzgray,tp,LOCATION_MZONE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.spellfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_LEAVE_GRAVE,g,1,0,0)
end
function s.chop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and tc:IsLocation(LOCATION_GRAVE)
		and aux.NecroValleyFilter()(tc)) then return end
	re:SetLabelObject(tc)
	Duel.ChangeTargetCard(ev,Group.FromCards(tc))
	Duel.ChangeChainOperation(ev,s.repop)
end
function s.repop(e,tp,eg,ep,ev,re,r,rp)
	local p=1-tp
	local tc=e:GetLabelObject()
	if not (tc and tc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter()(tc)) then return end
	if not Duel.IsExistingMatchingCard(s.xyzgray,p,LOCATION_MZONE,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,p,HINTMSG_FACEUP)
	local xc=Duel.SelectMatchingCard(p,s.xyzgray,p,LOCATION_MZONE,0,1,1,nil):GetFirst()
	if xc then
		Duel.Overlay(xc,Group.FromCards(tc))
	end
end
function s.thfilter(c,e)
	return c:IsSetCard(SET_GRAYSCALE) and c:IsAbleToHand()
		and c:IsCanBeEffectTarget(e)
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.thfilter)(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_GRAVE,0,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_GRAVE,0,1,1,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,tp,0)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter()(tc) and tc:IsAbleToHand() then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
	end
end
