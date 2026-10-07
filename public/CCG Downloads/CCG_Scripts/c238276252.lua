--Prayer Of Nephthys
local s,id=GetID()
local SET_NEPHTHYS=0x11f
local MSG_ID=132276252
local CARD_PHOENIX_WING_WIND_BLAST=63356631
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_DESTROYED)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_DAMAGE_STEP)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.thcon)
 e2:SetCost(aux.bfgcost)
 e2:SetTarget(s.thtg)
 e2:SetOperation(s.thop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_NEPHTHYS}
s.listed_names={CARD_PHOENIX_WING_WIND_BLAST}
function s.desfilter(c)
 return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:IsLevel(8) and c:IsDestructable()
end
function s.deslegal(c,tp)
 return s.desfilter(c) and Duel.GetMZoneCount(tp,c)>1
end
function s.spfilter(c,e,tp)
 return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:IsLevel(2)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return not Duel.IsPlayerAffectedByEffect(tp,59822133)
  and Duel.IsExistingMatchingCard(s.deslegal,tp,LOCATION_HAND+LOCATION_MZONE,0,1,nil,tp)
  and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,2,nil,e,tp) end
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_HAND+LOCATION_MZONE)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.spop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local dc=Duel.SelectMatchingCard(tp,s.desfilter,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,nil,tp):GetFirst()
 if not dc or Duel.Destroy(dc,REASON_EFFECT)==0 then return end
 if Duel.IsPlayerAffectedByEffect(tp,59822133) or Duel.GetLocationCount(tp,LOCATION_MZONE)<2
  or not Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,2,nil,e,tp) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spfilter),tp,LOCATION_HAND+LOCATION_GRAVE,0,2,2,nil,e,tp)
 local sg=Group.CreateGroup()
 local c=e:GetHandler()
 local fid=c:GetFieldID()
 for tc in aux.Next(g) do
  if Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP) then
   sg:AddCard(tc)
   local e1=Effect.CreateEffect(c)
   e1:SetType(EFFECT_TYPE_SINGLE)
   e1:SetCode(EFFECT_DISABLE)
   e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
   e1:SetReset(RESET_EVENT+RESETS_STANDARD)
   tc:RegisterEffect(e1,true)
   local e2=e1:Clone()
   e2:SetCode(EFFECT_DISABLE_EFFECT)
   tc:RegisterEffect(e2,true)
   tc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD,0,1,fid)
  end
 end
 Duel.SpecialSummonComplete()
 if #sg==0 then return end
 sg:KeepAlive()
 local de=Effect.CreateEffect(c)
 de:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 de:SetCode(EVENT_PHASE+PHASE_END)
 de:SetCountLimit(1)
 de:SetLabel(fid)
 de:SetLabelObject(sg)
 de:SetOperation(s.endop)
 de:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(de,tp)
end
function s.endop(e,tp)
 local g=e:GetLabelObject()
 local dg=g:Filter(function(c) return c:GetFlagEffectLabel(id)==e:GetLabel() end,nil)
 if #dg>0 then Duel.Destroy(dg,REASON_EFFECT) end
 g:DeleteGroup()
end
function s.ritualdestroyed(c)
 return c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_MONSTER) and c:IsType(TYPE_RITUAL)
end
function s.thcon(e,tp,eg)
 return not eg:IsContains(e:GetHandler()) and eg:IsExists(s.ritualdestroyed,1,nil)
end
function s.thfilter(c)
 return not c:IsCode(id) and c:IsAbleToHand() and (not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())
  and ((c:IsSetCard(SET_NEPHTHYS) and c:IsType(TYPE_SPELL+TYPE_TRAP)) or c:IsCode(CARD_PHOENIX_WING_WIND_BLAST))
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED)
end
function s.thop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil)
 if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end
end
