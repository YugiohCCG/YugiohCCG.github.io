--Prophecy of Boulders
local s,id=GetID()
local STRING_ID=133558392
local ATTRIBUTE_SEARCH=ATTRIBUTE_EARTH
s.search_codes={
	[1259814]=true,
	[1607603]=true,
	[1781310]=true,
	[1802450]=true,
	[2507443]=true,
	[3129527]=true,
	[3285551]=true,
	[3734202]=true,
	[4740489]=true,
	[6325660]=true,
	[7206349]=true,
	[8025950]=true,
	[10632284]=true,
	[11050415]=true,
	[13955608]=true,
	[13955628]=true,
	[14108995]=true,
	[14554127]=true,
	[17000165]=true,
	[17228908]=true,
	[18027138]=true,
	[20087414]=true,
	[20447641]=true,
	[21179143]=true,
	[22493811]=true,
	[22866836]=true,
	[23626223]=true,
	[25209168]=true,
	[25274141]=true,
	[27157727]=true,
	[28053763]=true,
	[28062325]=true,
	[28649820]=true,
	[32056070]=true,
	[32360466]=true,
	[33055499]=true,
	[33622465]=true,
	[33676146]=true,
	[33900648]=true,
	[34690953]=true,
	[34898052]=true,
	[35100834]=true,
	[35956022]=true,
	[36148308]=true,
	[37654623]=true,
	[37930737]=true,
	[40366667]=true,
	[40633084]=true,
	[42237854]=true,
	[43140791]=true,
	[43959432]=true,
	[44052074]=true,
	[44459942]=true,
	[51208877]=true,
	[52782439]=true,
	[53545926]=true,
	[55421040]=true,
	[55838342]=true,
	[56051648]=true,
	[56594520]=true,
	[58270977]=true,
	[59820352]=true,
	[60764581]=true,
	[60879050]=true,
	[60883493]=true,
	[61411502]=true,
	[63708033]=true,
	[64213017]=true,
	[70156997]=true,
	[70406920]=true,
	[73915051]=true,
	[74213995]=true,
	[74577599]=true,
	[76136345]=true,
	[82340056]=true,
	[84797028]=true,
	[85888377]=true,
	[87240371]=true,
	[88617904]=true,
	[88667504]=true,
	[89027418]=true,
	[90440725]=true,
	[90880453]=true,
	[92099232]=true,
	[95448372]=true,
	[95561146]=true,
	[96462121]=true,
	[96687733]=true,
	[98374133]=true,
	[98715423]=true,
	[100100009]=true,
	[100100044]=true,
	[100100057]=true,
	[100100063]=true,
	[100100510]=true,
	[100100515]=true,
	[100101002]=true,
	[120109053]=true,
	[120130036]=true,
	[120155046]=true,
	[120155058]=true,
	[120183052]=true,
	[120192027]=true,
	[120199048]=true,
	[120199049]=true,
	[120199062]=true,
	[120208047]=true,
	[120208048]=true,
	[120208060]=true,
	[120235057]=true,
	[120246078]=true,
	[120249047]=true,
	[120249058]=true,
	[120253058]=true,
	[120257058]=true,
	[120261053]=true,
	[120271012]=true,
	[120271013]=true,
	[120271014]=true,
	[120272051]=true,
	[120272052]=true,
	[120272053]=true,
	[120272059]=true,
	[120272061]=true,
	[120285052]=true,
	[120285053]=true,
	[120285054]=true,
	[120285061]=true,
	[120285064]=true,
	[120287011]=true,
	[120290058]=true,
	[120298042]=true,
	[120298043]=true,
	[120300047]=true,
	[120300048]=true,
	[120300050]=true,
	[120300051]=true,
	[120300062]=true,
	[120304048]=true,
	[120304049]=true,
	[120304060]=true,
	[121191283]=true,
	[121191293]=true,
	[121191332]=true,
	[131191285]=true,
	[131191424]=true,
	[131191476]=true,
	[131191598]=true,
	[131191637]=true,
	[131191686]=true,
	[131191687]=true,
	[131191688]=true,
	[131191689]=true,
	[131191690]=true,
	[131191691]=true,
	[131191692]=true,
	[131191718]=true,
	[131191719]=true,
	[131191720]=true,
	[131191722]=true,
	[131191868]=true,
	[131191875]=true,
	[131191885]=true,
	[131191886]=true,
	[131191948]=true,
	[131192009]=true,
	[131192013]=true,
	[131192014]=true,
	[131192015]=true,
	[131192021]=true,
	[131192024]=true,
	[131192066]=true,
	[131192068]=true,
	[131192083]=true,
	[131192087]=true,
	[131192103]=true,
	[131192106]=true,
	[131192117]=true,
	[131192122]=true,
	[131192124]=true,
	[131192126]=true,
	[131192132]=true,
	[131192134]=true,
	[131192160]=true,
	[131192163]=true,
	[131192186]=true,
	[131192189]=true,
	[131192235]=true,
	[131192276]=true,
	[131192289]=true,
	[131192290]=true,
	[141191722]=true,
	[141191886]=true,
	[141192021]=true,
	[152000170]=true,
	[152000190]=true,
}
function s.initial_effect(c)
	--Return 1 EARTH Extra Deck monster; Special Summon this card
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
