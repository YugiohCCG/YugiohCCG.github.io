--Chrono-Saur Rex
--Cleaned and audited replacement script for YGO Omega
local s,id=GetID()
local SET_CHRONO_SAUR=0xdae7
function s.initial_effect(c)
	--Destroy 1 card you control and Special Summon from hand
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_HAND)
	e1:SetHintTiming(0,TIMINGS_CHECK_MONSTER+TIMING_MAIN_END+TIMING_BATTLE_END)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.spcon1)
	e1:SetTarget(s.sptg1)
	e1:SetOperation(s.spop1)
	c:RegisterEffect(e1)
	--Special Summon from GY on attack declaration
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_ATTACK_ANNOUNCE)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,{id,1})
	e2:SetCondition(s.spcon2)
	e2:SetTarget(s.sptg2)
	e2:SetOperation(s.spop2)
	c:RegisterEffect(e2)
end
s.listed_series={SET_CHRONO_SAUR}

function s.spcon1(e,tp,eg,ep,ev,re,r,rp)
	local ph=Duel.GetCurrentPhase()
	return (ph==PHASE_MAIN1 or Duel.IsBattlePhase()) and not (ph&(PHASE_DAMAGE+PHASE_DAMAGE_CAL)~=0)
end
function s.desfilter(c,e,tp)
	return c:IsDestructable(e) and (c:IsSetCard(SET_CHRONO_SAUR) or (c:IsFaceup() and c:IsRace(RACE_DINOSAUR)))
		and Duel.GetMZoneCount(tp,c)>0
end
function s.sptg1(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsCanBeSpecialSummoned(e,0,tp,false,false)
		and Duel.IsExistingMatchingCard(s.desfilter,tp,LOCATION_ONFIELD,0,1,nil,e,tp) end
	local g=Duel.GetMatchingGroup(s.desfilter,tp,LOCATION_ONFIELD,0,nil,e,tp)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.spop1(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_ONFIELD,0,1,1,nil,e,tp)
	if #g>0 and Duel.Destroy(g,REASON_EFFECT)>0 and c:IsRelateToEffect(e) then
		if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then
			local end_phase=Duel.IsBattlePhase() and PHASE_BATTLE or PHASE_MAIN1
			local fid=c:GetFieldID()
			c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+end_phase,0,1,fid)
			local de=Effect.CreateEffect(c)
			de:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
			de:SetCode(EVENT_PHASE+end_phase)
			de:SetCountLimit(1)
			de:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
			de:SetLabel(fid)
			de:SetLabelObject(c)
			de:SetReset(RESET_PHASE+end_phase)
			de:SetOperation(s.desop)
			Duel.RegisterEffect(de,tp)
		end
	end
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local tc=e:GetLabelObject()
	if tc and tc:GetFlagEffectLabel(id)==e:GetLabel() then
		Duel.Destroy(tc,REASON_EFFECT)
	end
end
function s.spcon2(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetAttacker():IsControler(tp)
end
function s.sptg2(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.spop2(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then
		local fid=c:GetFieldID()
		c:RegisterFlagEffect(id+100,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_BATTLE,0,1,fid)
		local de=Effect.CreateEffect(c)
		de:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		de:SetCode(EVENT_PHASE+PHASE_BATTLE)
		de:SetCountLimit(1)
		de:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
		de:SetLabel(fid)
		de:SetLabelObject(c)
		de:SetReset(RESET_PHASE+PHASE_BATTLE)
		de:SetOperation(s.desop2)
		Duel.RegisterEffect(de,tp)
	end
end
function s.desop2(e,tp,eg,ep,ev,re,r,rp)
	local tc=e:GetLabelObject()
	if tc and tc:GetFlagEffectLabel(id+100)==e:GetLabel() then
		Duel.Destroy(tc,REASON_EFFECT)
	end
end
