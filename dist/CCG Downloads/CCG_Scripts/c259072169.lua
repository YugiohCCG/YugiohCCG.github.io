--Mirage Formation Dragon
local s,id=GetID()
local STRING_ID=133072169
local SET_HARPIE=0x64
local SET_HARPIE_CUSTOM=0x079c
local CARD_HARPIE_LADY=76812113
local CARD_HARPIE_LADY_SISTERS=12206212
local CARD_ELEGANT_EGOTIST=90219263
local HARP_CODE_LIST={CARD_HARPIE_LADY,CARD_HARPIE_LADY_SISTERS,91932350,27927359,54415063,80316585,259794136,id}
function s.initial_effect(c)
	aux.AddCodeList(c,CARD_HARPIE_LADY,CARD_HARPIE_LADY_SISTERS,CARD_ELEGANT_EGOTIST)
	--Xyz Summon
	aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsAttribute,ATTRIBUTE_WIND),7,2)
	c:EnableReviveLimit()
	--This card's name is treated as "Harpie Lady Sisters"
	aux.EnableChangeCode(c,CARD_HARPIE_LADY_SISTERS,LOCATION_MZONE+LOCATION_GRAVE)
	--Reveal this card and "Elegant Egotist"; Special Summon this card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_EXTRA)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.igncon)
	e1:SetCost(s.excost)
	e1:SetTarget(s.extg)
	e1:SetOperation(s.exop)
	c:RegisterEffect(e1)
	--Quick Effect if your opponent controls a monster
	local e2=e1:Clone()
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_FREE_CHAIN)
	e2:SetHintTiming(0,TIMING_MAIN_END)
	e2:SetCondition(s.qcon)
	c:RegisterEffect(e2)
	--If Special Summoned from the Extra Deck: Set Spells/Traps
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_SSET)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.setcon)
	e3:SetTarget(s.settg)
	e3:SetOperation(s.setop)
	c:RegisterEffect(e3)
	--If your opponent Special Summons by card effect
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,2))
	e4:SetCategory(CATEGORY_TOHAND+CATEGORY_DESTROY)
	e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e4:SetCode(EVENT_SPSUMMON_SUCCESS)
	e4:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e4:SetRange(LOCATION_MZONE)
	e4:SetCountLimit(1,id+200)
	e4:SetCondition(s.bcon)
	e4:SetCost(s.bcost)
	e4:SetTarget(s.btg)
	e4:SetOperation(s.bop)
	c:RegisterEffect(e4)
end
function s.igncon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetFieldGroupCount(tp,0,LOCATION_MZONE)==0
end
function s.qcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetFieldGroupCount(tp,0,LOCATION_MZONE)>0
end
function s.egfilter(c)
	return c:IsCode(CARD_ELEGANT_EGOTIST) and c:IsCanOverlay()
end
function s.excost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return not c:IsPublic()
		and Duel.IsExistingMatchingCard(s.egfilter,tp,LOCATION_HAND,0,1,nil) end
	Duel.ConfirmCards(1-tp,c)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local g=Duel.SelectMatchingCard(tp,s.egfilter,tp,LOCATION_HAND,0,1,1,nil)
	local ec=g:GetFirst()
	Duel.ConfirmCards(1-tp,g)
	Duel.ShuffleHand(tp)
	ec:CreateEffectRelation(e)
	e:SetLabelObject(ec)
end
function s.extg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCountFromEx(tp,tp,nil,c)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,true,false)
		and Duel.IsExistingMatchingCard(s.egfilter,tp,LOCATION_HAND,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_EXTRA)
end
function s.exop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if Duel.GetLocationCountFromEx(tp,tp,nil,c)<=0 or not c:IsRelateToEffect(e) then return end
	local ec=e:GetLabelObject()
	if not (ec and ec:IsRelateToEffect(e) and ec:IsLocation(LOCATION_HAND) and s.egfilter(ec)) then return end
	if Duel.SpecialSummon(c,0,tp,tp,true,false,POS_FACEUP)>0 then
		c:CompleteProcedure()
		Duel.Overlay(c,Group.FromCards(ec))
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_FIELD)
		e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
		e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
		e1:SetTargetRange(1,0)
		e1:SetTarget(s.splimit)
		e1:SetReset(RESET_PHASE+PHASE_END,2)
		Duel.RegisterEffect(e1,tp)
	end
end
function s.splimit(e,c)
	return not (c:IsAttribute(ATTRIBUTE_WIND) and (c:IsRace(RACE_WINDBEAST) or c:IsRace(RACE_DRAGON)))
end
function s.setcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonLocation(LOCATION_EXTRA)
end
function s.isharpielady(c)
	return c:IsCode(table.unpack(HARP_CODE_LIST))
end
function s.harplady(c)
	return c:IsFaceup() and c:IsType(TYPE_MONSTER) and s.isharpielady(c)
end
function s.setfilter(c)
	return c:IsType(TYPE_SPELL+TYPE_TRAP) and aux.IsCodeListed(c,CARD_HARPIE_LADY) and c:IsSSetable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
	local ct=math.min(Duel.GetMatchingGroupCount(s.harplady,tp,LOCATION_MZONE,0,nil),Duel.GetLocationCount(tp,LOCATION_SZONE))
	local g=Duel.GetMatchingGroup(s.setfilter,tp,LOCATION_DECK,0,nil)
	if chk==0 then return ct>0 and g:CheckSubGroup(aux.dncheck,1,ct) end
	Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_DECK)
end
function s.setop(e,tp,eg,ep,ev,re,r,rp)
	local ct=math.min(Duel.GetMatchingGroupCount(s.harplady,tp,LOCATION_MZONE,0,nil),Duel.GetLocationCount(tp,LOCATION_SZONE))
	if ct<=0 then return end
	local g=Duel.GetMatchingGroup(s.setfilter,tp,LOCATION_DECK,0,nil)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
	local sg=g:SelectSubGroup(tp,aux.dncheck,false,1,ct)
	if sg and #sg>0 then
		Duel.SSet(tp,sg)
	end
end
function s.oppfilter(c,tp)
	return c:IsSummonPlayer(1-tp)
end
function s.bcon(e,tp,eg,ep,ev,re,r,rp)
	return bit.band(r,REASON_EFFECT)~=0 and eg:IsExists(s.oppfilter,1,nil,tp)
end
function s.bcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:CheckRemoveOverlayCard(tp,1,REASON_COST) end
	c:RemoveOverlayCard(tp,1,1,REASON_COST)
end
function s.myfilter(c,e)
	return c:IsOnField() and c:IsCanBeEffectTarget(e) and (c:IsAbleToHand() or c:IsDestructable())
end
function s.oppcardfilter(c,e,tc)
	return c:IsFaceup() and c:IsCanBeEffectTarget(e)
		and ((tc:IsAbleToHand() and c:IsAbleToHand()) or (tc:IsDestructable() and c:IsDestructable()))
end
function s.pairfilter(c,e,tp)
	return s.myfilter(c,e) and Duel.IsExistingTarget(s.oppcardfilter,tp,0,LOCATION_ONFIELD,1,nil,e,c)
end
function s.btg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then
		if chkc:IsControler(tp) then return chkc:IsOnField() and s.pairfilter(chkc,e,tp) end
		return false
	end
	if chk==0 then return Duel.IsExistingTarget(s.pairfilter,tp,LOCATION_ONFIELD,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g1=Duel.SelectTarget(tp,s.pairfilter,tp,LOCATION_ONFIELD,0,1,1,nil,e,tp)
	local tc=g1:GetFirst()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g2=Duel.SelectTarget(tp,s.oppcardfilter,tp,0,LOCATION_ONFIELD,1,1,nil,e,tc)
	g1:Merge(g2)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g1,2,0,0)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g1,2,0,0)
end
function s.bop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
	if not g or #g<2 then return end
	local tc1=g:Filter(Card.IsControler,nil,tp):GetFirst()
	local tc2=g:Filter(Card.IsControler,nil,1-tp):GetFirst()
	if not (tc1 and tc1:IsRelateToEffect(e) and tc1:IsControler(tp) and tc1:IsOnField()
		and (tc1:IsAbleToHand() or tc1:IsDestructable())
		and tc2 and tc2:IsRelateToEffect(e) and tc2:IsControler(1-tp)
		and tc2:IsOnField() and tc2:IsFaceup()
		and (tc2:IsAbleToHand() or tc2:IsDestructable())) then return end
	local b1=tc1:IsAbleToHand() and tc2:IsAbleToHand()
	local b2=tc1:IsDestructable() and tc2:IsDestructable()
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,3),aux.Stringid(STRING_ID,4))
	elseif b2 then
		op=1
	end
	local rg=Group.FromCards(tc1,tc2)
	if op==0 then
		Duel.SendtoHand(rg,nil,REASON_EFFECT)
	else
		Duel.Destroy(rg,REASON_EFFECT)
	end
end
