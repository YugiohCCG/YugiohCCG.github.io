--Aquamarine Sand Clypeasteria
--Omega reference: c100233201 (select Fusion materials from a supplied group).
local s,id=GetID()
local SET_AQUAMARINE=0x0f3c
local MSG_ID=132636664
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.handcon)
 e1:SetTarget(s.handtg)
 e1:SetOperation(s.handop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON+CATEGORY_TOGRAVE)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.fustg)
 e2:SetOperation(s.fusop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCode(EVENT_REMOVE)
 e3:SetCountLimit(1,id+200)
 e3:SetCondition(s.gybancon)
 e3:SetCost(s.gybancost)
 e3:SetTarget(s.gybantg)
 e3:SetOperation(s.gybanop)
 c:RegisterEffect(e3)
end
function s.aquafilter(c)
 return c:IsFaceup() and c:IsSetCard(SET_AQUAMARINE)
end
function s.handcon(e,tp)
 local ph=Duel.GetCurrentPhase()
 return (ph==PHASE_MAIN1 or ph==PHASE_MAIN2)
  and Duel.IsExistingMatchingCard(s.aquafilter,tp,LOCATION_MZONE,0,1,nil)
end
function s.handtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
end
function s.handop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
 end
end
function s.matfilter(c,e)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsCanBeFusionMaterial()
  and c:IsAbleToGrave() and not c:IsImmuneToEffect(e)
end
function s.fusfilter(c,e,tp,mg)
 return c:IsType(TYPE_FUSION) and c:IsSetCard(SET_AQUAMARINE)
  and Duel.GetLocationCountFromEx(tp,tp,nil,c)>0
  and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false)
  and c:CheckFusionMaterial(mg,nil,tp)
end
function s.fustg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then
  local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_REMOVED,0,nil,e)
  return Duel.IsExistingMatchingCard(s.fusfilter,tp,LOCATION_EXTRA,0,1,nil,e,tp,mg)
 end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_EXTRA)
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_REMOVED)
end
function s.fusop(e,tp)
 local mg=Duel.GetMatchingGroup(s.matfilter,tp,LOCATION_REMOVED,0,nil,e)
 local sg=Duel.GetMatchingGroup(s.fusfilter,tp,LOCATION_EXTRA,0,nil,e,tp,mg)
 if #sg==0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local fc=sg:Select(tp,1,1,nil):GetFirst()
 local mat=Duel.SelectFusionMaterial(tp,fc,mg,nil,tp)
 if #mat==0 then return end
 fc:SetMaterial(mat)
 if Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)~=#mat then return end
 Duel.BreakEffect()
 if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then
  fc:CompleteProcedure()
 end
end
function s.gybancon(e)
 return e:GetHandler():IsPreviousLocation(LOCATION_GRAVE)
end
function s.costfilter(c,handler)
 return c:IsSetCard(SET_AQUAMARINE) and c:IsAbleToRemoveAsCost() and c~=handler
end
function s.gybancost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_GRAVE,0,1,nil,e:GetHandler()) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_GRAVE,0,1,1,nil,e:GetHandler())
 Duel.Remove(g,POS_FACEUP,REASON_COST)
end
function s.gybantg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_REMOVED)
end
function s.gybanop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then
  Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)
 end
end
