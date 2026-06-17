--Ursarctic Octantis
local s,id=GetID()
local SET_URSARCTIC=0x163
local CARD_HEXTANIUS=244921711
local CARD_URSARCTIC_DEPARTURE=16471775
local CARD_URSARCTIC_BIG_DIPPER=89264428
local CARD_LEOSHIP=247831166
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Cannot be Synchro Summoned
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	c:RegisterEffect(e0)
	--Must be Special Summoned by sending 2 monsters with a Level difference of 1
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetRange(LOCATION_EXTRA)
	e1:SetCondition(s.sprcon)
	e1:SetTarget(s.sprtg)
	e1:SetOperation(s.sprop)
	c:RegisterEffect(e1)
	--Tribute 1 Level 8 "Ursarctic" monster and this card; Special Summon 1 Level 7 "Ursarctic" Synchro
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_RELEASE+CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCost(s.upcost)
	e2:SetTarget(s.uptg)
	e2:SetOperation(s.upop)
	c:RegisterEffect(e2)
	--If an "Ursarctic" card you control is destroyed: banish this card; Special Summon 1 "Ursarctic" monster
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_DESTROYED)
	e3:SetRange(LOCATION_GRAVE)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id)
	e3:SetCondition(s.gyspcon)
	e3:SetCost(s.gyspcost)
	e3:SetTarget(s.gysptg)
	e3:SetOperation(s.gyspop)
	c:RegisterEffect(e3)
end
function s.matlevels(c,sc)
	local lv=c:GetLevel()
	if c:IsCode(CARD_HEXTANIUS) and sc:IsSetCard(SET_URSARCTIC) and sc:IsType(TYPE_SYNCHRO) then
		return {lv,7,8}
	end
	return {lv}
end
function s.leveldiff(c1,c2,dif,sc)
	for _,lv1 in ipairs(s.matlevels(c1,sc)) do
		for _,lv2 in ipairs(s.matlevels(c2,sc)) do
			if math.abs(lv1-lv2)==dif then return true end
		end
	end
	return false
end
function s.istuner(c,sc)
	return c:IsType(TYPE_TUNER)
end
function s.isnontuner(c,sc)
	return not c:IsType(TYPE_TUNER) or c:IsCode(CARD_HEXTANIUS) and sc:IsSetCard(SET_URSARCTIC) and sc:IsType(TYPE_SYNCHRO)
end
function s.tgrfilter(c)
	return c:IsFaceup() and c:IsLevelAbove(1) and c:IsAbleToGraveAsCost()
end
function s.fselect(g,tp,sc)
	if #g~=2 then return false end
	local c1=g:GetFirst()
	local c2=g:GetNext()
	return s.leveldiff(c1,c2,1,sc)
		and (s.istuner(c1,sc) and s.isnontuner(c2,sc) or s.istuner(c2,sc) and s.isnontuner(c1,sc))
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
function s.rfilter(c,tp)
	return c:IsLevel(8) and c:IsSetCard(SET_URSARCTIC) and c:IsReleasable()
		and (c:IsControler(tp) or c:IsFaceup())
end
function s.excostfilter(c,tp)
	return c:IsSetCard(SET_URSARCTIC) and c:IsLevelAbove(7) and c:IsAbleToRemoveAsCost()
		and s.repeffect(c,tp)
end
function s.repeffect(c,tp)
	return c:IsHasEffect(CARD_URSARCTIC_DEPARTURE,tp) or c:IsHasEffect(CARD_URSARCTIC_BIG_DIPPER,tp)
		or c:IsHasEffect(CARD_LEOSHIP,tp)
end
function s.upspfilter(c,e,tp,g)
	return c:IsLevel(7) and c:IsSetCard(SET_URSARCTIC) and c:IsType(TYPE_SYNCHRO)
		and Duel.GetLocationCountFromEx(tp,tp,g,c)>0 and c:IsCanBeSpecialSummoned(e,0,tp,true,false)
end
function s.costfilter(c,handler,e,tp)
	if s.repeffect(c,tp) then
		return Duel.IsExistingMatchingCard(s.upspfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,c)
	end
	if not handler:IsReleasable() then return false end
	return Duel.IsExistingMatchingCard(s.upspfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,Group.FromCards(c,handler))
end
function s.upcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local g=Duel.GetReleaseGroup(tp,true):Filter(s.rfilter,c,tp)
	g:Merge(Duel.GetMatchingGroup(s.excostfilter,tp,LOCATION_HAND+LOCATION_MZONE+LOCATION_GRAVE,0,c,tp))
	if chk==0 then return g:IsExists(s.costfilter,1,c,c,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local tc=g:FilterSelect(tp,s.costfilter,1,1,c,c,e,tp):GetFirst()
	local te=s.repeffect(tc,tp)
	if te then
		te:UseCountLimit(tp)
		Duel.Remove(tc,POS_FACEUP,REASON_EFFECT+REASON_REPLACE)
	else
		local rg=Group.FromCards(c,tc)
		Duel.Release(rg,REASON_COST)
	end
end
function s.uptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:IsCostChecked()
		or Duel.IsExistingMatchingCard(s.upspfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,nil) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.upop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,s.upspfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp,nil):GetFirst()
	if tc then
		Duel.SpecialSummon(tc,0,tp,tp,true,false,POS_FACEUP)
	end
end
function s.desfilter(c,tp)
	return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_ONFIELD) and c:IsPreviousSetCard(SET_URSARCTIC)
		and c:IsReason(REASON_BATTLE+REASON_EFFECT)
end
function s.gyspcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.desfilter,1,nil,tp)
end
function s.gyspcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToRemoveAsCost() end
	Duel.Remove(c,POS_FACEUP,REASON_COST)
end
function s.gyspfilter(c,e,tp)
	return c:IsSetCard(SET_URSARCTIC) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.gysptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.gyspfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.gyspop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.gyspfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp):GetFirst()
	if tc and not aux.NecroValleyNegateCheck(tc) then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	end
end
