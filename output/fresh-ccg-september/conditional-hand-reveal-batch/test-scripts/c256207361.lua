-- Sealed Glyphs Dragon
local s,id=GetID()
local STRING_ID=132207361
function s.initial_effect(c)
	-- xyz summon
	c:EnableReviveLimit()
	aux.AddXyzProcedure(c,nil,7,2,nil,nil,99)
	-- alternative summon
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetRange(LOCATION_EXTRA)
	e1:SetCondition(s.altcon)
	e1:SetTarget(s.alttg)
	e1:SetOperation(s.altop)
	e1:SetValue(SUMMON_TYPE_XYZ)
	c:RegisterEffect(e1)
	-- immune
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1)
	e2:SetCost(s.imcost)
	e2:SetTarget(s.imtg)
	e2:SetOperation(s.imop)
	c:RegisterEffect(e2)
end
function s.mfilter(c,xyzc,tp)
	return c:IsLocation(LOCATION_MZONE) and c:IsControler(tp) and c:IsFaceup()
		and c:IsCanBeXyzMaterial(xyzc)
end
function s.stfilter(c,xyzc,tp)
	return c:IsOnField() and c:IsFaceup() and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:GetOwner()==1-tp
		and c:IsCanOverlay()
end
function s.altfilter(c,xyzc,tp)
	return s.mfilter(c,xyzc,tp) or s.stfilter(c,xyzc,tp)
end
function s.altcheck(g,tp,xyzc)
	if #g~=2 then return false end
	local pair=g:IsExists(function(mc,sg,sc,p)
		return s.mfilter(mc,sc,p) and sg:IsExists(function(tc,first,xc,sp)
			return tc~=first and s.stfilter(tc,xc,sp)
		end,1,nil,mc,sc,p)
	end,1,nil,g,xyzc,tp)
	return pair and Duel.GetLocationCountFromEx(tp,tp,g,xyzc)>0
		and aux.MustMaterialCheck(g,tp,EFFECT_MUST_BE_XMATERIAL)
end
function s.getaltgroup(tp,xyzc,og)
	if og then return og:Filter(s.altfilter,nil,xyzc,tp) end
	return Duel.GetMatchingGroup(s.altfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil,xyzc,tp)
end
function s.altcountok(min,max)
	return not min or (min<=2 and max>=2)
end
function s.altcon(e,c,og,min,max)
	if c==nil then return true end
	if not s.altcountok(min,max) then return false end
	local tp=c:GetControler()
	local g=s.getaltgroup(tp,c,og)
	return g:CheckSubGroup(s.altcheck,2,2,tp,c)
end
function s.alttg(e,tp,eg,ep,ev,re,r,rp,chk,c,og,min,max)
	if og and not min then return true end
	if not s.altcountok(min,max) then return false end
	local g=s.getaltgroup(tp,c,og)
	if not g:CheckSubGroup(s.altcheck,2,2,tp,c) then return false end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
	local mat=g:SelectSubGroup(tp,s.altcheck,Duel.IsSummonCancelable(),2,2,tp,c)
	if not mat then return false end
	mat:KeepAlive()
	e:SetLabelObject(mat)
	return true
end
function s.altop(e,tp,eg,ep,ev,re,r,rp,c,og,min,max)
	local direct=og and not min
	local sg=direct and og or e:GetLabelObject()
	if not sg then return end
	for tc in aux.Next(sg) do
		local mg=tc:GetOverlayGroup()
		if #mg>0 then
			Duel.Overlay(c,mg)
		end
	end
	c:SetMaterial(sg)
	Duel.Overlay(c,sg)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_CANNOT_SUMMON)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e1:SetTargetRange(1,0)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	Duel.RegisterEffect(e2,tp)
	if not direct then sg:DeleteGroup() end
end
function s.imcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():CheckRemoveOverlayCard(tp,1,REASON_COST) end
	e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.imtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
end
function s.imop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and c:IsFaceup() then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_IMMUNE_EFFECT)
		e1:SetValue(s.efilter)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		c:RegisterEffect(e1)
	end
end
function s.efilter(e,re)
	return re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and re:GetOwnerPlayer()~=e:GetHandlerPlayer()
end
