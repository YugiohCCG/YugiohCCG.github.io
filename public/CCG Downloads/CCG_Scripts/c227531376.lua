local s,id=GetID()
local STRING_ID=133531376
local SET_GHOSTRICK=0x8d
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CANNOT_SUMMON)
	e1:SetCondition(s.sumcon)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,0))
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1)
	e2:SetCondition(s.poscon)
	e2:SetTarget(s.postg)
	e2:SetOperation(s.posop)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_FIELD)
	e3:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e3:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e3:SetRange(LOCATION_MZONE)
	e3:SetTargetRange(1,0)
	e3:SetTarget(s.splimit)
	c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_SINGLE)
	e4:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL)
	e4:SetValue(1)
	c:RegisterEffect(e4)
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(STRING_ID,1))
	e5:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DAMAGE)
	e5:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_QUICK_O)
	e5:SetCode(EVENT_CHAINING)
	e5:SetRange(LOCATION_HAND)
	e5:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e5:SetCondition(s.spcon)
	e5:SetTarget(s.sptg)
	e5:SetOperation(s.spop)
	c:RegisterEffect(e5)
end
function s.sumcon(e)
	return not Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) end,e:GetHandlerPlayer(),LOCATION_MZONE,0,1,nil)
end
function s.poscon(e)
	return e:GetHandler():IsFaceup() and e:GetHandler():IsCanTurnSet()
end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return e:GetHandler():IsCanTurnSet() end
end
function s.posop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and c:IsFaceup() then Duel.ChangePosition(c,POS_FACEDOWN_DEFENSE) end
end
function s.splimit(e,c)
	return not c:IsSetCard(SET_GHOSTRICK)
end
function s.edmonster(c)
	return (c:GetOriginalType()&(TYPE_FUSION+TYPE_SYNCHRO+TYPE_XYZ+TYPE_LINK))~=0
end
function s.xyzfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) and c:IsType(TYPE_XYZ)
end
function s.rcfilter(c,e)
	return c:IsCanBeEffectTarget(e) and c:IsCanOverlay()
		and (not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter(Card.IsCanOverlay)(c))
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	return rp==1-tp and re:IsActiveType(TYPE_MONSTER) and rc and s.edmonster(rc)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	local c=e:GetHandler()
	local rc=re:GetHandler()
	if chkc then return chkc==rc and s.rcfilter(chkc,e)
		or chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.xyzfilter(chkc) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE)
		and s.rcfilter(rc,e)
		and Duel.IsExistingTarget(s.xyzfilter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local xc=Duel.SelectTarget(tp,s.xyzfilter,tp,LOCATION_MZONE,0,1,1,nil):GetFirst()
	Duel.SetTargetCard(Group.FromCards(rc,xc))
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_HAND)
	Duel.SetOperationInfo(0,CATEGORY_DAMAGE,nil,0,tp,0)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
		or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)==0 then return end
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
	local rc=re:GetHandler()
	local xc=g:Filter(s.xyzfilter,nil):GetFirst()
	if not rc or not xc or rc==xc or not rc:IsRelateToEffect(e) or not xc:IsRelateToEffect(e)
		or rc:IsImmuneToEffect(e) or not s.rcfilter(rc,e) then return end
	local dam=math.abs(math.max(0,rc:GetTextAttack())-math.max(0,xc:GetTextAttack()))
	local og=rc:GetOverlayGroup()
	if #og>0 then Duel.SendtoGrave(og,REASON_RULE) end
	Duel.Overlay(xc,rc)
	if rc:IsLocation(LOCATION_OVERLAY) and dam>0 then Duel.Damage(tp,dam,REASON_EFFECT) end
end
