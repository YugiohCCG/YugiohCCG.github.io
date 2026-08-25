--Dinomorphia Provocation
--Omega references: Dinomorphia Domain (c26631975), Dinomorphia Frenzy (c78420796)
local s,id=GetID(); local SET_DINOMORPHIA=0x173; local MSG_ID=133826112
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON); e1:SetType(EFFECT_TYPE_ACTIVATE); e1:SetCode(EVENT_FREE_CHAIN); e1:SetCountLimit(1,id); e1:SetCost(s.lpcost); e1:SetTarget(s.tg); e1:SetOperation(s.op); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_TOGRAVE); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetCountLimit(1,id+100); e2:SetCost(s.gycost); e2:SetTarget(s.gytg); e2:SetOperation(s.gyop); c:RegisterEffect(e2)
end
function s.lpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)) end
function s.tf(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsTrap() and c:IsSSetable() end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.tf,tp,LOCATION_DECK,0,1,nil) end end
function s.op(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET); local g=Duel.SelectMatchingCard(tp,s.tf,tp,LOCATION_DECK,0,1,1,nil); if #g==0 or Duel.SSet(tp,g)==0 then return end local mg=Duel.GetFusionMaterial(tp); local fg=Duel.GetMatchingGroup(function(c,e,tp,mg) return c:IsSetCard(SET_DINOMORPHIA) and c:IsType(TYPE_FUSION) and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false) and c:CheckFusionMaterial(mg) end,tp,LOCATION_EXTRA,0,nil,e,tp,mg); if #fg>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local fc=fg:Select(tp,1,1,nil):GetFirst(); local mat=Duel.SelectFusionMaterial(tp,fc,mg,nil,tp); fc:SetMaterial(mat); Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION); Duel.BreakEffect(); Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP); fc:CompleteProcedure() end end
function s.gycost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsAbleToRemoveAsCost() end Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_COST); Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)) end
function s.df(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsAbleToGrave() end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.df,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK) end
function s.gyop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local g=Duel.SelectMatchingCard(tp,s.df,tp,LOCATION_DECK,0,1,1,nil); Duel.SendtoGrave(g,REASON_EFFECT) end
