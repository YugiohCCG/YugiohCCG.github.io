--Restoration of Azrynior
local s,id=GetID()
local STRING_ID=132239443
local TOKEN_PROTOGENIC=240299293
local CARD_AZRYNIOR=245099829
function s.initial_effect(c)
	--Activate
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_ACTIVATE)
	e0:SetCode(EVENT_FREE_CHAIN)
	c:RegisterEffect(e0)
	--Tribute 1 Token; Special Summon destroyed monsters
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_RELEASE+CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_QUICK_O)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetRange(LOCATION_SZONE)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.spcon)
	e1:SetCost(s.spcost)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e1:SetTarget(s.sptg)
	e1:SetOperation(s.spop)
	c:RegisterEffect(e1)
	if not s.global_check then
		s.global_check=true
		local ge1=Effect.CreateEffect(c)
		ge1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge1:SetCode(EVENT_DESTROYED)
		ge1:SetOperation(s.checkop)
		Duel.RegisterEffect(ge1,0)
	end
end
s.listed_names={TOKEN_PROTOGENIC,CARD_AZRYNIOR}
function s.checkfilter(c,p,effect_only)
	return c:IsType(TYPE_MONSTER) and c:IsReason(REASON_DESTROY)
		and c:GetPreviousControler()==p and c:GetReasonPlayer()==1-p
		and (not effect_only or c:IsReason(REASON_EFFECT))
end
function s.checkop(e,tp,eg,ep,ev,re,r,rp)
	for p=0,1 do
		for tc in aux.Next(eg) do
			if s.checkfilter(tc,p,false) then
				tc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1,p)
			end
			if s.checkfilter(tc,p,true) then
				tc:RegisterFlagEffect(id+1,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1,p)
			end
		end
	end
end
function s.azfilter(c)
	return c:IsFaceup() and c:IsCode(CARD_AZRYNIOR)
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(s.azfilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.tkfilter(c)
	return c:IsCode(TOKEN_PROTOGENIC) and c:IsReleasable()
end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.CheckReleaseGroup(tp,s.tkfilter,1,nil) end
	local g=Duel.SelectReleaseGroup(tp,s.tkfilter,1,1,nil)
	Duel.Release(g,REASON_COST)
end
function s.spfilter(c,e,tp,effect_only)
	local fid=effect_only and id+1 or id
	return c:IsType(TYPE_MONSTER) and c:GetFlagEffect(fid)>0 and c:GetFlagEffectLabel(fid)==tp
		and c:IsCanBeSpecialSummoned(e,0,tp,false,false) and aux.NecroValleyFilter()(c)
end
function s.match(c,tc)
	return c:IsRace(tc:GetRace()) or c:IsAttribute(tc:GetAttribute())
		or (c:GetLevel()>0 and tc:GetLevel()>0 and c:IsLevel(tc:GetLevel()))
		or (c:GetAttack()>=0 and tc:GetAttack()>=0 and c:GetAttack()==tc:GetAttack())
		or (not c:IsType(TYPE_LINK) and not tc:IsType(TYPE_LINK)
			and c:GetDefense()>=0 and tc:GetDefense()>=0 and c:GetDefense()==tc:GetDefense())
end
function s.grpfilter(c,e,tp,tc)
	return c==tc or s.spfilter(c,e,tp,false) and s.match(c,tc)
end
function s.tgfilter(c,e,tp,extra)
	if not s.spfilter(c,e,tp,true) then return false end
	local ft=Duel.GetLocationCount(tp,LOCATION_MZONE)+(extra or 0)
	if ft<=0 then return false end
	local g=Duel.GetMatchingGroup(s.grpfilter,tp,LOCATION_GRAVE,0,nil,e,tp,c)
	return #g>0 and #g<=ft and (#g==1 or not Duel.IsPlayerAffectedByEffect(tp,59822133))
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and s.tgfilter(chkc,e,tp,0) end
	if chk==0 then
		local extra=e:IsCostChecked() and 0 or 1
		return Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_GRAVE,0,1,nil,e,tp,extra)
	end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local g=Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_GRAVE,0,1,1,nil,e,tp,0)
	local tc=g:GetFirst()
	local sg=Duel.GetMatchingGroup(s.grpfilter,tp,LOCATION_GRAVE,0,nil,e,tp,tc)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,sg,#sg,tp,LOCATION_GRAVE)
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not (c:IsRelateToEffect(e) and tc and tc:IsRelateToEffect(e) and s.spfilter(tc,e,tp,true)) then return end
	local ft=Duel.GetLocationCount(tp,LOCATION_MZONE)
	if ft<=0 then return end
	local g=Duel.GetMatchingGroup(s.grpfilter,tp,LOCATION_GRAVE,0,nil,e,tp,tc)
	if #g==0 or #g>ft or (#g>1 and Duel.IsPlayerAffectedByEffect(tp,59822133)) then return end
	Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)
end
