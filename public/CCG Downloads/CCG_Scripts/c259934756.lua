--JELLY LASS OF THE GRAND BLUE
local s,id=GetID()
local SET_GRAND_BLUE=0x67ee
local CARD_UMI=22702055
local CARD_CITY_GRAND_BLUE=259679619
local CARD_GRAND_BLUE_PRINCESS=259177849
local CARD_GRAND_BLUE_PRINCE=259937946
function s.initial_effect(c)
	--Special Summon this card from your hand if you control "Umi"
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_HAND)
	e1:SetCountLimit(1,id)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	--Fusion Summon 1 "Grand Blue" Fusion Monster
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_HAND)
	e2:SetCountLimit(1,id+100)
	e2:SetTarget(s.fustg)
	e2:SetOperation(s.fusop)
	c:RegisterEffect(e2)
	--If sent to the GY by card effect: Special Summon 1 other "Grand Blue" monster from your GY
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,2))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY)
	e3:SetCode(EVENT_TO_GRAVE)
	e3:SetCountLimit(1,id+200)
	e3:SetCondition(s.gycon)
	e3:SetTarget(s.gytg)
	e3:SetOperation(s.gyop)
	c:RegisterEffect(e3)
end
function s.umifilter(c)
	return c:IsFaceup() and (c:IsCode(CARD_UMI) or c:IsCode(CARD_CITY_GRAND_BLUE))
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and Duel.IsExistingMatchingCard(s.umifilter,tp,LOCATION_ONFIELD,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
		Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
	end
end
function s.matfilter(c,e)
	return c:IsSetCard(SET_GRAND_BLUE) and c:IsType(TYPE_MONSTER) and c:IsCanBeFusionMaterial()
		and c:IsAbleToGrave() and not c:IsImmuneToEffect(e)
end
function s.princesscheck(g,tp,fc)
	return #g==2 and g:FilterCount(Card.IsSetCard,nil,SET_GRAND_BLUE)==2
		and Duel.GetLocationCountFromEx(tp,tp,g,fc)>0
end
function s.princecheck(g,tp,fc)
	return #g==2 and g:IsExists(Card.IsCode,1,nil,CARD_GRAND_BLUE_PRINCESS)
		and g:IsExists(Card.IsSetCard,1,nil,SET_GRAND_BLUE)
		and Duel.GetLocationCountFromEx(tp,tp,g,fc)>0
end
function s.fusfilter(c,e,tp,mg)
	if not (c:IsType(TYPE_FUSION) and c:IsSetCard(SET_GRAND_BLUE)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)) then return false end
	if c:IsCode(CARD_GRAND_BLUE_PRINCESS) then return mg:CheckSubGroup(s.princesscheck,2,2,tp,c) end
	if c:IsCode(CARD_GRAND_BLUE_PRINCE) then return mg:CheckSubGroup(s.princecheck,2,2,tp,c) end
	return false
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e)
	if chk==0 then return Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.fusop(e,tp,eg,ep,ev,re,r,rp)
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,e)
	local sg=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg)
	if #sg==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local fc=sg:Select(tp,1,1,nil):GetFirst()
	if not fc then return end
	local check=fc:IsCode(CARD_GRAND_BLUE_PRINCESS) and s.princesscheck or s.princecheck
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
	local mat=mg:SelectSubGroup(tp,check,false,2,2,tp,fc)
	if not mat or #mat~=2 then return end
	fc:SetMaterial(mat)
	Duel.HintSelection(mat)
	Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
	Duel.BreakEffect()
	if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then
		fc:CompleteProcedure()
	end
end
function s.gycon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsReason(REASON_EFFECT)
end
function s.gyfilter(c,e,tp,sc)
	return c~=sc and c:IsSetCard(SET_GRAND_BLUE) and c:IsType(TYPE_MONSTER)
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE)
end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local c=e:GetHandler()
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.gyfilter)(chkc,e,tp,c) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingTarget(aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,1,c,e,tp,c) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,1,1,c,e,tp,c)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,1,0,0)
end
function s.gyop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and tc and tc:IsRelateToEffect(e)
		and aux.NecroValleyFilter(s.gyfilter)(tc,e,tp,e:GetHandler()) then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_DEFENSE)
	end
end
