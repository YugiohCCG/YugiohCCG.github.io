--OTAKEMARU THE ACCUSER
local s,id=GetID()
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddSynchroProcedure(c,s.tunerfilter,aux.NonTuner(nil),1)
	--Other Spirit monsters cannot return to the hand or Extra Deck by card effect during the End Phase
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetOperation(s.retop)
	c:RegisterEffect(e1)
	--Your opponent cannot target Spirit monsters you control with card effects
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e2:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
	e2:SetRange(LOCATION_MZONE)
	e2:SetTargetRange(LOCATION_MZONE,0)
	e2:SetTarget(s.tgtg)
	e2:SetValue(aux.tgoval)
	c:RegisterEffect(e2)
	--If a Spirit monster is Normal Summoned: return 1 opponent's card to the hand
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetCategory(CATEGORY_TOHAND)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_SUMMON_SUCCESS)
	e3:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCondition(s.bcon)
	e3:SetTarget(s.btg)
	e3:SetOperation(s.bop)
	c:RegisterEffect(e3)
	--During the End Phase, return this card to the Extra Deck, then Special Summon Spirit monsters
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,2))
	e4:SetCategory(CATEGORY_TOEXTRA+CATEGORY_SPECIAL_SUMMON)
	e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F)
	e4:SetCode(EVENT_PHASE+PHASE_END)
	e4:SetRange(LOCATION_MZONE)
	e4:SetCondition(s.spcon)
	e4:SetTarget(s.sptg)
	e4:SetOperation(s.spop)
	c:RegisterEffect(e4)
end
function s.tunerfilter(c,scard,sumtype,tp)
	return c:IsType(TYPE_TUNER) and c:IsType(TYPE_SPIRIT)
end
function s.rettg(e,c)
	return c~=e:GetLabelObject() and c:IsFaceup() and c:IsType(TYPE_SPIRIT)
end
function s.retdecktg(e,c)
	return s.rettg(e,c) and c:IsType(TYPE_FUSION+TYPE_SYNCHRO+TYPE_XYZ+TYPE_LINK)
end
function s.retcon(e)
	return Duel.GetCurrentPhase()==PHASE_END
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_CANNOT_TO_HAND)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.rettg)
	e1:SetLabelObject(c)
	e1:SetCondition(s.retcon)
	e1:SetValue(1)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_CANNOT_TO_DECK)
	e2:SetTarget(s.retdecktg)
	Duel.RegisterEffect(e2,tp)
end
function s.tgtg(e,c)
	return c:IsFaceup() and c:IsType(TYPE_SPIRIT)
end
function s.nsfilter(c)
	return c:IsType(TYPE_SPIRIT) and c:IsSummonType(SUMMON_TYPE_NORMAL)
end
function s.bcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.nsfilter,1,nil)
end
function s.btg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(1-tp) and chkc:IsOnField() and chkc:IsAbleToHand() end
	if chk==0 then return Duel.IsExistingTarget(Card.IsAbleToHand,tp,0,LOCATION_ONFIELD,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND)
	local g=Duel.SelectTarget(tp,Card.IsAbleToHand,tp,0,LOCATION_ONFIELD,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
end
function s.bop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) and tc:IsAbleToHand() then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
	end
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsStatus(STATUS_SPSUMMON_TURN)
end
function s.spfilter(c,e,tp)
	return c:IsType(TYPE_SPIRIT) and c:IsType(TYPE_MONSTER)
		and c:IsCanBeSpecialSummoned(e,0,tp,true,true)
end
function s.spcheck(g)
	if #g~=2 then return false end
	local tc1=g:GetFirst()
	local tc2=g:GetNext()
	return tc1 and tc2 and tc1:GetLevel()+tc2:GetLevel()==9
		and g:IsExists(Card.IsType,1,nil,TYPE_TUNER)
		and g:IsExists(aux.NOT(Card.IsType),1,nil,TYPE_TUNER)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,nil,e,tp)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_TOEXTRA,c,1,0,0)
	if Duel.GetMZoneCount(tp,c)>1 and not Duel.IsPlayerAffectedByEffect(tp,59822133)
		and g:CheckSubGroup(s.spcheck,2,2) then
		Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,tp,LOCATION_GRAVE)
	end
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and c:IsAbleToExtra()) then return end
	if Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==0 or not c:IsLocation(LOCATION_EXTRA) then return end
	local ft=Duel.GetLocationCount(tp,LOCATION_MZONE)
	if ft<2 or Duel.IsPlayerAffectedByEffect(tp,59822133) then return end
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_GRAVE,0,nil,e,tp)
	if not g:CheckSubGroup(s.spcheck,2,2) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sg=g:SelectSubGroup(tp,s.spcheck,false,2,2)
	if sg and #sg==2 then
		Duel.SpecialSummon(sg,0,tp,tp,true,true,POS_FACEUP)
	end
end
