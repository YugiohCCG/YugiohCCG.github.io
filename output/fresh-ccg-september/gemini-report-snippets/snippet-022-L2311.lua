-- Replacement snippet for c236473882.lua:
function s.btcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:GetFlagEffect(id)==0 end
	c:RegisterFlagEffect(id,RESET_PHASE+PHASE_DAMAGE,0,1)
end

function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end

function s.spfilter(c,e,tp,lc)
	return c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_LINK) and c:IsLink(2)
		and Duel.GetLocationCountFromEx(tp,tp,lc,c)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end

function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return (e:GetHandler():IsAbleToDeck() or e:GetHandler():IsAbleToRemove())
		and Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,e:GetHandler()) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
end

function s.spop(e,tp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) then return end
	local op=s.leavechoice(c,tp)
	if op<0 then return end
	local ok
	if op==0 then
		ok=Duel.SendtoDeck(c,nil,2,REASON_EFFECT)>0
	else
		ok=Duel.Remove(c,POS_FACEUP,REASON_EFFECT)>0
	end
	if not ok then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp,nil):GetFirst()
	if sc then
		Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)
	end
end
