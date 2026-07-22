local s,id=GetID()
local STRING_ID=133128790
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_REMOVE)
	e1:SetRange(LOCATION_HAND)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.spcon)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetRange(LOCATION_MZONE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCountLimit(1,id+100)
	e2:SetCondition(s.syncon)
	e2:SetTarget(s.syntg)
	e2:SetOperation(s.synop)
	c:RegisterEffect(e2)
end
function s.rmfilter(c,tp) return c:IsPreviousControler(tp) end
function s.spcon(e,tp,eg) return eg:IsExists(s.rmfilter,1,nil,tp) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_HAND)
end
function s.spop(e,tp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end
end
function s.fromrm(c,tp) return c:IsSummonPlayer(tp) and c:IsPreviousLocation(LOCATION_REMOVED) end
function s.syncon(e,tp,eg) return eg:IsExists(s.fromrm,1,nil,tp) end
function s.nontunercheck(sc,mc)
	local te=Effect.CreateEffect(mc)
	te:SetType(EFFECT_TYPE_SINGLE)
	te:SetCode(EFFECT_NONTUNER)
	te:SetValue(1)
	mc:RegisterEffect(te)
	local res=sc:IsSynchroSummonable(nil)
	te:Reset()
	return res
end
function s.synfilter(c,mc)
	return c:IsType(TYPE_SYNCHRO) and (c:IsSynchroSummonable(nil) or s.nontunercheck(c,mc))
end
function s.syntg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.IsExistingMatchingCard(s.synfilter,tp,LOCATION_EXTRA,0,1,nil,c) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local sc=Duel.SelectMatchingCard(tp,s.synfilter,tp,LOCATION_EXTRA,0,1,1,nil,c):GetFirst()
	e:SetLabelObject(sc)
	Duel.ConfirmCards(1-tp,sc)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.synop(e,tp)
	local c=e:GetHandler()
	local sc=e:GetLabelObject()
	if not sc or not sc:IsLocation(LOCATION_EXTRA) then return end
	local nt=Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2))
	local te=nil
	if nt then
		te=Effect.CreateEffect(c)
		te:SetType(EFFECT_TYPE_SINGLE)
		te:SetCode(EFFECT_NONTUNER)
		te:SetValue(1)
		te:SetReset(RESET_CHAIN)
		c:RegisterEffect(te)
	end
	if sc:IsSynchroSummonable(nil) then Duel.SynchroSummon(tp,sc,nil) end
end
