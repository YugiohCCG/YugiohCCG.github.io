--Terror Blossom from Afterroot
--Omega patterns: conditional material Levels, c85698115 opponent Summon, c100259001 Set activation.
local s,id=GetID()
local SET_RROOT=0xA110
local SET_AFTERROOT=0xA113
local MSG_ID=132272440
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsLevel,3),aux.NonTuner(nil),1,1)
 --Keep the real Level; offer Level 1 only when used for an rroot Summon.
 for _,code in ipairs({EFFECT_SYNCHRO_LEVEL,EFFECT_RITUAL_LEVEL}) do
  local lv=Effect.CreateEffect(c)
  lv:SetType(EFFECT_TYPE_SINGLE)
  lv:SetCode(code)
  lv:SetValue(s.materiallevel)
  c:RegisterEffect(lv)
 end
 local xl=Effect.CreateEffect(c)
 xl:SetType(EFFECT_TYPE_SINGLE)
 xl:SetCode(EFFECT_XYZ_LEVEL)
 xl:SetValue(s.xyzlevel)
 c:RegisterEffect(xl)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SSET)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.settg)
 e1:SetOperation(s.setop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_FREE_CHAIN)
 e2:SetRange(LOCATION_MZONE)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.swaptg)
 e2:SetOperation(s.swapop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_QUICK_O)
 e3:SetCode(EVENT_FREE_CHAIN)
 e3:SetRange(LOCATION_MZONE)
 e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e3:SetHintTiming(0,TIMING_ATTACK)
 e3:SetCondition(s.batcon)
 e3:SetTarget(s.battg)
 e3:SetOperation(s.batop)
 c:RegisterEffect(e3)
end
function s.materiallevel(e,c)
 local lv=e:GetHandler():GetLevel()
 if c:IsSetCard(SET_RROOT) then return lv+(1<<16) end
 return lv
end
function s.xyzlevel(e,c,rc)
 return s.materiallevel(e,rc)
end
function s.setfilter(c)
 return (c:IsSetCard(SET_AFTERROOT) or c:IsCode(85698115)) and c:IsType(TYPE_TRAP) and c:IsSSetable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_DECK)
end
function s.setop(e,tp)
 if not Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
 local tc=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst()
 if tc and Duel.SSet(tp,tc)>0 then
  local act=Effect.CreateEffect(e:GetHandler())
  act:SetType(EFFECT_TYPE_SINGLE)
  act:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
  act:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
  act:SetReset(RESET_EVENT+RESETS_STANDARD)
  tc:RegisterEffect(act)
 end
end
function s.extratype(c)
 return c:IsType(TYPE_FUSION+TYPE_SYNCHRO+TYPE_XYZ+TYPE_LINK)
end
function s.fieldfilter(c,e)
 return s.extratype(c) and c:IsAbleToRemove() and c:IsCanBeEffectTarget(e)
end
function s.gravefilter(c,e,tp,fc)
 return s.extratype(c) and c:IsCanBeEffectTarget(e)
  and Duel.GetMZoneCount(1-tp,fc,1-tp)>0
  and c:IsCanBeSpecialSummoned(e,0,1-tp,false,false,POS_FACEUP,1-tp)
end
function s.pairfilter(c,e,tp)
 return s.fieldfilter(c,e)
  and Duel.IsExistingTarget(s.gravefilter,tp,0,LOCATION_GRAVE,1,nil,e,tp,c)
end
function s.swaptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return false end
 if chk==0 then return Duel.IsExistingTarget(s.pairfilter,tp,0,LOCATION_MZONE,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectTarget(tp,s.pairfilter,tp,0,LOCATION_MZONE,1,1,nil,e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local rg=Duel.SelectTarget(tp,s.gravefilter,tp,0,LOCATION_GRAVE,1,1,nil,e,tp,g:GetFirst())
 g:Merge(rg)
 g:KeepAlive()
 e:SetLabelObject(g)
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,g:Filter(Card.IsLocation,nil,LOCATION_MZONE),1,1-tp,LOCATION_MZONE)
end
function s.swapop(e,tp)
 local kept=e:GetLabelObject()
 if not kept then return end
 e:SetLabelObject(nil)
 local g=kept:Filter(Card.IsRelateToEffect,nil,e)
 kept:DeleteGroup()
 local fc=g:Filter(Card.IsLocation,nil,LOCATION_MZONE):GetFirst()
 local tc=g:Filter(Card.IsLocation,nil,LOCATION_GRAVE):GetFirst()
 if not fc or Duel.Remove(fc,POS_FACEUP,REASON_EFFECT)==0 or not fc:IsLocation(LOCATION_REMOVED) then return end
 local opp=1-tp
 if not tc or Duel.GetLocationCount(opp,LOCATION_MZONE)<=0
  or not tc:IsCanBeSpecialSummoned(e,0,opp,false,false,POS_FACEUP,opp)
  or not Duel.SelectYesNo(opp,aux.Stringid(MSG_ID,3)) then return end
 if Duel.SpecialSummon(tc,0,opp,opp,false,false,POS_FACEUP)>0 then
  local neg=Effect.CreateEffect(e:GetHandler())
  neg:SetType(EFFECT_TYPE_SINGLE)
  neg:SetCode(EFFECT_DISABLE)
  neg:SetReset(RESET_EVENT+RESETS_STANDARD)
  tc:RegisterEffect(neg)
  local neg2=neg:Clone()
  neg2:SetCode(EFFECT_DISABLE_EFFECT)
  tc:RegisterEffect(neg2)
 end
end
function s.battlemonster(c,tp)
 local a,d=Duel.GetAttacker(),Duel.GetAttackTarget()
 local other=a==c and d or d==c and a or nil
 if other and other:IsControler(1-tp) then return other end
end
function s.batcon(e,tp)
 return Duel.IsBattlePhase() and s.battlemonster(e:GetHandler(),tp)~=nil
end
function s.revivefilter(c,e,tp,oldcode)
 return not c:IsCode(oldcode) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE,1-tp)
end
function s.battg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 local tc=s.battlemonster(e:GetHandler(),tp)
 if chkc then return chkc==tc and tc:IsCanBeEffectTarget(e) and tc:IsAbleToGrave() end
 if chk==0 then return tc and tc:IsCanBeEffectTarget(e) and tc:IsAbleToGrave()
  and Duel.IsExistingMatchingCard(s.revivefilter,1-tp,LOCATION_GRAVE,0,1,nil,e,tp,tc:GetCode()) end
 Duel.SetTargetCard(tc)
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,tc,1,1-tp,LOCATION_MZONE)
end
function s.batop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) then return end
 local oldcode=tc:GetCode()
 if Duel.SendtoGrave(tc,REASON_EFFECT)==0 then return end
 local opp=1-tp
 if Duel.GetLocationCount(opp,LOCATION_MZONE)<=0
  or not Duel.IsExistingMatchingCard(s.revivefilter,opp,LOCATION_GRAVE,0,1,nil,e,tp,oldcode) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local sc=Duel.SelectMatchingCard(tp,s.revivefilter,opp,LOCATION_GRAVE,0,1,1,nil,e,tp,oldcode):GetFirst()
 if sc then Duel.SpecialSummon(sc,0,tp,opp,false,false,POS_FACEUP_DEFENSE) end
end
