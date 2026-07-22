local s,id=GetID()
local STRING_ID=132064522
function s.initial_effect(c)
	--Activate
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOKEN)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
	CCG_GLOBAL_CHECKS=CCG_GLOBAL_CHECKS or {}
	if not CCG_GLOBAL_CHECKS[231273040] then
		CCG_GLOBAL_CHECKS[231273040]=true
		local ge1=Effect.CreateEffect(c)
		ge1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge1:SetCode(EVENT_TO_HAND)
		ge1:SetOperation(function(e,tp,eg,ep,ev,re,r,rp)
			for p=0,1 do
				local ct=eg:FilterCount(function(c,tp) return c:IsSetCard(0x21fc) and c:IsControler(tp) and c:IsPreviousLocation(LOCATION_DECK) end,nil,p)
				for i=1,ct do
					Duel.RegisterFlagEffect(p,231273040,RESET_PHASE+PHASE_END,0,1)
				end
			end
		end)
		Duel.RegisterEffect(ge1,0)
	end
	if not CCG_GLOBAL_CHECKS[238064522] then
		CCG_GLOBAL_CHECKS[238064522]=true
		--Track Quick-Play Spells activated this Duel
		local ge2=Effect.CreateEffect(c)
		ge2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge2:SetCode(EVENT_CHAINING)
		ge2:SetOperation(function(e,tp,eg,ep,ev,re,r,rp)
			local rc=re:GetHandler()
			if rc:IsSetCard(0x21fc) and rc:IsType(TYPE_QUICKPLAY) and re:IsHasType(EFFECT_TYPE_ACTIVATE) then
				Duel.RegisterFlagEffect(rp,238064522,0,0,1)
			end
		end)
		Duel.RegisterEffect(ge2,0)
	end
end
s.listed_series={0x21fc}
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsPlayerCanSpecialSummonMonster(tp,id+1,0x21fc,TYPES_TOKEN_MONSTER,1000,1000,4,RACE_WINDBEAST,ATTRIBUTE_WIND) end
	local lv=Duel.AnnounceNumber(tp,4,6)
	e:SetLabel(lv)
	Duel.SetOperationInfo(0,CATEGORY_TOKEN,nil,1,tp,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,0)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	local lv=e:GetLabel()
	if not Duel.IsPlayerCanSpecialSummonMonster(tp,id+1,0x21fc,TYPES_TOKEN_MONSTER,1000,1000,lv,RACE_WINDBEAST,ATTRIBUTE_WIND) then return end
	local token=Duel.CreateToken(tp,id+1)
	if Duel.SpecialSummonStep(token,0,tp,tp,false,false,POS_FACEUP) then
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_CHANGE_LEVEL)
		e1:SetValue(lv)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		token:RegisterEffect(e1,true)
		
		if Duel.GetFlagEffect(tp,231273040)>=3 then
			local qp_ct = Duel.GetFlagEffect(tp,238064522)
			if Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then
				local e2=Effect.CreateEffect(e:GetHandler())
				e2:SetType(EFFECT_TYPE_SINGLE)
				e2:SetCode(EFFECT_ADD_TYPE)
				e2:SetValue(TYPE_TUNER)
				e2:SetReset(RESET_EVENT+RESETS_STANDARD)
				token:RegisterEffect(e2,true)
			end
			if qp_ct>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,1)) then
				local e3=Effect.CreateEffect(e:GetHandler())
				e3:SetType(EFFECT_TYPE_SINGLE)
				e3:SetCode(EFFECT_UPDATE_ATTACK)
				e3:SetValue(qp_ct*500)
				e3:SetReset(RESET_EVENT+RESETS_STANDARD)
				token:RegisterEffect(e3,true)
				local e4=e3:Clone()
				e4:SetCode(EFFECT_UPDATE_DEFENSE)
				token:RegisterEffect(e4,true)
			end
		end
		Duel.SpecialSummonComplete()
	end
end
