local s,id=GetID()
local STRING_ID=133924331
local BOB=259722826
local UMI=22702055
function s.initial_effect(c)
	aux.AddCodeList(c,BOB)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_ATKCHANGE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.bobfilter(c) return c:IsCode(BOB) and c:IsAbleToHand() end
function s.umifilter(c) return c:IsCode(UMI) and c:IsAbleToHand() end
function s.listfilter(c) return aux.IsCodeListed(c,BOB) and c:IsAbleToHand() end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	local pair=Duel.IsExistingMatchingCard(s.bobfilter,tp,LOCATION_DECK,0,1,nil) and Duel.IsExistingMatchingCard(s.umifilter,tp,LOCATION_DECK,0,1,nil)
	local listed=Duel.IsExistingMatchingCard(s.listfilter,tp,LOCATION_DECK,0,1,nil)
	if chk==0 then return pair or listed end
	local chain=Duel.GetCurrentChain()
	local te,player=nil,nil
	if chain>0 then te,player=Duel.GetChainInfo(chain,CHAININFO_TRIGGERING_EFFECT,CHAININFO_TRIGGERING_PLAYER) end
	e:SetLabel(te and player==1-tp and te:IsActiveType(TYPE_MONSTER) and 1 or 0)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.activate(e,tp)
	local pair=Duel.IsExistingMatchingCard(s.bobfilter,tp,LOCATION_DECK,0,1,nil) and Duel.IsExistingMatchingCard(s.umifilter,tp,LOCATION_DECK,0,1,nil)
	local listed=Duel.IsExistingMatchingCard(s.listfilter,tp,LOCATION_DECK,0,1,nil)
	if not pair and not listed then return end
	local op=pair and listed and Duel.SelectOption(tp,aux.Stringid(STRING_ID,1),aux.Stringid(STRING_ID,2)) or (pair and 0 or 1)
	local g=Group.CreateGroup()
	if op==0 then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		local bc=Duel.SelectMatchingCard(tp,s.bobfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
		local uc=Duel.SelectMatchingCard(tp,s.umifilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
		if bc then g:AddCard(bc) end
		if uc then g:AddCard(uc) end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
		g=Duel.SelectMatchingCard(tp,s.listfilter,tp,LOCATION_DECK,0,1,1,nil)
	end
	if #g==0 then return end
	local ct=#g
	if Duel.SendtoHand(g,nil,REASON_EFFECT)~=ct then return end
	Duel.ConfirmCards(1-tp,g)
	if e:GetLabel()==1 then
		local og=Duel.GetMatchingGroup(Card.IsFaceup,tp,0,LOCATION_MZONE,nil)
		for tc in aux.Next(og) do
			local ea=Effect.CreateEffect(e:GetHandler())
			ea:SetType(EFFECT_TYPE_SINGLE)
			ea:SetCode(EFFECT_SET_ATTACK_FINAL)
			ea:SetValue(math.floor(tc:GetAttack()/2))
			ea:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
			tc:RegisterEffect(ea)
			local ed=ea:Clone()
			ed:SetCode(EFFECT_SET_DEFENSE_FINAL)
			ed:SetValue(math.floor(tc:GetDefense()/2))
			tc:RegisterEffect(ed)
		end
	end
end
