local s,id=GetID()
local STRING_ID=133127930
local SET_GALACTICA=0x9c9
function s.initial_effect(c)
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_SINGLE) e0:SetCode(EFFECT_ADD_SETCODE) e0:SetValue(SET_GALACTICA) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH) e1:SetType(EFFECT_TYPE_ACTIVATE) e1:SetCode(EVENT_FREE_CHAIN) e1:SetCountLimit(1,id) e1:SetTarget(s.thtg) e1:SetOperation(s.thop) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1)) e2:SetCategory(CATEGORY_SPECIAL_SUMMON) e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O) e2:SetCode(EVENT_SUMMON_SUCCESS) e2:SetRange(LOCATION_GRAVE) e2:SetProperty(EFFECT_FLAG_DELAY) e2:SetCountLimit(1,id+100) e2:SetCondition(s.lkcon) e2:SetCost(aux.bfgcost) e2:SetTarget(s.lktg) e2:SetOperation(s.lkop) c:RegisterEffect(e2)
	local e3=e2:Clone() e3:SetCode(EVENT_SPSUMMON_SUCCESS) c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c)
	e4:SetDescription(aux.Stringid(STRING_ID,2)) e4:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON) e4:SetType(EFFECT_TYPE_IGNITION) e4:SetRange(LOCATION_GRAVE) e4:SetCountLimit(1,id+200) e4:SetCost(s.dcost) e4:SetOperation(s.delop) c:RegisterEffect(e4)
end
function s.thfilter(c) return c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND) local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil):GetFirst() if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,tc) end end
function s.evfilter(c,tp) return c:IsSummonPlayer(tp) and c:IsSetCard(SET_GALACTICA) end
function s.lkcon(e,tp,eg) return eg:IsExists(s.evfilter,1,nil,tp) end
function s.lkfilter(c) return c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_LINK) and c:IsLinkSummonable() end
function s.lktg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.lkfilter,tp,LOCATION_EXTRA,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA) end
function s.lkop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON) local lc=Duel.SelectMatchingCard(tp,s.lkfilter,tp,LOCATION_EXTRA,0,1,1,nil):GetFirst() if lc then Duel.LinkSummon(tp,lc,nil) end end
function s.othercost(c,ec) return c~=ec and c:IsAbleToRemoveAsCost() end
function s.selfcost(c) return c:IsAbleToRemoveAsCost() end
function s.dcost(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return aux.NecroValleyFilter(s.selfcost)(c) and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.othercost),tp,LOCATION_GRAVE,0,1,c,c) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE) local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.othercost),tp,LOCATION_GRAVE,0,1,1,c,c):GetFirst()
	Duel.Remove(Group.FromCards(c,tc),POS_FACEUP,REASON_COST)
end
function s.delspfilter(c,e,tp) return c:IsFaceupEx() and c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_ATTACK) end
function s.delop(e,tp)
	local ge=Effect.CreateEffect(e:GetHandler()) ge:SetDescription(aux.Stringid(STRING_ID,3)) ge:SetCategory(CATEGORY_SPECIAL_SUMMON) ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O) ge:SetCode(EVENT_PHASE+PHASE_BATTLE_START) ge:SetCountLimit(1) ge:SetTarget(s.delspgt) ge:SetOperation(s.delspop) ge:SetReset(RESET_PHASE+PHASE_BATTLE_START) Duel.RegisterEffect(ge,tp)
end
function s.delspgt(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.delspfilter,tp,LOCATION_HAND+LOCATION_REMOVED,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_REMOVED) end
function s.delspop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON) local tc=Duel.SelectMatchingCard(tp,s.delspfilter,tp,LOCATION_HAND+LOCATION_REMOVED,0,1,1,nil,e,tp):GetFirst() if tc then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK) end end
