--Mevalkagna, Eye of Zenith
--Omega references: c100211050 (constrained target subgroup), c18969888 (must attack), c35167375 (race/attribute effects).
local s,id=GetID()
local MSG_ID=132165675
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.sptg)
 e1:SetOperation(s.spop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_ATKCHANGE+CATEGORY_CONTROL)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_FREE_CHAIN)
 e2:SetRange(LOCATION_MZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.ctcon)
 e2:SetTarget(s.cttg)
 e2:SetOperation(s.ctop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_DESTROY)
 e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F)
 e3:SetCode(EVENT_PHASE+PHASE_END)
 e3:SetRange(LOCATION_MZONE)
 e3:SetCountLimit(1,id+200)
 e3:SetCondition(s.descon)
 e3:SetTarget(s.destg)
 e3:SetOperation(s.desop)
 c:RegisterEffect(e3)
end
function s.rmfilter(c)
 return c:IsType(TYPE_MONSTER) and c:IsAbleToRemove()
end
function s.unique(g)
 local seen={}
 for c in aux.Next(g) do
  local key=c:GetRace()..":"..c:GetAttribute()
  if seen[key] then return false end
  seen[key]=true
 end
 return true
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 local c=e:GetHandler()
 local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.rmfilter),tp,LOCATION_GRAVE,LOCATION_GRAVE,nil)
 if chkc then return chkc:IsLocation(LOCATION_GRAVE) and g:IsContains(chkc) end
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false) and g:CheckSubGroup(s.unique,3,3) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local sg=g:SelectSubGroup(tp,s.unique,false,3,3)
 Duel.SetTargetCard(sg)
 sg:KeepAlive()
 e:SetLabelObject(sg)
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,sg,3,0,0)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_HAND)
end
function s.spop(e,tp)
 local c=e:GetHandler()
 local targets=e:GetLabelObject()
 if not targets then return end
 local g=targets:Filter(Card.IsRelateToEffect,nil,e)
 targets:DeleteGroup()
 if #g~=3 or not s.unique(g) then return end
 local ct=Duel.Remove(g,POS_FACEUP,REASON_EFFECT)
 if ct~=3 or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or not c:IsRelateToEffect(e) or not c:IsCanBeSpecialSummoned(e,0,tp,false,false) then return end
 local rg=g:Filter(Card.IsLocation,nil,LOCATION_REMOVED)
 if #rg~=3 then return end
 local race,attribute=0,0
 for tc in aux.Next(rg) do
  race=bit.bor(race,tc:GetRace())
  attribute=bit.bor(attribute,tc:GetAttribute())
 end
 if Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local er=Effect.CreateEffect(c)
 er:SetType(EFFECT_TYPE_SINGLE)
 er:SetCode(EFFECT_ADD_RACE)
 er:SetValue(race)
 er:SetReset(RESET_EVENT+RESETS_STANDARD)
 c:RegisterEffect(er)
 local ea=er:Clone()
 ea:SetCode(EFFECT_ADD_ATTRIBUTE)
 ea:SetValue(attribute)
 c:RegisterEffect(ea)
end
function s.ctcon(e,tp)
 local ph=Duel.GetCurrentPhase()
 return Duel.GetTurnPlayer()==tp and (ph==PHASE_MAIN1 or ph==PHASE_MAIN2 or ph==PHASE_BATTLE)
end
function s.ctfilter(tc,c)
 return tc:IsFaceup() and tc:IsControlerCanBeChanged()
  and (tc:IsRace(c:GetRace()) or tc:IsAttribute(c:GetAttribute()))
end
function s.cttg(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:IsFaceup() and c:GetAttack()>=1000
  and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(s.ctfilter,tp,0,LOCATION_MZONE,1,nil,c) end
 Duel.SetOperationInfo(0,CATEGORY_CONTROL,nil,1,1-tp,LOCATION_MZONE)
end
function s.ctop(e,tp)
 local c=e:GetHandler()
 if not c:IsFaceup() or c:GetAttack()<1000 or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
 local atk=c:GetAttack()
 local ea=Effect.CreateEffect(c)
 ea:SetType(EFFECT_TYPE_SINGLE)
 ea:SetCode(EFFECT_UPDATE_ATTACK)
 ea:SetValue(-1000)
 ea:SetReset(RESET_EVENT+RESETS_STANDARD)
 c:RegisterEffect(ea)
 if c:GetAttack()~=atk-1000 or not Duel.IsExistingMatchingCard(s.ctfilter,tp,0,LOCATION_MZONE,1,nil,c) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONTROL)
 local g=Duel.SelectMatchingCard(tp,s.ctfilter,tp,0,LOCATION_MZONE,1,1,nil,c)
 local tc=g:GetFirst()
 if not tc or Duel.GetControl(tc,tp)==0 then return end
 local must=Effect.CreateEffect(c)
 must:SetType(EFFECT_TYPE_FIELD)
 must:SetCode(EFFECT_MUST_ATTACK)
 must:SetRange(LOCATION_MZONE)
 must:SetTargetRange(LOCATION_MZONE,0)
 must:SetTarget(function(e,mc) return mc==e:GetHandler() end)
 must:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
 tc:RegisterEffect(must)
end
function s.battledfilter(c)
 return c:IsType(TYPE_MONSTER) and c:GetBattledGroupCount()>0
end
function s.descon(e,tp)
 return Duel.IsExistingMatchingCard(s.battledfilter,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil)
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 local g=Duel.GetMatchingGroup(s.battledfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,#g,0,0)
end
function s.desop(e,tp)
 local g=Duel.GetMatchingGroup(s.battledfilter,tp,LOCATION_MZONE,LOCATION_MZONE,nil)
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end
