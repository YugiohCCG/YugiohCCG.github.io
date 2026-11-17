--Aurelion Divine Illumination
local s,id=GetID()
local STRING_ID=133889864
function s.initial_effect(c)
	--Declare up to 3 names; excavate the bottom 3 cards, then maybe Special Summon this card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_ANNOUNCE+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Return this card to hand; negate an opponent activation
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_NEGATE)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.negcon)
	e2:SetCost(s.negcost)
	e2:SetTarget(s.negtg)
	e2:SetOperation(s.negop)
	c:RegisterEffect(e2)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)>=3
		and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	local ac1=Duel.AnnounceCard(tp)
	local ac2,ac3=0,0
	local ct=1
	if Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
		ac2=Duel.AnnounceCard(tp)
		ct=2
		if Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then
			ac3=Duel.AnnounceCard(tp)
			ct=3
		end
	end
	e:SetLabel(ct)
	Duel.RegisterFlagEffect(tp,id,RESET_CHAIN,0,1,ac1)
	if ct>1 then Duel.RegisterFlagEffect(tp,id,RESET_CHAIN,0,1,ac2) end
	if ct>2 then Duel.RegisterFlagEffect(tp,id,RESET_CHAIN,0,1,ac3) end
	Duel.SetOperationInfo(0,CATEGORY_ANNOUNCE,nil,0,tp,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_HAND)
end
function s.getbottomgroup(tp,ct)
	local dg=Duel.GetFieldGroup(tp,LOCATION_DECK,0)
	local g=Group.CreateGroup()
	for i=1,ct do
		local tc=dg:GetMinGroup(Card.GetSequence):GetFirst()
		if not tc then break end
		g:AddCard(tc)
		dg:RemoveCard(tc)
	end
	return g
end
function s.declared(c,ac1,ac2,ac3)
	return c:IsCode(ac1) or c:IsCode(ac2) or c:IsCode(ac3)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)<3 then return end
	local labels={Duel.GetFlagEffectLabel(tp,id)}
	local ac1,ac2,ac3=labels[1],labels[2] or 0,labels[3] or 0
	local g=s.getbottomgroup(tp,3)
	if #g<3 then return end
	Duel.ConfirmCards(1-tp,g)
	if g:FilterCount(s.declared,nil,ac1,ac2,ac3)==3
		and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsRelateToEffect(e)
		and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then
		Duel.ShuffleDeck(tp)
	end
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp and Duel.IsChainNegatable(ev)
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToHandAsCost() end
	Duel.SendtoHand(c,nil,REASON_COST)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev,re,r,rp)
	Duel.NegateActivation(ev)
end
