--Abstain from Light
local s,id=GetID()
local SET_STAIN=0xbc5
s.listed_series={SET_STAIN}
function s.initial_effect(c)
	Duel.EnableGlobalFlag(GLOBALFLAG_DECK_REVERSE_CHECK)
	--Track "Stain" monsters shuffled into a Deck this turn
	if not s.global_check then
		s.global_check=true
		local ge1=Effect.CreateEffect(c)
		ge1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		ge1:SetCode(EVENT_MOVE)
		ge1:SetOperation(s.checkop)
		Duel.RegisterEffect(ge1,0)
	end
	--Fusion Summon 1 "Stain" Fusion Monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.fustg)
	e1:SetOperation(s.fusop)
	c:RegisterEffect(e1)
end
function s.checkfilter(c)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsLocation(LOCATION_DECK)
		and not c:IsPreviousLocation(LOCATION_DECK) and c:IsReason(REASON_EFFECT)
end
function s.checkop(e,tp,eg,ep,ev,re,r,rp)
	for tc in aux.Next(eg) do
		if s.checkfilter(tc) then
			local p=tc:GetPreviousControler()
			if p==0 or p==1 then
				Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1)
			end
		end
	end
end
function s.matfilter(c,fc)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER)
		and (not fc or c:IsCanBeFusionMaterial(fc))
end
function s.banmatfilter(c,fc)
	return c:IsFaceup() and c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER)
		and (not fc or c:IsCanBeFusionMaterial(fc)) and c:IsAbleToRemove()
end
function s.fusfilter(c,e,tp,mg,chkf)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_FUSION)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
		and c:CheckFusionMaterial(mg,nil,chkf)
end
function s.getmaterials(tp,fc)
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,nil,fc)
	if Duel.GetFlagEffect(tp,id)>0 then
		local dg=Duel.GetMatchingGroup(s.banmatfilter,tp,0,LOCATION_DECK,nil,fc)
		mg:Merge(dg)
	end
	return mg
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
	local chkf=tp
	local mg=s.getmaterials(tp,nil)
	if chk==0 then return Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg,chkf) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end
function s.retop(e,tp,eg,ep,ev,re,r,rp)
	local g=e:GetLabelObject()
	if g then
		local rg=g:Filter(Card.IsLocation,nil,LOCATION_REMOVED)
		if #rg>0 then Duel.SendtoGrave(rg,REASON_EFFECT+REASON_RETURN) end
		g:DeleteGroup()
	end
end
function s.registerreturn(e,tp,g)
	if #g==0 then return end
	g:KeepAlive()
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_PHASE+PHASE_END)
	e1:SetCountLimit(1)
	e1:SetLabelObject(g)
	e1:SetOperation(s.retop)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.fusop(e,tp,eg,ep,ev,re,r,rp)
	local chkf=tp
	local mg=s.getmaterials(tp,nil)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sg=Duel.SelectMatchingCard(tp,s.fusfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp,mg,chkf)
	local tc=sg:GetFirst()
	if not tc then return end
	mg=s.getmaterials(tp,tc)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
	local mat=Duel.SelectFusionMaterial(tp,tc,mg,nil,chkf)
	if #mat==0 then return end
	local banmat=mat:Filter(function(c) return c:IsLocation(LOCATION_DECK) and c:IsControler(1-tp) end,nil)
	local gmat=mat:Clone()
	gmat:Sub(banmat)
	tc:SetMaterial(mat)
	local ok=true
	if #gmat>0 and Duel.SendtoGrave(gmat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)==0 then ok=false end
	if ok and #banmat>0 and Duel.Remove(banmat,POS_FACEUP,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)==0 then ok=false end
	gmat:DeleteGroup()
	if not ok then return end
	Duel.BreakEffect()
	if Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)~=0 then
		tc:CompleteProcedure()
		s.registerreturn(e,tp,banmat)
	else
		banmat:DeleteGroup()
	end
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.splimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
	local e2=Effect.CreateEffect(e:GetHandler())
	e2:SetType(EFFECT_TYPE_FIELD)
	e2:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
	e2:SetCode(EFFECT_CANNOT_ACTIVATE)
	e2:SetTargetRange(1,0)
	e2:SetValue(s.aclimit)
	e2:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e2,tp)
end
function s.splimit(e,c,sump,sumtype,sumpos,targetp,se)
	return c:IsLocation(LOCATION_EXTRA) and not c:IsSetCard(SET_STAIN)
end
function s.aclimit(e,re,tp)
	return re:GetHandler():IsCode(id)
end
