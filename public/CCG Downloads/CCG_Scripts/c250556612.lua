--NiuHao - Zao
local s,id=GetID()
local STRING_ID=132556612
local SET_SACRED_TREASURE=0x8a20
function s.initial_effect(c)
	--Xyz Summon
	aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_WINDBEAST),1,2,nil,nil,99)
	c:EnableReviveLimit()
	--Materials detached from this card are banished instead
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_TO_GRAVE_REDIRECT)
	e1:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_OVERLAY,LOCATION_OVERLAY)
	e1:SetTarget(s.rmtg)
	e1:SetValue(LOCATION_REMOVED)
	c:RegisterEffect(e1)
	--Cannot be destroyed by card effects while it has material
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCondition(s.matcon)
	e2:SetValue(1)
	c:RegisterEffect(e2)
	--Detach 1 material; banish 2 "Sacred Treasure" Spells and apply their activation effects
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,0))
	e3:SetCategory(CATEGORY_REMOVE+CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON+CATEGORY_POSITION+CATEGORY_DRAW)
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_FREE_CHAIN)
	e3:SetRange(LOCATION_MZONE)
	e3:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_END_PHASE)
	e3:SetCountLimit(1,id)
	e3:SetCost(s.cost)
	e3:SetTarget(s.target)
	e3:SetOperation(s.operation)
	c:RegisterEffect(e3)
end
function s.rmtg(e,c)
	return c:GetOverlayTarget()==e:GetHandler()
end
function s.matcon(e)
	return e:GetHandler():GetOverlayCount()>0
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:CheckRemoveOverlayCard(tp,1,REASON_COST) end
	c:RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.rmfilter(c)
	return c:IsSetCard(SET_SACRED_TREASURE) and c:IsType(TYPE_SPELL) and c:IsAbleToRemove()
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
		and c:CheckActivateEffect(false,true,false)~=nil
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.rmfilter,tp,LOCATION_HAND+LOCATION_GRAVE,0,2,nil) end
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,2,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.operation(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsExistingMatchingCard(s.rmfilter,tp,LOCATION_HAND+LOCATION_GRAVE,0,2,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local rg=Duel.SelectMatchingCard(tp,s.rmfilter,tp,LOCATION_HAND+LOCATION_GRAVE,0,2,2,nil)
	if #rg<2 or Duel.Remove(rg,POS_FACEUP,REASON_EFFECT)<2 then return end
	local og=Duel.GetOperatedGroup():Filter(Card.IsLocation,nil,LOCATION_REMOVED)
	while #og>0 do
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
		local tc=og:Select(tp,1,1,nil):GetFirst()
		og:RemoveCard(tc)
		if tc then s.applyeffect(e,tp,tc) end
	end
end
function s.applyeffect(e,tp,tc)
	if not (tc:IsFaceup() and tc:IsLocation(LOCATION_REMOVED)) then return end
	local te,ceg,cep,cev,cre,cr,crp=tc:CheckActivateEffect(false,true,true)
	if not te then return end
	e:SetProperty(te:GetProperty())
	e:SetLabel(te:GetLabel())
	e:SetLabelObject(te:GetLabelObject())
	Duel.ClearTargetCard()
	local tg=te:GetTarget()
	if tg then tg(e,tp,ceg,cep,cev,cre,cr,crp,1) end
	te:SetLabel(e:GetLabel())
	te:SetLabelObject(e:GetLabelObject())
	e:SetLabelObject(te)
	local op=te:GetOperation()
	if op then
		e:SetLabel(te:GetLabel())
		e:SetLabelObject(te:GetLabelObject())
		op(e,tp,ceg,cep,cev,cre,cr,crp)
		te:SetLabel(e:GetLabel())
		te:SetLabelObject(e:GetLabelObject())
	end
	Duel.ClearOperationInfo(0)
end
