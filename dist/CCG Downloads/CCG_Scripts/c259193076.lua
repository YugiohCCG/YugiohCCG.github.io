--Eclipse Observer Baleygr
local s,id=GetID()
local SET_ECLIPSE=0xf2f4
local SET_ECLIPSE_OBSERVER=0xeb17
local OBSERVER_MONSTERS={
	[259652372]=true,
	[259926839]=true,
	[259069729]=true,
	[259487387]=true,
	[259058125]=true,
	[259193076]=true,
	[259126370]=true,
	[259612312]=true,
}
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddFusionProcFun2(c,s.fusmat1,aux.FilterBoolFunction(Card.IsRace,RACE_SPELLCASTER),true)
	--"Eclipse Observer" cards are unaffected by "Eclipse" Quick-Play Spells
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_IMMUNE_EFFECT)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTargetRange(LOCATION_ONFIELD+LOCATION_GRAVE,0)
	e1:SetTarget(s.immtg)
	e1:SetValue(s.immval)
	c:RegisterEffect(e1)
	--Cannot be destroyed by card effects while your opponent has 3+ cards
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	e2:SetCondition(s.hand3con)
	e2:SetValue(1)
	c:RegisterEffect(e2)
	--Cannot be targeted by card effects while your opponent has 3+ cards
	local e3=e2:Clone()
	e3:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	c:RegisterEffect(e3)
	--Opponent has no hand size limit while they have 6+ cards
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_FIELD)
	e4:SetCode(EFFECT_HAND_LIMIT)
	e4:SetRange(LOCATION_MZONE)
	e4:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e4:SetTargetRange(0,1)
	e4:SetCondition(s.hand6con)
	e4:SetValue(99)
	c:RegisterEffect(e4)
	--Copy an "Eclipse" Quick-Play Spell's activation effect
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(id,0))
	e5:SetType(EFFECT_TYPE_QUICK_O)
	e5:SetCode(EVENT_FREE_CHAIN)
	e5:SetRange(LOCATION_MZONE)
	e5:SetCountLimit(1,id)
	e5:SetCondition(s.cpcon)
	e5:SetCost(s.cpcost)
	e5:SetTarget(s.cptg)
	e5:SetOperation(s.cpop)
	c:RegisterEffect(e5)
end
s.listed_series={SET_ECLIPSE,SET_ECLIPSE_OBSERVER}
function s.isobservermonster(c)
	return c:IsType(TYPE_MONSTER) and (OBSERVER_MONSTERS[c:GetCode()] or c:IsSetCard(SET_ECLIPSE_OBSERVER))
end
function s.isobservercard(c)
	return s.isobservermonster(c) or c:IsSetCard(SET_ECLIPSE_OBSERVER)
end
function s.fusmat1(c)
	return s.isobservermonster(c) and c:IsLevel(8)
end
function s.immtg(e,c)
	return s.isobservercard(c)
end
function s.immval(e,te)
	local tc=te:GetHandler()
	return tc:IsSetCard(SET_ECLIPSE) and tc:IsType(TYPE_QUICKPLAY)
end
function s.hand3con(e)
	return Duel.GetFieldGroupCount(e:GetHandlerPlayer(),0,LOCATION_HAND)>=3
end
function s.hand6con(e)
	return Duel.GetFieldGroupCount(e:GetHandlerPlayer(),0,LOCATION_HAND)>=6
end
function s.cpcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetFieldGroupCount(tp,0,LOCATION_HAND)>=9
end
function s.cpfilter(c)
	return c:IsSetCard(SET_ECLIPSE) and c:IsType(TYPE_QUICKPLAY)
		and c:IsAbleToRemoveAsCost() and c:CheckActivateEffect(true,true,false)~=nil
end
function s.cpcost(e,tp,eg,ep,ev,re,r,rp,chk)
	e:SetLabel(1)
	if chk==0 then return true end
end
function s.cptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		if e:GetLabel()==0 then return false end
		e:SetLabel(0)
		return Duel.IsExistingMatchingCard(s.cpfilter,tp,LOCATION_GRAVE,0,1,nil)
	end
	e:SetLabel(0)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local tc=Duel.SelectMatchingCard(tp,s.cpfilter,tp,LOCATION_GRAVE,0,1,1,nil):GetFirst()
	local te,ceg,cep,cev,cre,cr,crp=tc:CheckActivateEffect(true,true,true)
	Duel.Remove(tc,POS_FACEUP,REASON_COST)
	e:SetProperty(te:GetProperty())
	local tg=te:GetTarget()
	if tg then tg(e,tp,ceg,cep,cev,cre,cr,crp,1) end
	te:SetLabelObject(e:GetLabelObject())
	e:SetLabelObject(te)
	Duel.ClearOperationInfo(0)
end
function s.cpop(e,tp,eg,ep,ev,re,r,rp)
	local te=e:GetLabelObject()
	if te then
		e:SetLabelObject(te:GetLabelObject())
		local op=te:GetOperation()
		if op then op(e,tp,eg,ep,ev,re,r,rp) end
	end
end
