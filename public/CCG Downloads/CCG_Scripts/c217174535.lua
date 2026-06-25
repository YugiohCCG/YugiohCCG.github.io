--Stainless Kaleidragon
local s,id=GetID()
local SET_STAIN=0xbc5
s.listed_series={SET_STAIN}
s.listed_names={218685316}
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.AddFusionProcMix(c,false,true,218685316,s.matfilter,s.matfilter)
	--Negate a Special Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_DISABLE_SUMMON+CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_SPSUMMON)
	e1:SetRange(LOCATION_MZONE)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetCondition(s.sumnegcon)
	e1:SetTarget(s.sumnegtg)
	e1:SetOperation(s.sumnegop)
	c:RegisterEffect(e1)
	--Negate an effect that Special Summons
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,0))
	e2:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY)
	e2:SetType(EFFECT_TYPE_QUICK_O)
	e2:SetCode(EVENT_CHAINING)
	e2:SetRange(LOCATION_MZONE)
	e2:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e2:SetCondition(s.actnegcon)
	e2:SetTarget(s.actnegtg)
	e2:SetOperation(s.actnegop)
	c:RegisterEffect(e2)
	--Look at opponent's hand and face-down cards
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,1))
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetRange(LOCATION_MZONE)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id+100+EFFECT_COUNT_CODE_OATH)
	e3:SetCondition(s.lookcon)
	e3:SetOperation(s.lookop)
	c:RegisterEffect(e3)
	Duel.AddCustomActivityCounter(id,ACTIVITY_CHAIN,s.actlimitfilter)
end
function s.matfilter(c,fc,sub,mg,sg)
	return c:IsFusionSetCard(SET_STAIN)
end
function s.stainfilter(c)
	return c:IsSetCard(SET_STAIN)
end
function s.actlimitfilter(re,tp,cid)
	return re:GetHandler():IsSetCard(SET_STAIN)
end
function s.chainlimit(e,re,tp)
	return not re:GetHandler():IsSetCard(SET_STAIN)
end
function s.applylimit(e,tp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
	e1:SetCode(EFFECT_CANNOT_ACTIVATE)
	e1:SetTargetRange(1,0)
	e1:SetValue(s.chainlimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.sumnegcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.GetCurrentChain()==0 and Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0
end
function s.sumnegtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_DISABLE_SUMMON,eg,#eg,0,0)
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,eg,#eg,0,0)
end
function s.sumnegop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.NegateSummon(eg)~=0 then
		Duel.Destroy(eg,REASON_EFFECT)
		s.applylimit(e,tp)
	end
end
function s.actnegcon(e,tp,eg,ep,ev,re,r,rp)
	local ex=Duel.GetOperationInfo(ev,CATEGORY_SPECIAL_SUMMON)
	return ex and Duel.IsChainNegatable(ev) and Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0
		and (rp~=tp or re:GetHandler():IsSetCard(SET_STAIN))
end
function s.actnegtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return true end
	Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
	if re:GetHandler():IsDestructable() and re:GetHandler():IsRelateToEffect(re) then
		Duel.SetOperationInfo(0,CATEGORY_DESTROY,eg,1,0,0)
	end
end
function s.actnegop(e,tp,eg,ep,ev,re,r,rp)
	local rc=re:GetHandler()
	if Duel.NegateActivation(ev)~=0 then
		if rc:IsRelateToEffect(re) then Duel.Destroy(rc,REASON_EFFECT) end
		s.applylimit(e,tp)
	end
end
function s.lookfilter(c,tp,sc)
	return c==sc or c:IsControler(tp) and c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c~=sc
end
function s.lookcon(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(s.lookfilter,1,nil,tp,e:GetHandler())
end
function s.lookop(e,tp,eg,ep,ev,re,r,rp)
	local hg=Duel.GetFieldGroup(tp,0,LOCATION_HAND)
	if #hg>0 then
		Duel.ConfirmCards(tp,hg)
		Duel.ShuffleHand(1-tp)
	end
	local fg=Duel.GetMatchingGroup(Card.IsFacedown,tp,0,LOCATION_ONFIELD,nil)
	if #fg>0 then
		Duel.ConfirmCards(tp,fg)
	end
end
