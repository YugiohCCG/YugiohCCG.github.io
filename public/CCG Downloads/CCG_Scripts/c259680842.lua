--Grimoire of Eclipse
local s,id=GetID()
local SET_ECLIPSE_OBSERVER=0xeb17
local CARD_BALEYGR=259193076
local OBSERVER_MONSTERS={
	[259652372]=true,
	[259926839]=true,
	[259069729]=true,
	[259487387]=true,
	[259058125]=true,
	[259193076]=true,
	[259126370]=true,
	[259612312]=true,
}
function s.initial_effect(c)
	--Fusion Summon 1 "Eclipse Observer" monster
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON+CATEGORY_DRAW)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.target)
	e1:SetOperation(s.activate)
	c:RegisterEffect(e1)
end
function s.isobservermonster(c)
	return c:IsType(TYPE_MONSTER) and (OBSERVER_MONSTERS[c:GetCode()] or c:IsSetCard(SET_ECLIPSE_OBSERVER))
end
function s.matfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsCanBeFusionMaterial() and c:IsAbleToGrave()
end
function s.matfilter1(c,e)
	return not c:IsImmuneToEffect(e)
end
function s.fcheck(tp,sg,fc)
	return sg:FilterCount(Card.IsLocation,nil,LOCATION_DECK)<=1
end
function s.baleygrmat1(c)
	return s.isobservermonster(c) and c:IsLevel(8)
end
function s.baleygrmatcheck(sg)
	if #sg~=2 or sg:FilterCount(Card.IsLocation,nil,LOCATION_DECK)>1 then return false end
	local c1=sg:GetFirst()
	local c2=sg:GetNext()
	return (s.baleygrmat1(c1) and c2:IsRace(RACE_SPELLCASTER))
		or (s.baleygrmat1(c2) and c1:IsRace(RACE_SPELLCASTER))
end
function s.fusfilter(c,e,tp,m,f,chkf,allow_custom)
	if not (s.isobservermonster(c) and c:IsType(TYPE_FUSION)
		and (not f or f(c))
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)) then return false end
	aux.FCheckAdditional=s.fcheck
	local res=c:CheckFusionMaterial(m,nil,chkf)
	aux.FCheckAdditional=nil
	return res or (allow_custom and c:IsCode(CARD_BALEYGR) and m:CheckSubGroup(s.baleygrmatcheck,2,2))
end
function s.fusiongroup(tp,e)
	local mg=Duel.GetFusionMaterial(tp)
	if e then
		mg=mg:Filter(s.matfilter1,nil,e)
	end
	if Duel.IsPlayerCanDraw(1-tp,2) then
		local dg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_DECK,0,nil)
		mg:Merge(dg)
	end
	return mg
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then
		local chkf=tp
		local mg=s.fusiongroup(tp,e)
		local res=Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg,nil,chkf,true)
		if not res then
			local ce=Duel.GetChainMaterial(tp)
			if ce then
				local fgroup=ce:GetTarget()
				local mg2=fgroup(ce,e,tp)
				local mf=ce:GetValue()
				res=Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg2,mf,chkf,false)
			end
		end
		return res
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,1-tp,2)
end
function s.activate(e,tp,eg,ep,ev,re,r,rp)
	local chkf=tp
	local mg1=s.fusiongroup(tp,e)
	local sg1=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg1,nil,chkf,true)
	local mg2=nil
	local sg2=nil
	local ce=Duel.GetChainMaterial(tp)
	if ce then
		local fgroup=ce:GetTarget()
		mg2=fgroup(ce,e,tp)
		local mf=ce:GetValue()
		sg2=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg2,mf,chkf,false)
	end
	if #sg1==0 and (not sg2 or #sg2==0) then return end
	local sg=sg1:Clone()
	if sg2 then sg:Merge(sg2) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tc=sg:Select(tp,1,1,nil):GetFirst()
	if not tc then return end
	if sg1:IsContains(tc) and (not sg2 or not sg2:IsContains(tc) or not Duel.SelectYesNo(tp,ce:GetDescription())) then
		local mat=nil
		local b1=false
		aux.FCheckAdditional=s.fcheck
		if tc:CheckFusionMaterial(mg1,nil,chkf) then b1=true end
		aux.FCheckAdditional=nil
		local b2=(tc:IsCode(CARD_BALEYGR) and mg1:CheckSubGroup(s.baleygrmatcheck,2,2))
		if b1 and b2 then
			if Duel.SelectYesNo(tp,aux.Stringid(id,1)) then
				mat=mg1:SelectSubGroup(tp,s.baleygrmatcheck,false,2,2)
			else
				aux.FCheckAdditional=s.fcheck
				mat=Duel.SelectFusionMaterial(tp,tc,mg1,nil,chkf)
				aux.FCheckAdditional=nil
			end
		elseif b2 then
			mat=mg1:SelectSubGroup(tp,s.baleygrmatcheck,false,2,2)
		else
			aux.FCheckAdditional=s.fcheck
			mat=Duel.SelectFusionMaterial(tp,tc,mg1,nil,chkf)
			aux.FCheckAdditional=nil
		end
		if not mat or #mat==0 then return end
		local used_deck=mat:IsExists(Card.IsLocation,1,nil,LOCATION_DECK)
		tc:SetMaterial(mat)
		Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)
		Duel.BreakEffect()
		if Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then
			tc:CompleteProcedure()
			if used_deck then
				Duel.Draw(1-tp,2,REASON_EFFECT)
			end
		end
	else
		local mat=Duel.SelectFusionMaterial(tp,tc,mg2,nil,chkf)
		local fop=ce:GetOperation()
		fop(ce,e,tp,tc,mat)
		tc:CompleteProcedure()
	end
end
