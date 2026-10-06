-- Gravinity Axis Matter
local s,id=GetID()
local STRING_ID=132831125
local SET_GRAVINITY=0x760
local CARD_NEBULIX=212429024
local CARD_SPHERIX=231088629
local NEBULIX_STRING_ID=132429024
local SPHERIX_STRING_ID=133088629
local COUNTER_GRAVITY=0x1290

function s.initial_effect(c)
	c:EnableCounterPermit(COUNTER_GRAVITY)

	-- Activate
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)

	-- Opponent cannot target Gravinity Synchro Monster Cards with card effects
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e1:SetRange(LOCATION_FZONE)
	e1:SetTargetRange(LOCATION_ONFIELD+LOCATION_GRAVE+LOCATION_REMOVED,0)
	e1:SetTarget(s.prottg)
	e1:SetValue(aux.tgoval)
	c:RegisterEffect(e1)

	-- Reduce Level of opponent's monsters in same column as a Gravinity monster by 1
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetCode(EFFECT_UPDATE_LEVEL)
	e2:SetRange(LOCATION_FZONE)
	e2:SetTargetRange(0,LOCATION_MZONE)
	e2:SetTarget(s.coltg)
	e2:SetValue(-1)
	c:RegisterEffect(e2)

	-- Reduce Rank by 1
	local e3=e2:Clone()
	e3:SetCode(EFFECT_UPDATE_RANK)
	c:RegisterEffect(e3)

	-- Standby Phase: Reveal 1 Level 11 Gravinity Synchro Monster; gain non-activated effects
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(STRING_ID,0))
	e5:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e5:SetCode(EVENT_PHASE+PHASE_STANDBY)
	e5:SetRange(LOCATION_FZONE)
	e5:SetCountLimit(1,id)
	e5:SetCost(s.copycost)
	e5:SetTarget(s.copytg)
	e5:SetOperation(s.copyop)
	c:RegisterEffect(e5)
end

function s.prottg(e,c)
	return c:IsSetCard(SET_GRAVINITY) and (c:GetOriginalType()&TYPE_SYNCHRO)~=0
end

function s.colfilter(c,oc)
	return c:IsFaceup() and c:IsSetCard(SET_GRAVINITY) and (c:GetOriginalType()&TYPE_MONSTER)~=0 and oc:GetColumnGroup():IsContains(c)
end
function s.coltg(e,c)
	return Duel.IsExistingMatchingCard(s.colfilter,e:GetHandlerPlayer(),LOCATION_ONFIELD,0,1,nil,c)
end

function s.copyfilter(c)
	return c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_SYNCHRO) and c:IsLevel(11)
end
function s.copycost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.copyfilter,tp,LOCATION_EXTRA,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local tc=Duel.SelectMatchingCard(tp,s.copyfilter,tp,LOCATION_EXTRA,0,1,1,nil):GetFirst()
	Duel.ConfirmCards(1-tp,tc)
	e:SetLabel(tc:GetOriginalCode())
end
function s.copytg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
end
function s.copyop(e,tp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	local code=e:GetLabel()
	if code==CARD_NEBULIX then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e1:SetCode(EVENT_CHAIN_SOLVED)
		e1:SetRange(LOCATION_FZONE)
		e1:SetCondition(s.nebcon)
		e1:SetOperation(s.nebop)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		c:RegisterEffect(e1)
	elseif code==CARD_SPHERIX then
		local e1=Effect.CreateEffect(c)
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e1:SetCode(EVENT_SUMMON_SUCCESS)
		e1:SetRange(LOCATION_FZONE)
		e1:SetOperation(s.sphreplaceop)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		c:RegisterEffect(e1)
		local e2=e1:Clone()
		e2:SetCode(EVENT_SPSUMMON_SUCCESS)
		c:RegisterEffect(e2)

		local e3=Effect.CreateEffect(c)
		e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e3:SetCode(EVENT_SPSUMMON_SUCCESS)
		e3:SetRange(LOCATION_FZONE)
		e3:SetCondition(s.sphctcon)
		e3:SetOperation(s.sphctop)
		e3:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		c:RegisterEffect(e3)

		local e4=Effect.CreateEffect(c)
		e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e4:SetCode(EVENT_PHASE+PHASE_END)
		e4:SetRange(LOCATION_FZONE)
		e4:SetCountLimit(1)
		e4:SetOperation(s.sphcleanup)
		e4:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
		c:RegisterEffect(e4)
	end
end

function s.nebcon(e,tp,eg,ep,ev,re)
	local rc=re:GetHandler()
	return rc:IsSetCard(SET_GRAVINITY) and re:IsActiveType(TYPE_SPELL+TYPE_TRAP)
end
function s.nebfilter(c,e,tp)
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
function s.nebop(e,tp)
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.nebfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,nil,e,tp)
	if #g==0 or not Duel.SelectYesNo(tp,aux.Stringid(NEBULIX_STRING_ID,1)) then return end
	Duel.Hint(HINT_CARD,0,id)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD)
	local tc=g:Select(tp,1,1,nil):GetFirst()
	if not tc then return end
	local b1=Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and tc:IsCanBeSpecialSummoned(e,0,tp,false,false)
	local b2=Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not tc:IsForbidden()
	if not b1 and not b2 then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(NEBULIX_STRING_ID,2),aux.Stringid(NEBULIX_STRING_ID,3))
	elseif b2 then
		op=1
	end
	if op==0 then
		Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)
	elseif Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then
		s.trapify(tc,e:GetHandler())
	end
end

function s.sphreplaceop(e,tp,eg)
	for tc in aux.Next(eg) do
		local p=tc:GetOwner()
		if not tc:IsPreviousLocation(LOCATION_SZONE) and tc:IsLocation(LOCATION_MZONE)
			and Duel.GetLocationCount(p,LOCATION_SZONE)>0 and not tc:IsForbidden() then
			if Duel.MoveToField(tc,tp,p,LOCATION_SZONE,POS_FACEUP,true) then
				s.trapify(tc,e:GetHandler())
				local e1=Effect.CreateEffect(tc)
				e1:SetDescription(aux.Stringid(SPHERIX_STRING_ID,1))
				e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
				e1:SetType(EFFECT_TYPE_IGNITION)
				e1:SetRange(LOCATION_SZONE)
				e1:SetCondition(function(te) return te:GetHandler():GetType()==TYPE_TRAP+TYPE_CONTINUOUS and Duel.IsMainPhase() end)
				e1:SetTarget(s.sphsptg)
				e1:SetOperation(s.sphspop)
				e1:SetReset(RESET_EVENT+RESETS_STANDARD)
				tc:RegisterEffect(e1)
			end
		end
	end
end

function s.sphsptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,true,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_SZONE)
end
function s.sphxyzmat(c,xc)
	return c:IsType(TYPE_MONSTER) and c:IsCanOverlay()
end
function s.sphspop(e,tp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) or Duel.SpecialSummon(c,0,tp,tp,true,false,POS_FACEUP)==0 then return end
	if c:IsType(TYPE_XYZ) then
		local minct=2
		local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.sphxyzmat),tp,LOCATION_GRAVE,0,nil,c)
		if #g>=minct and Duel.SelectYesNo(tp,aux.Stringid(SPHERIX_STRING_ID,1)) then
			Duel.BreakEffect()
			Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
			local sg=g:Select(tp,minct,minct,nil)
			Duel.Overlay(c,sg)
		end
	end
end

function s.sphctcon(e,tp,eg)
	return eg:IsExists(function(c) return (c:GetOriginalType()&TYPE_MONSTER)~=0 and c:IsPreviousLocation(LOCATION_SZONE) end,1,nil)
		and e:GetHandler():IsCanAddCounter(COUNTER_GRAVITY,1)
end
function s.sphctop(e)
	e:GetHandler():AddCounter(COUNTER_GRAVITY,1)
end
function s.sphcleanup(e,tp)
	local c=e:GetHandler()
	local ct=c:GetCounter(COUNTER_GRAVITY)
	if ct>0 then c:RemoveCounter(tp,COUNTER_GRAVITY,ct,REASON_RULE) end
end
