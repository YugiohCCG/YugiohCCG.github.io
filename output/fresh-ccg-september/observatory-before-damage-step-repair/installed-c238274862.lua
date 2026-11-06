--Vylon Observatory
--Omega references: c17315396 (turn-wide Summon oath), c14507213 (extra Synchro material), c75886890 (equip from GY).
local s,id=GetID()
local SET_VYLON=0x30
local MSG_ID=132274862
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.counterfilter)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetTarget(s.acttg)
 e1:SetOperation(s.actop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_EQUIP)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e2:SetCode(EVENT_DESTROYED)
 e2:SetRange(LOCATION_FZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.eqcon)
 e2:SetTarget(s.eqtg)
 e2:SetOperation(s.eqop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetType(EFFECT_TYPE_FIELD)
 e3:SetCode(EFFECT_EXTRA_SYNCHRO_MATERIAL)
 e3:SetRange(LOCATION_FZONE)
 e3:SetTargetRange(LOCATION_SZONE,0)
 e3:SetTarget(s.mattarget)
 e3:SetValue(s.matvalue)
 c:RegisterEffect(e3)
end
function s.counterfilter(c)
 return c:IsAttribute(ATTRIBUTE_LIGHT)
end
function s.splimit(e,c)
 return not c:IsAttribute(ATTRIBUTE_LIGHT)
end
function s.tunerfilter(c,e,tp)
 return c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER) and c:IsType(TYPE_TUNER)
  and c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 e:SetLabel(0)
 if Duel.GetFlagEffect(tp,id)>0 or Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)~=0
  or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or not Duel.IsExistingMatchingCard(s.tunerfilter,tp,LOCATION_DECK,0,1,nil,e,tp)
  or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then return end
 e:SetLabel(1)
 Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
 local lock=Effect.CreateEffect(e:GetHandler())
 lock:SetType(EFFECT_TYPE_FIELD)
 lock:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON)
 lock:SetProperty(EFFECT_FLAG_PLAYER_TARGET+EFFECT_FLAG_OATH)
 lock:SetTargetRange(1,0)
 lock:SetTarget(s.splimit)
 lock:SetReset(RESET_PHASE+PHASE_END)
 Duel.RegisterEffect(lock,tp)
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.actop(e,tp)
 if e:GetLabel()~=1 or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or not Duel.IsExistingMatchingCard(s.tunerfilter,tp,LOCATION_DECK,0,1,nil,e,tp)
  then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.tunerfilter,tp,LOCATION_DECK,0,1,1,nil,e,tp)
 if #g>0 then Duel.SpecialSummon(g:GetFirst(),0,tp,tp,false,false,POS_FACEUP) end
end
function s.destroyed(c)
 return c:IsPreviousLocation(LOCATION_ONFIELD) and c:IsPreviousPosition(POS_FACEUP)
  and (c:GetPreviousTypeOnField()&(TYPE_SPELL+TYPE_TRAP))~=0
end
function s.eqcon(e,tp,eg)
 return eg:IsExists(s.destroyed,1,nil)
end
function s.monfilter(c)
 return c:IsFaceup() and c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER)
end
function s.canEquipTo(tc,ec)
 return tc:IsFaceup() and tc:IsSetCard(SET_VYLON)
  and (not ec:IsType(TYPE_EQUIP) or ec:CheckEquipTarget(tc))
  and (not ec:IsType(TYPE_UNION) or (ec:CheckUnionTarget(tc) and aux.CheckUnionEquip(ec,tc)))
end
function s.eqfilter(c,tp)
 if not ((c:IsType(TYPE_EQUIP) and c:IsType(TYPE_SPELL))
  or (c:IsSetCard(SET_VYLON) and c:IsType(TYPE_MONSTER))) then return false end
 return Duel.IsExistingMatchingCard(s.canEquipTo,tp,LOCATION_MZONE,0,1,nil,c)
end
function s.eqtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_GRAVE) and chkc:IsControler(tp) and s.eqfilter(chkc,tp) end
 local count=eg:FilterCount(s.destroyed,nil)
 local slots=Duel.GetLocationCount(tp,LOCATION_SZONE)
 local limit=math.min(count,slots)
 if chk==0 then return limit>0
  and Duel.IsExistingMatchingCard(s.monfilter,tp,LOCATION_MZONE,0,1,nil)
  and Duel.IsExistingTarget(aux.NecroValleyFilter(s.eqfilter),tp,LOCATION_GRAVE,0,1,nil,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
 local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.eqfilter),tp,LOCATION_GRAVE,0,1,limit,nil,tp)
 Duel.SetOperationInfo(0,CATEGORY_EQUIP,g,#g,0,0)
end
function s.eqop(e,tp)
 local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)
 if not g then return end
 g=g:Filter(Card.IsRelateToEffect,nil,e):Filter(aux.NecroValleyFilter(s.eqfilter),nil,tp)
 for ec in aux.Next(g) do
  if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then break end
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
  local tg=Duel.SelectMatchingCard(tp,s.canEquipTo,tp,LOCATION_MZONE,0,1,1,nil,ec)
  local tc=tg:GetFirst()
  if tc and Duel.Equip(tp,ec,tc) then
   if ec:IsType(TYPE_UNION) then aux.SetUnionState(ec)
   else
    local limit=Effect.CreateEffect(ec)
    limit:SetType(EFFECT_TYPE_SINGLE)
    limit:SetCode(EFFECT_EQUIP_LIMIT)
    limit:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
    limit:SetLabelObject(tc)
    limit:SetValue(function(e,mc) return mc==e:GetLabelObject() end)
    limit:SetReset(RESET_EVENT+RESETS_STANDARD)
    ec:RegisterEffect(limit)
   end
  end
 end
end
function s.mattarget(e,c)
 return c:IsType(TYPE_MONSTER)
end
function s.matvalue(e,sc)
 return sc:IsSetCard(SET_VYLON) and sc:IsType(TYPE_SYNCHRO)
end
