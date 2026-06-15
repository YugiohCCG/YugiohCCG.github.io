--SACRED FEATHER OF NEPHTHYS
local s,id=GetID()
local SET_NEPHTHYS=0x11f
local CARD_CONDUCTOR_NEPHTHYS=84541257
local CARD_DEVOTEE_NEPHTHYS=88176533
local CARD_PRIESTESS_NEPHTHYS=211964444
function s.initial_effect(c)
	--Activate and Ritual Summon
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_RELEASE+CATEGORY_TOGRAVE)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetTarget(s.rittg)
	e1:SetOperation(s.ritop)
	c:RegisterEffect(e1)
	--If a card is destroyed: banish this card; destroy 1 card you control, then place 1 Trap
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_DESTROY)
	e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e2:SetCode(EVENT_DESTROYED)
	e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DELAY)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetCountLimit(1,id)
	e2:SetCondition(s.plcon)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.pltg)
	e2:SetOperation(s.plop)
	c:RegisterEffect(e2)
end
s.listed_series={SET_NEPHTHYS}
s.listed_names={CARD_CONDUCTOR_NEPHTHYS,CARD_DEVOTEE_NEPHTHYS,CARD_PRIESTESS_NEPHTHYS}
function s.ritfilter(c,e,tp,mg,deckmg)
	if not (c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_RITUAL)
		and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_RITUAL,tp,false,true)) then return false end
	local lv=c:GetLevel()
	local rmg=s.getmatgroup(mg,c,tp)
	local rdmg=s.getdeckmatgroup(deckmg,c,tp)
	return (rmg:GetCount()>0 and rmg:CheckSubGroup(s.matcheck,1,lv,lv,tp))
		or (Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)==0 and rdmg:GetCount()>0 and Duel.GetLocationCount(tp,LOCATION_MZONE)>0)
end
function s.matfilter(c,rc)
	return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:GetLevel()>0
		and (rc==nil or c:IsCanBeRitualMaterial(rc))
end
function s.deckmatfilter(c,rc)
	return s.matfilter(c,rc) and c:IsAbleToGrave()
end
function s.getmatgroup(mg,rc,tp)
	local res=mg:Filter(s.matfilter,nil,rc)
	if rc.mat_filter then
		res=res:Filter(rc.mat_filter,rc,tp)
	else
		res:RemoveCard(rc)
	end
	return res
end
function s.getdeckmatgroup(mg,rc,tp)
	local res=mg:Filter(s.deckmatfilter,nil,rc)
	if rc.mat_filter then
		res=res:Filter(rc.mat_filter,rc,tp)
	end
	return res
end
function s.matcheck(g,lv,tp)
	return g:GetSum(Card.GetLevel)>=lv and Duel.GetMZoneCount(tp,g)>0
end
function s.rittg(e,tp,eg,ep,ev,re,r,rp,chk)
	local mg=Duel.GetRitualMaterial(tp):Filter(s.matfilter,nil,nil)
	local deckmg=Duel.GetMatchingGroup(s.deckmatfilter,tp,LOCATION_DECK,0,nil,nil)
	if chk==0 then return Duel.IsExistingMatchingCard(s.ritfilter,tp,LOCATION_HAND,0,1,nil,e,tp,mg,deckmg) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND)
	Duel.SetOperationInfo(0,CATEGORY_RELEASE,nil,1,tp,LOCATION_HAND+LOCATION_MZONE)
end
function s.ritop(e,tp,eg,ep,ev,re,r,rp)
	local allmg=Duel.GetRitualMaterial(tp)
	local deckall=Duel.GetMatchingGroup(s.deckmatfilter,tp,LOCATION_DECK,0,nil,nil)
	if not Duel.IsExistingMatchingCard(s.ritfilter,tp,LOCATION_HAND,0,1,nil,e,tp,allmg,deckall) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
	local rc=Duel.SelectMatchingCard(tp,s.ritfilter,tp,LOCATION_HAND,0,1,1,nil,e,tp,allmg,deckall):GetFirst()
	if not rc then return end
	local lv=rc:GetLevel()
	local mg=s.getmatgroup(allmg,rc,tp)
	local deckmg=s.getdeckmatgroup(deckall,rc,tp)
	local cannormal=mg:GetCount()>0 and mg:CheckSubGroup(s.matcheck,1,lv,lv,tp)
	local candeck=Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)==0 and deckmg:GetCount()>0 and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
	if not (cannormal or candeck) then return end
	local useddeck=false
	if cannormal and candeck then
		useddeck=Duel.SelectOption(tp,aux.Stringid(id,2),aux.Stringid(id,3))==1
	elseif candeck then
		useddeck=true
	end
	local mat=nil
	if useddeck then
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
		mat=deckmg:Select(tp,1,1,nil)
		rc:SetMaterial(mat)
		if Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL)==0 then return end
	else
		Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
		mat=mg:SelectSubGroup(tp,s.matcheck,true,1,lv,lv,tp)
		if not mat or #mat==0 then return end
		rc:SetMaterial(mat)
		Duel.ReleaseRitualMaterial(mat)
	end
	Duel.BreakEffect()
	if rc:IsRelateToEffect(e) and Duel.SpecialSummon(rc,SUMMON_TYPE_RITUAL,tp,tp,false,true,POS_FACEUP)>0 then
		rc:CompleteProcedure()
	end
end
function s.ctrlfilter(c)
	return c:IsFaceup() and c:IsCode(CARD_CONDUCTOR_NEPHTHYS,CARD_DEVOTEE_NEPHTHYS,CARD_PRIESTESS_NEPHTHYS)
end
function s.plcon(e,tp,eg,ep,ev,re,r,rp)
	return Duel.IsExistingMatchingCard(s.ctrlfilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.pldesfilter(c,needszone)
	return c:IsDestructable() and (not needszone or c:IsLocation(LOCATION_SZONE))
end
function s.pltg(e,tp,eg,ep,ev,re,r,rp,chk)
	local needszone=Duel.GetLocationCount(tp,LOCATION_SZONE)<=0
	if chk==0 then return Duel.IsExistingMatchingCard(s.pldesfilter,tp,LOCATION_ONFIELD,0,1,nil,needszone)
		and Duel.IsExistingMatchingCard(s.trapfilter,tp,LOCATION_DECK,0,1,nil) end
	Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD)
end
function s.trapfilter(c)
	return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_TRAP) and c:IsType(TYPE_CONTINUOUS) and not c:IsForbidden()
end
function s.plop(e,tp,eg,ep,ev,re,r,rp)
	local needszone=Duel.GetLocationCount(tp,LOCATION_SZONE)<=0
	if not Duel.IsExistingMatchingCard(s.pldesfilter,tp,LOCATION_ONFIELD,0,1,nil,needszone) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
	local dg=Duel.SelectMatchingCard(tp,s.pldesfilter,tp,LOCATION_ONFIELD,0,1,1,nil,needszone)
	if #dg==0 or Duel.Destroy(dg,REASON_EFFECT)==0 then return end
	if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 or not Duel.IsExistingMatchingCard(s.trapfilter,tp,LOCATION_DECK,0,1,nil) then return end
	Duel.BreakEffect()
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
	local tc=Duel.SelectMatchingCard(tp,s.trapfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
	if tc then
		Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true)
	end
end
