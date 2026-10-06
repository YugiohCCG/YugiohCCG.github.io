--Maiden of Talismandrakes Seraphina
--Cleaned and audited replacement script for YGO Omega
local s,id=GetID()
local SET_TALISMANDRAKE=0xb47
local SET_TALISMANDRAKE_ARMS=0x452f
local CARD_SUPPRESSOR=238136421
local CARD_HALBERD=215921734
local CARD_SABRE=248788543
local CARD_SHIELD=255832330
function s.initial_effect(c)
	aux.EnablePendulumAttribute(c)
	c:EnableReviveLimit()
	aux.AddFusionProcFunFunRep(c,s.pyropend,aux.FilterBoolFunction(Card.IsFusionSetCard,SET_TALISMANDRAKE),2,2,true)
	--Pendulum Effect: Shuffle 3 with diff names -> Special Summon -> optional equip from GY
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_TODECK+CATEGORY_SPECIAL_SUMMON+CATEGORY_EQUIP)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_PZONE)
	e1:SetCountLimit(1,id)
	e1:SetCost(s.pcost)
	e1:SetTarget(s.psptg)
	e1:SetOperation(s.pspop)
	c:RegisterEffect(e1)
	--Monster Effect 1: Fusion Summoned OR opp activates card/effect -> add or equip Arms from GY
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_EQUIP)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	e2:SetCountLimit(1,{id,1})
	e2:SetCondition(s.fuscon)
	e2:SetTarget(s.gytg)
	e2:SetOperation(s.gyop)
	c:RegisterEffect(e2)
	local e3=e2:Clone()
	e3:SetType(EFFECT_TYPE_QUICK_O)
	e3:SetCode(EVENT_CHAINING)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCondition(s.oppcon)
	c:RegisterEffect(e3)
	--Monster Effect 2: If leaves field -> place in Pendulum Zone
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(id,2))
	e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e4:SetProperty(EFFECT_FLAG_DELAY)
	e4:SetCode(EVENT_LEAVE_FIELD)
	e4:SetCountLimit(1,{id,2})
	e4:SetCondition(s.pencon)
	e4:SetTarget(s.pentg)
	e4:SetOperation(s.penop)
	c:RegisterEffect(e4)
	--Board wipe Quick Effect
	local e5=Effect.CreateEffect(c)
	e5:SetDescription(aux.Stringid(id,3))
	e5:SetCategory(CATEGORY_DESTROY)
	e5:SetType(EFFECT_TYPE_QUICK_O)
	e5:SetCode(EVENT_FREE_CHAIN)
	e5:SetRange(LOCATION_MZONE)
	e5:SetCondition(s.descon)
	e5:SetCost(s.descost)
	e5:SetTarget(s.destg)
	e5:SetOperation(s.desop)
	c:RegisterEffect(e5)
end
s.listed_series={SET_TALISMANDRAKE,SET_TALISMANDRAKE_ARMS}

function s.pyropend(c)
	return c:IsRace(RACE_PYRO) and c:IsFusionType(TYPE_PENDULUM)
end
function s.pcostfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_MONSTER)
		and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
		and c:IsAbleToDeckOrExtraAsCost()
end
function s.pcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.pcostfilter),tp,LOCATION_ONFIELD+LOCATION_GRAVE+LOCATION_EXTRA,0,c)
	if chk==0 then return g:CheckSubGroup(aux.dncheck,3,3) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local sg=g:SelectSubGroup(tp,aux.dncheck,false,3,3)
	Duel.SendtoDeck(sg,nil,SEQ_DECKSHUFFLE,REASON_COST)
end
function s.psptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
	Duel.SetPossibleOperationInfo(0,CATEGORY_EQUIP,nil,1,tp,LOCATION_GRAVE)
end
function s.armsfilter(c)
	return c:IsSetCard(SET_TALISMANDRAKE_ARMS) and c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsForbidden()
end
function s.pspop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not (c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0) then return end
	if Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.armsfilter),tp,LOCATION_GRAVE,0,1,nil)
		and Duel.SelectYesNo(tp,aux.Stringid(id,5)) then
		Duel.BreakEffect()
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
		local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.armsfilter),tp,LOCATION_GRAVE,0,1,1,nil)
		local ec=g:GetFirst()
		if ec and Duel.Equip(tp,ec,c) then
			local e1=Effect.CreateEffect(c)
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetCode(EFFECT_CHANGE_TYPE)
			e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e1:SetValue(TYPE_SPELL+TYPE_EQUIP)
			e1:SetReset(RESET_EVENT+RESETS_STANDARD)
			ec:RegisterEffect(e1)
			local e2=Effect.CreateEffect(c)
			e2:SetType(EFFECT_TYPE_SINGLE)
			e2:SetCode(EFFECT_EQUIP_LIMIT)
			e2:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e2:SetValue(function(e,target) return target==c end)
			e2:SetReset(RESET_EVENT+RESETS_STANDARD)
			ec:RegisterEffect(e2)
		end
	end
end
function s.fuscon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():IsSummonType(SUMMON_TYPE_FUSION)
end
function s.oppcon(e,tp,eg,ep,ev,re,r,rp)
	return rp==1-tp
end
function s.gytgfilter(c,e,tp)
	return s.armsfilter(c) and (c:IsAbleToHand() or (Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and e:GetHandler():IsFaceup()))
end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and aux.NecroValleyFilter(s.gytgfilter)(chkc,e,tp) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.gytgfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.gytgfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
	Duel.SetPossibleOperationInfo(0,CATEGORY_TOHAND,g,1,0,0)
	Duel.SetPossibleOperationInfo(0,CATEGORY_EQUIP,g,1,0,0)
end
function s.gyop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter(s.armsfilter)(tc)) then return end
	local b1=tc:IsAbleToHand()
	local b2=c:IsRelateToEffect(e) and c:IsFaceup() and c:IsLocation(LOCATION_MZONE) and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
	if not (b1 or b2) then return end
	local op=0
	if b1 and b2 then
		op=Duel.SelectOption(tp,aux.Stringid(id,4),aux.Stringid(id,5))
	elseif b1 then
		op=0
	else
		op=1
	end
	if op==0 then
		Duel.SendtoHand(tc,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,tc)
	else
		if Duel.Equip(tp,tc,c) then
			local e1=Effect.CreateEffect(c)
			e1:SetType(EFFECT_TYPE_SINGLE)
			e1:SetCode(EFFECT_CHANGE_TYPE)
			e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e1:SetValue(TYPE_SPELL+TYPE_EQUIP)
			e1:SetReset(RESET_EVENT+RESETS_STANDARD)
			tc:RegisterEffect(e1)
			local e2=Effect.CreateEffect(c)
			e2:SetType(EFFECT_TYPE_SINGLE)
			e2:SetCode(EFFECT_EQUIP_LIMIT)
			e2:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
			e2:SetValue(function(e,target) return target==c end)
			e2:SetReset(RESET_EVENT+RESETS_STANDARD)
			tc:RegisterEffect(e2)
		end
	end
end
function s.pencon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousControler(tp)
end
function s.pentg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckLocation(tp,LOCATION_PZONE,0) or Duel.CheckLocation(tp,LOCATION_PZONE,1) end
end
function s.penop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) then
		Duel.MoveToField(c,tp,tp,LOCATION_PZONE,POS_FACEUP,true)
	end
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local eq=c:GetEquipGroup()
	if not eq or #eq<2 then return false end
	local has_left=eq:IsExists(function(card) return card:IsCode(CARD_SUPPRESSOR,CARD_SHIELD) end,1,nil)
	local has_right=eq:IsExists(function(card) return card:IsCode(CARD_HALBERD,CARD_SABRE) end,1,nil)
	return has_left and has_right and Duel.GetFlagEffect(tp,id+200)==0
end
function s.descost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckLPCost(tp,1000) end
	Duel.PayLPCost(tp,1000)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.TRUE,tp,0,LOCATION_ONFIELD,1,nil) end
	local g=Duel.GetMatchingGroup(aux.TRUE,tp,0,LOCATION_ONFIELD,nil)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,#g,0,0)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(aux.TRUE,tp,0,LOCATION_ONFIELD,nil)
	if #g>0 then
		Duel.Destroy(g,REASON_EFFECT)
	end
	--Lockout until end of next turn registered in operation
	Duel.RegisterFlagEffect(tp,id+200,RESET_PHASE+PHASE_END,0,2)
end
