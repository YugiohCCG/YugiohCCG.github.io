--Vylon Glome
--Omega reference: utility.lua UnionEquipFilter/UnionEquipLimit/SetUnionState.
local s,id=GetID()
local SET_VYLON=0x30
local MSG_ID=132274858
function s.initial_effect(c)
 local sub=Effect.CreateEffect(c)
 sub:SetType(EFFECT_TYPE_EQUIP)
 sub:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
 sub:SetCode(EFFECT_DESTROY_SUBSTITUTE)
 sub:SetValue(aux.UnionReplaceFilter)
 c:RegisterEffect(sub)
 local limit=Effect.CreateEffect(c)
 limit:SetType(EFFECT_TYPE_SINGLE)
 limit:SetCode(EFFECT_UNION_LIMIT)
 limit:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 limit:SetValue(aux.UnionEquipLimit(s.eqfilter))
 c:RegisterEffect(limit)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_EQUIP)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetRange(LOCATION_HAND+LOCATION_MZONE)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.eqtg)
 e1:SetOperation(s.eqop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_SZONE)
 e2:SetCountLimit(1,id)
 e2:SetTarget(s.sptg)
 e2:SetOperation(s.spop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e3:SetType(EFFECT_TYPE_IGNITION)
 e3:SetRange(LOCATION_SZONE)
 e3:SetCountLimit(1,id+100)
 e3:SetCondition(aux.IsUnionState)
 e3:SetTarget(s.thtg)
 e3:SetOperation(s.thop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,3))
 e4:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY)
 e4:SetCode(EVENT_TO_GRAVE)
 e4:SetCountLimit(1,id+200)
 e4:SetCondition(s.gycon)
 e4:SetTarget(s.gytg)
 e4:SetOperation(s.gyop)
 c:RegisterEffect(e4)
end
function s.eqfilter(c)
 return c:IsSetCard(SET_VYLON)
end
function s.eqtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 local filter=aux.UnionEquipFilter(s.eqfilter)
 if chkc then return chkc:IsLocation(LOCATION_MZONE) and filter(chkc,tp) end
 if chk==0 then return e:GetHandler():GetFlagEffect(FLAG_ID_UNION)==0
  and Duel.GetLocationCount(tp,LOCATION_SZONE)>0
  and Duel.IsExistingTarget(filter,tp,LOCATION_MZONE,0,1,e:GetHandler(),tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
 local g=Duel.SelectTarget(tp,filter,tp,LOCATION_MZONE,0,1,1,e:GetHandler(),tp)
 Duel.SetOperationInfo(0,CATEGORY_EQUIP,g,1,0,0)
 e:GetHandler():RegisterFlagEffect(FLAG_ID_UNION,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
end
function s.eqop(e,tp)
 local c=e:GetHandler()
 local tc=Duel.GetFirstTarget()
 local filter=aux.UnionEquipFilter(s.eqfilter)
 if not c:IsRelateToEffect(e) or not tc or not tc:IsRelateToEffect(e) or not filter(tc,tp) then return end
 if Duel.Equip(tp,c,tc) then aux.SetUnionState(c) end
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:GetFlagEffect(FLAG_ID_UNION)==0 and c:GetEquipTarget()
  and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,true,false,POS_FACEUP_DEFENSE) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
 c:RegisterFlagEffect(FLAG_ID_UNION,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)
end
function s.spop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,true,false,POS_FACEUP_DEFENSE) end
end
function s.thfilter(c)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end
end
function s.gycon(e)
 return e:GetHandler():IsPreviousLocation(LOCATION_SZONE)
  and e:GetHandler():IsPreviousPosition(POS_FACEUP)
end
function s.gyfilter(c,e,tp)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER) and not c:IsType(TYPE_TUNER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,1,e:GetHandler(),e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE)
end
function s.gyop(e,tp)
 if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,1,1,e:GetHandler(),e,tp)
 if #g>0 then Duel.SpecialSummon(g:GetFirst(),0,tp,tp,false,false,POS_FACEUP) end
end
