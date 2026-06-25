--Fall of Azrynior
local s,id=GetID()
local SET_TO_PROTO=0xe80d
local TOKEN_PROTOGENIC=240299293
local CARD_DYSMANDR=223512283
local RACE_GALAXY=0x80000000
function s.initial_effect(c)
	--Special Summon 1 DARK "Protogenic Essence Token", then Fusion Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOKEN+CATEGORY_FUSION_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.fustg)
	e1:SetOperation(s.fusop)
	c:RegisterEffect(e1)
	--If "Dysmandr, the Depraevity of Worlds" leaves the field because of your opponent's card
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TODECK+CATEGORY_TOHAND)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_LEAVE_FIELD)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.thcon)
	e2:SetCost(s.thcost)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
end
s.listed_names={TOKEN_PROTOGENIC,CARD_DYSMANDR}
function s.dragonmat(c,fc,e)
	return c:IsRace(RACE_DRAGON) and c:IsFusionAttribute(ATTRIBUTE_LIGHT)
		and (c:IsLevel(9) or c:IsRank(9))
		and (not fc or c:IsCanBeFusionMaterial(fc,SUMMON_TYPE_FUSION))
		and (not e or not c:IsImmuneToEffect(e))
end
function s.tokenmat(c,fc,e)
	return c:IsCode(TOKEN_PROTOGENIC)
		and (not fc or c:IsCanBeFusionMaterial(fc,SUMMON_TYPE_FUSION))
		and (not e or not c:IsImmuneToEffect(e))
end
function s.matfilter(c,e,fc)
	return c:IsLocation(LOCATION_HAND+LOCATION_MZONE)
		and (s.dragonmat(c,fc,e) or s.tokenmat(c,fc,e))
end
function s.matcheck(g,fc,tp)
	return #g==2 and g:IsExists(s.dragonmat,1,nil,fc,nil) and g:IsExists(s.tokenmat,1,nil,fc,nil)
		and aux.MustMaterialCheck(g,tp,EFFECT_MUST_BE_FMATERIAL)
		and (not aux.FCheckAdditional or aux.FCheckAdditional(tp,g,fc))
		and (not aux.FGoalCheckAdditional or aux.FGoalCheckAdditional(tp,g,fc))
		and Duel.GetLocationCountFromEx(tp,tp,g,fc)>0
end
function s.fusfilter(c,e,tp,mg)
	return c:IsCode(CARD_DYSMANDR) and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
		and (not mg or mg:CheckSubGroup(s.matcheck,2,2,c,tp))
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_PROTOGENIC,SET_TO_PROTO,TYPES_TOKEN_MONSTER,0,0,1,RACE_GALAXY,ATTRIBUTE_DARK)
		and Duel.IsExistingMatchingCard(s.dragonmat,tp,LOCATION_HAND+LOCATION_MZONE,0,1,nil,nil,e)
		and Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOKEN,nil,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.fusop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	if not Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_PROTOGENIC,SET_TO_PROTO,TYPES_TOKEN_MONSTER,0,0,1,RACE_GALAXY,ATTRIBUTE_DARK) then return end
	local token=Duel.CreateToken(tp,TOKEN_PROTOGENIC)
	if Duel.SpecialSummon(token,0,tp,tp,false,false,POS_FACEUP)==0 then return end
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
	e1:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	e1:SetRange(LOCATION_MZONE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	e1:SetValue(1)
	token:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_CHANGE_ATTRIBUTE)
	e2:SetValue(ATTRIBUTE_DARK)
	token:RegisterEffect(e2)
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e,nil)
	local fg=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg)
	if #fg==0 then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local fc=fg:Select(tp,1,1,nil):GetFirst()
	if not fc then return end
	mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e,fc)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
	local mat=mg:SelectSubGroup(tp,s.matcheck,false,2,2,fc,tp)
	if not mat or #mat~=2 then return end
	fc:SetMaterial(mat)
	Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
	Duel.BreakEffect()
	if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then
		fc:CompleteProcedure()
	end
end
function s.dysfilter(c,tp)
	return c:IsCode(CARD_DYSMANDR) and c:IsPreviousControler(tp)
		and c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousPosition(POS_FACEUP)
		and (c:IsReason(REASON_BATTLE) or (c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp))
end
function s.thcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.dysfilter,1,nil,tp)
end
function s.tdfilter(c)
	return c:IsRace(RACE_DRAGON) and c:IsAttribute(ATTRIBUTE_LIGHT+ATTRIBUTE_DARK)
		and c:IsAbleToDeckAsCost() and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.tdfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectMatchingCard(tp,s.tdfilter,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil)
	Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_COST)
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsAbleToHand() end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,c,1,tp,LOCATION_GRAVE)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.SendtoHand(c,nil,REASON_EFFECT)>0 then
		Duel.ConfirmCards(1-tp,c)
	end
end
