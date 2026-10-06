--Moltenzoic Tristegsaurus
local s,id=GetID()
local MSG_ID=132162598
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_DINOSAUR),aux.NonTuner(nil),1,1)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.destg)
 e1:SetOperation(s.desop)
 c:RegisterEffect(e1)
 local e2=e1:Clone()
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetRange(LOCATION_MZONE)
 e2:SetCode(EVENT_DESTROYED)
 e2:SetCondition(function() return bit.band(Duel.GetCurrentPhase(),PHASE_BATTLE_START+PHASE_BATTLE_STEP+PHASE_DAMAGE+PHASE_DAMAGE_CAL+PHASE_BATTLE)~=0 end)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetCode(EVENT_DESTROYED)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCountLimit(1,id+100)
 e3:SetTarget(s.delaytg)
 e3:SetOperation(s.delayop)
 c:RegisterEffect(e3)
end
function s.ownfilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_ONFIELD) and chkc:IsDestructable()
  and (chkc:IsControler(1-tp) or (chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and chkc:IsType(TYPE_MONSTER))) end
 if chk==0 then return Duel.IsExistingTarget(s.ownfilter,tp,LOCATION_MZONE,0,1,nil)
  and Duel.IsExistingTarget(Card.IsDestructable,tp,0,LOCATION_ONFIELD,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectTarget(tp,s.ownfilter,tp,LOCATION_MZONE,0,1,1,nil)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 g:Merge(Duel.SelectTarget(tp,Card.IsDestructable,tp,0,LOCATION_ONFIELD,1,1,nil))
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,2,0,0)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,PLAYER_ALL,LOCATION_GRAVE)
end
function s.spfilter(c,e,tp,p)
 return c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,p)
end
function s.desop(e,tp)
 local tg=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
 local g=tg:Filter(Card.IsRelateToEffect,nil,e)
 if #g==0 or Duel.Destroy(g,REASON_EFFECT)==0 then return end
 local sg=Group.CreateGroup()
 for p=0,1 do
  if Duel.GetLocationCount(p,LOCATION_MZONE)>0 then
   Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
   local sc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),p,LOCATION_GRAVE,0,1,1,nil,e,tp,p):GetFirst()
   if sc then sg:AddCard(sc) end
  end
 end
 for sc in aux.Next(sg) do Duel.SpecialSummonStep(sc,0,tp,sc:GetOwner(),false,false,POS_FACEUP) end
 Duel.SpecialSummonComplete()
end
function s.delaytg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return e:GetHandler():IsLocation(LOCATION_GRAVE) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_GRAVE)
end
function s.delayop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsLocation(LOCATION_GRAVE) then return end
 local fid=c:GetFieldID()
 c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD,0,1,fid)
 local ge=Effect.CreateEffect(c)
 ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 ge:SetCode(EVENT_PHASE+PHASE_BATTLE_START)
 ge:SetCountLimit(1)
 ge:SetLabel(fid)
 ge:SetLabelObject(c)
 ge:SetCondition(function(e) local tc=e:GetLabelObject() return tc:IsLocation(LOCATION_GRAVE) and tc:GetFlagEffectLabel(id)==e:GetLabel() end)
 ge:SetOperation(function(e,tp) local tc=e:GetLabelObject() if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end end)
 ge:SetReset(RESET_PHASE+PHASE_BATTLE_START)
 Duel.RegisterEffect(ge,tp)
end
