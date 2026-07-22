--Eclipse Observer Nora
local s,id,o=GetID()
local STRING_ID=133069729
local SET_ECLIPSE=0xf2f4
local SET_ECLIPSE_OBSERVER=0xeb17
local CARD_OBSERVATORY=259721372
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
	--Send 1 "Eclipse" Quick-Play Spell or "Eclipse Observer" card from your Deck to the GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SUMMON_SUCCESS)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.tgtg)
	e1:SetOperation(s.tgop)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e2)
	--If your opponent draws 2 or more cards, draw 1 card
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_DRAW)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_DRAW)
	e3:SetRange(LOCATION_MZONE)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id+o)
	e3:SetCondition(s.drcon)
	e3:SetTarget(s.drtg)
	e3:SetOperation(s.drop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_ECLIPSE,SET_ECLIPSE_OBSERVER}
function s.isobservermonster(c)
	return c:IsType(TYPE_MONSTER) and (OBSERVER_MONSTERS[c:GetCode()] or c:IsSetCard(SET_ECLIPSE_OBSERVER))
end
function s.isobservercard(c)
	return s.isobservermonster(c) or c:IsSetCard(SET_ECLIPSE_OBSERVER) or c:IsCode(CARD_OBSERVATORY)
end
function s.tgfilter(c)
	return c:IsAbleToGrave() and ((c:IsSetCard(SET_ECLIPSE) and c:IsType(TYPE_QUICKPLAY)) or s.isobservercard(c))
end
function s.tgtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.tgfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.tgop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local g=Duel.SelectMatchingCard(tp,s.tgfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 then
		Duel.SendtoGrave(g,REASON_EFFECT)
	end
end
function s.drcon(e,tp,eg,ep,ev,re,r,rp)
	return ep==1-tp and #eg>=2
end
function s.drtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
end
function s.drop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Draw(tp,1,REASON_EFFECT)
end
