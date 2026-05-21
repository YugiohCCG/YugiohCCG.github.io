--Virtua Leet
local s,id=GetID()
local SET_LEET=0xfe88
local STRING_ID=id
local MATCOUNT_FLAG=id+1000
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddFusionProcFunRep2(c,s.matfilter,2,99,true)
	--Store the number of qualifying Fusion Materials
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetCode(EFFECT_MATERIAL_CHECK)
	e0:SetValue(s.valcheck)
	c:RegisterEffect(e0)
	--2+ materials: cannot be destroyed by battle
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetCode(EFFECT_INDESTRUCTABLE_BATTLE)
	e1:SetCondition(s.con2)
	e1:SetValue(1)
	c:RegisterEffect(e1)
	--2+ materials: cannot be destroyed by card effects
	local e2=e1:Clone()
	e2:SetCode(EFFECT_INDESTRUCTABLE_EFFECT)
	c:RegisterEffect(e2)
	--3+ materials: cannot be targeted by opponent's card effects
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_SINGLE)
	e3:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET)
	e3:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e3:SetRange(LOCATION_MZONE)
	e3:SetCondition(s.con3)
	e3:SetValue(aux.tgoval)
	c:RegisterEffect(e3)
	--4+ materials: unaffected by card effects
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_SINGLE)
	e4:SetCode(EFFECT_IMMUNE_EFFECT)
	e4:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
	e4:SetRange(LOCATION_MZONE)
	e4:SetCondition(s.con4)
	e4:SetValue(s.immval)
	c:RegisterEffect(e4)
	--4+ materials: if Fusion Summoned this turn, you cannot Special Summon for the rest of the turn
	local e5=Effect.CreateEffect(c)
	e5:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
	e5:SetCode(EVENT_SPSUMMON_SUCCESS)
	e5:SetCondition(s.lockcon)
	e5:SetOperation(s.lockop)
	c:RegisterEffect(e5)
	--5+ materials: banish 1 Cyberse from GY; destroy 1 opponent's card
	local e6=Effect.CreateEffect(c)
	e6:SetDescription(aux.Stringid(STRING_ID,0))
	e6:SetCategory(CATEGORY_REMOVE+CATEGORY_DESTROY)
	e6:SetType(EFFECT_TYPE_IGNITION)
	e6:SetRange(LOCATION_MZONE)
	e6:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e6:SetCondition(s.descon)
	e6:SetCost(s.descost)
	e6:SetTarget(s.destg)
	e6:SetOperation(s.desop)
	c:RegisterEffect(e6)
end
s.listed_series={SET_LEET}
function s.zeroatkdef(c)
	return c:GetAttack()==0 and (c:IsType(TYPE_LINK) or c:GetDefense()==0)
end
function s.matfilter(c,fc,sumtype,tp)
	return c:IsRace(RACE_CYBERSE) and s.zeroatkdef(c)
end
function s.countmat(c)
	local g=c:GetMaterial()
	if not g then return 0 end
	return g:FilterCount(s.zeroatkdef,nil)
end
function s.valcheck(e,c)
	c:RegisterFlagEffect(MATCOUNT_FLAG,RESET_EVENT+RESETS_STANDARD,0,1,s.countmat(c))
end
function s.matcount(c)
	local ct=c:GetFlagEffectLabel(MATCOUNT_FLAG)
	if ct then return ct end
	return s.countmat(c)
end
function s.con2(e)
	return s.matcount(e:GetHandler())>=2
end
function s.con3(e)
	return s.matcount(e:GetHandler())>=3
end
function s.con4(e)
	return s.matcount(e:GetHandler())>=4
end
function s.immval(e,re)
	return true
end
function s.lockcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsSummonType(SUMMON_TYPE_FUSION) and s.matcount(c)>=4
end
function s.splimit(e,c,sump,sumtype,sumpos,targetp,se)
	return true
end
function s.lockop(e,tp,eg,ep,ev,re,r,rp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.splimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.descon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return s.matcount(c)>=5 and c:GetFlagEffect(id)==0
end
function s.rmfilter(c)
	return c:IsRace(RACE_CYBERSE) and c:IsAbleToRemoveAsCost()
end
function s.descost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.rmfilter),tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
	local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.rmfilter),tp,LOCATION_GRAVE,0,1,1,nil)
	Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.destfilter(c,e)
	return c:IsCanBeEffectTarget(e) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_ONFIELD) and s.destfilter(chkc,e) end
	if chk==0 then return Duel.IsExistingTarget(s.destfilter,tp,0,LOCATION_ONFIELD,1,nil,e) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local g=Duel.SelectTarget(tp,s.destfilter,tp,0,LOCATION_ONFIELD,1,1,nil,e)
	Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,tp,LOCATION_GRAVE)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
end
function s.desop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD,0,1)
	local tc=Duel.GetFirstTarget()
	if tc and tc:IsRelateToEffect(e) then
		Duel.Destroy(tc,REASON_EFFECT)
	end
end
