-- Replacement snippet for c232449539.lua:
function s.checkfilter(c)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_MONSTER) and c:IsLocation(LOCATION_DECK)
		and not c:IsPreviousLocation(LOCATION_DECK)
end

function s.fusfilter(c,e,tp,mg,chkf)
	return c:IsSetCard(SET_STAIN) and c:IsType(TYPE_FUSION)
		and c:CheckFusionMaterial(mg,nil,chkf)
		and Duel.GetLocationCountFromEx(tp,tp,nil,c)>0
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
	if #mat==0 or Duel.GetLocationCountFromEx(tp,tp,mat,tc)<=0 then return end
	local banmat=mat:Filter(function(c) return c:IsLocation(LOCATION_DECK) and c:IsControler(1-tp) end,nil)
	local gmat=mat:Clone()
	gmat:Sub(banmat)
	tc:SetMaterial(mat)
	if #gmat>0 then Duel.SendtoGrave(gmat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) end
	if #banmat>0 then Duel.Remove(banmat,POS_FACEUP,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) end
	gmat:DeleteGroup()
	Duel.BreakEffect()
	if Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)~=0 then
		tc:CompleteProcedure()
		s.registerreturn(e,tp,banmat)
	else
		banmat:DeleteGroup()
	end
	s.applylimit(e,tp)
end
