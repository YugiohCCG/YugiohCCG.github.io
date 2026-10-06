--Killamity Goldenrod
local s,id=GetID()
local SET_KILLAMITY=0xa120
local MSG_ID=132163199
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCondition(function(e,tp) return Duel.GetFieldGroupCount(tp,LOCATION_MZONE,0)==0 end)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.settg)
 e2:SetOperation(s.setop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetType(EFFECT_TYPE_IGNITION)
 e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e3:SetRange(LOCATION_GRAVE)
 e3:SetCountLimit(1,id+200)
 e3:SetTarget(s.attachtg)
 e3:SetOperation(s.attachop)
 c:RegisterEffect(e3)
end
s.listed_series={SET_KILLAMITY}
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND)
end
function s.spop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end
end
function s.setfilter(c)
 return c:IsSetCard(SET_KILLAMITY) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK,0,1,nil) end
end
function s.setop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
 local g=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 then Duel.SSet(tp,g) end
end
function s.xyzfilter(c)
 return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetRank()==12
end
function s.attachtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.xyzfilter(chkc) end
 if chk==0 then return Duel.IsExistingTarget(s.xyzfilter,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 Duel.SelectTarget(tp,s.xyzfilter,tp,LOCATION_MZONE,0,1,1,nil)
end
function s.attachop(e,tp)
 local c=e:GetHandler()
 local tc=Duel.GetFirstTarget()
 if not c:IsRelateToEffect(e) or not tc or not tc:IsRelateToEffect(e) or not tc:IsControler(tp) or not s.xyzfilter(tc) or tc:IsImmuneToEffect(e) then return end
 Duel.Overlay(tc,Group.FromCards(c))
 if not c:IsLocation(LOCATION_OVERLAY) or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then return end
 local grant=Effect.CreateEffect(c)
 grant:SetDescription(aux.Stringid(MSG_ID,4))
 grant:SetCategory(CATEGORY_SPECIAL_SUMMON)
 grant:SetType(EFFECT_TYPE_IGNITION)
 grant:SetRange(LOCATION_MZONE)
 grant:SetCost(s.grantcost)
 grant:SetTarget(s.granttg)
 grant:SetOperation(s.grantop)
 grant:SetReset(RESET_EVENT+RESETS_STANDARD)
 tc:RegisterEffect(grant,true)
end
function s.deckfilter(c,e,tp,attribute)
 return c:IsType(TYPE_MONSTER) and c:IsSetCard(SET_KILLAMITY) and c:GetAttribute()~=attribute and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.matfilter(c,e,tp)
 return c:IsType(TYPE_MONSTER) and c:IsAbleToGraveAsCost() and Duel.IsExistingMatchingCard(s.deckfilter,tp,LOCATION_DECK,0,1,nil,e,tp,c:GetAttribute())
end
function s.grantcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local g=e:GetHandler():GetOverlayGroup():Filter(s.matfilter,nil,e,tp)
 if chk==0 then return #g>0 end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVEXYZ)
 local sg=g:Select(tp,1,1,nil)
 e:SetLabel(sg:GetFirst():GetAttribute())
 Duel.SendtoGrave(sg,REASON_COST)
end
function s.granttg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.grantop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.deckfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp,e:GetLabel())
 if #g>0 then Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP) end
end
