local s,id=GetID()
local SET_FLOO=0x16d
function s.initial_effect(c)
	local e=Effect.CreateEffect(c)
	e:SetType(EFFECT_TYPE_ACTIVATE)
	e:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_SUMMON_PROC)
	e2:SetRange(LOCATION_SZONE)
	e2:SetTargetRange(LOCATION_HAND,0)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.sumcon)
	e2:SetOperation(s.sumop)
	e2:SetValue(SUMMON_TYPE_ADVANCE)
	c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_POSITION)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e3:SetCode(EVENT_SUMMON_SUCCESS)
	e3:SetRange(LOCATION_SZONE)
	e3:SetCountLimit(1,id+100)
	e3:SetCondition(s.poscon)
	e3:SetTarget(s.postg)
	e3:SetOperation(s.posop)
	c:RegisterEffect(e3)
end
function s.matfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsAbleToRemoveAsCost()
end
function s.fieldmat(c,tp)
	return s.matfilter(c) and Duel.GetMZoneCount(tp,c)>0
end
function s.deckmat(c)
	return c:IsSetCard(SET_FLOO) and s.matfilter(c)
end
function s.sumcon(e,c,minc)
	if c==nil then return true end
	local tp=c:GetControler()
	local min,max=c:GetTributeRequirement()
	return minc<=2 and min>=1 and min<=2 and max>=1 and c:IsSetCard(SET_FLOO)
		and Duel.IsExistingMatchingCard(s.fieldmat,tp,LOCATION_HAND+LOCATION_MZONE,0,1,c,tp)
		and Duel.IsExistingMatchingCard(s.deckmat,tp,LOCATION_DECK,0,1,nil)
end
function s.sumop(e,tp,eg,ep,ev,re,r,rp,c)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,s.fieldmat,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,c,tp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	g:Merge(Duel.SelectMatchingCard(tp,s.deckmat,tp,LOCATION_DECK,0,1,1,nil))
	c:SetMaterial(nil)
	Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.advanced(c,tp)
	return c:IsSummonPlayer(tp) and c:IsSummonType(SUMMON_TYPE_ADVANCE)
		and c:IsRace(RACE_WINDBEAST) and c:IsLevelAbove(7)
end
function s.poscon(e,tp,eg)
	return Duel.IsMainPhase() and eg:IsExists(s.advanced,1,nil,tp)
end
function s.posfilter(c)
	return c:IsDefensePos() and c:IsCanChangePosition()
end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_MZONE) and s.posfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.posfilter,tp,0,LOCATION_MZONE,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE)
	Duel.SelectTarget(tp,s.posfilter,tp,0,LOCATION_MZONE,1,1,nil)
end
function s.posop(e,tp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and tc:IsDefensePos() then Duel.ChangePosition(tc,POS_FACEUP_ATTACK) end
end
