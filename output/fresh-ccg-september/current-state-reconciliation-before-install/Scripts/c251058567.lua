--Prophecy of Waterfalls
local s,id=GetID()
local STRING_ID=133058567
local ATTRIBUTE_SEARCH=ATTRIBUTE_WATER
s.search_codes={
	[295517]=true,
	[1154611]=true,
	[1259814]=true,
	[1781310]=true,
	[2084239]=true,
	[2370081]=true,
	[2376209]=true,
	[2819435]=true,
	[6325660]=true,
	[6540606]=true,
	[6890729]=true,
	[7092142]=true,
	[7133305]=true,
	[7142724]=true,
	[7935043]=true,
	[10925955]=true,
	[12174035]=true,
	[14821890]=true,
	[17151328]=true,
	[19089195]=true,
	[21770260]=true,
	[22123627]=true,
	[22748199]=true,
	[22819092]=true,
	[24050692]=true,
	[24903843]=true,
	[26534688]=true,
	[26905245]=true,
	[28653611]=true,
	[29047353]=true,
	[30339825]=true,
	[32056070]=true,
	[32542011]=true,
	[32764863]=true,
	[33900648]=true,
	[34103656]=true,
	[34293667]=true,
	[34898052]=true,
	[35035481]=true,
	[37839434]=true,
	[38761908]=true,
	[43527730]=true,
	[44728989]=true,
	[45898858]=true,
	[45943123]=true,
	[49669730]=true,
	[51562916]=true,
	[53742162]=true,
	[54059040]=true,
	[55226821]=true,
	[57329501]=true,
	[58203736]=true,
	[58270977]=true,
	[58531587]=true,
	[61258740]=true,
	[61411502]=true,
	[61420130]=true,
	[62437430]=true,
	[62487836]=true,
	[63941169]=true,
	[64233143]=true,
	[64765016]=true,
	[65446452]=true,
	[65569724]=true,
	[65785782]=true,
	[68663427]=true,
	[69492187]=true,
	[71541986]=true,
	[72060415]=true,
	[72386290]=true,
	[72776252]=true,
	[78836195]=true,
	[78910579]=true,
	[79402185]=true,
	[80534031]=true,
	[81443745]=true,
	[82263578]=true,
	[82685480]=true,
	[82999629]=true,
	[83723605]=true,
	[88477149]=true,
	[90880453]=true,
	[94384774]=true,
	[95602345]=true,
	[96947648]=true,
	[97045737]=true,
	[98414735]=true,
	[98643358]=true,
	[98804359]=true,
	[99137266]=true,
	[100100047]=true,
	[100100060]=true,
	[101307073]=true,
	[120145050]=true,
	[120186029]=true,
	[120222054]=true,
	[120222055]=true,
	[120253054]=true,
	[120253056]=true,
	[120253064]=true,
	[120290058]=true,
	[120301050]=true,
	[120301054]=true,
	[120304058]=true,
	[120306046]=true,
	[120306063]=true,
	[121191215]=true,
	[121191217]=true,
	[121191243]=true,
	[121191283]=true,
	[121191288]=true,
	[121191293]=true,
	[121191322]=true,
	[121191331]=true,
	[131191291]=true,
	[131191327]=true,
	[131191536]=true,
	[131191537]=true,
	[131191538]=true,
	[131191715]=true,
	[131191726]=true,
	[131191727]=true,
	[131191728]=true,
	[131191729]=true,
	[131191730]=true,
	[131191766]=true,
	[131191767]=true,
	[131191770]=true,
	[131191899]=true,
	[131191923]=true,
	[131192002]=true,
	[131192117]=true,
	[131192126]=true,
	[131192132]=true,
	[131192135]=true,
	[131192157]=true,
	[131192198]=true,
	[131192238]=true,
	[131192276]=true,
	[131192280]=true,
	[131192282]=true,
	[131192283]=true,
	[141191538]=true,
	[141191899]=true,
	[150000870]=true,
	[152000160]=true,
	[152000170]=true,
	[216140411]=true,
	[218905439]=true,
	[221509060]=true,
	[227035644]=true,
	[246830897]=true,
	[248946297]=true,
	[253928485]=true,
	[255082735]=true,
	[256930605]=true,
	[259679619]=true,
	[259998396]=true,
}
function s.initial_effect(c)
	--Return 1 WATER Extra Deck monster; Special Summon this card
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
