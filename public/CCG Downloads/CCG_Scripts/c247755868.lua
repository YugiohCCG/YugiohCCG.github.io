--Kali Yuga - Karkotaka
local s,id=GetID()
local SET_KALI_YUGA=0xa121
local MSG_ID=133755868
function s.initial_effect(c)
 if not s.global_check then
  s.global_check=true
  local ge=Effect.CreateEffect(c)
  ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
  ge:SetCode(EVENT_DESTROYED)
  ge:SetOperation(s.record)
  Duel.RegisterEffect(ge,0)
 end
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_HAND+LOCATION_GRAVE)
 e1:SetCountLimit(1,id)
 e1:SetCondition(function(e,tp) return Duel.GetFlagEffect(tp,id)>0 end)
 e1:SetTarget(s.sstg)
 e1:SetOperation(s.ssop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_MZONE)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.lvtg)
 e2:SetOperation(s.lvop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_KALI_YUGA}
function s.recordfilter(c)
 local monster=c:IsType(TYPE_MONSTER)
 local kali=c:IsSetCard(SET_KALI_YUGA)
 if c:IsPreviousLocation(LOCATION_ONFIELD) then
  monster=bit.band(c:GetPreviousTypeOnField(),TYPE_MONSTER)~=0
  kali=c:IsPreviousSetCard(SET_KALI_YUGA)
 end
 return monster and kali
  and (c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT))
end
function s.record(e,tp,eg)
 if eg:IsExists(s.recordfilter,1,nil) then
  for player=0,1 do Duel.RegisterFlagEffect(player,id,RESET_PHASE+PHASE_END,0,1) end
 end
end
function s.sstg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0)
end
function s.ssop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or Duel.GetLocationCount(tp,LOCATION_MZONE)<=0
  or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_SINGLE)
 e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
 e1:SetValue(LOCATION_REMOVED)
 e1:SetReset(RESET_EVENT+RESETS_REDIRECT)
 c:RegisterEffect(e1,true)
end
function s.lvfilter(c)
 return c:IsFaceup() and c:IsSetCard(SET_KALI_YUGA) and c:IsType(TYPE_MONSTER) and c:GetLevel()>0
end
function s.lvtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.lvfilter(chkc) end
 if chk==0 then return Duel.IsExistingTarget(s.lvfilter,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
 Duel.SelectTarget(tp,s.lvfilter,tp,LOCATION_MZONE,0,1,1,nil)
 e:SetLabel(Duel.AnnounceLevel(tp,4,8))
end
function s.matlimit(e,c)
 return c and not c:IsSetCard(SET_KALI_YUGA)
end
function s.lvop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) or not tc:IsFaceup() or tc:GetLevel()<=0 then return end
 local change=Effect.CreateEffect(e:GetHandler())
 change:SetType(EFFECT_TYPE_SINGLE)
 change:SetCode(EFFECT_CHANGE_LEVEL)
 change:SetValue(e:GetLabel())
 change:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
 if not tc:RegisterEffect(change) then return end
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) then return end
 for _,code in ipairs({EFFECT_CANNOT_BE_FUSION_MATERIAL,EFFECT_CANNOT_BE_SYNCHRO_MATERIAL,EFFECT_CANNOT_BE_XYZ_MATERIAL,EFFECT_CANNOT_BE_LINK_MATERIAL}) do
  local limit=Effect.CreateEffect(c)
  limit:SetType(EFFECT_TYPE_SINGLE)
  limit:SetCode(code)
  limit:SetValue(s.matlimit)
  limit:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
  c:RegisterEffect(limit)
 end
end
