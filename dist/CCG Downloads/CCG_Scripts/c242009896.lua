--Extinction of Dysmandr
local s,id=GetID()
local STRING_ID=132009896
local TOKEN_PROTOGENIC=240299293
local CARD_DYSMANDR=223512283
function s.initial_effect(c)
	--Activate
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	--Tribute 1 Token; destroy matching Effect Monsters
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_RELEASE+CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_SZONE)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.descon)
	e1:SetCost(s.descost)
	e1:SetTarget(s.destg)
	e1:SetOperation(s.desop)
	c:RegisterEffect(e1)
end
s.listed_names={TOKEN_PROTOGENIC,CARD_DYSMANDR}
function s.ctrlfilter(c)
	return c:IsFaceup() and c:IsCode(CARD_DYSMANDR)
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(s.ctrlfilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.tkfilter(c)
	return c:IsCode(TOKEN_PROTOGENIC) and c:IsReleasable()
end
function s.descost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckReleaseGroup(tp,s.tkfilter,1,nil) end
	local g=Duel.SelectReleaseGroup(tp,s.tkfilter,1,1,nil)
	Duel.Release(g,REASON_COST)
end
function s.efilter(c)
	return c:IsFaceup() and c:IsType(TYPE_EFFECT)
end
function s.match(c,tc)
	return c:IsRace(tc:GetRace()) or c:IsAttribute(tc:GetAttribute())
		or (c:GetLevel()>0 and tc:GetLevel()>0 and c:IsLevel(tc:GetLevel()))
		or (c:GetAttack()>=0 and tc:GetAttack()>=0 and c:GetAttack()==tc:GetAttack())
		or (not c:IsType(TYPE_LINK) and not tc:IsType(TYPE_LINK)
			and c:GetDefense()>=0 and tc:GetDefense()>=0 and c:GetDefense()==tc:GetDefense())
end
function s.dgfilter(c,tc)
	return c~=tc and c:IsFaceup() and c:IsType(TYPE_EFFECT) and not c:IsCode(CARD_DYSMANDR)
		and s.match(c,tc)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.efilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,PLAYER_ALL,LOCATION_MZONE)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	if not e:GetHandler():IsRelateToEffect(e) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local tc=Duel.SelectMatchingCard(tp,s.efilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil):GetFirst()
	if not tc then return end
	local g=Duel.GetMatchingGroup(s.dgfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil,tc)
	if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 then return end
	Duel.BreakEffect()
	if tc:IsOnField() then
		Duel.Destroy(tc,REASON_EFFECT)
	end
end
