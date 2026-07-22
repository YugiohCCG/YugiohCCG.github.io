local s,id=GetID()
local STRING_ID=132005703
local SET_GALACTICA=0x9c9
function s.initial_effect(c)
	aux.AddLinkProcedure(c,nil,2,2,s.lcheck)
	c:EnableReviveLimit()
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_FIELD) e0:SetCode(EFFECT_AVOID_BATTLE_DAMAGE) e0:SetProperty(EFFECT_FLAG_PLAYER_TARGET) e0:SetRange(LOCATION_MZONE) e0:SetTargetRange(1,0) e0:SetValue(1) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c) e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_SSET) e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e1:SetCode(EVENT_SPSUMMON_SUCCESS) e1:SetProperty(EFFECT_FLAG_DELAY) e1:SetCountLimit(1,id) e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_LINK) end) e1:SetTarget(s.settg) e1:SetOperation(s.setop) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetDescription(aux.Stringid(STRING_ID,1)) e2:SetCategory(CATEGORY_TODECK+CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON) e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e2:SetCode(EVENT_BATTLE_DESTROYING) e2:SetCondition(aux.bdocon) e2:SetCost(s.btcost) e2:SetTarget(s.sptg) e2:SetOperation(s.spop) c:RegisterEffect(e2)
	local e3=e2:Clone() e3:SetCode(EVENT_BATTLE_DAMAGE) e3:SetCondition(function(e,tp,eg,ep) return ep==1-tp end) c:RegisterEffect(e3)
end
function s.lcheck(g) return g:IsExists(function(c) return c:IsSetCard(SET_GALACTICA) and c:IsLevel(2) end,1,nil) end
function s.setfilter(c) return c:IsFaceup() and c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable() end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_REMOVED,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_REMOVED) end
function s.setop(e,tp) if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET) local tc=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_REMOVED,0,1,1,nil):GetFirst() if tc then Duel.SSet(tp,tc) end end
function s.btcost(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler() if chk==0 then return c:GetFlagEffect(id)==0 end c:RegisterFlagEffect(id,RESET_PHASE+PHASE_DAMAGE,0,1) end
function s.spfilter(c,e,tp) return c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_LINK) and c:IsLink(2) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.spfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA) end
function s.spop(e,tp)
	local c=e:GetHandler() if not c:IsRelateToEffect(e) then return end
	local op=Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3)) local ok=op==0 and Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 or Duel.Remove(c,POS_FACEUP,REASON_EFFECT)>0
	if not ok then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON) local sc=Duel.SelectMatchingCard(tp,s.spfilter,tp,LOCATION_EXTRA,0,1,1,nil,e,tp):GetFirst() if sc then Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP) end
end
