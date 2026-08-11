--Prophecy of Storms
local s,id=GetID()
local STRING_ID=133592011
local ATTRIBUTE_SEARCH=ATTRIBUTE_WIND
s.search_codes={
	[904185]=true,
	[1187243]=true,
	[1259814]=true,
	[1781310]=true,
	[2572890]=true,
	[4215636]=true,
	[6325660]=true,
	[7917970]=true,
	[9553721]=true,
	[13972452]=true,
	[14005031]=true,
	[15306543]=true,
	[15854426]=true,
	[24920410]=true,
	[27980138]=true,
	[29999161]=true,
	[32056070]=true,
	[33900648]=true,
	[34898052]=true,
	[36183881]=true,
	[37301660]=true,
	[39275698]=true,
	[40366667]=true,
	[42425831]=true,
	[42548470]=true,
	[44221928]=true,
	[45778932]=true,
	[49366157]=true,
	[51250293]=true,
	[53813120]=true,
	[54880296]=true,
	[55321970]=true,
	[58270977]=true,
	[58543073]=true,
	[60176682]=true,
	[61011311]=true,
	[61411502]=true,
	[65664792]=true,
	[66002986]=true,
	[67441879]=true,
	[68831625]=true,
	[69320362]=true,
	[70875955]=true,
	[71459861]=true,
	[75622824]=true,
	[76473843]=true,
	[79333300]=true,
	[82255872]=true,
	[82263578]=true,
	[83319610]=true,
	[85704698]=true,
	[87639778]=true,
	[90880453]=true,
	[91422370]=true,
	[92223430]=true,
	[95561280]=true,
	[95714077]=true,
	[96156729]=true,
	[120120039]=true,
	[120151036]=true,
	[120151037]=true,
	[120151038]=true,
	[120155045]=true,
	[120183043]=true,
	[120183044]=true,
	[120183045]=true,
	[120183061]=true,
	[120228052]=true,
	[120228055]=true,
	[120228056]=true,
	[120228057]=true,
	[120247013]=true,
	[120247033]=true,
	[120247034]=true,
	[120247035]=true,
	[120247037]=true,
	[120249056]=true,
	[120253051]=true,
	[120264052]=true,
	[120277064]=true,
	[120279035]=true,
	[120290043]=true,
	[120290045]=true,
	[120290046]=true,
	[120290058]=true,
	[120290059]=true,
	[120298013]=true,
	[120298016]=true,
	[120301062]=true,
	[120301064]=true,
	[121191283]=true,
	[121191288]=true,
	[121191293]=true,
	[121191369]=true,
	[131191292]=true,
	[131191575]=true,
	[131191814]=true,
	[131191827]=true,
	[131191837]=true,
	[131191902]=true,
	[131191915]=true,
	[131191924]=true,
	[131191969]=true,
	[131191971]=true,
	[131191972]=true,
	[131191973]=true,
	[131192044]=true,
	[131192047]=true,
	[131192048]=true,
	[131192052]=true,
	[131192053]=true,
	[131192054]=true,
	[131192083]=true,
	[131192115]=true,
	[131192117]=true,
	[131192126]=true,
	[131192132]=true,
	[131192141]=true,
	[131192193]=true,
	[131192210]=true,
	[131192211]=true,
	[131192215]=true,
	[131192218]=true,
	[141191575]=true,
	[141191827]=true,
	[141191902]=true,
	[141191924]=true,
	[152000180]=true,
	[152000190]=true,
	[238064522]=true,
	[256110263]=true,
}
function s.initial_effect(c)
	--Return 1 WIND Extra Deck monster; Special Summon this card
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
