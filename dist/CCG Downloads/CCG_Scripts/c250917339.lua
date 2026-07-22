local s,id=GetID()
local STRING_ID=132917339
local GALACTICASSIOPEIA=227335484
local ELDORA=214552846
function s.initial_effect(c)
	if not s.global_check then s.global_check=true s.history={[0]={},[1]={}} local ge=Effect.CreateEffect(c) ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) ge:SetCode(EVENT_DESTROYED) ge:SetOperation(s.regop) Duel.RegisterEffect(ge,0) end
	local e1=Effect.CreateEffect(c) e1:SetType(EFFECT_TYPE_FIELD) e1:SetCode(EFFECT_SPSUMMON_PROC) e1:SetProperty(EFFECT_FLAG_UNCOPYABLE) e1:SetRange(LOCATION_HAND) e1:SetCountLimit(1,id) e1:SetCondition(s.spcon) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetDescription(aux.Stringid(STRING_ID,0)) e2:SetCategory(CATEGORY_RELEASE+CATEGORY_SPECIAL_SUMMON) e2:SetType(EFFECT_TYPE_QUICK_O) e2:SetCode(EVENT_FREE_CHAIN) e2:SetRange(LOCATION_MZONE) e2:SetCountLimit(1,id+100) e2:SetCondition(s.qcon) e2:SetCost(s.qcost) e2:SetTarget(s.qtg) e2:SetOperation(s.qop) c:RegisterEffect(e2)
end
function s.desfilter(c,p) local rc=c:GetReasonCard() return c:IsPreviousControler(p) and c:IsLocation(LOCATION_GRAVE) and ((c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-p) or rc and rc:IsCode(ELDORA)) end
function s.regop(e,tp,eg)
	local turn=Duel.GetTurnCount()
	for p=0,1 do
		local h=s.history[p]
		for i=#h,1,-1 do if h[i]<turn-1 then table.remove(h,i) end end
		local ct=eg:FilterCount(s.desfilter,nil,p)
		for _=1,ct do h[#h+1]=turn end
	end
end
function s.spcon(e,c)
	if c==nil then return true end
	local turn=Duel.GetTurnCount()
	local ct=0
	for _,dt in ipairs(s.history[c:GetControler()]) do if dt>=turn-1 then ct=ct+1 end end
	return ct>=2
end
function s.qcon(e,tp) return not Duel.IsExistingMatchingCard(function(c,mc) return c~=mc and c:IsFaceup() and c:IsType(TYPE_EFFECT) end,tp,LOCATION_MZONE,0,1,nil,e:GetHandler()) end
function s.qcost(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler() if chk==0 then return c:IsReleasable() end e:SetLabel(c:IsSummonType(SUMMON_TYPE_SPECIAL) and 1 or 0) Duel.Release(c,REASON_COST) end
function s.qfilter(c,e,tp) return c:IsCode(GALACTICASSIOPEIA) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_ATTACK) end
function s.qtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.qfilter,tp,LOCATION_DECK,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK) end
function s.qop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON) local tc=Duel.SelectMatchingCard(tp,s.qfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp):GetFirst() if tc and Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK)>0 and e:GetLabel()==1 then local te=Effect.CreateEffect(e:GetHandler()) te:SetType(EFFECT_TYPE_SINGLE) te:SetCode(EFFECT_INDESTRUCTABLE) te:SetValue(1) te:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END) tc:RegisterEffect(te) end end
