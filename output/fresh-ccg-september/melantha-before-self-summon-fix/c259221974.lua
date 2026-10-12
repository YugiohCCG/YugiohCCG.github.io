--Melantha, Keeper of Lamentations
--Omega references: Battlewasp - Dart the Hunter (c91283212), Artifact Scythe (c20292186)
local s,id=GetID(); local STRING_ID=133221974
function s.initial_effect(c)
 if not s.global_check then s.global_check=true; local ge=Effect.CreateEffect(c); ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); ge:SetCode(EVENT_SPSUMMON_SUCCESS); ge:SetOperation(s.exmark); Duel.RegisterEffect(ge,0) end
 c:EnableReviveLimit(); local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SPSUMMON_CONDITION); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetValue(function(e,se) return se and se:GetHandler()==e:GetHandler() end); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_SINGLE); e1:SetCode(EFFECT_INDESTRUCTABLE_BATTLE); e1:SetValue(1); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD); e2:SetCode(EFFECT_INDESTRUCTABLE_BATTLE); e2:SetRange(LOCATION_MZONE); e2:SetTargetRange(0,LOCATION_MZONE); e2:SetTarget(function(e,c) return c==e:GetHandler():GetBattleTarget() end); e2:SetValue(1); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,0)); e3:SetCategory(CATEGORY_SPECIAL_SUMMON); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND); e3:SetCountLimit(1,id); e3:SetCondition(s.spcon); e3:SetTarget(s.sptg); e3:SetOperation(s.spop); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e4:SetCode(EVENT_SPSUMMON_SUCCESS); e4:SetRange(LOCATION_MZONE); e4:SetCondition(s.taxcon); e4:SetOperation(s.taxop); c:RegisterEffect(e4)
end
function s.exmark(e,tp,eg) for p=0,1 do if eg:IsExists(function(c,p) return c:IsControler(p) and c:IsPreviousLocation(LOCATION_EXTRA) end,1,nil,p) then Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1) end end end
function s.spcon(e,tp) return Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)==0 and Duel.GetFlagEffect(1-tp,id)>0 end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.spop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end
function s.taxcon(e,tp,eg) return eg:IsExists(function(c,p) return c:IsControler(p) and c:IsPreviousLocation(LOCATION_EXTRA) end,1,nil,1-tp) end
function s.taxop(e,tp,eg) local p=1-tp; local sg=eg:Filter(function(c,p) return c:IsControler(p) and c:IsPreviousLocation(LOCATION_EXTRA) end,nil,p); local can_shuffle=Duel.IsExistingMatchingCard(Card.IsAbleToDeck,p,LOCATION_HAND,0,1,nil); local op=can_shuffle and Duel.SelectOption(p,aux.Stringid(STRING_ID,1),aux.Stringid(STRING_ID,2)) or 1; if op==0 then Duel.Hint(HINT_SELECTMSG,p,HINTMSG_TODECK); local g=Duel.SelectMatchingCard(p,Card.IsAbleToDeck,p,LOCATION_HAND,0,1,1,nil); Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) else Duel.SendtoGrave(sg,REASON_RULE) end end
