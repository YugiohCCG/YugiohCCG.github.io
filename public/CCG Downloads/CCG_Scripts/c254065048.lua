--Polemistis gia Ataxia
local s,id=GetID()
local SET_TO_PROTO=0xe80d
local TOKEN_PROTOGENIC=240299293
local CARD_TO_PROTO_ATAXIA=224225695
local ATAXIA_ST_CODES={
	[239245471]=true, --Birth of Azrynior
	[241957394]=true, --Chapter II Verse IV
}
function s.initial_effect(c)
	c:EnableReviveLimit()
	--Fusion material text
	aux.AddFusionProcFunRep(c,s.matfilter,2,true)
	--Must first be Special Summoned by Tributing the required materials
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0:SetValue(aux.fuslimit)
	c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_SPSUMMON_PROC)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e1:SetRange(LOCATION_EXTRA)
	e1:SetCondition(s.spcon)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Gain half the ATK/DEF currently lost by monsters on the field
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_SINGLE)
	e2:SetCode(EFFECT_UPDATE_ATTACK)
	e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetValue(s.atkval)
	c:RegisterEffect(e2)
	local e3=e2:Clone()
	e3:SetCode(EFFECT_UPDATE_DEFENSE)
	e3:SetValue(s.defval)
	c:RegisterEffect(e3)
	--Can attack all monsters your opponent controls, once each
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_SINGLE)
	e4:SetCode(EFFECT_ATTACK_ALL)
	e4:SetValue(1)
	c:RegisterEffect(e4)
	--If Special Summoned from the Extra Deck: add or send 1 "Ataxia" Spell/Trap
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(id,1))
	e5:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_TOGRAVE)
	e5:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e5:SetCode(EVENT_SPSUMMON_SUCCESS)
	e5:SetProperty(EFFECT_FLAG_DELAY)
	e5:SetCountLimit(1,id)
	e5:SetCondition(s.thcon)
	e5:SetTarget(s.thtg)
	e5:SetOperation(s.thop)
	c:RegisterEffect(e5)
end
s.listed_names={TOKEN_PROTOGENIC,CARD_TO_PROTO_ATAXIA}
function s.matfilter(c,fc)
	return c:IsCode(TOKEN_PROTOGENIC) and c:IsLevelAbove(1)
end
function s.ctrlfilter(c)
	return c:IsFaceup() and c:IsCode(CARD_TO_PROTO_ATAXIA)
end
function s.spfilter(c,fc)
	return s.matfilter(c,fc) and c:IsCanBeFusionMaterial(fc,SUMMON_TYPE_SPECIAL)
end
function s.spcheck(g,tp,fc)
	return Duel.GetLocationCountFromEx(tp,tp,g,fc)>0
end
function s.spcon(e,c)
	if c==nil then return true end
	local tp=c:GetControler()
	local rg=Duel.GetReleaseGroup(tp,false,REASON_SPSUMMON):Filter(s.spfilter,nil,c)
	return Duel.IsExistingMatchingCard(s.ctrlfilter,tp,LOCATION_MZONE,0,1,nil)
		and rg:CheckSubGroup(s.spcheck,2,2,tp,c)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,c)
	local rg=Duel.GetReleaseGroup(tp,false,REASON_SPSUMMON):Filter(s.spfilter,nil,c)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local g=rg:SelectSubGroup(tp,s.spcheck,true,2,2,tp,c)
	if g then
		g:KeepAlive()
		e:SetLabelObject(g)
		return true
	end
	return false
end
function s.spop(e,tp,eg,ep,ev,re,r,rp,c)
	local g=e:GetLabelObject()
	if not g then return end
	c:SetMaterial(g)
	Duel.Release(g,REASON_SPSUMMON+REASON_MATERIAL)
	g:DeleteGroup()
end
function s.atkloss(c)
	local oatk=c:GetTextAttack()
	if oatk<0 then return 0 end
	return math.max(0,oatk-c:GetAttack())
end
function s.defloss(c)
	local odef=c:GetTextDefense()
	if odef<0 then return 0 end
	return math.max(0,odef-c:GetDefense())
end
function s.lossfilter(c)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER)
end
function s.atkval(e,c)
	local g=Duel.GetMatchingGroup(s.lossfilter,e:GetHandlerPlayer(),LOCATION_MZONE,LOCATION_MZONE,nil)
	return math.floor(g:GetSum(s.atkloss)/2)
end
function s.defval(e,c)
	local g=Duel.GetMatchingGroup(s.lossfilter,e:GetHandlerPlayer(),LOCATION_MZONE,LOCATION_MZONE,nil)
	return math.floor(g:GetSum(s.defloss)/2)
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonLocation(LOCATION_EXTRA)
end
function s.thfilter(c)
	return ATAXIA_ST_CODES[c:GetCode()] and c:IsType(TYPE_SPELL+TYPE_TRAP)
		and (c:IsAbleToHand() or c:IsAbleToGrave())
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local tc=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if not tc then return end
	local b1=tc:IsAbleToHand()
	local b2=tc:IsAbleToGrave()
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))
	elseif b2 then
		op=1
	end
	if op==0 then
		if Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then
			Duel.ConfirmCards(1-tp,tc)
		end
	else
		Duel.SendtoGrave(tc,REASON_EFFECT)
	end
end
