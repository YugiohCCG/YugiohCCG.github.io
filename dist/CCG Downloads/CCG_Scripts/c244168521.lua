--Heavy-Armoured Ballista Bahariasaurus
--Omega references: c100211098 (constrained Link materials), c46247282 (disabled zones), c26913989 (Summon to opponent).
local s,id=GetID()
local MSG_ID=132168521
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddLinkProcedure(c,nil,2,4,s.lcheck)
 local e0=Effect.CreateEffect(c)
 e0:SetType(EFFECT_TYPE_FIELD)
 e0:SetCode(EFFECT_DISABLE_FIELD)
 e0:SetRange(LOCATION_MZONE)
 e0:SetValue(s.disval)
 c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_DESTROY)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_DESTROYED)
 e2:SetCountLimit(1,id+100)
 e2:SetCost(s.revcost)
 e2:SetTarget(s.revtg)
 e2:SetOperation(s.revop)
 c:RegisterEffect(e2)
end
function s.matfilter(c)
 return c:IsLinkAttribute(ATTRIBUTE_FIRE) or c:IsLinkRace(RACE_DINOSAUR)
end
function s.lcheck(g)
 return g:IsExists(s.matfilter,1,nil)
end
function s.disval(e)
 return bit.band(e:GetHandler():GetLinkedZone(),0x60)
end
function s.dinofilter(c,e,tp)
 return c:IsRace(RACE_DINOSAUR) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,1-tp)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_GRAVE) and chkc:IsControler(tp)
  and s.dinofilter(chkc,e,tp) end
 if chk==0 then return Duel.GetLocationCount(1-tp,LOCATION_MZONE)>0
  and Duel.IsExistingTarget(aux.NecroValleyFilter(s.dinofilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.dinofilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,g,1,tp,LOCATION_GRAVE)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,0,LOCATION_ONFIELD)
end
function s.adjfilter(c,seq)
 return c:IsLocation(LOCATION_MZONE) and c:GetSequence()<5
  and math.abs(c:GetSequence()-seq)==1
end
function s.spop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) or not s.dinofilter(tc,e,tp)
  or Duel.GetLocationCount(1-tp,LOCATION_MZONE)<=0 then return end
 if Duel.SpecialSummon(tc,0,tp,1-tp,false,false,POS_FACEUP)==0 then return end
 if not tc:IsLocation(LOCATION_MZONE) or not tc:IsControler(1-tp) then return end
 local g=Duel.GetMatchingGroup(s.adjfilter,tp,0,LOCATION_MZONE,tc,tc:GetSequence())
 g:AddCard(tc)
 Duel.Destroy(g,REASON_EFFECT)
end
function s.spellfilter(c)
 return c:IsType(TYPE_SPELL) and c:IsAbleToGraveAsCost()
end
function s.revcost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.spellfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE)
 local g=Duel.SelectMatchingCard(tp,s.spellfilter,tp,LOCATION_HAND+LOCATION_ONFIELD,0,1,1,nil)
 Duel.SendtoGrave(g,REASON_COST)
end
function s.revtg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,c:GetLocation())
end
function s.revop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local redirect=Effect.CreateEffect(c)
 redirect:SetType(EFFECT_TYPE_SINGLE)
 redirect:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
 redirect:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 redirect:SetValue(LOCATION_REMOVED)
 redirect:SetReset(RESET_EVENT+RESETS_STANDARD)
 c:RegisterEffect(redirect)
end
