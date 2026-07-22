--Recollection: Kaboom Papa
local s,id=GetID()
local STRING_ID=133447408
local CARD_PEDICAES_PAPA=241868535
local CARD_RECOLLECTION_MINE=231872299
function s.initial_effect(c)
	--Destroy 1 "Mine" Field Spell and 1 "Pedicae's Papa", and if you do, destroy all cards
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
s.listed_names={CARD_PEDICAES_PAPA,CARD_RECOLLECTION_MINE}
function s.minefilter(c)
	return c:IsFaceup() and c:IsCode(CARD_RECOLLECTION_MINE) and c:IsType(TYPE_FIELD) and c:IsDestructable()
end
function s.papafilter(c)
	return c:IsFaceup() and c:IsCode(CARD_PEDICAES_PAPA) and c:IsDestructable()
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.minefilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil)
		and Duel.IsExistingMatchingCard(s.papafilter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,2,PLAYER_ALL,LOCATION_ONFIELD)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local g=Group.CreateGroup()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local mg=Duel.SelectMatchingCard(tp,s.minefilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil)
	if #mg==0 then s.applysummonlimit(e,tp) return end
	g:Merge(mg)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local pg=Duel.SelectMatchingCard(tp,s.papafilter,tp,LOCATION_MZONE,0,1,1,nil)
	if #pg==0 then s.applysummonlimit(e,tp) return end
	g:Merge(pg)
	if Duel.Destroy(g,REASON_EFFECT)==2 then
		local dg=Duel.GetMatchingGroup(Card.IsDestructable,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil)
		if #dg>0 then
			Duel.BreakEffect()
			Duel.Destroy(dg,REASON_EFFECT)
		end
	end
	s.applysummonlimit(e,tp)
end
function s.applysummonlimit(e,tp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetCode(EFFECT_CANNOT_SUMMON)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.sumlimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_CANNOT_FLIP_SUMMON)
	Duel.RegisterEffect(e2,tp)
	local e3=e1:Clone()
	e3:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	Duel.RegisterEffect(e3,tp)
	local e4=Effect.CreateEffect(e:GetHandler())
	e4:SetType(EFFECT_TYPE_FIELD)
	e4:SetCode(EFFECT_LEFT_SPSUMMON_COUNT)
	e4:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
	e4:SetTargetRange(1,0)
	e4:SetValue(s.countval)
	e4:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e4,tp)
end
function s.summoncount(tp)
	local t1,t2,t3=Duel.GetActivityCount(tp,ACTIVITY_SUMMON,ACTIVITY_FLIPSUMMON,ACTIVITY_SPSUMMON)
	return t1+t2+t3
end
function s.sumlimit(e,c,tp)
	return s.summoncount(tp)>=1
end
function s.countval(e,re,tp)
	local ct=s.summoncount(tp)
	if ct>=1 then return 0 else return 1-ct end
end
