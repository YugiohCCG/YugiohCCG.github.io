-- Gravinity Nebulix
local s,id=GetID()
local STRING_ID=132429024
local SET_GRAVINITY=0x760

function s.initial_effect(c)
	-- Synchro Summon: 1 "Gravinity" Tuner + 1+ Cyberse Synchro Monsters
	aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsSetCard,SET_GRAVINITY),aux.NonTuner(s.ntfilter),1)
	c:EnableReviveLimit()

	-- Synchro Summon cannot be negated
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_CANNOT_DISABLE_SPSUMMON)
	e0:SetCondition(s.sumcon)
	c:RegisterEffect(e0)

	-- Shuffle up to 3 Gravinity cards from field/GY, then draw 1
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetCode(EVENT_SPSUMMON_SUCCESS)
	e1:SetProperty(EFFECT_FLAG_DELAY)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.tdcon)
	e1:SetTarget(s.tdtg)
	e1:SetOperation(s.tdop)
	c:RegisterEffect(e1)

	-- Additional effect at resolution of Gravinity Spell/Trap
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e2:SetCode(EVENT_CHAIN_SOLVED)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCondition(s.addcon)
	e2:SetOperation(s.addop)
	c:RegisterEffect(e2)
end

function s.ntfilter(c)
	return c:IsRace(RACE_CYBERSE) and c:IsType(TYPE_SYNCHRO)
end
function s.sumcon(e)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_SYNCHRO)
end

function s.tdcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsSummonType(SUMMON_TYPE_SYNCHRO) or (c:IsPreviousLocation(LOCATION_SZONE) and c:GetPreviousControler()==tp)
end
function s.tdfilter(c)
	return c:IsSetCard(SET_GRAVINITY) and c:IsAbleToDeck()
end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanDraw(tp,1)
		and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_ONFIELD+LOCATION_GRAVE,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,1,tp,LOCATION_ONFIELD+LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1)
end
function s.tdop(e,tp)
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.tdfilter),tp,LOCATION_ONFIELD+LOCATION_GRAVE,0,nil)
	if #g==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local sg=g:Select(tp,1,math.min(3,#g),nil)
	Duel.HintSelection(sg)
	if Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 then
		local og=Duel.GetOperatedGroup()
		if og:IsExists(Card.IsLocation,1,nil,LOCATION_DECK+LOCATION_EXTRA) then
			Duel.BreakEffect()
			Duel.Draw(tp,1,REASON_EFFECT)
		end
	end
end

function s.addcon(e,tp,eg,ep,ev,re)
	local rc=re:GetHandler()
	return rc:IsSetCard(SET_GRAVINITY) and re:IsActiveType(TYPE_SPELL+TYPE_TRAP)
end
function s.addfilter(c,e,tp)
	if not (c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_MONSTER)) then return false end
	local b1=Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
	local b2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not c:IsForbidden()
	return b1 or b2
end
function s.trapify(c,hc)
	local e1=Effect.CreateEffect(hc)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_CHANGE_TYPE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetValue(TYPE_TRAP+TYPE_CONTINUOUS)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET)
	c:RegisterEffect(e1)
end
function s.addop(e,tp)
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.addfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,nil,e,tp)
	if #g==0 or not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,1)) then return end
	Duel.Hint(HINT_CARD,0,id)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local tc=g:Select(tp,1,1,nil):GetFirst()
	if not tc then return end
	local b1=Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
	local b2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not tc:IsForbidden()
	if not b1 and not b2 then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3))
	elseif b2 then
		op=1
	end
	if op==0 then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	elseif Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then
		s.trapify(tc,e:GetHandler())
	end
end
