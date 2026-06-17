local s,id=GetID()
local SET_GLITCHLING=0x9894
function s.initial_effect(c)
	c:EnableReviveLimit()
	aux.EnablePendulumAttribute(c)
	--Special Summon limit
	local e0=Effect.CreateEffect(c)
	e0:SetType(EFFECT_TYPE_SINGLE)
	e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
	e0:SetCode(EFFECT_SPSUMMON_CONDITION)
	e0:SetValue(aux.ritlimit)
	c:RegisterEffect(e0)
	--Pendulum Effect: Ritual Summon using Cyberse monsters you control
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetRange(LOCATION_PZONE)
	e1:SetCountLimit(1,id)
	e1:SetCondition(s.pzcon)
	e1:SetTarget(s.pzrittg)
	e1:SetOperation(s.pzritop)
	c:RegisterEffect(e1)
	--Reveal this card and another monster; add 1 "Glitchling" Spell/Trap
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_HAND)
	e2:SetCountLimit(1,id+100)
	e2:SetCost(s.thcost)
	e2:SetTarget(s.thtg)
	e2:SetOperation(s.thop)
	c:RegisterEffect(e2)
	--If Special Summoned: Ritual Summon
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(id,2))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOGRAVE)
	e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCountLimit(1,id+200)
	e3:SetTarget(s.rittg)
	e3:SetOperation(s.ritop)
	c:RegisterEffect(e3)
end
s.listed_series={SET_GLITCHLING}
function s.splimit(e,c)
	return not (c:IsLocation(LOCATION_EXTRA)
		or c:IsSetCard(SET_GLITCHLING)
		or (c:IsRace(RACE_CYBERSE) and (c:IsType(TYPE_RITUAL) or c:IsType(TYPE_NORMAL))))
end
function s.register_lock(e,tp)
	local e1=Effect.CreateEffect(e:GetHandler())
	e1:SetType(EFFECT_TYPE_FIELD)
	e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
	e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
	e1:SetTargetRange(1,0)
	e1:SetTarget(s.splimit)
	e1:SetReset(RESET_PHASE+PHASE_END)
	Duel.RegisterEffect(e1,tp)
end
function s.otherpzone(c,pc)
	return c:IsFaceup() and c~=pc and c:IsRace(RACE_CYBERSE) and c:IsType(TYPE_PENDULUM)
end
function s.pzcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(s.otherpzone,tp,LOCATION_PZONE,0,1,nil,e:GetHandler())
end
function s.scalelimits(tp)
	local lpz=Duel.GetFieldCard(tp,LOCATION_PZONE,0)
	local rpz=Duel.GetFieldCard(tp,LOCATION_PZONE,1)
	if not (lpz and rpz) then return nil,nil end
	local lscale=lpz:GetLeftScale()
	local rscale=rpz:GetRightScale()
	if lscale>rscale then lscale,rscale=rscale,lscale end
	return lscale,rscale
end
function s.pzritfilter(c,e,tp,lscale,rscale)
	return c:IsRace(RACE_CYBERSE) and c:IsType(TYPE_RITUAL) and c:GetLevel()>lscale and c:GetLevel()<rscale
		and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)
end
function s.pzmatfilter(c,rc)
	return c:IsFaceup() and c:IsRace(RACE_CYBERSE) and c:GetLevel()>0 and c:IsCanBeRitualMaterial(rc)
end
function s.pzexcheck(sg,tp,mat)
	local exct=sg:FilterCount(Card.IsLocation,nil,LOCATION_EXTRA)
	if exct==0 then return true end
	return Duel.GetLocationCountFromEx(tp,tp,mat,TYPE_RITUAL)>=exct
end
function s.pzmatcheck(g,lv,ct,tp,sg)
	return g:GetSum(Card.GetLevel)>=lv and Duel.GetMZoneCount(tp,g)>=ct and s.pzexcheck(sg,tp,g)
end
function s.pzritcheck(g,e,tp,mg)
	local lv=g:GetSum(Card.GetLevel)
	return #g>0 and mg:CheckSubGroup(s.pzmatcheck,1,#mg,lv,#g,tp,g)
end
function s.pzrittg(e,tp,eg,ep,ev,re,r,rp,chk)
	local lscale,rscale=s.scalelimits(tp)
	if chk==0 then
		if not lscale then return false end
		local rg=Duel.GetMatchingGroup(s.pzritfilter,tp,LOCATION_HAND+LOCATION_EXTRA,0,nil,e,tp,lscale,rscale)
		local mg=Duel.GetMatchingGroup(s.pzmatfilter,tp,LOCATION_MZONE,0,nil,nil)
		return #rg>0 and #mg>0 and rg:CheckSubGroup(s.pzritcheck,1,#rg,e,tp,mg)
	end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_EXTRA)
end
function s.pzritop(e,tp,eg,ep,ev,re,r,rp)
	local lscale,rscale=s.scalelimits(tp)
	if not lscale then return end
	local rg=Duel.GetMatchingGroup(s.pzritfilter,tp,LOCATION_HAND+LOCATION_EXTRA,0,nil,e,tp,lscale,rscale)
	local mg=Duel.GetMatchingGroup(s.pzmatfilter,tp,LOCATION_MZONE,0,nil,nil)
	if #rg==0 or #mg==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local sg=rg:SelectSubGroup(tp,s.pzritcheck,false,1,#rg,e,tp,mg)
	if not sg then return end
	local lv=sg:GetSum(Card.GetLevel)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
	local mat=mg:SelectSubGroup(tp,s.pzmatcheck,true,1,#mg,lv,#sg,tp,sg)
	if not mat then return end
	for tc in aux.Next(sg) do
		tc:SetMaterial(mat)
	end
	Duel.ReleaseRitualMaterial(mat)
	Duel.BreakEffect()
	for tc in aux.Next(sg) do
		if Duel.SpecialSummonStep(tc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP) then
			tc:CompleteProcedure()
		end
	end
	Duel.SpecialSummonComplete()
end
function s.revealfilter(c)
	return c:IsRace(RACE_CYBERSE) and (c:IsType(TYPE_RITUAL) or c:IsType(TYPE_NORMAL))
end
function s.thcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return not c:IsPublic()
		and Duel.IsExistingMatchingCard(s.revealfilter,tp,LOCATION_HAND,0,1,c) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local g=Duel.SelectMatchingCard(tp,s.revealfilter,tp,LOCATION_HAND,0,1,1,c)
	g:AddCard(c)
	Duel.ConfirmCards(1-tp,g)
	Duel.ShuffleHand(tp)
end
function s.thfilter(c)
	return c:IsSetCard(SET_GLITCHLING) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
	s.register_lock(e,tp)
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
	if #g>0 then
		Duel.SendtoHand(g,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,g)
	end
end
function s.ritfilter(c,e,tp)
	return c:IsRace(RACE_CYBERSE) and c:IsType(TYPE_RITUAL)
		and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup())
		and (not c:IsLocation(LOCATION_EXTRA) or Duel.GetLocationCountFromEx(tp,tp,nil,c)>0)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)
end
function s.ritmatfilter(c,rc)
	return c:IsRace(RACE_CYBERSE) and c:GetLevel()>0 and c:IsAbleToGrave() and c:IsCanBeRitualMaterial(rc)
end
function s.ritcheck(g,lv)
	return g:GetSum(Card.GetLevel)>=lv
end
function s.canritual(c,e,tp)
	if not s.ritfilter(c,e,tp) then return false end
	local mg=Duel.GetMatchingGroup(s.ritmatfilter,tp,LOCATION_HAND+LOCATION_DECK,0,c,c)
	mg:RemoveCard(c)
	return #mg>0 and mg:CheckSubGroup(s.ritcheck,1,#mg,c:GetLevel())
end
function s.rittg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsExistingMatchingCard(s.ritfilter,tp,LOCATION_HAND+LOCATION_EXTRA,0,1,nil,e,tp)
		and Duel.IsExistingMatchingCard(s.canritual,tp,LOCATION_HAND+LOCATION_EXTRA,0,1,nil,e,tp) end
	s.register_lock(e,tp)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_EXTRA)
	Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK)
end
function s.ritop(e,tp,eg,ep,ev,re,r,rp)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	::cancel::
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local tg=Duel.SelectMatchingCard(tp,s.canritual,tp,LOCATION_HAND+LOCATION_EXTRA,0,1,1,nil,e,tp)
	local rc=tg:GetFirst()
	if not rc then return end
	local mg=Duel.GetMatchingGroup(s.ritmatfilter,tp,LOCATION_HAND+LOCATION_DECK,0,rc,rc)
	mg:RemoveCard(rc)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
	local mat=mg:SelectSubGroup(tp,s.ritcheck,true,1,#mg,rc:GetLevel())
	if not mat then goto cancel end
	if rc:IsLocation(LOCATION_EXTRA) and Duel.GetLocationCountFromEx(tp,tp,nil,rc)<=0 then return end
	rc:SetMaterial(mat)
	local handmat=mat:Filter(Card.IsLocation,nil,LOCATION_HAND)
	local deckmat=mat:Filter(Card.IsLocation,nil,LOCATION_DECK)
	if #handmat>0 then Duel.ReleaseRitualMaterial(handmat) end
	if #deckmat>0 then Duel.SendtoGrave(deckmat,REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL) end
	Duel.BreakEffect()
	if Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0 then
		rc:CompleteProcedure()
	end
end
