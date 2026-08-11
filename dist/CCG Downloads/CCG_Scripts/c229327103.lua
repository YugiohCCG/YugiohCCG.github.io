--Prophecy of Infernos
local s,id=GetID()
local STRING_ID=133327103
local ATTRIBUTE_SEARCH=ATTRIBUTE_FIRE
s.search_codes={
	[1259814]=true,
	[1781310]=true,
	[5439384]=true,
	[6325660]=true,
	[6713443]=true,
	[9102835]=true,
	[11501629]=true,
	[11654067]=true,
	[15590355]=true,
	[17151328]=true,
	[18937875]=true,
	[19027895]=true,
	[19384334]=true,
	[22993208]=true,
	[25388971]=true,
	[25800447]=true,
	[25807544]=true,
	[27979109]=true,
	[28653611]=true,
	[29143457]=true,
	[30336082]=true,
	[32056070]=true,
	[32268901]=true,
	[32542011]=true,
	[33872334]=true,
	[33900648]=true,
	[34822850]=true,
	[34898052]=true,
	[35697544]=true,
	[37478723]=true,
	[38784726]=true,
	[38798785]=true,
	[42516299]=true,
	[42945701]=true,
	[43664494]=true,
	[45133463]=true,
	[46898368]=true,
	[47658964]=true,
	[50179591]=true,
	[52971944]=true,
	[53639887]=true,
	[55484152]=true,
	[55538156]=true,
	[55749927]=true,
	[57103969]=true,
	[57554544]=true,
	[58270977]=true,
	[58809685]=true,
	[59388357]=true,
	[60433216]=true,
	[60718396]=true,
	[60883493]=true,
	[61411502]=true,
	[62091148]=true,
	[65305978]=true,
	[66730191]=true,
	[66750703]=true,
	[66947913]=true,
	[68815401]=true,
	[68957034]=true,
	[73714736]=true,
	[74055055]=true,
	[74845897]=true,
	[80044027]=true,
	[80758812]=true,
	[82705573]=true,
	[83533296]=true,
	[86690572]=true,
	[89023486]=true,
	[90861137]=true,
	[90880453]=true,
	[91703676]=true,
	[92092092]=true,
	[92345028]=true,
	[93754402]=true,
	[97045737]=true,
	[98319530]=true,
	[98596596]=true,
	[100100062]=true,
	[120100001]=true,
	[120183048]=true,
	[120183049]=true,
	[120183050]=true,
	[120199047]=true,
	[120199060]=true,
	[120199061]=true,
	[120201003]=true,
	[120205045]=true,
	[120205049]=true,
	[120231017]=true,
	[120235051]=true,
	[120249048]=true,
	[120253058]=true,
	[120261055]=true,
	[120261061]=true,
	[120272049]=true,
	[120272057]=true,
	[120274028]=true,
	[120274030]=true,
	[120290058]=true,
	[120298028]=true,
	[120298029]=true,
	[120298030]=true,
	[120300053]=true,
	[120305037]=true,
	[120305039]=true,
	[121191283]=true,
	[121191288]=true,
	[121191293]=true,
	[131191286]=true,
	[131191472]=true,
	[131191508]=true,
	[131191540]=true,
	[131191544]=true,
	[131191545]=true,
	[131191546]=true,
	[131191778]=true,
	[131191779]=true,
	[131191780]=true,
	[131191781]=true,
	[131191782]=true,
	[131191795]=true,
	[131191815]=true,
	[131191836]=true,
	[131191871]=true,
	[131191878]=true,
	[131191881]=true,
	[131191923]=true,
	[131191934]=true,
	[131191941]=true,
	[131191949]=true,
	[131191987]=true,
	[131191989]=true,
	[131192084]=true,
	[131192088]=true,
	[131192117]=true,
	[131192121]=true,
	[131192126]=true,
	[131192127]=true,
	[131192128]=true,
	[131192129]=true,
	[131192132]=true,
	[131192138]=true,
	[131192188]=true,
	[131192189]=true,
	[131192190]=true,
	[131192204]=true,
	[131192223]=true,
	[131192226]=true,
	[131192276]=true,
	[141191836]=true,
	[141191871]=true,
	[141191881]=true,
	[141191949]=true,
	[141192129]=true,
	[152000160]=true,
	[152000180]=true,
	[219714894]=true,
	[236815197]=true,
	[257239133]=true,
}
function s.initial_effect(c)
	--Return 1 FIRE Extra Deck monster; Special Summon this card
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND+CATEGORY_SEARCH)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
end
function s.rtfilter(c,e,tp)
	return c:IsFaceup() and c:IsAttribute(ATTRIBUTE_SEARCH) and c:IsSummonLocation(LOCATION_EXTRA)
		and c:IsAbleToExtra() and c:IsCanBeEffectTarget(e) and Duel.GetMZoneCount(tp,c)>0
end
function s.thfilter(c)
	if not (c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToHand()) then return false end
	local codes={c:GetCode()}
	for _,code in ipairs(codes) do
		if s.search_codes[code] then return true end
	end
	return false
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local c=e:GetHandler()
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.rtfilter(chkc,e,tp) end
	if chk==0 then return c:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and Duel.IsExistingTarget(s.rtfilter,tp,LOCATION_MZONE,0,1,nil,e,tp)
		and Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,s.rtfilter,tp,LOCATION_MZONE,0,1,1,nil,e,tp)
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and s.rtfilter(tc,e,tp)) then return end
	if Duel.SendtoDeck(tc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==0 or not tc:IsLocation(LOCATION_EXTRA) then return end
	if not (c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0) then return end
	if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
	if not Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then
		Duel.ConfirmCards(1-tp,g)
	end
end
