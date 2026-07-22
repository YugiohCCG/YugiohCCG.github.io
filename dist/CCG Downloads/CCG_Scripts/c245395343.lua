local s,id=GetID()
local STRING_ID=133395343
local SET_GALACTICA=0x9c9
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c) e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON) e1:SetType(EFFECT_TYPE_ACTIVATE) e1:SetCode(EVENT_FREE_CHAIN) e1:SetCountLimit(1) e1:SetCost(s.cost) e1:SetTarget(s.fustg) e1:SetOperation(s.fusop) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetDescription(aux.Stringid(STRING_ID,1)) e2:SetCategory(CATEGORY_TOHAND) e2:SetType(EFFECT_TYPE_IGNITION) e2:SetRange(LOCATION_REMOVED) e2:SetCountLimit(1,id) e2:SetCondition(s.thcon) e2:SetTarget(s.thtg) e2:SetOperation(s.thop) c:RegisterEffect(e2)
	local e3=e2:Clone() e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e3:SetCode(EVENT_REMOVE) e3:SetCondition(s.rmcon) c:RegisterEffect(e3)
end
function s.costfilter(c) return c:IsFaceup() and c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemoveAsCost() end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end if Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_MZONE,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE) local tc=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_MZONE,0,1,1,nil):GetFirst() Duel.Remove(tc,POS_FACEUP,REASON_COST) end end
function s.matfilter(c) return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsCanBeFusionMaterial() and c:IsAbleToDeck() end
function s.fusfilter(c,e,tp,mg) return c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_FUSION) and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false,POS_FACEUP_ATTACK) and c:CheckFusionMaterial(mg,nil,tp) end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk) local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_REMOVED,0,nil) if chk==0 then return Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA) end
function s.fusop(e,tp)
	local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_REMOVED,0,nil) local fg=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg) if #fg==0 then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON) local fc=fg:Select(tp,1,1,nil):GetFirst() local mat=Duel.SelectFusionMaterial(tp,fc,mg,nil,tp) if not mat or #mat==0 then return end
	fc:SetMaterial(mat) if Duel.SendtoDeck(mat,nil,SEQ_DECKSHUFFLE,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)==#mat and Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP_ATTACK)>0 then fc:CompleteProcedure() end
end
function s.thcon(e) return Duel.IsMainPhase() end
function s.rmcon(e) return Duel.IsBattlePhase() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return aux.NecroValleyFilter(Card.IsAbleToHand)(e:GetHandler()) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,e:GetHandler(),1,tp,LOCATION_REMOVED) end
function s.thop(e,tp) local c=e:GetHandler() if c:IsRelateToEffect(e) and Duel.SendtoHand(c,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,c) end end
