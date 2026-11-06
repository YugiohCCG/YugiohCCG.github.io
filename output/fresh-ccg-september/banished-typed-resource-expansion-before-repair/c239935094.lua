--Winged Snake of the Swamp
local s,id=GetID()
local SWAMP=239935101
local MSG_ID=133935094
function s.initial_effect(c)
 aux.AddCodeList(c,SWAMP)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,0))
 e2:SetCategory(CATEGORY_REMOVE)
 e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.destg)
 e2:SetOperation(s.desop)
 c:RegisterEffect(e2)
 local en=e2:Clone()
 en:SetCode(EVENT_SUMMON_SUCCESS)
 c:RegisterEffect(en)
 local e3=e2:Clone()
 e3:SetCode(EVENT_TO_GRAVE)
 e3:SetCondition(s.sendcon)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,1))
 e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e4:SetProperty(EFFECT_FLAG_DELAY)
 e4:SetCode(EVENT_REMOVE)
 e4:SetCountLimit(1,id+200)
 e4:SetCondition(s.fusioncon)
 e4:SetTarget(s.settg)
 e4:SetOperation(s.setop)
 c:RegisterEffect(e4)
end
s.listed_names={SWAMP}
function s.sendcon(e,tp,eg,ep,ev,re,r,rp)
 if not re then return false end
 local rc=re:GetHandler()
 --Pinned roster fallback supports mentioned cards whose scripts are not authored yet.
 local mentions=aux.IsCodeListed(rc,SWAMP) or rc:IsCode(239935093,239935094,239935095,239935096,239935097,239935099,239935100,239935101,239935102)
 return mentions
end
function s.desfilter(c)
 return c:IsAbleToRemove()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_GRAVE) and s.desfilter(chkc) end
 if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.desfilter),tp,0,LOCATION_GRAVE,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.desfilter),tp,0,LOCATION_GRAVE,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,0,0)
 if Duel.IsExistingMatchingCard(s.swampfilter,tp,LOCATION_ONFIELD+LOCATION_GRAVE,0,1,nil) then
  local tc=g:GetFirst()
  Duel.SetChainLimit(function(re,rp,tp) return rp==tp or re:GetHandler()~=tc end)
 end
end
function s.swampfilter(c)
 return c:IsCode(SWAMP) and (c:IsLocation(LOCATION_GRAVE) or c:IsFaceup())
end
function s.desop(e,tp)
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) then Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end
end

function s.fusioncon(e)
 local c=e:GetHandler()
 local rc=c:GetReasonCard()
 return c:IsReason(REASON_MATERIAL) and c:IsReason(REASON_FUSION) and rc
  and rc:IsType(TYPE_FUSION) and rc:IsRace(RACE_REPTILE) and rc:IsAttribute(ATTRIBUTE_WATER)
end
function s.setfilter(c,tp)
 --These are the Dark Swamp Spell/Traps in the pinned website roster.
 return c:IsCode(239935099,239935100,239935101,239935102) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsSSetable()
  and (c:IsType(TYPE_FIELD) or Duel.GetLocationCount(tp,LOCATION_SZONE)>0)
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK+LOCATION_REMOVED,0,1,nil,tp) end
end
function s.setop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
 local g=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK+LOCATION_REMOVED,0,1,1,nil,tp)
 if #g>0 then Duel.SSet(tp,g) end
end
